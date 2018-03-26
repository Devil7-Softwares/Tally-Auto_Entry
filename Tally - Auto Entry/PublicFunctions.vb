Imports System.Net
Imports System.IO
Imports System.Text
Module PublicFunctions
    Public Function SendRequestToTally(ByVal pWebRequstStr As String) As String
        Dim lResponseStr As String = ""
        Dim lResult As String = ""
        Try
            Dim lTallyLocalHost As String = My.Settings.TallyHostURL
            Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(lTallyLocalHost), HttpWebRequest)
            httpWebRequest.Method = "POST"
            httpWebRequest.ContentLength = CLng(pWebRequstStr.Length)
            httpWebRequest.ContentType = "application/x-www-form-urlencoded"
            Dim lStrmWritr As StreamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
            lStrmWritr.Write(pWebRequstStr)
            lStrmWritr.Close()
            Dim lhttpResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
            Dim lreceiveStream As Stream = lhttpResponse.GetResponseStream()
            Dim lStreamReader As StreamReader = New StreamReader(lreceiveStream, Encoding.UTF8)
            lResponseStr = lStreamReader.ReadToEnd()
            lhttpResponse.Close()
            lStreamReader.Close()
        Catch __unusedException1__ As Exception
            Return __unusedException1__.Message
        End Try
        lResult = lResponseStr
        Return lResult
    End Function
    Public Sub LedgerCreateXml(ByVal ledger As Ledger)
        Try
            Dim xmlstc As String = ""
            xmlstc = "<ENVELOPE>" & vbCrLf
            xmlstc = xmlstc & "<HEADER>" & vbCrLf
            xmlstc = xmlstc & "<TALLYREQUEST>Import Data</TALLYREQUEST>" & vbCrLf
            xmlstc = xmlstc & "</HEADER>" & vbCrLf
            xmlstc = xmlstc & "<BODY>" & vbCrLf
            xmlstc = xmlstc & "<IMPORTDATA>" & vbCrLf
            xmlstc = xmlstc & "<REQUESTDESC>" & vbCrLf
            xmlstc = xmlstc & "<REPORTNAME>All Masters</REPORTNAME>" & vbCrLf
            xmlstc = xmlstc & "</REQUESTDESC>" & vbCrLf
            xmlstc = xmlstc & "<REQUESTDATA>" & vbCrLf
            xmlstc = xmlstc & "<TALLYMESSAGE xmlns:UDF=" & """" & "TallyUDF" & """>" & vbCrLf
            xmlstc = xmlstc & "<LEDGER NAME=" & """" & ledger.ledgerName & """ Action =" & """" & "Create" & """>" & vbCrLf
            xmlstc = xmlstc & "<NAME>" & ledger.ledgerName & "</NAME>" & vbCrLf
            xmlstc = xmlstc & "<PARENT>" & ledger.parentName & "</PARENT>" & vbCrLf
            xmlstc = xmlstc & "<OPENINGBALANCE>" & ledger.openingBalance & "</OPENINGBALANCE>" & vbCrLf
            xmlstc = xmlstc & "<ISBILLWISEON>Yes</ISBILLWISEON>" & vbCrLf
            xmlstc = xmlstc & "</LEDGER>" & vbCrLf
            xmlstc = xmlstc & "</TALLYMESSAGE>" & vbCrLf
            xmlstc = xmlstc & "</REQUESTDATA>" & vbCrLf
            xmlstc = xmlstc & "</IMPORTDATA>" & vbCrLf
            xmlstc = xmlstc & "</BODY>"
            xmlstc = xmlstc & "</ENVELOPE>"
            Dim xml As String = xmlstc
            Dim lLedgerResponse As String = SendRequestToTally(xml)
            MessageBox.Show(lLedgerResponse)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function ProcessString(ByVal Text As String) As String
        Dim R As String = Text
        R = R.Replace("&amp;", "&")
        Return R
    End Function
    Public Function CEffect(ByVal Effect As String) As Effect
        Dim E As Effect = D7Automation.Effect.Dr
        If Effect = "Dr." Then
            E = D7Automation.Effect.Dr
        ElseIf Effect = "Cr." Then
            E = D7Automation.Effect.Cr
        End If
        Return E
    End Function
End Module
