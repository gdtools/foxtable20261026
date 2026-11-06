Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020004C5 RID: 1221
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OoO_oO
		Implements Oo0__O__O_0__

		' Token: 0x06004E93 RID: 20115 RVA: 0x002092A0 File Offset: 0x002074A0
		Public Sub New(A_0 As Table)
			Me.O_.o_. = New Dictionary(Of String, Integer)()
			Me.O0._ooOO. = A_0
			Dim o_oOooO_O As O_oOooO_O = Me.O0._ooOO..foxGrid
			Dim fixed As Integer = o_oOooO_O.Cols.Fixed
			Dim num As Integer = o_oOooO_O.Cols.Count - 1
			For i As Integer = fixed To num
				If Not Me.O_.o_..ContainsKey(o_oOooO_O.Cols(i).Name) Then
					Me.O_.o_..Add(o_oOooO_O.Cols(i).Name, o_oOooO_O.Cols(i).Width)
				End If
			Next
		End Sub

		' Token: 0x06004E94 RID: 20116 RVA: 0x00209342 File Offset: 0x00207542
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.oO_o_0.0.
			Me.O0._ooOO.()
		End Sub

		' Token: 0x06004E95 RID: 20117 RVA: 0x0020934C File Offset: 0x0020754C
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.Oo0__O__O_0__.O__00.__0_O.
			Dim o_oOooO_O As O_oOooO_O = Me.O0._ooOO..foxGrid
			Dim dictionary As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()
			Dim fixed As Integer = o_oOooO_O.Cols.Fixed
			Dim num As Integer = o_oOooO_O.Cols.Count - 1
			For i As Integer = fixed To num
				dictionary.Add(o_oOooO_O.Cols(i).Name, o_oOooO_O.Cols(i).Width)
			Next
			Dim fixed2 As Integer = o_oOooO_O.Cols.Fixed
			Dim num2 As Integer = o_oOooO_O.Cols.Count - 1
			For j As Integer = fixed2 To num2
				If Me.O_.o_..ContainsKey(o_oOooO_O.Cols(j).Name) Then
					o_oOooO_O.Cols(j).Width = Me.O_.o_.(o_oOooO_O.Cols(j).Name)
				End If
			Next
			Me.O_.o_..Clear()
			Try
				For Each key As String In dictionary.Keys
					Me.O_.o_..Add(key, dictionary(key))
				Next
			Finally
				Dim enumerator As Dictionary(Of String, Integer).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x04002088 RID: 8328
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04002089 RID: 8329
		Private <<EMPTY_NAME>> As Dictionary(Of String, Integer)
	End Class
End Namespace
