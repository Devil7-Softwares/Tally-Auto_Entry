﻿Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Dim ReduceOperation1 As DevExpress.XtraBars.Ribbon.ReduceOperation = New DevExpress.XtraBars.Ribbon.ReduceOperation()
        Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
        Dim SpreadsheetCommandGalleryItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Dim SpreadsheetCommandGalleryItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.MainMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.btn_New = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Open = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Save = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_SaveAs = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_DocumentInfo = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Exit = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rgb_Skins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.btn_Filter = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
        Me.btn_FilterClear = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Paste = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Cut = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Copy = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_PasteSpecial = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_WrapText = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
        Me.btn_IncreaseDecimal = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_DecreaseDecimal = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_InsertSheetRows = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Find = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Replace = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Undo = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Redo = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
        Me.btn_Sync = New DevExpress.XtraBars.BarButtonItem()
        Me.txt_CompanyName = New DevExpress.XtraBars.BarEditItem()
        Me.txt_CompanyNameEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_TallyVersion = New DevExpress.XtraBars.BarEditItem()
        Me.txt_TallyVersionEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_TallyHostURL = New DevExpress.XtraBars.BarEditItem()
        Me.txt_TallyHostURLEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_Year_From = New DevExpress.XtraBars.BarEditItem()
        Me.txt_Year_FromEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.txt_Year_To = New DevExpress.XtraBars.BarEditItem()
        Me.txt_Year_ToEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.btn_RefreshDates = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_GenerateXML_File = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_GenerateXML_Tally = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_NewLedger = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_CustomRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.txt_VoucherColumns = New DevExpress.XtraBars.BarEditItem()
        Me.txt_VoucherColumns_Edit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rp_Home = New DevExpress.XtraSpreadsheet.UI.HomeRibbonPage()
        Me.rpg_Clipboard = New DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup()
        Me.rpg_Tally = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Date = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Extras = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_XML = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rp_Extras = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_CellOptions = New DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup()
        Me.rpg_Filter = New DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup()
        Me.rpg_Find = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Skins = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Testing = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.MainSpreadSheet = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.panel_FormulaBar = New System.Windows.Forms.Panel()
        Me.MainProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.splitterControl = New DevExpress.XtraEditors.SplitterControl()
        Me.formulaBarNameBoxSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txt_NameBox = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
        Me.txt_FormulaBar = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
        Me.SpreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
        Me.SaveFileDialog_XML = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CompanyNameEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TallyVersionEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TallyHostURLEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Year_FromEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Year_ToEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_VoucherColumns_Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_FormulaBar.SuspendLayout()
        CType(Me.formulaBarNameBoxSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formulaBarNameBoxSplitContainerControl.SuspendLayout()
        CType(Me.txt_NameBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.MainMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.rgb_Skins, Me.btn_Filter, Me.btn_FilterClear, Me.btn_Paste, Me.btn_Cut, Me.btn_Copy, Me.btn_PasteSpecial, Me.btn_WrapText, Me.btn_IncreaseDecimal, Me.btn_DecreaseDecimal, Me.btn_InsertSheetRows, Me.btn_Find, Me.btn_Replace, Me.btn_New, Me.btn_Open, Me.btn_Save, Me.btn_SaveAs, Me.btn_Undo, Me.btn_Redo, Me.btn_DocumentInfo, Me.btn_Exit, Me.btn_Sync, Me.txt_CompanyName, Me.txt_TallyVersion, Me.txt_TallyHostURL, Me.txt_Year_From, Me.txt_Year_To, Me.btn_RefreshDates, Me.btn_GenerateXML_File, Me.btn_GenerateXML_Tally, Me.btn_NewLedger, Me.btn_CustomRequest, Me.txt_VoucherColumns})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 185
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home, Me.rp_Extras})
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.btn_Undo)
        Me.ribbonControl.QuickToolbarItemLinks.Add(Me.btn_Redo)
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPopupGalleryEdit1, Me.RepositoryItemTextEdit2, Me.txt_CompanyNameEdit, Me.txt_TallyVersionEdit, Me.txt_TallyHostURLEdit, Me.txt_Year_FromEdit, Me.txt_Year_ToEdit, Me.txt_VoucherColumns_Edit})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(1100, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        '
        'MainMenu
        '
        Me.MainMenu.ItemLinks.Add(Me.btn_New)
        Me.MainMenu.ItemLinks.Add(Me.btn_Open)
        Me.MainMenu.ItemLinks.Add(Me.btn_Save)
        Me.MainMenu.ItemLinks.Add(Me.btn_SaveAs)
        Me.MainMenu.ItemLinks.Add(Me.btn_DocumentInfo, True)
        Me.MainMenu.ItemLinks.Add(Me.btn_Exit, True)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Ribbon = Me.ribbonControl
        '
        'btn_New
        '
        Me.btn_New.CommandName = "FileNew"
        Me.btn_New.Description = "Create a new document."
        Me.btn_New.Id = 389
        Me.btn_New.ImageOptions.Image = CType(resources.GetObject("btn_New.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New.ImageOptions.LargeImage = CType(resources.GetObject("btn_New.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New.Name = "btn_New"
        '
        'btn_Open
        '
        Me.btn_Open.CommandName = "FileOpen"
        Me.btn_Open.Description = "Open a document."
        Me.btn_Open.Id = 390
        Me.btn_Open.ImageOptions.Image = CType(resources.GetObject("btn_Open.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Open.ImageOptions.LargeImage = CType(resources.GetObject("btn_Open.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Open.Name = "btn_Open"
        '
        'btn_Save
        '
        Me.btn_Save.CommandName = "FileSave"
        Me.btn_Save.Description = "Save the document."
        Me.btn_Save.Id = 391
        Me.btn_Save.ImageOptions.Image = CType(resources.GetObject("btn_Save.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Save.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_SaveAs
        '
        Me.btn_SaveAs.CommandName = "FileSaveAs"
        Me.btn_SaveAs.Description = "Open the Save As dialog box."
        Me.btn_SaveAs.Id = 392
        Me.btn_SaveAs.ImageOptions.Image = CType(resources.GetObject("btn_SaveAs.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_SaveAs.ImageOptions.LargeImage = CType(resources.GetObject("btn_SaveAs.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_SaveAs.Name = "btn_SaveAs"
        '
        'btn_DocumentInfo
        '
        Me.btn_DocumentInfo.CommandName = "FileShowDocumentProperties"
        Me.btn_DocumentInfo.Description = "Show the Properties dialog box."
        Me.btn_DocumentInfo.Id = 399
        Me.btn_DocumentInfo.ImageOptions.Image = CType(resources.GetObject("btn_DocumentInfo.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_DocumentInfo.ImageOptions.LargeImage = CType(resources.GetObject("btn_DocumentInfo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_DocumentInfo.Name = "btn_DocumentInfo"
        '
        'btn_Exit
        '
        Me.btn_Exit.Caption = "Exit"
        Me.btn_Exit.Description = "Close application."
        Me.btn_Exit.Id = 404
        Me.btn_Exit.ImageOptions.Image = CType(resources.GetObject("btn_Exit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Exit.ImageOptions.LargeImage = CType(resources.GetObject("btn_Exit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'rgb_Skins
        '
        Me.rgb_Skins.Caption = "Skins"
        '
        '
        '
        Me.rgb_Skins.Gallery.AllowHoverImages = True
        Me.rgb_Skins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgb_Skins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgb_Skins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgb_Skins.Gallery.ColumnCount = 4
        Me.rgb_Skins.Gallery.FixedHoverImageSize = False
        Me.rgb_Skins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgb_Skins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgb_Skins.Gallery.RowCount = 4
        Me.rgb_Skins.Id = 60
        Me.rgb_Skins.Name = "rgb_Skins"
        '
        'btn_Filter
        '
        Me.btn_Filter.CommandName = "DataFilterToggle"
        Me.btn_Filter.Id = 171
        Me.btn_Filter.Name = "btn_Filter"
        '
        'btn_FilterClear
        '
        Me.btn_FilterClear.CommandName = "DataFilterClear"
        Me.btn_FilterClear.Id = 172
        Me.btn_FilterClear.Name = "btn_FilterClear"
        '
        'btn_Paste
        '
        Me.btn_Paste.CommandName = "PasteSelection"
        Me.btn_Paste.Id = 253
        Me.btn_Paste.Name = "btn_Paste"
        Me.btn_Paste.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_Cut
        '
        Me.btn_Cut.CommandName = "CutSelection"
        Me.btn_Cut.Id = 254
        Me.btn_Cut.Name = "btn_Cut"
        Me.btn_Cut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Copy
        '
        Me.btn_Copy.CommandName = "CopySelection"
        Me.btn_Copy.Id = 255
        Me.btn_Copy.Name = "btn_Copy"
        Me.btn_Copy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_PasteSpecial
        '
        Me.btn_PasteSpecial.CommandName = "ShowPasteSpecialForm"
        Me.btn_PasteSpecial.Id = 256
        Me.btn_PasteSpecial.Name = "btn_PasteSpecial"
        Me.btn_PasteSpecial.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btn_WrapText
        '
        Me.btn_WrapText.CommandName = "FormatWrapText"
        Me.btn_WrapText.Id = 291
        Me.btn_WrapText.Name = "btn_WrapText"
        Me.btn_WrapText.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_IncreaseDecimal
        '
        Me.btn_IncreaseDecimal.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
        Me.btn_IncreaseDecimal.CommandName = "FormatNumberIncreaseDecimal"
        Me.btn_IncreaseDecimal.Id = 307
        Me.btn_IncreaseDecimal.Name = "btn_IncreaseDecimal"
        Me.btn_IncreaseDecimal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_DecreaseDecimal
        '
        Me.btn_DecreaseDecimal.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
        Me.btn_DecreaseDecimal.CommandName = "FormatNumberDecreaseDecimal"
        Me.btn_DecreaseDecimal.Id = 308
        Me.btn_DecreaseDecimal.Name = "btn_DecreaseDecimal"
        Me.btn_DecreaseDecimal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_InsertSheetRows
        '
        Me.btn_InsertSheetRows.CommandName = "InsertSheetRows"
        Me.btn_InsertSheetRows.Id = 336
        Me.btn_InsertSheetRows.Name = "btn_InsertSheetRows"
        Me.btn_InsertSheetRows.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_Find
        '
        Me.btn_Find.CommandName = "EditingFind"
        Me.btn_Find.Id = 382
        Me.btn_Find.Name = "btn_Find"
        '
        'btn_Replace
        '
        Me.btn_Replace.CommandName = "EditingReplace"
        Me.btn_Replace.Id = 383
        Me.btn_Replace.Name = "btn_Replace"
        '
        'btn_Undo
        '
        Me.btn_Undo.CommandName = "FileUndo"
        Me.btn_Undo.Id = 396
        Me.btn_Undo.Name = "btn_Undo"
        '
        'btn_Redo
        '
        Me.btn_Redo.CommandName = "FileRedo"
        Me.btn_Redo.Id = 397
        Me.btn_Redo.Name = "btn_Redo"
        '
        'btn_Sync
        '
        Me.btn_Sync.Caption = "Sync"
        Me.btn_Sync.Id = 172
        Me.btn_Sync.ImageOptions.SvgImage = CType(resources.GetObject("btn_Sync.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Sync.Name = "btn_Sync"
        '
        'txt_CompanyName
        '
        Me.txt_CompanyName.Caption = "Company Name :"
        Me.txt_CompanyName.Edit = Me.txt_CompanyNameEdit
        Me.txt_CompanyName.EditWidth = 150
        Me.txt_CompanyName.Id = 174
        Me.txt_CompanyName.Name = "txt_CompanyName"
        '
        'txt_CompanyNameEdit
        '
        Me.txt_CompanyNameEdit.AutoHeight = False
        Me.txt_CompanyNameEdit.Name = "txt_CompanyNameEdit"
        '
        'txt_TallyVersion
        '
        Me.txt_TallyVersion.Caption = "Tally Version      :"
        Me.txt_TallyVersion.Edit = Me.txt_TallyVersionEdit
        Me.txt_TallyVersion.EditWidth = 150
        Me.txt_TallyVersion.Id = 175
        Me.txt_TallyVersion.Name = "txt_TallyVersion"
        '
        'txt_TallyVersionEdit
        '
        Me.txt_TallyVersionEdit.AutoHeight = False
        Me.txt_TallyVersionEdit.Name = "txt_TallyVersionEdit"
        '
        'txt_TallyHostURL
        '
        Me.txt_TallyHostURL.Caption = "Tally Host URL   :"
        Me.txt_TallyHostURL.Edit = Me.txt_TallyHostURLEdit
        Me.txt_TallyHostURL.EditWidth = 150
        Me.txt_TallyHostURL.Id = 176
        Me.txt_TallyHostURL.Name = "txt_TallyHostURL"
        '
        'txt_TallyHostURLEdit
        '
        Me.txt_TallyHostURLEdit.AutoHeight = False
        Me.txt_TallyHostURLEdit.Name = "txt_TallyHostURLEdit"
        '
        'txt_Year_From
        '
        Me.txt_Year_From.Caption = "Fin. Year From :"
        Me.txt_Year_From.Edit = Me.txt_Year_FromEdit
        Me.txt_Year_From.EditWidth = 60
        Me.txt_Year_From.Id = 177
        Me.txt_Year_From.Name = "txt_Year_From"
        '
        'txt_Year_FromEdit
        '
        Me.txt_Year_FromEdit.AutoHeight = False
        Me.txt_Year_FromEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Year_FromEdit.Name = "txt_Year_FromEdit"
        '
        'txt_Year_To
        '
        Me.txt_Year_To.Caption = "Fin. Year To     :"
        Me.txt_Year_To.Edit = Me.txt_Year_ToEdit
        Me.txt_Year_To.EditWidth = 60
        Me.txt_Year_To.Id = 178
        Me.txt_Year_To.Name = "txt_Year_To"
        '
        'txt_Year_ToEdit
        '
        Me.txt_Year_ToEdit.AutoHeight = False
        Me.txt_Year_ToEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Year_ToEdit.Name = "txt_Year_ToEdit"
        Me.txt_Year_ToEdit.ReadOnly = True
        '
        'btn_RefreshDates
        '
        Me.btn_RefreshDates.Caption = "  Refresh Date Values"
        Me.btn_RefreshDates.Id = 179
        Me.btn_RefreshDates.ImageOptions.SvgImage = CType(resources.GetObject("btn_RefreshDates.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_RefreshDates.Name = "btn_RefreshDates"
        Me.btn_RefreshDates.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        Me.btn_RefreshDates.SmallWithTextWidth = 145
        '
        'btn_GenerateXML_File
        '
        Me.btn_GenerateXML_File.Caption = "To File"
        Me.btn_GenerateXML_File.Id = 180
        Me.btn_GenerateXML_File.ImageOptions.SvgImage = CType(resources.GetObject("btn_GenerateXML_File.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_GenerateXML_File.Name = "btn_GenerateXML_File"
        '
        'btn_GenerateXML_Tally
        '
        Me.btn_GenerateXML_Tally.Caption = "To Tally"
        Me.btn_GenerateXML_Tally.Id = 181
        Me.btn_GenerateXML_Tally.ImageOptions.SvgImage = CType(resources.GetObject("btn_GenerateXML_Tally.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_GenerateXML_Tally.Name = "btn_GenerateXML_Tally"
        '
        'btn_NewLedger
        '
        Me.btn_NewLedger.Caption = "Create New Ledger"
        Me.btn_NewLedger.Id = 182
        Me.btn_NewLedger.ImageOptions.SvgImage = CType(resources.GetObject("btn_NewLedger.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_NewLedger.Name = "btn_NewLedger"
        '
        'btn_CustomRequest
        '
        Me.btn_CustomRequest.Caption = "Send Custom XML Request to Tally"
        Me.btn_CustomRequest.Id = 183
        Me.btn_CustomRequest.ImageOptions.SvgImage = CType(resources.GetObject("btn_CustomRequest.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_CustomRequest.Name = "btn_CustomRequest"
        '
        'txt_VoucherColumns
        '
        Me.txt_VoucherColumns.Caption = "Entry Columns :"
        Me.txt_VoucherColumns.Edit = Me.txt_VoucherColumns_Edit
        Me.txt_VoucherColumns.Id = 184
        Me.txt_VoucherColumns.Name = "txt_VoucherColumns"
        '
        'txt_VoucherColumns_Edit
        '
        Me.txt_VoucherColumns_Edit.AutoHeight = False
        Me.txt_VoucherColumns_Edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_VoucherColumns_Edit.MaxValue = New Decimal(New Integer() {11, 0, 0, 0})
        Me.txt_VoucherColumns_Edit.MinValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txt_VoucherColumns_Edit.Name = "txt_VoucherColumns_Edit"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Clipboard, Me.rpg_Tally, Me.rpg_Date, Me.rpg_Extras, Me.rpg_XML})
        Me.rp_Home.Name = "rp_Home"
        ReduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
        ReduceOperation1.Group = Nothing
        ReduceOperation1.ItemLinkIndex = 2
        ReduceOperation1.ItemLinksCount = 0
        ReduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
        Me.rp_Home.ReduceOperations.Add(ReduceOperation1)
        '
        'rpg_Clipboard
        '
        Me.rpg_Clipboard.ItemLinks.Add(Me.btn_Paste)
        Me.rpg_Clipboard.ItemLinks.Add(Me.btn_Cut)
        Me.rpg_Clipboard.ItemLinks.Add(Me.btn_Copy)
        Me.rpg_Clipboard.ItemLinks.Add(Me.btn_PasteSpecial)
        Me.rpg_Clipboard.Name = "rpg_Clipboard"
        '
        'rpg_Tally
        '
        Me.rpg_Tally.ItemLinks.Add(Me.btn_Sync)
        Me.rpg_Tally.ItemLinks.Add(Me.txt_TallyVersion, True)
        Me.rpg_Tally.ItemLinks.Add(Me.txt_TallyHostURL)
        Me.rpg_Tally.ItemLinks.Add(Me.txt_CompanyName)
        Me.rpg_Tally.Name = "rpg_Tally"
        Me.rpg_Tally.ShowCaptionButton = False
        Me.rpg_Tally.Text = "Tally"
        '
        'rpg_Date
        '
        Me.rpg_Date.ItemLinks.Add(Me.txt_Year_From)
        Me.rpg_Date.ItemLinks.Add(Me.txt_Year_To)
        Me.rpg_Date.ItemLinks.Add(Me.btn_RefreshDates)
        Me.rpg_Date.Name = "rpg_Date"
        Me.rpg_Date.ShowCaptionButton = False
        Me.rpg_Date.Text = "Date"
        '
        'rpg_Extras
        '
        Me.rpg_Extras.ItemLinks.Add(Me.btn_NewLedger)
        Me.rpg_Extras.ItemLinks.Add(Me.txt_VoucherColumns, True)
        Me.rpg_Extras.Name = "rpg_Extras"
        Me.rpg_Extras.Text = "Extras"
        '
        'rpg_XML
        '
        Me.rpg_XML.ItemLinks.Add(Me.btn_GenerateXML_File)
        Me.rpg_XML.ItemLinks.Add(Me.btn_GenerateXML_Tally)
        Me.rpg_XML.Name = "rpg_XML"
        Me.rpg_XML.ShowCaptionButton = False
        Me.rpg_XML.Text = "Generate XML"
        '
        'rp_Extras
        '
        Me.rp_Extras.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_CellOptions, Me.rpg_Filter, Me.rpg_Find, Me.rpg_Skins, Me.rpg_Testing})
        Me.rp_Extras.Name = "rp_Extras"
        Me.rp_Extras.Text = "Extras"
        '
        'rpg_CellOptions
        '
        Me.rpg_CellOptions.ItemLinks.Add(Me.btn_InsertSheetRows)
        Me.rpg_CellOptions.ItemLinks.Add(Me.btn_WrapText)
        Me.rpg_CellOptions.ItemLinks.Add(Me.btn_IncreaseDecimal)
        Me.rpg_CellOptions.ItemLinks.Add(Me.btn_DecreaseDecimal)
        Me.rpg_CellOptions.Name = "rpg_CellOptions"
        Me.rpg_CellOptions.Text = "Cell Options"
        '
        'rpg_Filter
        '
        Me.rpg_Filter.ItemLinks.Add(Me.btn_Filter)
        Me.rpg_Filter.ItemLinks.Add(Me.btn_FilterClear)
        Me.rpg_Filter.Name = "rpg_Filter"
        Me.rpg_Filter.Text = "Filter"
        '
        'rpg_Find
        '
        Me.rpg_Find.ItemLinks.Add(Me.btn_Find)
        Me.rpg_Find.ItemLinks.Add(Me.btn_Replace)
        Me.rpg_Find.Name = "rpg_Find"
        Me.rpg_Find.ShowCaptionButton = False
        Me.rpg_Find.Text = "Find"
        '
        'rpg_Skins
        '
        Me.rpg_Skins.ItemLinks.Add(Me.rgb_Skins)
        Me.rpg_Skins.Name = "rpg_Skins"
        Me.rpg_Skins.ShowCaptionButton = False
        Me.rpg_Skins.Text = "Skins"
        '
        'rpg_Testing
        '
        Me.rpg_Testing.ItemLinks.Add(Me.btn_CustomRequest)
        Me.rpg_Testing.Name = "rpg_Testing"
        Me.rpg_Testing.Text = "Testing"
        '
        'RepositoryItemPopupGalleryEdit1
        '
        Me.RepositoryItemPopupGalleryEdit1.AutoHeight = False
        Me.RepositoryItemPopupGalleryEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        '
        '
        '
        Me.RepositoryItemPopupGalleryEdit1.Gallery.AllowFilter = False
        Me.RepositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = False
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1
        Me.RepositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = False
        SpreadsheetCommandGalleryItem1.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem1.Caption = "General"
        SpreadsheetCommandGalleryItem1.CaptionAsValue = True
        SpreadsheetCommandGalleryItem1.Checked = True
        SpreadsheetCommandGalleryItem1.CommandName = "FormatNumberGeneral"
        SpreadsheetCommandGalleryItem1.Description = "No specific format."
        SpreadsheetCommandGalleryItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem1.IsEmptyHint = True
        SpreadsheetCommandGalleryItem1.Value = "General"
        SpreadsheetCommandGalleryItem2.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem2.Caption = "Number"
        SpreadsheetCommandGalleryItem2.CaptionAsValue = True
        SpreadsheetCommandGalleryItem2.CommandName = "FormatNumberDecimal"
        SpreadsheetCommandGalleryItem2.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem2.IsEmptyHint = True
        SpreadsheetCommandGalleryItem2.Value = "Number"
        SpreadsheetCommandGalleryItem3.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem3.Caption = "Currency"
        SpreadsheetCommandGalleryItem3.CaptionAsValue = True
        SpreadsheetCommandGalleryItem3.CommandName = "FormatNumberAccountingCurrency"
        SpreadsheetCommandGalleryItem3.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem3.IsEmptyHint = True
        SpreadsheetCommandGalleryItem3.Value = "Currency"
        SpreadsheetCommandGalleryItem4.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem4.Caption = "Accounting"
        SpreadsheetCommandGalleryItem4.CaptionAsValue = True
        SpreadsheetCommandGalleryItem4.CommandName = "FormatNumberAccountingRegular"
        SpreadsheetCommandGalleryItem4.ImageOptions.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem4.IsEmptyHint = True
        SpreadsheetCommandGalleryItem4.Value = "Accounting"
        SpreadsheetCommandGalleryItem5.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem5.Caption = "Short Date"
        SpreadsheetCommandGalleryItem5.CaptionAsValue = True
        SpreadsheetCommandGalleryItem5.CommandName = "FormatNumberShortDate"
        SpreadsheetCommandGalleryItem5.ImageOptions.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem5.IsEmptyHint = True
        SpreadsheetCommandGalleryItem5.Value = "Short Date"
        SpreadsheetCommandGalleryItem6.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem6.Caption = "Long Date"
        SpreadsheetCommandGalleryItem6.CaptionAsValue = True
        SpreadsheetCommandGalleryItem6.CommandName = "FormatNumberLongDate"
        SpreadsheetCommandGalleryItem6.ImageOptions.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem6.IsEmptyHint = True
        SpreadsheetCommandGalleryItem6.Value = "Long Date"
        SpreadsheetCommandGalleryItem7.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem7.Caption = "Time"
        SpreadsheetCommandGalleryItem7.CaptionAsValue = True
        SpreadsheetCommandGalleryItem7.CommandName = "FormatNumberTime"
        SpreadsheetCommandGalleryItem7.ImageOptions.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem7.IsEmptyHint = True
        SpreadsheetCommandGalleryItem7.Value = "Time"
        SpreadsheetCommandGalleryItem8.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem8.Caption = "Percentage"
        SpreadsheetCommandGalleryItem8.CaptionAsValue = True
        SpreadsheetCommandGalleryItem8.CommandName = "FormatNumberPercentage"
        SpreadsheetCommandGalleryItem8.ImageOptions.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem8.IsEmptyHint = True
        SpreadsheetCommandGalleryItem8.Value = "Percentage"
        SpreadsheetCommandGalleryItem9.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem9.Caption = "Fraction"
        SpreadsheetCommandGalleryItem9.CaptionAsValue = True
        SpreadsheetCommandGalleryItem9.CommandName = "FormatNumberFraction"
        SpreadsheetCommandGalleryItem9.ImageOptions.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem9.IsEmptyHint = True
        SpreadsheetCommandGalleryItem9.Value = "Fraction"
        SpreadsheetCommandGalleryItem10.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem10.Caption = "Scientific"
        SpreadsheetCommandGalleryItem10.CaptionAsValue = True
        SpreadsheetCommandGalleryItem10.CommandName = "FormatNumberScientific"
        SpreadsheetCommandGalleryItem10.ImageOptions.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem10.IsEmptyHint = True
        SpreadsheetCommandGalleryItem10.Value = "Scientific"
        SpreadsheetCommandGalleryItem11.AlwaysUpdateDescription = True
        SpreadsheetCommandGalleryItem11.Caption = "Text"
        SpreadsheetCommandGalleryItem11.CaptionAsValue = True
        SpreadsheetCommandGalleryItem11.CommandName = "FormatNumberText"
        SpreadsheetCommandGalleryItem11.ImageOptions.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        SpreadsheetCommandGalleryItem11.IsEmptyHint = True
        SpreadsheetCommandGalleryItem11.Value = "Text"
        GalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {SpreadsheetCommandGalleryItem1, SpreadsheetCommandGalleryItem2, SpreadsheetCommandGalleryItem3, SpreadsheetCommandGalleryItem4, SpreadsheetCommandGalleryItem5, SpreadsheetCommandGalleryItem6, SpreadsheetCommandGalleryItem7, SpreadsheetCommandGalleryItem8, SpreadsheetCommandGalleryItem9, SpreadsheetCommandGalleryItem10, SpreadsheetCommandGalleryItem11})
        Me.RepositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
        Me.RepositoryItemPopupGalleryEdit1.Gallery.RowCount = 11
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = False
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ShowItemText = True
        Me.RepositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
        Me.RepositoryItemPopupGalleryEdit1.Gallery.StretchItems = True
        Me.RepositoryItemPopupGalleryEdit1.Name = "RepositoryItemPopupGalleryEdit1"
        Me.RepositoryItemPopupGalleryEdit1.ShowButtons = False
        Me.RepositoryItemPopupGalleryEdit1.ShowPopupCloseButton = False
        Me.RepositoryItemPopupGalleryEdit1.ShowSizeGrip = False
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 669)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 31)
        '
        'MainSpreadSheet
        '
        Me.MainSpreadSheet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSpreadSheet.Location = New System.Drawing.Point(0, 29)
        Me.MainSpreadSheet.MenuManager = Me.ribbonControl
        Me.MainSpreadSheet.Name = "MainSpreadSheet"
        Me.MainSpreadSheet.Options.Behavior.Selection.MoveActiveCellMode = DevExpress.XtraSpreadsheet.MoveActiveCellModeOnEnterPress.Right
        Me.MainSpreadSheet.Options.Import.Csv.Encoding = CType(resources.GetObject("MainSpreadSheet.Options.Import.Csv.Encoding"), System.Text.Encoding)
        Me.MainSpreadSheet.Options.Import.Txt.Encoding = CType(resources.GetObject("MainSpreadSheet.Options.Import.Txt.Encoding"), System.Text.Encoding)
        Me.MainSpreadSheet.Size = New System.Drawing.Size(1100, 497)
        Me.MainSpreadSheet.TabIndex = 1
        Me.MainSpreadSheet.Text = "spreadsheetControl1"
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer1.Appearance.Options.UseBackColor = True
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Location = New System.Drawing.Point(111, 197)
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Ribbon = Me.ribbonControl
        Me.popupControlContainer1.Size = New System.Drawing.Size(76, 70)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'panel_FormulaBar
        '
        Me.panel_FormulaBar.Controls.Add(Me.MainProgressPanel)
        Me.panel_FormulaBar.Controls.Add(Me.MainSpreadSheet)
        Me.panel_FormulaBar.Controls.Add(Me.splitterControl)
        Me.panel_FormulaBar.Controls.Add(Me.formulaBarNameBoxSplitContainerControl)
        Me.panel_FormulaBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_FormulaBar.Location = New System.Drawing.Point(0, 143)
        Me.panel_FormulaBar.Name = "panel_FormulaBar"
        Me.panel_FormulaBar.Size = New System.Drawing.Size(1100, 526)
        Me.panel_FormulaBar.TabIndex = 3
        '
        'MainProgressPanel
        '
        Me.MainProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.MainProgressPanel.Appearance.Options.UseBackColor = True
        Me.MainProgressPanel.BarAnimationElementThickness = 2
        Me.MainProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MainProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainProgressPanel.Location = New System.Drawing.Point(0, 29)
        Me.MainProgressPanel.Name = "MainProgressPanel"
        Me.MainProgressPanel.Size = New System.Drawing.Size(1100, 497)
        Me.MainProgressPanel.TabIndex = 5
        Me.MainProgressPanel.Visible = False
        '
        'splitterControl
        '
        Me.splitterControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitterControl.Location = New System.Drawing.Point(0, 24)
        Me.splitterControl.MinSize = 20
        Me.splitterControl.Name = "splitterControl"
        Me.splitterControl.Size = New System.Drawing.Size(1100, 5)
        Me.splitterControl.TabIndex = 2
        Me.splitterControl.TabStop = False
        '
        'formulaBarNameBoxSplitContainerControl
        '
        Me.formulaBarNameBoxSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.formulaBarNameBoxSplitContainerControl.Location = New System.Drawing.Point(0, 0)
        Me.formulaBarNameBoxSplitContainerControl.MinimumSize = New System.Drawing.Size(0, 24)
        Me.formulaBarNameBoxSplitContainerControl.Name = "formulaBarNameBoxSplitContainerControl"
        Me.formulaBarNameBoxSplitContainerControl.Panel1.Controls.Add(Me.txt_NameBox)
        Me.formulaBarNameBoxSplitContainerControl.Panel2.Controls.Add(Me.txt_FormulaBar)
        Me.formulaBarNameBoxSplitContainerControl.Size = New System.Drawing.Size(1100, 24)
        Me.formulaBarNameBoxSplitContainerControl.SplitterPosition = 145
        Me.formulaBarNameBoxSplitContainerControl.TabIndex = 3
        '
        'txt_NameBox
        '
        Me.txt_NameBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_NameBox.EditValue = "A1"
        Me.txt_NameBox.Location = New System.Drawing.Point(0, 0)
        Me.txt_NameBox.Name = "txt_NameBox"
        Me.txt_NameBox.Properties.AutoHeight = False
        Me.txt_NameBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.txt_NameBox.Size = New System.Drawing.Size(145, 24)
        Me.txt_NameBox.SpreadsheetControl = Me.MainSpreadSheet
        Me.txt_NameBox.TabIndex = 0
        '
        'txt_FormulaBar
        '
        Me.txt_FormulaBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_FormulaBar.Location = New System.Drawing.Point(0, 0)
        Me.txt_FormulaBar.MinimumSize = New System.Drawing.Size(0, 20)
        Me.txt_FormulaBar.Name = "txt_FormulaBar"
        Me.txt_FormulaBar.Size = New System.Drawing.Size(950, 24)
        Me.txt_FormulaBar.SpreadsheetControl = Me.MainSpreadSheet
        Me.txt_FormulaBar.TabIndex = 0
        '
        'SpreadsheetBarController1
        '
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Filter)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_FilterClear)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Paste)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Cut)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Copy)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_PasteSpecial)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_WrapText)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_IncreaseDecimal)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_DecreaseDecimal)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_InsertSheetRows)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Find)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Replace)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_New)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Open)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Save)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_SaveAs)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Undo)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_Redo)
        Me.SpreadsheetBarController1.BarItems.Add(Me.btn_DocumentInfo)
        Me.SpreadsheetBarController1.Control = Me.MainSpreadSheet
        '
        'SaveFileDialog_XML
        '
        Me.SaveFileDialog_XML.FileName = "Tally Vouchers.xml"
        Me.SaveFileDialog_XML.Filter = "eXtendted Markeup Language Files (*.xml)|*.xml"
        Me.SaveFileDialog_XML.Title = "Select Path to Save Generated XML"
        '
        'frm_Main
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.panel_FormulaBar)
        Me.Controls.Add(Me.popupControlContainer1)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Devil7 - Tally Auto Entry"
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CompanyNameEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TallyVersionEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TallyHostURLEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Year_FromEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Year_ToEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_VoucherColumns_Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_FormulaBar.ResumeLayout(False)
        CType(Me.formulaBarNameBoxSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formulaBarNameBoxSplitContainerControl.ResumeLayout(False)
        CType(Me.txt_NameBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents rpg_Skins As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgb_Skins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents panel_FormulaBar As System.Windows.Forms.Panel
    Private WithEvents MainSpreadSheet As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Private WithEvents splitterControl As DevExpress.XtraEditors.SplitterControl
    Private WithEvents formulaBarNameBoxSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents txt_NameBox As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
    Private WithEvents txt_FormulaBar As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
    Friend WithEvents btn_Filter As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
    Friend WithEvents btn_FilterClear As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Paste As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Cut As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Copy As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_PasteSpecial As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_WrapText As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
    Friend WithEvents RepositoryItemPopupGalleryEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit
    Friend WithEvents btn_IncreaseDecimal As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_DecreaseDecimal As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_InsertSheetRows As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Find As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Replace As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_New As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Open As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_SaveAs As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Undo As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_Redo As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents btn_DocumentInfo As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    Friend WithEvents rp_Home As DevExpress.XtraSpreadsheet.UI.HomeRibbonPage
    Friend WithEvents rpg_Clipboard As DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup
    Friend WithEvents rpg_CellOptions As DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup
    Friend WithEvents rpg_Filter As DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup
    Friend WithEvents SpreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
    Friend WithEvents btn_Exit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MainMenu As ApplicationMenu
    Friend WithEvents rp_Extras As RibbonPage
    Friend WithEvents rpg_Find As RibbonPageGroup
    Friend WithEvents btn_Sync As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Tally As RibbonPageGroup
    Friend WithEvents MainProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents txt_CompanyName As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_CompanyNameEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_TallyVersion As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_TallyVersionEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_TallyHostURL As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_TallyHostURLEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_Year_From As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_Year_FromEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txt_Year_To As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_Year_ToEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents btn_RefreshDates As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Date As RibbonPageGroup
    Friend WithEvents rpg_XML As RibbonPageGroup
    Friend WithEvents btn_GenerateXML_File As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaveFileDialog_XML As DevExpress.XtraEditors.XtraSaveFileDialog
    Friend WithEvents btn_GenerateXML_Tally As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_NewLedger As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Extras As RibbonPageGroup
    Friend WithEvents btn_CustomRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Testing As RibbonPageGroup
    Friend WithEvents txt_VoucherColumns As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_VoucherColumns_Edit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
