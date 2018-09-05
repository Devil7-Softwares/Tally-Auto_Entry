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

Imports DevExpress.Skins
Imports DevExpress.Spreadsheet
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraSpreadsheet

Public Class frm_Main

#Region "Variables"

    Dim LedgerNameColumns As New List(Of Integer)({6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39})
    Dim EffectColumns As New List(Of Integer)({7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40})
    Dim AmountColumns As New List(Of Integer)({8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41})
    Dim LastColumnIndex As Integer = 0

    Dim Tally As New Classes.TallyIO

#End Region

#Region "Subs"

    Sub InitSkins()
        SkinManager.EnableFormSkins()
        BonusSkins.Register()
    End Sub

    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgb_Skins, True)
    End Sub

    Sub NewDocument()
        MainSpreadSheet.CreateNewDocument()
        Dim S As DevExpress.Spreadsheet.IWorkbook = MainSpreadSheet.Document
        Dim VoucherEntrySheet As DevExpress.Spreadsheet.Worksheet = S.Worksheets.Add
        VoucherEntrySheet.Name = "Vouchers"
        Dim StockEntrySheet As DevExpress.Spreadsheet.Worksheet = S.Worksheets.Add
        StockEntrySheet.Name = "Stock"
        MainSpreadSheet.Document.Worksheets.ActiveWorksheet = VoucherEntrySheet
        Dim SheetsRemove As New List(Of DevExpress.Spreadsheet.Worksheet)
        For Each i As DevExpress.Spreadsheet.Worksheet In S.Worksheets
            If i.Name <> "Vouchers" AndAlso i.Name <> "Stock" Then
                SheetsRemove.Add(i)
            End If
        Next
        For Each i As DevExpress.Spreadsheet.Worksheet In SheetsRemove
            MainSpreadSheet.Document.Worksheets.Remove(i)
        Next
    End Sub

    Sub PrepareSheet()
        Dim VoucherEntrySheet As DevExpress.Spreadsheet.Worksheet = MainSpreadSheet.Document.Worksheets("Vouchers")
        MainSpreadSheet.Document.Worksheets.ActiveWorksheet = VoucherEntrySheet
        Dim MaxColumn As Integer = (6 + (3 * My.Settings.NumberOfColumns))
        LastColumnIndex = MaxColumn - 1
        MainSpreadSheet.WorksheetDisplayArea.SetSize(MainSpreadSheet.ActiveWorksheet.Index, MaxColumn, 99999)
        For Each i As Integer In LedgerNameColumns
            MainSpreadSheet.ActiveWorksheet.Columns(i).Borders.LeftBorder.Color = Color.Red
            MainSpreadSheet.ActiveWorksheet.Columns(i).Borders.LeftBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Medium
        Next
        MainSpreadSheet.ActiveWorksheet.Columns(0).NumberFormat = "dd/mm/yyyy"
        MainSpreadSheet.ActiveWorksheet.Columns(2).NumberFormat = "##"
        MainSpreadSheet.ActiveWorksheet.Columns(3).NumberFormat = "##"
        Try
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = MainSpreadSheet.ActiveWorksheet.Columns(0).GetRangeWithAbsoluteReference
            MainSpreadSheet.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.DateEdit)
        Catch ex As Exception

        End Try
        Try
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = MainSpreadSheet.ActiveWorksheet.Columns(1).GetRangeWithAbsoluteReference
            MainSpreadSheet.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.ComboBox, DevExpress.Spreadsheet.ValueObject.CreateListSource({"Purchase", "Sales", "Payment", "Receipt", "Contra", "Journal"}))
        Catch ex As Exception

        End Try
        For Each i As Integer In EffectColumns
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = MainSpreadSheet.ActiveWorksheet.Columns(i).GetRangeWithAbsoluteReference
            MainSpreadSheet.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.ComboBox, DevExpress.Spreadsheet.ValueObject.CreateListSource({"Dr.", "Cr."}))
        Next
    End Sub

    Sub LoadSettings()
        txt_TallyHostURL.EditValue = My.Settings.TallyHostURL
        txt_TallyVersion.EditValue = My.Settings.TallyVersion
    End Sub

    Function GetDate(ByVal Day As Integer, ByVal Month As Integer)
        If Month >= 4 Then
            Return New Date(txt_Year_From.EditValue, Month, Day)
        Else
            Return New Date(txt_Year_To.EditValue, Month, Day)
        End If
    End Function

    Sub PreCalculateValue(ByVal e As SpreadsheetCellEventArgs, ByVal AddIndex As Boolean)
        Dim ColumnIndex As Integer = If(AddIndex, e.ColumnIndex + 1, e.ColumnIndex)
        Dim Index As Integer = EffectColumns.IndexOf(ColumnIndex)

        Dim ValueCell As Cell = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, AmountColumns(Index))
        Dim EffectCell As CellValue = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, EffectColumns(Index)).Value
        Dim PrimaryEffect As String = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, EffectColumns(0)).Value.TextValue
        If ValueCell.Value.ToString = "" AndAlso EffectCell.TextValue <> "" AndAlso EffectCell.TextValue <> PrimaryEffect Then
            Dim Value As Integer = 0
            For i As Integer = 0 To Index - 1
                Dim EffectCell_ As CellValue = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, EffectColumns(i)).Value
                Dim ValueCell_ As CellValue = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, AmountColumns(i)).Value
                If ValueCell_.IsNumeric Then
                    If EffectCell_.TextValue = PrimaryEffect Then
                        Value += ValueCell_.NumericValue
                    Else
                        Value -= ValueCell_.NumericValue
                    End If
                End If
            Next
            ValueCell.SetValue(Value)
        End If
    End Sub

    Function GetVouchers() As List(Of Objects.Voucher)
        Dim VouchersList As New List(Of Objects.Voucher)
        For index As Integer = 0 To MainSpreadSheet.Document.Worksheets(0).Rows.LastUsedIndex
            Dim Row As DevExpress.Spreadsheet.Row = MainSpreadSheet.Document.Worksheets(0).Rows.Item(index)
            If Not Row.Item(1).Value.IsEmpty Then
                Dim Entries As New List(Of Objects.VoucherEntry)
                For i As Integer = 0 To My.Settings.NumberOfColumns - 1
                    Dim ledgerValue = Row.Item(LedgerNameColumns(i)).Value
                    If Not ledgerValue.IsEmpty Then
                        'Try
                        Dim LedgerName As String = ledgerValue.TextValue.Trim
                        Dim Effect As String = Row.Item(EffectColumns(i)).Value.TextValue.Trim
                        Dim Amount As Double = Row.Item(AmountColumns(i)).Value.NumericValue
                        Entries.Add(New Objects.VoucherEntry(LedgerName, Classes.CEffect(Effect), Amount))
                        'Catch ex As Exception

                        'End Try
                    End If
                Next
                Dim V As New Objects.Voucher(Row.Item(1).Value.TextValue, Row.Item(0).Value.DateTimeValue.ToString("dd/MM/yyyy"), Row.Item(4).Value.TextValue, Row.Item(5).Value.TextValue, Entries)
                VouchersList.Add(V)
            End If
        Next
        Return VouchersList
    End Function

#End Region

#Region "Events"

    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub

    Private Sub btn_Exit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Exit.ItemClick
        Me.Close()
    End Sub

    Private Sub MainSpreadSheet_ActiveSheetChanged(sender As Object, e As ActiveSheetChangedEventArgs) Handles MainSpreadSheet.ActiveSheetChanged
        MainSpreadSheet.WorksheetDisplayArea.SetSize(1, (6), 99999)
    End Sub

    Private Sub MainSpreadSheet_CustomDrawColumnHeader(sender As Object, e As CustomDrawColumnHeaderEventArgs) Handles MainSpreadSheet.CustomDrawColumnHeader
        If MainSpreadSheet.ActiveWorksheet.Name = "Vouchers" Then
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
        ElseIf MainSpreadSheet.ActiveWorksheet.Name = "Stock" Then
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

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()
        NewDocument()
        PrepareSheet()
        txt_Year_FromEdit.MaxValue = Now.Year
        txt_Year_From.EditValue = Now.Year - 1
    End Sub

    Private Async Sub btn_SyncLedgers_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Sync.ItemClick
        btn_Sync.Enabled = False
        MainProgressPanel.Description = "Syncronizing with Tally..."
        MainProgressPanel.Visible = True
        Dim Values As New List(Of CellValue)
        If Not Await Tally.LoadAllLedgers Then GoTo Finish
        For Each i As String In Tally.Ledgers
            Values.Add(i)
        Next
        txt_CompanyName.EditValue = Tally.CompanyName
        MainSpreadSheet.Document.DocumentProperties.Custom.Item("CompanyName") = Tally.CompanyName
        For Each i As Integer In LedgerNameColumns
            Dim comboBoxRange As DevExpress.Spreadsheet.Range = MainSpreadSheet.ActiveWorksheet.Columns(i).GetRangeWithAbsoluteReference
            MainSpreadSheet.ActiveWorksheet.CustomCellInplaceEditors.Add(comboBoxRange, DevExpress.Spreadsheet.CustomCellInplaceEditorType.ComboBox, DevExpress.Spreadsheet.ValueObject.CreateListSource(Values.ToArray))
            MainSpreadSheet.ActiveWorksheet.Columns(i).Borders.LeftBorder.Color = Color.Red
            MainSpreadSheet.ActiveWorksheet.Columns(i).Borders.LeftBorder.LineStyle = DevExpress.Spreadsheet.BorderLineStyle.Medium
        Next
Finish:
        btn_Sync.Enabled = True
        MainProgressPanel.Visible = False
    End Sub

    Private Sub txt_TallyHostURL_EditValueChanged(sender As Object, e As EventArgs) Handles txt_TallyHostURL.EditValueChanged
        My.Settings.TallyHostURL = txt_TallyHostURL.EditValue
        My.Settings.Save()
    End Sub

    Private Sub txt_TallyVersion_EditValueChanged(sender As Object, e As EventArgs) Handles txt_TallyVersion.EditValueChanged
        My.Settings.TallyVersion = txt_TallyVersion.EditValue
        My.Settings.Save()
    End Sub

    Private Sub MainSpreadSheet_KeyDown(sender As Object, e As KeyEventArgs) Handles MainSpreadSheet.KeyDown
        If e.KeyCode = Keys.Enter AndAlso (e.Control Or MainSpreadSheet.ActiveCell.ColumnIndex = LastColumnIndex) Then
            If MainSpreadSheet.ActiveSheet.Name = "Vouchers" Then
                MainSpreadSheet.SelectedCell = MainSpreadSheet.Document.Range("B" & MainSpreadSheet.ActiveCell.RowIndex + 2)
                MainSpreadSheet.ActiveWorksheet.ScrollToColumn(0)
            Else
                Exit Sub
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Year_From_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Year_From.EditValueChanged
        txt_Year_To.EditValue = txt_Year_From.EditValue + 1
    End Sub

    Private Sub MainSpreadSheet_CellValueChanged(sender As Object, e As SpreadsheetCellEventArgs) Handles MainSpreadSheet.CellValueChanged
        If MainSpreadSheet.ActiveSheet.Name = "Vouchers" Then
            If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
                If e.Value.ToString <> "" AndAlso e.Value.IsNumeric = False Then
                    MsgBox("Only numeric values are allowed.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                    e.Cell.SetValue(e.OldValue.ToObject)
                Else
                    Dim MonthCell As CellValue = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, 3).Value
                    Dim DayCell As CellValue = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, 2).Value
                    If MonthCell.IsNumeric And DayCell.IsNumeric Then
                        Dim DateCell = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, 0)
                        DateCell.SetValue(GetDate(DayCell.NumericValue, MonthCell.NumericValue))
                    End If
                End If
            ElseIf e.ColumnIndex = 0 AndAlso e.Action <> CellValueChangedAction.API Then
                Dim DateCell As CellValue = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, 0).Value
                If DateCell.IsDateTime Then
                    MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, 3).SetValue(DateCell.DateTimeValue.Month)
                    MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, 2).SetValue(DateCell.DateTimeValue.Day)
                End If
            ElseIf LedgerNameColumns.Contains(e.ColumnIndex) AndAlso LedgerNameColumns.IndexOf(e.ColumnIndex) > 0 Then
                Dim PreEffectCell As Cell = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, EffectColumns(LedgerNameColumns.IndexOf(e.ColumnIndex) - 1))
                Dim EffectCell As Cell = MainSpreadSheet.ActiveWorksheet.Cells.Item(e.RowIndex, EffectColumns(LedgerNameColumns.IndexOf(e.ColumnIndex)))
                If PreEffectCell.Value.TextValue = "Dr." Then
                    EffectCell.SetValue("Cr.")
                ElseIf PreEffectCell.Value.TextValue = "Cr." Then
                    EffectCell.SetValue("Dr.")
                End If
                PreCalculateValue(e, True)
            ElseIf EffectColumns.Contains(e.ColumnIndex) AndAlso EffectColumns.IndexOf(e.ColumnIndex) > 0 Then
                PreCalculateValue(e, False)
            End If
        End If
    End Sub

    Private Sub btn_GenerateXML_File_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_GenerateXML_File.ItemClick
        If SaveFileDialog_XML.ShowDialog = DialogResult.OK Then
            Dim Vouchers As List(Of Objects.Voucher) = GetVouchers()
            Classes.XMLGenerator.GenerateXML(txt_CompanyName.EditValue, Vouchers, SaveFileDialog_XML.FileName)
        End If
    End Sub

    Private Async Sub btn_GenerateXML_Tally_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_GenerateXML_Tally.ItemClick
        Try
            Dim Vouchers As List(Of Objects.Voucher) = GetVouchers()
            Dim Data As String = Classes.XMLGenerator.GenerateXML(txt_CompanyName.EditValue, Vouchers)
            Dim Response As Objects.Response = Await Tally.SendRequestToTally(Data)
            If Response.Status Then
                MsgBox(String.Format("Successfully Created {0} Entries.", Response.Created), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            Else
                Classes.PublicFunctions.WriteErrorResponse(Response)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub MainSpreadSheet_DocumentLoaded(sender As Object, e As EventArgs) Handles MainSpreadSheet.DocumentLoaded
        txt_CompanyName.EditValue = MainSpreadSheet.Document.DocumentProperties.Custom.Item("CompanyName").TextValue
    End Sub

    Private Sub btn_NewLedger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_NewLedger.ItemClick
        Dim d As New frm_NewLedger(Tally)
        d.ShowDialog()
    End Sub

    Private Sub btn_CustomRequest_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_CustomRequest.ItemClick
        Dim d As New frm_CustomRequest(Tally)
        d.ShowDialog()
    End Sub

#End Region

End Class
