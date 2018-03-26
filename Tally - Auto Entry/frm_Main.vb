Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon


Public Class frm_Main
    Dim isLoading As Boolean = True
    Dim LedgerNameColumns As New List(Of Integer)
    Dim EffectColumns As New List(Of Integer)
    Dim AmountColumns As New List(Of Integer)
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub
    Sub PrepareSheet(ByVal LoadFromTally As Boolean)
        Dim VoucherEntrySheet As DevExpress.Spreadsheet.Worksheet = spreadsheetControl.Document.Worksheets("Vouchers")
        spreadsheetControl.Document.Worksheets.ActiveWorksheet = VoucherEntrySheet
        Dim Values As New List(Of DevExpress.Spreadsheet.CellValue)
        If LoadFromTally = True Then
            Dim L As New AllLedgers
            L.GetAll()
            For Each i As String In L.Ledgers
                Values.Add(i)
            Next
            txt_CompanyName.EditValue = L.CompanyName
        End If
        spreadsheetControl.WorksheetDisplayArea.SetSize(spreadsheetControl.ActiveWorksheet.Index, (6 + (3 * My.Settings.NumberOfColumns)), 99999)
        For Each i As Integer In LedgerNameColumns
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = spreadsheetControl.ActiveWorksheet.Columns(i).GetRangeWithAbsoluteReference
            spreadsheetControl.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.ComboBox, DevExpress.Spreadsheet.ValueObject.CreateListSource(Values.ToArray))
            spreadsheetControl.ActiveWorksheet.Columns(i).Borders.LeftBorder.Color = Color.Red
            spreadsheetControl.ActiveWorksheet.Columns(i).Borders.LeftBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Medium
        Next
        spreadsheetControl.ActiveWorksheet.Columns(0).NumberFormat = "dd/mm/yyyy"
        spreadsheetControl.ActiveWorksheet.Columns(2).NumberFormat = "##"
        spreadsheetControl.ActiveWorksheet.Columns(3).NumberFormat = "##"
        Try
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = spreadsheetControl.ActiveWorksheet.Columns(0).GetRangeWithAbsoluteReference
            spreadsheetControl.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.DateEdit)
        Catch ex As Exception

        End Try
        Try
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = spreadsheetControl.ActiveWorksheet.Columns(1).GetRangeWithAbsoluteReference
            spreadsheetControl.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.ComboBox, DevExpress.Spreadsheet.ValueObject.CreateListSource({"Purchase", "Sales", "Payment", "Receipt", "Contra", "Journal"}))
        Catch ex As Exception

        End Try
        For Each i As Integer In EffectColumns
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = spreadsheetControl.ActiveWorksheet.Columns(i).GetRangeWithAbsoluteReference
            spreadsheetControl.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.ComboBox, DevExpress.Spreadsheet.ValueObject.CreateListSource({"Dr.", "Cr."}))
        Next
    End Sub
    Sub NewDocument()
        spreadsheetControl.CreateNewDocument()
        Dim S As DevExpress.Spreadsheet.IWorkbook = spreadsheetControl.Document
        Dim VoucherEntrySheet As DevExpress.Spreadsheet.Worksheet = S.Worksheets.Add
        VoucherEntrySheet.Name = "Vouchers"
        Dim StockEntrySheet As DevExpress.Spreadsheet.Worksheet = S.Worksheets.Add
        StockEntrySheet.Name = "Stock"
        spreadsheetControl.Document.Worksheets.ActiveWorksheet = VoucherEntrySheet
        Dim SheetsRemove As New List(Of DevExpress.Spreadsheet.Worksheet)
        For Each i As DevExpress.Spreadsheet.Worksheet In S.Worksheets
            If i.Name <> "Vouchers" AndAlso i.Name <> "Stock" Then
                SheetsRemove.Add(i)
            End If
        Next
        For Each i As DevExpress.Spreadsheet.Worksheet In SheetsRemove
            spreadsheetControl.Document.Worksheets.Remove(i)
        Next
    End Sub
    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Columns.EditValue = My.Settings.NumberOfColumns
        NewDocument()
        LedgerNameColumns.AddRange({6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39})
        EffectColumns.AddRange({7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40})
        AmountColumns.AddRange({8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41})
        PrepareSheet(False)
    End Sub

    Private Sub spreadsheetControl_ActiveSheetChanged(ByVal sender As Object, ByVal e As DevExpress.Spreadsheet.ActiveSheetChangedEventArgs) Handles spreadsheetControl.ActiveSheetChanged
        spreadsheetControl.WorksheetDisplayArea.SetSize(1, (6), 99999)
    End Sub

    Private Sub spreadsheetControl_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.CustomDrawColumnHeaderEventArgs) Handles spreadsheetControl.CustomDrawColumnHeader
        If spreadsheetControl.ActiveWorksheet.Name = "Vouchers" Then
            Dim text As String = ""
            Select Case e.ColumnIndex
                Case 0
                    text = "Date"
                Case 1
                    text = "Voucher Type"
                Case 2
                    text = "Day"
                Case 3
                    text = "Month"
                Case 4
                    text = "Reference No."
                Case 5
                    text = "Narration"
            End Select
            If LedgerNameColumns.Contains(e.ColumnIndex) Then
                text = "Ledger Name"
            ElseIf EffectColumns.Contains(e.ColumnIndex) Then
                text = "Effect"
            ElseIf AmountColumns.Contains(e.ColumnIndex) Then
                text = "Amount"
            End If
            If text <> "" Then
                e.Handled = True
                Dim MinW = e.Graphics.MeasureString(text, e.Font).Width + 10
                If e.Control.ActiveWorksheet.Columns(e.ColumnIndex).WidthInPixels < MinW Then
                    e.Control.ActiveWorksheet.Columns(e.ColumnIndex).WidthInPixels = MinW
                End If
                Dim formatHeaderText As New StringFormat()
                formatHeaderText.LineAlignment = StringAlignment.Center
                formatHeaderText.Alignment = StringAlignment.Center
                formatHeaderText.Trimming = StringTrimming.EllipsisCharacter
                e.Graphics.DrawString(text, e.Font, e.Cache.GetSolidBrush(e.ForeColor), e.Bounds, formatHeaderText)
            End If
        ElseIf spreadsheetControl.ActiveWorksheet.Name = "Stock" Then
            Dim text As String = ""
            Select Case e.ColumnIndex
                Case 0
                    text = "Entries Cell Address"
                Case 1
                    text = "Name of Item"
                Case 2
                    text = "Quantity"
                Case 3
                    text = "Rate"
                Case 4
                    text = "Unit"
                Case 5
                    text = "Amount"
            End Select
            If text <> "" Then
                e.Handled = True
                Dim MinW = e.Graphics.MeasureString(text, e.Font).Width + 10
                If e.Control.ActiveWorksheet.Columns(e.ColumnIndex).WidthInPixels < MinW Then
                    e.Control.ActiveWorksheet.Columns(e.ColumnIndex).WidthInPixels = MinW
                End If
                Dim formatHeaderText As New StringFormat()
                formatHeaderText.LineAlignment = StringAlignment.Center
                formatHeaderText.Alignment = StringAlignment.Center
                formatHeaderText.Trimming = StringTrimming.EllipsisCharacter
                e.Graphics.DrawString(text, e.Font, e.Cache.GetSolidBrush(e.ForeColor), e.Bounds, formatHeaderText)
            End If
        End If
    End Sub

    Private Sub btn_SyncLedgers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SyncLedgers.ItemClick
        PrepareSheet(True)
    End Sub

    Private Sub btn_CustomRequestTester_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_CustomRequestTester.ItemClick
        Form1.ShowDialog()
    End Sub

    Private Sub btn_GenerateXML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_GenerateXML.ItemClick
        Dim VouchersList As New List(Of Voucher)
        For index As Integer = 0 To spreadsheetControl.Document.Worksheets(0).Rows.LastUsedIndex
            Dim Row As DevExpress.Spreadsheet.Row = spreadsheetControl.Document.Worksheets(0).Rows.Item(index)
            If Not Row.Item(1).Value.IsEmpty Then
                Dim Entries As New List(Of VoucherEntry)
                For i As Integer = 0 To My.Settings.NumberOfColumns - 1
                    Dim ledgerValue = Row.Item(LedgerNameColumns(i)).Value
                    If Not ledgerValue.IsEmpty Then
                        'Try
                        Dim LedgerName As String = ledgerValue.TextValue.Trim
                        Dim Effect As String = Row.Item(EffectColumns(i)).Value.TextValue.Trim
                        Dim Amount As Double = Row.Item(AmountColumns(i)).Value.NumericValue
                        Entries.Add(New VoucherEntry(LedgerName, CEffect(Effect), Amount))
                        'Catch ex As Exception

                        'End Try
                    End If
                Next
                Dim V As New Voucher(Row.Item(1).Value.TextValue, Row.Item(0).Value.DateTimeValue.ToString("dd/MM/yyyy"), Row.Item(4).Value.TextValue, Row.Item(5).Value.TextValue, Entries)
                VouchersList.Add(V)
            End If
        Next
        Dim S As New Vouchers
        S.GenerateXML(txt_CompanyName.EditValue, VouchersList)
    End Sub

    Private Sub cmb_Columns_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Columns.EditValueChanged
        My.Settings.NumberOfColumns = cmb_Columns.EditValue
        spreadsheetControl.WorksheetDisplayArea.SetSize(0, (6 + (3 * My.Settings.NumberOfColumns)), 99999)
    End Sub

    Private Sub spreadsheetControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spreadsheetControl.Click

    End Sub

    Private Sub btn_CreateNewLedger_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_CreateNewLedger.ItemClick

    End Sub
End Class
