Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x020001A6 RID: 422
	<ComVisible(True)>
	Public Class ListViewGroup
		' Token: 0x060013E9 RID: 5097 RVA: 0x00080291 File Offset: 0x0007E491
		Public Sub New(A_0 As ListViewGroup)
			Me.O.oo_oO. = A_0
		End Sub

		' Token: 0x17000413 RID: 1043
		' (get) Token: 0x060013EA RID: 5098 RVA: 0x000802A0 File Offset: 0x0007E4A0
		' (set) Token: 0x060013EB RID: 5099 RVA: 0x000802AD File Offset: 0x0007E4AD
		Public Property Name As String
			Get
				Return Me.O.oo_oO..Name
			End Get
			Set(value As String)
				Me.O.oo_oO..Name = value
			End Set
		End Property

		' Token: 0x17000414 RID: 1044
		' (get) Token: 0x060013EC RID: 5100 RVA: 0x000802BB File Offset: 0x0007E4BB
		' (set) Token: 0x060013ED RID: 5101 RVA: 0x000802C8 File Offset: 0x0007E4C8
		Public Property Text As String
			Get
				Return Me.O.oo_oO..Header
			End Get
			Set(value As String)
				Me.O.oo_oO..Header = value
			End Set
		End Property

		' Token: 0x17000415 RID: 1045
		' (get) Token: 0x060013EE RID: 5102 RVA: 0x000802D6 File Offset: 0x0007E4D6
		Friend ReadOnly Property BaseGroup As ListViewGroup
			Get
				Return Me.O.oo_oO.
			End Get
		End Property

		' Token: 0x17000416 RID: 1046
		' (get) Token: 0x060013EF RID: 5103 RVA: 0x000802DE File Offset: 0x0007E4DE
		Public ReadOnly Property Rows As ListViewRowCollections
			Get
				Return New ListViewRowCollections(Me.O.oo_oO..Items)
			End Get
		End Property

		' Token: 0x17000417 RID: 1047
		' (get) Token: 0x060013F0 RID: 5104 RVA: 0x000802F0 File Offset: 0x0007E4F0
		' (set) Token: 0x060013F1 RID: 5105 RVA: 0x000802FD File Offset: 0x0007E4FD
		Public Property Tag As Object
			Get
				Return Me.O.oo_oO..Tag
			End Get
			Set(value As Object)
				Me.O.oo_oO..Tag = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x040007CA RID: 1994
		Private <<EMPTY_NAME>> As ListViewGroup
	End Class
End Namespace
