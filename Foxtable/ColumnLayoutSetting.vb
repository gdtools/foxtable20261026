Imports System

Namespace Foxtable
	' Token: 0x02000310 RID: 784
	Friend Class ColumnLayoutSetting
		' Token: 0x06002AC6 RID: 10950 RVA: 0x0012CE58 File Offset: 0x0012B058
		Friend Sub New(A_0 As String, A_1 As Integer, A_2 As Boolean, A_3 As Boolean)
			Me.O0._ooOO. = A_0
			Me.O0._ooOO. = A_1
			Me.Oo.0O. = A_3
		End Sub

		' Token: 0x17000A13 RID: 2579
		' (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0012CE76 File Offset: 0x0012B076
		' (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0012CE7E File Offset: 0x0012B07E
		Friend Property Name As String
			Get
				Return Me.O0._ooOO.
			End Get
			Set(value As String)
				Me.O0._ooOO. = value
			End Set
		End Property

		' Token: 0x17000A14 RID: 2580
		' (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0012CE87 File Offset: 0x0012B087
		Friend ReadOnly Property Width As Integer
			Get
				Return Me.O0._ooOO.
			End Get
		End Property

		' Token: 0x17000A15 RID: 2581
		' (get) Token: 0x06002ACA RID: 10954 RVA: 0x0012CE8F File Offset: 0x0012B08F
		Friend ReadOnly Property Visible As Boolean
			Get
				Return Me.Oo.0O.
			End Get
		End Property

		' Token: 0x04001160 RID: 4448
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001161 RID: 4449
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001162 RID: 4450
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001163 RID: 4451
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
