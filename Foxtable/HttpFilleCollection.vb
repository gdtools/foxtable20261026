Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020001FB RID: 507
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class HttpFilleCollection
		Inherits Dictionary(Of String, List(Of String))

		' Token: 0x06001848 RID: 6216 RVA: 0x0009EC10 File Offset: 0x0009CE10
		Public Sub Add(id As String, FileName As String)
			If Not MyBase.ContainsKey(id) Then
				MyBase.Add(id, New List(Of String)())
			End If
			MyBase(id).Add(FileName)
		End Sub
	End Class
End Namespace
