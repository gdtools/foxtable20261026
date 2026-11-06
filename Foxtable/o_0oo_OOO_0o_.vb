Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004CA RID: 1226
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o_0oo_OOO_0o_
		Inherits List(Of Oo0__O__O_0__)

		' Token: 0x06004EA4 RID: 20132 RVA: 0x00209929 File Offset: 0x00207B29
		Public Sub New(A_0 As List(Of Oo0__O__O_0__))
			Me.RedoInfos = A_0
		End Sub

		' Token: 0x06004EA5 RID: 20133 RVA: 0x00209938 File Offset: 0x00207B38
		Public Sub <<EMPTY_NAME>>(A_0 As Oo0__O__O_0__)
			MyBase.Add(A_0)
			If Me.RedoInfos.Count > 0 AndAlso A_0 IsNot Me.RedoInfos(Me.RedoInfos.Count - 1) Then
				Me.RedoInfos.Clear()
			End If
			If MyBase.Count > 100 Then
				MyBase.RemoveAt(0)
			End If
		End Sub

		' Token: 0x04002095 RID: 8341
		Private RedoInfos As List(Of Oo0__O__O_0__)
	End Class
End Namespace
