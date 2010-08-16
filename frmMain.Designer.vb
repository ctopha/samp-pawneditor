<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmTab = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.statusStrip = New System.Windows.Forms.StatusStrip
        Me.statusLine = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusChr = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusINS = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsstripHints = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStrip = New System.Windows.Forms.ToolStrip
        Me.toolstripNew = New System.Windows.Forms.ToolStripButton
        Me.toolstripOpen = New System.Windows.Forms.ToolStripButton
        Me.toolstripSave = New System.Windows.Forms.ToolStripButton
        Me.toolstripSaveAll = New System.Windows.Forms.ToolStripButton
        Me.toolstripClose = New System.Windows.Forms.ToolStripButton
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
        Me.toolstripFindReplace = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.menuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newGamemodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newFilterscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newBlankDocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.BuildOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AssociatepwnFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.dlgScintillaFont = New System.Windows.Forms.FontDialog
        Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog
        Me.ttipErrorHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.tabcontrolOpenFiles = New System.Windows.Forms.TabControl
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.tabErrors = New System.Windows.Forms.TabPage
        Me.lstErrors = New System.Windows.Forms.ListView
        Me.lstvw_type = New System.Windows.Forms.ColumnHeader
        Me.lstvw_id = New System.Windows.Forms.ColumnHeader
        Me.lstvw_desc = New System.Windows.Forms.ColumnHeader
        Me.lstvw_file = New System.Windows.Forms.ColumnHeader
        Me.lstvw_line = New System.Windows.Forms.ColumnHeader
        Me.tabOutput = New System.Windows.Forms.TabPage
        Me.txtCompilerOutput = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.tabIncludes = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.treeIncludes = New System.Windows.Forms.TreeView
        Me.txtIncludesSearch = New System.Windows.Forms.TextBox
        Me.tabFileFunctions = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.treeCurrFile = New System.Windows.Forms.TreeView
        Me.txtFileSearch = New System.Windows.Forms.TextBox
        Me.tviewFilesIncluded = New System.Windows.Forms.TreeView
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmTab.SuspendLayout()
        Me.statusStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.tabErrors.SuspendLayout()
        Me.tabOutput.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabIncludes.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabFileFunctions.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmTab
        '
        Me.cmTab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem1, Me.SaveAsToolStripMenuItem1, Me.ToolStripSeparator13, Me.CloseToolStripMenuItem1})
        Me.cmTab.Name = "cmenuTab"
        Me.cmTab.Size = New System.Drawing.Size(149, 76)
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save As"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(145, 6)
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_delete
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.CloseToolStripMenuItem1.Text = "Close"
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLine, Me.statusChr, Me.statusINS, Me.ToolStripStatusLabel1, Me.tsstripHints})
        Me.statusStrip.Location = New System.Drawing.Point(0, 637)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(828, 22)
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
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(605, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'tsstripHints
        '
        Me.tsstripHints.Name = "tsstripHints"
        Me.tsstripHints.Size = New System.Drawing.Size(121, 17)
        Me.tsstripHints.Text = "ToolStripStatusLabel2"
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripNew, Me.toolstripOpen, Me.toolstripSave, Me.toolstripSaveAll, Me.toolstripClose, Me.ToolStripSeparator1, Me.toolstripCut, Me.toolstripCopy, Me.toolstripPaste, Me.ToolStripSeparator2, Me.toolstripUndo, Me.toolstripRedo, Me.ToolStripSeparator3, Me.toolstripCompile, Me.toolstripCompileRun, Me.ToolStripSeparator5, Me.toolstripFind, Me.toolstripFindReplace, Me.ToolStripSeparator4})
        Me.toolStrip.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(828, 25)
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
        Me.toolstripNew.ToolTipText = "Create a New Blank Document"
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
        Me.toolstripSave.Enabled = False
        Me.toolstripSave.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk
        Me.toolstripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSave.Name = "toolstripSave"
        Me.toolstripSave.Size = New System.Drawing.Size(23, 22)
        Me.toolstripSave.Text = "ToolStripButton2"
        Me.toolstripSave.ToolTipText = "Save Current Document"
        '
        'toolstripSaveAll
        '
        Me.toolstripSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripSaveAll.Enabled = False
        Me.toolstripSaveAll.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk_multiple
        Me.toolstripSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSaveAll.Name = "toolstripSaveAll"
        Me.toolstripSaveAll.Size = New System.Drawing.Size(23, 22)
        Me.toolstripSaveAll.Text = "ToolStripButton9"
        Me.toolstripSaveAll.ToolTipText = "Save All Documents at Once"
        '
        'toolstripClose
        '
        Me.toolstripClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripClose.Enabled = False
        Me.toolstripClose.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_delete
        Me.toolstripClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripClose.Name = "toolstripClose"
        Me.toolstripClose.Size = New System.Drawing.Size(23, 22)
        Me.toolstripClose.Text = "ToolStripButton1"
        Me.toolstripClose.ToolTipText = "Close Current Document"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripCut
        '
        Me.toolstripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripCut.Enabled = False
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
        Me.toolstripCopy.Enabled = False
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
        Me.toolstripPaste.Enabled = False
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
        Me.toolstripUndo.Enabled = False
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
        Me.toolstripRedo.Enabled = False
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
        Me.toolstripCompile.Enabled = False
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
        Me.toolstripCompileRun.Enabled = False
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
        Me.toolstripFind.Enabled = False
        Me.toolstripFind.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.magnifier
        Me.toolstripFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripFind.Name = "toolstripFind"
        Me.toolstripFind.Size = New System.Drawing.Size(23, 22)
        Me.toolstripFind.Text = "ToolStripButton8"
        Me.toolstripFind.ToolTipText = "Find"
        '
        'toolstripFindReplace
        '
        Me.toolstripFindReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripFindReplace.Enabled = False
        Me.toolstripFindReplace.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.text_replace
        Me.toolstripFindReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripFindReplace.Name = "toolstripFindReplace"
        Me.toolstripFindReplace.Size = New System.Drawing.Size(23, 22)
        Me.toolstripFindReplace.Text = "ToolStripButton11"
        Me.toolstripFindReplace.ToolTipText = "Find & Replace"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.BuildToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(828, 24)
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator9, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SaveAllToolStripMenuItem, Me.CloseToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ToolStripSeparator10, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newGamemodeToolStripMenuItem, Me.newFilterscriptToolStripMenuItem, Me.newBlankDocToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_white_add
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "New..."
        '
        'newGamemodeToolStripMenuItem
        '
        Me.newGamemodeToolStripMenuItem.Name = "newGamemodeToolStripMenuItem"
        Me.newGamemodeToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.newGamemodeToolStripMenuItem.Text = "Gamemode"
        '
        'newFilterscriptToolStripMenuItem
        '
        Me.newFilterscriptToolStripMenuItem.Name = "newFilterscriptToolStripMenuItem"
        Me.newFilterscriptToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.newFilterscriptToolStripMenuItem.Text = "Filterscript"
        '
        'newBlankDocToolStripMenuItem
        '
        Me.newBlankDocToolStripMenuItem.Name = "newBlankDocToolStripMenuItem"
        Me.newBlankDocToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newBlankDocToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.newBlankDocToolStripMenuItem.Text = "Blank Document"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.folder_page
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        Me.OpenToolStripMenuItem.ToolTipText = "Open a Script Document"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(177, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.ToolTipText = "Save Current Document"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Enabled = False
        Me.SaveAllToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.disk_multiple
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        Me.SaveAllToolStripMenuItem.ToolTipText = "Save All Documents at Once"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Enabled = False
        Me.CloseToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_delete
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Close Current Document"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Enabled = False
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseAllToolStripMenuItem.Text = "Close All"
        Me.CloseAllToolStripMenuItem.ToolTipText = "Close All Open Documents"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.UndoToolStripMenuItem.Enabled = False
        Me.UndoToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.arrow_undo
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Enabled = False
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
        Me.CutToolStripMenuItem.Enabled = False
        Me.CutToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.cut_red
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Enabled = False
        Me.CopyToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.page_copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Enabled = False
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
        Me.FindToolStripMenuItem.Enabled = False
        Me.FindToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.magnifier
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FindAndReplaceToolStripMenuItem
        '
        Me.FindAndReplaceToolStripMenuItem.Enabled = False
        Me.FindAndReplaceToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.text_replace
        Me.FindAndReplaceToolStripMenuItem.Name = "FindAndReplaceToolStripMenuItem"
        Me.FindAndReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.FindAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FindAndReplaceToolStripMenuItem.Text = "Find and Replace"
        '
        'GoToLineToolStripMenuItem
        '
        Me.GoToLineToolStripMenuItem.Enabled = False
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
        Me.SelectAllToolStripMenuItem.Enabled = False
        Me.SelectAllToolStripMenuItem.Image = CType(resources.GetObject("SelectAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileToolStripMenuItem, Me.CompileAndRunToolStripMenuItem, Me.ToolStripSeparator11, Me.BuildOptionsToolStripMenuItem})
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Enabled = False
        Me.CompileToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.application_lightning
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'CompileAndRunToolStripMenuItem
        '
        Me.CompileAndRunToolStripMenuItem.Enabled = False
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
        'BuildOptionsToolStripMenuItem
        '
        Me.BuildOptionsToolStripMenuItem.Image = CType(resources.GetObject("BuildOptionsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuildOptionsToolStripMenuItem.Name = "BuildOptionsToolStripMenuItem"
        Me.BuildOptionsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.BuildOptionsToolStripMenuItem.Text = "Options"
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
        Me.AssociatepwnFilesToolStripMenuItem.Image = Global.SA_MP_Pawn_Editor.My.Resources.Resources.pawn_icon
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
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "Open File(s)"
        Me.dlgOpenFile.Filter = "PAWN Script|*.pwn|Includes|*.inc|All files|*.*"
        Me.dlgOpenFile.InitialDirectory = "Documents"
        Me.dlgOpenFile.Multiselect = True
        Me.dlgOpenFile.Title = "Open File(s)"
        '
        'dlgSaveFile
        '
        Me.dlgSaveFile.Filter = "PAWN Script|*.pwn|Includes|*.inc"
        Me.dlgSaveFile.InitialDirectory = "Documents"
        '
        'ttipErrorHelp
        '
        Me.ttipErrorHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tabcontrolOpenFiles)
        Me.SplitContainer1.Panel1MinSize = 435
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(624, 588)
        Me.SplitContainer1.SplitterDistance = 435
        Me.SplitContainer1.TabIndex = 5
        '
        'tabcontrolOpenFiles
        '
        Me.tabcontrolOpenFiles.AllowDrop = True
        Me.tabcontrolOpenFiles.ContextMenuStrip = Me.cmTab
        Me.tabcontrolOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOpenFiles.HotTrack = True
        Me.tabcontrolOpenFiles.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrolOpenFiles.Name = "tabcontrolOpenFiles"
        Me.tabcontrolOpenFiles.SelectedIndex = 0
        Me.tabcontrolOpenFiles.Size = New System.Drawing.Size(624, 435)
        Me.tabcontrolOpenFiles.TabIndex = 0
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.tabErrors)
        Me.TabControl3.Controls.Add(Me.tabOutput)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(624, 149)
        Me.TabControl3.TabIndex = 4
        '
        'tabErrors
        '
        Me.tabErrors.Controls.Add(Me.lstErrors)
        Me.tabErrors.Location = New System.Drawing.Point(4, 22)
        Me.tabErrors.Name = "tabErrors"
        Me.tabErrors.Padding = New System.Windows.Forms.Padding(3)
        Me.tabErrors.Size = New System.Drawing.Size(616, 123)
        Me.tabErrors.TabIndex = 0
        Me.tabErrors.Text = "Error Output"
        Me.tabErrors.UseVisualStyleBackColor = True
        '
        'lstErrors
        '
        Me.lstErrors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstvw_type, Me.lstvw_id, Me.lstvw_desc, Me.lstvw_file, Me.lstvw_line})
        Me.lstErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstErrors.FullRowSelect = True
        Me.lstErrors.GridLines = True
        Me.lstErrors.Location = New System.Drawing.Point(3, 3)
        Me.lstErrors.MultiSelect = False
        Me.lstErrors.Name = "lstErrors"
        Me.lstErrors.Size = New System.Drawing.Size(610, 117)
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
        Me.tabOutput.Controls.Add(Me.txtCompilerOutput)
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(616, 122)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Misc Output"
        Me.tabOutput.UseVisualStyleBackColor = True
        '
        'txtCompilerOutput
        '
        Me.txtCompilerOutput.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompilerOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCompilerOutput.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.txtCompilerOutput.Location = New System.Drawing.Point(3, 3)
        Me.txtCompilerOutput.Multiline = True
        Me.txtCompilerOutput.Name = "txtCompilerOutput"
        Me.txtCompilerOutput.ReadOnly = True
        Me.txtCompilerOutput.Size = New System.Drawing.Size(610, 116)
        Me.txtCompilerOutput.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Panel1MinSize = 500
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Panel2MinSize = 100
        Me.SplitContainer2.Size = New System.Drawing.Size(828, 588)
        Me.SplitContainer2.SplitterDistance = 624
        Me.SplitContainer2.TabIndex = 6
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.tviewFilesIncluded)
        Me.SplitContainer3.Size = New System.Drawing.Size(200, 588)
        Me.SplitContainer3.SplitterDistance = 391
        Me.SplitContainer3.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tabIncludes)
        Me.TabControl2.Controls.Add(Me.tabFileFunctions)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(200, 391)
        Me.TabControl2.TabIndex = 2
        '
        'tabIncludes
        '
        Me.tabIncludes.Controls.Add(Me.TableLayoutPanel1)
        Me.tabIncludes.Location = New System.Drawing.Point(4, 22)
        Me.tabIncludes.Name = "tabIncludes"
        Me.tabIncludes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIncludes.Size = New System.Drawing.Size(192, 365)
        Me.tabIncludes.TabIndex = 0
        Me.tabIncludes.Text = "Includes"
        Me.tabIncludes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.treeIncludes, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIncludesSearch, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(186, 359)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'treeIncludes
        '
        Me.treeIncludes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeIncludes.Location = New System.Drawing.Point(3, 30)
        Me.treeIncludes.Name = "treeIncludes"
        Me.treeIncludes.Size = New System.Drawing.Size(180, 359)
        Me.treeIncludes.TabIndex = 1
        '
        'txtIncludesSearch
        '
        Me.txtIncludesSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncludesSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtIncludesSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtIncludesSearch.Name = "txtIncludesSearch"
        Me.txtIncludesSearch.Size = New System.Drawing.Size(180, 21)
        Me.txtIncludesSearch.TabIndex = 0
        '
        'tabFileFunctions
        '
        Me.tabFileFunctions.Controls.Add(Me.TableLayoutPanel2)
        Me.tabFileFunctions.Location = New System.Drawing.Point(4, 22)
        Me.tabFileFunctions.Name = "tabFileFunctions"
        Me.tabFileFunctions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFileFunctions.Size = New System.Drawing.Size(192, 365)
        Me.tabFileFunctions.TabIndex = 1
        Me.tabFileFunctions.Text = "File Functions"
        Me.tabFileFunctions.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.treeCurrFile, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFileSearch, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(186, 359)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'treeCurrFile
        '
        Me.treeCurrFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeCurrFile.Location = New System.Drawing.Point(3, 30)
        Me.treeCurrFile.Name = "treeCurrFile"
        Me.treeCurrFile.Size = New System.Drawing.Size(180, 359)
        Me.treeCurrFile.TabIndex = 1
        '
        'txtFileSearch
        '
        Me.txtFileSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFileSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtFileSearch.Name = "txtFileSearch"
        Me.txtFileSearch.Size = New System.Drawing.Size(180, 21)
        Me.txtFileSearch.TabIndex = 0
        '
        'tviewFilesIncluded
        '
        Me.tviewFilesIncluded.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tviewFilesIncluded.Location = New System.Drawing.Point(0, 0)
        Me.tviewFilesIncluded.Name = "tviewFilesIncluded"
        Me.tviewFilesIncluded.Size = New System.Drawing.Size(200, 193)
        Me.tviewFilesIncluded.TabIndex = 0
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(828, 659)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.menuStrip)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SA-MP Pawn Editor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmTab.ResumeLayout(False)
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.tabErrors.ResumeLayout(False)
        Me.tabOutput.ResumeLayout(False)
        Me.tabOutput.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tabIncludes.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabFileFunctions.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents toolstripCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripFindReplace As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompileAndRunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssociatepwnFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusLine As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusChr As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusINS As System.Windows.Forms.ToolStripStatusLabel
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
    Friend WithEvents newGamemodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newFilterscriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newBlankDocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dlgSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTab As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttipErrorHelp As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tabcontrolOpenFiles As System.Windows.Forms.TabControl
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents tabErrors As System.Windows.Forms.TabPage
    Friend WithEvents lstErrors As System.Windows.Forms.ListView
    Friend WithEvents lstvw_type As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_file As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstvw_line As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabOutput As System.Windows.Forms.TabPage
    Friend WithEvents txtCompilerOutput As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabIncludes As System.Windows.Forms.TabPage
    Friend WithEvents tabFileFunctions As System.Windows.Forms.TabPage
    Friend WithEvents tviewFilesIncluded As System.Windows.Forms.TreeView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsstripHints As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents treeIncludes As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents treeCurrFile As System.Windows.Forms.TreeView
    Friend WithEvents txtFileSearch As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtIncludesSearch As System.Windows.Forms.TextBox

End Class
