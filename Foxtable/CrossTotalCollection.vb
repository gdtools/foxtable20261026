Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200027E RID: 638
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CrossTotalCollection
		Implements IEnumerable(Of CrossTotalOn)

		' Token: 0x06001EBE RID: 7870 RVA: 0x000C8285 File Offset: 0x000C6485
		Public Sub New()
			Me.O_oO_O_0.0_o. = New List(Of CrossTotalOn)()
			Me.O_oO_O_0.0_o. = New List(Of ExpressionTotal)()
		End Sub

		' Token: 0x06001EBF RID: 7871 RVA: 0x000C82A3 File Offset: 0x000C64A3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Add(item As CrossTotalOn)
			Me.O_oO_O_0.0_o..Add(item)
		End Sub

		' Token: 0x06001EC0 RID: 7872 RVA: 0x000C82B4 File Offset: 0x000C64B4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddDef(ParamArray args As Object())
			Select Case args.Length
				Case 1
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					If TypeOf objectValue Is String Then
						Dim name As String = Conversions.ToString(objectValue).Trim()
						Me.AddDef(name, False)
						Return
					End If
				Case 2
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(1))
					If TypeOf objectValue2 Is String AndAlso TypeOf objectValue3 Is Boolean Then
						Dim name2 As String = Conversions.ToString(objectValue2).Trim()
						Dim upto As Boolean = Conversions.ToBoolean(objectValue3)
						Me.AddDef(name2, upto)
						Return
					End If
					If TypeOf objectValue2 Is String AndAlso (TypeOf objectValue3 Is Integer OrElse TypeOf objectValue3 Is AggregateEnum) Then
						Dim name3 As String = Conversions.ToString(objectValue2).Trim()
						Dim aggregate As AggregateEnum = Conversions.ToInteger(objectValue3)
						Me.AddDef(name3, aggregate, False)
						Return
					End If
					If TypeOf objectValue2 Is String AndAlso TypeOf objectValue3 Is String Then
						Dim name4 As String = Conversions.ToString(objectValue2).Trim()
						Dim caption As String = Conversions.ToString(objectValue3).Trim()
						Me.AddDef(name4, caption, False)
						Return
					End If
				Case 3
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(args(2))
					If TypeOf objectValue4 Is String AndAlso (TypeOf objectValue5 Is Integer OrElse TypeOf objectValue5 Is AggregateEnum) AndAlso TypeOf objectValue6 Is Boolean Then
						Dim name5 As String = Conversions.ToString(objectValue4).Trim()
						Dim aggregate2 As AggregateEnum = Conversions.ToInteger(objectValue5)
						Dim upto2 As Boolean = Conversions.ToBoolean(objectValue6)
						Me.AddDef(name5, aggregate2, upto2)
						Return
					End If
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is String AndAlso TypeOf objectValue6 Is Boolean Then
						Dim name6 As String = Conversions.ToString(objectValue4).Trim()
						Dim caption2 As String = Conversions.ToString(objectValue5).Trim()
						Dim upto3 As Boolean = Conversions.ToBoolean(objectValue6)
						Me.AddDef(name6, caption2, upto3)
						Return
					End If
					If TypeOf objectValue4 Is String AndAlso (TypeOf objectValue5 Is Integer OrElse TypeOf objectValue5 Is AggregateEnum) AndAlso TypeOf objectValue6 Is String Then
						Dim name7 As String = Conversions.ToString(objectValue4).Trim()
						Dim aggregate3 As AggregateEnum = Conversions.ToInteger(objectValue5)
						Dim caption3 As String = Conversions.ToString(objectValue6).Trim()
						Me.AddDef(name7, aggregate3, caption3, False)
						Return
					End If
				Case 4
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(args(3))
					If TypeOf objectValue7 Is String AndAlso (TypeOf objectValue8 Is Integer OrElse TypeOf objectValue8 Is AggregateEnum) AndAlso TypeOf objectValue9 Is String AndAlso TypeOf objectValue10 Is Boolean Then
						Dim name8 As String = Conversions.ToString(objectValue7).Trim()
						Dim aggregate4 As AggregateEnum = Conversions.ToInteger(objectValue8)
						Dim caption4 As String = Conversions.ToString(objectValue9).Trim()
						Dim upto4 As Boolean = Conversions.ToBoolean(objectValue10)
						Me.AddDef(name8, aggregate4, caption4, upto4)
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001EC1 RID: 7873 RVA: 0x000C8573 File Offset: 0x000C6773
		Public Sub AddDef(Name As String, Optional upto As Boolean = False)
			Me.O_oO_O_0.0_o..Add(New CrossTotalOn(Name, upto))
		End Sub

		' Token: 0x06001EC2 RID: 7874 RVA: 0x000C8587 File Offset: 0x000C6787
		Public Sub AddDef(Name As String, Aggregate As AggregateEnum, Optional upto As Boolean = False)
			Me.O_oO_O_0.0_o..Add(New CrossTotalOn(Name, Aggregate, upto))
		End Sub

		' Token: 0x06001EC3 RID: 7875 RVA: 0x000C859C File Offset: 0x000C679C
		Public Sub AddDef(Name As String, Caption As String, Optional upto As Boolean = False)
			Me.O_oO_O_0.0_o..Add(New CrossTotalOn(Name, Caption, upto))
		End Sub

		' Token: 0x06001EC4 RID: 7876 RVA: 0x000C85B1 File Offset: 0x000C67B1
		Public Sub AddDef(Name As String, Aggregate As AggregateEnum, Caption As String, Optional upto As Boolean = False)
			Me.O_oO_O_0.0_o..Add(New CrossTotalOn(Name, Aggregate, Caption, upto))
		End Sub

		' Token: 0x06001EC5 RID: 7877 RVA: 0x000C85C8 File Offset: 0x000C67C8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddExp(ParamArray args As Object())
			Select Case args.Length
				Case 2
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(1))
					If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is String Then
						Dim name As String = Conversions.ToString(objectValue).Trim()
						Dim expression As String = Conversions.ToString(objectValue2).Trim()
						Me.AddExp(name, expression, False)
						Return
					End If
				Case 3
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(args(2))
					If TypeOf objectValue3 Is String AndAlso TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is Boolean Then
						Dim name2 As String = Conversions.ToString(objectValue3).Trim()
						Dim expression2 As String = Conversions.ToString(objectValue4).Trim()
						Dim upto As Boolean = Conversions.ToBoolean(objectValue5)
						Me.AddExp(name2, expression2, upto)
						Return
					End If
					If TypeOf objectValue3 Is String AndAlso TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is Integer Then
						Dim name3 As String = Conversions.ToString(objectValue3).Trim()
						Dim expression3 As String = Conversions.ToString(objectValue4).Trim()
						Dim aggregate As AggregateEnum = Conversions.ToInteger(objectValue5)
						Me.AddExp(name3, expression3, aggregate, False)
						Return
					End If
					If TypeOf objectValue3 Is String AndAlso TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is String Then
						Dim name4 As String = Conversions.ToString(objectValue3).Trim()
						Dim expression4 As String = Conversions.ToString(objectValue4).Trim()
						Dim caption As String = Conversions.ToString(objectValue5).Trim()
						Me.AddExp(name4, expression4, caption, False)
						Return
					End If
				Case 4
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(args(3))
					If TypeOf objectValue6 Is String AndAlso TypeOf objectValue7 Is String AndAlso TypeOf objectValue8 Is Integer AndAlso TypeOf objectValue9 Is Boolean Then
						Dim name5 As String = Conversions.ToString(objectValue6).Trim()
						Dim expression5 As String = Conversions.ToString(objectValue7).Trim()
						Dim aggregate2 As AggregateEnum = Conversions.ToInteger(objectValue8)
						Dim upto2 As Boolean = Conversions.ToBoolean(objectValue9)
						Me.AddExp(name5, expression5, aggregate2, upto2)
						Return
					End If
					If TypeOf objectValue6 Is String AndAlso TypeOf objectValue7 Is String AndAlso TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is Boolean Then
						Dim name6 As String = Conversions.ToString(objectValue6).Trim()
						Dim expression6 As String = Conversions.ToString(objectValue7).Trim()
						Dim caption2 As String = Conversions.ToString(objectValue8).Trim()
						Dim upto3 As Boolean = Conversions.ToBoolean(objectValue9)
						Me.AddExp(name6, expression6, caption2, upto3)
						Return
					End If
					If TypeOf objectValue6 Is String AndAlso TypeOf objectValue7 Is String AndAlso TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is Integer Then
						Dim name7 As String = Conversions.ToString(objectValue6).Trim()
						Dim expression7 As String = Conversions.ToString(objectValue7).Trim()
						Dim caption3 As String = Conversions.ToString(objectValue8).Trim()
						Dim aggregate3 As AggregateEnum = Conversions.ToInteger(objectValue9)
						Me.AddExp(name7, expression7, caption3, aggregate3, False)
						Return
					End If
				Case 5
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(args(3))
					Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(args(4))
					If TypeOf objectValue10 Is String AndAlso TypeOf objectValue11 Is String AndAlso TypeOf objectValue12 Is String AndAlso TypeOf objectValue13 Is Integer AndAlso TypeOf objectValue14 Is Boolean Then
						Dim name8 As String = Conversions.ToString(objectValue10).Trim()
						Dim expression8 As String = Conversions.ToString(objectValue11).Trim()
						Dim caption4 As String = Conversions.ToString(objectValue12).Trim()
						Dim aggregate4 As AggregateEnum = Conversions.ToInteger(objectValue13)
						Dim upto4 As Boolean = Conversions.ToBoolean(objectValue14)
						Me.AddExp(name8, expression8, caption4, aggregate4, upto4)
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001EC6 RID: 7878 RVA: 0x000C8960 File Offset: 0x000C6B60
		Public Sub AddExp(Name As String, Expression As String, Optional upto As Boolean = False)
			Me.AddExp(Name, Expression, "", 2, upto)
		End Sub

		' Token: 0x06001EC7 RID: 7879 RVA: 0x000C8971 File Offset: 0x000C6B71
		Public Sub AddExp(Name As String, Expression As String, Aggregate As AggregateEnum, Optional upto As Boolean = False)
			Me.AddExp(Name, Expression, "", Aggregate, upto)
		End Sub

		' Token: 0x06001EC8 RID: 7880 RVA: 0x000C8983 File Offset: 0x000C6B83
		Public Sub AddExp(Name As String, Expression As String, Caption As String, Optional upto As Boolean = False)
			Me.AddExp(Name, Expression, Caption, 2, upto)
		End Sub

		' Token: 0x06001EC9 RID: 7881 RVA: 0x000C8994 File Offset: 0x000C6B94
		Public Sub AddExp(Name As String, Expression As String, Caption As String, Aggregate As AggregateEnum, Optional upto As Boolean = False)
			Dim expressionTotal As ExpressionTotal = New ExpressionTotal()
			expressionTotal.Name = Name
			expressionTotal.Expression = Expression
			expressionTotal.Caption = Caption
			expressionTotal.Aggregate = Aggregate
			expressionTotal.upto = upto
			Me.Exprs.Add(expressionTotal)
		End Sub

		' Token: 0x06001ECA RID: 7882 RVA: 0x000C89D8 File Offset: 0x000C6BD8
		Public Function GetEnumerator() As IEnumerator(Of CrossTotalOn) Implements System.Collections.Generic.IEnumerable(Of Foxtable.CrossTotalOn).GetEnumerator
			Return CType(Me.O_oO_O_0.0_o..GetEnumerator(), IEnumerator(Of CrossTotalOn))
		End Function

		' Token: 0x06001ECB RID: 7883 RVA: 0x000C89EF File Offset: 0x000C6BEF
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.GetEnumerator()
		End Function

		' Token: 0x170006E5 RID: 1765
		' (get) Token: 0x06001ECC RID: 7884 RVA: 0x000C89F7 File Offset: 0x000C6BF7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Exprs As List(Of ExpressionTotal)
			Get
				Return Me.O_oO_O_0.0_o.
			End Get
		End Property

		' Token: 0x170006E6 RID: 1766
		' (get) Token: 0x06001ECD RID: 7885 RVA: 0x000C89FF File Offset: 0x000C6BFF
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O_oO_O_0.0_o..Count
			End Get
		End Property

		' Token: 0x170006E7 RID: 1767
		Public ReadOnly Default Property Item(A_0 As Integer) As CrossTotalOn
			Get
				Return Me.O_oO_O_0.0_o.(A_0)
			End Get
		End Property

		' Token: 0x06001ECF RID: 7887 RVA: 0x000C8A1A File Offset: 0x000C6C1A
		Public Sub RemoveAt(index As Integer)
			Me.O_oO_O_0.0_o..RemoveAt(index)
		End Sub

		' Token: 0x06001ED0 RID: 7888 RVA: 0x000C8A28 File Offset: 0x000C6C28
		Public Sub Remove(item As CrossTotalOn)
			Me.O_oO_O_0.0_o..Remove(item)
		End Sub

		' Token: 0x06001ED1 RID: 7889 RVA: 0x000C8A37 File Offset: 0x000C6C37
		Public Sub AddRange(items As IEnumerable(Of CrossTotalOn))
			Me.O_oO_O_0.0_o..AddRange(items)
		End Sub

		' Token: 0x04000CE0 RID: 3296
		Private <<EMPTY_NAME>> As List(Of CrossTotalOn)

		' Token: 0x04000CE1 RID: 3297
		Private <<EMPTY_NAME>> As List(Of ExpressionTotal)
	End Class
End Namespace
