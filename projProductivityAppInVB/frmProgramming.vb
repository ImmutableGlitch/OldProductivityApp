Public Class frmProgramming
    Dim path As String = "E:\Hobbies\Programming"

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub frmProgramming_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMenu.Show()
    End Sub

    Private Sub frmProgramming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(39, 40, 34)
        ComboBox1.SelectedItem = "All"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("explorer " & path, AppWinStyle.NormalFocus)
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim Item As String
        Item = "explorer " + ListBox1.SelectedItem
        'MessageBox.Show(bookItem)
        Shell(Item, AppWinStyle.NormalFocus)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem.ToString = "All") Then
            ListBox1.Items.Clear()
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path)
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path)
                ListBox1.Items.Add(foundFile)
            Next
        ElseIf (ComboBox1.SelectedItem.ToString = "Java") Then
            ListBox1.Items.Clear()
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path & "\Java Training")
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path & "\Java Training")
                ListBox1.Items.Add(foundFile)
            Next
        ElseIf (ComboBox1.SelectedItem.ToString = "Scripting") Then
            ListBox1.Items.Clear()
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path & "\JavaScript for Web Designers")
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path & "\JavaScript for Web Designers")
                ListBox1.Items.Add(foundFile)
            Next
        ElseIf (ComboBox1.SelectedItem.ToString = ".Net") Then
            ListBox1.Items.Clear()
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path & "\.NET Training")
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path & "\.NET Training")
                ListBox1.Items.Add(foundFile)
            Next
        ElseIf (ComboBox1.SelectedItem.ToString = "Other") Then
            ListBox1.Items.Clear()
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path & "\iOS App Development Essential Training")
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path & "\iOS App Development Essential Training")
                ListBox1.Items.Add(foundFile)
            Next
            'iOS above
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path & "\Other")
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path & "\Other")
                ListBox1.Items.Add(foundFile)
            Next
            'Other folder above
        ElseIf (ComboBox1.SelectedItem.ToString = "PHP MySQL") Then
            ListBox1.Items.Clear()
            For Each foundFolder As String In My.Computer.FileSystem.GetDirectories(path & "\PHP MySQL")
                ListBox1.Items.Add(foundFolder)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path & "\PHP MySQL")
                ListBox1.Items.Add(foundFile)
            Next
        End If

    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        If (ListBox2.SelectedItem.ToString = "Udemy Courses") Then
            Dim Item As String
            Item = "explorer " + (path & "\Other\Udemy Courses")
            Shell(Item, AppWinStyle.NormalFocus)
        Else
            Dim url As String
            url = ListBox2.SelectedItem.ToString
            System.Diagnostics.Process.Start(url)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("Z:\Programs\Installed\Sublime Text 3\sublime_text.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Shell("Z:\Programs\Installed\NetBeans 8.0\bin\netbeans64.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("Z:\Programs\Installed\Eclipse Luna\eclipse\eclipse.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("Z:\Programs\Installed\Microsoft Visual Studio 12.0\Common7\IDE\WDExpress.exe", AppWinStyle.NormalFocus)
    End Sub
End Class