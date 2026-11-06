Imports System
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000272 RID: 626
	Friend Class o_0OO0_
		' Token: 0x06001E1D RID: 7709 RVA: 0x000C0511 File Offset: 0x000BE711
		Friend Sub New(A_0 As DataRow)
			Me.O_o0.Oo00o0. = A_0
		End Sub

		' Token: 0x170006BE RID: 1726
		' (get) Token: 0x06001E1E RID: 7710 RVA: 0x000C0520 File Offset: 0x000BE720
		' (set) Token: 0x06001E1F RID: 7711 RVA: 0x000C0538 File Offset: 0x000BE738
		Friend Property Name As String
			Get
				Return Conversions.ToString(Me.O_o0.Oo00o0.("ColumnName"))
			End Get
			Set(value As String)
				value = value.Replace("＿", "_")
				If o_O_o_oOoo__.OO_.O.(value) Then
					For Each dataRow As DataRow In Me.O_o0.Oo00o0..Table.[Select]("TableName = '" + Conversions.ToString(Me.O_o0.Oo00o0.("TableName")) + "'")
						If dataRow IsNot Me.O_o0.Oo00o0. AndAlso Operators.CompareString(Conversions.ToString(Me.O_o0.Oo00o0.("ColumnName")), Conversions.ToString(dataRow("ColumnName")), True) = 0 Then
							MessageBox.Show("列[" + value + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
					Next
					Me.O_o0.Oo00o0.("ColumnName") = value
				End If
			End Set
		End Property

		' Token: 0x06001E20 RID: 7712 RVA: 0x000C0610 File Offset: 0x000BE810
		Friend Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Me.O_o0.Oo00o0..IsNull("Caption") Then
				result = ""
			Else
				result = Conversions.ToString(Me.O_o0.Oo00o0.("Caption"))
			End If
			Return result
		End Function

		' Token: 0x06001E21 RID: 7713 RVA: 0x000C064E File Offset: 0x000BE84E
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O_o0.Oo00o0.("Caption") = A_0
		End Sub

		' Token: 0x06001E22 RID: 7714 RVA: 0x000C0661 File Offset: 0x000BE861
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Conversions.ToInteger(Me.O_o0.Oo00o0.("MaxLength"))
		End Function

		' Token: 0x06001E23 RID: 7715 RVA: 0x000C0678 File Offset: 0x000BE878
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			If o_0OO0_.O_o0.Oo00o0.(A_0) Then
				Me.O_o0.Oo00o0.("Maxlength") = A_0
			End If
		End Sub

		' Token: 0x06001E24 RID: 7716 RVA: 0x000C0698 File Offset: 0x000BE898
		Friend Function <<EMPTY_NAME>>() As ColumnDataTypeEnum
			Return CType(Conversions.ToInteger(Me.O_o0.Oo00o0.("DataType")), ColumnDataTypeEnum)
		End Function

		' Token: 0x06001E25 RID: 7717 RVA: 0x000C06AF File Offset: 0x000BE8AF
		Friend Sub <<EMPTY_NAME>>(A_0 As ColumnDataTypeEnum)
			Me.O_o0.Oo00o0.("DataType") = A_0
		End Sub

		' Token: 0x06001E26 RID: 7718 RVA: 0x000C06C8 File Offset: 0x000BE8C8
		Friend Shared Function <<EMPTY_NAME>>(A_0 As Integer) As Boolean
			Dim result As Boolean
			If A_0 > 255 Then
				MessageBox.Show("字符列长度不能超过255！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			ElseIf A_0 < 1 Then
				MessageBox.Show("字符列长度不能小于1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x04000CA0 RID: 3232
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
