Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.MyServices

Namespace Foxtable
	' Token: 0x020001D4 RID: 468
	<ComVisible(True)>
	Public Class DataToTable
		' Token: 0x060015E0 RID: 5600 RVA: 0x00091240 File Offset: 0x0008F440
		Public Sub New(A_0 As WebViewer)
			Me.O.0_o0. = New List(Of Assembly)()
			Me.Oo_00_oO.00O0O. = New List(Of String)()
			Me.Oo_00_oO.00O0O. = New Dictionary(Of String, Type)(StringComparer.OrdinalIgnoreCase)
			Me.AccessData = True
			Me.O.0_o0..Add(Assembly.GetExecutingAssembly())
			Me.Oo_00_oO.00O0O..Add("Foxtable")
			Me.O.0_o0..Add(GetType(DateGroupEnum).Assembly)
			Me.Oo_00_oO.00O0O..Add("Foxtable")
			Me.Oo_00_oO.00O0O. = A_0
		End Sub

		' Token: 0x060015E1 RID: 5601 RVA: 0x000912D1 File Offset: 0x0008F4D1
		Public Sub Add(assembly As Assembly, SpaceName As String)
			Me.O.0_o0..Add(assembly)
			Me.Oo_00_oO.00O0O..Add(SpaceName)
		End Sub

		' Token: 0x060015E2 RID: 5602 RVA: 0x000912EC File Offset: 0x0008F4EC
		Private Function <<EMPTY_NAME>>(A_0 As String) As Type
			Dim result As Type
			If Me.Oo_00_oO.00O0O..ContainsKey(A_0) Then
				result = Me.Oo_00_oO.00O0O.(A_0)
			Else
				Dim type As Type = Nothing
				Dim left As String = A_0.ToLower()
				If Operators.CompareString(left, "color", True) = 0 Then
					type = GetType(Color)
				ElseIf Operators.CompareString(left, "dialogresult", True) = 0 Then
					type = GetType(DialogResult)
				ElseIf Operators.CompareString(left, "messageboxbuttons", True) = 0 Then
					type = GetType(MessageBoxButtons)
				ElseIf Operators.CompareString(left, "messageboxicon", True) = 0 Then
					type = GetType(MessageBoxIcon)
				ElseIf Operators.CompareString(left, "messageboxdefaultbutton", True) = 0 Then
					type = GetType(MessageBoxDefaultButton)
				ElseIf Operators.CompareString(left, "FontStyle", True) = 0 Then
					type = GetType(FontStyle)
				ElseIf Operators.CompareString(left, "AudioPlayMode", True) = 0 Then
					type = GetType(AudioPlayMode)
				Else
					If Operators.CompareString(left, "viewmode", True) = 0 Then
						Return GetType(View)
					End If
					If Operators.CompareString(left, "textimagerelation", True) = 0 Then
						Return GetType(TextImageRelation)
					End If
					If Operators.CompareString(left, "flatstyle", True) = 0 Then
						Return GetType(FlatStyle)
					End If
					If Operators.CompareString(left, "horizontalalignment", True) = 0 Then
						Return GetType(HorizontalAlignment)
					End If
					If Operators.CompareString(left, "appearance", True) = 0 Then
						Return GetType(Appearance)
					End If
					If Operators.CompareString(left, "borderstyle", True) = 0 Then
						Return GetType(BorderStyle)
					End If
					If Operators.CompareString(left, "mousebuttons", True) = 0 Then
						Return GetType(MouseButtons)
					End If
					If Operators.CompareString(left, "imagelayout", True) = 0 Then
						Return GetType(ImageLayout)
					End If
					If Operators.CompareString(left, "ivisualstyle", True) = 0 Then
						Return GetType(VisualStyle)
					End If
					If Operators.CompareString(left, "keys", True) = 0 Then
						Return GetType(Keys)
					End If
					If Operators.CompareString(left, "textdataformat", True) = 0 Then
						Return GetType(TextDataFormat)
					End If
					Dim num As Integer = Me.O.0_o0..Count - 1
					For i As Integer = 0 To num
						type = Me.O.0_o0.(i).[GetType](Me.Oo_00_oO.00O0O.(i) + "." + A_0, False, True)
						If type IsNot Nothing Then
							Exit For
						End If
					Next
				End If
				If type IsNot Nothing Then
					Me.Oo_00_oO.00O0O..Add(A_0, type)
					result = type
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x17000498 RID: 1176
		Public ReadOnly Default Property Item(A_0 As String) As Object
			Get
				Dim type As Type = Me.O_oooooO.0.(A_0)
				Dim result As Object
				If type IsNot Nothing Then
					result = New DyncMemberAccessor(type)
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x060015E4 RID: 5604 RVA: 0x000915C4 File Offset: 0x0008F7C4
		Public Function GetEnumerator() As IEnumerator
			Return Enumerable.Empty(Of Object)().GetEnumerator()
		End Function

		' Token: 0x17000499 RID: 1177
		' (get) Token: 0x060015E5 RID: 5605 RVA: 0x000915D0 File Offset: 0x0008F7D0
		' (set) Token: 0x060015E6 RID: 5606 RVA: 0x000915D8 File Offset: 0x0008F7D8
		Public Property AccessData As Boolean

		' Token: 0x1700049A RID: 1178
		' (get) Token: 0x060015E7 RID: 5607 RVA: 0x000915E4 File Offset: 0x0008F7E4
		Public ReadOnly Property DataTables As DataTableCollection
			Get
				Dim result As DataTableCollection
				If Me.AccessData Then
					result = OO_00oOO.DataTables
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700049B RID: 1179
		' (get) Token: 0x060015E8 RID: 5608 RVA: 0x00091604 File Offset: 0x0008F804
		Public ReadOnly Property Tables As TableCollection
			Get
				Dim result As TableCollection
				If Me.AccessData Then
					result = OO_00oOO.Tables
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700049C RID: 1180
		' (get) Token: 0x060015E9 RID: 5609 RVA: 0x00091624 File Offset: 0x0008F824
		Public ReadOnly Property Rand As Randjs
			Get
				If Me.O.0_o0. Is Nothing Then
					Me.O.0_o0. = New Randjs()
				End If
				Return Me.O.0_o0.
			End Get
		End Property

		' Token: 0x1700049D RID: 1181
		' (get) Token: 0x060015EA RID: 5610 RVA: 0x0009163F File Offset: 0x0008F83F
		Public ReadOnly Property PY As PYJS
			Get
				If Me.O.0_o0. Is Nothing Then
					Me.O.0_o0. = New PYJS()
				End If
				Return Me.O.0_o0.
			End Get
		End Property

		' Token: 0x1700049E RID: 1182
		' (get) Token: 0x060015EB RID: 5611 RVA: 0x0009165A File Offset: 0x0008F85A
		Public ReadOnly Property MRP As MRPTableCols
			Get
				Return OO_00oOO.MRP
			End Get
		End Property

		' Token: 0x1700049F RID: 1183
		' (get) Token: 0x060015EC RID: 5612 RVA: 0x00091661 File Offset: 0x0008F861
		Public ReadOnly Property MRPCols As MRPTableCols
			Get
				Return OO_00oOO.MRPCols
			End Get
		End Property

		' Token: 0x170004A0 RID: 1184
		' (get) Token: 0x060015ED RID: 5613 RVA: 0x00091668 File Offset: 0x0008F868
		Public ReadOnly Property OpenFileArgs As List(Of Object)
			Get
				Return OO_00oOO.OpenFileArgs
			End Get
		End Property

		' Token: 0x170004A1 RID: 1185
		' (get) Token: 0x060015EE RID: 5614 RVA: 0x0009166F File Offset: 0x0008F86F
		Public ReadOnly Property Forms As FormCollection
			Get
				Return OO_00oOO.Forms
			End Get
		End Property

		' Token: 0x170004A2 RID: 1186
		' (get) Token: 0x060015EF RID: 5615 RVA: 0x00091676 File Offset: 0x0008F876
		Public ReadOnly Property Reports As ReportCollection
			Get
				Return OO_00oOO.Reports
			End Get
		End Property

		' Token: 0x170004A3 RID: 1187
		' (get) Token: 0x060015F0 RID: 5616 RVA: 0x0009167D File Offset: 0x0008F87D
		Public ReadOnly Property Functions As UserFunctions
			Get
				Return OO_00oOO.Functions
			End Get
		End Property

		' Token: 0x170004A4 RID: 1188
		' (get) Token: 0x060015F1 RID: 5617 RVA: 0x00091684 File Offset: 0x0008F884
		Public ReadOnly Property HardWareInfo As HardWare
			Get
				Return OO_00oOO.HardWareInfo
			End Get
		End Property

		' Token: 0x170004A5 RID: 1189
		' (get) Token: 0x060015F2 RID: 5618 RVA: 0x0009168B File Offset: 0x0008F88B
		' (set) Token: 0x060015F3 RID: 5619 RVA: 0x00091692 File Offset: 0x0008F892
		Public Property ProjectFile As String
			Get
				Return OO_00oOO.ProjectFile
			End Get
			Set(value As String)
				OO_00oOO.ProjectFile = value
			End Set
		End Property

		' Token: 0x170004A6 RID: 1190
		' (get) Token: 0x060015F4 RID: 5620 RVA: 0x0009169A File Offset: 0x0008F89A
		Public ReadOnly Property ApplicationPath As String
			Get
				Return OO_00oOO.ApplicationPath
			End Get
		End Property

		' Token: 0x170004A7 RID: 1191
		' (get) Token: 0x060015F5 RID: 5621 RVA: 0x000916A1 File Offset: 0x0008F8A1
		Public ReadOnly Property ProjectPath As String
			Get
				Return OO_00oOO.ProjectPath
			End Get
		End Property

		' Token: 0x170004A8 RID: 1192
		' (get) Token: 0x060015F6 RID: 5622 RVA: 0x000916A8 File Offset: 0x0008F8A8
		Public ReadOnly Property AttachPath As String
			Get
				Return OO_00oOO.AttachPath
			End Get
		End Property

		' Token: 0x170004A9 RID: 1193
		' (get) Token: 0x060015F7 RID: 5623 RVA: 0x000916B0 File Offset: 0x0008F8B0
		Public ReadOnly Property CurrentTable As Table
			Get
				Dim result As Table
				If Me.AccessData Then
					result = OO_00oOO.CurrentTable
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170004AA RID: 1194
		' (get) Token: 0x060015F8 RID: 5624 RVA: 0x000916D0 File Offset: 0x0008F8D0
		' (set) Token: 0x060015F9 RID: 5625 RVA: 0x000916F0 File Offset: 0x0008F8F0
		Public Property MainTable As Table
			Get
				Dim result As Table
				If Me.AccessData Then
					result = OO_00oOO.MainTable
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As Table)
				OO_00oOO.MainTable = value
			End Set
		End Property

		' Token: 0x060015FA RID: 5626 RVA: 0x000916F8 File Offset: 0x0008F8F8
		Public Sub RaiseSystemEvent(Table As Table, ParamArray EventType As SystemEventTypeEnum())
			OO_00oOO.RaiseSystemEvent(Table, EventType)
		End Sub

		' Token: 0x170004AB RID: 1195
		' (get) Token: 0x060015FB RID: 5627 RVA: 0x00091701 File Offset: 0x0008F901
		Public ReadOnly Property Relations As DataRelationCollection
			Get
				Return OO_00oOO.Relations
			End Get
		End Property

		' Token: 0x170004AC RID: 1196
		' (get) Token: 0x060015FC RID: 5628 RVA: 0x00091708 File Offset: 0x0008F908
		Public ReadOnly Property Connections As ConnectionCollection
			Get
				Return OO_00oOO.Connections
			End Get
		End Property

		' Token: 0x170004AD RID: 1197
		' (get) Token: 0x060015FD RID: 5629 RVA: 0x0009170F File Offset: 0x0008F90F
		Public ReadOnly Property FileWatcher As FileSystemWatcher
			Get
				Return OO_00oOO.FileWatcher
			End Get
		End Property

		' Token: 0x170004AE RID: 1198
		' (get) Token: 0x060015FE RID: 5630 RVA: 0x00091716 File Offset: 0x0008F916
		Public ReadOnly Property Ports As MyPortCollections
			Get
				Return OO_00oOO.Ports
			End Get
		End Property

		' Token: 0x170004AF RID: 1199
		' (get) Token: 0x060015FF RID: 5631 RVA: 0x0009171D File Offset: 0x0008F91D
		Public ReadOnly Property ContextMenus As ContextMenuCollection
			Get
				Return OO_00oOO.ContextMenus
			End Get
		End Property

		' Token: 0x170004B0 RID: 1200
		' (get) Token: 0x06001600 RID: 5632 RVA: 0x00091724 File Offset: 0x0008F924
		Public ReadOnly Property RibbonTabs As RibbonTabCollection
			Get
				Return OO_00oOO.RibbonTabs
			End Get
		End Property

		' Token: 0x170004B1 RID: 1201
		' (get) Token: 0x06001601 RID: 5633 RVA: 0x0009172B File Offset: 0x0008F92B
		Public ReadOnly Property RibbonTabGroups As RibbonTabGroupCollection
			Get
				Return OO_00oOO.RibbonTabGroups
			End Get
		End Property

		' Token: 0x170004B2 RID: 1202
		' (get) Token: 0x06001602 RID: 5634 RVA: 0x00091732 File Offset: 0x0008F932
		Public ReadOnly Property ApplicationMenu As ApplicationMenu
			Get
				Return OO_00oOO.ApplicationMenu
			End Get
		End Property

		' Token: 0x170004B3 RID: 1203
		' (get) Token: 0x06001603 RID: 5635 RVA: 0x00091739 File Offset: 0x0008F939
		Public ReadOnly Property QAT As Qat
			Get
				Return OO_00oOO.QAT
			End Get
		End Property

		' Token: 0x170004B4 RID: 1204
		' (get) Token: 0x06001604 RID: 5636 RVA: 0x00091740 File Offset: 0x0008F940
		Public ReadOnly Property ConfigBar As ConfigBar
			Get
				Return OO_00oOO.ConfigBar
			End Get
		End Property

		' Token: 0x170004B5 RID: 1205
		' (get) Token: 0x06001605 RID: 5637 RVA: 0x00091747 File Offset: 0x0008F947
		Public ReadOnly Property TopToolBar As TopToolBar
			Get
				Return OO_00oOO.TopToolBar
			End Get
		End Property

		' Token: 0x170004B6 RID: 1206
		' (get) Token: 0x06001606 RID: 5638 RVA: 0x0009174E File Offset: 0x0008F94E
		Public ReadOnly Property BottomToolBar As BottomToolBar
			Get
				Return OO_00oOO.BottomToolBar
			End Get
		End Property

		' Token: 0x170004B7 RID: 1207
		' (get) Token: 0x06001607 RID: 5639 RVA: 0x00091755 File Offset: 0x0008F955
		Public ReadOnly Property User As UserInfo
			Get
				Return OO_00oOO.User
			End Get
		End Property

		' Token: 0x170004B8 RID: 1208
		' (get) Token: 0x06001608 RID: 5640 RVA: 0x0009175C File Offset: 0x0008F95C
		Public ReadOnly Property ModifierKey As Keys
			Get
				Return OO_00oOO.ModifierKey
			End Get
		End Property

		' Token: 0x170004B9 RID: 1209
		' (get) Token: 0x06001609 RID: 5641 RVA: 0x00091763 File Offset: 0x0008F963
		Public ReadOnly Property MouseButton As MouseButtons
			Get
				Return OO_00oOO.MouseButton
			End Get
		End Property

		' Token: 0x170004BA RID: 1210
		' (get) Token: 0x0600160A RID: 5642 RVA: 0x0009176A File Offset: 0x0008F96A
		Public ReadOnly Property MyTimers As TimerCollection
			Get
				Return OO_00oOO.MyTimers
			End Get
		End Property

		' Token: 0x170004BB RID: 1211
		' (get) Token: 0x0600160B RID: 5643 RVA: 0x00091771 File Offset: 0x0008F971
		Public ReadOnly Property Vars As VarsCollection
			Get
				Return OO_00oOO.Vars
			End Get
		End Property

		' Token: 0x0600160C RID: 5644 RVA: 0x00091778 File Offset: 0x0008F978
		Public Function GetImage(ImageFile As String) As Image
			Return OO_00oOO.GetImage(ImageFile)
		End Function

		' Token: 0x170004BC RID: 1212
		' (get) Token: 0x0600160D RID: 5645 RVA: 0x00091780 File Offset: 0x0008F980
		Public ReadOnly Property BindTables(A_0 As String) As DataView
			Get
				Return OO_00oOO.O___OOOoo.o.(A_0)
			End Get
		End Property

		' Token: 0x170004BD RID: 1213
		' (get) Token: 0x0600160E RID: 5646 RVA: 0x00091788 File Offset: 0x0008F988
		Public ReadOnly Property Audio As AudioJs
			Get
				If Me.O.0_o0. Is Nothing Then
					Me.O.0_o0. = New AudioJs()
				End If
				Return Me.O.0_o0.
			End Get
		End Property

		' Token: 0x170004BE RID: 1214
		' (get) Token: 0x0600160F RID: 5647 RVA: 0x000917A3 File Offset: 0x0008F9A3
		Public ReadOnly Property FileSys As FileSystemProxy
			Get
				Return OO_00oOO.FileSys
			End Get
		End Property

		' Token: 0x06001610 RID: 5648 RVA: 0x000917AA File Offset: 0x0008F9AA
		Public Function InTax(x As Double) As Double
			Return OO_00oOO.InTax(x)
		End Function

		' Token: 0x06001611 RID: 5649 RVA: 0x000917B2 File Offset: 0x0008F9B2
		Public Function Eval(Expr As String, Row As Row) As Object
			Return OO_00oOO.Eval(Expr, Row)
		End Function

		' Token: 0x06001612 RID: 5650 RVA: 0x000917BB File Offset: 0x0008F9BB
		Public Function Eval(Expr As String, DataRow As DataRow) As Object
			Return OO_00oOO.Eval(Expr, DataRow)
		End Function

		' Token: 0x06001613 RID: 5651 RVA: 0x000917C4 File Offset: 0x0008F9C4
		Public Function Eval(Expr As String) As Object
			Return OO_00oOO.Eval(Expr)
		End Function

		' Token: 0x06001614 RID: 5652 RVA: 0x000917CC File Offset: 0x0008F9CC
		Public Function Eval2(Expr As String, Row As Row) As Object
			Return OO_00oOO.Eval2(Expr, Row)
		End Function

		' Token: 0x06001615 RID: 5653 RVA: 0x000917D5 File Offset: 0x0008F9D5
		Public Function Eval2(Expr As String, DataRow As DataRow) As Object
			Return OO_00oOO.Eval2(Expr, DataRow)
		End Function

		' Token: 0x06001616 RID: 5654 RVA: 0x000917DE File Offset: 0x0008F9DE
		Public Function Eval2(Expr As String) As Object
			Return OO_00oOO.Eval2(Expr)
		End Function

		' Token: 0x06001617 RID: 5655 RVA: 0x000917E6 File Offset: 0x0008F9E6
		Public Function TryEval(Expr As String, Row As Row) As Object
			Return OO_00oOO.TryEval(Expr, Row)
		End Function

		' Token: 0x06001618 RID: 5656 RVA: 0x000917EF File Offset: 0x0008F9EF
		Public Function TryEval(Expr As String, DataRow As DataRow) As Object
			Return OO_00oOO.TryEval(Expr, DataRow)
		End Function

		' Token: 0x06001619 RID: 5657 RVA: 0x000917F8 File Offset: 0x0008F9F8
		Public Function TryEval(Expr As String) As Object
			Return OO_00oOO.TryEval(Expr)
		End Function

		' Token: 0x170004BF RID: 1215
		' (get) Token: 0x0600161A RID: 5658 RVA: 0x00091800 File Offset: 0x0008FA00
		' (set) Token: 0x0600161B RID: 5659 RVA: 0x00091807 File Offset: 0x0008FA07
		Public Property VisualStyle As VisualStyleEnum
			Get
				Return OO_00oOO.VisualStyle
			End Get
			Set(value As VisualStyleEnum)
				OO_00oOO.VisualStyle = value
			End Set
		End Property

		' Token: 0x0600161C RID: 5660 RVA: 0x0009180F File Offset: 0x0008FA0F
		Public Sub ShowHelpWindow()
			OO_00oOO.ShowHelpWindow()
		End Sub

		' Token: 0x0600161D RID: 5661 RVA: 0x00091816 File Offset: 0x0008FA16
		Public Sub ShowHelpWindow(Topic As String)
			OO_00oOO.ShowHelpWindow(Topic)
		End Sub

		' Token: 0x0600161E RID: 5662 RVA: 0x0009181E File Offset: 0x0008FA1E
		Public Sub ShowHelpWindow2()
			OO_00oOO.ShowHelpWindow2()
		End Sub

		' Token: 0x0600161F RID: 5663 RVA: 0x00091825 File Offset: 0x0008FA25
		Public Function ExecuteCode(Code As String, ReturnValue As Boolean) As Object
			Return OO_00oOO.ExecuteCode(Code, ReturnValue)
		End Function

		' Token: 0x06001620 RID: 5664 RVA: 0x0009182E File Offset: 0x0008FA2E
		Public Sub AddConnection(ConnName As String, ConnString As String)
			OO_00oOO.AddConnection(ConnName, ConnString)
		End Sub

		' Token: 0x06001621 RID: 5665 RVA: 0x00091837 File Offset: 0x0008FA37
		Public Sub DeleteConnection(ConnName As String)
			OO_00oOO.DeleteConnection(ConnName)
		End Sub

		' Token: 0x06001622 RID: 5666 RVA: 0x0009183F File Offset: 0x0008FA3F
		Public Function ContainsConnection(Connname As String) As Boolean
			Return OO_00oOO.ContainsConnection(Connname)
		End Function

		' Token: 0x06001623 RID: 5667 RVA: 0x00091847 File Offset: 0x0008FA47
		Public Function ApplicationVertion() As String
			Return OO_00oOO.ApplicationVertion()
		End Function

		' Token: 0x170004C0 RID: 1216
		' (get) Token: 0x06001624 RID: 5668 RVA: 0x0009184E File Offset: 0x0008FA4E
		' (set) Token: 0x06001625 RID: 5669 RVA: 0x00091855 File Offset: 0x0008FA55
		Public Property ApplicationTitle As String
			Get
				Return OO_00oOO.ApplicationTitle
			End Get
			Set(value As String)
				OO_00oOO.ApplicationTitle = value
			End Set
		End Property

		' Token: 0x06001626 RID: 5670 RVA: 0x0009185D File Offset: 0x0008FA5D
		Public Function PublishDate() As DateTime
			Return OO_00oOO.PublishDate()
		End Function

		' Token: 0x170004C1 RID: 1217
		' (get) Token: 0x06001627 RID: 5671 RVA: 0x00091864 File Offset: 0x0008FA64
		' (set) Token: 0x06001628 RID: 5672 RVA: 0x0009186B File Offset: 0x0008FA6B
		Public Property UpdatePath As String
			Get
				Return OO_00oOO.UpdatePath
			End Get
			Set(value As String)
				OO_00oOO.UpdatePath = value
			End Set
		End Property

		' Token: 0x170004C2 RID: 1218
		' (get) Token: 0x06001629 RID: 5673 RVA: 0x00091873 File Offset: 0x0008FA73
		' (set) Token: 0x0600162A RID: 5674 RVA: 0x0009187A File Offset: 0x0008FA7A
		Public Property RemoteUpdate As Boolean
			Get
				Return OO_00oOO.RemoteUpdate
			End Get
			Set(value As Boolean)
				OO_00oOO.RemoteUpdate = value
			End Set
		End Property

		' Token: 0x170004C3 RID: 1219
		' (get) Token: 0x0600162B RID: 5675 RVA: 0x00091882 File Offset: 0x0008FA82
		Public ReadOnly Property ComputerId As String
			Get
				Return o_o_O0OO_0__.oo00_.0oO_.()
			End Get
		End Property

		' Token: 0x170004C4 RID: 1220
		' (get) Token: 0x0600162C RID: 5676 RVA: 0x00091889 File Offset: 0x0008FA89
		Public ReadOnly Property InstalledPrinters As List(Of String)
			Get
				Return OO_00oOO.InstalledPrinters
			End Get
		End Property

		' Token: 0x170004C5 RID: 1221
		' (get) Token: 0x0600162D RID: 5677 RVA: 0x00091890 File Offset: 0x0008FA90
		Public ReadOnly Property DefaultPrinter As String
			Get
				Return OO_00oOO.DefaultPrinter
			End Get
		End Property

		' Token: 0x170004C6 RID: 1222
		' (get) Token: 0x0600162E RID: 5678 RVA: 0x00091897 File Offset: 0x0008FA97
		Public ReadOnly Property GetPaperSources(A_0 As String) As List(Of String)
			Get
				Return OO_00oOO.oooo_0_OO0o._0.(A_0)
			End Get
		End Property

		' Token: 0x0600162F RID: 5679 RVA: 0x0009189F File Offset: 0x0008FA9F
		Public Sub CloseSplashForm()
			OO_00oOO.CloseSplashForm()
		End Sub

		' Token: 0x170004C7 RID: 1223
		' (get) Token: 0x06001630 RID: 5680 RVA: 0x000918A6 File Offset: 0x0008FAA6
		' (set) Token: 0x06001631 RID: 5681 RVA: 0x000918AD File Offset: 0x0008FAAD
		Public Property MarkModifedCell As Boolean
			Get
				Return OO_00oOO.MarkModifedCell
			End Get
			Set(value As Boolean)
				OO_00oOO.MarkModifedCell = value
			End Set
		End Property

		' Token: 0x06001632 RID: 5682 RVA: 0x000918B5 File Offset: 0x0008FAB5
		Public Function EditConnectionString(Optional ConnectionString As String = "") As String
			Return OO_00oOO.EditConnectionString(ConnectionString)
		End Function

		' Token: 0x06001633 RID: 5683 RVA: 0x000918BD File Offset: 0x0008FABD
		Public Function GetTableNamesFromConnection(ConnectionName As String) As List(Of String)
			Return OO_00oOO.GetTableNamesFromConnection(ConnectionName)
		End Function

		' Token: 0x06001634 RID: 5684 RVA: 0x000918C5 File Offset: 0x0008FAC5
		Public Function Round2(x As Double, y As Integer) As Double
			Return OO_00oOO.Round2(x, y)
		End Function

		' Token: 0x06001635 RID: 5685 RVA: 0x000918CE File Offset: 0x0008FACE
		Public Function HardDiskId() As String
			Return OO_00oOO.HardDiskId()
		End Function

		' Token: 0x06001636 RID: 5686 RVA: 0x000918D5 File Offset: 0x0008FAD5
		Public Function IssueName() As String
			Return OO_00oOO.IssueName()
		End Function

		' Token: 0x06001637 RID: 5687 RVA: 0x000918DC File Offset: 0x0008FADC
		Public Sub ExportStructure()
			OO_00oOO.ExportStructure()
		End Sub

		' Token: 0x06001638 RID: 5688 RVA: 0x000918E3 File Offset: 0x0008FAE3
		Public Sub ExportEventCode(Optional tpe As OO_00oOO.OoOO = OO_00oOO.OoOO.O_Oo_0.0., Optional nm As String = "")
			OO_00oOO.oo0oOO.o.(tpe, nm)
		End Sub

		' Token: 0x170004C8 RID: 1224
		' (get) Token: 0x06001639 RID: 5689 RVA: 0x000918EC File Offset: 0x0008FAEC
		Public ReadOnly Property Registry As RegistryProxy
			Get
				Return OO_00oOO.Registry
			End Get
		End Property

		' Token: 0x0600163A RID: 5690 RVA: 0x000918F4 File Offset: 0x0008FAF4
		Public Function InputPassword(ByRef passWord As String, Text As String, Description As String) As String
			Dim result As String
			If OO_00oOO.InputPassword(passWord, Text, Description) Then
				result = passWord
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x0600163B RID: 5691 RVA: 0x00091918 File Offset: 0x0008FB18
		Public Function InputValue(ParamArray args As Object()) As String
			If args.Length >= 3 Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
				Dim text As String = args(1).ToString()
				Dim description As String = args(2).ToString()
				If args.Length = 3 Then
					If OO_00oOO.InputValue(objectValue, text, description) Then
						Return objectValue.ToString()
					End If
					Return Nothing
				ElseIf args.Length >= 4 Then
					If TypeOf args(3)Is Boolean Then
						If OO_00oOO.InputValue(objectValue, text, description, Conversions.ToBoolean(args(3))) Then
							Return objectValue.ToString()
						End If
						Return Nothing
					ElseIf TypeOf args(3)Is String Then
						If args.Length = 4 Then
							If OO_00oOO.InputValue(objectValue, text, description, args(3).ToString()) Then
								Return objectValue.ToString()
							End If
							Return Nothing
						ElseIf args.Length >= 5 AndAlso TypeOf args(4)Is Boolean Then
							Dim multiSelect As Boolean = Conversions.ToBoolean(args(4))
							If OO_00oOO.InputValue(objectValue, text, description, args(3).ToString(), multiSelect) Then
								Return objectValue.ToString()
							End If
							Return Nothing
						End If
					End If
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x0600163C RID: 5692 RVA: 0x00091A0F File Offset: 0x0008FC0F
		Public Function FileIsOpened(FName As String) As Boolean
			Return OO_00oOO.FileIsOpened(FName)
		End Function

		' Token: 0x170004C9 RID: 1225
		' (get) Token: 0x0600163D RID: 5693 RVA: 0x00091A17 File Offset: 0x0008FC17
		Public ReadOnly Property BaseMainForm As Form
			Get
				Return OO_00oOO.BaseMainForm
			End Get
		End Property

		' Token: 0x170004CA RID: 1226
		' (get) Token: 0x0600163E RID: 5694 RVA: 0x00091A1E File Offset: 0x0008FC1E
		' (set) Token: 0x0600163F RID: 5695 RVA: 0x00091A25 File Offset: 0x0008FC25
		Public Property TableCaptionVisible As Boolean
			Get
				Return OO_00oOO.TableCaptionVisible
			End Get
			Set(value As Boolean)
				OO_00oOO.TableCaptionVisible = value
			End Set
		End Property

		' Token: 0x170004CB RID: 1227
		' (get) Token: 0x06001640 RID: 5696 RVA: 0x00091A2D File Offset: 0x0008FC2D
		' (set) Token: 0x06001641 RID: 5697 RVA: 0x00091A34 File Offset: 0x0008FC34
		Public Property ShowCloseButton As Boolean
			Get
				Return OO_00oOO.ShowCloseButton
			End Get
			Set(value As Boolean)
				OO_00oOO.ShowCloseButton = value
			End Set
		End Property

		' Token: 0x170004CC RID: 1228
		' (get) Token: 0x06001642 RID: 5698 RVA: 0x00091A3C File Offset: 0x0008FC3C
		Public ReadOnly Property LastInputTickCount As Long
			Get
				Return OO_00oOO.LastInputTickCount
			End Get
		End Property

		' Token: 0x06001643 RID: 5699 RVA: 0x00091A43 File Offset: 0x0008FC43
		Public Sub CreateBlankAccessFile()
			OO_00oOO.CreateBlankAccessFile()
		End Sub

		' Token: 0x170004CD RID: 1229
		' (get) Token: 0x06001644 RID: 5700 RVA: 0x00091A4A File Offset: 0x0008FC4A
		Public ReadOnly Property Users As UserInfos
			Get
				Return OO_00oOO.Users
			End Get
		End Property

		' Token: 0x170004CE RID: 1230
		' (get) Token: 0x06001645 RID: 5701 RVA: 0x00091A51 File Offset: 0x0008FC51
		Public ReadOnly Property FoxSMS As FoxSMSControl
			Get
				Return OO_00oOO.FoxSMS
			End Get
		End Property

		' Token: 0x06001646 RID: 5702 RVA: 0x00091A58 File Offset: 0x0008FC58
		Public Function CompactAccessFile(FileName As String, Optional PassWord As String = "", Optional backup As Boolean = True) As Boolean
			Return OO_00oOO.CompactAccessFile(FileName, PassWord, backup)
		End Function

		' Token: 0x06001647 RID: 5703 RVA: 0x00091A62 File Offset: 0x0008FC62
		Public Function CompactToAccess(FileName As String, Password As String) As Boolean
			Return OO_00oOO.CompactToAccess(FileName, Password)
		End Function

		' Token: 0x06001648 RID: 5704 RVA: 0x00091A6B File Offset: 0x0008FC6B
		Public Function TryConnectHost(address As String) As Boolean
			Return OO_00oOO.TryConnectHost(address)
		End Function

		' Token: 0x06001649 RID: 5705 RVA: 0x00091A73 File Offset: 0x0008FC73
		Public Function FindAppWindow(Caption As String) As Integer
			Return OO_00oOO.FindAppWindow(Caption)
		End Function

		' Token: 0x0600164A RID: 5706 RVA: 0x00091A7B File Offset: 0x0008FC7B
		Public Function ShowAppWindow(Caption As String, State As Integer) As Boolean
			Return OO_00oOO.ShowAppWindow(Caption, State)
		End Function

		' Token: 0x0600164B RID: 5707 RVA: 0x00091A84 File Offset: 0x0008FC84
		Public Sub LockBaseMainForm()
			OO_00oOO.LockBaseMainForm()
		End Sub

		' Token: 0x0600164C RID: 5708 RVA: 0x00091A8B File Offset: 0x0008FC8B
		Public Sub UnlockBaseMainForm()
			OO_00oOO.UnlockBaseMainForm()
		End Sub

		' Token: 0x170004CF RID: 1231
		' (get) Token: 0x0600164D RID: 5709 RVA: 0x00091A92 File Offset: 0x0008FC92
		' (set) Token: 0x0600164E RID: 5710 RVA: 0x00091A99 File Offset: 0x0008FC99
		Public Property SystemMenu As Boolean
			Get
				Return OO_00oOO.SystemMenu
			End Get
			Set(value As Boolean)
				OO_00oOO.SystemMenu = value
			End Set
		End Property

		' Token: 0x0600164F RID: 5711 RVA: 0x00091AA1 File Offset: 0x0008FCA1
		Public Function CExp(expr As String, ParamArray values As String()) As String
			Return OO_00oOO.CExp(expr, values)
		End Function

		' Token: 0x170004D0 RID: 1232
		' (get) Token: 0x06001650 RID: 5712 RVA: 0x00091AAA File Offset: 0x0008FCAA
		' (set) Token: 0x06001651 RID: 5713 RVA: 0x00091AB1 File Offset: 0x0008FCB1
		Public Property SystemReady As Boolean
			Get
				Return OO_00oOO.SystemReady
			End Get
			Set(value As Boolean)
				OO_00oOO.SystemReady = value
			End Set
		End Property

		' Token: 0x170004D1 RID: 1233
		' (get) Token: 0x06001652 RID: 5714 RVA: 0x00091AB9 File Offset: 0x0008FCB9
		Public ReadOnly Property IMServers As IMServerCollections
			Get
				Return OO_00oOO.IMServers
			End Get
		End Property

		' Token: 0x170004D2 RID: 1234
		' (get) Token: 0x06001653 RID: 5715 RVA: 0x00091AC0 File Offset: 0x0008FCC0
		Public ReadOnly Property IMClients As IMClientCollections
			Get
				Return OO_00oOO.IMClients
			End Get
		End Property

		' Token: 0x170004D3 RID: 1235
		' (get) Token: 0x06001654 RID: 5716 RVA: 0x00091AC7 File Offset: 0x0008FCC7
		Public ReadOnly Property QQServers As IMServerCollections
			Get
				Return OO_00oOO.QQServers
			End Get
		End Property

		' Token: 0x170004D4 RID: 1236
		' (get) Token: 0x06001655 RID: 5717 RVA: 0x00091ACE File Offset: 0x0008FCCE
		Public ReadOnly Property QQClients As IMClientCollections
			Get
				Return OO_00oOO.QQClients
			End Get
		End Property

		' Token: 0x170004D5 RID: 1237
		' (get) Token: 0x06001656 RID: 5718 RVA: 0x00091AD5 File Offset: 0x0008FCD5
		Public ReadOnly Property UDPClients As oO_OO_o0_
			Get
				Return OO_00oOO.UDPClients
			End Get
		End Property

		' Token: 0x170004D6 RID: 1238
		' (get) Token: 0x06001657 RID: 5719 RVA: 0x00091ADC File Offset: 0x0008FCDC
		Public ReadOnly Property QQServer As IMServer
			Get
				Return OO_00oOO.QQServer
			End Get
		End Property

		' Token: 0x170004D7 RID: 1239
		' (get) Token: 0x06001658 RID: 5720 RVA: 0x00091AE3 File Offset: 0x0008FCE3
		Public ReadOnly Property QQClient As IMClient
			Get
				Return OO_00oOO.QQClient
			End Get
		End Property

		' Token: 0x06001659 RID: 5721 RVA: 0x00091AEA File Offset: 0x0008FCEA
		Public Function GetPinYin(hzStr As String, Optional mode As Integer = 0) As String
			Return OO_00oOO.GetPinYin(hzStr, mode)
		End Function

		' Token: 0x0600165A RID: 5722 RVA: 0x00091AF3 File Offset: 0x0008FCF3
		Public Function ReadBirthDay(PIN As String) As DateTime
			Return ChinesFunctions.ReadBirthDay(PIN)
		End Function

		' Token: 0x0600165B RID: 5723 RVA: 0x00091AFB File Offset: 0x0008FCFB
		Public Function ReadSex(PIN As String) As String
			Return ChinesFunctions.ReadSex(PIN)
		End Function

		' Token: 0x0600165C RID: 5724 RVA: 0x00091B03 File Offset: 0x0008FD03
		Public Function ValidPIN(PIN As String) As Boolean
			Return ChinesFunctions.ValidPIN(PIN)
		End Function

		' Token: 0x0600165D RID: 5725 RVA: 0x00091B0B File Offset: 0x0008FD0B
		Public Function CLDate(value As DateTime) As String
			Return ChinesFunctions.CLDate(value)
		End Function

		' Token: 0x0600165E RID: 5726 RVA: 0x00091B13 File Offset: 0x0008FD13
		Public Function CUDate(Value As DateTime) As String
			Return ChinesFunctions.CUDate(Value)
		End Function

		' Token: 0x0600165F RID: 5727 RVA: 0x00091B1B File Offset: 0x0008FD1B
		Public Function CCDate(value As DateTime) As String
			Return ChinesFunctions.CCDate(value)
		End Function

		' Token: 0x06001660 RID: 5728 RVA: 0x00091B23 File Offset: 0x0008FD23
		Public Function CUMoney(Value As String) As String
			Return ChinesFunctions.CUMoney(Value)
		End Function

		' Token: 0x06001661 RID: 5729 RVA: 0x00091B2B File Offset: 0x0008FD2B
		Public Function CUNumber(value As String) As String
			Return ChinesFunctions.CUNumber(value)
		End Function

		' Token: 0x06001662 RID: 5730 RVA: 0x00091B33 File Offset: 0x0008FD33
		Public Function CUNUM(value As Integer) As String
			Return ChinesFunctions.CUNUM(value)
		End Function

		' Token: 0x06001663 RID: 5731 RVA: 0x00091B3B File Offset: 0x0008FD3B
		Public Function CLNUM(value As Integer) As String
			Return ChinesFunctions.CLNUM(value)
		End Function

		' Token: 0x06001664 RID: 5732 RVA: 0x00091B43 File Offset: 0x0008FD43
		Public Function CCNumber(Value As String) As String
			Return ChinesFunctions.CCNumber(Value)
		End Function

		' Token: 0x06001665 RID: 5733 RVA: 0x00091B4B File Offset: 0x0008FD4B
		Public Function EUMoney(Value As String) As String
			Return ChinesFunctions.EUMoney(Value)
		End Function

		' Token: 0x06001666 RID: 5734 RVA: 0x00091B53 File Offset: 0x0008FD53
		Public Function EUNumber(Value As String) As String
			Return ChinesFunctions.EUMoney(Value)
		End Function

		' Token: 0x06001667 RID: 5735 RVA: 0x00091B5C File Offset: 0x0008FD5C
		Public Function GetDigit(ParamArray args As Object()) As Char
			Dim digit As Char
			If args.Length = 2 Then
				digit = ChinesFunctions.GetDigit(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)), "￥"c)
			ElseIf args.Length = 3 Then
				digit = ChinesFunctions.GetDigit(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)), Conversions.ToChar(args(2)))
			End If
			Return digit
		End Function

		' Token: 0x06001668 RID: 5736 RVA: 0x00091BB1 File Offset: 0x0008FDB1
		Public Function StrToWide(str As String) As String
			Return ChinesFunctions.StrToWide(str)
		End Function

		' Token: 0x06001669 RID: 5737 RVA: 0x00091BB9 File Offset: 0x0008FDB9
		Public Function StrToNarrow(str As String) As String
			Return ChinesFunctions.StrToNarrow(str)
		End Function

		' Token: 0x0600166A RID: 5738 RVA: 0x00091BC1 File Offset: 0x0008FDC1
		Public Function StrToSimplified(str As String) As String
			Return ChinesFunctions.StrToSimplified(str)
		End Function

		' Token: 0x0600166B RID: 5739 RVA: 0x00091BC9 File Offset: 0x0008FDC9
		Public Function StrToTraditional(str As String) As String
			Return ChinesFunctions.StrToTraditional(str)
		End Function

		' Token: 0x0600166C RID: 5740 RVA: 0x00091BD1 File Offset: 0x0008FDD1
		Public Sub DateYMD(dt1 As DateTime, dt2 As DateTime, ByRef y As Integer, ByRef m As Integer, ByRef d As Integer)
			ChinesFunctions.DateYMD(dt1, dt2, y, m, d)
		End Sub

		' Token: 0x0600166D RID: 5741 RVA: 0x00091BDF File Offset: 0x0008FDDF
		Public Function DecToBin(Dec As Long) As String
			Return ChinesFunctions.DecToBin(Dec)
		End Function

		' Token: 0x0600166E RID: 5742 RVA: 0x00091BE7 File Offset: 0x0008FDE7
		Public Function DecToHex(Dec As Long) As String
			Return ChinesFunctions.DecToHex(Dec)
		End Function

		' Token: 0x0600166F RID: 5743 RVA: 0x00091BEF File Offset: 0x0008FDEF
		Public Function DecToOct(Dec As Long) As String
			Return ChinesFunctions.DecToOct(Dec)
		End Function

		' Token: 0x06001670 RID: 5744 RVA: 0x00091BF7 File Offset: 0x0008FDF7
		Public Function HexToDec(value As String) As Long
			Return ChinesFunctions.HexToDec(value)
		End Function

		' Token: 0x06001671 RID: 5745 RVA: 0x00091BFF File Offset: 0x0008FDFF
		Public Function OctToDec(value As String) As Long
			Return ChinesFunctions.OctToDec(value)
		End Function

		' Token: 0x06001672 RID: 5746 RVA: 0x00091C07 File Offset: 0x0008FE07
		Public Function BinToDec(value As String) As Long
			Return Me.BinToDec(value)
		End Function

		' Token: 0x06001673 RID: 5747 RVA: 0x00091C10 File Offset: 0x0008FE10
		Public Function EncryptText(Text As String, Key As String, IV As String) As String
			Return O00.EncryptText(Text, Key, IV)
		End Function

		' Token: 0x06001674 RID: 5748 RVA: 0x00091C1A File Offset: 0x0008FE1A
		Public Function DecryptText(Text As String, Key As String, IV As String) As String
			Return O00.DecryptText(Text, Key, IV)
		End Function

		' Token: 0x06001675 RID: 5749 RVA: 0x00091C24 File Offset: 0x0008FE24
		Public Function MD5Encrypt(strToHash As String) As String
			Return O00.MD5Encrypt(strToHash)
		End Function

		' Token: 0x06001676 RID: 5750 RVA: 0x00091C2C File Offset: 0x0008FE2C
		Public Function CRCCheckFile(FileName As String) As String
			Return O00.CRCCheckFile(FileName)
		End Function

		' Token: 0x06001677 RID: 5751 RVA: 0x00091C34 File Offset: 0x0008FE34
		Public Function CRCCheckString(strValue As String) As String
			Return O00.CRCCheckString(strValue)
		End Function

		' Token: 0x06001678 RID: 5752 RVA: 0x00091C3C File Offset: 0x0008FE3C
		Public Function EncryptFile(InFile As String, OutFile As String, PassWord As String) As Boolean
			Return O00.EncryptFile(InFile, OutFile, PassWord)
		End Function

		' Token: 0x06001679 RID: 5753 RVA: 0x00091C46 File Offset: 0x0008FE46
		Public Function DecryptFile(InFile As String, OutFile As String, PassWord As String) As Boolean
			Return O00.DecryptFile(InFile, OutFile, PassWord)
		End Function

		' Token: 0x170004D8 RID: 1240
		' (get) Token: 0x0600167A RID: 5754 RVA: 0x00091C50 File Offset: 0x0008FE50
		Public ReadOnly Property HttpServer As HttpListenter
			Get
				Return OO_00oOO.HttpServer
			End Get
		End Property

		' Token: 0x0600167B RID: 5755 RVA: 0x00091C57 File Offset: 0x0008FE57
		Public Sub PopMessage(Message As String, Optional Caption As String = "提示", Optional Icon As PopiconEnum = 0, Optional Duration As Integer = -1)
			OO_00oOO.PopMessage(Message, Caption, Icon, Duration)
		End Sub

		' Token: 0x170004D9 RID: 1241
		' (get) Token: 0x0600167C RID: 5756 RVA: 0x00091C63 File Offset: 0x0008FE63
		Public ReadOnly Property DongleID As String
			Get
				Return OO_00oOO.DongleID
			End Get
		End Property

		' Token: 0x170004DA RID: 1242
		' (get) Token: 0x0600167D RID: 5757 RVA: 0x00091C6A File Offset: 0x0008FE6A
		Public ReadOnly Property ProjectID As String
			Get
				Return OO_00oOO.ProjectID
			End Get
		End Property

		' Token: 0x0600167E RID: 5758 RVA: 0x00091C71 File Offset: 0x0008FE71
		Public Sub Sleep(msec As Integer)
			OO_00oOO.Sleep(msec)
		End Sub

		' Token: 0x0600167F RID: 5759 RVA: 0x00091C79 File Offset: 0x0008FE79
		Public Function OSVersion() As Integer
			Return OO_00oOO.OSVersion()
		End Function

		' Token: 0x170004DB RID: 1243
		' (get) Token: 0x06001680 RID: 5760 RVA: 0x00091C80 File Offset: 0x0008FE80
		' (set) Token: 0x06001681 RID: 5761 RVA: 0x00091C87 File Offset: 0x0008FE87
		Public Property ControlTheme As String
			Get
				Return OO_00oOO.ControlTheme
			End Get
			Set(value As String)
				OO_00oOO.ControlTheme = value
			End Set
		End Property

		' Token: 0x170004DC RID: 1244
		' (get) Token: 0x06001682 RID: 5762 RVA: 0x00091C8F File Offset: 0x0008FE8F
		' (set) Token: 0x06001683 RID: 5763 RVA: 0x00091C96 File Offset: 0x0008FE96
		Public Property RibbonTheme As String
			Get
				Return OO_00oOO.RibbonTheme
			End Get
			Set(value As String)
				OO_00oOO.RibbonTheme = value
			End Set
		End Property

		' Token: 0x170004DD RID: 1245
		' (get) Token: 0x06001684 RID: 5764 RVA: 0x00091C9E File Offset: 0x0008FE9E
		' (set) Token: 0x06001685 RID: 5765 RVA: 0x00091CA5 File Offset: 0x0008FEA5
		Public Property GridTheme As String
			Get
				Return OO_00oOO.GridTheme
			End Get
			Set(value As String)
				OO_00oOO.GridTheme = value
			End Set
		End Property

		' Token: 0x170004DE RID: 1246
		' (get) Token: 0x06001686 RID: 5766 RVA: 0x00091CAD File Offset: 0x0008FEAD
		Public ReadOnly Property Themes As List(Of String)
			Get
				Return OO_00oOO.Themes
			End Get
		End Property

		' Token: 0x06001687 RID: 5767 RVA: 0x00091CB4 File Offset: 0x0008FEB4
		Public Function isUserColdeRunning() As Boolean
			Return OO_00oOO.isUserColdeRunning()
		End Function

		' Token: 0x06001688 RID: 5768 RVA: 0x00091CBC File Offset: 0x0008FEBC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GroupTableBuilder(TableName As String, ParamArray args As Object()) As GroupTableBuilder
			Dim result As GroupTableBuilder
			Try
				Dim num As Integer = args.Length
				If num <> 1 Then
					If num = 2 Then
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
						Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(1))
						If TypeOf objectValue Is DataTable AndAlso TypeOf objectValue2 Is String Then
							Dim a_ As DataTable = CType(objectValue, DataTable)
							Dim a_2 As String = Conversions.ToString(objectValue2)
							Return New GroupTableBuilder(TableName, a_, a_2)
						End If
						If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is String Then
							Dim a_3 As String = Conversions.ToString(objectValue)
							Dim a_4 As String = Conversions.ToString(objectValue2)
							Return New GroupTableBuilder(TableName, a_3, a_4)
						End If
					End If
				Else
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(0))
					If TypeOf objectValue3 Is DataTable Then
						Dim a_5 As DataTable = CType(objectValue3, DataTable)
						Return New GroupTableBuilder(TableName, a_5)
					End If
					If TypeOf objectValue3 Is String Then
						Dim a_6 As String = Conversions.ToString(objectValue3)
						Return New GroupTableBuilder(TableName, a_6)
					End If
				End If
				Throw New Exception("传入的参数组合不匹配GroupTableBuilder的任何构造函数，请检查参数类型和个数！")
			Catch ex As Exception
				Interaction.MsgBox(String.Format("创建GroupTableBuilder失败：{0}", ex.Message), MsgBoxStyle.OkOnly, Nothing)
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x06001689 RID: 5769 RVA: 0x00091DDC File Offset: 0x0008FFDC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function CrossTableBuilder(TableName As String, ParamArray args As Object()) As CrossTableBuilder
			Dim num As Integer = args.Length
			If num <> 1 Then
				If num = 2 Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(1))
					If TypeOf objectValue Is DataTable AndAlso TypeOf objectValue2 Is String Then
						Dim a_ As DataTable = CType(objectValue, DataTable)
						Dim a_2 As String = Conversions.ToString(objectValue2)
						Return New CrossTableBuilder(TableName, a_, a_2)
					End If
					If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is String Then
						Dim a_3 As String = Conversions.ToString(objectValue)
						Dim a_4 As String = Conversions.ToString(objectValue2)
						Return New CrossTableBuilder(TableName, a_3, a_4)
					End If
				End If
			Else
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(0))
				If TypeOf objectValue3 Is DataTable Then
					Dim a_5 As DataTable = CType(objectValue3, DataTable)
					Return New CrossTableBuilder(TableName, a_5)
				End If
				If TypeOf objectValue3 Is String Then
					Dim a_6 As String = Conversions.ToString(objectValue3)
					Return New CrossTableBuilder(TableName, a_6)
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x0600168A RID: 5770 RVA: 0x00091EB8 File Offset: 0x000900B8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLCrossTableBuilder(TableName As String, ParamArray args As Object()) As SQLCrossTableBuilder
			Dim num As Integer = args.Length
			If num <> 1 Then
				If num = 2 Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(1))
					If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is String Then
						Dim a_ As String = Conversions.ToString(objectValue)
						Dim a_2 As String = Conversions.ToString(objectValue2)
						Return New SQLCrossTableBuilder(TableName, a_, a_2)
					End If
				End If
			Else
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(0))
				If TypeOf objectValue3 Is String Then
					Dim a_3 As String = Conversions.ToString(objectValue3)
					Return New SQLCrossTableBuilder(TableName, a_3)
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x0600168B RID: 5771 RVA: 0x00091F40 File Offset: 0x00090140
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLGroupTableBuilder(TableName As String, ParamArray args As Object()) As SQLGroupTableBuilder
			Dim num As Integer = args.Length
			If num <> 1 Then
				If num = 2 Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(1))
					If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is String Then
						Dim a_ As String = Conversions.ToString(objectValue)
						Dim a_2 As String = Conversions.ToString(objectValue2)
						Return New SQLGroupTableBuilder(TableName, a_, a_2)
					End If
				End If
			Else
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(0))
				If TypeOf objectValue3 Is String Then
					Dim a_3 As String = Conversions.ToString(objectValue3)
					Return New SQLGroupTableBuilder(TableName, a_3)
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x0600168C RID: 5772 RVA: 0x00091FC5 File Offset: 0x000901C5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLJoinTableBuilder(TableName As String, BaseTable As String) As SQLJoinTableBuilder
			Return New SQLJoinTableBuilder(TableName, BaseTable)
		End Function

		' Token: 0x0600168D RID: 5773 RVA: 0x00091FD0 File Offset: 0x000901D0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SQLCommand(ParamArray args As Object()) As SQLCommand
			Dim result As SQLCommand
			If args.Length = 0 Then
				result = New SQLCommand()
			ElseIf args.Length = 1 Then
				result = New SQLCommand(Conversions.ToString(args(0)))
			ElseIf args.Length = 2 Then
				result = New SQLCommand(Conversions.ToString(args(0)), Conversions.ToString(args(1)))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x0600168E RID: 5774 RVA: 0x00092021 File Offset: 0x00090221
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function DropTreeBuilder() As DropTreeBuilder
			Return New DropTreeBuilder()
		End Function

		' Token: 0x0600168F RID: 5775 RVA: 0x00092028 File Offset: 0x00090228
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function QueryBuilder(ParamArray args As Object()) As QueryBuilder
			Dim result As QueryBuilder
			If args.Length = 0 Then
				result = New QueryBuilder()
			ElseIf args.Length = 1 Then
				result = New QueryBuilder(Conversions.ToString(args(0)))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001690 RID: 5776 RVA: 0x0009205C File Offset: 0x0009025C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function OuterTableBuilder(ParamArray args As Object()) As OuterTableBuilder
			Dim result As OuterTableBuilder
			If args.Length = 0 Then
				result = New OuterTableBuilder()
			ElseIf args.Length = 1 Then
				result = New OuterTableBuilder(Conversions.ToString(args(0)))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001691 RID: 5777 RVA: 0x00092090 File Offset: 0x00090290
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function InlineMRPBuilder(ParamArray args As Object()) As InlineMRPBuilder
			Dim result As InlineMRPBuilder
			If args.Length = 0 Then
				result = New InlineMRPBuilder()
			ElseIf args.Length = 1 Then
				result = New InlineMRPBuilder(Conversions.ToString(args(0)))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001692 RID: 5778 RVA: 0x000920C4 File Offset: 0x000902C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function LayersMRPBuilder(ParamArray args As Object()) As LayersMRPBuilder
			Dim result As LayersMRPBuilder
			If args.Length = 0 Then
				result = New LayersMRPBuilder()
			ElseIf args.Length = 1 Then
				result = New LayersMRPBuilder(Conversions.ToString(args(0)))
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001693 RID: 5779 RVA: 0x000920F7 File Offset: 0x000902F7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function InlineTreeSetting() As InlineTreeSetting
			Return New InlineTreeSetting()
		End Function

		' Token: 0x06001694 RID: 5780 RVA: 0x000920FE File Offset: 0x000902FE
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function LayerTreeSetting() As LayerTreeSetting
			Return New LayerTreeSetting()
		End Function

		' Token: 0x06001695 RID: 5781 RVA: 0x00092105 File Offset: 0x00090305
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GroupTreeSetting() As GroupTreeSetting
			Return New GroupTreeSetting()
		End Function

		' Token: 0x06001696 RID: 5782 RVA: 0x0009210C File Offset: 0x0009030C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Exporter() As Exporter
			Return New Exporter()
		End Function

		' Token: 0x06001697 RID: 5783 RVA: 0x00092113 File Offset: 0x00090313
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Importer() As Importer
			Return New Importer()
		End Function

		' Token: 0x06001698 RID: 5784 RVA: 0x0009211A File Offset: 0x0009031A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Merger() As Merger
			Return New Merger()
		End Function

		' Token: 0x06001699 RID: 5785 RVA: 0x00092121 File Offset: 0x00090321
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function SaveFileDialog() As SaveFileDialogForjs
			Return New SaveFileDialogForjs(Me.Oo_00_oO.00O0O.)
		End Function

		' Token: 0x0600169A RID: 5786 RVA: 0x0009212E File Offset: 0x0009032E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function OpenFileDialog() As OpenFileDialogForjs
			Return New OpenFileDialogForjs(Me.Oo_00_oO.00O0O.)
		End Function

		' Token: 0x0600169B RID: 5787 RVA: 0x0009213B File Offset: 0x0009033B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function FolderBrowserDialog() As FolderBrowserDialogForjs
			Return New FolderBrowserDialogForjs(Me.Oo_00_oO.00O0O.)
		End Function

		' Token: 0x0600169C RID: 5788 RVA: 0x00092148 File Offset: 0x00090348
		Public Function ColorDialog() As ColorDialogJs
			Return New ColorDialogJs(Me.Oo_00_oO.00O0O.)
		End Function

		' Token: 0x0600169D RID: 5789 RVA: 0x00092155 File Offset: 0x00090355
		Public Function FontDialog() As FontDialogJs
			Return New FontDialogJs(Me.Oo_00_oO.00O0O.)
		End Function

		' Token: 0x0600169E RID: 5790 RVA: 0x00092162 File Offset: 0x00090362
		Public Function MessageBox() As MessageBoxForJs
			Return New MessageBoxForJs(Me.Oo_00_oO.00O0O.)
		End Function

		' Token: 0x0600169F RID: 5791 RVA: 0x0009216F File Offset: 0x0009036F
		Public Function FileInfo(file As String) As FileInfo
			Return New FileInfo(file)
		End Function

		' Token: 0x060016A0 RID: 5792 RVA: 0x00092178 File Offset: 0x00090378
		Public Function Font(ParamArray args As Object()) As Font
			Dim result As Font
			If args.Length = 2 Then
				result = New Font(Conversions.ToString(args(0)), CSng(Conversions.ToInteger(args(1))))
			Else
				result = New Font(Conversions.ToString(args(0)), CSng(Conversions.ToInteger(args(1))), CType(Conversions.ToInteger(args(2)), FontStyle))
			End If
			Return result
		End Function

		' Token: 0x060016A1 RID: 5793 RVA: 0x000921C4 File Offset: 0x000903C4
		Public Function DataTableBuilder(TableName As String) As DataTableBuilder
			Return New DataTableBuilder(TableName)
		End Function

		' Token: 0x060016A2 RID: 5794 RVA: 0x000921CC File Offset: 0x000903CC
		Public Function SubtotalGroup() As SubtotalGroup
			Return New SubtotalGroup()
		End Function

		' Token: 0x060016A3 RID: 5795 RVA: 0x000921D3 File Offset: 0x000903D3
		Public Function ImageMap() As ImageMap
			Return New ImageMap()
		End Function

		' Token: 0x060016A4 RID: 5796 RVA: 0x000921DA File Offset: 0x000903DA
		Public Function MultiDataMap() As MultiDataMap
			Return New MultiDataMap()
		End Function

		' Token: 0x060016A5 RID: 5797 RVA: 0x000921E1 File Offset: 0x000903E1
		Public Function Process() As Process
			Return New Process()
		End Function

		' Token: 0x060016A6 RID: 5798 RVA: 0x000921E8 File Offset: 0x000903E8
		Public Function TableDataMap() As TableDataMap
			Return New TableDataMap()
		End Function

		' Token: 0x060016A7 RID: 5799 RVA: 0x000921EF File Offset: 0x000903EF
		Public Function DataMap() As DataMapJs
			Return New DataMapJs()
		End Function

		' Token: 0x060016A8 RID: 5800 RVA: 0x000921F8 File Offset: 0x000903F8
		Public Function FTPClient(ParamArray args As Object()) As FTPClient
			Dim result As FTPClient
			If args.Length = 0 Then
				result = New FTPClient()
			Else
				If args.Length >= 3 Then
					Dim a_ As String = Conversions.ToString(args(0))
					Dim a_2 As String = Conversions.ToString(args(1))
					Dim a_3 As String = Conversions.ToString(args(2))
					Select Case args.Length
						Case 3
							Return New FTPClient(a_, a_2, a_3, Nothing)
						Case 4
							Dim encoding As Encoding = Encoding.GetEncoding(Conversions.ToString(args(3)))
							Return New FTPClient(a_, a_2, a_3, encoding)
						Case 5, 6
							Dim a_4 As Integer = Conversions.ToInteger(args(3))
							Dim a_5 As Integer = Conversions.ToInteger(args(4))
							If args.Length = 5 Then
								Return New FTPClient(a_, a_2, a_3, a_4, a_5, Nothing)
							End If
							Dim encoding2 As Encoding = Encoding.GetEncoding(Conversions.ToString(args(5)))
							Return New FTPClient(a_, a_2, a_3, a_4, a_5, encoding2)
					End Select
				End If
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060016A9 RID: 5801 RVA: 0x000922CE File Offset: 0x000904CE
		Public Function InlineGroupTableBuilder(TableName As String) As InlineGroupTableBuilder
			Return New InlineGroupTableBuilder(TableName)
		End Function

		' Token: 0x060016AA RID: 5802 RVA: 0x000922D6 File Offset: 0x000904D6
		Public Function LayersGroupTableBuilder(TableName As String) As LayersGroupTableBuilder
			Return New LayersGroupTableBuilder(TableName)
		End Function

		' Token: 0x060016AB RID: 5803 RVA: 0x000922DE File Offset: 0x000904DE
		Public Function MailSender() As MailSender
			Return New MailSender()
		End Function

		' Token: 0x170004DF RID: 1247
		' (get) Token: 0x060016AC RID: 5804 RVA: 0x000922E5 File Offset: 0x000904E5
		Public ReadOnly Property RibbonMenu As RibbonMenuJs
			Get
				If Me.Oo_00_oO.00O0O. Is Nothing Then
					Me.Oo_00_oO.00O0O. = New RibbonMenuJs()
				End If
				Return Me.Oo_00_oO.00O0O.
			End Get
		End Property

		' Token: 0x170004E0 RID: 1248
		' (get) Token: 0x060016AD RID: 5805 RVA: 0x00092300 File Offset: 0x00090500
		Public ReadOnly Property SendKeys As SendkeysJs
			Get
				If Me.Oo_00_oO.00O0O. Is Nothing Then
					Me.Oo_00_oO.00O0O. = New SendkeysJs()
				End If
				Return Me.Oo_00_oO.00O0O.
			End Get
		End Property

		' Token: 0x170004E1 RID: 1249
		' (get) Token: 0x060016AE RID: 5806 RVA: 0x0009231B File Offset: 0x0009051B
		Public ReadOnly Property ClipBoard As ClipBoardJs
			Get
				If Me.O.0_o0. Is Nothing Then
					Me.O.0_o0. = New ClipBoardJs()
				End If
				Return Me.O.0_o0.
			End Get
		End Property

		' Token: 0x04000910 RID: 2320
		Private <<EMPTY_NAME>> As List(Of Assembly)

		' Token: 0x04000911 RID: 2321
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000912 RID: 2322
		Private <<EMPTY_NAME>> As Dictionary(Of String, Type)

		' Token: 0x04000913 RID: 2323
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x04000914 RID: 2324
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000915 RID: 2325
		Private <<EMPTY_NAME>> As Randjs

		' Token: 0x04000916 RID: 2326
		Private <<EMPTY_NAME>> As PYJS

		' Token: 0x04000917 RID: 2327
		Private <<EMPTY_NAME>> As AudioJs

		' Token: 0x04000918 RID: 2328
		Private <<EMPTY_NAME>> As RibbonMenuJs

		' Token: 0x04000919 RID: 2329
		Private <<EMPTY_NAME>> As SendkeysJs

		' Token: 0x0400091A RID: 2330
		Private <<EMPTY_NAME>> As ClipBoardJs
	End Class
End Namespace
