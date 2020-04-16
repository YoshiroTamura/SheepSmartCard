Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1

    <DllImport("SheepSmartCard64.dll", EntryPoint:="GetSmartCardUID")>
    Private Shared Function GetSmartCardUID64(ByVal SCardIDm As Byte()) As Integer
    End Function

    <DllImport("SheepSmartCard32.dll", EntryPoint:="GetSmartCardUID")>
    Private Shared Function GetSmartCardUID32(ByVal SCardIDm As Byte()) As Integer
    End Function

    Delegate Function CallDllDelegate(ByVal SCardIDm As Byte()) As Integer

    Private Sub btnReadUID_Click(sender As Object, e As EventArgs) Handles btnReadUID.Click

        Dim GetSmartCardIDm As CallDllDelegate
        If (Environment.Is64BitProcess) Then
            GetSmartCardIDm = New CallDllDelegate(AddressOf GetSmartCardUID64)
        Else
            GetSmartCardIDm = New CallDllDelegate(AddressOf GetSmartCardUID32)
        End If

        Me.txtSCardIDm.Text = ""
        Me.txtErrMsg.Text = ""

        Dim bRecvBuffer As Byte() = Encoding.Unicode.GetBytes(New String(vbNullChar, 128))
        Dim ret As Integer = GetSmartCardIDm(bRecvBuffer)
        Dim idm As String = Encoding.ASCII.GetString(bRecvBuffer).TrimEnd(vbNullChar)

        Select Case ret
            Case 0
                Me.txtSCardIDm.Text = idm
            Case 100
                Me.txtErrMsg.Text = "No card detected, or the card is unreadable."
            Case 200
                Me.txtErrMsg.Text = "A smart card reader is not detected." & Environment.NewLine & "Please confirm it is connected to this pc."
            Case 300
                Me.txtErrMsg.Text = "The smart card service is not running" & Environment.NewLine & "or it is not installed."
            Case 400
                Me.txtErrMsg.Text = "Failed to get the card UID."
            Case Else
                Me.txtErrMsg.Text = "An unexpected error has occurred"
        End Select

    End Sub
End Class
