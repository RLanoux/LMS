<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookMtc
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
        Me.grpBookMtc = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSynopsis = New System.Windows.Forms.TextBox()
        Me.txtDewey = New System.Windows.Forms.TextBox()
        Me.cboxAgeGrp = New System.Windows.Forms.ComboBox()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.cboxFiction = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.btnBkMtcDelete = New System.Windows.Forms.Button()
        Me.btnBkMtcInquire = New System.Windows.Forms.Button()
        Me.btnBkMtcEdit = New System.Windows.Forms.Button()
        Me.btnBkMtcAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPubMtc = New System.Windows.Forms.Button()
        Me.btnAuthorMtc = New System.Windows.Forms.Button()
        Me.btnCiCo = New System.Windows.Forms.Button()
        Me.btnClMtc = New System.Windows.Forms.Button()
        Me.btnBkMtc = New System.Windows.Forms.Button()
        Me.grpBookMtc.SuspendLayout()
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
        'grpBookMtc
        '
        Me.grpBookMtc.Controls.Add(Me.Label9)
        Me.grpBookMtc.Controls.Add(Me.Label8)
        Me.grpBookMtc.Controls.Add(Me.Label7)
        Me.grpBookMtc.Controls.Add(Me.Label6)
        Me.grpBookMtc.Controls.Add(Me.Label5)
        Me.grpBookMtc.Controls.Add(Me.Label4)
        Me.grpBookMtc.Controls.Add(Me.Label3)
        Me.grpBookMtc.Controls.Add(Me.Label2)
        Me.grpBookMtc.Controls.Add(Me.Label1)
        Me.grpBookMtc.Controls.Add(Me.txtSynopsis)
        Me.grpBookMtc.Controls.Add(Me.txtDewey)
        Me.grpBookMtc.Controls.Add(Me.cboxAgeGrp)
        Me.grpBookMtc.Controls.Add(Me.txtPages)
        Me.grpBookMtc.Controls.Add(Me.txtGenre)
        Me.grpBookMtc.Controls.Add(Me.cboxFiction)
        Me.grpBookMtc.Controls.Add(Me.txtYear)
        Me.grpBookMtc.Controls.Add(Me.txtTitle)
        Me.grpBookMtc.Controls.Add(Me.txtISBN)
        Me.grpBookMtc.Controls.Add(Me.btnBkMtcDelete)
        Me.grpBookMtc.Controls.Add(Me.btnBkMtcInquire)
        Me.grpBookMtc.Controls.Add(Me.btnBkMtcEdit)
        Me.grpBookMtc.Controls.Add(Me.btnBkMtcAdd)
        Me.grpBookMtc.Location = New System.Drawing.Point(143, 12)
        Me.grpBookMtc.Name = "grpBookMtc"
        Me.grpBookMtc.Size = New System.Drawing.Size(329, 438)
        Me.grpBookMtc.TabIndex = 14
        Me.grpBookMtc.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Synopsis:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Dewey Decimal:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Age Group:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Length:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Genre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Fiction? :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Year Published:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Title:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ISBN:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSynopsis
        '
        Me.txtSynopsis.Location = New System.Drawing.Point(86, 229)
        Me.txtSynopsis.Multiline = True
        Me.txtSynopsis.Name = "txtSynopsis"
        Me.txtSynopsis.Size = New System.Drawing.Size(237, 169)
        Me.txtSynopsis.TabIndex = 12
        '
        'txtDewey
        '
        Me.txtDewey.Location = New System.Drawing.Point(86, 203)
        Me.txtDewey.Name = "txtDewey"
        Me.txtDewey.Size = New System.Drawing.Size(237, 20)
        Me.txtDewey.TabIndex = 11
        '
        'cboxAgeGrp
        '
        Me.cboxAgeGrp.FormattingEnabled = True
        Me.cboxAgeGrp.Items.AddRange(New Object() {"All", "Children", "Teens", "Adults", "Seniors"})
        Me.cboxAgeGrp.Location = New System.Drawing.Point(86, 176)
        Me.cboxAgeGrp.Name = "cboxAgeGrp"
        Me.cboxAgeGrp.Size = New System.Drawing.Size(237, 21)
        Me.cboxAgeGrp.TabIndex = 10
        Me.cboxAgeGrp.Text = "(Select one.)"
        '
        'txtPages
        '
        Me.txtPages.Location = New System.Drawing.Point(86, 150)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.Size = New System.Drawing.Size(237, 20)
        Me.txtPages.TabIndex = 9
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(86, 124)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(237, 20)
        Me.txtGenre.TabIndex = 8
        '
        'cboxFiction
        '
        Me.cboxFiction.FormattingEnabled = True
        Me.cboxFiction.Items.AddRange(New Object() {"Fiction", "Non-Fiction"})
        Me.cboxFiction.Location = New System.Drawing.Point(86, 97)
        Me.cboxFiction.Name = "cboxFiction"
        Me.cboxFiction.Size = New System.Drawing.Size(237, 21)
        Me.cboxFiction.TabIndex = 7
        Me.cboxFiction.Text = "(Select one.)"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(86, 71)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(237, 20)
        Me.txtYear.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(86, 45)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(237, 20)
        Me.txtTitle.TabIndex = 5
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(86, 19)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(237, 20)
        Me.txtISBN.TabIndex = 4
        '
        'btnBkMtcDelete
        '
        Me.btnBkMtcDelete.Location = New System.Drawing.Point(249, 404)
        Me.btnBkMtcDelete.Name = "btnBkMtcDelete"
        Me.btnBkMtcDelete.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcDelete.TabIndex = 3
        Me.btnBkMtcDelete.Text = "&Delete"
        Me.btnBkMtcDelete.UseVisualStyleBackColor = True
        '
        'btnBkMtcInquire
        '
        Me.btnBkMtcInquire.Location = New System.Drawing.Point(169, 404)
        Me.btnBkMtcInquire.Name = "btnBkMtcInquire"
        Me.btnBkMtcInquire.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcInquire.TabIndex = 2
        Me.btnBkMtcInquire.Text = "&Inquire"
        Me.btnBkMtcInquire.UseVisualStyleBackColor = True
        '
        'btnBkMtcEdit
        '
        Me.btnBkMtcEdit.Location = New System.Drawing.Point(86, 404)
        Me.btnBkMtcEdit.Name = "btnBkMtcEdit"
        Me.btnBkMtcEdit.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcEdit.TabIndex = 1
        Me.btnBkMtcEdit.Text = "&Edit"
        Me.btnBkMtcEdit.UseVisualStyleBackColor = True
        '
        'btnBkMtcAdd
        '
        Me.btnBkMtcAdd.Location = New System.Drawing.Point(6, 404)
        Me.btnBkMtcAdd.Name = "btnBkMtcAdd"
        Me.btnBkMtcAdd.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcAdd.TabIndex = 0
        Me.btnBkMtcAdd.Text = "&Add"
        Me.btnBkMtcAdd.UseVisualStyleBackColor = True
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
        Me.btnBkMtc.Enabled = False
        Me.btnBkMtc.Location = New System.Drawing.Point(12, 38)
        Me.btnBkMtc.Name = "btnBkMtc"
        Me.btnBkMtc.Size = New System.Drawing.Size(125, 20)
        Me.btnBkMtc.TabIndex = 8
        Me.btnBkMtc.Text = "Book Maintenance"
        Me.btnBkMtc.UseVisualStyleBackColor = True
        '
        'frmBookMtc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.grpBookMtc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPubMtc)
        Me.Controls.Add(Me.btnAuthorMtc)
        Me.Controls.Add(Me.btnCiCo)
        Me.Controls.Add(Me.btnClMtc)
        Me.Controls.Add(Me.btnBkMtc)
        Me.Name = "frmBookMtc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Maintenance"
        Me.grpBookMtc.ResumeLayout(False)
        Me.grpBookMtc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents grpBookMtc As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPubMtc As System.Windows.Forms.Button
    Friend WithEvents btnAuthorMtc As System.Windows.Forms.Button
    Friend WithEvents btnCiCo As System.Windows.Forms.Button
    Friend WithEvents btnClMtc As System.Windows.Forms.Button
    Friend WithEvents btnBkMtc As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcDelete As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcInquire As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcEdit As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcAdd As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSynopsis As System.Windows.Forms.TextBox
    Friend WithEvents txtDewey As System.Windows.Forms.TextBox
    Friend WithEvents cboxAgeGrp As System.Windows.Forms.ComboBox
    Friend WithEvents txtPages As System.Windows.Forms.TextBox
    Friend WithEvents txtGenre As System.Windows.Forms.TextBox
    Friend WithEvents cboxFiction As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
End Class
