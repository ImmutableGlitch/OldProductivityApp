Imports System.IO

Public Class frmBooks
    Dim dir As String = "E:\Data\Dropbox\Dropbox\Books"
    Dim FileLocation As DirectoryInfo = New DirectoryInfo(dir)
    Dim fi As List(Of FileInfo) = New List(Of FileInfo)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("explorer " & dir, AppWinStyle.NormalFocus)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(39, 40, 34)
        scanBooks()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        scanBooks()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub frmBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMenu.Show()
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim bookItem As String
        bookItem = "explorer " + fi(ListBox1.SelectedIndex).FullName
        MessageBox.Show(bookItem)
        Shell(bookItem, AppWinStyle.NormalFocus)
    End Sub

    Public Sub scanBooks()
        Dim pointer As Integer = 0

        fi.Clear()

        For Each File In FileLocation.GetFiles()
            If (File IsNot Nothing) Then
                fi.Add(File)
            End If
        Next

        For Each i As FileInfo In fi
            ListBox1.Items.Add(i.Name)
        Next

    End Sub

End Class
