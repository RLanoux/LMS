Public Class frmAuthorMtc

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnMain_Click(sender As System.Object, e As System.EventArgs) Handles btnMain.Click
        frmMain.Show()
        frmMain.BringToFront()
        Me.Hide()
    End Sub

    Private Sub btnBkMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnBkMtc.Click
        frmBookMtc.Show()
        frmBookMtc.BringToFront()
        Me.Hide()
    End Sub

    Private Sub btnClMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnClMtc.Click
        frmClientMtc.Show()
        frmClientMtc.BringToFront()
        Me.Hide()
    End Sub

    Private Sub btnCiCo_Click(sender As System.Object, e As System.EventArgs) Handles btnCiCo.Click
        frmCiCo.Show()
        frmCiCo.BringToFront()
        Me.Hide()
    End Sub

    Private Sub btnAuthorMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnAuthorMtc.Click
    End Sub

    Private Sub btnPubMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnPubMtc.Click
        frmPubMtc.Show()
        frmPubMtc.BringToFront()
        Me.Hide()
    End Sub
End Class