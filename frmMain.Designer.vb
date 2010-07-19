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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.statusStrip = New System.Windows.Forms.StatusStrip
        Me.toolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.menuStrip = New System.Windows.Forms.MenuStrip
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(12, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(551, 330)
        Me.TabControl1.TabIndex = 0
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
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.toolStrip.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(730, 25)
        Me.toolStrip.TabIndex = 2
        Me.toolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(730, 24)
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "MenuStrip"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
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
        Me.tabCurrFile.Size = New System.Drawing.Size(150, 237)
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
        Me.tabErrors.Text = "TabPage1"
        Me.tabErrors.UseVisualStyleBackColor = True
        '
        'tabOutput
        '
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(543, 125)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "TabPage2"
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
        Me.Controls.Add(Me.TabControl1)
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabIncludes As System.Windows.Forms.TabPage
    Friend WithEvents tabCurrFile As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents tabErrors As System.Windows.Forms.TabPage
    Friend WithEvents tabOutput As System.Windows.Forms.TabPage

End Class
