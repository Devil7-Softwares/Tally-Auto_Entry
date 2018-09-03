'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml

Namespace Classes
    Public Class TallyIO
#Region "Variables"
        Dim Ledgers_ As New List(Of String)
        Dim CompanyName_ As String = ""
#End Region

#Region "Properties"
        ReadOnly Property Ledgers As List(Of String)
            Get
                Return Ledgers_
            End Get
        End Property

        ReadOnly Property CompanyName As String
            Get
                Return CompanyName_
            End Get
        End Property
#End Region

#Region "Private Subs & Functions"
        Async Function SendRequestToTally(ByVal pWebRequstStr As String) As Threading.Tasks.Task(Of Objects.Response)
            Dim lResponseStr As String = ""
            Dim lResult As String = ""
            Try
                Dim lTallyLocalHost As String = My.Settings.TallyHostURL
                Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(lTallyLocalHost), HttpWebRequest)
                httpWebRequest.Method = "POST"
                httpWebRequest.ContentType = "application/x-www-form-urlencoded"
                Dim lStrmWritr As Stream = Await httpWebRequest.GetRequestStreamAsync()
                Dim Bytes As Byte() = (New Text.ASCIIEncoding).GetBytes(pWebRequstStr)
                Await lStrmWritr.WriteAsync(Bytes, 0, Bytes.Length)
                lStrmWritr.Close()
                Dim lhttpResponse As HttpWebResponse = CType(Await httpWebRequest.GetResponseAsync(), HttpWebResponse)
                Dim lreceiveStream As Stream = lhttpResponse.GetResponseStream()
                Dim lStreamReader As StreamReader = New StreamReader(lreceiveStream, Encoding.UTF8)
                lResponseStr = lStreamReader.ReadToEnd()
                lhttpResponse.Close()
                lStreamReader.Close()
            Catch ex As Exception
                Return New Objects.Response(ex.Message, False)
            End Try
            lResult = lResponseStr
            Return New Objects.Response(lResult)
        End Function

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
                    Me.CompanyName_ = m_xmlr.ReadInnerXml
                ElseIf m_xmlr.Name = "LEDGER" Then
                    Dim Names As String() = ReadLedger(m_xmlr.ReadInnerXml)
                    For Each i As String In Names
                        Ledgers.Add(ProcessString(i))
                    Next
                End If
            End While
            m_xmlr.Close()
            Me.Ledgers_ = Ledgers
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
#End Region

        Friend Async Function LoadAllLedgers() As Threading.Tasks.Task(Of Boolean)
            Try
                Dim Response As Objects.Response = Await SendRequestToTally(Requests.GetAllLedgers)
                If Response.Status = True Then
                    ReadXML(Response.Data)
                    Return True
                End If
            Catch ex As Exception
                MsgBox("Error on loading ledgers." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End Try
            Return False
        End Function

    End Class
End Namespace