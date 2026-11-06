Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x0200002F RID: 47
	<oO0oooo("1132")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class RibbonItemCollection
		Implements IEnumerable

		' Token: 0x06000172 RID: 370 RVA: 0x00004164 File Offset: 0x00002364
		Public Sub New(A_0 As RibbonItemCollection)
			Me.oOo_.0o_O_O_0. = A_0
		End Sub

		' Token: 0x06000173 RID: 371 RVA: 0x00004173 File Offset: 0x00002373
		Public Sub Add(Item As RibbonItem)
			Me.oOo_.0o_O_O_0..Add(Item.oOo_.0o_O_O_0.)
		End Sub

		' Token: 0x06000174 RID: 372 RVA: 0x00004187 File Offset: 0x00002387
		Public Sub Insert(Index As Integer, Item As RibbonItem)
			Me.oOo_.0o_O_O_0..Insert(Index, Item.oOo_.0o_O_O_0.)
		End Sub

		' Token: 0x06000175 RID: 373 RVA: 0x0000419B File Offset: 0x0000239B
		Public Sub Remove(Name As String)
			Me.oOo_.0o_O_O_0..Remove(Name)
		End Sub

		' Token: 0x06000176 RID: 374 RVA: 0x000041A9 File Offset: 0x000023A9
		Public Sub Remove(Item As RibbonItem)
			Me.oOo_.0o_O_O_0..Remove(Item.oOo_.0o_O_O_0.)
		End Sub

		' Token: 0x06000177 RID: 375 RVA: 0x000041BC File Offset: 0x000023BC
		Public Sub RemoveAt(Index As Integer)
			Me.oOo_.0o_O_O_0..RemoveAt(Index)
		End Sub

		' Token: 0x170000A9 RID: 169
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

		' Token: 0x170000AA RID: 170
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As String) As Object
			Get
				Dim result As Object
				If Me.oOo_.0o_O_O_0..Contains(A_0) Then
					result = Me(Me.oOo_.0o_O_O_0..IndexOf(Me.oOo_.0o_O_O_0.(A_0)))
				Else
					MessageBox.Show("菜单中不存在名为""" + A_0 + """的组件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170000AB RID: 171
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Integer) As Object
			Get
				Dim result As Object
				If A_0 < 0 Or A_0 > Me.oOo_.0o_O_O_0..Count - 1 Then
					result = Nothing
				Else
					If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonListItem Then
						Dim ribbonListItem As RibbonListItem = CType(Me.oOo_.0o_O_O_0.(A_0), RibbonListItem)
						If ribbonListItem.Items.Count > 0 AndAlso TypeOf ribbonListItem.Items(0)Is RibbonButton Then
							Return New Button(CType(ribbonListItem.Items(0), RibbonButton))
						End If
					Else
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonToggleButton Then
							Return New ToggleButton(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonToggleButton))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonDatePicker Then
							Return New DatePicker(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonDatePicker))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonTimePicker Then
							Return New TimePicker(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonTimePicker))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonNumericBox Then
							Return New NumericBox(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonNumericBox))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonProgressBar Then
							Return New ProgressBar(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonProgressBar))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonCheckBox Then
							Return New CheckBox(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonCheckBox))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonButton Then
							Return New Button(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonButton))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonColorPicker Then
							Return New ColorPicker(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonColorPicker))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonSplitButton Then
							Return New SplitButton(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonSplitButton))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonLabel Then
							Return New Label(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonLabel))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonTextBox Then
							Return New TextBox(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonTextBox))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonMenu Then
							Return New MenuButton(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonMenu))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonFontComboBox Then
							Return New FontComboBox(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonFontComboBox))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonComboBox Then
							Return New ComboBox(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonComboBox))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonToolBar Then
							Return New ToolBar(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonToolBar))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonToggleGroup Then
							Return New ToggleGroup(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonToggleGroup))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonSeparator Then
							Return New Separator(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonSeparator))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is o_o_Oo0__o_0 Then
							Return New Gallery(CType(Me.oOo_.0o_O_O_0.(A_0), o_o_Oo0__o_0))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonGalleryItem Then
							Return New GalleryItem(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonGalleryItem))
						End If
						If TypeOf Me.oOo_.0o_O_O_0.(A_0)Is RibbonTrackBar Then
							Return New TrackBar(CType(Me.oOo_.0o_O_O_0.(A_0), RibbonTrackBar))
						End If
					End If
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x0600017B RID: 379 RVA: 0x00004696 File Offset: 0x00002896
		Public Function Contains(Name As String) As Boolean
			Return Me.oOo_.0o_O_O_0..Contains(Name)
		End Function

		' Token: 0x0600017C RID: 380 RVA: 0x000046A4 File Offset: 0x000028A4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Contains(Item As RibbonItem) As Boolean
			Return Me.oOo_.0o_O_O_0..Contains(Item.oOo_.0o_O_O_0.)
		End Function

		' Token: 0x0600017D RID: 381 RVA: 0x000046B7 File Offset: 0x000028B7
		Public Sub Clear()
			Me.oOo_.0o_O_O_0..Clear()
		End Sub

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x0600017E RID: 382 RVA: 0x000046C4 File Offset: 0x000028C4
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oOo_.0o_O_O_0..Count
			End Get
		End Property

		' Token: 0x0600017F RID: 383 RVA: 0x000046D1 File Offset: 0x000028D1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New RibbonItemEnumerator(Me)
		End Function

		' Token: 0x0400004E RID: 78
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
