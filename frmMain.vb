Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports newPT
Imports System.Xml

Public Class frmMain
    Friend prs As Parser
    Private CodeTabs As New Dictionary(Of TabPage, CodeDocument)()
    Private cur_tbs As Integer = -1, hParam As Integer
    Private gmn As Integer, fsn As Integer, etcn As Integer
    Private cur_cd As CodeDocument
    Private func As New Functions()
    Private cfs As c_function

    Const FILE_NEW_GM As Integer = 1
    Const FILE_NEW_FS As Integer = 2
    Const FILE_NEW As Integer = 3
    Const FILE_OPEN As Integer = 4

    Private Sub LoadPrerequisites()

        prs = New Parser()
        Dim il As New ImageList()
        il.Images.Add(My.Resources.VSProject_genericfile)
        il.Images.Add(My.Resources.VSObject_Method)
        il.Images.Add(My.Resources.VSObject_Constant)
        il.Images.Add(My.Resources.VSObject_Field)
        treeIncludes.ImageList = il
        treeCurrFile.ImageList = il
        il = New ImageList()
        il.Images.Add(My.Resources._Error)
        il.Images.Add(My.Resources.Warning)
        lstErrors.SmallImageList = il
        FindIncludeFunc()
    End Sub

    Private Sub FindIncludeFunc()
        Dim includesDir As New DirectoryInfo(Application.StartupPath + "\include")
        If includesDir.Exists = False Then
            Try
                includesDir.Create()
            Catch generatedExceptionName As IOException
                MessageBox.Show("Please create an 'include' folder in " & includesDir.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End If
        prs.incarry = New c_FileFnc(includesDir.GetFiles("*.inc").Length - 1) {}

        For Each include As FileInfo In includesDir.GetFiles("*.inc")
            Dim sr As New StreamReader(include.FullName)
            prs.CodeParser(include.Name, sr.ReadToEnd(), True, My.Settings.fd)
        Next
        treeIncludes.Nodes.Clear()

        For Each fifnc As c_FileFnc In prs.incarry
            Dim tnca As TreeNode() = New TreeNode(fifnc.functions.Count + (fifnc.constants.Count - 1)) {}
            Dim b As Integer = 0, c As Integer = 0
            For Each cfs As c_function In fifnc.constants.Values
                tnca(b) = New TreeNode(cfs.fName)
                tnca(b).ImageIndex = 2
                tnca(b).SelectedImageIndex = 2
                b += 1
            Next

            For Each cfs As c_function In fifnc.functions.Values
                func.AddFunction(cfs.fName)
                tnca(fifnc.constants.Count + c) = New TreeNode(cfs.fName)
                tnca(fifnc.constants.Count + c).ImageIndex = 1
                tnca(fifnc.constants.Count + c).SelectedImageIndex = 1
                c += 1
            Next
            Array.Sort(tnca, Function(tn1 As TreeNode, tn2 As TreeNode) tn1.Text.CompareTo(tn2.Text))
            Dim tn As New TreeNode(fifnc.FileName, tnca)
            tn.ImageIndex = 0
            treeIncludes.Nodes.Add(tn)
        Next
    End Sub

    Private Sub FindLocalFunc(ByVal cd As String, ByVal refresh As Boolean)
        If cur_cd.lv Is Nothing OrElse refresh = True Then
            prs.CodeParser("null", cd, False, My.Settings.fd)
            cur_cd.lv = prs.curFile
        Else
            prs.curFile = cur_cd.lv
        End If

        treeCurrFile.Nodes.Clear()

        For Each fnc As c_function In cur_cd.lv.functions.Values
            Dim tn As New TreeNode(fnc.fName)
            tn.ImageIndex = 1
            tn.SelectedImageIndex = 1
            treeCurrFile.Nodes.Add(tn)
        Next

        For Each fnc As c_function In cur_cd.lv.constants.Values
            Dim tn As New TreeNode(fnc.fName)
            tn.ImageIndex = 2
            tn.SelectedImageIndex = 2
            treeCurrFile.Nodes.Add(tn)
        Next

        For Each fnc As c_function In cur_cd.lv.variables.Values
            Dim tn As New TreeNode(fnc.fName)
            tn.ImageIndex = 3
            tn.SelectedImageIndex = 3
            treeCurrFile.Nodes.Add(tn)
        Next
        treeCurrFile.Sort()
    End Sub

    ''' <summary>
    ''' Creates a new code tab window thingy.
    ''' </summary>
    ''' <param name="type">Either "new" or "open", no excuses</param>
    ''' <param name="FileName">The safe file name or null, if new</param>
    ''' <param name="FilePath">The FilePath or null, if new</param>
    Private Sub NewScintillaInstance(ByVal type As String, ByVal FileName As String, ByVal FilePath As String)
        Dim tb As TabPage = New TabPage(FileName)
        Dim pgsc As New ScintillaNet.Scintilla()

        Select Case type
            Case 1 'NEW_GM
                pgsc = func.InitSC(My.Resources.newPWN)
            Case 2 'NEW_FS
                pgsc = func.InitSC(My.Resources.newFS)
            Case 3 'NEW
                pgsc = func.InitSC(Nothing)
            Case 4 'OPEN
                Dim sr As New StreamReader(FilePath)
                pgsc = func.InitSC(sr.ReadToEnd())
                sr.Close()
            Case Else 'Something went wrong. Be safe, open just a new tab and display and error message
                pgsc = func.InitSC(Nothing)
                MsgBox("It appears that something went wrong! Contact the program's autor.", MsgBoxStyle.Exclamation)
        End Select

        AddHandler pgsc.TextChanged, AddressOf pgsc_TextChanged
        AddHandler pgsc.CharAdded, AddressOf pgsc_CharAdded
        AddHandler pgsc.TextDeleted, AddressOf pgsc_TextDeleted
        AddHandler pgsc.SelectionChanged, AddressOf pgsc_SelectionChanged
        AddHandler pgsc.KeyUp, AddressOf pgsc_KeyUp

        tb.Controls.Add(pgsc)
        tabcontrolOpenFiles.TabPages.Add(tb)

        cur_cd = New CodeDocument(pgsc, FileName, FilePath)
        CodeTabs.Add(tabcontrolOpenFiles.TabPages(tabcontrolOpenFiles.TabPages.Count - 1), cur_cd)
        tabcontrolOpenFiles.SelectedIndex = tabcontrolOpenFiles.TabPages.Count - 1
    End Sub

    Private Sub DestroyScintillaInstance(ByVal inst As TabPage)
        CodeTabs.Remove(inst)
        If tabcontrolOpenFiles.TabPages.Count = 1 Then
            NewScintillaInstance("new", "New Blank File", Nothing)
        End If

        tabcontrolOpenFiles.TabPages.Remove(inst)
    End Sub

    Private Sub SaveScintillaDoc(ByVal cd As CodeDocument, ByVal inst As Integer, ByVal FileName As String, ByVal FilePath As String)
        Try
            Dim sw As New StreamWriter(FilePath)
            With sw
                .Write(cd.[Interface].Text)
                .Flush()
                .Close()
            End With
        Catch ex As IOException
            MessageBox.Show("I/O Error! " + ex.Message)
        End Try
        If cd.FilePath Is Nothing Then
            cd.FileName = FileName
            cd.FilePath = FilePath
        End If

        If inst <> -1 Then
            tabcontrolOpenFiles.TabPages(inst).Text = FileName
        Else
            tabcontrolOpenFiles.SelectedTab.Text = FileName
        End If
        cd.IsEdited = False
    End Sub

    Private Sub DiscChanger()
        If cur_cd.[Interface].UndoRedo.CanUndo = False Then
            toolstripUndo.Enabled = False
            'undoToolStripMenuItem.Enabled = False
        Else
            toolstripUndo.Enabled = True
            'undoToolStripMenuItem.Enabled = True
        End If
        If cur_cd.[Interface].UndoRedo.CanRedo = True Then
            toolstripRedo.Enabled = True
            'redoToolStripMenuItem.Enabled = True
        Else
            toolstripRedo.Enabled = False
            'redoToolStripMenuItem.Enabled = False
        End If

        If cur_cd.IsEdited = False Then
            'save_tbcm.Enabled = False
            toolstripSave.Enabled = False
            'saveToolStripMenuItem.Enabled = False
        Else
            'save_tbcm.Enabled = True
            toolstripSave.Enabled = True
            'saveToolStripMenuItem.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Parses errors from PAWN and keeps it
    ''' </summary>
    ''' <param name="errq">The error, in its full glory</param>
    Private Sub DispErr(ByVal errq As String)
        For Each erl As [Error] In cur_cd.Errors.Values
            cur_cd.[Interface].Lines(erl.Line - 1).Range.ClearIndicator(0)
        Next
        cur_cd.Errors.Clear()
        Dim terr As String = If((errq.IndexOf("Compilation") <> -1), errq.Remove(errq.IndexOf("Compilation")), errq)
        terr = terr.Trim()
        Dim errors As String() = terr.Split(ControlChars.Lf)
        For Each [error] As String In errors
            Dim err_elems As [Error] = newPT.ErrorParser.ParseCompilerError([error])
            cur_cd.Errors.Add(LoadErrorsIntoList(err_elems), err_elems)
        Next
    End Sub


    Public Function LoadErrorsIntoList(ByVal err As [Error]) As ListViewItem
        Dim lvsi_err As ListViewItem.ListViewSubItem() = New ListViewItem.ListViewSubItem(4) {}
        lvsi_err(0) = New ListViewItem.ListViewSubItem()
        Dim ii As Integer = CInt(err.Type)
        lvsi_err(0).Text = ii.ToString()
        For i As Integer = 1 To lvsi_err.Length - 1
            lvsi_err(i) = New ListViewItem.ListViewSubItem()
        Next
        lvsi_err(1).Text = err.ID.ToString()
        lvsi_err(2).Text = err.Description
        lvsi_err(3).Text = cur_cd.FileName
        lvsi_err(4).Text = err.Line.ToString()
        cur_cd.[Interface].Lines(err.Line - 1).Range.SetIndicator(0)
        Dim lvi_err As New ListViewItem(lvsi_err, CInt(err.Type))
        lstErrors.Items.Add(lvi_err)
        Return lvi_err
    End Function

    Private Sub pgsc_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'If cur_cd.Initial = True Then
        '    cur_cd.Initial = False
        '    cur_cd.[Interface].UndoRedo.EmptyUndoBuffer()
        'ElseIf cur_cd.IsEdited = False Then
        '    cur_cd.IsEdited = True
        '    tabcontrolOpenFiles.SelectedTab.Text = cur_cd.FileName + "*"
        'End If
        DiscChanger()
    End Sub

    Private Sub pgsc_CharAdded(ByVal sender As Object, ByVal e As ScintillaNet.CharAddedEventArgs)
        Dim s_tmp As ScintillaNet.Scintilla = DirectCast(sender, ScintillaNet.Scintilla)
        Select Case e.Ch
            Case "("c
                Dim test As String = s_tmp.Lines.Current.Text.Trim()
                'test = test.Split(' ').Last<String>();
                test = test.TrimEnd("("c)
                cfs = prs.SearchForFunc(test)
                If cfs IsNot Nothing Then
                    hParam = 0
                    Dim PartA As String = cfs.fReturn + ":" + cfs.fName & "("
                    Dim PartB As String = String.Join(",", cfs.fParams) & ")"
                    s_tmp.CallTip.Message = PartA + PartB
                    s_tmp.CallTip.HighlightStart = PartA.Length
                    s_tmp.CallTip.HighlightEnd = PartA.Length + cfs.fParams(0).Length
                    s_tmp.CallTip.Show(PartA.Length, PartA.Length + cfs.fParams(0).Length)
                End If
                Exit Select

            Case ","c
                If s_tmp.CallTip.IsActive = True Then
                    If hParam >= cfs.fParams.Length - 1 Then
                        hParam += 1
                        s_tmp.CallTip.HighlightStart += 50
                        s_tmp.CallTip.HighlightEnd += 50
                        Exit Select
                    End If
                    s_tmp.CallTip.HighlightStart += cfs.fParams(hParam).Length + 1
                    hParam += 1
                    s_tmp.CallTip.HighlightEnd += cfs.fParams(hParam).Length + 1
                End If
                Exit Select

            Case ")"c
                If s_tmp.CallTip.IsActive = True Then
                    s_tmp.CallTip.Hide()
                End If
                Exit Select
        End Select
    End Sub

    Private Sub pgsc_TextDeleted(ByVal sender As Object, ByVal e As ScintillaNet.TextModifiedEventArgs)
        Dim s_tmp As ScintillaNet.Scintilla = DirectCast(sender, ScintillaNet.Scintilla)
        If e.Length = 1 Then
            If e.Text = "," AndAlso s_tmp.CallTip.IsActive = True Then
                If hParam = 0 Then
                    s_tmp.CallTip.Hide()
                    Return
                End If
                If hParam >= cfs.fParams.Length Then
                    hParam -= 1
                    s_tmp.CallTip.HighlightStart -= 50
                    s_tmp.CallTip.HighlightEnd -= 50
                    Return
                Else
                    hParam -= 1
                    s_tmp.CallTip.HighlightStart -= cfs.fParams(hParam).Length + 1
                    s_tmp.CallTip.HighlightEnd -= cfs.fParams(hParam + 1).Length + 1
                End If
            End If
        End If
    End Sub

    Private Sub pgsc_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        statusINS.Text = If((cur_cd.[Interface].OverType = True), "OVR", "INS")
    End Sub

    Private Sub pgsc_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        statusLine.Text = "Ln " & (cur_cd.[Interface].Lines.Current.VisibleLineNumber + 1)
        statusChr.Text = "Ch " & (cur_cd.[Interface].Selection.Start - cur_cd.[Interface].Lines.Current.StartPosition + 1)
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPrerequisites()
    End Sub

    Private Sub toolstripNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripNew.Click
        NewScintillaInstance("new_gm", "New Gamemode (" & gmn & ")", Nothing)
        gmn += 1
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim lstvw_wdth As Double = lstErrors.Width - 40
        lstvw_id.Width = lstvw_wdth * 0.1
        lstvw_desc.Width = lstvw_wdth * 0.6
        lstvw_file.Width = lstvw_wdth * 0.2
        lstvw_line.Width = lstvw_wdth * 0.1
    End Sub

    Private Sub OptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem1.Click
        frmBuildOptions.ShowDialog()
    End Sub

    Private Sub toolstripOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripOpen.Click
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            For i As Integer = 0 To dlgOpenFile.FileNames.Length - 1
                NewScintillaInstance(FILE_OPEN, dlgOpenFile.SafeFileNames(i), dlgOpenFile.FileNames(i))
            Next
        End If
    End Sub

    Private Sub toolstripFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripFont.Click
        If dlgScintillaFont.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.font = dlgScintillaFont.Font
        End If
    End Sub

    Private Sub toolstripSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripSave.Click
        If cur_cd.FilePath IsNot Nothing Then
            SaveScintillaDoc(cur_cd, -1, cur_cd.FileName, cur_cd.FilePath)
        Else
            If spf_main.ShowDialog() = DialogResult.OK Then
                SaveScintillaDoc(cur_cd, -1, Path.GetFileName(spf_main.FileName), spf_main.FileName)
            Else
                Return
            End If
        End If

    End Sub

    Private Sub toolstripCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripCut.Click
        If cur_cd.[Interface].Selection.Text = "" Then
            Return
        End If
        Clipboard.SetText(cur_cd.[Interface].Selection.Text)
        cur_cd.[Interface].Selection.Clear()
    End Sub

    Private Sub toolstripCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripCopy.Click
        If cur_cd.[Interface].Selection.Text = "" Then
            Return
        End If
        Clipboard.SetText(cur_cd.[Interface].Selection.Text)
    End Sub

    Private Sub toolstripPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripPaste.Click
        If cur_cd.[Interface].Selection.Text <> "" Then
            cur_cd.[Interface].Selection.Text = Clipboard.GetText()
            Return
        End If
        cur_cd.[Interface].InsertText(Clipboard.GetText())
    End Sub

    Private Sub toolstripUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripUndo.Click
        cur_cd.Interface.UndoRedo.Undo()
        DiscChanger()
    End Sub

    Private Sub toolstripRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripRedo.Click
        cur_cd.Interface.UndoRedo.Redo()
        DiscChanger()
    End Sub

    Private Sub toolstripCompile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripCompile.Click
        toolstripSave_Click(sender, e)
        lstErrors.Items.Clear()
        If cur_cd.FilePath Is Nothing Then
            Return
        End If
        Dim pcmp As New System.Diagnostics.Process()
        pcmp.StartInfo.UseShellExecute = False
        pcmp.StartInfo.RedirectStandardOutput = True
        pcmp.StartInfo.RedirectStandardError = True
        pcmp.StartInfo.CreateNoWindow = True
        'MessageBox.Show(SAMPCE.Properties.Settings.Default.cpath);
        pcmp.StartInfo.FileName = My.Settings.cpath
        pcmp.StartInfo.Arguments = My.Settings.cargs + " """ + cur_cd.FilePath & """"
        t_cout.Text += vbCr & vbLf & "=== BEGIN OUTPUT FOR " + cur_cd.FileName & " ===" & vbCr & vbLf
        pcmp.Start()
        Dim output As String = pcmp.StandardOutput.ReadToEnd()
        Dim err As String = pcmp.StandardError.ReadToEnd()
        pcmp.WaitForExit()
        pcmp.Close()
        t_cout.Text += (output & vbCr & vbLf & "=== END OUTPUT FOR ") + cur_cd.FileName & " ===" & vbCr & vbLf
        t_cout.SelectionStart = t_cout.Text.Length
        t_cout.ScrollToCaret()
        If err <> "" Then
            DispErr(err)
        End If
        If Not lstErrors.Items.ContainsKey(CInt(ErrorType.[Error]).ToString()) Then
            Dim fi As New FileInfo(Path.GetFileNameWithoutExtension(cur_cd.FileName) + ".amx")
            If My.Settings.afl = "pwn" Then
                Try
                    fi.MoveTo(cur_cd.FilePath)
                Catch ex As Exception
                    MessageBox.Show("Could not move resulting amx file! Reason: " + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            ElseIf My.Settings.afl = "custom" And My.Settings.aflcustom <> "" Then
                Try
                    fi.MoveTo(My.Settings.aflcustom)
                Catch ex As Exception
                    MessageBox.Show("Could not move resulting amx file! Reason: " + ex.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try

            End If
        End If
    End Sub
End Class
