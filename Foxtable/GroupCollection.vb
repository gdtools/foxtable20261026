Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000285 RID: 645
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GroupCollection
		Implements IEnumerable(Of GroupOn)

		' Token: 0x06001F2E RID: 7982 RVA: 0x000C9C44 File Offset: 0x000C7E44
		Public Sub New()
			Me.o_0ooO.Oo. = New List(Of GroupOn)()
			Me.o_0ooO.Oo. = New List(Of ExpressionGroup)()
		End Sub

		' Token: 0x06001F2F RID: 7983 RVA: 0x000C9C62 File Offset: 0x000C7E62
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Add(Item As GroupOn)
			Me.o_0ooO.Oo..Add(Item)
		End Sub

		' Token: 0x06001F30 RID: 7984 RVA: 0x000C9C70 File Offset: 0x000C7E70
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddDef(ParamArray args As Object())
			Dim list As List(Of Object) = New List(Of Object)()
			For i As Integer = 0 To args.Length - 1
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(i))
				If objectValue IsNot Nothing Then
					If TypeOf objectValue Is String Then
						list.Add(Conversions.ToString(objectValue).Trim())
					Else
						list.Add(RuntimeHelpers.GetObjectValue(objectValue))
					End If
				End If
			Next
			Select Case list.Count
				Case 1
					Dim name As String = Conversions.ToString(list(0))
					Me.AddDef(name)
					Return
				Case 2
					Dim name2 As String = Conversions.ToString(list(0))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(list(1))
					If TypeOf objectValue2 Is Integer OrElse TypeOf objectValue2 Is DateGroupEnum Then
						Dim dateGroup As DateGroupEnum = Conversions.ToInteger(objectValue2)
						Me.AddDef(name2, dateGroup)
						Return
					End If
					Dim newName As String = Conversions.ToString(objectValue2)
					Me.AddDef(name2, newName)
					Return
				Case 3
					Dim name3 As String = Conversions.ToString(list(0))
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(list(1))
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(list(2))
					If TypeOf objectValue3 Is Integer OrElse TypeOf objectValue3 Is DateGroupEnum Then
						Dim dateGroup2 As DateGroupEnum = Conversions.ToInteger(objectValue3)
						Dim newName2 As String = Conversions.ToString(objectValue4)
						Me.AddDef(name3, dateGroup2, newName2)
						Return
					End If
					Dim newName3 As String = Conversions.ToString(objectValue3)
					Dim newCaption As String = Conversions.ToString(objectValue4)
					Me.AddDef(name3, newName3, newCaption)
					Return
				Case 4
					Dim name4 As String = Conversions.ToString(list(0))
					Dim dateGroup3 As DateGroupEnum = Conversions.ToInteger(list(1))
					Dim newName4 As String = Conversions.ToString(list(2))
					Dim newCaption2 As String = Conversions.ToString(list(3))
					Me.AddDef(name4, dateGroup3, newName4, newCaption2)
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06001F31 RID: 7985 RVA: 0x000C9E15 File Offset: 0x000C8015
		Public Sub AddDef(Name As String)
			Me.o_0ooO.Oo..Add(New GroupOn(Name))
		End Sub

		' Token: 0x06001F32 RID: 7986 RVA: 0x000C9E28 File Offset: 0x000C8028
		Public Sub AddDef(Name As String, NewName As String)
			Me.o_0ooO.Oo..Add(New GroupOn(Name, NewName))
		End Sub

		' Token: 0x06001F33 RID: 7987 RVA: 0x000C9E3C File Offset: 0x000C803C
		Public Sub AddDef(Name As String, NewName As String, NewCaption As String)
			Me.o_0ooO.Oo..Add(New GroupOn(Name, NewName, NewCaption))
		End Sub

		' Token: 0x06001F34 RID: 7988 RVA: 0x000C9E51 File Offset: 0x000C8051
		Public Sub AddDef(Name As String, DateGroup As DateGroupEnum)
			Me.o_0ooO.Oo..Add(New GroupOn(Name, DateGroup))
		End Sub

		' Token: 0x06001F35 RID: 7989 RVA: 0x000C9E65 File Offset: 0x000C8065
		Public Sub AddDef(Name As String, DateGroup As DateGroupEnum, NewName As String)
			Me.o_0ooO.Oo..Add(New GroupOn(Name, DateGroup, NewName))
		End Sub

		' Token: 0x06001F36 RID: 7990 RVA: 0x000C9E7A File Offset: 0x000C807A
		Public Sub AddDef(Name As String, DateGroup As DateGroupEnum, NewName As String, NewCaption As String)
			Me.o_0ooO.Oo..Add(New GroupOn(Name, DateGroup, NewName, NewCaption))
		End Sub

		' Token: 0x06001F37 RID: 7991 RVA: 0x000C9E94 File Offset: 0x000C8094
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddExp(ParamArray args As Object())
			Dim array As String() = New String(args.Length - 1 + 1 - 1) {}
			Dim num As Integer = args.Length - 1
			For i As Integer = 0 To num
				array(i) = Conversions.ToString(args(i)).Trim()
			Next
			If args.Length = 2 Then
				Me.AddExp(array(0), array(1))
				Return
			End If
			If args.Length = 3 Then
				Me.AddExp(array(0), array(1), array(2))
			End If
		End Sub

		' Token: 0x06001F38 RID: 7992 RVA: 0x000C9EF8 File Offset: 0x000C80F8
		Public Sub AddExp(Name As String, Expression As String)
			Me.Exprs.Add(New ExpressionGroup(Name, Expression, ""))
		End Sub

		' Token: 0x06001F39 RID: 7993 RVA: 0x000C9F11 File Offset: 0x000C8111
		Public Sub AddExp(Name As String, Expression As String, Caption As String)
			Me.Exprs.Add(New ExpressionGroup(Name, Expression, Caption))
		End Sub

		' Token: 0x06001F3A RID: 7994 RVA: 0x000C9F26 File Offset: 0x000C8126
		Public Function GetEnumerator() As IEnumerator(Of GroupOn) Implements System.Collections.Generic.IEnumerable(Of Foxtable.GroupOn).GetEnumerator
			Return CType(Me.o_0ooO.Oo..GetEnumerator(), IEnumerator(Of GroupOn))
		End Function

		' Token: 0x06001F3B RID: 7995 RVA: 0x000C9F3D File Offset: 0x000C813D
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Me.GetEnumerator()
		End Function

		' Token: 0x17000707 RID: 1799
		' (get) Token: 0x06001F3C RID: 7996 RVA: 0x000C9F45 File Offset: 0x000C8145
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Exprs As List(Of ExpressionGroup)
			Get
				Return Me.o_0ooO.Oo.
			End Get
		End Property

		' Token: 0x17000708 RID: 1800
		' (get) Token: 0x06001F3D RID: 7997 RVA: 0x000C9F4D File Offset: 0x000C814D
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o_0ooO.Oo..Count
			End Get
		End Property

		' Token: 0x17000709 RID: 1801
		Public ReadOnly Default Property Item(A_0 As Integer) As GroupOn
			Get
				Return Me.o_0ooO.Oo.(A_0)
			End Get
		End Property

		' Token: 0x06001F3F RID: 7999 RVA: 0x000C9F68 File Offset: 0x000C8168
		Public Sub RemoveAt(index As Integer)
			Me.o_0ooO.Oo..RemoveAt(index)
		End Sub

		' Token: 0x06001F40 RID: 8000 RVA: 0x000C9F76 File Offset: 0x000C8176
		Public Sub AddRange(items As IEnumerable(Of GroupOn))
			Me.o_0ooO.Oo..AddRange(items)
		End Sub

		' Token: 0x04000D02 RID: 3330
		Private <<EMPTY_NAME>> As List(Of GroupOn)

		' Token: 0x04000D03 RID: 3331
		Private <<EMPTY_NAME>> As List(Of ExpressionGroup)
	End Class
End Namespace
