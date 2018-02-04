Public Class Form3
    Public deleteFlagEnabled As Boolean = False

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Form4.initialize(Label1.Text)
        Form4.Show()
        Me.Enabled = False
        Me.Opacity = 0.8

    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Form.Enabled = True
        Form.Opacity = 1
        Me.Close()
    End Sub

    Public Sub createVoiceNote(name As String)

        Dim Btn As New Button
        Dim myFont As New Font("Verdana", 14, FontStyle.Bold)
        AddHandler Btn.Click, AddressOf voiceNoteClick
        Btn.Font = myFont
        Btn.Text = name
        Btn.Width = 500
        Btn.Height = 75
        Btn.BackColor = Color.PeachPuff
        Btn.AutoEllipsis = True

        tlp.Controls.Add(Btn)
    End Sub

    Private Sub voiceNoteClick(sender As Object, e As EventArgs)
        If Not deleteFlagEnabled Then
            Dim SAPI As Object = CreateObject("SAPI.spvoice")
            Me.Enabled = False
            Try
                SAPI.voice = SAPI.getVoices.item(4)
            Catch exp As Exception
                SAPI.voice = SAPI.getVoices.item(0)
            End Try

            SAPI.speak(sender.Text)
            Me.Enabled = True
        Else
            Form5.initialize(Label1.Text, sender, 1)
        End If

    End Sub


    Public Sub initialize(id As String)
        deltLabel.Hide()
        Label1.Text = id
        id = id.Replace(" ", "_")

        Dim minID As Integer
        Dim rowCount As Integer
        Dim queryString As String

        Dim dbCon As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyVoiceDB.mdb")
        dbCon.Open()

        queryString = "SELECT Count(VoiceNote) FROM " + id + ";"
        Dim query As New OleDb.OleDbCommand(queryString)
        query.Connection = dbCon
        rowCount = query.ExecuteScalar

        queryString = "SELECT COUNT(ID) FROM " + id + ";"
        query = New OleDb.OleDbCommand(queryString)
        query.Connection = dbCon

        If Not query.ExecuteScalar = 0 Then
            queryString = "SELECT MIN(ID) FROM " + id + ";"
            query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            minID = query.ExecuteScalar()
        End If

        Dim i As Integer = 0
        While i < rowCount
            queryString = "SELECT VoiceNote FROM " + id + " WHERE ID=" + minID.ToString() + ";"
            query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            If Not String.IsNullOrEmpty(query.ExecuteScalar) Then
                createVoiceNote(query.ExecuteScalar)
                i += 1
            End If
            minID += 1
        End While

        dbCon.Close()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If Not deleteFlagEnabled Then
            deleteFlagEnabled = True
            deltLabel.Show()
            Me.BackColor = Color.DarkRed
        Else
            deleteFlagEnabled = False
            deltLabel.Hide()
            Me.BackColor = Color.IndianRed
        End If

    End Sub
End Class