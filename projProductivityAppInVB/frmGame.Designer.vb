<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.ofdEditImage = New System.Windows.Forms.OpenFileDialog()
        Me.ofdGameLocAdd = New System.Windows.Forms.OpenFileDialog()
        Me.ofdGameLocEdit = New System.Windows.Forms.OpenFileDialog()
        Me.ofdAddImage = New System.Windows.Forms.OpenFileDialog()
        Me.btnEditImage = New System.Windows.Forms.Button()
        Me.btnLocationEdit = New System.Windows.Forms.Button()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.picEditPanel = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSelectGame = New System.Windows.Forms.ComboBox()
        Me.txtLocEdit = New System.Windows.Forms.TextBox()
        Me.txtNameEdit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSaveEditPanel = New System.Windows.Forms.Button()
        Me.btnDeleteEditPanel = New System.Windows.Forms.Button()
        Me.btnCloseEditPanel = New System.Windows.Forms.Button()
        Me.pnlAdd = New System.Windows.Forms.Panel()
        Me.btnLocationAdd = New System.Windows.Forms.Button()
        Me.picAddPanel = New System.Windows.Forms.PictureBox()
        Me.btnDoneAddPanel = New System.Windows.Forms.Button()
        Me.btnCloseAddPanel = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flo = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNumOfGames = New System.Windows.Forms.Label()
        Me.btnEnlarge = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.btnAddGame = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlEdit.SuspendLayout()
        CType(Me.picEditPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdd.SuspendLayout()
        CType(Me.picAddPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEnlarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdEditImage
        '
        Me.ofdEditImage.InitialDirectory = "\"
        '
        'ofdGameLocAdd
        '
        Me.ofdGameLocAdd.InitialDirectory = "C:\"
        '
        'ofdGameLocEdit
        '
        Me.ofdGameLocEdit.InitialDirectory = "C:\"
        '
        'ofdAddImage
        '
        Me.ofdAddImage.InitialDirectory = "\"
        '
        'btnEditImage
        '
        Me.btnEditImage.Location = New System.Drawing.Point(153, 198)
        Me.btnEditImage.Name = "btnEditImage"
        Me.btnEditImage.Size = New System.Drawing.Size(75, 23)
        Me.btnEditImage.TabIndex = 16
        Me.btnEditImage.Text = "Edit Image"
        Me.btnEditImage.UseVisualStyleBackColor = True
        '
        'btnLocationEdit
        '
        Me.btnLocationEdit.Location = New System.Drawing.Point(310, 162)
        Me.btnLocationEdit.Name = "btnLocationEdit"
        Me.btnLocationEdit.Size = New System.Drawing.Size(59, 20)
        Me.btnLocationEdit.TabIndex = 15
        Me.btnLocationEdit.Text = "Browse"
        Me.btnLocationEdit.UseVisualStyleBackColor = True
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.picEditPanel)
        Me.pnlEdit.Controls.Add(Me.btnEditImage)
        Me.pnlEdit.Controls.Add(Me.btnLocationEdit)
        Me.pnlEdit.Controls.Add(Me.Label6)
        Me.pnlEdit.Controls.Add(Me.cboSelectGame)
        Me.pnlEdit.Controls.Add(Me.txtLocEdit)
        Me.pnlEdit.Controls.Add(Me.txtNameEdit)
        Me.pnlEdit.Controls.Add(Me.Label4)
        Me.pnlEdit.Controls.Add(Me.Label5)
        Me.pnlEdit.Controls.Add(Me.btnSaveEditPanel)
        Me.pnlEdit.Controls.Add(Me.btnDeleteEditPanel)
        Me.pnlEdit.Controls.Add(Me.btnCloseEditPanel)
        Me.pnlEdit.Location = New System.Drawing.Point(12, 37)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(388, 374)
        Me.pnlEdit.TabIndex = 18
        '
        'picEditPanel
        '
        Me.picEditPanel.Location = New System.Drawing.Point(73, 227)
        Me.picEditPanel.Name = "picEditPanel"
        Me.picEditPanel.Size = New System.Drawing.Size(230, 108)
        Me.picEditPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEditPanel.TabIndex = 17
        Me.picEditPanel.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(12, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Select Game:"
        '
        'cboSelectGame
        '
        Me.cboSelectGame.FormattingEnabled = True
        Me.cboSelectGame.Location = New System.Drawing.Point(15, 45)
        Me.cboSelectGame.Name = "cboSelectGame"
        Me.cboSelectGame.Size = New System.Drawing.Size(354, 21)
        Me.cboSelectGame.TabIndex = 13
        '
        'txtLocEdit
        '
        Me.txtLocEdit.Location = New System.Drawing.Point(15, 162)
        Me.txtLocEdit.Name = "txtLocEdit"
        Me.txtLocEdit.Size = New System.Drawing.Size(288, 20)
        Me.txtLocEdit.TabIndex = 12
        '
        'txtNameEdit
        '
        Me.txtNameEdit.Location = New System.Drawing.Point(15, 107)
        Me.txtNameEdit.Name = "txtNameEdit"
        Me.txtNameEdit.Size = New System.Drawing.Size(354, 20)
        Me.txtNameEdit.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(12, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Name of Game:"
        '
        'btnSaveEditPanel
        '
        Me.btnSaveEditPanel.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSaveEditPanel.Location = New System.Drawing.Point(132, 344)
        Me.btnSaveEditPanel.Name = "btnSaveEditPanel"
        Me.btnSaveEditPanel.Size = New System.Drawing.Size(47, 23)
        Me.btnSaveEditPanel.TabIndex = 8
        Me.btnSaveEditPanel.Text = "Save"
        Me.btnSaveEditPanel.UseVisualStyleBackColor = False
        '
        'btnDeleteEditPanel
        '
        Me.btnDeleteEditPanel.Location = New System.Drawing.Point(194, 344)
        Me.btnDeleteEditPanel.Name = "btnDeleteEditPanel"
        Me.btnDeleteEditPanel.Size = New System.Drawing.Size(48, 23)
        Me.btnDeleteEditPanel.TabIndex = 7
        Me.btnDeleteEditPanel.Text = "Delete"
        Me.btnDeleteEditPanel.UseVisualStyleBackColor = True
        '
        'btnCloseEditPanel
        '
        Me.btnCloseEditPanel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCloseEditPanel.Location = New System.Drawing.Point(362, 5)
        Me.btnCloseEditPanel.Name = "btnCloseEditPanel"
        Me.btnCloseEditPanel.Size = New System.Drawing.Size(21, 23)
        Me.btnCloseEditPanel.TabIndex = 6
        Me.btnCloseEditPanel.Text = "X"
        Me.btnCloseEditPanel.UseVisualStyleBackColor = False
        '
        'pnlAdd
        '
        Me.pnlAdd.Controls.Add(Me.btnLocationAdd)
        Me.pnlAdd.Controls.Add(Me.picAddPanel)
        Me.pnlAdd.Controls.Add(Me.btnDoneAddPanel)
        Me.pnlAdd.Controls.Add(Me.btnCloseAddPanel)
        Me.pnlAdd.Controls.Add(Me.txtLocation)
        Me.pnlAdd.Controls.Add(Me.txtName)
        Me.pnlAdd.Controls.Add(Me.btnAddImage)
        Me.pnlAdd.Controls.Add(Me.Label3)
        Me.pnlAdd.Controls.Add(Me.Label2)
        Me.pnlAdd.Location = New System.Drawing.Point(12, 29)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(388, 317)
        Me.pnlAdd.TabIndex = 17
        '
        'btnLocationAdd
        '
        Me.btnLocationAdd.Location = New System.Drawing.Point(306, 104)
        Me.btnLocationAdd.Name = "btnLocationAdd"
        Me.btnLocationAdd.Size = New System.Drawing.Size(59, 20)
        Me.btnLocationAdd.TabIndex = 16
        Me.btnLocationAdd.Text = "Browse"
        Me.btnLocationAdd.UseVisualStyleBackColor = True
        '
        'picAddPanel
        '
        Me.picAddPanel.Location = New System.Drawing.Point(73, 178)
        Me.picAddPanel.Name = "picAddPanel"
        Me.picAddPanel.Size = New System.Drawing.Size(230, 108)
        Me.picAddPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAddPanel.TabIndex = 7
        Me.picAddPanel.TabStop = False
        '
        'btnDoneAddPanel
        '
        Me.btnDoneAddPanel.BackColor = System.Drawing.Color.PaleGreen
        Me.btnDoneAddPanel.Location = New System.Drawing.Point(151, 292)
        Me.btnDoneAddPanel.Name = "btnDoneAddPanel"
        Me.btnDoneAddPanel.Size = New System.Drawing.Size(75, 23)
        Me.btnDoneAddPanel.TabIndex = 6
        Me.btnDoneAddPanel.Text = "Done"
        Me.btnDoneAddPanel.UseVisualStyleBackColor = False
        '
        'btnCloseAddPanel
        '
        Me.btnCloseAddPanel.BackColor = System.Drawing.Color.IndianRed
        Me.btnCloseAddPanel.Location = New System.Drawing.Point(362, 6)
        Me.btnCloseAddPanel.Name = "btnCloseAddPanel"
        Me.btnCloseAddPanel.Size = New System.Drawing.Size(21, 23)
        Me.btnCloseAddPanel.TabIndex = 5
        Me.btnCloseAddPanel.Text = "X"
        Me.btnCloseAddPanel.UseVisualStyleBackColor = False
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(15, 105)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(288, 20)
        Me.txtLocation.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(350, 20)
        Me.txtName.TabIndex = 3
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(151, 148)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(75, 23)
        Me.btnAddImage.TabIndex = 2
        Me.btnAddImage.Text = "Add Image"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name of Game:"
        '
        'flo
        '
        Me.flo.BackColor = System.Drawing.Color.Lavender
        Me.flo.Location = New System.Drawing.Point(12, 45)
        Me.flo.Name = "flo"
        Me.flo.Size = New System.Drawing.Size(826, 419)
        Me.flo.TabIndex = 20
        '
        'lblNumOfGames
        '
        Me.lblNumOfGames.AutoSize = True
        Me.lblNumOfGames.Font = New System.Drawing.Font("OCR A Std", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfGames.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblNumOfGames.Location = New System.Drawing.Point(334, 14)
        Me.lblNumOfGames.Name = "lblNumOfGames"
        Me.lblNumOfGames.Size = New System.Drawing.Size(261, 20)
        Me.lblNumOfGames.TabIndex = 19
        Me.lblNumOfGames.Text = "Number of Games: 0"
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Image = Global.projProductivityAppInVB.My.Resources.Resources.enlarge
        Me.btnEnlarge.Location = New System.Drawing.Point(766, 6)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(33, 33)
        Me.btnEnlarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEnlarge.TabIndex = 25
        Me.btnEnlarge.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Image = Global.projProductivityAppInVB.My.Resources.Resources.menu
        Me.btnMenu.Location = New System.Drawing.Point(805, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(33, 33)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 24
        Me.btnMenu.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.projProductivityAppInVB.My.Resources.Resources.edit
        Me.btnEdit.Location = New System.Drawing.Point(61, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(33, 33)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.TabStop = False
        '
        'btnAddGame
        '
        Me.btnAddGame.Image = Global.projProductivityAppInVB.My.Resources.Resources.add
        Me.btnAddGame.Location = New System.Drawing.Point(21, 6)
        Me.btnAddGame.Name = "btnAddGame"
        Me.btnAddGame.Size = New System.Drawing.Size(33, 33)
        Me.btnAddGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddGame.TabIndex = 22
        Me.btnAddGame.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(712, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Games Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddGame)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.pnlAdd)
        Me.Controls.Add(Me.flo)
        Me.Controls.Add(Me.lblNumOfGames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGame"
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        CType(Me.picEditPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdd.ResumeLayout(False)
        Me.pnlAdd.PerformLayout()
        CType(Me.picAddPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEnlarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnEdit As System.Windows.Forms.PictureBox
    Friend WithEvents ofdEditImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdGameLocAdd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdGameLocEdit As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdAddImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAddGame As System.Windows.Forms.PictureBox
    Friend WithEvents picEditPanel As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditImage As System.Windows.Forms.Button
    Friend WithEvents btnLocationEdit As System.Windows.Forms.Button
    Friend WithEvents pnlEdit As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSelectGame As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocEdit As System.Windows.Forms.TextBox
    Friend WithEvents txtNameEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSaveEditPanel As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEditPanel As System.Windows.Forms.Button
    Friend WithEvents btnCloseEditPanel As System.Windows.Forms.Button
    Friend WithEvents pnlAdd As System.Windows.Forms.Panel
    Friend WithEvents btnLocationAdd As System.Windows.Forms.Button
    Friend WithEvents picAddPanel As System.Windows.Forms.PictureBox
    Friend WithEvents btnDoneAddPanel As System.Windows.Forms.Button
    Friend WithEvents btnCloseAddPanel As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents flo As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblNumOfGames As System.Windows.Forms.Label
    Friend WithEvents btnEnlarge As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
