Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000279 RID: 633
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CrossExpressionGroupCollections
		Inherits List(Of CrossExpressionGroup)

		' Token: 0x06001E57 RID: 7767 RVA: 0x000C2864 File Offset: 0x000C0A64
		Public Sub Adddef(Name As String, Expression As String)
			MyBase.Add(New CrossExpressionGroup(Name, Expression, ""))
		End Sub

		' Token: 0x06001E58 RID: 7768 RVA: 0x000C2878 File Offset: 0x000C0A78
		Public Sub Adddef(Name As String, Expression As String, Pattern As String)
			MyBase.Add(New CrossExpressionGroup(Name, Expression, Pattern))
		End Sub
	End Class
End Namespace
