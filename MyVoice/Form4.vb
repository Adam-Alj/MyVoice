Public Class Form4
    Public vgName As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Form3.Enabled = True
        Form3.Opacity = 1
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Dim dbCon As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyVoiceDB.mdb")
        dbCon.Open()

        Dim queryString As String
        Dim newText As String = TextBox1.Text.Replace("'", "''")
        If Not String.IsNullOrEmpty(newText) Then
            queryString = "SELECT VoiceNote FROM " + vgName + " WHERE VoiceNote = '" + newText + "';"

            Dim query As New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            If String.IsNullOrEmpty(query.ExecuteScalar) Then
                queryString = "INSERT INTO " + vgName + "(VoiceNote) VALUES('" + newText + "');"
                query = New OleDb.OleDbCommand(queryString)
                query.Connection = dbCon
                query.ExecuteNonQuery()
                Form3.createVoiceNote(TextBox1.Text)
                cancelBtn.PerformClick()
            Else
                MsgBox("VoiceNote already exists!")
            End If
            dbCon.Close()
        Else
            MsgBox("You must give the VoiceNote something to say!")
        End If

    End Sub

    Public Sub initialize(name As String)
        vgName = name.Replace(" ", "_")
    End Sub

End Class