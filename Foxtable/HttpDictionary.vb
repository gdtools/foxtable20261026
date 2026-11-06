Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001DD RID: 477
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class HttpDictionary
		' Token: 0x06001704 RID: 5892 RVA: 0x0009433A File Offset: 0x0009253A
		Public Sub New()
			Me.o0O_.0o0_oO. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
		End Sub

		' Token: 0x170004EC RID: 1260
		Public Default Property Item(key As String) As String
			Get
				Dim result As String
				If Me.o0O_.0o0_oO..ContainsKey(key) Then
					result = Me.o0O_.0o0_oO.(key)
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If Me.o0O_.0o0_oO..ContainsKey(key) Then
					Me.o0O_.0o0_oO.(key) = value
				End If
			End Set
		End Property

		' Token: 0x06001707 RID: 5895 RVA: 0x0009439E File Offset: 0x0009259E
		Public Sub Add(key As String, value As String)
			Me.o0O_.0o0_oO..Add(key, value)
		End Sub

		' Token: 0x06001708 RID: 5896 RVA: 0x000943AD File Offset: 0x000925AD
		Public Sub Clear()
			Me.o0O_.0o0_oO..Clear()
		End Sub

		' Token: 0x06001709 RID: 5897 RVA: 0x000943BA File Offset: 0x000925BA
		Public Function ContainsKey(key As String) As Boolean
			Return Me.o0O_.0o0_oO..ContainsKey(key)
		End Function

		' Token: 0x0600170A RID: 5898 RVA: 0x000943C8 File Offset: 0x000925C8
		Public Function ContainsValue(value As String) As Boolean
			Dim result As Boolean
			Try
				For Each key As String In Me.o0O_.0o0_oO..Keys
					If Operators.CompareString(Me.o0O_.0o0_oO.(key), value, True) = 0 Then
						result = True
						Exit For
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return result
		End Function

		' Token: 0x170004ED RID: 1261
		' (get) Token: 0x0600170B RID: 5899 RVA: 0x00094434 File Offset: 0x00092634
		Public ReadOnly Property Keys As Dictionary(Of String, String).KeyCollection
			Get
				Return Me.o0O_.0o0_oO..Keys
			End Get
		End Property

		' Token: 0x170004EE RID: 1262
		' (get) Token: 0x0600170C RID: 5900 RVA: 0x00094441 File Offset: 0x00092641
		Public ReadOnly Property Values As Dictionary(Of String, String).ValueCollection
			Get
				Return Me.o0O_.0o0_oO..Values
			End Get
		End Property

		' Token: 0x170004EF RID: 1263
		' (get) Token: 0x0600170D RID: 5901 RVA: 0x0009444E File Offset: 0x0009264E
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o0O_.0o0_oO..Count
			End Get
		End Property

		' Token: 0x0400093E RID: 2366
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
