Imports System.IO

Public Class frmGame
    Dim pointerArray As Integer = 0

    Dim arrGameName(49) As String 'Increase array limit once it is reached. Array lists
    Dim arrGameLoc(49) As String
    Dim arrPic(49) As String

    Dim GameLocList As String = "GameLoc.txt" 'Text file locations in root dir
    Dim GameNameList As String = "GameName.txt"
    Dim PicList As String = "Pic.txt"

    Private Sub frmGames_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMenu.Show()
    End Sub

    Private Sub frmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAdd.Top = (Me.Height \ 2) - (pnlAdd.Height \ 2)
        pnlAdd.Left = (Me.Width \ 2) - (pnlAdd.Width \ 2)

        pnlEdit.Top = (Me.Height \ 2) - (pnlEdit.Height \ 2)
        pnlEdit.Left = (Me.Width \ 2) - (pnlEdit.Width \ 2)

        pnlAdd.Hide()
        pnlEdit.Hide()

        Me.BackColor = Color.FromArgb(39, 40, 34)   'Add colour scheme option
        flo.BackColor = Color.FromArgb(48, 47, 44)

        flo.FlowDirection = FlowDirection.TopDown
        flo.WrapContents = True
        flo.AutoScroll = True

        ReadTextFile()
    End Sub

    Public Sub ReadTextFile()
        pointerArray = 0

        For i = 0 To arrGameLoc.GetUpperBound(0)
            arrGameLoc(i) = Nothing
            arrGameName(i) = Nothing
            arrPic(i) = Nothing
        Next

        Dim strReadPicList() As String = IO.File.ReadAllLines(PicList)
        For x As Integer = 0 To strReadPicList.GetLength(0) - 1
            arrPic(x) = strReadPicList(x)
        Next

        Dim strGameNameList() As String = IO.File.ReadAllLines(GameNameList)
        For x As Integer = 0 To strGameNameList.GetLength(0) - 1
            arrGameName(x) = strGameNameList(x)
        Next

        Dim strGameLocList() As String = IO.File.ReadAllLines(GameLocList)
        For x As Integer = 0 To strGameLocList.GetLength(0) - 1
            arrGameLoc(x) = strGameLocList(x)
            GenerateButtons(arrGameName(x))
            pointerArray = pointerArray + 1
        Next
    End Sub

    Public Sub GenerateButtons(ByVal strGameName)
        Dim NewGame As New PictureBox
        AddHandler NewGame.Click, AddressOf NewClickEvent

        NewGame.Width = 230
        NewGame.Height = 108

        NewGame.Margin = New Padding(0, 0, 60, 0)

        NewGame.ImageLocation = arrPic(pointerArray)
        NewGame.SizeMode = 1

        NewGame.Tag = pointerArray
        NewGame.BackColor = Color.FromArgb(113, 114, 110)
        flo.Controls.Add(NewGame)

        Dim AmountOfButtons = flo.Controls.OfType(Of PictureBox).Count
        lblNumOfGames.Text = ("Number of Games: " & AmountOfButtons.ToString)

        Dim ButtonLabel As New Label
        ButtonLabel.Text = strGameName
        ButtonLabel.Font = New Drawing.Font("OCR A Std", 7)
        ButtonLabel.ForeColor = Color.White
        flo.Controls.Add(ButtonLabel)
    End Sub

    Private Sub NewClickEvent(sender As Object, e As EventArgs)
        Dim btn As PictureBox
        btn = sender

        Me.Hide()
        frmMenu.Show()

        Try
            MessageBox.Show(btn.ImageLocation.ToString)
            Diagnostics.Process.Start(arrGameLoc(btn.Tag))
        Catch ex As Exception
            MessageBox.Show("Game not found!")
        End Try
    End Sub

    Public Sub UpdateTextFiles()
        If System.IO.File.Exists(GameNameList) = True Then
            System.IO.File.Delete(GameNameList)
        End If

        Using writer As New StreamWriter(GameNameList, True)
            For x As Integer = 0 To pointerArray
                If arrGameName(x) <> "" Then
                    writer.WriteLine(arrGameName(x))
                End If
            Next
        End Using

        If System.IO.File.Exists(GameLocList) = True Then
            System.IO.File.Delete(GameLocList)
        End If

        Using writer2 As New StreamWriter(GameLocList, True)
            For x As Integer = 0 To pointerArray
                If arrGameName(x) <> "" Then
                    writer2.WriteLine(arrGameLoc(x))
                End If
            Next
        End Using

        If System.IO.File.Exists(PicList) = True Then
            System.IO.File.Delete(PicList)
        End If

        Using writer3 As New StreamWriter(PicList, True)
            For x As Integer = 0 To pointerArray
                If arrGameName(x) <> "" Then
                    writer3.WriteLine(arrPic(x))
                End If
            Next
        End Using
    End Sub

    Public Sub testDelete()
        pointerArray = 0

        For i = 0 To arrGameLoc.GetUpperBound(0)
            arrGameName(i) = Nothing
        Next

        Dim strGameNameList() As String = IO.File.ReadAllLines(GameNameList)

        For x As Integer = 0 To strGameNameList.GetLength(0) - 1
            arrGameName(x) = strGameNameList(x)
            GenerateButtons(arrGameName(x))
            pointerArray = pointerArray + 1
        Next
    End Sub

    Public Sub UpdateEditPanel()
        cboSelectGame.Items.Clear()
        cboSelectGame.Text = "..."
        txtNameEdit.Text = "..."
        txtLocEdit.Text = "..."
        picEditPanel.Image = Nothing
        picEditPanel.ImageLocation = Nothing

        For i As Integer = 0 To pointerArray - 1
            cboSelectGame.Items.Add(arrGameName(i))
        Next

        btnSaveEditPanel.Enabled = False
        btnDeleteEditPanel.Enabled = False
        btnEditImage.Enabled = False
        btnLocationEdit.Enabled = False
        btnEnlarge.Enabled = False
    End Sub

#Region "Panel buttons"

    Private Sub btnCloseEditPanel_Click(sender As Object, e As EventArgs) Handles btnCloseEditPanel.Click
        pnlEdit.Hide()
        btnAddGame.Enabled = True
        btnEdit.Enabled = True
        btnMenu.Enabled = True
        flo.Enabled = True
        btnEnlarge.Enabled = True
    End Sub

    Private Sub btnDeleteEditPanel_Click(sender As Object, e As EventArgs) Handles btnDeleteEditPanel.Click
        Dim pos As Integer = cboSelectGame.SelectedIndex

        If pos < pointerArray Then
            pointerArray = pointerArray - 1

            For index As Integer = pos To pointerArray 'bubble sort algorithm
                arrGameLoc(index) = arrGameLoc(index + 1)
                arrGameName(index) = arrGameName(index + 1)
                arrPic(index) = arrPic(index + 1)
            Next

        End If

        UpdateTextFiles()

        UpdateEditPanel()

        flo.Controls.Clear()
        ReadTextFile()

        pnlEdit.Hide()
        btnAddGame.Enabled = True
        btnEdit.Enabled = True
        btnMenu.Enabled = True
        flo.Enabled = True
        btnEnlarge.Enabled = True
    End Sub

    Private Sub cboSelectGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectGame.SelectedIndexChanged
        btnSaveEditPanel.Enabled = True
        btnDeleteEditPanel.Enabled = True
        btnEditImage.Enabled = True
        btnLocationEdit.Enabled = True
        btnEnlarge.Enabled = True
        txtNameEdit.Text = arrGameName(cboSelectGame.SelectedIndex)
        txtLocEdit.Text = arrGameLoc(cboSelectGame.SelectedIndex)
        picEditPanel.ImageLocation = arrPic(cboSelectGame.SelectedIndex)
    End Sub

    Private Sub btnSaveEditPanel_Click(sender As Object, e As EventArgs) Handles btnSaveEditPanel.Click
        arrGameName(cboSelectGame.SelectedIndex) = txtNameEdit.Text
        arrGameLoc(cboSelectGame.SelectedIndex) = txtLocEdit.Text
        arrPic(cboSelectGame.SelectedIndex) = picEditPanel.ImageLocation

        UpdateTextFiles()

        UpdateEditPanel()

        flo.Controls.Clear()

        ReadTextFile()
    End Sub

    Private Sub btnCloseAddPanel_Click(sender As Object, e As EventArgs) Handles btnCloseAddPanel.Click
        pnlAdd.Hide()
        btnAddGame.Enabled = True
        btnEdit.Enabled = True
        btnMenu.Enabled = True
        flo.Enabled = True
        btnEnlarge.Enabled = True
    End Sub

    Private Sub btnDoneAddPanel_Click(sender As Object, e As EventArgs) Handles btnDoneAddPanel.Click
        If txtName.Text = "" Or txtLocation.Text = "" Then
            MessageBox.Show("You left fields blank!")
        Else
            'Update Arrays
            arrGameName(pointerArray) = txtName.Text
            arrGameLoc(pointerArray) = txtLocation.Text
            arrPic(pointerArray) = picAddPanel.ImageLocation

            'Update text files
            UpdateTextFiles()

            'Update buttons
            flo.Controls.Clear()
            ReadTextFile()

            'Blank the textfields
            txtName.Text = ""
            txtLocation.Text = ""
            picAddPanel.Image = Nothing
            picAddPanel.ImageLocation = Nothing
        End If
    End Sub

#End Region

#Region "Buttons"


    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        ofdAddImage.ShowDialog()
    End Sub

    Private Sub btnEditImage_Click(sender As Object, e As EventArgs) Handles btnEditImage.Click
        ofdEditImage.ShowDialog()
    End Sub

    Private Sub ofdAddImage_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdAddImage.FileOk
        picAddPanel.ImageLocation = "steampix\" + ofdAddImage.SafeFileName
    End Sub

    Private Sub ofdGameLocEdit_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdGameLocEdit.FileOk
        txtLocEdit.Text = ofdGameLocEdit.FileName
    End Sub

    Private Sub ofdGameLocAdd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdGameLocAdd.FileOk
        txtLocation.Text = ofdGameLocAdd.FileName
    End Sub

    Private Sub ofdEditImage_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdEditImage.FileOk
        picEditPanel.ImageLocation = "steampix\" + ofdEditImage.SafeFileName
    End Sub

    Private Sub btnLocationAdd_Click(sender As Object, e As EventArgs) Handles btnLocationAdd.Click
        ofdGameLocAdd.ShowDialog()
    End Sub

    Private Sub btnLocationEdit_Click(sender As Object, e As EventArgs) Handles btnLocationEdit.Click
        ofdGameLocEdit.ShowDialog()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        pnlEdit.Show()
        btnAddGame.Enabled = False
        btnMenu.Enabled = False
        btnEdit.Enabled = False
        btnEnlarge.Enabled = False
        flo.Enabled = False

        UpdateEditPanel()
    End Sub

    Private Sub btnAddGame_Click(sender As Object, e As EventArgs) Handles btnAddGame.Click
        pnlAdd.Show()
        btnAddGame.Enabled = False
        btnEdit.Enabled = False
        btnMenu.Enabled = False
        btnEnlarge.Enabled = False
        flo.Enabled = False
    End Sub

    Private Sub btnMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnMenu.MouseEnter
        btnMenu.Image = My.Resources.menuH
    End Sub

    Private Sub btnMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMenu.MouseLeave
        btnMenu.Image = My.Resources.menu
    End Sub

    Private Sub btnEdit_MouseEnter(sender As Object, e As EventArgs) Handles btnEdit.MouseEnter
        btnEdit.Image = My.Resources.editH
    End Sub

    Private Sub btnEdit_MouseLeave(sender As Object, e As EventArgs) Handles btnEdit.MouseLeave
        btnEdit.Image = My.Resources.edit
    End Sub

    Private Sub btnAddGame_MouseEnter(sender As Object, e As EventArgs) Handles btnAddGame.MouseEnter
        btnAddGame.Image = My.Resources.addH
    End Sub

    Private Sub btnAddGame_MouseLeave(sender As Object, e As EventArgs) Handles btnAddGame.MouseLeave
        btnAddGame.Image = My.Resources.add
    End Sub

    Private Sub btnEnlarge_Click(sender As Object, e As EventArgs) Handles btnEnlarge.Click
        If (Me.Size <> New System.Drawing.Size(850, 478)) Then
            Me.Size = New System.Drawing.Size(850, 478) 'Form size
            lblNumOfGames.Location = New System.Drawing.Point(334, 14) 'Number of games label position
            flo.Size = New System.Drawing.Size(826, 419) 'Flow control size
            btnMenu.Location = New System.Drawing.Point(805, 6) 'menu button location
            btnEnlarge.Location = New System.Drawing.Point(766, 6) ' enlarge button location
        Else
            Me.Size = New System.Drawing.Size(1420, 866)
            lblNumOfGames.Location = New System.Drawing.Point(667, 10)
            flo.Size = New System.Drawing.Size(1396, 810)
            btnMenu.Location = New System.Drawing.Point(1375, 6)
            btnEnlarge.Location = New System.Drawing.Point(1336, 6)
        End If

        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)

        pnlAdd.Top = (Me.Height \ 2) - (pnlAdd.Height \ 2)
        pnlAdd.Left = (Me.Width \ 2) - (pnlAdd.Width \ 2)

        pnlEdit.Top = (Me.Height \ 2) - (pnlEdit.Height \ 2)
        pnlEdit.Left = (Me.Width \ 2) - (pnlEdit.Width \ 2)
    End Sub

    Private Sub btnEnlarge_MouseEnter(sender As Object, e As EventArgs) Handles btnEnlarge.MouseEnter
        btnEnlarge.Image = My.Resources.enlargeH
    End Sub

    Private Sub btnEnlarge_MouseLeave(sender As Object, e As EventArgs) Handles btnEnlarge.MouseLeave
        btnEnlarge.Image = My.Resources.enlarge
    End Sub

    Private Sub flo_MouseEnter(sender As Object, e As EventArgs) Handles flo.MouseEnter
        flo.Focus() 'provides mouse scrolling!
    End Sub

    Private Sub frmGame_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        flo.Focus() 'provides mouse scrolling!
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Diagnostics.Process.Start("Z:\Games\Installed")
        Catch ex As Exception
            MessageBox.Show("Game not found!")
        End Try
    End Sub

#End Region
End Class