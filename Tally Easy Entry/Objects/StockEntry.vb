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
    Public Class StockEntry

#Region "Subs"
        Sub New(ByVal LedgerCell As String, ByVal StockItemName As String, ByVal Quantity As Double, ByVal Rate As Double, ByVal Unit As String, ByVal Amount As Double)
            Me.LedgerCell = LedgerCell
            Me.StockItemName = StockItemName
            Me.Quantity = Quantity
            Me.Rate = Rate
            Me.Unit = Unit
            Me.Amount = Amount
        End Sub
#End Region

#Region "Properties"
        ReadOnly Property LedgerCell As String

        ReadOnly Property StockItemName As String

        ReadOnly Property Quantity As Double

        ReadOnly Property Rate As Double

        ReadOnly Property Unit As String

        ReadOnly Property Amount As Double
#End Region

    End Class
End Namespace