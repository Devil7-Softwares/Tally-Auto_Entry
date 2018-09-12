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

Imports System.Text
Imports System.Xml

Namespace Classes
    Public Class XMLGenerator

        Public Shared Sub GenerateXML(ByVal CompanyName As String, ByVal Vouchers As List(Of Objects.Voucher), ByVal FileName As String)
            My.Computer.FileSystem.WriteAllText(FileName, GenerateXML(CompanyName, Vouchers), False)
        End Sub

        Public Shared Function GenerateXML(ByVal CompanyName As String, ByVal Vouchers As List(Of Objects.Voucher)) As String
            Dim enc As New UnicodeEncoding
            Dim MemStream As New IO.MemoryStream
            ' Declare a XmlTextWriter-Object, with which we are going to write the config file
            Dim XMLobj As XmlTextWriter = New XmlTextWriter(MemStream, enc)

            With XMLobj
                .Formatting = Formatting.Indented
                .Indentation = 4
                .WriteStartDocument()
                .WriteStartElement("ENVELOPE") 'ENVELOPE
                .WriteStartElement("HEADER") 'HEADER
                .WriteStartElement("VERSION") 'VERSION
                .WriteString(My.Settings.TallyVersion)
                .WriteEndElement() 'VERSION
                .WriteStartElement("TALLYREQUEST") 'TALLYREQUEST
                .WriteString("Import")
                .WriteEndElement() 'TALLYREQUEST
                .WriteStartElement("TYPE") 'TYPE
                .WriteString("Data")
                .WriteEndElement() 'TYPE
                .WriteStartElement("ID") 'ID
                .WriteString("Vouchers")
                .WriteEndElement() 'ID
                .WriteEndElement() 'HEADER
                .WriteStartElement("BODY") 'BODY
                .WriteStartElement("DESC") 'DESC
                .WriteStartElement("REPORTNAME") 'REPORTNAME
                .WriteString("Vouchers")
                .WriteEndElement() 'REPORTNAME
                .WriteStartElement("STATICVARIABLES") 'STATICVARIABLES
                .WriteStartElement("SVCURRENTCOMPANY") 'SVCURRENTCOMPANY
                .WriteString(CompanyName)
                .WriteEndElement() 'SVCURRENTCOMPANY
                .WriteEndElement() 'STATICVARIABLES
                .WriteEndElement() 'DESC
                .WriteStartElement("IMPORTDATA") 'IMPORTDATA
                .WriteStartElement("REQUESTDATA") 'REQUESTDATA
                WriteVouchers(Vouchers, XMLobj)
                .WriteEndElement() 'REQUESTDATA
                .WriteEndElement() 'IMPORTDATA
                .WriteEndElement() 'BODY
                .WriteEndElement() 'ENVELOPE
                .WriteEndDocument()
                .Close()
            End With
            Return enc.GetString(MemStream.ToArray)
        End Function

        Private Shared Sub WriteVouchers(ByVal Vouchers As List(Of Objects.Voucher), ByRef XMLWriter As XmlWriter)
            For Each i As Objects.Voucher In Vouchers
                With XMLWriter
                    .WriteStartElement("TALLYMESSAGE") 'TALLYMESSAGE
                    .WriteAttributeString("xmlns:UDF", "TallyUDF")
                    .WriteStartElement("VOUCHER")
                    .WriteAttributeString("VCHTYPE", i.VoucherType)
                    .WriteAttributeString("ACTION", "CREATE")
                    .WriteStartElement("VOUCHERTYPENAME") 'VOUCHERTYPENAME
                    .WriteString(i.VoucherType)
                    .WriteEndElement() 'VOUCHERTYPENAME
                    .WriteStartElement("DATE") 'DATE
                    .WriteString(i.VoucherDate)
                    .WriteEndElement() 'DATE
                    .WriteStartElement("EFFECTIVEDATE") 'EFFECTIVEDATE
                    .WriteString(i.VoucherDate)
                    .WriteEndElement() 'EFFECTIVEDATE
                    .WriteStartElement("REFERENCE") 'REFERENCE
                    .WriteString(i.VoucherRef)
                    .WriteEndElement() 'REFERENCE
                    .WriteStartElement("NARRATION") 'NARRATION
                    .WriteString(i.Narration)
                    .WriteEndElement() 'NARRATION

                    For Each entry As Objects.VoucherEntry In i.Entries
                        .WriteStartElement("ALLLEDGERENTRIES.LIST") 'ALLLEDGERENTRIES.LIST
                        .WriteStartElement("REMOVEZEROENTRIES") 'REMOVEZEROENTRIES
                        .WriteString("No")
                        .WriteEndElement() 'REMOVEZEROENTRIES
                        .WriteStartElement("ISDEEMEDPOSITIVE") 'ISDEEMEDPOSITIVE
                        If entry.Effect = Objects.Effect.Cr Then
                            .WriteString("No")
                        Else
                            .WriteString("Yes")
                        End If
                        .WriteEndElement() 'ISDEEMEDPOSITIVE
                        .WriteStartElement("LEDGERNAME") 'LEDGERNAME
                        .WriteString(entry.LedgerName)
                        .WriteEndElement() 'LEDGERNAME
                        .WriteStartElement("AMOUNT") 'AMOUNT
                        Dim AMT As Double = entry.Amount
                        If entry.Effect = Objects.Effect.Dr Then
                            AMT = Math.Abs(entry.Amount) * -1
                        Else
                            AMT = Math.Abs(entry.Amount)
                        End If
                        .WriteString(AMT)
                        .WriteEndElement() 'AMOUNT
                        For Each s As Objects.StockEntry In entry.StockEntries
                            .WriteStartElement("INVENTORYALLOCATIONS.LIST") 'INVENTORY LIST
                            .WriteStartElement("STOCKITEMNAME") 'STOCKITEMNAME
                            .WriteString(s.StockItemName)
                            .WriteEndElement() 'STOCKITEMNAME
                            .WriteStartElement("ISDEEMEDPOSITIVE") 'ISDEEMEDPOSITIVE
                            .WriteString(If(entry.Effect = Objects.Effect.Dr, "Yes", "No"))
                            .WriteEndElement() 'ISDEEMEDPOSITIVE
                            .WriteStartElement("AMOUNT") 'AMOUNT
                            .WriteString(If(entry.Effect = Objects.Effect.Dr, s.Amount * -1, s.Amount))
                            .WriteEndElement() 'AMOUNT
                            .WriteStartElement("ACTUALQTY") 'ACTUALQTY
                            .WriteString(s.Quantity)
                            .WriteEndElement() 'ACTUALQTY
                            .WriteStartElement("BILLEDQTY") 'BILLEDQTY
                            .WriteString(s.Quantity)
                            .WriteEndElement() 'AMOUNT
                            .WriteStartElement("RATE") 'RATE
                            .WriteString(s.Rate)
                            .WriteEndElement() 'RATE
                            .WriteEndElement() 'INVENTORY LIST
                        Next
                        .WriteEndElement() 'ALLLEDGERENTRIES.LIST
                    Next

                    .WriteEndElement() 'VOUCHER
                    .WriteEndElement() 'TALLYMESSAGE
                End With
            Next
        End Sub

    End Class
End Namespace