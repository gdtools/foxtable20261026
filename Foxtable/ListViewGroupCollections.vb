Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001A5 RID: 421
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class ListViewGroupCollections
		Implements IEnumerable(Of Foxtable.WinForm.ListViewGroup)

		' Token: 0x060013DC RID: 5084 RVA: 0x0008011A File Offset: 0x0007E31A
		Public Sub New(A_0 As ListViewGroupCollection)
			Me.oo.oO_. = A_0
		End Sub

		' Token: 0x1700040F RID: 1039
		' (get) Token: 0x060013DD RID: 5085 RVA: 0x00080129 File Offset: 0x0007E329
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oo.oO_..Count
			End Get
		End Property

		' Token: 0x17000410 RID: 1040
		' (get) Token: 0x060013DE RID: 5086 RVA: 0x00080138 File Offset: 0x0007E338
		Public ReadOnly Property Contains(key As String) As Boolean
			Get
				Try
					Dim enumerator As IEnumerator = Me.oo.oO_..GetEnumerator()
					While enumerator.MoveNext()
						If Operators.CompareString(CType(enumerator.Current, System.Windows.Forms.ListViewGroup).Name, key, True) = 0 Then
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
			End Get
		End Property

		' Token: 0x17000411 RID: 1041
		Public ReadOnly Default Property Item(Index As Integer) As Foxtable.WinForm.ListViewGroup
			Get
				Return New Foxtable.WinForm.ListViewGroup(Me.oo.oO_.(Index))
			End Get
		End Property

		' Token: 0x17000412 RID: 1042
		Public ReadOnly Default Property Item(Key As String) As Foxtable.WinForm.ListViewGroup
			Get
				Return New Foxtable.WinForm.ListViewGroup(Me.oo.oO_.(Key))
			End Get
		End Property

		' Token: 0x060013E1 RID: 5089 RVA: 0x000801CA File Offset: 0x0007E3CA
		Public Sub Clear()
			Me.oo.oO_..Clear()
		End Sub

		' Token: 0x060013E2 RID: 5090 RVA: 0x000801D8 File Offset: 0x0007E3D8
		Public Function Add() As Foxtable.WinForm.ListViewGroup
			Dim listViewGroup As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup()
			Me.oo.oO_..Add(listViewGroup)
			Return New Foxtable.WinForm.ListViewGroup(listViewGroup)
		End Function

		' Token: 0x060013E3 RID: 5091 RVA: 0x00080200 File Offset: 0x0007E400
		Public Function Add(Name As String) As Foxtable.WinForm.ListViewGroup
			Dim listViewGroup As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup()
			Me.oo.oO_..Add(listViewGroup)
			listViewGroup.Name = Name
			listViewGroup.Header = Name
			Return New Foxtable.WinForm.ListViewGroup(listViewGroup)
		End Function

		' Token: 0x060013E4 RID: 5092 RVA: 0x00080234 File Offset: 0x0007E434
		Public Sub Delete(Index As Integer)
			Me.oo.oO_..RemoveAt(Index)
		End Sub

		' Token: 0x060013E5 RID: 5093 RVA: 0x00080242 File Offset: 0x0007E442
		Public Sub Delete(Key As String)
			If Me.get_Contains(Key) Then
				Me.oo.oO_..Remove(Me.oo.oO_.(Key))
			End If
		End Sub

		' Token: 0x060013E6 RID: 5094 RVA: 0x00080264 File Offset: 0x0007E464
		Public Sub Delete(item As Foxtable.WinForm.ListViewGroup)
			Me.oo.oO_..Remove(item.BaseGroup)
		End Sub

		' Token: 0x060013E7 RID: 5095 RVA: 0x00080277 File Offset: 0x0007E477
		Public Function GetEnumerator() As IEnumerator(Of Foxtable.WinForm.ListViewGroup) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.ListViewGroup).GetEnumerator
			Return New OO0_o_oOo0(Me.oo.oO_.)
		End Function

		' Token: 0x060013E8 RID: 5096 RVA: 0x00080284 File Offset: 0x0007E484
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New OO0_o_oOo0(Me.oo.oO_.)
		End Function

		' Token: 0x040007C9 RID: 1993
		Private <<EMPTY_NAME>> As ListViewGroupCollection
	End Class
End Namespace
