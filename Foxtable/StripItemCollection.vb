Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000172 RID: 370
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("3221")>
	<ComVisible(True)>
	Public Class StripItemCollection
		Implements IEnumerable(Of StripItem)

		' Token: 0x0600112D RID: 4397 RVA: 0x0006B800 File Offset: 0x00069A00
		Public Sub New(A_0 As ToolStripItemCollection, A_1 As Foxtable.WinForm.Form)
			Me.OOOOO.Oo_Oo. = A_0
			Me.OOOOO.Oo_Oo. = A_1
		End Sub

		' Token: 0x17000396 RID: 918
		' (get) Token: 0x0600112E RID: 4398 RVA: 0x0006B816 File Offset: 0x00069A16
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OOOOO.Oo_Oo..Count
			End Get
		End Property

		' Token: 0x17000397 RID: 919
		' (get) Token: 0x0600112F RID: 4399 RVA: 0x0006B823 File Offset: 0x00069A23
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Index As Integer) As StripItem
			Get
				Return New StripItem(Me.OOOOO.Oo_Oo.(Index), Me.OOOOO.Oo_Oo.)
			End Get
		End Property

		' Token: 0x17000398 RID: 920
		' (get) Token: 0x06001130 RID: 4400 RVA: 0x0006B83C File Offset: 0x00069A3C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Name As String) As StripItem
			Get
				Return New StripItem(Me.OOOOO.Oo_Oo.(Name), Me.OOOOO.Oo_Oo.)
			End Get
		End Property

		' Token: 0x17000399 RID: 921
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As StripItem
			Get
				Dim index As Integer = -1
				Dim result As StripItem
				If Integer.TryParse(A_0.ToString(), index) Then
					result = Me.get_Item(index)
				Else
					result = Me.get_Item(A_0.ToString())
				End If
				Return result
			End Get
		End Property

		' Token: 0x06001132 RID: 4402 RVA: 0x0006B88E File Offset: 0x00069A8E
		Public Function Contains(Name As String) As Boolean
			Return Me.OOOOO.Oo_Oo..ContainsKey(Name)
		End Function

		' Token: 0x06001133 RID: 4403 RVA: 0x0006B89C File Offset: 0x00069A9C
		Public Sub Remove(Name As String)
			Try
				For Each obj As Object In Me.OOOOO.Oo_Oo.
					Dim toolStripItem As ToolStripItem = CType(obj, ToolStripItem)
					If Operators.CompareString(toolStripItem.Name, Name, True) = 0 Then
						Me.OOOOO.Oo_Oo..Remove(toolStripItem)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06001134 RID: 4404 RVA: 0x0006B910 File Offset: 0x00069B10
		Public Function Add(Name As String, Text As String, ImageFile As String, Type As StripItemTypeEnum, Optional Delimiter As Boolean = False) As StripItem
			Dim toolStripItem As ToolStripItem = Me.OOOOO.Oo_Oo.(Name, Text, ImageFile, Type, Delimiter)
			Me.OOOOO.Oo_Oo..Add(toolStripItem)
			Return New StripItem(toolStripItem, Me.OOOOO.Oo_Oo.)
		End Function

		' Token: 0x06001135 RID: 4405 RVA: 0x0006B944 File Offset: 0x00069B44
		Public Function Insert(Index As Integer, Name As String, Text As String, ImageFile As String, Type As StripItemTypeEnum, Optional Delimiter As Boolean = False) As StripItem
			Dim toolStripItem As ToolStripItem = Me.OOOOO.Oo_Oo.(Name, Text, ImageFile, Type, Delimiter)
			Me.OOOOO.Oo_Oo..Insert(Index, toolStripItem)
			Return New StripItem(toolStripItem, Me.OOOOO.Oo_Oo.)
		End Function

		' Token: 0x06001136 RID: 4406 RVA: 0x0006B97C File Offset: 0x00069B7C
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As StripItemTypeEnum, Optional A_4 As Boolean = False) As ToolStripItem
			Dim toolStripItem As ToolStripItem = Nothing
			Select Case A_3
				Case StripItemTypeEnum.MenuItem
					toolStripItem = New ToolStripMenuItem()
				Case StripItemTypeEnum.Button
					toolStripItem = New ToolStripButton()
					toolStripItem.DisplayStyle = ToolStripItemDisplayStyle.Image
				Case StripItemTypeEnum.Label
					toolStripItem = New ToolStripLabel()
				Case StripItemTypeEnum.SplitButton
					toolStripItem = New ToolStripSplitButton()
					toolStripItem.DisplayStyle = ToolStripItemDisplayStyle.Image
				Case StripItemTypeEnum.TextBox
					toolStripItem = New ToolStripTextBox()
				Case StripItemTypeEnum.ComboBox
					toolStripItem = New ToolStripComboBox()
				Case StripItemTypeEnum.Separator
					toolStripItem = New ToolStripSeparator()
			End Select
			toolStripItem.Name = A_0
			toolStripItem.Text = A_1
			toolStripItem.Image = OO_00oOO.GetImage(A_2)
			If A_4 Then
				Me.OOOOO.Oo_Oo..Add(New ToolStripSeparator())
			End If
			If Me.OOOOO.Oo_Oo. IsNot Nothing Then
				If A_3 = StripItemTypeEnum.MenuItem Then
					AddHandler CType(CType(toolStripItem, ToolStripMenuItem).DropDown, ToolStripDropDownMenu).ItemClicked, AddressOf Me.OOOOO.Oo_Oo..o_O._o_0_o.
				End If
				If A_3 = StripItemTypeEnum.SplitButton Then
					AddHandler CType(CType(toolStripItem, ToolStripSplitButton).DropDown, ToolStripDropDownMenu).ItemClicked, AddressOf Me.OOOOO.Oo_Oo..o_O._o_0_o.
				End If
				AddHandler toolStripItem.MouseEnter, AddressOf Me.OOOOO.Oo_Oo..O0O_o.OOOO0o.
				AddHandler toolStripItem.MouseLeave, AddressOf Me.OOOOO.Oo_Oo..Oo_o.OO.
				AddHandler toolStripItem.MouseHover, AddressOf Me.OOOOO.Oo_Oo..o.0__0_0o.
			End If
			Return toolStripItem
		End Function

		' Token: 0x06001137 RID: 4407 RVA: 0x0006BACC File Offset: 0x00069CCC
		Public Function AddControl(Name As String, control As Foxtable.WinForm.Control) As StripItem
			Dim toolStripControlHost As ToolStripControlHost = New ToolStripControlHost(control.BaseControl, Name)
			toolStripControlHost.AutoSize = False
			toolStripControlHost.Visible = True
			Me.OOOOO.Oo_Oo..Add(toolStripControlHost)
			Return New StripItem(toolStripControlHost, Me.OOOOO.Oo_Oo.)
		End Function

		' Token: 0x06001138 RID: 4408 RVA: 0x0006BB10 File Offset: 0x00069D10
		Public Function InsertControl(Name As String, control As Foxtable.WinForm.Control, Index As Integer) As StripItem
			Dim toolStripControlHost As ToolStripControlHost = New ToolStripControlHost(control.BaseControl, Name)
			toolStripControlHost.AutoSize = False
			toolStripControlHost.Visible = True
			If Index < 0 Then
				Me.OOOOO.Oo_Oo..Add(toolStripControlHost)
			Else
				Me.OOOOO.Oo_Oo..Insert(Index, toolStripControlHost)
			End If
			Return New StripItem(toolStripControlHost, Me.OOOOO.Oo_Oo.)
		End Function

		' Token: 0x06001139 RID: 4409 RVA: 0x0006BB64 File Offset: 0x00069D64
		Public Sub Clear()
			Me.OOOOO.Oo_Oo..Clear()
		End Sub

		' Token: 0x0600113A RID: 4410 RVA: 0x0006BB71 File Offset: 0x00069D71
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of StripItem) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.StripItem).GetEnumerator
			Return New O00Oo00ooO0_(Me.OOOOO.Oo_Oo., Me.OOOOO.Oo_Oo.)
		End Function

		' Token: 0x0600113B RID: 4411 RVA: 0x0006BB84 File Offset: 0x00069D84
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O00Oo00ooO0_(Me.OOOOO.Oo_Oo., Me.OOOOO.Oo_Oo.)
		End Function

		' Token: 0x04000688 RID: 1672
		Private <<EMPTY_NAME>> As ToolStripItemCollection

		' Token: 0x04000689 RID: 1673
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form
	End Class
End Namespace
