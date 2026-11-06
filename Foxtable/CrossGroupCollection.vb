Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200027B RID: 635
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CrossGroupCollection
		Implements IEnumerable(Of CrossGroupOn)

		' Token: 0x06001E60 RID: 7776 RVA: 0x000C28D8 File Offset: 0x000C0AD8
		Public Sub New()
			Me.OOOOO_0._o0O0o. = New List(Of CrossGroupOn)()
			Me.OOOOO_0._o0O0o. = New List(Of CrossExpressionGroup)()
		End Sub

		' Token: 0x06001E61 RID: 7777 RVA: 0x000C28F6 File Offset: 0x000C0AF6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Add(item As CrossGroupOn)
			Me.OOOOO_0._o0O0o..Add(item)
		End Sub

		' Token: 0x06001E62 RID: 7778 RVA: 0x000C2904 File Offset: 0x000C0B04
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddDef(ParamArray args As Object())
			Select Case args.Length
				Case 1
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					If TypeOf objectValue Is String Then
						Dim name As String = Conversions.ToString(objectValue).Trim()
						Me.AddDef(name)
						Return
					End If
				Case 2
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(1))
					If TypeOf objectValue2 Is String Then
						If TypeOf objectValue3 Is String Then
							Dim name2 As String = Conversions.ToString(objectValue2).Trim()
							Dim pattern As String = Conversions.ToString(objectValue3).Trim()
							Me.AddDef(name2, pattern)
							Return
						End If
						If TypeOf objectValue3 Is Integer OrElse TypeOf objectValue3 Is DateGroupEnum Then
							Dim name3 As String = Conversions.ToString(objectValue2).Trim()
							Dim dateGroup As DateGroupEnum = Conversions.ToInteger(objectValue3)
							Me.AddDef(name3, dateGroup)
							Return
						End If
					End If
				Case 3
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(args(2))
					If TypeOf objectValue4 Is String AndAlso (TypeOf objectValue5 Is Integer OrElse TypeOf objectValue5 Is DateGroupEnum) AndAlso TypeOf objectValue6 Is String Then
						Dim name4 As String = Conversions.ToString(objectValue4).Trim()
						Dim dateGroup2 As DateGroupEnum = Conversions.ToInteger(objectValue5)
						Dim pattern2 As String = Conversions.ToString(objectValue6).Trim()
						Me.AddDef(name4, dateGroup2, pattern2)
					End If
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001E63 RID: 7779 RVA: 0x000C2A48 File Offset: 0x000C0C48
		Public Sub AddDef(Name As String)
			Me.OOOOO_0._o0O0o..Add(New CrossGroupOn(Name))
		End Sub

		' Token: 0x06001E64 RID: 7780 RVA: 0x000C2A5B File Offset: 0x000C0C5B
		Public Sub AddDef(Name As String, Pattern As String)
			Me.OOOOO_0._o0O0o..Add(New CrossGroupOn(Name, Pattern))
		End Sub

		' Token: 0x06001E65 RID: 7781 RVA: 0x000C2A6F File Offset: 0x000C0C6F
		Public Sub AddDef(Name As String, DateGroup As DateGroupEnum)
			Me.OOOOO_0._o0O0o..Add(New CrossGroupOn(Name, DateGroup))
		End Sub

		' Token: 0x06001E66 RID: 7782 RVA: 0x000C2A83 File Offset: 0x000C0C83
		Public Sub AddDef(Name As String, DateGroup As DateGroupEnum, Pattern As String)
			Me.OOOOO_0._o0O0o..Add(New CrossGroupOn(Name, DateGroup, Pattern))
		End Sub

		' Token: 0x06001E67 RID: 7783 RVA: 0x000C2A98 File Offset: 0x000C0C98
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddExp(ParamArray args As Object())
			Dim array As String() = New String(args.Length - 1 + 1 - 1) {}
			Dim num As Integer = args.Length - 1
			For i As Integer = 0 To num
				array(i) = Conversions.ToString(args(i)).Trim()
			Next
			Dim num2 As Integer = array.Length
			If num2 = 2 Then
				Dim name As String = array(0)
				Dim expression As String = array(1)
				Me.AddExp(name, expression)
				Return
			End If
			If num2 <> 3 Then
				Return
			End If
			Dim name2 As String = array(0)
			Dim expression2 As String = array(1)
			Dim pattern As String = array(2)
			Me.AddExp(name2, expression2, pattern)
		End Sub

		' Token: 0x06001E68 RID: 7784 RVA: 0x000C2B11 File Offset: 0x000C0D11
		Public Sub AddExp(Name As String, Expression As String)
			Me.Exprs.Add(New CrossExpressionGroup(Name, Expression, ""))
		End Sub

		' Token: 0x06001E69 RID: 7785 RVA: 0x000C2B2A File Offset: 0x000C0D2A
		Public Sub AddExp(Name As String, Expression As String, Pattern As String)
			Me.Exprs.Add(New CrossExpressionGroup(Name, Expression, Pattern))
		End Sub

		' Token: 0x06001E6A RID: 7786 RVA: 0x000C2B3F File Offset: 0x000C0D3F
		Public Function GetEnumerator() As IEnumerator(Of CrossGroupOn) Implements System.Collections.Generic.IEnumerable(Of Foxtable.CrossGroupOn).GetEnumerator
			Return CType(Me.OOOOO_0._o0O0o..GetEnumerator(), IEnumerator(Of CrossGroupOn))
		End Function

		' Token: 0x06001E6B RID: 7787 RVA: 0x000C2B56 File Offset: 0x000C0D56
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.GetEnumerator()
		End Function

		' Token: 0x170006C3 RID: 1731
		' (get) Token: 0x06001E6C RID: 7788 RVA: 0x000C2B5E File Offset: 0x000C0D5E
		Public ReadOnly Property Exprs As List(Of CrossExpressionGroup)
			Get
				Return Me.OOOOO_0._o0O0o.
			End Get
		End Property

		' Token: 0x170006C4 RID: 1732
		' (get) Token: 0x06001E6D RID: 7789 RVA: 0x000C2B66 File Offset: 0x000C0D66
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OOOOO_0._o0O0o..Count
			End Get
		End Property

		' Token: 0x170006C5 RID: 1733
		Public ReadOnly Default Property Item(A_0 As Integer) As CrossGroupOn
			Get
				Return Me.OOOOO_0._o0O0o.(A_0)
			End Get
		End Property

		' Token: 0x06001E6F RID: 7791 RVA: 0x000C2B81 File Offset: 0x000C0D81
		Public Sub RemoveAt(index As Integer)
			Me.OOOOO_0._o0O0o..RemoveAt(index)
		End Sub

		' Token: 0x06001E70 RID: 7792 RVA: 0x000C2B8F File Offset: 0x000C0D8F
		Public Sub AddRange(items As IEnumerable(Of CrossGroupOn))
			Me.OOOOO_0._o0O0o..AddRange(items)
		End Sub

		' Token: 0x04000CB8 RID: 3256
		Private <<EMPTY_NAME>> As List(Of CrossGroupOn)

		' Token: 0x04000CB9 RID: 3257
		Private <<EMPTY_NAME>> As List(Of CrossExpressionGroup)
	End Class
End Namespace
