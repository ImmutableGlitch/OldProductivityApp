Public Class frmTest
    Dim pointerArray As Integer = 0
    Dim arrGameName(49) As String
    Dim GameNameList As String = "GameName.txt"

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) \ 2
        Dim y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) \ 2

        Me.Location = New Point(x, y)

        Dim strGameNameList() As String = IO.File.ReadAllLines(GameNameList)

        For i As Integer = 0 To strGameNameList.GetUpperBound(0)
            arrGameName(i) = strGameNameList(i)
            pointerArray = pointerArray + 1
            TextBox1.Text = TextBox1.Text + i.ToString + ": " + " " + arrGameName(i).ToString + System.Environment.NewLine
        Next

        lblPointer.Text = pointerArray.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If CInt(txtChoice.Text) < pointerArray Then

            For i As Integer = CInt(txtChoice.Text) To pointerArray 'bubble sort algorithm
                arrGameName(i) = arrGameName(i + 1)
            Next

            pointerArray = pointerArray - 1
        End If

        TextBox1.Text = ""

        For x As Integer = 0 To pointerArray - 1
            TextBox1.Text = TextBox1.Text + x.ToString + ": " + " " + arrGameName(x).ToString + System.Environment.NewLine
        Next

        lblPointer.Text = pointerArray.ToString

    End Sub
End Class