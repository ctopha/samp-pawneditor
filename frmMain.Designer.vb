﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabcontrolOpenFiles = New System.Windows.Forms.TabControl
        Me.statusStrip = New System.Windows.Forms.StatusStrip
        Me.statusLine = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusChr = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusINS = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStrip = New System.Windows.Forms.ToolStrip
        Me.toolstripNew = New System.Windows.Forms.ToolStripButton
        Me.toolstripOpen = New System.Windows.Forms.ToolStripButton
        Me.toolstripSave = New System.Windows.Forms.ToolStripButton
        Me.toolstripSaveAll = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripCut = New System.Windows.Forms.ToolStripButton
        Me.toolstripCopy = New System.Windows.Forms.ToolStripButton
        Me.toolstripPaste = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripUndo = New System.Windows.Forms.ToolStripButton
        Me.toolstripRedo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripCompile = New System.Windows.Forms.ToolStripButton
        Me.toolstripCompileRun = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripFind = New System.Windows.Forms.ToolStripButton
        Me.toolstripReplace = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripFont = New System.Windows.Forms.ToolStripButton
        Me.menuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GamemodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IncludToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindAndReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoToLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompileAndRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AssociatepwnFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.tabIncludes = New System.Windows.Forms.TabPage
        Me.treeIncludes = New System.Windows.Forms.TreeView
        Me.tabCurrFile = New System.Windows.Forms.TabPage
        Me.treeCurrFile = New System.Windows.Forms.TreeView
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.tabErrors = New System.Windows.Forms.TabPage
        Me.lstErrors = New System.Windows.Forms.ListView
        Me.lstvw_type = New System.Windows.Forms.ColumnHeader
        Me.lstvw_id = New System.Windows.Forms.ColumnHeader
        Me.lstvw_desc = New System.Windows.Forms.ColumnHeader
        Me.lstvw_file = New System.Windows.Forms.ColumnHeader
        Me.lstvw_line = New System.Windows.Forms.ColumnHeader
        Me.tabOutput = New System.Windows.Forms.TabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.dlgScintillaFont = New System.Windows.Forms.FontDialog
        Me.statusStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabIncludes.SuspendLayout()
        Me.tabCurrFile.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.tabErrors.SuspendLayout()
        Me.tabOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcontrolOpenFiles
        '
        Me.tabcontrolOpenFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolOpenFiles.Location = New System.Drawing.Point(12, 52)
        Me.tabcontrolOpenFiles.Name = "tabcontrolOpenFiles"
        Me.tabcontrolOpenFiles.SelectedIndex = 0
        Me.tabcontrolOpenFiles.Size = New System.Drawing.Size(551, 330)
        Me.tabcontrolOpenFiles.TabIndex = 0
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLine, Me.statusChr, Me.statusINS})
        Me.statusStrip.Location = New System.Drawing.Point(0, 542)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(730, 22)
        Me.statusStrip.TabIndex = 1
        Me.statusStrip.Text = "StatusStrip1"
        '
        'statusLine
        '
        Me.statusLine.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLine.Name = "statusLine"
        Me.statusLine.Size = New System.Drawing.Size(30, 17)
        Me.statusLine.Text = "Ln 1"
        '
        'statusChr
        '
        Me.statusChr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusChr.Name = "statusChr"
        Me.statusChr.Size = New System.Drawing.Size(31, 17)
        Me.statusChr.Text = "Ch 1"
        '
        'statusINS
        '
        Me.statusINS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusINS.Name = "statusINS"
        Me.statusINS.Size = New System.Drawing.Size(26, 17)
        Me.statusINS.Text = "INS"
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripNew, Me.toolstripOpen, Me.toolstripSave, Me.toolstripSaveAll, Me.ToolStripSeparator1, Me.toolstripCut, Me.toolstripCopy, Me.toolstripPaste, Me.ToolStripSeparator2, Me.toolstripUndo, Me.toolstripRedo, Me.ToolStripSeparator3, Me.toolstripCompile, Me.toolstripCompileRun, Me.ToolStripSeparator5, Me.toolstripFind, Me.toolstripReplace, Me.ToolStripSeparator4, Me.toolstripFont})
        Me.toolStrip.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(730, 25)
        Me.toolStrip.TabIndex = 2
        Me.toolStrip.Text = "ToolStrip1"
        '
        'toolstripNew
        '
        Me.toolstripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripNew.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_white_add
        Me.toolstripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripNew.Name = "toolstripNew"
        Me.toolstripNew.Size = New System.Drawing.Size(23, 22)
        Me.toolstripNew.Text = "ToolStripButton5"
        Me.toolstripNew.ToolTipText = "New File"
        '
        'toolstripOpen
        '
        Me.toolstripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripOpen.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.folder_page
        Me.toolstripOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripOpen.Name = "toolstripOpen"
        Me.toolstripOpen.Size = New System.Drawing.Size(23, 22)
        Me.toolstripOpen.Text = "ToolStripButton1"
        Me.toolstripOpen.ToolTipText = "Open File"
        '
        'toolstripSave
        '
        Me.toolstripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripSave.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk
        Me.toolstripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSave.Name = "toolstripSave"
        Me.toolstripSave.Size = New System.Drawing.Size(23, 22)
        Me.toolstripSave.Text = "ToolStripButton2"
        Me.toolstripSave.ToolTipText = "Save Current File"
        '
        'toolstripSaveAll
        '
        Me.toolstripSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripSaveAll.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk_multiple
        Me.toolstripSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSaveAll.Name = "toolstripSaveAll"
        Me.toolstripSaveAll.Size = New System.Drawing.Size(23, 22)
        Me.toolstripSaveAll.Text = "ToolStripButton9"
        Me.toolstripSaveAll.ToolTipText = "Save All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripCut
        '
        Me.toolstripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripCut.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.cut_red
        Me.toolstripCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripCut.Name = "toolstripCut"
        Me.toolstripCut.Size = New System.Drawing.Size(23, 22)
        Me.toolstripCut.Text = "ToolStripButton12"
        Me.toolstripCut.ToolTipText = "Cut"
        '
        'toolstripCopy
        '
        Me.toolstripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripCopy.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_copy
        Me.toolstripCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripCopy.Name = "toolstripCopy"
        Me.toolstripCopy.Size = New System.Drawing.Size(23, 22)
        Me.toolstripCopy.Text = "ToolStripButton4"
        Me.toolstripCopy.ToolTipText = "Copy"
        '
        'toolstripPaste
        '
        Me.toolstripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripPaste.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_paste
        Me.toolstripPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripPaste.Name = "toolstripPaste"
        Me.toolstripPaste.Size = New System.Drawing.Size(23, 22)
        Me.toolstripPaste.Text = "ToolStripButton3"
        Me.toolstripPaste.ToolTipText = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripUndo
        '
        Me.toolstripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripUndo.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.arrow_undo
        Me.toolstripUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripUndo.Name = "toolstripUndo"
        Me.toolstripUndo.Size = New System.Drawing.Size(23, 22)
        Me.toolstripUndo.Text = "ToolStripButton6"
        Me.toolstripUndo.ToolTipText = "Undo"
        '
        'toolstripRedo
        '
        Me.toolstripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripRedo.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.arrow_redo
        Me.toolstripRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripRedo.Name = "toolstripRedo"
        Me.toolstripRedo.Size = New System.Drawing.Size(23, 22)
        Me.toolstripRedo.Text = "ToolStripButton7"
        Me.toolstripRedo.ToolTipText = "Redo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripCompile
        '
        Me.toolstripCompile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripCompile.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.application_lightning
        Me.toolstripCompile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripCompile.Name = "toolstripCompile"
        Me.toolstripCompile.Size = New System.Drawing.Size(23, 22)
        Me.toolstripCompile.Text = "ToolStripButton1"
        Me.toolstripCompile.ToolTipText = "Compile"
        '
        'toolstripCompileRun
        '
        Me.toolstripCompileRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripCompileRun.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.application_xp_terminal
        Me.toolstripCompileRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripCompileRun.Name = "toolstripCompileRun"
        Me.toolstripCompileRun.Size = New System.Drawing.Size(23, 22)
        Me.toolstripCompileRun.Text = "ToolStripButton1"
        Me.toolstripCompileRun.ToolTipText = "Compile and Run"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripFind
        '
        Me.toolstripFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripFind.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.magnifier
        Me.toolstripFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripFind.Name = "toolstripFind"
        Me.toolstripFind.Size = New System.Drawing.Size(23, 22)
        Me.toolstripFind.Text = "ToolStripButton8"
        Me.toolstripFind.ToolTipText = "Find"
        '
        'toolstripReplace
        '
        Me.toolstripReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripReplace.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.text_replace
        Me.toolstripReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripReplace.Name = "toolstripReplace"
        Me.toolstripReplace.Size = New System.Drawing.Size(23, 22)
        Me.toolstripReplace.Text = "ToolStripButton11"
        Me.toolstripReplace.ToolTipText = "Find & Replace"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripFont
        '
        Me.toolstripFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripFont.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.style
        Me.toolstripFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripFont.Name = "toolstripFont"
        Me.toolstripFont.Size = New System.Drawing.Size(23, 22)
        Me.toolstripFont.Text = "ToolStripButton10"
        Me.toolstripFont.ToolTipText = "Change Document Font"
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.BuildToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(730, 24)
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator9, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SaveAllToolStripMenuItem, Me.ToolStripSeparator10, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GamemodeToolStripMenuItem, Me.FilterscriptToolStripMenuItem, Me.IncludToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_white_add
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NewToolStripMenuItem.Text = "New..."
        '
        'GamemodeToolStripMenuItem
        '
        Me.GamemodeToolStripMenuItem.Name = "GamemodeToolStripMenuItem"
        Me.GamemodeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.GamemodeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GamemodeToolStripMenuItem.Text = "Gamemode"
        '
        'FilterscriptToolStripMenuItem
        '
        Me.FilterscriptToolStripMenuItem.Name = "FilterscriptToolStripMenuItem"
        Me.FilterscriptToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FilterscriptToolStripMenuItem.Text = "Filterscript"
        '
        'IncludToolStripMenuItem
        '
        Me.IncludToolStripMenuItem.Name = "IncludToolStripMenuItem"
        Me.IncludToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.IncludToolStripMenuItem.Text = "Include"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.folder_page
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(178, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk_multiple
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator6, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator7, Me.FindToolStripMenuItem, Me.FindAndReplaceToolStripMenuItem, Me.GoToLineToolStripMenuItem, Me.ToolStripSeparator8, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.arrow_undo
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.arrow_redo
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(192, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.cut_red
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(192, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.magnifier
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FindAndReplaceToolStripMenuItem
        '
        Me.FindAndReplaceToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.text_replace
        Me.FindAndReplaceToolStripMenuItem.Name = "FindAndReplaceToolStripMenuItem"
        Me.FindAndReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.FindAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindAndReplaceToolStripMenuItem.Text = "Find and Replace"
        '
        'GoToLineToolStripMenuItem
        '
        Me.GoToLineToolStripMenuItem.Image = CType(resources.GetObject("GoToLineToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GoToLineToolStripMenuItem.Name = "GoToLineToolStripMenuItem"
        Me.GoToLineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GoToLineToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.GoToLineToolStripMenuItem.Text = "Go To Line..."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(192, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = CType(resources.GetObject("SelectAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileToolStripMenuItem, Me.CompileAndRunToolStripMenuItem, Me.ToolStripSeparator11, Me.OptionsToolStripMenuItem1})
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.application_lightning
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'CompileAndRunToolStripMenuItem
        '
        Me.CompileAndRunToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.application_xp_terminal
        Me.CompileAndRunToolStripMenuItem.Name = "CompileAndRunToolStripMenuItem"
        Me.CompileAndRunToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.CompileAndRunToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CompileAndRunToolStripMenuItem.Text = "Compile and Run"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(195, 6)
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.Image = CType(resources.GetObject("OptionsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontToolStripMenuItem, Me.AssociatepwnFilesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ChangeFontToolStripMenuItem
        '
        Me.ChangeFontToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.style
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        Me.ChangeFontToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ChangeFontToolStripMenuItem.Text = "Change Font"
        '
        'AssociatepwnFilesToolStripMenuItem
        '
        Me.AssociatepwnFilesToolStripMenuItem.CheckOnClick = True
        Me.AssociatepwnFilesToolStripMenuItem.Name = "AssociatepwnFilesToolStripMenuItem"
        Me.AssociatepwnFilesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AssociatepwnFilesToolStripMenuItem.Text = "Associate .pwn Extension"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.tabIncludes)
        Me.TabControl2.Controls.Add(Me.tabCurrFile)
        Me.TabControl2.Location = New System.Drawing.Point(569, 52)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(158, 330)
        Me.TabControl2.TabIndex = 0
        '
        'tabIncludes
        '
        Me.tabIncludes.Controls.Add(Me.treeIncludes)
        Me.tabIncludes.Location = New System.Drawing.Point(4, 22)
        Me.tabIncludes.Name = "tabIncludes"
        Me.tabIncludes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIncludes.Size = New System.Drawing.Size(150, 304)
        Me.tabIncludes.TabIndex = 0
        Me.tabIncludes.Text = "Includes"
        Me.tabIncludes.UseVisualStyleBackColor = True
        '
        'treeIncludes
        '
        Me.treeIncludes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeIncludes.Location = New System.Drawing.Point(3, 3)
        Me.treeIncludes.Name = "treeIncludes"
        Me.treeIncludes.Size = New System.Drawing.Size(144, 298)
        Me.treeIncludes.TabIndex = 0
        '
        'tabCurrFile
        '
        Me.tabCurrFile.Controls.Add(Me.treeCurrFile)
        Me.tabCurrFile.Location = New System.Drawing.Point(4, 22)
        Me.tabCurrFile.Name = "tabCurrFile"
        Me.tabCurrFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCurrFile.Size = New System.Drawing.Size(150, 304)
        Me.tabCurrFile.TabIndex = 1
        Me.tabCurrFile.Text = "Current File"
        Me.tabCurrFile.UseVisualStyleBackColor = True
        '
        'treeCurrFile
        '
        Me.treeCurrFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeCurrFile.Location = New System.Drawing.Point(3, 3)
        Me.treeCurrFile.Name = "treeCurrFile"
        Me.treeCurrFile.Size = New System.Drawing.Size(144, 298)
        Me.treeCurrFile.TabIndex = 0
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.tabErrors)
        Me.TabControl3.Controls.Add(Me.tabOutput)
        Me.TabControl3.Location = New System.Drawing.Point(12, 388)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(551, 151)
        Me.TabControl3.TabIndex = 4
        '
        'tabErrors
        '
        Me.tabErrors.Controls.Add(Me.lstErrors)
        Me.tabErrors.Location = New System.Drawing.Point(4, 22)
        Me.tabErrors.Name = "tabErrors"
        Me.tabErrors.Padding = New System.Windows.Forms.Padding(3)
        Me.tabErrors.Size = New System.Drawing.Size(543, 125)
        Me.tabErrors.TabIndex = 0
        Me.tabErrors.Text = "Error Output"
        Me.tabErrors.UseVisualStyleBackColor = True
        '
        'lstErrors
        '
        Me.lstErrors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstvw_type, Me.lstvw_id, Me.lstvw_desc, Me.lstvw_file, Me.lstvw_line})
        Me.lstErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstErrors.GridLines = True
        Me.lstErrors.Location = New System.Drawing.Point(3, 3)
        Me.lstErrors.MultiSelect = False
        Me.lstErrors.Name = "lstErrors"
        Me.lstErrors.Size = New System.Drawing.Size(537, 119)
        Me.lstErrors.TabIndex = 0
        Me.lstErrors.UseCompatibleStateImageBehavior = False
        Me.lstErrors.View = System.Windows.Forms.View.Details
        '
        'lstvw_type
        '
        Me.lstvw_type.Text = ""
        Me.lstvw_type.Width = 25
        '
        'lstvw_id
        '
        Me.lstvw_id.Text = "ID"
        '
        'lstvw_desc
        '
        Me.lstvw_desc.Text = "Description"
        Me.lstvw_desc.Width = 247
        '
        'lstvw_file
        '
        Me.lstvw_file.Text = "File"
        Me.lstvw_file.Width = 85
        '
        'lstvw_line
        '
        Me.lstvw_line.Text = "Line"
        Me.lstvw_line.Width = 35
        '
        'tabOutput
        '
        Me.tabOutput.Controls.Add(Me.TextBox1)
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(543, 125)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Misc Output"
        Me.tabOutput.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(537, 119)
        Me.TextBox1.TabIndex = 0
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "Open File(s)"
        Me.dlgOpenFile.Filter = "PAWN Script|*.pwn|Includes|*.inc|All files|*.*"
        Me.dlgOpenFile.InitialDirectory = "Documents"
        Me.dlgOpenFile.Multiselect = True
        Me.dlgOpenFile.Title = "Open File(s)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 564)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.tabcontrolOpenFiles)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SA-MP Pawn Editor"
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tabIncludes.ResumeLayout(False)
        Me.tabCurrFile.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.tabErrors.ResumeLayout(False)
        Me.tabOutput.ResumeLayout(False)
        Me.tabOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabcontrolOpenFiles As System.Windows.Forms.TabControl
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabIncludes As System.Windows.Forms.TabPage
    Friend WithEvents tabCurrFile As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents tabErrors As System.Windows.Forms.TabPage
    Friend WithEvents tabOutput As System.Windows.Forms.TabPage
    Friend WithEvents toolstripSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripSaveAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripReplace As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompileAndRunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssociatepwnFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents treeIncludes As System.Windows.Forms.TreeView
    Friend WithEvents treeCurrFile As System.Windows.Forms.TreeView
    Friend WithEvents lstErrors As System.Windows.Forms.ListView
    Friend WithEvents statusLine As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusChr As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusINS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lstvw_type As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_file As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_line As System.Windows.Forms.ColumnHeader
    Friend WithEvents toolstripCompile As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripCompileRun As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindAndReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgScintillaFont As System.Windows.Forms.FontDialog
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GamemodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterscriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncludToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator

End Class
