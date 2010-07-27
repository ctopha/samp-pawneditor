<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuildOptions))
        Me.gb_afl = New System.Windows.Forms.GroupBox
        Me.b_aflbrws = New System.Windows.Forms.Button
        Me.t_afl = New System.Windows.Forms.TextBox
        Me.rb_afl_custom = New System.Windows.Forms.RadioButton
        Me.rb_afl_pwn = New System.Windows.Forms.RadioButton
        Me.rb_afl_default = New System.Windows.Forms.RadioButton
        Me.groupBox4 = New System.Windows.Forms.GroupBox
        Me.t_cargs = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.b_cpathbrws = New System.Windows.Forms.Button
        Me.t_cpath = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.gb_afl.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_afl
        '
        Me.gb_afl.Controls.Add(Me.b_aflbrws)
        Me.gb_afl.Controls.Add(Me.t_afl)
        Me.gb_afl.Controls.Add(Me.rb_afl_custom)
        Me.gb_afl.Controls.Add(Me.rb_afl_pwn)
        Me.gb_afl.Controls.Add(Me.rb_afl_default)
        Me.gb_afl.Location = New System.Drawing.Point(12, 92)
        Me.gb_afl.Name = "gb_afl"
        Me.gb_afl.Size = New System.Drawing.Size(385, 71)
        Me.gb_afl.TabIndex = 4
        Me.gb_afl.TabStop = False
        Me.gb_afl.Text = "Place .amx file in..."
        '
        'b_aflbrws
        '
        Me.b_aflbrws.Location = New System.Drawing.Point(304, 38)
        Me.b_aflbrws.Name = "b_aflbrws"
        Me.b_aflbrws.Size = New System.Drawing.Size(75, 23)
        Me.b_aflbrws.TabIndex = 6
        Me.b_aflbrws.Text = "Browse..."
        Me.b_aflbrws.UseVisualStyleBackColor = True
        '
        't_afl
        '
        Me.t_afl.BackColor = System.Drawing.SystemColors.Window
        Me.t_afl.Location = New System.Drawing.Point(78, 41)
        Me.t_afl.Name = "t_afl"
        Me.t_afl.ReadOnly = True
        Me.t_afl.Size = New System.Drawing.Size(220, 21)
        Me.t_afl.TabIndex = 6
        '
        'rb_afl_custom
        '
        Me.rb_afl_custom.AutoSize = True
        Me.rb_afl_custom.Location = New System.Drawing.Point(9, 42)
        Me.rb_afl_custom.Name = "rb_afl_custom"
        Me.rb_afl_custom.Size = New System.Drawing.Size(65, 17)
        Me.rb_afl_custom.TabIndex = 2
        Me.rb_afl_custom.TabStop = True
        Me.rb_afl_custom.Text = "Custom:"
        Me.rb_afl_custom.UseVisualStyleBackColor = True
        '
        'rb_afl_pwn
        '
        Me.rb_afl_pwn.AutoSize = True
        Me.rb_afl_pwn.Location = New System.Drawing.Point(193, 19)
        Me.rb_afl_pwn.Name = "rb_afl_pwn"
        Me.rb_afl_pwn.Size = New System.Drawing.Size(142, 17)
        Me.rb_afl_pwn.TabIndex = 1
        Me.rb_afl_pwn.TabStop = True
        Me.rb_afl_pwn.Text = "Together with PAWN file"
        Me.rb_afl_pwn.UseVisualStyleBackColor = True
        '
        'rb_afl_default
        '
        Me.rb_afl_default.AutoSize = True
        Me.rb_afl_default.Location = New System.Drawing.Point(9, 19)
        Me.rb_afl_default.Name = "rb_afl_default"
        Me.rb_afl_default.Size = New System.Drawing.Size(153, 17)
        Me.rb_afl_default.TabIndex = 0
        Me.rb_afl_default.TabStop = True
        Me.rb_afl_default.Text = "Together with pawncc.exe"
        Me.rb_afl_default.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.t_cargs)
        Me.groupBox4.Controls.Add(Me.label3)
        Me.groupBox4.Controls.Add(Me.b_cpathbrws)
        Me.groupBox4.Controls.Add(Me.t_cpath)
        Me.groupBox4.Controls.Add(Me.label2)
        Me.groupBox4.Location = New System.Drawing.Point(12, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(385, 74)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "General"
        '
        't_cargs
        '
        Me.t_cargs.Location = New System.Drawing.Point(86, 45)
        Me.t_cargs.Name = "t_cargs"
        Me.t_cargs.Size = New System.Drawing.Size(293, 21)
        Me.t_cargs.TabIndex = 4
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 48)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Compiler args:"
        '
        'b_cpathbrws
        '
        Me.b_cpathbrws.Location = New System.Drawing.Point(304, 17)
        Me.b_cpathbrws.Name = "b_cpathbrws"
        Me.b_cpathbrws.Size = New System.Drawing.Size(75, 23)
        Me.b_cpathbrws.TabIndex = 2
        Me.b_cpathbrws.Text = "Browse..."
        Me.b_cpathbrws.UseVisualStyleBackColor = True
        '
        't_cpath
        '
        Me.t_cpath.BackColor = System.Drawing.SystemColors.Window
        Me.t_cpath.Location = New System.Drawing.Point(86, 19)
        Me.t_cpath.Name = "t_cpath"
        Me.t_cpath.ReadOnly = True
        Me.t_cpath.Size = New System.Drawing.Size(212, 21)
        Me.t_cpath.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 22)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Compiler path:"
        '
        'frmBuildOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 173)
        Me.Controls.Add(Me.gb_afl)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuildOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Build Options"
        Me.gb_afl.ResumeLayout(False)
        Me.gb_afl.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_afl As System.Windows.Forms.GroupBox
    Private WithEvents b_aflbrws As System.Windows.Forms.Button
    Private WithEvents t_afl As System.Windows.Forms.TextBox
    Private WithEvents rb_afl_custom As System.Windows.Forms.RadioButton
    Private WithEvents rb_afl_pwn As System.Windows.Forms.RadioButton
    Private WithEvents rb_afl_default As System.Windows.Forms.RadioButton
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents t_cargs As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents b_cpathbrws As System.Windows.Forms.Button
    Private WithEvents t_cpath As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
