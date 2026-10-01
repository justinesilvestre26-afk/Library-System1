Public Class Form1
    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchPanel(New Dashboard())
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        switchPanel(New Books())
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        switchPanel(New Members())
    End Sub

    Private Sub btnBorrowReturn_Click(sender As Object, e As EventArgs) Handles btnBorrowReturn.Click
        switchPanel(New BorrowReturn())
    End Sub

    Private Sub btnOverdue_Click(sender As Object, e As EventArgs) Handles btnOverdue.Click
        switchPanel(New OverdueBooks)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        switchPanel(New Reports())
    End Sub

    Private Sub btnSetings_Click(sender As Object, e As EventArgs) Handles btnSetings.Click
        switchPanel(New Settings())
    End Sub
End Class