Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004C4 RID: 1220
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ooO0O__o_o_O_
		Implements Oo0__O__O_0__

		' Token: 0x06004E90 RID: 20112 RVA: 0x0020910C File Offset: 0x0020730C
		Public Sub New(A_0 As Table)
			Me.O0oO.o_OOoO_. = New List(Of String)()
			Me.O0oO.o_OOoO_. = A_0
			Dim o_oOooO_O As O_oOooO_O = Me.O0oO.o_OOoO_..foxGrid
			Dim fixed As Integer = o_oOooO_O.Cols.Fixed
			Dim num As Integer = o_oOooO_O.Cols.Count - 1
			For i As Integer = fixed To num
				If o_oOooO_O.Cols(i).Visible Then
					Me.O0oO.o_OOoO_..Add(o_oOooO_O.Cols(i).Name)
				End If
			Next
		End Sub

		' Token: 0x06004E91 RID: 20113 RVA: 0x00209192 File Offset: 0x00207392
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.O0oO.o_OOoO_.()
		End Sub

		' Token: 0x06004E92 RID: 20114 RVA: 0x0020919C File Offset: 0x0020739C
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim o_oOooO_O As O_oOooO_O = Me.O0oO.o_OOoO_..foxGrid
			o_oOooO_O.BeginUpdate()
			Dim list As List(Of String) = New List(Of String)()
			Dim fixed As Integer = o_oOooO_O.Cols.Fixed
			Dim num As Integer = o_oOooO_O.Cols.Count - 1
			For i As Integer = fixed To num
				If o_oOooO_O.Cols(i).Visible Then
					list.Add(o_oOooO_O.Cols(i).Name)
				End If
			Next
			Dim fixed2 As Integer = o_oOooO_O.Cols.Fixed
			Dim num2 As Integer = o_oOooO_O.Cols.Count - 1
			For j As Integer = fixed2 To num2
				If Me.O0oO.o_OOoO_..Contains(o_oOooO_O.Cols(j).Name) Then
					o_oOooO_O.Cols(j).Visible = True
				Else
					o_oOooO_O.Cols(j).Visible = False
				End If
			Next
			Me.O0oO.o_OOoO_..Clear()
			Me.O0oO.o_OOoO_..AddRange(list)
			o_oOooO_O.EndUpdate()
		End Sub

		' Token: 0x04002086 RID: 8326
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04002087 RID: 8327
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
