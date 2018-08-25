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
    Public Class Voucher

#Region "Subs"
        Sub New(ByVal VoucherType As String, ByVal VoucherDate As String, ByVal VoucherRef As String, ByVal Narration As String, ByVal Entries As List(Of VoucherEntry))
            Me.VoucherType = VoucherType
            Me.Entries = Entries
            Me.VoucherDate = VoucherDate
            Me.VoucherRef = VoucherRef
            Me.Narration = Narration
        End Sub
#End Region

#Region "Properties"
        ReadOnly Property Entries As New List(Of VoucherEntry)

        ReadOnly Property VoucherType As String

        ReadOnly Property Narration As String

        ReadOnly Property VoucherRef As String

        ReadOnly Property VoucherDate As String
#End Region

    End Class
End Namespace