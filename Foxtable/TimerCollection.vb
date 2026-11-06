Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000319 RID: 793
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0658")>
	Public Class TimerCollection
		Implements IEnumerable(Of Timer)

		' Token: 0x06002B16 RID: 11030 RVA: 0x0012D9CC File Offset: 0x0012BBCC
		Public Sub New()
			Me.O_o.Oo_o__. = New Dictionary(Of String, Timer)(StringComparer.OrdinalIgnoreCase)
		End Sub

		' Token: 0x17000A30 RID: 2608
		' (get) Token: 0x06002B17 RID: 11031 RVA: 0x0012D9E4 File Offset: 0x0012BBE4
		' (set) Token: 0x06002B18 RID: 11032 RVA: 0x0012D9EC File Offset: 0x0012BBEC
		Public Property Pause As Boolean
			Get
				Return Me.O_o.Oo_o__.
			End Get
			Set(value As Boolean)
				Me.O_o.Oo_o__. = value
			End Set
		End Property

		' Token: 0x06002B19 RID: 11033 RVA: 0x0012D9F8 File Offset: 0x0012BBF8
		Public Sub Clear()
			Try
				For Each timer As Timer In Me.O_o.Oo_o__..Values
					timer.Enabled = False
					timer.Dispose()
				Next
			Finally
				Dim enumerator As Dictionary(Of String, Timer).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Me.O_o.Oo_o__..Clear()
		End Sub

		' Token: 0x06002B1A RID: 11034 RVA: 0x0012DA60 File Offset: 0x0012BC60
		Public Sub Add(key As String, timer As Timer)
			Me.O_o.Oo_o__..Add(key, timer)
		End Sub

		' Token: 0x06002B1B RID: 11035 RVA: 0x0012DA6F File Offset: 0x0012BC6F
		Public Sub Remove(key As String)
			Me.O_o.Oo_o__..Remove(key)
		End Sub

		' Token: 0x06002B1C RID: 11036 RVA: 0x0012DA7E File Offset: 0x0012BC7E
		Public Function GetEnumerator() As IEnumerator(Of Timer) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Timer).GetEnumerator
			Return Me.Values.GetEnumerator()
		End Function

		' Token: 0x06002B1D RID: 11037 RVA: 0x0012DA8B File Offset: 0x0012BC8B
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.Values.GetEnumerator()
		End Function

		' Token: 0x17000A31 RID: 2609
		Public ReadOnly Default Property Item(A_0 As String) As Timer
			Get
				Return Me.O_o.Oo_o__.(A_0)
			End Get
		End Property

		' Token: 0x17000A32 RID: 2610
		' (get) Token: 0x06002B1F RID: 11039 RVA: 0x0012DAA6 File Offset: 0x0012BCA6
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O_o.Oo_o__..Count
			End Get
		End Property

		' Token: 0x17000A33 RID: 2611
		' (get) Token: 0x06002B20 RID: 11040 RVA: 0x0012DAB3 File Offset: 0x0012BCB3
		Public ReadOnly Property Keys As IEnumerable(Of String)
			Get
				Return Me.O_o.Oo_o__..Keys
			End Get
		End Property

		' Token: 0x17000A34 RID: 2612
		' (get) Token: 0x06002B21 RID: 11041 RVA: 0x0012DAC0 File Offset: 0x0012BCC0
		Public ReadOnly Property Values As IEnumerable(Of Timer)
			Get
				Return Me.O_o.Oo_o__..Values
			End Get
		End Property

		' Token: 0x0400117C RID: 4476
		Private <<EMPTY_NAME>> As Dictionary(Of String, Timer)

		' Token: 0x0400117D RID: 4477
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
