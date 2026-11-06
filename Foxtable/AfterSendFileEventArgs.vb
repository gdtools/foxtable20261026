Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000182 RID: 386
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class AfterSendFileEventArgs
		' Token: 0x06001208 RID: 4616 RVA: 0x0006E870 File Offset: 0x0006CA70
		Public Sub New(A_0 As String, A_1 As String, A_2 As Boolean)
			Me.O.0___0__0. = A_0
			Me.O___o.O_0__OoO. = A_1
			Me.O.0___0__0. = A_2
		End Sub

		' Token: 0x170003D5 RID: 981
		' (get) Token: 0x06001209 RID: 4617 RVA: 0x0006E88D File Offset: 0x0006CA8D
		' (set) Token: 0x0600120A RID: 4618 RVA: 0x0006E895 File Offset: 0x0006CA95
		Public Property ServerFileName As String
			Get
				Return Me.oOO00.0O_0__0.
			End Get
			Friend Set(value As String)
				Me.oOO00.0O_0__0. = value
			End Set
		End Property

		' Token: 0x170003D6 RID: 982
		' (get) Token: 0x0600120B RID: 4619 RVA: 0x0006E89E File Offset: 0x0006CA9E
		Public ReadOnly Property Success As Boolean
			Get
				Return Me.O.0___0__0.
			End Get
		End Property

		' Token: 0x170003D7 RID: 983
		' (get) Token: 0x0600120C RID: 4620 RVA: 0x0006E8A6 File Offset: 0x0006CAA6
		Public ReadOnly Property UserName As String
			Get
				Return Me.O.0___0__0.
			End Get
		End Property

		' Token: 0x170003D8 RID: 984
		' (get) Token: 0x0600120D RID: 4621 RVA: 0x0006E8AE File Offset: 0x0006CAAE
		Public ReadOnly Property FileName As String
			Get
				Return Me.O___o.O_0__OoO.
			End Get
		End Property

		' Token: 0x040006ED RID: 1773
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006EE RID: 1774
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006EF RID: 1775
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006F0 RID: 1776
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
