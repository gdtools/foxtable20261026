Imports System
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200045C RID: 1116
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Report
		' Token: 0x06004AA7 RID: 19111 RVA: 0x001F7021 File Offset: 0x001F5221
		Public Sub New(A_0 As DataRow)
			Me.o.0OoO. = A_0
		End Sub

		' Token: 0x17001094 RID: 4244
		' (get) Token: 0x06004AA8 RID: 19112 RVA: 0x001F7030 File Offset: 0x001F5230
		Public ReadOnly Property Name As String
			Get
				Return Conversions.ToString(Me.o.0OoO.("Name"))
			End Get
		End Property

		' Token: 0x06004AA9 RID: 19113 RVA: 0x001F7048 File Offset: 0x001F5248
		Public Sub Execute()
			Dim reportProperty As ReportProperty = New ReportProperty()
			If Not Me.o.0OoO..IsNull("Property") Then
				o_O_o_oOoo__.OOOO_OO._oo.(reportProperty, Conversions.ToString(Me.o.0OoO.("Property")), vbVerticalTab)
				If reportProperty.Code IsNot Nothing AndAlso Operators.CompareString(reportProperty.Code(0), "", True) > 0 Then
					Dim text As String = reportProperty.Code(0)
					If Operators.CompareString(text, "", True) > 0 Then
						text = text.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
					End If
					Dim text2 As String
					If text.StartsWith("'''async", StringComparison.OrdinalIgnoreCase) Then
						text2 = "Public Async Sub Build()"
					Else
						text2 = "Public Sub Build()"
					End If
					text2 += vbCrLf
					text2 += text
					text2 += vbCrLf
					text2 += "End Sub"
					O_O0OO.OoO_o.oO0o0O.(o0_.Oo_0.OOo0oO0.(text2, "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True), "Build", New Object(-1) {}, False, "", False)
				End If
			End If
		End Sub

		' Token: 0x04001EA3 RID: 7843
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
