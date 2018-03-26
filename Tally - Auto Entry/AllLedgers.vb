Imports System.Xml

Public Class AllLedgers
    Property Ledgers As List(Of String)
    Property CompanyName As String
    Friend Sub GetAll()
        Dim RequestData As String = PublicFunctions.SendRequestToTally(TallyXMLRequests.GetAllLedgers)
        ReadXML(RequestData)
    End Sub
    Private Sub ReadXML(ByVal RequestData As String)
        Dim Ledgers As New List(Of String)
        Dim m_xmlr As New XmlTextReader(New IO.MemoryStream(System.Text.Encoding.ASCII.GetBytes(RequestData)))
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        m_xmlr.Read()
        While Not m_xmlr.EOF
            m_xmlr.Read()
            If Not m_xmlr.IsStartElement() Then
                Continue While
            End If
            If m_xmlr.Name = "SVCURRENTCOMPANY" Then
                Me.CompanyName = m_xmlr.ReadInnerXml
            ElseIf m_xmlr.Name = "LEDGER" Then
                Dim Names As String() = ReadLedger(m_xmlr.ReadInnerXml)
                For Each i As String In Names
                    Ledgers.Add(ProcessString(i))
                Next
            End If
        End While
        m_xmlr.Close()
        Me.Ledgers = Ledgers
    End Sub
    Private Function ReadLedger(ByVal LedgerData As String) As String()
        LedgerData = "<ROOT>" & LedgerData & "</ROOT>"
        Dim Names As New List(Of String)
        Dim doc As New XmlDocument()
        doc.LoadXml(LedgerData)
        Dim root As XmlElement = doc.DocumentElement
        Dim elements As XmlNodeList = root.ChildNodes
        For i As Integer = 0 To elements.Count - 1
            If elements(i).Name = "LANGUAGENAME.LIST" Then
                For Each e As XmlNode In elements(i).ChildNodes
                    If e.Name = "NAME.LIST" Then
                        For Each n As XmlNode In e.ChildNodes
                            If n.Name = "NAME" Then
                                Names.Add(n.InnerXml)
                            End If
                        Next
                    End If
                Next
            End If
        Next
        Return Names.ToArray
    End Function
End Class
