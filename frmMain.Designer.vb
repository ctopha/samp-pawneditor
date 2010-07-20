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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabcontrolOpenFiles = New System.Windows.Forms.TabControl
        Me.statusStrip = New System.Windows.Forms.StatusStrip
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
        Me.toolstripFind = New System.Windows.Forms.ToolStripButton
        Me.toolstripReplace = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripFont = New System.Windows.Forms.ToolStripButton
        Me.menuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompileAndRunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AssociatepwnFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.tabIncludes = New System.Windows.Forms.TabPage
        Me.tabCurrFile = New System.Windows.Forms.TabPage
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.tabErrors = New System.Windows.Forms.TabPage
        Me.tabOutput = New System.Windows.Forms.TabPage
        Me.toolStrip.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
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
        Me.statusStrip.Location = New System.Drawing.Point(0, 542)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(730, 22)
        Me.statusStrip.TabIndex = 1
        Me.statusStrip.Text = "StatusStrip1"
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripNew, Me.toolstripOpen, Me.toolstripSave, Me.toolstripSaveAll, Me.ToolStripSeparator1, Me.toolstripCut, Me.toolstripCopy, Me.toolstripPaste, Me.ToolStripSeparator2, Me.toolstripUndo, Me.toolstripRedo, Me.ToolStripSeparator3, Me.toolstripFind, Me.toolstripReplace, Me.ToolStripSeparator4, Me.toolstripFont})
        Me.toolStrip.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(730, 25)
        Me.toolStrip.TabIndex = 2
        Me.toolStrip.Text = "ToolStrip1"
        '
        'toolstripNew
        '
        Me.toolstripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripNew.Image = CType(resources.GetObject("toolstripNew.Image"), System.Drawing.Image)
        Me.toolstripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripNew.Name = "toolstripNew"
        Me.toolstripNew.Size = New System.Drawing.Size(23, 22)
        Me.toolstripNew.Text = "ToolStripButton5"
        Me.toolstripNew.ToolTipText = "New File"
        '
        'toolstripOpen
        '
        Me.toolstripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripOpen.Image = CType(resources.GetObject("toolstripOpen.Image"), System.Drawing.Image)
        Me.toolstripOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripOpen.Name = "toolstripOpen"
        Me.toolstripOpen.Size = New System.Drawing.Size(23, 22)
        Me.toolstripOpen.Text = "ToolStripButton1"
        Me.toolstripOpen.ToolTipText = "Open File"
        '
        'toolstripSave
        '
        Me.toolstripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripSave.Image = CType(resources.GetObject("toolstripSave.Image"), System.Drawing.Image)
        Me.toolstripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSave.Name = "toolstripSave"
        Me.toolstripSave.Size = New System.Drawing.Size(23, 22)
        Me.toolstripSave.Text = "ToolStripButton2"
        Me.toolstripSave.ToolTipText = "Save Current File"
        '
        'toolstripSaveAll
        '
        Me.toolstripSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripSaveAll.Image = CType(resources.GetObject("toolstripSaveAll.Image"), System.Drawing.Image)
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
        Me.toolstripCut.Image = CType(resources.GetObject("toolstripCut.Image"), System.Drawing.Image)
        Me.toolstripCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripCut.Name = "toolstripCut"
        Me.toolstripCut.Size = New System.Drawing.Size(23, 22)
        Me.toolstripCut.Text = "ToolStripButton12"
        Me.toolstripCut.ToolTipText = "Cut"
        '
        'toolstripCopy
        '
        Me.toolstripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripCopy.Image = CType(resources.GetObject("toolstripCopy.Image"), System.Drawing.Image)
        Me.toolstripCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripCopy.Name = "toolstripCopy"
        Me.toolstripCopy.Size = New System.Drawing.Size(23, 22)
        Me.toolstripCopy.Text = "ToolStripButton4"
        Me.toolstripCopy.ToolTipText = "Copy"
        '
        'toolstripPaste
        '
        Me.toolstripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripPaste.Image = CType(resources.GetObject("toolstripPaste.Image"), System.Drawing.Image)
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
        Me.toolstripUndo.Image = CType(resources.GetObject("toolstripUndo.Image"), System.Drawing.Image)
        Me.toolstripUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripUndo.Name = "toolstripUndo"
        Me.toolstripUndo.Size = New System.Drawing.Size(23, 22)
        Me.toolstripUndo.Text = "ToolStripButton6"
        Me.toolstripUndo.ToolTipText = "Undo"
        '
        'toolstripRedo
        '
        Me.toolstripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripRedo.Image = CType(resources.GetObject("toolstripRedo.Image"), System.Drawing.Image)
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
        'toolstripFind
        '
        Me.toolstripFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripFind.Image = CType(resources.GetObject("toolstripFind.Image"), System.Drawing.Image)
        Me.toolstripFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripFind.Name = "toolstripFind"
        Me.toolstripFind.Size = New System.Drawing.Size(23, 22)
        Me.toolstripFind.Text = "ToolStripButton8"
        Me.toolstripFind.ToolTipText = "Find"
        '
        'toolstripReplace
        '
        Me.toolstripReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripReplace.Image = CType(resources.GetObject("toolstripReplace.Image"), System.Drawing.Image)
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
        Me.toolstripFont.Image = CType(resources.GetObject("toolstripFont.Image"), System.Drawing.Image)
        Me.toolstripFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripFont.Name = "toolstripFont"
        Me.toolstripFont.Size = New System.Drawing.Size(23, 22)
        Me.toolstripFont.Text = "ToolStripButton10"
        Me.toolstripFont.ToolTipText = "Change Font"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.BuildToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(730, 24)
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileToolStripMenuItem, Me.CompileAndRunToolStripMenuItem, Me.OptionsToolStripMenuItem1})
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'CompileAndRunToolStripMenuItem
        '
        Me.CompileAndRunToolStripMenuItem.Name = "CompileAndRunToolStripMenuItem"
        Me.CompileAndRunToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CompileAndRunToolStripMenuItem.Text = "Compile and Run"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFontToolStripMenuItem, Me.AssociatepwnFilesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ChangeFontToolStripMenuItem
        '
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        Me.ChangeFontToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ChangeFontToolStripMenuItem.Text = "Change Font"
        '
        'AssociatepwnFilesToolStripMenuItem
        '
        Me.AssociatepwnFilesToolStripMenuItem.Name = "AssociatepwnFilesToolStripMenuItem"
        Me.AssociatepwnFilesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AssociatepwnFilesToolStripMenuItem.Text = "Register .pwn Extension"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.TabControl2.Size = New System.Drawing.Size(158, 487)
        Me.TabControl2.TabIndex = 0
        '
        'tabIncludes
        '
        Me.tabIncludes.Location = New System.Drawing.Point(4, 22)
        Me.tabIncludes.Name = "tabIncludes"
        Me.tabIncludes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIncludes.Size = New System.Drawing.Size(150, 461)
        Me.tabIncludes.TabIndex = 0
        Me.tabIncludes.Text = "Includes"
        Me.tabIncludes.UseVisualStyleBackColor = True
        '
        'tabCurrFile
        '
        Me.tabCurrFile.Location = New System.Drawing.Point(4, 22)
        Me.tabCurrFile.Name = "tabCurrFile"
        Me.tabCurrFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCurrFile.Size = New System.Drawing.Size(150, 461)
        Me.tabCurrFile.TabIndex = 1
        Me.tabCurrFile.Text = "Current File"
        Me.tabCurrFile.UseVisualStyleBackColor = True
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
        Me.tabErrors.Location = New System.Drawing.Point(4, 22)
        Me.tabErrors.Name = "tabErrors"
        Me.tabErrors.Padding = New System.Windows.Forms.Padding(3)
        Me.tabErrors.Size = New System.Drawing.Size(543, 125)
        Me.tabErrors.TabIndex = 0
        Me.tabErrors.Text = "Error Output"
        Me.tabErrors.UseVisualStyleBackColor = True
        '
        'tabOutput
        '
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(543, 125)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Misc Output"
        Me.tabOutput.UseVisualStyleBackColor = True
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
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SA-MP Pawn Editor"
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
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

End Class
