Imports System.IO
Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stream As New FileStream(TextBox1.Text, FileMode.Open, FileAccess.ReadWrite)
        Dim values(stream.Length) As Byte
        For i = 0 To stream.Length - 1
            values(i) = stream.ReadByte()
        Next
        For i = 0 To values.Length - 1
            stream.Position = i
            If values(i) + 1 = 256 Then
                stream.WriteByte(0)
            Else
                stream.WriteByte(values(i) + 1)
            End If
        Next
        stream.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim stream As New FileStream(TextBox1.Text, FileMode.Open, FileAccess.ReadWrite)
        Dim values(stream.Length) As Byte
        For i = 0 To stream.Length - 1
            values(i) = stream.ReadByte()
        Next
        For i = 0 To values.Length - 1
            stream.Position = i
            If values(i) - 1 = -1 Then
                stream.WriteByte(255)
            Else
                stream.WriteByte(values(i) - 1)
            End If
        Next
        stream.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim file As New OpenFileDialog
        file.ShowDialog()
        If file.FileName <> "" Then
            TextBox1.Text = file.FileName
        End If
    End Sub
End Class