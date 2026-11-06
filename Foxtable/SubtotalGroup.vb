Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000099 RID: 153
	<oO0oooo("1372")>
	<ComVisible(True)>
	Public Class SubtotalGroup
		' Token: 0x060005A1 RID: 1441 RVA: 0x0001D66B File Offset: 0x0001B86B
		Public Sub New()
			Me.oO0O_0.ooo00. = ""
			Me.oOo0.0_. = ""
			Me.O_oo.0oOO. = 2
			Me.O_oo.0oOO. = 3
		End Sub

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001D697 File Offset: 0x0001B897
		' (set) Token: 0x060005A3 RID: 1443 RVA: 0x0001D69F File Offset: 0x0001B89F
		Public Property GroupOn As String
			Get
				Return Me.oO0O_0.ooo00.
			End Get
			Set(value As String)
				Me.oO0O_0.ooo00. = value
			End Set
		End Property

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001D6A8 File Offset: 0x0001B8A8
		' (set) Token: 0x060005A5 RID: 1445 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
		Public Property TotalOn As String
			Get
				Return Me.oOo0.0_.
			End Get
			Set(value As String)
				Me.oOo0.0_. = value
			End Set
		End Property

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		' (set) Token: 0x060005A7 RID: 1447 RVA: 0x0001D6F1 File Offset: 0x0001B8F1
		<oO0oooo("3292")>
		Public Property Aggregate As AggregateEnum
			Get
				Dim result As AggregateEnum
				If [Enum].IsDefined(GetType(AggregateEnum), Me.O_oo.0oOO.) Then
					result = Me.O_oo.0oOO.
				Else
					result = 2
				End If
				Return result
			End Get
			Set(value As AggregateEnum)
				Me.O_oo.0oOO. = value
			End Set
		End Property

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001D6FA File Offset: 0x0001B8FA
		' (set) Token: 0x060005A9 RID: 1449 RVA: 0x0001D702 File Offset: 0x0001B902
		<oO0oooo("3296")>
		Public Property Caption As String
			Get
				Return Me.o.O_0_00__0.
			End Get
			Set(value As String)
				Me.o.O_0_00__0. = value
			End Set
		End Property

		' Token: 0x060005AA RID: 1450 RVA: 0x0001D70C File Offset: 0x0001B90C
		Friend Function <<EMPTY_NAME>>(A_0 As Table) As String
			Dim text As String = ""
			Dim text2 As String = ""
			Select Case Me.Aggregate
				Case 2, 3, 4
					If Me.upto Then
						text = "累计"
					Else
						text = "小计"
					End If
					text2 = "总计"
				Case 6
					text = "平均"
					text2 = "平均"
				Case 7
					text = "最大"
					text2 = "最大"
				Case 8
					text = "最小"
					text2 = "最小"
				Case 9
					text = "标准偏差"
					text2 = "标准偏差"
				Case 10
					text = "采样方差"
					text2 = "采样方差"
				Case 11
					text = "总体标准差"
					text2 = "总体标准差"
				Case 12
					text = "总体方差"
					text2 = "总体方差"
			End Select
			If Operators.CompareString(Me.GroupOn, "*", True) <> 0 AndAlso A_0.Cols(Me.GroupOn).IsDate() Then
				Select Case Me.DateGroup
					Case 1
						text = "{0}年 " + text
					Case 2
						text = "{0}季 " + text
					Case 3
						text = "{0}月 " + text
					Case 4
						text = "{0}周 " + text
					Case 5
						text = "{0}日 " + text
					Case 6
						text = "{0}时 " + text
					Case 7
						text = "{0}分 " + text
					Case 8
						text = "{0}秒 " + text
					Case Else
						text = "{0} " + text
				End Select
			Else
				text = "{0} " + text
			End If
			Dim result As String
			If Operators.CompareString(Me.GroupOn, "*", True) = 0 Then
				result = text2
			Else
				result = text
			End If
			Return result
		End Function

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x060005AB RID: 1451 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
		' (set) Token: 0x060005AC RID: 1452 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
		<oO0oooo("3291")>
		Public Property DateGroup As DateGroupEnum
			Get
				Return Me.O_oo.0oOO.
			End Get
			Set(value As DateGroupEnum)
				Me.O_oo.0oOO. = value
			End Set
		End Property

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x060005AD RID: 1453 RVA: 0x0001D8F9 File Offset: 0x0001BAF9
		' (set) Token: 0x060005AE RID: 1454 RVA: 0x0001D901 File Offset: 0x0001BB01
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Level As Integer
			Get
				Return Me.oO0O_0.ooo00.
			End Get
			Set(value As Integer)
				Me.oO0O_0.ooo00. = value
			End Set
		End Property

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x060005AF RID: 1455 RVA: 0x0001D90A File Offset: 0x0001BB0A
		' (set) Token: 0x060005B0 RID: 1456 RVA: 0x0001D912 File Offset: 0x0001BB12
		<oO0oooo("3293")>
		Public Property upto As Boolean
			Get
				Return Me.oO0O_0.ooo00.
			End Get
			Set(value As Boolean)
				Me.oO0O_0.ooo00. = value
			End Set
		End Property

		' Token: 0x04000150 RID: 336
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000151 RID: 337
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000152 RID: 338
		Private <<EMPTY_NAME>> As AggregateEnum

		' Token: 0x04000153 RID: 339
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000154 RID: 340
		Private <<EMPTY_NAME>> As DateGroupEnum

		' Token: 0x04000155 RID: 341
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000156 RID: 342
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000157 RID: 343
		Friend <<EMPTY_NAME>> As Integer
	End Class
End Namespace
