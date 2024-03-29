﻿'=========================================================================='
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

Namespace Classes
    Module PublicFunctions

        Public Function ProcessString(ByVal Text As String) As String
            Dim R As String = Text
            R = R.Replace("&amp;", "&")
            Return R
        End Function

        Public Function CEffect(ByVal Effect As String) As Objects.Effect
            Dim E As Objects.Effect = Objects.Effect.Dr
            If Effect = "Dr." Then
                E = Objects.Effect.Dr
            ElseIf Effect = "Cr." Then
                E = Objects.Effect.Cr
            End If
            Return E
        End Function

        Public Sub WriteErrorResponse(ByVal Response As Objects.Response)
            Dim Filename As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, String.Format("ErrorReport_{0}.xml", Now.ToString("yyyyMMdd_hhmmss")))
            My.Computer.FileSystem.WriteAllText(Filename, Response.Data, False)
            MsgBox("Unknown Error Occured. Error Report Saved to Desktop.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End Sub

    End Module
End Namespace