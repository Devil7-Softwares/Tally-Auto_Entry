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

Namespace Objects
    Public Class VoucherEntry

#Region "Subs"
        Sub New(ByVal LedgerName As String, ByVal Effect As Effect, ByVal Amount As Double)
            Me.LedgerName = LedgerName
            Me.Effect = Effect
            Me.Amount = Amount
        End Sub
#End Region

#Region "Properties"
        ReadOnly Property LedgerName As String

        ReadOnly Property Effect As Effect

        ReadOnly Property Amount As Integer
#End Region
    End Class
End Namespace