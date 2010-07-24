Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports newPT

Module Module1
    Public Class CodeDocument
        Public FileName As String = String.Empty
        Public Errors As New Dictionary(Of ListViewItem, [Error])()
        Public [Interface] As ScintillaNet.Scintilla
        Public IsEdited As Boolean = False
        Public Initial As Boolean = True
        'Initial is there for a reason!
        Public FilePath As String = String.Empty
        Public lv As c_FileFnc

        Public Sub New(ByVal sc As ScintillaNet.Scintilla, ByVal sfn As String, ByVal sfp As String)
            FilePath = sfp
            [Interface] = sc
            FileName = sfn
        End Sub
    End Class

    ''' <summary>
    ''' Functions used in f_main, mostly Scintilla stuff.
    ''' </summary>
    Public Class Functions
        Private lst As List(Of String), lite As List(Of String)
        Private ico As New System.Windows.Forms.ImageList()

        Public Sub New()
            ico.Images.Add(My.Resources.VSObject_MethodW)
            ico.Images.Add(My.Resources.VSObject_Type)
            lst = New List(Of String)()
            lite = New List(Of String)()
        End Sub

        Public Function AddFunction(ByVal func As String) As Boolean
            lite.Add(func)
            lst.Add(func & "?0")
            Return True
        End Function

#Region "Scintilla Initialization stuff"
        Public Function InitSC(ByVal InitialText As String) As ScintillaNet.Scintilla
            Dim sc As New ScintillaNet.Scintilla()
            sc.ConfigurationManager.CustomLocation = "cpp.xml"
            sc.ConfigurationManager.Language = "cpp"
            sc.Dock = System.Windows.Forms.DockStyle.Fill
            sc.Font = My.Settings.font
            sc.Indentation.ShowGuides = True
            sc.Indentation.SmartIndentType = ScintillaNet.SmartIndent.CPP2
            sc.Indentation.TabWidth = 5
            sc.IsBraceMatching = True
            sc.Lexing.Lexer = ScintillaNet.Lexer.Cpp
            sc.Lexing.SetKeywords(1, lst.ToString())
            sc.Lexing.LexerName = "cpp"
            sc.Lexing.LineCommentPrefix = ""
            sc.Lexing.StreamCommentPrefix = ""
            sc.Lexing.StreamCommentSufix = ""
            sc.Location = New System.Drawing.Point(0, 0)
            sc.Margins.Margin0.Width = 30
            sc.Margins.Margin2.Width = 15
            sc.Text = InitialText
            sc.Scrolling.HorizontalWidth = 480
            sc.Size = New System.Drawing.Size(624, 371)
            sc.Styles.BraceBad.FontName = "Verdana"
            sc.Styles.BraceLight.FontName = "Verdana"
            sc.Styles.ControlChar.FontName = "Verdana"
            sc.Styles.[Default].FontName = "Verdana"
            sc.Styles.IndentGuide.FontName = "Verdana"
            sc.Styles.LastPredefined.FontName = "Verdana"
            sc.Styles.LineNumber.FontName = "Verdana"
            sc.Styles.Max.FontName = "Verdana"
            sc.Lexing.SetKeywords(1, String.Join(" ", lite.ToArray()))
            lst.Sort()
            sc.AutoComplete.List.AddRange(lst)
            sc.AutoComplete.RegisterImages(ico)
            sc.AutoComplete.AutomaticLengthEntered = True
            sc.AutoComplete.DropRestOfWord = True
            sc.AutoComplete.AutoHide = False
            sc.Indicators(0).Color = Color.Red
            Return sc
        End Function
#End Region
    End Class

End Module
