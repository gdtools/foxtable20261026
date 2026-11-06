Imports System
Imports System.ComponentModel
Imports JinDI_SmsComLib
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000255 RID: 597
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FoxSMSControl
		Inherits SmsControlClass

		' Token: 0x06001B9B RID: 7067 RVA: 0x000ADDC0 File Offset: 0x000ABFC0
		Public Sub New()
			MyBase.ConnectModemResult += New _ISmsControlEvents_ConnectModemResultEventHandler(Me, CType(ldftn(AddressOf oOo00O0._oO.), UIntPtr))
			MyBase.NewMessage += New _ISmsControlEvents_NewMessageEventHandler(Me, CType(ldftn(AddressOf o0__o.O0.), UIntPtr))
			MyBase.ReceivedCall += New _ISmsControlEvents_ReceivedCallEventHandler(Me, CType(ldftn(AddressOf o0__o.O0.), UIntPtr))
			MyBase.SentMsgStatus += New _ISmsControlEvents_SentMsgStatusEventHandler(Me, CType(ldftn(AddressOf o0__o.O0.), UIntPtr))
			MyBase.SimCardNoMemory += New _ISmsControlEvents_SimCardNoMemoryEventHandler(Me, CType(ldftn(AddressOf o__0oo.___o_.), UIntPtr))
			MyBase.SimCardNoMoney += New _ISmsControlEvents_SimCardNoMoneyEventHandler(Me, CType(ldftn(AddressOf oOo00O0._oO.), UIntPtr))
			Me.AutoDelMsg = True
			Me.Settings = 0
			Me.CountryCode = "86"
			Me.SyncWorkMode = False
		End Sub

		' Token: 0x17000649 RID: 1609
		' (get) Token: 0x06001B9C RID: 7068 RVA: 0x000ADE5F File Offset: 0x000AC05F
		Public ReadOnly Property Ready As Boolean
			Get
				Return Not MyBase.IsOpen
			End Get
		End Property

		' Token: 0x1700064A RID: 1610
		' (get) Token: 0x06001B9D RID: 7069 RVA: 0x000ADE6A File Offset: 0x000AC06A
		' (set) Token: 0x06001B9E RID: 7070 RVA: 0x000ADE72 File Offset: 0x000AC072
		Public Property BaudRate As Integer
			Get
				Return MyBase.Settings
			End Get
			Set(value As Integer)
				MyBase.Settings = value
			End Set
		End Property

		' Token: 0x1700064B RID: 1611
		' (get) Token: 0x06001B9F RID: 7071 RVA: 0x000ADE7C File Offset: 0x000AC07C
		Public ReadOnly Property SimMsgCount As Integer
			Get
				Dim result As Short = 0S
				OO_00oOO.FoxSMS.GetSimNum(result)
				Return CInt(result)
			End Get
		End Property

		' Token: 0x1700064C RID: 1612
		' (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000ADE9C File Offset: 0x000AC09C
		Public ReadOnly Property SimMsgcapacity As Integer
			Get
				Dim num As Short = 0S
				Return CInt(OO_00oOO.FoxSMS.GetSimNum(num))
			End Get
		End Property

		' Token: 0x06001BA1 RID: 7073 RVA: 0x000ADEB8 File Offset: 0x000AC0B8
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim connectModemResultEventArgs As ConnectModemResultEventArgs = New ConnectModemResultEventArgs(A_0)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "ConnectModemResult", New Object() { connectModemResultEventArgs }, False, "项目", False)
		End Sub

		' Token: 0x06001BA2 RID: 7074 RVA: 0x000ADEF0 File Offset: 0x000AC0F0
		Private Sub <<EMPTY_NAME>>(A_0 As Short, A_1 As Short, A_2 As String, A_3 As String, A_4 As DateTime)
			Dim newMessageEventArgs As NewMessageEventArgs = New NewMessageEventArgs(A_0, A_1, A_2, A_3, A_4)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "NewMessage", New Object() { newMessageEventArgs }, False, "项目", False)
		End Sub

		' Token: 0x06001BA3 RID: 7075 RVA: 0x000ADF2C File Offset: 0x000AC12C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If Operators.CompareString(Me.oOo00O0._oO., A_0, True) = 0 AndAlso (DateTime.Now - Me.oOo00O0._oO.).TotalSeconds < 4.0 Then
				Me.oOo00O0._oO. = A_0
				Me.oOo00O0._oO. = DateTime.Now
				Return
			End If
			Me.oOo00O0._oO. = A_0
			Me.oOo00O0._oO. = DateTime.Now
			Dim receivedCallEventArgs As ReceivedCallEventArgs = New ReceivedCallEventArgs(A_0)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "ReceivedCall", New Object() { receivedCallEventArgs }, False, "项目", False)
		End Sub

		' Token: 0x06001BA4 RID: 7076 RVA: 0x000ADFB8 File Offset: 0x000AC1B8
		Private Sub <<EMPTY_NAME>>(A_0 As UInteger, A_1 As String, A_2 As String, A_3 As Short, A_4 As Boolean)
			Dim sentMsgStatusEventArgs As SentMsgStatusEventArgs = New SentMsgStatusEventArgs(A_0, A_1, A_2, A_3, A_4)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SentMsgStatus", New Object() { sentMsgStatusEventArgs }, False, "项目", False)
		End Sub

		' Token: 0x06001BA5 RID: 7077 RVA: 0x000ADFF3 File Offset: 0x000AC1F3
		Private Sub <<EMPTY_NAME>>()
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SimCardNoMemory", Nothing, False, "项目", False)
		End Sub

		' Token: 0x06001BA6 RID: 7078 RVA: 0x000AE00D File Offset: 0x000AC20D
		Private Sub <<EMPTY_NAME>>()
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SimCardNoMoney", Nothing, False, "项目", False)
		End Sub

		' Token: 0x04000BBB RID: 3003
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000BBC RID: 3004
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
