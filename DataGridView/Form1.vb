Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim col As MyDataGridViewCell = New MyDataGridViewCell()
        Dim c As DataGridViewColumn

        With DataGridView1
            .ColumnCount = 4

            For Each c In .Columns
                c.SortMode = DataGridViewColumnSortMode.NotSortable
                c.CellTemplate = col
            Next

            .RowCount = 5
            With .Rows(1)
                .Cells(0).Value = 123
                .Cells(0).Style.BackColor = Color.Red
                .Cells(0).Style.SelectionForeColor = Color.Black

                .Cells(1).Value = 234
                .Cells(1).Style.SelectionForeColor = Color.Red
            End With
        End With

    End Sub
End Class
