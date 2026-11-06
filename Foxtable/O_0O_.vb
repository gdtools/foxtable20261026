Imports System
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000275 RID: 629
	Friend Class O_0O_
		' Token: 0x06001E38 RID: 7736 RVA: 0x000C0AD1 File Offset: 0x000BECD1
		Friend Sub New(A_0 As DataRow)
			Me.oooO__O_0o_.o_. = A_0
			Me.oooO__O_0o_.o_. = New OOOO(A_0)
		End Sub

		' Token: 0x06001E39 RID: 7737 RVA: 0x000C0AEC File Offset: 0x000BECEC
		Friend Function <<EMPTY_NAME>>() As OOOO
			Return Me.oooO__O_0o_.o_.
		End Function

		' Token: 0x170006BF RID: 1727
		' (get) Token: 0x06001E3A RID: 7738 RVA: 0x000C0AF4 File Offset: 0x000BECF4
		' (set) Token: 0x06001E3B RID: 7739 RVA: 0x000C0B0C File Offset: 0x000BED0C
		Friend Property Name As String
			Get
				Return Conversions.ToString(Me.oooO__O_0o_.o_.("TableName"))
			End Get
			Set(value As String)
				If o_O_o_oOoo__.O_o_._o0.(value) Then
					For Each dataRow As DataRow In Me.oooO__O_0o_.o_..Table.[Select]("", "", DataViewRowState.CurrentRows)
						If dataRow IsNot Me.oooO__O_0o_.o_. AndAlso Operators.CompareString(Conversions.ToString(Me.oooO__O_0o_.o_.("TableName")), Conversions.ToString(dataRow("TableName")), True) = 0 Then
							MessageBox.Show("表[" + value + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
					Next
					Me.oooO__O_0o_.o_.("TableName") = value
				End If
			End Set
		End Property

		' Token: 0x06001E3C RID: 7740 RVA: 0x000C0BB9 File Offset: 0x000BEDB9
		Friend Function <<EMPTY_NAME>>() As String
			Return Conversions.ToString(Me.oooO__O_0o_.o_.("TableCaption"))
		End Function

		' Token: 0x06001E3D RID: 7741 RVA: 0x000C0BD0 File Offset: 0x000BEDD0
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.oooO__O_0o_.o_.("TableCaption") = A_0
		End Sub

		' Token: 0x04000CA5 RID: 3237
		Private <<EMPTY_NAME>> As OOOO

		' Token: 0x04000CA6 RID: 3238
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
