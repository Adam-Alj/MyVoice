Public Class Form

    Public deleteFlagEnabled As Boolean = False

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()
    End Sub

    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        MsgBox("USE GUIDE" + Chr(13) + "-------------------------------------------" + Chr(13) + "Create groups (VoiceGroups) on the main page to hold your voice notes." + Chr(13) +
               Chr(13) + "VoiceGroups can only be created with letters and/or numbers. Apostrophes and quotation marks are not allowed." + Chr(13) +
               Chr(13) + "Click on the VoiceGroup to bring up your voice notes." + Chr(13) +
               Chr(13) + "Add a new VoiceNote by clicking the (+) symbol at the bottom left of the page." + Chr(13) +
               Chr(13) + "The text for your voice note is what will be spoken back." + Chr(13) +
               Chr(13) + "Once you have created your VoiceNote, simply click on the button and it will speak its contents." + Chr(13) +
               Chr(13) + "VoiceGroup names should be under 22 characters long, anything longer than this might be cut off from view." + Chr(13) +
               Chr(13) + "VoiceNote names should be under 78 characters long, anything longer than this might be cut off from view. However, the entire VoiceNote" +
               " will still be spoken." + Chr(13) + Chr(13) + "Anything longer than 200 characters in either the VoiceNotes or VoiceGroups is not allowed." + Chr(13) + Chr(13) +
               "Delete VoiceGroups by clicking the 'Delete VoiceGroup' button and then selecting the VoiceGroup." + Chr(13) + Chr(13) +
               "Delete VoiceNotes by clicking the (-) button and then selecting the VoiceNote.")
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        deleteInstruction.Hide()
        Dim dbCon As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyVoiceDB.mdb")
        dbCon.Open()

        Dim rowCount As Integer
        Dim minRowID As Integer

        Dim queryString As String
        queryString = "SELECT Count(VoiceGroup) FROM mvdb;"
        Dim query As New OleDb.OleDbCommand(queryString)
        query.Connection = dbCon
        rowCount = query.ExecuteScalar()

        queryString = "SELECT COUNT(ID) FROM mvdb;"
        query = New OleDb.OleDbCommand(queryString)
        query.Connection = dbCon

        If Not query.ExecuteScalar = 0 Then
            queryString = "SELECT MIN(ID) FROM mvdb;"
            query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            minRowID = query.ExecuteScalar()
        End If


        Dim i As Integer = 0
        While i < rowCount
            queryString = "SELECT VoiceGroup FROM mvdb WHERE ID=" + minRowID.ToString() + ";"
            query = New OleDb.OleDbCommand(queryString)
            query.Connection = dbCon
            If Not String.IsNullOrEmpty(query.ExecuteScalar) Then
                createBtn(query.ExecuteScalar.replace("_", " "))
                i += 1
            End If
            minRowID += 1
        End While

        dbCon.Close()
    End Sub

    Private Sub addVGBtn_Click(sender As Object, e As EventArgs) Handles addVGBtn.Click
        Me.Enabled = False
        Me.Opacity = 0.8
        Form2.Show()
    End Sub

    Public Sub createBtn(name As String)
        Dim Btn As New Button
        Dim newFont As New Font("Verdana", 16, FontStyle.Bold)
        AddHandler Btn.Click, AddressOf VoiceGroupBtn_Click

        Btn.BackColor = Color.PeachPuff
        Btn.Font = newFont
        Btn.Text = name
        Btn.Width = 200
        Btn.Height = 100
        Btn.AutoEllipsis = True
        vgGrid.Controls.Add(Btn)
    End Sub


    Public Sub VoiceGroupBtn_Click(sender As Object, e As EventArgs)
        If Not deleteFlagEnabled Then
            Me.Enabled = False
            Me.Opacity = 0.8
            Form3.initialize(sender.Text)
            Form3.Show()
        Else
            Form5.initialize(sender.text, sender, 0)
        End If

    End Sub

    Private Sub deleteVGBTN_Click(sender As Object, e As EventArgs) Handles deleteVGBTN.Click
        If Not deleteFlagEnabled Then
            deleteInstruction.Show()
            deleteFlagEnabled = True
            Me.BackColor = Color.DarkRed
        Else
            deleteFlagEnabled = False
            deleteInstruction.Hide()
            Me.BackColor = Color.LightCoral
        End If
    End Sub
End Class
