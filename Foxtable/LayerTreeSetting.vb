Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000A7 RID: 167
	<ComVisible(True)>
	Public Class LayerTreeSetting
		' Token: 0x060006AA RID: 1706 RVA: 0x00026AEA File Offset: 0x00024CEA
		Public Sub New()
			Me.IncludeSub = True
			Me.ExpandTo = 0
			Me.Unique = True
		End Sub

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x060006AB RID: 1707 RVA: 0x00026B07 File Offset: 0x00024D07
		' (set) Token: 0x060006AC RID: 1708 RVA: 0x00026B0F File Offset: 0x00024D0F
		Public Property PathCol As String

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x060006AD RID: 1709 RVA: 0x00026B18 File Offset: 0x00024D18
		' (set) Token: 0x060006AE RID: 1710 RVA: 0x00026B20 File Offset: 0x00024D20
		Public Property TextCol As String

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x060006AF RID: 1711 RVA: 0x00026B29 File Offset: 0x00024D29
		' (set) Token: 0x060006B0 RID: 1712 RVA: 0x00026B31 File Offset: 0x00024D31
		Public Property TreeCol As String

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x060006B1 RID: 1713 RVA: 0x00026B3A File Offset: 0x00024D3A
		' (set) Token: 0x060006B2 RID: 1714 RVA: 0x00026B42 File Offset: 0x00024D42
		Public Property ValueCol As String

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x060006B3 RID: 1715 RVA: 0x00026B4B File Offset: 0x00024D4B
		' (set) Token: 0x060006B4 RID: 1716 RVA: 0x00026B53 File Offset: 0x00024D53
		Public Property IncludeSub As Boolean

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x060006B5 RID: 1717 RVA: 0x00026B5C File Offset: 0x00024D5C
		' (set) Token: 0x060006B6 RID: 1718 RVA: 0x00026B64 File Offset: 0x00024D64
		Public Property Subtotal As Boolean

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x060006B7 RID: 1719 RVA: 0x00026B6D File Offset: 0x00024D6D
		' (set) Token: 0x060006B8 RID: 1720 RVA: 0x00026B7A File Offset: 0x00024D7A
		Public Property Separator As String
			Get
				Return Conversions.ToString(Me.Separator2)
			End Get
			Set(value As String)
				If value.Length > 0 Then
					Me.Separator2 = value(0)
				End If
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x060006B9 RID: 1721 RVA: 0x00026B92 File Offset: 0x00024D92
		' (set) Token: 0x060006BA RID: 1722 RVA: 0x00026B9A File Offset: 0x00024D9A
		Friend Property Separator2 As Char

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x060006BB RID: 1723 RVA: 0x00026BA4 File Offset: 0x00024DA4
		' (set) Token: 0x060006BC RID: 1724 RVA: 0x00026BF8 File Offset: 0x00024DF8
		Public Property Lengths As Object()
			Get
				Dim list As List(Of Object) = New List(Of Object)()
				If Me.Lengths2 IsNot Nothing AndAlso Me.Lengths2.Length > 0 Then
					For Each num As Integer In Me.Lengths2
						list.Add(num)
					Next
				End If
				Return list.ToArray()
			End Get
			Set(value As Object())
				Dim list As List(Of Integer) = New List(Of Integer)()
				For i As Integer = 0 To value.Length - 1
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(value(i))
					If TypeOf objectValue Is Integer Then
						list.Add(Conversions.ToInteger(objectValue))
					End If
				Next
				Me.Lengths2 = list.ToArray()
			End Set
		End Property

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x060006BD RID: 1725 RVA: 0x00026C44 File Offset: 0x00024E44
		' (set) Token: 0x060006BE RID: 1726 RVA: 0x00026C4C File Offset: 0x00024E4C
		Friend Property Lengths2 As Integer()

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x060006BF RID: 1727 RVA: 0x00026C55 File Offset: 0x00024E55
		' (set) Token: 0x060006C0 RID: 1728 RVA: 0x00026C5D File Offset: 0x00024E5D
		Public Property GridTree As Boolean

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x060006C1 RID: 1729 RVA: 0x00026C66 File Offset: 0x00024E66
		' (set) Token: 0x060006C2 RID: 1730 RVA: 0x00026C6E File Offset: 0x00024E6E
		Public Property ExpandTo As Integer

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x060006C3 RID: 1731 RVA: 0x00026C77 File Offset: 0x00024E77
		' (set) Token: 0x060006C4 RID: 1732 RVA: 0x00026C7F File Offset: 0x00024E7F
		Public Property AggregateCols As Object()

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x060006C5 RID: 1733 RVA: 0x00026C88 File Offset: 0x00024E88
		' (set) Token: 0x060006C6 RID: 1734 RVA: 0x00026C90 File Offset: 0x00024E90
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ValueCols As String

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x060006C7 RID: 1735 RVA: 0x00026C99 File Offset: 0x00024E99
		' (set) Token: 0x060006C8 RID: 1736 RVA: 0x00026CA1 File Offset: 0x00024EA1
		Public Property Unique As Boolean

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x060006C9 RID: 1737 RVA: 0x00026CAA File Offset: 0x00024EAA
		' (set) Token: 0x060006CA RID: 1738 RVA: 0x00026CB2 File Offset: 0x00024EB2
		Public Property SortCol As String

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x060006CB RID: 1739 RVA: 0x00026CBB File Offset: 0x00024EBB
		' (set) Token: 0x060006CC RID: 1740 RVA: 0x00026CC3 File Offset: 0x00024EC3
		Public Property SortDesc As Boolean

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x060006CD RID: 1741 RVA: 0x00026CCC File Offset: 0x00024ECC
		' (set) Token: 0x060006CE RID: 1742 RVA: 0x00026CD4 File Offset: 0x00024ED4
		Public Property UseStyle As Boolean

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x060006CF RID: 1743 RVA: 0x00026CDD File Offset: 0x00024EDD
		' (set) Token: 0x060006D0 RID: 1744 RVA: 0x00026CE5 File Offset: 0x00024EE5
		Public Property MergeTotal As Boolean

		' Token: 0x040001CB RID: 459
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001CC RID: 460
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001CD RID: 461
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001CE RID: 462
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001CF RID: 463
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001D0 RID: 464
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001D1 RID: 465
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Char

		' Token: 0x040001D2 RID: 466
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x040001D3 RID: 467
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001D4 RID: 468
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040001D5 RID: 469
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object()

		' Token: 0x040001D6 RID: 470
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001D7 RID: 471
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001D8 RID: 472
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x040001D9 RID: 473
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001DA RID: 474
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040001DB RID: 475
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
