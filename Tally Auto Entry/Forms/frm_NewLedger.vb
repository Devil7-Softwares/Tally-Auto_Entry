Public Class frm_NewLedger

    Dim Tally As Classes.TallyIO

    Sub New(ByVal Tally As Classes.TallyIO)
        InitializeComponent()
        Me.Tally = Tally
    End Sub

    Private Async Sub LoadGroups()
        Invoke(Sub()
                   ControlBox = False
                   ProgressPanel1.Visible = True
               End Sub)
        Await Tally.LoadAllGroups()
        If Tally.Groups.Count > 0 Then
            For Each i As String In Tally.Groups
                If Not cmb_Group.Properties.Items.Contains(i) Then cmb_Group.Properties.Items.Add(i)
            Next
            cmb_Group.Properties.Sorted = True
            cmb_Group.SelectedIndex = 0
        End If
        Invoke(Sub()
                   ControlBox = True
                   ProgressPanel1.Visible = False
               End Sub)
    End Sub

    Private Sub frm_NewLedger_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadGroups()
    End Sub

    Private Async Sub btn_CreateLedger_Click(sender As Object, e As EventArgs) Handles btn_CreateLedger.Click
        Me.Invoke(Sub()
                      For Each i As Control In Controls
                          i.Enabled = False
                      Next
                      Cursor = Cursors.WaitCursor
                  End Sub)
        Dim Response As Objects.Response = Await Tally.CreateLedger(txt_Ledger.Text, cmb_Group.SelectedItem, txt_OpeningBalance.Value)
        If Response.Status And Response.Created > 0 Then
            MsgBox("Successfully created ledger.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        Else
            Classes.PublicFunctions.WriteErrorResponse(Response)
        End If
        Me.Invoke(Sub()
                      For Each i As Control In Controls
                          i.Enabled = True
                      Next
                      Cursor = Cursors.Default
                  End Sub)
    End Sub

End Class