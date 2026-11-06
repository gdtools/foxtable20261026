Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200045D RID: 1117
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ReportCollection
		Implements IEnumerable(Of Report)

		' Token: 0x06004AAA RID: 19114 RVA: 0x001F716F File Offset: 0x001F536F
		Public Sub New()
			Me.o.0OoO. = New Dictionary(Of String, Report)()
		End Sub

		' Token: 0x06004AAB RID: 19115 RVA: 0x001F7184 File Offset: 0x001F5384
		Friend Sub <<EMPTY_NAME>>()
			Me.o.0OoO..Clear()
			For Each a_ As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).[Select]("[Type] = " + Conversions.ToString(6))
				Dim report As Report = New Report(a_)
				Me.o.0OoO..Add(report.Name, report)
			Next
			Oo00.oO.0_o0o.()
		End Sub

		' Token: 0x17001095 RID: 4245
		Public ReadOnly Default Property Item(Name As String) As Report
			Get
				Return Me.o.0OoO.(Name)
			End Get
		End Property

		' Token: 0x06004AAD RID: 19117 RVA: 0x001F7204 File Offset: 0x001F5404
		Public Function GetEnumerator() As IEnumerator(Of Report) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Report).GetEnumerator
			Return CType(Me.o.0OoO..Values.GetEnumerator(), IEnumerator(Of Report))
		End Function

		' Token: 0x06004AAE RID: 19118 RVA: 0x001F7220 File Offset: 0x001F5420
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.o.0OoO..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x04001EA4 RID: 7844
		Private <<EMPTY_NAME>> As Dictionary(Of String, Report)
	End Class
End Namespace
