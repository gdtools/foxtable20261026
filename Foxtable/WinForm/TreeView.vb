Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000527 RID: 1319
	<ComVisible(True)>
	Public Class TreeView
		Inherits Control

		' Token: 0x060056ED RID: 22253 RVA: 0x00223689 File Offset: 0x00221889
		Public Sub New(A_0 As TreeView)
			MyBase.New(A_0, ControlTypeEnum.TreeView)
			Me.oO._o_00_O. = A_0
			A_0.ShowNodeToolTips = True
			A_0.HideSelection = False
		End Sub

		' Token: 0x17001529 RID: 5417
		' (get) Token: 0x060056EE RID: 22254 RVA: 0x002236A9 File Offset: 0x002218A9
		' (set) Token: 0x060056EF RID: 22255 RVA: 0x002236B6 File Offset: 0x002218B6
		<oO0oooo("1286")>
		Public Property CheckBoxes As Boolean
			Get
				Return Me.oO._o_00_O..CheckBoxes
			End Get
			Set(value As Boolean)
				Me.oO._o_00_O..CheckBoxes = value
				If value Then
					Me.ItemHeight = Math.Max(16, Me.ItemHeight)
				End If
			End Set
		End Property

		' Token: 0x1700152A RID: 5418
		' (get) Token: 0x060056F0 RID: 22256 RVA: 0x002236DA File Offset: 0x002218DA
		' (set) Token: 0x060056F1 RID: 22257 RVA: 0x002236E7 File Offset: 0x002218E7
		Public Property ShowPlusMinus As Boolean
			Get
				Return Me.oO._o_00_O..ShowPlusMinus
			End Get
			Set(value As Boolean)
				Me.oO._o_00_O..ShowPlusMinus = value
			End Set
		End Property

		' Token: 0x1700152B RID: 5419
		' (get) Token: 0x060056F2 RID: 22258 RVA: 0x002236F5 File Offset: 0x002218F5
		' (set) Token: 0x060056F3 RID: 22259 RVA: 0x00223702 File Offset: 0x00221902
		Public Property ShowLines As Boolean
			Get
				Return Me.oO._o_00_O..ShowLines
			End Get
			Set(value As Boolean)
				Me.oO._o_00_O..ShowLines = value
			End Set
		End Property

		' Token: 0x1700152C RID: 5420
		' (get) Token: 0x060056F4 RID: 22260 RVA: 0x00223710 File Offset: 0x00221910
		' (set) Token: 0x060056F5 RID: 22261 RVA: 0x0022371D File Offset: 0x0022191D
		Public Property ItemHeight As Integer
			Get
				Return Me.oO._o_00_O..ItemHeight
			End Get
			Set(value As Integer)
				If value > 0 Then
					Me.oO._o_00_O..ItemHeight = value
					Return
				End If
				Me.oO._o_00_O..ItemHeight = CInt(Math.Ceiling(CDbl(Me.oO._o_00_O..Font.Size) * 1.5))
			End Set
		End Property

		' Token: 0x1700152D RID: 5421
		' (get) Token: 0x060056F6 RID: 22262 RVA: 0x0022375C File Offset: 0x0022195C
		' (set) Token: 0x060056F7 RID: 22263 RVA: 0x00223764 File Offset: 0x00221964
		Public Property ImageFile As String
			Get
				Return Me.oO._o_00_O.
			End Get
			Set(value As String)
				Me.oO._o_00_O. = value
				Me.SetImageKey()
			End Set
		End Property

		' Token: 0x1700152E RID: 5422
		' (get) Token: 0x060056F8 RID: 22264 RVA: 0x00223773 File Offset: 0x00221973
		' (set) Token: 0x060056F9 RID: 22265 RVA: 0x0022377B File Offset: 0x0022197B
		Public Property SelectedImageFile As String
			Get
				Return Me.OO_OOOOOO00.O.
			End Get
			Set(value As String)
				Me.OO_OOOOOO00.O. = value
				Me.SetImageKey()
			End Set
		End Property

		' Token: 0x060056FA RID: 22266 RVA: 0x0022378C File Offset: 0x0022198C
		Private Sub SetImageKey()
			If Operators.CompareString(Me.ImageFile, "", True) <= 0 AndAlso Operators.CompareString(Me.SelectedImageFile, "", True) <= 0 Then
				Me.oO._o_00_O..ImageKey = String.Empty
				Me.oO._o_00_O..SelectedImageKey = String.Empty
				Return
			End If
			Dim imageList As ImageList
			If Me.oO._o_00_O..ImageList Is Nothing Then
				imageList = New ImageList()
				Me.oO._o_00_O..ImageList = imageList
			Else
				imageList = Me.oO._o_00_O..ImageList
			End If
			If Operators.CompareString(Me.ImageFile, "", True) > 0 AndAlso Not imageList.Images.Keys.Contains(Me.ImageFile) Then
				Dim image As Image = OO_00oOO.GetImage(Me.ImageFile)
				If image IsNot Nothing Then
					imageList.Images.Add(Me.ImageFile, image)
				End If
			End If
			If Operators.CompareString(Me.SelectedImageFile, "", True) > 0 AndAlso Not imageList.Images.Keys.Contains(Me.SelectedImageFile) Then
				Dim image2 As Image = OO_00oOO.GetImage(Me.SelectedImageFile)
				If image2 IsNot Nothing Then
					imageList.Images.Add(Me.SelectedImageFile, image2)
				End If
			End If
			If Operators.CompareString(Me.ImageFile, "", True) > 0 Then
				Me.oO._o_00_O..ImageKey = Me.ImageFile
			ElseIf Operators.CompareString(Me.SelectedImageFile, "", True) > 0 Then
				Me.oO._o_00_O..ImageKey = Me.SelectedImageFile
			Else
				Me.oO._o_00_O..ImageKey = String.Empty
			End If
			If Operators.CompareString(Me.SelectedImageFile, "", True) > 0 Then
				Me.oO._o_00_O..SelectedImageKey = Me.SelectedImageFile
				Return
			End If
			If Operators.CompareString(Me.ImageFile, "", True) > 0 Then
				Me.oO._o_00_O..SelectedImageKey = Me.ImageFile
				Return
			End If
			Me.oO._o_00_O..SelectedImageKey = String.Empty
		End Sub

		' Token: 0x1700152F RID: 5423
		' (get) Token: 0x060056FB RID: 22267 RVA: 0x00223965 File Offset: 0x00221B65
		' (set) Token: 0x060056FC RID: 22268 RVA: 0x00223968 File Offset: 0x00221B68
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property NodesSettingString As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) <> 0 Then
					Dim array As String() = value.Split(New Char() { vbFormFeed })
					Dim nodes As TreeNodeCollection = Me.oO._o_00_O..Nodes
					Dim o_o__00Ooo As O_o__00Ooo = Nothing
					Me.oO._o_00_O..BeginUpdate()
					For Each text As String In array
						If Operators.CompareString(text, "Inner", True) = 0 Then
							nodes = o_o__00Ooo.Nodes
						ElseIf Operators.CompareString(text, "Outer", True) = 0 Then
							If nodes(0).Parent.Parent Is Nothing Then
								nodes = Me.oO._o_00_O..Nodes
							Else
								nodes = nodes(0).Parent.Parent.Nodes
							End If
						Else
							o_o__00Ooo = New O_o__00Ooo()
							nodes.Add(o_o__00Ooo)
							o_O_o_oOoo__.OOOO_OO._oo.(New CustomTreeNodeProperty(o_o__00Ooo), text, vbTab)
						End If
					Next
					Me.oO._o_00_O..EndUpdate()
				End If
			End Set
		End Property

		' Token: 0x17001530 RID: 5424
		' (get) Token: 0x060056FD RID: 22269 RVA: 0x00223A54 File Offset: 0x00221C54
		<oO0oooo("0887")>
		Public ReadOnly Property Nodes As TreeNodes
			Get
				If Me.a Is Nothing Then
					Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.a, New StaticLocalInitFlag(), Nothing)
				End If
				Dim flag As Boolean = False
				Try
					Monitor.Enter(Me.a, flag)
					If Me.a.State = 0S Then
						Me.a.State = 2S
						Me.a = Nothing
					ElseIf Me.a.State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					Me.a.State = 1S
					If flag Then
						Monitor.[Exit](Me.a)
					End If
				End Try
				If Me.a Is Nothing Then
					Me.a = New TreeNodes(Me.oO._o_00_O..Nodes)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17001531 RID: 5425
		' (get) Token: 0x060056FE RID: 22270 RVA: 0x00223B14 File Offset: 0x00221D14
		' (set) Token: 0x060056FF RID: 22271 RVA: 0x00223B49 File Offset: 0x00221D49
		<oO0oooo("0884")>
		Public Property SelectedNode As TreeNode
			Get
				Dim result As TreeNode
				If Me.oO._o_00_O..SelectedNode IsNot Nothing Then
					result = New TreeNode(CType(Me.oO._o_00_O..SelectedNode, O_o__00Ooo))
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As TreeNode)
				If value Is Nothing Then
					Me.oO._o_00_O..SelectedNode = Nothing
					Return
				End If
				Me.oO._o_00_O..SelectedNode = value.BaseNode
			End Set
		End Property

		' Token: 0x06005700 RID: 22272 RVA: 0x00223B6C File Offset: 0x00221D6C
		Public Sub CollapseAll()
			Me.oO._o_00_O..CollapseAll()
		End Sub

		' Token: 0x06005701 RID: 22273 RVA: 0x00223B79 File Offset: 0x00221D79
		Public Sub ExpandAll()
			Me.oO._o_00_O..ExpandAll()
		End Sub

		' Token: 0x06005702 RID: 22274 RVA: 0x00223B86 File Offset: 0x00221D86
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildDataTree2(DataTable As String, RowFilter As String, RowSort As String, ParamArray Columns As String())
			Me.BuildDataTree2(OO_00oOO.DataTables(DataTable), RowFilter, RowSort, Columns)
		End Sub

		' Token: 0x06005703 RID: 22275 RVA: 0x00223B9D File Offset: 0x00221D9D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildDataTree2(DataTable As DataTable, RowFilter As String, RowSort As String, ParamArray Columns As String())
			oOO0oo_o0.O.ooooo.(Me.oO._o_00_O., DataTable.BaseTable, RowFilter, RowSort, "", String.Join("|", Columns), True)
		End Sub

		' Token: 0x06005704 RID: 22276 RVA: 0x00223BC4 File Offset: 0x00221DC4
		Public Sub BuildDataTree(DataTable As String, RowFilter As String, ParamArray Columns As String())
			If OO_00oOO.DataTables.Contains(DataTable) Then
				Me.BuildDataTree2(OO_00oOO.DataTables(DataTable), RowFilter, "", Columns)
			End If
		End Sub

		' Token: 0x06005705 RID: 22277 RVA: 0x00223BEB File Offset: 0x00221DEB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildDataTree(DataTable As DataTable, RowFilter As String, ParamArray Columns As String())
			Me.BuildDataTree2(DataTable, RowFilter, "", Columns)
		End Sub

		' Token: 0x06005706 RID: 22278 RVA: 0x00223BFB File Offset: 0x00221DFB
		<oO0oooo("0893")>
		Public Sub BuildTree(DataTable As DataTable, ColumnNames As String, Optional Filter As String = "", Optional Sort As String = "")
			oOO0oo_o0.O.ooooo.(Me.oO._o_00_O., DataTable.BaseTable, Filter, Sort, "", ColumnNames, True)
		End Sub

		' Token: 0x06005707 RID: 22279 RVA: 0x00223C18 File Offset: 0x00221E18
		<oO0oooo("0893")>
		Public Sub BuildTree(DataTableName As String, ColumnNames As String, Optional Filter As String = "", Optional Sort As String = "")
			Dim columns As String() = ColumnNames.Split(New Char() { "|"c })
			Me.BuildDataTree2(DataTableName, Filter, Sort, columns)
		End Sub

		' Token: 0x06005708 RID: 22280 RVA: 0x00223C42 File Offset: 0x00221E42
		<oO0oooo("1969")>
		Public Sub CreateTree(DataTable As DataTable, Column As String, Optional Separator As String = "\", Optional Filter As String = "", Optional Sort As String = "")
			Me.CreateDataTree(DataTable.BaseTable, Column, Separator, Filter, Sort, "", "")
		End Sub

		' Token: 0x06005709 RID: 22281 RVA: 0x00223C60 File Offset: 0x00221E60
		<oO0oooo("2621")>
		Public Sub GenerateTree(DataTable As DataTable, Column As String, CaptionColumn As String, Optional Separator As String = "\", Optional Filter As String = "", Optional Sort As String = "")
			Me.CreateDataTree(DataTable.BaseTable, Column, Separator, Filter, Sort, CaptionColumn, "")
		End Sub

		' Token: 0x0600570A RID: 22282 RVA: 0x00223C7B File Offset: 0x00221E7B
		<oO0oooo("2621")>
		Public Sub GenerateTree(DataTableName As String, Column As String, CaptionColumn As String, Optional Separator As String = "\", Optional Filter As String = "", Optional Sort As String = "")
			Me.CreateDataTree(OO_00oOO.DataTables(DataTableName).BaseTable, Column, Separator, Filter, Sort, CaptionColumn, "")
		End Sub

		' Token: 0x0600570B RID: 22283 RVA: 0x00223CA0 File Offset: 0x00221EA0
		<oO0oooo("1969")>
		Public Sub CreateTree(DataTableName As String, Column As String, Optional Separator As String = "\", Optional Filter As String = "", Optional Sort As String = "")
			Me.CreateDataTree(OO_00oOO.DataTables(DataTableName).BaseTable, Column, Separator, Filter, Sort, "", "")
		End Sub

		' Token: 0x0600570C RID: 22284 RVA: 0x00223CC8 File Offset: 0x00221EC8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub CreateDataTree(DataTablename As String, Column As String, Optional Separator As String = "\", Optional Filter As String = "", Optional Sort As String = "")
			Me.CreateDataTree(OO_00oOO.DataTables(DataTablename).BaseTable, Column, Separator, Filter, Sort, "", "")
		End Sub

		' Token: 0x0600570D RID: 22285 RVA: 0x00223CF0 File Offset: 0x00221EF0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub CreateDataTree(DataTable As DataTable, Column As String, Optional Separator As String = "\", Optional Filter As String = "", Optional Sort As String = "", Optional CaptionColumn As String = "", Optional SourceCols As String = "")
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Sort, "", True) <> 0 Then
					GoTo IL_1F
				End If
				IL_18:
				num2 = 3
				Sort = Column
				GoTo IL_24
				IL_1F:
				num2 = 5
				Dim flag As Boolean = True
				IL_24:
				num2 = 6
				If Operators.CompareString(Filter, "", True) <= 0 Then
					GoTo IL_4E
				End If
				IL_36:
				num2 = 7
				Filter = Filter + " And [" + Column + "] IS NOT NULL"
				GoTo IL_63
				IL_4E:
				num2 = 9
				Filter = "[" + Column + "] IS NOT NULL"
				IL_63:
				num2 = 10
				If Operators.CompareString(Separator, "", True) <> 0 Then
					GoTo IL_7E
				End If
				IL_74:
				num2 = 11
				Separator = "\"
				IL_7E:
				num2 = 12
				Dim pathSeparator As String = Me.oO._o_00_O..PathSeparator
				IL_8E:
				num2 = 13
				Dim array As DataRow() = DataTable.[Select](Filter, Sort)
				IL_9D:
				num2 = 14
				Dim list As List(Of String) = New List(Of String)()
				IL_A7:
				num2 = 15
				Me.oO._o_00_O..BeginUpdate()
				IL_B5:
				num2 = 16
				Me.oO._o_00_O..Nodes.Clear()
				IL_C8:
				num2 = 17
				Dim treeNode As TreeNode = Nothing
				IL_CE:
				num2 = 18
				Dim dictionary As Dictionary(Of String, DataRow) = New Dictionary(Of String, DataRow)()
				IL_D8:
				num2 = 19
				If SourceCols IsNot Nothing Then
					GoTo IL_E9
				End If
				IL_DF:
				num2 = 20
				SourceCols = ""
				IL_E9:
				num2 = 21
				Dim array2 As String() = SourceCols.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_101:
				num2 = 22
				For Each text As String In array2
					IL_114:
					num2 = 23
					If Not DataTable.Columns.Contains(text) Then
						IL_126:
						num2 = 24
						MessageBox.Show("无效列名：" + text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						IL_5E8:
						GoTo IL_7D2
					End If
					IL_148:
					num2 = 26
				Next
				IL_159:
				num2 = 27
				Me.oO._o_00_O..PathSeparator = "\"
				IL_16C:
				num2 = 28
				Dim num3 As Integer = array.Length - 1
				Dim j As Integer = 0
				While j <= num3
					IL_17F:
					num2 = 29
					Dim value As DataRow = array(j)
					IL_189:
					num2 = 30
					If j <= 0 Then
						GoTo IL_1BE
					End If
					IL_191:
					num2 = 31
					If Operators.CompareString(array(j)(Column).ToString(), array(j - 1)(Column).ToString(), True) <> 0 Then
						GoTo IL_1BE
					End If
					IL_21C:
					num2 = 39
					j += 1
					Continue While
					IL_1BE:
					num2 = 33
					Dim text2 As String
					If Operators.CompareString(Separator, "\", True) = 0 Then
						IL_1CF:
						num2 = 34
						text2 = array(j)(Column).ToString()
					Else
						IL_1E5:
						num2 = 36
						text2 = array(j)(Column).ToString().Replace(Separator, "\")
					End If
					IL_204:
					num2 = 37
					list.Add(text2)
					IL_20F:
					num2 = 38
					dictionary.Add(text2, value)
					GoTo IL_21C
				End While
				IL_22E:
				num2 = 40
				If Operators.CompareString(Separator, "\", True) = 0 OrElse Operators.CompareString(Sort, Column, True) <> 0 Then
					GoTo IL_254
				End If
				IL_24A:
				num2 = 41
				list.Sort()
				IL_254:
				num2 = 42
				Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim text3 As String = enumerator.Current
					IL_26E:
					num2 = 43
					Dim array4 As String() = text3.Split(New Char() { "\"c })
					IL_285:
					num2 = 44
					Dim tag As DataRow = dictionary(text3)
					IL_293:
					num2 = 45
					Dim num4 As Integer
					If treeNode IsNot Nothing Then
						While True
							IL_29D:
							num2 = 47
							If text3.StartsWith(treeNode.FullPath + "\") Then
								Exit For
							End If
							IL_362:
							num2 = 61
							treeNode = treeNode.ParentNode
							IL_36E:
							num2 = 62
							If treeNode Is Nothing Then
								GoTo IL_378
							End If
						End While
						IL_2BD:
						num2 = 48
						num4 = treeNode.Level + 1
						IL_2CB:
						num2 = 49
						If flag Then
							IL_2D2:
							num2 = 50
							If treeNode.Nodes.Contains(array4(num4)) Then
								IL_2E8:
								num2 = 51
								treeNode = treeNode.Nodes(array4(num4))
							Else
								IL_300:
								num2 = 53
								treeNode = treeNode.Nodes.Add(array4(num4), array4(num4))
							End If
						Else
							IL_31D:
							num2 = 55
							treeNode = treeNode.Nodes.Add(array4(num4), array4(num4))
						End If
						IL_338:
						num2 = 56
						If array2.Length = 0 Then
							IL_341:
							num2 = 57
							treeNode.BaseNode.Tag = tag
						End If
						IL_352:
						num2 = 58
						num4 = treeNode.Level + 1
					End If
					IL_378:
					num2 = 65
					If treeNode Is Nothing Then
						IL_37F:
						num2 = 66
						treeNode = Me.Nodes(array4(0))
						IL_393:
						num2 = 67
						If treeNode Is Nothing Then
							IL_39A:
							num2 = 68
							treeNode = Me.Nodes.Add(array4(0), array4(0))
						End If
						IL_3B2:
						num2 = 69
						If array2.Length = 0 Then
							IL_3BB:
							num2 = 70
							treeNode.BaseNode.Tag = tag
						End If
						IL_3CC:
						num2 = 71
						num4 = 1
					End If
					IL_3D2:
					num2 = 72
					Dim num5 As Integer = num4
					Dim num6 As Integer = array4.Length - 1
					For k As Integer = num5 To num6
						IL_3E6:
						num2 = 73
						If flag Then
							IL_3ED:
							num2 = 74
							If treeNode.Nodes.Contains(array4(k)) Then
								IL_403:
								num2 = 75
								treeNode = treeNode.Nodes(array4(k))
							Else
								IL_41B:
								num2 = 77
								treeNode = treeNode.Nodes.Add(array4(k), array4(k))
							End If
						Else
							IL_438:
							num2 = 79
							treeNode = treeNode.Nodes.Add(array4(k), array4(k))
						End If
						IL_453:
						num2 = 80
						If array2.Length = 0 Then
							IL_45C:
							num2 = 81
							treeNode.BaseNode.Tag = tag
						End If
						IL_46D:
						num2 = 82
					Next
					IL_47F:
					num2 = 83
				End While
				IL_48E:
				num2 = 84
				CType(enumerator, IDisposable).Dispose()
				IL_49E:
				num2 = 85
				If Operators.CompareString(CaptionColumn, "", True) <= 0 AndAlso array2.Length <= 0 Then
					GoTo IL_5CA
				End If
				IL_4BB:
				num2 = 86
				If dictionary.Count <= 0 Then
					GoTo IL_5CA
				End If
				IL_4CB:
				num2 = 87
				For l As Integer = Me.AllNodes.Count - 1 To 0 Step -1
					IL_4E2:
					num2 = 88
					Dim treeNode2 As TreeNode = Me.AllNodes(l)
					IL_4F4:
					num2 = 89
					Dim text2 As String = treeNode2.FullPath
					IL_4FF:
					num2 = 90
					If dictionary.ContainsKey(text2) Then
						IL_50F:
						num2 = 91
						If Operators.CompareString(CaptionColumn, "", True) > 0 Then
							IL_522:
							num2 = 92
							treeNode2.Text = dictionary(text2)(CaptionColumn).ToString()
						End If
						IL_540:
						num2 = 93
						If array2.Length > 0 Then
							IL_54A:
							num2 = 94
							Dim text4 As String = ""
							IL_554:
							num2 = 95
							For Each columnName As String In array2
								IL_567:
								num2 = 96
								text4 = text4 + vbTab + dictionary(text2)(columnName).ToString()
								IL_58C:
								num2 = 97
							Next
							IL_59D:
							num2 = 98
							treeNode2.Tag = text4.Trim(New Char() { vbTab })
						End If
					End If
					IL_5B9:
					num2 = 99
				Next
				IL_5CA:
				num2 = 100
				Me.oO._o_00_O..PathSeparator = pathSeparator
				IL_5DA:
				num2 = 101
				Me.oO._o_00_O..EndUpdate()
				GoTo IL_5E8
				IL_5ED:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_793:
				GoTo IL_7C7
				IL_795:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7A5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_795
			End Try
			IL_7C7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7D2:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600570E RID: 22286 RVA: 0x002244F4 File Offset: 0x002226F4
		<oO0oooo("1974")>
		Public Sub Save(FileName As String, Optional All As Boolean = False)
			OO_00oOO.FileSys.WriteAllText(FileName, Me.SaveToString(All), False, Encoding.Unicode)
		End Sub

		' Token: 0x0600570F RID: 22287 RVA: 0x00224510 File Offset: 0x00222710
		<oO0oooo("1975")>
		Public Sub Load(FileName As String)
			If OO_00oOO.FileSys.FileExists(FileName) Then
				Dim str As String = OO_00oOO.FileSys.ReadAllText(FileName, Encoding.Unicode)
				Me.LoadFromString(str)
				Return
			End If
			MessageBox.Show("没有找到文件：" + FileName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06005710 RID: 22288 RVA: 0x0022455C File Offset: 0x0022275C
		<oO0oooo("2015")>
		Public Sub LoadFromString(Str1 As String)
			Me.NodesSettingString = Str1
		End Sub

		' Token: 0x06005711 RID: 22289 RVA: 0x00224568 File Offset: 0x00222768
		<oO0oooo("2014")>
		Public Function SaveToString(Optional All As Boolean = False) As String
			Dim result As String = Nothing
			If All Then
				oOO0oo_o0.O__o0o0O0O_.0.(Me.oO._o_00_O..Nodes, result)
			Else
				oOO0oo_o0.o.O0o000_.(Me.oO._o_00_O..Nodes, result)
			End If
			Return result
		End Function

		' Token: 0x06005712 RID: 22290 RVA: 0x002245A1 File Offset: 0x002227A1
		Public Sub BeginEdit()
			If Me.oO._o_00_O..SelectedNode IsNot Nothing Then
				Me.oO._o_00_O..LabelEdit = True
				Me.oO._o_00_O..SelectedNode.BeginEdit()
			End If
		End Sub

		' Token: 0x17001532 RID: 5426
		' (get) Token: 0x06005713 RID: 22291 RVA: 0x002245CC File Offset: 0x002227CC
		<oO0oooo("2302")>
		Public ReadOnly Property AllNodes As List(Of TreeNode)
			Get
				Dim list As List(Of TreeNode) = New List(Of TreeNode)()
				ooO_0O.o_O0.O_.(Me.oO._o_00_O..Nodes, list)
				Return list
			End Get
		End Property

		' Token: 0x06005714 RID: 22292 RVA: 0x002245F1 File Offset: 0x002227F1
		<oO0oooo("2439")>
		Public Sub StopRedraw()
			Me.oO._o_00_O..BeginUpdate()
		End Sub

		' Token: 0x06005715 RID: 22293 RVA: 0x002245FE File Offset: 0x002227FE
		<oO0oooo("2440")>
		Public Sub ResumeRedraw()
			Me.oO._o_00_O..EndUpdate()
		End Sub

		' Token: 0x17001533 RID: 5427
		' (get) Token: 0x06005716 RID: 22294 RVA: 0x0022460C File Offset: 0x0022280C
		' (set) Token: 0x06005717 RID: 22295 RVA: 0x0022463C File Offset: 0x0022283C
		Public Property RaiseCheckedEventAnyWay As Boolean
			Get
				Return Not(TypeOf Me.oO._o_00_O. Is O__oO_o0_o_o) OrElse CType(Me.oO._o_00_O., O__oO_o0_o_o).Ooo__.ooO_0.()
			End Get
			Set(value As Boolean)
				If TypeOf Me.oO._o_00_O. Is O__oO_o0_o_o Then
					CType(Me.oO._o_00_O., O__oO_o0_o_o).Ooo__.ooO_0.(value)
				End If
			End Set
		End Property

		' Token: 0x04002233 RID: 8755
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x04002234 RID: 8756
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002235 RID: 8757
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002236 RID: 8758
		Private a As TreeNodes

		' Token: 0x04002237 RID: 8759
		Private a As StaticLocalInitFlag
	End Class
End Namespace
