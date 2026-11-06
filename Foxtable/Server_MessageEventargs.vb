Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001B3 RID: 435
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Server_MessageEventargs
		' Token: 0x0600146A RID: 5226 RVA: 0x00080F09 File Offset: 0x0007F109
		Friend Sub New(A_0 As IMServer, A_1 As String, A_2 As String, A_3 As oO__oO_0_O, A_4 As String())
			Me.o__.O0_0. = A_0
			Me.o__.O0_0. = A_1
			Me.O0_0OO00ooO.0. = A_2
			Me.o__.O0_0. = A_3
			Me.o__.O0_0. = A_4
		End Sub

		' Token: 0x17000446 RID: 1094
		' (get) Token: 0x0600146B RID: 5227 RVA: 0x00080F36 File Offset: 0x0007F136
		Public ReadOnly Property UserName As String
			Get
				Return Me.o__.O0_0.
			End Get
		End Property

		' Token: 0x17000447 RID: 1095
		' (get) Token: 0x0600146C RID: 5228 RVA: 0x00080F3E File Offset: 0x0007F13E
		Public ReadOnly Property Message As String
			Get
				Return Me.O0_0OO00ooO.0.
			End Get
		End Property

		' Token: 0x17000448 RID: 1096
		' (get) Token: 0x0600146D RID: 5229 RVA: 0x00080F46 File Offset: 0x0007F146
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Server As IMServer
			Get
				Return Me.o__.O0_0.
			End Get
		End Property

		' Token: 0x17000449 RID: 1097
		' (get) Token: 0x0600146E RID: 5230 RVA: 0x00080F4E File Offset: 0x0007F14E
		' (set) Token: 0x0600146F RID: 5231 RVA: 0x00080F56 File Offset: 0x0007F156
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AsyncExecute As Boolean
			Get
				Return Me.o__.O0_0.
			End Get
			Set(value As Boolean)
				Me.o__.O0_0. = True
			End Set
		End Property

		' Token: 0x1700044A RID: 1098
		' (set) Token: 0x06001470 RID: 5232 RVA: 0x00080F60 File Offset: 0x0007F160
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public WriteOnly Property Handled As Boolean
			Set(value As Boolean)
				If value Then
					Dim method As o_OOO_o0_ = AddressOf Me.O0_00._0o0.
					If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						OO_00oOO.BaseMainForm.Invoke(method)
					End If
				End If
			End Set
		End Property

		' Token: 0x06001471 RID: 5233 RVA: 0x00080F9C File Offset: 0x0007F19C
		Private Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.ReturnValue, "", True) > 0 Then
				Dim a_ As String = "$" & vbVerticalTab & vbVerticalTab + Me.ReturnValue + vbVerticalTab + Me.o__.O0_0.(3)
				Me.o__.O0_0..O0o_.Oo0oo.(Me.o__.O0_0..Oo0oo._.(), a_)
			End If
		End Sub

		' Token: 0x1700044B RID: 1099
		' (get) Token: 0x06001472 RID: 5234 RVA: 0x00080FF2 File Offset: 0x0007F1F2
		' (set) Token: 0x06001473 RID: 5235 RVA: 0x00080FFA File Offset: 0x0007F1FA
		Public Property ReturnValue As String
			Get
				Return Me.OOO.o0_o.
			End Get
			Set(value As String)
				Me.OOO.o0_o. = value
			End Set
		End Property

		' Token: 0x040007EE RID: 2030
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x040007EF RID: 2031
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007F0 RID: 2032
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007F1 RID: 2033
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007F2 RID: 2034
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040007F3 RID: 2035
		Private <<EMPTY_NAME>> As oO__oO_0_O

		' Token: 0x040007F4 RID: 2036
		Friend <<EMPTY_NAME>> As String()
	End Class
End Namespace
