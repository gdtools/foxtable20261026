Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200016D RID: 365
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	<oO0oooo("Strips")>
	Public Class StripCollection
		Implements IEnumerable(Of Strip)

		' Token: 0x0600110A RID: 4362 RVA: 0x0006AD3C File Offset: 0x00068F3C
		Public Sub New(A_0 As Dictionary(Of String, ToolStrip), A_1 As Foxtable.WinForm.Form)
			Me.o.__o_O. = A_0
			Me.o.__o_O. = A_1
		End Sub

		' Token: 0x1700038C RID: 908
		' (get) Token: 0x0600110B RID: 4363 RVA: 0x0006AD52 File Offset: 0x00068F52
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o.__o_O..Count
			End Get
		End Property

		' Token: 0x1700038D RID: 909
		' (get) Token: 0x0600110C RID: 4364 RVA: 0x0006AD60 File Offset: 0x00068F60
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(index As Integer) As Strip
			Get
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(Me.o.__o_O..Keys)
				Return New Strip(Me.o.__o_O.(list(index)), Me.o.__o_O.)
			End Get
		End Property

		' Token: 0x1700038E RID: 910
		' (get) Token: 0x0600110D RID: 4365 RVA: 0x0006ADA1 File Offset: 0x00068FA1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Name As String) As Strip
			Get
				Return New Strip(Me.o.__o_O.(Name), Me.o.__o_O.)
			End Get
		End Property

		' Token: 0x1700038F RID: 911
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Strip
			Get
				Dim index As Integer = -1
				Dim result As Strip
				If Integer.TryParse(A_0.ToString(), index) Then
					result = Me.get_Item(index)
				Else
					result = Me.get_Item(A_0.ToString())
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600110F RID: 4367 RVA: 0x0006ADF4 File Offset: 0x00068FF4
		Public Sub Remove(Name As String)
			If Me.o.__o_O..ContainsKey(Name) Then
				Dim toolStrip As ToolStrip = Me.o.__o_O.(Name)
				Me.o.__o_O..Remove(Name)
				If toolStrip.Parent IsNot Nothing Then
					toolStrip.Parent.Controls.Remove(toolStrip)
				End If
				toolStrip.Dispose()
			End If
		End Sub

		' Token: 0x06001110 RID: 4368 RVA: 0x0006AE48 File Offset: 0x00069048
		Public Function Contains(Name As String) As Boolean
			Return Me.o.__o_O..O_0.O00o_00_O..ContainsKey(Name)
		End Function

		' Token: 0x06001111 RID: 4369 RVA: 0x0006AE5C File Offset: 0x0006905C
		Public Sub Clear()
			Try
				For Each toolStrip As ToolStrip In Me.o.__o_O..Values
					If toolStrip.Parent IsNot Nothing Then
						toolStrip.Parent.Controls.Remove(toolStrip)
					End If
					toolStrip.Dispose()
				Next
			Finally
				Dim enumerator As Dictionary(Of String, ToolStrip).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Me.o.__o_O..Clear()
		End Sub

		' Token: 0x06001112 RID: 4370 RVA: 0x0006AED8 File Offset: 0x000690D8
		Public Function Add(Name As String, Type As StripTypeEnum, Optional Dock As DockStyle = DockStyle.None) As Strip
			Dim toolStrip As ToolStrip
			Select Case Type
				Case StripTypeEnum.MainMenu
					toolStrip = New MenuStrip()
					toolStrip.Dock = DockStyle.Top
				Case StripTypeEnum.ToolBar
					toolStrip = New ToolStrip()
					If Dock <> DockStyle.None AndAlso Dock <> DockStyle.Fill Then
						toolStrip.Dock = Dock
					Else
						toolStrip.Dock = DockStyle.Top
					End If
				Case StripTypeEnum.StatusBar
					toolStrip = New StatusStrip()
					toolStrip.Dock = DockStyle.Bottom
					toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
					CType(toolStrip, StatusStrip).SizingGrip = True
				Case StripTypeEnum.ContextMenu
					toolStrip = New ContextMenuStrip()
				Case Else
					Return Nothing
			End Select
			AddHandler toolStrip.ItemClicked, AddressOf Me.o.__o_O..o_O._o_0_o.
			If Type <> StripTypeEnum.ContextMenu Then
				Me.o.__o_O..Pane.Controls.Add(toolStrip)
			End If
			If Operators.CompareString(Me.o.__o_O..MenuTheme, "(none)", True) = 0 Then
				toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode
				toolStrip.Renderer = O_O0OO.o0_OO.000.()
			Else
				Main.OO_O.o..Oo.oOo_o0Oo0.(Me.o.__o_O..MenuTheme, New Object() { toolStrip })
			End If
			Me.o.__o_O..O_0.O00o_00_O..Add(Name, toolStrip)
			toolStrip.Name = Name
			Return Me.o.__o_O..Strips(Name)
		End Function

		' Token: 0x06001113 RID: 4371 RVA: 0x0006B006 File Offset: 0x00069206
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Strip) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.Strip).GetEnumerator
			Dim list As List(Of ToolStrip) = New List(Of ToolStrip)()
			list.AddRange(Me.o.__o_O..Values)
			Return New OoO00OooO_(list, Me.o.__o_O.)
		End Function

		' Token: 0x06001114 RID: 4372 RVA: 0x0006B029 File Offset: 0x00069229
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Dim list As List(Of ToolStrip) = New List(Of ToolStrip)()
			list.AddRange(Me.o.__o_O..Values)
			Return New OoO00OooO_(list, Me.o.__o_O.)
		End Function

		' Token: 0x04000678 RID: 1656
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ToolStrip)

		' Token: 0x04000679 RID: 1657
		Friend <<EMPTY_NAME>> As Foxtable.WinForm.Form
	End Class
End Namespace
