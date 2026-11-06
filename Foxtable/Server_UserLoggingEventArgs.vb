Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001B6 RID: 438
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Server_UserLoggingEventArgs
		' Token: 0x0600147B RID: 5243 RVA: 0x00081029 File Offset: 0x0007F229
		Friend Sub New(A_0 As String, A_1 As String, A_2 As IMServer, A_3 As oO__oO_0_O, A_4 As String())
			Me.oo_O._. = New List(Of String)()
			Me.o_o._O0O_. = A_0
			Me.O.0Oo_o0. = A_1
			Me.o_o._O0O_. = A_2
			Me.o_o._O0O_. = A_3
			Me.o_o._O0O_. = A_4
		End Sub

		' Token: 0x1700044E RID: 1102
		' (get) Token: 0x0600147C RID: 5244 RVA: 0x00081061 File Offset: 0x0007F261
		Public ReadOnly Property Password As String
			Get
				Return Me.O.0Oo_o0.
			End Get
		End Property

		' Token: 0x1700044F RID: 1103
		' (get) Token: 0x0600147D RID: 5245 RVA: 0x00081069 File Offset: 0x0007F269
		Public ReadOnly Property UserName As String
			Get
				Return Me.o_o._O0O_.
			End Get
		End Property

		' Token: 0x17000450 RID: 1104
		' (get) Token: 0x0600147E RID: 5246 RVA: 0x00081071 File Offset: 0x0007F271
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Server As IMServer
			Get
				Return Me.o_o._O0O_.
			End Get
		End Property

		' Token: 0x17000451 RID: 1105
		' (get) Token: 0x0600147F RID: 5247 RVA: 0x00081079 File Offset: 0x0007F279
		' (set) Token: 0x06001480 RID: 5248 RVA: 0x00081081 File Offset: 0x0007F281
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AsyncExecute As Boolean
			Get
				Return Me.oo0_O00.o_0.
			End Get
			Set(value As Boolean)
				Me.oo0_O00.o_0. = True
			End Set
		End Property

		' Token: 0x17000452 RID: 1106
		' (set) Token: 0x06001481 RID: 5249 RVA: 0x0008108C File Offset: 0x0007F28C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public WriteOnly Property Handled As Boolean
			Set(value As Boolean)
				If value Then
					Dim method As ooo_0_ = AddressOf o0___oO.O.oOo0O0O.
					If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						OO_00oOO.BaseMainForm.Invoke(method, New Object() { Me.o_o._O0O_., Me, Me.o_o._O0O_., Me.o_o._O0O_. })
					End If
				End If
			End Set
		End Property

		' Token: 0x17000453 RID: 1107
		' (get) Token: 0x06001482 RID: 5250 RVA: 0x000810ED File Offset: 0x0007F2ED
		' (set) Token: 0x06001483 RID: 5251 RVA: 0x000810F5 File Offset: 0x0007F2F5
		Public Property Success As Boolean
			Get
				Return Me.o_o._O0O_.
			End Get
			Set(value As Boolean)
				Me.o_o._O0O_. = value
			End Set
		End Property

		' Token: 0x17000454 RID: 1108
		' (get) Token: 0x06001484 RID: 5252 RVA: 0x000810FE File Offset: 0x0007F2FE
		' (set) Token: 0x06001485 RID: 5253 RVA: 0x00081106 File Offset: 0x0007F306
		Public Property Message As String
			Get
				Return Me.Oooo0.o.
			End Get
			Set(value As String)
				Me.Oooo0.o. = value
			End Set
		End Property

		' Token: 0x17000455 RID: 1109
		' (get) Token: 0x06001486 RID: 5254 RVA: 0x0008110F File Offset: 0x0007F30F
		Public ReadOnly Property Buddies As List(Of String)
			Get
				Return Me.oo_O._.
			End Get
		End Property

		' Token: 0x17000456 RID: 1110
		' (get) Token: 0x06001487 RID: 5255 RVA: 0x00081117 File Offset: 0x0007F317
		' (set) Token: 0x06001488 RID: 5256 RVA: 0x0008111F File Offset: 0x0007F31F
		Friend Property BuildIn As Boolean
			Get
				Return Me.O.0Oo_o0.
			End Get
			Set(value As Boolean)
				Me.O.0Oo_o0. = value
			End Set
		End Property

		' Token: 0x17000457 RID: 1111
		' (get) Token: 0x06001489 RID: 5257 RVA: 0x00081128 File Offset: 0x0007F328
		Public ReadOnly Property User As UserInfo
			Get
				Dim result As UserInfo
				If Me.a = 1 Then
					result = Me.a
				Else
					Me.a = 1
					If Me.Server.Buildin Then
						Dim array As String() = Me.UserName.Split(New Char() { "."c })
						Dim userInfo As UserInfo = Nothing
						Dim text As String
						If array.Length = 2 Then
							text = array(1)
						Else
							text = Me.UserName
						End If
						If OO_00oOO.Users.Contains(text) Then
							userInfo = OO_00oOO.Users(text)
							If userInfo.Type = 2 Then
								If Operators.CompareString(userInfo.Password, Me.Password, True) <> 0 Then
									O_O0OO.OoO_o.oO0o0O.(text, OO_00oOO.Users.UserView.Table)
									userInfo = OO_00oOO.Users(text)
								End If
							Else
								Dim text2 As String = O_O0OO.O_O._Oo.()
								If Operators.CompareString(userInfo.Password, O00.MD5Encrypt(O00.ooo000o_0.00o0.(Me.Password, text2.Substring(0, 8), text2.Substring(text2.Length - 8))), True) <> 0 Then
									O_O0OO.OoO_o.oO0o0O.(text, OO_00oOO.Users.UserView.Table)
									userInfo = OO_00oOO.Users(text)
								End If
							End If
						Else
							O_O0OO.OoO_o.oO0o0O.(text, OO_00oOO.Users.UserView.Table)
							If OO_00oOO.Users.Contains(text) Then
								userInfo = OO_00oOO.Users(text)
							End If
						End If
						If userInfo IsNot Nothing Then
							If userInfo.Type = 2 Then
								If Operators.CompareString(userInfo.Password, Me.Password, True) = 0 Then
									Me.a = userInfo
									Return Me.a
								End If
							Else
								Dim text3 As String = O_O0OO.O_O._Oo.()
								If Operators.CompareString(userInfo.Password, O00.MD5Encrypt(O00.ooo000o_0.00o0.(Me.Password, text3.Substring(0, 8), text3.Substring(text3.Length - 8))), True) = 0 Then
									Me.a = userInfo
									Return Me.a
								End If
							End If
						End If
					End If
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x040007F7 RID: 2039
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007F8 RID: 2040
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007F9 RID: 2041
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040007FA RID: 2042
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007FB RID: 2043
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x040007FC RID: 2044
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040007FD RID: 2045
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x040007FE RID: 2046
		Private <<EMPTY_NAME>> As UserInfo

		' Token: 0x040007FF RID: 2047
		Friend <<EMPTY_NAME>> As oO__oO_0_O

		' Token: 0x04000800 RID: 2048
		Friend <<EMPTY_NAME>> As String()

		' Token: 0x04000801 RID: 2049
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000802 RID: 2050
		Private a As UserInfo

		' Token: 0x04000803 RID: 2051
		Private a As Integer
	End Class
End Namespace
