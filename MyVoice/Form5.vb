Public Class Form5
    Dim buttonCall As Object
    Dim delType As Integer
    Dim tableName As String

    Sub initialize(text As String, buttonSender As Object, deleteType As Integer)
        If deleteType = 0 Then
            Me.Show()
            Form.Enabled = False
            Label2.Text = text
            buttonCall = buttonSender
            delType = deleteType
            tableName = text.Replace(" ", "_")
        ElseIf deleteType = 1 Then
            Me.Show()
            Form.Enabled = False
            Label2.Text = buttonSender.text
            Label1.Text = "Are you sure you want to delete the VoiceNote:"
            buttonCall = buttonSender
            delType = deleteType
            tableName = text.Replace(" ", "_")
        End If


    End Sub

    Sub deconstruct()
        If delType = 0 Then
            Form.deleteFlagEnabled = False
            Form.deleteInstruction.Hide()
            Form.Enabled = True
            Form.BackColor = Color.LightCoral
            Me.Close()
        ElseIf delType = 1 Then
            Form3.deleteFlagEnabled = False
            Form3.deltLabel.Hide()
            Form3.Enabled = True
            Form3.BackColor = Color.IndianRed
            Me.Close()
        End If
    End Sub

    Private Sub noBtnDel_Click(sender As Object, e As EventArgs) Handles noBtnDel.Click
        deconstruct()
    End Sub

    Private Sub yesBtnDel_Click(sender As Object, e As EventArgs) Handles yesBtnDel.Click
        Dim dbCon As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyVoiceDB.mdb")
        dbCon.Open()

        If delType = 0 Then
            Dim queryString As String = "DROP TABLE " + buttonCall.Text.replace(" ", "_") + ";"
            Dim query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            query.ExecuteNonQuery()

            queryString = "DELETE * FROM mvdb WHERE VoiceGroup = '" + buttonCall.text.Replace(" ", "_") + "';"
            query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            query.ExecuteNonQuery()
        ElseIf delType = 1 Then
            Dim queryString = "DELETE * FROM " + tableName + " WHERE VoiceNote = '" + buttonCall.Text.Replace("'", "''") + "';"
            Dim query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            query.ExecuteNonQuery()
        End If


        dbCon.Close()
        buttonCall.hide()
        deconstruct()
    End Sub
End Class