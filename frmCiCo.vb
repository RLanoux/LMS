Public Class frmCiCo

    Private Sub Change(ByVal s As String)
        Select Case (s)
            Case "Loan"
                btnLoan.Enabled = True
                btnItemsReturn.Enabled = False
            Case "Return"
                btnItemsReturn.Enabled = True
                btnLoan.Enabled = False
            Case Else
                'Do Nothing
        End Select
    End Sub

    Private Sub Commit()
        'Clear the card number box
        txtCardNumber.Clear()

        'Clear the ISBN box
        txtISBN.Clear()

        'Clear the big label
        lblCheckedOut.Text = String.Empty

        If (rdoLoan.Checked) Then
            'Messagebox that the loan has been processed
            MessageBox.Show("Check in has been processed!" & vbCrLf & "Tell 'em to go home and read!", _
                            "LMS - Library Management System", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.None)
        Else
            'Messagebox that the loan has been processed
            MessageBox.Show("Return has been processed!" & vbCrLf & "Good on ya mate, f'r readin'!", _
                            "LMS - Library Management System", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.None)
        End If
    End Sub

    Private Sub ItemsReturn()
        'Preserve the card number text box

        'Copy the ISBN to the big label
        lblCheckedOut.Text = lblCheckedOut.Text & txtISBN.Text & vbCrLf

        'Clear the ISBN textbox
        txtISBN.Clear()

        'Enable the Commit button
        btnCommit.Enabled = True
    End Sub

    Private Sub Loan()
        'Preserve the card number text box

        'Copy the ISBN to the big label
        lblCheckedOut.Text = lblCheckedOut.Text & txtISBN.Text & vbCrLf

        'Clear the ISBN textbox
        txtISBN.Clear()

        'Enable the Commit button
        btnCommit.Enabled = True
    End Sub

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
    End Sub

    Private Sub btnAuthorMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnAuthorMtc.Click
        frmAuthorMtc.Show()
        frmAuthorMtc.BringToFront()
        Me.Hide()
    End Sub

    Private Sub btnPubMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnPubMtc.Click
        frmPubMtc.Show()
        frmPubMtc.BringToFront()
        Me.Hide()
    End Sub

    Private Sub rdoLoan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoLoan.CheckedChanged
        If (rdoLoan.Checked) Then
            Change("Loan")
        Else
            Change("Return")
        End If
    End Sub

    Private Sub btnLoan_Click(sender As System.Object, e As System.EventArgs) Handles btnLoan.Click
        Loan()
    End Sub

    Private Sub btnItemsReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnItemsReturn.Click
        ItemsReturn()
    End Sub

    Private Sub btnCommit_Click(sender As System.Object, e As System.EventArgs) Handles btnCommit.Click
        Commit()
    End Sub

    Private Sub txtISBN_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtISBN.TextChanged
        btnCommit.Enabled = False
    End Sub
End Class