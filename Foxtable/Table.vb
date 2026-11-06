Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms
Imports C1.C1Excel
Imports C1.C1Preview
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Preview
Imports Foxtable.My.Resources
Imports Foxtable.RibbonMenu
Imports Foxtable.WinForm
Imports Foxtable.XLS
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200030A RID: 778
	<oO0oooo("1585")>
	<ComVisible(True)>
	Public Class Table
		Implements IEnumerable(Of Row)

		' Token: 0x1400000C RID: 12
		' (add) Token: 0x06002903 RID: 10499 RVA: 0x00114074 File Offset: 0x00112274
		' (remove) Token: 0x06002904 RID: 10500 RVA: 0x001140AC File Offset: 0x001122AC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Custom Event NameChanged As Table.oO00_O_O
			<CompilerGenerated()>
			AddHandler
				Dim oO00_O_O As Table.oO00_O_O = Me.O.OoOo_.
				Dim oO00_O_O2 As Table.oO00_O_O
				Do
					oO00_O_O2 = oO00_O_O
					Dim value2 As Table.oO00_O_O = CType([Delegate].Combine(oO00_O_O2, value), Table.oO00_O_O)
					oO00_O_O = Interlocked.CompareExchange(Of Table.oO00_O_O)(Me.O.OoOo_., value2, oO00_O_O2)
				Loop While oO00_O_O IsNot oO00_O_O2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oO00_O_O As Table.oO00_O_O = Me.O.OoOo_.
				Dim oO00_O_O2 As Table.oO00_O_O
				Do
					oO00_O_O2 = oO00_O_O
					Dim value2 As Table.oO00_O_O = CType([Delegate].Remove(oO00_O_O2, value), Table.oO00_O_O)
					oO00_O_O = Interlocked.CompareExchange(Of Table.oO00_O_O)(Me.O.OoOo_., value2, oO00_O_O2)
				Loop While oO00_O_O IsNot oO00_O_O2
			End RemoveHandler
		End Event

		' Token: 0x06002905 RID: 10501
		Private Declare Function FindPort_2 Lib "Interop.ADOSC.dll" (A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As StringBuilder) As Integer

		' Token: 0x06002906 RID: 10502 RVA: 0x001140E4 File Offset: 0x001122E4
		Friend Sub New(A_0 As O_0)
			Me.oO._0ooO_o0_. = 0
			Me.oO._0ooO_o0_. = 0
			Me.oO.O0OOO___. = 0
			Me.O._0_0ooO0_o0o. = 0
			Me.Oo_00o0_.o00. = 0
			Me.o.OO0O0O. = 0
			Me.o_oo___0.0. = 0
			Me.Oo_o._oO0o. = 0
			Me.OOO.ooO. = 0
			Me.O0O_o0.O_Oo0O0. = 0
			Me.Oo_.o0__0. = 0
			Me.o_oo.o_. = 0
			Me.O_0_O0Oo__.O_o. = 0
			Me.OOo0O._0__0. = 0
			Me.Oo.0o_0_0. = 0
			Me.ooo0.O_. = 0
			Me.oo_._0oo_o_0. = 0
			Me.o.O_o. = 0
			Me.oO._oo_00. = 0
			Me.oO00__O_.oO. = 0
			Me.oO00__O_.oO. = New List(Of String)()
			Me.o0__OOo0._oO. = 1
			Me.O0oooo_o0o0.o. = False
			Me.o.OO0O0O. = True
			Me.ooo.__00__0. = False
			Me.Oo_oo_.o_. = True
			Me.OO0.O__. = True
			Me.oO._0ooO_o0_. = New SubtotalGroupCollection()
			Me.o0O_o00_.0__O. = False
			Me.o.Oo_o_o_0oo. = False
			Me.Oo_0o.0. = True
			Me.o_o0O000o.000. = True
			Me.o.0o00ooo_. = New List(Of String)()
			Me.o.OOoo_o. = New List(Of String)()
			Me.O_O__.ooOo. = New Dictionary(Of String, ListSortDirection)()
			Me.O.OoOo_. = 1
			Me.oo_o_.oOO. = False
			Me.O.O000. = False
			Me.ooo_Ooo0.__. = True
			Me.o.0o00ooo_. = 0
			Me.O0oO0_._0. = False
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.
			Me.OOoOO.OO0. = True
			Me.o.0__o0. = 10000
			Me.oo.o_ooO. = False
			Me.O_O0._. = New InlineGroupTableBuilder()
			Me.O_O0._. = New LayersGroupTableBuilder()
			Me.o__.O0o. = 0
			Me.o.0ooOO_0__. = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
			Me.ooo00.o0__OO0. = "(default)"
			Me.O_O__.ooOo. = New List(Of Oo0__O__O_0__)()
			Me.O_o0OOo_.o0. = New o_0oo_OOO_0o_(Me.O_O__.ooOo.)
			Me.o.0ooOO_0__. = A_0
			Me.O_o0OOo_.o0. = New O_oOooO_O(Me)
			Me.oO._0ooO_o0_. = New RowCollection(Me)
			Me.o0__OOo0._oO. = New ColCollection(Me)
			Me.O_o0OOo_.o0..Dock = DockStyle.Fill
			Me.Ooo0ooOOo.o.()
			Me.oO._0ooO_o0_. = New PrintInfo(Me)
			Me.o.0ooOO_0__..O00o0.0_0O_.()
			If A_0.o_o.O0ooOo.() IsNot Nothing AndAlso OO_00oOO.DataTables.Contains(A_0.o_o.O0ooOo.().TableName) Then
				Me.AllowBackEndFilter = OO_00oOO.DataTables(A_0.o_o.O0ooOo.().TableName).o0OOOo_.0_o_0o.
				Me.O_o0OOo_.o0..PreserveEditMode = OO_00oOO.DataTables(A_0.o_o.O0ooOo.().TableName).PreserveEditMode
			End If
			Me.O_o0OOo_.o0..PreserveEditMode = Me.PreserveEditMode
		End Sub

		' Token: 0x06002908 RID: 10504 RVA: 0x00114369 File Offset: 0x00112569
		Friend Sub <<EMPTY_NAME>>()
			Me.O_o0OOo_.o0..O.00oO.()
			Me.O_o0OOo_.o0..DataSource = Nothing
			Me.O_o0OOo_.o0..Controls.Clear()
			Me.O_o0OOo_.o0..Dispose()
			Me.O_o0OOo_.o0. = Nothing
		End Sub

		' Token: 0x170009A2 RID: 2466
		' (get) Token: 0x06002909 RID: 10505 RVA: 0x001143A4 File Offset: 0x001125A4
		' (set) Token: 0x0600290A RID: 10506 RVA: 0x001143BC File Offset: 0x001125BC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property HierarchyData As Boolean
			Get
				Return Me.O0_O.0oOO0Oo0. AndAlso Me.DataTable.oOOO.OOO_0ooO0.
			End Get
			Set(value As Boolean)
				Me.O0_O.0oOO0Oo0. = value
				Me.StopRedraw()
				Dim num As Integer = Me.Grid.Rows.Count - 1
				For i As Integer = 0 To num
					Me.Grid.Rows(i).Visible = True
				Next
				Me.ResumeRedraw()
				Me.Grid.Refresh()
			End Set
		End Property

		' Token: 0x170009A3 RID: 2467
		' (get) Token: 0x0600290B RID: 10507 RVA: 0x00114420 File Offset: 0x00112620
		' (set) Token: 0x0600290C RID: 10508 RVA: 0x00114449 File Offset: 0x00112649
		Friend Property Loaded As Boolean
			Get
				Return Me.IsCopy OrElse Me.TableType IsNot Nothing OrElse Me.o.O0_0o_0O0O.
			End Get
			Set(value As Boolean)
				Me.o.O0_0o_0O0O. = True
			End Set
		End Property

		' Token: 0x170009A4 RID: 2468
		' (get) Token: 0x0600290D RID: 10509 RVA: 0x00114452 File Offset: 0x00112652
		' (set) Token: 0x0600290E RID: 10510 RVA: 0x0011445A File Offset: 0x0011265A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property NeedSaveSetting As Boolean
			Get
				Return Me.O.0_oooOo00.
			End Get
			Set(value As Boolean)
				Me.O.0_oooOo00. = value
			End Set
		End Property

		' Token: 0x170009A5 RID: 2469
		' (get) Token: 0x0600290F RID: 10511 RVA: 0x00114463 File Offset: 0x00112663
		<oO0oooo("0440")>
		Public ReadOnly Property Name As String
			Get
				Return Me.View.Oo._Oo0OO.()
			End Get
		End Property

		' Token: 0x170009A6 RID: 2470
		' (get) Token: 0x06002910 RID: 10512 RVA: 0x00114470 File Offset: 0x00112670
		' (set) Token: 0x06002911 RID: 10513 RVA: 0x001144FC File Offset: 0x001126FC
		<oO0oooo("0441")>
		Public Property Visible As Boolean
			Get
				Dim result As Boolean
				If Me.IsRelation Then
					result = (Me.foxGrid.FindForm() IsNot Nothing)
				Else
					Try
						For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
							Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
							If oo0__Oo.O_000__.o.() Is Me Then
								result = oo0__Oo.TabVisible
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Return result
			End Get
			Set(value As Boolean)
				If Me.IsRelation Then
					If Not value Then
						If Me.foxGrid.FindForm() Is Main.OO_O.o. Then
							Dim parent As System.Windows.Forms.Control = Me.foxGrid.Parent
							While parent IsNot Nothing
								If TypeOf parent Is o_O0_0O0 Then
									CType(parent, o_O0_0O0).o_o.O___0o.(Me.foxGrid)
									Return
								End If
								parent = parent.Parent
							End While
							Return
						End If
					ElseIf Me.foxGrid.FindForm() Is Nothing Then
						Dim text As String = Me.Name.Substring(0, Me.Name.IndexOf("."))
						Dim o_O0_0O As o_O0_0O0
						Select Case Me._frdDockArea
							Case 0
								o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).o__0_.o0OoOOO.()
								GoTo IL_128
							Case 2
								o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O__O.o_oOO.()
								GoTo IL_128
							Case 3
								o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O_000__.o.()
								GoTo IL_128
						End Select
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O._o_00__.()
						IL_128:
						o_O0_0O.OO_o0_oO.0.(Me, Me._frdDockTitle)
						Return
					End If
				Else
					Try
						For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
							Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
							If oo0__Oo.O_000__.o.() Is Me Then
								oo0__Oo.TabVisible = value
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
			End Set
		End Property

		' Token: 0x06002912 RID: 10514 RVA: 0x001146AC File Offset: 0x001128AC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Show()
			If Not Me.IsRelation Then
				Try
					For Each form As Foxtable.WinForm.Form In OO_00oOO.Forms
						If form.IsMain AndAlso Operators.CompareString(form.TableName, Me.Name, True) = 0 Then
							form.Close()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Foxtable.WinForm.Form)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			If Me.foxGrid.FindForm() IsNot Nothing Then
				Dim parent As System.Windows.Forms.Control = Me.foxGrid.Parent
				While parent IsNot Nothing
					If TypeOf parent Is FormPanel Then
						Dim form2 As Foxtable.WinForm.Form = OO_00oOO.Forms(parent.Name)
						form2.Close()
						If form2.IsMain And Operators.CompareString(form2.TableName, Me.Name, True) <> 0 Then
							OO_00oOO.Tables(form2.TableName).Show()
						End If
						Exit While
					End If
					parent = parent.Parent
				End While
			End If
			oOO0oo_o0.o.O0o000_.(Me.foxGrid)
		End Sub

		' Token: 0x170009A7 RID: 2471
		' (get) Token: 0x06002913 RID: 10515 RVA: 0x001147A4 File Offset: 0x001129A4
		<oO0oooo("0442")>
		Public ReadOnly Property DataTable As DataTable
			Get
				Return OO_00oOO.DataTables(Me.View.o_o.O0ooOo.().TableName)
			End Get
		End Property

		' Token: 0x170009A8 RID: 2472
		' (get) Token: 0x06002914 RID: 10516 RVA: 0x001147C0 File Offset: 0x001129C0
		' (set) Token: 0x06002915 RID: 10517 RVA: 0x001147CD File Offset: 0x001129CD
		<oO0oooo("0497")>
		Public Property Font As Font
			Get
				Return Me.foxGrid.Font
			End Get
			Set(value As Font)
				Me.foxGrid.Font = value
			End Set
		End Property

		' Token: 0x170009A9 RID: 2473
		' (get) Token: 0x06002916 RID: 10518 RVA: 0x001147DB File Offset: 0x001129DB
		' (set) Token: 0x06002917 RID: 10519 RVA: 0x001147E8 File Offset: 0x001129E8
		<oO0oooo("0498")>
		Public Property ForeColor As Color
			Get
				Return Me.foxGrid.ForeColor
			End Get
			Set(value As Color)
				Me.foxGrid.ForeColor = value
			End Set
		End Property

		' Token: 0x170009AA RID: 2474
		' (get) Token: 0x06002918 RID: 10520 RVA: 0x001147F6 File Offset: 0x001129F6
		<oO0oooo("0459")>
		Public ReadOnly Property CanUndo As Boolean
			Get
				Return Me.O_o0OOo_.o0..Count > 0
			End Get
		End Property

		' Token: 0x170009AB RID: 2475
		' (get) Token: 0x06002919 RID: 10521 RVA: 0x00114806 File Offset: 0x00112A06
		<oO0oooo("0460")>
		Public ReadOnly Property CanRedo As Boolean
			Get
				Return Me.O_O__.ooOo..Count > 0
			End Get
		End Property

		' Token: 0x0600291A RID: 10522 RVA: 0x00114818 File Offset: 0x00112A18
		<oO0oooo("0542")>
		Public Sub Undo()
			If Me.O_o0OOo_.o0..Count > 0 Then
				Dim oo0__O__O_0__ As Oo0__O__O_0__ = Me.O_o0OOo_.o0.(Me.O_o0OOo_.o0..Count - 1)
				oo0__O__O_0__.O__00.__0_O.()
				Me.O_O__.ooOo..Add(oo0__O__O_0__)
				Me.O_o0OOo_.o0..Remove(oo0__O__O_0__)
				Me.Refresh()
			End If
		End Sub

		' Token: 0x0600291B RID: 10523 RVA: 0x00114874 File Offset: 0x00112A74
		<oO0oooo("0543")>
		Public Sub Redo()
			If Me.O_O__.ooOo..Count > 0 Then
				Dim oo0__O__O_0__ As Oo0__O__O_0__ = Me.O_O__.ooOo.(Me.O_O__.ooOo..Count - 1)
				oo0__O__O_0__.oO_o_0.0.()
				Me.O_o0OOo_.o0..O__00.__0_O.(oo0__O__O_0__)
				Me.O_O__.ooOo..Remove(oo0__O__O_0__)
				Me.Refresh()
			End If
		End Sub

		' Token: 0x0600291C RID: 10524 RVA: 0x001148CD File Offset: 0x00112ACD
		<oO0oooo("0544")>
		Public Sub ClearEditInfos()
			Me.O_o0OOo_.o0..Clear()
			Me.O_O__.ooOo..Clear()
		End Sub

		' Token: 0x0600291D RID: 10525 RVA: 0x001148E8 File Offset: 0x00112AE8
		<oO0oooo("0545")>
		Public Function Aggregate(AggregateType As AggregateEnum, R1 As Integer, C1 As Integer, R2 As Integer, C2 As Integer) As Double
			Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
			Dim digits As Integer = 2
			R1 = o_oOooO_O.Rows.Fixed + R1
			R2 = o_oOooO_O.Rows.Fixed + R2
			C1 = o_oOooO_O.Cols.Fixed + C1
			C2 = o_oOooO_O.Cols.Fixed + C2
			Dim result As Double
			If R1 < 0 OrElse R2 < 0 OrElse C1 < 0 OrElse C2 < 0 Then
				result = 0.0
			Else
				If Me.Cols(o_oOooO_O.Cols(C1).Name).DataCol.Decimals > 2 Then
					digits = Me.Cols(o_oOooO_O.Cols(C1).Name).DataCol.Decimals
				End If
				Dim dataIndex As Integer = Me.foxGrid.Rows(R2).DataIndex
				If Me.GridTreeVisible Then
					If dataIndex >= 0 AndAlso Me.Rows(dataIndex).HasChild Then
						Dim hierarchy As Integer = Me.Rows(dataIndex).Hierarchy
						Dim num As Integer = R2 + 1
						Dim num2 As Integer = Me.foxGrid.Rows.Count - 1
						For i As Integer = num To num2
							dataIndex = Me.foxGrid.Rows(i).DataIndex
							If dataIndex >= 0 Then
								If Me.Rows(dataIndex).Hierarchy <= hierarchy Then
									Exit For
								End If
								R2 = i
							End If
						Next
					End If
					result = Math.Round(Me.foxGrid.Aggregate(AggregateType, R1, C1, R2, C2, 1), digits)
				Else
					If dataIndex < 0 AndAlso o_oOooO_O.Rows(R2).Node IsNot Nothing AndAlso o_oOooO_O.SubtotalPosition Is Nothing Then
						Dim level As Integer = o_oOooO_O.Rows(R2).Node.Level
						Dim num3 As Integer = o_oOooO_O.Rows.Count - 1
						Dim num4 As Integer = R2 + 1
						Dim num5 As Integer = Me.foxGrid.Rows.Count - 1
						For j As Integer = num4 To num5
							If o_oOooO_O.Rows(j).IsNode AndAlso o_oOooO_O.Rows(j).Node.Level = level Then
								num3 = j - 1
								Exit For
							End If
						Next
						R2 = num3
					End If
					result = Math.Round(Me.foxGrid.Aggregate(AggregateType, R1, C1, R2, C2, 9), digits)
				End If
			End If
			Return result
		End Function

		' Token: 0x170009AC RID: 2476
		' (get) Token: 0x0600291E RID: 10526 RVA: 0x00114B49 File Offset: 0x00112D49
		' (set) Token: 0x0600291F RID: 10527 RVA: 0x00114B51 File Offset: 0x00112D51
		<oO0oooo("1373")>
		Public Property MergeCols As List(Of String)
			Get
				Return Me.oO00__O_.oO.
			End Get
			Set(value As List(Of String))
				Me.oO00__O_.oO. = value
			End Set
		End Property

		' Token: 0x170009AD RID: 2477
		' (get) Token: 0x06002920 RID: 10528 RVA: 0x00114B5A File Offset: 0x00112D5A
		' (set) Token: 0x06002921 RID: 10529 RVA: 0x00114B62 File Offset: 0x00112D62
		<oO0oooo("1373")>
		Public Property MergeSort As String
			Get
				Return Me.oO00__O_.oO.
			End Get
			Set(value As String)
				Me.oO00__O_.oO. = value
			End Set
		End Property

		' Token: 0x170009AE RID: 2478
		' (get) Token: 0x06002922 RID: 10530 RVA: 0x00114B6B File Offset: 0x00112D6B
		' (set) Token: 0x06002923 RID: 10531 RVA: 0x00114B73 File Offset: 0x00112D73
		<oO0oooo("1373")>
		Public Property MergeMode As MergeModeEnum
			Get
				Return Me.oO00__O_.oO.
			End Get
			Set(value As MergeModeEnum)
				Me.oO00__O_.oO. = value
			End Set
		End Property

		' Token: 0x170009AF RID: 2479
		' (get) Token: 0x06002924 RID: 10532 RVA: 0x00114B7C File Offset: 0x00112D7C
		' (set) Token: 0x06002925 RID: 10533 RVA: 0x00114BA0 File Offset: 0x00112DA0
		<oO0oooo("1373")>
		Public Property AllowMerge As Boolean
			Get
				Return Me.foxGrid.AllowMerging <> 7
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
					If Not value OrElse Me.MergeCols Is Nothing Then
						GoTo IL_13C
					End If
					IL_1A:
					num2 = 3
					Dim enumerator As IEnumerator(Of Col) = Me.Cols.GetEnumerator()
					While enumerator.MoveNext()
						Dim col As Col = enumerator.Current
						IL_32:
						num2 = 4
						col.AllowMerging = False
						IL_3C:
						num2 = 5
					End While
					IL_46:
					num2 = 6
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
					IL_51:
					num2 = 7
					Select Case Me.MergeMode
						Case 0
							IL_92:
							num2 = 13
							Me.foxGrid.AllowMerging = 7
						Case 1
							IL_70:
							num2 = 9
							Me.foxGrid.AllowMerging = 3
						Case 2
							IL_81:
							num2 = 11
							Me.foxGrid.AllowMerging = 1
					End Select
					IL_A1:
					num2 = 15
					Dim enumerator2 As List(Of String).Enumerator = Me.MergeCols.GetEnumerator()
					While enumerator2.MoveNext()
						Dim text As String = enumerator2.Current
						IL_BC:
						num2 = 16
						If Me.Cols.Contains(text) Then
							IL_CE:
							num2 = 17
							Me.Cols(text).AllowMerging = True
						End If
						IL_E4:
						num2 = 18
					End While
					IL_F0:
					num2 = 19
					CType(enumerator2, IDisposable).Dispose()
					IL_100:
					num2 = 20
					Me.MergeMode = Me.MergeMode
					IL_10F:
					num2 = 21
					If Operators.CompareString(Me.View.oO_O.o_OOO.(), Me.MergeSort, True) = 0 Then
						GoTo IL_14B
					End If
					IL_12B:
					num2 = 22
					Me.Sort = Me.MergeSort
					GoTo IL_14B
					IL_13C:
					num2 = 24
					Me.foxGrid.AllowMerging = 7
					IL_14B:
					num2 = 25
					Me.foxGrid.Invalidate()
					IL_159:
					GoTo IL_213
					IL_15E:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_1D4:
					GoTo IL_208
					IL_1D6:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_1E6:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_1D6
				End Try
				IL_208:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_213:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x170009B0 RID: 2480
		' (get) Token: 0x06002926 RID: 10534 RVA: 0x00114DE4 File Offset: 0x00112FE4
		<oO0oooo("1372")>
		Public ReadOnly Property SubtotalGroups As SubtotalGroupCollection
			Get
				Return Me.oO._0ooO_o0_.
			End Get
		End Property

		' Token: 0x170009B1 RID: 2481
		' (get) Token: 0x06002927 RID: 10535 RVA: 0x00114DEC File Offset: 0x00112FEC
		' (set) Token: 0x06002928 RID: 10536 RVA: 0x00114DF4 File Offset: 0x00112FF4
		<oO0oooo("1372")>
		Public Property GroupAboveData As Boolean
			Get
				Return Me.o0O_o00_.0__O.
			End Get
			Set(value As Boolean)
				Me.o0O_o00_.0__O. = value
			End Set
		End Property

		' Token: 0x170009B2 RID: 2482
		' (get) Token: 0x06002929 RID: 10537 RVA: 0x00114DFD File Offset: 0x00112FFD
		' (set) Token: 0x0600292A RID: 10538 RVA: 0x00114E08 File Offset: 0x00113008
		<oO0oooo("1372")>
		Public Property TreeVisible As Boolean
			Get
				Return Me.o.Oo_o_o_0oo.
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
					Me.o.Oo_o_o_0oo. = value
					IL_10:
					num2 = 3
					If Not value Then
						GoTo IL_2D
					End If
					IL_15:
					num2 = 4
					Me.foxGrid.Tree.Style = 7
					GoTo IL_FD
					IL_2D:
					num2 = 6
					If Not Me.IsSubtotal Then
						GoTo IL_E9
					End If
					IL_3A:
					num2 = 7
					If Me.foxGrid.Rows.Count <= Me.foxGrid.Rows.Fixed Then
						GoTo IL_E9
					End If
					IL_61:
					num2 = 8
					If Me.foxGrid.SubtotalPosition IsNot Nothing Then
						GoTo IL_A3
					End If
					IL_70:
					num2 = 9
					Dim level As Integer = Me.foxGrid.Rows(Me.foxGrid.Rows.Count - 1).Node.Level
					GoTo IL_D2
					IL_A3:
					num2 = 11
					level = Me.foxGrid.Rows(Me.foxGrid.Rows.Fixed).Node.Level
					IL_D2:
					num2 = 12
					Me.foxGrid.Tree.Show(level + 1)
					IL_E9:
					num2 = 13
					Me.foxGrid.Tree.Style = 0
					IL_FD:
					num2 = 14
					If Me.foxGrid.FindForm() Is Nothing OrElse Not Me.IsSubtotal Then
						GoTo IL_1C9
					End If
					IL_11B:
					num2 = 16
					Dim width As Integer = Me.foxGrid.Cols(Me.foxGrid.Cols.Fixed).Width
					IL_144:
					num2 = 17
					Me.foxGrid.AutoSizeCols(Me.foxGrid.Cols.Fixed - 1, Me.foxGrid.Cols.Fixed, 0)
					IL_175:
					num2 = 18
					If Me.foxGrid.Cols(Me.foxGrid.Cols.Fixed).Width >= width Then
						GoTo IL_1C9
					End If
					IL_1A0:
					num2 = 19
					Me.foxGrid.Cols(Me.foxGrid.Cols.Fixed).Width = width
					IL_1C9:
					GoTo IL_26B
					IL_1CE:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_22C:
					GoTo IL_260
					IL_22E:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_23E:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_22E
				End Try
				IL_260:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_26B:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x170009B3 RID: 2483
		' (get) Token: 0x0600292B RID: 10539 RVA: 0x001150A4 File Offset: 0x001132A4
		' (set) Token: 0x0600292C RID: 10540 RVA: 0x001150B1 File Offset: 0x001132B1
		Public Property ScrollPosition As Point
			Get
				Return Me.foxGrid.ScrollPosition
			End Get
			Set(value As Point)
				Me.foxGrid.ScrollPosition = value
			End Set
		End Property

		' Token: 0x170009B4 RID: 2484
		' (get) Token: 0x0600292D RID: 10541 RVA: 0x001150C0 File Offset: 0x001132C0
		<oO0oooo("1372")>
		Public ReadOnly Property IsSubtotal As Boolean
			Get
				Dim result As Boolean
				If Me.foxGrid.Rows.Count - Me.foxGrid.Rows.Fixed = Me.View.Count Then
					result = False
				Else
					Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
					result = ((o_oOooO_O.Rows(o_oOooO_O.Rows.Count - 1).DataIndex <> -1 OrElse o_oOooO_O.Rows(o_oOooO_O.Rows.Count - 1).IsNode) AndAlso Not Me.foxGrid.OO.o_o00o.())
				End If
				Return result
			End Get
		End Property

		' Token: 0x170009B5 RID: 2485
		' (get) Token: 0x0600292E RID: 10542 RVA: 0x0011515F File Offset: 0x0011335F
		' (set) Token: 0x0600292F RID: 10543 RVA: 0x0011516C File Offset: 0x0011336C
		<oO0oooo("2750")>
		Public Property GrandTotal As Boolean
			Get
				Return Me.foxGrid.AllowAddNew
			End Get
			Set(value As Boolean)
				If value AndAlso (Me.IsSubtotal OrElse Me.foxGrid.OO.o_o00o.()) Then
					MessageBox.Show("不能在汇总模式下显示总计行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.foxGrid.AllowAddNew = value
				End If
				Me.Grid.Rows(Me.Grid.Rows.Count - 1).Invalidate()
			End Set
		End Property

		' Token: 0x06002930 RID: 10544 RVA: 0x001151D9 File Offset: 0x001133D9
		<oO0oooo("1372")>
		Public Sub ClearSubtotal()
			If Me.IsSubtotal Then
				Me.foxGrid.Subtotal(1)
			End If
			Me.foxGrid.O.O00O_oO_OO00.(True)
		End Sub

		' Token: 0x06002931 RID: 10545 RVA: 0x001151FC File Offset: 0x001133FC
		<oO0oooo("1372")>
		Public Sub Subtotal(Optional UseCurrentSort As Boolean = False)
			Dim num As Integer = Me.SubtotalGroups.Count - 1
			For i As Integer = 0 To num
				If Operators.CompareString(Me.SubtotalGroups(i).Caption, "", True) = 0 Then
					Me.SubtotalGroups(i).Caption = Me.SubtotalGroups(i).O_oo.0oOO.(Me)
				End If
				If Operators.CompareString(Me.SubtotalGroups(i).GroupOn, "*", True) <> 0 Then
					For j As Integer = i - 1 To 0 Step -1
						If Operators.CompareString(Me.SubtotalGroups(j).GroupOn, "*", True) <> 0 AndAlso Me.Cols(Me.SubtotalGroups(i).GroupOn).IsDate() AndAlso Me.SubtotalGroups(i).DateGroup IsNot Nothing AndAlso Not Me.Cols(Me.SubtotalGroups(j).GroupOn).IsDate() Then
							MessageBox.Show("汇总模式的日期分组列必须作为第一个分组！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
					Next
				End If
			Next
			Me.O0o._oo_.(UseCurrentSort)
		End Sub

		' Token: 0x06002932 RID: 10546 RVA: 0x00115334 File Offset: 0x00113534
		Private Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False)
			Dim num3 As Integer
			Dim num23 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Me.View.Count = 0 Then
					GoTo IL_1F6E
				End If
				IL_12:
				num = 3
				Me.GrandTotal = False
				IL_1B:
				num = 4
				Dim num2 As Integer = 0
				IL_20:
				num = 5
				IL_22:
				num = 6
				Dim subtotalGroup As SubtotalGroup = Nothing
				IL_27:
				num = 7
				Dim list As List(Of String) = New List(Of String)()
				IL_30:
				num = 8
				Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
				IL_39:
				num = 9
				Dim list2 As List(Of String) = New List(Of String)()
				IL_43:
				num = 10
				Dim text As String = ""
				IL_4D:
				num = 11
				Me.StopRedraw()
				IL_56:
				num = 12
				If Not Me.GridTreeVisible Then
					GoTo IL_6A
				End If
				IL_61:
				num = 13
				Me.CloseGridTree()
				IL_6A:
				num = 14
				Information.Err().Clear()
				IL_77:
				ProjectData.ClearProjectError()
				num3 = 1
				IL_7E:
				num = 16
				If Not Me.GroupAboveData Then
					GoTo IL_9A
				End If
				IL_89:
				num = 17
				Me.foxGrid.SubtotalPosition = 0
				GoTo IL_A9
				IL_9A:
				num = 19
				Me.foxGrid.SubtotalPosition = 1
				IL_A9:
				num = 20
				Me.foxGrid.Subtotal(1)
				IL_B8:
				num = 21
				Me.foxGrid.Tree.Column = Me.foxGrid.Cols.Fixed - 1
				IL_DD:
				num = 22
				Dim num4 As Integer
				For i As Integer = Me.SubtotalGroups.Count - 1 To 0 Step -1
					IL_F4:
					num = 23
					Dim subtotalGroup2 As SubtotalGroup = Me.SubtotalGroups(i)
					IL_106:
					num = 24
					If Operators.CompareString(subtotalGroup2.GroupOn, "", True) <> 0 AndAlso Operators.CompareString(subtotalGroup2.GroupOn, "*", True) <> 0 AndAlso Me.foxGrid.Cols.Contains(subtotalGroup2.GroupOn) Then
						IL_153:
						num = 27
						If subtotalGroup IsNot Nothing Then
							IL_15A:
							num = 28
							If Operators.CompareString(subtotalGroup2.GroupOn, subtotalGroup.GroupOn, True) <> 0 OrElse subtotalGroup2.DateGroup <> subtotalGroup.DateGroup Then
								IL_183:
								num = 29
								num2 += 1
							End If
						End If
						IL_18C:
						num = 30
						subtotalGroup2.Level = num2
						IL_198:
						num = 31
						subtotalGroup = subtotalGroup2
						IL_19F:
						num = 32
						If Not list2.Contains(subtotalGroup2.GroupOn) Then
							IL_1B2:
							num = 33
							list2.Add(subtotalGroup2.GroupOn)
							IL_1C3:
							num = 34
							If list2.Count > 1 Then
								IL_1D0:
								num = 35
								text += ","
							End If
							IL_1E1:
							num = 36
							text += subtotalGroup2.GroupOn
						End If
						IL_1F4:
						num = 37
						num4 += 1
					End If
					IL_1FB:
					num = 38
				Next
				IL_20C:
				num = 39
				If A_0 Then
					GoTo IL_253
				End If
				IL_212:
				num = 40
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_253
				End If
				IL_225:
				num = 41
				Me.View.o_O_.00o.(text)
				IL_235:
				num = 42
				Me.View.o_o.O0ooOo.().Sort = text
				IL_24A:
				num = 43
				Me.O0O.O00oO.()
				IL_253:
				num = 44
				Foxtable.RibbonMenu.StatusBar.Message1 = "正在统计"
				IL_260:
				num = 45
				Foxtable.RibbonMenu.StatusBar.ProgressBar.Visible = True
				IL_269:
				num = 46
				For j As Integer = Me.SubtotalGroups.Count - 1 To 0 Step -1
					IL_280:
					num = 47
					Dim subtotalGroup2 As SubtotalGroup = Me.SubtotalGroups(j)
					IL_292:
					num = 48
					list.Clear()
					IL_29C:
					num = 49
					dictionary.Clear()
					IL_2A6:
					num = 50
					If Operators.CompareString(subtotalGroup2.GroupOn, "", True) <> 0 AndAlso (Operators.CompareString(subtotalGroup2.GroupOn, "*", True) = 0 OrElse Me.foxGrid.Cols.Contains(subtotalGroup2.GroupOn)) Then
						IL_2F0:
						num = 52
						Dim flag As Boolean
						If Operators.CompareString(subtotalGroup2.GroupOn, "*", True) <> 0 AndAlso Me.View.o_o.O0ooOo.().Columns(Me.foxGrid.Cols(subtotalGroup2.GroupOn).Name).DataType Is GetType(DateTime) AndAlso subtotalGroup2.DateGroup IsNot Nothing Then
							IL_352:
							num = 53
							flag = True
						Else
							IL_35A:
							num = 55
							flag = False
						End If
						IL_360:
						num = 56
						list.AddRange(subtotalGroup2.TotalOn.Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries))
						IL_382:
						num = 57
						If subtotalGroup2.Aggregate = 3 Then
							IL_392:
							num = 58
							Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
							While enumerator.MoveNext()
								Dim text2 As String = enumerator.Current
								IL_3AC:
								num = 59
								Dim num5 As Integer = Me.foxGrid.Cols.IndexOf(text2)
								IL_3C3:
								num = 60
								If Not dictionary.ContainsKey(text2) Then
									IL_3D4:
									num = 62
									Dim value As Double
									If Me.View.o_o.O0ooOo.().Columns(text2).DataType Is GetType(DateTime) Then
										IL_3FF:
										num = 63
										value = Me.foxGrid.Aggregate(4, Me.foxGrid.Rows.Fixed, num5, Me.foxGrid.Rows.Count - 1, num5, 3)
									Else
										IL_43C:
										num = 65
										If Me.View.o_o.O0ooOo.().Columns(text2).DataType Is GetType(Boolean) Then
											IL_467:
											num = 66
											value = Me.foxGrid.Aggregate(4, Me.foxGrid.Rows.Fixed, num5, Me.foxGrid.Rows.Count - 1, num5, 5)
										Else
											IL_4A1:
											num = 68
											value = Me.foxGrid.Aggregate(2, Me.foxGrid.Rows.Fixed, num5, Me.foxGrid.Rows.Count - 1, num5, 1)
										End If
									End If
									IL_4D9:
									num = 69
									dictionary.Add(text2, value)
								End If
								IL_4E7:
								num = 70
							End While
							IL_4F6:
							num = 71
							CType(enumerator, IDisposable).Dispose()
						End If
						IL_506:
						num = 72
						If Operators.CompareString(subtotalGroup2.GroupOn, "*", True) = 0 Then
							IL_520:
							num = 73
							Dim num7 As Integer
							If Me.foxGrid.SubtotalPosition = 1 Then
								IL_534:
								num = 74
								Dim num6 As Integer = Me.foxGrid.Rows.Count - 1
								Dim fixed As Integer = Me.foxGrid.Rows.Fixed
								For k As Integer = num6 To fixed Step -1
									IL_55F:
									num = 75
									If Not Me.foxGrid.Rows(k).IsNode OrElse Me.foxGrid.Rows(k).Node.Level > -1 Then
										IL_59A:
										num = 76
										num7 = k + 1
										Exit For
									End If
									IL_5A8:
									num = 78
								Next
							Else
								IL_5B9:
								num = 80
								Dim fixed2 As Integer = Me.foxGrid.Rows.Fixed
								Dim num8 As Integer = Me.foxGrid.Rows.Count - 1
								For l As Integer = fixed2 To num8
									IL_5E4:
									num = 81
									If Not Me.foxGrid.Rows(l).IsNode OrElse Me.foxGrid.Rows(l).Node.Level > -1 Then
										IL_61F:
										num = 82
										num7 = l
										Exit For
									End If
									IL_628:
									num = 84
								Next
							End If
							IL_637:
							num = 85
							If num7 <> 0 Then
								IL_641:
								num = 87
								Dim row As Row = Me.foxGrid.Rows.InsertNode(num7, -1).Row
								IL_65E:
								num = 88
								Me.foxGrid.SetData(row.Index, Me.foxGrid.Cols.Fixed, subtotalGroup2.Caption, False)
								IL_68C:
								num = 89
								row.Style = Me.foxGrid.Styles(13)
								IL_6A8:
								num = 90
								Dim enumerator2 As List(Of String).Enumerator = list.GetEnumerator()
								While enumerator2.MoveNext()
									Dim text3 As String = enumerator2.Current
									IL_6C2:
									num = 91
									Dim num5 As Integer = Me.foxGrid.Cols.IndexOf(text3)
									IL_6D9:
									num = 92
									If Me.Cols(text3).IsNumeric() Then
										IL_6F0:
										num = 93
										Me.foxGrid.GetCellRange(row.Index, num5).StyleNew.DataType = GetType(Decimal)
									End If
									IL_71F:
									num = 94
									If Me.View.o_o.O0ooOo.().Columns(text3).DataType Is GetType(Boolean) Then
										IL_74A:
										num = 95
										Me.foxGrid.GetCellRange(row.Index, num5).StyleNew.DataType = GetType(Double)
									End If
									IL_779:
									num = 96
									If subtotalGroup2.Aggregate = 3 Then
										IL_786:
										num = 97
										row(num5) = 1
										IL_798:
										num = 98
										Me.foxGrid.GetCellRange(row.Index, num5).StyleNew.Format = "0.##%"
									Else
										IL_7C7:
										num = 100
										If Me.View.o_o.O0ooOo.().Columns(text3).DataType Is GetType(DateTime) Then
											IL_7F2:
											num = 101
											row(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, Me.foxGrid.Rows.Fixed, num5, Me.foxGrid.Rows.Count - 1, num5, 3)
										Else
											IL_841:
											num = 103
											If Me.View.o_o.O0ooOo.().Columns(text3).DataType Is GetType(Boolean) AndAlso subtotalGroup2.Aggregate = 2 Then
												IL_876:
												num = 104
												row(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, Me.foxGrid.Rows.Fixed, num5, Me.foxGrid.Rows.Count - 1, num5, 5)
											Else
												IL_8C2:
												num = 106
												row(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, Me.foxGrid.Rows.Fixed, num5, Me.foxGrid.Rows.Count - 1, num5, 1)
											End If
										End If
									End If
									IL_90C:
									num = 107
								End While
								IL_91B:
								num = 108
								CType(enumerator2, IDisposable).Dispose()
							End If
						Else
							IL_930:
							num = 111
							Dim num9 As Integer = Me.foxGrid.Cols.IndexOf(subtotalGroup2.GroupOn)
							IL_94C:
							num = 112
							If Me.foxGrid.SubtotalPosition = 1 Then
								IL_960:
								num = 113
								Dim flag2 As Boolean = False
								IL_966:
								num = 114
								Dim num10 As Integer = Me.foxGrid.Rows.Fixed
								IL_97B:
								num = 115
								Dim num11 As Integer = Me.foxGrid.Rows.Fixed + 1
								IL_992:
								num = 116
								subtotalGroup2.oOo0.0_. = num10
								IL_99E:
								num = 117
								Dim text4 As String
								If Me.foxGrid(num10, num9) Is DBNull.Value Then
									IL_9B7:
									num = 118
									text4 = ""
								Else
									IL_9C6:
									num = 120
									If flag Then
										IL_9CD:
										num = 121
										text4 = Me.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup)
									Else
										IL_9E8:
										num = 123
										If Me.foxGrid(num10, num9) Is DBNull.Value Then
											IL_A01:
											num = 124
											text4 = ""
										Else
											IL_A10:
											num = 126
											text4 = Conversions.ToString(Me.foxGrid(num10, num9))
										End If
									End If
								End If
								While True
									IL_1319:
									num = 128
									IL_A2E:
									num = 129
									Dim flag3 As Boolean
									If num10 = Me.foxGrid.Rows.Count - 1 Then
										IL_A4A:
										num = 130
										flag3 = True
										IL_A53:
										num = 131
										num11 = Me.foxGrid.Rows.Count
									Else
										IL_A70:
										num = 133
										If Me.foxGrid.Rows(num11).DataIndex = -1 Then
											IL_A90:
											num = 134
											If subtotalGroup2.Level <> Me.foxGrid.Rows(num11).Node.Level Then
												IL_ABB:
												num = 135
												flag2 = True
											End If
											IL_AC4:
											num = 136
											flag3 = True
										Else
											IL_AD2:
											num = 138
											If num11 = Me.foxGrid.Rows.Count - 1 Then
												IL_AF1:
												num = 139
												flag3 = True
												IL_AFA:
												num = 140
												If Me.foxGrid.Rows(num11).DataIndex > -1 Then
													IL_B1D:
													num = 141
													If Operators.CompareString(Me.foxGrid(num11, num9).ToString(), text4, True) = 0 Then
														IL_B41:
														num = 142
														num11 = Me.foxGrid.Rows.Count
													Else
														IL_B5E:
														num = 144
														If flag AndAlso Operators.CompareString(Me.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, True) = 0 Then
															IL_B89:
															num = 145
															num11 = Me.foxGrid.Rows.Count
														End If
													End If
												End If
											Else
												IL_BA6:
												num = 147
												If Operators.CompareString(text4, "", True) = 0 AndAlso Me.foxGrid(num11, num9) IsNot DBNull.Value Then
													IL_BD1:
													num = 148
													flag3 = True
												Else
													IL_BDF:
													num = 150
													If flag Then
														IL_BE9:
														num = 151
														If Operators.CompareString(Me.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, True) <> 0 Then
															IL_C0A:
															num = 152
															flag3 = True
														End If
													Else
														IL_C15:
														num = 154
														If Me.foxGrid(num11, num9) Is DBNull.Value Then
															IL_C31:
															num = 155
															If Operators.CompareString(text4, "", True) <> 0 Then
																IL_C46:
																num = 156
																flag3 = True
															End If
														Else
															IL_C51:
															num = 158
															If Operators.CompareString(Conversions.ToString(Me.foxGrid(num11, num9)), text4, True) <> 0 Then
																IL_C75:
																num = 159
																flag3 = True
															End If
														End If
													End If
												End If
											End If
										End If
									End If
									IL_C7E:
									num = 160
									If flag3 Then
										IL_C8B:
										num = 161
										flag3 = False
										IL_C94:
										num = 162
										Dim arg As String
										If Me.foxGrid.Cols(num9).DataMap Is Nothing Then
											IL_CB3:
											num = 163
											arg = text4
										Else
											IL_CBF:
											num = 165
											arg = Me.foxGrid.GetDataDisplay(num10, num9)
										End If
										IL_CD6:
										num = 166
										Dim row2 As Row = Me.foxGrid.Rows.InsertNode(num11, subtotalGroup2.Level).Row
										IL_CFC:
										num = 167
										row2.Style = Me.foxGrid.Styles(Conversions.ToInteger([Enum].Parse(GetType(CellStyleEnum), "Subtotal" + Conversions.ToString(Math.Min(subtotalGroup2.Level, 5)))))
										IL_D49:
										num = 168
										Me.foxGrid.SetData(row2.Index, Me.foxGrid.Cols.Fixed, String.Format(subtotalGroup2.Caption, arg), False)
										IL_D81:
										num = 169
										Dim num12 As Integer = num10
										IL_D8B:
										num = 170
										If subtotalGroup2.upto Then
											IL_D9A:
											num = 171
											num12 = subtotalGroup2.oOo0.0_.
										End If
										IL_DA9:
										num = 172
										Dim enumerator3 As List(Of String).Enumerator = list.GetEnumerator()
										While enumerator3.MoveNext()
											Dim text5 As String = enumerator3.Current
											IL_DC6:
											num = 173
											Dim num5 As Integer = Me.foxGrid.Cols.IndexOf(text5)
											IL_DE0:
											num = 174
											If Me.Cols(text5).IsNumeric() Then
												IL_DFA:
												num = 175
												Me.foxGrid.GetCellRange(row2.Index, num5).StyleNew.DataType = GetType(Decimal)
											End If
											IL_E2C:
											num = 176
											If num5 >= Me.foxGrid.Cols.Fixed Then
												IL_E49:
												num = 178
												If Me.View.o_o.O0ooOo.().Columns(text5).DataType Is GetType(Boolean) Then
													IL_E77:
													num = 179
													Me.foxGrid.GetCellRange(row2.Index, num5).StyleNew.DataType = GetType(Double)
												End If
												IL_EA9:
												num = 180
												If subtotalGroup2.Aggregate = 3 Then
													IL_EBC:
													num = 181
													Me.foxGrid.GetCellRange(row2.Index, num5).StyleNew.Format = "0.##%"
													IL_EE9:
													num = 182
													Dim num13 As Double
													If Me.View.o_o.O0ooOo.().Columns(text5).DataType Is GetType(DateTime) Then
														IL_F17:
														num = 183
														num13 = Me.foxGrid.Aggregate(4, num12, num5, num11 - 1, num5, 3)
													Else
														IL_F38:
														num = 185
														If Me.View.o_o.O0ooOo.().Columns(text5).DataType Is GetType(Boolean) Then
															IL_F66:
															num = 186
															num13 = Me.foxGrid.Aggregate(4, num12, num5, num11 - 1, num5, 5)
														Else
															IL_F87:
															num = 188
															num13 = Me.foxGrid.Aggregate(2, num12, num5, num11 - 1, num5, 1)
														End If
													End If
													IL_FA6:
													num = 189
													If dictionary(text5) > 0.0 Then
														IL_FC0:
														num = 190
														row2(num5) = num13 / dictionary(text5)
													Else
														IL_FE5:
														num = 192
														row2(num5) = 0
													End If
												Else
													IL_FFF:
													num = 194
													If Me.View.o_o.O0ooOo.().Columns(text5).DataType Is GetType(DateTime) Then
														IL_102D:
														num = 195
														row2(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, num12, num5, num11 - 1, num5, 3)
													Else
														IL_1063:
														num = 197
														If Me.View.o_o.O0ooOo.().Columns(text5).DataType Is GetType(Boolean) AndAlso subtotalGroup2.Aggregate = 2 Then
															IL_109B:
															num = 198
															row2(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, num12, num5, num11 - 1, num5, 5)
														Else
															IL_10CE:
															num = 200
															row2(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, num12, num5, num11 - 1, num5, 1)
														End If
													End If
												End If
											End If
											IL_10FF:
											num = 201
										End While
										IL_1111:
										num = 202
										CType(enumerator3, IDisposable).Dispose()
										IL_1124:
										num = 203
										num10 = -1
										IL_112D:
										num = 204
										text4 = ""
										IL_113A:
										num = 205
										Dim num14 As Integer = num11
										Dim num15 As Integer = Me.foxGrid.Rows.Count - 1
										Dim m As Integer = num14
										While m <= num15
											IL_115D:
											num = 206
											If Me.foxGrid.Rows(m).DataIndex <> -1 Then
												IL_1180:
												num = 209
												num10 = m
												IL_118A:
												num = 210
												num11 = num10 + 1
												IL_1196:
												num = 211
												If Me.foxGrid(num10, num9) Is Nothing Then
													IL_11AD:
													num = 212
													text4 = ""
													Exit While
												End If
												IL_11BF:
												num = 214
												If flag Then
													IL_11C9:
													num = 215
													text4 = Me.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup)
													Exit While
												End If
												IL_11E4:
												num = 217
												If Me.foxGrid(num10, num9) Is DBNull.Value Then
													IL_1200:
													num = 218
													text4 = ""
													Exit While
												End If
												IL_120F:
												num = 220
												text4 = Conversions.ToString(Me.foxGrid(num10, num9))
												Exit While
											Else
												IL_122D:
												num = 222
												m += 1
											End If
										End While
										IL_1242:
										num = 223
										If num10 = -1 Then
											Exit For
										End If
										IL_1250:
										num = 225
										If flag2 Then
											IL_125A:
											num = 226
											subtotalGroup2.oOo0.0_. = num10
											IL_1269:
											num = 227
											flag2 = False
										End If
									Else
										IL_1274:
										num = 229
										num11 += 1
										IL_1280:
										num = 230
										If num11 > Me.foxGrid.Rows.Count - 1 Then
											Exit For
										End If
									End If
									IL_129F:
									num = 232
									If num11 Mod 500 = 0 Then
										IL_12AF:
										num = 233
										Dim value2 As Integer = CInt(Math.Round(CDbl(num11) / CDbl(Me.foxGrid.Rows.Count) / CDbl(num4) * CDbl((j + 1)) * 100.0))
										IL_12E5:
										num = 234
										Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = value2
										IL_12F2:
										num = 235
										Foxtable.RibbonMenu.StatusBar.Message2 = Conversions.ToString(value2) + "%"
										IL_130E:
										num = 236
										Application.DoEvents()
									End If
								End While
							Else
								IL_1324:
								num = 239
								If Me.foxGrid.SubtotalPosition Is Nothing Then
									IL_133A:
									num = 240
									Dim flag2 As Boolean = False
									IL_1343:
									num = 241
									Dim fixed3 As Integer = Me.foxGrid.Rows.Fixed
									Dim num16 As Integer = Me.foxGrid.Rows.Count - 1
									Dim num10 As Integer
									For n As Integer = fixed3 To num16
										IL_1371:
										num = 242
										If Me.foxGrid.Rows(n).DataIndex > -1 Then
											IL_1391:
											num = 243
											num10 = n
											Exit For
										End If
										IL_139D:
										num = 245
									Next
									IL_13AF:
									num = 246
									subtotalGroup2.oOo0.0_. = num10
									IL_13BE:
									num = 247
									Dim num11 As Integer = num10 + 1
									IL_13CA:
									num = 248
									Dim text4 As String
									If Me.foxGrid(num10, num9) Is DBNull.Value Then
										IL_13E6:
										num = 249
										text4 = ""
									Else
										IL_13F8:
										num = 251
										If flag Then
											IL_1402:
											num = 252
											text4 = Me.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup)
										Else
											IL_1420:
											num = 254
											If Me.foxGrid(num10, num9) Is DBNull.Value Then
												IL_143C:
												num = 255
												text4 = ""
											Else
												IL_144E:
												num = 257
												text4 = Conversions.ToString(Me.foxGrid(num10, num9))
											End If
										End If
									End If
									While True
										IL_1D37:
										num = 259
										IL_146F:
										num = 260
										Dim flag3 As Boolean
										If num10 = Me.foxGrid.Rows.Count - 1 Then
											IL_148B:
											num = 261
											flag3 = True
											IL_1494:
											num = 262
											num11 = Me.foxGrid.Rows.Count
										Else
											IL_14B1:
											num = 264
											If Me.foxGrid.Rows(num11).DataIndex = -1 Then
												IL_14D1:
												num = 265
												If subtotalGroup2.Level <> Me.foxGrid.Rows(num11).Node.Level Then
													IL_14FC:
													num = 266
													flag2 = True
												End If
												IL_1505:
												num = 267
												flag3 = True
											Else
												IL_1513:
												num = 269
												If num11 = Me.foxGrid.Rows.Count - 1 Then
													IL_1532:
													num = 270
													flag3 = True
													IL_153B:
													num = 271
													If flag Then
														IL_1545:
														num = 272
														If Operators.CompareString(Me.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, True) = 0 Then
															IL_1569:
															num = 273
															num11 = Me.foxGrid.Rows.Count
														End If
													Else
														IL_1586:
														num = 275
														If Operators.CompareString(Me.foxGrid(num11, num9).ToString(), text4, True) = 0 Then
															IL_15AD:
															num = 276
															num11 = Me.foxGrid.Rows.Count
														End If
													End If
												Else
													IL_15CA:
													num = 278
													If Operators.CompareString(text4, "", True) = 0 AndAlso Me.foxGrid(num11, num9) IsNot DBNull.Value Then
														IL_15F5:
														num = 279
														flag3 = True
													Else
														IL_1603:
														num = 281
														If flag Then
															IL_160D:
															num = 282
															If Operators.CompareString(Me.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, True) <> 0 Then
																IL_162E:
																num = 283
																flag3 = True
															End If
														Else
															IL_1639:
															num = 285
															If Me.foxGrid(num11, num9) Is DBNull.Value Then
																IL_1655:
																num = 286
																If Operators.CompareString(text4, "", True) <> 0 Then
																	IL_166A:
																	num = 287
																	flag3 = True
																End If
															Else
																IL_1675:
																num = 289
																If Operators.CompareString(Conversions.ToString(Me.foxGrid(num11, num9)), text4, True) <> 0 Then
																	IL_1699:
																	num = 290
																	flag3 = True
																End If
															End If
														End If
													End If
												End If
											End If
										End If
										IL_16A2:
										num = 291
										If flag3 Then
											IL_16AF:
											num = 292
											flag3 = False
											IL_16B8:
											num = 293
											Dim arg As String
											If Me.foxGrid.Cols(num9).DataMap Is Nothing Then
												IL_16D7:
												num = 294
												arg = text4
											Else
												IL_16E3:
												num = 296
												arg = Me.foxGrid.GetDataDisplay(num10, num9)
											End If
											IL_16FA:
											num = 297
											Dim row3 As Row = Me.foxGrid.Rows.InsertNode(num10, subtotalGroup2.Level).Row
											IL_1720:
											num = 298
											row3.Style = Me.foxGrid.Styles(Conversions.ToInteger([Enum].Parse(GetType(CellStyleEnum), "Subtotal" + Conversions.ToString(Math.Min(subtotalGroup2.Level, 5)))))
											IL_176D:
											num = 299
											Me.foxGrid.SetData(row3.Index, Me.foxGrid.Cols.Fixed, String.Format(subtotalGroup2.Caption, arg), False)
											IL_17A5:
											num = 300
											Dim num17 As Integer = num10 + 1
											IL_17B1:
											num = 301
											If subtotalGroup2.upto Then
												IL_17C0:
												num = 302
												num17 = subtotalGroup2.oOo0.0_. + 1
											End If
											IL_17D1:
											num = 303
											Dim enumerator4 As List(Of String).Enumerator = list.GetEnumerator()
											While enumerator4.MoveNext()
												Dim text6 As String = enumerator4.Current
												IL_17EE:
												num = 304
												Dim num5 As Integer = Me.foxGrid.Cols.IndexOf(text6)
												IL_1808:
												num = 305
												If Me.Cols(text6).IsNumeric() Then
													IL_1822:
													num = 306
													Me.foxGrid.GetCellRange(row3.Index, num5).StyleNew.DataType = GetType(Decimal)
												End If
												IL_1854:
												num = 307
												If num5 >= Me.foxGrid.Cols.Fixed Then
													IL_1871:
													num = 309
													If Me.View.o_o.O0ooOo.().Columns(text6).DataType Is GetType(Boolean) Then
														IL_189F:
														num = 310
														Me.foxGrid.GetCellRange(row3.Index, num5).StyleNew.DataType = GetType(Double)
													End If
													IL_18D1:
													num = 311
													If subtotalGroup2.Aggregate = 3 Then
														IL_18E4:
														num = 312
														Me.foxGrid.GetCellRange(row3.Index, num5).StyleNew.Format = "0.##%"
														IL_1911:
														num = 313
														Dim num18 As Double
														If Me.View.o_o.O0ooOo.().Columns(text6).DataType Is GetType(DateTime) Then
															IL_193F:
															num = 314
															num18 = Me.foxGrid.Aggregate(4, num17, num5, num11, num5, 3)
														Else
															IL_195E:
															num = 316
															If Me.View.o_o.O0ooOo.().Columns(text6).DataType Is GetType(Boolean) Then
																IL_198C:
																num = 317
																num18 = Me.foxGrid.Aggregate(4, num17, num5, num11, num5, 5)
															Else
																IL_19AB:
																num = 319
																num18 = Me.foxGrid.Aggregate(2, num17, num5, num11, num5, 1)
															End If
														End If
														IL_19C8:
														num = 320
														If dictionary(text6) > 0.0 Then
															IL_19E2:
															num = 321
															row3(num5) = num18 / dictionary(text6)
														Else
															IL_1A07:
															num = 323
															row3(num5) = 0
														End If
													Else
														IL_1A21:
														num = 325
														If Me.View.o_o.O0ooOo.().Columns(text6).DataType Is GetType(DateTime) Then
															IL_1A4F:
															num = 326
															row3(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, num17, num5, num11, num5, 3)
														Else
															IL_1A83:
															num = 328
															If Me.View.o_o.O0ooOo.().Columns(text6).DataType Is GetType(Boolean) AndAlso subtotalGroup2.Aggregate = 2 Then
																IL_1ABB:
																num = 329
																row3(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, num17, num5, num11, num5, 5)
															Else
																IL_1AEC:
																num = 331
																row3(num5) = Me.foxGrid.Aggregate(subtotalGroup2.Aggregate, num17, num5, num11, num5, 1)
															End If
														End If
													End If
												End If
												IL_1B1B:
												num = 332
											End While
											IL_1B2D:
											num = 333
											CType(enumerator4, IDisposable).Dispose()
											IL_1B40:
											num = 334
											num10 = -1
											IL_1B49:
											num = 335
											text4 = ""
											IL_1B56:
											num = 336
											Dim num19 As Integer = num11 + 1
											Dim num20 As Integer = Me.foxGrid.Rows.Count - 1
											Dim num21 As Integer = num19
											While num21 <= num20
												IL_1B7B:
												num = 337
												If Me.foxGrid.Rows(num21).DataIndex <> -1 Then
													IL_1B9E:
													num = 340
													num10 = num21
													IL_1BA8:
													num = 341
													num11 = num10 + 1
													IL_1BB4:
													num = 342
													If Me.foxGrid(num10, num9) Is Nothing Then
														IL_1BCB:
														num = 343
														text4 = ""
														Exit While
													End If
													IL_1BDD:
													num = 345
													If flag Then
														IL_1BE7:
														num = 346
														text4 = Me.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup)
														Exit While
													End If
													IL_1C02:
													num = 348
													If Me.foxGrid(num10, num9) Is DBNull.Value Then
														IL_1C1E:
														num = 349
														text4 = ""
														Exit While
													End If
													IL_1C2D:
													num = 351
													text4 = Conversions.ToString(Me.foxGrid(num10, num9))
													Exit While
												Else
													IL_1C4B:
													num = 353
													num21 += 1
												End If
											End While
											IL_1C60:
											num = 354
											If num10 = -1 Then
												Exit For
											End If
											IL_1C6E:
											num = 356
											If flag2 Then
												IL_1C78:
												num = 357
												subtotalGroup2.oOo0.0_. = num10
												IL_1C87:
												num = 358
												flag2 = False
											End If
										Else
											IL_1C92:
											num = 360
											num11 += 1
											IL_1C9E:
											num = 361
											If num11 > Me.foxGrid.Rows.Count - 1 Then
												Exit For
											End If
										End If
										IL_1CBD:
										num = 363
										If num11 Mod 500 = 0 Then
											IL_1CCD:
											num = 364
											Dim value3 As Integer = CInt(Math.Round(CDbl(num11) / CDbl(Me.foxGrid.Rows.Count) / CDbl(num4) * CDbl((j + 1)) * 100.0))
											IL_1D03:
											num = 365
											Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = value3
											IL_1D10:
											num = 366
											Foxtable.RibbonMenu.StatusBar.Message2 = Conversions.ToString(value3) + "%"
											IL_1D2C:
											num = 367
											Application.DoEvents()
										End If
									End While
								End If
							End If
						End If
					End If
					IL_1D42:
					num = 369
				Next
				IL_1D56:
				num = 370
				If Not Me.TreeVisible Then
					GoTo IL_1D7D
				End If
				IL_1D64:
				num = 371
				Me.foxGrid.Tree.Style = 7
				GoTo IL_1D94
				IL_1D7D:
				num = 373
				Me.foxGrid.Tree.Style = 0
				IL_1D94:
				num = 374
				Dim width As Integer = Me.Grid.Cols(0).Width
				IL_1DB2:
				num = 375
				If Me.SpillNode Then
					GoTo IL_1EB3
				End If
				IL_1DC3:
				num = 376
				Dim width2 As Integer = Me.foxGrid.Cols(Me.foxGrid.Cols.Fixed).Width
				IL_1DF0:
				num = 377
				If Not Me.TreeVisible Then
					GoTo IL_1E34
				End If
				IL_1DFE:
				num = 378
				Me.foxGrid.AutoSizeCols(Me.foxGrid.Cols.Fixed - 1, Me.foxGrid.Cols.Fixed, 4)
				GoTo IL_1E55
				IL_1E34:
				num = 380
				Me.foxGrid.AutoSizeCol(Me.foxGrid.Cols.Fixed)
				IL_1E55:
				num = 381
				If Me.foxGrid.Cols(Me.foxGrid.Cols.Fixed).Width >= width2 Then
					GoTo IL_1EE9
				End If
				IL_1E84:
				num = 382
				Me.foxGrid.Cols(Me.foxGrid.Cols.Fixed).Width = width2
				GoTo IL_1EE9
				IL_1EB3:
				num = 384
				Me.foxGrid.AutoSizeCols(Me.foxGrid.Cols.Fixed - 1, Me.foxGrid.Cols.Fixed - 1, 4)
				IL_1EE9:
				num = 385
				If Me.Grid.Cols(0).Width >= width Then
					GoTo IL_1F27
				End If
				IL_1F09:
				num = 386
				Me.Grid.Cols(0).Width = width
				IL_1F27:
				num = 387
				Foxtable.RibbonMenu.StatusBar.Reset()
				IL_1F32:
				num = 388
				Me.ResumeRedraw()
				IL_1F3E:
				num = 389
				If Information.Err().Number = 0 Then
					GoTo IL_1F6E
				End If
				IL_1F50:
				num = 390
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_1F6E:
				GoTo IL_25DC
				IL_1F73:
				Dim num22 As Integer = num23 + 1
				num23 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num22)
				IL_259D:
				GoTo IL_25D1
				IL_259F:
				num23 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_25AF:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num3 <> 0 And num23 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_259F
			End Try
			IL_25D1:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_25DC:
			If num23 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x170009B6 RID: 2486
		' (get) Token: 0x06002933 RID: 10547 RVA: 0x00117944 File Offset: 0x00115B44
		' (set) Token: 0x06002934 RID: 10548 RVA: 0x00117A1C File Offset: 0x00115C1C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Value(A_0 As Object()) As Object
			Get
				Select Case A_0.Length
					Case 0
						Return Me.Value
					Case 2
						Dim a_ As Integer = Conversions.ToInteger(A_0(0))
						If TypeOf A_0(1)Is Integer Then
							Return Me.O000o_oO.Oo_o.(a_, Conversions.ToInteger(A_0(1)), False)
						End If
						If TypeOf A_0(1)Is String Then
							Return Me.OooO.0.(a_, Conversions.ToString(A_0(1)), False)
						End If
					Case 3
						Dim a_2 As Integer = Conversions.ToInteger(A_0(0))
						Dim a_3 As Boolean = Conversions.ToBoolean(A_0(2))
						If TypeOf A_0(1)Is Integer Then
							Return Me.O000o_oO.Oo_o.(a_2, Conversions.ToInteger(A_0(1)), a_3)
						End If
						If TypeOf A_0(1)Is String Then
							Return Me.OooO.0.(a_2, Conversions.ToString(A_0(1)), a_3)
						End If
				End Select
				Throw New ArgumentException("Value属性仅支持2个或3个参数！")
			End Get
			Set(value As Object)
				Select Case A_0.Length
					Case 0
						Me.Value = RuntimeHelpers.GetObjectValue(value)
						Return
					Case 1
					Case 2
						Dim a_ As Integer = Conversions.ToInteger(A_0(0))
						If TypeOf A_0(1)Is Integer Then
							Me.OO_oo_._.(a_, Conversions.ToInteger(A_0(1)), False, RuntimeHelpers.GetObjectValue(value))
							Return
						End If
						If TypeOf A_0(1)Is String Then
							Me.OO_oo_._.(a_, Conversions.ToString(A_0(1)), False, RuntimeHelpers.GetObjectValue(value))
							Return
						End If
					Case 3
						Dim a_2 As Integer = Conversions.ToInteger(A_0(0))
						Dim a_3 As Boolean = Conversions.ToBoolean(A_0(2))
						If TypeOf A_0(1)Is Integer Then
							Me.OO_oo_._.(a_2, Conversions.ToInteger(A_0(1)), a_3, RuntimeHelpers.GetObjectValue(value))
							Return
						End If
						If TypeOf A_0(1)Is String Then
							Me.OO_oo_._.(a_2, Conversions.ToString(A_0(1)), a_3, RuntimeHelpers.GetObjectValue(value))
						End If
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x170009B7 RID: 2487
		' (get) Token: 0x06002935 RID: 10549 RVA: 0x00117AF0 File Offset: 0x00115CF0
		' (set) Token: 0x06002936 RID: 10550 RVA: 0x00117BE8 File Offset: 0x00115DE8
		<oO0oooo("0443")>
		Public Property Value As Object
			Get
				Dim result As Object
				If Me.foxGrid.Row < Me.foxGrid.Rows.Fixed OrElse Me.foxGrid.Col < Me.foxGrid.Cols.Fixed Then
					result = Nothing
				ElseIf Me.Grid.Rows(Me.foxGrid.Row).DataIndex >= 0 Then
					result = Me.O000o_oO.Oo_o.(Me.Grid.Rows(Me.foxGrid.Row).DataIndex, Me.Grid.Col - Me.Grid.Cols.Fixed, False)
				Else
					result = Me.O000o_oO.Oo_o.(Me.foxGrid.Row - Me.Grid.Rows.Fixed, Me.Grid.Col - Me.Grid.Cols.Fixed, True)
				End If
				Return result
			End Get
			Set(value As Object)
				If Me.foxGrid.Row >= Me.foxGrid.Rows.Fixed AndAlso Me.foxGrid.Col >= Me.foxGrid.Cols.Fixed Then
					If Me.Grid.Rows(Me.foxGrid.Row).DataIndex >= 0 Then
						Me.OO_oo_._.(Me.Grid.Rows(Me.foxGrid.Row).DataIndex, Me.Grid.Col - Me.Grid.Cols.Fixed, False, RuntimeHelpers.GetObjectValue(value))
						Return
					End If
					Me.OO_oo_._.(Me.foxGrid.Row - Me.Grid.Rows.Fixed, Me.Grid.Col - Me.Grid.Cols.Fixed, True, RuntimeHelpers.GetObjectValue(value))
				End If
			End Set
		End Property

		' Token: 0x170009B8 RID: 2488
		' (get) Token: 0x06002937 RID: 10551 RVA: 0x00117CE7 File Offset: 0x00115EE7
		' (set) Token: 0x06002938 RID: 10552 RVA: 0x00117CF2 File Offset: 0x00115EF2
		<oO0oooo("0443")>
		Public Property Value(A_0 As Integer, A_1 As Integer, A_2 As Boolean) As Object
			Get
				Return Me(A_0, A_1, A_2)
			End Get
			Set(value As Object)
				Me(A_0, A_1, A_2) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170009B9 RID: 2489
		' (get) Token: 0x06002939 RID: 10553 RVA: 0x00117D04 File Offset: 0x00115F04
		' (set) Token: 0x0600293A RID: 10554 RVA: 0x00117D0F File Offset: 0x00115F0F
		<oO0oooo("0443")>
		Public Property Value(A_0 As Integer, A_1 As String, A_2 As Boolean) As Object
			Get
				Return Me(A_0, A_1, A_2)
			End Get
			Set(value As Object)
				Me(A_0, A_1, A_2) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170009BA RID: 2490
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(A_0 As Integer, A_1 As Integer, Optional A_2 As Boolean = False) As Object
			Get
				Dim name As String = Me.O_o0OOo_.o0..Cols(A_1 + Me.O_o0OOo_.o0..Cols.Fixed).Name
				Return Me(A_0, name, A_2)
			End Get
			Set(value As Object)
				Dim name As String = Me.O_o0OOo_.o0..Cols(A_1 + Me.O_o0OOo_.o0..Cols.Fixed).Name
				Me(A_0, name, A_2) = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170009BB RID: 2491
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(A_0 As Integer, A_1 As String, Optional A_2 As Boolean = False) As Object
			Get
				Dim result As Object
				If A_2 Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.foxGrid(A_0 + Me.O_o0OOo_.o0..Rows.Fixed, A_1))
					If objectValue Is DBNull.Value OrElse objectValue Is Nothing Then
						Dim dataType As Type = Me.View.o_o.O0ooOo.().Columns(A_1).DataType
						If dataType Is GetType(String) Then
							result = ""
						ElseIf dataType Is GetType(Boolean) Then
							result = False
						ElseIf dataType Is GetType(DateTime) Then
							result = Nothing
						Else
							result = 0
						End If
					Else
						result = objectValue
					End If
				ElseIf Me.View.O0O_0_0__.0O.(A_0).Row.IsNull(A_1) Then
					Dim dataType2 As Type = Me.View.o_o.O0ooOo.().Columns(A_1).DataType
					If dataType2 Is GetType(String) Then
						result = ""
					ElseIf dataType2 Is GetType(Boolean) Then
						result = False
					ElseIf dataType2 Is GetType(DateTime) Then
						result = Nothing
					Else
						result = 0
					End If
				Else
					If Me.View.o_o.O0ooOo.().Columns(A_1).DataType Is GetType(DateTime) Then
						Dim dateTime As DateTime = Conversions.ToDate(Me.View.O0O_0_0__.0O.(A_0)(A_1))
						Select Case Me.DataTable.DataCols(A_1).DateTimeFormat
							Case 0
								Return dateTime.[Date]
							Case 1
								dateTime = New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
								Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
							Case 2
								Return New DateTime(dateTime.Ticks - dateTime.[Date].Ticks)
							Case 3
								Return dateTime.AddSeconds(CDbl((-CDbl(dateTime.Second))))
							Case 4
								Return dateTime
						End Select
					End If
					result = Me.View.O0O_0_0__.0O.(A_0)(A_1)
				End If
				Return result
			End Get
			Set(value As Object)
				If Not o_O_o_oOoo__.oO.O_..Contains(A_1) AndAlso Operators.CompareString(A_1, Me.DataTable.O_.__0., True) <> 0 Then
					If A_2 Then
						If Me.O_o0OOo_.o0..Rows(A_0 + Me.O_o0OOo_.o0..Rows.Fixed).IsNode Then
							Me.O_o0OOo_.o0..SetData(A_0 + Me.O_o0OOo_.o0..Rows.Fixed, A_1, RuntimeHelpers.GetObjectValue(value), False)
							Return
						End If
						Me.O_o0OOo_.o0.(A_0 + Me.O_o0OOo_.o0..Rows.Fixed, A_1) = RuntimeHelpers.GetObjectValue(value)
						Return
					Else
						Me.View.O0O_0_0__.0O.(A_0)(A_1) = RuntimeHelpers.GetObjectValue(value)
					End If
				End If
			End Set
		End Property

		' Token: 0x170009BC RID: 2492
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer, Optional A_1 As Boolean = False) As Row
			Get
				Dim result As Row
				If A_1 Then
					result = New Row(Me, A_0)
				Else
					result = New Row(Me, Me.View.O0O_0_0__.0O.(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170009BD RID: 2493
		' (get) Token: 0x06002940 RID: 10560 RVA: 0x0011811E File Offset: 0x0011631E
		<oO0oooo("0444")>
		Public ReadOnly Property Text As String
			Get
				Return Me.foxGrid.GetDataDisplay(Me.foxGrid.Row, Me.foxGrid.Col)
			End Get
		End Property

		' Token: 0x170009BE RID: 2494
		' (get) Token: 0x06002941 RID: 10561 RVA: 0x00118141 File Offset: 0x00116341
		<oO0oooo("0444")>
		Public ReadOnly Property Text(A_0 As Integer, A_1 As Integer) As String
			Get
				Return Me.foxGrid.GetDataDisplay(A_0 + Me.foxGrid.Rows.Fixed, A_1 + Me.foxGrid.Cols.Fixed)
			End Get
		End Property

		' Token: 0x170009BF RID: 2495
		' (get) Token: 0x06002942 RID: 10562 RVA: 0x00118174 File Offset: 0x00116374
		Public ReadOnly Property Count(A_0 As Boolean) As Integer
			Get
				Dim result As Integer
				If A_0 Then
					Dim num As Integer = Me.foxGrid.Rows.Count - Me.foxGrid.Rows.Fixed
					If Me.GrandTotal Then
						num -= 1
					End If
					result = num
				Else
					result = Me.View.Count
				End If
				Return result
			End Get
		End Property

		' Token: 0x170009C0 RID: 2496
		' (get) Token: 0x06002943 RID: 10563 RVA: 0x001181C3 File Offset: 0x001163C3
		<oO0oooo("1438")>
		Public ReadOnly Property Rows As RowCollection
			Get
				Return Me.oO._0ooO_o0_.
			End Get
		End Property

		' Token: 0x170009C1 RID: 2497
		' (get) Token: 0x06002944 RID: 10564 RVA: 0x001181CB File Offset: 0x001163CB
		<oO0oooo("0561")>
		Public ReadOnly Property Cols As ColCollection
			Get
				If Me.foxGrid.FindForm() Is Nothing Then
					Me.O.__O0o0.(True, False)
				End If
				Return Me.o0__OOo0._oO.
			End Get
		End Property

		' Token: 0x170009C2 RID: 2498
		' (get) Token: 0x06002945 RID: 10565 RVA: 0x001181E9 File Offset: 0x001163E9
		' (set) Token: 0x06002946 RID: 10566 RVA: 0x001181F4 File Offset: 0x001163F4
		<oO0oooo("0450")>
		Public Property StateFilter As StateFilterEnum
			Get
				Return Me.oO._0ooO_o0_.
			End Get
			Set(value As StateFilterEnum)
				Dim num2 As Integer
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					Dim num As Integer = 1
					Me.oO._0ooO_o0_. = value
					IL_09:
					ProjectData.ClearProjectError()
					num2 = 1
					IL_10:
					num = 3
					Select Case value
						Case 0
							IL_4C:
							num = 7
							Me.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.CurrentRows
						Case 1
							IL_37:
							num = 5
							Me.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.Added
						Case 2
							IL_62:
							num = 9
							Me.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.ModifiedCurrent
						Case 3
							IL_A7:
							num = 15
							Me.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.Unchanged
						Case 4
							IL_90:
							num = 13
							Me.View.o_o.O0ooOo.().RowStateFilter = (DataViewRowState.Unchanged Or DataViewRowState.ModifiedOriginal)
						Case 5
							IL_79:
							num = 11
							Me.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.ModifiedOriginal
					End Select
					IL_BB:
					GoTo IL_151
					IL_C0:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_112:
					GoTo IL_146
					IL_114:
					num4 = num
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
					IL_124:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_114
				End Try
				IL_146:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_151:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x170009C3 RID: 2499
		' (get) Token: 0x06002947 RID: 10567 RVA: 0x00118378 File Offset: 0x00116578
		<oO0oooo("0456")>
		Public ReadOnly Property IsChild As Boolean
			Get
				Return Me.View.O.o_OOOo_OoO.()
			End Get
		End Property

		' Token: 0x170009C4 RID: 2500
		' (get) Token: 0x06002948 RID: 10568 RVA: 0x00118385 File Offset: 0x00116585
		<oO0oooo("0455")>
		Public ReadOnly Property IsParent As Boolean
			Get
				Return Me.View.O0OOO_0.o.()
			End Get
		End Property

		' Token: 0x170009C5 RID: 2501
		' (get) Token: 0x06002949 RID: 10569 RVA: 0x00118392 File Offset: 0x00116592
		<oO0oooo("0454")>
		Public ReadOnly Property IsRelation As Boolean
			Get
				Return Me.View.O0O_0_0__.0O.() IsNot Nothing
			End Get
		End Property

		' Token: 0x170009C6 RID: 2502
		' (get) Token: 0x0600294A RID: 10570 RVA: 0x001183A4 File Offset: 0x001165A4
		' (set) Token: 0x0600294B RID: 10571 RVA: 0x00118470 File Offset: 0x00116670
		<oO0oooo("0446")>
		Public Property Position As Integer
			Get
				Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
				Dim result As Integer
				If o_oOooO_O.Rows.Count = o_oOooO_O.Rows.Fixed AndAlso Me.View.o_o.O0ooOo.() IsNot Nothing Then
					result = Me.View.Position
				Else
					If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed And o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed Then
						o_oOooO_O.Row = o_oOooO_O.Rows.Fixed
					End If
					If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed Then
						result = -1
					ElseIf o_oOooO_O.Rows(o_oOooO_O.Row).DataIndex < 0 Then
						result = -1
					Else
						result = Me.View.Position
					End If
				End If
				Return result
			End Get
			Set(value As Integer)
				If(Me.View.Position <> value OrElse Me.Grid.Row <= Me.foxGrid.Rows.Count - 1 OrElse Me.foxGrid.Rows(Me.foxGrid.Row).DataIndex < 0) AndAlso value >= 0 Then
					Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
					If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed AndAlso o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed Then
						o_oOooO_O.Row = o_oOooO_O.Rows.Fixed
					End If
					If o_oOooO_O.Row >= o_oOooO_O.Rows.Fixed AndAlso Me.View.Position = value AndAlso o_oOooO_O.Rows(o_oOooO_O.Row).DataIndex <> value Then
						Dim row As Integer = o_oOooO_O.Row
						Dim fixed As Integer = o_oOooO_O.Rows.Fixed
						For i As Integer = row To fixed Step -1
							If o_oOooO_O.Rows(i).DataIndex <> -1 Then
								o_oOooO_O.Row = i
							End If
						Next
					End If
					Me.View.Position = value
				End If
			End Set
		End Property

		' Token: 0x170009C7 RID: 2503
		' (get) Token: 0x0600294C RID: 10572 RVA: 0x0011859C File Offset: 0x0011679C
		<oO0oooo("0445")>
		Public ReadOnly Property Current As Row
			Get
				Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
				Dim result As Row
				If o_oOooO_O.Rows.Count = o_oOooO_O.Rows.Fixed AndAlso Me.View.o_o.O0ooOo.() IsNot Nothing Then
					result = New Row(Me, Me.View.o_o.O0ooOo.())
				ElseIf o_oOooO_O.Row > o_oOooO_O.Rows.Count - 1 Then
					result = Nothing
				Else
					If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed And o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed Then
						o_oOooO_O.Row = o_oOooO_O.Rows.Fixed
					End If
					If o_oOooO_O.Row < o_oOooO_O.Rows.Fixed Then
						result = Nothing
					ElseIf o_oOooO_O.Rows(o_oOooO_O.Row).DataIndex < 0 Then
						result = Nothing
					ElseIf Me.View.o_o.O0ooOo.() Is Nothing Then
						result = Nothing
					Else
						result = New Row(Me, Me.View.o_o.O0ooOo.())
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x170009C8 RID: 2504
		' (get) Token: 0x0600294D RID: 10573 RVA: 0x001186A1 File Offset: 0x001168A1
		<oO0oooo("0447")>
		Public ReadOnly Property RowSel As Integer
			Get
				Return Me.foxGrid.Row - Me.foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x170009C9 RID: 2505
		' (get) Token: 0x0600294E RID: 10574 RVA: 0x001186BF File Offset: 0x001168BF
		<oO0oooo("0447")>
		Public ReadOnly Property ColSel As Integer
			Get
				Return Me.foxGrid.Col - Me.foxGrid.Cols.Fixed
			End Get
		End Property

		' Token: 0x170009CA RID: 2506
		' (get) Token: 0x0600294F RID: 10575 RVA: 0x001186E0 File Offset: 0x001168E0
		<oO0oooo("0447")>
		Public ReadOnly Property TopRow As Integer
			Get
				Return Me.foxGrid.Selection.TopRow - Me.foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x06002950 RID: 10576 RVA: 0x00118711 File Offset: 0x00116911
		Public Sub SetFirstVisibleRow(Index As Integer)
			Me.foxGrid.TopRow = Me.foxGrid.Rows.Fixed + Index
		End Sub

		' Token: 0x06002951 RID: 10577 RVA: 0x00118730 File Offset: 0x00116930
		Public Sub SetFirstVisibleCol(Index As Integer)
			Me.foxGrid.LeftCol = Me.foxGrid.Cols.Fixed + Index
		End Sub

		' Token: 0x170009CB RID: 2507
		' (get) Token: 0x06002952 RID: 10578 RVA: 0x00118750 File Offset: 0x00116950
		<oO0oooo("1595")>
		Public ReadOnly Property TopPosition As Integer
			Get
				Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
				Dim topRow As Integer = o_oOooO_O.Selection.TopRow
				Dim bottomRow As Integer = o_oOooO_O.Selection.BottomRow
				Dim i As Integer = topRow
				While i <= bottomRow
					Dim result As Integer
					If i < 0 Then
						result = -1
					Else
						If o_oOooO_O.Rows(i).DataIndex <= -1 Then
							i += 1
							Continue While
						End If
						result = o_oOooO_O.Rows(i).DataIndex
					End If
					Return result
				End While
				Return -1
			End Get
		End Property

		' Token: 0x170009CC RID: 2508
		' (get) Token: 0x06002953 RID: 10579 RVA: 0x001187C4 File Offset: 0x001169C4
		<oO0oooo("1596")>
		Public ReadOnly Property BottomPosition As Integer
			Get
				Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
				Dim bottomRow As Integer = o_oOooO_O.Selection.BottomRow
				Dim topRow As Integer = o_oOooO_O.Selection.TopRow
				Dim i As Integer = bottomRow
				While i >= topRow
					Dim result As Integer
					If i < 0 Then
						result = -1
					Else
						If o_oOooO_O.Rows(i).DataIndex <= -1 Then
							i += -1
							Continue While
						End If
						result = o_oOooO_O.Rows(i).DataIndex
					End If
					Return result
				End While
				Return -1
			End Get
		End Property

		' Token: 0x170009CD RID: 2509
		' (get) Token: 0x06002954 RID: 10580 RVA: 0x00118838 File Offset: 0x00116A38
		<oO0oooo("0447")>
		Public ReadOnly Property BottomRow As Integer
			Get
				Return Me.foxGrid.Selection.BottomRow - Me.foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x170009CE RID: 2510
		' (get) Token: 0x06002955 RID: 10581 RVA: 0x0011886C File Offset: 0x00116A6C
		<oO0oooo("0447")>
		Public ReadOnly Property LeftCol As Integer
			Get
				Dim result As Integer
				If Me.foxGrid.Selection.LeftCol < Me.foxGrid.Cols.Fixed Then
					result = -1
				Else
					result = Me.foxGrid.Selection.LeftCol - Me.foxGrid.Cols.Fixed
				End If
				Return result
			End Get
		End Property

		' Token: 0x170009CF RID: 2511
		' (get) Token: 0x06002956 RID: 10582 RVA: 0x001188C8 File Offset: 0x00116AC8
		<oO0oooo("0447")>
		Public ReadOnly Property RightCol As Integer
			Get
				Dim result As Integer
				If Me.foxGrid.Selection.LeftCol < Me.foxGrid.Cols.Fixed Then
					result = -2
				Else
					result = Me.foxGrid.Selection.RightCol - Me.foxGrid.Cols.Fixed
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002957 RID: 10583 RVA: 0x00118928 File Offset: 0x00116B28
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub [Select](ParamArray args As Object())
			Select Case args.Length
				Case 0
					Me.[Select]()
					Return
				Case 1, 3
				Case 2
					Me.[Select](Conversions.ToInteger(args(0)), Conversions.ToInteger(args(1)))
					Return
				Case 4
					Me.[Select](Conversions.ToInteger(args(0)), Conversions.ToInteger(args(1)), Conversions.ToInteger(args(2)), Conversions.ToInteger(args(3)))
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06002958 RID: 10584 RVA: 0x00118999 File Offset: 0x00116B99
		<oO0oooo("0550")>
		Public Sub [Select](r1 As Integer, c1 As Integer)
			Me.foxGrid.[Select](r1 + Me.foxGrid.Rows.Fixed, c1 + Me.foxGrid.Cols.Fixed, True)
		End Sub

		' Token: 0x06002959 RID: 10585 RVA: 0x001189CC File Offset: 0x00116BCC
		<oO0oooo("0550")>
		Public Sub [Select](r1 As Integer, c1 As Integer, r2 As Integer, c2 As Integer)
			Me.foxGrid.[Select](r1 + Me.foxGrid.Rows.Fixed, c1 + Me.foxGrid.Cols.Fixed, r2 + Me.foxGrid.Rows.Fixed, c2 + Me.foxGrid.Cols.Fixed, True)
		End Sub

		' Token: 0x170009D0 RID: 2512
		' (get) Token: 0x0600295A RID: 10586 RVA: 0x00118A2E File Offset: 0x00116C2E
		' (set) Token: 0x0600295B RID: 10587 RVA: 0x00118A3B File Offset: 0x00116C3B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Redraw As Boolean
			Get
				Return Me.foxGrid.Redraw
			End Get
			Set(value As Boolean)
				Me.foxGrid.Redraw = value
			End Set
		End Property

		' Token: 0x0600295C RID: 10588 RVA: 0x00118A49 File Offset: 0x00116C49
		<oO0oooo("0453")>
		Public Sub StopRedraw()
			Me.foxGrid.BeginUpdate()
		End Sub

		' Token: 0x0600295D RID: 10589 RVA: 0x00118A56 File Offset: 0x00116C56
		<oO0oooo("1961")>
		Public Sub ResumeRedraw()
			Me.foxGrid.EndUpdate()
		End Sub

		' Token: 0x170009D1 RID: 2513
		' (get) Token: 0x0600295E RID: 10590 RVA: 0x00118A63 File Offset: 0x00116C63
		' (set) Token: 0x0600295F RID: 10591 RVA: 0x00118A70 File Offset: 0x00116C70
		Friend Property _frdFilterString As String
			Get
				Return Me.View.o0.O0.()
			End Get
			Set(value As String)
				Me.View.Oo._Oo0OO.(value)
			End Set
		End Property

		' Token: 0x170009D2 RID: 2514
		' (get) Token: 0x06002960 RID: 10592 RVA: 0x00118A7E File Offset: 0x00116C7E
		' (set) Token: 0x06002961 RID: 10593 RVA: 0x00118A8B File Offset: 0x00116C8B
		<oO0oooo("0448")>
		Public Property Filter As String
			Get
				Return Me.View.get_Filter()
			End Get
			Set(value As String)
				Me.O_o0OOo_.o0..Oo.0.(False)
				Me.ClearSubtotal()
				Me.View.Oo._Oo0OO.(value)
				Me.View.set_Filter(value)
			End Set
		End Property

		' Token: 0x170009D3 RID: 2515
		' (get) Token: 0x06002962 RID: 10594 RVA: 0x00118AB7 File Offset: 0x00116CB7
		' (set) Token: 0x06002963 RID: 10595 RVA: 0x00118AC4 File Offset: 0x00116CC4
		<oO0oooo("0449")>
		Public Property ApplyFilter As Boolean
			Get
				Return Me.View.o__0.O.()
			End Get
			Set(value As Boolean)
				If value Then
					Me.View.set_Filter(Me.View.o0.O0.())
					Return
				End If
				Me.View.set_Filter("")
			End Set
		End Property

		' Token: 0x170009D4 RID: 2516
		' (get) Token: 0x06002964 RID: 10596 RVA: 0x00118AF0 File Offset: 0x00116CF0
		' (set) Token: 0x06002965 RID: 10597 RVA: 0x00118AFD File Offset: 0x00116CFD
		Friend Property _frdSortString As String
			Get
				Return Me.View.o_._0O0o_OoO.()
			End Get
			Set(value As String)
				Me.View.o_O_.00o.(value)
			End Set
		End Property

		' Token: 0x170009D5 RID: 2517
		' (get) Token: 0x06002966 RID: 10598 RVA: 0x00118B0B File Offset: 0x00116D0B
		' (set) Token: 0x06002967 RID: 10599 RVA: 0x00118B18 File Offset: 0x00116D18
		<oO0oooo("0451")>
		Public Property Sort As String
			Get
				Return Me.View.oO_O.o_OOO.()
			End Get
			Set(value As String)
				Me.O_o0OOo_.o0..Oo.0.(False)
				Me.View.oO0o0_.OoO_.(value)
				Me.O0O.O00oO.()
			End Set
		End Property

		' Token: 0x06002968 RID: 10600 RVA: 0x00118B38 File Offset: 0x00116D38
		Private Sub <<EMPTY_NAME>>()
			Me.O_O__.ooOo..Clear()
			If Me.View.SortDescriptions IsNot Nothing Then
				Dim num As Integer = Me.View.SortDescriptions.Count - 1
				For i As Integer = 0 To num
					Dim name As String = Me.View.SortDescriptions(i).PropertyDescriptor.Name
					If Operators.CompareString(name, "System_Sort_Temporary", True) <> 0 AndAlso Operators.CompareString(name, "_SortKey", True) <> 0 Then
						Me.O_O__.ooOo..Add(Me.View.SortDescriptions(i).PropertyDescriptor.Name.ToLower(), Me.View.SortDescriptions(i).SortDirection)
					End If
				Next
			End If
		End Sub

		' Token: 0x170009D6 RID: 2518
		' (get) Token: 0x06002969 RID: 10601 RVA: 0x00118BFB File Offset: 0x00116DFB
		' (set) Token: 0x0600296A RID: 10602 RVA: 0x00118C08 File Offset: 0x00116E08
		<oO0oooo("0452")>
		Public Property ApplySort As Boolean
			Get
				Return Me.View.OO.___OO0O.()
			End Get
			Set(value As Boolean)
				If value Then
					Me.Sort = Me.View.o_._0O0o_OoO.()
					Return
				End If
				Me.View.oO0o0_.OoO_.("")
				Me.O0O.O00oO.()
			End Set
		End Property

		' Token: 0x0600296B RID: 10603 RVA: 0x00118C38 File Offset: 0x00116E38
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Compute(ParamArray args As Object()) As Object
			Dim result As Object
			If args.Length = 1 Then
				result = Me.Compute(Conversions.ToString(args(0)))
			ElseIf args.Length = 2 Then
				result = Me.Compute(Conversions.ToString(args(0)), Conversions.ToString(args(1)))
			End If
			Return result
		End Function

		' Token: 0x0600296C RID: 10604 RVA: 0x00118C7A File Offset: 0x00116E7A
		<oO0oooo("0548")>
		Public Function Compute(Expression As String) As Object
			Return Me.Compute(Expression, "")
		End Function

		' Token: 0x0600296D RID: 10605 RVA: 0x00118C88 File Offset: 0x00116E88
		<oO0oooo("0548")>
		Public Function Compute(Expression As String, Filter As String) As Object
			Dim num As Integer
			Dim result As Object
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.IsRelation Then
					GoTo IL_1BC
				End If
				IL_14:
				num2 = 3
				Dim text As String = ""
				IL_1D:
				num2 = 4
				If Not Me.IsChild Then
					GoTo IL_51
				End If
				IL_27:
				num2 = 5
				Dim array As DataColumn() = Me.View.O0O_0_0__.0O.().ChildColumns
				IL_3B:
				num2 = 6
				Dim array2 As DataColumn() = Me.View.O0O_0_0__.0O.().ParentColumns
				GoTo IL_7A
				IL_51:
				num2 = 8
				array = Me.View.O0O_0_0__.0O.().ParentColumns
				IL_65:
				num2 = 9
				array2 = Me.View.O0O_0_0__.0O.().ChildColumns
				IL_7A:
				num2 = 10
				Dim num3 As Integer = Me.View.O0O_0_0__.0O.().ChildColumns.Length - 1
				For i As Integer = 0 To num3
					IL_9B:
					num2 = 11
					If Operators.CompareString(text, "", True) > 0 Then
						IL_AE:
						num2 = 12
						text += " And "
					End If
					IL_BF:
					num2 = 13
					text = text + "[" + array(i).ColumnName + "] = "
					IL_DF:
					num2 = 14
					If Me.DataTable.DataCols(array(i).ColumnName).IsNumeric Then
						IL_103:
						num2 = 15
						text += Convert.ToString(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.()(array2(i).ColumnName)))
					Else
						IL_13A:
						num2 = 17
						text = text + "'" + Convert.ToString(RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.()(array2(i).ColumnName))) + "'"
					End If
					IL_179:
					num2 = 18
				Next
				IL_18B:
				num2 = 19
				If Operators.CompareString(Filter, "", True) <> 0 Then
					GoTo IL_1A5
				End If
				IL_19C:
				num2 = 20
				Filter = text
				GoTo IL_1BC
				IL_1A5:
				num2 = 22
				Filter = Filter + " And (" + text + ")"
				IL_1BC:
				num2 = 23
				If Operators.CompareString(Me.View.get_Filter(), "", True) <= 0 Then
					GoTo IL_267
				End If
				IL_1DB:
				num2 = 24
				If Operators.CompareString(Filter, "", True) <= 0 Then
					GoTo IL_23F
				End If
				IL_1ED:
				num2 = 25
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.View.o_o.O0ooOo.().Compute(Expression, String.Concat(New String() { "(", Filter, ") And (", Me.View.get_Filter(), ")" })))
				GoTo IL_283
				IL_23F:
				num2 = 27
				objectValue = RuntimeHelpers.GetObjectValue(Me.View.o_o.O0ooOo.().Compute(Expression, Me.View.get_Filter()))
				GoTo IL_283
				IL_267:
				num2 = 29
				objectValue = RuntimeHelpers.GetObjectValue(Me.View.o_o.O0ooOo.().Compute(Expression, Filter))
				IL_283:
				num2 = 30
				If objectValue IsNot DBNull.Value Then
					GoTo IL_296
				End If
				IL_28F:
				num2 = 31
				result = Nothing
				GoTo IL_29C
				IL_296:
				num2 = 33
				result = objectValue
				IL_29C:
				GoTo IL_376
				IL_2A1:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_337:
				GoTo IL_36B
				IL_339:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_349:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_339
			End Try
			IL_36B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_376:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600296E RID: 10606 RVA: 0x00119030 File Offset: 0x00117230
		Friend Sub <<EMPTY_NAME>>()
			Me.o.O_o. = 0
		End Sub

		' Token: 0x170009D7 RID: 2519
		' (get) Token: 0x0600296F RID: 10607 RVA: 0x0011903C File Offset: 0x0011723C
		' (set) Token: 0x06002970 RID: 10608 RVA: 0x0011906F File Offset: 0x0011726F
		<oO0oooo("0472")>
		Public Property EnterKeyActionDown As Boolean
			Get
				Dim result As Boolean
				If Me.o.O_o. Is Nothing Then
					result = Me.DataTable.EnterKeyActionDown
				Else
					result = (Me.o.O_o. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o.O_o. = 1
				Else
					Me.o.O_o. = 2
				End If
				If Me.EnterKeyActionDown Then
					Me.O_o0OOo_.o0..KeyActionEnter = 1
					Return
				End If
				Me.O_o0OOo_.o0..KeyActionEnter = 2
			End Set
		End Property

		' Token: 0x06002971 RID: 10609 RVA: 0x001190A5 File Offset: 0x001172A5
		Friend Sub <<EMPTY_NAME>>()
			Me.oo_._0oo_o_0. = 0
		End Sub

		' Token: 0x170009D8 RID: 2520
		' (get) Token: 0x06002972 RID: 10610 RVA: 0x001190B0 File Offset: 0x001172B0
		' (set) Token: 0x06002973 RID: 10611 RVA: 0x001190E3 File Offset: 0x001172E3
		<oO0oooo("0473")>
		Public Property TabKeyActionDown As Boolean
			Get
				Dim result As Boolean
				If Me.oo_._0oo_o_0. Is Nothing Then
					result = Me.DataTable.TabKeyActionDown
				Else
					result = (Me.oo_._0oo_o_0. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.oo_._0oo_o_0. = 1
				Else
					Me.oo_._0oo_o_0. = 2
				End If
				If Me.TabKeyActionDown Then
					Me.O_o0OOo_.o0..KeyActionTab = 1
					Return
				End If
				Me.O_o0OOo_.o0..KeyActionTab = 2
			End Set
		End Property

		' Token: 0x06002974 RID: 10612 RVA: 0x00119119 File Offset: 0x00117319
		Friend Sub <<EMPTY_NAME>>()
			Me.Oo_o._oO0o. = 0
		End Sub

		' Token: 0x170009D9 RID: 2521
		' (get) Token: 0x06002975 RID: 10613 RVA: 0x00119124 File Offset: 0x00117324
		' (set) Token: 0x06002976 RID: 10614 RVA: 0x00119157 File Offset: 0x00117357
		<oO0oooo("0468")>
		Public Property AllowDragColumn As Boolean
			Get
				Dim result As Boolean
				If Me.Oo_o._oO0o. Is Nothing Then
					result = Me.DataTable.AllowDragColumn
				Else
					result = (Me.Oo_o._oO0o. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.Oo_o._oO0o. = 1
				Else
					Me.Oo_o._oO0o. = 2
				End If
				Me.Ooo0ooOOo.o.()
			End Set
		End Property

		' Token: 0x06002977 RID: 10615 RVA: 0x00119172 File Offset: 0x00117372
		Friend Sub <<EMPTY_NAME>>()
			Me.o_oo.o_. = 0
		End Sub

		' Token: 0x170009DA RID: 2522
		' (get) Token: 0x06002978 RID: 10616 RVA: 0x0011917C File Offset: 0x0011737C
		' (set) Token: 0x06002979 RID: 10617 RVA: 0x001191AF File Offset: 0x001173AF
		<oO0oooo("0469")>
		Public Property AllowFreezeColumn As Boolean
			Get
				Dim result As Boolean
				If Me.o_oo.o_. Is Nothing Then
					result = Me.DataTable.AllowFreezeColumn
				Else
					result = (Me.o_oo.o_. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o_oo.o_. = 1
				Else
					Me.o_oo.o_. = 2
				End If
				Me.Ooo0ooOOo.o.()
			End Set
		End Property

		' Token: 0x0600297A RID: 10618 RVA: 0x001191CA File Offset: 0x001173CA
		Friend Sub <<EMPTY_NAME>>()
			Me.O0O_o0.O_Oo0O0. = 0
		End Sub

		' Token: 0x170009DB RID: 2523
		' (get) Token: 0x0600297B RID: 10619 RVA: 0x001191D4 File Offset: 0x001173D4
		' (set) Token: 0x0600297C RID: 10620 RVA: 0x00119207 File Offset: 0x00117407
		<oO0oooo("0470")>
		Public Property AllowResizeColumn As Boolean
			Get
				Dim result As Boolean
				If Me.O0O_o0.O_Oo0O0. Is Nothing Then
					result = Me.DataTable.AllowResizeColumn
				Else
					result = (Me.O0O_o0.O_Oo0O0. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.O0O_o0.O_Oo0O0. = 1
				Else
					Me.O0O_o0.O_Oo0O0. = 2
				End If
				Me.Ooo0ooOOo.o.()
			End Set
		End Property

		' Token: 0x0600297D RID: 10621 RVA: 0x00119222 File Offset: 0x00117422
		Friend Sub <<EMPTY_NAME>>()
			Me.Oo_.o0__0. = 0
		End Sub

		' Token: 0x170009DC RID: 2524
		' (get) Token: 0x0600297E RID: 10622 RVA: 0x0011922C File Offset: 0x0011742C
		' (set) Token: 0x0600297F RID: 10623 RVA: 0x0011925F File Offset: 0x0011745F
		<oO0oooo("1370")>
		Public Property AllowResizeRow As Boolean
			Get
				Dim result As Boolean
				If Me.Oo_.o0__0. Is Nothing Then
					result = Me.DataTable.AllowResizeRow
				Else
					result = (Me.Oo_.o0__0. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.Oo_.o0__0. = 1
				Else
					Me.Oo_.o0__0. = 2
				End If
				Me.Ooo0ooOOo.o.()
			End Set
		End Property

		' Token: 0x06002980 RID: 10624 RVA: 0x0011927A File Offset: 0x0011747A
		Friend Sub <<EMPTY_NAME>>()
			Me.oO.O0OOO___. = 0
		End Sub

		' Token: 0x170009DD RID: 2525
		' (get) Token: 0x06002981 RID: 10625 RVA: 0x00119284 File Offset: 0x00117484
		' (set) Token: 0x06002982 RID: 10626 RVA: 0x001192C8 File Offset: 0x001174C8
		<oO0oooo("0462")>
		Public Property AllowEdit As Boolean
			Get
				Dim result As Boolean
				If Not OO_00oOO.DataTables.AllowEdit Then
					result = False
				ElseIf Me.oO.O0OOO___. Is Nothing Then
					result = Me.DataTable.AllowEdit
				Else
					result = (Me.oO.O0OOO___. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.oO.O0OOO___. = 1
				Else
					Me.oO.O0OOO___. = 2
				End If
				O_O0OO.OoO_o.oO0o0O.(Me.DataTable.o_0_00_.oo0O0., "TableAllowEditChanged", New Object(-1) {}, True, Me.DataTable.Name, False)
				Me.foxGrid.Rows(0).Invalidate()
				Main.OO_O.o..O.ooO0. = True
			End Set
		End Property

		' Token: 0x06002983 RID: 10627 RVA: 0x00119332 File Offset: 0x00117532
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O._0_0ooO0_o0o. = 0
			Me.Grid.PreserveEditMode = Me.PreserveEditMode
		End Sub

		' Token: 0x170009DE RID: 2526
		' (get) Token: 0x06002984 RID: 10628 RVA: 0x0011934C File Offset: 0x0011754C
		' (set) Token: 0x06002985 RID: 10629 RVA: 0x0011937F File Offset: 0x0011757F
		<oO0oooo("3278")>
		Public Property PreserveEditMode As Boolean
			Get
				Dim result As Boolean
				If Me.O._0_0ooO0_o0o. Is Nothing Then
					result = Me.DataTable.PreserveEditMode
				Else
					result = (Me.O._0_0ooO0_o0o. = 1)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.O._0_0ooO0_o0o. = 1
				Else
					Me.O._0_0ooO0_o0o. = 2
				End If
				Me.Grid.PreserveEditMode = value
			End Set
		End Property

		' Token: 0x06002986 RID: 10630 RVA: 0x001193A0 File Offset: 0x001175A0
		Friend Sub <<EMPTY_NAME>>()
			Me.Oo_00o0_.o00. = 0
		End Sub

		' Token: 0x170009DF RID: 2527
		' (get) Token: 0x06002987 RID: 10631 RVA: 0x001193AC File Offset: 0x001175AC
		' (set) Token: 0x06002988 RID: 10632 RVA: 0x001193E1 File Offset: 0x001175E1
		<oO0oooo("0463")>
		Public Property AllowAddNew As Boolean
			Get
				Dim dataTable As DataTable = Me.DataTable
				Dim result As Boolean
				If Me.Oo_00o0_.o00. Is Nothing Then
					result = dataTable.AllowAddNew
				Else
					result = (Me.Oo_00o0_.o00. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.Oo_00o0_.o00. = 1
					Return
				End If
				Me.Oo_00o0_.o00. = 2
			End Set
		End Property

		' Token: 0x06002989 RID: 10633 RVA: 0x001193F5 File Offset: 0x001175F5
		Friend Sub <<EMPTY_NAME>>()
			Me.o.OO0O0O. = 0
		End Sub

		' Token: 0x170009E0 RID: 2528
		' (get) Token: 0x0600298A RID: 10634 RVA: 0x00119400 File Offset: 0x00117600
		' (set) Token: 0x0600298B RID: 10635 RVA: 0x00119435 File Offset: 0x00117635
		<oO0oooo("0464")>
		Public Property AutoAddNew As Boolean
			Get
				Dim dataTable As DataTable = Me.DataTable
				Dim result As Boolean
				If Me.o.OO0O0O. Is Nothing Then
					result = dataTable.AutoAddNew
				Else
					result = (Me.o.OO0O0O. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o.OO0O0O. = 1
					Return
				End If
				Me.o.OO0O0O. = 2
			End Set
		End Property

		' Token: 0x0600298C RID: 10636 RVA: 0x00119449 File Offset: 0x00117649
		Friend Sub <<EMPTY_NAME>>()
			Me.o_oo___0.0. = 0
		End Sub

		' Token: 0x170009E1 RID: 2529
		' (get) Token: 0x0600298D RID: 10637 RVA: 0x00119454 File Offset: 0x00117654
		' (set) Token: 0x0600298E RID: 10638 RVA: 0x00119489 File Offset: 0x00117689
		<oO0oooo("0465")>
		Public Property AllowDelete As Boolean
			Get
				Dim dataTable As DataTable = Me.DataTable
				Dim result As Boolean
				If Me.o_oo___0.0. Is Nothing Then
					result = dataTable.AllowDelete
				Else
					result = (Me.o_oo___0.0. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.o_oo___0.0. = 1
					Return
				End If
				Me.o_oo___0.0. = 2
			End Set
		End Property

		' Token: 0x0600298F RID: 10639 RVA: 0x0011949D File Offset: 0x0011769D
		Friend Sub <<EMPTY_NAME>>()
			Me.O_0_O0Oo__.O_o. = 0
		End Sub

		' Token: 0x170009E2 RID: 2530
		' (get) Token: 0x06002990 RID: 10640 RVA: 0x001194A8 File Offset: 0x001176A8
		' (set) Token: 0x06002991 RID: 10641 RVA: 0x001194DB File Offset: 0x001176DB
		<oO0oooo("0466")>
		Public Property AllowLockRow As Boolean
			Get
				Dim result As Boolean
				If Me.O_0_O0Oo__.O_o. Is Nothing Then
					result = Me.DataTable.AllowLockRow
				Else
					result = (Me.O_0_O0Oo__.O_o. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.O_0_O0Oo__.O_o. = 1
					Return
				End If
				Me.O_0_O0Oo__.O_o. = 2
			End Set
		End Property

		' Token: 0x06002992 RID: 10642 RVA: 0x001194EF File Offset: 0x001176EF
		Friend Sub <<EMPTY_NAME>>()
			Me.OOo0O._0__0. = 0
		End Sub

		' Token: 0x170009E3 RID: 2531
		' (get) Token: 0x06002993 RID: 10643 RVA: 0x001194F8 File Offset: 0x001176F8
		' (set) Token: 0x06002994 RID: 10644 RVA: 0x0011952B File Offset: 0x0011772B
		<oO0oooo("0467")>
		Public Property AllowUnLockRow As Boolean
			Get
				Dim result As Boolean
				If Me.OOo0O._0__0. Is Nothing Then
					result = Me.DataTable.AllowUnlockRow
				Else
					result = (Me.OOo0O._0__0. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.OOo0O._0__0. = 1
					Return
				End If
				Me.OOo0O._0__0. = 2
			End Set
		End Property

		' Token: 0x06002995 RID: 10645 RVA: 0x0011953F File Offset: 0x0011773F
		Friend Sub <<EMPTY_NAME>>()
			Me.ooo0.O_. = 0
		End Sub

		' Token: 0x170009E4 RID: 2532
		' (get) Token: 0x06002996 RID: 10646 RVA: 0x00119548 File Offset: 0x00117748
		' (set) Token: 0x06002997 RID: 10647 RVA: 0x0011957B File Offset: 0x0011777B
		<oO0oooo("0471")>
		Public Property AllowResizeSingleRow As Boolean
			Get
				Dim result As Boolean
				If Me.ooo0.O_. Is Nothing Then
					result = Me.DataTable.AllowResizeSingleRow
				Else
					result = (Me.ooo0.O_. <> 2)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If value Then
					Me.ooo0.O_. = 1
					Return
				End If
				Me.ooo0.O_. = 2
			End Set
		End Property

		' Token: 0x06002998 RID: 10648 RVA: 0x0011958F File Offset: 0x0011778F
		<oO0oooo("0549")>
		Public Function Focus() As Boolean
			Return Me.foxGrid.Focus()
		End Function

		' Token: 0x06002999 RID: 10649 RVA: 0x0011959C File Offset: 0x0011779C
		<oO0oooo("0550")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function [Select]() As Boolean
			Return Me.Focus()
		End Function

		' Token: 0x170009E5 RID: 2533
		' (get) Token: 0x0600299A RID: 10650 RVA: 0x001195A4 File Offset: 0x001177A4
		<oO0oooo("0458")>
		Public ReadOnly Property Focused As Boolean
			Get
				Return Me.foxGrid.Focused
			End Get
		End Property

		' Token: 0x170009E6 RID: 2534
		' (get) Token: 0x0600299B RID: 10651 RVA: 0x001195B1 File Offset: 0x001177B1
		' (set) Token: 0x0600299C RID: 10652 RVA: 0x001195B9 File Offset: 0x001177B9
		Public Property PrintInfo As PrintInfo
			Get
				Return Me.oO._0ooO_o0_.
			End Get
			Friend Set(value As PrintInfo)
				Me.oO._0ooO_o0_. = value
			End Set
		End Property

		' Token: 0x0600299D RID: 10653 RVA: 0x001195C4 File Offset: 0x001177C4
		Private Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.o.OOoo_o., "", True) > 0 Then
				Me.PrintInfo.PaperSize = Me.PrintInfo.PaperSize
				o_O_o_oOoo__.OOOO_OO._oo.(Me.PrintInfo, Me.o.OOoo_o., vbLf)
				Me.o.OOoo_o. = ""
			End If
		End Sub

		' Token: 0x0600299E RID: 10654 RVA: 0x0011961C File Offset: 0x0011781C
		<oO0oooo("0554")>
		Public Sub Print(Preview As Boolean, ShowDialog As Boolean)
			Me.o.O0___OOo0_oO.()
			If Me.View.Count >= 1 Then
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
				Catch ex As Exception
					Return
				End Try
				If Preview Then
					New o_00OOooo__0_(Me.PrintInfo, False).ooo.0_oO_0.()
					Return
				End If
				Dim printerSettings As PrinterSettings = CType(Me.foxGrid.PrintParameters.PrintDocument.PrinterSettings.Clone(), PrinterSettings)
				If Operators.CompareString(Me.PrintInfo.PrinterName, "", True) > 0 Then
					printerSettings.PrinterName = Me.PrintInfo.PrinterName
				End If
				If Not ShowDialog OrElse New PrintDialog() With { .PrinterSettings = printerSettings }.ShowDialog() <> DialogResult.Cancel Then
					New o_00OOooo__0_(Me.PrintInfo, False).O0o.__.(printerSettings)
				End If
			End If
		End Sub

		' Token: 0x0600299F RID: 10655 RVA: 0x00119710 File Offset: 0x00117910
		<oO0oooo("0555")>
		Public Sub DirectPrint(Preview As Boolean, ShowDialog As Boolean)
			If Not Me.O_O0oo_.OO. Then
				Me.O_O0oo_.OO. = True
				Me.foxGrid.o.O_0o.()
				Try
					Try
						If PrinterSettings.InstalledPrinters.Count = 0 Then
							MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.O_O0oo_.OO. = False
							Return
						End If
					Catch ex As Exception
						Me.O_O0oo_.OO. = False
						Return
					End Try
				Catch ex2 As Exception
					Me.O_O0oo_.OO. = False
					Return
				End Try
				Dim printGridFlags As PrintGridFlags
				If ShowDialog Then
					printGridFlags = printGridFlags Or 8
				End If
				If Me.PrintInfo.DirectFitIntoPage Then
					printGridFlags = printGridFlags Or 1
				End If
				If Me.PrintInfo.DirectFitIntoOnePage Then
					printGridFlags = printGridFlags Or 2
				End If
				If Me.PrintInfo.DirectExtendLastCol Then
					printGridFlags = printGridFlags Or 64
				End If
				If Me.PrintInfo.DirectHighLight Then
					printGridFlags = printGridFlags Or 32
				End If
				Me.foxGrid.PrintParameters.HeaderFont = Me.PrintInfo.DirectPageHeaderFont
				Me.foxGrid.PrintParameters.FooterFont = Me.PrintInfo.DirectPageHeaderFont
				Me.foxGrid.PrintParameters.Header = Me.o.oO__OO_oo_0_.(Me.PrintInfo.DirectPageHeader)
				Me.foxGrid.PrintParameters.Footer = Me.o.oO__OO_oo_0_.(Me.PrintInfo.DirectPageFooter)
				Me.foxGrid.PrintParameters.PrintGridFlags = printGridFlags
				Dim selection As CellRange = Me.foxGrid.Selection
				Try
					If Not Me.PrintInfo.DirectHighLight Then
						OO_00oOO.SystemReady = False
						Me.foxGrid.[Select](-1, -1)
						OO_00oOO.SystemReady = True
					End If
					If Not Preview Then
						Me.foxGrid.PrintGrid(Me.Name)
					Else
						Dim c1PrintPreviewDialog As C1PrintPreviewDialog = New C1PrintPreviewDialog()
						Try
							Me.O.OoOo_. = 0
							AddHandler Me.foxGrid.PrintParameters.PrintDocument.PrintPage, AddressOf Me.Oo_oOo_.O0_.
							Me.O.OoOo_. = New o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
							Me.O.OoOo_..Show()
							Application.DoEvents()
							c1PrintPreviewDialog.PreviewPane.ZoomMode = 0
							c1PrintPreviewDialog.ShowInTaskbar = False
							c1PrintPreviewDialog.Text = "打印预览"
							c1PrintPreviewDialog.Icon = Foxtable.My.Resources.a.O_.o_0oo_000_.()
							c1PrintPreviewDialog.WindowState = FormWindowState.Maximized
							c1PrintPreviewDialog.Document = Me.foxGrid.PrintParameters.PrintDocument
							Me.O.OoOo_..Close()
							If Me.O.OoOo_..Ooo_oo._o.() Then
								Return
							End If
							c1PrintPreviewDialog.ShowDialog()
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "")
						Finally
							c1PrintPreviewDialog.Dispose()
							Me.foxGrid.PrintParameters.PrintDocument.Dispose()
							GC.Collect()
							Me.O.OoOo_..Close()
							Me.O.OoOo_..Dispose()
							Me.O.OoOo_. = Nothing
							RemoveHandler Me.foxGrid.PrintParameters.PrintDocument.PrintPage, AddressOf Me.Oo_oOo_.O0_.
						End Try
					End If
					If Not Me.PrintInfo.DirectHighLight Then
						OO_00oOO.SystemReady = False
						Me.foxGrid.[Select](selection.r1, selection.c1, selection.r2, selection.c2)
						OO_00oOO.SystemReady = True
					End If
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "")
				Finally
					Me.O_O0oo_.OO. = False
					OO_00oOO.SystemReady = True
				End Try
			End If
		End Sub

		' Token: 0x060029A0 RID: 10656 RVA: 0x00119AF4 File Offset: 0x00117CF4
		<oO0oooo("1269")>
		Public Sub OpenView(ViewName As String)
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { Me.DataTable.Name, ViewName, 0 })
			If dataRow IsNot Nothing Then
				Dim tableViewProperty As TableViewProperty = New TableViewProperty(Me)
				o_O_o_oOoo__.OOOO_OO._oo.(tableViewProperty, Conversions.ToString(dataRow("Property")), vbVerticalTab)
				Try
					OO_00oOO.LockBaseMainForm()
					Me.StopRedraw()
					tableViewProperty.Restore()
				Catch ex As Exception
				Finally
					Me.ResumeRedraw()
					OO_00oOO.UnlockBaseMainForm()
				End Try
			End If
		End Sub

		' Token: 0x060029A1 RID: 10657 RVA: 0x00119BAC File Offset: 0x00117DAC
		Public Sub Refresh()
			Me.foxGrid.Invalidate()
		End Sub

		' Token: 0x060029A2 RID: 10658 RVA: 0x00119BBC File Offset: 0x00117DBC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub RefreshChildTables()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.Name.StartsWith(Me.Name + ".") Then
						table.Refresh()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060029A3 RID: 10659 RVA: 0x00119C24 File Offset: 0x00117E24
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SaveExcel(ParamArray args As Object())
			If args.Length = 3 Then
				Dim fileName As String = Conversions.ToString(args(0))
				Dim sheetName As String = Conversions.ToString(args(1))
				If TypeOf args(2)Is Boolean Then
					Me.SaveExcel(fileName, sheetName, Conversions.ToBoolean(args(2)))
					Return
				End If
				If TypeOf args(2)Is Integer Then
					Me.SaveExcel(fileName, sheetName, CType(args(2), SaveExcelFlags))
				End If
			End If
		End Sub

		' Token: 0x060029A4 RID: 10660 RVA: 0x00119C80 File Offset: 0x00117E80
		<oO0oooo("0559")>
		Public Sub SaveExcel(FileName As String, SheetName As String, SelectedRowsOnly As Boolean)
			Me.SaveExcel(FileName, SheetName, New SaveExcelFlags() With { .SelectedOnly = SelectedRowsOnly, .MergedRanges = True })
		End Sub

		' Token: 0x060029A5 RID: 10661 RVA: 0x00119CAC File Offset: 0x00117EAC
		<oO0oooo("1971")>
		Public Sub CreateSheetHeader(XLSSheet As Sheet, Optional StartRow As Integer = 0, Optional StartCol As Integer = 0, Optional VisibleOnly As Boolean = True)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim ooo_O__.0. As XLSheet = XLSSheet.Ooo_O__.0.
				IL_10:
				num2 = 3
				IL_12:
				num2 = 4
				IL_14:
				num2 = 5
				Dim num3 As Integer = Me.foxGrid.Cols.Count - 1
				Dim num4 As Integer
				For i As Integer = 1 To num3
					IL_32:
					num2 = 6
					If Me.foxGrid.Cols(i).Visible OrElse Not VisibleOnly Then
						IL_54:
						num2 = 7
						If Me.foxGrid.Cols(i).Visible Then
							IL_6F:
							num2 = 8
							ooo_O__.0..Columns(StartCol + num4).Width = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Cols(i).WidthDisplay))
						Else
							IL_A4:
							num2 = 10
							ooo_O__.0..Columns(StartCol + num4).Width = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Cols(i).Width))
						End If
						IL_D8:
						num2 = 11
						Dim num5 As Integer = Me.foxGrid.Rows.Fixed - 1
						For j As Integer = 0 To num5
							IL_F4:
							num2 = 12
							ooo_O__.0.(StartRow + j, StartCol + num4).Value = Me.foxGrid.GetDataDisplay(j, i)
							IL_119:
							num2 = 13
						Next
						IL_128:
						num2 = 14
						num4 += 1
					End If
					IL_131:
					num2 = 15
				Next
				IL_143:
				num2 = 16
				Dim xlstyle As XLStyle = New XLStyle(ooo_O__.0..Book)
				IL_153:
				num2 = 17
				xlstyle.AlignHorz = 2
				IL_15E:
				num2 = 18
				xlstyle.AlignVert = 1
				IL_169:
				num2 = 19
				xlstyle.WordWrap = True
				IL_174:
				num2 = 20
				Dim num6 As Integer = StartRow + Me.foxGrid.Rows.Fixed - 1
				For k As Integer = StartRow To num6
					IL_192:
					num2 = 21
					ooo_O__.0..Rows(k).Style = xlstyle
					IL_1A9:
					num2 = 22
				Next
				IL_1B8:
				num2 = 23
				Me.O0o.00oOo0O.(ooo_O__.0., StartRow, StartRow + Me.foxGrid.Rows.Fixed - 1, StartCol, StartCol + num4 - 1)
				IL_1DE:
				GoTo IL_290
				IL_1E3:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_251:
				GoTo IL_285
				IL_253:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_263:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_253
			End Try
			IL_285:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_290:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x170009E7 RID: 2535
		' (get) Token: 0x060029A6 RID: 10662 RVA: 0x00119F70 File Offset: 0x00118170
		Public ReadOnly Property HeaderRows As Integer
			Get
				Return Me.foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x060029A7 RID: 10663 RVA: 0x00119F84 File Offset: 0x00118184
		<oO0oooo("1973")>
		Public Sub CreateReportHeader(RenderTable As RenderTable, Optional VisibleOnly As Boolean = True)
			Dim num As Integer
			Dim num29 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				RenderTable.Rows.Clear()
				IL_14:
				num2 = 3
				RenderTable.Cols.Clear()
				IL_21:
				num2 = 4
				Dim num3 As Integer = Me.foxGrid.Cols.Count - 1
				Dim num4 As Integer
				For i As Integer = 1 To num3
					IL_3F:
					num2 = 5
					If Me.foxGrid.Cols(i).Visible OrElse Not VisibleOnly Then
						IL_60:
						num2 = 6
						RenderTable.Cols(num4).Width = Me.Cols(Me.foxGrid.Cols(i).Name).PrintWidth
						IL_9F:
						num2 = 7
						Dim num5 As Integer = Me.foxGrid.Rows.Fixed - 1
						For j As Integer = 0 To num5
							IL_BA:
							num2 = 8
							RenderTable.Cells(j, num4).Text = Me.foxGrid.GetDataDisplay(j, i)
							IL_DE:
							num2 = 9
						Next
						IL_ED:
						num2 = 10
						num4 += 1
					End If
					IL_F4:
					num2 = 11
				Next
				IL_106:
				num2 = 12
				Dim num6 As Integer = num4 - 1
				For k As Integer = 0 To num6
					IL_116:
					num2 = 13
					Dim num7 As Integer = Me.foxGrid.Rows.Count - 1
					For l As Integer = 0 To num7
						IL_135:
						num2 = 14
						Dim num8 As Integer = l
						IL_13C:
						num2 = 15
						Dim num9 As Integer = k
						IL_143:
						num2 = 16
						Dim num10 As Integer = l
						IL_14A:
						num2 = 17
						Dim num11 As Integer = k
						IL_151:
						num2 = 18
						Dim text As String = RenderTable.Cells(l, k).Text
						IL_16A:
						num2 = 19
						If Operators.CompareString(text, "", True) <> 0 Then
							IL_17F:
							num2 = 21
							For m As Integer = l - 1 To 0 Step -1
								IL_18A:
								num2 = 22
								If Operators.CompareString(RenderTable.Cells(m, k).Text, text, True) <> 0 Then
									Exit For
								End If
								IL_1AB:
								num2 = 23
								num8 = m
								IL_1B2:
								num2 = 26
							Next
							IL_1C0:
							num2 = 27
							Dim num12 As Integer = l + 1
							Dim num13 As Integer = Me.foxGrid.Rows.Count - 1
							For n As Integer = num12 To num13
								IL_1DF:
								num2 = 28
								If Operators.CompareString(RenderTable.Cells(n, k).Text, text, True) <> 0 Then
									Exit For
								End If
								IL_200:
								num2 = 29
								num10 = n
								IL_207:
								num2 = 32
							Next
							IL_216:
							num2 = 33
							Dim flag As Boolean = False
							IL_21C:
							num2 = 34
							For num14 As Integer = k - 1 To 0 Step -1
								IL_227:
								num2 = 35
								flag = False
								IL_22D:
								num2 = 36
								Dim num15 As Integer = num8
								Dim num16 As Integer = num10
								For num17 As Integer = num15 To num16
									IL_23A:
									num2 = 37
									If Operators.CompareString(RenderTable.Cells(num17, num14).Text, text, True) <> 0 Then
										IL_25B:
										num2 = 38
										flag = False
										Exit For
									End If
									IL_263:
									num2 = 40
								Next
								IL_272:
								num2 = 41
								If Not flag Then
									Exit For
								End If
								IL_279:
								num2 = 42
								num9 = num14
								IL_280:
								num2 = 45
							Next
							IL_28E:
							num2 = 46
							Dim num18 As Integer = k + 1
							Dim num19 As Integer = num4 - 1
							For num20 As Integer = num18 To num19
								IL_29E:
								num2 = 47
								flag = True
								IL_2A4:
								num2 = 48
								Dim num21 As Integer = num8
								Dim num22 As Integer = num10
								For num23 As Integer = num21 To num22
									IL_2B1:
									num2 = 49
									If Operators.CompareString(RenderTable.Cells(num23, num20).Text, text, True) <> 0 Then
										IL_2D2:
										num2 = 50
										flag = False
										Exit For
									End If
									IL_2DA:
									num2 = 52
								Next
								IL_2E9:
								num2 = 53
								If Not flag Then
									Exit For
								End If
								IL_2F0:
								num2 = 54
								num11 = num20
								IL_2F7:
								num2 = 57
							Next
							IL_306:
							num2 = 58
							If num8 <> num10 OrElse num9 <> num11 Then
								IL_315:
								num2 = 59
								If num8 = l AndAlso num9 = k Then
									IL_324:
									num2 = 60
									RenderTable.Cells(l, k).SpanRows = num10 - num8 + 1
									IL_342:
									num2 = 61
									RenderTable.Cells(l, k).SpanCols = num11 - num9 + 1
								End If
							End If
						End If
						IL_360:
						num2 = 62
					Next
					IL_372:
					num2 = 63
				Next
				IL_384:
				num2 = 64
				Dim num24 As Integer = Me.foxGrid.Rows.Fixed - 1
				For num25 As Integer = 0 To num24
					IL_3A0:
					num2 = 65
					Dim num26 As Integer = num4 - 1
					For num27 As Integer = 0 To num26
						IL_3AD:
						num2 = 66
						RenderTable.Cells(num25, num27).Style.TextAlignHorz = 1
						IL_3CA:
						num2 = 67
						RenderTable.Cells(num25, num27).Style.TextAlignVert = 1
						IL_3E7:
						num2 = 68
					Next
					IL_3F6:
					num2 = 69
				Next
				IL_405:
				GoTo IL_56F
				IL_40A:
				Dim num28 As Integer = num29 + 1
				num29 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num28)
				IL_530:
				GoTo IL_564
				IL_532:
				num29 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_542:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num29 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_532
			End Try
			IL_564:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_56F:
			If num29 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029A8 RID: 10664 RVA: 0x0011A524 File Offset: 0x00118724
		<oO0oooo("0559")>
		Public Sub SaveExcel(FileName As String, SheetName As String, Optional Flags As SaveExcelFlags = Nothing)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1XLBook As C1XLBook = New C1XLBook()
				IL_0F:
				num2 = 3
				If Not OO_00oOO.FileSys.FileExists(FileName) Then
					GoTo IL_86
				End If
				IL_1E:
				num2 = 4
				c1XLBook.Load(FileName)
				IL_27:
				num2 = 5
				If Not c1XLBook.Sheets.Contains(SheetName) Then
					GoTo IL_74
				End If
				IL_37:
				num2 = 6
				Dim xlsheet As XLSheet = c1XLBook.Sheets(SheetName)
				IL_47:
				num2 = 7
				xlsheet.Rows.Clear()
				IL_55:
				num2 = 8
				xlsheet.Columns.Clear()
				IL_63:
				num2 = 9
				xlsheet.MergedCells.Clear()
				GoTo IL_97
				IL_74:
				num2 = 11
				xlsheet = c1XLBook.Sheets.Add()
				GoTo IL_97
				IL_86:
				num2 = 13
				xlsheet = c1XLBook.Sheets(0)
				IL_97:
				num2 = 14
				xlsheet.Name = SheetName
				IL_A2:
				num2 = 15
				xlsheet.PrintSettings.PrintGridlines = True
				IL_B2:
				num2 = 16
				If Flags IsNot Nothing Then
					GoTo IL_C2
				End If
				IL_B8:
				num2 = 17
				Flags = New SaveExcelFlags()
				IL_C2:
				num2 = 18
				If Not FileName.EndsWith(".xlsx", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_DD
				End If
				IL_D3:
				num2 = 19
				c1XLBook.CompatibilityMode = 1
				IL_DD:
				num2 = 20
				c1XLBook.DefaultFont = Me.foxGrid.Font
				IL_F1:
				num2 = 21
				Dim bitmap As Bitmap = Nothing
				IL_F7:
				num2 = 22
				bitmap = New Bitmap(400, 100)
				IL_108:
				num2 = 23
				Dim graphics As Graphics = Graphics.FromImage(bitmap)
				IL_114:
				num2 = 24
				Dim num3 As Integer = Me.foxGrid.Rows.Count - 1
				Dim num4 As Integer
				For i As Integer = 0 To num3
					IL_133:
					num2 = 25
					xlsheet.Rows(i).Height = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Rows(i).HeightDisplay))
					IL_166:
					num2 = 26
					num4 = 0
					IL_16C:
					num2 = 27
					If Flags.RowNumber Then
						IL_17A:
						num2 = 28
						If i = 0 Then
							IL_181:
							num2 = 29
							xlsheet.Columns(0).Width = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Cols(0).WidthDisplay))
							IL_1B2:
							num2 = 30
							Dim xlstyle As XLStyle = New XLStyle(c1XLBook)
							IL_1BD:
							num2 = 31
							xlstyle.AlignVert = 1
							IL_1C8:
							num2 = 32
							xlstyle.AlignHorz = 2
							IL_1D3:
							num2 = 33
							xlsheet.Columns(0).Style = xlstyle
						Else
							IL_1EC:
							num2 = 35
							If Me.foxGrid.Rows(i).DataIndex >= 0 Then
								IL_209:
								num2 = 36
								xlsheet(i, 0).Value = Me.foxGrid.Rows(i).DataIndex + 1
							End If
						End If
						IL_239:
						num2 = 37
						num4 = 1
					End If
					IL_23F:
					num2 = 38
					If i < Me.foxGrid.Rows.Fixed Then
						IL_256:
						num2 = 39
						Dim xlstyle2 As XLStyle = New XLStyle(c1XLBook)
						IL_261:
						num2 = 40
						xlstyle2.AlignHorz = 2
						IL_26C:
						num2 = 41
						xlstyle2.AlignVert = 1
						IL_277:
						num2 = 42
						xlstyle2.WordWrap = True
						IL_282:
						num2 = 43
						xlsheet.Rows(i).Style = xlstyle2
					End If
					IL_29A:
					num2 = 44
					If Me.foxGrid.Rows(i).IsNode Then
						IL_2B6:
						num2 = 45
						Dim xlstyle3 As XLStyle = New XLStyle(c1XLBook)
						IL_2C1:
						num2 = 46
						xlstyle3.BackColor = Me.foxGrid.GetCellStyleDisplay(i, 1).BackColor
						IL_2DE:
						num2 = 47
						xlsheet.Rows(i).Style = xlstyle3
					End If
					IL_2F6:
					num2 = 48
					Dim num5 As Integer = Me.foxGrid.Cols.Count - 1
					For j As Integer = 1 To num5
						IL_315:
						num2 = 49
						If Me.foxGrid.Cols(j).Visible OrElse Not Flags.VisibleOnly Then
							IL_33C:
							num2 = 50
							If i = 0 Then
								IL_346:
								num2 = 51
								If Me.foxGrid.Cols(j).Visible Then
									IL_362:
									num2 = 52
									xlsheet.Columns(num4).Width = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Cols(j).WidthDisplay))
								Else
									IL_397:
									num2 = 54
									If Me.foxGrid.Cols(j).Width > 0 Then
										IL_3B4:
										num2 = 55
										xlsheet.Columns(num4).Width = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Cols(j).Width))
									Else
										IL_3E9:
										num2 = 57
										xlsheet.Columns(num4).Width = C1XLBook.PixelsToTwips(CDbl(Me.foxGrid.Cols.DefaultSize))
									End If
								End If
								IL_415:
								num2 = 58
								Dim xlstyle4 As XLStyle = New XLStyle(c1XLBook)
								IL_420:
								num2 = 59
								If Me.foxGrid.Cols(j).DataType Is GetType(DateTime) Then
									IL_446:
									num2 = 60
									xlstyle4.Format = XLStyle.FormatDotNetToXL(Me.foxGrid.Cols(j).Format)
								Else
									IL_471:
									num2 = 62
									Dim name As String = Me.foxGrid.Cols(j).Name
									IL_48D:
									num2 = 63
									If Me.Cols(name).IsNumeric() Then
										IL_4A7:
										num2 = 64
										If Me.DataTable.DataCols(name).FixedDecimals Then
											IL_4C6:
											num2 = 65
											If Me.DataTable.DataCols(name).PercentStyle Then
												IL_4E2:
												num2 = 66
												If Me.DataTable.DataCols(name).Decimals >= 2 Then
													IL_4FF:
													num2 = 67
													xlstyle4.Format = "0." + New String("0"c, Me.DataTable.DataCols(name).Decimals - 2)
												Else
													IL_535:
													num2 = 69
													xlstyle4.Format = "0"
												End If
											Else
												IL_546:
												num2 = 71
												xlstyle4.Format = "0." + New String("0"c, Me.DataTable.DataCols(name).Decimals)
											End If
											IL_578:
											num2 = 72
											If Me.DataTable.DataCols(name).PercentStyle Then
												IL_594:
												num2 = 73
												xlstyle4.Format += "%"
											End If
										Else
											IL_5B1:
											num2 = 75
											If Me.DataTable.DataCols(name).PercentStyle Then
												IL_5CD:
												num2 = 76
												xlstyle4.Format = "0.00%"
											End If
										End If
									End If
								End If
								IL_5DC:
								num2 = 77
								Dim textAlign As TextAlignEnum = Me.foxGrid.Cols(j).TextAlign
								If textAlign <> 1 Then
									If textAlign <> 4 Then
										If textAlign = 7 Then
											IL_623:
											num2 = 83
											xlstyle4.AlignHorz = 3
										End If
									Else
										IL_609:
										num2 = 79
										xlstyle4.AlignHorz = 2
									End If
								Else
									IL_616:
									num2 = 81
									xlstyle4.AlignHorz = 1
								End If
								IL_62E:
								num2 = 85
								xlstyle4.AlignVert = 1
								IL_639:
								num2 = 86
								xlsheet.Columns(num4).Style = xlstyle4
							End If
							IL_651:
							num2 = 87
							xlsheet(i, num4).Value = RuntimeHelpers.GetObjectValue(Me.foxGrid.GetData(i, j))
							IL_678:
							num2 = 88
							If(Flags.CellStyle AndAlso Me.DataTable.OO00.oO_. IsNot Nothing) OrElse Me.DataTable.GlobalHandler.DrawCell Then
								IL_6A5:
								num2 = 89
								If i >= Me.foxGrid.Rows.Fixed Then
									IL_6BF:
									num2 = 90
									Dim text As String
									If xlsheet(i, num4).Value Is Nothing Then
										IL_6D4:
										num2 = 91
										text = ""
									Else
										IL_6E0:
										num2 = 93
										text = xlsheet(i, num4).Value.ToString()
									End If
									IL_6FA:
									num2 = 94
									Dim ownerDrawCellEventArgs As OwnerDrawCellEventArgs = New OwnerDrawCellEventArgs(Nothing, graphics, i, j, Nothing, New Rectangle(0, 0, bitmap.Width, bitmap.Height), text, Nothing)
									IL_724:
									num2 = 95
									Dim o_o0OOo_.o0. As O_oOooO_O = Me.O_o0OOo_.o0.
									Dim o_o0OOo_.o0.2 As Object = Me.O_o0OOo_.o0.
									Dim a_ As OwnerDrawCellEventArgs = ownerDrawCellEventArgs
									Dim excuteDrawCell As Boolean = Me.oO._0ooO_o0_..ExcuteDrawCell
									Dim a_2 As Boolean = True
									Dim flag As Boolean = False
									o_o0OOo_.o0..OO_.00oO0Oo.(o_o0OOo_.o0.2, a_, excuteDrawCell, a_2, flag)
									IL_74B:
									num2 = 96
									If Operators.CompareString(ownerDrawCellEventArgs.Text, text, True) <> 0 Then
										IL_75F:
										num2 = 97
										xlsheet(i, num4).Value = ownerDrawCellEventArgs.Text
									End If
									IL_779:
									num2 = 98
									If ownerDrawCellEventArgs.Style IsNot Nothing Then
										IL_785:
										num2 = 99
										Dim xlstyle5 As XLStyle = xlsheet.Columns(num4).Style.Clone()
										IL_7A2:
										num2 = 100
										xlstyle5.BackColor = ownerDrawCellEventArgs.Style.BackColor
										IL_7B8:
										num2 = 101
										xlstyle5.ForeColor = ownerDrawCellEventArgs.Style.ForeColor
										IL_7CE:
										num2 = 102
										xlsheet(i, num4).Style = xlstyle5
									End If
								End If
							End If
							IL_7E3:
							num2 = 103
							If Flags.MergedRanges AndAlso Me.AllowMerge AndAlso i = Me.foxGrid.Rows.Count - 1 Then
								IL_815:
								num2 = 104
								If Me.MergeCols.Contains(Me.foxGrid.Cols(j).Name) Then
									IL_83F:
									num2 = 105
									Dim fixed As Integer = Me.foxGrid.Rows.Fixed
									Dim num6 As Integer = Me.foxGrid.Rows.Count - 1
									For k As Integer = fixed To num6
										IL_86A:
										num2 = 106
										Dim cellRange As CellRange = Me.foxGrid.OO_.00oO0Oo.(k, j, False)
										IL_87F:
										num2 = 107
										If cellRange.r1 = k AndAlso cellRange.r2 > k Then
											IL_898:
											num2 = 108
											xlsheet.MergedCells.Add(k, num4, cellRange.r2 - cellRange.r1 + 1, 1)
										End If
										IL_8BE:
										num2 = 109
									Next
								End If
							End If
							IL_8CD:
							num2 = 110
							num4 += 1
						End If
						IL_8D6:
						num2 = 111
					Next
					IL_8E8:
					num2 = 112
				Next
				IL_8FA:
				num2 = 113
				If Me.foxGrid.Rows.Fixed <= 1 Then
					GoTo IL_963
				End If
				IL_910:
				num2 = 114
				If Not Flags.RowNumber Then
					GoTo IL_940
				End If
				IL_91B:
				num2 = 115
				Me.O0o.00oOo0O.(xlsheet, 0, Me.foxGrid.Rows.Fixed - 1, 1, num4 - 1)
				GoTo IL_963
				IL_940:
				num2 = 117
				Me.O0o.00oOo0O.(xlsheet, 0, Me.foxGrid.Rows.Fixed - 1, 0, num4 - 1)
				IL_963:
				num2 = 118
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
				IL_973:
				num2 = 119
				If OO_00oOO.FileSys.DirectoryExists(parentPath) Then
					GoTo IL_993
				End If
				IL_984:
				num2 = 120
				OO_00oOO.FileSys.CreateDirectory(parentPath)
				IL_993:
				num2 = 121
				If Not FileName.EndsWith(".xlsx", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_9B1
				End If
				IL_9A4:
				num2 = 122
				c1XLBook.Save(FileName, 2)
				GoTo IL_9BC
				IL_9B1:
				num2 = 124
				c1XLBook.Save(FileName, 0)
				IL_9BC:
				GoTo IL_C02
				IL_9C1:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_BC3:
				GoTo IL_BF7
				IL_BC5:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_BD5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_BC5
			End Try
			IL_BF7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C02:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029A9 RID: 10665 RVA: 0x0011B158 File Offset: 0x00119358
		Public Sub SaveHTM(FileName As String)
			Me.o.O0___OOo0_oO.()
			If Me.View.Count >= 1 Then
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
				Catch ex As Exception
					Return
				End Try
				New o_00OOooo__0_(Me.PrintInfo, True).o.OO__0.(FileName)
			End If
		End Sub

		' Token: 0x060029AA RID: 10666 RVA: 0x0011B1D0 File Offset: 0x001193D0
		<oO0oooo("2458")>
		Public Sub SavePDF(FileName As String)
			Me.o.O0___OOo0_oO.()
			If Me.View.Count >= 1 Then
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
				Catch ex As Exception
					Return
				End Try
				New o_00OOooo__0_(Me.PrintInfo, True).oOO_0o_.oOo_o0.(FileName)
			End If
		End Sub

		' Token: 0x060029AB RID: 10667 RVA: 0x0011B248 File Offset: 0x00119448
		Private Sub <<EMPTY_NAME>>(A_0 As XLSheet, A_1 As Integer, A_2 As Integer, A_3 As Integer, A_4 As Integer)
			Dim num As Integer
			Dim num14 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				For i As Integer = A_3 To A_4
					IL_16:
					num2 = 3
					For j As Integer = A_1 To A_2
						IL_23:
						num2 = 4
						Dim num3 As Integer = j
						IL_28:
						num2 = 5
						Dim num4 As Integer = i
						IL_2E:
						num2 = 6
						Dim num5 As Integer = j
						IL_34:
						num2 = 7
						Dim num6 As Integer = i
						IL_3A:
						num2 = 8
						Dim text As String = A_0(j, i).Text
						IL_4D:
						num2 = 9
						For k As Integer = j - 1 To A_1 Step -1
							IL_5B:
							num2 = 10
							Dim text2 As String = A_0(k, i).Text
							IL_6F:
							num2 = 11
							If Operators.CompareString(text, text2, True) <> 0 Then
								Exit For
							End If
							IL_7E:
							num2 = 12
							num3 = k
							IL_84:
							num2 = 15
						Next
						IL_93:
						num2 = 16
						For l As Integer = j + 1 To A_2
							IL_A1:
							num2 = 17
							Dim text2 As String = A_0(l, i).Text
							IL_B5:
							num2 = 18
							If Operators.CompareString(text, text2, True) <> 0 Then
								Exit For
							End If
							IL_C4:
							num2 = 19
							num5 = l
							IL_CB:
							num2 = 22
						Next
						IL_DA:
						num2 = 23
						Dim flag As Boolean = False
						IL_E0:
						num2 = 24
						For m As Integer = i - 1 To A_3 Step -1
							IL_EF:
							num2 = 25
							flag = True
							IL_F5:
							num2 = 26
							Dim num7 As Integer = num3
							Dim num8 As Integer = num5
							For n As Integer = num7 To num8
								IL_101:
								num2 = 27
								Dim text2 As String = A_0(n, m).Text
								IL_115:
								num2 = 28
								If Operators.CompareString(text, text2, True) <> 0 Then
									IL_124:
									num2 = 29
									flag = False
									Exit For
								End If
								IL_12C:
								num2 = 31
							Next
							IL_13B:
							num2 = 32
							If Not flag Then
								Exit For
							End If
							IL_142:
							num2 = 33
							num4 = m
							IL_149:
							num2 = 36
						Next
						IL_158:
						num2 = 37
						For num9 As Integer = i + 1 To A_4
							IL_167:
							num2 = 38
							flag = True
							IL_16D:
							num2 = 39
							Dim num10 As Integer = num3
							Dim num11 As Integer = num5
							For num12 As Integer = num10 To num11
								IL_179:
								num2 = 40
								Dim text2 As String = A_0(num12, num9).Text
								IL_18D:
								num2 = 41
								If Operators.CompareString(text, text2, True) <> 0 Then
									IL_19C:
									num2 = 42
									flag = False
									Exit For
								End If
								IL_1A4:
								num2 = 44
							Next
							IL_1B3:
							num2 = 45
							If Not flag Then
								Exit For
							End If
							IL_1BA:
							num2 = 46
							num6 = num9
							IL_1C1:
							num2 = 49
						Next
						IL_1D0:
						num2 = 50
						If num3 <> num5 OrElse num4 <> num6 Then
							IL_1DE:
							num2 = 51
							If num3 = j AndAlso num4 = i Then
								IL_1EC:
								num2 = 52
								A_0.MergedCells.Add(num3, num4, num5 - num3 + 1, num6 - num4 + 1)
							End If
						End If
						IL_20B:
						num2 = 53
					Next
					IL_21D:
					num2 = 54
				Next
				IL_22F:
				GoTo IL_35D
				IL_234:
				Dim num13 As Integer = num14 + 1
				num14 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num13)
				IL_31E:
				GoTo IL_352
				IL_320:
				num14 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_330:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num14 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_320
			End Try
			IL_352:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_35D:
			If num14 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029AC RID: 10668 RVA: 0x0011B5D8 File Offset: 0x001197D8
		<oO0oooo("0556")>
		Public Sub PrintSetting()
			Me.o.O0___OOo0_oO.()
			Try
				If PrinterSettings.InstalledPrinters.Count = 0 Then
					MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
			Catch ex As Exception
				Return
			End Try
			New o\u3002\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3002\u3002(Me.PrintInfo).ShowDialog()
			OO_00oOO.Vars("SysUpdatePrintInfo") = True
		End Sub

		' Token: 0x060029AD RID: 10669 RVA: 0x0011B654 File Offset: 0x00119854
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Find(ParamArray args As Object()) As Integer
			Dim result As Integer
			If args.Length = 6 Then
				If TypeOf args(2)Is Integer Then
					result = Me.Find(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)), Conversions.ToInteger(args(2)), Conversions.ToBoolean(args(3)), Conversions.ToBoolean(args(4)), Conversions.ToBoolean(args(5)))
				ElseIf TypeOf args(2)Is String Then
					result = Me.Find(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)), Conversions.ToString(args(2)), Conversions.ToBoolean(args(3)), Conversions.ToBoolean(args(4)), Conversions.ToBoolean(args(5)))
				End If
			End If
			Return result
		End Function

		' Token: 0x060029AE RID: 10670 RVA: 0x0011B6F0 File Offset: 0x001198F0
		<oO0oooo("0552")>
		Public Function Find(StrFind As String, RowStart As Integer, Col As Integer, caseSensitive As Boolean, fullMatch As Boolean, Wrap As Boolean) As Integer
			Dim num As Integer = Me.foxGrid.FindRow(StrFind, RowStart + Me.foxGrid.Rows.Fixed, Col + Me.foxGrid.Cols.Fixed, caseSensitive, fullMatch, Wrap)
			Dim result As Integer
			If num > -1 Then
				result = Me.foxGrid.Rows(num).DataIndex
			Else
				result = -1
			End If
			Return result
		End Function

		' Token: 0x060029AF RID: 10671 RVA: 0x0011B754 File Offset: 0x00119954
		<oO0oooo("0552")>
		Public Function Find(StrFind As String, RowStart As Integer, ColName As String, caseSensitive As Boolean, fullMatch As Boolean, Wrap As Boolean) As Integer
			Dim index As Integer = Me.Cols(ColName).Index
			Return Me.Find(StrFind, RowStart, index, caseSensitive, fullMatch, Wrap)
		End Function

		' Token: 0x060029B0 RID: 10672 RVA: 0x0011B784 File Offset: 0x00119984
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function FindRow(ParamArray args As Object()) As Integer
			Dim result As Integer
			Select Case args.Length
				Case 1
					If TypeOf args(0)Is DataRow Then
						result = Me.FindRow(CType(args(0), DataRow))
					Else
						result = Me.FindRow(Conversions.ToString(args(0)))
					End If
				Case 2
					result = Me.FindRow(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)))
				Case 3
					result = Me.FindRow(Conversions.ToString(args(0)), Conversions.ToInteger(args(1)), Conversions.ToBoolean(args(2)))
			End Select
			Return result
		End Function

		' Token: 0x060029B1 RID: 10673 RVA: 0x0011B810 File Offset: 0x00119A10
		<oO0oooo("0553")>
		Public Function FindRow(Expression As String) As Integer
			Return Me.FindRow(Expression, 0, False)
		End Function

		' Token: 0x060029B2 RID: 10674 RVA: 0x0011B81B File Offset: 0x00119A1B
		<oO0oooo("0553")>
		Public Function FindRow(Expression As String, RowStart As Integer) As Integer
			Return Me.FindRow(Expression, RowStart, False)
		End Function

		' Token: 0x060029B3 RID: 10675 RVA: 0x0011B828 File Offset: 0x00119A28
		<oO0oooo("0553")>
		Public Function FindRow(Expression As String, RowStart As Integer, Wrap As Boolean) As Integer
			Dim obj As Object = Me.DataTable.BaseTable
			Dim array As DataRow()
			SyncLock obj
				array = Me.DataTable.BaseTable.[Select](Expression, Me.View.o_o.O0ooOo.().Sort)
			End SyncLock
			If array.Length > 0 Then
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim num2 As Integer = Me.View.o_o.O0ooOo.(array(i))
					If num2 >= RowStart Then
						Return num2
					End If
				Next
				If Wrap Then
					Dim num3 As Integer = array.Length - 1
					For j As Integer = 0 To num3
						Dim num4 As Integer = Me.View.o_o.O0ooOo.(array(j))
						If num4 >= 0 Then
							Return num4
						End If
					Next
				End If
			End If
			Return -1
		End Function

		' Token: 0x060029B4 RID: 10676 RVA: 0x0011B8FC File Offset: 0x00119AFC
		<oO0oooo("0553")>
		Public Function FindRow(dataRow As DataRow) As Integer
			Dim result As Integer
			If dataRow IsNot Nothing Then
				result = Me.View.o_o.O0ooOo.(dataRow.BaseRow)
			Else
				result = -1
			End If
			Return result
		End Function

		' Token: 0x060029B5 RID: 10677 RVA: 0x0011B924 File Offset: 0x00119B24
		<oO0oooo("0557")>
		Public Sub StartEditing()
			Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
			If o_oOooO_O.Row >= o_oOooO_O.Rows.Fixed And o_oOooO_O.Col >= o_oOooO_O.Cols.Fixed Then
				o_oOooO_O.StartEditing()
			End If
		End Sub

		' Token: 0x060029B6 RID: 10678 RVA: 0x0011B970 File Offset: 0x00119B70
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function AddNew(ParamArray args As Object()) As Row
			Dim result As Row
			If args.Length = 0 Then
				result = Me.AddNew()
			Else
				If args.Length = 1 Then
					Dim num As Integer = -1
					If Integer.TryParse(Conversions.ToString(args(0)), num) AndAlso num > 0 Then
						Return Me.AddNew(num)
					End If
				End If
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060029B7 RID: 10679 RVA: 0x0011B9B5 File Offset: 0x00119BB5
		<oO0oooo("0560")>
		Public Function AddNew() As Row
			Return Me.Rows.AddNew(1)
		End Function

		' Token: 0x060029B8 RID: 10680 RVA: 0x0011B9C3 File Offset: 0x00119BC3
		<oO0oooo("0560")>
		Public Function AddNew(Count As Integer) As Row
			Return Me.Rows.AddNew(Count)
		End Function

		' Token: 0x060029B9 RID: 10681 RVA: 0x0011B9D1 File Offset: 0x00119BD1
		<oO0oooo("1981")>
		Public Function InsertNew() As Row
			Return Me.Rows.InsertNew()
		End Function

		' Token: 0x060029BA RID: 10682 RVA: 0x0011B9E0 File Offset: 0x00119BE0
		<oO0oooo("0558")>
		Public Sub FinishEditing()
			Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
			If o_oOooO_O.Editor IsNot Nothing Then
				o_oOooO_O.FinishEditing()
			End If
		End Sub

		' Token: 0x060029BB RID: 10683 RVA: 0x0011BA08 File Offset: 0x00119C08
		Private Sub <<EMPTY_NAME>>(A_0 As Row, A_1 As Row)
			If Operators.CompareString(Me.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., True) = 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) AndAlso Me.DataTable.BaseTable.Columns(O_O0OO.ooO0oO0O.o_O_.).DataType Is GetType(Integer) Then
				Dim prevSlibing As Row = A_1.PrevSlibing
				Dim nextSlibing As Row = A_1.NextSlibing
				If prevSlibing IsNot Nothing OrElse nextSlibing IsNot Nothing Then
					If prevSlibing Is Nothing Then
						Dim nextSlibing2 As Row = nextSlibing.NextSlibing
						If nextSlibing2 Is Nothing Then
							A_1.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = 0
							nextSlibing.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = 1
							Return
						End If
						If Not nextSlibing2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) Then
							Dim num As Integer = Conversions.ToInteger(nextSlibing2(O_O0OO.ooO0oO0O.o_O_.))
							A_1.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num - 2
							nextSlibing.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num - 1
							Return
						End If
						If A_0 IsNot Nothing Then
							Me.OO.0OO000_0__.(A_0.GetChildren(False), A_1)
							Return
						End If
						Me.Oo_o0_o_o.0O_.()
						Return
					ElseIf nextSlibing Is Nothing Then
						Dim prevSlibing2 As Row = prevSlibing.PrevSlibing
						If prevSlibing2 Is Nothing Then
							prevSlibing.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = 0
							A_1.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = 1
							Return
						End If
						If Not prevSlibing2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) Then
							Dim num2 As Integer = Conversions.ToInteger(prevSlibing2(O_O0OO.ooO0oO0O.o_O_.))
							prevSlibing.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num2 + 1
							A_1.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num2 + 2
							Return
						End If
						If A_0 IsNot Nothing Then
							Me.OO.0OO000_0__.(A_0.GetChildren(False), A_1)
							Return
						End If
						Me.Oo_o0_o_o.0O_.()
						Return
					Else
						If Not prevSlibing.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) AndAlso Not A_1.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) AndAlso Not nextSlibing.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) Then
							Dim array As Integer() = New Integer() { Conversions.ToInteger(prevSlibing(O_O0OO.ooO0oO0O.o_O_.)), Conversions.ToInteger(A_1(O_O0OO.ooO0oO0O.o_O_.)), Conversions.ToInteger(nextSlibing(O_O0OO.ooO0oO0O.o_O_.)) }
							Array.Sort(Of Integer)(array)
							If array(0) <> array(1) AndAlso array(0) <> array(2) AndAlso array(1) <> array(2) Then
								prevSlibing.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = array(0)
								A_1.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = array(1)
								nextSlibing.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = array(2)
								Return
							End If
						End If
						If A_0 IsNot Nothing Then
							Me.OO.0OO000_0__.(A_0.GetChildren(False), A_1)
							Return
						End If
						Me.Oo_o0_o_o.0O_.()
					End If
				End If
			End If
		End Sub

		' Token: 0x060029BC RID: 10684 RVA: 0x0011BCDC File Offset: 0x00119EDC
		Private Sub <<EMPTY_NAME>>(A_0 As List(Of Row), A_1 As Row)
			If Operators.CompareString(Me.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., True) = 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) AndAlso Me.DataTable.BaseTable.Columns(O_O0OO.ooO0oO0O.o_O_.).DataType Is GetType(Integer) Then
				If Me.oO_.ooo0o. Then
					A_0.Reverse()
				End If
				Dim num As Integer = 0
				Dim num2 As Integer = A_0.Count - 1
				For i As Integer = 0 To num2
					If A_0(i).BaseDataRow Is A_1.BaseDataRow Then
						num = i
						Exit For
					End If
				Next
				If CDbl(num) <= CDbl(A_0.Count) / 2.0 Then
					If num < A_0.Count - 1 Then
						Dim row As Row = A_0(num + 1)
						If Not row.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) Then
							Dim num3 As Integer = Conversions.ToInteger(row(O_O0OO.ooO0oO0O.o_O_.)) - 1
							For j As Integer = num To 0 Step -1
								A_0(j).BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num3
								num3 -= 1
							Next
							Return
						End If
					End If
				ElseIf CDbl(num) > CDbl(A_0.Count) / 2.0 AndAlso num > 0 Then
					Dim row2 As Row = A_0(num - 1)
					If Not row2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) Then
						Dim num4 As Integer = Conversions.ToInteger(row2(O_O0OO.ooO0oO0O.o_O_.)) + 1
						Dim num5 As Integer = num
						Dim num6 As Integer = A_0.Count - 1
						For k As Integer = num5 To num6
							A_0(k).BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num4
							num4 += 1
						Next
						Return
					End If
				End If
				Dim num7 As Integer = A_0.Count - 1
				For l As Integer = 0 To num7
					A_0(l).BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = l
				Next
			End If
		End Sub

		' Token: 0x060029BD RID: 10685 RVA: 0x0011BED0 File Offset: 0x0011A0D0
		Private Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., True) = 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) AndAlso Me.DataTable.BaseTable.Columns(O_O0OO.ooO0oO0O.o_O_.).DataType Is GetType(Integer) Then
				Try
					For Each row As Row In Me.Rows
						If row.Hierarchy = 0 Then
							Dim num As Integer
							row.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num
							num += 1
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Row)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060029BE RID: 10686 RVA: 0x0011BF98 File Offset: 0x0011A198
		Friend Sub <<EMPTY_NAME>>()
			If Me.GridTreeVisible AndAlso Me.Current IsNot Nothing AndAlso Me.o.0ooOO_0__. IsNot Nothing Then
				Dim row As Row = Me.Current
				If row.Hierarchy > 0 Then
					Dim parent As Row = row.Parent
					If parent IsNot Nothing Then
						Dim parent2 As Row = parent.Parent
						Dim children As List(Of Row) = parent.GetChildren(True)
						Dim children2 As List(Of Row) = row.GetChildren(True)
						children2.Insert(0, row)
						Dim list As List(Of Row) = New List(Of Row)()
						Me.O0o._oo_.(Me.Current.BaseDataRow, True)
						Dim num As Integer = children.Count - 1
						For i As Integer = 0 To num
							If children(i).BaseDataRow Is children2(children2.Count - 1).BaseDataRow Then
								Dim num2 As Integer = i + 1
								Dim num3 As Integer = children.Count - 1
								For j As Integer = num2 To num3
									list.Add(children(j))
								Next
								Exit For
							End If
						Next
						Dim array As Boolean() = New Boolean(children2.Count - 1 + 1 - 1) {}
						Dim array2 As Boolean() = New Boolean(list.Count - 1 + 1 - 1) {}
						Dim array3 As Object() = New Object(children2.Count - 1 + 1 - 1) {}
						Dim array4 As Object() = New Object(list.Count - 1 + 1 - 1) {}
						Dim list2 As List(Of Double) = New List(Of Double)()
						Dim num4 As Integer = Me.Grid.Rows.Fixed + row.Index
						Dim num5 As Integer = num4
						Dim num6 As Integer = children2.Count - 1
						For k As Integer = 0 To num6
							list2.Add(Conversions.ToDouble(children2(k)("System_Sort_Temporary")))
							array(k) = Me.Grid.Rows(num5 + k).Visible
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Grid.GetUserData(num5 + k, Me.Grid.Cols.Fixed - 1))
							If objectValue IsNot Nothing Then
								array3(k) = RuntimeHelpers.GetObjectValue(objectValue)
							End If
						Next
						num5 += children2.Count
						Dim num7 As Integer = list.Count - 1
						For l As Integer = 0 To num7
							list2.Add(Conversions.ToDouble(list(l)("System_Sort_Temporary")))
							array2(l) = Me.Grid.Rows(num5 + l).Visible
							Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Me.Grid.GetUserData(num5 + l, Me.Grid.Cols.Fixed - 1))
							If objectValue2 IsNot Nothing Then
								array4(l) = RuntimeHelpers.GetObjectValue(objectValue2)
							End If
						Next
						Dim list3 As List(Of DataRow) = New List(Of DataRow)()
						Dim list4 As List(Of DataRow) = New List(Of DataRow)()
						Try
							For Each row2 As Row In list
								list3.Add(row2.DataRow.BaseRow)
							Next
						Finally
							Dim enumerator As List(Of Row).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						Try
							For Each row3 As Row In children2
								list3.Add(row3.DataRow.BaseRow)
								list4.Add(row3.DataRow.BaseRow)
							Next
						Finally
							Dim enumerator2 As List(Of Row).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
						Me.StopRedraw()
						OO_00oOO.SystemReady = False
						Dim num8 As Integer = list3.Count - 1
						For m As Integer = 0 To num8
							list3(m)("System_Sort_Temporary") = list2(m)
						Next
						num5 = num4
						Dim num9 As Integer = list.Count - 1
						For n As Integer = 0 To num9
							Me.Grid.Rows(num5 + n).Visible = array2(n)
							If array4(n) IsNot Nothing Then
								Me.Grid.SetUserData(num5 + n, Me.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array4(n)))
							End If
						Next
						num5 += list.Count
						Dim num10 As Integer = children2.Count - 1
						For num11 As Integer = 0 To num10
							Me.Grid.Rows(num5 + num11).Visible = array(num11)
							If array3(num11) IsNot Nothing Then
								Me.Grid.SetUserData(num5 + num11, Me.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array3(num11)))
							End If
						Next
						If Operators.CompareString(Conversions.ToString(Me.o.0ooOO_0__..O_OOO.0o.), vbNullChar, True) > 0 Then
							Conversions.ToString(Me.o.0ooOO_0__..O_OOO.0o.)
						End If
						If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
							If parent2 IsNot Nothing Then
								list4(0)(Me.o.0ooOO_0__..O_OOO.0o.) = RuntimeHelpers.GetObjectValue(parent(Me.o.0ooOO_0__..O_OOO.0o.))
							ElseIf Not parent.get_IsNull(Me.o.0ooOO_0__..O_OOO.0o.) Then
								list4(0)(Me.o.0ooOO_0__..O_OOO.0o.) = RuntimeHelpers.GetObjectValue(parent(Me.o.0ooOO_0__..O_OOO.0o.))
							Else
								list4(0)(Me.o.0ooOO_0__..O_OOO.0o.) = RuntimeHelpers.GetObjectValue(list4(0)(Me.o.0ooOO_0__..OO._o0_o_OO0O.))
							End If
						Else
							Dim text As String = Conversions.ToString(row(Me.o.0ooOO_0__..OOOO._.))
							Dim str As String
							If parent2 IsNot Nothing Then
								str = Me.o.0ooOO_0__..O0____o.o.(parent2, row)
							Else
								str = Me.o.0ooOO_0__..O0____o.o.(Me)
							End If
							Try
								For Each dataRow As DataRow In list4
									Dim text2 As String = Conversions.ToString(dataRow(Me.o.0ooOO_0__..OOOO._.))
									If text2.Length >= text.Length Then
										text2 = str + text2.Substring(text.Length)
									End If
									dataRow(Me.o.0ooOO_0__..OOOO._.) = text2
								Next
							Finally
								Dim enumerator3 As List(Of DataRow).Enumerator
								CType(enumerator3, IDisposable).Dispose()
							End Try
						End If
						Try
							For Each dataRow2 As DataRow In list4
								dataRow2("sys_Hierarchy_Level") = Conversions.ToInteger(dataRow2("sys_Hierarchy_Level")) - 1
							Next
						Finally
							Dim enumerator4 As List(Of DataRow).Enumerator
							CType(enumerator4, IDisposable).Dispose()
						End Try
						OO_00oOO.SystemReady = True
						If Me.Current.BaseDataRow IsNot list4(0) Then
							Me.Position = Me.FindRow(New DataRow(list4(0)))
						End If
						If Me.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) Then
							Me.Current.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = DBNull.Value
						End If
						Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
						Me.ResumeRedraw()
					End If
				End If
			End If
		End Sub

		' Token: 0x060029BF RID: 10687 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
		Friend Sub <<EMPTY_NAME>>()
			If Me.GridTreeVisible AndAlso Me.Current IsNot Nothing AndAlso Me.o.0ooOO_0__. IsNot Nothing AndAlso Me.Position > 0 Then
				Dim row As Row = Me.Current
				Dim hierarchy As Integer = row.Hierarchy
				Dim prevSlibing As Row = row.PrevSlibing
				If prevSlibing IsNot Nothing Then
					Me.StopRedraw()
					OO_00oOO.SystemReady = False
					prevSlibing.Collapsed = False
					If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
						row(Me.o.0ooOO_0__..O_OOO.0o.) = RuntimeHelpers.GetObjectValue(prevSlibing(Me.o.0ooOO_0__..OO._o0_o_OO0O.))
						Dim num As Integer = Me.Position
						Dim num2 As Integer = Me.Rows.Count - 1
						For i As Integer = num To num2
							If i > Me.Position AndAlso Me.Rows(i).Hierarchy <= hierarchy Then
								Exit For
							End If
							Me.Rows(i).BaseDataRow("sys_Hierarchy_Level") = Conversions.ToInteger(Me.Rows(i).BaseDataRow("sys_Hierarchy_Level")) + 1
						Next
					Else
						If Operators.CompareString(Conversions.ToString(Me.o.0ooOO_0__..O_OOO.0o.), vbNullChar, True) > 0 Then
							Conversions.ToString(Me.o.0ooOO_0__..O_OOO.0o.)
						End If
						Dim text As String = Conversions.ToString(row(Me.o.0ooOO_0__..OOOO._.))
						Dim str As String = Me.o.0ooOO_0__..O0____o.o.(prevSlibing, row)
						Dim num3 As Integer = Me.Position
						Dim num4 As Integer = Me.Rows.Count - 1
						Dim num5 As Integer = num3
						While num5 <= num4 AndAlso (num5 <= Me.Position OrElse Me.Rows(num5).Hierarchy > hierarchy)
							Dim text2 As String = Me.Rows(num5)(Me.o.0ooOO_0__..OOOO._.).ToString()
							If text2.Length >= text.Length Then
								text2 = str + text2.Substring(text.Length)
							End If
							Me.Rows(num5).BaseDataRow(Me.o.0ooOO_0__..OOOO._.) = text2
							Me.Rows(num5).BaseDataRow("sys_Hierarchy_Level") = Conversions.ToInteger(Me.Rows(num5)("sys_Hierarchy_Level")) + 1
							num5 += 1
						End While
					End If
					OO_00oOO.SystemReady = True
					Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
					If Me.Current.Parent IsNot Nothing Then
						Me.o0O_o0.oOO.(Me.Current.BaseDataRow)
					End If
					Me.ResumeRedraw()
				End If
			End If
		End Sub

		' Token: 0x060029C0 RID: 10688 RVA: 0x0011C99C File Offset: 0x0011AB9C
		Friend Sub <<EMPTY_NAME>>()
			If Me.GridTreeVisible AndAlso Me.Current IsNot Nothing AndAlso Me.Position < Me.Rows.Count - 1 Then
				Dim row As Row = Me.Current
				Dim dataRow As DataRow = row.DataRow
				Me.O0o.00oOo0O.(row)
				If Me.Current.BaseDataRow IsNot dataRow.BaseRow Then
					Me.Position = Me.FindRow(dataRow)
				End If
				Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
			End If
		End Sub

		' Token: 0x060029C1 RID: 10689 RVA: 0x0011CA1C File Offset: 0x0011AC1C
		Friend Sub <<EMPTY_NAME>>()
			If Me.GridTreeVisible AndAlso Me.Current IsNot Nothing AndAlso Me.Position > 0 Then
				Dim row As Row = Me.Current
				Dim dataRow As DataRow = row.DataRow
				Dim prevSlibing As Row = row.PrevSlibing
				If prevSlibing IsNot Nothing Then
					Me.O0o.00oOo0O.(prevSlibing)
					If Me.Current.BaseDataRow IsNot dataRow.BaseRow Then
						Me.Position = Me.FindRow(dataRow)
					End If
					Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
				End If
			End If
		End Sub

		' Token: 0x060029C2 RID: 10690 RVA: 0x0011CA98 File Offset: 0x0011AC98
		Private Sub <<EMPTY_NAME>>(A_0 As Row)
			Dim nextSlibing As Row = A_0.NextSlibing
			If nextSlibing IsNot Nothing Then
				Dim children As List(Of Row) = A_0.GetChildren(True)
				Dim children2 As List(Of Row) = nextSlibing.GetChildren(True)
				children.Insert(0, A_0)
				children2.Insert(0, nextSlibing)
				Dim array As Boolean() = New Boolean(children.Count - 1 + 1 - 1) {}
				Dim array2 As Boolean() = New Boolean(children2.Count - 1 + 1 - 1) {}
				Dim array3 As Object() = New Object(children.Count - 1 + 1 - 1) {}
				Dim array4 As Object() = New Object(children2.Count - 1 + 1 - 1) {}
				Dim list As List(Of Double) = New List(Of Double)()
				Dim num As Integer = Me.Grid.Rows.Fixed + A_0.Index
				Dim num2 As Integer = num
				Dim num3 As Integer = children.Count - 1
				For i As Integer = 0 To num3
					list.Add(Conversions.ToDouble(children(i)("System_Sort_Temporary")))
					array(i) = Me.Grid.Rows(num2 + i).Visible
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Grid.GetUserData(num2 + i, Me.Grid.Cols.Fixed - 1))
					If objectValue IsNot Nothing Then
						array3(i) = RuntimeHelpers.GetObjectValue(objectValue)
					End If
				Next
				num2 += children.Count
				Dim num4 As Integer = children2.Count - 1
				For j As Integer = 0 To num4
					list.Add(Conversions.ToDouble(children2(j)("System_Sort_Temporary")))
					array2(j) = Me.Grid.Rows(num2 + j).Visible
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Me.Grid.GetUserData(num2 + j, Me.Grid.Cols.Fixed - 1))
					If objectValue2 IsNot Nothing Then
						array4(j) = RuntimeHelpers.GetObjectValue(objectValue2)
					End If
				Next
				Dim list2 As List(Of DataRow) = New List(Of DataRow)()
				Try
					For Each row As Row In children2
						list2.Add(row.DataRow.BaseRow)
					Next
				Finally
					Dim enumerator As List(Of Row).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Try
					For Each row2 As Row In children
						list2.Add(row2.DataRow.BaseRow)
					Next
				Finally
					Dim enumerator2 As List(Of Row).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				Me.StopRedraw()
				OO_00oOO.SystemReady = False
				Dim num5 As Integer = list2.Count - 1
				For k As Integer = 0 To num5
					list2(k)("System_Sort_Temporary") = list(k)
				Next
				num2 = num
				Dim num6 As Integer = children2.Count - 1
				For l As Integer = 0 To num6
					Me.Grid.Rows(num2 + l).Visible = array2(l)
					If array4(l) IsNot Nothing Then
						Me.Grid.SetUserData(num2 + l, Me.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array4(l)))
					End If
				Next
				num2 += children2.Count
				Dim num7 As Integer = children.Count - 1
				For m As Integer = 0 To num7
					Me.Grid.Rows(num2 + m).Visible = array(m)
					If array3(m) IsNot Nothing Then
						Me.Grid.SetUserData(num2 + m, Me.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array3(m)))
					End If
				Next
				OO_00oOO.SystemReady = True
				Me.ResumeRedraw()
			End If
		End Sub

		' Token: 0x060029C3 RID: 10691 RVA: 0x0011CE4C File Offset: 0x0011B04C
		Friend Function <<EMPTY_NAME>>() As Row
			Dim result As Row
			If Not Me.GridTreeVisible Then
				result = Nothing
			Else
				Dim row As Row = Me.Current
				If row Is Nothing Then
					row = Me.AddNew()
					row.DataRow.BaseRow("sys_Hierarchy_Level") = 0
					row.DataRow.BaseRow("System_Sort_Temporary") = 0
					If Me.o.0ooOO_0__. IsNot Nothing Then
						If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
							Dim value As String = Me.o.0ooOO_0__..o0Oo.0_Oo0__O.(Me)
							row(Me.o.0ooOO_0__..O_OOO.0o.) = value
							row(Me.o.0ooOO_0__..OO._o0_o_OO0O.) = value
						Else
							row(Me.o.0ooOO_0__..OOOO._.) = Me.o.0ooOO_0__..O0____o.o.(Me)
						End If
					End If
					result = row
				Else
					Me.StopRedraw()
					Dim baseRow As DataRow = row.DataRow.BaseRow
					Dim num As Integer = 0
					If Not baseRow.IsNull("sys_Hierarchy_Level") Then
						num = Conversions.ToInteger(baseRow("sys_Hierarchy_Level"))
					End If
					Dim num2 As Double = -1.0
					Dim parent As Row = row.Parent
					Dim text As String = ""
					Dim value2 As String = ""
					If Me.o.0ooOO_0__. IsNot Nothing Then
						If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
							If num > 0 Then
								text = Conversions.ToString(baseRow(Me.o.0ooOO_0__..O_OOO.0o.))
								value2 = Me.o.0ooOO_0__..o0o0OOO.OO0o.(parent)
							Else
								text = Me.o.0ooOO_0__..o0Oo.0_Oo0__O.(Me)
								value2 = text
							End If
						ElseIf parent IsNot Nothing Then
							text = Me.o.0ooOO_0__..O0____o.o.(parent, Nothing)
						Else
							text = Me.o.0ooOO_0__..O0____o.o.(Me)
						End If
					End If
					If parent Is Nothing OrElse Me.Position = Me.Rows.Count - 1 Then
						num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(Me.Rows.Count - 1)("System_Sort_Temporary"))) + 1.0
					Else
						Dim num3 As Integer = Me.Position
						Dim num4 As Integer = Me.Rows.Count - 1
						For i As Integer = num3 To num4
							If Conversions.ToInteger(Me.Rows(i)("sys_Hierarchy_Level")) < num Then
								num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(i - 1)("System_Sort_Temporary"))) + (Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(i)("System_Sort_Temporary"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(i - 1)("System_Sort_Temporary")))) * 0.2
								Exit For
							End If
						Next
						If num2 = -1.0 Then
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(Me.Rows.Count - 1)("System_Sort_Temporary"))) + 1.0
						End If
					End If
					Dim dataRow As DataRow = Me.DataTable.AddNew(1)
					If dataRow Is Nothing Then
						Me.ResumeRedraw()
						result = Nothing
					Else
						If Me.IsChild Then
							Dim dataRelation As DataRelation = Me.View.O0O_0_0__.0O.()
							Dim num5 As Integer = dataRelation.ChildColumns.Length - 1
							For j As Integer = 0 To num5
								dataRow(dataRelation.ChildColumns(j).ColumnName) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row(dataRelation.ParentColumns(j).ColumnName))
							Next
						End If
						dataRow.BaseRow("sys_Hierarchy_Level") = num
						dataRow.BaseRow("System_Sort_Temporary") = num2
						If Operators.CompareString(text, "", True) > 0 Then
							If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
								dataRow(Me.o.0ooOO_0__..O_OOO.0o.) = text
								dataRow(Me.o.0ooOO_0__..OO._o0_o_OO0O.) = value2
							Else
								dataRow(Me.o.0ooOO_0__..OOOO._.) = text
							End If
						End If
						Me.Position = Me.FindRow(dataRow)
						If Me.Current IsNot Nothing Then
							Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
						End If
						Me.ResumeRedraw()
						result = Me.Current
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060029C4 RID: 10692 RVA: 0x0011D2CC File Offset: 0x0011B4CC
		Friend Sub <<EMPTY_NAME>>()
			If Me.GridTreeVisible AndAlso Me.o.0ooOO_0__. IsNot Nothing AndAlso Me.Current IsNot Nothing Then
				Dim row As Row = Me.Current
				Dim row2 As Row = Me.O____o.0.()
				Try
					For Each col As Col In Me.Cols
						If Operators.CompareString(col.Name, Me.o.0ooOO_0__..O_OOO.0o., True) <> 0 AndAlso Operators.CompareString(col.Name, Me.o.0ooOO_0__..OO._o0_o_OO0O., True) <> 0 AndAlso Operators.CompareString(col.Name, Me.o.0ooOO_0__..OOOO._., True) <> 0 AndAlso Operators.CompareString(col.DataCol.BaseColumn.Expression, "", True) <= 0 Then
							row2(col.Name) = RuntimeHelpers.GetObjectValue(row(col.Name))
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Col)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060029C5 RID: 10693 RVA: 0x0011D3D0 File Offset: 0x0011B5D0
		Friend Sub <<EMPTY_NAME>>()
			If Me.foxGrid.OO.o_o00o.() AndAlso Me.o.0ooOO_0__. IsNot Nothing AndAlso Me.Current IsNot Nothing Then
				Dim row As Row = Me.Current
				Dim row2 As Row = Me.O_.o__ooo.(False)
				Try
					For Each col As Col In Me.Cols
						If Operators.CompareString(col.DataCol.BaseColumn.Expression, "", True) <= 0 Then
							row2(col.Name) = RuntimeHelpers.GetObjectValue(row(col.Name))
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Col)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060029C6 RID: 10694 RVA: 0x0011D480 File Offset: 0x0011B680
		Friend Function <<EMPTY_NAME>>() As Row
			Dim result As Row
			If Not Me.GridTreeVisible Then
				result = Nothing
			Else
				Dim row As Row = Me.Current
				If row Is Nothing Then
					result = Me.O____o.0.()
				Else
					Me.StopRedraw()
					Dim baseRow As DataRow = row.DataRow.BaseRow
					If Not baseRow.IsNull("sys_Hierarchy_Level") Then
						Dim num As Integer = Conversions.ToInteger(baseRow("sys_Hierarchy_Level"))
						Dim parent As Row = row.Parent
						Dim text As String = ""
						Dim value As String = ""
						If Me.o.0ooOO_0__. IsNot Nothing Then
							If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
								If num > 0 Then
									text = Conversions.ToString(baseRow(Me.o.0ooOO_0__..O_OOO.0o.))
									value = Me.o.0ooOO_0__..o0o0OOO.OO0o.(parent)
								Else
									text = Me.o.0ooOO_0__..o0Oo.0_Oo0__O.(Me)
									value = text
								End If
							ElseIf parent IsNot Nothing Then
								text = Me.o.0ooOO_0__..O0____o.o.(parent, Nothing)
							Else
								text = Me.o.0ooOO_0__..O0____o.o.(Me)
							End If
						End If
						Dim num2 As Double
						If Me.Position = 0 Then
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow("System_Sort_Temporary"))) - 1.0
						Else
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(Me.Position - 1)("System_Sort_Temporary"))) + (Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow("System_Sort_Temporary"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(Me.Position - 1)("System_Sort_Temporary")))) * 0.8
						End If
						Dim scrollPosition As Point = Me.foxGrid.ScrollPosition
						Dim dataRow As DataRow = Me.DataTable.AddNew(1)
						If Me.IsChild Then
							Dim dataRelation As DataRelation = Me.View.O0O_0_0__.0O.()
							Dim num3 As Integer = dataRelation.ChildColumns.Length - 1
							For i As Integer = 0 To num3
								dataRow(dataRelation.ChildColumns(i).ColumnName) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row(dataRelation.ParentColumns(i).ColumnName))
							Next
						End If
						dataRow.BaseRow("sys_Hierarchy_Level") = num
						dataRow.BaseRow("System_Sort_Temporary") = num2
						If Operators.CompareString(text, "", True) > 0 Then
							If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
								dataRow(Me.o.0ooOO_0__..O_OOO.0o.) = text
								dataRow(Me.o.0ooOO_0__..OO._o0_o_OO0O.) = value
							Else
								dataRow(Me.o.0ooOO_0__..OOOO._.) = text
							End If
						End If
						Me.Position = Me.FindRow(dataRow)
						If Me.Current IsNot Nothing Then
							Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
						End If
						Me.foxGrid.ScrollPosition = scrollPosition
						Me.ResumeRedraw()
						result = Me.Current
					Else
						Me.ResumeRedraw()
						result = Nothing
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060029C7 RID: 10695 RVA: 0x0011D79C File Offset: 0x0011B99C
		Friend Function <<EMPTY_NAME>>() As Row
			Dim result As Row
			If Not Me.GridTreeVisible Then
				result = Nothing
			Else
				Dim row As Row = Me.Current
				If row Is Nothing Then
					result = Me.O____o.0.()
				Else
					Me.StopRedraw()
					Dim flag As Boolean
					If Me.Position = Me.Rows.Count - 1 Then
						flag = True
					ElseIf row.Collapsed Then
						row.Collapsed = False
					End If
					Dim text As String = ""
					Dim value As String = ""
					If Me.o.0ooOO_0__. IsNot Nothing Then
						If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
							text = Conversions.ToString(row(Me.o.0ooOO_0__..OO._o0_o_OO0O.))
							value = Me.o.0ooOO_0__..o0o0OOO.OO0o.(row)
						Else
							text = Me.o.0ooOO_0__..O0____o.o.(row, Nothing)
						End If
					End If
					Dim baseRow As DataRow = row.DataRow.BaseRow
					If Not baseRow.IsNull("sys_Hierarchy_Level") Then
						Dim num As Integer = Conversions.ToInteger(baseRow("sys_Hierarchy_Level"))
						Dim num2 As Double = -1.0
						If Me.Position < Me.Rows.Count - 1 Then
							If Conversions.ToInteger(Me.Rows(Me.Position + 1)("sys_Hierarchy_Level")) = num + 1 Then
								Dim num3 As Integer = Me.Position + 1
								Dim num4 As Integer = Me.Rows.Count - 1
								For i As Integer = num3 To num4
									If Conversions.ToInteger(Me.Rows(i)("sys_Hierarchy_Level")) <= num Then
										num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(i - 1)("System_Sort_Temporary"))) + (Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(i)("System_Sort_Temporary"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(i - 1)("System_Sort_Temporary")))) * 0.2
										Exit For
									End If
								Next
								If num2 = -1.0 Then
									num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(Me.Rows.Count - 1)("System_Sort_Temporary"))) + 1.0
								End If
							Else
								num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow("System_Sort_Temporary"))) + (Conversion.Val(RuntimeHelpers.GetObjectValue(Me.Rows(Me.Position + 1)("System_Sort_Temporary"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow("System_Sort_Temporary")))) * 0.2
							End If
						Else
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow("System_Sort_Temporary"))) + 1.0
						End If
						Dim dataRow As DataRow = Me.DataTable.AddNew(1)
						If Me.IsChild Then
							Dim dataRelation As DataRelation = Me.View.O0O_0_0__.0O.()
							Dim num5 As Integer = dataRelation.ChildColumns.Length - 1
							For j As Integer = 0 To num5
								dataRow(dataRelation.ChildColumns(j).ColumnName) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row(dataRelation.ParentColumns(j).ColumnName))
							Next
						End If
						dataRow.BaseRow("sys_Hierarchy_Level") = num + 1
						dataRow.BaseRow("System_Sort_Temporary") = num2
						If Operators.CompareString(text, "", True) > 0 Then
							If Operators.CompareString(Me.o.0ooOO_0__..O_OOO.0o., "", True) > 0 Then
								dataRow(Me.o.0ooOO_0__..O_OOO.0o.) = text
								dataRow(Me.o.0ooOO_0__..OO._o0_o_OO0O.) = value
							Else
								dataRow(Me.o.0ooOO_0__..OOOO._.) = text
							End If
						End If
						If flag Then
							row.Collapsed = False
						End If
						Me.Position = Me.FindRow(dataRow)
						If Me.Current IsNot Nothing Then
							Me.OO.0OO000_0__.(Me.Current.Parent, Me.Current)
						End If
						Me.ResumeRedraw()
						result = Me.Current
					Else
						Me.ResumeRedraw()
						result = Nothing
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x060029C8 RID: 10696 RVA: 0x0011DBE4 File Offset: 0x0011BDE4
		Friend Function <<EMPTY_NAME>>(A_0 As Boolean) As Row
			Dim result As Row
			If Me.foxGrid.OO.o_o00o.() AndAlso Me.o.0ooOO_0__. IsNot Nothing Then
				Dim num As Integer = Me.foxGrid.Row
				While Me.foxGrid.Rows(num).DataIndex = -1
					If Me.foxGrid.Rows(num).IsNode Then
						Me.foxGrid.Rows(num).Node.Expanded = True
					End If
					If num >= Me.foxGrid.Rows.Count - 1 Then
						Exit While
					End If
					num += 1
				End While
				If Me.foxGrid.Rows(num).DataIndex = -1 Then
					result = Nothing
				Else
					Dim row As Row = Me.Rows(Me.foxGrid.Rows(num).DataIndex)
					Dim row2 As Row = Nothing
					If Not A_0 Then
						Dim num2 As Integer = num + 1
						Dim num3 As Integer = Me.foxGrid.Rows.Count - 1
						Dim num4 As Integer = num2
						While num4 <= num3 AndAlso Me.foxGrid.Rows(num4).DataIndex <> -1
							row = Me.Rows(Me.foxGrid.Rows(num4).DataIndex)
							num4 += 1
						End While
					End If
					If row.Index > 0 Then
						row2 = Me.Rows(row.Index - 1)
					End If
					Dim num5 As Double = Conversions.ToDouble(row("System_Sort_Temporary"))
					Dim num6 As Double
					If row.Index = 0 Then
						num6 = num5 - 1.0
					ElseIf A_0 Then
						num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(row2("System_Sort_Temporary"))) + (Conversion.Val(RuntimeHelpers.GetObjectValue(row("System_Sort_Temporary"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(row2("System_Sort_Temporary")))) * 0.8
					Else
						num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(row2("System_Sort_Temporary"))) + (Conversion.Val(RuntimeHelpers.GetObjectValue(row("System_Sort_Temporary"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(row2("System_Sort_Temporary")))) * 0.2
					End If
					Me.StopRedraw()
					Dim scrollPosition As Point = Me.foxGrid.ScrollPosition
					Dim dataRow As DataRow = Me.DataTable.AddNew(1)
					If Me.IsChild Then
						Dim dataRelation As DataRelation = Me.View.O0O_0_0__.0O.()
						Dim num7 As Integer = dataRelation.ChildColumns.Length - 1
						For i As Integer = 0 To num7
							dataRow(dataRelation.ChildColumns(i).ColumnName) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row(dataRelation.ParentColumns(i).ColumnName))
						Next
					End If
					If A_0 Then
						dataRow.BaseRow("System_Sort_Temporary") = num6
					Else
						dataRow.BaseRow("System_Sort_Temporary") = num6
						row.BaseDataRow("System_Sort_Temporary") = num6
						dataRow.BaseRow("System_Sort_Temporary") = num5
					End If
					For Each columnName As String In Me.o.0ooOO_0__..O_OOO.0o.
						dataRow(columnName) = RuntimeHelpers.GetObjectValue(row(columnName))
					Next
					Me.Position = Me.FindRow(dataRow)
					Me.foxGrid.ScrollPosition = scrollPosition
					If Operators.CompareString(Me.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., True) = 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) AndAlso Me.DataTable.BaseTable.Columns(O_O0OO.ooO0oO0O.o_O_.).DataType Is GetType(Integer) Then
						Me.OO.0OO000_0__.(Me.foxGrid.Row)
					End If
					Me.ResumeRedraw()
					result = Me.Current
				End If
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060029C9 RID: 10697 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Operators.CompareString(A_0, Me.Name, True) <> 0 Then
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "[" + A_0 + "]", "" })
				If dataRow IsNot Nothing Then
					dataRow("Table") = "[" + Me.Name + "]"
				End If
			End If
			Dim o.OoOo_. As Table.oO00_O_O = Me.O.OoOo_.
			If o.OoOo_. IsNot Nothing Then
				o.OoOo_.()
			End If
		End Sub

		' Token: 0x060029CA RID: 10698 RVA: 0x0011E077 File Offset: 0x0011C277
		Friend Sub <<EMPTY_NAME>>()
			Me.oo0OO0Ooo._.(False)
		End Sub

		' Token: 0x060029CB RID: 10699 RVA: 0x0011E080 File Offset: 0x0011C280
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Me.NeedSaveSetting AndAlso Me.TableType Is Nothing AndAlso Not Me.View.O0O.o__0.() Then
				Dim a_ As TableProperty = New TableProperty(Me)
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "[" + Me.Name + "]", "" })
				If dataRow Is Nothing Then
					dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).NewRow()
					dataRow("Table") = "[" + Me.Name + "]"
					dataRow("Column") = ""
					O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Add(dataRow)
				End If
				dataRow("Config") = o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbVerticalTab, False)
				Me.NeedSaveSetting = False
				If A_0 Then
					Oo00.O0Oo_O.0O_0O.(dataRow)
				End If
			End If
		End Sub

		' Token: 0x060029CC RID: 10700 RVA: 0x0011E190 File Offset: 0x0011C390
		Friend Function <<EMPTY_NAME>>(A_0 As Boolean) As TableProperty
			Dim tableProperty As TableProperty = New TableProperty(Me)
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "[" + Me.Name + "]", "" })
			If dataRow IsNot Nothing Then
				o_O_o_oOoo__.OOOO_OO._oo.(tableProperty, dataRow("Config").ToString(), vbVerticalTab)
				If A_0 Then
					tableProperty.Restore()
				End If
			End If
			Me.NeedSaveSetting = False
			Me.Loaded = True
			Return tableProperty
		End Function

		' Token: 0x170009E8 RID: 2536
		' (get) Token: 0x060029CD RID: 10701 RVA: 0x0011E21C File Offset: 0x0011C41C
		' (set) Token: 0x060029CE RID: 10702 RVA: 0x0011E224 File Offset: 0x0011C424
		Friend Property foxGrid As O_oOooO_O
			Get
				Return Me.O_o0OOo_.o0.
			End Get
			Set(value As O_oOooO_O)
				Me.O_o0OOo_.o0. = value
			End Set
		End Property

		' Token: 0x170009E9 RID: 2537
		' (get) Token: 0x060029CF RID: 10703 RVA: 0x0011E22D File Offset: 0x0011C42D
		Public ReadOnly Property Grid As C1FlexGrid
			Get
				Return Me.O_o0OOo_.o0.
			End Get
		End Property

		' Token: 0x170009EA RID: 2538
		' (get) Token: 0x060029D0 RID: 10704 RVA: 0x0011E235 File Offset: 0x0011C435
		' (set) Token: 0x060029D1 RID: 10705 RVA: 0x0011E23D File Offset: 0x0011C43D
		Friend Property View As O_0
			Get
				Return Me.o.0ooOO_0__.
			End Get
			Set(value As O_0)
			End Set
		End Property

		' Token: 0x060029D2 RID: 10706 RVA: 0x0011E23F File Offset: 0x0011C43F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ResetCurrentItem()
			Me.o.0ooOO_0__..ResetCurrentItem()
		End Sub

		' Token: 0x060029D3 RID: 10707 RVA: 0x0011E24C File Offset: 0x0011C44C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ResetBindings(Optional metadataChanged As Boolean = False)
			Me.o.0ooOO_0__..ResetBindings(metadataChanged)
		End Sub

		' Token: 0x060029D4 RID: 10708 RVA: 0x0011E25A File Offset: 0x0011C45A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ResetItem(Itemindex As Integer)
			Me.o.0ooOO_0__..ResetItem(Itemindex)
		End Sub

		' Token: 0x060029D5 RID: 10709 RVA: 0x0011E268 File Offset: 0x0011C468
		Friend Sub <<EMPTY_NAME>>()
			If Me.AllowFreezeColumn Then
				Me.O_o0OOo_.o0..AllowFreezing = 1
			Else
				Me.O_o0OOo_.o0..AllowFreezing = 0
			End If
			If Me.AllowResizeColumn And Me.AllowResizeRow Then
				Me.O_o0OOo_.o0..AllowResizing = 3
			ElseIf Me.AllowResizeColumn Then
				Me.O_o0OOo_.o0..AllowResizing = 1
			ElseIf Me.AllowResizeRow Then
				Me.O_o0OOo_.o0..AllowResizing = 5
			Else
				Me.O_o0OOo_.o0..AllowResizing = 0
			End If
			If Me.EnterKeyActionDown Then
				Me.O_o0OOo_.o0..KeyActionEnter = 1
			Else
				Me.O_o0OOo_.o0..KeyActionEnter = 2
			End If
			If Me.TabKeyActionDown Then
				Me.O_o0OOo_.o0..KeyActionTab = 1
				Return
			End If
			Me.O_o0OOo_.o0..KeyActionTab = 2
		End Sub

		' Token: 0x060029D6 RID: 10710 RVA: 0x0011E330 File Offset: 0x0011C530
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim tableName As String = Me.View.o_o.O0ooOo.().TableName
			Dim result As Boolean
			If Me.IsParent Then
				MessageBox.Show("不能直接在父表增加行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				If Me.IsChild Then
					If Me.View.O0O_0_0__.0O.().Position < 0 Then
						MessageBox.Show("增加行失败，父表无有效行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return False
					End If
					Dim num As Integer = Me.View.O0O_0_0__.0O.().ChildColumns.Length - 1
					For i As Integer = 0 To num
						If Me.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row.IsNull(Me.View.O0O_0_0__.0O.().ParentColumns(i).ColumnName) Then
							MessageBox.Show("增加行失败，父行(" + Me.View.O0O_0_0__.0O.().ParentColumns(i).ColumnName + ")未输入有效值！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return False
						End If
					Next
				End If
				result = True
			End If
			Return result
		End Function

		' Token: 0x060029D7 RID: 10711 RVA: 0x0011E437 File Offset: 0x0011C637
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Row) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Row).GetEnumerator
			Return New O_0o_0o_o0O_(Me)
		End Function

		' Token: 0x060029D8 RID: 10712 RVA: 0x0011E43F File Offset: 0x0011C63F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O_0o_0o_o0O_(Me)
		End Function

		' Token: 0x060029D9 RID: 10713 RVA: 0x0011E448 File Offset: 0x0011C648
		Friend Function <<EMPTY_NAME>>(Optional A_0 As Boolean = True, Optional A_1 As Boolean = False) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As List(Of String).Enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator()
				Dim flag As Boolean
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_20:
					num2 = 3
					If Me.foxGrid.Cols.Contains(text) Then
						IL_36:
						num2 = 4
						flag = True
						Exit While
					End If
					IL_3D:
					num2 = 6
				End While
				IL_48:
				num2 = 7
				CType(enumerator, IDisposable).Dispose()
				IL_57:
				num2 = 8
				Dim enumerator2 As IEnumerator = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj As Object = enumerator2.Current
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					IL_7A:
					num2 = 9
					If Me.DataTable.BaseTable Is dataRelation.ParentTable OrElse Me.DataTable.BaseTable Is dataRelation.ChildTable Then
						IL_A5:
						num2 = 10
						If Me.foxGrid.Cols.Contains(dataRelation.RelationName) Then
							IL_C1:
							num2 = 11
							flag = True
							Exit While
						End If
					End If
					IL_C9:
					num2 = 13
				End While
				IL_D5:
				num2 = 14
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_ED:
				num2 = 15
				For i As Integer = Me.foxGrid.Cols.Count - 1 To 1 Step -1
					IL_109:
					num2 = 16
					If OO_00oOO.User.Type IsNot Nothing Then
						IL_118:
						num2 = 17
						If Me.foxGrid.Cols(i).Name.StartsWith("sys_", StringComparison.CurrentCultureIgnoreCase) Then
							IL_13F:
							num2 = 18
							flag = True
							Exit For
						End If
					End If
					IL_14A:
					num2 = 20
					If Not Me.DataTable.BaseTable.Columns.Contains(Me.foxGrid.Cols(i).Name) Then
						IL_17B:
						num2 = 21
						flag = True
						Exit For
					End If
					IL_183:
					num2 = 23
					If Me.foxGrid.Cols(Me.foxGrid.Cols(i).Name).Index <> i Then
						IL_1B6:
						num2 = 24
						flag = True
						Exit For
					End If
					IL_1BE:
					num2 = 26
				Next
				IL_1CF:
				num2 = 27
				If Not flag AndAlso Not A_1 Then
					GoTo IL_1F7
				End If
				IL_1D8:
				num2 = 28
				Me.oO_o_0o._0oooo.(A_0)
				IL_1E2:
				num2 = 29
				Me.foxGrid.Refresh()
				IL_1F0:
				num2 = 30
				result = True
				GoTo IL_1FC
				IL_1F7:
				num2 = 32
				result = False
				IL_1FC:
				GoTo IL_2D2
				IL_201:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_293:
				GoTo IL_2C7
				IL_295:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2A5:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_295
			End Try
			IL_2C7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2D2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060029DA RID: 10714 RVA: 0x0011E74C File Offset: 0x0011C94C
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = True)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 0
				IL_0B:
				num2 = 3
				If Me.Grid.Cols.Count <= 1 OrElse Operators.CompareString(Me.Grid.Cols(1).Name, "", True) <> 0 Then
					GoTo IL_60
				End If
				IL_43:
				num2 = 4
				Me.Grid.DataSource = RuntimeHelpers.GetObjectValue(Me.Grid.DataSource)
				IL_60:
				num2 = 5
				Dim num4 As Integer = 1
				Do
					IL_65:
					num2 = 6
					Dim enumerator As List(Of String).Enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator()
					While enumerator.MoveNext()
						Dim text As String = enumerator.Current
						IL_7E:
						num2 = 7
						If Me.foxGrid.Cols.Contains(text) Then
							IL_94:
							num2 = 8
							Me.foxGrid.Cols.Remove(text)
							IL_A9:
							num2 = 9
							num3 += 1
						End If
						IL_B0:
						num2 = 10
					End While
					IL_BC:
					num2 = 11
					CType(enumerator, IDisposable).Dispose()
					IL_CC:
					num2 = 12
					num4 += 1
				Loop While num4 <= 3
				IL_DA:
				num2 = 13
				Dim enumerator2 As IEnumerator = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj As Object = enumerator2.Current
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					IL_FE:
					num2 = 14
					If Me.DataTable.BaseTable Is dataRelation.ParentTable OrElse Me.DataTable.BaseTable Is dataRelation.ChildTable Then
						IL_129:
						num2 = 15
						If Me.foxGrid.Cols.Contains(dataRelation.RelationName) Then
							IL_145:
							num2 = 16
							Me.foxGrid.Cols.Remove(dataRelation.RelationName)
							IL_160:
							num2 = 17
							num3 += 1
						End If
					End If
					IL_167:
					num2 = 18
				End While
				IL_176:
				num2 = 19
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_18E:
				num2 = 20
				Dim i As Integer = Me.foxGrid.Cols.Count - 1
				While i >= 1
					IL_1AA:
					num2 = 21
					If OO_00oOO.User.Type Is Nothing Then
						GoTo IL_1FB
					End If
					IL_1B9:
					num2 = 22
					If Not Me.foxGrid.Cols(i).Name.StartsWith("sys_", StringComparison.CurrentCultureIgnoreCase) Then
						GoTo IL_1FB
					End If
					IL_1E0:
					num2 = 23
					Me.foxGrid.Cols.Remove(i)
					IL_28D:
					num2 = 30
					i += -1
					Continue While
					IL_1FB:
					num2 = 25
					If Not Me.DataTable.BaseTable.Columns.Contains(Me.foxGrid.Cols(i).Name) Then
						IL_22C:
						num2 = 26
						Me.foxGrid.Cols.Remove(i)
						GoTo IL_28D
					End If
					IL_244:
					num2 = 28
					If Me.foxGrid.Cols(Me.foxGrid.Cols(i).Name).Index <> i Then
						IL_277:
						num2 = 29
						Me.foxGrid.Cols.Remove(i)
						GoTo IL_28D
					End If
					GoTo IL_28D
				End While
				IL_29E:
				num2 = 31
				If num3 <> 0 Then
					GoTo IL_2B0
				End If
				IL_2A4:
				num2 = 32
				Me.O0oO0oo_O_o.Oo.(False)
				GoTo IL_2BA
				IL_2B0:
				num2 = 34
				Me.O0oO0oo_O_o.Oo.(True)
				IL_2BA:
				num2 = 35
				Me.o.OO0O0O. = ""
				IL_2C8:
				num2 = 36
				If Not A_0 Then
					GoTo IL_30A
				End If
				IL_2CE:
				num2 = 37
				Dim tableEventArgs As TableEventArgs = New TableEventArgs(Me)
				IL_2D9:
				num2 = 38
				O_O0OO.OoO_o.oO0o0O.(Me.DataTable.o_0_00_.oo0O0., "AfterLoadTableSetting", New Object() { tableEventArgs }, True, Me.DataTable.Name, False)
				IL_30A:
				GoTo IL_3F8
				IL_30F:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_3B9:
				GoTo IL_3ED
				IL_3BB:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3CB:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_3BB
			End Try
			IL_3ED:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3F8:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029DB RID: 10715 RVA: 0x0011EB78 File Offset: 0x0011CD78
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = True)
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 1
				IL_0B:
				num2 = 3
				Me.foxGrid.BeginUpdate()
				IL_18:
				num2 = 4
				Dim fixed As Integer = Me.foxGrid.Cols.Fixed
				Dim num4 As Integer = Me.foxGrid.Cols.Count - 1
				For i As Integer = fixed To num4
					IL_45:
					num2 = 5
					Dim col As Col = Me.Cols(Me.foxGrid.Cols(i).Name)
					IL_6B:
					num2 = 6
					If A_0 Then
						IL_70:
						num2 = 7
						If Me.TableType Is Nothing AndAlso Not Me.DataTable.AddByCode Then
							IL_87:
							num2 = 8
							col.o0.O.()
						Else
							IL_92:
							num2 = 10
							If col.IsDate() Then
								IL_9E:
								num2 = 11
								col.SetDateTimeFormat(0)
							End If
						End If
					End If
					IL_A9:
					num2 = 12
					Me.foxGrid.Cols(i).Caption = col.Caption
					IL_CA:
					num2 = 13
					num3 = Math.Max(num3, Me.foxGrid.Cols(i).Caption.ToString().Split(New Char() { "_"c, "＿"c }).Length)
					IL_10A:
					num2 = 14
				Next
				IL_11C:
				num2 = 15
				If Not Me.DataTable.MultiRowHeader Then
					GoTo IL_142
				End If
				IL_12C:
				num2 = 16
				Me.foxGrid.Rows.Fixed = num3
				GoTo IL_156
				IL_142:
				num2 = 18
				Me.foxGrid.Rows.Fixed = 1
				IL_156:
				num2 = 19
				If num3 <= 1 OrElse Not Me.DataTable.MultiRowHeader Then
					GoTo IL_256
				End If
				IL_170:
				num2 = 20
				Dim num5 As Integer = num3 - 1
				For j As Integer = 0 To num5
					IL_17D:
					num2 = 21
					Me.foxGrid.Rows(j).AllowMerging = True
					IL_198:
					num2 = 22
				Next
				IL_1A7:
				num2 = 23
				Dim fixed2 As Integer = Me.foxGrid.Cols.Fixed
				Dim num6 As Integer = Me.foxGrid.Cols.Count - 1
				For k As Integer = fixed2 To num6
					IL_1D2:
					num2 = 24
					Dim array As String() = Me.foxGrid.Cols(k).Caption.Split(New Char() { "_"c, "＿"c })
					IL_206:
					num2 = 25
					Dim num7 As Integer = num3 - 1
					For l As Integer = 0 To num7
						IL_213:
						num2 = 26
						Me.foxGrid(l, k) = array(Math.Min(l, array.Length - 1))
						IL_235:
						num2 = 27
					Next
					IL_244:
					num2 = 28
				Next
				IL_256:
				num2 = 29
				If Me.foxGrid.Col >= Me.foxGrid.Cols.Fixed OrElse Me.foxGrid.Cols.Count <= Me.foxGrid.Cols.Fixed Then
					GoTo IL_2B6
				End If
				IL_298:
				num2 = 30
				Me.foxGrid.Col = Me.foxGrid.Cols.Fixed
				IL_2B6:
				num2 = 31
				Me.foxGrid.EndUpdate()
				IL_2C4:
				GoTo IL_396
				IL_2C9:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_357:
				GoTo IL_38B
				IL_359:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_369:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_359
			End Try
			IL_38B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_396:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029DC RID: 10716 RVA: 0x0011EF40 File Offset: 0x0011D140
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildHeader()
			Me.O0oO0oo_O_o.Oo.(False)
		End Sub

		' Token: 0x060029DD RID: 10717 RVA: 0x0011EF4C File Offset: 0x0011D14C
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.View.Count = 0 Then
					GoTo IL_312
				End If
				IL_19:
				num2 = 4
				If Me.foxGrid.Col < Me.foxGrid.Cols.Fixed Then
					GoTo IL_312
				End If
				IL_3B:
				num2 = 6
				If Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex < 0 Then
					GoTo IL_312
				End If
				IL_6C:
				num2 = 8
				Dim name As String = Me.foxGrid.Cols(Me.foxGrid.Col).Name
				IL_8F:
				num2 = 9
				If Not Me.AllowEdit OrElse Not Me.Cols(name).AllowEdit Then
					GoTo IL_312
				End If
				IL_B3:
				num2 = 11
				Me.O_o0OOo_.o0..O__00.__0_O.(New oOOOo0oOOOO_(Me, Me.foxGrid.Selection))
				IL_D2:
				num2 = 12
				If Me.foxGrid.Selection.TopRow <> Me.foxGrid.Selection.BottomRow Then
					GoTo IL_1D5
				End If
				IL_102:
				num2 = 13
				Dim dataIndex As Integer = Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex
				IL_130:
				num2 = 14
				If dataIndex <= 0 Then
					GoTo IL_312
				End If
				IL_13B:
				num2 = 17
				If Not Me.foxGrid.o000OOo.OO.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col) Then
					GoTo IL_2EE
				End If
				IL_16D:
				num2 = 18
				Me.View.O0O_0_0__.0O.(dataIndex).Row(name) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(dataIndex - 1)(name))
				IL_1A2:
				num2 = 19
				Me.foxGrid.O.O0_0.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col, Nothing)
				GoTo IL_2EE
				IL_1D5:
				num2 = 21
				Dim dataRowView As DataRowView = Me.View.O0O_0_0__.0O.(Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex)
				IL_20E:
				num2 = 22
				If dataRowView.Row.IsNull(name) Then
					GoTo IL_312
				End If
				IL_223:
				num2 = 24
				Dim topRow As Integer = Me.foxGrid.Selection.TopRow
				Dim bottomRow As Integer = Me.foxGrid.Selection.BottomRow
				For i As Integer = topRow To bottomRow
					IL_257:
					num2 = 25
					Dim dataIndex2 As Integer = Me.foxGrid.Rows(i).DataIndex
					IL_273:
					num2 = 26
					If dataIndex2 >= 0 Then
						IL_27B:
						num2 = 27
						If Me.foxGrid.o000OOo.OO.(i, Me.foxGrid.Col) Then
							IL_298:
							num2 = 28
							Me.View.O0O_0_0__.0O.(dataIndex2).Row(name) = RuntimeHelpers.GetObjectValue(dataRowView(name))
							IL_2C0:
							num2 = 29
							Me.foxGrid.O.O0_0.(i, Me.foxGrid.Col, Nothing)
						End If
					End If
					IL_2DC:
					num2 = 30
				Next
				IL_2EE:
				num2 = 31
				If Me.View.Position < 0 Then
					GoTo IL_312
				End If
				IL_2FF:
				num2 = 32
				Me.View.o_o.O0ooOo.().EndEdit()
				IL_312:
				GoTo IL_3E8
				IL_317:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_3A9:
				GoTo IL_3DD
				IL_3AB:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3BB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3AB
			End Try
			IL_3DD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3E8:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029DE RID: 10718 RVA: 0x0011F368 File Offset: 0x0011D568
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dataTable As DataTable = Me.DataTable
				IL_10:
				num2 = 3
				Dim name As String = Me.foxGrid.Cols(Me.foxGrid.Col).Name
				IL_34:
				num2 = 4
				If Not Me.AllowEdit OrElse Not Me.Cols(name).AllowEdit Then
					GoTo IL_AE8
				End If
				IL_58:
				num2 = 6
				If Me.View.Count = 0 Then
					GoTo IL_AE8
				End If
				IL_6A:
				num2 = 8
				If Me.foxGrid.Selection.TopRow <> Me.foxGrid.Selection.BottomRow Then
					GoTo IL_192
				End If
				IL_99:
				num2 = 9
				Dim dataIndex As Integer = Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex
				IL_C7:
				num2 = 10
				If dataIndex <> 1 Then
					GoTo IL_187
				End If
				IL_D2:
				num2 = 11
				If Not Me.foxGrid.o000OOo.OO.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col) Then
					GoTo IL_187
				End If
				IL_104:
				num2 = 12
				Me.O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me, Me.View.O0O_0_0__.0O.(1).Row, name))
				IL_12B:
				num2 = 13
				Me.View.O0O_0_0__.0O.(1)(name) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(0)(name))
				IL_159:
				num2 = 14
				Me.foxGrid.O.O0_0.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col, Nothing)
				IL_187:
				num2 = 15
				If dataIndex <= 1 Then
					GoTo IL_AE8
				End If
				IL_192:
				num2 = 17
				Me.O_o0OOo_.o0..O__00.__0_O.(New oOOOo0oOOOO_(Me, Me.foxGrid.Selection))
				IL_1B1:
				num2 = 18
				If Not dataTable.DataCols(name).IsNumeric Then
					GoTo IL_48E
				End If
				IL_1CB:
				num2 = 19
				If Me.foxGrid.Selection.TopRow <> Me.foxGrid.Selection.BottomRow Then
					GoTo IL_355
				End If
				IL_1FB:
				num2 = 20
				Dim dataIndex2 As Integer = Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex
				IL_229:
				num2 = 21
				Dim dataRowView As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex2 - 2)
				IL_23D:
				num2 = 22
				Dim dataRowView2 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex2 - 1)
				IL_251:
				num2 = 23
				Dim dataRowView3 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex2)
				IL_263:
				num2 = 24
				If Not Me.foxGrid.o000OOo.OO.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col) Then
					GoTo IL_AC4
				End If
				IL_295:
				num2 = 25
				If Not(dataRowView.Row.IsNull(name) Or dataRowView2.Row.IsNull(name)) Then
					GoTo IL_2D8
				End If
				IL_2B7:
				num2 = 26
				dataRowView3.Row(name) = RuntimeHelpers.GetObjectValue(dataRowView2(name))
				GoTo IL_322
				IL_2D8:
				num2 = 28
				dataRowView3.Row(name) = Decimal.Add(Conversions.ToDecimal(dataRowView2(name)), Decimal.Subtract(Conversions.ToDecimal(dataRowView2(name)), Conversions.ToDecimal(dataRowView(name))))
				IL_322:
				num2 = 29
				Me.foxGrid.O.O0_0.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col, Nothing)
				GoTo IL_AC4
				IL_355:
				num2 = 31
				Dim dataRowView4 As DataRowView = Nothing
				IL_35B:
				num2 = 32
				Dim dataRowView5 As DataRowView = Nothing
				IL_361:
				num2 = 33
				Dim num3 As Integer
				Me.o.oO__OO_oo_0_.(dataRowView4, dataRowView5, num3)
				IL_370:
				num2 = 34
				If dataRowView5 Is Nothing Then
					GoTo IL_AE8
				End If
				IL_37A:
				num2 = 37
				If dataRowView4.Row.IsNull(name) Or dataRowView5.Row.IsNull(name) Then
					GoTo IL_AE8
				End If
				IL_39F:
				num2 = 39
				Dim num4 As Double = Conversions.ToDouble(dataRowView5(name))
				IL_3B2:
				num2 = 40
				Dim num5 As Double = num4 - Conversions.ToDouble(dataRowView4(name))
				IL_3C8:
				num2 = 41
				Dim num6 As Integer = num3
				Dim bottomRow As Integer = Me.foxGrid.Selection.BottomRow
				For i As Integer = num6 To bottomRow
					IL_3EA:
					num2 = 42
					Dim dataIndex3 As Integer = Me.foxGrid.Rows(i).DataIndex
					IL_406:
					num2 = 43
					If dataIndex3 >= 0 Then
						IL_40E:
						num2 = 44
						If Me.foxGrid.o000OOo.OO.(i, Me.foxGrid.Col) Then
							IL_42B:
							num2 = 45
							Me.View.O0O_0_0__.0O.(dataIndex3).Row(name) = num4 + num5
							IL_451:
							num2 = 46
							Me.foxGrid.O.O0_0.(i, Me.foxGrid.Col, Nothing)
						End If
						IL_46D:
						num2 = 47
						num4 += num5
					End If
					IL_477:
					num2 = 48
				Next
				GoTo IL_AC4
				IL_48E:
				num2 = 50
				If Not dataTable.DataCols(name).IsDate Then
					GoTo IL_782
				End If
				IL_4A8:
				num2 = 51
				If Me.foxGrid.Selection.TopRow <> Me.foxGrid.Selection.BottomRow Then
					GoTo IL_637
				End If
				IL_4D8:
				num2 = 52
				Dim dataIndex4 As Integer = Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex
				IL_506:
				num2 = 53
				Dim dataRowView6 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex4 - 2)
				IL_51A:
				num2 = 54
				Dim dataRowView7 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex4 - 1)
				IL_52E:
				num2 = 55
				Dim dataRowView8 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex4)
				IL_540:
				num2 = 56
				If Not Me.foxGrid.o000OOo.OO.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col) Then
					GoTo IL_AC4
				End If
				IL_572:
				num2 = 57
				If Not(dataRowView6.Row.IsNull(name) Or dataRowView7.Row.IsNull(name)) Then
					GoTo IL_5B5
				End If
				IL_594:
				num2 = 58
				dataRowView8.Row(name) = RuntimeHelpers.GetObjectValue(dataRowView7(name))
				GoTo IL_604
				IL_5B5:
				num2 = 60
				dataRowView8.Row(name) = DateAndTime.DateAdd(DateInterval.Day, CDbl(DateAndTime.DateDiff(DateInterval.Day, Conversions.ToDate(dataRowView6(name)), Conversions.ToDate(dataRowView7(name)), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)), Conversions.ToDate(dataRowView7(name)))
				IL_604:
				num2 = 61
				Me.foxGrid.O.O0_0.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col, Nothing)
				GoTo IL_AC4
				IL_637:
				num2 = 63
				Dim dataRowView9 As DataRowView = Nothing
				IL_63D:
				num2 = 64
				Dim dataRowView10 As DataRowView = Nothing
				IL_643:
				num2 = 65
				Dim num7 As Integer
				Me.o.oO__OO_oo_0_.(dataRowView9, dataRowView10, num7)
				IL_652:
				num2 = 66
				If dataRowView10 Is Nothing Then
					GoTo IL_AE8
				End If
				IL_65C:
				num2 = 69
				If dataRowView9.Row.IsNull(name) Or dataRowView10.Row.IsNull(name) Then
					GoTo IL_AE8
				End If
				IL_681:
				num2 = 71
				Dim dateTime As DateTime = Conversions.ToDate(dataRowView10(name))
				IL_694:
				num2 = 72
				Dim number As Double = CDbl(DateAndTime.DateDiff(DateInterval.Day, Conversions.ToDate(dataRowView9(name)), dateTime, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1))
				IL_6B2:
				num2 = 73
				Dim num8 As Integer = num7
				Dim bottomRow2 As Integer = Me.foxGrid.Selection.BottomRow
				For j As Integer = num8 To bottomRow2
					IL_6D4:
					num2 = 74
					Dim dataIndex5 As Integer = Me.foxGrid.Rows(j).DataIndex
					IL_6F0:
					num2 = 75
					If dataIndex5 >= 0 Then
						IL_6F8:
						num2 = 76
						If Me.foxGrid.o000OOo.OO.(j, Me.foxGrid.Col) Then
							IL_715:
							num2 = 77
							Me.View.O0O_0_0__.0O.(dataIndex5).Row(name) = DateAndTime.DateAdd(DateInterval.Day, number, dateTime)
							IL_740:
							num2 = 78
							Me.foxGrid.O.O0_0.(j, Me.foxGrid.Col, Nothing)
						End If
						IL_75C:
						num2 = 79
						dateTime = DateAndTime.DateAdd(DateInterval.Day, number, dateTime)
					End If
					IL_76B:
					num2 = 80
				Next
				GoTo IL_AC4
				IL_782:
				num2 = 82
				If Not dataTable.DataCols(name).IsString Then
					GoTo IL_AC4
				End If
				IL_79C:
				num2 = 83
				If Me.foxGrid.Selection.TopRow <> Me.foxGrid.Selection.BottomRow Then
					GoTo IL_9E4
				End If
				IL_7CC:
				num2 = 84
				Dim dataIndex6 As Integer = Me.foxGrid.Rows(Me.foxGrid.Selection.TopRow).DataIndex
				IL_7FA:
				num2 = 85
				Dim dataRowView11 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex6 - 2)
				IL_80E:
				num2 = 86
				Dim dataRowView12 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex6 - 1)
				IL_822:
				num2 = 87
				Dim dataRowView13 As DataRowView = Me.View.O0O_0_0__.0O.(dataIndex6)
				IL_834:
				num2 = 88
				If Not Me.foxGrid.o000OOo.OO.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col) Then
					GoTo IL_AC4
				End If
				IL_866:
				num2 = 89
				If Not(dataRowView11.Row.IsNull(name) Or dataRowView12.Row.IsNull(name)) Then
					GoTo IL_8AC
				End If
				IL_888:
				num2 = 90
				dataRowView13.Row(name) = RuntimeHelpers.GetObjectValue(dataRowView12(name))
				GoTo IL_9B1
				IL_8AC:
				num2 = 92
				If Operators.CompareString(Conversions.ToString(dataRowView11(name)), Conversions.ToString(dataRowView12(name)), True) <> 0 Then
					GoTo IL_8F7
				End If
				IL_8D3:
				num2 = 93
				dataRowView13.Row(name) = RuntimeHelpers.GetObjectValue(dataRowView12(name))
				GoTo IL_9B1
				IL_8F7:
				num2 = 95
				If Not Versioned.IsNumeric(Strings.Right(Conversions.ToString(dataRowView11(name)), 1)) OrElse Not Versioned.IsNumeric(Strings.Right(Conversions.ToString(dataRowView12(name)), 1)) Then
					GoTo IL_955
				End If
				IL_930:
				num2 = 96
				Me.o0O0oo.o.(dataRowView11, dataRowView12, Me.foxGrid.Selection.TopRow, name)
				GoTo IL_9B1
				IL_955:
				num2 = 98
				If Not Versioned.IsNumeric(Strings.Left(Conversions.ToString(dataRowView11(name)), 1)) OrElse Not Versioned.IsNumeric(Strings.Left(Conversions.ToString(dataRowView12(name)), 1)) Then
					GoTo IL_9B1
				End If
				IL_98E:
				num2 = 99
				Me.O0o._oo_.(dataRowView11, dataRowView12, Me.foxGrid.Selection.TopRow, name)
				IL_9B1:
				num2 = 100
				Me.foxGrid.O.O0_0.(Me.foxGrid.Selection.TopRow, Me.foxGrid.Col, Nothing)
				GoTo IL_AC4
				IL_9E4:
				num2 = 102
				Dim dataRowView14 As DataRowView = Nothing
				IL_9EA:
				num2 = 103
				Dim dataRowView15 As DataRowView = Nothing
				IL_9F0:
				num2 = 104
				Dim a_ As Integer
				Me.o.oO__OO_oo_0_.(dataRowView14, dataRowView15, a_)
				IL_9FF:
				num2 = 105
				If dataRowView15 Is Nothing Then
					GoTo IL_AE8
				End If
				IL_A09:
				num2 = 108
				If dataRowView14.Row.IsNull(name) Or dataRowView15.Row.IsNull(name) Then
					GoTo IL_AE8
				End If
				IL_A2E:
				num2 = 110
				If Not Versioned.IsNumeric(Strings.Right(Conversions.ToString(dataRowView14(name)), 1)) OrElse Not Versioned.IsNumeric(Strings.Right(Conversions.ToString(dataRowView15(name)), 1)) Then
					GoTo IL_A7A
				End If
				IL_A67:
				num2 = 111
				Me.o0O0oo.o.(dataRowView14, dataRowView15, a_, name)
				GoTo IL_AC4
				IL_A7A:
				num2 = 113
				If Not Versioned.IsNumeric(Strings.Left(Conversions.ToString(dataRowView14(name)), 1)) OrElse Not Versioned.IsNumeric(Strings.Left(Conversions.ToString(dataRowView15(name)), 1)) Then
					GoTo IL_AC4
				End If
				IL_AB3:
				num2 = 114
				Me.O0o._oo_.(dataRowView14, dataRowView15, a_, name)
				IL_AC4:
				num2 = 115
				If Me.View.Position < 0 Then
					GoTo IL_AE8
				End If
				IL_AD5:
				num2 = 116
				Me.View.o_o.O0ooOo.().EndEdit()
				IL_AE8:
				GoTo IL_D0E
				IL_AED:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_CCF:
				GoTo IL_D03
				IL_CD1:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_CE1:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_CD1
			End Try
			IL_D03:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_D0E:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029DF RID: 10719 RVA: 0x001200A8 File Offset: 0x0011E2A8
		Private Sub <<EMPTY_NAME>>(A_0 As DataRowView, A_1 As DataRowView, A_2 As Integer, A_3 As String)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = Conversions.ToString(A_0(A_3))
				IL_17:
				num2 = 3
				Dim text2 As String = Conversions.ToString(A_1(A_3))
				IL_28:
				num2 = 4
				Dim str As String = Nothing
				IL_2D:
				num2 = 5
				Dim text3 As String = Nothing
				IL_32:
				num2 = 6
				Dim num3 As Integer = Math.Min(text.Length, text2.Length)
				IL_48:
				num2 = 7
				Dim index As Integer = Me.foxGrid.Cols(A_3).Index
				IL_63:
				num2 = 8
				For i As Integer = num3 - 1 To 0 Step -1
					IL_6D:
					num2 = 9
					If Not Versioned.IsNumeric(text.Substring(i, 1)) OrElse Not Versioned.IsNumeric(text2.Substring(i, 1)) Then
						IL_A4:
						num2 = 12
						str = Strings.Left(text, i + 1)
						IL_B3:
						num2 = 13
						text = text.Substring(i + 1)
						IL_C1:
						num2 = 14
						text2 = text2.Substring(i + 1)
						Exit For
					End If
					IL_91:
					num2 = 10
					text3 += "0"
					IL_D3:
					num2 = 16
				Next
				IL_E1:
				num2 = 17
				Dim num4 As Long = Conversions.ToLong(text2)
				IL_ED:
				num2 = 18
				Dim num5 As Long = Conversions.ToLong(text2) - Conversions.ToLong(text)
				IL_100:
				num2 = 19
				Dim bottomRow As Integer = Me.foxGrid.Selection.BottomRow
				For j As Integer = A_2 To bottomRow
					IL_121:
					num2 = 20
					Dim dataIndex As Integer = Me.foxGrid.Rows(j).DataIndex
					IL_13D:
					num2 = 21
					If dataIndex >= 0 Then
						IL_145:
						num2 = 22
						If Me.foxGrid.o000OOo.OO.(j, index) Then
							IL_159:
							num2 = 23
							Me.View.O0O_0_0__.0O.(dataIndex).Row(A_3) = str + Strings.Format(num4 + num5, text3)
							IL_18D:
							num2 = 24
							Me.foxGrid.O.O0_0.(j, index, Nothing)
						End If
						IL_1A0:
						num2 = 25
						num4 += num5
					End If
					IL_1AA:
					num2 = 26
				Next
				IL_1BC:
				GoTo IL_27A
				IL_1C1:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_23B:
				GoTo IL_26F
				IL_23D:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_24D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_23D
			End Try
			IL_26F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_27A:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029E0 RID: 10720 RVA: 0x00120354 File Offset: 0x0011E554
		Private Sub <<EMPTY_NAME>>(A_0 As DataRowView, A_1 As DataRowView, A_2 As Integer, A_3 As String)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = Conversions.ToString(A_0(A_3))
				IL_17:
				num2 = 3
				Dim text2 As String = Conversions.ToString(A_1(A_3))
				IL_28:
				num2 = 4
				Dim str As String = Nothing
				IL_2D:
				num2 = 5
				Dim text3 As String = Nothing
				IL_32:
				num2 = 6
				Dim num3 As Integer = Math.Min(text.Length, text2.Length)
				IL_48:
				num2 = 7
				Dim index As Integer = Me.foxGrid.Cols(A_3).Index
				IL_63:
				num2 = 8
				Dim num4 As Integer = num3 - 1
				For i As Integer = 0 To num4
					IL_70:
					num2 = 9
					If Not Versioned.IsNumeric(text.Substring(i, 1)) OrElse Not Versioned.IsNumeric(text2.Substring(i, 1)) Then
						IL_A7:
						num2 = 12
						str = text.Substring(i)
						IL_B4:
						num2 = 13
						text = text.Substring(0, i)
						IL_C1:
						num2 = 14
						text2 = text2.Substring(0, i)
						Exit For
					End If
					IL_94:
					num2 = 10
					text3 += "0"
					IL_D2:
					num2 = 16
				Next
				IL_E1:
				num2 = 17
				Dim num5 As Long = Conversions.ToLong(text2)
				IL_ED:
				num2 = 18
				Dim num6 As Long = Conversions.ToLong(text2) - Conversions.ToLong(text)
				IL_100:
				num2 = 19
				Dim bottomRow As Integer = Me.foxGrid.Selection.BottomRow
				For j As Integer = A_2 To bottomRow
					IL_121:
					num2 = 20
					Dim dataIndex As Integer = Me.foxGrid.Rows(j).DataIndex
					IL_13D:
					num2 = 21
					If dataIndex >= 0 Then
						IL_145:
						num2 = 22
						If Me.foxGrid.o000OOo.OO.(j, index) Then
							IL_159:
							num2 = 23
							Me.View.O0O_0_0__.0O.(dataIndex).Row(A_3) = Strings.Format(num5 + num6, text3) + str
							IL_18D:
							num2 = 24
							Me.foxGrid.O.O0_0.(j, index, Nothing)
						End If
						IL_1A0:
						num2 = 25
						num5 += num6
					End If
					IL_1AA:
					num2 = 26
				Next
				IL_1BC:
				GoTo IL_27A
				IL_1C1:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_23B:
				GoTo IL_26F
				IL_23D:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_24D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_23D
			End Try
			IL_26F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_27A:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029E1 RID: 10721 RVA: 0x00120600 File Offset: 0x0011E800
		Private Sub <<EMPTY_NAME>>(ByRef A_0 As DataRowView, ByRef A_1 As DataRowView, ByRef A_2 As Integer)
			Dim topRow As Integer = Me.foxGrid.Selection.TopRow
			Dim bottomRow As Integer = Me.foxGrid.Selection.BottomRow
			For i As Integer = topRow To bottomRow
				If Me.foxGrid.Rows(i).DataIndex >= 0 Then
					If A_0 Is Nothing Then
						A_0 = Me.View.O0O_0_0__.0O.(Me.foxGrid.Rows(i).DataIndex)
					ElseIf A_1 Is Nothing Then
						A_1 = Me.View.O0O_0_0__.0O.(Me.foxGrid.Rows(i).DataIndex)
						A_2 = i + 1
						Return
					End If
				End If
			Next
		End Sub

		' Token: 0x060029E2 RID: 10722 RVA: 0x001206B0 File Offset: 0x0011E8B0
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As DateGroupEnum) As String
			Dim result As String
			If Me.foxGrid(A_0, A_1) Is Nothing OrElse Me.foxGrid(A_0, A_1) Is DBNull.Value Then
				result = Nothing
			Else
				Dim dateTime As DateTime = Conversions.ToDate(Me.foxGrid(A_0, A_1))
				Select Case A_2
					Case 1
						result = dateTime.Year.ToString()
					Case 2
						result = DateAndTime.DatePart(DateInterval.Quarter, dateTime, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString()
					Case 3
						result = dateTime.Month.ToString()
					Case 4
						result = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString()
					Case 5
						result = dateTime.Day.ToString()
					Case 6
						result = dateTime.Hour.ToString()
					Case 7
						result = dateTime.Minute.ToString()
					Case 8
						result = dateTime.Second.ToString()
					Case Else
						result = dateTime.ToString()
				End Select
			End If
			Return result
		End Function

		' Token: 0x060029E3 RID: 10723 RVA: 0x001207D4 File Offset: 0x0011E9D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PrintPageEventArgs)
			If Me.O.OoOo_. IsNot Nothing Then
				Me.O.OoOo_. += 1
				Me.O.OoOo_..Oo0._.("已经完成" + Conversions.ToString(Me.O.OoOo_.) + "页...")
				If Me.O.OoOo_..Ooo_oo._o.() Then
					A_1.HasMorePages = False
				End If
			End If
		End Sub

		' Token: 0x060029E4 RID: 10724 RVA: 0x00120830 File Offset: 0x0011EA30
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If String.IsNullOrEmpty(A_0) Then
				result = ""
			Else
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "|", vbTab)
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[PageNo]", "{0}")
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[PageCount]", "{1}")
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Today]", Strings.Format(DateTime.Today, "yyyy-MM-dd"))
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Time]", Strings.Format(DateTime.Now, "HH:mm:ss"))
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[ShortTime]", Strings.Format(DateTime.Now, "HH:mm"))
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Year]", DateTime.Today.Year.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Month]", DateTime.Today.Month.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Day]", DateTime.Today.Day.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Hour]", DateTime.Now.Hour.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Minute]", DateTime.Now.Minute.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Second]", DateTime.Now.Second.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[WeekDay]", DateTime.Today.DayOfWeek.ToString())
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableName]", Me.oO._0ooO_o0_..Table.DataTable.Name)
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x060029E5 RID: 10725 RVA: 0x00120A04 File Offset: 0x0011EC04
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As Integer, Optional A_3 As Boolean = True)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
				IL_10:
				num2 = 3
				If A_0 > A_1 OrElse A_0 < o_oOooO_O.Cols.Fixed OrElse A_1 > o_oOooO_O.Cols.Count - 1 Then
					GoTo IL_267
				End If
				IL_3D:
				num2 = 5
				If A_2 >= A_0 AndAlso A_2 <= A_1 Then
					GoTo IL_267
				End If
				IL_4A:
				num2 = 7
				Dim dragColumnEventArgs As DragColumnEventArgs = New DragColumnEventArgs(Me, A_0 - o_oOooO_O.Cols.Fixed, A_1 - o_oOooO_O.Cols.Fixed, A_2 - o_oOooO_O.Cols.Fixed)
				IL_7B:
				num2 = 8
				Dim a_ As String = "BeforeDragColumn"
				IL_84:
				num2 = 9
				O_O0OO.OoO_o.oO0o0O.(Me.DataTable.o_0_00_.oo0O0., a_, New Object() { dragColumnEventArgs }, False, Me.DataTable.Name, False)
				IL_B2:
				num2 = 10
				If dragColumnEventArgs.Cancel OrElse Not Me.DataTable.GlobalHandler.BeforeDragColumn Then
					GoTo IL_F2
				End If
				IL_D0:
				num2 = 11
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { dragColumnEventArgs }, False, "全局表事件", False)
				IL_F2:
				num2 = 12
				If dragColumnEventArgs.Cancel Then
					GoTo IL_267
				End If
				IL_101:
				num2 = 14
				If dragColumnEventArgs.Cancel Then
					GoTo IL_267
				End If
				IL_110:
				num2 = 16
				A_2 = dragColumnEventArgs.Position + o_oOooO_O.Cols.Fixed
				IL_128:
				num2 = 17
				If A_2 >= A_0 AndAlso A_2 <= A_1 Then
					GoTo IL_267
				End If
				IL_136:
				num2 = 19
				Dim a_2 As o_0oOOOOO__ = New o_0oOOOOO__(Me, A_0, A_1, A_2)
				IL_144:
				num2 = 20
				If Not(A_2 < A_0 And A_2 >= o_oOooO_O.Cols.Fixed) Then
					GoTo IL_190
				End If
				IL_15F:
				num2 = 21
				For i As Integer = A_0 To A_1
					IL_16A:
					num2 = 22
					o_oOooO_O.Cols(A_1).Move(A_2)
					IL_17F:
					num2 = 23
				Next
				GoTo IL_1DF
				IL_190:
				num2 = 25
				If Not(A_2 > A_0 And A_2 <= o_oOooO_O.Cols.Count - 1) Then
					GoTo IL_267
				End If
				IL_1B0:
				num2 = 26
				For j As Integer = A_0 To A_1
					IL_1BB:
					num2 = 27
					o_oOooO_O.Cols(A_0).Move(A_2)
					IL_1D0:
					num2 = 28
				Next
				IL_1DF:
				num2 = 31
				If Not A_3 Then
					GoTo IL_1F6
				End If
				IL_1E6:
				num2 = 32
				Me.O_o0OOo_.o0..O__00.__0_O.(a_2)
				IL_1F6:
				num2 = 33
				a_ = "AfterDragColumn"
				IL_200:
				num2 = 34
				O_O0OO.OoO_o.oO0o0O.(Me.DataTable.o_0_00_.oo0O0., a_, New Object() { dragColumnEventArgs }, False, Me.DataTable.Name, False)
				IL_22E:
				num2 = 35
				If Not Me.DataTable.GlobalHandler.AfterDragColumn Then
					GoTo IL_265
				End If
				IL_243:
				num2 = 36
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { dragColumnEventArgs }, False, "全局表事件", False)
				IL_265:
				o_oOooO_O = Nothing
				IL_267:
				GoTo IL_351
				IL_26C:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_312:
				GoTo IL_346
				IL_314:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_324:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_314
			End Try
			IL_346:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_351:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x170009EB RID: 2539
		' (get) Token: 0x060029E6 RID: 10726 RVA: 0x00120D88 File Offset: 0x0011EF88
		' (set) Token: 0x060029E7 RID: 10727 RVA: 0x00120D90 File Offset: 0x0011EF90
		Friend Property _frdDockArea As DockAreaEnum
			Get
				Return Me.o0__OOo0._oO.
			End Get
			Set(value As DockAreaEnum)
				Me.o0__OOo0._oO. = value
			End Set
		End Property

		' Token: 0x170009EC RID: 2540
		' (get) Token: 0x060029E8 RID: 10728 RVA: 0x00120D99 File Offset: 0x0011EF99
		' (set) Token: 0x060029E9 RID: 10729 RVA: 0x00120DA1 File Offset: 0x0011EFA1
		Friend Property _frdDockTitle As Boolean
			Get
				Return Me.O0oooo_o0o0.o.
			End Get
			Set(value As Boolean)
				Me.O0oooo_o0o0.o. = value
			End Set
		End Property

		' Token: 0x170009ED RID: 2541
		' (get) Token: 0x060029EA RID: 10730 RVA: 0x00120DAA File Offset: 0x0011EFAA
		' (set) Token: 0x060029EB RID: 10731 RVA: 0x00120DB2 File Offset: 0x0011EFB2
		Friend Property _frdAutoHide As Boolean
			Get
				Return Me.ooo.__00__0.
			End Get
			Set(value As Boolean)
				Me.ooo.__00__0. = value
			End Set
		End Property

		' Token: 0x170009EE RID: 2542
		' (get) Token: 0x060029EC RID: 10732 RVA: 0x00120DBB File Offset: 0x0011EFBB
		' (set) Token: 0x060029ED RID: 10733 RVA: 0x00120DC3 File Offset: 0x0011EFC3
		Friend Property _frdShowCaption As Boolean
			Get
				Return Me.Oo_oo_.o_.
			End Get
			Set(value As Boolean)
				Me.Oo_oo_.o_. = value
			End Set
		End Property

		' Token: 0x170009EF RID: 2543
		' (get) Token: 0x060029EE RID: 10734 RVA: 0x00120DCC File Offset: 0x0011EFCC
		' (set) Token: 0x060029EF RID: 10735 RVA: 0x00120DD4 File Offset: 0x0011EFD4
		Friend Property _frdAllowClose As Boolean
			Get
				Return Me.OO0.O__.
			End Get
			Set(value As Boolean)
				Me.OO0.O__. = value
			End Set
		End Property

		' Token: 0x170009F0 RID: 2544
		' (get) Token: 0x060029F0 RID: 10736 RVA: 0x00120DDD File Offset: 0x0011EFDD
		' (set) Token: 0x060029F1 RID: 10737 RVA: 0x00120DEA File Offset: 0x0011EFEA
		Friend Property _frdIcon As Image
			Get
				Return Me.DataTable.frd_Icon
			End Get
			Set(value As Image)
			End Set
		End Property

		' Token: 0x170009F1 RID: 2545
		' (get) Token: 0x060029F2 RID: 10738 RVA: 0x00120DEC File Offset: 0x0011EFEC
		' (set) Token: 0x060029F3 RID: 10739 RVA: 0x00120DF4 File Offset: 0x0011EFF4
		Friend Property _frdAutoOpen As Boolean
			Get
				Return Me.o.OO0O0O.
			End Get
			Set(value As Boolean)
				Me.o.OO0O0O. = value
			End Set
		End Property

		' Token: 0x060029F4 RID: 10740 RVA: 0x00120E00 File Offset: 0x0011F000
		Friend Function <<EMPTY_NAME>>(A_0 As Table, ParamArray A_1 As Decimal()) As Decimal
			Dim num As Integer
			Dim result As Decimal
			Dim num10 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Decimal = A_1(0)
				IL_12:
				num2 = 3
				Dim num4 As Decimal = A_1(1)
				IL_1D:
				num2 = 4
				Dim num5 As Integer = 1
				IL_22:
				num2 = 5
				For Each num6 As Decimal In A_1
					IL_37:
					num2 = 6
					Dim text As String = num6.ToString().Trim(New Char() { "0"c })
					IL_52:
					num2 = 7
					num5 = Math.Max(num5, text.Length - text.IndexOf(".") - 1)
					IL_73:
					num2 = 8
				Next
				IL_83:
				num2 = 9
				Dim num6 As Decimal = Decimal.Subtract(num4, Convert.ToDecimal(1.0 / Math.Pow(10.0, CDbl(num5))))
				IL_AF:
				num2 = 10
				If Decimal.Compare(num6, num3) > 0 AndAlso Decimal.Compare(num6, num4) < 0 Then
					GoTo IL_364
				End If
				IL_CD:
				num2 = 11
				If num5 + 1 <= 14 AndAlso Decimal.Compare(num3, num4) <> 0 Then
					GoTo IL_30D
				End If
				IL_E6:
				num2 = 12
				A_0.StopRedraw()
				IL_EF:
				num2 = 13
				OO_00oOO.SystemReady = False
				IL_F8:
				num2 = 14
				Dim rowFilter As String = A_0.View.o_o.O0ooOo.().RowFilter
				IL_10D:
				num2 = 15
				A_0.View.o_o.O0ooOo.().RowFilter = "False"
				IL_125:
				num2 = 16
				Dim obj As Object = Me.DataTable.BaseTable
				Dim array As DataRow()
				SyncLock obj
					array = Me.DataTable.BaseTable.[Select]("[_SortKey] >= " + Conversions.ToString(Math.Floor(num3)) + " And [_SortKey] <= " + Conversions.ToString(Math.Ceiling(num4)), "_SortKey")
				End SyncLock
				IL_18D:
				num2 = 17
				Dim num7 As Integer = array.Length
				IL_196:
				num2 = 18
				num5 = Convert.ToInt32(Math.Floor(Math.Log10(CDbl(array.Length)) + 1.0))
				IL_1B9:
				num2 = 19
				Dim num8 As Integer = array.Length - 1
				For j As Integer = 0 To num8
					IL_1CC:
					num2 = 20
					If Decimal.Compare(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(array(j)("_SortKey"))), num3) = 0 AndAlso num7 = array.Length Then
						IL_1F9:
						num2 = 21
						num6 = Decimal.Add(Math.Floor(num3), Convert.ToDecimal(1.0 / Math.Pow(10.0, CDbl(num5)) * CDbl((j + 1))))
						IL_230:
						num2 = 22
						num7 = j
					End If
					IL_237:
					num2 = 23
					If j <= num7 Then
						IL_240:
						num2 = 24
						array(j)("_SortKey") = Decimal.Add(Math.Floor(num3), Convert.ToDecimal(1.0 / Math.Pow(10.0, CDbl(num5)) * CDbl(j)))
					Else
						IL_289:
						num2 = 26
						array(j)("_SortKey") = Decimal.Add(Math.Floor(num3), Convert.ToDecimal(1.0 / Math.Pow(10.0, CDbl(num5)) * CDbl((j + 1))))
					End If
					IL_2D2:
					num2 = 27
				Next
				IL_2E4:
				num2 = 28
				A_0.View.o_o.O0ooOo.().RowFilter = rowFilter
				IL_2F9:
				num2 = 29
				OO_00oOO.SystemReady = True
				IL_302:
				num2 = 30
				A_0.ResumeRedraw()
				GoTo IL_364
				IL_30D:
				num2 = 32
				If num5 Mod 3 <> 0 Then
					GoTo IL_321
				End If
				IL_316:
				num2 = 33
				num5 += 1
				GoTo IL_32A
				IL_321:
				num2 = 35
				num5 += 2
				IL_32A:
				num2 = 36
				num5 = Math.Min(num5, 14)
				IL_338:
				num2 = 37
				num6 = Decimal.Subtract(num4, Convert.ToDecimal(1.0 / Math.Pow(10.0, CDbl(num5))))
				IL_364:
				num2 = 38
				result = num6
				IL_36A:
				GoTo IL_458
				IL_36F:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_419:
				GoTo IL_44D
				IL_41B:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_42B:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_41B
			End Try
			IL_44D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_458:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060029F5 RID: 10741 RVA: 0x001212A4 File Offset: 0x0011F4A4
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim num As Integer
			Dim num14 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As IEnumerator(Of SubtotalGroup) = Me.SubtotalGroups.GetEnumerator()
				While enumerator.MoveNext()
					Dim subtotalGroup As SubtotalGroup = enumerator.Current
					IL_22:
					num2 = 3
					If Operators.CompareString(subtotalGroup.GroupOn, A_0, True) = 0 Then
						IL_34:
						num2 = 4
						subtotalGroup.GroupOn = A_1
					End If
					IL_3E:
					num2 = 5
					If Operators.CompareString(subtotalGroup.TotalOn, "", True) > 0 Then
						IL_58:
						num2 = 6
						Dim array As String() = subtotalGroup.TotalOn.Split(New Char() { ","c })
						IL_73:
						num2 = 7
						Dim num3 As Integer = array.Length - 1
						For i As Integer = 0 To num3
							IL_82:
							num2 = 8
							If Operators.CompareString(array(i), A_0, True) = 0 Then
								IL_92:
								num2 = 9
								array(i) = A_1
							End If
							IL_9B:
							num2 = 10
						Next
						IL_AA:
						num2 = 11
						subtotalGroup.TotalOn = array(0)
						IL_B8:
						num2 = 12
						Dim num4 As Integer = array.Length - 1
						For j As Integer = 1 To num4
							IL_C8:
							num2 = 13
							subtotalGroup.TotalOn = subtotalGroup.TotalOn + "," + array(j)
							IL_E8:
							num2 = 14
						Next
					End If
					IL_F7:
					num2 = 15
				End While
				IL_105:
				num2 = 16
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_111:
				num2 = 17
				Dim num5 As Integer = Me.MergeCols.Count - 1
				For k As Integer = 0 To num5
					IL_128:
					num2 = 18
					If Operators.CompareString(Me.MergeCols(k), A_0, True) = 0 Then
						IL_141:
						num2 = 19
						Me.MergeCols(k) = A_1
					End If
					IL_152:
					num2 = 20
				Next
				IL_161:
				num2 = 21
				If Me.O_0._O_0OO000O. Is Nothing Then
					GoTo IL_241
				End If
				IL_16F:
				num2 = 22
				Dim num6 As Integer = Me.O_0._O_0OO000O..Groups.Count - 1
				For l As Integer = 0 To num6
					IL_18B:
					num2 = 23
					If Operators.CompareString(Me.O_0._O_0OO000O..Groups(l).Name, A_0, True) = 0 Then
						IL_1AE:
						num2 = 24
						Me.O_0._O_0OO000O..Groups(l).Name = A_1
					End If
					IL_1C9:
					num2 = 25
				Next
				IL_1D8:
				num2 = 26
				Dim num7 As Integer = Me.O_0._O_0OO000O..Totals.Count - 1
				For m As Integer = 0 To num7
					IL_1F4:
					num2 = 27
					If Operators.CompareString(Me.O_0._O_0OO000O..Totals(m).Name, A_0, True) = 0 Then
						IL_217:
						num2 = 28
						Me.O_0._O_0OO000O..Totals(m).Name = A_1
					End If
					IL_232:
					num2 = 29
				Next
				IL_241:
				num2 = 30
				If Me.O_0._O_0OO000O. Is Nothing Then
					GoTo IL_38A
				End If
				IL_24F:
				num2 = 31
				Dim num8 As Integer = Me.O_0._O_0OO000O..HGroups.Count - 1
				For n As Integer = 0 To num8
					IL_26B:
					num2 = 32
					If Operators.CompareString(Me.O_0._O_0OO000O..HGroups(n).Name, A_0, True) = 0 Then
						IL_28E:
						num2 = 33
						Me.O_0._O_0OO000O..HGroups(n).Name = A_1
					End If
					IL_2A9:
					num2 = 34
				Next
				IL_2B8:
				num2 = 35
				Dim num9 As Integer = Me.O_0._O_0OO000O..VGroups.Count - 1
				For num10 As Integer = 0 To num9
					IL_2D4:
					num2 = 36
					If Operators.CompareString(Me.O_0._O_0OO000O..VGroups(num10).Name, A_0, True) = 0 Then
						IL_2F7:
						num2 = 37
						Me.O_0._O_0OO000O..VGroups(num10).Name = A_1
					End If
					IL_312:
					num2 = 38
				Next
				IL_321:
				num2 = 39
				Dim num11 As Integer = Me.O_0._O_0OO000O..Totals.Count - 1
				For num12 As Integer = 0 To num11
					IL_33D:
					num2 = 40
					If Operators.CompareString(Me.O_0._O_0OO000O..Totals(num12).Name, A_0, True) = 0 Then
						IL_360:
						num2 = 41
						Me.O_0._O_0OO000O..Totals(num12).Name = A_1
					End If
					IL_37B:
					num2 = 42
				Next
				IL_38A:
				GoTo IL_488
				IL_38F:
				Dim num13 As Integer = num14 + 1
				num14 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num13)
				IL_449:
				GoTo IL_47D
				IL_44B:
				num14 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_45B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num14 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_44B
			End Try
			IL_47D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_488:
			If num14 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060029F6 RID: 10742 RVA: 0x00121760 File Offset: 0x0011F960
		<oO0oooo("1548")>
		Public Sub SetHeaderRowHeight(ParamArray Heights As Integer())
			Dim num As Integer = Math.Min(Heights.Length - 1, Me.foxGrid.Rows.Fixed - 1)
			For i As Integer = 0 To num
				Me.foxGrid.Rows(i).Height = Heights(i)
			Next
		End Sub

		' Token: 0x060029F7 RID: 10743 RVA: 0x001217B0 File Offset: 0x0011F9B0
		<oO0oooo("1551")>
		Public Sub AutoSizeHeaderRow()
			Dim num As Integer = Me.foxGrid.Rows.Fixed - 1
			For i As Integer = 0 To num
				Me.foxGrid.AutoSizeRow(i)
			Next
		End Sub

		' Token: 0x060029F8 RID: 10744 RVA: 0x001217E8 File Offset: 0x0011F9E8
		<oO0oooo("1552")>
		Public Sub AutoSizeRows(Optional extraSpace As Integer = 2)
			Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
			o_oOooO_O.AutoSizeRows(o_oOooO_O.Rows.Fixed, o_oOooO_O.Cols.Fixed, o_oOooO_O.Rows.Count - 1, o_oOooO_O.Cols.Count - 1, extraSpace, 6)
		End Sub

		' Token: 0x060029F9 RID: 10745 RVA: 0x00121836 File Offset: 0x0011FA36
		<oO0oooo("1564")>
		Public Sub AutoSizeRow(Index As Integer)
			Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
			o_oOooO_O.AutoSizeRow(o_oOooO_O.Rows.Fixed + Index)
		End Sub

		' Token: 0x060029FA RID: 10746 RVA: 0x00121854 File Offset: 0x0011FA54
		<oO0oooo("1554")>
		Public Sub AutoSizeCols(Optional extraSpace As Integer = 2)
			Me.foxGrid
			Dim o_oOooO_O As O_oOooO_O = Me.foxGrid
			o_oOooO_O.AutoSizeCols(0, o_oOooO_O.Cols.Fixed, o_oOooO_O.Rows.Count - 1, o_oOooO_O.Cols.Count - 1, extraSpace, 2)
		End Sub

		' Token: 0x060029FB RID: 10747 RVA: 0x001218A4 File Offset: 0x0011FAA4
		<oO0oooo("1553")>
		Public Sub AutoSizeCol(ColName As String, Optional extraSpace As Integer = 2)
			Dim index As Integer = Me.foxGrid.Cols(ColName).Index
			Me.foxGrid.AutoSizeCol(index, extraSpace)
		End Sub

		' Token: 0x060029FC RID: 10748 RVA: 0x001218D8 File Offset: 0x0011FAD8
		<oO0oooo("1550")>
		Public Sub SetHeaderCellFont(ColName As String, font As Font, Optional level As Integer = 0)
			Dim index As Integer = Me.foxGrid.Cols(ColName).Index
			Me.foxGrid.GetCellRange(level, index).StyleNew.Font = font
		End Sub

		' Token: 0x060029FD RID: 10749 RVA: 0x00121918 File Offset: 0x0011FB18
		<oO0oooo("1549")>
		Public Sub SetHeaderCellForeColor(ColName As String, color As Color, Optional level As Integer = 0)
			Dim index As Integer = Me.foxGrid.Cols(ColName).Index
			Me.foxGrid.GetCellRange(level, index).StyleNew.ForeColor = color
		End Sub

		' Token: 0x060029FE RID: 10750 RVA: 0x00121958 File Offset: 0x0011FB58
		<oO0oooo("2066")>
		Public Sub SetHeaderCellBackColor(ColName As String, color As Color, Optional Level As Integer = 0)
			Dim index As Integer = Me.foxGrid.Cols(ColName).Index
			Me.foxGrid.GetCellRange(Level, index).StyleNew.BackColor = color
		End Sub

		' Token: 0x170009F2 RID: 2546
		' (get) Token: 0x060029FF RID: 10751 RVA: 0x00121997 File Offset: 0x0011FB97
		' (set) Token: 0x06002A00 RID: 10752 RVA: 0x0012199F File Offset: 0x0011FB9F
		<oO0oooo("1779")>
		Public Property TableType As TableTypeEnum
			Get
				Return Me.oO._0ooO_o0_.
			End Get
			Friend Set(value As TableTypeEnum)
				Me.oO._0ooO_o0_. = value
			End Set
		End Property

		' Token: 0x170009F3 RID: 2547
		' (get) Token: 0x06002A01 RID: 10753 RVA: 0x001219A8 File Offset: 0x0011FBA8
		<oO0oooo("1780")>
		Public ReadOnly Property IsCopy As Boolean
			Get
				Return Me.View.O0O.o__0.()
			End Get
		End Property

		' Token: 0x170009F4 RID: 2548
		' (get) Token: 0x06002A02 RID: 10754 RVA: 0x001219B5 File Offset: 0x0011FBB5
		' (set) Token: 0x06002A03 RID: 10755 RVA: 0x001219BD File Offset: 0x0011FBBD
		<oO0oooo("1634")>
		Public Property ListMode As Boolean
			Get
				Return Me.oO00__O_.oO.
			End Get
			Set(value As Boolean)
				Me.oO00__O_.oO. = value
				If OO_00oOO.SystemReady Then
					Me.foxGrid.Oo0._0.()
				End If
				Me.foxGrid.Invalidate()
			End Set
		End Property

		' Token: 0x170009F5 RID: 2549
		' (get) Token: 0x06002A04 RID: 10756 RVA: 0x001219E3 File Offset: 0x0011FBE3
		' (set) Token: 0x06002A05 RID: 10757 RVA: 0x001219EB File Offset: 0x0011FBEB
		<oO0oooo("1774")>
		Public Property AllowClickSort As Boolean
			Get
				Return Me.O_0o__O0O0_0.0.
			End Get
			Set(value As Boolean)
				Me.O_0o__O0O0_0.0. = value
			End Set
		End Property

		' Token: 0x170009F6 RID: 2550
		' (get) Token: 0x06002A06 RID: 10758 RVA: 0x001219F4 File Offset: 0x0011FBF4
		' (set) Token: 0x06002A07 RID: 10759 RVA: 0x00121A0C File Offset: 0x0011FC0C
		<oO0oooo("1773")>
		Public Property RowHeaderVisible As Boolean
			Get
				Return Me.foxGrid.Cols(0).Visible
			End Get
			Set(value As Boolean)
				Me.foxGrid.Cols(0).Visible = value
			End Set
		End Property

		' Token: 0x170009F7 RID: 2551
		' (get) Token: 0x06002A08 RID: 10760 RVA: 0x00121A25 File Offset: 0x0011FC25
		' (set) Token: 0x06002A09 RID: 10761 RVA: 0x00121A4C File Offset: 0x0011FC4C
		<oO0oooo("1635")>
		Public Property ShowCheckBox As Boolean
			Get
				Return Me.foxGrid.Cols(0).DataType Is GetType(Boolean)
			End Get
			Set(value As Boolean)
				If value Then
					If Me.foxGrid.Cols(0).DataType IsNot GetType(Boolean) Then
						Me.foxGrid.Cols(0).Width = 25
						Me.foxGrid.Cols(0).DataType = GetType(Boolean)
						Return
					End If
				ElseIf Me.foxGrid.Cols(0).DataType Is GetType(Boolean) Then
					Me.foxGrid.Cols(0).DataType = GetType(String)
					Me.foxGrid.O.O00O_oO_OO00.(True)
				End If
			End Set
		End Property

		' Token: 0x06002A0A RID: 10762 RVA: 0x00121B08 File Offset: 0x0011FD08
		<oO0oooo("1636")>
		Public Function GetCheckedRows() As List(Of Row)
			Dim list As List(Of Row) = New List(Of Row)()
			Dim fixed As Integer = Me.foxGrid.Rows.Fixed
			Dim num As Integer = Me.foxGrid.Rows.Count - 1
			For i As Integer = fixed To num
				If Me.foxGrid.GetCellCheck(i, 0) = 1 AndAlso Me.foxGrid.Rows(i).DataIndex >= 0 Then
					list.Add(New Row(Me, Me.View.O0O_0_0__.0O.(Me.foxGrid.Rows(i).DataIndex)))
				End If
			Next
			Return list
		End Function

		' Token: 0x06002A0B RID: 10763 RVA: 0x00121BA0 File Offset: 0x0011FDA0
		<oO0oooo("1637")>
		Public Sub ClearCheckedRows()
			If Me.foxGrid.Cols(0).DataType Is GetType(Boolean) Then
				Dim fixed As Integer = Me.foxGrid.Rows.Fixed
				Dim num As Integer = Me.foxGrid.Rows.Count - 1
				For i As Integer = fixed To num
					If Me.foxGrid.Rows(i).DataIndex >= 0 Then
						Me.foxGrid.SetCellCheck(i, 0, 2)
					End If
				Next
			End If
		End Sub

		' Token: 0x170009F8 RID: 2552
		' (set) Token: 0x06002A0C RID: 10764 RVA: 0x00121C24 File Offset: 0x0011FE24
		<oO0oooo("1778")>
		Public WriteOnly Property DataSource As Object
			Set(value As Object)
				Dim num As Integer
				Dim num4 As Integer
				Dim obj4 As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Dim obj As Object = RuntimeHelpers.GetObjectValue(value)
					IL_10:
					num2 = 3
					Dim dataTable As DataTable = Nothing
					IL_15:
					num2 = 4
					If Me.TableType Is Nothing AndAlso Not Me.IsCopy Then
						GoTo IL_974
					End If
					IL_2A:
					num2 = 6
					Me.foxGrid.BeginUpdate()
					IL_37:
					num2 = 7
					If Not(TypeOf value Is DataTable) Then
						GoTo IL_73
					End If
					IL_41:
					num2 = 8
					Dim dataTable2 As DataTable = CType(value, DataTable).BaseTable
					IL_50:
					num2 = 9
					If dataTable2.DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
						GoTo IL_73
					End If
					IL_61:
					num2 = 10
					dataTable = CType(value, DataTable)
					IL_6C:
					num2 = 11
					value = dataTable2
					IL_73:
					num2 = 12
					If Not(TypeOf value Is DataTable) Then
						GoTo IL_307
					End If
					IL_81:
					num2 = 13
					Dim dataTable3 As DataTable = CType(value, DataTable).BaseTable
					IL_91:
					num2 = 14
					If Me.TableType Is Nothing Then
						GoTo IL_FF
					End If
					IL_9C:
					num2 = 15
					If Me.DataTable.BaseTable.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() OrElse Operators.CompareString(Me.DataTable.BaseTable.TableName, Me.Name, True) <> 0 Then
						GoTo IL_EC
					End If
					IL_D4:
					num2 = 16
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(Me.Name)
					IL_EC:
					num2 = 17
					OO_00oOO.DataTables.OoO_00.O.(Me.Name)
					IL_FF:
					num2 = 18
					Me.TableType = 0
					IL_109:
					num2 = 19
					Dim o_ As O_0 = O_O0OO.o__.O.()(Me.View.Oo._Oo0OO.())
					IL_123:
					num2 = 20
					O_O0OO.o__.O.().Remove(Me.View.Oo._Oo0OO.())
					IL_13C:
					num2 = 21
					Dim dataSource As O_0 = New O_0(dataTable3, Me.View.Oo._Oo0OO.())
					IL_153:
					num2 = 22
					Me.o.0ooOO_0__. = dataSource
					IL_15E:
					num2 = 23
					Me.o.0ooOO_0__..O00o0.0_0O_.()
					IL_16C:
					num2 = 24
					Me.foxGrid.DataSource = dataSource
					IL_17C:
					num2 = 25
					Me.Cols.Reset()
					IL_18A:
					num2 = 26
					Me.oO_o_0o._0oooo.(True)
					IL_194:
					num2 = 27
					Dim enumerator As IEnumerator = Me.foxGrid.Styles.GetEnumerator()
					While enumerator.MoveNext()
						Dim obj2 As Object = enumerator.Current
						Dim cellStyle As CellStyle = CType(obj2, CellStyle)
						IL_1B9:
						num2 = 28
						If Operators.CompareString(Conversions.ToString(cellStyle.UserData), "User", True) = 0 Then
							IL_1D5:
							num2 = 29
							Me.foxGrid.Styles.Remove(cellStyle)
						End If
						IL_1EA:
						num2 = 30
					End While
					IL_1F6:
					num2 = 31
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
					IL_20E:
					num2 = 32
					If Not OO_00oOO.Tables.get_Contains(dataTable3.TableName) Then
						GoTo IL_2DC
					End If
					IL_227:
					num2 = 33
					Dim enumerator2 As IEnumerator = OO_00oOO.Tables(dataTable3.TableName).Grid.Styles.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj3 As Object = enumerator2.Current
						Dim cellStyle2 As CellStyle = CType(obj3, CellStyle)
						IL_25C:
						num2 = 34
						If Not Me.foxGrid.Styles.Contains(cellStyle2.Name) Then
							IL_278:
							num2 = 35
							Me.foxGrid.Styles.Add(cellStyle2.Name, cellStyle2)
						Else
							IL_297:
							num2 = 37
							Me.foxGrid.Styles(cellStyle2.Name).MergeWith(cellStyle2)
						End If
						IL_2B8:
						num2 = 38
					End While
					IL_2C4:
					num2 = 39
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
					IL_2DC:
					num2 = 40
					Me.View.o_._0O0o_OoO.()
					IL_2EA:
					num2 = 41
					Me.View.Oo._Oo0OO.()
					IL_2F8:
					num2 = 42
					o_.Dispose()
					GoTo IL_7D5
					IL_307:
					num2 = 44
					If Not(TypeOf value Is DataTable) Then
						GoTo IL_7D5
					End If
					IL_315:
					num2 = 45
					Dim dataTable4 As DataTable = CType(value, DataTable)
					IL_320:
					num2 = 46
					Dim o000_00._0_o. As Boolean = True
					IL_326:
					num2 = 47
					dataTable4.TableName = Me.Name
					IL_336:
					num2 = 48
					If Me.TableType IsNot Nothing Then
						GoTo IL_386
					End If
					IL_341:
					num2 = 49
					If dataTable4.DataSet IsNot Nothing Then
						GoTo IL_361
					End If
					IL_34D:
					num2 = 50
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable4)
					IL_361:
					num2 = 51
					OO_00oOO.DataTables.OO0o00.0O_0o.(New DataTable(dataTable4, Nothing, Nothing, "", O_O0OO.OoO.0OO__0ooo.()))
					GoTo IL_4D8
					IL_386:
					num2 = 53
					If dataTable4.Columns.Contains("_Locked") Then
						GoTo IL_3C1
					End If
					IL_39C:
					num2 = 54
					dataTable4.Columns.Add("_Locked", GetType(Boolean))
					IL_3BB:
					num2 = 55
					o000_00._0_o. = False
					IL_3C1:
					num2 = 56
					If dataTable4.Columns.Contains("System_Sort_Temporary") Then
						GoTo IL_434
					End If
					IL_3D7:
					num2 = 57
					dataTable4.Columns.Add("System_Sort_Temporary", GetType(Double))
					IL_3F6:
					num2 = 58
					dataTable4.Columns.Add("System_Filter_Temporary", GetType(Integer))
					IL_415:
					num2 = 59
					dataTable4.Columns.Add("System_Filter_Unique", GetType(Integer))
					IL_434:
					num2 = 60
					If Me.DataTable.BaseTable.DataSet IsNot O_O0OO.OOOo.oo_OOOO_0.() OrElse Operators.CompareString(Me.DataTable.BaseTable.TableName, Me.Name, True) <> 0 Then
						GoTo IL_484
					End If
					IL_46C:
					num2 = 61
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(Me.Name)
					IL_484:
					num2 = 62
					If dataTable4.DataSet IsNot Nothing Then
						GoTo IL_4A4
					End If
					IL_490:
					num2 = 63
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable4)
					IL_4A4:
					num2 = 64
					OO_00oOO.DataTables(Me.Name).BaseTable = dataTable4
					IL_4BE:
					num2 = 65
					OO_00oOO.DataTables(Me.Name).O000_00._0_o. = o000_00._0_o.
					IL_4D8:
					num2 = 66
					OO_00oOO.DataTables(Me.Name).o.0O000_.()
					IL_4F0:
					num2 = 67
					OO_00oOO.DataTables(Me.Name).AddByCode = True
					IL_509:
					num2 = 68
					If dataTable Is Nothing Then
						GoTo IL_5C4
					End If
					IL_513:
					num2 = 69
					Dim dataTable5 As DataTable = OO_00oOO.DataTables(Me.Name)
					IL_528:
					num2 = 70
					dataTable5._Adapter = dataTable._Adapter
					IL_539:
					num2 = 71
					dataTable5.o._OOO0oOo0__. = dataTable.o._OOO0oOo0__.
					IL_54A:
					num2 = 72
					dataTable5.o0__.Oo0o__O. = dataTable.o0__.Oo0o__O.
					IL_55B:
					num2 = 73
					dataTable5.ConnectionName = dataTable.ConnectionName
					IL_56C:
					num2 = 74
					dataTable5.OO00.oO_. = dataTable.OO00.oO_.
					IL_57D:
					num2 = 75
					dataTable5.DataServer = dataTable.DataServer
					IL_58E:
					num2 = 76
					dataTable5.HttpSelect = dataTable.HttpSelect
					IL_59F:
					num2 = 77
					dataTable5.UpdateServer = dataTable.UpdateServer
					IL_5B0:
					num2 = 78
					dataTable5.UpdateColumns = dataTable.UpdateColumns
					IL_5C1:
					dataTable5 = Nothing
					IL_5C4:
					num2 = 80
					Dim enumerator3 As IEnumerator(Of DataCol) = OO_00oOO.DataTables(Me.Name).DataCols.GetEnumerator()
					While enumerator3.MoveNext()
						Dim dataCol As DataCol = enumerator3.Current
						IL_5EE:
						num2 = 81
						If dataCol.BaseColumn.ExtendedProperties.ContainsKey("IsTimeSpan") Then
							IL_609:
							num2 = 82
							dataCol.ExtendColumnType = 8
						End If
						IL_614:
						num2 = 83
					End While
					IL_620:
					num2 = 84
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
					IL_62E:
					num2 = 85
					Dim dataTable6 As DataTable = OO_00oOO.DataTables(Me.Name)
					IL_643:
					num2 = 86
					If dataTable6._Adapter Is Nothing OrElse Operators.CompareString(dataTable6.o._OOO0oOo0__., "", True) <= 0 Then
						GoTo IL_670
					End If
					IL_664:
					num2 = 87
					Me.TableType = 1
					GoTo IL_6B3
					IL_670:
					num2 = 89
					If Operators.CompareString(dataTable6.DataServer, "", True) <= 0 OrElse Operators.CompareString(dataTable6.UpdateServer, "", True) <= 0 Then
						GoTo IL_6A9
					End If
					IL_69D:
					num2 = 90
					Me.TableType = 1
					GoTo IL_6B3
					IL_6A9:
					num2 = 92
					Me.TableType = 2
					IL_6B3:
					dataTable6 = Nothing
					IL_6B6:
					num2 = 94
					Dim enumerator4 As IEnumerator(Of DataCol) = OO_00oOO.DataTables(Me.Name).DataCols.GetEnumerator()
					While enumerator4.MoveNext()
						Dim dataCol2 As DataCol = enumerator4.Current
						IL_6E0:
						num2 = 95
						dataCol2.Caption = dataCol2.BaseColumn.Caption
						IL_6F6:
						num2 = 96
						dataCol2.BaseColumn.Caption = ""
						IL_70A:
						num2 = 97
					End While
					IL_716:
					num2 = 98
					If enumerator4 IsNot Nothing Then
						enumerator4.Dispose()
					End If
					IL_724:
					num2 = 99
					Dim o_2 As O_0 = O_O0OO.o__.O.()(Me.View.Oo._Oo0OO.())
					IL_73E:
					num2 = 100
					O_O0OO.o__.O.().Remove(Me.View.Oo._Oo0OO.())
					IL_757:
					num2 = 101
					Dim dataSource2 As O_0 = New O_0(dataTable4, Me.View.Oo._Oo0OO.())
					IL_76E:
					num2 = 102
					Me.o.0ooOO_0__. = dataSource2
					IL_779:
					num2 = 103
					Me.o.0ooOO_0__..O00o0.0_0O_.()
					IL_787:
					num2 = 104
					Me.foxGrid.DataSource = dataSource2
					IL_797:
					num2 = 105
					Me.Cols.Reset()
					IL_7A5:
					num2 = 106
					Me.oO_o_0o._0oooo.(True)
					IL_7AF:
					num2 = 107
					Me.View.o_._0O0o_OoO.()
					IL_7BD:
					num2 = 108
					Me.View.Oo._Oo0OO.()
					IL_7CB:
					num2 = 109
					o_2.Dispose()
					IL_7D5:
					num2 = 110
					If Not(TypeOf obj Is fxDataSource2) Then
						GoTo IL_7EF
					End If
					IL_7E0:
					num2 = 111
					obj = CType(obj, fxDataSource2).DataSource
					IL_7EF:
					num2 = 112
					If Not(TypeOf obj Is fxDataSource) Then
						GoTo IL_917
					End If
					IL_7FD:
					num2 = 113
					Dim fxDataSource As fxDataSource = CType(obj, fxDataSource)
					IL_808:
					num2 = 114
					If fxDataSource.O_O_O.00. Is Nothing Then
						GoTo IL_847
					End If
					IL_814:
					num2 = 115
					If Not fxDataSource.O_O_O.00..Subtotal Then
						GoTo IL_884
					End If
					IL_825:
					num2 = 116
					fxDataSource.O_O_O.00..oO0.O00oO.(Me.Name, Me.DataTable.BaseTable)
					GoTo IL_884
					IL_847:
					num2 = 118
					If fxDataSource.O_O_O.00. Is Nothing Then
						GoTo IL_884
					End If
					IL_853:
					num2 = 119
					If Not fxDataSource.O_O_O.00..Subtotal Then
						GoTo IL_884
					End If
					IL_864:
					num2 = 120
					fxDataSource.O_O_O.00..o_o00_O.0_oo.(Me.Name, Me.DataTable.BaseTable)
					IL_884:
					num2 = 121
					Dim enumerator5 As IEnumerator(Of DataCol) = Me.DataTable.DataCols.GetEnumerator()
					While enumerator5.MoveNext()
						Dim dataCol3 As DataCol = enumerator5.Current
						IL_8A4:
						num2 = 122
						If dataCol3.DataType Is GetType(Double) Then
							IL_8BA:
							num2 = 123
							If dataCol3.BaseColumn.ExtendedProperties.Contains("displayformat") Then
								IL_8D5:
								num2 = 124
								dataCol3.SetFormat(dataCol3.BaseColumn.ExtendedProperties("displayformat").ToString())
							End If
						End If
						IL_8FA:
						num2 = 125
					End While
					IL_906:
					num2 = 126
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
					IL_914:
					fxDataSource = Nothing
					IL_917:
					num2 = 128
					Me.foxGrid.EndUpdate()
					IL_928:
					num2 = 129
					Me.foxGrid.EndUpdate()
					IL_939:
					num2 = 130
					Me.foxGrid.EndUpdate()
					IL_94A:
					num2 = 131
					Me.foxGrid.Enabled = True
					IL_95C:
					num2 = 132
					Me.RaiseCurrentChanged()
					IL_968:
					num2 = 133
					Me.RaisePositionChanged()
					IL_974:
					GoTo IL_BDE
					IL_979:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_B9F:
					GoTo IL_BD3
					IL_BA1:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_BB1:
				Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj5, Exception)
					GoTo IL_BA1
				End Try
				IL_BD3:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_BDE:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x06002A0D RID: 10765 RVA: 0x00122834 File Offset: 0x00120A34
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Fill(ParamArray args As Object())
			Dim num As Integer = args.Length
			If num = 2 Then
				Me.Fill(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)))
				Return
			End If
			If num <> 3 Then
				Return
			End If
			Me.Fill(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2)))
		End Sub

		' Token: 0x06002A0E RID: 10766 RVA: 0x00122883 File Offset: 0x00120A83
		<oO0oooo("1777")>
		Public Sub Fill(SelectString As String, IsQuery As Boolean)
			Me.Fill(SelectString, "", IsQuery)
		End Sub

		' Token: 0x06002A0F RID: 10767 RVA: 0x00122894 File Offset: 0x00120A94
		<oO0oooo("1777")>
		Public Sub Fill(SelectString As String, connName As String, IsQuery As Boolean)
			Me.foxGrid.BeginUpdate()
			Try
				Me.DataTable.o0O_ooo__.O0o_.()
				If Me.TableType IsNot Nothing Then
					Me.DataTable.Fill(SelectString, connName, IsQuery)
					Me.DataTable.AddByCode = True
					If IsQuery Then
						Me.TableType = 2
					Else
						Me.TableType = 1
					End If
				ElseIf Me.IsCopy Then
					Dim oleDbConnection As OleDbConnection = Nothing
					Dim o0O As O0O = Nothing
					Dim httpClient As HttpClient = Nothing
					If Operators.CompareString(connName, "", True) = 0 Then
						oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
					ElseIf O_O0OO.O._o_.().ContainsKey(connName) Then
						oleDbConnection = O_O0OO.O._o_.()(connName)
					ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(connName) Then
						o0O = O_O0OO.OoO__.0oO0oo.()(connName)
					End If
					Dim a_ As String = ""
					Dim text As String = Me.View.Oo._Oo0OO.()
					If Not IsQuery Then
						a_ = "?"
					End If
					OO_00oOO.SystemReady = False
					Dim component As Component = Me.View
					O_O0OO.o__.O.().Remove(text)
					If oleDbConnection IsNot Nothing Then
						SelectString = Oo00.o0_o._O_.(oleDbConnection, SelectString, False)
					Else
						SelectString = Oo00.o0_o._O_.(o0O.OO.OoO0., SelectString, False)
						httpClient = o0O.oO0_0.o.()
						httpClient.[Select] = SelectString
						If Not IsQuery Then
							httpClient.FormData("Action") = 1.ToString()
						Else
							httpClient.FormData("Action") = 2.ToString()
						End If
					End If
					o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, SelectString, text, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_, True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), Me.DataTable.FillLoadTimeOut, Nothing, connName, httpClient)
					OO_00oOO.DataTables(text).o.0O000_.()
					OO_00oOO.DataTables(text).AddByCode = True
					If Me.o0__OOo0._oO. IsNot Nothing Then
						OO_00oOO.DataTables(text).o_0_00_.oo0O0. = Me.o0__OOo0._oO.
						OO_00oOO.DataTables(text).o0O.O_0.(OO_00oOO.DataTables(text).o_0_00_.oo0O0.)
					End If
					Me.o.0ooOO_0__. = O_O0OO.o__.O.()(text)
					Me.foxGrid.DataSource = Me.o.0ooOO_0__.
					Me.Cols.Reset()
					Me.oO_o_0o._0oooo.(True)
					component.Dispose()
					If IsQuery Then
						Me.TableType = 2
						Me.DataTable.AllowEdit = False
					Else
						Me.TableType = 1
					End If
					OO_00oOO.SystemReady = True
					Me.View.o_._0O0o_OoO.()
					Me.View.Oo._Oo0OO.()
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				OO_00oOO.SystemReady = True
				Me.foxGrid.EndUpdate()
			End Try
		End Sub

		' Token: 0x170009F9 RID: 2553
		' (get) Token: 0x06002A10 RID: 10768 RVA: 0x00122B58 File Offset: 0x00120D58
		' (set) Token: 0x06002A11 RID: 10769 RVA: 0x00122B74 File Offset: 0x00120D74
		Friend Property _frdTableLayout As OOO0o
			Get
				If Me.oO._0ooO_o0_. Is Nothing Then
					Me.oO._0ooO_o0_. = New OOO0o(Me)
				End If
				Return Me.oO._0ooO_o0_.
			End Get
			Set(value As OOO0o)
			End Set
		End Property

		' Token: 0x06002A12 RID: 10770 RVA: 0x00122B78 File Offset: 0x00120D78
		<oO0oooo("1775")>
		Public Sub SetColVisibleWidth(setting As String)
			Dim dictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
			Dim array As String() = setting.Split(New Char() { "|"c })
			Dim num As Integer = array.Length - 2
			For i As Integer = 0 To num Step 2
				Dim value As Integer
				If Operators.CompareString(array(i), "", True) > 0 AndAlso Operators.CompareString(array(i + 1), "", True) > 0 AndAlso Integer.TryParse(array(i + 1), value) Then
					dictionary.Add(array(i), value)
				End If
			Next
			Me.foxGrid.BeginUpdate()
			Try
				Try
					For Each col As Col In Me.Cols
						col.Visible = dictionary.ContainsKey(col.Name)
						If col.Visible Then
							col.Width = dictionary(col.Name)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Col)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Dim num2 As Integer = Me.foxGrid.Cols.Fixed
				Try
					For Each text As String In dictionary.Keys
						If Operators.CompareString(text, "", True) > 0 AndAlso Me.foxGrid.Cols.Contains(text) Then
							Me.foxGrid.Cols(text).Move(num2)
							num2 += 1
						End If
					Next
				Finally
					Dim enumerator2 As Dictionary(Of String, Integer).KeyCollection.Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.foxGrid.EndUpdate()
			End Try
		End Sub

		' Token: 0x06002A13 RID: 10771 RVA: 0x00122D6C File Offset: 0x00120F6C
		<oO0oooo("2496")>
		Public Function GetColVisibleWidth() As String
			Dim text As String = ""
			Try
				For Each col As Col In Me.Cols
					If col.Visible Then
						text = String.Concat(New String() { text, col.Name, "|", Conversions.ToString(Me.foxGrid.Cols(col.Name).WidthDisplay), "|" })
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Col)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return text.Trim(New Char() { "|"c })
		End Function

		' Token: 0x06002A14 RID: 10772 RVA: 0x00122E20 File Offset: 0x00121020
		<oO0oooo("2367")>
		Public Sub RaiseCurrentChanged()
			Me.View.o_._0O0o_OoO.()
		End Sub

		' Token: 0x06002A15 RID: 10773 RVA: 0x00122E2D File Offset: 0x0012102D
		<oO0oooo("2367")>
		Public Sub RaisePositionChanged()
			Me.View.Oo._Oo0OO.()
		End Sub

		' Token: 0x170009FA RID: 2554
		' (get) Token: 0x06002A16 RID: 10774 RVA: 0x00122E3A File Offset: 0x0012103A
		' (set) Token: 0x06002A17 RID: 10775 RVA: 0x00122E4C File Offset: 0x0012104C
		<oO0oooo("1662")>
		Public Property DefaultRowHeight As Integer
			Get
				Return Me.foxGrid.Rows.DefaultSize
			End Get
			Set(value As Integer)
				Me.foxGrid.Rows.DefaultSize = value
			End Set
		End Property

		' Token: 0x170009FB RID: 2555
		' (get) Token: 0x06002A18 RID: 10776 RVA: 0x00122E5F File Offset: 0x0012105F
		' (set) Token: 0x06002A19 RID: 10777 RVA: 0x00122E71 File Offset: 0x00121071
		<oO0oooo("2651")>
		Public Property DefaultColWidth As Integer
			Get
				Return Me.foxGrid.Cols.DefaultSize
			End Get
			Set(value As Integer)
				Me.foxGrid.Cols.DefaultSize = value
			End Set
		End Property

		' Token: 0x170009FC RID: 2556
		' (get) Token: 0x06002A1A RID: 10778 RVA: 0x00122E84 File Offset: 0x00121084
		' (set) Token: 0x06002A1B RID: 10779 RVA: 0x00122E94 File Offset: 0x00121094
		<oO0oooo("1923")>
		Public Property FocusRect As Boolean
			Get
				Return Me.foxGrid.FocusRect > 0
			End Get
			Set(value As Boolean)
				If value Then
					Me.foxGrid.FocusRect = 3
					Me.foxGrid.HighLight = 1
					Return
				End If
				Me.foxGrid.FocusRect = 0
				Me.foxGrid.HighLight = 0
			End Set
		End Property

		' Token: 0x170009FD RID: 2557
		' (get) Token: 0x06002A1C RID: 10780 RVA: 0x00122ECA File Offset: 0x001210CA
		' (set) Token: 0x06002A1D RID: 10781 RVA: 0x00122ED2 File Offset: 0x001210D2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SpillNode As Boolean
			Get
				Return Me.Oo_0o.0.
			End Get
			Set(value As Boolean)
				Me.Oo_0o.0. = value
			End Set
		End Property

		' Token: 0x06002A1E RID: 10782 RVA: 0x00122EDB File Offset: 0x001210DB
		Public Sub SetRowHeight(Index As Integer, Height As Integer)
			Me.foxGrid.Rows(Index + Me.foxGrid.Rows.Fixed).Height = Height
		End Sub

		' Token: 0x06002A1F RID: 10783 RVA: 0x00122F05 File Offset: 0x00121105
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetLayersBOMTree()
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.
			Me.SetLayersTree()
		End Sub

		' Token: 0x06002A20 RID: 10784 RVA: 0x00122F14 File Offset: 0x00121114
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetLayersFilterTree()
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.
			Me.SetLayersTree()
		End Sub

		' Token: 0x06002A21 RID: 10785 RVA: 0x00122F24 File Offset: 0x00121124
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetLayersTree()
			If Me.TableType Is Nothing AndAlso Not Me.IsCopy AndAlso Not Me.IsRelation Then
				Me.NeedSaveSetting = True
				New o\u3000\u3002\u3000\u3002\u3000\u3002(Me, Me.o00oOO00_.ooOo.).ShowDialog(Main.OO_O.o.)
				Return
			End If
			MessageBox.Show("只有主表才能设置多级分类树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06002A22 RID: 10786 RVA: 0x00122F7B File Offset: 0x0012117B
		Public Sub OpenLayersBOMTree(ParamArray args As Object())
			If args.Length = 0 Then
				Me.OpenLayersBOMTree()
				Return
			End If
			If args.Length = 1 Then
				Me.OpenLayersBOMTree(CType(args(0), LayerTreeSetting), -1)
				Return
			End If
			If args.Length = 2 Then
				Me.OpenLayersBOMTree(CType(args(0), LayerTreeSetting), Conversions.ToInteger(args(1)))
			End If
		End Sub

		' Token: 0x06002A23 RID: 10787 RVA: 0x00122FBC File Offset: 0x001211BC
		<oO0oooo("3354")>
		Public Sub OpenLayersBOMTree(setting As LayerTreeSetting, Optional Size As Integer = -1)
			Me.Oo_oOo_.O0_.(O0_0_0O0___O.OOO.__O_oO_., setting.PathCol, setting.TextCol, setting.ValueCol, setting.SortCol, setting.SortDesc, setting.Separator2, setting.Lengths2, setting.IncludeSub, setting.Subtotal, setting.GridTree, setting.ExpandTo <> 0, setting.Unique, Size <> 0, 0)
		End Sub

		' Token: 0x06002A24 RID: 10788 RVA: 0x00123020 File Offset: 0x00121220
		<oO0oooo("3354")>
		Public Sub OpenLayersBOMTree()
			If Me.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_. AndAlso Operators.CompareString(Me.o_O_0._O_., "", True) > 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.o_O_0._O_.) AndAlso (Operators.CompareString(Conversions.ToString(Me.o00oOO00_.ooOo.), "", True) > 0 OrElse Operators.CompareString(Me.oo.o0o0O_o_., "", True) > 0) Then
				Me.OpenLayersTree()
				Return
			End If
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.
			Me.SetLayersTree()
		End Sub

		' Token: 0x06002A25 RID: 10789 RVA: 0x001230A7 File Offset: 0x001212A7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenLayersFilterTree(ParamArray args As Object())
			If args.Length = 0 Then
				Me.OpenLayersFilterTree()
				Return
			End If
			If args.Length = 1 Then
				Me.OpenLayersFilterTree(CType(args(0), LayerTreeSetting), -1)
				Return
			End If
			If args.Length = 2 Then
				Me.OpenLayersFilterTree(CType(args(0), LayerTreeSetting), Conversions.ToInteger(args(1)))
			End If
		End Sub

		' Token: 0x06002A26 RID: 10790 RVA: 0x001230E8 File Offset: 0x001212E8
		<oO0oooo("3356")>
		Public Sub OpenLayersFilterTree(setting As LayerTreeSetting, Optional Size As Integer = -1)
			Me.Oo_oOo_.O0_.(O0_0_0O0___O.oOO___o.0oO., setting.PathCol, setting.TextCol, setting.ValueCol, setting.SortCol, setting.SortDesc, setting.Separator2, setting.Lengths2, setting.IncludeSub, setting.Subtotal, setting.GridTree, setting.ExpandTo <> 0, setting.Unique, setting.MergeTotal, Size)
		End Sub

		' Token: 0x06002A27 RID: 10791 RVA: 0x00123150 File Offset: 0x00121350
		<oO0oooo("3356")>
		Public Sub OpenLayersFilterTree()
			If Me.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO. AndAlso Operators.CompareString(Me.o_O_0._O_., "", True) > 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.o_O_0._O_.) AndAlso (Operators.CompareString(Conversions.ToString(Me.o00oOO00_.ooOo.), "", True) > 0 OrElse Operators.CompareString(Me.oo.o0o0O_o_., "", True) > 0) Then
				Me.OpenLayersTree()
				Return
			End If
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.
			Me.SetLayersTree()
		End Sub

		' Token: 0x06002A28 RID: 10792 RVA: 0x001231D8 File Offset: 0x001213D8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenLayersTree()
			' The following expression was wrapped in a checked-statement
			If Operators.CompareString(Me.o_O_0._O_., "", True) > 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.o_O_0._O_.) Then
				If Operators.CompareString(Conversions.ToString(Me.o00oOO00_.ooOo.), "", True) > 0 Then
					Me.Oo_oOo_.O0_.(Me.o00oOO00_.ooOo., Me.o_O_0._O_., Me.ooO0o.o_O., Me.Oo_0o_O0._., Me.ooo._Ooo., Me.O0_.__o00_., Me.o00oOO00_.ooOo., Nothing, Me.oo_o_.oOO., Me.O.O000., Me.O0oO0_._0., Me.o.0o00ooo_. <> 0, Me.OOoOO.OO0., Me.ooo_Ooo0.__., 0)
					Return
				End If
				If Me.oo.o0o0O_o_..Length > 0 Then
					Dim array As String() = Regex.Split(Me.oo.o0o0O_o_., "[^\d]+")
					Dim list As List(Of Integer) = New List(Of Integer)()
					Dim array2 As String() = array
					For i As Integer = 0 To array2.Length - 1
						Dim item As Integer
						If Integer.TryParse(array2(i), item) Then
							list.Add(item)
						End If
					Next
					Me.Oo_oOo_.O0_.(Me.o00oOO00_.ooOo., Me.o_O_0._O_., Me.ooO0o.o_O., Me.Oo_0o_O0._., Me.ooo._Ooo., Me.O0_.__o00_., Me.o00oOO00_.ooOo., list.ToArray(), Me.oo_o_.oOO., Me.O.O000., Me.O0oO0_._0., Me.o.0o00ooo_. <> 0, Me.OOoOO.OO0., Me.ooo_Ooo0.__., 0)
					Return
				End If
			End If
			Me.SetLayersTree()
		End Sub

		' Token: 0x06002A29 RID: 10793 RVA: 0x00123340 File Offset: 0x00121540
		Private Sub <<EMPTY_NAME>>(A_0 As O0_0_0O0___O, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As Boolean, A_6 As Char, A_7 As Integer(), A_8 As Boolean, A_9 As Boolean, A_10 As Boolean, A_11 As Boolean, A_12 As Boolean, A_13 As Boolean, Optional A_14 As Integer = 0)
			If A_0 = O0_0_0O0___O.OOO.__O_oO_. Then
				A_12 = True
			End If
			If Me.o.0ooOO_0__. IsNot Nothing Then
				If Me.o.0ooOO_0__..Disposing OrElse Me.o.0ooOO_0__..IsDisposed Then
					Me.o.0ooOO_0__. = Nothing
				ElseIf Not(TypeOf Me.o.0ooOO_0__. Is oO_oo0Oo) OrElse CType(Me.o.0ooOO_0__., oO_oo0Oo).OO_0._O_. <> A_0 Then
					Me.CloseFilterTree()
					Me.o.0ooOO_0__. = Nothing
				End If
			End If
			If Me.TableType Is Nothing AndAlso Not Me.IsCopy AndAlso Not Me.IsRelation Then
				If Me.o.0ooOO_0__. IsNot Nothing AndAlso TypeOf Me.o.0ooOO_0__. Is oO_oo0Oo Then
					Dim oO_oo0Oo As oO_oo0Oo = CType(Me.o.0ooOO_0__., oO_oo0Oo)
					oO_oo0Oo.oo.00__O0o. = A_1
					If Operators.CompareString(A_2, "", True) > 0 Then
						oO_oo0Oo.OO0_0O._oO0O_o. = A_2
					Else
						oO_oo0Oo.OO0_0O._oO0O_o. = oO_oo0Oo.oo.00__O0o.
					End If
					oO_oo0Oo.OO_0._O_. = A_0
					oO_oo0Oo.oo__._0. = A_3
					oO_oo0Oo.o_._O0___O. = A_4
					oO_oo0Oo.oOo.O. = A_5
					oO_oo0Oo.o0ooOo0.0o_Oo. = A_10
					oO_oo0Oo.OOOOO0.0. = If((-If((A_11 > False), 1, 0)), 1, 0)
					oO_oo0Oo.OO_0o0.O_o_. = A_8
					oO_oo0Oo.OO_0._O_. = A_9
					oO_oo0Oo.oo.00__O0o. = A_6
					oO_oo0Oo.o_._O0___O. = A_12
					oO_oo0Oo.oo.00__O0o. = A_7
					If oO_oo0Oo.Oo0_o0_oOoo.O.() IsNot Nothing Then
						oO_oo0Oo.Oo0_o0_oOoo.O.().Checked = A_13
					End If
					If Not CType(Me.o.0ooOO_0__., oO_oo0Oo).o.0o__.() Then
						Me.CloseFilterTree()
						Me.o.0ooOO_0__. = Nothing
						Return
					End If
					CType(Me.o.0ooOO_0__..Parent, C1DockingTabPage).CaptionText = Conversions.ToString(Interaction.IIf(A_0 = O0_0_0O0___O.OOO.__O_oO_., "层级BOM树", RuntimeHelpers.GetObjectValue(Interaction.IIf(A_12, "层级项目树", "层级筛选树"))))
				ElseIf A_7 IsNot Nothing AndAlso A_7.Length > 0 Then
					Me.o.0ooOO_0__. = New oO_oo0Oo(A_0, Me, A_1, A_2, A_3, A_4, A_5, A_8, A_9, A_12, A_13, A_7)
				Else
					If Operators.CompareString(Conversions.ToString(A_6), "", True) <= 0 Then
						Return
					End If
					Me.o.0ooOO_0__. = New oO_oo0Oo(A_0, Me, A_1, A_2, A_3, A_4, A_5, A_6, A_8, A_9, A_12, A_13)
				End If
				CType(Me.o.0ooOO_0__., oO_oo0Oo).o0ooOo0.0o_Oo. = A_10
				CType(Me.o.0ooOO_0__., oO_oo0Oo).OOOOO0.0. = If((-If((A_11 > False), 1, 0)), 1, 0)
				If Me.o.0ooOO_0__..FindForm() Is Nothing Then
					Dim text As String = Me.Name
					If text.IndexOf(".") > 0 Then
						text = text.Substring(0, text.IndexOf("."))
					End If
					Dim o_O0_0O As o_O0_0O0 = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O__O.o_oOO.()
					If A_14 > 0 Then
						o_O0_0O.OoOoo_O0o0.0O_.(A_14)
					End If
					If A_0 = O0_0_0O0___O.OOO.__O_oO_. Then
						o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "层级BOM树", True, Nothing, Nothing, True)
						Return
					End If
					If A_12 Then
						o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "层级项目树", True, Nothing, Nothing, True)
						Return
					End If
					o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "层级筛选树", True, Nothing, Nothing, True)
					Return
				End If
			Else
				MessageBox.Show("只有主表才能打开筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x06002A2A RID: 10794 RVA: 0x00123641 File Offset: 0x00121841
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetInlineBOMTree()
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.
			Me.SetInlineTree()
		End Sub

		' Token: 0x06002A2B RID: 10795 RVA: 0x00123650 File Offset: 0x00121850
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetInlineFilterTree()
			Me.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.
			Me.SetInlineTree()
		End Sub

		' Token: 0x06002A2C RID: 10796 RVA: 0x00123660 File Offset: 0x00121860
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetInlineTree()
			If Me.TableType Is Nothing AndAlso Not Me.IsCopy AndAlso Not Me.IsRelation Then
				Me.NeedSaveSetting = True
				New OO\u3000(Me, Me.o00oOO00_.ooOo.).ShowDialog(Main.OO_O.o.)
				Return
			End If
			MessageBox.Show("只有主表才能设内联树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06002A2D RID: 10797 RVA: 0x001236B7 File Offset: 0x001218B7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenInlineBomTree(ParamArray args As Object())
			If args.Length = 0 Then
				Me.OpenInlineBomTree()
				Return
			End If
			If args.Length = 1 Then
				Me.OpenInlineBomTree(CType(args(0), InlineTreeSetting), -1)
				Return
			End If
			If args.Length = 2 Then
				Me.OpenInlineBomTree(CType(args(0), InlineTreeSetting), Conversions.ToInteger(args(1)))
			End If
		End Sub

		' Token: 0x06002A2E RID: 10798 RVA: 0x001236F8 File Offset: 0x001218F8
		<oO0oooo("3353")>
		Public Sub OpenInlineBomTree(Setting As InlineTreeSetting, Optional Size As Integer = -1)
			Me.Oo_oOo_.O0_.(O0_0_0O0___O.OOO.__O_oO_., Setting.ParentCol, Setting.ChildCol, Setting.ValueCol, Setting.TextCol, Setting.SortCol, Setting.SortDesc, Setting.IncludeSub, Setting.Subtotal, Setting.GridTree, Setting.ExpandTo, Setting.Unique, Setting.MergeTotal, Size)
		End Sub

		' Token: 0x06002A2F RID: 10799 RVA: 0x00123758 File Offset: 0x00121958
		<oO0oooo("3353")>
		Public Sub OpenInlineBomTree()
			If Operators.CompareString(Me.oo.0___0O00., "", True) > 0 AndAlso Operators.CompareString(Me.oOo0.____., "", True) > 0 AndAlso Me.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_. AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.oo.0___0O00.) AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.oOo0.____.) Then
				Me.OpenInlineTree()
				Return
			End If
			Me.SetInlineBOMTree()
		End Sub

		' Token: 0x06002A30 RID: 10800 RVA: 0x001237DC File Offset: 0x001219DC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenInlineFilterTree(ParamArray args As Object())
			If args.Length = 0 Then
				Me.OpenInlineFilterTree()
				Return
			End If
			If args.Length = 1 Then
				Me.OpenInlineFilterTree(CType(args(0), InlineTreeSetting), -1)
				Return
			End If
			If args.Length = 2 Then
				Me.OpenInlineFilterTree(CType(args(0), InlineTreeSetting), Conversions.ToInteger(args(1)))
			End If
		End Sub

		' Token: 0x06002A31 RID: 10801 RVA: 0x0012381C File Offset: 0x00121A1C
		<oO0oooo("3355")>
		Public Sub OpenInlineFilterTree(Setting As InlineTreeSetting, Optional Size As Integer = -1)
			Me.Oo_oOo_.O0_.(O0_0_0O0___O.oOO___o.0oO., Setting.ParentCol, Setting.ChildCol, Setting.ValueCol, Setting.TextCol, Setting.SortCol, Setting.SortDesc, Setting.IncludeSub, Setting.Subtotal, Setting.GridTree, Setting.ExpandTo, Setting.Unique, Setting.MergeTotal, Size)
		End Sub

		' Token: 0x06002A32 RID: 10802 RVA: 0x0012387C File Offset: 0x00121A7C
		<oO0oooo("3355")>
		Public Sub OpenInlineFilterTree()
			If Operators.CompareString(Me.oo.0___0O00., "", True) > 0 AndAlso Operators.CompareString(Me.oOo0.____., "", True) > 0 AndAlso Me.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO. AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.oo.0___0O00.) AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.oOo0.____.) Then
				Me.OpenInlineTree()
				Return
			End If
			Me.SetInlineFilterTree()
		End Sub

		' Token: 0x06002A33 RID: 10803 RVA: 0x00123904 File Offset: 0x00121B04
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenInlineTree()
			If Operators.CompareString(Me.oo.0___0O00., "", True) > 0 AndAlso Operators.CompareString(Me.oOo0.____., "", True) > 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.oo.0___0O00.) AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.oOo0.____.) Then
				Me.Oo_oOo_.O0_.(Me.o00oOO00_.ooOo., Me.oo.0___0O00., Me.oOo0.____., Me.Oo_0o_O0._., Me.ooO0o.o_O., Me.ooo._Ooo., Me.O0_.__o00_., Me.oo_o_.oOO., Me.O.O000., Me.O0oO0_._0., Me.o.0o00ooo_., Me.OOoOO.OO0., Me.ooo_Ooo0.__., 0)
				Return
			End If
			Me.SetInlineTree()
		End Sub

		' Token: 0x06002A34 RID: 10804 RVA: 0x001239D8 File Offset: 0x00121BD8
		Private Sub <<EMPTY_NAME>>(A_0 As O0_0_0O0___O, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As String, A_6 As Boolean, A_7 As Boolean, A_8 As Boolean, A_9 As Boolean, A_10 As Integer, A_11 As Boolean, A_12 As Boolean, Optional A_13 As Integer = 0)
			If A_0 = O0_0_0O0___O.OOO.__O_oO_. Then
				A_11 = True
			End If
			If Me.o.0ooOO_0__. IsNot Nothing Then
				If Me.o.0ooOO_0__..Disposing OrElse Me.o.0ooOO_0__..IsDisposed Then
					Me.o.0ooOO_0__. = Nothing
				ElseIf Not(TypeOf Me.o.0ooOO_0__. Is oo__) OrElse CType(Me.o.0ooOO_0__., oo__).O_OOo0o0__0.0_. <> A_0 Then
					Me.CloseFilterTree()
					Me.o.0ooOO_0__. = Nothing
				End If
			End If
			If Me.TableType Is Nothing AndAlso Not Me.IsCopy AndAlso Not Me.IsRelation Then
				If Me.o.0ooOO_0__. IsNot Nothing AndAlso TypeOf Me.o.0ooOO_0__. Is oo__ Then
					Dim oo__ As oo__ = CType(Me.o.0ooOO_0__., oo__)
					oo__.O_OOo0o0__0.0_. = A_0
					oo__.oO0.o_O. = A_1
					oo__.O_o_o.oo0_. = A_2
					oo__.Ooo_00_OO.0Oo_. = A_3
					oo__.oO0__0_oO0.O_0. = A_5
					oo__.oO0.o_O. = A_6
					oo__.Ooo_00_OO.0Oo_. = A_11
					If Operators.CompareString(A_4, "", True) > 0 Then
						oo__.o0O_Oo0_O._. = A_4
					Else
						oo__.o0O_Oo0_O._. = A_2
					End If
					oo__.O_00.0___0. = A_8
					oo__.o.ooO_. = A_7
					If oo__.oOO.oOOO000O.() IsNot Nothing Then
						oo__.oOO.oOOO000O.().Checked = A_12
					End If
					oo__.o00O_o.OO0oO. = ""
					If Not CType(Me.o.0ooOO_0__., oo__).Oo0___O.0.() Then
						Me.CloseFilterTree()
						Me.o.0ooOO_0__. = Nothing
						Return
					End If
					CType(Me.o.0ooOO_0__..Parent, C1DockingTabPage).CaptionText = Conversions.ToString(Interaction.IIf(A_0 = O0_0_0O0___O.OOO.__O_oO_., "内联BOM树", RuntimeHelpers.GetObjectValue(Interaction.IIf(A_11, "内联项目树", "内联筛选树"))))
				Else
					Me.o.0ooOO_0__. = New oo__(A_0, Me, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_11, A_12)
				End If
				If Me.o.0ooOO_0__..FindForm() Is Nothing Then
					Dim text As String = Me.Name
					If text.IndexOf(".") > 0 Then
						text = text.Substring(0, text.IndexOf("."))
					End If
					Dim o_O0_0O As o_O0_0O0 = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O__O.o_oOO.()
					If A_13 > 0 Then
						o_O0_0O.OoOoo_O0o0.0O_.(A_13)
					End If
					If A_0 = O0_0_0O0___O.OOO.__O_oO_. Then
						o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "内联BOM树", True, Nothing, Nothing, True)
					ElseIf A_11 Then
						o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "内联项目树", True, Nothing, Nothing, True)
					Else
						o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "内联筛选树", True, Nothing, Nothing, True)
					End If
				End If
				CType(Me.o.0ooOO_0__., oo__).o__oO0.OOo_O. = A_9
				CType(Me.o.0ooOO_0__., oo__).o_.0Oo_oo0_. = A_10
				Return
			End If
			MessageBox.Show("只有主表才能打开筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06002A35 RID: 10805 RVA: 0x00123C7E File Offset: 0x00121E7E
		<oO0oooo("2020")>
		Public Sub OpenFilterTree()
			If Operators.CompareString(Me.O00.o_0OO__., "", True) > 0 Then
				Me.OpenFilterTree(Me.O00.o_0OO__., 0)
				Return
			End If
			Me.SetFilterTree()
		End Sub

		' Token: 0x06002A36 RID: 10806 RVA: 0x00123CA8 File Offset: 0x00121EA8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenFilterTree(ParamArray args As Object())
			Dim num As Integer = args.Length
			If num = 0 Then
				Me.OpenFilterTree()
				Return
			End If
			If num >= 1 AndAlso num <= 2 Then
				Dim colNames As String = Conversions.ToString(args(0))
				Dim size As Integer = If((args.Length >= 2), Conversions.ToInteger(args(1)), 0)
				Me.OpenFilterTree(colNames, size)
			End If
		End Sub

		' Token: 0x06002A37 RID: 10807 RVA: 0x00123CF0 File Offset: 0x00121EF0
		<oO0oooo("2020")>
		Public Sub OpenFilterTree(ColNames As String, Optional size As Integer = 0)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				OO_00oOO.LockBaseMainForm()
				IL_0E:
				num2 = 3
				If Operators.CompareString(Me.O00.o_0OO__., ColNames, True) = 0 Then
					GoTo IL_31
				End If
				IL_1F:
				num2 = 4
				Me.O00.o_0OO__. = ColNames
				IL_28:
				num2 = 5
				Me.NeedSaveSetting = True
				IL_31:
				num2 = 6
				If Me.o.0ooOO_0__. Is Nothing Then
					GoTo IL_85
				End If
				IL_3B:
				num2 = 7
				If Not Me.o.0ooOO_0__..Disposing AndAlso Not Me.o.0ooOO_0__..IsDisposed Then
					GoTo IL_62
				End If
				IL_57:
				num2 = 8
				Me.o.0ooOO_0__. = Nothing
				GoTo IL_85
				IL_62:
				num2 = 10
				If TypeOf Me.o.0ooOO_0__. Is o_o0ooOooO Then
					GoTo IL_85
				End If
				IL_72:
				num2 = 11
				Me.CloseFilterTree()
				IL_7B:
				num2 = 12
				Me.o.0ooOO_0__. = Nothing
				IL_85:
				num2 = 13
				If Me.TableType IsNot Nothing OrElse Me.IsCopy OrElse Me.IsRelation Then
					GoTo IL_1AF
				End If
				IL_A9:
				num2 = 14
				If Me.o.0ooOO_0__. Is Nothing OrElse Not(TypeOf Me.o.0ooOO_0__. Is o_o0ooOooO) Then
					GoTo IL_EF
				End If
				IL_C1:
				num2 = 15
				If CType(Me.o.0ooOO_0__., o_o0ooOooO).O0o.0oo0_.(ColNames) Then
					GoTo IL_FF
				End If
				IL_D7:
				num2 = 16
				Me.CloseFilterTree()
				IL_E0:
				num2 = 17
				Me.o.0ooOO_0__. = Nothing
				GoTo IL_1CD
				IL_EF:
				num2 = 20
				Me.o.0ooOO_0__. = New o_o0ooOooO(Me, ColNames)
				IL_FF:
				num2 = 21
				Me.o.0ooOO_0__..Nodes.Insert(0, "显示所有行")
				IL_119:
				num2 = 22
				If Me.o.0ooOO_0__..FindForm() IsNot Nothing Then
					GoTo IL_1C5
				End If
				IL_12C:
				num2 = 23
				Dim text As String = Me.Name
				IL_136:
				num2 = 24
				If text.IndexOf(".") <= 0 Then
					GoTo IL_15D
				End If
				IL_147:
				num2 = 25
				text = text.Substring(0, text.IndexOf("."))
				IL_15D:
				num2 = 26
				Dim o_O0_0O As o_O0_0O0 = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O__O.o_oOO.()
				IL_181:
				num2 = 27
				If size <= 0 Then
					GoTo IL_193
				End If
				IL_188:
				num2 = 28
				o_O0_0O.OoOoo_O0o0.0O_.(size)
				IL_193:
				num2 = 29
				o_O0_0O.OO_o0_oO.0.(Me.o.0ooOO_0__., "筛选树", True, Nothing, Nothing, True)
				GoTo IL_1C5
				IL_1AF:
				num2 = 31
				MessageBox.Show("只有主表才能打开筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_1C5:
				num2 = 32
				OO_00oOO.UnlockBaseMainForm()
				IL_1CD:
				GoTo IL_2A3
				IL_1D2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_264:
				GoTo IL_298
				IL_266:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_276:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_266
			End Try
			IL_298:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2A3:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A38 RID: 10808 RVA: 0x00123FC4 File Offset: 0x001221C4
		Public Sub CloseFilterTree()
			If Me.o.0ooOO_0__. IsNot Nothing Then
				Dim parent As System.Windows.Forms.Control = Me.o.0ooOO_0__..Parent
				While parent IsNot Nothing AndAlso Not(TypeOf parent Is FormPanel)
					If TypeOf parent Is o_O0_0O0 Then
						CType(parent, o_O0_0O0).o_o.O___0o.(Me.o.0ooOO_0__.)
						Return
					End If
					parent = parent.Parent
				End While
			End If
		End Sub

		' Token: 0x170009FE RID: 2558
		' (get) Token: 0x06002A39 RID: 10809 RVA: 0x00124014 File Offset: 0x00122214
		<oO0oooo("2203")>
		Public ReadOnly Property RecordGridVisible As Boolean
			Get
				Return Me.o00oOO00_.ooOo. IsNot Nothing AndAlso Me.o00oOO00_.ooOo..FindForm() IsNot Nothing
			End Get
		End Property

		' Token: 0x06002A3A RID: 10810 RVA: 0x00124040 File Offset: 0x00122240
		<oO0oooo("2203")>
		Public Sub OpenRecordGrid(Optional size As Integer = 0)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.TableType IsNot Nothing OrElse Me.IsCopy Then
					GoTo IL_192
				End If
				IL_1F:
				num2 = 4
				If Me.o00oOO00_.ooOo. IsNot Nothing AndAlso Me.o00oOO00_.ooOo..FindForm() IsNot Nothing Then
					GoTo IL_192
				End If
				IL_39:
				num2 = 6
				Dim oooOo0___oO As OooOo0___oO = New OooOo0___oO(Me, "", True, True)
				IL_49:
				num2 = 7
				Dim text As String = Me.Name
				IL_53:
				num2 = 8
				If text.IndexOf(".") <= 0 Then
					GoTo IL_7D
				End If
				IL_64:
				num2 = 9
				text = text.Substring(0, text.IndexOf("."))
				IL_7D:
				num2 = 10
				Dim o_O0_0O As o_O0_0O0 = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).o__0_.o0OoOOO.()
				IL_A2:
				num2 = 11
				If size <= 0 Then
					GoTo IL_B4
				End If
				IL_A9:
				num2 = 12
				o_O0_0O.OoOoo_O0o0.0O_.(size)
				IL_B4:
				num2 = 13
				oooOo0___oO.BorderStyle = 0
				IL_BE:
				num2 = 14
				Dim array As String() = Me.Name.Split(New Char() { "."c })
				IL_D9:
				num2 = 15
				Dim text2 As String = ""
				IL_E3:
				num2 = 16
				For Each text3 As String In array
					IL_F6:
					num2 = 17
					If Operators.CompareString(text2, "", True) > 0 Then
						IL_109:
						num2 = 18
						text2 += "."
					End If
					IL_11A:
					num2 = 19
					text2 += Interaction.IIf(Operators.CompareString(OO_00oOO.DataTables(text3).Caption, "", True) > 0, OO_00oOO.DataTables(text3).Caption, text3).ToString()
					IL_162:
					num2 = 20
				Next
				IL_176:
				num2 = 21
				o_O0_0O.OO_o0_oO.0.(oooOo0___oO, text2, True, Nothing, Nothing, True)
				IL_188:
				num2 = 22
				Me.o00oOO00_.ooOo. = oooOo0___oO
				IL_192:
				GoTo IL_240
				IL_197:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_201:
				GoTo IL_235
				IL_203:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_213:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_203
			End Try
			IL_235:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_240:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A3B RID: 10811 RVA: 0x001242B4 File Offset: 0x001224B4
		Public Sub CloseRecordGrid()
			If Me.o00oOO00_.ooOo. IsNot Nothing Then
				If Me.o00oOO00_.ooOo..Editor IsNot Nothing AndAlso Not Me.o00oOO00_.ooOo..FinishEditing() Then
					Me.o00oOO00_.ooOo..FinishEditing(True)
				End If
				Dim parent As System.Windows.Forms.Control = Me.o00oOO00_.ooOo..Parent
				While parent IsNot Nothing AndAlso Not(TypeOf parent Is FormPanel)
					If TypeOf parent Is o_O0_0O0 Then
						CType(parent, o_O0_0O0).o_o.O___0o.(Me.o00oOO00_.ooOo.)
						Exit While
					End If
					parent = parent.Parent
				End While
				Me.o00oOO00_.ooOo..O_._0o00_.()
				Me.o00oOO00_.ooOo. = Nothing
			End If
		End Sub

		' Token: 0x06002A3C RID: 10812 RVA: 0x00124340 File Offset: 0x00122540
		Public Sub SetFilterTree()
			If Me.TableType Is Nothing AndAlso Not Me.IsCopy AndAlso Not Me.IsRelation Then
				Me.NeedSaveSetting = True
				New jr(Me).ShowDialog(Main.OO_O.o.)
				Return
			End If
			MessageBox.Show("只有主表才能设置筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06002A3D RID: 10813 RVA: 0x00124394 File Offset: 0x00122594
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenLoadTree(ParamArray args As Object())
			Dim num As Integer = args.Length
			If num = 0 Then
				Me.OpenLoadTree()
				Return
			End If
			If num >= 1 AndAlso num <= 5 Then
				Dim colNames As String = Conversions.ToString(args(0))
				Dim size As Integer = If((args.Length >= 2), Conversions.ToInteger(args(1)), 0)
				Dim pageRows As Integer = If((args.Length >= 3), Conversions.ToInteger(args(2)), 0)
				Dim loadFirstPage As Boolean = args.Length >= 4 AndAlso Conversions.ToBoolean(args(3))
				Dim filter As String = If((args.Length >= 5), Conversions.ToString(args(4)), "-")
				Me.OpenLoadTree(colNames, size, pageRows, loadFirstPage, filter)
			End If
		End Sub

		' Token: 0x06002A3E RID: 10814 RVA: 0x0012441B File Offset: 0x0012261B
		<oO0oooo("2022")>
		Public Sub OpenLoadTree()
			If Operators.CompareString(Me.o.Ooo__., "", True) = 0 Then
				Me.SetLoadTree()
				Return
			End If
			Me.OpenLoadTree(Me.o.Ooo__., 0, 0, False, Me.oO.oO_00o__o.)
		End Sub

		' Token: 0x06002A3F RID: 10815 RVA: 0x0012444C File Offset: 0x0012264C
		<oO0oooo("2022")>
		Public Sub OpenLoadTree(ColNames As String, Optional size As Integer = 0, Optional PageRows As Integer = 0, Optional LoadFirstPage As Boolean = False, Optional Filter As String = "-")
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				OO_00oOO.LockBaseMainForm()
				IL_0E:
				num2 = 3
				If Operators.CompareString(Me.o.Ooo__., ColNames, True) = 0 Then
					GoTo IL_31
				End If
				IL_1F:
				num2 = 4
				Me.o.Ooo__. = ColNames
				IL_28:
				num2 = 5
				Me.NeedSaveSetting = True
				IL_31:
				num2 = 6
				If PageRows <= 0 Then
					GoTo IL_40
				End If
				IL_37:
				num2 = 7
				Me.o.0__o0. = PageRows
				IL_40:
				num2 = 8
				Me.O0__O_.O. = Me.DataTable.LoadOver
				IL_53:
				num2 = 9
				If Operators.CompareString(Filter, "-", True) = 0 Then
					GoTo IL_70
				End If
				IL_65:
				num2 = 10
				Me.oO.oO_00o__o. = Filter
				IL_70:
				num2 = 11
				If Me.O.OoOo_. Is Nothing Then
					GoTo IL_A2
				End If
				IL_7B:
				num2 = 12
				If Not Me.O.OoOo_..Disposing AndAlso Not Me.O.OoOo_..IsDisposed Then
					GoTo IL_A2
				End If
				IL_98:
				num2 = 13
				Me.O.OoOo_. = Nothing
				IL_A2:
				num2 = 14
				If Me.TableType IsNot Nothing OrElse Me.IsCopy OrElse Me.IsRelation OrElse (Operators.CompareString(Me.DataTable.DataServer, "", True) <= 0 AndAlso Me.DataTable.frd_IsTemporary) Then
					GoTo IL_23F
				End If
				IL_EF:
				num2 = 15
				If Me.O.OoOo_. Is Nothing Then
					GoTo IL_129
				End If
				IL_FA:
				num2 = 16
				Me.O.OoOo_..oOo0O.___ooOO0. = Filter
				IL_10A:
				num2 = 17
				If Me.O.OoOo_..o000.oO0.(ColNames) Then
					GoTo IL_13B
				End If
				IL_11B:
				num2 = 18
				Me.CloseLoadTree()
				GoTo IL_25D
				IL_129:
				num2 = 21
				Me.O.OoOo_. = New o_0(Me, ColNames, Filter)
				IL_13B:
				num2 = 22
				Me.O.OoOo_..OOOO_.o.().Nodes.Insert(0, "加载所有行")
				IL_15A:
				num2 = 23
				If Me.O.OoOo_..FindForm() IsNot Nothing Then
					GoTo IL_1EE
				End If
				IL_16D:
				num2 = 24
				Dim text As String = Me.Name
				IL_177:
				num2 = 25
				If text.IndexOf(".") <= 0 Then
					GoTo IL_19E
				End If
				IL_188:
				num2 = 26
				text = text.Substring(0, text.IndexOf("."))
				IL_19E:
				num2 = 27
				Dim o_O0_0O As o_O0_0O0 = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(text), Oo0__Oo).O__O.o_oOO.()
				IL_1C2:
				num2 = 28
				If size <= 0 Then
					GoTo IL_1D4
				End If
				IL_1C9:
				num2 = 29
				o_O0_0O.OoOoo_O0o0.0O_.(size)
				IL_1D4:
				num2 = 30
				o_O0_0O.OO_o0_oO.0.(Me.O.OoOo_., "加载树", True, Nothing, Nothing, True)
				IL_1EE:
				num2 = 31
				If Not LoadFirstPage OrElse PageRows <= 0 Then
					GoTo IL_255
				End If
				IL_1F9:
				num2 = 32
				If Me.O.OoOo_..OOOO_.o.().Nodes.Count <= 0 Then
					GoTo IL_255
				End If
				IL_214:
				num2 = 33
				Me.O.OoOo_..OOOO_.o.().SelectedNode = Me.O.OoOo_..OOOO_.o.().Nodes(0)
				GoTo IL_255
				IL_23F:
				num2 = 35
				MessageBox.Show("只有主表才能打开加载树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_255:
				num2 = 36
				OO_00oOO.UnlockBaseMainForm()
				IL_25D:
				GoTo IL_343
				IL_262:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_304:
				GoTo IL_338
				IL_306:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_316:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_306
			End Try
			IL_338:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_343:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A40 RID: 10816 RVA: 0x001247C0 File Offset: 0x001229C0
		Public Sub SetLoadTree()
			If Me.TableType Is Nothing AndAlso Not Me.IsCopy AndAlso Not Me.IsRelation AndAlso Not Me.DataTable.frd_IsTemporary Then
				Me.NeedSaveSetting = True
				New ky(Me).ShowDialog(Main.OO_O.o.)
				Return
			End If
			MessageBox.Show("只有主表才能设置加载树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06002A41 RID: 10817 RVA: 0x00124820 File Offset: 0x00122A20
		Public Sub CloseLoadTree()
			If Me.O.OoOo_. IsNot Nothing Then
				Dim parent As System.Windows.Forms.Control = Me.O.OoOo_..Parent
				While parent IsNot Nothing AndAlso Not(TypeOf parent Is FormPanel)
					If TypeOf parent Is o_O0_0O0 Then
						CType(parent, o_O0_0O0).o_o.O___0o.(Me.O.OoOo_.)
						Return
					End If
					parent = parent.Parent
				End While
			End If
		End Sub

		' Token: 0x06002A42 RID: 10818 RVA: 0x0012486F File Offset: 0x00122A6F
		Public Sub BuildChart()
			New O\u3002_\u3000\u3002\u3000\u3000\u3000\u3000(Me).ShowDialog(Main.OO_O.o.)
		End Sub

		' Token: 0x06002A43 RID: 10819 RVA: 0x00124882 File Offset: 0x00122A82
		Public Sub ShowCell(Row As Integer, col As Integer)
			Me.foxGrid.ShowCell(Me.foxGrid.Rows.Fixed + Row, Me.foxGrid.Cols.Fixed + col)
		End Sub

		' Token: 0x170009FF RID: 2559
		' (get) Token: 0x06002A44 RID: 10820 RVA: 0x001248B3 File Offset: 0x00122AB3
		' (set) Token: 0x06002A45 RID: 10821 RVA: 0x001248BB File Offset: 0x00122ABB
		<oO0oooo("1623")>
		Public Property AllowBackgroundStatistics As Boolean
			Get
				Return Me.o_o0O000o.000.
			End Get
			Set(value As Boolean)
				Me.o_o0O000o.000. = value
			End Set
		End Property

		' Token: 0x06002A46 RID: 10822 RVA: 0x001248C4 File Offset: 0x00122AC4
		Public Sub EditCopy()
			Me.foxGrid.Oo.O_.()
		End Sub

		' Token: 0x06002A47 RID: 10823 RVA: 0x001248D1 File Offset: 0x00122AD1
		Public Sub EditCut()
			Me.foxGrid.Oo.O_.()
			Me.foxGrid.oO0O00o0o.O.()
		End Sub

		' Token: 0x06002A48 RID: 10824 RVA: 0x001248E9 File Offset: 0x00122AE9
		Public Sub EditPaste()
			Me.foxGrid.o0o0__.o.()
		End Sub

		' Token: 0x06002A49 RID: 10825 RVA: 0x001248F6 File Offset: 0x00122AF6
		Public Sub EditDelete()
			Me.foxGrid.oO0O00o0o.O.()
		End Sub

		' Token: 0x17000A00 RID: 2560
		' (get) Token: 0x06002A4A RID: 10826 RVA: 0x00124903 File Offset: 0x00122B03
		' (set) Token: 0x06002A4B RID: 10827 RVA: 0x00124921 File Offset: 0x00122B21
		<oO0oooo("2358")>
		Public Property LeftVisibleCol As Integer
			Get
				Return Me.foxGrid.LeftCol - Me.foxGrid.Cols.Fixed
			End Get
			Set(value As Integer)
				Me.foxGrid.LeftCol = value + Me.foxGrid.Cols.Fixed
			End Set
		End Property

		' Token: 0x17000A01 RID: 2561
		' (get) Token: 0x06002A4C RID: 10828 RVA: 0x00124940 File Offset: 0x00122B40
		<oO0oooo("2358")>
		Public ReadOnly Property RightVisibleCol As Integer
			Get
				Return Me.foxGrid.RightCol - Me.foxGrid.Cols.Fixed
			End Get
		End Property

		' Token: 0x17000A02 RID: 2562
		' (get) Token: 0x06002A4D RID: 10829 RVA: 0x0012495E File Offset: 0x00122B5E
		' (set) Token: 0x06002A4E RID: 10830 RVA: 0x0012497C File Offset: 0x00122B7C
		<oO0oooo("2358")>
		Public Property TopVisibleRow As Integer
			Get
				Return Me.foxGrid.TopRow - Me.foxGrid.Rows.Fixed
			End Get
			Set(value As Integer)
				Me.foxGrid.TopRow = value + Me.foxGrid.Rows.Fixed
			End Set
		End Property

		' Token: 0x17000A03 RID: 2563
		' (get) Token: 0x06002A4F RID: 10831 RVA: 0x0012499B File Offset: 0x00122B9B
		<oO0oooo("2358")>
		Public ReadOnly Property BottomVisibleRow As Integer
			Get
				Return Me.foxGrid.BottomRow - Me.foxGrid.Rows.Fixed
			End Get
		End Property

		' Token: 0x17000A04 RID: 2564
		' (get) Token: 0x06002A50 RID: 10832 RVA: 0x001249B9 File Offset: 0x00122BB9
		' (set) Token: 0x06002A51 RID: 10833 RVA: 0x001249C6 File Offset: 0x00122BC6
		<oO0oooo("2380")>
		Public Property ExtendLastCol As Boolean
			Get
				Return Me.foxGrid.ExtendLastCol
			End Get
			Set(value As Boolean)
				Me.foxGrid.ExtendLastCol = value
			End Set
		End Property

		' Token: 0x17000A05 RID: 2565
		' (get) Token: 0x06002A52 RID: 10834 RVA: 0x001249D4 File Offset: 0x00122BD4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Appearance As LookAndFeelProperty
			Get
				Return Me.foxGrid.OO_.00oO0Oo.()
			End Get
		End Property

		' Token: 0x06002A53 RID: 10835 RVA: 0x001249E4 File Offset: 0x00122BE4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ShowToolTip(ParamArray args As Object())
			Dim num As Integer = args.Length
			If num <> 3 Then
				If num <> 4 Then
					Return
				End If
				Dim text As String = Conversions.ToString(args(0))
				Dim row As Row = CType(args(1), Row)
				Dim dutation As Integer = Conversions.ToInteger(args(3))
				If TypeOf args(2)Is Col Then
					Me.ShowToolTip(text, row, CType(args(2), Col), dutation)
					Return
				End If
				If TypeOf args(2)Is String Then
					Me.ShowToolTip(text, row, Conversions.ToString(args(2)), dutation)
				End If
			Else
				Dim text2 As String = Conversions.ToString(args(0))
				Dim row2 As Row = CType(args(1), Row)
				If TypeOf args(2)Is Col Then
					Me.ShowToolTip(text2, row2, CType(args(2), Col), -1)
					Return
				End If
				If TypeOf args(2)Is String Then
					Me.ShowToolTip(text2, row2, Conversions.ToString(args(2)), -1)
					Return
				End If
			End If
		End Sub

		' Token: 0x06002A54 RID: 10836 RVA: 0x00124AA0 File Offset: 0x00122CA0
		<oO0oooo("2680")>
		Public Sub ShowToolTip(Text As String, row As Row, col As Col, Optional dutation As Integer = -1)
			Dim num As Integer = Me.Grid.Cols(col.Index + Me.Grid.Cols.Fixed).Left + Me.Grid.ScrollPosition.X
			Dim num2 As Integer
			If Me.IsSubtotal Then
				num2 = row.Index
				Dim c1FlexGrid As C1FlexGrid = Me.foxGrid
				If c1FlexGrid.MouseRow >= c1FlexGrid.Rows.Fixed AndAlso c1FlexGrid.Rows(c1FlexGrid.MouseRow).DataIndex = num2 Then
					num2 = c1FlexGrid.MouseRow
				Else
					Dim fixed As Integer = c1FlexGrid.Rows.Fixed
					Dim num3 As Integer = c1FlexGrid.Rows.Count - 1
					For i As Integer = fixed To num3
						If c1FlexGrid.Rows(i).DataIndex = num2 Then
							num2 = i
							Exit For
						End If
					Next
				End If
				If num2 = row.Index Then
					num2 += c1FlexGrid.Rows.Fixed
				End If
			Else
				num2 = row.Index + Me.Grid.Rows.Fixed
			End If
			Dim num4 As Integer = Me.Grid.Rows(num2).Top + Me.Grid.ScrollPosition.Y
			If Me.Grid.Cols.Frozen > 0 AndAlso Me.Grid.Cols(col.Name).Index - Me.Grid.Cols.Fixed < Me.Grid.Cols.Frozen Then
				num -= Me.Grid.ScrollPosition.X
			End If
			num -= 1
			num4 = num4 + Me.Grid.Rows(num2).HeightDisplay - 1
			If Me.foxGrid.OOOOOO.o0Oo0. Then
				Dim point As Point = Me.foxGrid.PointToClient(System.Windows.Forms.Control.MousePosition)
				num = point.X + 10
				num4 = point.Y - 30
			End If
			If dutation <= 0 Then
				Main.OO_O.o..O0o__0_OO.o.().Show(Text, Me.Grid, num, num4)
				Return
			End If
			Main.OO_O.o..O0o__0_OO.o.().Show(Text, Me.Grid, num, num4, dutation)
		End Sub

		' Token: 0x06002A55 RID: 10837 RVA: 0x00124CD9 File Offset: 0x00122ED9
		<oO0oooo("2680")>
		Public Sub ShowToolTip(Text As String, row As Row, colName As String, Optional dutation As Integer = -1)
			If Me.Cols.Contains(colName) Then
				Me.ShowToolTip(Text, row, Me.Cols(colName), dutation)
			End If
		End Sub

		' Token: 0x06002A56 RID: 10838 RVA: 0x00124CFF File Offset: 0x00122EFF
		<oO0oooo("2681")>
		Public Sub HideToolTip()
			Main.OO_O.o..O0o__0_OO.o.().Hide(Me.Grid)
		End Sub

		' Token: 0x17000A06 RID: 2566
		' (get) Token: 0x06002A57 RID: 10839 RVA: 0x00124D16 File Offset: 0x00122F16
		' (set) Token: 0x06002A58 RID: 10840 RVA: 0x00124D23 File Offset: 0x00122F23
		<oO0oooo("2685")>
		Public Property ShowErrors As Boolean
			Get
				Return Me.Grid.ShowErrors
			End Get
			Set(value As Boolean)
				Me.Grid.ShowErrors = value
				Me.foxGrid.oo0_oo0.ooo_o.()
			End Set
		End Property

		' Token: 0x06002A59 RID: 10841 RVA: 0x00124D3C File Offset: 0x00122F3C
		Friend Shared Function IsReady() As Boolean
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim result As Boolean
			If Table.FindPort_2(0, 999, 1015341241, stringBuilder) = 0 Then
				stringBuilder.ToString()
				result = True
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x06002A5A RID: 10842 RVA: 0x00124D7C File Offset: 0x00122F7C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub RelationFilter(ParamArray args As Object())
			Dim num As Integer = args.Length
			If num <> 4 Then
				If num <> 5 Then
					Return
				End If
				Dim colName As String = Conversions.ToString(args(0))
				Dim match As Boolean = Conversions.ToBoolean(args(3))
				Dim backFilter As Boolean = Conversions.ToBoolean(args(4))
				If TypeOf args(1)Is DataTable Then
					Dim dataTable As DataTable = CType(args(1), DataTable)
					Dim colName2 As String = Conversions.ToString(args(2))
					Me.RelationFilter(colName, dataTable, colName2, match, backFilter)
					Return
				End If
				If TypeOf args(1)Is String Then
					Dim dataTableName As String = Conversions.ToString(args(1))
					Dim colName3 As String = Conversions.ToString(args(2))
					Me.RelationFilter(colName, dataTableName, colName3, match, backFilter)
				End If
			Else
				Dim colName4 As String = Conversions.ToString(args(0))
				Dim match2 As Boolean = Conversions.ToBoolean(args(3))
				If TypeOf args(1)Is DataTable Then
					Dim dataTable2 As DataTable = CType(args(1), DataTable)
					Dim colName5 As String = Conversions.ToString(args(2))
					Me.RelationFilter(colName4, dataTable2, colName5, match2, False)
					Return
				End If
				If TypeOf args(1)Is String Then
					Dim dataTableName2 As String = Conversions.ToString(args(1))
					Dim colName6 As String = Conversions.ToString(args(2))
					Me.RelationFilter(colName4, dataTableName2, colName6, match2, False)
					Return
				End If
			End If
		End Sub

		' Token: 0x06002A5B RID: 10843 RVA: 0x00124E7C File Offset: 0x0012307C
		<oO0oooo("2711")>
		Public Sub RelationFilter(ColName1 As String, DataTable As DataTable, ColName2 As String, Match As Boolean, Optional backFilter As Boolean = False)
			If backFilter AndAlso DataTable.frd_Connection Is Me.DataTable.frd_Connection Then
				Me.o0O0oo.o.(ColName1, DataTable, ColName2, Match)
				Return
			End If
			Me.Oo_oOo_.O0_.(ColName1, DataTable, ColName2, Match)
		End Sub

		' Token: 0x06002A5C RID: 10844 RVA: 0x00124EAC File Offset: 0x001230AC
		<oO0oooo("2711")>
		Public Sub RelationFilter(ColName1 As String, DataTableName As String, ColName2 As String, Match As Boolean, Optional backFilter As Boolean = False)
			If backFilter AndAlso OO_00oOO.DataTables(DataTableName).frd_Connection Is Me.DataTable.frd_Connection Then
				Me.o0O0oo.o.(ColName1, OO_00oOO.DataTables(DataTableName), ColName2, Match)
				Return
			End If
			Me.Oo_oOo_.O0_.(ColName1, OO_00oOO.DataTables(DataTableName), ColName2, Match)
		End Sub

		' Token: 0x06002A5D RID: 10845 RVA: 0x00124F08 File Offset: 0x00123108
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable, A_2 As String, A_3 As Boolean)
			Dim a_ As String = String.Concat(New String() { "RelationFilter3" & vbVerticalTab, A_0, vbVerticalTab, A_1.Name, vbVerticalTab, A_2, vbVerticalTab, Conversions.ToString(A_3) })
			A_0 = Oo00.OoOo_oo_.o_o.(A_0, Me)
			Dim text As String
			If A_3 Then
				text = String.Concat(New String() { A_0, " in ( Select distinct [", A_2, "] From ", Oo00.oo_0__0.o.(A_1._Adapter.SelectCommand.CommandText), " Where [", A_2, "] Is Not Null)" })
			Else
				text = String.Concat(New String() { A_0, " not in ( Select distinct [", A_2, "] From ", Oo00.oo_0__0.o.(A_1._Adapter.SelectCommand.CommandText), " Where [", A_2, "] Is Not Null)" })
			End If
			If Operators.CompareString(Me.DataTable.OOOOO._., "", True) > 0 Then
				text = "(" + Me.DataTable.OOOOO._. + ") And " + text
			End If
			Me.DataTable.LoadPage = 0
			Me.DataTable.OOO_o_O.OO0o.(text, a_)
			Me.DataTable.o0.o.(True, Nothing)
			If Me.O.OoOo_. IsNot Nothing AndAlso Me.O.OoOo_..FindForm() IsNot Nothing Then
				Me.O.OoOo_..oO.Oo0__O_.()
			End If
		End Sub

		' Token: 0x06002A5E RID: 10846 RVA: 0x00125088 File Offset: 0x00123288
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable, A_2 As String, A_3 As Boolean)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim list As List(Of OoO_O00) = New List(Of OoO_O00)()
				IL_0F:
				num2 = 3
				Dim table As DataTable = A_1.BaseTable
				IL_19:
				num2 = 4
				Dim dataView As DataView = New DataView(table, "[" + A_2 + "] Is NOT NULL", A_2, DataViewRowState.CurrentRows)
				IL_37:
				num2 = 5
				If Not Me.View.o_oo._0Oo.() AndAlso Not Me.View.O0OOO_0.o.() Then
					GoTo IL_69
				End If
				IL_53:
				num2 = 6
				Dim array As DataRow() = Me.View.o_o.O0ooOo.().[Select]()
				GoTo IL_C1
				IL_69:
				num2 = 8
				array = New DataRow(Me.View.Count - 1 + 1 - 1) {}
				IL_81:
				num2 = 9
				Dim num3 As Integer = Me.View.Count - 1
				For i As Integer = 0 To num3
					IL_98:
					num2 = 10
					array(i) = Me.View.O0O_0_0__.0O.(i).Row
					IL_B2:
					num2 = 11
				Next
				IL_C1:
				num2 = 12
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table2 As Table = enumerator.Current
					IL_DB:
					num2 = 13
					If table2.View.o_o.O0ooOo.() Is Me.View.o_o.O0ooOo.() Then
						IL_F7:
						num2 = 14
						list.Add(New OoO_O00(table2))
					End If
					IL_107:
					num2 = 15
				End While
				IL_113:
				num2 = 16
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_121:
				num2 = 17
				Dim a_ As Dictionary(Of DataColumn, String) = Oo00.ooO.ooo.(Me.DataTable.BaseTable)
				IL_136:
				num2 = 18
				If Not A_3 Then
					GoTo IL_1A4
				End If
				IL_13D:
				num2 = 19
				For Each dataRow As DataRow In array
					IL_150:
					num2 = 20
					If dataView.Find(RuntimeHelpers.GetObjectValue(dataRow(A_0))) >= 0 Then
						IL_16A:
						num2 = 21
						dataRow("System_Filter_Unique") = 1
					Else
						IL_181:
						num2 = 23
						dataRow("System_Filter_Unique") = Nothing
					End If
					IL_191:
					num2 = 24
				Next
				GoTo IL_209
				IL_1A4:
				num2 = 26
				For Each dataRow2 As DataRow In array
					IL_1B7:
					num2 = 27
					If dataView.Find(RuntimeHelpers.GetObjectValue(dataRow2(A_0))) >= 0 Then
						IL_1D1:
						num2 = 28
						dataRow2("System_Filter_Unique") = Nothing
					Else
						IL_1E3:
						num2 = 30
						dataRow2("System_Filter_Unique") = 1
					End If
					IL_1F8:
					num2 = 31
				Next
				IL_209:
				num2 = 32
				Oo00.o0_o._O_.(a_)
				IL_213:
				num2 = 33
				Dim enumerator2 As List(Of OoO_O00).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim ooO_O As OoO_O00 = enumerator2.Current
					IL_229:
					num2 = 34
					ooO_O.O._00000.(Me)
					IL_234:
					num2 = 35
				End While
				IL_240:
				num2 = 36
				CType(enumerator2, IDisposable).Dispose()
				IL_250:
				num2 = 37
				If Operators.CompareString(Me.Filter, "", True) <> 0 Then
					GoTo IL_276
				End If
				IL_266:
				num2 = 38
				Me.Filter = "[System_Filter_Unique] = 1"
				GoTo IL_2BB
				IL_276:
				num2 = 40
				If Me.Filter.IndexOf("[System_Filter_Unique]") >= 0 Then
					GoTo IL_2AC
				End If
				IL_28C:
				num2 = 41
				Me.Filter = "(" + Me.Filter + ") And [System_Filter_Unique] = 1"
				GoTo IL_2BB
				IL_2AC:
				num2 = 43
				Me.Filter = Me.Filter
				IL_2BB:
				num2 = 44
				Me.ResumeRedraw()
				IL_2C4:
				GoTo IL_3CA
				IL_2C9:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_38B:
				GoTo IL_3BF
				IL_38D:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_39D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_38D
			End Try
			IL_3BF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3CA:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A5F RID: 10847 RVA: 0x00125484 File Offset: 0x00123684
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Integer)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				IL_0B:
				num2 = 3
				If Me Is Nothing Then
					GoTo IL_3E7
				End If
				IL_13:
				num2 = 5
				If Me.View.Count <= 1 Then
					GoTo IL_3E7
				End If
				IL_26:
				num2 = 8
				Me.ClearEditInfos()
				IL_2E:
				num2 = 9
				Dim list As List(Of OoO_O00) = New List(Of OoO_O00)()
				IL_38:
				num2 = 10
				If Not Me.View.o_oo._0Oo.() AndAlso Not Me.View.O0OOO_0.o.() AndAlso Not Me.View.O0O.o__0.() Then
					GoTo IL_85
				End If
				IL_62:
				num2 = 11
				Dim array As DataRow() = Me.View.o_o.O0ooOo.().[Select](Me.View.oo_0._o.(), A_0)
				GoTo IL_DE
				IL_85:
				num2 = 13
				array = New DataRow(Me.View.Count - 1 + 1 - 1) {}
				IL_9E:
				num2 = 14
				Dim num3 As Integer = Me.View.Count - 1
				For i As Integer = 0 To num3
					IL_B5:
					num2 = 15
					array(i) = Me.View.O0O_0_0__.0O.(i).Row
					IL_CF:
					num2 = 16
				Next
				IL_DE:
				num2 = 17
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_F8:
					num2 = 18
					If table.View.o_o.O0ooOo.() Is Me.View.o_o.O0ooOo.() Then
						IL_114:
						num2 = 19
						list.Add(New OoO_O00(table))
					End If
					IL_125:
					num2 = 20
				End While
				IL_131:
				num2 = 21
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_13F:
				num2 = 22
				Dim a_ As Dictionary(Of DataColumn, String) = Oo00.ooO.ooo.(Me.DataTable.BaseTable)
				IL_154:
				num2 = 23
				If Operators.CompareString(array(0)(A_0).ToString(), array(1)(A_0).ToString(), True) <> 0 Then
					GoTo IL_196
				End If
				IL_17D:
				num2 = 24
				array(0)("System_Filter_Unique") = 1
				GoTo IL_1A8
				IL_196:
				num2 = 26
				array(0)("System_Filter_Unique") = Nothing
				IL_1A8:
				num2 = 27
				If Operators.CompareString(array(array.Length - 1)(A_0).ToString(), array(array.Length - 2)(A_0).ToString(), True) <> 0 Then
					GoTo IL_1F9
				End If
				IL_1DB:
				num2 = 28
				array(array.Length - 1)("System_Filter_Unique") = 1
				GoTo IL_210
				IL_1F9:
				num2 = 30
				array(array.Length - 1)("System_Filter_Unique") = Nothing
				IL_210:
				num2 = 31
				Dim num4 As Integer = array.Length - 2
				For j As Integer = 1 To num4
					IL_223:
					num2 = 32
					If Operators.CompareString(array(j)(A_0).ToString(), array(j - 1)(A_0).ToString(), True) = 0 Then
						IL_250:
						num2 = 33
						array(j)("System_Filter_Unique") = 1
					Else
						IL_26A:
						num2 = 35
						If Operators.CompareString(array(j)(A_0).ToString(), array(j + 1)(A_0).ToString(), True) = 0 Then
							IL_297:
							num2 = 36
							array(j)("System_Filter_Unique") = 1
						Else
							IL_2B1:
							num2 = 38
							array(j)("System_Filter_Unique") = Nothing
						End If
					End If
					IL_2C4:
					num2 = 39
				Next
				IL_2D6:
				num2 = 40
				Oo00.o0_o._O_.(a_)
				IL_2E0:
				num2 = 41
				Dim enumerator2 As List(Of OoO_O00).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim ooO_O As OoO_O00 = enumerator2.Current
					IL_2F7:
					num2 = 42
					ooO_O.O._00000.(Me)
					IL_302:
					num2 = 43
				End While
				IL_30E:
				num2 = 44
				CType(enumerator2, IDisposable).Dispose()
				IL_31E:
				num2 = 45
				If A_1 <> 1 Then
					GoTo IL_384
				End If
				IL_325:
				num2 = 46
				If Operators.CompareString(Me.Filter, "", True) <> 0 Then
					GoTo IL_34E
				End If
				IL_33B:
				num2 = 47
				Me.Filter = "[System_Filter_Unique] = 1"
				GoTo IL_3DE
				IL_34E:
				num2 = 49
				If Me.Filter.IndexOf("[System_Filter_Unique]") >= 0 Then
					GoTo IL_3DE
				End If
				IL_364:
				num2 = 50
				Me.Filter = "(" + Me.Filter + ") And [System_Filter_Unique] = 1"
				GoTo IL_3DE
				IL_384:
				num2 = 52
				If Operators.CompareString(Me.Filter, "", True) <> 0 Then
					GoTo IL_3AA
				End If
				IL_39A:
				num2 = 53
				Me.Filter = "[System_Filter_Unique] Is Null"
				GoTo IL_3DE
				IL_3AA:
				num2 = 55
				If Me.Filter.IndexOf("[System_Filter_Unique]") >= 0 Then
					GoTo IL_3DE
				End If
				IL_3C0:
				num2 = 56
				Me.Filter = "(" + Me.Filter + ") And [System_Filter_Unique] Is Null"
				IL_3DE:
				num2 = 57
				Me.ResumeRedraw()
				IL_3E7:
				GoTo IL_521
				IL_3EC:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_4E2:
				GoTo IL_516
				IL_4E4:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4F4:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4E4
			End Try
			IL_516:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_521:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A60 RID: 10848 RVA: 0x001259D8 File Offset: 0x00123BD8
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Integer)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				IL_0B:
				num2 = 3
				If Me Is Nothing Then
					GoTo IL_2CB
				End If
				IL_13:
				num2 = 5
				If Me.View.Count <= 1 Then
					GoTo IL_2CB
				End If
				IL_26:
				num2 = 8
				Me.ClearEditInfos()
				IL_2E:
				num2 = 9
				Dim list As List(Of OoO_O00) = New List(Of OoO_O00)()
				IL_38:
				num2 = 10
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_1 = 0, 1, Nothing))
				IL_52:
				num2 = 11
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_1 = 0, Nothing, 1))
				IL_6C:
				num2 = 12
				If Not Me.View.o_oo._0Oo.() AndAlso Not Me.View.O0OOO_0.o.() AndAlso Not Me.View.O0O.o__0.() Then
					GoTo IL_B9
				End If
				IL_96:
				num2 = 13
				Dim array As DataRow() = Me.View.o_o.O0ooOo.().[Select](Me.View.oo_0._o.(), A_0)
				GoTo IL_112
				IL_B9:
				num2 = 15
				array = New DataRow(Me.View.Count - 1 + 1 - 1) {}
				IL_D2:
				num2 = 16
				Dim num3 As Integer = Me.View.Count - 1
				For i As Integer = 0 To num3
					IL_E9:
					num2 = 17
					array(i) = Me.View.O0O_0_0__.0O.(i).Row
					IL_103:
					num2 = 18
				Next
				IL_112:
				num2 = 19
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_12C:
					num2 = 20
					If table.View.o_o.O0ooOo.() Is Me.View.o_o.O0ooOo.() Then
						IL_148:
						num2 = 21
						list.Add(New OoO_O00(table))
					End If
					IL_159:
					num2 = 22
				End While
				IL_165:
				num2 = 23
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_173:
				num2 = 24
				Dim a_ As Dictionary(Of DataColumn, String) = Oo00.ooO.ooo.(Me.DataTable.BaseTable)
				IL_188:
				num2 = 25
				array(0)("System_Filter_Unique") = RuntimeHelpers.GetObjectValue(objectValue)
				IL_1A0:
				num2 = 26
				Dim num4 As Integer = array.Length - 1
				For j As Integer = 1 To num4
					IL_1B0:
					num2 = 27
					If Operators.CompareString(array(j)(A_0).ToString(), array(j - 1)(A_0).ToString(), True) = 0 Then
						IL_1DD:
						num2 = 28
						array(j)("System_Filter_Unique") = RuntimeHelpers.GetObjectValue(objectValue2)
					Else
						IL_1F8:
						num2 = 30
						array(j)("System_Filter_Unique") = RuntimeHelpers.GetObjectValue(objectValue)
					End If
					IL_211:
					num2 = 31
				Next
				IL_220:
				num2 = 32
				Oo00.o0_o._O_.(a_)
				IL_22A:
				num2 = 33
				Dim enumerator2 As List(Of OoO_O00).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim ooO_O As OoO_O00 = enumerator2.Current
					IL_241:
					num2 = 34
					ooO_O.O._00000.(Me)
					IL_24C:
					num2 = 35
				End While
				IL_258:
				num2 = 36
				CType(enumerator2, IDisposable).Dispose()
				IL_268:
				num2 = 37
				If Operators.CompareString(Me.Filter, "", True) <> 0 Then
					GoTo IL_28E
				End If
				IL_27E:
				num2 = 38
				Me.Filter = "[System_Filter_Unique] = 1"
				GoTo IL_2C2
				IL_28E:
				num2 = 40
				If Me.Filter.IndexOf("[System_Filter_Unique]") >= 0 Then
					GoTo IL_2C2
				End If
				IL_2A4:
				num2 = 41
				Me.Filter = "(" + Me.Filter + ") And [System_Filter_Unique] = 1"
				IL_2C2:
				num2 = 42
				Me.ResumeRedraw()
				IL_2CB:
				GoTo IL_3C9
				IL_2D0:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_38A:
				GoTo IL_3BE
				IL_38C:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_39C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_38C
			End Try
			IL_3BE:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3C9:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A61 RID: 10849 RVA: 0x00125DD4 File Offset: 0x00123FD4
		<oO0oooo("2712")>
		Public Sub RepeatFilter(ColName As String, Mode As Integer, Optional backFilter As Boolean = False)
			If backFilter AndAlso Me.DataTable.BaseTable.PrimaryKey.Length <> 1 Then
				backFilter = False
			End If
			Select Case Mode
				Case 0
					If backFilter Then
						Me.o_0_O__o0O.oo.(ColName, 1)
						Return
					End If
					Me.o0O_o0.oOO.(ColName, 1)
					Return
				Case 1
					If backFilter Then
						Me.O____o.0.(ColName, Conversions.ToString(0))
						Return
					End If
					Me.OO.0OO000_0__.(ColName, 0)
					Return
				Case 2
					If backFilter Then
						Me.O____o.0.(ColName, Conversions.ToString(1))
						Return
					End If
					Me.OO.0OO000_0__.(ColName, 1)
					Return
				Case 3
					If backFilter Then
						Me.o_0_O__o0O.oo.(ColName, 2)
						Return
					End If
					Me.o0O_o0.oOO.(ColName, 2)
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06002A62 RID: 10850 RVA: 0x00125E74 File Offset: 0x00124074
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Integer)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = ""
				IL_0F:
				num2 = 3
				Dim a_ As String = "ShowBackSameValues" & vbVerticalTab + A_0 + vbVerticalTab + Conversions.ToString(A_1)
				IL_29:
				num2 = 4
				Dim text2 As String = Oo00.oo_0__0.o.(Me.DataTable._Adapter.SelectCommand.CommandText)
				IL_47:
				num2 = 5
				A_0 = Oo00.OoOo_oo_.o_o.(A_0, Me)
				IL_52:
				num2 = 6
				If A_1 <> 1 Then
					GoTo IL_68
				End If
				IL_58:
				num2 = 7
				text = A_0 + " in "
				GoTo IL_77
				IL_68:
				num2 = 9
				text = A_0 + " not in "
				IL_77:
				num2 = 10
				If Operators.CompareString(Me.DataTable.LoadFilter, "", True) <= 0 Then
					GoTo IL_10C
				End If
				IL_93:
				num2 = 11
				text = String.Concat(New String() { text, "( Select ", A_0, " From ", text2, " Where ", Me.DataTable.LoadFilter, " group by ", A_0, " having count(*) > 1)" })
				IL_EB:
				num2 = 12
				text = "(" + Me.DataTable.LoadFilter + ") And " + text
				GoTo IL_14C
				IL_10C:
				num2 = 14
				text = String.Concat(New String() { text, "( Select ", A_0, " From ", text2, " group by ", A_0, " having count(*) > 1)" })
				IL_14C:
				num2 = 15
				Me.DataTable.LoadPage = 0
				IL_15B:
				num2 = 16
				Me.DataTable.OOO_o_O.OO0o.(text, a_)
				IL_16C:
				num2 = 17
				Me.DataTable.o0.o.(True, Nothing)
				IL_17C:
				num2 = 18
				If Me.O.OoOo_. Is Nothing OrElse Me.O.OoOo_..FindForm() Is Nothing Then
					GoTo IL_1A2
				End If
				IL_194:
				num2 = 19
				Me.O.OoOo_..oO.Oo0__O_.()
				IL_1A2:
				GoTo IL_244
				IL_1A7:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_205:
				GoTo IL_239
				IL_207:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_217:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_207
			End Try
			IL_239:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_244:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A63 RID: 10851 RVA: 0x001260EC File Offset: 0x001242EC
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim a_ As String = "BackSameValuesFilter" & vbVerticalTab + A_0 + vbVerticalTab + A_1
				IL_1C:
				num2 = 3
				Dim text As String = Oo00.oo_0__0.o.(Me.DataTable._Adapter.SelectCommand.CommandText)
				IL_3A:
				num2 = 4
				Dim text2 As String = Me.DataTable.BaseTable.PrimaryKey(0).ColumnName
				IL_55:
				num2 = 5
				text2 = Oo00.OoOo_oo_.o_o.(text2, Me)
				IL_61:
				num2 = 6
				A_0 = Oo00.OoOo_oo_.o_o.(A_0, Me)
				IL_6C:
				num2 = 7
				If Conversions.ToDouble(A_1) <> 0.0 Then
					GoTo IL_90
				End If
				IL_7F:
				num2 = 8
				Dim text3 As String = text2 + " in "
				GoTo IL_A0
				IL_90:
				num2 = 10
				text3 = text2 + " not in "
				IL_A0:
				num2 = 11
				If Operators.CompareString(Me.DataTable.LoadFilter, "", True) <= 0 Then
					GoTo IL_136
				End If
				IL_BC:
				num2 = 12
				text3 = String.Concat(New String() { text3, "(Select min(", text2, ") From ", text, " Where ", Me.DataTable.LoadFilter, " Group by ", A_0, ")" })
				IL_115:
				num2 = 13
				text3 = "(" + Me.DataTable.LoadFilter + ") And " + text3
				GoTo IL_177
				IL_136:
				num2 = 15
				text3 = String.Concat(New String() { text3, "(Select min(", text2, ") From ", text, " Group by ", A_0, ")" })
				IL_177:
				num2 = 16
				Me.DataTable.LoadPage = 0
				IL_186:
				num2 = 17
				Me.DataTable.OOO_o_O.OO0o.(text3, a_)
				IL_197:
				num2 = 18
				Me.DataTable.o0.o.(True, Nothing)
				IL_1A7:
				num2 = 19
				If Me.O.OoOo_. Is Nothing OrElse Me.O.OoOo_..FindForm() Is Nothing Then
					GoTo IL_1CD
				End If
				IL_1BF:
				num2 = 20
				Me.O.OoOo_..oO.Oo0__O_.()
				IL_1CD:
				GoTo IL_273
				IL_1D2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_234:
				GoTo IL_268
				IL_236:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_246:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_236
			End Try
			IL_268:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_273:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A64 RID: 10852 RVA: 0x00126390 File Offset: 0x00124590
		<oO0oooo("0126")>
		Public Sub AdvancedFilter()
			New ef(Me) With { .Owner = Main.OO_O.o. }.Show()
		End Sub

		' Token: 0x06002A65 RID: 10853 RVA: 0x001263A8 File Offset: 0x001245A8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AdvancedFilter(Dialog As Boolean)
			If Not Dialog Then
				Me.AdvancedFilter()
				Return
			End If
			New ef(Me).Show()
		End Sub

		' Token: 0x06002A66 RID: 10854 RVA: 0x001263BF File Offset: 0x001245BF
		<oO0oooo("2731")>
		Public Sub GroupSubtotal(Optional last As Boolean = True)
			New j8(Not last, Me).ShowDialog()
		End Sub

		' Token: 0x06002A67 RID: 10855 RVA: 0x001263D1 File Offset: 0x001245D1
		<oO0oooo("2732")>
		Public Sub CrossSubtotal(Optional last As Boolean = True)
			New mf(Not last, Me).ShowDialog()
		End Sub

		' Token: 0x06002A68 RID: 10856 RVA: 0x001263E3 File Offset: 0x001245E3
		<oO0oooo("2733")>
		Public Sub SetSubtotalMode(Optional last As Boolean = True)
			New du(Me, Not last).ShowDialog()
		End Sub

		' Token: 0x06002A69 RID: 10857 RVA: 0x001263F5 File Offset: 0x001245F5
		<oO0oooo("2734")>
		Public Sub SetMergeMode()
			New O\u3000\u3000\u3000\u3000_\u3002(Me).ShowDialog()
		End Sub

		' Token: 0x06002A6A RID: 10858 RVA: 0x00126403 File Offset: 0x00124603
		Public Sub Save()
			Me.DataTable.Save()
		End Sub

		' Token: 0x06002A6B RID: 10859 RVA: 0x00126410 File Offset: 0x00124610
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_0 = 0, 1, Nothing))
				IL_20:
				num2 = 3
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_0 = 0, Nothing, 1))
				IL_39:
				num2 = 4
				IL_3E:
				num2 = 5
				Dim scrollPosition As Point = Me.Grid.ScrollPosition
				IL_4D:
				num2 = 6
				If Me.View.O0OOO_0.o.() Then
					GoTo IL_366
				End If
				IL_60:
				num2 = 8
				Me.ClearEditInfos()
				IL_69:
				num2 = 9
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_73:
				num2 = 10
				If Not Me.View.o_oo._0Oo.() AndAlso Not Me.View.O0OOO_0.o.() Then
					GoTo IL_B6
				End If
				IL_92:
				num2 = 11
				Dim array As DataRow() = Me.View.o_o.O0ooOo.().[Select](Me.View.oo_0._o.())
				GoTo IL_112
				IL_B6:
				num2 = 13
				array = New DataRow(Me.View.Count - 1 + 1 - 1) {}
				IL_D0:
				num2 = 14
				Dim num3 As Integer = Me.View.Count - 1
				For i As Integer = 0 To num3
					IL_E8:
					num2 = 15
					array(i) = Me.View.O0O_0_0__.0O.(i).Row
					IL_103:
					num2 = 16
				Next
				IL_112:
				num2 = 17
				Dim topRow As Integer = Me.foxGrid.Selection.TopRow
				IL_12C:
				num2 = 18
				Dim bottomRow As Integer = Me.foxGrid.Selection.BottomRow
				IL_146:
				num2 = 19
				If bottomRow < 0 Then
					GoTo IL_366
				End If
				IL_151:
				num2 = 21
				Dim num4 As Integer = bottomRow
				Dim num5 As Integer = topRow
				For j As Integer = num4 To num5 Step -1
					IL_15E:
					num2 = 22
					Dim dataIndex As Integer = Me.foxGrid.Rows(j).DataIndex
					IL_17A:
					num2 = 23
					If dataIndex >= 0 Then
						IL_181:
						num2 = 24
						list.Add(Me.View.O0O_0_0__.0O.(dataIndex).Row)
					End If
					IL_19D:
					num2 = 25
				Next
				IL_1AC:
				num2 = 26
				Dim list2 As List(Of OoO_O00) = New List(Of OoO_O00)()
				IL_1B6:
				num2 = 27
				Dim enumerator As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim table As Table = enumerator.Current
					IL_1D0:
					num2 = 28
					If table.View.o_o.O0ooOo.() Is Me.View.o_o.O0ooOo.() Then
						IL_1ED:
						num2 = 29
						list2.Add(New OoO_O00(table))
					End If
					IL_1FE:
					num2 = 30
				End While
				IL_20A:
				num2 = 31
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_218:
				num2 = 32
				For Each dataRow As DataRow In array
					IL_22B:
					num2 = 33
					dataRow("System_Filter_Unique") = RuntimeHelpers.GetObjectValue(objectValue)
					IL_241:
					num2 = 34
				Next
				IL_252:
				num2 = 35
				Dim enumerator2 As List(Of DataRow).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim dataRow2 As DataRow = enumerator2.Current
					IL_269:
					num2 = 36
					dataRow2("System_Filter_Unique") = RuntimeHelpers.GetObjectValue(objectValue2)
					IL_27F:
					num2 = 37
				End While
				IL_28B:
				num2 = 38
				CType(enumerator2, IDisposable).Dispose()
				IL_29B:
				num2 = 39
				Dim enumerator3 As List(Of OoO_O00).Enumerator = list2.GetEnumerator()
				While enumerator3.MoveNext()
					Dim ooO_O As OoO_O00 = enumerator3.Current
					IL_2B2:
					num2 = 40
					ooO_O.O._00000.(Me)
					IL_2BE:
					num2 = 41
				End While
				IL_2CA:
				num2 = 42
				CType(enumerator3, IDisposable).Dispose()
				IL_2DA:
				num2 = 43
				If Operators.CompareString(Me.Filter, "", True) <> 0 Then
					GoTo IL_302
				End If
				IL_2F1:
				num2 = 44
				Me.Filter = "[System_Filter_Unique] Is Not Null"
				GoTo IL_34C
				IL_302:
				num2 = 46
				If Me.Filter.IndexOf("[System_Filter_Unique]") >= 0 Then
					GoTo IL_33B
				End If
				IL_319:
				num2 = 47
				Me.Filter = "(" + Me.Filter + ") And [System_Filter_Unique] Is Not Null"
				GoTo IL_34C
				IL_33B:
				num2 = 49
				Me.Filter = Me.Filter
				IL_34C:
				num2 = 50
				Me.Grid.ScrollPosition = scrollPosition
				IL_35C:
				num2 = 51
				Me.ResumeRedraw()
				IL_366:
				GoTo IL_488
				IL_36B:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_449:
				GoTo IL_47D
				IL_44B:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_45B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_44B
			End Try
			IL_47D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_488:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A6C RID: 10860 RVA: 0x001268CC File Offset: 0x00124ACC
		Public Sub HideUnSelectedRows()
			Me.o.O0___OOo0_oO.(1)
		End Sub

		' Token: 0x06002A6D RID: 10861 RVA: 0x001268D5 File Offset: 0x00124AD5
		Public Sub HideSelectedRows()
			Me.o.O0___OOo0_oO.(0)
		End Sub

		' Token: 0x06002A6E RID: 10862 RVA: 0x001268DE File Offset: 0x00124ADE
		<oO0oooo("2737")>
		Public Sub OpenCalculator()
			New O\u3002\u3000\u3002\u3002(Me) With { .Owner = Main.OO_O.o. }.Show()
		End Sub

		' Token: 0x06002A6F RID: 10863 RVA: 0x001268F8 File Offset: 0x00124AF8
		<oO0oooo("3379")>
		Public Sub LoopFilter(ParentCol As String, Childcol As String)
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.StopRedraw()
				IL_0F:
				num2 = 3
				Dim dataView As DataView = New DataView(Me.DataTable.BaseTable, "", ParentCol, DataViewRowState.CurrentRows)
				IL_2A:
				num2 = 4
				Dim num3 As Integer = Me.DataTable.BaseTable.Columns.IndexOf("System_Filter_Unique")
				IL_48:
				num2 = 5
				Dim num4 As Integer = Me.DataTable.BaseTable.Columns.IndexOf(ParentCol)
				IL_62:
				num2 = 6
				Dim num5 As Integer = Me.DataTable.BaseTable.Columns.IndexOf(Childcol)
				IL_7C:
				num2 = 7
				Dim text As String = ""
				IL_85:
				num2 = 8
				Dim list As List(Of DataRowView) = New List(Of DataRowView)()
				IL_8E:
				num2 = 9
				Dim num6 As Integer = dataView.Count - 1
				For i As Integer = 0 To num6
					IL_A0:
					num2 = 10
					dataView(i)(num3) = DBNull.Value
					IL_B7:
					num2 = 11
				Next
				IL_C6:
				num2 = 12
				Dim num7 As Integer = 0
				IL_CC:
				num2 = 13
				Dim num8 As Integer = dataView.Count - 1
				For j As Integer = 0 To num8
					IL_E1:
					num2 = 14
					If Operators.CompareString(dataView(j)(num4).ToString(), dataView(j)(num5).ToString(), True) <> 0 Then
						IL_117:
						num2 = 16
						text = Conversions.ToString(dataView(j)(num4))
						IL_130:
						num2 = 17
						Dim array As DataRowView() = dataView.FindRows(RuntimeHelpers.GetObjectValue(dataView(j)(num5)))
						IL_14F:
						num2 = 18
						Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
						IL_159:
						num2 = 19
						hashSet.Add(text)
						IL_166:
						num2 = 20
						For Each dataRowView As DataRowView In array
							IL_179:
							num2 = 21
							If Me.DiguiLoopFilter(dataRowView, num4, num5, num3, text, list, hashSet) Then
								IL_192:
								num2 = 22
								If Not list.Contains(dataRowView) Then
									IL_1A0:
									num2 = 23
									list.Add(dataRowView)
								End If
								IL_1AC:
								num2 = 24
								If Not list.Contains(dataView(j)) Then
									IL_1C0:
									num2 = 25
									list.Add(dataView(j))
								End If
							End If
							IL_1D2:
							num2 = 26
						Next
						IL_1E3:
						num2 = 27
						For l As Integer = list.Count - 1 To 0 Step -1
							IL_1F3:
							num2 = 28
							If list(l).Row.IsNull(num3) Then
								IL_20D:
								num2 = 29
								list(l)(num3) = num7
							End If
							IL_227:
							num2 = 30
							num7 += 1
							IL_230:
							num2 = 31
						Next
						IL_23E:
						num2 = 32
						list.Clear()
					End If
					IL_248:
					num2 = 33
				Next
				IL_25A:
				num2 = 34
				Me.Filter = "[System_Filter_Unique] Is Not Null"
				IL_268:
				num2 = 35
				Me.Sort = "System_Filter_Unique"
				IL_276:
				num2 = 36
				Me.ResumeRedraw()
				IL_27F:
				GoTo IL_365
				IL_284:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_326:
				GoTo IL_35A
				IL_328:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_338:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_328
			End Try
			IL_35A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_365:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A70 RID: 10864 RVA: 0x00126C90 File Offset: 0x00124E90
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function DiguiLoopFilter(vr As DataRowView, parentidx As Integer, childidx As Integer, filtidx As Integer, RootKey As String, returnvrs As List(Of DataRowView), ParentKeys As HashSet(Of String)) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(vr(parentidx).ToString(), vr(childidx).ToString(), True) <> 0 Then
					GoTo IL_32
				End If
				IL_29:
				num2 = 3
				result = False
				GoTo IL_131
				IL_32:
				num2 = 4
				If Operators.CompareString(vr(childidx).ToString(), RootKey, True) <> 0 Then
					GoTo IL_69
				End If
				IL_4A:
				num2 = 5
				If returnvrs.Contains(vr) Then
					GoTo IL_60
				End If
				IL_56:
				num2 = 6
				returnvrs.Add(vr)
				IL_60:
				num2 = 7
				result = True
				GoTo IL_131
				IL_69:
				num2 = 9
				If Not ParentKeys.Contains(vr(childidx).ToString()) Then
					GoTo IL_8B
				End If
				IL_81:
				num2 = 10
				result = False
				GoTo IL_131
				IL_8B:
				num2 = 12
				ParentKeys.Add(vr(childidx).ToString())
				IL_A2:
				num2 = 13
				Dim flag As Boolean = False
				IL_A8:
				num2 = 14
				Dim array As DataRowView() = vr.DataView.FindRows(RuntimeHelpers.GetObjectValue(vr(childidx)))
				IL_C4:
				num2 = 15
				For Each dataRowView As DataRowView In array
					IL_D7:
					num2 = 16
					Dim parentKeys As HashSet(Of String) = New HashSet(Of String)(ParentKeys)
					IL_E3:
					num2 = 17
					If Me.DiguiLoopFilter(dataRowView, parentidx, childidx, filtidx, RootKey, returnvrs, parentKeys) Then
						IL_FA:
						num2 = 18
						If Not returnvrs.Contains(dataRowView) Then
							IL_108:
							num2 = 19
							returnvrs.Add(dataRowView)
						End If
						IL_114:
						num2 = 20
						flag = True
					End If
					IL_11A:
					num2 = 21
				Next
				IL_12B:
				num2 = 22
				result = flag
				IL_131:
				GoTo IL_1DF
				IL_136:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1A0:
				GoTo IL_1D4
				IL_1A2:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1B2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1A2
			End Try
			IL_1D4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1DF:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002A71 RID: 10865 RVA: 0x00126EA4 File Offset: 0x001250A4
		<oO0oooo("3380")>
		Public Sub DuplicateValuesFilter(Columns As String())
			Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
			For Each item As String In Columns
				hashSet.Add(item)
			Next
			Dim list As List(Of String) = New List(Of String)()
			list.AddRange(hashSet)
			Columns = list.ToArray()
			Dim text As String = Columns(0)
			Dim array2 As Integer() = New Integer(Columns.Length - 1 + 1 - 1) {}
			Dim num As Integer = Me.DataTable.BaseTable.Columns.IndexOf("System_Filter_Unique")
			array2(0) = Me.DataTable.BaseTable.Columns.IndexOf(Columns(0))
			Dim num2 As Integer = Columns.Length - 1
			For j As Integer = 1 To num2
				text = text + "," + Columns(j)
				array2(j) = Me.DataTable.BaseTable.Columns.IndexOf(Columns(j))
			Next
			OO_00oOO.LockBaseMainForm()
			Me.StopRedraw()
			Me.Sort = ""
			Dim dataView As DataView = New DataView(Me.DataTable.BaseTable, "", text, DataViewRowState.CurrentRows)
			dataView(0)(num) = DBNull.Value
			Dim num3 As Integer = dataView.Count - 1
			For k As Integer = 1 To num3
				Dim num4 As Integer = 0
				For Each ndx As Integer In array2
					If Operators.CompareString(dataView(k)(ndx).ToString(), dataView(k - 1)(ndx).ToString(), True) <> 0 Then
						num4 = -1
						Exit For
					End If
				Next
				If num4 = 0 Then
					dataView(k)(num) = 0
					If dataView(k - 1).Row.IsNull(num) Then
						dataView(k - 1)(num) = 0
					End If
				Else
					dataView(k)(num) = DBNull.Value
				End If
			Next
			Me.Sort = text
			Me.Filter = "[System_Filter_Unique] Is Not Null"
			Me.ResumeRedraw()
			OO_00oOO.UnlockBaseMainForm()
		End Sub

		' Token: 0x06002A72 RID: 10866 RVA: 0x001270B8 File Offset: 0x001252B8
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Try
				Dim enumerator As IEnumerator(Of Col) = Me.Cols.GetEnumerator()
				While enumerator.MoveNext()
					If enumerator.Current.IsNumeric() Then
						num = 1
						Exit While
					End If
				End While
			Finally
				Dim enumerator As IEnumerator(Of Col)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			If num = 0 Then
				MessageBox.Show("只有数值型的列才能进行统计，当前表没有数值列，请合理设置列的数据类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x17000A07 RID: 2567
		' (get) Token: 0x06002A73 RID: 10867 RVA: 0x00127120 File Offset: 0x00125320
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Dim parent As System.Windows.Forms.Control = Me.Grid.Parent
				While parent IsNot Nothing
					If TypeOf parent Is FormPanel Then
						Return OO_00oOO.Forms(parent.Name)
					End If
					parent = parent.Parent
				End While
				Return Nothing
			End Get
		End Property

		' Token: 0x17000A08 RID: 2568
		' (get) Token: 0x06002A74 RID: 10868 RVA: 0x00127164 File Offset: 0x00125364
		' (set) Token: 0x06002A75 RID: 10869 RVA: 0x00127192 File Offset: 0x00125392
		<oO0oooo("2892")>
		Public Property AllowBackEndFilter As Boolean
			Get
				Return Not Me.IsRelation AndAlso Me.DataTable.CannBackEndFilter AndAlso Me.O___O0.000OO__.
			End Get
			Set(value As Boolean)
				Me.O___O0.000OO__. = value
				If value AndAlso Operators.CompareString(Me.Filter, "", True) > 0 Then
					Me.Filter = ""
				End If
			End Set
		End Property

		' Token: 0x17000A09 RID: 2569
		' (get) Token: 0x06002A76 RID: 10870 RVA: 0x001271BD File Offset: 0x001253BD
		' (set) Token: 0x06002A77 RID: 10871 RVA: 0x001271C9 File Offset: 0x001253C9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property UseVisualStyle As Boolean
			Get
				Return Conversions.ToBoolean("")
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000A0A RID: 2570
		' (get) Token: 0x06002A78 RID: 10872 RVA: 0x001271CC File Offset: 0x001253CC
		' (set) Token: 0x06002A79 RID: 10873 RVA: 0x00127204 File Offset: 0x00125404
		<oO0oooo("3305")>
		Public Property Theme As String
			Get
				Dim result As String
				If Operators.CompareString(Me.ooo00.o0__OO0., "(default)", True) = 0 Then
					result = Me.DataTable.Theme
				Else
					result = Me.ooo00.o0__OO0.
				End If
				Return result
			End Get
			Set(value As String)
				Me.ooo00.o0__OO0. = value
				If Me.Grid.FindForm() IsNot Nothing Then
					Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me.Grid })
					Main.OO_O.o..Oo.oOo_o0Oo0.(Me.Theme, New Object() { Me.Grid })
					Me.foxGrid.Oo0._0.()
				End If
			End Set
		End Property

		' Token: 0x06002A7A RID: 10874 RVA: 0x00127268 File Offset: 0x00125468
		Friend Sub <<EMPTY_NAME>>()
			Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me.Grid })
			Main.OO_O.o..Oo.oOo_o0Oo0.(Me.Theme, New Object() { Me.Grid })
			Me.foxGrid.Oo0._0.()
		End Sub

		' Token: 0x17000A0B RID: 2571
		' (get) Token: 0x06002A7B RID: 10875 RVA: 0x001272B8 File Offset: 0x001254B8
		<oO0oooo("1577")>
		Public ReadOnly Property SysStyles As CellStyleCollection
			Get
				Return Me.foxGrid.Styles
			End Get
		End Property

		' Token: 0x06002A7C RID: 10876 RVA: 0x001272C5 File Offset: 0x001254C5
		Friend Sub <<EMPTY_NAME>>(A_0 As String(), A_1 As String, Optional A_2 As Integer = -1)
			Me.OOo0_Oo._OOo.(A_0, A_1, "", False, A_2)
		End Sub

		' Token: 0x06002A7D RID: 10877 RVA: 0x001272D8 File Offset: 0x001254D8
		Friend Sub <<EMPTY_NAME>>(A_0 As String(), A_1 As String, A_2 As String, A_3 As Boolean, Optional A_4 As Integer = -1)
			Dim text As String = ""
			For Each text2 As String In A_0
				If Not Me.DataTable.BaseTable.Columns.Contains(text2) Then
					Return
				End If
				text = text + text2 + ","
			Next
			text = text.Trim(New Char() { ","c })
			If Operators.CompareString(A_2, "", True) > 0 Then
				text = text + "," + A_2
				If A_3 Then
					text += " Desc"
				End If
			End If
			Dim list As List(Of String) = New List(Of String)()
			Me.o.0ooOO_0__..Clear()
			If Operators.CompareString(A_1, "", True) > 0 Then
				For Each text3 As String In A_1.Split(New Char() { ","c })
					If Me.DataTable.DataCols.Contains(text3) AndAlso Me.DataTable.DataCols(text3).IsNumeric Then
						list.Add(text3)
						Me.o.0ooOO_0__..Add(text3)
					End If
				Next
			End If
			Me.o.o0o_0. = True
			If Me.o.0ooOO_0__. IsNot Nothing Then
				Me.o.0ooOO_0__..Clear()
			End If
			Me.o.0ooOO_0__. = New Oo0()
			Me.o.0ooOO_0__..O_OOO.0o. = A_0
			Me.O0_O.0oOO0Oo0. = A_2
			Me.oO_.ooo0o. = A_3
			OO_00oOO.LockBaseMainForm()
			Me.StopRedraw()
			Try
				Me.Grid.Tree.Style = 2
				Me.Grid.Tree.Column = Me.Grid.Cols.Fixed
				Me.foxGrid.Subtotal(1)
				Me.foxGrid.SubtotalPosition = 0
				Dim dataView As DataView = New DataView(Me.DataTable.BaseTable, "", text, DataViewRowState.CurrentRows)
				Dim num As Integer = dataView.Count - 1
				For k As Integer = 0 To num
					dataView(k)("System_Sort_Temporary") = k
				Next
				Me.Sort = "[System_Sort_Temporary]"
				Dim o_o0OOo_.o0. As C1FlexGrid = Me.O_o0OOo_.o0.
				Dim l As Integer = o_o0OOo_.o0..Rows.Fixed
				Dim num2 As Integer = -1
				While l <= o_o0OOo_.o0..Rows.Count - 1
					Dim num3 As Integer = Me.o.oO__OO_oo_0_.(l, num2, A_0)
					If num3 > -1 Then
						num2 = o_o0OOo_.o0..Rows(l).DataIndex
						Dim num4 As Integer = num3
						Dim num5 As Integer = A_0.Length - 1
						For m As Integer = num4 To num5
							o_o0OOo_.o0..Rows.InsertNode(l, m)
							Dim num6 As Integer = m
							For n As Integer = 0 To num6
								o_o0OOo_.o0..Rows(l)(A_0(n)) = RuntimeHelpers.GetObjectValue(Me.View.O0O_0_0__.0O.(num2)(A_0(n)))
								o_o0OOo_.o0..Rows(l).Style = Me.Grid.Styles(14 + m Mod 6)
							Next
							l += 1
						Next
					End If
					l += 1
				End While
				Me.O_o0OOo_.o0..Oo.0.(True)
				Me.O_o0OOo_.o0..SetUserData(Me.O_o0OOo_.o0..Rows.Fixed, 0, "GridTreeMode")
				For num7 As Integer = A_0.Length - 1 To A_4 Step -1
					Me.O_o0OOo_.o0..Tree.Show(num7)
				Next
				If list.Count > 0 Then
					Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
					Dim row As Row = Me.Grid.Rows(Me.Grid.Rows.Count - 1)
					Try
						For Each text4 As String In list
							If row(text4) Is DBNull.Value Then
								dictionary.Add(text4, 0.0)
							Else
								dictionary.Add(text4, Conversion.Val(RuntimeHelpers.GetObjectValue(row(text4))))
							End If
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Dim num8 As Integer = Me.Grid.Rows.Count - 2
					While num8 >= 0
						row = Me.Grid.Rows(num8)
						If Not row.IsNode Then
							GoTo IL_613
						End If
						If Not Me.Grid.Rows(num8 + 1).IsNode Then
							Try
								For Each text5 As String In list
									row(text5) = dictionary(text5)
								Next
							Finally
								Dim enumerator2 As List(Of String).Enumerator
								CType(enumerator2, IDisposable).Dispose()
							End Try
						End If
						Try
							For Each key As String In list
								dictionary(key) = 0.0
							Next
						Finally
							Dim enumerator3 As List(Of String).Enumerator
							CType(enumerator3, IDisposable).Dispose()
						End Try
						If Me.Grid.Rows(num8 + 1).IsNode Then
							For Each node As Node In row.Node.Nodes
								Try
									For Each text6 As String In list
										If node.Row(text6) IsNot Nothing AndAlso node.Row(text6) IsNot DBNull.Value AndAlso node.Row(text6) IsNot DBNull.Value Then
											dictionary(text6) += Conversion.Val(RuntimeHelpers.GetObjectValue(node.Row(text6)))
										End If
									Next
								Finally
									Dim enumerator4 As List(Of String).Enumerator
									CType(enumerator4, IDisposable).Dispose()
								End Try
							Next
							Try
								For Each text7 As String In list
									row(text7) = dictionary(text7)
									dictionary(text7) = 0.0
								Next
								GoTo IL_691
							Finally
								Dim enumerator5 As List(Of String).Enumerator
								CType(enumerator5, IDisposable).Dispose()
							End Try
							GoTo IL_613
						End If
						IL_691:
						num8 += -1
						Continue While
						IL_613:
						Try
							For Each text8 As String In list
								If row(text8) IsNot Nothing AndAlso row(text8) IsNot DBNull.Value AndAlso row(text8) IsNot DBNull.Value Then
									dictionary(text8) += Conversion.Val(RuntimeHelpers.GetObjectValue(row(text8)))
								End If
							Next
						Finally
							Dim enumerator6 As List(Of String).Enumerator
							CType(enumerator6, IDisposable).Dispose()
						End Try
						GoTo IL_691
					End While
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.ResumeRedraw()
				OO_00oOO.UnlockBaseMainForm()
				Me.o.o0o_0. = False
			End Try
		End Sub

		' Token: 0x06002A7E RID: 10878 RVA: 0x00127A78 File Offset: 0x00125C78
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As String()) As Integer
			If Me.Grid.Rows(A_0).DataIndex > -1 Then
				If A_1 = -1 Then
					Return 0
				End If
				Dim dataIndex As Integer = Me.Grid.Rows(A_0).DataIndex
				Dim num As Integer = A_2.Length - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Me.View.O0O_0_0__.0O.(dataIndex)(A_2(i)).ToString(), Me.View.O0O_0_0__.0O.(A_1)(A_2(i)).ToString(), True) <> 0 Then
						Return i
					End If
				Next
			End If
			Return -1
		End Function

		' Token: 0x06002A7F RID: 10879 RVA: 0x00127B10 File Offset: 0x00125D10
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, Optional A_2 As Integer = -1)
			Me.OOo0_Oo._OOo.(A_0, A_1, "", "", A_2)
		End Sub

		' Token: 0x06002A80 RID: 10880 RVA: 0x00127B28 File Offset: 0x00125D28
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, Optional A_4 As Integer = -1)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.DataTable.BaseTable.Columns.Contains(A_1) OrElse A_1.Length <> 1 Then
					GoTo IL_48
				End If
				IL_2A:
				num2 = 3
				Me.O_.o__ooo.(A_0, "", A_1(0), A_3, A_4)
				GoTo IL_56C
				IL_48:
				num2 = 5
				Dim list As List(Of String) = New List(Of String)()
				IL_50:
				num2 = 6
				Me.o.0ooOO_0__..Clear()
				IL_5D:
				num2 = 7
				If Operators.CompareString(A_3, "", True) <= 0 Then
					GoTo IL_F8
				End If
				IL_72:
				num2 = 8
				Dim array As String() = A_3.Split(New Char() { ","c })
				IL_88:
				num2 = 9
				For Each text As String In array
					IL_9B:
					num2 = 10
					If Me.DataTable.DataCols.Contains(text) AndAlso Me.DataTable.DataCols(text).IsNumeric Then
						IL_CB:
						num2 = 11
						list.Add(text)
						IL_D6:
						num2 = 12
						Me.o.0ooOO_0__..Add(text)
					End If
					IL_E7:
					num2 = 13
				Next
				IL_F8:
				num2 = 14
				Me.o.o0o_0. = True
				IL_102:
				num2 = 15
				If Me.o.0ooOO_0__. Is Nothing Then
					GoTo IL_11D
				End If
				IL_10D:
				num2 = 16
				Me.o.0ooOO_0__..Clear()
				GoTo IL_12B
				IL_11D:
				num2 = 18
				Me.o.0ooOO_0__. = New Dictionary(Of DataRow, Dictionary(Of String, Double))()
				IL_12B:
				num2 = 19
				Me.o.0ooOO_0__. = New Oo0()
				IL_139:
				num2 = 20
				Me.o.0ooOO_0__..O_OOO.0o. = A_0
				IL_148:
				num2 = 21
				Me.o.0ooOO_0__..OO._o0_o_OO0O. = A_1
				IL_157:
				num2 = 22
				OO_00oOO.LockBaseMainForm()
				IL_15F:
				num2 = 23
				Me.StopRedraw()
				IL_168:
				num2 = 24
				If Me.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level") Then
					GoTo IL_190
				End If
				IL_187:
				num2 = 25
				Me.O_.OOoO_Oo.()
				IL_190:
				num2 = 26
				Me.DataTable.oOOO.OOO_0ooO0. = True
				IL_19F:
				num2 = 27
				If Operators.CompareString(A_2, "", True) <= 0 Then
					GoTo IL_1BD
				End If
				IL_1B1:
				num2 = 28
				Me.OO0o_o0.0oOo0o. = A_2
				GoTo IL_1C7
				IL_1BD:
				num2 = 30
				Me.OO0o_o0.0oOo0o. = A_1
				IL_1C7:
				num2 = 31
				Me.Sort = ""
				IL_1D5:
				num2 = 32
				Dim array3 As DataRow() = Me.DataTable.BaseTable.[Select](String.Concat(New String() { "(", A_0, " Is Null or ", A_1, " Is  Null) or (", A_0, " = ", A_1, ")" }), A_1, DataViewRowState.CurrentRows)
				IL_231:
				num2 = 33
				Dim hashSet As HashSet(Of String) = Oo00.O____0O._0.(Me.DataTable.BaseTable, Me.Filter, "", A_0)
				IL_252:
				num2 = 34
				Dim hashSet2 As HashSet(Of String) = Oo00.O____0O._0.(Me.DataTable.BaseTable, Me.Filter, "", A_1)
				IL_273:
				num2 = 35
				hashSet.ExceptWith(hashSet2)
				IL_27F:
				num2 = 36
				Dim list2 As List(Of String) = New List(Of String)()
				IL_289:
				num2 = 37
				If Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.) Then
					GoTo IL_39E
				End If
				IL_2C3:
				num2 = 38
				Array.Sort(Of DataRow)(array3, New o_oo(Me.O0_O.0oOO0Oo0., Me.oO_.ooo0o.))
				IL_2DE:
				num2 = 39
				For Each dataRow As DataRow In array3
					IL_2F1:
					num2 = 40
					Dim item As String
					If dataRow.IsNull(A_1) Then
						IL_2FE:
						num2 = 41
						item = dataRow(A_0).ToString()
					Else
						IL_312:
						num2 = 43
						item = dataRow(A_1).ToString()
					End If
					IL_324:
					num2 = 44
					If Not list2.Contains(item) Then
						IL_332:
						num2 = 45
						list2.Add(item)
					End If
					IL_33E:
					num2 = 46
				Next
				IL_34F:
				num2 = 47
				Dim enumerator As HashSet(Of String).Enumerator = hashSet.GetEnumerator()
				While enumerator.MoveNext()
					Dim item2 As String = enumerator.Current
					IL_366:
					num2 = 48
					If Not list2.Contains(item2) Then
						IL_374:
						num2 = 49
						list2.Add(item2)
					End If
					IL_380:
					num2 = 50
				End While
				IL_38C:
				num2 = 51
				CType(enumerator, IDisposable).Dispose()
				GoTo IL_417
				IL_39E:
				num2 = 53
				For Each dataRow2 As DataRow In array3
					IL_3B1:
					num2 = 54
					If dataRow2.IsNull(A_1) Then
						IL_3BE:
						num2 = 55
						hashSet.Add(dataRow2(A_0).ToString())
					Else
						IL_3D8:
						num2 = 57
						hashSet.Add(dataRow2(A_1).ToString())
					End If
					IL_3F0:
					num2 = 58
				Next
				IL_401:
				num2 = 59
				list2.AddRange(hashSet)
				IL_40D:
				num2 = 60
				list2.Sort()
				IL_417:
				num2 = 61
				hashSet.Clear()
				IL_421:
				num2 = 62
				hashSet2.Clear()
				IL_42B:
				num2 = 63
				Dim a_ As DataView = New DataView(Me.DataTable.BaseTable, Me.Filter, A_0, DataViewRowState.CurrentRows)
				IL_449:
				num2 = 64
				Dim dataView As DataView = New DataView(Me.DataTable.BaseTable, Me.Filter, A_1, DataViewRowState.CurrentRows)
				IL_467:
				num2 = 65
				Dim num3 As Integer = dataView.Count - 1
				For l As Integer = 0 To num3
					IL_47A:
					num2 = 66
					dataView(l)("sys_Hierarchy_Level") = DBNull.Value
					IL_495:
					num2 = 67
				Next
				IL_4A4:
				num2 = 68
				Me.OOo_OO.0_0_oo. = 0
				IL_4AE:
				num2 = 69
				Dim enumerator2 As List(Of String).Enumerator = list2.GetEnumerator()
				While enumerator2.MoveNext()
					Dim text2 As String = enumerator2.Current
					IL_4C5:
					num2 = 70
					If Operators.CompareString(text2, "", True) <> 0 Then
						IL_4D7:
						num2 = 72
						Me.OOo0_Oo._OOo.(A_0, A_1, a_, dataView, text2, New List(Of String)(), list, 0)
					End If
					IL_4F0:
					num2 = 73
				End While
				IL_4FC:
				num2 = 74
				CType(enumerator2, IDisposable).Dispose()
				IL_50C:
				num2 = 75
				Me.Sort = "[System_Sort_Temporary]"
				IL_51A:
				num2 = 76
				Me.HierarchyData = True
				IL_524:
				num2 = 77
				Me.Cols(Me.OO0o_o0.0oOo0o.).TextAlign = 1
				IL_53E:
				num2 = 78
				If A_4 <= -1 Then
					GoTo IL_551
				End If
				IL_546:
				num2 = 79
				Me.ExpandGridTree(A_4)
				IL_551:
				num2 = 80
				Me.ResumeRedraw()
				IL_55A:
				num2 = 81
				OO_00oOO.UnlockBaseMainForm()
				IL_562:
				num2 = 82
				Me.o.o0o_0. = False
				IL_56C:
				GoTo IL_70A
				IL_571:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_6CB:
				GoTo IL_6FF
				IL_6CD:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6DD:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6CD
			End Try
			IL_6FF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_70A:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A81 RID: 10881 RVA: 0x00128264 File Offset: 0x00126464
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As DataView, A_3 As DataView, A_4 As String, A_5 As List(Of String), A_6 As List(Of String), A_7 As Integer) As Dictionary(Of String, Double)
			Dim num As Integer
			Dim result As Dictionary(Of String, Double)
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
				IL_10:
				num2 = 3
				Dim enumerator As List(Of String).Enumerator = A_6.GetEnumerator()
				While enumerator.MoveNext()
					Dim key As String = enumerator.Current
					IL_26:
					num2 = 4
					dictionary.Add(key, 0.0)
					IL_3A:
					num2 = 5
				End While
				IL_45:
				num2 = 6
				CType(enumerator, IDisposable).Dispose()
				IL_54:
				num2 = 7
				If Not A_5.Contains(A_4) Then
					GoTo IL_D2
				End If
				IL_61:
				num2 = 8
				Dim num3 As Integer = A_5.IndexOf(A_4)
				IL_6E:
				num2 = 9
				MessageBox.Show(String.Concat(New String() { "发现循环引用：" & vbCrLf, String.Join("→", A_5.ToArray(), num3, A_5.Count - num3), "→", A_4, vbCrLf & "无法正确生成折叠树!" }), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				IL_C7:
				num2 = 10
				result = dictionary
				GoTo IL_5C5
				IL_D2:
				num2 = 11
				Dim right As String = ""
				IL_DC:
				num2 = 12
				If A_5.Count <= 0 Then
					GoTo IL_FE
				End If
				IL_E9:
				num2 = 13
				right = A_5(A_5.Count - 1)
				IL_FE:
				num2 = 14
				A_5.Add(A_4)
				IL_10A:
				num2 = 15
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_114:
				num2 = 16
				Dim array As DataRowView() = A_3.FindRows(A_4)
				IL_122:
				num2 = 17
				If array.Length <> 0 Then
					GoTo IL_18E
				End If
				IL_12B:
				num2 = 18
				If A_7 <> 0 Then
					GoTo IL_215
				End If
				IL_135:
				num2 = 19
				array = A_2.FindRows(A_4)
				IL_142:
				num2 = 20
				For Each dataRowView As DataRowView In array
					IL_155:
					num2 = 21
					If dataRowView.Row.IsNull(A_1) Then
						IL_167:
						num2 = 22
						list.Add(dataRowView.Row)
					End If
					IL_178:
					num2 = 23
				Next
				GoTo IL_215
				IL_18E:
				num2 = 25
				For Each dataRowView2 As DataRowView In array
					IL_1A1:
					num2 = 26
					If dataRowView2.Row.IsNull("sys_Hierarchy_Level") Then
						IL_1B7:
						num2 = 28
						If Operators.CompareString(dataRowView2(A_0).ToString(), right, True) = 0 OrElse Operators.CompareString(dataRowView2(A_0).ToString(), dataRowView2(A_1).ToString(), True) = 0 Then
							IL_1F3:
							num2 = 29
							list.Add(dataRowView2.Row)
						End If
					End If
					IL_204:
					num2 = 30
				Next
				IL_215:
				num2 = 31
				If Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.) Then
					GoTo IL_264
				End If
				IL_249:
				num2 = 32
				list.Sort(New o_oo(Me.O0_O.0oOO0Oo0., Me.oO_.ooo0o.))
				IL_264:
				num2 = 33
				Dim num4 As Integer = list.Count - 1
				For k As Integer = 0 To num4
					IL_27A:
					num2 = 34
					Dim dataRow As DataRow = list(k)
					IL_288:
					num2 = 35
					dataRow("sys_Hierarchy_Level") = A_7
					IL_29E:
					num2 = 36
					dataRow("System_Sort_Temporary") = Me.OOo_OO.0_0_oo.
					IL_2B8:
					num2 = 37
					Me.OOo_OO.0_0_oo. += 1
					IL_2C9:
					num2 = 38
					If dictionary.Count > 0 Then
						IL_2D6:
						num2 = 39
						Dim enumerator2 As List(Of String).Enumerator = A_6.GetEnumerator()
						While enumerator2.MoveNext()
							Dim text As String = enumerator2.Current
							IL_2ED:
							num2 = 40
							If Not list(k).IsNull(text) Then
								IL_302:
								num2 = 41
								dictionary(text) += Conversions.ToDouble(list(k)(text))
							End If
							IL_32D:
							num2 = 42
						End While
						IL_339:
						num2 = 43
						CType(enumerator2, IDisposable).Dispose()
					End If
					IL_349:
					num2 = 44
				Next
				IL_35B:
				num2 = 45
				Dim num5 As Integer = 1
				IL_361:
				num2 = 46
				If A_7 <> 0 OrElse list.Count <> 0 Then
					GoTo IL_377
				End If
				IL_371:
				num2 = 47
				num5 = 0
				IL_377:
				num2 = 48
				array = A_2.FindRows(A_4)
				IL_384:
				num2 = 49
				Dim list2 As List(Of String) = New List(Of String)()
				IL_38E:
				num2 = 50
				If Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.) Then
					GoTo IL_44F
				End If
				IL_3C8:
				num2 = 51
				Array.Sort(array, New O0_(Me.O0_O.0oOO0Oo0., Me.oO_.ooo0o.))
				IL_3E3:
				num2 = 52
				For Each dataRowView3 As DataRowView In array
					IL_3F6:
					num2 = 53
					If Operators.CompareString(dataRowView3(A_1).ToString(), A_4, True) <> 0 Then
						IL_410:
						num2 = 55
						Dim item As String = dataRowView3(A_1).ToString()
						IL_422:
						num2 = 56
						If Not list2.Contains(item) Then
							IL_430:
							num2 = 57
							list2.Add(item)
						End If
					End If
					IL_43C:
					num2 = 58
				Next
				GoTo IL_4C5
				IL_44F:
				num2 = 60
				Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
				IL_459:
				num2 = 61
				For Each dataRowView4 As DataRowView In array
					IL_46C:
					num2 = 62
					If Operators.CompareString(dataRowView4(A_1).ToString(), A_4, True) <> 0 Then
						IL_486:
						num2 = 64
						hashSet.Add(dataRowView4(A_1).ToString())
					End If
					IL_49E:
					num2 = 65
				Next
				IL_4AF:
				num2 = 66
				list2.AddRange(hashSet)
				IL_4BB:
				num2 = 67
				list2.Sort()
				IL_4C5:
				num2 = 68
				Dim enumerator3 As List(Of String).Enumerator = list2.GetEnumerator()
				While enumerator3.MoveNext()
					Dim a_ As String = enumerator3.Current
					IL_4DF:
					num2 = 69
					Dim list3 As List(Of String) = New List(Of String)()
					IL_4E9:
					num2 = 70
					list3.AddRange(A_5)
					IL_4F5:
					num2 = 71
					Dim dictionary2 As Dictionary(Of String, Double) = Me.OOo0_Oo._OOo.(A_0, A_1, A_2, A_3, a_, list3, A_6, A_7 + num5)
					IL_510:
					num2 = 72
					Dim enumerator4 As Dictionary(Of String, Double).KeyCollection.Enumerator = dictionary2.Keys.GetEnumerator()
					While enumerator4.MoveNext()
						Dim key2 As String = enumerator4.Current
						IL_52C:
						num2 = 73
						dictionary(key2) += dictionary2(key2)
						IL_54B:
						num2 = 74
					End While
					IL_557:
					num2 = 75
					CType(enumerator4, IDisposable).Dispose()
					IL_567:
					num2 = 76
				End While
				IL_576:
				num2 = 77
				CType(enumerator3, IDisposable).Dispose()
				IL_586:
				num2 = 78
				If dictionary.Count <= 0 OrElse list.Count <= 0 OrElse list2.Count <= 0 Then
					GoTo IL_5BF
				End If
				IL_5A7:
				num2 = 79
				Me.o.0ooOO_0__..Add(list(0), dictionary)
				IL_5BF:
				num2 = 80
				result = dictionary
				IL_5C5:
				GoTo IL_75B
				IL_5CA:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_71C:
				GoTo IL_750
				IL_71E:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_72E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_71E
			End Try
			IL_750:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_75B:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06002A82 RID: 10882 RVA: 0x001289F4 File Offset: 0x00126BF4
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Char, Optional A_2 As Integer = -1)
			Me.O_.o__ooo.(A_0, "", A_1, A_2)
		End Sub

		' Token: 0x06002A83 RID: 10883 RVA: 0x00128A04 File Offset: 0x00126C04
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Char, Optional A_3 As Integer = -1)
			Me.O_.o__ooo.(A_0, A_1, A_2, "", A_3)
		End Sub

		' Token: 0x06002A84 RID: 10884 RVA: 0x00128A18 File Offset: 0x00126C18
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Char, A_3 As String, Optional A_4 As Integer = -1)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim list As List(Of String) = New List(Of String)()
				IL_0F:
				num2 = 3
				Me.o.0ooOO_0__..Clear()
				IL_1C:
				num2 = 4
				If Operators.CompareString(A_3, "", True) <= 0 Then
					GoTo IL_B4
				End If
				IL_31:
				num2 = 5
				Dim array As String() = A_3.Split(New Char() { ","c })
				IL_47:
				num2 = 6
				For Each text As String In array
					IL_59:
					num2 = 7
					If Me.DataTable.DataCols.Contains(text) AndAlso Me.DataTable.DataCols(text).IsNumeric Then
						IL_88:
						num2 = 8
						list.Add(text)
						IL_92:
						num2 = 9
						Me.o.0ooOO_0__..Add(text)
					End If
					IL_A3:
					num2 = 10
				Next
				IL_B4:
				num2 = 11
				Me.o.o0o_0. = True
				IL_BE:
				num2 = 12
				If Me.o.0ooOO_0__. Is Nothing Then
					GoTo IL_D9
				End If
				IL_C9:
				num2 = 13
				Me.o.0ooOO_0__..Clear()
				GoTo IL_E7
				IL_D9:
				num2 = 15
				Me.o.0ooOO_0__. = New Dictionary(Of DataRow, Dictionary(Of String, Double))()
				IL_E7:
				num2 = 16
				Me.o.0ooOO_0__. = New Oo0()
				IL_F5:
				num2 = 17
				Me.o.0ooOO_0__..OOOO._. = A_0
				IL_104:
				num2 = 18
				Me.o.0ooOO_0__..O_OOO.0o. = A_2
				IL_113:
				num2 = 19
				OO_00oOO.LockBaseMainForm()
				IL_11B:
				num2 = 20
				Me.StopRedraw()
				IL_124:
				num2 = 21
				If Me.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level") Then
					GoTo IL_14C
				End If
				IL_143:
				num2 = 22
				Me.O_.OOoO_Oo.()
				IL_14C:
				num2 = 23
				Me.DataTable.oOOO.OOO_0ooO0. = True
				IL_15B:
				num2 = 24
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_179
				End If
				IL_16D:
				num2 = 25
				Me.OO0o_o0.0oOo0o. = A_1
				GoTo IL_183
				IL_179:
				num2 = 27
				Me.OO0o_o0.0oOo0o. = A_0
				IL_183:
				num2 = 28
				Me.Sort = ""
				IL_191:
				num2 = 29
				If Not Me.IsChild Then
					GoTo IL_1A9
				End If
				IL_19C:
				num2 = 30
				Dim bindingList As IBindingList = Me.View
				GoTo IL_1C7
				IL_1A9:
				num2 = 32
				bindingList = New DataView(Me.DataTable.BaseTable, Me.Filter, A_0, DataViewRowState.CurrentRows)
				IL_1C7:
				num2 = 33
				Dim num3 As Integer = bindingList.Count - 1
				For j As Integer = 0 To num3
					IL_1DA:
					num2 = 34
					NewLateBinding.LateIndexSetComplex(bindingList(j), New Object() { "sys_Hierarchy_Level", DBNull.Value }, Nothing, False, True)
					IL_204:
					num2 = 35
				Next
				IL_213:
				num2 = 36
				Me.OOo_OO.0_0_oo. = 0
				IL_21D:
				num2 = 37
				Dim flag As Boolean = True
				IL_223:
				num2 = 38
				Dim left As String = ""
				IL_22D:
				num2 = 39
				Dim dictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
				IL_237:
				num2 = 40
				Dim treeView As System.Windows.Forms.TreeView = Nothing
				IL_23D:
				num2 = 41
				Dim stack As Stack(Of System.Windows.Forms.TreeNode) = Nothing
				IL_243:
				num2 = 42
				Dim flag2 As Boolean = False
				IL_249:
				num2 = 43
				If list.Count <= 0 AndAlso (Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.)) Then
					GoTo IL_2D4
				End If
				IL_286:
				num2 = 44
				treeView = New System.Windows.Forms.TreeView()
				IL_290:
				num2 = 45
				stack = New Stack(Of System.Windows.Forms.TreeNode)()
				IL_29A:
				num2 = 46
				If Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.) Then
					GoTo IL_2D4
				End If
				IL_2CE:
				num2 = 47
				flag2 = True
				IL_2D4:
				num2 = 48
				Dim num4 As Integer = bindingList.Count - 1
				For k As Integer = 0 To num4
					IL_2EA:
					num2 = 49
					Dim instance As Object = NewLateBinding.LateGet(bindingList(k), Nothing, "Row", New Object(-1) {}, Nothing, Nothing, Nothing)
					Dim type As Type = Nothing
					Dim memberName As String = "IsNull"
					Dim array3 As Object() = New Object() { A_0 }
					Dim array4 As Object() = array3
					Dim argumentNames As String() = Nothing
					Dim typeArguments As Type() = Nothing
					Dim array5 As Boolean() = New Boolean() { True }
					Dim array6 As Boolean() = array5
					Dim value As Object = NewLateBinding.LateGet(instance, type, memberName, array3, argumentNames, typeArguments, array5)
					If array6(0) Then
						A_0 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4(0)), GetType(String)))
					End If
					If Conversions.ToBoolean(value) Then
						IL_35D:
						num2 = 50
						NewLateBinding.LateSetComplex(bindingList(k), Nothing, "row", New Object() { "sys_Hierarchy_Level", 0 }, Nothing, Nothing, False, True)
					Else
						IL_394:
						num2 = 52
						Dim text2 As String = NewLateBinding.LateIndexGet(bindingList(k), New Object() { A_0 }, Nothing).ToString()
						IL_3B7:
						num2 = 53
						If Not flag2 Then
							IL_3BE:
							num2 = 54
							NewLateBinding.LateIndexSetComplex(bindingList(k), New Object() { "System_Sort_Temporary", Me.OOo_OO.0_0_oo. }, Nothing, False, True)
							IL_3EE:
							num2 = 55
							Me.OOo_OO.0_0_oo. += 1
						End If
						IL_3FF:
						num2 = 56
						Dim array7 As String() = text2.Split(New Char() { A_2 })
						IL_415:
						num2 = 57
						Dim num5 As Integer = 0
						IL_41B:
						num2 = 58
						If k <> 0 AndAlso array7.Length <> 1 Then
							IL_429:
							num2 = 60
							Dim num6 As Integer = array7.Length - 1
							Dim key As String
							While True
								IL_474:
								num2 = 62
								If num6 <= 0 Then
									GoTo IL_47C
								End If
								IL_436:
								num2 = 63
								key = String.Join(Conversions.ToString(A_2), array7, 0, num6)
								IL_44B:
								num2 = 64
								If dictionary.ContainsKey(key) Then
									Exit For
								End If
								IL_46B:
								num2 = 67
								num6 -= 1
							End While
							IL_459:
							num2 = 65
							num5 = dictionary(key) + 1
						End If
						IL_47C:
						num2 = 69
						NewLateBinding.LateIndexSetComplex(bindingList(k), New Object() { "sys_Hierarchy_Level", num5 }, Nothing, False, True)
						IL_4A8:
						num2 = 70
						If num5 = 0 Then
							IL_4AF:
							num2 = 71
							dictionary.Clear()
						End If
						IL_4B9:
						num2 = 72
						If Not dictionary.ContainsKey(text2) Then
							IL_4C7:
							num2 = 73
							dictionary.Add(text2, num5)
						End If
						IL_4D5:
						num2 = 74
						If flag AndAlso k > 0 Then
							IL_4E1:
							num2 = 75
							If Operators.CompareString(left, text2, True) = 0 Then
								IL_4F0:
								num2 = 76
								flag = False
							End If
						End If
						IL_4F6:
						num2 = 77
						left = text2
						IL_4FD:
						num2 = 78
						If treeView IsNot Nothing Then
							IL_507:
							num2 = 79
							Dim treeNode As System.Windows.Forms.TreeNode = Nothing
							IL_50D:
							num2 = 80
							If num5 > 0 Then
								While True
									IL_53E:
									num2 = 82
									If stack.Count <= 0 Then
										Exit For
									End If
									IL_517:
									num2 = 83
									treeNode = stack.Peek()
									IL_523:
									num2 = 84
									If treeNode.Level = num5 - 1 Then
										Exit For
									End If
									IL_533:
									num2 = 87
									stack.Pop()
								End While
							End If
							IL_54B:
							num2 = 89
							Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode()
							IL_555:
							num2 = 90
							treeNode2.Text = text2
							IL_561:
							num2 = 91
							treeNode2.Tag = RuntimeHelpers.GetObjectValue(bindingList(k))
							IL_579:
							num2 = 92
							If treeNode IsNot Nothing Then
								IL_580:
								num2 = 93
								treeNode.Nodes.Add(treeNode2)
							Else
								IL_594:
								num2 = 95
								treeView.Nodes.Add(treeNode2)
							End If
							IL_5A6:
							num2 = 96
							stack.Push(treeNode2)
						End If
					End If
					IL_5B2:
					num2 = 97
				Next
				IL_5C4:
				num2 = 98
				If treeView Is Nothing Then
					GoTo IL_872
				End If
				IL_5CE:
				num2 = 99
				If list.Count <= 0 Then
					GoTo IL_809
				End If
				IL_5DD:
				num2 = 100
				Dim list2 As List(Of System.Windows.Forms.TreeNode) = o_O_o_oOoo__.OO_O0oO0.oooO_.(treeView)
				IL_5E9:
				num2 = 101
				Dim dictionary2 As Dictionary(Of System.Windows.Forms.TreeNode, Dictionary(Of String, Double)) = New Dictionary(Of System.Windows.Forms.TreeNode, Dictionary(Of String, Double))()
				IL_5F3:
				num2 = 102
				For l As Integer = list2.Count - 1 To 0 Step -1
					IL_606:
					num2 = 103
					Dim treeNode3 As System.Windows.Forms.TreeNode = list2(l)
					IL_614:
					num2 = 104
					Dim parent As System.Windows.Forms.TreeNode = treeNode3.Parent
					IL_620:
					num2 = 105
					Dim dataRowView As DataRowView = CType(treeNode3.Tag, DataRowView)
					IL_631:
					num2 = 106
					Dim dictionary3 As Dictionary(Of String, Double) = Nothing
					IL_637:
					num2 = 107
					If parent IsNot Nothing Then
						IL_641:
						num2 = 108
						If Not dictionary2.TryGetValue(parent, dictionary3) Then
							IL_654:
							num2 = 109
							dictionary3 = New Dictionary(Of String, Double)()
							IL_65E:
							num2 = 110
							Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
							While enumerator.MoveNext()
								Dim key2 As String = enumerator.Current
								IL_674:
								num2 = 111
								dictionary3(key2) = 0.0
								IL_689:
								num2 = 112
							End While
							IL_695:
							num2 = 113
							CType(enumerator, IDisposable).Dispose()
							IL_6A5:
							num2 = 114
							dictionary2.Add(parent, dictionary3)
							IL_6B3:
							num2 = 115
							Me.o.0ooOO_0__..Add(CType(parent.Tag, DataRowView).Row, dictionary3)
						End If
						IL_6D4:
						num2 = 116
						Dim enumerator2 As List(Of String).Enumerator = list.GetEnumerator()
						While enumerator2.MoveNext()
							Dim text3 As String = enumerator2.Current
							IL_6EA:
							num2 = 117
							If Not dataRowView.Row.IsNull(text3) Then
								IL_6FD:
								num2 = 118
								dictionary3(text3) += Conversions.ToDouble(dataRowView(text3))
							End If
							IL_721:
							num2 = 119
						End While
						IL_72D:
						num2 = 120
						CType(enumerator2, IDisposable).Dispose()
					End If
					IL_73D:
					num2 = 121
					If treeNode3.Nodes.Count > 0 Then
						IL_752:
						num2 = 122
						Dim dictionary4 As Dictionary(Of String, Double) = dictionary2(treeNode3)
						IL_760:
						num2 = 123
						Dim enumerator3 As List(Of String).Enumerator = list.GetEnumerator()
						While enumerator3.MoveNext()
							Dim text4 As String = enumerator3.Current
							IL_776:
							num2 = 124
							If parent IsNot Nothing Then
								IL_77D:
								num2 = 125
								dictionary3(text4) += dictionary4(text4)
							End If
							IL_79C:
							num2 = 126
							If Not dataRowView.Row.IsNull(text4) Then
								IL_7AF:
								num2 = 127
								dictionary4(text4) += Conversions.ToDouble(dataRowView(text4))
							End If
							IL_7D3:
							num2 = 128
						End While
						IL_7E2:
						num2 = 129
						CType(enumerator3, IDisposable).Dispose()
					End If
					IL_7F5:
					num2 = 130
				Next
				IL_809:
				num2 = 131
				If Not flag2 Then
					GoTo IL_872
				End If
				IL_813:
				num2 = 132
				treeView.TreeViewNodeSorter = New OOO(Me.O0_O.0oOO0Oo0., Me.oO_.ooo0o., flag, A_2)
				IL_834:
				num2 = 133
				treeView.TreeViewNodeSorter = Nothing
				IL_842:
				num2 = 134
				If flag Then
					GoTo IL_85F
				End If
				IL_84C:
				num2 = 135
				Me.o00O.oooo0.(treeView.Nodes)
				IL_85F:
				num2 = 136
				Me.O0o._oo_.(treeView.Nodes)
				IL_872:
				num2 = 137
				Me.Sort = "[System_Sort_Temporary]"
				IL_883:
				num2 = 138
				Me.HierarchyData = True
				IL_890:
				num2 = 139
				Me.Cols(Me.OO0o_o0.0oOo0o.).TextAlign = 1
				IL_8AD:
				num2 = 140
				If A_4 <= -1 Then
					GoTo IL_8C6
				End If
				IL_8B8:
				num2 = 141
				Me.ExpandGridTree(A_4)
				IL_8C6:
				num2 = 142
				Me.ResumeRedraw()
				IL_8D2:
				num2 = 143
				OO_00oOO.UnlockBaseMainForm()
				IL_8DD:
				num2 = 144
				Me.o.o0o_0. = False
				IL_8EA:
				GoTo IL_B80
				IL_8EF:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_B41:
				GoTo IL_B75
				IL_B43:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B53:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B43
			End Try
			IL_B75:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B80:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A85 RID: 10885 RVA: 0x001295CC File Offset: 0x001277CC
		Private Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection)
			Try
				For Each obj As Object In A_0
					Dim treeNode As System.Windows.Forms.TreeNode = CType(obj, System.Windows.Forms.TreeNode)
					If treeNode.Nodes.Count > 0 Then
						Dim treeNode2 As System.Windows.Forms.TreeNode = treeNode
						While True
							Dim nextNode As System.Windows.Forms.TreeNode = treeNode2.NextNode
							If nextNode Is Nothing OrElse Operators.CompareString(treeNode2.NextNode.Text, treeNode.Text, True) <> 0 Then
								Exit For
							End If
							treeNode2 = nextNode
						End While
						If treeNode2 IsNot treeNode Then
							Dim array As System.Windows.Forms.TreeNode() = New System.Windows.Forms.TreeNode(treeNode.Nodes.Count - 1 + 1 - 1) {}
							treeNode.Nodes.CopyTo(array, 0)
							treeNode.Nodes.Clear()
							treeNode2.Nodes.AddRange(array)
							Me.o00O.oooo0.(treeNode2.Nodes)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002A86 RID: 10886 RVA: 0x001296A8 File Offset: 0x001278A8
		Private Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection)
			Try
				For Each obj As Object In A_0
					Dim treeNode As System.Windows.Forms.TreeNode = CType(obj, System.Windows.Forms.TreeNode)
					CType(treeNode.Tag, DataRowView)("System_Sort_Temporary") = Me.OOo_OO.0_0_oo.
					Me.OOo_OO.0_0_oo. += 1
					If treeNode.Nodes.Count > 0 Then
						Me.O0o._oo_.(treeNode.Nodes)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06002A87 RID: 10887 RVA: 0x00129740 File Offset: 0x00127940
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Integer(), Optional A_2 As Integer = -1)
			Me.OOo0_Oo._OOo.(A_0, "", A_1, A_2)
		End Sub

		' Token: 0x06002A88 RID: 10888 RVA: 0x00129750 File Offset: 0x00127950
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Integer(), Optional A_3 As Integer = -1)
			Me.OOo0_Oo._OOo.(A_0, A_1, A_2, "", A_3)
		End Sub

		' Token: 0x06002A89 RID: 10889 RVA: 0x00129764 File Offset: 0x00127964
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Integer(), A_3 As String, Optional A_4 As Integer = -1)
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim list As List(Of String) = New List(Of String)()
				IL_0F:
				num2 = 3
				Me.o.0ooOO_0__..Clear()
				IL_1C:
				num2 = 4
				If Operators.CompareString(A_3, "", True) <= 0 Then
					GoTo IL_B4
				End If
				IL_31:
				num2 = 5
				Dim array As String() = A_3.Split(New Char() { ","c })
				IL_47:
				num2 = 6
				For Each text As String In array
					IL_59:
					num2 = 7
					If Me.DataTable.DataCols.Contains(text) AndAlso Me.DataTable.DataCols(text).IsNumeric Then
						IL_88:
						num2 = 8
						list.Add(text)
						IL_92:
						num2 = 9
						Me.o.0ooOO_0__..Add(text)
					End If
					IL_A3:
					num2 = 10
				Next
				IL_B4:
				num2 = 11
				Me.o.o0o_0. = True
				IL_BE:
				num2 = 12
				If Me.o.0ooOO_0__. Is Nothing Then
					GoTo IL_D9
				End If
				IL_C9:
				num2 = 13
				Me.o.0ooOO_0__..Clear()
				GoTo IL_E7
				IL_D9:
				num2 = 15
				Me.o.0ooOO_0__. = New Dictionary(Of DataRow, Dictionary(Of String, Double))()
				IL_E7:
				num2 = 16
				Me.o.0ooOO_0__. = New Oo0()
				IL_F5:
				num2 = 17
				Me.o.0ooOO_0__..OOOO._. = A_0
				IL_104:
				num2 = 18
				Me.o.0ooOO_0__..O_OOO.0o. = A_2
				IL_113:
				num2 = 19
				OO_00oOO.LockBaseMainForm()
				IL_11B:
				num2 = 20
				Me.StopRedraw()
				IL_124:
				num2 = 21
				If Me.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level") Then
					GoTo IL_14C
				End If
				IL_143:
				num2 = 22
				Me.O_.OOoO_Oo.()
				IL_14C:
				num2 = 23
				Me.DataTable.oOOO.OOO_0ooO0. = True
				IL_15B:
				num2 = 24
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_179
				End If
				IL_16D:
				num2 = 25
				Me.OO0o_o0.0oOo0o. = A_1
				GoTo IL_183
				IL_179:
				num2 = 27
				Me.OO0o_o0.0oOo0o. = A_0
				IL_183:
				num2 = 28
				Me.Sort = ""
				IL_191:
				num2 = 29
				Dim dataView As DataView = New DataView(Me.DataTable.BaseTable, Me.Filter, A_0, DataViewRowState.CurrentRows)
				IL_1AF:
				num2 = 30
				Dim num3 As Integer = dataView.Count - 1
				For j As Integer = 0 To num3
					IL_1C2:
					num2 = 31
					dataView(j)("sys_Hierarchy_Level") = DBNull.Value
					IL_1DD:
					num2 = 32
				Next
				IL_1EC:
				num2 = 33
				Me.OOo_OO.0_0_oo. = 0
				IL_1F6:
				num2 = 34
				Dim flag As Boolean = True
				IL_1FC:
				num2 = 35
				Dim left As String = ""
				IL_206:
				num2 = 36
				Dim dictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
				IL_210:
				num2 = 37
				Dim flag2 As Boolean = False
				IL_216:
				num2 = 38
				Dim treeView As System.Windows.Forms.TreeView = Nothing
				IL_21C:
				num2 = 39
				Dim stack As Stack(Of System.Windows.Forms.TreeNode) = Nothing
				IL_222:
				num2 = 40
				If list.Count <= 0 AndAlso (Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.)) Then
					GoTo IL_2AD
				End If
				IL_25F:
				num2 = 41
				treeView = New System.Windows.Forms.TreeView()
				IL_269:
				num2 = 42
				stack = New Stack(Of System.Windows.Forms.TreeNode)()
				IL_273:
				num2 = 43
				If Operators.CompareString(Me.O0_O.0oOO0Oo0., "", True) <= 0 OrElse Not Me.DataTable.BaseTable.Columns.Contains(Me.O0_O.0oOO0Oo0.) Then
					GoTo IL_2AD
				End If
				IL_2A7:
				num2 = 44
				flag2 = True
				IL_2AD:
				num2 = 45
				Dim num4 As Integer = dataView.Count - 1
				For k As Integer = 0 To num4
					IL_2C3:
					num2 = 46
					If Not dataView(k).Row.IsNull(A_0) Then
						IL_2DF:
						num2 = 48
						If Not flag2 Then
							IL_2E6:
							num2 = 49
							dataView(k)("System_Sort_Temporary") = Me.OOo_OO.0_0_oo.
							IL_307:
							num2 = 50
							Me.OOo_OO.0_0_oo. += 1
						End If
						IL_318:
						num2 = 51
						Dim text2 As String = Conversions.ToString(dataView(k)(A_0))
						IL_331:
						num2 = 52
						Dim list2 As List(Of String) = New List(Of String)()
						IL_33B:
						num2 = 53
						Dim num5 As Integer = -1
						IL_341:
						num2 = 54
						Dim num6 As Integer = 0
						IL_347:
						num2 = 55
						Dim num7 As Integer = 0
						While True
							IL_3A6:
							num2 = 57
							If num6 > text2.Length - 1 Then
								Exit For
							End If
							IL_34F:
							num2 = 58
							If num5 < A_2.Length - 1 Then
								IL_35B:
								num2 = 59
								num5 += 1
							Else
								IL_366:
								num2 = 61
								num5 = A_2.Length - 1
							End If
							IL_370:
							num2 = 62
							If num6 + A_2(num5) > text2.Length Then
								Exit For
							End If
							IL_383:
							num2 = 63
							list2.Add(text2.Substring(num6, A_2(num5)))
							IL_39A:
							num2 = 64
							num6 += A_2(num5)
						End While
						IL_3B6:
						num2 = 68
						If k <> 0 AndAlso list2.Count <> 1 Then
							IL_3C7:
							num2 = 70
							num5 = list2.Count - 1
							Dim key As String
							While True
								IL_419:
								num2 = 72
								If num5 <= 0 Then
									GoTo IL_421
								End If
								IL_3D7:
								num2 = 73
								key = String.Join("", list2.ToArray(), 0, num5)
								IL_3F0:
								num2 = 74
								If dictionary.ContainsKey(key) Then
									Exit For
								End If
								IL_410:
								num2 = 77
								num5 -= 1
							End While
							IL_3FE:
							num2 = 75
							num7 = dictionary(key) + 1
						End If
						IL_421:
						num2 = 79
						dataView(k)("sys_Hierarchy_Level") = num7
						IL_43E:
						num2 = 80
						If num7 = 0 Then
							IL_445:
							num2 = 81
							dictionary.Clear()
						End If
						IL_44F:
						num2 = 82
						Dim text3 As String = dataView(k)(A_0).ToString()
						IL_468:
						num2 = 83
						If Not dictionary.ContainsKey(text3) Then
							IL_476:
							num2 = 84
							dictionary.Add(text3, num7)
						End If
						IL_484:
						num2 = 85
						If flag AndAlso k > 0 Then
							IL_490:
							num2 = 86
							If Operators.CompareString(left, text3, True) = 0 Then
								IL_49F:
								num2 = 87
								flag = False
							End If
						End If
						IL_4A5:
						num2 = 88
						left = text3
						IL_4AC:
						num2 = 89
						If treeView IsNot Nothing Then
							IL_4B6:
							num2 = 90
							Dim treeNode As System.Windows.Forms.TreeNode = Nothing
							IL_4BC:
							num2 = 91
							If num7 > 0 Then
								While True
									IL_4ED:
									num2 = 93
									If stack.Count <= 0 Then
										Exit For
									End If
									IL_4C6:
									num2 = 94
									treeNode = stack.Peek()
									IL_4D2:
									num2 = 95
									If treeNode.Level = num7 - 1 Then
										Exit For
									End If
									IL_4E2:
									num2 = 98
									stack.Pop()
								End While
							End If
							IL_4FA:
							num2 = 100
							Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode()
							IL_504:
							num2 = 101
							treeNode2.Name = text3
							IL_510:
							num2 = 102
							treeNode2.Tag = dataView(k)
							IL_523:
							num2 = 103
							If treeNode IsNot Nothing Then
								IL_52A:
								num2 = 104
								treeNode.Nodes.Add(treeNode2)
							Else
								IL_53E:
								num2 = 106
								treeView.Nodes.Add(treeNode2)
							End If
							IL_550:
							num2 = 107
							stack.Push(treeNode2)
						End If
					End If
					IL_55C:
					num2 = 108
				Next
				IL_56E:
				num2 = 109
				If treeView Is Nothing Then
					GoTo IL_83F
				End If
				IL_578:
				num2 = 110
				If list.Count <= 0 Then
					GoTo IL_7D7
				End If
				IL_587:
				num2 = 111
				Dim list3 As List(Of System.Windows.Forms.TreeNode) = o_O_o_oOoo__.OO_O0oO0.oooO_.(treeView)
				IL_593:
				num2 = 112
				Dim dictionary2 As Dictionary(Of System.Windows.Forms.TreeNode, Dictionary(Of String, Double)) = New Dictionary(Of System.Windows.Forms.TreeNode, Dictionary(Of String, Double))()
				IL_59D:
				num2 = 113
				For l As Integer = list3.Count - 1 To 0 Step -1
					IL_5B0:
					num2 = 114
					Dim treeNode3 As System.Windows.Forms.TreeNode = list3(l)
					IL_5BE:
					num2 = 115
					Dim parent As System.Windows.Forms.TreeNode = treeNode3.Parent
					IL_5CA:
					num2 = 116
					Dim dataRowView As DataRowView = CType(treeNode3.Tag, DataRowView)
					IL_5DB:
					num2 = 117
					Dim dictionary3 As Dictionary(Of String, Double) = Nothing
					IL_5E1:
					num2 = 118
					If parent IsNot Nothing Then
						IL_5EB:
						num2 = 119
						If Not dictionary2.TryGetValue(parent, dictionary3) Then
							IL_5FE:
							num2 = 120
							dictionary3 = New Dictionary(Of String, Double)()
							IL_608:
							num2 = 121
							Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
							While enumerator.MoveNext()
								Dim key2 As String = enumerator.Current
								IL_61E:
								num2 = 122
								dictionary3(key2) = 0.0
								IL_633:
								num2 = 123
							End While
							IL_63F:
							num2 = 124
							CType(enumerator, IDisposable).Dispose()
							IL_64F:
							num2 = 125
							dictionary2.Add(parent, dictionary3)
							IL_65D:
							num2 = 126
							Me.o.0ooOO_0__..Add(CType(parent.Tag, DataRowView).Row, dictionary3)
						End If
						IL_67E:
						num2 = 127
						Dim enumerator2 As List(Of String).Enumerator = list.GetEnumerator()
						While enumerator2.MoveNext()
							Dim text4 As String = enumerator2.Current
							IL_694:
							num2 = 128
							If Not dataRowView.Row.IsNull(text4) Then
								IL_6AA:
								num2 = 129
								dictionary3(text4) += Conversions.ToDouble(dataRowView(text4))
							End If
							IL_6D1:
							num2 = 130
						End While
						IL_6E0:
						num2 = 131
						CType(enumerator2, IDisposable).Dispose()
					End If
					IL_6F3:
					num2 = 132
					If treeNode3.Nodes.Count > 0 Then
						IL_70B:
						num2 = 133
						Dim dictionary4 As Dictionary(Of String, Double) = dictionary2(treeNode3)
						IL_71C:
						num2 = 134
						Dim enumerator3 As List(Of String).Enumerator = list.GetEnumerator()
						While enumerator3.MoveNext()
							Dim text5 As String = enumerator3.Current
							IL_735:
							num2 = 135
							If parent IsNot Nothing Then
								IL_73F:
								num2 = 136
								dictionary3(text5) += dictionary4(text5)
							End If
							IL_761:
							num2 = 137
							If Not dataRowView.Row.IsNull(text5) Then
								IL_777:
								num2 = 138
								dictionary4(text5) += Conversions.ToDouble(dataRowView(text5))
							End If
							IL_79E:
							num2 = 139
						End While
						IL_7B0:
						num2 = 140
						CType(enumerator3, IDisposable).Dispose()
					End If
					IL_7C3:
					num2 = 141
				Next
				IL_7D7:
				num2 = 142
				If Not flag2 Then
					GoTo IL_83F
				End If
				IL_7E1:
				num2 = 143
				treeView.TreeViewNodeSorter = New OOO(Me.O0_O.0oOO0Oo0., Me.oO_.ooo0o., flag)
				IL_801:
				num2 = 144
				treeView.TreeViewNodeSorter = Nothing
				IL_80F:
				num2 = 145
				If flag Then
					GoTo IL_82C
				End If
				IL_819:
				num2 = 146
				Me.o00O.oooo0.(treeView.Nodes)
				IL_82C:
				num2 = 147
				Me.O0o._oo_.(treeView.Nodes)
				IL_83F:
				num2 = 148
				Me.Sort = "[System_Sort_Temporary]"
				IL_850:
				num2 = 149
				Me.HierarchyData = True
				IL_85D:
				num2 = 150
				Me.Cols(Me.OO0o_o0.0oOo0o.).TextAlign = 1
				IL_87A:
				num2 = 151
				If A_4 <= -1 Then
					GoTo IL_893
				End If
				IL_885:
				num2 = 152
				Me.ExpandGridTree(A_4)
				IL_893:
				num2 = 153
				Me.ResumeRedraw()
				IL_89F:
				num2 = 154
				OO_00oOO.UnlockBaseMainForm()
				IL_8AA:
				num2 = 155
				Me.o.o0o_0. = False
				IL_8B7:
				GoTo IL_B79
				IL_8BC:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_B3A:
				GoTo IL_B6E
				IL_B3C:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B4C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B3C
			End Try
			IL_B6E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B79:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002A8A RID: 10890 RVA: 0x0012A310 File Offset: 0x00128510
		<oO0oooo("3386")>
		Public Sub ExpandGridTree(level As Integer)
			If Me.HierarchyData Then
				Me.O_o0OOo_.o0..OoO._OOo__.(level)
			End If
		End Sub

		' Token: 0x06002A8B RID: 10891 RVA: 0x0012A326 File Offset: 0x00128526
		<oO0oooo("3386")>
		Public Sub CloseGridTree()
			OO_00oOO.LockBaseMainForm()
			Me.o.oO000Ooo_.()
			OO_00oOO.UnlockBaseMainForm()
		End Sub

		' Token: 0x06002A8C RID: 10892 RVA: 0x0012A338 File Offset: 0x00128538
		Friend Sub <<EMPTY_NAME>>()
			Me.StopRedraw()
			If Me.foxGrid.OO.o_o00o.() Then
				Me.foxGrid.Oo.0.(False)
				Me.foxGrid.Subtotal(1)
			Else
				Me.O0_O.0oOO0Oo0. = False
				If Not Me.o.o0o_0. AndAlso Me.o.0ooOO_0__. IsNot Nothing Then
					Me.o.0ooOO_0__..Clear()
					Me.o.0ooOO_0__. = Nothing
				End If
				Dim c1FlexGrid As C1FlexGrid = Me.Grid
				Dim fixed As Integer = c1FlexGrid.Rows.Fixed
				Dim num As Integer = c1FlexGrid.Rows.Count - 1
				For i As Integer = fixed To num
					c1FlexGrid.Rows(i).Visible = True
					c1FlexGrid.SetUserData(i, c1FlexGrid.Cols.Fixed - 1, Nothing)
				Next
			End If
			Me.ResumeRedraw()
		End Sub

		' Token: 0x06002A8D RID: 10893 RVA: 0x0012A3F8 File Offset: 0x001285F8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ShowGridTree(ParamArray Args As Object())
			If Args.Length = 1 Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Args(0))
				If TypeOf objectValue Is LayerTreeSetting Then
					Me.ShowGridTree(CType(objectValue, LayerTreeSetting))
					Return
				End If
				If TypeOf objectValue Is InlineTreeSetting Then
					Me.ShowGridTree(CType(objectValue, InlineTreeSetting))
					Return
				End If
				If TypeOf objectValue Is GroupTreeSetting Then
					Me.ShowGridTree(CType(objectValue, GroupTreeSetting), 0)
					Return
				End If
			ElseIf Args.Length = 2 Then
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Args(0))
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Args(1))
				If TypeOf objectValue2 Is GroupTreeSetting AndAlso TypeOf objectValue3 Is Integer Then
					Me.ShowGridTree(CType(objectValue2, GroupTreeSetting), Conversions.ToInteger(objectValue3))
				End If
			End If
		End Sub

		' Token: 0x06002A8E RID: 10894 RVA: 0x0012A490 File Offset: 0x00128690
		<oO0oooo("3348")>
		Public Sub ShowGridTree(Setting As InlineTreeSetting)
			Me.O0_O.0oOO0Oo0. = Setting.SortCol
			Me.oO_.ooo0o. = Setting.SortDesc
			Me.oO._o. = Setting.UseStyle
			Dim a_ As String = ""
			If Setting.AggregateCols IsNot Nothing AndAlso Setting.AggregateCols.Length > 0 Then
				a_ = String.Join(",", Setting.AggregateCols)
			End If
			Me.OOo0_Oo._OOo.(Setting.ParentCol, Setting.ChildCol, Setting.TreeCol, a_, Setting.ExpandTo)
		End Sub

		' Token: 0x06002A8F RID: 10895 RVA: 0x0012A50C File Offset: 0x0012870C
		<oO0oooo("3349")>
		Public Sub ShowGridTree(Setting As LayerTreeSetting)
			Me.O0_O.0oOO0Oo0. = Setting.SortCol
			Me.oO_.ooo0o. = Setting.SortDesc
			Me.oO._o. = Setting.UseStyle
			Dim a_ As String = ""
			If Setting.AggregateCols IsNot Nothing AndAlso Setting.AggregateCols.Length > 0 Then
				a_ = String.Join(",", Setting.AggregateCols)
			End If
			If Operators.CompareString(Conversions.ToString(Setting.Separator2), "", True) > 0 Then
				Me.O_.o__ooo.(Setting.PathCol, Setting.TreeCol, Setting.Separator2, a_, Setting.ExpandTo)
				Return
			End If
			If Setting.Lengths2 IsNot Nothing AndAlso Setting.Lengths2.Length > 0 Then
				Me.OOo0_Oo._OOo.(Setting.PathCol, Setting.TreeCol, Setting.Lengths2, a_, Setting.ExpandTo)
			End If
		End Sub

		' Token: 0x06002A90 RID: 10896 RVA: 0x0012A5D4 File Offset: 0x001287D4
		<oO0oooo("3351")>
		Public Sub ShowGridTree(Setting As GroupTreeSetting, Optional ExpandTo As Integer = 0)
			Dim a_ As String = ""
			If Setting.AggregateCols IsNot Nothing AndAlso Setting.AggregateCols.Length > 0 Then
				a_ = String.Join(",", Setting.AggregateCols)
			End If
			Me.OOo0_Oo._OOo.(Setting.GroupCols2, a_, Setting.SortCol, Setting.SortDesc, ExpandTo)
		End Sub

		' Token: 0x06002A91 RID: 10897 RVA: 0x0012A625 File Offset: 0x00128825
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ShowGridTree(Groups As String(), Optional ExpandTo As Integer = 0)
			Me.OOo0_Oo._OOo.(Groups, "", ExpandTo)
		End Sub

		' Token: 0x06002A92 RID: 10898 RVA: 0x0012A634 File Offset: 0x00128834
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ShowGridTree(Groups As String(), valueCols As String(), Optional ExpandTo As Integer = 0)
			Me.OOo0_Oo._OOo.(Groups, String.Join(",", valueCols), ExpandTo)
		End Sub

		' Token: 0x06002A93 RID: 10899 RVA: 0x0012A64C File Offset: 0x0012884C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ShowGridTree() As Boolean
			Dim result As Boolean
			If Operators.CompareString(Me.oooo00O.o__0O., "", True) > 0 AndAlso Operators.CompareString(Me.O___o0.Oo., "", True) > 0 Then
				If Me.DataTable.BaseTable.Columns.Contains(Me.oooo00O.o__0O.) AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.O___o0.Oo.) AndAlso (Operators.CompareString(Me.O000__.o_ooo_O., "", True) = 0 OrElse Me.DataTable.BaseTable.Columns.Contains(Me.O000__.o_ooo_O.)) Then
					Me.OOo0_Oo._OOo.(Me.oooo00O.o__0O., Me.O___o0.Oo., Me.O000__.o_ooo_O., Me.oOoo____oo.O0., Me.o__.O0o.)
					Me.O_O0.0_o.(Me.o__.O0o.)
					result = True
				End If
			ElseIf Operators.CompareString(Me.O_.oOoOO0o., "", True) > 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(Me.O_.oOoOO0o.) Then
				If Operators.CompareString(Me.O000__.o_ooo_O., "", True) = 0 OrElse Me.DataTable.BaseTable.Columns.Contains(Me.O000__.o_ooo_O.) Then
					If Operators.CompareString(Me.oO0.00., "", True) > 0 Then
						Me.O_.o__ooo.(Me.O_.oOoOO0o., Me.O000__.o_ooo_O., Me.oO0.00.(0), Me.oOoo____oo.O0., Me.o__.O0o.)
						Me.O_O0.0_o.(Me.o__.O0o.)
						result = True
					Else
						If Operators.CompareString(Me.O_OO.oO0_., "", True) > 0 Then
							Dim array As String() = Me.O_OO.oO0_..Split(New Char() { ","c })
							Dim list As List(Of Integer) = New List(Of Integer)()
							For Each value As String In array
								list.Add(Conversions.ToInteger(value))
							Next
							If list.Count >= 1 Then
								Me.OOo0_Oo._OOo.(Me.O_.oOoOO0o., Me.O000__.o_ooo_O., list.ToArray(), Me.oOoo____oo.O0., Me.o__.O0o.)
								Me.O_O0.0_o.(Me.o__.O0o.)
								Return True
							End If
						End If
						result = True
					End If
				End If
			ElseIf Operators.CompareString(Me.o_oO__O.0_., "", True) > 0 Then
				Dim list2 As List(Of String) = New List(Of String)()
				list2.AddRange(Me.o_oO__O.0_..Split(New Char() { ","c }))
				Try
					For Each name As String In list2
						If Not Me.DataTable.BaseTable.Columns.Contains(name) Then
							Return False
						End If
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.OOo0_Oo._OOo.(list2.ToArray(), Me.oOoo____oo.O0., Me.O0_O.0oOO0Oo0., Me.oO_.ooo0o., Me.o__.O0o.)
				result = True
			ElseIf Operators.CompareString(Me.DataTable.OoOo_OoOO0.o., "", True) > 0 AndAlso Me.DataTable.oOOO.OOO_0ooO0. Then
				Me.OO0o_o0.0oOo0o. = Me.DataTable.OoOo_OoOO0.o.
				Me.HierarchyData = True
				Me.Cols(Me.OO0o_o0.0oOo0o.).TextAlign = 1
				Me.ExpandGridTree(0)
				result = True
			End If
			Return result
		End Function

		' Token: 0x17000A0C RID: 2572
		' (get) Token: 0x06002A94 RID: 10900 RVA: 0x0012A9A4 File Offset: 0x00128BA4
		<oO0oooo("3386")>
		Public ReadOnly Property GridTreeVisible As Boolean
			Get
				Return Me.HierarchyData
			End Get
		End Property

		' Token: 0x06002A95 RID: 10901 RVA: 0x0012A9AC File Offset: 0x00128BAC
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As String, A_2 As Object, A_3 As Object)
			If Me.GridTreeVisible AndAlso Me.o.0ooOO_0__..Contains(A_1) Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				If num >= 0 Then
					Dim dataRow As DataRow = Nothing
					Dim num2 As Double
					If A_2 IsNot DBNull.Value Then
						num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_2))
					End If
					Dim num3 As Double
					If A_3 IsNot DBNull.Value Then
						num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_3))
					End If
					Dim num4 As Double = num3 - num2
					Dim row As Row
					If Me.Rows(num).HasChild Then
						row = Me.Rows(num)
					Else
						row = Me.Rows(num).Parent
						If Me.Rows(num).DataRow IsNot Nothing Then
							dataRow = Me.Rows(num).DataRow.BaseRow
						End If
					End If
					If dataRow IsNot Nothing AndAlso Me.o.0ooOO_0__..ContainsKey(dataRow) Then
						Me.o.0ooOO_0__..Remove(dataRow)
					End If
					While row IsNot Nothing
						Dim baseRow As DataRow = row.DataRow.BaseRow
						Dim dictionary As Dictionary(Of String, Double)
						If Not Me.o.0ooOO_0__..ContainsKey(baseRow) Then
							dictionary = New Dictionary(Of String, Double)()
							If Not baseRow.IsNull(A_1) Then
								If baseRow Is A_0 Then
									dictionary(A_1) = num2
								Else
									dictionary(A_1) = Conversions.ToDouble(baseRow(A_1))
								End If
							End If
							Me.o.0ooOO_0__.(baseRow) = dictionary
						Else
							dictionary = Me.o.0ooOO_0__.(baseRow)
						End If
						If Not dictionary.ContainsKey(A_1) Then
							dictionary(A_1) = num4
						Else
							dictionary(A_1) += num4
						End If
						row = row.Parent
					End While
				End If
			End If
		End Sub

		' Token: 0x06002A96 RID: 10902 RVA: 0x0012AB4C File Offset: 0x00128D4C
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As String)
			If Me.GridTreeVisible AndAlso Me.o.0ooOO_0__..Contains(A_1) Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				If num >= 0 Then
					Dim row As Row
					If Me.Rows(num).HasChild Then
						row = Me.Rows(num)
					Else
						row = Me.Rows(num).Parent
					End If
					While row IsNot Nothing
						Dim children As List(Of Row) = row.GetChildren(False)
						Dim num2 As Double = 0.0
						Try
							For Each row2 As Row In children
								If row2.HasChild Then
									If Not Me.o.0ooOO_0__..ContainsKey(row2.DataRow.BaseRow) Then
										Me.o.0ooOO_0__.(row2.DataRow.BaseRow) = New Dictionary(Of String, Double)()
									End If
									Dim dictionary As Dictionary(Of String, Double) = Me.o.0ooOO_0__.(row2.DataRow.BaseRow)
									If Not dictionary.ContainsKey(A_1) Then
										dictionary(A_1) = 0.0
									End If
									num2 += dictionary(A_1)
								ElseIf row2(A_1) IsNot DBNull.Value Then
									num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(row2(A_1)))
								End If
							Next
						Finally
							Dim enumerator As List(Of Row).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						If Not Me.o.0ooOO_0__..ContainsKey(row.DataRow.BaseRow) Then
							Me.o.0ooOO_0__.(row.DataRow.BaseRow) = New Dictionary(Of String, Double)()
						End If
						If Not row.BaseDataRow.IsNull(A_1) Then
							num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(row(A_1)))
						End If
						Me.o.0ooOO_0__.(row.DataRow.BaseRow)(A_1) = num2
						row = row.Parent
					End While
				End If
			End If
		End Sub

		' Token: 0x06002A97 RID: 10903 RVA: 0x0012AD38 File Offset: 0x00128F38
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, Optional A_1 As Boolean = False)
			If Me.GridTreeVisible AndAlso Me.o.0ooOO_0__..Count > 0 Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
				If Me.o.0ooOO_0__..ContainsKey(A_0) Then
					dictionary = Me.o.0ooOO_0__.(A_0)
				End If
				If num >= 0 Then
					Dim parent As Row = Me.Rows(num).Parent
					While parent IsNot Nothing
						Dim baseRow As DataRow = parent.DataRow.BaseRow
						If Me.o.0ooOO_0__..ContainsKey(baseRow) Then
							Dim dictionary2 As Dictionary(Of String, Double) = Me.o.0ooOO_0__.(baseRow)
							Try
								For Each text As String In Me.o.0ooOO_0__.
									Dim num2 As Double = 0.0
									If dictionary.ContainsKey(text) AndAlso A_1 Then
										num2 = -dictionary(text)
									ElseIf Not A_0.IsNull(text) Then
										num2 = -Conversions.ToDouble(A_0(text))
									End If
									dictionary2(text) += num2
								Next
							Finally
								Dim enumerator As HashSet(Of String).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
						End If
						parent = parent.Parent
						If A_1 Then
							Exit While
						End If
					End While
				End If
			End If
		End Sub

		' Token: 0x06002A98 RID: 10904 RVA: 0x0012AE78 File Offset: 0x00129078
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			If Me.GridTreeVisible AndAlso Me.o.0ooOO_0__..Count > 0 Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()
				If Me.o.0ooOO_0__..ContainsKey(A_0) Then
					dictionary = Me.o.0ooOO_0__.(A_0)
				End If
				If num >= 0 Then
					Dim parent As Row = Me.Rows(num).Parent
					If parent IsNot Nothing Then
						Dim baseRow As DataRow = parent.DataRow.BaseRow
						Dim dictionary2 As Dictionary(Of String, Double)
						If Me.o.0ooOO_0__..ContainsKey(baseRow) Then
							dictionary2 = Me.o.0ooOO_0__.(baseRow)
						Else
							dictionary2 = New Dictionary(Of String, Double)()
							Try
								For Each text As String In Me.o.0ooOO_0__.
									If Not baseRow.IsNull(text) Then
										dictionary2(text) = Conversions.ToDouble(baseRow(text))
									End If
								Next
							Finally
								Dim enumerator As HashSet(Of String).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							Me.o.0ooOO_0__.(baseRow) = dictionary2
						End If
						Try
							For Each text2 As String In Me.o.0ooOO_0__.
								Dim num2 As Double = 0.0
								If dictionary.ContainsKey(text2) Then
									num2 = dictionary(text2)
								ElseIf Not A_0.IsNull(text2) Then
									num2 = Conversions.ToDouble(A_0(text2))
								End If
								If dictionary2.ContainsKey(text2) Then
									dictionary2(text2) += num2
								Else
									dictionary2(text2) = num2
								End If
							Next
						Finally
							Dim enumerator2 As HashSet(Of String).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x06002A99 RID: 10905 RVA: 0x0012B030 File Offset: 0x00129230
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As String, A_2 As Object, A_3 As Object)
			If Me.foxGrid.OO.o_o00o.() AndAlso Me.o.0ooOO_0__..Contains(A_1) Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				If num >= 0 Then
					Dim num2 As Double
					If A_2 IsNot DBNull.Value Then
						num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_2))
					End If
					Dim num3 As Double
					If A_3 IsNot DBNull.Value Then
						num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_3))
					End If
					Dim num4 As Double = num3 - num2
					Dim num5 As Integer = -1
					Dim num6 As Integer = num
					Dim num7 As Integer = Me.Grid.Rows.Count - 1
					For i As Integer = num6 To num7
						If Me.Grid.Rows(i).DataIndex = num Then
							num5 = i
							Exit For
						End If
					Next
					If num5 <> -1 Then
						Dim node As Node = Me.Grid.Rows(num5).Node
						While node IsNot Nothing
							Dim num8 As Double = 0.0
							If node.Row(A_1) IsNot DBNull.Value Then
								num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(node.Row(A_1)))
							End If
							node.Row(A_1) = num8 + num4
							node = node.Parent
						End While
					End If
				End If
			End If
		End Sub

		' Token: 0x06002A9A RID: 10906 RVA: 0x0012B160 File Offset: 0x00129360
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As String)
			If Me.foxGrid.OO.o_o00o.() AndAlso Me.o.0ooOO_0__..Contains(A_1) Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				If num >= 0 Then
					Dim num2 As Integer = -1
					Dim num3 As Integer = num
					Dim num4 As Integer = Me.Grid.Rows.Count - 1
					For i As Integer = num3 To num4
						If Me.Grid.Rows(i).DataIndex = num Then
							num2 = i
							Exit For
						End If
					Next
					If num2 <> -1 Then
						Dim node As Node = Me.Grid.Rows(num2).Node
						num2 = node.Row.Index
						While node IsNot Nothing
							Dim num5 As Double = 0.0
							If node.FirstChild Is Nothing Then
								Dim num6 As Integer = num2 + 1
								Dim num7 As Integer = Me.Grid.Rows.Count - 1
								Dim num8 As Integer = num6
								While num8 <= num7 AndAlso Me.Grid.Rows(num8).DataIndex >= 0
									If Me.Grid.Rows(num8)(A_1) IsNot DBNull.Value Then
										num5 = Conversions.ToDouble(Operators.AddObject(num5, Me.Grid.Rows(num8)(A_1)))
									End If
									num8 += 1
								End While
								node.Row(A_1) = num5
							Else
								Dim node2 As Node = node.FirstChild
								While node2 IsNot Nothing
									If node2.Row(A_1) IsNot DBNull.Value Then
										num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(node2.Row(A_1)))
									End If
									node2 = node2.NextNode
								End While
								node.Row(A_1) = num5
							End If
							node = node.Parent
						End While
					End If
				End If
			End If
		End Sub

		' Token: 0x06002A9B RID: 10907 RVA: 0x0012B330 File Offset: 0x00129530
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			If Me.foxGrid.OO.o_o00o.() AndAlso Me.o.0ooOO_0__..Count > 0 Then
				Dim num As Integer = Me.o.oO__OO_oo_0_.(A_0)
				If num >= 0 Then
					Dim num2 As Integer = -1
					Dim num3 As Integer = num
					Dim num4 As Integer = Me.Grid.Rows.Count - 1
					For i As Integer = num3 To num4
						If Me.Grid.Rows(i).DataIndex = num Then
							num2 = i
							Exit For
						End If
					Next
					If num2 <> -1 Then
						Dim node As Node = Me.Grid.Rows(num2).Node
						num2 = node.Row.Index
						While node IsNot Nothing
							Try
								For Each text As String In Me.o.0ooOO_0__.
									Dim num5 As Double = 0.0
									If node.Row(text) IsNot DBNull.Value Then
										num5 = Conversions.ToDouble(node.Row(text))
									End If
									If Not A_0.IsNull(text) Then
										num5 -= Conversion.Val(RuntimeHelpers.GetObjectValue(A_0(text)))
									End If
									node.Row(text) = num5
								Next
							Finally
								Dim enumerator As HashSet(Of String).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							node = node.Parent
						End While
					End If
				End If
			End If
		End Sub

		' Token: 0x06002A9C RID: 10908 RVA: 0x0012B498 File Offset: 0x00129698
		Private Function <<EMPTY_NAME>>(A_0 As DataRow) As Integer
			For i As Integer = Me.View.Position To 0 Step -1
				If Me.View.O0O_0_0__.0O.(i).Row Is A_0 Then
					Return i
				End If
			Next
			Dim num As Integer = Me.View.Position + 1
			Dim num2 As Integer = Me.View.Count - 1
			For j As Integer = num To num2
				If Me.View.O0O_0_0__.0O.(j).Row Is A_0 Then
					Return j
				End If
			Next
			Return -1
		End Function

		' Token: 0x06002A9D RID: 10909 RVA: 0x0012B514 File Offset: 0x00129714
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			If Me.o.0ooOO_0__. IsNot Nothing AndAlso Not Me.o.0ooOO_0__..Disposing AndAlso Not Me.o.0ooOO_0__..IsDisposed Then
				If TypeOf Me.o.0ooOO_0__. Is oO_oo0Oo Then
					CType(Me.o.0ooOO_0__., oO_oo0Oo).o0ooOo0.0o_Oo. = True
					CType(Me.o.0ooOO_0__., oO_oo0Oo).OOOOO0.0. = A_0
				End If
				If TypeOf Me.o.0ooOO_0__. Is oo__ Then
					CType(Me.o.0ooOO_0__., oo__).o__oO0.OOo_O. = True
					CType(Me.o.0ooOO_0__., oo__).o_.0Oo_oo0_. = A_0
				End If
			End If
		End Sub

		' Token: 0x06002A9E RID: 10910 RVA: 0x0012B5A1 File Offset: 0x001297A1
		Friend Sub <<EMPTY_NAME>>()
			If Me.foxGrid.Row >= Me.foxGrid.Rows.Fixed Then
				Me.o_o.O_.(Me.foxGrid.Row)
			End If
		End Sub

		' Token: 0x06002A9F RID: 10911 RVA: 0x0012B5D1 File Offset: 0x001297D1
		Friend Sub <<EMPTY_NAME>>()
			If Me.foxGrid.Row > Me.foxGrid.Rows.Fixed Then
				Me.o_o.O_.(Me.foxGrid.Row - 1)
			End If
		End Sub

		' Token: 0x06002AA0 RID: 10912 RVA: 0x0012B604 File Offset: 0x00129804
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim flag As Boolean
			If Me.foxGrid.Row <> A_0 Then
				flag = True
			End If
			If Me.foxGrid.OO.o_o00o.() AndAlso A_0 < Me.foxGrid.Rows.Count - 1 AndAlso Me.foxGrid.Rows(A_0).DataIndex <> -1 AndAlso Me.foxGrid.Rows(A_0 + 1).DataIndex <> -1 Then
				Me.StopRedraw()
				Dim row As Row = Me.Rows(Me.foxGrid.Rows(A_0).DataIndex)
				Dim row2 As Row = Me.Rows(Me.foxGrid.Rows(A_0 + 1).DataIndex)
				Dim num As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(row("System_Sort_Temporary")))
				row.BaseDataRow("System_Sort_Temporary") = RuntimeHelpers.GetObjectValue(row2("System_Sort_Temporary"))
				row2.BaseDataRow("System_Sort_Temporary") = num
				If flag Then
					Me.Position = Me.FindRow(row2.DataRow)
				Else
					Me.Position = Me.FindRow(row.DataRow)
				End If
				Dim flag2 As Boolean
				If Operators.CompareString(Me.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., True) = 0 AndAlso Me.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) AndAlso Me.DataTable.BaseTable.Columns(O_O0OO.ooO0oO0O.o_O_.).DataType Is GetType(Integer) Then
					If Not row.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) AndAlso Not row2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) Then
						Dim num2 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(row(O_O0OO.ooO0oO0O.o_O_.)))))
						row.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = RuntimeHelpers.GetObjectValue(row2(O_O0OO.ooO0oO0O.o_O_.))
						row2.BaseDataRow(O_O0OO.ooO0oO0O.o_O_.) = num2
						flag2 = True
					End If
				Else
					flag2 = True
				End If
				If Not flag2 Then
					Me.OO.0OO000_0__.(Me.Grid.Row)
				End If
				Me.ResumeRedraw()
			End If
		End Sub

		' Token: 0x06002AA1 RID: 10913 RVA: 0x0012B838 File Offset: 0x00129A38
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim node As Node = Me.foxGrid.Rows(A_0).Node
			Dim a_ As Row = Me.Rows(Me.foxGrid.Rows(A_0).DataIndex)
			Dim list As List(Of Row) = New List(Of Row)()
			If node IsNot Nothing Then
				Dim num As Integer = node.Row.Index + 1
				Dim num2 As Integer = Me.foxGrid.Rows.Count - 1
				For i As Integer = num To num2
					If Me.foxGrid.Rows(i).DataIndex = -1 Then
						Dim flag As Boolean
						If flag Then
							Exit For
						End If
					Else
						Dim flag As Boolean
						If Not flag Then
							flag = True
						End If
						list.Add(Me.Rows(Me.foxGrid.Rows(i).DataIndex))
					End If
				Next
			End If
			Me.OO.0OO000_0__.(list, a_)
		End Sub

		' Token: 0x17000A0D RID: 2573
		' (get) Token: 0x06002AA2 RID: 10914 RVA: 0x0012B90C File Offset: 0x00129B0C
		<oO0oooo("3751")>
		Public ReadOnly Property MouseChartIndex As Integer
			Get
				Dim num As Integer
				Dim result As Integer
				Dim num9 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Dim point As Point = Me.Grid.PointToClient(System.Windows.Forms.Control.MousePosition)
					IL_1B:
					num2 = 3
					Dim mouseRow As Integer = Me.Grid.MouseRow
					IL_2A:
					num2 = 4
					Dim mouseCol As Integer = Me.Grid.MouseCol
					IL_39:
					num2 = 5
					If mouseRow >= Me.Grid.Rows.Fixed AndAlso mouseCol >= Me.Grid.Cols.Fixed Then
						GoTo IL_6C
					End If
					IL_63:
					num2 = 6
					result = -1
					GoTo IL_1C7
					IL_6C:
					num2 = 7
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Grid.GetUserData(mouseRow, mouseCol))
					IL_84:
					num2 = 8
					If objectValue IsNot Nothing Then
						GoTo IL_94
					End If
					IL_8A:
					num2 = 9
					result = -1
					GoTo IL_1C7
					IL_94:
					num2 = 10
					Dim list As List(Of Integer) = New List(Of Integer)()
					IL_9E:
					num2 = 11
					For Each s As String In objectValue.ToString().Trim(New Char() { "@"c, "{"c, "}"c }).Split(New Char() { ","c })
						IL_DC:
						num2 = 12
						Dim item As Integer
						If Integer.TryParse(s, item) Then
							IL_EA:
							num2 = 13
							list.Add(item)
						End If
						IL_F6:
						num2 = 14
					Next
					IL_107:
					num2 = 15
					If list.Count = 2 Then
						GoTo IL_11E
					End If
					IL_114:
					num2 = 16
					result = -1
					GoTo IL_1C7
					IL_11E:
					num2 = 17
					Dim num3 As Integer = list(0)
					IL_12A:
					num2 = 18
					Dim num4 As Integer = list(1)
					IL_137:
					num2 = 19
					Dim cellRect As Rectangle = Me.Grid.GetCellRect(mouseRow, mouseCol)
					IL_14B:
					num2 = 20
					Dim num5 As Integer = cellRect.X + 5 + num4
					IL_15C:
					num2 = 21
					Dim num6 As Integer = cellRect.Width - (5 + num4) * 2
					IL_16F:
					num2 = 22
					Dim num7 As Integer = CInt(Math.Floor(CDbl((point.X - num5)) / CDbl(num6) * CDbl(list(0))))
					IL_193:
					num2 = 23
					If num7 >= 0 Then
						GoTo IL_1A1
					End If
					IL_19B:
					num2 = 24
					num7 = 0
					IL_1A1:
					num2 = 25
					If num7 <= list(0) - 1 Then
						GoTo IL_1C1
					End If
					IL_1B2:
					num2 = 26
					num7 = list(0) - 1
					IL_1C1:
					num2 = 27
					result = num7
					IL_1C7:
					GoTo IL_289
					IL_1CC:
					Dim num8 As Integer = num9 + 1
					num9 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
					IL_24A:
					GoTo IL_27E
					IL_24C:
					num9 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_25C:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_24C
				End Try
				IL_27E:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_289:
				If num9 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002AA3 RID: 10915 RVA: 0x0012BBC8 File Offset: 0x00129DC8
		Friend Function <<EMPTY_NAME>>(A_0 As Rectangle, A_1 As Integer, A_2 As Integer) As Rectangle
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Grid.GetUserData(A_1, A_2))
			Dim result As Rectangle
			If objectValue Is Nothing Then
				result = A_0
			Else
				Dim list As List(Of Integer) = New List(Of Integer)()
				Dim array As String() = objectValue.ToString().Trim(New Char() { "@"c, "{"c, "}"c }).Split(New Char() { ","c })
				Dim num As Integer
				Dim num2 As Integer
				For i As Integer = 0 To array.Length - 1
					Dim item As Integer
					If Integer.TryParse(array(i), item) Then
						list.Add(item)
					End If
				Next
				num = list(0)
				num2 = list(1)
				Dim num3 As Integer = CInt(Math.Floor(CDbl((A_0.Width - (5 + num2) * 2)) / CDbl(num)))
				A_0.Width += num3
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06002AA4 RID: 10916 RVA: 0x0012BC90 File Offset: 0x00129E90
		Private Sub <<EMPTY_NAME>>()
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.DataTable.BaseTable Is Me.DataTable.BaseTable OrElse table.Name.IndexOf(Me.DataTable.Name) >= 0 Then
						table._frdTableLayout.OOooOOo_.0_0_o.()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.DataTable.BaseTable.Columns.Add("sys_Hierarchy_Level", GetType(Integer))
			Try
				For Each table2 As Table In OO_00oOO.Tables
					If table2.DataTable.BaseTable Is Me.DataTable.BaseTable OrElse table2.Name.IndexOf(Me.DataTable.Name) >= 0 Then
						table2.oO_o_0o._0oooo.(True)
						table2._frdTableLayout.Oo_.oo_oOo_oO.()
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of Table)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x040010D2 RID: 4306
		Friend <<EMPTY_NAME>> As O_0

		' Token: 0x040010D3 RID: 4307
		Private <<EMPTY_NAME>> As O_oOooO_O

		' Token: 0x040010D4 RID: 4308
		Private <<EMPTY_NAME>> As RowCollection

		' Token: 0x040010D5 RID: 4309
		Private <<EMPTY_NAME>> As ColCollection

		' Token: 0x040010D6 RID: 4310
		Private <<EMPTY_NAME>> As StateFilterEnum

		' Token: 0x040010D7 RID: 4311
		Private <<EMPTY_NAME>> As TableTypeEnum

		' Token: 0x040010D8 RID: 4312
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010D9 RID: 4313
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010DA RID: 4314
		Private <<EMPTY_NAME>> As OOO0o

		' Token: 0x040010DB RID: 4315
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010DC RID: 4316
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010DD RID: 4317
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010DE RID: 4318
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010DF RID: 4319
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E0 RID: 4320
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E1 RID: 4321
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E2 RID: 4322
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E3 RID: 4323
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E4 RID: 4324
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E5 RID: 4325
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E6 RID: 4326
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E7 RID: 4327
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E8 RID: 4328
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010E9 RID: 4329
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010EA RID: 4330
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010EB RID: 4331
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040010EC RID: 4332
		Private <<EMPTY_NAME>> As MergeModeEnum

		' Token: 0x040010ED RID: 4333
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x040010EE RID: 4334
		Private <<EMPTY_NAME>> As String

		' Token: 0x040010EF RID: 4335
		Private <<EMPTY_NAME>> As DockAreaEnum

		' Token: 0x040010F0 RID: 4336
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F1 RID: 4337
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F2 RID: 4338
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F3 RID: 4339
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F4 RID: 4340
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F5 RID: 4341
		Private <<EMPTY_NAME>> As SubtotalGroupCollection

		' Token: 0x040010F6 RID: 4342
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F7 RID: 4343
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F8 RID: 4344
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040010F9 RID: 4345
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040010FA RID: 4346
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040010FB RID: 4347
		Private <<EMPTY_NAME>> As PrintInfo

		' Token: 0x040010FC RID: 4348
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040010FD RID: 4349
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Table.oO00_O_O

		' Token: 0x040010FE RID: 4350
		Friend <<EMPTY_NAME>> As GroupTableBuilder

		' Token: 0x040010FF RID: 4351
		Friend <<EMPTY_NAME>> As CrossTableBuilder

		' Token: 0x04001100 RID: 4352
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001101 RID: 4353
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001102 RID: 4354
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001103 RID: 4355
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001104 RID: 4356
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ListSortDirection)

		' Token: 0x04001105 RID: 4357
		Friend <<EMPTY_NAME>> As o_0oo_OOO_0o_

		' Token: 0x04001106 RID: 4358
		Friend <<EMPTY_NAME>> As List(Of Oo0__O__O_0__)

		' Token: 0x04001107 RID: 4359
		Friend <<EMPTY_NAME>> As Assembly

		' Token: 0x04001108 RID: 4360
		Private <<EMPTY_NAME>> As o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000

		' Token: 0x04001109 RID: 4361
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400110A RID: 4362
		Private <<EMPTY_NAME>> As System.Windows.Forms.TreeView

		' Token: 0x0400110B RID: 4363
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400110C RID: 4364
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400110D RID: 4365
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400110E RID: 4366
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400110F RID: 4367
		Friend <<EMPTY_NAME>> As Char

		' Token: 0x04001110 RID: 4368
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001111 RID: 4369
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001112 RID: 4370
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001113 RID: 4371
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001114 RID: 4372
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001115 RID: 4373
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001116 RID: 4374
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001117 RID: 4375
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001118 RID: 4376
		Friend <<EMPTY_NAME>> As O0_0_0O0___O

		' Token: 0x04001119 RID: 4377
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400111A RID: 4378
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400111B RID: 4379
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400111C RID: 4380
		Friend <<EMPTY_NAME>> As o_0

		' Token: 0x0400111D RID: 4381
		Friend <<EMPTY_NAME>> As OooOo0___oO

		' Token: 0x0400111E RID: 4382
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400111F RID: 4383
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001120 RID: 4384
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001121 RID: 4385
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001122 RID: 4386
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001123 RID: 4387
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001124 RID: 4388
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001125 RID: 4389
		Friend <<EMPTY_NAME>> As InlineGroupTableBuilder

		' Token: 0x04001126 RID: 4390
		Friend <<EMPTY_NAME>> As LayersGroupTableBuilder

		' Token: 0x04001127 RID: 4391
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001128 RID: 4392
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001129 RID: 4393
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400112A RID: 4394
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400112B RID: 4395
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400112C RID: 4396
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400112D RID: 4397
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400112E RID: 4398
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400112F RID: 4399
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001130 RID: 4400
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001131 RID: 4401
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001132 RID: 4402
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001133 RID: 4403
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001134 RID: 4404
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001135 RID: 4405
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001136 RID: 4406
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001137 RID: 4407
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001138 RID: 4408
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001139 RID: 4409
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x0400113A RID: 4410
		Friend <<EMPTY_NAME>> As Dictionary(Of DataRow, Dictionary(Of String, Double))

		' Token: 0x0400113B RID: 4411
		Friend <<EMPTY_NAME>> As HashSet(Of String)

		' Token: 0x0400113C RID: 4412
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400113D RID: 4413
		Friend <<EMPTY_NAME>> As Oo0

		' Token: 0x0400113E RID: 4414
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400113F RID: 4415
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001140 RID: 4416
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001141 RID: 4417
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0200030B RID: 779
		' (Invoke) Token: 0x06002AA8 RID: 10920
		Public Delegate Sub oO00_O_O()

		' Token: 0x0200030C RID: 780
		' (Invoke) Token: 0x06002AAC RID: 10924
		Private Delegate Function o0Oo_(A_0 As String, A_1 As StringBuilder) As Integer

		' Token: 0x0200030D RID: 781
		Friend Class Oo_0O0o_
			' Token: 0x06002AAD RID: 10925 RVA: 0x0012BDB0 File Offset: 0x00129FB0
			Public Sub New()
				Dim a_ As Integer = 5
				MyBase..ctor()
				Me.OO._O_o__. = O00OOOo_O0_O.b("ꊒꖔꖖ궘", a_)
				Me.Ooo.0OOoO_0. = O00OOOo_O0_O.b("ﮒ", a_)
				Me.o0.O_0OO0_00_. = ooO0__OO.O00.O__o.()
				Me.o0.O0o_00. = ooO0__OO.O0_.OOo0OO.()
				Me.O0_O_o0O00_O.o. = ooO0__OO.o0O._ooo_O_.()
				Me.o0o_0.0_O_Oo0o. = O_O0OO.o_Oo0_oOo.0.
				Me.oooooo._000_. = ooO0__OO.oo._o.()
				Me.oooO_O0.0. = ooO0__OO.o_0_000._O.()
				Me.oo0ooO0_O0.o0. = O00OOOo_O0_O.b("ﮒ殺", a_)
				Me.O0.o_0Oo0__O. = O00OOOo_O0_O.b("첞誠貢춤힦첨사覰�麴肶", a_)
				Me.O0O0_o.Oo0_O. = O00OOOo_O0_O.b("ﾔ튖�첚ﮜ춞ﮠ�쪤킨욪��ﶲ颶邺芾", a_)
				Me.O___OOo_O.O0. = O00OOOo_O0_O.b("�쪘漢ﾜ�잠햦톪캬鮮우󼢴�覺좾꧀菆", a_)
				Me.oOOoOO0_.O_o0. = O00OOOo_O0_O.b("벒�ﺖ連쾜킦ﺨﺮ�躲", a_)
			End Sub

			' Token: 0x06002AAE RID: 10926
			Private Declare Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "LoadLibrary" (A_0 As String) As IntPtr

			' Token: 0x06002AAF RID: 10927
			Private Declare Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "GetProcAddress" (A_0 As IntPtr, A_1 As String) As IntPtr

			' Token: 0x06002AB0 RID: 10928
			Private Declare Function <<EMPTY_NAME>> Lib "kernel32.dll" Alias "FreeLibrary" (A_0 As IntPtr) As Boolean

			' Token: 0x06002AB1 RID: 10929 RVA: 0x0012BE9C File Offset: 0x0012A09C
			Friend Function <<EMPTY_NAME>>(A_0 As String) As String
				Dim a_ As Integer = 16
				Dim stringBuilder As StringBuilder = New StringBuilder(32)
				Dim intPtr As IntPtr = Table.Oo_0O0o_.o_Oo.0o0oo__o.(O00.DecryptText(Me.O0.o_0Oo0__O. + Me.O0O0_o.Oo0_O., O00OOOo_O0_O.b("튟춡캣쎥쮧�", a_), O00OOOo_O0_O.b("ﶝ쾟첡슣쾥쾧", a_)))
				Dim result As String
				If intPtr = IntPtr.Zero Then
					result = Nothing
				Else
					Try
						Dim intPtr2 As IntPtr = Table.Oo_0O0o_.O.OoOo_.(intPtr, O00.DecryptText(Me.O___OOo_O.O0. + Me.oOOoOO0_.O_o0., O00OOOo_O0_O.b("튟춡캣쎥쮧�", a_), O00OOOo_O0_O.b("ﶝ쾟첡슣쾥쾧", a_)))
						If intPtr2 = IntPtr.Zero Then
							result = Nothing
						ElseIf CType(Marshal.GetDelegateForFunctionPointer(intPtr2, GetType(Table.o0Oo_)), Table.o0Oo_)(A_0, stringBuilder) = 1 Then
							result = stringBuilder.ToString()
						Else
							result = Nothing
						End If
					Finally
						Table.Oo_0O0o_.O.OoOo_.(intPtr)
					End Try
				End If
				Return result
			End Function

			' Token: 0x06002AB2 RID: 10930 RVA: 0x0012BF98 File Offset: 0x0012A198
			Private Function <<EMPTY_NAME>>(A_0 As Byte(), A_1 As Integer, A_2 As Byte(), A_3 As Integer, A_4 As Integer) As Boolean
				Dim num As Integer = A_4 - 1
				For i As Integer = 0 To num
					A_2(A_3 + i) = A_0(A_1 + i)
				Next
				Return True
			End Function

			' Token: 0x06002AB3 RID: 10931 RVA: 0x0012BFC4 File Offset: 0x0012A1C4
			Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
				Dim result As Boolean
				If OoO0o.WaitNamedPipe(A_0, 4000) = 0 Then
					result = False
				Else
					Me.Oo.00OoO000. = OoO0o.CreateFile(A_0, 3221225472UI, 0, 0, 3, 0, 0)
					result = (Me.Oo.00OoO000. <> -1)
				End If
				Return result
			End Function

			' Token: 0x06002AB4 RID: 10932 RVA: 0x0012C008 File Offset: 0x0012A208
			Private Function <<EMPTY_NAME>>(A_0 As Integer, ByRef A_1 As Byte()) As Boolean
				Dim num As Integer = 1
				Dim array As Byte() = New Byte(0) {}
				Dim num2 As Integer
				Do
					num2 = 0
					Dim array2 As Byte() = New Byte(999) {}
					If Not OoO0o.ReadFile(A_0, array2, 1000UI, num2, 0UI) Then
						Exit Do
					End If
					Dim array3 As Byte() = New Byte(num - 1 + 1 - 1) {}
					Me.o_Oo.0o0oo__o.(array, 0, array3, 0, num)
					num += num2
					array = New Byte(num - 1 + 1 - 1) {}
					Me.o_Oo.0o0oo__o.(array3, 0, array, 0, array3.GetLength(0))
					Me.o_Oo.0o0oo__o.(array2, 0, array, num - num2, num2)
				Loop While num2 >= 1000
				A_1 = New Byte(num - 2 + 1 - 1) {}
				Me.o_Oo.0o0oo__o.(array, 1, A_1, 0, num - 1)
				Return True
			End Function

			' Token: 0x06002AB5 RID: 10933 RVA: 0x0012C0AC File Offset: 0x0012A2AC
			Friend Function <<EMPTY_NAME>>() As Boolean
				Me.O.OoOo_.(Me.o_Oo.0o0oo__o.())
				Dim result As Boolean
				Return result
			End Function

			' Token: 0x06002AB6 RID: 10934 RVA: 0x0012C0C8 File Offset: 0x0012A2C8
			Private Function <<EMPTY_NAME>>() As String
				Dim a_ As Integer = 14
				Dim num As Integer
				Dim result As String
				Dim num7 As Integer
				Dim obj As Object
				Try
					IL_09:
					ProjectData.ClearProjectError()
					num = 1
					IL_10:
					Dim num2 As Integer = 2
					If Operators.CompareString(Me.o0oO0_o._ooo0., "", True) <= 0 Then
						GoTo IL_34
					End If
					IL_26:
					num2 = 3
					result = Me.o0oO0_o._ooo0.
					GoTo IL_702
					IL_34:
					num2 = 4
					If String.IsNullOrEmpty(Me.o0oO0_o._ooo0.) Then
						GoTo IL_1FB
					End If
					IL_46:
					num2 = 6
					Dim text As String = Application.ProductVersion.Replace(O00OOOo_O0_O.b("늛", a_), "")
					IL_67:
					num2 = 7
					Dim value As Char = "0"c
					IL_6D:
					num2 = 8
					Dim array As Char() = New Char(0) {}
					IL_77:
					num2 = 9
					Dim text2 As String = ""
					IL_81:
					num2 = 10
					array(0) = "."c
					IL_8A:
					num2 = 11
					Dim array2 As String() = Nothing
					IL_90:
					num2 = 12
					array2 = text.Split(New Char() { array(0) })
					IL_A9:
					num2 = 13
					Dim num3 As Integer
					If Not(array2(0).Length > 0 And num3 >= 0) Then
						GoTo IL_126
					End If
					IL_C3:
					num2 = 14
					array2(0) = o_O_o_oOoo__.OOOO_OO._oo.(array2(0))
					IL_D3:
					num2 = 15
					If array2(0).Length <= num3 Then
						GoTo IL_FD
					End If
					IL_E3:
					num2 = 16
					text2 = Conversions.ToString(array2(0)(num3))
					GoTo IL_1A3
					IL_FD:
					num2 = 18
					If array2(0).Length <> num3 Then
						GoTo IL_11E
					End If
					IL_10D:
					num2 = 19
					text2 = Conversions.ToString(value)
					GoTo IL_1A3
					IL_11E:
					num2 = 21
					text2 = Nothing
					GoTo IL_1A3
					IL_126:
					num2 = 23
					If Not(array2.Length > 1 And num3 < 0) Then
						GoTo IL_180
					End If
					IL_138:
					num2 = 24
					If array2(1).Length < Math.Abs(num3) Then
						GoTo IL_16B
					End If
					IL_14D:
					num2 = 25
					text2 = Conversions.ToString(array2(1)(Math.Abs(num3) - 1))
					GoTo IL_1A3
					IL_16B:
					num2 = 27
					text2 = O00OOOo_O0_O.b("겛", a_)
					GoTo IL_1A3
					IL_180:
					num2 = 29
					If num3 >= 0 Then
						GoTo IL_19D
					End If
					IL_188:
					num2 = 30
					text2 = O00OOOo_O0_O.b("겛", a_)
					GoTo IL_1A3
					IL_19D:
					num2 = 32
					text2 = Nothing
					IL_1A3:
					num2 = 33
					num3 = 0
					IL_1A9:
					num2 = 34
					If Operators.CompareString(text2, "", True) <= 0 Then
						GoTo IL_1FB
					End If
					IL_1BC:
					num2 = 35
					Dim text3 As String = text2
					For i As Integer = 0 To text3.Length - 1
						Dim [string] As String = Conversions.ToString(text3(i))
						IL_1D8:
						num2 = 36
						num3 += Strings.Asc([string])
						IL_1E7:
						num2 = 37
					Next
					IL_1FB:
					num2 = 38
					Dim text4 As String = Me.O.OoOo_.(O_O0OO.o.00O_O.() + O_O0OO.O0_00o.o0__o..o0__oo0.00Oo.()) + Me.O.OoOo_.(O_O0OO.o.00O_O.() + O_O0OO.O0_00o.o0__o..o0__oo0.00Oo.() + O_O0OO.O0_00o.o0__o..Ooo_.o0_.())
					IL_243:
					num2 = 39
					Dim dataRow As DataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("�ﾝ풟쎡쾥쒧쾩��횱", a_))
					IL_265:
					num2 = 40
					If dataRow IsNot Nothing AndAlso Not dataRow.IsNull(O00OOOo_O0_O.b("�캟쒡춣솥", a_)) Then
						GoTo IL_295
					End If
					IL_283:
					num2 = 41
					Me.o0oO0_o._ooo0. = OoOo0O.OO_o.0o_O.(22)
					GoTo IL_2D5
					IL_295:
					num2 = 43
					Me.o0oO0_o._ooo0. = dataRow(O00OOOo_O0_O.b("�캟쒡춣솥", a_)).ToString()
					IL_2B8:
					num2 = 44
					Me.o0oO0_o._ooo0. = O00.oO_.0o_oo_0O_.(Me.o0oO0_o._ooo0., text4, o_O_o_oOoo__.OOOO_OO._oo.(text4))
					IL_2D5:
					num2 = 45
					Me.OO._O_o__. = Me.OO._O_o__..TrimEnd(New Char() { "."c })
					IL_2F4:
					num2 = 46
					If Versioned.IsNumeric(Me.OO._O_o__.) Then
						GoTo IL_31B
					End If
					IL_304:
					num2 = 47
					Me.oooO_O0.0. = O00OOOo_O0_O.b("ﮝ슟", a_)
					IL_31B:
					num2 = 48
					If Conversion.Val(Me.OO._O_o__.) <> 0.0 Then
						GoTo IL_34B
					End If
					IL_334:
					num2 = 49
					Me.oooO_O0.0. = O00OOOo_O0_O.b("풟튡", a_)
					IL_34B:
					num2 = 50
					If Operators.CompareString(Me.oooO_O0.0., "", True) <> 0 Then
						GoTo IL_6E9
					End If
					IL_364:
					num2 = 51
					Me.Oo.00OoO000. = CLng(CInt(Math.Floor(Conversion.Val(Me.OO._O_o__.))))
					IL_37F:
					num2 = 52
					If Me.OO._O_o__..IndexOf(O00OOOo_O0_O.b("늛", a_)) < 0 Then
						GoTo IL_3C1
					End If
					IL_39E:
					num2 = 53
					Me.o0.O_0OO0_00_. = Me.OO._O_o__..Substring(Me.OO._O_o__..IndexOf("."c) + 1)
					IL_3C1:
					num2 = 54
					If Me.Oo.00OoO000. <= 0L Then
						GoTo IL_5EA
					End If
					IL_3D1:
					num2 = 55
					If Me.Oo.00OoO000. <> 0L Then
						GoTo IL_3F8
					End If
					IL_3DC:
					num2 = 56
					Me.oooO_O0.0. = O00OOOo_O0_O.b("첟", a_)
					GoTo IL_5EA
					IL_3F8:
					num2 = 58
					Me.OO._O_o__. = Me.Oo.00OoO000..ToString()
					IL_40C:
					num2 = 59
					Dim num4 As Integer = 1
					Do
						IL_412:
						num2 = 60
						Me.o0.O0o_00. = Strings.Right(Me.OO._O_o__., 4)
						IL_427:
						num2 = 61
						Me.Oo.00OoO000. = Long.Parse(Me.o0.O0o_00.)
						IL_43B:
						num2 = 62
						Me.o0.O0o_00. = Me.Oo.00OoO000..ToString()
						IL_44F:
						num2 = 63
						If num4 = 1 Then
							IL_457:
							num2 = 64
							Me.oooooo._000_. = Me.o0.O0o_00.
						Else
							IL_46B:
							num2 = 66
							If Me.Oo.00OoO000. > 0L Then
								IL_478:
								num2 = 67
								Me.o0o_0.0_O_Oo0o. = Me.o0.O0o_00. + Conversions.ToString(Me.oo0ooO0_O0.o0.(num4 - 2))
							End If
							IL_4A0:
							num2 = 68
							If Operators.CompareString(Me.oooooo._000_., "", True) > 0 Then
								IL_4B7:
								num2 = 69
								If Me.Oo.00OoO000. = 0L OrElse Me.O0_O_o0O00_O.o..Length < 4 OrElse Me.o0.O0o_00..EndsWith(O00OOOo_O0_O.b("겛", a_)) Then
									IL_4EB:
									num2 = 70
									Me.oooooo._000_. = Me.o0o_0.0_O_Oo0o. + O00OOOo_O0_O.b("", a_) + Me.oooooo._000_.
								Else
									IL_515:
									num2 = 72
									Me.oooooo._000_. = Me.o0o_0.0_O_Oo0o. + Me.oooooo._000_.
								End If
							Else
								IL_531:
								num2 = 74
								Me.oooooo._000_. = Me.o0o_0.0_O_Oo0o.
							End If
						End If
						IL_540:
						num2 = 75
						Me.O0_O_o0O00_O.o. = Me.o0.O0o_00.
						IL_54F:
						num2 = 76
						If Me.OO._O_o__..Length <= 4 Then
							Exit Do
						End If
						IL_560:
						num2 = 79
						Me.OO._O_o__. = Me.OO._O_o__..Substring(0, Me.OO._O_o__..Length - 4)
						IL_582:
						num2 = 80
						num4 += 1
					Loop While num4 <= 4
					IL_593:
					num2 = 81
					Me.oooooo._000_. = Me.oooooo._000_..Replace(O00OOOo_O0_O.b("瀞킟", a_), "")
					IL_5BA:
					num2 = 82
					Me.oooooo._000_. = Me.oooooo._000_..Replace(O00OOOo_O0_O.b("풟튡", a_), O00OOOo_O0_O.b("", a_))
					IL_5EA:
					num2 = 83
					If Operators.CompareString(Me.o0.O_0OO0_00_., "", True) <= 0 Then
						GoTo IL_6D8
					End If
					IL_604:
					num2 = 84
					If Operators.CompareString(Me.oooooo._000_., "", True) <> 0 Then
						GoTo IL_633
					End If
					IL_61A:
					num2 = 85
					Me.oooooo._000_. = O00OOOo_O0_O.b("풟튡힣", a_)
					GoTo IL_655
					IL_633:
					num2 = 87
					Me.oooooo._000_. += O00OOOo_O0_O.b("첟", a_)
					IL_655:
					num2 = 88
					Dim num5 As Integer = Me.o0.O_0OO0_00_..Length - Me.o0.O_0OO0_00_..TrimStart(New Char() { "0"c }).Length
					IL_681:
					num2 = 89
					If num5 <= 0 Then
						GoTo IL_6B4
					End If
					IL_689:
					num2 = 90
					Me.oooooo._000_. += O00OOOo_O0_O.b("", a_).PadLeft(num5, "w"c)
					IL_6B4:
					num2 = 91
					Me.oooooo._000_. += Conversions.ToString(Conversions.ToInteger(Me.o0.O_0OO0_00_.))
					IL_6D8:
					num2 = 92
					Me.oooO_O0.0. = Me.oooooo._000_.
					GoTo IL_6F8
					IL_6E9:
					num2 = 94
					Me.oooO_O0.0. = Me.oooooo._000_.
					IL_6F8:
					num2 = 95
					result = Me.o0oO0_o._ooo0.
					IL_702:
					GoTo IL_8D4
					IL_707:
					Dim num6 As Integer = num7 + 1
					num7 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
					IL_895:
					GoTo IL_8C9
					IL_897:
					num7 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_8A7:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_897
				End Try
				IL_8C9:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_8D4:
				If num7 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x06002AB7 RID: 10935 RVA: 0x0012C9D0 File Offset: 0x0012ABD0
			Friend Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As Byte()) As Boolean
				Dim bytes As Byte() = Encoding.ASCII.GetBytes(A_0)
				Dim num As Integer = 0
				OoO0o.WriteFile(Me.Oo.00OoO000., bytes, CUInt((CULng(bytes.GetLength(0)) + 1UL)), num, 0UI)
				Me.o_Oo.0o0oo__o.(Me.Oo.00OoO000., A_1)
				Return True
			End Function

			' Token: 0x06002AB8 RID: 10936 RVA: 0x0012CA18 File Offset: 0x0012AC18
			Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
				Dim a_ As Integer = 17
				If Table.Oo_0O0o_.Oo.00OoO000. Is Nothing Then
					Table.Oo_0O0o_.Oo.00OoO000. = New Stopwatch()
					Table.Oo_0O0o_.Oo.00OoO000..Start()
				End If
				Dim a_2 As String = A_0 + O00OOOo_O0_O.b("뎞", a_) + A_1
				Dim bytes As Byte() = New Byte(0) {}
				Me.O.OoOo_.(a_2, bytes)
				If Table.Oo_0O0o_.Oo.00OoO000..Elapsed.TotalMinutes >= CDbl(Strings.Len(Main.OO_O.o..Name)) Then
					Table.Oo_0O0o_.Oo.00OoO000..Reset()
					O_O0OO.O0_00o.o0__o..O__O0OO_0._O.()
				End If
				Return Encoding.ASCII.GetString(bytes)
			End Function

			' Token: 0x04001142 RID: 4418
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001143 RID: 4419
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001144 RID: 4420
			Friend <<EMPTY_NAME>> As Long

			' Token: 0x04001145 RID: 4421
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001146 RID: 4422
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001147 RID: 4423
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001148 RID: 4424
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001149 RID: 4425
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400114A RID: 4426
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400114B RID: 4427
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400114C RID: 4428
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400114D RID: 4429
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400114E RID: 4430
			Friend <<EMPTY_NAME>> As String

			' Token: 0x0400114F RID: 4431
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001150 RID: 4432
			Public <<EMPTY_NAME>> As Integer

			' Token: 0x04001151 RID: 4433
			Private Shared <<EMPTY_NAME>> As Stopwatch

			' Token: 0x04001152 RID: 4434
			Private <<EMPTY_NAME>> As String
		End Class
	End Class
End Namespace
