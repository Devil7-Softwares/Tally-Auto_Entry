<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_NewLedger
    Inherits Classes.XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_NewLedger))
        Me.btn_CreateLedger = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Ledger = New DevExpress.XtraEditors.TextEdit()
        Me.cmb_Group = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_OpeningBalance = New DevExpress.XtraEditors.SpinEdit()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.txt_Ledger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OpeningBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_CreateLedger
        '
        Me.btn_CreateLedger.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CreateLedger.Location = New System.Drawing.Point(314, 86)
        Me.btn_CreateLedger.Name = "btn_CreateLedger"
        Me.btn_CreateLedger.Size = New System.Drawing.Size(83, 23)
        Me.btn_CreateLedger.TabIndex = 3
        Me.btn_CreateLedger.Text = "Create Ledger"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ledger Name :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Under Group :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Opening Balance :"
        '
        'txt_Ledger
        '
        Me.txt_Ledger.EnterMoveNextControl = True
        Me.txt_Ledger.Location = New System.Drawing.Point(107, 6)
        Me.txt_Ledger.Name = "txt_Ledger"
        Me.txt_Ledger.Size = New System.Drawing.Size(290, 20)
        Me.txt_Ledger.TabIndex = 0
        '
        'cmb_Group
        '
        Me.cmb_Group.EnterMoveNextControl = True
        Me.cmb_Group.Location = New System.Drawing.Point(107, 33)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Group.Properties.Items.AddRange(New Object() {"Bank OCC A/c", "Bank OD A/c", "Branch / Divisions", "Cash-in-Hand", "Current Assets", "Current Liabilities", "Direct Expenses", "Direct Incomes", "Duties & Taxes", "Expenses (Direct)", "Expenses (Indirect)", "Fixed Assets", "Income (Direct)", "Income (Indirect)", "Indirect Expenses", "Indirect Incomes", "Investments", "Loans & Advances (Assets)", "Loans (Liability)", "Misc. Expenses (ASSET)", "Provisions", "Purchase Accounts", "Reserves & Surplus", "Retained Earnings", "Secured Loans", "Stock-in-Hand", "Sundry Creditors", "Sundry Debtors", "Suspense A/c", "Unsecured Loans"})
        Me.cmb_Group.Size = New System.Drawing.Size(290, 20)
        Me.cmb_Group.TabIndex = 1
        '
        'txt_OpeningBalance
        '
        Me.txt_OpeningBalance.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_OpeningBalance.EnterMoveNextControl = True
        Me.txt_OpeningBalance.Location = New System.Drawing.Point(107, 58)
        Me.txt_OpeningBalance.Name = "txt_OpeningBalance"
        Me.txt_OpeningBalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_OpeningBalance.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.txt_OpeningBalance.Size = New System.Drawing.Size(290, 20)
        Me.txt_OpeningBalance.TabIndex = 2
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(409, 121)
        Me.ProgressPanel1.TabIndex = 4
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'frm_NewLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 121)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.Controls.Add(Me.txt_OpeningBalance)
        Me.Controls.Add(Me.cmb_Group)
        Me.Controls.Add(Me.txt_Ledger)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_CreateLedger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_NewLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Ledger"
        CType(Me.txt_Ledger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Group.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OpeningBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_CreateLedger As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Ledger As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmb_Group As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_OpeningBalance As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
End Class
