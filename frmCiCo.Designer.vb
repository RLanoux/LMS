<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCiCo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.grpCiCo = New System.Windows.Forms.GroupBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.lblCheckedOut = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnItemsReturn = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.rdoReturn = New System.Windows.Forms.RadioButton()
        Me.rdoLoan = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPubMtc = New System.Windows.Forms.Button()
        Me.btnAuthorMtc = New System.Windows.Forms.Button()
        Me.btnCiCo = New System.Windows.Forms.Button()
        Me.btnClMtc = New System.Windows.Forms.Button()
        Me.btnBkMtc = New System.Windows.Forms.Button()
        Me.grpCiCo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(12, 12)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(125, 20)
        Me.btnMain.TabIndex = 15
        Me.btnMain.Text = "Entry Screen"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'grpCiCo
        '
        Me.grpCiCo.Controls.Add(Me.btnCommit)
        Me.grpCiCo.Controls.Add(Me.lblCheckedOut)
        Me.grpCiCo.Controls.Add(Me.Label3)
        Me.grpCiCo.Controls.Add(Me.btnItemsReturn)
        Me.grpCiCo.Controls.Add(Me.btnLoan)
        Me.grpCiCo.Controls.Add(Me.Label2)
        Me.grpCiCo.Controls.Add(Me.txtISBN)
        Me.grpCiCo.Controls.Add(Me.rdoReturn)
        Me.grpCiCo.Controls.Add(Me.rdoLoan)
        Me.grpCiCo.Controls.Add(Me.Label1)
        Me.grpCiCo.Controls.Add(Me.txtCardNumber)
        Me.grpCiCo.Location = New System.Drawing.Point(143, 12)
        Me.grpCiCo.Name = "grpCiCo"
        Me.grpCiCo.Size = New System.Drawing.Size(329, 438)
        Me.grpCiCo.TabIndex = 14
        Me.grpCiCo.TabStop = False
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(205, 406)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(118, 26)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "&Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'lblCheckedOut
        '
        Me.lblCheckedOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckedOut.Location = New System.Drawing.Point(9, 173)
        Me.lblCheckedOut.Name = "lblCheckedOut"
        Me.lblCheckedOut.Size = New System.Drawing.Size(314, 230)
        Me.lblCheckedOut.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Books Checked Out:"
        '
        'btnItemsReturn
        '
        Me.btnItemsReturn.Enabled = False
        Me.btnItemsReturn.Location = New System.Drawing.Point(205, 105)
        Me.btnItemsReturn.Name = "btnItemsReturn"
        Me.btnItemsReturn.Size = New System.Drawing.Size(118, 32)
        Me.btnItemsReturn.TabIndex = 7
        Me.btnItemsReturn.Text = "&Return"
        Me.btnItemsReturn.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Location = New System.Drawing.Point(84, 105)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(115, 32)
        Me.btnLoan.TabIndex = 6
        Me.btnLoan.Text = "&Loan"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ISBN Number:"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(84, 79)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(239, 20)
        Me.txtISBN.TabIndex = 4
        '
        'rdoReturn
        '
        Me.rdoReturn.AutoSize = True
        Me.rdoReturn.Location = New System.Drawing.Point(205, 28)
        Me.rdoReturn.Name = "rdoReturn"
        Me.rdoReturn.Size = New System.Drawing.Size(57, 17)
        Me.rdoReturn.TabIndex = 3
        Me.rdoReturn.Text = "Return"
        Me.rdoReturn.UseVisualStyleBackColor = True
        '
        'rdoLoan
        '
        Me.rdoLoan.AutoSize = True
        Me.rdoLoan.Checked = True
        Me.rdoLoan.Location = New System.Drawing.Point(84, 28)
        Me.rdoLoan.Name = "rdoLoan"
        Me.rdoLoan.Size = New System.Drawing.Size(49, 17)
        Me.rdoLoan.TabIndex = 2
        Me.rdoLoan.TabStop = True
        Me.rdoLoan.Text = "Loan"
        Me.rdoLoan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Card Number:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(84, 53)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(239, 20)
        Me.txtCardNumber.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 20)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit System"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPubMtc
        '
        Me.btnPubMtc.Location = New System.Drawing.Point(12, 142)
        Me.btnPubMtc.Name = "btnPubMtc"
        Me.btnPubMtc.Size = New System.Drawing.Size(125, 20)
        Me.btnPubMtc.TabIndex = 12
        Me.btnPubMtc.Text = "Publisher Maintenance"
        Me.btnPubMtc.UseVisualStyleBackColor = True
        '
        'btnAuthorMtc
        '
        Me.btnAuthorMtc.Location = New System.Drawing.Point(12, 116)
        Me.btnAuthorMtc.Name = "btnAuthorMtc"
        Me.btnAuthorMtc.Size = New System.Drawing.Size(125, 20)
        Me.btnAuthorMtc.TabIndex = 11
        Me.btnAuthorMtc.Text = "Author Maintenance"
        Me.btnAuthorMtc.UseVisualStyleBackColor = True
        '
        'btnCiCo
        '
        Me.btnCiCo.Enabled = False
        Me.btnCiCo.Location = New System.Drawing.Point(12, 90)
        Me.btnCiCo.Name = "btnCiCo"
        Me.btnCiCo.Size = New System.Drawing.Size(125, 20)
        Me.btnCiCo.TabIndex = 10
        Me.btnCiCo.Text = "Check Out / Return"
        Me.btnCiCo.UseVisualStyleBackColor = True
        '
        'btnClMtc
        '
        Me.btnClMtc.Location = New System.Drawing.Point(12, 64)
        Me.btnClMtc.Name = "btnClMtc"
        Me.btnClMtc.Size = New System.Drawing.Size(125, 20)
        Me.btnClMtc.TabIndex = 9
        Me.btnClMtc.Text = "Client Maintenance"
        Me.btnClMtc.UseVisualStyleBackColor = True
        '
        'btnBkMtc
        '
        Me.btnBkMtc.Location = New System.Drawing.Point(12, 38)
        Me.btnBkMtc.Name = "btnBkMtc"
        Me.btnBkMtc.Size = New System.Drawing.Size(125, 20)
        Me.btnBkMtc.TabIndex = 8
        Me.btnBkMtc.Text = "Book Maintenance"
        Me.btnBkMtc.UseVisualStyleBackColor = True
        '
        'frmCiCo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.grpCiCo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPubMtc)
        Me.Controls.Add(Me.btnAuthorMtc)
        Me.Controls.Add(Me.btnCiCo)
        Me.Controls.Add(Me.btnClMtc)
        Me.Controls.Add(Me.btnBkMtc)
        Me.Name = "frmCiCo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Out/Return"
        Me.grpCiCo.ResumeLayout(False)
        Me.grpCiCo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents grpCiCo As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPubMtc As System.Windows.Forms.Button
    Friend WithEvents btnAuthorMtc As System.Windows.Forms.Button
    Friend WithEvents btnCiCo As System.Windows.Forms.Button
    Friend WithEvents btnClMtc As System.Windows.Forms.Button
    Friend WithEvents btnBkMtc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents rdoReturn As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLoan As System.Windows.Forms.RadioButton
    Friend WithEvents btnItemsReturn As System.Windows.Forms.Button
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents lblCheckedOut As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
