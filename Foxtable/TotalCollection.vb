Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200028E RID: 654
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class TotalCollection
		Implements IEnumerable(Of TotalOn)

		' Token: 0x06001FFA RID: 8186 RVA: 0x000D51AF File Offset: 0x000D33AF
		Public Sub New()
			Me.O__.o__. = New List(Of TotalOn)()
			Me.O__.o__. = New List(Of ExpressionTotal)()
		End Sub

		' Token: 0x06001FFB RID: 8187 RVA: 0x000D51CD File Offset: 0x000D33CD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Add(Item As TotalOn)
			Me.O__.o__..Add(Item)
		End Sub

		' Token: 0x06001FFC RID: 8188 RVA: 0x000D51DC File Offset: 0x000D33DC
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
					If TypeOf objectValue2 Is String AndAlso TypeOf objectValue3 Is String Then
						Dim name3 As String = Conversions.ToString(objectValue2).Trim()
						Dim newName As String = Conversions.ToString(objectValue3).Trim()
						Me.AddDef(name3, newName, False)
						Return
					End If
					If TypeOf objectValue2 Is String AndAlso (TypeOf objectValue3 Is Integer OrElse TypeOf objectValue3 Is AggregateEnum) Then
						Dim name4 As String = Conversions.ToString(objectValue2).Trim()
						Dim aggregate As AggregateEnum = Conversions.ToInteger(objectValue3)
						Me.AddDef(name4, aggregate, False)
						Return
					End If
				Case 3
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(args(2))
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is String AndAlso TypeOf objectValue6 Is Boolean Then
						Dim name5 As String = Conversions.ToString(objectValue4).Trim()
						Dim newName2 As String = Conversions.ToString(objectValue5).Trim()
						Dim upto2 As Boolean = Conversions.ToBoolean(objectValue6)
						Me.AddDef(name5, newName2, upto2)
						Return
					End If
					If TypeOf objectValue4 Is String AndAlso (TypeOf objectValue5 Is Integer OrElse TypeOf objectValue5 Is AggregateEnum) AndAlso TypeOf objectValue6 Is Boolean Then
						Dim name6 As String = Conversions.ToString(objectValue4).Trim()
						Dim aggregate2 As AggregateEnum = Conversions.ToInteger(objectValue5)
						Dim upto3 As Boolean = Conversions.ToBoolean(objectValue6)
						Me.AddDef(name6, aggregate2, upto3)
						Return
					End If
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is String AndAlso TypeOf objectValue6 Is String Then
						Dim name7 As String = Conversions.ToString(objectValue4).Trim()
						Dim newName3 As String = Conversions.ToString(objectValue5).Trim()
						Dim newCaption As String = Conversions.ToString(objectValue6).Trim()
						Me.AddDef(name7, newName3, newCaption, False)
						Return
					End If
					If TypeOf objectValue4 Is String AndAlso (TypeOf objectValue5 Is Integer OrElse TypeOf objectValue5 Is AggregateEnum) AndAlso TypeOf objectValue6 Is String Then
						Dim name8 As String = Conversions.ToString(objectValue4).Trim()
						Dim aggregate3 As AggregateEnum = Conversions.ToInteger(objectValue5)
						Dim newName4 As String = Conversions.ToString(objectValue6).Trim()
						Me.AddDef(name8, aggregate3, newName4, False)
						Return
					End If
				Case 4
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(args(3))
					If TypeOf objectValue7 Is String AndAlso TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is String AndAlso TypeOf objectValue10 Is Boolean Then
						Dim name9 As String = Conversions.ToString(objectValue7).Trim()
						Dim newName5 As String = Conversions.ToString(objectValue8).Trim()
						Dim newCaption2 As String = Conversions.ToString(objectValue9).Trim()
						Dim upto4 As Boolean = Conversions.ToBoolean(objectValue10)
						Me.AddDef(name9, newName5, newCaption2, upto4)
						Return
					End If
					If TypeOf objectValue7 Is String AndAlso (TypeOf objectValue8 Is Integer OrElse TypeOf objectValue8 Is AggregateEnum) AndAlso TypeOf objectValue9 Is String AndAlso TypeOf objectValue10 Is Boolean Then
						Dim name10 As String = Conversions.ToString(objectValue7).Trim()
						Dim aggregate4 As AggregateEnum = Conversions.ToInteger(objectValue8)
						Dim newName6 As String = Conversions.ToString(objectValue9).Trim()
						Dim upto5 As Boolean = Conversions.ToBoolean(objectValue10)
						Me.AddDef(name10, aggregate4, newName6, upto5)
						Return
					End If
					If TypeOf objectValue7 Is String AndAlso (TypeOf objectValue8 Is Integer OrElse TypeOf objectValue8 Is AggregateEnum) AndAlso TypeOf objectValue9 Is String AndAlso TypeOf objectValue10 Is String Then
						Dim name11 As String = Conversions.ToString(objectValue7).Trim()
						Dim aggregate5 As AggregateEnum = Conversions.ToInteger(objectValue8)
						Dim newName7 As String = Conversions.ToString(objectValue9).Trim()
						Dim newCaption3 As String = Conversions.ToString(objectValue10).Trim()
						Me.AddDef(name11, aggregate5, newName7, newCaption3, False)
						Return
					End If
				Case 5
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(args(3))
					Dim objectValue15 As Object = RuntimeHelpers.GetObjectValue(args(4))
					If TypeOf objectValue11 Is String AndAlso (TypeOf objectValue12 Is Integer OrElse TypeOf objectValue12 Is AggregateEnum) AndAlso TypeOf objectValue13 Is String AndAlso TypeOf objectValue14 Is String AndAlso TypeOf objectValue15 Is Boolean Then
						Dim name12 As String = Conversions.ToString(objectValue11).Trim()
						Dim aggregate6 As AggregateEnum = Conversions.ToInteger(objectValue12)
						Dim newName8 As String = Conversions.ToString(objectValue13).Trim()
						Dim newCaption4 As String = Conversions.ToString(objectValue14).Trim()
						Dim upto6 As Boolean = Conversions.ToBoolean(objectValue15)
						Me.AddDef(name12, aggregate6, newName8, newCaption4, upto6)
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001FFD RID: 8189 RVA: 0x000D568C File Offset: 0x000D388C
		Public Sub AddDef(Name As String, Optional upto As Boolean = False)
			Dim totalOn As TotalOn = New TotalOn(Name)
			totalOn.upto = upto
			Me.O__.o__..Add(totalOn)
		End Sub

		' Token: 0x06001FFE RID: 8190 RVA: 0x000D56B4 File Offset: 0x000D38B4
		Public Sub AddDef(Name As String, NewName As String, Optional upto As Boolean = False)
			Dim totalOn As TotalOn = New TotalOn(Name, NewName)
			totalOn.upto = upto
			Me.O__.o__..Add(totalOn)
		End Sub

		' Token: 0x06001FFF RID: 8191 RVA: 0x000D56DC File Offset: 0x000D38DC
		Public Sub AddDef(Name As String, NewName As String, NewCaption As String, Optional upto As Boolean = False)
			Dim totalOn As TotalOn = New TotalOn(Name, NewName, NewCaption)
			totalOn.upto = upto
			Me.O__.o__..Add(totalOn)
		End Sub

		' Token: 0x06002000 RID: 8192 RVA: 0x000D5708 File Offset: 0x000D3908
		Public Sub AddDef(Name As String, Aggregate As AggregateEnum, Optional upto As Boolean = False)
			Dim totalOn As TotalOn = New TotalOn(Name, Aggregate)
			totalOn.upto = upto
			Me.O__.o__..Add(totalOn)
		End Sub

		' Token: 0x06002001 RID: 8193 RVA: 0x000D5730 File Offset: 0x000D3930
		Public Sub AddDef(Name As String, Aggregate As AggregateEnum, NewName As String, Optional upto As Boolean = False)
			Dim totalOn As TotalOn = New TotalOn(Name, Aggregate, NewName)
			totalOn.upto = upto
			Me.O__.o__..Add(totalOn)
		End Sub

		' Token: 0x06002002 RID: 8194 RVA: 0x000D575C File Offset: 0x000D395C
		Public Sub AddDef(Name As String, Aggregate As AggregateEnum, NewName As String, NewCaption As String, Optional upto As Boolean = False)
			Dim totalOn As TotalOn = New TotalOn(Name, Aggregate, NewName, NewCaption)
			totalOn.upto = upto
			Me.O__.o__..Add(totalOn)
		End Sub

		' Token: 0x06002003 RID: 8195 RVA: 0x000D5788 File Offset: 0x000D3988
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
					If TypeOf objectValue3 Is String AndAlso TypeOf objectValue4 Is String Then
						If TypeOf objectValue5 Is Boolean Then
							Dim name2 As String = Conversions.ToString(objectValue3).Trim()
							Dim expression2 As String = Conversions.ToString(objectValue4).Trim()
							Dim upto As Boolean = Conversions.ToBoolean(objectValue5)
							Me.AddExp(name2, expression2, upto)
							Return
						End If
						If TypeOf objectValue5 Is String Then
							Dim name3 As String = Conversions.ToString(objectValue3).Trim()
							Dim expression3 As String = Conversions.ToString(objectValue4).Trim()
							Dim caption As String = Conversions.ToString(objectValue5).Trim()
							Me.AddExp(name3, expression3, caption, False)
							Return
						End If
						If TypeOf objectValue5 Is Integer Then
							Dim name4 As String = Conversions.ToString(objectValue3).Trim()
							Dim expression4 As String = Conversions.ToString(objectValue4).Trim()
							Dim aggregate As AggregateEnum = Conversions.ToInteger(objectValue5)
							Me.AddExp(name4, expression4, aggregate, False)
							Return
						End If
					End If
				Case 4
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(args(3))
					If TypeOf objectValue6 Is String AndAlso TypeOf objectValue7 Is String Then
						If TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is Boolean Then
							Dim name5 As String = Conversions.ToString(objectValue6).Trim()
							Dim expression5 As String = Conversions.ToString(objectValue7).Trim()
							Dim caption2 As String = Conversions.ToString(objectValue8).Trim()
							Dim upto2 As Boolean = Conversions.ToBoolean(objectValue9)
							Me.AddExp(name5, expression5, caption2, upto2)
							Return
						End If
						If TypeOf objectValue8 Is Integer AndAlso TypeOf objectValue9 Is Boolean Then
							Dim name6 As String = Conversions.ToString(objectValue6).Trim()
							Dim expression6 As String = Conversions.ToString(objectValue7).Trim()
							Dim aggregate2 As AggregateEnum = Conversions.ToInteger(objectValue8)
							Dim upto3 As Boolean = Conversions.ToBoolean(objectValue9)
							Me.AddExp(name6, expression6, aggregate2, upto3)
							Return
						End If
						If TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is Integer Then
							Dim name7 As String = Conversions.ToString(objectValue6).Trim()
							Dim expression7 As String = Conversions.ToString(objectValue7).Trim()
							Dim caption3 As String = Conversions.ToString(objectValue8).Trim()
							Dim aggregate3 As AggregateEnum = Conversions.ToInteger(objectValue9)
							Me.AddExp(name7, expression7, caption3, aggregate3, False)
							Return
						End If
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

		' Token: 0x06002004 RID: 8196 RVA: 0x000D5AD8 File Offset: 0x000D3CD8
		Public Sub AddExp(Name As String, Expression As String, Optional upto As Boolean = False)
			Me.AddExp(Name, Expression, "", 2, upto)
		End Sub

		' Token: 0x06002005 RID: 8197 RVA: 0x000D5AE9 File Offset: 0x000D3CE9
		Public Sub AddExp(Name As String, Expression As String, Aggregate As AggregateEnum, Optional upto As Boolean = False)
			Me.AddExp(Name, Expression, "", Aggregate, upto)
		End Sub

		' Token: 0x06002006 RID: 8198 RVA: 0x000D5AFB File Offset: 0x000D3CFB
		Public Sub AddExp(Name As String, Expression As String, Caption As String, Optional upto As Boolean = False)
			Me.AddExp(Name, Expression, Caption, 2, upto)
		End Sub

		' Token: 0x06002007 RID: 8199 RVA: 0x000D5B0C File Offset: 0x000D3D0C
		Public Sub AddExp(Name As String, Expression As String, Caption As String, Aggregate As AggregateEnum, Optional upto As Boolean = False)
			Dim expressionTotal As ExpressionTotal = New ExpressionTotal()
			expressionTotal.Name = Name
			expressionTotal.Expression = Expression
			expressionTotal.Caption = Caption
			expressionTotal.Aggregate = Aggregate
			expressionTotal.upto = upto
			Me.Exprs.Add(expressionTotal)
		End Sub

		' Token: 0x06002008 RID: 8200 RVA: 0x000D5B50 File Offset: 0x000D3D50
		Public Function GetEnumerator() As IEnumerator(Of TotalOn) Implements System.Collections.Generic.IEnumerable(Of Foxtable.TotalOn).GetEnumerator
			Return CType(Me.O__.o__..GetEnumerator(), IEnumerator(Of TotalOn))
		End Function

		' Token: 0x06002009 RID: 8201 RVA: 0x000D5B67 File Offset: 0x000D3D67
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.GetEnumerator()
		End Function

		' Token: 0x1700073F RID: 1855
		' (get) Token: 0x0600200A RID: 8202 RVA: 0x000D5B6F File Offset: 0x000D3D6F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Exprs As List(Of ExpressionTotal)
			Get
				Return Me.O__.o__.
			End Get
		End Property

		' Token: 0x17000740 RID: 1856
		' (get) Token: 0x0600200B RID: 8203 RVA: 0x000D5B77 File Offset: 0x000D3D77
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O__.o__..Count
			End Get
		End Property

		' Token: 0x17000741 RID: 1857
		Public ReadOnly Default Property Item(A_0 As Integer) As TotalOn
			Get
				Return Me.O__.o__.(A_0)
			End Get
		End Property

		' Token: 0x0600200D RID: 8205 RVA: 0x000D5B92 File Offset: 0x000D3D92
		Public Sub RemoveAt(index As Integer)
			Me.O__.o__..RemoveAt(index)
		End Sub

		' Token: 0x0600200E RID: 8206 RVA: 0x000D5BA0 File Offset: 0x000D3DA0
		Public Sub AddRange(items As IEnumerable(Of TotalOn))
			Me.O__.o__..AddRange(items)
		End Sub

		' Token: 0x04000D48 RID: 3400
		Private <<EMPTY_NAME>> As List(Of TotalOn)

		' Token: 0x04000D49 RID: 3401
		Private <<EMPTY_NAME>> As List(Of ExpressionTotal)
	End Class
End Namespace
