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
            Dim scintilla As New ScintillaNet.Scintilla()

            With scintilla
                .ConfigurationManager.CustomLocation = "cpp.xml"
                .ConfigurationManager.Language = "cpp"
                .Dock = System.Windows.Forms.DockStyle.Fill
                .Font = My.Settings.font
                .Indentation.ShowGuides = True
                .Indentation.SmartIndentType = ScintillaNet.SmartIndent.CPP2
                .Indentation.TabWidth = 5
                .IsBraceMatching = True
                .Lexing.Lexer = ScintillaNet.Lexer.Cpp
                .Lexing.SetKeywords(1, lst.ToString())
                .Lexing.LexerName = "cpp"
                .Lexing.LineCommentPrefix = ""
                .Lexing.StreamCommentPrefix = ""
                .Lexing.StreamCommentSufix = ""
                .Location = New System.Drawing.Point(0, 0)
                .Margins.Margin0.Width = 30
                .Margins.Margin2.Width = 15
                .Text = InitialText
                .Scrolling.HorizontalWidth = 480
                .Size = New System.Drawing.Size(624, 371)
                .Styles.BraceBad.FontName = "Verdana"
                .Styles.BraceLight.FontName = "Verdana"
                .Styles.ControlChar.FontName = "Verdana"
                .Styles.[Default].FontName = "Verdana"
                .Styles.IndentGuide.FontName = "Verdana"
                .Styles.LastPredefined.FontName = "Verdana"
                .Styles.LineNumber.FontName = "Verdana"
                .Styles.Max.FontName = "Verdana"
                .Lexing.SetKeywords(1, String.Join(" ", lite.ToArray()))
                lst.Sort()
                .AutoComplete.List.AddRange(lst)
                .AutoComplete.RegisterImages(ico)
                .AutoComplete.AutomaticLengthEntered = True
                .AutoComplete.DropRestOfWord = True
                .AutoComplete.AutoHide = False
                .Indicators(0).Color = Color.Red
            End With

            Return scintilla
        End Function
#End Region
    End Class

End Module
