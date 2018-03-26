Imports System.Text
Imports System.Xml

Public Class Vouchers

    Sub GenerateXML(ByVal CompanyName As String, ByVal Vouchers As List(Of Voucher))
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
            .WriteStartElement("TALLYREQUEST") 'TALLYREQUEST
            .WriteString("Import Data")
            .WriteEndElement() 'TALLYREQUEST
            .WriteEndElement() 'HEADER
            .WriteStartElement("BODY") 'BODY
            .WriteStartElement("IMPORTDATA") 'IMPORTDATA
            .WriteStartElement("REQUESTDESC") 'REQUESTDESC
            .WriteStartElement("REPORTNAME") 'REPORTNAME
            .WriteString("Vouchers")
            .WriteEndElement() 'REPORTNAME
            .WriteStartElement("STATICVARIABLES") 'STATICVARIABLES
            .WriteStartElement("SVCURRENTCOMPANY") 'SVCURRENTCOMPANY
            .WriteString(CompanyName)
            .WriteEndElement() 'SVCURRENTCOMPANY
            .WriteEndElement() 'STATICVARIABLES
            .WriteEndElement() 'REQUESTDESC
            .WriteStartElement("REQUESTDATA") 'REQUESTDATA
            WriteVouchers(Vouchers, XMLobj)
            .WriteEndElement() 'REQUESTDATA
            .WriteEndElement() 'IMPORTDATA
            .WriteEndElement() 'BODY
            .WriteEndElement() 'ENVELOPE
            .WriteEndDocument()
            .Close()
        End With
        My.Computer.FileSystem.WriteAllBytes("E:\Test.xml", MemStream.ToArray, False)
    End Sub
    Sub WriteVouchers(ByVal Vouchers As List(Of Voucher), ByRef XMLWriter As XmlWriter)
        For Each i As Voucher In Vouchers
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

                For Each entry As VoucherEntry In i.Entries
                    .WriteStartElement("ALLLEDGERENTRIES.LIST") 'ALLLEDGERENTRIES.LIST
                    .WriteStartElement("REMOVEZEROENTRIES") 'REMOVEZEROENTRIES
                    .WriteString("No")
                    .WriteEndElement() 'REMOVEZEROENTRIES
                    .WriteStartElement("ISDEEMEDPOSITIVE") 'ISDEEMEDPOSITIVE
                    If entry.Effect = Effect.Cr Then
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
                    If entry.Effect = Effect.Dr Then
                        AMT = Math.Abs(entry.Amount) * -1
                    Else
                        AMT = Math.Abs(entry.Amount)
                    End If
                    .WriteString(AMT)
                    .WriteEndElement() 'AMOUNT
                    .WriteEndElement() 'ALLLEDGERENTRIES.LIST
                Next

                .WriteEndElement() 'VOUCHER
                .WriteEndElement() 'TALLYMESSAGE
            End With
        Next
    End Sub
End Class
Public Class Voucher
    Sub New(ByVal VType As String, ByVal Vdate As String, ByVal Reference As String, ByVal Narration As String, ByVal Entries As List(Of VoucherEntry))
        Me.VType = VType
        Me.Entries = Entries
        Me.VDate = Vdate
        Me.Reference = Reference
        Me.Narration_ = Narration
    End Sub
    Dim VType As String = ""
    Property Entries As New List(Of VoucherEntry)
    Dim VDate As Date = Today
    Dim Reference As String = ""
    Dim Narration_ As String = ""
    ReadOnly Property VoucherType As String
        Get
            Return VType
        End Get
    End Property
    ReadOnly Property Narration As String
        Get
            Return Narration_
        End Get
    End Property
    ReadOnly Property VoucherRef As String
        Get
            Return Reference
        End Get
    End Property
    ReadOnly Property VoucherDate As String
        Get
            Return VDate.ToString("yyyyMMdd")
        End Get
    End Property
End Class
Public Class VoucherEntry
    Dim LedgerName_ As String
    Dim Effect_ As Effect = Effect.Dr
    Dim Amount_ As Double = 0
    Sub New(ByVal LedgerName As String, ByVal Effect As Effect, ByVal Amount As Double)
        Me.LedgerName_ = LedgerName
        Me.Effect_ = Effect
        Me.Amount_ = Amount
    End Sub
    ReadOnly Property LedgerName As String
        Get
            Return LedgerName_
        End Get
    End Property
    ReadOnly Property Effect As Effect
        Get
            Return Effect_
        End Get
    End Property
    ReadOnly Property Amount As Effect
        Get
            Return Amount_
        End Get
    End Property
End Class
Public Class StockEntry
    Dim Name_ As String = ""
    Dim Quantity_ As Double = 0
    Dim Amount_ As Double = 0
    Sub New(ByVal Name As String, ByVal Quantity As Double, ByVal Amount As Double)
        Me.Name_ = Name
        Me.Quantity_ = Quantity
        Me.Amount_ = Amount
    End Sub
End Class
Public Enum Effect
    Dr
    Cr
End Enum