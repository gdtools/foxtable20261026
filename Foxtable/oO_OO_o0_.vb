Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020001C3 RID: 451
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oO_OO_o0_
		Inherits Dictionary(Of String, UDPClient)
		Implements IEnumerable(Of UDPClient)

		' Token: 0x060014EF RID: 5359 RVA: 0x000828D0 File Offset: 0x00080AD0
		Public Sub New()
			Me.OO.000O. = "jsn3DUSsXEPyI0w1RKCIV/+CtcaS959KLMVZa/cPJ8fr5Y8WV8v+ZA=="
		End Sub

		' Token: 0x060014F0 RID: 5360 RVA: 0x000828E4 File Offset: 0x00080AE4
		Public Sub Add(Name As String)
			If Not o0OO__.OO0oO.o.() Then
				MessageBox.Show(O00.DecryptText(Me.OO.000O., "my", "fox"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Dim value As UDPClient = New UDPClient(Name)
			MyBase.Add(Name, value)
		End Sub

		' Token: 0x060014F1 RID: 5361 RVA: 0x0008292B File Offset: 0x00080B2B
		Public Sub Remove(Name As String)
			If MyBase.ContainsKey(Name) Then
				MyBase.Remove(Name)
			End If
		End Sub

		' Token: 0x060014F2 RID: 5362 RVA: 0x0008293E File Offset: 0x00080B3E
		Public Function Contains(Name As String) As Boolean
			Return MyBase.ContainsKey(Name)
		End Function

		' Token: 0x060014F3 RID: 5363 RVA: 0x00082947 File Offset: 0x00080B47
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator(Of UDPClient) Implements System.Collections.Generic.IEnumerable(Of Foxtable.UDPClient).GetEnumerator
			Return CType(MyBase.Values.GetEnumerator(), IEnumerator(Of UDPClient))
		End Function

		' Token: 0x04000861 RID: 2145
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
