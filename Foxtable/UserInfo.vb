Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000252 RID: 594
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0609")>
	Public Class UserInfo
		' Token: 0x06001B6F RID: 7023 RVA: 0x000AD993 File Offset: 0x000ABB93
		Public Sub New()
			Me.OOO_o00.0. = New Dictionary(Of String, Object)()
		End Sub

		' Token: 0x17000637 RID: 1591
		' (get) Token: 0x06001B70 RID: 7024 RVA: 0x000AD9A6 File Offset: 0x000ABBA6
		' (set) Token: 0x06001B71 RID: 7025 RVA: 0x000AD9AE File Offset: 0x000ABBAE
		Public Property Name As String
			Get
				Return Me.OOO_o00.0.
			End Get
			Friend Set(value As String)
				If OO_00oOO.User IsNot Me Then
					Me.OOO_o00.0. = value
				End If
			End Set
		End Property

		' Token: 0x17000638 RID: 1592
		' (get) Token: 0x06001B72 RID: 7026 RVA: 0x000AD9BF File Offset: 0x000ABBBF
		' (set) Token: 0x06001B73 RID: 7027 RVA: 0x000AD9C7 File Offset: 0x000ABBC7
		Public Property Group As String
			Get
				Return Me.O_oO0OOO.o0_o_.
			End Get
			Friend Set(value As String)
				If OO_00oOO.User IsNot Me Then
					Me.O_oO0OOO.o0_o_. = value
				End If
			End Set
		End Property

		' Token: 0x17000639 RID: 1593
		' (get) Token: 0x06001B74 RID: 7028 RVA: 0x000AD9D8 File Offset: 0x000ABBD8
		' (set) Token: 0x06001B75 RID: 7029 RVA: 0x000AD9E0 File Offset: 0x000ABBE0
		Public Property Type As UserTypeEnum
			Get
				Return Me.OOO_o00.0.
			End Get
			Friend Set(value As UserTypeEnum)
				If OO_00oOO.User IsNot Me Then
					Me.OOO_o00.0. = value
				End If
			End Set
		End Property

		' Token: 0x1700063A RID: 1594
		' (get) Token: 0x06001B76 RID: 7030 RVA: 0x000AD9F1 File Offset: 0x000ABBF1
		' (set) Token: 0x06001B77 RID: 7031 RVA: 0x000AD9F9 File Offset: 0x000ABBF9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Tag As String
			Get
				Return Me.Oo_OO.0.
			End Get
			Set(value As String)
				If OO_00oOO.User IsNot Me Then
					Me.Oo_OO.0. = value
				End If
			End Set
		End Property

		' Token: 0x1700063B RID: 1595
		' (get) Token: 0x06001B78 RID: 7032 RVA: 0x000ADA0A File Offset: 0x000ABC0A
		' (set) Token: 0x06001B79 RID: 7033 RVA: 0x000ADA12 File Offset: 0x000ABC12
		Public Property Roles As String
			Get
				Return Me.OO0O0_OO0_.OO0.
			End Get
			Friend Set(value As String)
				If OO_00oOO.User IsNot Me Then
					Me.OO0O0_OO0_.OO0. = value
				End If
			End Set
		End Property

		' Token: 0x1700063C RID: 1596
		' (get) Token: 0x06001B7A RID: 7034 RVA: 0x000ADA23 File Offset: 0x000ABC23
		' (set) Token: 0x06001B7B RID: 7035 RVA: 0x000ADA2B File Offset: 0x000ABC2B
		Public Property [Default] As Boolean
			Get
				Return Me.OOO_o00.0.
			End Get
			Friend Set(value As Boolean)
				Me.OOO_o00.0. = value
			End Set
		End Property

		' Token: 0x1700063D RID: 1597
		' (get) Token: 0x06001B7C RID: 7036 RVA: 0x000ADA34 File Offset: 0x000ABC34
		Public ReadOnly Property ExtendedValues As Dictionary(Of String, Object)
			Get
				Return Me.OOO_o00.0.
			End Get
		End Property

		' Token: 0x06001B7D RID: 7037 RVA: 0x000ADA3C File Offset: 0x000ABC3C
		Public Function IsRole(Role As String) As Boolean
			Dim result As Boolean
			If Operators.CompareString(Me.Roles, "", True) = 0 Then
				result = False
			Else
				Dim array As String() = Me.Roles.Split(New Char() { ","c })
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					If Operators.CompareString(array(i), Role, True) = 0 Then
						Return True
					End If
				Next
				result = False
			End If
			Return result
		End Function

		' Token: 0x1700063E RID: 1598
		' (get) Token: 0x06001B7E RID: 7038 RVA: 0x000ADA9C File Offset: 0x000ABC9C
		' (set) Token: 0x06001B7F RID: 7039 RVA: 0x000ADAA4 File Offset: 0x000ABCA4
		Friend Property Password As String
			Get
				Return Me.oo0OOOO.0__OO.
			End Get
			Set(value As String)
				Me.oo0OOOO.0__OO. = value
			End Set
		End Property

		' Token: 0x04000BA9 RID: 2985
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000BAA RID: 2986
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000BAB RID: 2987
		Private <<EMPTY_NAME>> As UserTypeEnum

		' Token: 0x04000BAC RID: 2988
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000BAD RID: 2989
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000BAE RID: 2990
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000BAF RID: 2991
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000BB0 RID: 2992
		Private <<EMPTY_NAME>> As Dictionary(Of String, Object)
	End Class
End Namespace
