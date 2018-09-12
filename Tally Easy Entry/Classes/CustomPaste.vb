
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.XtraSpreadsheet.Commands
Imports DevExpress.XtraSpreadsheet.Services

Public Class CustomSpreadsheetCommandFactoryService
    Implements ISpreadsheetCommandFactoryService

    ReadOnly service As ISpreadsheetCommandFactoryService
    ReadOnly control As SpreadsheetControl

    Public Sub New(ByVal control As SpreadsheetControl, ByVal service As ISpreadsheetCommandFactoryService)
        DevExpress.Utils.Guard.ArgumentNotNull(control, "control")
        DevExpress.Utils.Guard.ArgumentNotNull(service, "service")
        Me.control = control
        Me.service = service
    End Sub

    Public Function CreateCommand(ByVal id As SpreadsheetCommandId) As SpreadsheetCommand Implements ISpreadsheetCommandFactoryService.CreateCommand
        If id = SpreadsheetCommandId.PasteSelection Then Return New CustomPasteSelection(control)
        Return service.CreateCommand(id)
    End Function
End Class

Public Class CustomPasteSelection
    Inherits PasteSelectionCommand

    Public Sub New(ByVal control As ISpreadsheetControl)
        MyBase.New(control)
        Dim po As DevExpress.XtraSpreadsheet.Model.ModelPasteSpecialOptions = New DevExpress.XtraSpreadsheet.Model.ModelPasteSpecialOptions()
        po.InnerFlags = DevExpress.XtraSpreadsheet.Model.ModelPasteSpecialFlags.Values
        Me.PasteOptions = po
    End Sub
End Class