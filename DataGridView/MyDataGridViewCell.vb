
Imports System.Windows.Forms

Public Class MyDataGridViewCell
    Inherits DataGridViewTextBoxCell

    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, _
                                  cellBounds As Rectangle, rowIndex As Integer, _
                                  cellState As DataGridViewElementStates, value As Object, _
                                  formattedValue As Object, errorText As String, _
                                  cellStyle As DataGridViewCellStyle, _
                                  advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
                                  paintParts As DataGridViewPaintParts)

        Dim pParts As DataGridViewPaintParts = paintParts
        Dim isSelected As Boolean = ((cellState And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected)

        If (isSelected) Then
            graphics.FillRectangle(New SolidBrush(cellStyle.BackColor), cellBounds)
            If (paintParts And DataGridViewPaintParts.Focus) Then
                Dim borderRect As Rectangle = Me.BorderWidths(advancedBorderStyle)
                Dim paintRect As New Rectangle(cellBounds.Left + borderRect.Left, _
                           cellBounds.Top + borderRect.Top, _
                           cellBounds.Width - borderRect.Right, _
                           cellBounds.Height - borderRect.Bottom)
                Dim focusRect As Rectangle = paintRect

                'focusRect.Inflate(-1, -1)
                ControlPaint.DrawFocusRectangle(graphics, focusRect)
                'focusRect.Inflate(-2, -4)
                focusRect.Inflate(-1, -1)
                ControlPaint.DrawFocusRectangle(graphics, focusRect)

                'Dim myPen As Pen = New Pen(Color.Black, 2)
                'myPen.DashStyle = Drawing2D.DashStyle.Dash
                'graphics.DrawRectangle(myPen, focusRect)
            End If
            pParts = paintParts And Not DataGridViewPaintParts.Background
        End If

        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, _
                     cellState, value, formattedValue, errorText, _
                     cellStyle, advancedBorderStyle, pParts)

    End Sub
End Class
