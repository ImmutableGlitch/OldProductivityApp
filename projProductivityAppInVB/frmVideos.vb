﻿Public Class frmVideos

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub frmVideos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMenu.Show()
    End Sub

    Private Sub frmVideos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(39, 40, 34)
    End Sub
End Class