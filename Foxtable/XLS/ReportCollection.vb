Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Reflection
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.XLS
	' Token: 0x020004E2 RID: 1250
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ReportCollection
		Implements IEnumerable(Of Report)

		' Token: 0x06005046 RID: 20550 RVA: 0x0021856F File Offset: 0x0021676F
		Public Sub New()
			Me.OoOoo.o. = New Dictionary(Of String, Report)()
			Me.OoOoo.o. = True
		End Sub

		' Token: 0x06005047 RID: 20551 RVA: 0x0021858C File Offset: 0x0021678C
		Friend Sub <<EMPTY_NAME>>()
			Me.OoOoo.o..Clear()
			For Each a_ As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).[Select]("[Type] = " + Conversions.ToString(5))
				Dim report As Report = New Report(a_)
				Me.OoOoo.o..Add(report.Name, report)
			Next
		End Sub

		' Token: 0x17001220 RID: 4640
		Public ReadOnly Default Property Item(Name As String) As Report
			Get
				Return Me.OoOoo.o.(Name)
			End Get
		End Property

		' Token: 0x06005049 RID: 20553 RVA: 0x00218607 File Offset: 0x00216807
		Public Function GetEnumerator() As IEnumerator(Of Report) Implements System.Collections.Generic.IEnumerable(Of Foxtable.XLS.Report).GetEnumerator
			Return CType(Me.OoOoo.o..Values.GetEnumerator(), IEnumerator(Of Report))
		End Function

		' Token: 0x0600504A RID: 20554 RVA: 0x00218623 File Offset: 0x00216823
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.OoOoo.o..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x04002193 RID: 8595
		Private <<EMPTY_NAME>> As Dictionary(Of String, Report)

		' Token: 0x04002194 RID: 8596
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04002195 RID: 8597
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04002196 RID: 8598
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
