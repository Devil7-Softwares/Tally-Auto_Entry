Partial Class frm_CustomRequest
    Inherits Classes.XtraFormTemp

    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CustomRequest))
        Me.MainContainer = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grp_Request = New DevExpress.XtraEditors.GroupControl()
        Me.grp_Response = New DevExpress.XtraEditors.GroupControl()
        Me.Panel_Controls = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Send = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_Request = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_Response = New DevExpress.XtraEditors.MemoEdit()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.MainContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainContainer.SuspendLayout()
        CType(Me.grp_Request, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Request.SuspendLayout()
        CType(Me.grp_Response, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Response.SuspendLayout()
        CType(Me.Panel_Controls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Controls.SuspendLayout()
        CType(Me.txt_Request.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Response.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainContainer
        '
        Me.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContainer.Horizontal = False
        Me.MainContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.Panel1.Controls.Add(Me.grp_Request)
        Me.MainContainer.Panel1.Controls.Add(Me.Panel_Controls)
        Me.MainContainer.Panel1.Text = "Panel1"
        Me.MainContainer.Panel2.Controls.Add(Me.grp_Response)
        Me.MainContainer.Panel2.Text = "Panel2"
        Me.MainContainer.Size = New System.Drawing.Size(559, 400)
        Me.MainContainer.SplitterPosition = 187
        Me.MainContainer.TabIndex = 0
        Me.MainContainer.Text = "SplitContainerControl1"
        '
        'grp_Request
        '
        Me.grp_Request.Controls.Add(Me.txt_Request)
        Me.grp_Request.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_Request.Location = New System.Drawing.Point(0, 0)
        Me.grp_Request.Name = "grp_Request"
        Me.grp_Request.Size = New System.Drawing.Size(559, 151)
        Me.grp_Request.TabIndex = 0
        Me.grp_Request.Text = "Request"
        '
        'grp_Response
        '
        Me.grp_Response.Controls.Add(Me.ProgressPanel)
        Me.grp_Response.Controls.Add(Me.txt_Response)
        Me.grp_Response.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_Response.Location = New System.Drawing.Point(0, 0)
        Me.grp_Response.Name = "grp_Response"
        Me.grp_Response.Size = New System.Drawing.Size(559, 208)
        Me.grp_Response.TabIndex = 0
        Me.grp_Response.Text = "Response"
        '
        'Panel_Controls
        '
        Me.Panel_Controls.Controls.Add(Me.btn_Send)
        Me.Panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Controls.Location = New System.Drawing.Point(0, 151)
        Me.Panel_Controls.Name = "Panel_Controls"
        Me.Panel_Controls.Size = New System.Drawing.Size(559, 36)
        Me.Panel_Controls.TabIndex = 1
        '
        'btn_Send
        '
        Me.btn_Send.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Send.Location = New System.Drawing.Point(2, 2)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(75, 32)
        Me.btn_Send.TabIndex = 0
        Me.btn_Send.Text = "Send Request"
        '
        'txt_Request
        '
        Me.txt_Request.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Request.Location = New System.Drawing.Point(2, 20)
        Me.txt_Request.Name = "txt_Request"
        Me.txt_Request.Size = New System.Drawing.Size(555, 129)
        Me.txt_Request.TabIndex = 0
        '
        'txt_Response
        '
        Me.txt_Response.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Response.Location = New System.Drawing.Point(2, 20)
        Me.txt_Response.Name = "txt_Response"
        Me.txt_Response.Size = New System.Drawing.Size(555, 186)
        Me.txt_Response.TabIndex = 0
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.BarAnimationElementThickness = 2
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel.Location = New System.Drawing.Point(2, 20)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(555, 186)
        Me.ProgressPanel.TabIndex = 1
        Me.ProgressPanel.Text = "ProgressPanel1"
        '
        'frm_CustomRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 400)
        Me.Controls.Add(Me.MainContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CustomRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom XML Request"
        CType(Me.MainContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainContainer.ResumeLayout(False)
        CType(Me.grp_Request, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Request.ResumeLayout(False)
        CType(Me.grp_Response, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Response.ResumeLayout(False)
        CType(Me.Panel_Controls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Controls.ResumeLayout(False)
        CType(Me.txt_Request.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Response.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainContainer As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents grp_Request As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grp_Response As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_Request As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel_Controls As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Response As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
End Class
