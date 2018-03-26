Public Class TallyXMLRequests
    Shared ReadOnly Property GetAllLedgers As String
        Get
            Dim R As String = My.Resources.GetAllLedgerRequest
            Return R.Replace("<<version>>", My.Settings.TallyVersion)
        End Get
    End Property
End Class
