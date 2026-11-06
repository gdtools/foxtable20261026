Imports System
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000288 RID: 648
	<oO0oooo("1279")>
	<ComVisible(True)>
	Public Class OuterTableBuilder
		Inherits QueryBuilder

		' Token: 0x06001F98 RID: 8088 RVA: 0x000D0535 File Offset: 0x000CE735
		Public Sub New()
			MyBase.IsDataTable = True
		End Sub

		' Token: 0x06001F99 RID: 8089 RVA: 0x000D0544 File Offset: 0x000CE744
		Public Sub New(A_0 As String)
			MyBase.TableName = A_0
			MyBase.IsDataTable = True
		End Sub
	End Class
End Namespace
