Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .ColumnCount = 4

            For Each c In .Columns
                c.sortmode = DataGridViewColumnSortMode.NotSortable
            Next

            .RowCount = 5
            With .Rows(1)
                .Cells(0).Value = 123
                .Cells(1).Value = 234
            End With
        End With

    End Sub
End Class
