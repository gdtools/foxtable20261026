Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x0200002B RID: 43
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ContextCommandCollection
		Implements IEnumerable

		' Token: 0x06000153 RID: 339 RVA: 0x00003D1A File Offset: 0x00001F1A
		Friend Sub New(A_0 As C1CommandLinks)
			Me.o_o_0oO_.o_o. = A_0
		End Sub

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x06000154 RID: 340 RVA: 0x00003D29 File Offset: 0x00001F29
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o_o_0oO_.o_o..Count
			End Get
		End Property

		' Token: 0x06000155 RID: 341 RVA: 0x00003D38 File Offset: 0x00001F38
		Public Function Contains(Name As String) As Boolean
			Try
				Dim enumerator As IEnumerator = Me.o_o_0oO_.o_o..GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(CType(enumerator.Current, C1CommandLink).Command.Name, Name, True) = 0 Then
						Return True
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return False
		End Function

		' Token: 0x170000A0 RID: 160
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Object
			Get
				Dim result As Object
				If TypeOf A_0 Is String Then
					result = Me(Conversions.ToString(A_0))
				Else
					result = Me(Conversions.ToInteger(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000A1 RID: 161
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer) As Object
			Get
				Dim result As Object
				If A_0 < 0 Or A_0 > Me.o_o_0oO_.o_o..Count - 1 Then
					result = Nothing
				Else
					result = New ContextCommand(Me.o_o_0oO_.o_o.(A_0))
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000A2 RID: 162
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As String) As Object
			Get
				Try
					For Each obj As Object In Me.o_o_0oO_.o_o.
						Dim c1CommandLink As C1CommandLink = CType(obj, C1CommandLink)
						If Operators.CompareString(c1CommandLink.Command.Name, A_0, True) = 0 Then
							If TypeOf c1CommandLink.Command Is C1CommandMenu Then
								Return New ContextCommandMenu(c1CommandLink)
							End If
							Return New ContextCommand(c1CommandLink)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				MessageBox.Show("不存在名为""" + A_0 + "的快捷菜单命令""！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return Nothing
			End Get
		End Property

		' Token: 0x06000159 RID: 345 RVA: 0x00003EC4 File Offset: 0x000020C4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New ContextCommandEnumerator(Me)
		End Function

		' Token: 0x0600015A RID: 346 RVA: 0x00003ECC File Offset: 0x000020CC
		Public Sub Add(command As ContextCommand)
			Me.Add(command, command.Delimiter)
		End Sub

		' Token: 0x0600015B RID: 347 RVA: 0x00003EDC File Offset: 0x000020DC
		Public Sub Add(command As ContextCommand, Delimiter As Boolean)
			Dim c1CommandLink As C1CommandLink = New C1CommandLink(command.oo0OOOO_._..Command)
			c1CommandLink.Delimiter = Delimiter
			Me.o_o_0oO_.o_o..Add(c1CommandLink)
		End Sub

		' Token: 0x04000047 RID: 71
		Private <<EMPTY_NAME>> As C1CommandLinks
	End Class
End Namespace
