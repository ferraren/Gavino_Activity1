﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer

        a = txtfirstnumber.Text
        b = txtsecondnumber.Text

        Label1.Text = a + b


    End Sub
End Class
