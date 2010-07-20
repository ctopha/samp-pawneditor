Imports System.IO

Public Class frmMain

    ' <summary>
    'Creates a new code tab window thingy.
    ' </summary>
    ' <param name="type">Either "new" or "open", no excuses</param>
    ' <param name="FileName">The safe file name or null, if new</param>
    ' <param name="FilePath">The FilePath or null, if new</param>
    Private Sub NewScintillaInstance(ByVal type As String, ByVal filename As String, ByVal filepath As String)

        Dim newTab As TabPage = New TabPage(filename)
        Dim pgsc = New ScintillaNet.Scintilla()

        If type = "new_gm" Then
            'pgsc = InitSC(Properties.Resources.newPWN)
        ElseIf (type = "new_fs") Then
            'pgsc = InitSC(Properties.Resources.newFS)
        ElseIf (type = "new") Then
            pgsc = InitSC("")
        ElseIf (type = "open") Then
            Dim sr As StreamReader = New StreamReader(filepath)
            pgsc = InitSC(sr.ReadToEnd())
            sr.Close()
        End If

        pgsc.TextChanged += New EventHandler < EventArgs > (pgsc_TextChanged)
        pgsc.CharAdded += New EventHandler < ScintillaNet.CharAddedEventArgs > (pgsc_CharAdded)
        pgsc.TextDeleted += New EventHandler < ScintillaNet.TextModifiedEventArgs > (pgsc_TextDeleted)
        pgsc.SelectionChanged += New EventHandler(pgsc_SelectionChanged)
        pgsc.KeyUp += New KeyEventHandler(pgsc_KeyUp)
        newTab.Controls.Add(pgsc)
        tc_main.TabPages.Add(newTab)
        CodeDocument(cd = New CodeDocument(pgsc, filename, filepath))
        CodeTabs.Add(tc_main.TabPages[tc_main.TabPages.Count - 1], cd)
        tc_main.SelectedIndex = tc_main.TabPages.Count - 1
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub toolstripNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripNew.Click
        tabcontrolOpenFiles.TabPages.Add()
    End Sub
End Class
