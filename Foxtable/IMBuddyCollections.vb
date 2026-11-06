Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001CA RID: 458
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class IMBuddyCollections
		Implements IEnumerable(Of IMBuddy)

		' Token: 0x06001574 RID: 5492 RVA: 0x0008D928 File Offset: 0x0008BB28
		Public Sub New()
			Me.OOO__.0. = New Dictionary(Of String, IMBuddy)()
		End Sub

		' Token: 0x06001575 RID: 5493 RVA: 0x0008D93B File Offset: 0x0008BB3B
		Friend Sub <<EMPTY_NAME>>(A_0 As IMBuddy)
			Me.OOO__.0..Add(A_0.Name, A_0)
		End Sub

		' Token: 0x06001576 RID: 5494 RVA: 0x0008D94F File Offset: 0x0008BB4F
		Friend Sub <<EMPTY_NAME>>()
			Me.OOO__.0..Clear()
		End Sub

		' Token: 0x06001577 RID: 5495 RVA: 0x0008D95C File Offset: 0x0008BB5C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OOO__.0..Remove(A_0)
		End Sub

		' Token: 0x06001578 RID: 5496 RVA: 0x0008D96B File Offset: 0x0008BB6B
		Friend Sub <<EMPTY_NAME>>(A_0 As IMBuddy)
			Me.OOO__.0..Remove(A_0.Name)
		End Sub

		' Token: 0x06001579 RID: 5497 RVA: 0x0008D97F File Offset: 0x0008BB7F
		Public Function Contains(Name As String) As Boolean
			Return Me.OOO__.0..ContainsKey(Name)
		End Function

		' Token: 0x0600157A RID: 5498 RVA: 0x0008D98D File Offset: 0x0008BB8D
		Friend Function <<EMPTY_NAME>>(A_0 As IMBuddy) As Boolean
			Return Me.OOO__.0..ContainsKey(A_0.Name)
		End Function

		' Token: 0x17000494 RID: 1172
		' (get) Token: 0x0600157B RID: 5499 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OOO__.0..Count
			End Get
		End Property

		' Token: 0x17000495 RID: 1173
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As IMBuddy
			Get
				Dim a_ As Integer = -1
				Dim result As IMBuddy
				If Integer.TryParse(A_0.ToString(), a_) Then
					result = Me.OOO__.0.(a_)
				Else
					result = Me.get_Item(Conversions.ToString(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000496 RID: 1174
		' (get) Token: 0x0600157D RID: 5501 RVA: 0x0008D9E6 File Offset: 0x0008BBE6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Name As String) As IMBuddy
			Get
				Return Me.OOO__.0.(Name)
			End Get
		End Property

		' Token: 0x17000497 RID: 1175
		' (get) Token: 0x0600157E RID: 5502 RVA: 0x0008D9F4 File Offset: 0x0008BBF4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(A_0 As Integer) As IMBuddy
			Get
				Dim num As Integer = 0
				Try
					For Each key As String In Me.OOO__.0..Keys
						If num = A_0 Then
							Return Me.OOO__.0.(key)
						End If
						num += 1
					Next
				Finally
					Dim enumerator As Dictionary(Of String, IMBuddy).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return Nothing
			End Get
		End Property

		' Token: 0x0600157F RID: 5503 RVA: 0x0008DA64 File Offset: 0x0008BC64
		Public Function GetEnumerator() As IEnumerator(Of IMBuddy) Implements System.Collections.Generic.IEnumerable(Of Foxtable.IMBuddy).GetEnumerator
			Return CType(Me.OOO__.0..Values.GetEnumerator(), IEnumerator(Of IMBuddy))
		End Function

		' Token: 0x06001580 RID: 5504 RVA: 0x0008DA80 File Offset: 0x0008BC80
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.OOO__.0..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x040008B5 RID: 2229
		Private <<EMPTY_NAME>> As Dictionary(Of String, IMBuddy)
	End Class
End Namespace
