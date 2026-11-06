Imports System
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000282 RID: 642
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ExpressionGroup
		' Token: 0x06001F02 RID: 7938 RVA: 0x000C9548 File Offset: 0x000C7748
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.O_0_O.OoO_0_0O. = A_0
			Me.O.O_O. = A_1
			Me.OoOO0.00_O_o. = A_2
		End Sub

		' Token: 0x170006F4 RID: 1780
		' (get) Token: 0x06001F03 RID: 7939 RVA: 0x000C9565 File Offset: 0x000C7765
		' (set) Token: 0x06001F04 RID: 7940 RVA: 0x000C956D File Offset: 0x000C776D
		Public Property Name As String
			Get
				Return Me.O_0_O.OoO_0_0O.
			End Get
			Set(value As String)
				Me.O_0_O.OoO_0_0O. = value
			End Set
		End Property

		' Token: 0x170006F5 RID: 1781
		' (get) Token: 0x06001F05 RID: 7941 RVA: 0x000C9576 File Offset: 0x000C7776
		' (set) Token: 0x06001F06 RID: 7942 RVA: 0x000C957E File Offset: 0x000C777E
		Public Property Caption As String
			Get
				Return Me.OoOO0.00_O_o.
			End Get
			Set(value As String)
				Me.OoOO0.00_O_o. = value
			End Set
		End Property

		' Token: 0x170006F6 RID: 1782
		' (get) Token: 0x06001F07 RID: 7943 RVA: 0x000C9587 File Offset: 0x000C7787
		' (set) Token: 0x06001F08 RID: 7944 RVA: 0x000C958F File Offset: 0x000C778F
		Public Property Expression As String
			Get
				Return Me.O.O_O.
			End Get
			Set(value As String)
				Me.O.O_O. = value
			End Set
		End Property

		' Token: 0x170006F7 RID: 1783
		' (get) Token: 0x06001F09 RID: 7945 RVA: 0x000C9598 File Offset: 0x000C7798
		' (set) Token: 0x06001F0A RID: 7946 RVA: 0x000C95A0 File Offset: 0x000C77A0
		Friend Property Pattern As String
			Get
				Return Me.o.0_0o.
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso value.IndexOf("{0}") >= 0 Then
					Me.o.0_0o. = value
				End If
			End Set
		End Property

		' Token: 0x170006F8 RID: 1784
		' (get) Token: 0x06001F0B RID: 7947 RVA: 0x000C95C6 File Offset: 0x000C77C6
		' (set) Token: 0x06001F0C RID: 7948 RVA: 0x000C95CE File Offset: 0x000C77CE
		Friend Property Vertical As Boolean
			Get
				Return Me.O_0_O.OoO_0_0O.
			End Get
			Set(value As Boolean)
				Me.O_0_O.OoO_0_0O. = value
			End Set
		End Property

		' Token: 0x04000CEF RID: 3311
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CF0 RID: 3312
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CF1 RID: 3313
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CF2 RID: 3314
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000CF3 RID: 3315
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
