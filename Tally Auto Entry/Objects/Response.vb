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

Imports System.Xml

Namespace Objects
    Public Class Response

        Sub New(ByVal Data As String)
            Me.Data = Data
            ReadXML(Data)
        End Sub

        Sub New(ByVal Data As String, ByVal Status As Boolean)
            Me.Status = True
            Me.Data = Data
            ReadXML(Data)
        End Sub

        Property Data As String = ""
        Property Status As Boolean = False
        Property Created As Integer = -1

        Private Sub ReadXML(ByVal XML As String)
            Dim Doc As New XmlDocument()
            Doc.LoadXml(XML)

            'Status
            For Each i As XmlNode In Doc.GetElementsByTagName("STATUS")
                If Not String.IsNullOrEmpty(i.InnerText) Then Integer.TryParse(i.InnerText, Status)
            Next

            'No of Ledgers Created
            For Each i As XmlNode In Doc.GetElementsByTagName("CREATED")
                If Not String.IsNullOrEmpty(i.InnerText) Then Integer.TryParse(i.InnerText, Created)
            Next
        End Sub

    End Class
End Namespace