Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Form.Opacity = 1.0
        Form.Enabled = True
        Me.Close()
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        If vgInputField.Text.Length = 0 Then
            MsgBox("You must enter a name for the VoiceGroup!")
        Else
            Dim dbCon As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyVoiceDB.mdb")
            dbCon.Open()
            Dim queryString As String
            Dim inputString As String = vgInputField.Text
            Try
                queryString = "SELECT VoiceGroup FROM mvdb WHERE VoiceGroup = '" + inputString.Replace(" ", "_") + "';"

                Dim query As New OleDb.OleDbCommand(queryString)
                query.Connection = dbCon

                If String.IsNullOrEmpty(query.ExecuteScalar) Then

                    queryString = "CREATE TABLE " + inputString.Replace(" ", "_") + " (ID int IDENTITY(1,1) NOT NULL, VoiceNote varchar);"
                    query = New OleDb.OleDbCommand(queryString)
                    query.Connection = dbCon
                    query.ExecuteNonQuery()

                    queryString = "INSERT INTO mvdb(VoiceGroup) VALUES('" + inputString.Replace(" ", "_") + "');"
                    query = New OleDb.OleDbCommand(queryString)
                    query.Connection = dbCon
                    query.ExecuteNonQuery()


                    Form.createBtn(inputString)
                    Form.Enabled = True
                    Form.Opacity = 1.0
                    Me.Close()

                Else
                    MsgBox("This voicegroup already exists!!")
                End If
            Catch ex As Exception
                MsgBox("VoiceGroup names can only contain letters A-Z, numbers 0-9, and spaces. Try again.")
                vgInputField.Text = ""
            Finally
                dbCon.Close()
            End Try

        End If

    End Sub
End Class