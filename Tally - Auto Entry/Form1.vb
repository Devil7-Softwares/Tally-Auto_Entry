
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Function SendReqst(ByVal pWebRequstStr As String) As String
        Dim lResponseStr As String = ""
        Dim lResult As String = ""
        Try
            Dim lTallyLocalHost As String = "http://localhost:9000"
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
            Throw
        End Try

        lResult = lResponseStr
        Return lResult
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim lLedgerResponse As String = SendReqst(TextBox1.Text)
        RichTextBox1.Text = (lLedgerResponse)
    End Sub

End Class

Public Class Ledger

    Public Sub New()
    End Sub

    Public Property ledgerName As String

    Public Property parentName As String

    Public Property openingBalance As String
End Class
