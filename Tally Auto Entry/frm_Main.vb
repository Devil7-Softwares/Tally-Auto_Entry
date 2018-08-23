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

#End Region

End Class
