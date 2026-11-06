Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Reflection
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Word
	' Token: 0x02000005 RID: 5
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ReportCollection
		Implements IEnumerable(Of Report)

		' Token: 0x06000010 RID: 16 RVA: 0x000023F0 File Offset: 0x000005F0
		Public Sub New()
			Me.O0oOOO._OOO. = New Dictionary(Of String, Report)()
			Me.O0oOOO._OOO. = True
		End Sub

		' Token: 0x06000011 RID: 17 RVA: 0x0000240C File Offset: 0x0000060C
		Friend Sub Load()
			Me.O0oOOO._OOO..Clear()
			For Each a_ As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).[Select]("[Type] = " + Conversions.ToString(9))
				Dim report As Report = New Report(a_)
				Me.O0oOOO._OOO..Add(report.Name, report)
			Next
		End Sub

		' Token: 0x17000009 RID: 9
		Public ReadOnly Default Property Item(Name As String) As Report
			Get
				Return Me.O0oOOO._OOO.(Name)
			End Get
		End Property

		' Token: 0x06000013 RID: 19 RVA: 0x00002488 File Offset: 0x00000688
		Public Function GetEnumerator() As IEnumerator(Of Report) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Word.Report).GetEnumerator
			Return CType(Me.O0oOOO._OOO..Values.GetEnumerator(), IEnumerator(Of Report))
		End Function

		' Token: 0x06000014 RID: 20 RVA: 0x000024A4 File Offset: 0x000006A4
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.O0oOOO._OOO..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x04000006 RID: 6
		Private <<EMPTY_NAME>> As Dictionary(Of String, Report)

		' Token: 0x04000007 RID: 7
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04000008 RID: 8
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04000009 RID: 9
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
