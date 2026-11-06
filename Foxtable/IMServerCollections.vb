Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020002DB RID: 731
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class IMServerCollections
		Inherits Dictionary(Of String, IMServer)
		Implements IEnumerable(Of IMServer)

		' Token: 0x060026D2 RID: 9938 RVA: 0x00107B15 File Offset: 0x00105D15
		Public Sub New()
			Me.oO_0OO.0. = "jsn3DUSsXEPZuuflGGv9gzvJFXsmNjC4BjTrGYJ6t6bwNwcz2W9Mpg=="
		End Sub

		' Token: 0x060026D3 RID: 9939 RVA: 0x00107B28 File Offset: 0x00105D28
		Public Sub Add(Name As String)
			If MyBase.Count > 0 AndAlso Not o0OO__.OO0oO.o.() Then
				MessageBox.Show(O00.DecryptText(Me.oO_0OO.0., "my", "fox"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Dim value As IMServer = New IMServer(Name)
			MyBase.Add(Name, value)
		End Sub

		' Token: 0x060026D4 RID: 9940 RVA: 0x00107B78 File Offset: 0x00105D78
		Public Sub Remove(Name As String)
			If MyBase.ContainsKey(Name) Then
				MyBase.Remove(Name)
			End If
		End Sub

		' Token: 0x060026D5 RID: 9941 RVA: 0x00107B8B File Offset: 0x00105D8B
		Public Function Contains(ServerName As String) As Boolean
			Return MyBase.ContainsKey(ServerName)
		End Function

		' Token: 0x060026D6 RID: 9942 RVA: 0x00107B94 File Offset: 0x00105D94
		Public Function GetEnumerator1() As IEnumerator(Of IMServer) Implements System.Collections.Generic.IEnumerable(Of Foxtable.IMServer).GetEnumerator
			Return CType(MyBase.Values.GetEnumerator(), IEnumerator(Of IMServer))
		End Function

		' Token: 0x04001013 RID: 4115
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
