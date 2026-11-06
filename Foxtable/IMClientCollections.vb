Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x020001C8 RID: 456
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class IMClientCollections
		Inherits Dictionary(Of String, IMClient)
		Implements IEnumerable(Of IMClient)

		' Token: 0x06001518 RID: 5400 RVA: 0x00088314 File Offset: 0x00086514
		Public Sub New()
			Me.O00.O0. = "jsn3DUSsXEPZuuflGGv9gzvJFXsmNjC4JEPCOTHL/1hyPIJjPJ1BaA=="
			Me.O00.O0. = RuntimeHelpers.GetObjectValue(New Object())
		End Sub

		' Token: 0x06001519 RID: 5401 RVA: 0x00088338 File Offset: 0x00086538
		Friend Sub Add(Name As String)
			Dim value As IMClient = New IMClient(Name)
			MyBase.Add(Name, value)
		End Sub

		' Token: 0x0600151A RID: 5402 RVA: 0x00088354 File Offset: 0x00086554
		Friend Sub Remove(Name As String)
			If MyBase.ContainsKey(Name) Then
				MyBase.Remove(Name)
			End If
		End Sub

		' Token: 0x0600151B RID: 5403 RVA: 0x00088367 File Offset: 0x00086567
		Public Function Contains(ClientName As String) As Boolean
			Return MyBase.ContainsKey(ClientName)
		End Function

		' Token: 0x0600151C RID: 5404 RVA: 0x00088370 File Offset: 0x00086570
		Public Function GetEnumerator1() As IEnumerator(Of IMClient) Implements System.Collections.Generic.IEnumerable(Of Foxtable.IMClient).GetEnumerator
			Return CType(MyBase.Values.GetEnumerator(), IEnumerator(Of IMClient))
		End Function

		' Token: 0x04000876 RID: 2166
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000877 RID: 2167
		Friend <<EMPTY_NAME>> As Object
	End Class
End Namespace
