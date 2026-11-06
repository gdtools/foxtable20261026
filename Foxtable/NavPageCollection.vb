Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Command
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003B4 RID: 948
	<ComVisible(True)>
	<oO0oooo("0873")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class NavPageCollection
		Implements IEnumerable(Of NavPage)

		' Token: 0x06003CD8 RID: 15576 RVA: 0x001AA756 File Offset: 0x001A8956
		Public Sub New(A_0 As C1NavBarPanel.PanelCollection)
			Me.O__0_0Oo.Oo000. = A_0
		End Sub

		' Token: 0x17000D4D RID: 3405
		Public ReadOnly Default Property Item(Index As Integer) As NavPage
			Get
				Return CType(Me.O__0_0Oo.Oo000.(Index), NavPage)
			End Get
		End Property

		' Token: 0x17000D4E RID: 3406
		Public ReadOnly Default Property Item(Name As String) As NavPage
			Get
				Return CType(Me.O__0_0Oo.Oo000.(Name), NavPage)
			End Get
		End Property

		' Token: 0x06003CDB RID: 15579 RVA: 0x001AA78C File Offset: 0x001A898C
		Public Function Contains(Name As String) As Boolean
			Try
				Dim enumerator As IEnumerator = Me.O__0_0Oo.Oo000..GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(CType(enumerator.Current, C1NavBarPanel).Name, Name, True) = 0 Then
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

		' Token: 0x17000D4F RID: 3407
		' (get) Token: 0x06003CDC RID: 15580 RVA: 0x001AA7F8 File Offset: 0x001A89F8
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O__0_0Oo.Oo000..Count
			End Get
		End Property

		' Token: 0x06003CDD RID: 15581 RVA: 0x001AA808 File Offset: 0x001A8A08
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function AddNavPage() As NavPage
			Dim navPage As NavPage = New NavPage()
			Me.O__0_0Oo.Oo000..Add(navPage)
			Return navPage
		End Function

		' Token: 0x06003CDE RID: 15582 RVA: 0x001AA829 File Offset: 0x001A8A29
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of NavPage) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.NavPage).GetEnumerator
			Return New OOO0O0(Me.O__0_0Oo.Oo000.)
		End Function

		' Token: 0x06003CDF RID: 15583 RVA: 0x001AA836 File Offset: 0x001A8A36
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New OOO0O0(Me.O__0_0Oo.Oo000.)
		End Function

		' Token: 0x06003CE0 RID: 15584 RVA: 0x001AA844 File Offset: 0x001A8A44
		Public Function Add(Name As String, ButtonText As String, ButtonImageFile As String) As NavPage
			Dim navPage As NavPage = New NavPage()
			navPage.Name = Name
			navPage.ButtonText = ButtonText
			navPage.Button.Image = OO_00oOO.GetImage(ButtonImageFile)
			Me.O__0_0Oo.Oo000..Add(navPage)
			Return navPage
		End Function

		' Token: 0x06003CE1 RID: 15585 RVA: 0x001AA884 File Offset: 0x001A8A84
		Public Function Insert(Name As String, ButtonText As String, ButtonImageFile As String, Index As Integer) As NavPage
			Dim navPage As NavPage = New NavPage()
			navPage.Name = Name
			navPage.ButtonText = ButtonText
			navPage.Button.Image = OO_00oOO.GetImage(ButtonImageFile)
			Me.O__0_0Oo.Oo000..Insert(Index, navPage)
			Return navPage
		End Function

		' Token: 0x06003CE2 RID: 15586 RVA: 0x001AA8C8 File Offset: 0x001A8AC8
		Public Sub Delete(Name As String)
			Dim navPage As NavPage = CType(Me.O__0_0Oo.Oo000.(Name), NavPage)
			navPage.ClearControl()
			Me.O__0_0Oo.Oo000..Remove(navPage)
		End Sub

		' Token: 0x06003CE3 RID: 15587 RVA: 0x001AA8FC File Offset: 0x001A8AFC
		Public Sub Delete(index As Integer)
			Dim navPage As NavPage = CType(Me.O__0_0Oo.Oo000.(index), NavPage)
			navPage.ClearControl()
			Me.O__0_0Oo.Oo000..Remove(navPage)
		End Sub

		' Token: 0x06003CE4 RID: 15588 RVA: 0x001AA930 File Offset: 0x001A8B30
		Public Sub Clear()
			Try
				For Each obj As Object In Me.O__0_0Oo.Oo000.
					CType(obj, NavPage).ClearControl()
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.O__0_0Oo.Oo000..Clear()
		End Sub

		' Token: 0x040018FC RID: 6396
		Private <<EMPTY_NAME>> As C1NavBarPanel.PanelCollection
	End Class
End Namespace
