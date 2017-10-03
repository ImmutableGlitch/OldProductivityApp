<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(28, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 38)
        Me.Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button1.TabIndex = 6
        Me.Button1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(210, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 38)
        Me.Button2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button2.TabIndex = 7
        Me.Button2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(209, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(166, 38)
        Me.Button4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button4.TabIndex = 9
        Me.Button4.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(27, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 38)
        Me.Button3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button3.TabIndex = 8
        Me.Button3.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(209, 141)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(166, 38)
        Me.Button6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button6.TabIndex = 11
        Me.Button6.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(27, 141)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(166, 38)
        Me.Button5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button5.TabIndex = 10
        Me.Button5.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuText
        Me.BackgroundImage = Global.projProductivityAppInVB.My.Resources.Resources.MainMenuBGblue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.PictureBox
End Class
