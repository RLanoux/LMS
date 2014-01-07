<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthorMtc
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
        Me.grpAuthorMtc = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPubMtc = New System.Windows.Forms.Button()
        Me.btnAuthorMtc = New System.Windows.Forms.Button()
        Me.btnCiCo = New System.Windows.Forms.Button()
        Me.btnClMtc = New System.Windows.Forms.Button()
        Me.btnBkMtc = New System.Windows.Forms.Button()
        Me.btnBkMtcDelete = New System.Windows.Forms.Button()
        Me.btnBkMtcInquire = New System.Windows.Forms.Button()
        Me.btnBkMtcEdit = New System.Windows.Forms.Button()
        Me.btnBkMtcAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuthorID = New System.Windows.Forms.TextBox()
        Me.txtAuthorFName = New System.Windows.Forms.TextBox()
        Me.txtAuthorMName = New System.Windows.Forms.TextBox()
        Me.txtAuthorLName = New System.Windows.Forms.TextBox()
        Me.grpAuthorMtc.SuspendLayout()
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
        'grpAuthorMtc
        '
        Me.grpAuthorMtc.Controls.Add(Me.txtAuthorLName)
        Me.grpAuthorMtc.Controls.Add(Me.txtAuthorMName)
        Me.grpAuthorMtc.Controls.Add(Me.txtAuthorFName)
        Me.grpAuthorMtc.Controls.Add(Me.txtAuthorID)
        Me.grpAuthorMtc.Controls.Add(Me.Label4)
        Me.grpAuthorMtc.Controls.Add(Me.Label3)
        Me.grpAuthorMtc.Controls.Add(Me.Label2)
        Me.grpAuthorMtc.Controls.Add(Me.Label1)
        Me.grpAuthorMtc.Controls.Add(Me.btnBkMtcDelete)
        Me.grpAuthorMtc.Controls.Add(Me.btnBkMtcInquire)
        Me.grpAuthorMtc.Controls.Add(Me.btnBkMtcEdit)
        Me.grpAuthorMtc.Controls.Add(Me.btnBkMtcAdd)
        Me.grpAuthorMtc.Location = New System.Drawing.Point(143, 12)
        Me.grpAuthorMtc.Name = "grpAuthorMtc"
        Me.grpAuthorMtc.Size = New System.Drawing.Size(329, 438)
        Me.grpAuthorMtc.TabIndex = 14
        Me.grpAuthorMtc.TabStop = False
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
        Me.btnAuthorMtc.Enabled = False
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
        Me.btnBkMtc.Location = New System.Drawing.Point(12, 38)
        Me.btnBkMtc.Name = "btnBkMtc"
        Me.btnBkMtc.Size = New System.Drawing.Size(125, 20)
        Me.btnBkMtc.TabIndex = 8
        Me.btnBkMtc.Text = "Book Maintenance"
        Me.btnBkMtc.UseVisualStyleBackColor = True
        '
        'btnBkMtcDelete
        '
        Me.btnBkMtcDelete.Location = New System.Drawing.Point(249, 404)
        Me.btnBkMtcDelete.Name = "btnBkMtcDelete"
        Me.btnBkMtcDelete.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcDelete.TabIndex = 7
        Me.btnBkMtcDelete.Text = "&Delete"
        Me.btnBkMtcDelete.UseVisualStyleBackColor = True
        '
        'btnBkMtcInquire
        '
        Me.btnBkMtcInquire.Location = New System.Drawing.Point(169, 404)
        Me.btnBkMtcInquire.Name = "btnBkMtcInquire"
        Me.btnBkMtcInquire.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcInquire.TabIndex = 6
        Me.btnBkMtcInquire.Text = "&Inquire"
        Me.btnBkMtcInquire.UseVisualStyleBackColor = True
        '
        'btnBkMtcEdit
        '
        Me.btnBkMtcEdit.Location = New System.Drawing.Point(86, 404)
        Me.btnBkMtcEdit.Name = "btnBkMtcEdit"
        Me.btnBkMtcEdit.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcEdit.TabIndex = 5
        Me.btnBkMtcEdit.Text = "&Edit"
        Me.btnBkMtcEdit.UseVisualStyleBackColor = True
        '
        'btnBkMtcAdd
        '
        Me.btnBkMtcAdd.Location = New System.Drawing.Point(6, 404)
        Me.btnBkMtcAdd.Name = "btnBkMtcAdd"
        Me.btnBkMtcAdd.Size = New System.Drawing.Size(74, 28)
        Me.btnBkMtcAdd.TabIndex = 4
        Me.btnBkMtcAdd.Text = "&Add"
        Me.btnBkMtcAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Author ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Middle Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Last Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAuthorID
        '
        Me.txtAuthorID.Location = New System.Drawing.Point(86, 16)
        Me.txtAuthorID.Name = "txtAuthorID"
        Me.txtAuthorID.Size = New System.Drawing.Size(237, 20)
        Me.txtAuthorID.TabIndex = 12
        '
        'txtAuthorFName
        '
        Me.txtAuthorFName.Location = New System.Drawing.Point(86, 42)
        Me.txtAuthorFName.Name = "txtAuthorFName"
        Me.txtAuthorFName.Size = New System.Drawing.Size(237, 20)
        Me.txtAuthorFName.TabIndex = 13
        '
        'txtAuthorMName
        '
        Me.txtAuthorMName.Location = New System.Drawing.Point(86, 68)
        Me.txtAuthorMName.Name = "txtAuthorMName"
        Me.txtAuthorMName.Size = New System.Drawing.Size(237, 20)
        Me.txtAuthorMName.TabIndex = 14
        '
        'txtAuthorLName
        '
        Me.txtAuthorLName.Location = New System.Drawing.Point(86, 94)
        Me.txtAuthorLName.Name = "txtAuthorLName"
        Me.txtAuthorLName.Size = New System.Drawing.Size(237, 20)
        Me.txtAuthorLName.TabIndex = 15
        '
        'frmAuthorMtc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.grpAuthorMtc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPubMtc)
        Me.Controls.Add(Me.btnAuthorMtc)
        Me.Controls.Add(Me.btnCiCo)
        Me.Controls.Add(Me.btnClMtc)
        Me.Controls.Add(Me.btnBkMtc)
        Me.Name = "frmAuthorMtc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Author Maintenance"
        Me.grpAuthorMtc.ResumeLayout(False)
        Me.grpAuthorMtc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents grpAuthorMtc As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPubMtc As System.Windows.Forms.Button
    Friend WithEvents btnAuthorMtc As System.Windows.Forms.Button
    Friend WithEvents btnCiCo As System.Windows.Forms.Button
    Friend WithEvents btnClMtc As System.Windows.Forms.Button
    Friend WithEvents btnBkMtc As System.Windows.Forms.Button
    Friend WithEvents txtAuthorLName As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorMName As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorFName As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBkMtcDelete As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcInquire As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcEdit As System.Windows.Forms.Button
    Friend WithEvents btnBkMtcAdd As System.Windows.Forms.Button
End Class
