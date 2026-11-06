Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003B7 RID: 951
	<oO0oooo("0830")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class TabPageCollection
		Implements IEnumerable(Of TabPage)

		' Token: 0x06003CFB RID: 15611 RVA: 0x001AABF8 File Offset: 0x001A8DF8
		Public Sub New(A_0 As C1DockingTabPages)
			Me.Oo_._O0oOOOo. = A_0
		End Sub

		' Token: 0x17000D56 RID: 3414
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Index As Integer) As TabPage
			Get
				Return CType(Me.Oo_._O0oOOOo.(Index), TabPage)
			End Get
		End Property

		' Token: 0x17000D57 RID: 3415
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As TabPage
			Get
				Return CType(Me.Oo_._O0oOOOo.(Name), TabPage)
			End Get
		End Property

		' Token: 0x17000D58 RID: 3416
		' (get) Token: 0x06003CFE RID: 15614 RVA: 0x001AAC2D File Offset: 0x001A8E2D
		Public ReadOnly Property Count As Integer
			Get
				Return Me.Oo_._O0oOOOo..Count
			End Get
		End Property

		' Token: 0x06003CFF RID: 15615 RVA: 0x001AAC3C File Offset: 0x001A8E3C
		Public Function Contains(name As String) As Boolean
			Try
				Dim enumerator As IEnumerator = Me.Oo_._O0oOOOo..GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(CType(enumerator.Current, C1DockingTabPage).Name, name, True) = 0 Then
						Return True
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x06003D00 RID: 15616 RVA: 0x001AACA8 File Offset: 0x001A8EA8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of TabPage) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.TabPage).GetEnumerator
			Return New o0_0oo00_o(Me.Oo_._O0oOOOo.)
		End Function

		' Token: 0x06003D01 RID: 15617 RVA: 0x001AACB5 File Offset: 0x001A8EB5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New o0_0oo00_o(Me.Oo_._O0oOOOo.)
		End Function

		' Token: 0x06003D02 RID: 15618 RVA: 0x001AACC4 File Offset: 0x001A8EC4
		Public Function Add(Name As String, Text As String) As TabPage
			Dim tabPage As TabPage = New TabPage()
			tabPage.Name = Name
			tabPage.Text = Text
			Me.Oo_._O0oOOOo..Add(tabPage)
			Return tabPage
		End Function

		' Token: 0x06003D03 RID: 15619 RVA: 0x001AACF4 File Offset: 0x001A8EF4
		Public Function Insert(Name As String, Text As String, Index As Integer) As TabPage
			Dim tabPage As TabPage = New TabPage()
			tabPage.Name = Name
			tabPage.Text = Text
			Me.Oo_._O0oOOOo..Insert(Index, tabPage)
			Return tabPage
		End Function

		' Token: 0x06003D04 RID: 15620 RVA: 0x001AAD24 File Offset: 0x001A8F24
		Public Sub Delete(Name As String)
			Dim tabPage As TabPage = CType(Me.Oo_._O0oOOOo.(Name), TabPage)
			tabPage.ClearControl()
			Me.Oo_._O0oOOOo..Remove(tabPage)
		End Sub

		' Token: 0x06003D05 RID: 15621 RVA: 0x001AAD58 File Offset: 0x001A8F58
		Public Sub Delete(index As Integer)
			Dim tabPage As TabPage = CType(Me.Oo_._O0oOOOo.(index), TabPage)
			tabPage.ClearControl()
			Me.Oo_._O0oOOOo..Remove(tabPage)
		End Sub

		' Token: 0x06003D06 RID: 15622 RVA: 0x001AAD8C File Offset: 0x001A8F8C
		Public Sub Clear()
			Try
				For Each obj As Object In Me.Oo_._O0oOOOo.
					CType(obj, TabPage).ClearControl()
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.Oo_._O0oOOOo..Clear()
		End Sub

		' Token: 0x04001902 RID: 6402
		Private <<EMPTY_NAME>> As C1DockingTabPages
	End Class
End Namespace
