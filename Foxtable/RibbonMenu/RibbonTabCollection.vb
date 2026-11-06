Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000033 RID: 51
	<oO0oooo("2483")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class RibbonTabCollection
		Implements IEnumerable

		' Token: 0x06000195 RID: 405 RVA: 0x00004912 File Offset: 0x00002B12
		Public Sub New(A_0 As RibbonTabCollection)
			Me.O_00Oo_.0. = A_0
		End Sub

		' Token: 0x06000196 RID: 406 RVA: 0x00004921 File Offset: 0x00002B21
		Public Sub Add(Tab As Tab)
			Me.O_00Oo_.0..Add(Tab.OO0.0OOo__.)
		End Sub

		' Token: 0x06000197 RID: 407 RVA: 0x00004935 File Offset: 0x00002B35
		Public Sub Insert(Index As Integer, Tab As Tab)
			Me.O_00Oo_.0..Insert(Index, Tab.OO0.0OOo__.)
		End Sub

		' Token: 0x06000198 RID: 408 RVA: 0x00004949 File Offset: 0x00002B49
		Public Sub Remove(Tab As Tab)
			If Tab.OO0.0OOo__..OwnerCollection = Me.O_00Oo_.0. Then
				Me.O_00Oo_.0..Remove(Tab.OO0.0OOo__.)
			End If
		End Sub

		' Token: 0x06000199 RID: 409 RVA: 0x0000496F File Offset: 0x00002B6F
		Public Sub Remove(TabName As String)
			If Me.O_00Oo_.0..Contains(TabName) Then
				Me.O_00Oo_.0..Remove(Me.O_00Oo_.0.(TabName))
			End If
		End Sub

		' Token: 0x0600019A RID: 410 RVA: 0x00004996 File Offset: 0x00002B96
		Public Sub RemoveAt(Index As Integer)
			Me.O_00Oo_.0..RemoveAt(Index)
		End Sub

		' Token: 0x170000B3 RID: 179
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Tab
			Get
				Dim result As Tab
				If TypeOf A_0 Is String Then
					result = Me(Conversions.ToString(A_0))
				Else
					result = Me(Conversions.ToInteger(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000B4 RID: 180
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer) As Tab
			Get
				Dim result As Tab
				If A_0 < 0 Or A_0 > Me.O_00Oo_.0..Count - 1 Then
					result = Nothing
				Else
					result = New Tab(Me.O_00Oo_.0.(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000B5 RID: 181
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As String) As Tab
			Get
				Dim result As Tab
				If Me.O_00Oo_.0..Contains(A_0) Then
					result = Me(Me.O_00Oo_.0..IndexOf(Me.O_00Oo_.0.(A_0)))
				Else
					If Me.O_00Oo_.0. = Main.OO_O.o..O.OOO0_OOo.().Tabs Then
						Try
							For Each obj As Object In Main.OO_O.o..O.OOO0_OOo.().ContextualTabGroups
								Dim ribbonContextualTabGroup As RibbonContextualTabGroup = CType(obj, RibbonContextualTabGroup)
								If ribbonContextualTabGroup.Tabs.Contains(A_0) Then
									Return New Tab(ribbonContextualTabGroup.Tabs(A_0))
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
					MessageBox.Show("菜单中不存在名为""" + A_0 + """的功能区！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600019E RID: 414 RVA: 0x00004B00 File Offset: 0x00002D00
		Public Sub Clear()
			Me.O_00Oo_.0..Clear()
		End Sub

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x0600019F RID: 415 RVA: 0x00004B0D File Offset: 0x00002D0D
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O_00Oo_.0..Count
			End Get
		End Property

		' Token: 0x060001A0 RID: 416 RVA: 0x00004B1A File Offset: 0x00002D1A
		Public Function Contains(Name As String) As Boolean
			Return Me.O_00Oo_.0..Contains(Name)
		End Function

		' Token: 0x060001A1 RID: 417 RVA: 0x00004B28 File Offset: 0x00002D28
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Contains(g As Tab) As Boolean
			Return Me.O_00Oo_.0..Contains(g.OO0.0OOo__.)
		End Function

		' Token: 0x060001A2 RID: 418 RVA: 0x00004B3B File Offset: 0x00002D3B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New RibbonTabEnumerator(Me)
		End Function

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060001A3 RID: 419 RVA: 0x00004B43 File Offset: 0x00002D43
		' (set) Token: 0x060001A4 RID: 420 RVA: 0x00004B59 File Offset: 0x00002D59
		Public Property SelectedTab As Tab
			Get
				Return New Tab(Main.OO_O.o..O.OOO0_OOo.().SelectedTab)
			End Get
			Set(value As Tab)
				Main.OO_O.o..O.OOO0_OOo.().SelectedTab = value.OO0.0OOo__.
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x060001A5 RID: 421 RVA: 0x00004B70 File Offset: 0x00002D70
		' (set) Token: 0x060001A6 RID: 422 RVA: 0x00004B81 File Offset: 0x00002D81
		Public Property AllowMinimize As Boolean
			Get
				Return Main.OO_O.o..O.OOO0_OOo.().AllowMinimize
			End Get
			Set(value As Boolean)
				Main.OO_O.o..O.OOO0_OOo.().AllowMinimize = value
			End Set
		End Property

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x060001A7 RID: 423 RVA: 0x00004B93 File Offset: 0x00002D93
		' (set) Token: 0x060001A8 RID: 424 RVA: 0x00004BA4 File Offset: 0x00002DA4
		Public Property Minimized As Boolean
			Get
				Return Main.OO_O.o..O.OOO0_OOo.().Minimized
			End Get
			Set(value As Boolean)
				Main.OO_O.o..O.OOO0_OOo.().Minimized = value
			End Set
		End Property

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x060001A9 RID: 425 RVA: 0x00004BB6 File Offset: 0x00002DB6
		' (set) Token: 0x060001AA RID: 426 RVA: 0x00004BC7 File Offset: 0x00002DC7
		Public Property HideTabHeaderRow As Boolean
			Get
				Return Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow
			End Get
			Set(value As Boolean)
				Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow = value
			End Set
		End Property

		' Token: 0x04000054 RID: 84
		Private <<EMPTY_NAME>> As RibbonTabCollection
	End Class
End Namespace
