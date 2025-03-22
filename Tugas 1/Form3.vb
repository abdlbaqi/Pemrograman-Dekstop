Public Class Form3

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNip.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""

        'membersihkan selection pada dataGrid
        DataGridView1.ClearSelection()
        'membuat kursor kembali ke posisi txtNip
        txtNip.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (DataGridView1.SelectedRows().Count > 0) Then
            Dim selectedRows As DataGridViewRow = DataGridView1.SelectedRows(0)
            selectedRows.Cells(0).Value = txtNip.Text
            selectedRows.Cells(1).Value = txtNama.Text
            selectedRows.Cells(2).Value = txtAlamat.Text

            DataGridView1.Refresh()
        Else
            DataGridView1.Rows.Add(txtNip.Text, txtNama.Text, txtAlamat.Text)

        End If

        'menambahkan data pada masing2 text filed kedalam data gridview
        btnNew.PerformClick()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.Rows(e.RowIndex).Selected = True
        txtNip.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        txtNama.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        txtAlamat.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedRows As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim res As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data dengan NIP " + selectedRows.Cells(0).Value + "?", "konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (res = Windows.Forms.DialogResult.Yes) Then
            DataGridView1.Rows.Remove(selectedRows)
        End If
    End Sub
End Class