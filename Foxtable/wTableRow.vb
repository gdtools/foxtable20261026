Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000222 RID: 546
	<oO0oooo("A0063")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wTableRow
		' Token: 0x06001969 RID: 6505 RVA: 0x000A4B05 File Offset: 0x000A2D05
		Public Sub New()
			Me.o0oO._0o0_O. = New List(Of String)()
		End Sub

		' Token: 0x170005A5 RID: 1445
		' (get) Token: 0x0600196A RID: 6506 RVA: 0x000A4B18 File Offset: 0x000A2D18
		' (set) Token: 0x0600196B RID: 6507 RVA: 0x000A4B20 File Offset: 0x000A2D20
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property [Class] As String
			Get
				Return Me.OOooOo.00OO_.
			End Get
			Set(value As String)
				Me.OOooOo.00OO_. = value
			End Set
		End Property

		' Token: 0x170005A6 RID: 1446
		' (get) Token: 0x0600196C RID: 6508 RVA: 0x000A4B29 File Offset: 0x000A2D29
		' (set) Token: 0x0600196D RID: 6509 RVA: 0x000A4B31 File Offset: 0x000A2D31
		Public Property Attribute As String
			Get
				Return Me.O0oO.o_Oo0.
			End Get
			Set(value As String)
				Me.O0oO.o_Oo0. = value
			End Set
		End Property

		' Token: 0x170005A7 RID: 1447
		' (get) Token: 0x0600196E RID: 6510 RVA: 0x000A4B3A File Offset: 0x000A2D3A
		' (set) Token: 0x0600196F RID: 6511 RVA: 0x000A4B42 File Offset: 0x000A2D42
		Public Property Primarykey As String
			Get
				Return Me.OOooO_o0.o.
			End Get
			Set(value As String)
				Me.OOooO_o0.o. = value
			End Set
		End Property

		' Token: 0x06001970 RID: 6512 RVA: 0x000A4B4B File Offset: 0x000A2D4B
		<oO0oooo("A0068")>
		Public Sub AddCells(ParamArray values As String())
			Me.o0oO._0o0_O..AddRange(values)
		End Sub

		' Token: 0x06001971 RID: 6513 RVA: 0x000A4B59 File Offset: 0x000A2D59
		<oO0oooo("A0068")>
		Public Sub AddCells(values As IEnumerable(Of String))
			Me.o0oO._0o0_O..AddRange(values)
		End Sub

		' Token: 0x06001972 RID: 6514 RVA: 0x000A4B67 File Offset: 0x000A2D67
		<oO0oooo("A0068")>
		Public Sub AddCell(value As String, Optional Attribute As String = "")
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Me.o0oO._0o0_O..Add(value + vbVerticalTab + Attribute)
				Return
			End If
			Me.o0oO._0o0_O..Add(value)
		End Sub

		' Token: 0x06001973 RID: 6515 RVA: 0x000A4B9C File Offset: 0x000A2D9C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As Integer, A_2 As wRowCollection, A_3 As Integer, A_4 As Boolean, A_5 As Integer, Optional A_6 As String = "")
			A_0.Append("<tr")
			If Operators.CompareString(Me.Attribute, "", True) > 0 Then
				A_0.Append(" " + Me.Attribute)
			End If
			If Operators.CompareString(Me.OOooO_o0.o., "", True) > 0 Then
				A_0.Append(" data-key='" + Me.OOooO_o0.o. + "'")
			End If
			If A_4 Then
				Me.[Class] += " alt"
			End If
			If Operators.CompareString(Me.[Class], "", True) > 0 Then
				A_0.Append(" class='" + Me.[Class] + "'")
			End If
			A_0.Append(">")
			Dim array As String() = New String(-1) {}
			If Operators.CompareString(A_6, "", True) > 0 Then
				array = A_6.Split(New Char() { ","c })
			End If
			Dim num As Integer = Me.o0oO._0o0_O..Count - 1
			Dim i As Integer = 0
			While i <= num
				Dim text As String = Me.o0oO._0o0_O.(i)
				Dim num2 As Integer = 1
				Dim num3 As Integer = 1
				If Me.o0oO._0o0_O. Then
					Me.OOooOo.00OO_.(A_1, i, A_2, num2, num3)
					If num2 <> -1 AndAlso num3 <> -1 Then
						A_0.Append("<th data-idx='" + Conversions.ToString(i) + "'")
						If num2 > 1 Then
							A_0.Append(" rowspan='" + Conversions.ToString(num2) + "'")
						End If
						If num3 > 1 Then
							A_0.Append(" colspan='" + Conversions.ToString(num3) + "'")
						End If
						If(A_1 = 0 OrElse A_2(A_1 - 1).o0oO._0o0_O..Count > i) AndAlso array.Length > i AndAlso Operators.CompareString(array(i), "", True) > 0 Then
							A_0.Append(" width='" + array(i) + "'")
							GoTo IL_241
						End If
						GoTo IL_241
					End If
				Else
					If A_3 > i Then
						num2 = Me.OOooOo.00OO_.(A_1, i, A_2)
						If num2 = -1 Then
							GoTo IL_2B8
						End If
					End If
					If i < A_5 Then
						A_0.Append("<th")
					Else
						A_0.Append("<td")
					End If
					If num2 > 1 Then
						A_0.Append(" rowspan='" + Conversions.ToString(num2) + "'")
						GoTo IL_241
					End If
					GoTo IL_241
				End If
				IL_2B8:
				i += 1
				Continue While
				IL_241:
				If text.IndexOf(vbVerticalTab) >= 0 Then
					Dim array2 As String() = text.Split(New Char() { vbVerticalTab })
					A_0.Append(" " + array2(1) + ">" + array2(0))
				Else
					A_0.Append(">" + text)
				End If
				If Me.o0oO._0o0_O. OrElse i < A_5 Then
					A_0.Append("</th>")
					GoTo IL_2B8
				End If
				A_0.Append("</td>")
				GoTo IL_2B8
			End While
			A_0.AppendLine("</tr>")
		End Sub

		' Token: 0x06001974 RID: 6516 RVA: 0x000A4E78 File Offset: 0x000A3078
		Private Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As wRowCollection) As Integer
			Dim num As Integer = 1
			Dim result As Integer
			If A_0 > 0 AndAlso A_2(A_0 - 1).o0oO._0o0_O..Count > A_1 AndAlso Me.OOooOo.00OO_.(A_2(A_0 - 1).o0oO._0o0_O.(A_1), Me.o0oO._0o0_O.(A_1)) Then
				result = -1
			Else
				Dim num2 As Integer = A_0 + 1
				Dim num3 As Integer = A_2.Count - 1
				Dim num4 As Integer = num2
				While num4 <= num3 AndAlso A_2(num4).o0oO._0o0_O..Count > A_1 AndAlso Me.OOooOo.00OO_.(A_2(num4).o0oO._0o0_O.(A_1), Me.o0oO._0o0_O.(A_1))
					num += 1
					num4 += 1
				End While
				result = num
			End If
			Return result
		End Function

		' Token: 0x06001975 RID: 6517 RVA: 0x000A4F28 File Offset: 0x000A3128
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Dim array As String() = A_0.Split(New Char() { vbVerticalTab })
			Dim array2 As String() = A_1.Split(New Char() { vbVerticalTab })
			Return Operators.CompareString(array(0), array2(0), True) = 0
		End Function

		' Token: 0x06001976 RID: 6518 RVA: 0x000A4F68 File Offset: 0x000A3168
		Private Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As wRowCollection, ByRef A_3 As Integer, ByRef A_4 As Integer)
			If A_0 > 0 AndAlso A_2(A_0 - 1).o0oO._0o0_O..Count > A_1 AndAlso Me.OOooOo.00OO_.(A_2(A_0 - 1).o0oO._0o0_O.(A_1), Me.o0oO._0o0_O.(A_1)) Then
				A_3 = -1
			End If
			If A_3 = 1 AndAlso A_1 > 0 AndAlso Operators.CompareString(Me.o0oO._0o0_O.(A_1), Me.o0oO._0o0_O.(A_1 - 1), True) = 0 Then
				Dim flag As Boolean = True
				Dim num As Integer = A_0 + 1
				Dim num2 As Integer = A_2.Count - 1
				Dim num3 As Integer = num
				While num3 <= num2 AndAlso A_2(num3).o0oO._0o0_O..Count > A_1
					If Me.OOooOo.00OO_.(A_2(num3).o0oO._0o0_O.(A_1 - 1), Me.o0oO._0o0_O.(A_1)) Xor Me.OOooOo.00OO_.(A_2(num3).o0oO._0o0_O.(A_1), Me.o0oO._0o0_O.(A_1)) Then
						flag = False
						Exit While
					End If
					If Not Me.OOooOo.00OO_.(A_2(num3).o0oO._0o0_O.(A_1 - 1), Me.o0oO._0o0_O.(A_1)) Then
						Exit While
					End If
					num3 += 1
				End While
				If flag Then
					A_4 = -1
				End If
			End If
			If A_3 = 1 AndAlso A_4 = 1 Then
				Dim num4 As Integer = A_0 + 1
				Dim num5 As Integer = A_2.Count - 1
				Dim num6 As Integer = num4
				While num6 <= num5 AndAlso A_2(num6).o0oO._0o0_O..Count > A_1 AndAlso Me.OOooOo.00OO_.(A_2(num6).o0oO._0o0_O.(A_1), Me.o0oO._0o0_O.(A_1))
					A_3 += 1
					num6 += 1
				End While
				Dim num7 As Integer = A_1 + 1
				Dim num8 As Integer = Me.o0oO._0o0_O..Count - 1
				For i As Integer = num7 To num8
					Dim flag2 As Boolean = True
					Dim num9 As Integer = A_0 + A_3 - 1
					For j As Integer = A_0 To num9
						If A_2(j).o0oO._0o0_O..Count <= i OrElse Not Me.OOooOo.00OO_.(A_2(j).o0oO._0o0_O.(i), Me.o0oO._0o0_O.(A_1)) Then
							flag2 = False
							Exit For
						End If
					Next
					If Not flag2 Then
						Exit For
					End If
					A_4 += 1
				Next
			End If
		End Sub

		' Token: 0x04000AB2 RID: 2738
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AB3 RID: 2739
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000AB4 RID: 2740
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AB5 RID: 2741
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AB6 RID: 2742
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
