Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020002E2 RID: 738
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class IMUserCollections
		Implements IEnumerable(Of IMUser)

		' Token: 0x06002725 RID: 10021 RVA: 0x0010AA5A File Offset: 0x00108C5A
		Public Sub New()
			Me.oO._O_0oO__0. = New Dictionary(Of String, IMUser)()
		End Sub

		' Token: 0x06002726 RID: 10022 RVA: 0x0010AA6D File Offset: 0x00108C6D
		Friend Sub <<EMPTY_NAME>>(A_0 As IMUser)
			Me.oO._O_0oO__0..Add(A_0.Name, A_0)
		End Sub

		' Token: 0x06002727 RID: 10023 RVA: 0x0010AA81 File Offset: 0x00108C81
		Friend Sub <<EMPTY_NAME>>()
			Me.oO._O_0oO__0..Clear()
		End Sub

		' Token: 0x06002728 RID: 10024 RVA: 0x0010AA90 File Offset: 0x00108C90
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			SyncLock Me
				Me.oO._O_0oO__0..Remove(A_0)
			End SyncLock
		End Sub

		' Token: 0x06002729 RID: 10025 RVA: 0x0010AAD4 File Offset: 0x00108CD4
		Friend Sub <<EMPTY_NAME>>(A_0 As IMUser)
			SyncLock Me
				Me.oO._O_0oO__0..Remove(A_0.Name)
			End SyncLock
		End Sub

		' Token: 0x0600272A RID: 10026 RVA: 0x0010AB1C File Offset: 0x00108D1C
		Public Function Contains(Name As String) As Boolean
			Return Me.oO._O_0oO__0..ContainsKey(Name)
		End Function

		' Token: 0x0600272B RID: 10027 RVA: 0x0010AB2A File Offset: 0x00108D2A
		Friend Function <<EMPTY_NAME>>(A_0 As IMUser) As Boolean
			Return Me.oO._O_0oO__0..ContainsKey(A_0.Name)
		End Function

		' Token: 0x170008C1 RID: 2241
		' (get) Token: 0x0600272C RID: 10028 RVA: 0x0010AB3D File Offset: 0x00108D3D
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oO._O_0oO__0..Count
			End Get
		End Property

		' Token: 0x170008C2 RID: 2242
		Public ReadOnly Default Property Item(Name As String) As IMUser
			Get
				Return Me.oO._O_0oO__0.(Name)
			End Get
		End Property

		' Token: 0x0600272E RID: 10030 RVA: 0x0010AB58 File Offset: 0x00108D58
		Public Function GetEnumerator() As IEnumerator(Of IMUser) Implements System.Collections.Generic.IEnumerable(Of Foxtable.IMUser).GetEnumerator
			Return CType(Me.oO._O_0oO__0..Values.GetEnumerator(), IEnumerator(Of IMUser))
		End Function

		' Token: 0x0600272F RID: 10031 RVA: 0x0010AB74 File Offset: 0x00108D74
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.oO._O_0oO__0..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x04001036 RID: 4150
		Private <<EMPTY_NAME>> As Dictionary(Of String, IMUser)
	End Class
End Namespace
