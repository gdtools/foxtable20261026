Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200025D RID: 605
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("2442")>
	<ComVisible(True)>
	Public Class ChildrenCollection
		Inherits List(Of Foxtable.WinForm.Control)

		' Token: 0x1700064D RID: 1613
		Public ReadOnly Default Property Item(Name As String) As Foxtable.WinForm.Control
			Get
				Try
					For Each control As Foxtable.WinForm.Control In Me
						If Operators.CompareString(control.Name, Name, True) = 0 Then
							Return control
						End If
					Next
				Finally
					Dim enumerator As List(Of Foxtable.WinForm.Control).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				MessageBox.Show("找不到名称为""" + Name + """的子控件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return Nothing
			End Get
		End Property

		' Token: 0x1700064E RID: 1614
		Public ReadOnly Default Property Item(index As Integer) As Foxtable.WinForm.Control
			Get
				Return MyBase(index)
			End Get
		End Property

		' Token: 0x06001C84 RID: 7300 RVA: 0x000B64B0 File Offset: 0x000B46B0
		Public Function Contains(Name As String) As Boolean
			Try
				Dim enumerator As List(Of Foxtable.WinForm.Control).Enumerator = MyBase.GetEnumerator()
				While enumerator.MoveNext()
					If Operators.CompareString(enumerator.Current.Name, Name, True) = 0 Then
						Return True
					End If
				End While
			Finally
				Dim enumerator As List(Of Foxtable.WinForm.Control).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return False
		End Function
	End Class
End Namespace
