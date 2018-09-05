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

Namespace Classes
    Public Class Requests

        Shared Function GetReport(ByVal ReportName As String)
            Return My.Resources.ReportRequest.Replace("<<version>>", My.Settings.TallyVersion).Replace("<<report>>", ReportName)
        End Function

        Shared Function GetAllLedgers() As String
            Return GetReport("List of Accounts")
        End Function

        Shared Function GetAllGroups() As String
            Return GetReport("Group Summary")
        End Function

        Shared Function CreateLedger(ByVal CompanyName As String, ByVal LedgerName As String, ByVal Group As String, ByVal Balance As Integer)
            Return My.Resources.MastersRequest.Replace("<<company>>", CompanyName).Replace("<<ledger>>", LedgerName).Replace("<<group>>", Group).Replace("<<balance>>", Balance)
        End Function

    End Class
End Namespace