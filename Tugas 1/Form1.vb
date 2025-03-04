Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProces.Click
        Dim nip As Long
        If Not Long.TryParse(txtNip.Text, nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim nama As String = txtNama.Text
        Dim fakultas As String = cbFakultas.Text
        Dim jurusan As String = cbJurusan.Text

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub
End Class
