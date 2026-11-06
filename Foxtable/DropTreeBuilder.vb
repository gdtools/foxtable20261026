Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200023A RID: 570
	<oO0oooo("2031")>
	<ComVisible(True)>
	Public Class DropTreeBuilder
		' Token: 0x06001A9D RID: 6813 RVA: 0x000AB6BD File Offset: 0x000A98BD
		Public Sub New()
			Me.o0._o00_0o_oo. = "\"c
			Me.o_.___0O0. = "|"c
		End Sub

		' Token: 0x170005EF RID: 1519
		' (get) Token: 0x06001A9E RID: 6814 RVA: 0x000AB6D5 File Offset: 0x000A98D5
		' (set) Token: 0x06001A9F RID: 6815 RVA: 0x000AB6DD File Offset: 0x000A98DD
		Public Property TreeFile As String
			Get
				Return Me.o0._o00_0o_oo.
			End Get
			Set(value As String)
				Me.o0._o00_0o_oo. = value
			End Set
		End Property

		' Token: 0x170005F0 RID: 1520
		' (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000AB6E6 File Offset: 0x000A98E6
		' (set) Token: 0x06001AA1 RID: 6817 RVA: 0x000AB6EE File Offset: 0x000A98EE
		Public Property TreeString As String
			Get
				Return Me.o_oOOo_.oO.
			End Get
			Set(value As String)
				Me.o_oOOo_.oO. = value
			End Set
		End Property

		' Token: 0x170005F1 RID: 1521
		' (get) Token: 0x06001AA2 RID: 6818 RVA: 0x000AB6F7 File Offset: 0x000A98F7
		' (set) Token: 0x06001AA3 RID: 6819 RVA: 0x000AB6FF File Offset: 0x000A98FF
		Public Property ReceiveCols As String
			Get
				Return Me.o._o0O_.
			End Get
			Set(value As String)
				Me.o._o0O_. = value
			End Set
		End Property

		' Token: 0x170005F2 RID: 1522
		' (get) Token: 0x06001AA4 RID: 6820 RVA: 0x000AB708 File Offset: 0x000A9908
		' (set) Token: 0x06001AA5 RID: 6821 RVA: 0x000AB710 File Offset: 0x000A9910
		Public Property SourceTable As DataTable
			Get
				Return Me.O_o.o__.
			End Get
			Set(value As DataTable)
				Me.O_o.o__. = value
			End Set
		End Property

		' Token: 0x170005F3 RID: 1523
		' (get) Token: 0x06001AA6 RID: 6822 RVA: 0x000AB719 File Offset: 0x000A9919
		' (set) Token: 0x06001AA7 RID: 6823 RVA: 0x000AB721 File Offset: 0x000A9921
		Public Property TreeCols As String
			Get
				Return Me.oO.0_O_O0O.
			End Get
			Set(value As String)
				Me.oO.0_O_O0O. = value
			End Set
		End Property

		' Token: 0x170005F4 RID: 1524
		' (get) Token: 0x06001AA8 RID: 6824 RVA: 0x000AB72A File Offset: 0x000A992A
		' (set) Token: 0x06001AA9 RID: 6825 RVA: 0x000AB732 File Offset: 0x000A9932
		Public Property TreeFilter As String
			Get
				Return Me.O__oOo.oO_Oo0.
			End Get
			Set(value As String)
				Me.O__oOo.oO_Oo0. = value
			End Set
		End Property

		' Token: 0x170005F5 RID: 1525
		' (get) Token: 0x06001AAA RID: 6826 RVA: 0x000AB73B File Offset: 0x000A993B
		' (set) Token: 0x06001AAB RID: 6827 RVA: 0x000AB743 File Offset: 0x000A9943
		Public Property TreeSort As String
			Get
				Return Me.o0oO.0O_0Oo_oo.
			End Get
			Set(value As String)
				Me.o0oO.0O_0Oo_oo. = value
			End Set
		End Property

		' Token: 0x170005F6 RID: 1526
		' (get) Token: 0x06001AAC RID: 6828 RVA: 0x000AB74C File Offset: 0x000A994C
		' (set) Token: 0x06001AAD RID: 6829 RVA: 0x000AB754 File Offset: 0x000A9954
		Public Property SourceCols As String
			Get
				Return Me.OoO._oo_0.
			End Get
			Set(value As String)
				Me.OoO._oo_0. = value
			End Set
		End Property

		' Token: 0x170005F7 RID: 1527
		' (get) Token: 0x06001AAE RID: 6830 RVA: 0x000AB75D File Offset: 0x000A995D
		' (set) Token: 0x06001AAF RID: 6831 RVA: 0x000AB76A File Offset: 0x000A996A
		Public Property PathSeparator As String
			Get
				Return Conversions.ToString(Me.o0._o00_0o_oo.)
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					value = "\"
				End If
				Me.o0._o00_0o_oo. = value(0)
			End Set
		End Property

		' Token: 0x170005F8 RID: 1528
		' (get) Token: 0x06001AB0 RID: 6832 RVA: 0x000AB78E File Offset: 0x000A998E
		' (set) Token: 0x06001AB1 RID: 6833 RVA: 0x000AB796 File Offset: 0x000A9996
		Public Property PathSeparator2 As Char
			Get
				Return Me.o0._o00_0o_oo.
			End Get
			Set(value As Char)
				If Operators.CompareString(Conversions.ToString(value), "", True) = 0 Then
					value = "\"c
				End If
				Me.o0._o00_0o_oo. = value
			End Set
		End Property

		' Token: 0x170005F9 RID: 1529
		' (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000AB7B6 File Offset: 0x000A99B6
		' (set) Token: 0x06001AB3 RID: 6835 RVA: 0x000AB7C3 File Offset: 0x000A99C3
		Public Property ContentSeparator As String
			Get
				Return Conversions.ToString(Me.o_.___0O0.)
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					value = "|"
				End If
				Me.o_.___0O0. = value(0)
			End Set
		End Property

		' Token: 0x170005FA RID: 1530
		' (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000AB7E7 File Offset: 0x000A99E7
		' (set) Token: 0x06001AB5 RID: 6837 RVA: 0x000AB7EF File Offset: 0x000A99EF
		Public Property ContentSeparator2 As Char
			Get
				Return Me.o_.___0O0.
			End Get
			Set(value As Char)
				If Operators.CompareString(Conversions.ToString(value), "", True) = 0 Then
					value = "|"c
				End If
				Me.o_.___0O0. = value
			End Set
		End Property

		' Token: 0x170005FB RID: 1531
		' (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000AB80F File Offset: 0x000A9A0F
		' (set) Token: 0x06001AB7 RID: 6839 RVA: 0x000AB817 File Offset: 0x000A9A17
		Public Property SeparateContent As Boolean
			Get
				Return Me.o0._o00_0o_oo.
			End Get
			Set(value As Boolean)
				Me.o0._o00_0o_oo. = value
			End Set
		End Property

		' Token: 0x06001AB8 RID: 6840 RVA: 0x000AB820 File Offset: 0x000A9A20
		Public Function Build() As BuildInDropTree
			Dim buildInDropTree As BuildInDropTree = Nothing
			If Operators.CompareString(Me.TreeFile, "", True) > 0 AndAlso Operators.CompareString(Me.ReceiveCols, "", True) > 0 Then
				buildInDropTree = New BuildInDropTree(ooO.OoO0o_o___.O.(Me.TreeFile), Me.ReceiveCols, True)
			ElseIf Operators.CompareString(Me.TreeString, "", True) > 0 AndAlso Operators.CompareString(Me.ReceiveCols, "", True) > 0 Then
				buildInDropTree = New BuildInDropTree(Me.TreeString, Me.ReceiveCols, False)
			ElseIf Me.SourceTable IsNot Nothing AndAlso Operators.CompareString(Me.ReceiveCols, "", True) > 0 AndAlso Operators.CompareString(Me.TreeCols, "", True) > 0 Then
				buildInDropTree = New BuildInDropTree(Me.SourceTable, Me.TreeCols, Me.SourceCols, Me.ReceiveCols, Me.PathSeparator2, Me.TreeFilter, Me.TreeSort)
			End If
			If buildInDropTree IsNot Nothing Then
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = Me.PathSeparator2
				buildInDropTree.Ooo._0oO..O0ooOO_o0.00. = Me.ContentSeparator2
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = Me.SeparateContent
				If Me.TreeWidth > 0 Then
					buildInDropTree.Ooo._0oO..Width = Me.TreeWidth
				End If
				If Me.TreeHeight > 0 Then
					buildInDropTree.Ooo._0oO..Height = Me.TreeHeight
				End If
			End If
			Return buildInDropTree
		End Function

		' Token: 0x170005FC RID: 1532
		' (get) Token: 0x06001AB9 RID: 6841 RVA: 0x000AB97C File Offset: 0x000A9B7C
		' (set) Token: 0x06001ABA RID: 6842 RVA: 0x000AB984 File Offset: 0x000A9B84
		Public Property TreeWidth As Integer
			Get
				Return Me.O_o.o__.
			End Get
			Set(value As Integer)
				Me.O_o.o__. = value
			End Set
		End Property

		' Token: 0x170005FD RID: 1533
		' (get) Token: 0x06001ABB RID: 6843 RVA: 0x000AB990 File Offset: 0x000A9B90
		' (set) Token: 0x06001ABC RID: 6844 RVA: 0x000AB9A1 File Offset: 0x000A9BA1
		Public Property TreeHeight As Integer
			Get
				Dim num As Integer = -num
				Return num
			End Get
			Set(value As Integer)
				Me.o_.___0O0. = value
			End Set
		End Property

		' Token: 0x04000B3B RID: 2875
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B3C RID: 2876
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B3D RID: 2877
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B3E RID: 2878
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000B3F RID: 2879
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B40 RID: 2880
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B41 RID: 2881
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B42 RID: 2882
		Private <<EMPTY_NAME>> As Char

		' Token: 0x04000B43 RID: 2883
		Private <<EMPTY_NAME>> As Char

		' Token: 0x04000B44 RID: 2884
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000B45 RID: 2885
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000B46 RID: 2886
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B47 RID: 2887
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
