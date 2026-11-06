Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200013F RID: 319
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class O0oO_0
		Inherits Form

		' Token: 0x06000F52 RID: 3922 RVA: 0x00068561 File Offset: 0x00066761
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.OoO0O0.0O_oo.
			MyBase.KeyPreview = True
		End Sub

		' Token: 0x06000F53 RID: 3923 RVA: 0x00068584 File Offset: 0x00066784
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.Control AndAlso A_1.Shift AndAlso A_1.KeyCode = Keys.F6 Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
				Try
					Dim enumerator As Dictionary(Of String, IMClient).ValueCollection.Enumerator = OO_00oOO.IMClients.Values.GetEnumerator()
					If enumerator.MoveNext() Then
						enumerator.Current.o0.0o_00.(Me)
					End If
				Finally
					Dim enumerator As Dictionary(Of String, IMClient).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
		End Sub
	End Class
End Namespace
