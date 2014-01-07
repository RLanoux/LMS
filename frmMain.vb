Imports Microsoft.SqlServer


Public Class frmMain

    Dim m_oConn As SqlClient.SqlConnection = Nothing

    Private Sub ButtonChange(ByVal s As String)
        Select Case (s)
            Case "Main"
                grpMain.Visible = True
                grpAuthorMtc.Visible = False
                grpBookMtc.Visible = False
                grpCiCo.Visible = False
                grpClientMtc.Visible = False
                grpPubMtc.Visible = False

            Case "BookMtc"
                grpMain.Visible = False
                grpAuthorMtc.Visible = False
                grpBookMtc.Visible = True
                grpCiCo.Visible = False
                grpClientMtc.Visible = False
                grpPubMtc.Visible = False

            Case "ClientMtc"
                grpMain.Visible = False
                grpAuthorMtc.Visible = False
                grpBookMtc.Visible = False
                grpCiCo.Visible = False
                grpClientMtc.Visible = True
                grpPubMtc.Visible = False

            Case "CheckInCO"
                grpMain.Visible = False
                grpAuthorMtc.Visible = False
                grpBookMtc.Visible = False
                grpCiCo.Visible = True
                grpClientMtc.Visible = False
                grpPubMtc.Visible = False

            Case "AuthorMtc"
                grpMain.Visible = False
                grpAuthorMtc.Visible = True
                grpBookMtc.Visible = False
                grpCiCo.Visible = False
                grpClientMtc.Visible = False
                grpPubMtc.Visible = False

            Case "PubMtc"
                grpMain.Visible = False
                grpAuthorMtc.Visible = False
                grpBookMtc.Visible = False
                grpCiCo.Visible = False
                grpClientMtc.Visible = False
                grpPubMtc.Visible = True
            Case "null"
        End Select
    End Sub

    Private Sub AddBook(ByVal sISBN As String, _
                        ByVal sTitle As String, _
                        ByVal sYear As String, _
                        ByVal sFiction As Boolean, _
                        ByVal sGenre As String, _
                        ByVal sPages As Integer, _
                        ByVal sAge As String, _
                        ByVal sDewey As String, _
                        ByVal sSynopsis As String)

        If InitializeDatabases() Then
            Dim sSql As String = "INSERT INTO Book (ISBN, Title, Year, Fiction, Genre, Pages, Age, Dewey Decimal, Synopsis)"
        End If
    End Sub

    Private Function InitializeDatabases() As Boolean
        Dim sConn As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Library;Data Source=202-SP-SVR"

        'This sets up a pointer to the SQL server for the Transform Manager database.
        If m_oConn Is Nothing Then
            m_oConn = New SqlClient.SqlConnection(sConn)
        End If

        If m_oConn.State = 1 Then  'open already
        Else
            Try

                m_oConn.Open()

            Catch ex As Exception
                m_oConn = Nothing
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End If

        Return True
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnMain_Click(sender As System.Object, e As System.EventArgs) Handles btnMain.Click
        ButtonChange("Main")
    End Sub

    Private Sub btnBkMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnBkMtc.Click
        ButtonChange("BookMtc")
    End Sub

    Private Sub btnClMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnClMtc.Click
        ButtonChange("ClientMtc")
    End Sub

    Private Sub btnCiCo_Click(sender As System.Object, e As System.EventArgs) Handles btnCiCo.Click
        ButtonChange("CheckInCO")
    End Sub

    Private Sub btnAuthorMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnAuthorMtc.Click
        ButtonChange("AuthorMtc")
    End Sub

    Private Sub btnPubMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnPubMtc.Click
        ButtonChange("PubMtc")
    End Sub

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        If InitializeDatabases() Then
            MessageBox.Show("Connection Successful!")
        Else
            MessageBox.Show("Connection Failed!")
        End If
    End Sub
End Class
