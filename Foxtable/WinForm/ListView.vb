Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004F7 RID: 1271
	<ComVisible(True)>
	Public Class ListView
		Inherits Control

		' Token: 0x06005169 RID: 20841 RVA: 0x0021A49E File Offset: 0x0021869E
		Friend Sub New(A_0 As o_OO_oOOO0o)
			MyBase.New(A_0, ControlTypeEnum.ListView)
			Me.O.oo_oO. = A_0
		End Sub

		' Token: 0x1700129C RID: 4764
		' (get) Token: 0x0600516A RID: 20842 RVA: 0x0021A4B0 File Offset: 0x002186B0
		Public ReadOnly Property Groups As ListViewGroupCollections
			Get
				Return New ListViewGroupCollections(Me.O.oo_oO..Groups)
			End Get
		End Property

		' Token: 0x1700129D RID: 4765
		' (get) Token: 0x0600516B RID: 20843 RVA: 0x0021A4C2 File Offset: 0x002186C2
		Public ReadOnly Property Columns As ListViewColumnCollections
			Get
				Return New ListViewColumnCollections(Me.O.oo_oO., Me.O.oo_oO..Columns)
			End Get
		End Property

		' Token: 0x1700129E RID: 4766
		' (get) Token: 0x0600516C RID: 20844 RVA: 0x0021A4DA File Offset: 0x002186DA
		Public ReadOnly Property Rows As ListViewRowCollections
			Get
				Return New ListViewRowCollections(Me.O.oo_oO.)
			End Get
		End Property

		' Token: 0x1700129F RID: 4767
		' (get) Token: 0x0600516D RID: 20845 RVA: 0x0021A4E8 File Offset: 0x002186E8
		Public ReadOnly Property SelectedRows As List(Of ListViewRow)
			Get
				Dim list As List(Of ListViewRow) = New List(Of ListViewRow)()
				If Me.O.oo_oO..VirtualMode Then
					Try
						For Each value As Object In Me.O.oo_oO..SelectedIndices
							Dim key As Integer = Conversions.ToInteger(value)
							list.Add(Me.O.oo_oO..o0__o.O0.(key))
						Next
						Return list
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Try
					For Each obj As Object In Me.O.oo_oO..SelectedItems
						Dim a_ As ListViewItem = CType(obj, ListViewItem)
						list.Add(New ListViewRow(a_))
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Return list
			End Get
		End Property

		' Token: 0x170012A0 RID: 4768
		' (get) Token: 0x0600516E RID: 20846 RVA: 0x0021A5C8 File Offset: 0x002187C8
		Public ReadOnly Property CheckedRows As List(Of ListViewRow)
			Get
				Dim list As List(Of ListViewRow) = New List(Of ListViewRow)()
				If Me.O.oo_oO..VirtualMode Then
					Try
						For Each listViewRow As ListViewRow In Me.O.oo_oO..o0__o.O0..Values
							If listViewRow.Checked Then
								list.Add(listViewRow)
							End If
						Next
						Return list
					Finally
						Dim enumerator As Dictionary(Of Integer, ListViewRow).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				Try
					For Each obj As Object In Me.O.oo_oO..CheckedItems
						Dim a_ As ListViewItem = CType(obj, ListViewItem)
						list.Add(New ListViewRow(a_))
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Return list
			End Get
		End Property

		' Token: 0x170012A1 RID: 4769
		' (get) Token: 0x0600516F RID: 20847 RVA: 0x0021A69C File Offset: 0x0021889C
		Public ReadOnly Property VirtualRows As Dictionary(Of Integer, ListViewRow).ValueCollection
			Get
				Return Me.O.oo_oO..o0__o.O0..Values
			End Get
		End Property

		' Token: 0x170012A2 RID: 4770
		' (get) Token: 0x06005170 RID: 20848 RVA: 0x0021A6AE File Offset: 0x002188AE
		Public ReadOnly Property Images As ListViewImageManger
			Get
				Return New ListViewImageManger(Me.O.oo_oO.)
			End Get
		End Property

		' Token: 0x06005171 RID: 20849 RVA: 0x0021A6BC File Offset: 0x002188BC
		Public Sub Reset()
			Me.O.oo_oO..BeginUpdate()
			Me.O.oo_oO..Columns.Clear()
			Me.O.oo_oO..Groups.Clear()
			Me.O.oo_oO..Items.Clear()
			Me.Images.Clear()
			Me.O.oo_oO..EndUpdate()
		End Sub

		' Token: 0x170012A3 RID: 4771
		' (get) Token: 0x06005172 RID: 20850 RVA: 0x0021A71A File Offset: 0x0021891A
		' (set) Token: 0x06005173 RID: 20851 RVA: 0x0021A727 File Offset: 0x00218927
		Public Property View As View
			Get
				Return Me.O.oo_oO..View
			End Get
			Set(value As View)
				Me.O.oo_oO..View = value
			End Set
		End Property

		' Token: 0x170012A4 RID: 4772
		' (get) Token: 0x06005174 RID: 20852 RVA: 0x0021A735 File Offset: 0x00218935
		' (set) Token: 0x06005175 RID: 20853 RVA: 0x0021A742 File Offset: 0x00218942
		Public Property GridLines As Boolean
			Get
				Return Me.O.oo_oO..GridLines
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..GridLines = value
			End Set
		End Property

		' Token: 0x170012A5 RID: 4773
		' (get) Token: 0x06005176 RID: 20854 RVA: 0x0021A750 File Offset: 0x00218950
		' (set) Token: 0x06005177 RID: 20855 RVA: 0x0021A760 File Offset: 0x00218960
		Public Property ShowGroups As Boolean
			Get
				Return Me.O.oo_oO..ShowGroups
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..SuspendLayout()
				Me.O.oo_oO..ShowGroups = value
				If MyBase.Parent IsNot Nothing Then
					Me.O.oo_oO..Width = Me.O.oo_oO..Width - 1
					Me.O.oo_oO..Width = Me.O.oo_oO..Width + 1
				End If
				Me.O.oo_oO..ResumeLayout()
			End Set
		End Property

		' Token: 0x06005178 RID: 20856 RVA: 0x0021A7C7 File Offset: 0x002189C7
		Public Sub StopRedraw()
			Me.O.oo_oO..BeginUpdate()
		End Sub

		' Token: 0x06005179 RID: 20857 RVA: 0x0021A7D4 File Offset: 0x002189D4
		Public Sub ResumeRedraw()
			Me.O.oo_oO..EndUpdate()
		End Sub

		' Token: 0x0600517A RID: 20858 RVA: 0x0021A7E1 File Offset: 0x002189E1
		Public Sub AutoResizeColumns(Optional mode As ColumnHeaderAutoResizeStyle = ColumnHeaderAutoResizeStyle.ColumnContent)
			Me.O.oo_oO..AutoResizeColumns(mode)
		End Sub

		' Token: 0x170012A6 RID: 4774
		' (get) Token: 0x0600517B RID: 20859 RVA: 0x0021A7EF File Offset: 0x002189EF
		' (set) Token: 0x0600517C RID: 20860 RVA: 0x0021A7FC File Offset: 0x002189FC
		Public Property TitleSize As Size
			Get
				Return Me.O.oo_oO..TileSize
			End Get
			Set(value As Size)
				Me.O.oo_oO..TileSize = value
			End Set
		End Property

		' Token: 0x170012A7 RID: 4775
		' (get) Token: 0x0600517D RID: 20861 RVA: 0x0021A80A File Offset: 0x00218A0A
		' (set) Token: 0x0600517E RID: 20862 RVA: 0x0021A817 File Offset: 0x00218A17
		Public Property MultiSelect As Boolean
			Get
				Return Me.O.oo_oO..MultiSelect
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..MultiSelect = value
			End Set
		End Property

		' Token: 0x170012A8 RID: 4776
		' (get) Token: 0x0600517F RID: 20863 RVA: 0x0021A825 File Offset: 0x00218A25
		' (set) Token: 0x06005180 RID: 20864 RVA: 0x0021A834 File Offset: 0x00218A34
		Public Property CheckBoxes As Boolean
			Get
				Return Me.O.oo_oO..CheckBoxes
			End Get
			Set(value As Boolean)
				Dim num As Integer
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					If Not Me.O.oo_oO..VirtualMode Then
						GoTo IL_1F8
					End If
					IL_19:
					num2 = 3
					If Me.O.oo_oO..Parent Is Nothing Then
						GoTo IL_35
					End If
					IL_28:
					num2 = 4
					Me.O.oo_oO..BeginUpdate()
					IL_35:
					num2 = 5
					If Me.O.oo_oO..Columns.Count <= 0 Then
						GoTo IL_63
					End If
					IL_4A:
					num2 = 6
					Dim width As Integer = Me.O.oo_oO..Columns(0).Width
					IL_63:
					num2 = 7
					Me.O.oo_oO..BeginUpdate()
					IL_70:
					num2 = 8
					If Not value Then
						GoTo IL_FF
					End If
					IL_78:
					num2 = 9
					If Me.O.oo_oO..CheckBoxes Then
						GoTo IL_138
					End If
					IL_8B:
					num2 = 10
					Dim enumerator As Dictionary(Of Integer, ListViewRow).ValueCollection.Enumerator = Me.O.oo_oO..o0__o.O0..Values.GetEnumerator()
					While enumerator.MoveNext()
						Dim listViewRow As ListViewRow = enumerator.Current
						IL_B0:
						num2 = 11
						If Not listViewRow.Checked Then
							IL_BC:
							num2 = 12
							listViewRow.Checked = True
							IL_C7:
							num2 = 13
							listViewRow.Checked = False
						End If
						IL_D2:
						num2 = 14
					End While
					IL_DE:
					num2 = 15
					CType(enumerator, IDisposable).Dispose()
					IL_EE:
					num2 = 16
					Me.O.oo_oO..CheckBoxes = True
					GoTo IL_138
					IL_FF:
					num2 = 18
					If value Then
						GoTo IL_138
					End If
					IL_105:
					num2 = 19
					If Not Me.O.oo_oO..CheckBoxes Then
						GoTo IL_138
					End If
					IL_115:
					num2 = 20
					Me.VirtualMode = False
					IL_11F:
					num2 = 21
					Me.O.oo_oO..CheckBoxes = False
					IL_12E:
					num2 = 22
					Me.VirtualMode = True
					IL_138:
					num2 = 23
					Dim o_OO_oOOO0o As o_OO_oOOO0o = Me.O.oo_oO.
					IL_143:
					num2 = 24
					If Me.View <> View.SmallIcon Then
						GoTo IL_177
					End If
					IL_14F:
					num2 = 25
					If o_OO_oOOO0o.Columns.Count <= 0 Then
						GoTo IL_177
					End If
					IL_161:
					num2 = 26
					o_OO_oOOO0o.Columns(0).Width = width
					IL_177:
					num2 = 27
					o_OO_oOOO0o.SetBounds(o_OO_oOOO0o.Left, o_OO_oOOO0o.Top, o_OO_oOOO0o.Width - 1, o_OO_oOOO0o.Height)
					IL_19F:
					num2 = 28
					o_OO_oOOO0o.SetBounds(o_OO_oOOO0o.Left, o_OO_oOOO0o.Top, o_OO_oOOO0o.Width + 1, o_OO_oOOO0o.Height)
					IL_1C7:
					o_OO_oOOO0o = Nothing
					IL_1CA:
					num2 = 30
					Me.O.oo_oO..EndUpdate()
					IL_1D8:
					num2 = 31
					If Me.O.oo_oO..Parent Is Nothing Then
						GoTo IL_207
					End If
					IL_1E8:
					num2 = 32
					Me.O.oo_oO..EndUpdate()
					GoTo IL_207
					IL_1F8:
					num2 = 34
					Me.O.oo_oO..CheckBoxes = value
					IL_207:
					GoTo IL_2E5
					IL_20C:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_2A6:
					GoTo IL_2DA
					IL_2A8:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_2B8:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_2A8
				End Try
				IL_2DA:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_2E5:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x170012A9 RID: 4777
		' (get) Token: 0x06005181 RID: 20865 RVA: 0x0021AB4C File Offset: 0x00218D4C
		' (set) Token: 0x06005182 RID: 20866 RVA: 0x0021AB5C File Offset: 0x00218D5C
		Public Property VirtualMode As Boolean
			Get
				Return Me.O.oo_oO..VirtualMode
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..VirtualMode = value
				If value Then
					If Me.O.oo_oO..o0__o.O0. Is Nothing Then
						Me.O.oo_oO..o0__o.O0. = New Dictionary(Of Integer, ListViewRow)()
						Return
					End If
				ElseIf Me.O.oo_oO..o0__o.O0. IsNot Nothing Then
					Me.O.oo_oO..o0__o.O0..Clear()
				End If
			End Set
		End Property

		' Token: 0x170012AA RID: 4778
		' (get) Token: 0x06005183 RID: 20867 RVA: 0x0021ABB3 File Offset: 0x00218DB3
		' (set) Token: 0x06005184 RID: 20868 RVA: 0x0021ABC0 File Offset: 0x00218DC0
		Public Property VirtualListSize As Integer
			Get
				Return Me.O.oo_oO..VirtualListSize
			End Get
			Set(value As Integer)
				Me.O.oo_oO..VirtualListSize = value
			End Set
		End Property

		' Token: 0x170012AB RID: 4779
		' (get) Token: 0x06005185 RID: 20869 RVA: 0x0021ABD0 File Offset: 0x00218DD0
		' (set) Token: 0x06005186 RID: 20870 RVA: 0x0021ACA7 File Offset: 0x00218EA7
		Public Property Current As ListViewRow
			Get
				Dim result As ListViewRow
				If Me.O.oo_oO..FocusedItem IsNot Nothing AndAlso Me.O.oo_oO..FocusedItem.Selected Then
					result = New ListViewRow(Me.O.oo_oO..FocusedItem)
				Else
					If Me.VirtualMode Then
						If Me.O.oo_oO..SelectedIndices.Count > 0 Then
							Return New ListViewRow(Me.O.oo_oO..SelectedItems(Me.O.oo_oO..SelectedIndices(Me.O.oo_oO..SelectedIndices.Count - 1)))
						End If
					ElseIf Me.O.oo_oO..SelectedItems.Count > 0 Then
						Return New ListViewRow(Me.O.oo_oO..SelectedItems(Me.O.oo_oO..SelectedItems.Count - 1))
					End If
					result = Nothing
				End If
				Return result
			End Get
			Set(value As ListViewRow)
				Me.O.oo_oO..FocusedItem = value.BaseItem
				Me.O.oo_oO..FocusedItem.EnsureVisible()
				Me.O.oo_oO..FocusedItem.Selected = True
			End Set
		End Property

		' Token: 0x170012AC RID: 4780
		' (get) Token: 0x06005187 RID: 20871 RVA: 0x0021ACDC File Offset: 0x00218EDC
		' (set) Token: 0x06005188 RID: 20872 RVA: 0x0021AD03 File Offset: 0x00218F03
		Public Property Position As Integer
			Get
				Dim index As Integer
				If Me.Current IsNot Nothing Then
					index = Me.Current.BaseItem.Index
				End If
				Return index
			End Get
			Set(value As Integer)
				If value >= 0 AndAlso value <= Me.O.oo_oO..Items.Count - 1 Then
					Me.Current = New ListViewRow(Me.O.oo_oO..Items(value))
				End If
			End Set
		End Property

		' Token: 0x06005189 RID: 20873 RVA: 0x0021AD3A File Offset: 0x00218F3A
		Public Sub RetrieveAll()
			If Me.VirtualMode Then
				Me.O.oo_oO..o0__o.O0..Clear()
				Me.O.oo_oO..Invalidate()
			End If
		End Sub

		' Token: 0x170012AD RID: 4781
		' (get) Token: 0x0600518A RID: 20874 RVA: 0x0021AD5F File Offset: 0x00218F5F
		' (set) Token: 0x0600518B RID: 20875 RVA: 0x0021AD6C File Offset: 0x00218F6C
		Public Property AllowDrag As Boolean
			Get
				Return Me.O.oo_oO..O_O.0Oo_o.()
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..o0__o.O0.(value)
			End Set
		End Property

		' Token: 0x170012AE RID: 4782
		' (get) Token: 0x0600518C RID: 20876 RVA: 0x0021AD7A File Offset: 0x00218F7A
		' (set) Token: 0x0600518D RID: 20877 RVA: 0x0021AD87 File Offset: 0x00218F87
		Public Property AllowDrop As Boolean
			Get
				Return Me.O.oo_oO..get_AllowDrop()
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..set_AllowDrop(value)
			End Set
		End Property

		' Token: 0x170012AF RID: 4783
		' (get) Token: 0x0600518E RID: 20878 RVA: 0x0021AD95 File Offset: 0x00218F95
		' (set) Token: 0x0600518F RID: 20879 RVA: 0x0021ADA2 File Offset: 0x00218FA2
		Public Property AllowEdit As Boolean
			Get
				Return Me.O.oo_oO..LabelEdit
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..LabelEdit = value
			End Set
		End Property

		' Token: 0x170012B0 RID: 4784
		' (get) Token: 0x06005190 RID: 20880 RVA: 0x0021ADB0 File Offset: 0x00218FB0
		' (set) Token: 0x06005191 RID: 20881 RVA: 0x0021ADBD File Offset: 0x00218FBD
		Public Property OwnerDraw As Boolean
			Get
				Return Me.O.oo_oO..OwnerDraw
			End Get
			Set(value As Boolean)
				Me.O.oo_oO..OwnerDraw = value
			End Set
		End Property

		' Token: 0x040021B4 RID: 8628
		Private <<EMPTY_NAME>> As o_OO_oOOO0o
	End Class
End Namespace
