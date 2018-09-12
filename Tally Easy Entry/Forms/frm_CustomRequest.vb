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

Public Class frm_CustomRequest

    Dim Tally As Classes.TallyIO

    Public Sub New(ByVal Tally As Classes.TallyIO)
        InitializeComponent()
        Me.Tally = Tally
    End Sub

    Sub EnableControls()
        If InvokeRequired Then
            Invoke(Sub() EnableControls())
        Else
            txt_Request.Enabled = True
            btn_Send.Enabled = True
            ProgressPanel.Visible = False
        End If
    End Sub

    Sub DisableControls()
        If InvokeRequired Then
            Invoke(Sub() DisableControls())
        Else
            txt_Request.Enabled = False
            btn_Send.Enabled = False
            ProgressPanel.Visible = True
        End If
    End Sub

    Private Async Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        DisableControls()
        Try
            txt_Response.Text = (Await Tally.SendRequestToTally(txt_Request.Text)).Data
        Catch ex As Exception
            MsgBox("Error on processing request." & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Try
        EnableControls()
    End Sub

End Class
