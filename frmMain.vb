﻿Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Diagnostics
Imports newPT

Public Class frmMain
    Friend prs As Parser
    Private CodeTabs As New Dictionary(Of TabPage, CodeDocument)()
    Private cur_tbs As Integer = -1, hParam As Integer
    Private numNewDocs As Integer
    Private currDoc As CodeDocument
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
        If currDoc.lv Is Nothing OrElse refresh = True Then
            prs.CodeParser("null", cd, False, My.Settings.fd)
            currDoc.lv = prs.curFile
        Else
            prs.curFile = currDoc.lv
        End If

        treeCurrFile.Nodes.Clear()

        For Each fnc As c_function In currDoc.lv.functions.Values
            Dim tn As New TreeNode(fnc.fName)
            tn.ImageIndex = 1
            tn.SelectedImageIndex = 1
            treeCurrFile.Nodes.Add(tn)
        Next

        For Each fnc As c_function In currDoc.lv.constants.Values
            Dim tn As New TreeNode(fnc.fName)
            tn.ImageIndex = 2
            tn.SelectedImageIndex = 2
            treeCurrFile.Nodes.Add(tn)
        Next

        For Each fnc As c_function In currDoc.lv.variables.Values
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
    Public Sub NewScintillaInstance(ByVal type As String, ByVal FileName As String, ByVal FilePath As String)
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

        currDoc = New CodeDocument(pgsc, FileName, FilePath)
        CodeTabs.Add(tabcontrolOpenFiles.TabPages(tabcontrolOpenFiles.TabPages.Count - 1), currDoc)
        tabcontrolOpenFiles.SelectedIndex = tabcontrolOpenFiles.TabPages.Count - 1
        DiscChanger()
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
        If tabcontrolOpenFiles.TabCount <= 0 Then 'If there is not tab open

        Else

        End If

        'UNDO
        If currDoc.[Interface].UndoRedo.CanUndo = False Then
            toolstripUndo.Enabled = False
            UndoToolStripMenuItem.Enabled = False
        Else
            toolstripUndo.Enabled = True
            UndoToolStripMenuItem.Enabled = True
        End If

        'REDO
        If currDoc.[Interface].UndoRedo.CanRedo = True Then
            toolstripRedo.Enabled = True
            RedoToolStripMenuItem.Enabled = True
        Else
            toolstripRedo.Enabled = False
            RedoToolStripMenuItem.Enabled = False
        End If

        'SAVE
        If currDoc.IsEdited = False Then
            'save_tbcm.Enabled = False
            toolstripSave.Enabled = False
            SaveToolStripMenuItem.Enabled = False
        Else
            'save_tbcm.Enabled = True
            toolstripSave.Enabled = True
            SaveToolStripMenuItem.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Parses errors from PAWN and keeps it
    ''' </summary>
    ''' <param name="errq">The error, in its full glory</param>
    Private Sub DispErr(ByVal errq As String)
        For Each erl As [Error] In currDoc.Errors.Values
            currDoc.[Interface].Lines(erl.Line - 1).Range.ClearIndicator(0)
        Next
        currDoc.Errors.Clear()
        Dim terr As String = If((errq.IndexOf("Compilation") <> -1), errq.Remove(errq.IndexOf("Compilation")), errq)
        terr = terr.Trim()
        Dim errors As String() = terr.Split(ControlChars.Lf)
        For Each [error] As String In errors
            Dim err_elems As [Error] = newPT.ErrorParser.ParseCompilerError([error])
            currDoc.Errors.Add(LoadErrorsIntoList(err_elems), err_elems)
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
        lvsi_err(3).Text = currDoc.FileName
        lvsi_err(4).Text = err.Line.ToString()
        currDoc.[Interface].Lines(err.Line - 1).Range.SetIndicator(0)
        Dim lvi_err As New ListViewItem(lvsi_err, CInt(err.Type))
        lstErrors.Items.Add(lvi_err)
        Return lvi_err
    End Function

    Private Sub pgsc_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If currDoc.Initial = True Then
            currDoc.Initial = False
            currDoc.[Interface].UndoRedo.EmptyUndoBuffer()
        ElseIf currDoc.IsEdited = False Then
            currDoc.IsEdited = True
            tabcontrolOpenFiles.SelectedTab.Text = currDoc.FileName + "*"
        End If
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
        statusINS.Text = If((currDoc.[Interface].OverType = True), "OVR", "INS")
    End Sub

    Private Sub pgsc_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        statusLine.Text = "Ln " & (currDoc.[Interface].Lines.Current.VisibleLineNumber + 1)
        statusChr.Text = "Ch " & (currDoc.[Interface].Selection.Start - currDoc.[Interface].Lines.Current.StartPosition + 1)
    End Sub

    Private Function CheckupOK()
        Dim essFiles As String() = {"pawncc.exe", "pawnc.dll", "libpawnc.dll", "ScintillaNet.dll", "newPT.dll", "cpp.xml"}

        For file As Integer = 0 To essFiles.Length - 1
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & essFiles(file)) = False Then
                MsgBox("Oops, something went wrong! Be sure to have these files in the same folder as this program, before you start it:" & vbNewLine & vbNewLine & _
                       "'pawncc.exe', 'pawnc.dll', 'libpawnc.dll', 'ScintillaNet.dll', 'cpp.xml' and 'newPT.dll'." & vbNewLine & vbNewLine & _
                       "Program will now shutdown.", MsgBoxStyle.Critical)
                Return False
            End If
        Next
        Return True

    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If the application starts from an associated file type then load the according file
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim procPawn As Process() = Process.GetProcessesByName("samp_pawneditor")
            If procPawn.Length > 0 Then
                MsgBox("Another instance of this program is already running!")
                Close()
            Else
                Dim filePathAndName As String = My.Application.CommandLineArgs.Item(0).ToString
                Dim fileName As String = System.IO.Path.GetFileName(filePathAndName)

                NewScintillaInstance(FILE_OPEN, fileName, filePathAndName)
            End If
        ElseIf CheckupOK() = True Then
            LoadPrerequisites()
            dlgScintillaFont.Font = My.Settings.font
            tstripIncludeHelp.Text = Nothing
        Else
            Close()
        End If
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim lstvw_wdth As Double = lstErrors.Width - 40
        lstvw_id.Width = lstvw_wdth * 0.1
        lstvw_desc.Width = lstvw_wdth * 0.6
        lstvw_file.Width = lstvw_wdth * 0.2
        lstvw_line.Width = lstvw_wdth * 0.1
    End Sub

    Private Sub DisplayBuildOptions(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildOptionsToolStripMenuItem.Click
        frmBuildOptions.ShowDialog()
    End Sub

    Private Sub NewGamemode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGamemodeToolStripMenuItem.Click
        NewScintillaInstance(FILE_NEW_GM, "New Gamemode (" & numNewDocs & ")", Nothing)
        numNewDocs += 1
    End Sub

    Private Sub newFilterscript(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newFilterscriptToolStripMenuItem.Click
        NewScintillaInstance(FILE_NEW_FS, "New Filterscript (" & numNewDocs & ")", Nothing)
        numNewDocs += 1
    End Sub

    Private Sub newBlankDoc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripNew.Click, newBlankDocToolStripMenuItem.Click
        NewScintillaInstance(FILE_NEW, "New PAWN Script (" & numNewDocs & ")", Nothing)
        numNewDocs += 1
    End Sub

    Private Sub OpenFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripOpen.Click, OpenToolStripMenuItem.Click
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            For i As Integer = 0 To dlgOpenFile.FileNames.Length - 1
                NewScintillaInstance(FILE_OPEN, dlgOpenFile.SafeFileNames(i), dlgOpenFile.FileNames(i))
            Next
        End If
    End Sub

    Private Sub ChangeFont(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeFontToolStripMenuItem.Click
        'Change Scintilla's font
        If dlgScintillaFont.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.font = dlgScintillaFont.Font
        End If
    End Sub

    Private Sub SaveFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripSave.Click, SaveToolStripMenuItem.Click
        If currDoc.FilePath IsNot Nothing Then
            SaveScintillaDoc(currDoc, -1, currDoc.FileName, currDoc.FilePath)
        Else
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                SaveScintillaDoc(currDoc, -1, Path.GetFileName(dlgSaveFile.FileName), dlgSaveFile.FileName)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub SaveAs(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If dlgSaveFile.ShowDialog() = DialogResult.OK Then
            SaveScintillaDoc(currDoc, -1, Path.GetFileName(dlgSaveFile.FileName), dlgSaveFile.FileName)
        Else
            Return
        End If
    End Sub

    Private Sub SaveAll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAllToolStripMenuItem.Click, toolstripSaveAll.Click

    End Sub

    Private Sub CloseDoc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripClose.Click, CloseToolStripMenuItem.Click
        If cur_tbs = -1 Then
            Return
        End If
        Dim sel_cd As CodeDocument = CodeTabs(tabcontrolOpenFiles.TabPages(cur_tbs))
        If sel_cd.IsEdited = True Then
            Dim dr As DialogResult = MessageBox.Show("Do you want to save changes made to this file?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Select Case dr
                Case DialogResult.Yes
                    'save_tbcm_Click(sender, e)
                    Exit Select

                Case DialogResult.No
                    Exit Select

                Case DialogResult.Cancel
                    Return
            End Select
        End If
        DestroyScintillaInstance(tabcontrolOpenFiles.TabPages(cur_tbs))

    End Sub

    Private Sub Cut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripCut.Click, CutToolStripMenuItem.Click
        If currDoc.[Interface].Selection.Text = "" Then
            Return
        End If
        Clipboard.SetText(currDoc.[Interface].Selection.Text)
        currDoc.[Interface].Selection.Clear()
    End Sub

    Private Sub Copy(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripCopy.Click, CopyToolStripMenuItem.Click
        If currDoc.[Interface].Selection.Text = "" Then
            Return
        End If
        Clipboard.SetText(currDoc.[Interface].Selection.Text)
    End Sub

    Private Sub Paste(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripPaste.Click, PasteToolStripMenuItem.Click
        If currDoc.[Interface].Selection.Text <> "" Then
            currDoc.[Interface].Selection.Text = Clipboard.GetText()
            Return
        End If
        currDoc.[Interface].InsertText(Clipboard.GetText())
    End Sub

    Private Sub Undo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripUndo.Click, UndoToolStripMenuItem.Click
        currDoc.Interface.UndoRedo.Undo()
        DiscChanger()
    End Sub

    Private Sub Redo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripRedo.Click, RedoToolStripMenuItem.Click
        currDoc.Interface.UndoRedo.Redo()
        DiscChanger()
    End Sub

    Private Sub Compile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripCompile.Click, CompileToolStripMenuItem.Click
        SaveFile(sender, e) 'Save current file before compiling it

        lstErrors.Items.Clear()
        If currDoc.FilePath Is Nothing Then
            Return
        End If
        Dim pcmp As New System.Diagnostics.Process()
        pcmp.StartInfo.UseShellExecute = False
        pcmp.StartInfo.RedirectStandardOutput = True
        pcmp.StartInfo.RedirectStandardError = True
        pcmp.StartInfo.CreateNoWindow = True
        'MessageBox.Show(SAMPCE.Properties.Settings.Default.cpath);
        pcmp.StartInfo.FileName = My.Settings.cpath
        pcmp.StartInfo.Arguments = My.Settings.cargs + " """ + currDoc.FilePath & """"
        txtCompilerOutput.Text += vbCr & vbLf & "=== BEGIN OUTPUT FOR " + currDoc.FileName & " ===" & vbCr & vbLf
        pcmp.Start()
        Dim output As String = pcmp.StandardOutput.ReadToEnd()
        Dim err As String = pcmp.StandardError.ReadToEnd()
        pcmp.WaitForExit()
        pcmp.Close()
        txtCompilerOutput.Text += (output & vbCr & vbLf & "=== END OUTPUT FOR ") + currDoc.FileName & " ===" & vbCr & vbLf
        txtCompilerOutput.SelectionStart = txtCompilerOutput.Text.Length
        txtCompilerOutput.ScrollToCaret()
        If err <> "" Then
            DispErr(err)
        End If
        If Not lstErrors.Items.ContainsKey(CInt(ErrorType.[Error]).ToString()) Then
            Dim fi As New FileInfo(Path.GetFileNameWithoutExtension(currDoc.FileName) + ".amx")
            If My.Settings.afl = "pwn" Then
                Try
                    fi.MoveTo(currDoc.FilePath)
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

    Private Sub AssociatepwnFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssociatepwnFilesToolStripMenuItem.Click
        If Not File.Exists(Environment.CurrentDirectory + "/pawn.ico") Then
            MsgBox("pawn.ico is missing! Put it back to its place!", MsgBoxStyle.Critical)
            Return
        Else

            Dim Assoc As New Associations.AF_FileAssociator(".pwn")
            Assoc.Create("SA-MP Pawn Editor", "PAWN Source Code", New Associations.ProgramIcon(Environment.CurrentDirectory + "/pawn.ico"), New Associations.ExecApplication(Application.ExecutablePath), New Associations.OpenWithList(New String() {"SA-MP Pawn Editor"}))
        End If
    End Sub

    Private Sub tabcontrolOpenFiles_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tabcontrolOpenFiles.DragDrop
        'Thanks to Cybernavigator @ portugal-a-programar.org - http://www.portugal-a-programar.org/forum/index.php?topic=20665.0

        Dim filePathAndName As String = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
        Dim fileName As String = System.IO.Path.GetFileName(filePathAndName)

        NewScintillaInstance(FILE_OPEN, fileName, filePathAndName)
    End Sub

    Private Sub tabcontrolOpenFiles_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tabcontrolOpenFiles.DragEnter
        'Thanks to Cybernavigator @ portugal-a-programar.org - http://www.portugal-a-programar.org/forum/index.php?topic=20665.0

        Dim fileExt As String = System.IO.Path.GetExtension(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString).ToString.ToLower

        If (e.Data.GetDataPresent(DataFormats.FileDrop)) And (fileExt = ".pwn" Or fileExt = ".inc") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub treeIncludes_NodeMouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseHoverEventArgs) Handles treeIncludes.NodeMouseHover
        If e.Node.Parent IsNot Nothing AndAlso e.Node.ImageIndex = 1 Then
            Dim cftemp As c_function = prs.SearchForFunc(e.Node.Text)
            tstripIncludeHelp.Text = cftemp.fReturn + ":" + cftemp.fName & "(" & String.Join(",", cftemp.fParams) & ")"
        End If
    End Sub

    Private Sub treeIncludes_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeIncludes.NodeMouseDoubleClick
        If e.Node.Parent IsNot Nothing AndAlso e.Node.ImageIndex = 1 Then
            currDoc.[Interface].InsertText(e.Node.Text)
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        currDoc.Interface.Selection.SelectAll()
    End Sub

    Private Sub GoToLineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoToLineToolStripMenuItem.Click
        currDoc.Interface.GoTo.ShowGoToDialog()
    End Sub

    Private Sub FindAndReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindAndReplaceToolStripMenuItem.Click
        currDoc.Interface.FindReplace.ShowReplace()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        currDoc.Interface.FindReplace.ShowFind()
    End Sub

    Private Sub KeyboardShortcutsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyboardShortcutsToolStripMenuItem.Click
        MsgBox(Nothing)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
