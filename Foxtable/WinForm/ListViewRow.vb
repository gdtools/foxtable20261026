Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020001AA RID: 426
	<ComVisible(True)>
	Public Class ListViewRow
		' Token: 0x06001414 RID: 5140 RVA: 0x00080794 File Offset: 0x0007E994
		Public Sub New(A_0 As ListViewItem)
			Me.O.oo_oO. = A_0
		End Sub

		' Token: 0x17000420 RID: 1056
		' (get) Token: 0x06001415 RID: 5141 RVA: 0x000807A3 File Offset: 0x0007E9A3
		Friend ReadOnly Property BaseItem As ListViewItem
			Get
				Return Me.O.oo_oO.
			End Get
		End Property

		' Token: 0x17000421 RID: 1057
		Public Default Property Item(Key As String) As String
			Get
				Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(Me.O.oo_oO..ListView, o_OO_oOOO0o)
				Dim text As String
				If Operators.CompareString(Key, o_OO_oOOO0o.O_O.0Oo_o.(), True) = 0 Then
					text = Me.O.oo_oO..SubItems(0).Text
				Else
					text = Me.O.oo_oO..SubItems(Key).Text
				End If
				Return text
			End Get
			Set(value As String)
				Dim right As String
				If Me.O.oo_oO..ListView Is Nothing Then
					right = CType(Me.O.oo_oO., ooO0__O0_O).o0.oooO.()
				Else
					right = CType(Me.O.oo_oO..ListView, o_OO_oOOO0o).O_O.0Oo_o.()
				End If
				If Operators.CompareString(Key, right, True) = 0 Then
					Me.O.oo_oO..SubItems(0).Text = value
					Return
				End If
				Me.O.oo_oO..SubItems(Key).Text = value
			End Set
		End Property

		' Token: 0x17000422 RID: 1058
		' (get) Token: 0x06001418 RID: 5144 RVA: 0x00080888 File Offset: 0x0007EA88
		Public ReadOnly Property Cells(Key As String) As ListViewCell
			Get
				Return New ListViewCell(Me.O.oo_oO..SubItems(Key))
			End Get
		End Property

		' Token: 0x17000423 RID: 1059
		' (get) Token: 0x06001419 RID: 5145 RVA: 0x000808A0 File Offset: 0x0007EAA0
		Public ReadOnly Property Cells(index As Integer) As ListViewCell
			Get
				Return New ListViewCell(Me.O.oo_oO..SubItems(index))
			End Get
		End Property

		' Token: 0x17000424 RID: 1060
		' (get) Token: 0x0600141A RID: 5146 RVA: 0x000808B8 File Offset: 0x0007EAB8
		' (set) Token: 0x0600141B RID: 5147 RVA: 0x000808C5 File Offset: 0x0007EAC5
		Public Property CellUseRowStyle As Boolean
			Get
				Return Me.O.oo_oO..UseItemStyleForSubItems
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..UseItemStyleForSubItems = value
			End Set
		End Property

		' Token: 0x17000425 RID: 1061
		' (get) Token: 0x0600141C RID: 5148 RVA: 0x000808D3 File Offset: 0x0007EAD3
		' (set) Token: 0x0600141D RID: 5149 RVA: 0x000808E0 File Offset: 0x0007EAE0
		Public Property Text As String
			Get
				Return Me.O.oo_oO..Text
			End Get
			Set(value As String)
				Me.O.oo_oO..Text = value
			End Set
		End Property

		' Token: 0x17000426 RID: 1062
		' (get) Token: 0x0600141E RID: 5150 RVA: 0x000808EE File Offset: 0x0007EAEE
		' (set) Token: 0x0600141F RID: 5151 RVA: 0x000808FB File Offset: 0x0007EAFB
		Public Property Name As String
			Get
				Return Me.O.oo_oO..Name
			End Get
			Set(value As String)
				Me.O.oo_oO..Name = value
			End Set
		End Property

		' Token: 0x17000427 RID: 1063
		' (get) Token: 0x06001420 RID: 5152 RVA: 0x00080909 File Offset: 0x0007EB09
		' (set) Token: 0x06001421 RID: 5153 RVA: 0x00080916 File Offset: 0x0007EB16
		Public Property Tag As Object
			Get
				Return Me.O.oo_oO..Tag
			End Get
			Set(value As Object)
				Me.O.oo_oO..Tag = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17000428 RID: 1064
		' (get) Token: 0x06001422 RID: 5154 RVA: 0x00080929 File Offset: 0x0007EB29
		' (set) Token: 0x06001423 RID: 5155 RVA: 0x00080936 File Offset: 0x0007EB36
		Public Property ToolTipText As String
			Get
				Return Me.O.oo_oO..ToolTipText
			End Get
			Set(value As String)
				Me.O.oo_oO..ToolTipText = value
			End Set
		End Property

		' Token: 0x06001424 RID: 5156 RVA: 0x00080944 File Offset: 0x0007EB44
		Public Sub Delete()
			If Me.O.oo_oO..ListView.VirtualMode Then
				Dim index As Integer = Me.O.oo_oO..Index
				Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(Me.O.oo_oO..ListView, o_OO_oOOO0o)
				Dim array As Integer() = New Integer(o_OO_oOOO0o.o0__o.O0..Count - 1 + 1 - 1) {}
				o_OO_oOOO0o.o0__o.O0..Keys.CopyTo(array, 0)
				Array.Sort(Of Integer)(array)
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim num2 As Integer = array(i)
					If num2 = index Then
						o_OO_oOOO0o.o0__o.O0..Remove(num2)
					ElseIf num2 > index Then
						Dim value As ListViewRow = o_OO_oOOO0o.o0__o.O0.(num2)
						o_OO_oOOO0o.o0__o.O0..Remove(num2)
						o_OO_oOOO0o.o0__o.O0..Add(num2 - 1, value)
					End If
				Next
				o_OO_oOOO0o.VirtualListSize -= 1
				Return
			End If
			Me.O.oo_oO..Remove()
		End Sub

		' Token: 0x06001425 RID: 5157 RVA: 0x00080A30 File Offset: 0x0007EC30
		Public Sub Retrieve()
			If Me.O.oo_oO..ListView.VirtualMode Then
				Dim index As Integer = Me.O.oo_oO..Index
				Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(Me.O.oo_oO..ListView, o_OO_oOOO0o)
				If o_OO_oOOO0o.o0__o.O0..ContainsKey(index) Then
					o_OO_oOOO0o.o0__o.O0..Remove(index)
				End If
			End If
			Me.O.oo_oO..ListView.Invalidate(Me.O.oo_oO..Bounds)
		End Sub

		' Token: 0x17000429 RID: 1065
		' (get) Token: 0x06001426 RID: 5158 RVA: 0x00080AA2 File Offset: 0x0007ECA2
		' (set) Token: 0x06001427 RID: 5159 RVA: 0x00080AAF File Offset: 0x0007ECAF
		Public Property Selected As Boolean
			Get
				Return Me.O.oo_oO..Selected
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..Selected = value
			End Set
		End Property

		' Token: 0x1700042A RID: 1066
		' (get) Token: 0x06001428 RID: 5160 RVA: 0x00080ABD File Offset: 0x0007ECBD
		' (set) Token: 0x06001429 RID: 5161 RVA: 0x00080ACA File Offset: 0x0007ECCA
		Public Property BackColor As Color
			Get
				Return Me.O.oo_oO..BackColor
			End Get
			Set(value As Color)
				Me.O.oo_oO..BackColor = value
			End Set
		End Property

		' Token: 0x1700042B RID: 1067
		' (get) Token: 0x0600142A RID: 5162 RVA: 0x00080AD8 File Offset: 0x0007ECD8
		' (set) Token: 0x0600142B RID: 5163 RVA: 0x00080AE5 File Offset: 0x0007ECE5
		Public Property ForeColor As Color
			Get
				Return Me.O.oo_oO..ForeColor
			End Get
			Set(value As Color)
				Me.O.oo_oO..ForeColor = value
			End Set
		End Property

		' Token: 0x1700042C RID: 1068
		' (get) Token: 0x0600142C RID: 5164 RVA: 0x00080AF3 File Offset: 0x0007ECF3
		' (set) Token: 0x0600142D RID: 5165 RVA: 0x00080B00 File Offset: 0x0007ED00
		Public Property Font As Font
			Get
				Return Me.O.oo_oO..Font
			End Get
			Set(value As Font)
				Me.O.oo_oO..Font = value
			End Set
		End Property

		' Token: 0x1700042D RID: 1069
		' (get) Token: 0x0600142E RID: 5166 RVA: 0x00080B0E File Offset: 0x0007ED0E
		' (set) Token: 0x0600142F RID: 5167 RVA: 0x00080B1C File Offset: 0x0007ED1C
		Public Property Checked As Boolean
			Get
				Return Me.O.oo_oO..Checked
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..Checked = value
				If Me.O.oo_oO..ListView IsNot Nothing AndAlso Me.O.oo_oO..ListView.VirtualMode Then
					Me.O.oo_oO..ListView.Invalidate(Me.O.oo_oO..SubItems(0).Bounds)
				End If
			End Set
		End Property

		' Token: 0x1700042E RID: 1070
		' (get) Token: 0x06001430 RID: 5168 RVA: 0x00080B7C File Offset: 0x0007ED7C
		' (set) Token: 0x06001431 RID: 5169 RVA: 0x00080BB0 File Offset: 0x0007EDB0
		Public Property Group As String
			Get
				Dim result As String
				If Me.O.oo_oO..Group IsNot Nothing Then
					result = Me.O.oo_oO..Group.Name
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					Me.O.oo_oO..Group = Nothing
					Return
				End If
				Me.O.oo_oO..Group = Me.O.oo_oO..ListView.Groups(value)
			End Set
		End Property

		' Token: 0x1700042F RID: 1071
		' (get) Token: 0x06001432 RID: 5170 RVA: 0x00080BEE File Offset: 0x0007EDEE
		Public ReadOnly Property Index As Integer
			Get
				Return Me.O.oo_oO..Index
			End Get
		End Property

		' Token: 0x17000430 RID: 1072
		' (get) Token: 0x06001433 RID: 5171 RVA: 0x00080BFB File Offset: 0x0007EDFB
		' (set) Token: 0x06001434 RID: 5172 RVA: 0x00080C08 File Offset: 0x0007EE08
		Public Property ImageKey As String
			Get
				Return Me.O.oo_oO..ImageKey
			End Get
			Set(value As String)
				Me.O.oo_oO..ImageKey = value
				If Me.O.oo_oO..ListView IsNot Nothing AndAlso Me.O.oo_oO..ListView.VirtualMode Then
					Dim listView As ListView = Me.O.oo_oO..ListView
					Dim num As Integer = listView.SmallImageList.Images.IndexOfKey(value)
					If num >= 0 Then
						Me.O.oo_oO..ImageIndex = num
						Return
					End If
					num = listView.LargeImageList.Images.IndexOfKey(value)
					If num >= 0 Then
						Me.O.oo_oO..ImageIndex = num
					End If
				End If
			End Set
		End Property

		' Token: 0x06001435 RID: 5173 RVA: 0x00080C91 File Offset: 0x0007EE91
		Public Sub EnsureVisible()
			Me.O.oo_oO..EnsureVisible()
		End Sub

		' Token: 0x06001436 RID: 5174 RVA: 0x00080C9E File Offset: 0x0007EE9E
		Public Sub BeginEdit()
			Me.O.oo_oO..BeginEdit()
		End Sub

		' Token: 0x040007D3 RID: 2003
		Private <<EMPTY_NAME>> As ListViewItem
	End Class
End Namespace
