Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Foxtable.Syscmd
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports TSF

Namespace Foxtable
	' Token: 0x0200007E RID: 126
	Friend Class O_oOooO_O
		Inherits C1FlexGrid

		' Token: 0x06000434 RID: 1076 RVA: 0x0000FD65 File Offset: 0x0000DF65
		Friend Sub <<EMPTY_NAME>>()
			Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me })
		End Sub

		' Token: 0x06000435 RID: 1077 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		Public Sub New(A_0 As Foxtable.Table)
			Dim a_ As Integer = 14
			MyBase..ctor()
			MyBase.AfterEdit += AddressOf Me.o__.o0oOO_O.
			MyBase.AfterFreezeColumn += AddressOf Me.O0._0O00oO0o0O.
			MyBase.AfterResizeColumn += AddressOf Me.Oo0oO0O.O_oo_.
			MyBase.AfterResizeRow += AddressOf Me.o_.o00_.
			MyBase.AfterRowColChange += AddressOf Me.o.O_0o.
			MyBase.AfterScroll += AddressOf Me.oO__O.o00O.
			MyBase.AfterSelChange += AddressOf Me.oO.o_o0O.
			MyBase.BeforeDoubleClick += AddressOf Me.O.O0_0.
			MyBase.BeforeDragColumn += AddressOf Me.OoO._OOo__.
			MyBase.BeforeEdit += AddressOf Me.oo_o_.o.
			MyBase.BeforeFreezeColumn += AddressOf Me.oOO0___._.
			MyBase.BeforeMouseDown += AddressOf Me.o0.OO00.
			MyBase.BeforeResizeColumn += AddressOf Me.oOO0_0oo_0.O.
			MyBase.BeforeResizeRow += AddressOf Me.oo_Oo.0oo__.
			MyBase.BeforeRowColChange += AddressOf Me.oo0O.0.
			MyBase.BeforeSelChange += AddressOf Me.o0.OO00.
			MyBase.CellButtonClick += AddressOf Me.o00OO.Oo.
			MyBase.ChangeEdit += AddressOf Me.oo_o_.o.
			AddHandler MyBase.Click, AddressOf Me.O_oO0._.
			AddHandler MyBase.DoubleClick, AddressOf Me.OoOooO_._0_0o.
			AddHandler MyBase.Enter, AddressOf Me.oo_Oo.0oo__.
			AddHandler MyBase.FontChanged, AddressOf Me.ooO._00000O00_.
			AddHandler MyBase.GotFocus, AddressOf Me.O_.__oo0.
			AddHandler MyBase.KeyDown, AddressOf Me.OO.o_o00o.
			MyBase.KeyDownEdit += AddressOf Me.OO.o_o00o.
			MyBase.KeyPressEdit += AddressOf Me.o._O00___.
			AddHandler MyBase.KeyUp, AddressOf Me.o000OOo.OO.
			MyBase.KeyUpEdit += AddressOf Me.o._O00___.
			AddHandler MyBase.MouseDown, AddressOf Me.oo.0.
			MyBase.MouseEnterCell += AddressOf Me.O_.__oo0.
			MyBase.MouseLeaveCell += AddressOf Me.o0.Oo.
			MyBase.OwnerDrawCell += AddressOf Me.o._O00___.
			AddHandler MyBase.ParentChanged, AddressOf Me.o0.Oo.
			MyBase.SetupEditor += AddressOf Me.OO.o_o00o.
			MyBase.StartEdit += AddressOf Me.o._O00___.
			MyBase.ValidateEdit += AddressOf Me.o._O00___.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.o000OOo.OO.
			AddHandler MyBase.MouseClick, AddressOf Me.o000OOo.OO.
			AddHandler MyBase.MouseMove, AddressOf Me.o000OOo.OO.
			Me.o_.o. = New Dictionary(Of Column, Integer)()
			Me.o_.o. = New Dictionary(Of String, String)()
			Me.O_._. = 0
			Me.O_._. = -1F
			MyBase.ShowErrors = True
			MyBase.Rows.DefaultSize = 19
			MyBase.VisualStyle = 0
			Main.OO_O.o..Oo.oOo_o0Oo0.(A_0.Theme, New Object() { Me })
			Me.Font = New Font(O00OOOo_O0_O.b("ៀ췒", a_), 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			MyBase.AutoResize = False
			If Environment.OSVersion.Version.Major >= 6 Then
				Me.BorderStyle = 0
			Else
				Me.BorderStyle = 4
			End If
			MyBase.Glyphs(8) = O_oOooO_O.o_.o.
			MyBase.Styles.Normal.WordWrap = True
			MyBase.FocusRect = 3
			MyBase.AllowResizing = 3
			MyBase.Cols.DefaultSize = 70
			MyBase.AllowSorting = 0
			MyBase.AllowMerging = 7
			MyBase.AllowMergingFixed = 5
			MyBase.EditOptions = 99
			MyBase.Styles.Normal.BackColor = Color.White
			MyBase.ShowSort = False
			Me.o.0O_O0o_. = A_0
			MyBase.DataSource = A_0.View
			MyBase.Cols.MinSize = 16
			MyBase.DrawMode = 1
			Me.CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap()
			Me.Oo0._0.()
		End Sub

		' Token: 0x06000436 RID: 1078 RVA: 0x000101B4 File Offset: 0x0000E3B4
		Friend Overloads Function <<EMPTY_NAME>>() As LookAndFeelProperty
			Return Me.O_._.
		End Function

		' Token: 0x06000437 RID: 1079 RVA: 0x000101BC File Offset: 0x0000E3BC
		Friend Sub <<EMPTY_NAME>>(A_0 As LookAndFeelProperty)
			Me.O_._. = A_0
		End Sub

		' Token: 0x06000438 RID: 1080 RVA: 0x000101C5 File Offset: 0x0000E3C5
		Friend Sub <<EMPTY_NAME>>()
			Me.o.0O_O0o_. = Nothing
			Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me })
		End Sub

		' Token: 0x06000439 RID: 1081 RVA: 0x000101E4 File Offset: 0x0000E3E4
		Friend Function <<EMPTY_NAME>>() As Boolean
			If Me.O0._0O. Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetUserData(MyBase.Rows.Fixed, 0))
				If objectValue IsNot Nothing Then
					Return Operators.CompareString(objectValue.ToString(), "GridTreeMode", True) = 0
				End If
			End If
			Return False
		End Function

		' Token: 0x0600043A RID: 1082 RVA: 0x0001022E File Offset: 0x0000E42E
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O0._0O. = A_0
		End Sub

		' Token: 0x0600043B RID: 1083 RVA: 0x00010238 File Offset: 0x0000E438
		Friend Sub <<EMPTY_NAME>>()
			Me.OO0o_o_OO.O_O.(Me.o.0O_O0o_..DataTable.frd_LookAndFeel)
			Me.BeginUpdate()
			MyBase.Styles.Fixed.TextAlign = 4
			MyBase.Styles.SelectedRowHeader.TextAlign = 4
			Select Case Me.OO_.00oO0Oo.().GridStyle
				Case 1
					MyBase.Styles.Normal.Border.Style = 7
				Case 2
					MyBase.Styles.Normal.Border.Style = 2
				Case 3
					MyBase.Styles.Normal.Border.Style = 6
				Case 4
					MyBase.Styles.Normal.Border.Style = 1
				Case 5
					MyBase.Styles.Normal.Border.Style = 5
				Case 6
					MyBase.Styles.Normal.Border.Style = 4
				Case 7
					MyBase.Styles.Normal.Border.Style = 0
				Case 8
					MyBase.Styles.Normal.Border.Style = 3
			End Select
			Select Case Me.OO_.00oO0Oo.().GridWidth
				Case 1
					MyBase.Styles.Normal.Border.Width = 0
				Case 2
					MyBase.Styles.Normal.Border.Width = 1
				Case 3
					MyBase.Styles.Normal.Border.Width = 2
				Case 4
					MyBase.Styles.Normal.Border.Width = 3
			End Select
			Select Case Me.OO_.00oO0Oo.().GridLineDirection
				Case 0
					MyBase.Styles.Normal.Border.Direction = 0
				Case 1
					MyBase.Styles.Normal.Border.Direction = 1
				Case 2
					MyBase.Styles.Normal.Border.Direction = 2
			End Select
			If Me.OO_.00oO0Oo.().GridColor <> Color.Transparent Then
				MyBase.Styles.Normal.Border.Color = Me.OO_.00oO0Oo.().GridColor
			End If
			MyBase.Styles.EmptyArea.Border.Width = 0
			If Me.OO_.00oO0Oo.().BackColor <> Color.Transparent Then
				MyBase.Styles.Normal.BackColor = Me.OO_.00oO0Oo.().BackColor
			End If
			If Me.OO_.00oO0Oo.().ForeColor <> Color.Transparent Then
				MyBase.Styles.Normal.ForeColor = Me.OO_.00oO0Oo.().ForeColor
			End If
			If Me.OO_.00oO0Oo.().FixedForeColor <> Color.Transparent Then
				MyBase.Styles.Fixed.ForeColor = Me.OO_.00oO0Oo.().FixedForeColor
			End If
			If Me.OO_.00oO0Oo.().FixedBackColor <> Color.Transparent Then
				MyBase.Styles.Fixed.BackColor = Me.OO_.00oO0Oo.().FixedBackColor
			End If
			If Me.OO_.00oO0Oo.().HighlightBackColor <> Color.Transparent Then
				MyBase.Styles.Highlight.BackColor = Me.OO_.00oO0Oo.().HighlightBackColor
			End If
			If Me.OO_.00oO0Oo.().HighlightForeColor <> Color.Transparent Then
				MyBase.Styles.Highlight.ForeColor = Me.OO_.00oO0Oo.().HighlightForeColor
			End If
			If Me.OO_.00oO0Oo.().FrozenBackColor <> Color.Transparent Then
				MyBase.Styles.Frozen.BackColor = Me.OO_.00oO0Oo.().FrozenBackColor
			End If
			If Me.OO_.00oO0Oo.().frozenForeColor <> Color.Transparent Then
				MyBase.Styles.Frozen.ForeColor = Me.OO_.00oO0Oo.().frozenForeColor
			End If
			If Not Me.OO_.00oO0Oo.() Then
				Dim color As Color = Me.OooO_0_o0Oo0.0.()
				If color <> Color.Transparent Then
					MyBase.Styles.Alternate.BackColor = color
				End If
				color = Me.OO_.00oO0Oo.()
				If color <> Color.Transparent Then
					MyBase.Styles.Alternate.ForeColor = color
				End If
				MyBase.Styles.Alternate.Clear(1)
			Else
				MyBase.Styles.Alternate.Clear()
			End If
			If Me.OO_.00oO0Oo.().SelectedHeaderBackColor <> Color.Transparent Then
				MyBase.Styles.SelectedRowHeader.BackColor = Me.OO_.00oO0Oo.().SelectedHeaderBackColor
				MyBase.Styles.SelectedColumnHeader.BackColor = Me.OO_.00oO0Oo.().SelectedHeaderBackColor
			End If
			If Me.OO_.00oO0Oo.().SelectedHeaderForeColor <> Color.Transparent Then
				MyBase.Styles.SelectedRowHeader.ForeColor = Me.OO_.00oO0Oo.().SelectedHeaderForeColor
				MyBase.Styles.SelectedColumnHeader.ForeColor = Me.OO_.00oO0Oo.().SelectedHeaderForeColor
			End If
			If Me.OO_.00oO0Oo.().EmptyBackColor <> Color.Transparent Then
				MyBase.Styles.EmptyArea.BackColor = Me.OO_.00oO0Oo.().EmptyBackColor
			End If
			If Me.OO_.00oO0Oo.().GrandTotalBackColor <> Color.Transparent Then
				MyBase.Styles(13).BackColor = Me.OO_.00oO0Oo.().GrandTotalBackColor
			End If
			If Me.OO_.00oO0Oo.().GrandTotalForeColor <> Color.Transparent Then
				MyBase.Styles(13).ForeColor = Me.OO_.00oO0Oo.().GrandTotalForeColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal0BackColor <> Color.Transparent Then
				MyBase.Styles(14).BackColor = Me.OO_.00oO0Oo.().Subtotal0BackColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal0ForeColor <> Color.Transparent Then
				MyBase.Styles(14).ForeColor = Me.OO_.00oO0Oo.().Subtotal0ForeColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal1BackColor <> Color.Transparent Then
				MyBase.Styles(15).BackColor = Me.OO_.00oO0Oo.().Subtotal1BackColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal1ForeColor <> Color.Transparent Then
				MyBase.Styles(15).ForeColor = Me.OO_.00oO0Oo.().Subtotal1ForeColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal2BackColor <> Color.Transparent Then
				MyBase.Styles(16).BackColor = Me.OO_.00oO0Oo.().Subtotal2BackColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal2ForeColor <> Color.Transparent Then
				MyBase.Styles(16).ForeColor = Me.OO_.00oO0Oo.().Subtotal2ForeColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal3BackColor <> Color.Transparent Then
				MyBase.Styles(17).BackColor = Me.OO_.00oO0Oo.().Subtotal3BackColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal3ForeColor <> Color.Transparent Then
				MyBase.Styles(17).ForeColor = Me.OO_.00oO0Oo.().Subtotal3ForeColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal4BackColor <> Color.Transparent Then
				MyBase.Styles(18).BackColor = Me.OO_.00oO0Oo.().Subtotal4BackColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal4ForeColor <> Color.Transparent Then
				MyBase.Styles(18).ForeColor = Me.OO_.00oO0Oo.().Subtotal4ForeColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal5BackColor <> Color.Transparent Then
				MyBase.Styles(19).BackColor = Me.OO_.00oO0Oo.().Subtotal5BackColor
			End If
			If Me.OO_.00oO0Oo.().Subtotal5ForeColor <> Color.Transparent Then
				MyBase.Styles(19).ForeColor = Me.OO_.00oO0Oo.().Subtotal5ForeColor
			End If
			MyBase.Styles.Fixed.WordWrap = True
			MyBase.Styles.Normal.Trimming = StringTrimming.Character
			MyBase.Styles.Fixed.Trimming = StringTrimming.Character
			Me.o.0o_O.()
			Me.O._0ooo00o.()
			If Me.OO_.00oO0Oo.().FocusBackColor <> Color.Transparent Then
				MyBase.Styles.Focus.BackColor = Me.OO_.00oO0Oo.().FocusBackColor
			ElseIf Me.o.0O_O0o_..ListMode Then
				MyBase.Styles.Focus.BackColor = MyBase.Styles("CurrentRow").BackColor
			Else
				MyBase.Styles.Focus.BackColor = MyBase.Styles.Normal.BackColor
			End If
			If Me.OO_.00oO0Oo.().FocusForeColor <> Color.Transparent Then
				MyBase.Styles.Focus.ForeColor = Me.OO_.00oO0Oo.().FocusForeColor
			End If
			MyBase.Invalidate()
			Me.EndUpdate()
		End Sub

		' Token: 0x0600043C RID: 1084 RVA: 0x00010B6C File Offset: 0x0000ED6C
		Private Overloads Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			Select Case Me.OO_.00oO0Oo.().DisableAlterRowMode
				Case 0
					result = (O_O0OO.O0_00o.o0__o..DisableAlterRowMode = 1 OrElse (O_O0OO.O0_00o.o0__o..DisableAlterRowMode <> 2 AndAlso O_O0OO.o0O._O00o.))
				Case 1
					result = True
				Case 2
					result = False
			End Select
			Return result
		End Function

		' Token: 0x0600043D RID: 1085 RVA: 0x00010BCC File Offset: 0x0000EDCC
		Private Function <<EMPTY_NAME>>() As Color
			Dim result As Color
			If Me.OO_.00oO0Oo.().AlterRowBackColor = Color.Transparent Then
				If O_O0OO.O0_00o.o0__o..AlterRowBackColor = Color.Transparent Then
					result = O_O0OO.O0_00o.o0__o.
				Else
					result = O_O0OO.O0_00o.o0__o..AlterRowBackColor
				End If
			Else
				result = Me.OO_.00oO0Oo.().AlterRowBackColor
			End If
			Return result
		End Function

		' Token: 0x0600043E RID: 1086 RVA: 0x00010C28 File Offset: 0x0000EE28
		Private Overloads Function <<EMPTY_NAME>>() As Color
			Dim result As Color
			If Me.OO_.00oO0Oo.().AlterRowForeColor = Color.Transparent Then
				If O_O0OO.O0_00o.o0__o..AlterRowForeColor = Color.Transparent Then
					result = O_O0OO.oo0_o_.o.
				Else
					result = O_O0OO.O0_00o.o0__o..AlterRowForeColor
				End If
			Else
				result = Me.OO_.00oO0Oo.().AlterRowForeColor
			End If
			Return result
		End Function

		' Token: 0x0600043F RID: 1087 RVA: 0x00010C84 File Offset: 0x0000EE84
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each obj As Object In MyBase.Styles
					Dim cellStyle As CellStyle = CType(obj, CellStyle)
					If Operators.CompareString(Conversions.ToString(cellStyle.UserData), "Row", True) = 0 Then
						MyBase.Styles.Remove(cellStyle)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim cellStyle2 As CellStyle = MyBase.Styles.Add("LockedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().LockedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("SelectedLockedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.SelectedRowHeader)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().LockedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("UnchangedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().UnchangedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("SelectedUnchangedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.SelectedRowHeader)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().UnchangedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("ModifiedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().ModifiedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("SelectedModifiedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.SelectedRowHeader)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().ModifiedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("LockedModifiedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().LockedModifiedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("SelectedLockedModifiedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.SelectedRowHeader)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().LockedModifiedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("AddedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().AddedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("SelectedAddedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.SelectedRowHeader)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().AddedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("LockedAddedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().LockedAddedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("SelectedLockedAddedRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.SelectedRowHeader)
			cellStyle2.ForeColor = Me.OO_.00oO0Oo.().LockedAddedRowHeaderForeColor
			cellStyle2 = MyBase.Styles.Add("ModifiedCell")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Normal)
			If Me.OO_.00oO0Oo.().ModifiedCellBackColor = Color.Transparent Then
				cellStyle2.BackColor = Color.Red
			Else
				cellStyle2.BackColor = Me.OO_.00oO0Oo.().ModifiedCellBackColor
			End If
			If Me.OO_.00oO0Oo.().ModifiedCellForeColor = Color.Transparent Then
				cellStyle2.ForeColor = Color.White
			Else
				cellStyle2.ForeColor = Me.OO_.00oO0Oo.().ModifiedCellForeColor
			End If
			cellStyle2.Clear(1)
			cellStyle2 = MyBase.Styles.Add("CurrentRow")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Normal)
			If Me.OO_.00oO0Oo.().CurrentRowBackColor = Color.Transparent Then
				cellStyle2.BackColor = Color.FloralWhite
			Else
				cellStyle2.BackColor = Me.OO_.00oO0Oo.().CurrentRowBackColor
			End If
			If Me.OO_.00oO0Oo.().CurrentRowForeColor = Color.Transparent Then
				cellStyle2.ForeColor = SystemColors.ControlText
			Else
				cellStyle2.ForeColor = Me.OO_.00oO0Oo.().CurrentRowForeColor
			End If
			cellStyle2.Clear(1)
			cellStyle2 = MyBase.Styles.Add("GrandTotalRowHeader")
			cellStyle2.UserData = "Row"
			cellStyle2.MergeWith(MyBase.Styles.Fixed)
			cellStyle2.ImageAlign = 12
			MyBase.Styles.Fixed.ImageAlign = 7
			MyBase.Cols(0).TextAlign = 4
			MyBase.Cols(0).ImageAlign = 4
			MyBase.GetCellRange(0, 0).StyleNew.ImageAlign = 4
		End Sub

		' Token: 0x06000440 RID: 1088 RVA: 0x000111A4 File Offset: 0x0000F3A4
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each obj As Object In MyBase.Styles
					Dim cellStyle As CellStyle = CType(obj, CellStyle)
					If Operators.CompareString(Conversions.ToString(cellStyle.UserData), "User", True) = 0 Then
						MyBase.Styles.Remove(cellStyle)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Operators.CompareString(Me.o.0O_O0o_..DataTable.frd_LookAndFeel.UserStyle, "", True) <> 0 Then
				For Each a_ As String In Me.o.0O_O0o_..DataTable.frd_LookAndFeel.UserStyle.Split(New Char() { vbCr })
					Dim cellStyleProperty As CellStyleProperty = New CellStyleProperty()
					o_O_o_oOoo__.OOOO_OO._oo.(cellStyleProperty, a_, vbLf)
					Dim cellStyle2 As CellStyle = MyBase.Styles.Add("User" + cellStyleProperty.Name)
					cellStyle2.UserData = "User"
					If cellStyleProperty.BackColor <> Color.Empty Then
						cellStyle2.BackColor = cellStyleProperty.BackColor
					End If
					If cellStyleProperty.ForeColor <> Color.Empty Then
						cellStyle2.ForeColor = cellStyleProperty.ForeColor
					End If
					If cellStyleProperty.FontBold OrElse cellStyleProperty.FontStrikeout OrElse cellStyleProperty.FontUnderLine Then
						Dim fontStyle As FontStyle
						If cellStyleProperty.FontBold Then
							fontStyle = FontStyle.Bold
						End If
						If cellStyleProperty.FontStrikeout Then
							fontStyle = fontStyle Or FontStyle.Strikeout
						End If
						If cellStyleProperty.FontUnderLine Then
							fontStyle = fontStyle Or FontStyle.Underline
						End If
						cellStyle2.Font = New Font(cellStyle2.Font, fontStyle)
					End If
				Next
			End If
		End Sub

		' Token: 0x06000441 RID: 1089 RVA: 0x0001135C File Offset: 0x0000F55C
		Public Overrides Overloads Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As Boolean) As CellRange
			Dim result As CellRange
			If MyBase.Disposing OrElse MyBase.IsDisposed OrElse MyBase.FindForm() Is Nothing OrElse Me.o.0O_O0o_. Is Nothing Then
				result = Nothing
			ElseIf A_0 < 0 OrElse A_0 > MyBase.Rows.Count - 1 Then
				result = Nothing
			ElseIf A_0 >= MyBase.Rows.Fixed AndAlso MyBase.Rows(A_0).DataIndex < 0 AndAlso A_1 >= 1 Then
				Dim cellRange As CellRange = MyBase.GetCellRange(A_0, A_1)
				Dim cellRange2 As CellRange = MyBase.GetCellRange(A_0, 1)
				If Me.o.0O_O0o_..SpillNode AndAlso MyBase.Rows(A_0).IsNode Then
					Dim num As Integer = MyBase.Cols.Count - 1
					If MyBase.Cols.Frozen > 0 Then
						num = Math.Min(num, MyBase.Cols.Frozen)
					End If
					Dim num2 As Integer = cellRange2.c2 + 1
					Dim num3 As Integer = num
					Dim num4 As Integer = num2
					While num4 <= num3 AndAlso Operators.CompareString(Me.GetDataDisplay(A_0, num4), "", True) = 0
						cellRange2.c2 = num4
						num4 += 1
					End While
				End If
				If cellRange2.Contains(A_0, A_1) Then
					result = cellRange2
				Else
					result = cellRange
				End If
			ElseIf A_1 < MyBase.Cols.Fixed OrElse A_0 > MyBase.Rows.Fixed - 1 Then
				result = MyBase.GetMergedRange(A_0, A_1, A_2)
			ElseIf A_0 > MyBase.Rows.Count - 1 OrElse A_1 > MyBase.Cols.Count - 1 Then
				result = MyBase.GetMergedRange(A_0, A_1, A_2)
			ElseIf A_0 < 0 Then
				result = MyBase.GetMergedRange(A_0, A_1, A_2)
			Else
				Dim cellRange3 As CellRange = MyBase.GetCellRange(A_0, A_1)
				Dim dataDisplay As String = Me.GetDataDisplay(A_0, A_1)
				If Operators.CompareString(dataDisplay, "", True) = 0 Then
					result = cellRange3
				Else
					Dim num5 As Integer = cellRange3.r2 + 1
					Dim num6 As Integer = MyBase.Rows.Fixed - 1
					Dim num7 As Integer = num5
					While num7 <= num6 AndAlso Operators.CompareString(Me.GetDataDisplay(num7, A_1), dataDisplay, True) = 0
						cellRange3.r2 = num7
						num7 += 1
					End While
					Dim num8 As Integer = cellRange3.r1 - 1
					While num8 >= 0 AndAlso Operators.CompareString(Me.GetDataDisplay(num8, A_1), dataDisplay, True) = 0
						cellRange3.r1 = num8
						num8 += -1
					End While
					Dim clip As String = cellRange3.Clip
					Dim num9 As Integer = cellRange3.c2 + 1
					Dim num10 As Integer = MyBase.Cols.Count - 1
					Dim num11 As Integer = num9
					While num11 <= num10 AndAlso Operators.CompareString(Me.OO_.00oO0Oo.(MyBase.GetCellRange(cellRange3.r1, num11, cellRange3.r2, num11)), clip, True) = 0 AndAlso (cellRange3.r1 = 0 OrElse Operators.CompareString(Me.GetDataDisplay(cellRange3.r1 - 1, num11), dataDisplay, True) <> 0) AndAlso (cellRange3.r2 = MyBase.Rows.Fixed - 1 OrElse Operators.CompareString(Me.GetDataDisplay(cellRange3.r2 + 1, num11), dataDisplay, True) <> 0) AndAlso (cellRange3.r1 <= 0 OrElse Operators.CompareString(Me.GetDataDisplay(cellRange3.r1 - 1, cellRange3.c2), Me.GetDataDisplay(cellRange3.r1 - 1, num11), True) = 0)
						cellRange3.c2 = num11
						num11 += 1
					End While
					Dim num12 As Integer = cellRange3.c1 - 1
					Dim fixed As Integer = MyBase.Cols.Fixed
					Dim num13 As Integer = num12
					While num13 >= fixed AndAlso Operators.CompareString(Me.OO_.00oO0Oo.(MyBase.GetCellRange(cellRange3.r1, num13, cellRange3.r2, num13)), clip, True) = 0 AndAlso (cellRange3.r1 = 0 OrElse Operators.CompareString(Me.GetDataDisplay(cellRange3.r1 - 1, num13), dataDisplay, True) <> 0) AndAlso (cellRange3.r2 = MyBase.Rows.Fixed - 1 OrElse Operators.CompareString(Me.GetDataDisplay(cellRange3.r2 + 1, num13), dataDisplay, True) <> 0) AndAlso (cellRange3.r1 <= 0 OrElse Operators.CompareString(Me.GetDataDisplay(cellRange3.r1 - 1, cellRange3.c1), Me.GetDataDisplay(cellRange3.r1 - 1, num13), True) = 0)
						cellRange3.c1 = num13
						num13 += -1
					End While
					result = cellRange3
				End If
			End If
			Return result
		End Function

		' Token: 0x06000442 RID: 1090 RVA: 0x000117A0 File Offset: 0x0000F9A0
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As RecordGrid)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If MyBase.Rows(A_0).DataIndex = -1 Then
					GoTo IL_CEE
				End If
				IL_20:
				num2 = 4
				Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_0).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1).Name), Nothing)
				IL_7C:
				num2 = 5
				Dim a_ As String = "CellButtonClick"
				IL_85:
				num2 = 6
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_BB:
				num2 = 7
				If MyBase.Disposing OrElse MyBase.IsDisposed OrElse Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.CellButtonClick OrElse rowColEventArgs.Cancel Then
					GoTo IL_11E
				End If
				IL_FE:
				num2 = 8
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColEventArgs }, False, "全局表事件", False)
				IL_11E:
				num2 = 9
				If rowColEventArgs.Cancel Then
					GoTo IL_CEE
				End If
				IL_12C:
				num2 = 11
				Dim name As String = MyBase.Cols(A_1).Name
				IL_142:
				num2 = 12
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 5 OrElse MyBase.Cols(A_1).DataType IsNot GetType(Integer) Then
					GoTo IL_265
				End If
				IL_187:
				num2 = 13
				If MyBase(A_0, A_1) Is Nothing OrElse MyBase(A_0, A_1) Is DBNull.Value Then
					GoTo IL_1B5
				End If
				IL_1A3:
				num2 = 14
				Dim argb As Integer = Conversions.ToInteger(MyBase(A_0, A_1))
				IL_1B5:
				num2 = 15
				Dim colorDialog As ColorDialog = New ColorDialog()
				IL_1BF:
				num2 = 16
				colorDialog.Color = Color.FromArgb(argb)
				IL_1D0:
				num2 = 17
				colorDialog.FullOpen = True
				IL_1DB:
				num2 = 18
				If colorDialog.ShowDialog() <> DialogResult.OK Then
					GoTo IL_CEE
				End If
				IL_1EB:
				num2 = 19
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_0).DataIndex).Row, MyBase.Cols(A_1).Name))
				IL_240:
				num2 = 20
				MyBase(A_0, A_1) = colorDialog.Color.ToArgb()
				GoTo IL_CEE
				IL_265:
				num2 = 22
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 1 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_38F
				End If
				IL_2AA:
				num2 = 23
				Dim text As String = ""
				IL_2B4:
				num2 = 24
				Dim topRow As Integer = Me.Selection.TopRow
				Dim bottomRow As Integer = Me.Selection.BottomRow
				For i As Integer = topRow To bottomRow
					IL_2DB:
					num2 = 25
					If MyBase.Rows(i).DataIndex <> -1 Then
						IL_2F3:
						num2 = 27
						Dim text2 As String = MyBase(i, A_1).ToString().ToLower()
						IL_30B:
						num2 = 28
						If LikeOperator.LikeString(text2, "*@*.*[a-z]", CompareMethod.Text) Then
							IL_31D:
							num2 = 29
							If Operators.CompareString(text, "", True) = 0 Then
								IL_32F:
								num2 = 30
								text = text2
							Else
								IL_338:
								num2 = 32
								text = text + ";" + text2
							End If
						End If
					End If
					IL_34B:
					num2 = 33
				Next
				IL_35A:
				num2 = 34
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_CEE
				End If
				IL_370:
				num2 = 35
				Me.OO0o_o_OO.O_O.("mailto:" + text, "无效邮件地址！")
				GoTo IL_CEE
				IL_38F:
				num2 = 37
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 6 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_52E
				End If
				IL_3D4:
				num2 = 38
				Dim form As System.Windows.Forms.Form = New System.Windows.Forms.Form()
				IL_3DE:
				num2 = 39
				form.Text = "文件管理器"
				IL_3ED:
				num2 = 40
				form.MinimizeBox = False
				IL_3F8:
				num2 = 41
				form.MaximizeBox = False
				IL_403:
				num2 = 42
				form.FormBorderStyle = FormBorderStyle.FixedDialog
				IL_40E:
				num2 = 43
				form.StartPosition = FormStartPosition.CenterScreen
				IL_419:
				num2 = 44
				form.ShowInTaskbar = False
				IL_424:
				num2 = 45
				form.Size = New Size(350, 500)
				IL_43D:
				num2 = 46
				form.FormBorderStyle = FormBorderStyle.Sizable
				IL_448:
				num2 = 47
				Dim fileManager As FileManager = New FileManager()
				IL_452:
				num2 = 48
				Dim dataCol As DataCol = Me.o.0O_O0o_..Cols(name).DataCol
				IL_46E:
				num2 = 49
				fileManager.Dock = DockStyle.Fill
				IL_479:
				num2 = 50
				fileManager.FTPclient = dataCol.FTPClient
				IL_48A:
				num2 = 51
				fileManager.DataBindings.Add("FileString", Me.o.0O_O0o_..View, name)
				IL_4AC:
				num2 = 52
				fileManager.AutoUpdate = dataCol.AutoUpdate
				IL_4BD:
				num2 = 53
				form.Controls.Add(fileManager)
				IL_4CE:
				num2 = 54
				form.ShowDialog()
				IL_4D9:
				num2 = 55
				If fileManager.FTPclient Is Nothing Then
					GoTo IL_510
				End If
				IL_4E5:
				num2 = 56
				If Not fileManager.FTPclient.Connected Then
					GoTo IL_505
				End If
				IL_4F6:
				num2 = 57
				fileManager.FTPclient.Close()
				IL_505:
				num2 = 58
				fileManager.FTPclient = Nothing
				IL_510:
				num2 = 59
				fileManager.DataBindings.Clear()
				IL_51F:
				num2 = 60
				fileManager.Dispose()
				GoTo IL_CEE
				IL_52E:
				num2 = 62
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 4 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_6DE
				End If
				IL_573:
				num2 = 63
				Dim form2 As System.Windows.Forms.Form = New System.Windows.Forms.Form()
				IL_57D:
				num2 = 64
				form2.Text = "图片管理器"
				IL_58C:
				num2 = 65
				form2.MinimizeBox = False
				IL_597:
				num2 = 66
				form2.MaximizeBox = False
				IL_5A2:
				num2 = 67
				form2.FormBorderStyle = FormBorderStyle.FixedDialog
				IL_5AD:
				num2 = 68
				form2.StartPosition = FormStartPosition.CenterScreen
				IL_5B8:
				num2 = 69
				form2.ShowInTaskbar = False
				IL_5C3:
				num2 = 70
				form2.Size = New Size(350, 500)
				IL_5DC:
				num2 = 71
				form2.FormBorderStyle = FormBorderStyle.Sizable
				IL_5E7:
				num2 = 72
				Dim dataCol2 As DataCol = Me.o.0O_O0o_..Cols(name).DataCol
				IL_603:
				num2 = 73
				Dim pictureViewer As PictureViewer = New PictureViewer()
				IL_60D:
				num2 = 74
				pictureViewer.FTPclient = dataCol2.FTPClient
				IL_61E:
				num2 = 75
				pictureViewer.Dock = DockStyle.Fill
				IL_629:
				num2 = 76
				pictureViewer.DataBindings.Add("ImageFiles", Me.o.0O_O0o_..View, name)
				IL_64B:
				num2 = 77
				pictureViewer.AutoDownLoad = dataCol2.AutoDownload
				IL_65C:
				num2 = 78
				pictureViewer.AutoUpdate = dataCol2.AutoUpdate
				IL_66D:
				num2 = 79
				form2.Controls.Add(pictureViewer)
				IL_67E:
				num2 = 80
				form2.ShowDialog()
				IL_689:
				num2 = 81
				If pictureViewer.FTPclient Is Nothing Then
					GoTo IL_6C0
				End If
				IL_695:
				num2 = 82
				If Not pictureViewer.FTPclient.Connected Then
					GoTo IL_6B5
				End If
				IL_6A6:
				num2 = 83
				pictureViewer.FTPclient.Close()
				IL_6B5:
				num2 = 84
				pictureViewer.FTPclient = Nothing
				IL_6C0:
				num2 = 85
				pictureViewer.DataBindings.Clear()
				IL_6CF:
				num2 = 86
				pictureViewer.Dispose()
				GoTo IL_CEE
				IL_6DE:
				num2 = 88
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 2 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_7BE
				End If
				IL_723:
				num2 = 89
				If MyBase(A_0, A_1) Is Nothing OrElse MyBase(A_0, A_1) Is DBNull.Value Then
					GoTo IL_CEE
				End If
				IL_745:
				num2 = 90
				Dim text3 As String = MyBase(A_0, A_1).ToString().ToLower()
				IL_75C:
				num2 = 91
				If Not text3.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) AndAlso Not text3.StartsWith("www.", StringComparison.CurrentCultureIgnoreCase) AndAlso Not text3.StartsWith("ftp.", StringComparison.CurrentCultureIgnoreCase) AndAlso Not text3.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_CEE
				End If
				IL_79E:
				num2 = 92
				Me.OO0o_o_OO.O_O.(MyBase(A_0, A_1).ToString(), "无效网址！")
				GoTo IL_CEE
				IL_7BE:
				num2 = 94
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 9 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_868
				End If
				IL_801:
				num2 = 95
				If MyBase(A_0, A_1) Is Nothing OrElse MyBase(A_0, A_1) Is DBNull.Value Then
					GoTo IL_CEE
				End If
				IL_823:
				num2 = 96
				Dim text4 As String = MyBase(A_0, A_1).ToString().ToLower()
				IL_83A:
				num2 = 97
				If Not Versioned.IsNumeric(text4) Then
					GoTo IL_CEE
				End If
				IL_849:
				num2 = 98
				Me.OO0o_o_OO.O_O.("tencent://message/?uin=" + text4, "无效QQ号！")
				GoTo IL_CEE
				IL_868:
				num2 = 100
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 10 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_900
				End If
				IL_8A8:
				num2 = 101
				If MyBase(A_0, A_1) Is Nothing OrElse MyBase(A_0, A_1) Is DBNull.Value Then
					GoTo IL_CEE
				End If
				IL_8CA:
				num2 = 102
				Dim str As String = MyBase(A_0, A_1).ToString().ToLower()
				IL_8E1:
				num2 = 103
				Me.OO0o_o_OO.O_O.("aliim:sendmsg?touid=cntaobao" + str, "无效旺旺号！")
				GoTo IL_CEE
				IL_900:
				num2 = 105
				If Me.o.0O_O0o_..Cols(name).DataCol.ExtendColumnType <> 3 OrElse MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_BD8
				End If
				IL_945:
				num2 = 106
				Dim contextMenu As ContextMenu = New ContextMenu()
				IL_94F:
				num2 = 107
				Dim text5 As String = Nothing
				IL_955:
				num2 = 108
				If MyBase(A_0, A_1) Is Nothing OrElse MyBase(A_0, A_1) Is DBNull.Value Then
					GoTo IL_983
				End If
				IL_971:
				num2 = 109
				text5 = MyBase(A_0, A_1).ToString()
				IL_983:
				num2 = 110
				If Operators.CompareString(text5, "", True) <= 0 Then
					GoTo IL_A41
				End If
				IL_999:
				num2 = 111
				If Not text5.StartsWith("[") OrElse Not text5.EndsWith("]") Then
					GoTo IL_9E7
				End If
				IL_9B8:
				num2 = 112
				Dim item As MenuItem = New MenuItem("打开目录(&O)", AddressOf Me.O__.0_O.)
				IL_9D3:
				num2 = 113
				contextMenu.MenuItems.Add(item)
				GoTo IL_A41
				IL_9E7:
				num2 = 115
				item = New MenuItem("打开文件(&O)", AddressOf Me.O__.0_O.)
				IL_A02:
				num2 = 116
				contextMenu.MenuItems.Add(item)
				IL_A14:
				num2 = 117
				item = New MenuItem("另存文件(&S)", AddressOf Me.o.o0OO00oO_0.)
				IL_A2F:
				num2 = 118
				contextMenu.MenuItems.Add(item)
				IL_A41:
				num2 = 119
				item = New MenuItem("插入文件(&F)", AddressOf Me.o0o0o0.oooOO0.)
				IL_A5C:
				num2 = 120
				contextMenu.MenuItems.Add(item)
				IL_A6E:
				num2 = 121
				item = New MenuItem("插入目录(&D)", AddressOf Me.o0o0__.o.)
				IL_A89:
				num2 = 122
				contextMenu.MenuItems.Add(item)
				IL_A9B:
				num2 = 123
				If Operators.CompareString(text5, "", True) <= 0 Then
					GoTo IL_AFC
				End If
				IL_AAE:
				num2 = 124
				item = New MenuItem("-")
				IL_ABD:
				num2 = 125
				contextMenu.MenuItems.Add(item)
				IL_ACF:
				num2 = 126
				item = New MenuItem("清除内容(&C)", AddressOf Me.oO0O00o0o.O.)
				IL_AEA:
				num2 = 127
				contextMenu.MenuItems.Add(item)
				IL_AFC:
				num2 = 128
				If A_2 IsNot Nothing Then
					GoTo IL_B62
				End If
				IL_B05:
				num2 = 129
				contextMenu.Show(Me, New Point(MyBase.Cols(A_1).Right - 16 + MyBase.ScrollPosition.X, MyBase.Rows(A_0).Bottom + MyBase.ScrollPosition.Y))
				GoTo IL_CEE
				IL_B62:
				num2 = 131
				Dim baseGrid As C1FlexGrid = A_2.BaseGrid
				IL_B70:
				num2 = 132
				contextMenu.Show(baseGrid, New Point(baseGrid.Cols(1).Right - 16 + baseGrid.ScrollPosition.X, baseGrid.Rows(baseGrid.Row).Bottom + baseGrid.ScrollPosition.Y))
				GoTo IL_CEE
				IL_BD8:
				num2 = 134
				If MyBase.Cols(A_1).DataType IsNot GetType(String) Then
					GoTo IL_CEE
				End If
				IL_BFE:
				num2 = 135
				Dim o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u As O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000 = New O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000()
				IL_C0B:
				num2 = 136
				If MyBase.Rows(MyBase.Row).DataIndex < 0 Then
					GoTo IL_CEE
				End If
				IL_C2D:
				num2 = 138
				Dim row As DataRow = Me.o.0O_O0o_..View.o_o.O0ooOo.().Row
				IL_C4A:
				num2 = 139
				If row.IsNull(name) Then
					GoTo IL_C7B
				End If
				IL_C5B:
				num2 = 140
				o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.O0.00o__OO.().Value = row(name).ToString()
				IL_C7B:
				num2 = 141
				o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.Text = o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.Text + " - " + name
				IL_C9B:
				num2 = 142
				If o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.ShowDialog() <> DialogResult.OK Then
					GoTo IL_CEE
				End If
				IL_CAB:
				num2 = 143
				If Operators.CompareString(o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.O0.00o__OO.().Text, row(name).ToString(), True) = 0 Then
					GoTo IL_CEE
				End If
				IL_CD3:
				num2 = 144
				row(name) = o_u3002_u3002_u3002_u3000_u3002_u3002_u3002_u3002_u.O0.00o__OO.().Text
				IL_CEE:
				GoTo IL_F84
				IL_CF3:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_F45:
				GoTo IL_F79
				IL_F47:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F57:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_F47
			End Try
			IL_F79:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F84:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000443 RID: 1091 RVA: 0x00012758 File Offset: 0x00010958
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Try
				Process.Start(A_0)
			Catch ex As Exception
				MessageBox.Show(A_1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End Try
		End Sub

		' Token: 0x06000444 RID: 1092 RVA: 0x0001279C File Offset: 0x0001099C
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer, A_2 As RecordGrid)
			If MyBase.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_. IsNot Nothing AndAlso A_0 >= 0 AndAlso A_1 <> 0 AndAlso A_0 < MyBase.Rows.Count AndAlso MyBase.Rows(A_0).DataIndex <> -1 Then
				Dim row As DataRow = Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_0).DataIndex).Row
				If row.RowState <> DataRowState.Detached AndAlso row.HasVersion(DataRowVersion.Proposed) Then
					row.CancelEdit()
					Return
				End If
				Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_0).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1).Name), A_2)
				Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.O0O00o_.0Oo.
				If methodInfo IsNot Nothing AndAlso OO_00oOO.SystemReady Then
					Try
						methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "表，" + Me.o.0O_O0o_..DataTable.Name + "，AfterEdit")
					End Try
				End If
				If Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterEdit AndAlso OO_00oOO.SystemReady Then
					methodInfo = O_O0OO.O0_00o.o0__o..o0Oo.Oo_0oO0o.
					If methodInfo IsNot Nothing Then
						Try
							methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
						Catch a_2 As Exception
							ooO.oOo0Oo.o.(a_2, "全局表事件，AfterEdit")
						End Try
					End If
				End If
				If Me.o_.o. IsNot Nothing Then
					Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(Me.o_.o.)
					Me.o_.o. = Nothing
				End If
			End If
		End Sub

		' Token: 0x06000445 RID: 1093 RVA: 0x000129A4 File Offset: 0x00010BA4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Me.O.O0_0.(A_1.Row, A_1.Col, Nothing)
			If MyBase.Row <> A_1.Row AndAlso Me.o.0O_O0o_..Name.Length - Me.o.0O_O0o_..Name.Replace(".", "").Length >= 2 Then
				MyBase.Row = A_1.Row
			End If
		End Sub

		' Token: 0x06000446 RID: 1094 RVA: 0x00012A14 File Offset: 0x00010C14
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim rowColPositionEventArgs As RowColPositionEventArgs = New RowColPositionEventArgs(Me.o.0O_O0o_., A_1.Col - MyBase.Cols.Fixed)
			Dim a_ As String = "AfterFreezeColumn"
			O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColPositionEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterFreezeColumn Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColPositionEventArgs }, False, "全局表事件", False)
			End If
			If Me.o.0O_O0o_. IsNot Nothing Then
				Me.o.0O_O0o_..NeedSaveSetting = True
			End If
		End Sub

		' Token: 0x06000447 RID: 1095 RVA: 0x00012AE4 File Offset: 0x00010CE4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim rowColPositionEventArgs As RowColPositionEventArgs = New RowColPositionEventArgs(Me.o.0O_O0o_., A_1.Col - MyBase.Cols.Fixed)
			Dim a_ As String = "AfterResizeColumn"
			O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColPositionEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterResizeColumn Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColPositionEventArgs }, False, "全局表事件", False)
			End If
			If Me.o.0O_O0o_. IsNot Nothing Then
				Me.o.0O_O0o_..NeedSaveSetting = True
			End If
		End Sub

		' Token: 0x06000448 RID: 1096 RVA: 0x00012BB4 File Offset: 0x00010DB4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row >= MyBase.Rows.Fixed Then
				Me.BeginUpdate()
				If Not Me.o.0O_O0o_..AllowResizeSingleRow Then
					MyBase.Rows.DefaultSize = MyBase.Rows(A_1.Row).HeightDisplay
					Dim fixed As Integer = MyBase.Rows.Fixed
					Dim num As Integer = MyBase.Rows.Count - 1
					For i As Integer = fixed To num
						MyBase.Rows(i).Height = -1
					Next
				End If
				Me.EndUpdate()
			End If
			Dim rowColPositionEventArgs As RowColPositionEventArgs = New RowColPositionEventArgs(Me.o.0O_O0o_., A_1.Row - MyBase.Rows.Fixed)
			Dim a_ As String = "AfterResizeRow"
			O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColPositionEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterResizeRow Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColPositionEventArgs }, False, "全局表事件", False)
			End If
			If Me.o.0O_O0o_. IsNot Nothing Then
				Me.o.0O_O0o_..NeedSaveSetting = True
			End If
		End Sub

		' Token: 0x06000449 RID: 1097 RVA: 0x00012D05 File Offset: 0x00010F05
		Friend Sub <<EMPTY_NAME>>()
			If MyBase.FindForm() IsNot Nothing Then
				Me.o.O_0o.(Me, New RangeEventArgs(Me.Selection, Me.Selection))
			End If
		End Sub

		' Token: 0x0600044A RID: 1098 RVA: 0x00012D28 File Offset: 0x00010F28
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			If OO_00oOO.SystemReady AndAlso OO_00oOO.Tables.get_Contains(Me.o.0O_O0o_..Name) Then
				Dim cellRangeChangeEventArgs As CellRangeChangeEventArgs = New CellRangeChangeEventArgs(Me.o.0O_O0o_., New CellRange(Me.o.0O_O0o_., A_1.OldRange), New CellRange(Me.o.0O_O0o_., A_1.NewRange))
				Dim a_ As String = "AfterSelChange"
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { cellRangeChangeEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterSelChange Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { cellRangeChangeEventArgs }, False, "全局表事件", False)
				End If
				a_ = "AfterSelChange_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag)
				Dim tableEventArgs As TableEventArgs = New TableEventArgs(Me.o.0O_O0o_.)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { tableEventArgs }, False, "菜单", False)
				If A_1.NewRange.r1 <> A_1.OldRange.r1 Then
					MyBase.Invalidate(A_1.NewRange.r1, 0, A_1.NewRange.r2, MyBase.Cols.Count - 1)
					MyBase.Invalidate(A_1.OldRange.r1, 0, A_1.OldRange.r2, MyBase.Cols.Count - 1)
				End If
			End If
		End Sub

		' Token: 0x0600044B RID: 1099 RVA: 0x00012EDC File Offset: 0x000110DC
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False)
			If MyBase.Cols(0).DataType IsNot GetType(Boolean) AndAlso MyBase.Rows.Count > MyBase.Rows.Fixed AndAlso Not MyBase.Rows(MyBase.Rows.Fixed).IsNode AndAlso Not MyBase.Rows(MyBase.Rows.Count - 1).IsNode AndAlso ((MyBase.BottomRow >= MyBase.Rows.Fixed AndAlso MyBase.TopRow >= MyBase.Rows.Fixed) OrElse Me.o_.o. = 0) AndAlso (Me.o_.o..ToString().Length <> MyBase.BottomRow.ToString().Length OrElse Me.o_.o. = 0 OrElse A_0) Then
				Me.oo0_oo0.ooo_o.()
			End If
			Me.o_.o. = MyBase.BottomRow
		End Sub

		' Token: 0x0600044C RID: 1100 RVA: 0x00012FD4 File Offset: 0x000111D4
		Friend Sub <<EMPTY_NAME>>()
			Dim graphics As Graphics = MyBase.CreateGraphics()
			Dim count As Integer = Math.Max(3, MyBase.BottomRow.ToString().Length)
			MyBase.Cols(0).Width = CInt(Math.Round(CDbl(graphics.MeasureString(New String("0"c, count), Me.Font, 100).Width))) + 5
		End Sub

		' Token: 0x0600044D RID: 1101 RVA: 0x0001303C File Offset: 0x0001123C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			Me.O.O00O_oO_OO00.(False)
			If MyBase.Rows.Fixed > 1 AndAlso A_1.OldRange.TopRow = A_1.NewRange.TopRow Then
				Dim num As Integer = MyBase.Rows.Fixed - 1
				For i As Integer = 0 To num
					MyBase.Rows(i).Invalidate()
				Next
			End If
			Dim tableEventArgs As TableEventArgs = New TableEventArgs(Me.o.0O_O0o_.)
			Dim a_ As String = "AfterScroll"
			If OO_00oOO.SystemReady AndAlso MyBase.FindForm() IsNot Nothing Then
				If Me.o.0O_O0o_..o0__OOo0._oO. Is Nothing Then
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { tableEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				Else
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..o0__OOo0._oO., a_, New Object() { tableEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				End If
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterScroll Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { tableEventArgs }, False, "全局表事件", False)
				End If
			End If
		End Sub

		' Token: 0x0600044E RID: 1102 RVA: 0x00013187 File Offset: 0x00011387
		Friend Sub <<EMPTY_NAME>>()
			If MyBase.FindForm() IsNot Nothing Then
				Me.oO.o_o0O.(Me, New RangeEventArgs(Me.Selection, Me.Selection))
			End If
		End Sub

		' Token: 0x0600044F RID: 1103 RVA: 0x000131AC File Offset: 0x000113AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			If OO_00oOO.SystemReady AndAlso OO_00oOO.Tables.get_Contains(Me.o.0O_O0o_..Name) AndAlso MyBase.Cols.Count > MyBase.Cols.Fixed AndAlso A_1.NewRange.LeftCol >= MyBase.Cols.Fixed Then
				Dim fixed As Integer = MyBase.Cols.Fixed
				Dim num As Integer = MyBase.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(MyBase.Cols(i).Name, "", True) = 0 Then
						Return
					End If
				Next
				Dim cellRangeChangeEventArgs As CellRangeChangeEventArgs = New CellRangeChangeEventArgs(Me.o.0O_O0o_., New CellRange(Me.o.0O_O0o_., A_1.OldRange), New CellRange(Me.o.0O_O0o_., A_1.NewRange))
				Dim a_ As String = "AfterSelRangeChange"
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { cellRangeChangeEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.AfterSelRangeChange Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { cellRangeChangeEventArgs }, False, "全局表事件", False)
				End If
				a_ = "AfterSelRangeChange_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag)
				Dim tableEventArgs As TableEventArgs = New TableEventArgs(Me.o.0O_O0o_.)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { tableEventArgs }, False, "菜单", False)
			End If
		End Sub

		' Token: 0x06000450 RID: 1104 RVA: 0x00013368 File Offset: 0x00011568
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As BeforeMouseDownEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If MyBase.Row < 0 OrElse MyBase.Rows(MyBase.Row).DataIndex < 0 Then
					GoTo IL_3C0
				End If
				IL_31:
				num2 = 4
				If MyBase.Editor IsNot Nothing Then
					GoTo IL_3C0
				End If
				IL_3E:
				num2 = 5
				If Me.MouseRow < MyBase.Rows.Fixed OrElse Me.MouseCol < MyBase.Cols.Fixed Then
					GoTo IL_206
				End If
				IL_6C:
				num2 = 6
				Dim cellClickEventArgs As CellClickEventArgs = New CellClickEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(MyBase.Col).Name), Nothing, A_1.Button.ToString())
				IL_E7:
				num2 = 7
				Dim a_ As String = "DoubleClick"
				IL_F0:
				num2 = 8
				If Me.o.0O_O0o_..o0__OOo0._oO. IsNot Nothing Then
					GoTo IL_138
				End If
				IL_FF:
				num2 = 9
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { cellClickEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				GoTo IL_16A
				IL_138:
				num2 = 11
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..o0__OOo0._oO., a_, New Object() { cellClickEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_16A:
				num2 = 12
				If cellClickEventArgs.Cancel OrElse MyBase.Disposing OrElse MyBase.IsDisposed Then
					GoTo IL_1D2
				End If
				IL_185:
				num2 = 13
				If Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.DoubleClick Then
					GoTo IL_1D2
				End If
				IL_1B1:
				num2 = 14
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { cellClickEventArgs }, False, "全局表事件", False)
				IL_1D2:
				num2 = 15
				A_1.Cancel = cellClickEventArgs.Cancel
				IL_1E1:
				num2 = 16
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed Then
					GoTo IL_3C0
				End If
				IL_1F7:
				num2 = 17
				A_1.Cancel = True
				GoTo IL_3C0
				IL_206:
				num2 = 19
				If Me.MouseRow < MyBase.Rows.Fixed OrElse Me.MouseCol >= MyBase.Cols.Fixed Then
					GoTo IL_3C0
				End If
				IL_235:
				num2 = 20
				Dim cellClickEventArgs2 As CellClickEventArgs = New CellClickEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(MyBase.Col).Name), Nothing, A_1.Button.ToString())
				IL_2B2:
				num2 = 21
				Dim a_2 As String = "DoubleClickRowHeader"
				IL_2BC:
				num2 = 22
				If Me.o.0O_O0o_..o0__OOo0._oO. IsNot Nothing Then
					GoTo IL_306
				End If
				IL_2CC:
				num2 = 23
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_2, New Object() { cellClickEventArgs2 }, False, Me.o.0O_O0o_..DataTable.Name, False)
				GoTo IL_339
				IL_306:
				num2 = 25
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..o0__OOo0._oO., a_2, New Object() { cellClickEventArgs2 }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_339:
				num2 = 26
				If cellClickEventArgs2.Cancel OrElse MyBase.Disposing OrElse MyBase.IsDisposed Then
					GoTo IL_3A3
				End If
				IL_355:
				num2 = 27
				If Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.DoubleClickRowHeader Then
					GoTo IL_3A3
				End If
				IL_381:
				num2 = 28
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_2, New Object() { cellClickEventArgs2 }, False, "全局表事件", False)
				IL_3A3:
				num2 = 29
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed Then
					GoTo IL_3C0
				End If
				IL_3B6:
				num2 = 30
				A_1.Cancel = True
				IL_3C0:
				GoTo IL_48E
				IL_3C5:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_44F:
				GoTo IL_483
				IL_451:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_461:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_451
			End Try
			IL_483:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_48E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000451 RID: 1105 RVA: 0x00013828 File Offset: 0x00011A28
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DragRowColEventArgs)
			Dim leftCol As Integer = Me.Selection.LeftCol
			Dim rightCol As Integer = Me.Selection.RightCol
			A_1.Cancel = True
			Me.o.0O_O0o_..O.__O0o0.(leftCol, rightCol, A_1.Position, True)
			Me.o.0O_O0o_..NeedSaveSetting = True
		End Sub

		' Token: 0x06000452 RID: 1106 RVA: 0x0001387C File Offset: 0x00011A7C
		Friend Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Boolean
			Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(A_0, A_1)
			Me.O.O0_0.(Me, rowColEventArgs, Nothing)
			Dim result As Boolean
			If rowColEventArgs.Cancel Then
				result = False
			Else
				Me.OOOo_oO_O.O.(Me, rowColEventArgs, Nothing)
				result = Not rowColEventArgs.Cancel
			End If
			Return result
		End Function

		' Token: 0x06000453 RID: 1107 RVA: 0x000138C0 File Offset: 0x00011AC0
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs, A_2 As RecordGrid)
			Me.oo_OOo0.O___oo. = True
			If Me.O_._. = 2 Then
				A_1.Cancel = True
				Me.O_._. = 0
				Return
			End If
			Me.O_._. = 0
			If A_1.Col <> 0 OrElse MyBase.Cols(0).DataType IsNot GetType(Boolean) Then
				Dim name As String = MyBase.Cols(A_1.Col).Name
				If Me.o.0O_O0o_..IsSubtotal OrElse Not OO_00oOO.SystemReady OrElse Me.o.0O_O0o_..Position < 0 Then
					A_1.Cancel = True
					Return
				End If
				If Operators.CompareString(name, "", True) = 0 OrElse MyBase.Rows(A_1.Row).DataIndex = -1 OrElse (Not MyBase.Cols(A_1.Col).Visible And A_2 Is Nothing) Then
					A_1.Cancel = True
				ElseIf Not Me.o.0O_O0o_..AllowEdit Then
					A_1.Cancel = True
				ElseIf Not Me.o.0O_O0o_..Cols(name).AllowEdit Then
					A_1.Cancel = True
				ElseIf New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)).Locked Then
					A_1.Cancel = True
				ElseIf A_1.Col < MyBase.Cols.Fixed And A_1.Row < MyBase.Rows.Fixed Then
					A_1.Cancel = True
				ElseIf Me.o.0O_O0o_..DataTable.BaseTable.Columns(name).AutoIncrement Then
					A_1.Cancel = True
				ElseIf O_O0OO.O0OO_.0. Then
					Dim primaryKey As DataColumn() = Me.o.0O_O0o_..DataTable.BaseTable.PrimaryKey
					For i As Integer = 0 To primaryKey.Length - 1
						If Operators.CompareString(primaryKey(i).ColumnName, name, True) = 0 Then
							A_1.Cancel = True
							Exit For
						End If
					Next
				End If
				If Not A_1.Cancel Then
					Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name), A_2)
					If A_0 IsNot Me Then
						rowColEventArgs.IsFocusCell = True
					Else
						rowColEventArgs.IsFocusCell = (A_1.Row = MyBase.Row AndAlso MyBase.Col = A_1.Col)
					End If
					Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.Oo0O00Ooo._.
					Dim text As String = "PrepareEdit事件执行错误，在您修正代码之前，将暂停执行该事件代码！"
					If methodInfo IsNot Nothing AndAlso OO_00oOO.SystemReady Then
						Try
							methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
						Catch a_ As Exception
							Me.o.0O_O0o_..DataTable.Oo0O00Ooo._. = Nothing
							ooO.oOo0Oo.o.(a_, "表，" + Me.o.0O_O0o_..DataTable.Name + "，PrepareEdit")
							MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End Try
					End If
					If Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.PrepareEdit AndAlso Not rowColEventArgs.Cancel AndAlso OO_00oOO.SystemReady Then
						methodInfo = O_O0OO.O0_00o.o0__o..OO00_oo0o_._O.
						If methodInfo IsNot Nothing Then
							Try
								methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
							Catch a_2 As Exception
								O_O0OO.O0_00o.o0__o..OO00_oo0o_._O. = Nothing
								ooO.oOo0Oo.o.(a_2, "全局表事件，PrepareEdit")
								MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							End Try
						End If
					End If
					A_1.Cancel = rowColEventArgs.Cancel
					Me.oo_OOo0.O___oo. = rowColEventArgs.[Continue]
					Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
					If Not Me.o.0O_O0o_..Cols(name).DataCol.IsString OrElse Operators.CompareString(MyBase.Cols(A_1.Col).EditMask, "", True) > 0 Then
						c1FlexGrid.ImeMode = ImeMode.Close
						Return
					End If
					If Me.o.0O_O0o_..Cols(name).DataCol.ImeMode = 1 Then
						c1FlexGrid.ImeMode = ImeMode.[On]
						Return
					End If
					If Me.o.0O_O0o_..Cols(name).DataCol.ImeMode = 2 Then
						c1FlexGrid.ImeMode = ImeMode.Close
						Return
					End If
					c1FlexGrid.ImeMode = ImeMode.NoControl
				End If
			End If
		End Sub

		' Token: 0x06000454 RID: 1108 RVA: 0x00013D74 File Offset: 0x00011F74
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Col = 0 AndAlso MyBase.Rows(A_1.Row).DataIndex < 0 Then
				A_1.Cancel = True
				Return
			End If
			If Not MyBase.GetMergedRange(A_1.Row, A_1.Col).IsSingleCell Then
				A_1.Cancel = True
				Return
			End If
			Dim editor As System.Windows.Forms.Control = MyBase.Cols(A_1.Col).Editor
			If editor IsNot Nothing AndAlso TypeOf editor Is BuildInDropTree AndAlso CType(editor, BuildInDropTree).Ooo._0oO..IsDisposed Then
				Dim dataCol As DataCol = Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name).DataCol
				Dim dataTable As DataTable = dataCol.DataTable
				dataCol.oO0._00o_0. = Nothing
				Try
					For Each table As Foxtable.Table In OO_00oOO.Tables
						If table.DataTable Is dataCol.DataTable Then
							Try
								For Each col As Col In table.Cols
									If col.DataCol Is dataCol Then
										col.o0.O.()
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator(Of Col)
								If enumerator2 IsNot Nothing Then
									enumerator2.Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Foxtable.Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			Me.O.O0_0.(RuntimeHelpers.GetObjectValue(A_0), A_1, Nothing)
			Me.o_O.Oo. = Not A_1.Cancel
		End Sub

		' Token: 0x06000455 RID: 1109 RVA: 0x00013EF8 File Offset: 0x000120F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim rowColPositionEventArgs As RowColPositionEventArgs = New RowColPositionEventArgs(Me.o.0O_O0o_., A_1.Col - MyBase.Cols.Fixed)
			Dim a_ As String = "BeforeFreezeColumn"
			O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColPositionEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Not rowColPositionEventArgs.Cancel AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeFreezeColumn Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColPositionEventArgs }, False, "全局表事件", False)
			End If
			A_1.Cancel = rowColPositionEventArgs.Cancel
		End Sub

		' Token: 0x06000456 RID: 1110 RVA: 0x00013FC8 File Offset: 0x000121C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As BeforeMouseDownEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.Focused OrElse Not MyBase.CanFocus OrElse MyBase.Editor IsNot Nothing Then
					GoTo IL_8A
				End If
				IL_21:
				num2 = 3
				MyBase.Focus()
				IL_2A:
				num2 = 4
				If Not Me.Focused OrElse Me.MouseRow < MyBase.Rows.Fixed OrElse Me.MouseRow > MyBase.Rows.Count - 1 OrElse Me.Selection.ContainsRow(Me.MouseRow) OrElse Me.MouseCol <= 0 Then
					GoTo IL_8A
				End If
				IL_7C:
				num2 = 5
				MyBase.Row = Me.MouseRow
				IL_8A:
				num2 = 6
				Dim hitTestInfo As HitTestInfo = MyBase.HitTest(A_1.X, A_1.Y)
				IL_9F:
				num2 = 7
				If hitTestInfo.Type Is Nothing Then
					GoTo IL_5E5
				End If
				IL_AD:
				num2 = 9
				If A_1.Button <> MouseButtons.Left OrElse System.Windows.Forms.Control.ModifierKeys <> Keys.Shift OrElse hitTestInfo.Type <> 5 Then
					GoTo IL_138
				End If
				IL_D3:
				num2 = 10
				If Me.MouseRow < MyBase.Rows.Fixed OrElse MyBase.Row < MyBase.Rows.Fixed Then
					GoTo IL_138
				End If
				IL_FC:
				num2 = 11
				MyBase.[Select](MyBase.Row, MyBase.Cols.Fixed, Me.MouseRow, MyBase.Cols.Count - 1)
				IL_129:
				num2 = 12
				A_1.Cancel = True
				GoTo IL_5E5
				IL_138:
				num2 = 14
				If A_1.Button <> MouseButtons.Left OrElse (System.Windows.Forms.Control.ModifierKeys <> Keys.Control AndAlso Not Me.o.0O_O0o_..AllowClickSort) Then
					GoTo IL_238
				End If
				IL_167:
				num2 = 15
				If hitTestInfo.Type <> 2 Then
					GoTo IL_238
				End If
				IL_177:
				num2 = 16
				Dim column As Integer = hitTestInfo.Column
				IL_182:
				num2 = 17
				If hitTestInfo.Column < MyBase.Cols.Fixed Then
					GoTo IL_238
				End If
				IL_19C:
				num2 = 18
				If Operators.CompareString(Me.o.0O_O0o_..Sort, "", True) <> 0 AndAlso Not Me.o.0O_O0o_..Sort.ToLower().EndsWith(" desc") Then
					GoTo IL_1FA
				End If
				IL_1D3:
				num2 = 19
				Me.o.0O_O0o_..Sort = MyBase.Cols(hitTestInfo.Column).Name
				GoTo IL_229
				IL_1FA:
				num2 = 21
				Me.o.0O_O0o_..Sort = MyBase.Cols(hitTestInfo.Column).Name + " desc"
				IL_229:
				num2 = 22
				A_1.Cancel = True
				GoTo IL_5E5
				IL_238:
				num2 = 24
				If Not(hitTestInfo.Type = 2 And hitTestInfo.Column >= MyBase.Cols.Fixed) Then
					GoTo IL_2D7
				End If
				IL_25F:
				num2 = 25
				If Not Me.o.0O_O0o_..AllowDragColumn OrElse Me.Selection.TopRow <> MyBase.Rows.Fixed OrElse Me.Selection.BottomRow <> MyBase.Rows.Count - 1 OrElse Not Me.Selection.ContainsCol(hitTestInfo.Column) Then
					GoTo IL_2CD
				End If
				IL_2C1:
				num2 = 26
				MyBase.AllowDragging = 1
				GoTo IL_2D7
				IL_2CD:
				num2 = 28
				MyBase.AllowDragging = 0
				IL_2D7:
				num2 = 29
				If Me.o.0O_O0o_..View.Count = 0 Or MyBase.Col < MyBase.Cols.Fixed Then
					GoTo IL_5E5
				End If
				IL_306:
				num2 = 31
				If Me.Selection.Contains(Me.MouseRow, Me.MouseCol) OrElse A_1.Button = MouseButtons.Left Then
					GoTo IL_5E5
				End If
				IL_339:
				num2 = 34
				If Me.MouseCol >= MyBase.Cols.Fixed OrElse Me.MouseRow >= MyBase.Rows.Fixed Then
					GoTo IL_3A1
				End If
				IL_362:
				num2 = 35
				MyBase.[Select](MyBase.Rows.Fixed, MyBase.Cols.Fixed, MyBase.Rows.Count - 1, MyBase.Cols.Count - 1, False)
				GoTo IL_5E5
				IL_3A1:
				num2 = 37
				If Me.MouseRow >= MyBase.Rows.Fixed OrElse Me.MouseCol < MyBase.Cols.Fixed Then
					GoTo IL_4A7
				End If
				IL_3D0:
				num2 = 38
				If Me.Selection.TopRow = MyBase.Rows.Fixed AndAlso Me.Selection.BottomRow = MyBase.Rows.Count - 1 Then
					GoTo IL_440
				End If
				IL_40D:
				num2 = 39
				MyBase.[Select](MyBase.Rows.Fixed, Me.MouseCol, MyBase.Rows.Count - 1, Me.MouseCol, False)
				GoTo IL_5E5
				IL_440:
				num2 = 41
				If Me.MouseCol >= Me.Selection.LeftCol AndAlso Me.MouseCol <= Me.Selection.RightCol Then
					GoTo IL_5E5
				End If
				IL_474:
				num2 = 42
				MyBase.[Select](MyBase.Rows.Fixed, Me.MouseCol, MyBase.Rows.Count - 1, Me.MouseCol, False)
				GoTo IL_5E5
				IL_4A7:
				num2 = 44
				If Me.MouseCol >= MyBase.Cols.Fixed OrElse Me.MouseRow < MyBase.Rows.Fixed Then
					GoTo IL_5A7
				End If
				IL_4D6:
				num2 = 45
				If Me.Selection.LeftCol = MyBase.Cols.Fixed AndAlso Me.Selection.RightCol = MyBase.Cols.Count - 1 Then
					GoTo IL_546
				End If
				IL_513:
				num2 = 46
				MyBase.[Select](Me.MouseRow, MyBase.Cols.Fixed, Me.MouseRow, MyBase.Cols.Count - 1, False)
				GoTo IL_5E5
				IL_546:
				num2 = 48
				If Me.MouseRow >= Me.Selection.TopRow AndAlso Me.MouseRow <= Me.Selection.BottomRow Then
					GoTo IL_5E5
				End If
				IL_577:
				num2 = 49
				MyBase.[Select](Me.MouseRow, MyBase.Cols.Fixed, Me.MouseRow, MyBase.Cols.Count - 1, False)
				GoTo IL_5E5
				IL_5A7:
				num2 = 51
				If Me.MouseRow < MyBase.Rows.Fixed OrElse Me.MouseCol < MyBase.Cols.Fixed Then
					GoTo IL_5E5
				End If
				IL_5D0:
				num2 = 52
				MyBase.[Select](Me.MouseRow, Me.MouseCol)
				IL_5E5:
				GoTo IL_70B
				IL_5EA:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_6CC:
				GoTo IL_700
				IL_6CE:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6DE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6CE
			End Try
			IL_700:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_70B:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000457 RID: 1111 RVA: 0x00014704 File Offset: 0x00012904
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim rowColPositionEventArgs As RowColPositionEventArgs = New RowColPositionEventArgs(Me.o.0O_O0o_., A_1.Col - MyBase.Cols.Fixed)
			Dim a_ As String = "BeforeResizeColumn"
			O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColPositionEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Not rowColPositionEventArgs.Cancel AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeResizeColumn Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColPositionEventArgs }, False, "全局表事件", False)
			End If
			A_1.Cancel = rowColPositionEventArgs.Cancel
			If Not A_1.Cancel Then
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New OoO_oO(Me.o.0O_O0o_.))
			End If
		End Sub

		' Token: 0x06000458 RID: 1112 RVA: 0x000147F8 File Offset: 0x000129F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim num As Integer = MyBase.Rows.Fixed - 1
			For i As Integer = 0 To num
				MyBase.Rows(i).Height = MyBase.Rows(i).HeightDisplay
			Next
			Dim rowColPositionEventArgs As RowColPositionEventArgs = New RowColPositionEventArgs(Me.o.0O_O0o_., A_1.Row - MyBase.Rows.Fixed)
			Dim a_ As String = "BeforeResizeRow"
			O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { rowColPositionEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Not rowColPositionEventArgs.Cancel AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeResizeRow Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { rowColPositionEventArgs }, False, "全局表事件", False)
			End If
			A_1.Cancel = rowColPositionEventArgs.Cancel
			If Not A_1.Cancel Then
				If A_1.Row < MyBase.Rows.Fixed Then
					Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New O00OOO0o_00o(Me.o.0O_O0o_., A_1.Row, MyBase.Rows(A_1.Row).Height))
					Return
				End If
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o_o0_(Me.o.0O_O0o_., A_1.Row, MyBase.Rows(A_1.Row).Height))
			End If
		End Sub

		' Token: 0x06000459 RID: 1113 RVA: 0x00014990 File Offset: 0x00012B90
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			If OO_00oOO.SystemReady Then
				Dim cellRangeChangeEventArgs As CellRangeChangeEventArgs = New CellRangeChangeEventArgs(Me.o.0O_O0o_., New CellRange(Me.o.0O_O0o_., A_1.OldRange), New CellRange(Me.o.0O_O0o_., A_1.NewRange))
				If OO_00oOO.Tables.get_Contains(Me.o.0O_O0o_..Name) Then
					Dim a_ As String = "BeforeSelChange"
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { cellRangeChangeEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
					If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Not cellRangeChangeEventArgs.Cancel AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeSelChange Then
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { cellRangeChangeEventArgs }, False, "全局表事件", False)
					End If
					A_1.Cancel = cellRangeChangeEventArgs.Cancel
				End If
			End If
		End Sub

		' Token: 0x0600045A RID: 1114 RVA: 0x00014A94 File Offset: 0x00012C94
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			If OO_00oOO.SystemReady Then
				Dim cellRangeChangeEventArgs As CellRangeChangeEventArgs = New CellRangeChangeEventArgs(Me.o.0O_O0o_., New CellRange(Me.o.0O_O0o_., A_1.OldRange), New CellRange(Me.o.0O_O0o_., A_1.NewRange))
				Dim a_ As String = "BeforeSelRangeChange"
				If OO_00oOO.Tables.get_Contains(Me.o.0O_O0o_..Name) Then
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { cellRangeChangeEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
					If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Not cellRangeChangeEventArgs.Cancel AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeSelRangeChange Then
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { cellRangeChangeEventArgs }, False, "全局表事件", False)
					End If
					A_1.Cancel = cellRangeChangeEventArgs.Cancel
				End If
			End If
		End Sub

		' Token: 0x0600045B RID: 1115 RVA: 0x00014B96 File Offset: 0x00012D96
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Me.o_.OO.(A_1.Row, A_1.Col, Nothing)
			A_1.Cancel = True
		End Sub

		' Token: 0x0600045C RID: 1116 RVA: 0x00014BB4 File Offset: 0x00012DB4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataCol As DataCol = Me.o.0O_O0o_..DataTable.DataCols(MyBase.Cols(MyBase.Col).Name)
			Dim dataRow As DataRow = Me.o.0O_O0o_..Current.DataRow
			If MyBase(MyBase.Row, MyBase.Col) IsNot Nothing AndAlso MyBase(MyBase.Row, MyBase.Col) IsNot DBNull.Value Then
				Dim a_ As String = MyBase(MyBase.Row, MyBase.Col).ToString()
				Oo00.o00O0O_.O.(dataRow, dataCol, dataCol.FTPClient, a_, dataCol.AutoUpdate)
			End If
		End Sub

		' Token: 0x0600045D RID: 1117 RVA: 0x00014C5C File Offset: 0x00012E5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataCol As DataCol = Me.o.0O_O0o_..DataTable.DataCols(MyBase.Cols(MyBase.Col).Name)
			Dim dataRow As DataRow = Me.o.0O_O0o_..Current.DataRow
			If MyBase(MyBase.Row, MyBase.Col) IsNot Nothing AndAlso MyBase(MyBase.Row, MyBase.Col) IsNot DBNull.Value Then
				Dim text As String = MyBase(MyBase.Row, MyBase.Col).ToString()
				If Not text.StartsWith("[") OrElse Not text.EndsWith("]") Then
					Oo00.o0_o._O_.(dataRow, dataCol, dataCol.FTPClient, text, dataCol.AutoUpdate)
				End If
			End If
		End Sub

		' Token: 0x0600045E RID: 1118 RVA: 0x00014D1C File Offset: 0x00012F1C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataCol As DataCol = Me.o.0O_O0o_..DataTable.DataCols(MyBase.Cols(MyBase.Col).Name)
			Dim dataRow As DataRow = Me.o.0O_O0o_..Current.DataRow
			Dim list As List(Of String) = New List(Of String)()
			list = Oo00.O____0O._0.(dataRow, dataCol, dataCol.FTPClient, "")
			If list IsNot Nothing AndAlso list.Count > 0 Then
				Dim text As String = list(0)
				Dim maxLength As Integer = dataCol.MaxLength
				If maxLength < text.Length AndAlso maxLength > 0 Then
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行""更改列""命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.o_o.O0ooOo.().Row, dataCol.Name))
				MyBase(MyBase.Row, MyBase.Col) = text
			End If
		End Sub

		' Token: 0x0600045F RID: 1119 RVA: 0x00014E08 File Offset: 0x00013008
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataCol As DataCol = Me.o.0O_O0o_..DataTable.DataCols(MyBase.Cols(MyBase.Col).Name)
			Dim text As String = Oo00.O____0O._0.(Me.o.0O_O0o_..Current.DataRow, dataCol, dataCol.FTPClient, "")
			If Operators.CompareString(text, "", True) > 0 Then
				Dim maxLength As Integer = dataCol.MaxLength
				If maxLength < text.Length AndAlso maxLength > 0 Then
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行""更改列""命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.o_o.O0ooOo.().Row, dataCol.Name))
				MyBase(MyBase.Row, MyBase.Col) = text
			End If
		End Sub

		' Token: 0x06000460 RID: 1120 RVA: 0x00014EE4 File Offset: 0x000130E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex).Row, MyBase.Cols(MyBase.Col).Name))
			Dim dataDisplay As String = Me.GetDataDisplay(MyBase.Row, MyBase.Col)
			If Operators.CompareString(dataDisplay, "", True) > 0 Then
				Dim dataRow As DataRow = Me.o.0O_O0o_..Current.DataRow
				Dim a_ As DataCol = Me.o.0O_O0o_..DataTable.DataCols(MyBase.Cols(MyBase.Col).Name)
				If Not Oo00.OO.0O0o.(dataRow, a_, dataDisplay) Then
					Return
				End If
			End If
			MyBase(MyBase.Row, MyBase.Col) = DBNull.Value
		End Sub

		' Token: 0x06000461 RID: 1121 RVA: 0x00014FCC File Offset: 0x000131CC
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String, A_2 As RecordGrid)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1TextBox As C1TextBox = Nothing
				IL_0B:
				num2 = 3
				Dim editor As System.Windows.Forms.Control = CType(A_0, C1FlexGrid).Editor
				IL_1A:
				num2 = 4
				Me.O__o._oOOoO. += 1
				IL_2A:
				num2 = 5
				If Not(TypeOf editor Is O0o__o0_o0) AndAlso Not(TypeOf editor Is O0_0_0_Oo_o) AndAlso Not(TypeOf editor Is o0_o_o_0) Then
					GoTo IL_97
				End If
				IL_47:
				num2 = 6
				c1TextBox = CType(editor, C1TextBox)
				IL_51:
				num2 = 7
				If Not((Me.O__o._oOOoO. = 1 AndAlso c1TextBox.SelectionStart = 0 AndAlso c1TextBox.Text.Length >= 1) And Not Me.o_.o.) Then
					GoTo IL_97
				End If
				IL_84:
				num2 = 8
				c1TextBox.SelectionStart = c1TextBox.Text.Length
				IL_97:
				num2 = 9
				If Me.O__o._oOOoO. <> 2 OrElse Me.o_.o. Then
					GoTo IL_195
				End If
				IL_B1:
				num2 = 10
				If c1TextBox Is Nothing Then
					GoTo IL_195
				End If
				IL_BA:
				num2 = 11
				Dim c1TextBox2 As C1TextBox = c1TextBox
				IL_C0:
				num2 = 12
				If c1TextBox2.Text.Length <= 1 OrElse c1TextBox2.Text(c1TextBox2.Text.Length - 2) <> c1TextBox2.Text(c1TextBox2.Text.Length - 1) OrElse (DateTime.Now - Me.o_.o.).TotalSeconds >= 0.05 Then
					GoTo IL_192
				End If
				IL_132:
				num2 = 13
				If c1TextBox2.Text(c1TextBox2.Text.Length - 1) = " "c Then
					GoTo IL_192
				End If
				IL_153:
				num2 = 14
				c1TextBox2.Value = c1TextBox2.Text(c1TextBox2.Text.Length - 1)
				IL_17C:
				num2 = 15
				c1TextBox2.SelectionStart = c1TextBox2.Text.Length
				IL_192:
				c1TextBox2 = Nothing
				IL_195:
				num2 = 17
				If MyBase.Rows(MyBase.Row).DataIndex = -1 Then
					GoTo IL_2AE
				End If
				IL_1B4:
				num2 = 19
				Dim changeEditEventArgs As ChangeEditEventArgs = New ChangeEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex)), Me.o.0O_O0o_..Cols(A_1), editor.Text, A_2)
				IL_20E:
				num2 = 20
				Dim a_ As String = "ChangeEdit"
				IL_218:
				num2 = 21
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { changeEditEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_250:
				num2 = 22
				If MyBase.Disposing OrElse MyBase.IsDisposed OrElse Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.ChangeEdit Then
					GoTo IL_2AE
				End If
				IL_28C:
				num2 = 23
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { changeEditEventArgs }, False, "全局表事件", False)
				IL_2AE:
				GoTo IL_360
				IL_2B3:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_321:
				GoTo IL_355
				IL_323:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_333:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_323
			End Try
			IL_355:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_360:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000462 RID: 1122 RVA: 0x00015360 File Offset: 0x00013560
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), MyBase.Cols(MyBase.Col).Name, Nothing)
		End Sub

		' Token: 0x06000463 RID: 1123 RVA: 0x00015388 File Offset: 0x00013588
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.Row >= 0 AndAlso MyBase.Rows(MyBase.Row).DataIndex >= 0 AndAlso MyBase.Editor Is Nothing AndAlso Me.MouseRow >= MyBase.Rows.Fixed AndAlso Me.MouseCol >= MyBase.Cols.Fixed Then
				Dim mouseEventArgs As MouseEventArgs = CType(A_1, MouseEventArgs)
				Dim cellClickEventArgs As CellClickEventArgs = New CellClickEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(MyBase.Col).Name), Nothing, mouseEventArgs.Button.ToString())
				Dim a_ As String = "Click"
				If Me.o.0O_O0o_..o0__OOo0._oO. Is Nothing Then
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { cellClickEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				Else
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..o0__OOo0._oO., a_, New Object() { cellClickEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				End If
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.Click Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { cellClickEventArgs }, False, "全局表事件", False)
				End If
			End If
		End Sub

		' Token: 0x06000464 RID: 1124 RVA: 0x0001553F File Offset: 0x0001373F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
		End Sub

		' Token: 0x06000465 RID: 1125 RVA: 0x00015544 File Offset: 0x00013744
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.SystemReady AndAlso MyBase.FindForm() IsNot Nothing AndAlso OO_00oOO.CurrentTable IsNot Me.o.0O_O0o_. Then
				OO_00oOO.CurrentTable = Me.o.0O_O0o_.
				Dim table As Foxtable.Table = Me.o.0O_O0o_.
				Dim array As SystemEventTypeEnum() = New SystemEventTypeEnum(2) {}
				RuntimeHelpers.InitializeArray(array, fieldof(b.o00_.oO_.).FieldHandle)
				OO_00oOO.RaiseSystemEvent(table, array)
				If OO_00oOO.SystemReady Then
					Me.o.0O_O0o_..View.o_._0O0o_OoO.()
					Me.o.0O_O0o_..View.Oo._Oo0OO.()
				End If
			End If
		End Sub

		' Token: 0x06000466 RID: 1126 RVA: 0x000155BC File Offset: 0x000137BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_._. = -1F
			If MyBase.FindForm() IsNot Nothing Then
				Me.O.O00O_oO_OO00.(False)
				If MyBase.Cols.Count > MyBase.Cols.Fixed Then
					Me.AutoSizeRows(0, MyBase.Cols.Fixed, MyBase.Rows.Fixed - 1, MyBase.Cols.Fixed, 0, 1)
				End If
				Try
					For Each col As Col In Me.o.0O_O0o_..Cols
						Dim o_o_O.0000_O. As System.Windows.Forms.Control = col.o_o_O.0000_O.
						If o_o_O.0000_O. IsNot Nothing AndAlso Not o_o_O.0000_O..Disposing AndAlso Not o_o_O.0000_O..IsDisposed AndAlso TypeOf o_o_O.0000_O. Is O__o Then
							o_o_O.0000_O..Font = CType(Me.Font.Clone(), Font)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Col)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If Me.o.0O_O0o_..o00oOO00_.ooOo. IsNot Nothing AndAlso Not Me.o.0O_O0o_..o00oOO00_.ooOo..Disposing AndAlso Not Me.o.0O_O0o_..o00oOO00_.ooOo..IsDisposed Then
					Me.o.0O_O0o_..o00oOO00_.ooOo..Font = CType(Me.Font.Clone(), Font)
					Me.o.0O_O0o_..o00oOO00_.ooOo..AutoSizeRows(0, 0, Me.o.0O_O0o_..o00oOO00_.ooOo..Rows.Count - 1, 0, 0, 1)
					Me.o.0O_O0o_..o00oOO00_.ooOo..AutoSizeCol(0, 10)
				End If
			End If
		End Sub

		' Token: 0x06000467 RID: 1127 RVA: 0x00015734 File Offset: 0x00013934
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oo_Oo.0oo__.(RuntimeHelpers.GetObjectValue(A_0), A_1)
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000468 RID: 1128 RVA: 0x0001574C File Offset: 0x0001394C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim keyEventArgs As KeyEventArgs = New KeyEventArgs(Me.o.0O_O0o_., A_1.KeyData)
				IL_1B:
				num2 = 3
				Dim a_ As String = "KeyDown"
				IL_24:
				num2 = 4
				If Not OO_00oOO.SystemReady Then
					GoTo IL_A5
				End If
				IL_2D:
				num2 = 5
				If Me.o.0O_O0o_..o0__OOo0._oO. IsNot Nothing Then
					GoTo IL_74
				End If
				IL_3C:
				num2 = 6
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { keyEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				GoTo IL_A5
				IL_74:
				num2 = 8
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..o0__OOo0._oO., a_, New Object() { keyEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_A5:
				num2 = 9
				If keyEventArgs.Handled Then
					GoTo IL_10D
				End If
				IL_B0:
				num2 = 10
				If MyBase.Disposing OrElse MyBase.IsDisposed OrElse Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.KeyDown Then
					GoTo IL_10D
				End If
				IL_EC:
				num2 = 11
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { keyEventArgs }, False, "全局表事件", False)
				IL_10D:
				num2 = 12
				If Not keyEventArgs.Handled Then
					GoTo IL_136
				End If
				IL_118:
				num2 = 13
				A_1.Handled = keyEventArgs.Handled
				IL_127:
				num2 = 14
				A_1.SuppressKeyPress = True
				GoTo IL_6DB
				IL_136:
				num2 = 16
				Dim flag As Boolean = True
				IL_13C:
				num2 = 17
				Dim flag2 As Boolean = False
				IL_142:
				num2 = 18
				Dim num3 As Integer = MyBase.Col + 1
				Dim num4 As Integer = MyBase.Cols.Count - 1
				For i As Integer = num3 To num4
					IL_160:
					num2 = 19
					If MyBase.Cols(i).Visible Then
						IL_177:
						num2 = 20
						flag = False
						Exit For
					End If
					IL_17F:
					num2 = 22
				Next
				IL_18E:
				num2 = 23
				If MyBase.Row <> MyBase.Rows.Count - 1 AndAlso (MyBase.Row <> MyBase.Rows.Count - 2 OrElse Not Me.o.0O_O0o_..GrandTotal) Then
					GoTo IL_20E
				End If
				IL_1C8:
				num2 = 24
				If Me.o.0O_O0o_..IsSubtotal OrElse Not Me.o.0O_O0o_..AutoAddNew OrElse Not Me.o.0O_O0o_..AllowAddNew Then
					GoTo IL_20E
				End If
				IL_1F2:
				num2 = 25
				flag2 = True
				IL_1F8:
				num2 = 26
				If MyBase.KeyActionEnter <> 2 OrElse flag Then
					GoTo IL_20E
				End If
				IL_208:
				num2 = 27
				flag2 = False
				IL_20E:
				num2 = 28
				If A_1.KeyCode <> Keys.Tab OrElse Not flag2 Then
					GoTo IL_245
				End If
				IL_21F:
				num2 = 29
				A_1.Handled = True
				IL_229:
				num2 = 30
				A_1.SuppressKeyPress = True
				IL_233:
				num2 = 31
				SendKeys.SendWait("{ENTER}")
				GoTo IL_6DB
				IL_245:
				num2 = 33
				If A_1.KeyCode <> Keys.[Return] Then
					GoTo IL_2ED
				End If
				IL_255:
				num2 = 34
				If MyBase.Editor IsNot Nothing Then
					GoTo IL_6DB
				End If
				IL_263:
				num2 = 35
				A_1.Handled = True
				IL_26D:
				num2 = 36
				A_1.SuppressKeyPress = True
				IL_277:
				num2 = 37
				If Not flag2 Then
					GoTo IL_2AD
				End If
				IL_27E:
				num2 = 38
				Row.AddNew()
				IL_286:
				num2 = 39
				If MyBase.KeyActionEnter <> 2 Then
					GoTo IL_29B
				End If
				IL_292:
				num2 = 40
				Me.O_o.O_O__O.()
				IL_29B:
				num2 = 41
				SendKeys.SendWait("{F2}")
				GoTo IL_6DB
				IL_2AD:
				num2 = 43
				If MyBase.KeyActionEnter <> 1 Then
					GoTo IL_2C8
				End If
				IL_2B9:
				num2 = 44
				Me.o.Ooo_0o_oO.(False)
				GoTo IL_6DB
				IL_2C8:
				num2 = 46
				If Not flag Then
					GoTo IL_2DE
				End If
				IL_2CF:
				num2 = 47
				Me.O_o.O_O__O.(False)
				GoTo IL_6DB
				IL_2DE:
				num2 = 49
				Me.OOOo_oO_O.O.(False)
				GoTo IL_6DB
				IL_2ED:
				num2 = 51
				If MyBase.Row < MyBase.Rows.Fixed Then
					GoTo IL_6DB
				End If
				IL_306:
				num2 = 53
				If(Not A_1.Control OrElse (A_1.KeyCode <> Keys.X AndAlso A_1.KeyCode <> Keys.C AndAlso A_1.KeyCode <> Keys.Insert)) AndAlso (Not A_1.Shift OrElse A_1.KeyCode <> Keys.Delete) Then
					GoTo IL_34A
				End If
				IL_341:
				num2 = 54
				Me.Oo.O_.()
				IL_34A:
				num2 = 55
				If Me.o.0O_O0o_..IsSubtotal Then
					GoTo IL_6DB
				End If
				IL_35D:
				num2 = 57
				If Not Me.o.0O_O0o_..GrandTotal Then
					GoTo IL_391
				End If
				IL_36D:
				num2 = 58
				If Me.Selection.BottomRow = MyBase.Rows.Count - 1 Then
					GoTo IL_6DB
				End If
				IL_391:
				num2 = 60
				If(Not A_1.Control OrElse A_1.KeyCode <> Keys.X) AndAlso (Not A_1.Shift OrElse A_1.KeyCode <> Keys.Delete) AndAlso A_1.KeyCode <> Keys.Delete Then
					GoTo IL_4A7
				End If
				IL_3C5:
				num2 = 61
				If Me.Selection.LeftCol <> Me.Selection.RightCol OrElse Me.Selection.TopRow <> Me.Selection.BottomRow Then
					GoTo IL_46C
				End If
				IL_40B:
				num2 = 62
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex).Row, MyBase.Cols(MyBase.Col).Name))
				GoTo IL_499
				IL_46C:
				num2 = 64
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New oOOOo0oOOOO_(Me.o.0O_O0o_., Me.Selection))
				IL_490:
				num2 = 65
				O_O0OO.O0OO_.0. = True
				IL_499:
				num2 = 66
				Me.oO0O00o0o.O.()
				GoTo IL_6DB
				IL_4A7:
				num2 = 68
				If(Not A_1.Control OrElse A_1.KeyCode <> Keys.V) AndAlso (Not A_1.Shift OrElse A_1.KeyCode <> Keys.Insert) Then
					GoTo IL_6DB
				End If
				IL_4D4:
				num2 = 69
				A_1.Handled = True
				IL_4DE:
				num2 = 70
				A_1.SuppressKeyPress = True
				IL_4E8:
				num2 = 71
				Dim text As String = Clipboard.GetText()
				IL_4F2:
				num2 = 72
				text = text.TrimEnd(New Char() { vbCr, vbLf })
				IL_50E:
				num2 = 73
				If String.IsNullOrEmpty(text) Then
					GoTo IL_6DB
				End If
				IL_51D:
				num2 = 75
				Dim array As String() = text.Split(New Char() { MyBase.ClipSeparators(1) })
				IL_53E:
				num2 = 76
				Dim num5 As Integer = array.Length
				IL_547:
				num2 = 77
				If array.Length = 0 Then
					GoTo IL_6DB
				End If
				IL_553:
				num2 = 79
				Dim num6 As Integer = array(0).Split(New Char() { MyBase.ClipSeparators(0) }).Length
				IL_578:
				num2 = 80
				Dim num7 As Integer = num6
				IL_57F:
				num2 = 81
				Dim leftCol As Integer = Me.Selection.LeftCol
				Dim num8 As Integer = MyBase.Cols.Count - 1
				For j As Integer = leftCol To num8
					IL_5A4:
					num2 = 82
					If MyBase.Cols(j).Visible Then
						IL_5BB:
						num2 = 83
						num7 -= 1
					Else
						IL_5C6:
						num2 = 85
						num6 += 1
					End If
					IL_5CF:
					num2 = 86
					If num7 = 0 Then
						Exit For
					End If
					IL_5D6:
					num2 = 88
				Next
				IL_5E5:
				num2 = 89
				If Not(num5 = 1 And num6 = 1) Then
					GoTo IL_656
				End If
				IL_5F5:
				num2 = 90
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(MyBase.Row).DataIndex).Row, MyBase.Cols(MyBase.Col).Name))
				GoTo IL_6D2
				IL_656:
				num2 = 92
				MyBase.[Select](MyBase.Row, MyBase.Col, Math.Min(MyBase.Row + num5 - 1, MyBase.Rows.Count - 1), Math.Min(MyBase.Col + num6 - 1, MyBase.Cols.Count - 1))
				IL_6A5:
				num2 = 93
				Me.o.0O_O0o_..O_o0OOo_.o0..O__00.__0_O.(New oOOOo0oOOOO_(Me.o.0O_O0o_., Me.Selection))
				IL_6C9:
				num2 = 94
				O_O0OO.O0OO_.0. = True
				IL_6D2:
				num2 = 95
				Me.o0o0__.o.()
				IL_6DB:
				GoTo IL_8AD
				IL_6E0:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_86E:
				GoTo IL_8A2
				IL_870:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_880:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_870
			End Try
			IL_8A2:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8AD:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000469 RID: 1129 RVA: 0x0001602C File Offset: 0x0001422C
		Friend Sub <<EMPTY_NAME>>()
			Me.oo_OOo0.O___oo. = True
			Dim array As String() = Clipboard.GetText().TrimEnd(New Char() { vbCr, vbLf }).Split(New Char() { MyBase.ClipSeparators(1) })
			Dim selection As CellRange = Me.Selection
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num
				Dim num2 As Integer = selection.TopRow + i
				If num2 > MyBase.Rows.Count - 1 Then
					Exit For
				End If
				Dim array2 As String() = array(i).Split(New Char() { MyBase.ClipSeparators(0) })
				Dim j As Integer = selection.LeftCol - 1
				Dim num3 As Integer = array2.Length - 1
				Dim k As Integer = 0
				IL_1B2:
				While k <= num3
					j += 1
					While j <= MyBase.Cols.Count - 1
						If Not MyBase.Cols(j).Visible Then
							j += 1
						Else
							If Not Me.o000OOo.OO.(num2, j) Then
								GoTo IL_1A4
							End If
							Dim name As String = MyBase.Cols(j).Name
							If Operators.CompareString(name, "", True) <= 0 OrElse Not Me.o.0O_O0o_..Cols.Contains(name) OrElse Me.o.0O_O0o_..Cols(name).AllowDirectType Then
								Dim text As String = array2(k)
								text = text.Replace(vbCrLf, vbLf)
								text = text.Replace(vbCr, vbLf)
								text = text.Replace(vbLf, vbCrLf)
								MyBase(num2, j) = text.Trim(New Char() { " "c, vbLf, vbCr })
								Me.O.O0_0.(num2, j, Nothing)
								GoTo IL_1A4
							End If
							IL_1AC:
							k += 1
							GoTo IL_1B2
							IL_1A4:
							If Me.oo_OOo0.O___oo. Then
								GoTo IL_1AC
							End If
							Return
						End If
					End While
					Exit While
				End While
			Next
		End Sub

		' Token: 0x0600046A RID: 1130 RVA: 0x00016204 File Offset: 0x00014404
		Friend Sub <<EMPTY_NAME>>()
			Dim selection As CellRange = Me.Selection
			Me.oo_OOo0.O___oo. = True
			Dim topRow As Integer = selection.TopRow
			Dim bottomRow As Integer = selection.BottomRow
			For i As Integer = topRow To bottomRow
				Dim leftCol As Integer = selection.LeftCol
				Dim rightCol As Integer = selection.RightCol
				For j As Integer = leftCol To rightCol
					If MyBase.Cols(j).Visible Then
						If Me.o000OOo.OO.(i, j) Then
							MyBase(i, j) = Nothing
							Me.O.O0_0.(i, j, Nothing)
						End If
						If Not Me.oo_OOo0.O___oo. Then
							Return
						End If
					End If
				Next
			Next
		End Sub

		' Token: 0x0600046B RID: 1131 RVA: 0x00016294 File Offset: 0x00014494
		Friend Sub <<EMPTY_NAME>>()
			If Me.o.0O_O0o_..DataTable.AllowClipBoard Then
				Dim value As Char = MyBase.ClipSeparators(0)
				Dim value2 As Char = MyBase.ClipSeparators(1)
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Dim flag As Boolean
				If Me.o.0O_O0o_..GridTreeVisible AndAlso Me.o.0O_O0o_..o.0ooOO_0__. IsNot Nothing Then
					flag = True
				End If
				If Me.o.0O_O0o_..DataTable.AllowCopyHeader Then
					Dim leftCol As Integer = Me.Selection.LeftCol
					Dim rightCol As Integer = Me.Selection.RightCol
					For i As Integer = leftCol To rightCol
						If MyBase.Cols(i).Visible Then
							stringBuilder.Append(MyBase.Cols(i).Name)
							If i < Me.Selection.RightCol Then
								stringBuilder.Append(value)
							End If
						End If
					Next
					stringBuilder.Append(value2)
				End If
				Dim topRow As Integer = Me.Selection.TopRow
				Dim bottomRow As Integer = Me.Selection.BottomRow
				For j As Integer = topRow To bottomRow
					Dim leftCol2 As Integer = Me.Selection.LeftCol
					Dim rightCol2 As Integer = Me.Selection.RightCol
					For k As Integer = leftCol2 To rightCol2
						If MyBase.Cols(k).Visible Then
							If MyBase.Rows(j).DataIndex = -1 AndAlso Not MyBase.Rows(j).IsNode Then
								Dim name As String = MyBase.Cols(k).Name
								If Me.o_.o..ContainsKey(name) Then
									stringBuilder.Append(Me.o_.o.(name))
								Else
									stringBuilder.Append("")
								End If
							Else
								Dim obj As Object = Nothing
								If flag Then
									Dim name2 As String = MyBase.Cols(k).Name
									If Me.o.0O_O0o_..o.0ooOO_0__..Contains(name2) Then
										Dim key As DataRow = Me.o.0O_O0o_..Rows(MyBase.Rows(j).DataIndex).BaseDataRow
										Dim dictionary As Dictionary(Of String, Double) = Nothing
										If Me.o.0O_O0o_..o.0ooOO_0__..TryGetValue(key, dictionary) Then
											Dim num As Double = 0.0
											If dictionary.TryGetValue(name2, num) Then
												obj = num
											End If
										End If
									End If
								End If
								If obj Is Nothing Then
									obj = RuntimeHelpers.GetObjectValue(Me.GetData(j, k))
								End If
								If obj Is Nothing Then
									stringBuilder.Append("")
								Else
									stringBuilder.Append(obj.ToString().Replace(vbCrLf, vbLf))
								End If
							End If
							If k < Me.Selection.RightCol Then
								stringBuilder.Append(value)
							End If
						End If
					Next
					If j < Me.Selection.BottomRow Then
						stringBuilder.Append(value2)
					End If
				Next
				If stringBuilder.Length > 0 Then
					Try
						Clipboard.SetText(stringBuilder.ToString())
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600046C RID: 1132 RVA: 0x000165C4 File Offset: 0x000147C4
		Friend Overloads Function <<EMPTY_NAME>>(A_0 As CellRange) As String
			Dim value As Char = MyBase.ClipSeparators(0)
			Dim value2 As Char = MyBase.ClipSeparators(1)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim topRow As Integer = A_0.TopRow
			Dim bottomRow As Integer = A_0.BottomRow
			For i As Integer = topRow To bottomRow
				Dim leftCol As Integer = A_0.LeftCol
				Dim rightCol As Integer = A_0.RightCol
				For j As Integer = leftCol To rightCol
					If Me.GetData(i, j) Is Nothing Then
						stringBuilder.Append("")
					Else
						stringBuilder.Append(Me.GetData(i, j).ToString())
					End If
					If j < A_0.RightCol Then
						stringBuilder.Append(value)
					End If
				Next
				If i < A_0.BottomRow Then
					stringBuilder.Append(value2)
				End If
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x0600046D RID: 1133 RVA: 0x0001668E File Offset: 0x0001488E
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs, A_2 As String, A_3 As System.Windows.Forms.Control, A_4 As RecordGrid)
			Me.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), A_1, A_2, A_3, A_4)
		End Sub

		' Token: 0x0600046E RID: 1134 RVA: 0x000166A4 File Offset: 0x000148A4
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs, A_2 As String, A_3 As System.Windows.Forms.Control, A_4 As RecordGrid, A_5 As Boolean)
			If A_1.KeyCode <> Keys.ControlKey Then
				Me.o_.o. = True
				If MyBase.Rows(A_1.Row).DataIndex <> -1 Then
					If A_4 IsNot Nothing Then
						If Not(TypeOf A_4.BaseGrid.Editor Is System.Windows.Forms.TextBox) Then
							Return
						End If
					ElseIf Not(TypeOf MyBase.Editor Is System.Windows.Forms.TextBox) Then
						Return
					End If
					Dim keyEditEventArgs As KeyEditEventArgs = New KeyEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), Me.o.0O_O0o_..Cols(A_2), A_1.KeyData, A_3, A_4)
					Dim a_ As String = "KeyDownEdit"
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { keyEditEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
					If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.KeyDownEdit AndAlso Not keyEditEventArgs.Handled Then
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { keyEditEventArgs }, False, "全局表事件", False)
					End If
					A_1.Handled = keyEditEventArgs.Handled
					If Not A_1.Handled Then
						Dim flag As Boolean = True
						Dim num As Integer = MyBase.Col + 1
						Dim num2 As Integer = MyBase.Cols.Count - 1
						For i As Integer = num To num2
							If MyBase.Cols(i).Visible Then
								flag = False
								Exit For
							End If
						Next
						If A_1.KeyCode = Keys.[Return] Then
							If(Not flag OrElse A_1.Row <> MyBase.Rows.Count - 1) AndAlso (MyBase.KeyActionEnter <> 1 OrElse A_1.Row <> MyBase.Rows.Count - 1) Then
								A_1.Handled = True
								If TypeOf MyBase.Editor Is O0_0_0_Oo_o Then
									Dim o0_0_0_Oo_o As O0_0_0_Oo_o = CType(MyBase.Editor, O0_0_0_Oo_o)
									If o0_0_0_Oo_o.AutoCompleteMode = AutoCompleteMode.SuggestAppend AndAlso o0_0_0_Oo_o.AutoCompleteSource = AutoCompleteSource.CustomSource Then
										MyBase.FinishEditing()
									End If
								End If
								If A_1.Modifiers <> Keys.Control Then
									MyBase.FinishEditing()
								End If
								If MyBase.Editor Is Nothing Then
									If MyBase.KeyActionEnter = 2 Then
										If A_5 Then
											Me.OOOo_oO_O.O.(True)
											Return
										End If
									ElseIf A_5 Then
										Me.o.Ooo_0o_oO.(True)
										Return
									End If
								End If
							End If
						ElseIf A_1.KeyCode = Keys.Tab AndAlso (flag OrElse MyBase.KeyActionTab = 1) AndAlso A_1.Row = MyBase.Rows.Count - 1 Then
							MyBase.FinishEditing()
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600046F RID: 1135 RVA: 0x00016946 File Offset: 0x00014B46
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs)
			Me.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), A_1, MyBase.Cols(A_1.Col).Name, MyBase.Editor, Nothing, True)
		End Sub

		' Token: 0x06000470 RID: 1136 RVA: 0x00016974 File Offset: 0x00014B74
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEditEventArgs, A_2 As System.Windows.Forms.Control, A_3 As RecordGrid)
			If MyBase.Rows(A_1.Row).DataIndex <> -1 Then
				If A_3 IsNot Nothing Then
					If Not(TypeOf A_3.BaseGrid.Editor Is System.Windows.Forms.TextBox) Then
						Return
					End If
				ElseIf Not(TypeOf MyBase.Editor Is System.Windows.Forms.TextBox) Then
					Return
				End If
				Dim keyPressEditEventArgs As KeyPressEditEventArgs = New KeyPressEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name), A_1.KeyChar, A_2, A_3)
				Dim a_ As String = "KeyPressEdit"
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { keyPressEditEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.KeyPressEdit AndAlso Not keyPressEditEventArgs.Cancel Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { keyPressEditEventArgs }, False, "全局表事件", False)
				End If
				A_1.Handled = keyPressEditEventArgs.Cancel
			End If
		End Sub

		' Token: 0x06000471 RID: 1137 RVA: 0x00016AD4 File Offset: 0x00014CD4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEditEventArgs)
			Me.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), A_1, MyBase.Editor, Nothing)
		End Sub

		' Token: 0x06000472 RID: 1138 RVA: 0x00016AEC File Offset: 0x00014CEC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim keyEventArgs As KeyEventArgs = New KeyEventArgs(Me.o.0O_O0o_., A_1.KeyData)
			Dim a_ As String = "KeyUp"
			If OO_00oOO.SystemReady Then
				If Me.o.0O_O0o_..o0__OOo0._oO. Is Nothing Then
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { keyEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				Else
					O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..o0__OOo0._oO., a_, New Object() { keyEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				End If
			End If
			If Not keyEventArgs.Handled AndAlso Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.KeyUp Then
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { keyEventArgs }, False, "全局表事件", False)
			End If
			If keyEventArgs.Handled Then
				A_1.Handled = keyEventArgs.Handled
				A_1.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000473 RID: 1139 RVA: 0x00016C04 File Offset: 0x00014E04
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs, A_2 As String, A_3 As System.Windows.Forms.Control, A_4 As RecordGrid)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If MyBase.Rows(A_1.Row).DataIndex = -1 Then
					GoTo IL_167
				End If
				IL_25:
				num2 = 4
				If A_4 Is Nothing Then
					GoTo IL_45
				End If
				IL_2B:
				num2 = 5
				If Not(TypeOf A_4.BaseGrid.Editor Is System.Windows.Forms.TextBox) Then
					GoTo IL_167
				End If
				GoTo IL_57
				IL_45:
				num2 = 8
				If Not(TypeOf MyBase.Editor Is System.Windows.Forms.TextBox) Then
					GoTo IL_167
				End If
				IL_57:
				num2 = 10
				Dim keyEditEventArgs As KeyEditEventArgs = New KeyEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), Me.o.0O_O0o_..Cols(A_2), A_1.KeyData, A_3, A_4)
				IL_B2:
				num2 = 11
				Dim a_ As String = "KeyUpEdit"
				IL_BC:
				num2 = 12
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { keyEditEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_F3:
				num2 = 13
				If MyBase.Disposing OrElse MyBase.IsDisposed OrElse Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.KeyUpEdit OrElse keyEditEventArgs.Handled Then
					GoTo IL_158
				End If
				IL_137:
				num2 = 14
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { keyEditEventArgs }, False, "全局表事件", False)
				IL_158:
				num2 = 15
				A_1.Handled = keyEditEventArgs.Handled
				IL_167:
				GoTo IL_1F9
				IL_16C:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1BA:
				GoTo IL_1EE
				IL_1BC:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1CC:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1BC
			End Try
			IL_1EE:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1F9:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000474 RID: 1140 RVA: 0x00016E30 File Offset: 0x00015030
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs)
			Me.O._o0O0o0o0.(RuntimeHelpers.GetObjectValue(A_0), A_1, MyBase.Cols(A_1.Col).Name, MyBase.Editor, Nothing)
		End Sub

		' Token: 0x06000475 RID: 1141 RVA: 0x00016E5C File Offset: 0x0001505C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_1.Button <> MouseButtons.Right Then
					GoTo IL_298
				End If
				IL_19:
				num2 = 3
				Dim hitTestInfo As HitTestInfo = MyBase.HitTest(A_1.X, A_1.Y)
				IL_2F:
				num2 = 4
				If Me.o.0O_O0o_..View.Count <> 0 Then
					GoTo IL_4C
				End If
				IL_43:
				num2 = 5
				Dim hitTypeEnum As HitTypeEnum = 4
				GoTo IL_FA
				IL_4C:
				num2 = 7
				If hitTestInfo.Type <> 2 OrElse Me.MouseCol < MyBase.Cols.Fixed Then
					GoTo IL_74
				End If
				IL_6B:
				num2 = 8
				hitTypeEnum = 1
				GoTo IL_FA
				IL_74:
				num2 = 10
				If hitTestInfo.Type <> 5 OrElse Me.MouseRow < MyBase.Rows.Fixed Then
					GoTo IL_9B
				End If
				IL_94:
				num2 = 11
				hitTypeEnum = 0
				GoTo IL_FA
				IL_9B:
				num2 = 13
				If hitTestInfo.Type IsNot Nothing Then
					GoTo IL_AE
				End If
				IL_A7:
				num2 = 14
				hitTypeEnum = 4
				GoTo IL_FA
				IL_AE:
				num2 = 16
				If Not Me.Selection.IsSingleCell Then
					GoTo IL_C9
				End If
				IL_C2:
				num2 = 17
				hitTypeEnum = 2
				GoTo IL_FA
				IL_C9:
				num2 = 19
				If Me.MouseRow < MyBase.Rows.Fixed AndAlso Me.MouseCol < MyBase.Cols.Fixed Then
					GoTo IL_298
				End If
				IL_F5:
				num2 = 21
				hitTypeEnum = 3
				IL_FA:
				num2 = 22
				Dim beforeShowContextMenuEventArgs As BeforeShowContextMenuEventArgs = New BeforeShowContextMenuEventArgs(Me.o.0O_O0o_., hitTypeEnum)
				IL_10B:
				num2 = 23
				Dim a_ As String = "BeforeShowContextMenu"
				IL_115:
				num2 = 24
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { beforeShowContextMenuEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_14D:
				num2 = 25
				If beforeShowContextMenuEventArgs.Cancel OrElse Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeShowContextMenu Then
					GoTo IL_1AF
				End If
				IL_182:
				num2 = 26
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { beforeShowContextMenuEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_1AF:
				num2 = 27
				If beforeShowContextMenuEventArgs.Cancel Then
					GoTo IL_298
				End If
				IL_1BE:
				num2 = 30
				If beforeShowContextMenuEventArgs.ContextMenu Is Nothing Then
					GoTo IL_21A
				End If
				IL_1CA:
				num2 = 31
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(Me), New Object() { beforeShowContextMenuEventArgs.ContextMenu.BaseMenu })
				IL_1F7:
				num2 = 32
				beforeShowContextMenuEventArgs.ContextMenu.Show(Me, New Point(A_1.X, A_1.Y))
				GoTo IL_298
				IL_21A:
				num2 = 34
				Dim name As String = [Enum].GetName(GetType(HitTypeEnum), hitTypeEnum)
				IL_234:
				num2 = 35
				If Not O_O0OO.o.00O_O.().ContainsKey(name) Then
					GoTo IL_298
				End If
				IL_245:
				num2 = 36
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(Me), New Object() { O_O0OO.o.00O_O.()(name) })
				IL_272:
				num2 = 37
				O_O0OO.o.00O_O.()(name).ShowContextMenu(Me, New Point(A_1.X, A_1.Y))
				IL_298:
				GoTo IL_382
				IL_29D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_343:
				GoTo IL_377
				IL_345:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_355:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_345
			End Try
			IL_377:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_382:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000476 RID: 1142 RVA: 0x00017210 File Offset: 0x00015410
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs, A_2 As Boolean, A_3 As Boolean, Optional ByRef A_4 As Boolean = False)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso MyBase.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_. IsNot Nothing Then
				Dim name As String
				If A_1.Style IsNot Nothing Then
					name = A_1.Style.Name
				End If
				Dim flag As Boolean = Me.Selection.ContainsRow(A_1.Row)
				If A_1.Col = 0 And A_1.Row = 0 Then
					If Me.OO_.00oO0Oo.().ShowLockTableIcon AndAlso Not Me.o.0O_O0o_..AllowEdit Then
						A_1.Image = O_O0OO.O_O00OOooo.O_.
						Return
					End If
				ElseIf A_1.Col <= MyBase.Cols.Fixed - 1 OrElse Operators.CompareString(MyBase.Cols(A_1.Col).Name, Nothing, True) <> 0 Then
					If A_1.Col >= MyBase.Cols.Fixed And A_1.Row < MyBase.Rows.Fixed Then
						Dim image As Image = Nothing
						If Me.OO_.00oO0Oo.().ShowLockColumnIcon AndAlso Not Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name).AllowEdit Then
							image = a.ooO.Oo.().ToBitmap()
						ElseIf Me.OO_.00oO0Oo.().ShowSortIcon AndAlso Me.o.0O_O0o_..O_O__.ooOo..ContainsKey(MyBase.Cols(A_1.Col).Name.ToLower()) Then
							If Me.o.0O_O0o_..O_O__.ooOo.(MyBase.Cols(A_1.Col).Name.ToLower()) = ListSortDirection.Ascending Then
								A_1.Image = a.o0Oo_0o._00Oo_.().ToBitmap()
							Else
								A_1.Image = a.ooO.OooOoOO.().ToBitmap()
							End If
						End If
						If image IsNot Nothing Then
							If A_1.Row = MyBase.Rows.Fixed - 1 Then
								A_1.Image = image
								Return
							End If
							Dim row As Integer = A_1.Row
							Dim num As Integer = MyBase.Rows.Fixed - 1
							For i As Integer = row To num
								If Operators.CompareString(Me.GetDataDisplay(i, A_1.Col), Me.GetDataDisplay(A_1.Row, A_1.Col), True) <> 0 Then
									Return
								End If
							Next
							A_1.Image = image
							Return
						End If
					ElseIf(A_1.Col = 0 And Me.o.0O_O0o_..View.Count > 0) AndAlso A_1.Row >= MyBase.Rows.Fixed Then
						Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.Ooo.Oo0o0.
						If methodInfo Is Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeDrawRow AndAlso O_O0OO.O0_00o.o0__o..OO.OOOO. IsNot Nothing Then
							methodInfo = O_O0OO.O0_00o.o0__o..OO.OOOO.
						End If
						If methodInfo IsNot Nothing Then
							Dim drawRowEventArgs As DrawRowEventArgs
							If MyBase.Rows(A_1.Row).DataIndex > -1 Then
								drawRowEventArgs = New DrawRowEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), MyBase.Rows(A_1.Row).Height)
							Else
								drawRowEventArgs = New DrawRowEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., A_1.Row - MyBase.Rows.Fixed), MyBase.Rows(A_1.Row).Height)
							End If
							Try
								methodInfo.Invoke(Nothing, New Object() { drawRowEventArgs })
								If MyBase.Rows(A_1.Row).Height <> drawRowEventArgs.Height Then
									MyBase.Rows(A_1.Row).Height = drawRowEventArgs.Height
									Return
								End If
							Catch a_ As Exception
								If methodInfo Is O_O0OO.O0_00o.o0__o..OO.OOOO. Then
									O_O0OO.O0_00o.o0__o..OO.OOOO. = Nothing
									ooO.oOo0Oo.o.(a_, "全局表事件,BeforeDrawRow")
								Else
									Me.o.0O_O0o_..DataTable.Ooo.Oo0o0. = Nothing
									ooO.oOo0Oo.o.(a_, "表，" + Me.o.0O_O0o_..DataTable.Name + "，BeforeDrawRow")
								End If
								MessageBox.Show("BeforeDrawRow事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							End Try
						End If
						If MyBase.Rows(A_1.Row).DataIndex > -1 Then
							If MyBase.Cols(0).DataType Is GetType(Boolean) Then
								Return
							End If
							Dim dataRowView As DataRowView = Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)
							If dataRowView Is Nothing Then
								Return
							End If
							Dim row2 As DataRow = dataRowView.Row
							If row2 IsNot Nothing AndAlso (row2.RowState = DataRowState.Deleted OrElse row2.RowState = DataRowState.Detached) Then
								Return
							End If
							If Me.OO_.00oO0Oo.().ShowLineNumber Then
								A_1.Text = (MyBase.Rows(A_1.Row).DataIndex + 1).ToString()
								If row2 Is Nothing Then
									If flag Then
										A_1.Style = MyBase.Styles("SelectedAddedRowHeader")
									Else
										A_1.Style = MyBase.Styles("AddedRowHeader")
									End If
								ElseIf row2.IsNull("_Locked") OrElse Not Conversions.ToBoolean(row2("_Locked")) Then
									Dim rowState As DataRowState = row2.RowState
									If rowState <> DataRowState.Unchanged Then
										If rowState <> DataRowState.Added Then
											If rowState = DataRowState.Modified Then
												If flag Then
													A_1.Style = MyBase.Styles("SelectedModifiedRowHeader")
												Else
													A_1.Style = MyBase.Styles("ModifiedRowHeader")
												End If
											End If
										ElseIf flag Then
											A_1.Style = MyBase.Styles("SelectedAddedRowHeader")
										Else
											A_1.Style = MyBase.Styles("AddedRowHeader")
										End If
									ElseIf flag Then
										A_1.Style = MyBase.Styles("SelectedUnchangedRowHeader")
									Else
										A_1.Style = MyBase.Styles("UnchangedRowHeader")
									End If
								Else
									Dim rowState2 As DataRowState = row2.RowState
									If rowState2 <> DataRowState.Unchanged Then
										If rowState2 <> DataRowState.Added Then
											If rowState2 = DataRowState.Modified Then
												If flag Then
													A_1.Style = MyBase.Styles("SelectedLockedModifiedRowHeader")
												Else
													A_1.Style = MyBase.Styles("LockedModifiedRowHeader")
												End If
											End If
										ElseIf flag Then
											A_1.Style = MyBase.Styles("SelectedLockedAddedRowHeader")
										Else
											A_1.Style = MyBase.Styles("LockedAddedRowHeader")
										End If
									ElseIf flag Then
										A_1.Style = MyBase.Styles("SelectedLockedRowHeader")
									Else
										A_1.Style = MyBase.Styles("LockedRowHeader")
									End If
								End If
							ElseIf Me.OO_.00oO0Oo.().ShowLockRowIcon AndAlso Not row2.IsNull("_Locked") AndAlso Conversions.ToBoolean(row2("_Locked")) Then
								A_1.Image = O_O0OO.o.0__0_O_.
							End If
						End If
						If MyBase.Rows(A_1.Row).DataIndex = -1 AndAlso Not MyBase.Rows(A_1.Row).IsNode Then
							A_1.Style = MyBase.Styles("GrandTotalRowHeader")
							Return
						End If
					ElseIf A_1.Col >= MyBase.Cols.Fixed AndAlso A_1.Row >= MyBase.Rows.Fixed AndAlso MyBase.Rows(A_1.Row).DataIndex = -1 AndAlso Not MyBase.Rows(A_1.Row).IsNode Then
						A_1.Style = MyBase.Styles(13)
						Dim columnName As String = Me.o.0O_O0o_..View.o_o.O0ooOo.().Columns(MyBase.Cols(A_1.Col).Name).ColumnName
						If MyBase.Cols.Fixed = A_1.Col Then
							A_1.Text = "合计"
							If A_1.Image IsNot Nothing Then
								A_1.Image = Nothing
							End If
						Else
							Dim col As Col = Me.o.0O_O0o_..Cols(columnName)
							If col.IsNumeric() AndAlso col.GrandTotal Then
								Dim num2 As Double = MyBase.Aggregate(2, MyBase.Rows.Fixed, A_1.Col, MyBase.Rows.Count - 1, A_1.Col, 1)
								num2 = Math.Round(num2, col.DataCol.Decimals)
								Dim text As String = ""
								If MyBase.Cols(A_1.Col).DataType Is GetType(Double) AndAlso Me.o.0O_O0o_..Cols(columnName).DataCol.ExtendColumnType = 8 Then
									O_O0OO.o.00O_O.(num2, text)
								ElseIf Operators.CompareString(MyBase.Cols(A_1.Col).Format, "", True) > 0 Then
									text = Strings.Format(num2, MyBase.Cols(A_1.Col).Format)
								Else
									text = num2.ToString()
								End If
								A_1.Text = text
							End If
						End If
						If Me.o_.o..ContainsKey(columnName) Then
							Me.o_.o.(columnName) = A_1.Text
							Return
						End If
						Me.o_.o..Add(columnName, A_1.Text)
						Return
					ElseIf A_1.Col >= MyBase.Cols.Fixed AndAlso A_1.Row >= MyBase.Rows.Fixed Then
						Dim columnName2 As String = Me.o.0O_O0o_..View.o_o.O0ooOo.().Columns(MyBase.Cols(A_1.Col).Name).ColumnName
						If MyBase.Cols(A_1.Col).DataType Is GetType(Double) AndAlso Me.o.0O_O0o_..Cols(columnName2).DataCol.ExtendColumnType = 8 AndAlso MyBase(A_1.Row, A_1.Col) IsNot Nothing AndAlso MyBase(A_1.Row, A_1.Col) IsNot DBNull.Value Then
							Dim a_2 As Double = Conversions.ToDouble(MyBase(A_1.Row, A_1.Col))
							Dim text2 As String = ""
							If O_O0OO.o.00O_O.(a_2, text2) Then
								A_1.Text = text2
							End If
						End If
						If MyBase.Rows(A_1.Row).DataIndex > -1 Then
							If MyBase.Cols(A_1.Col).DataType Is GetType(Integer) AndAlso Me.o.0O_O0o_..Cols(columnName2).DataCol.ExtendColumnType = 5 Then
								Dim bounds As Rectangle = A_1.Bounds
								If Me.Selection.Contains(A_1.Row, A_1.Col) Then
									bounds = New Rectangle(bounds.X + 1, bounds.Y + 1, bounds.Width - 4, bounds.Height - 4)
									A_1.Graphics.DrawRectangle(Pens.Gray, bounds)
									bounds = New Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 3, bounds.Height - 3)
								Else
									bounds = New Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 5, bounds.Height - 5)
								End If
								If MyBase(A_1.Row, A_1.Col) IsNot Nothing AndAlso MyBase(A_1.Row, A_1.Col) IsNot DBNull.Value Then
									A_1.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(Conversions.ToInteger(MyBase(A_1.Row, A_1.Col)))), bounds)
								End If
								If Not A_3 Then
									A_1.DrawCell(2)
								Else
									A_1.Text = " "
								End If
								A_1.Handled = True
							End If
							If OO_00oOO.MarkModifedCell AndAlso Not A_1.Handled AndAlso MyBase.Rows(A_1.Row).DataIndex > -1 Then
								Dim row3 As DataRow = Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex).Row
								If row3.RowState = DataRowState.Modified AndAlso String.Compare(row3(columnName2).ToString(), row3(columnName2, DataRowVersion.Original).ToString(), False) <> 0 Then
									A_1.Style = MyBase.Styles("ModifiedCell")
								End If
							End If
							If(Me.o.0O_O0o_..ListMode And Not A_1.Handled) AndAlso A_1.Row = MyBase.Row AndAlso MyBase.Rows(A_1.Row).DataIndex > -1 AndAlso Not Me.Selection.Contains(A_1.Row, A_1.Col) Then
								A_1.Style = MyBase.Styles("CurrentRow")
							End If
							If MyBase.Rows(A_1.Row).DataIndex > -1 AndAlso A_1.Col >= MyBase.Cols.Fixed AndAlso Me.o.0O_O0o_..HierarchyData AndAlso Me.o.0O_O0o_..o.0ooOO_0__. IsNot Nothing Then
								Dim row4 As DataRow = Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex).Row
								Dim dictionary As Dictionary(Of String, Double) = Nothing
								Dim num3 As Double
								If Me.o.0O_O0o_..o.0ooOO_0__..TryGetValue(row4, dictionary) AndAlso dictionary.TryGetValue(columnName2, num3) Then
									If Operators.CompareString(MyBase.Cols(A_1.Col).Format, "", True) > 0 Then
										A_1.Text = Strings.Format(num3, MyBase.Cols(A_1.Col).Format)
									Else
										A_1.Text = num3.ToString()
									End If
								End If
							End If
						End If
						If O_O0OO.O0_00o.o0__o..OO_O00O.O_.(O_O0OO.O0_00o.o0__o.) AndAlso Not A_1.Handled AndAlso A_2 Then
							Dim methodInfo2 As MethodInfo = Me.o.0O_O0o_..DataTable.OO00.oO_.
							If methodInfo2 Is Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.DrawCell AndAlso O_O0OO.O0_00o.o0__o..oO0o_.__O0. IsNot Nothing Then
								methodInfo2 = O_O0OO.O0_00o.o0__o..oO0o_.__O0.
							End If
							If methodInfo2 IsNot Nothing Then
								Dim drawCellEventArgs As DrawCellEventArgs
								If MyBase.Rows(A_1.Row).DataIndex > -1 Then
									drawCellEventArgs = New DrawCellEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name), A_1, Me, A_3)
								Else
									drawCellEventArgs = New DrawCellEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., A_1.Row - MyBase.Rows.Fixed), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name), A_1, Me, A_3)
								End If
								A_4 = drawCellEventArgs.O0O__O._0.
								Try
									methodInfo2.Invoke(Nothing, New Object() { drawCellEventArgs })
									If Not A_1.Handled AndAlso Operators.CompareString(drawCellEventArgs.Style, "", True) > 0 AndAlso MyBase.Styles.Contains("User" + drawCellEventArgs.Style) Then
										If Me.Selection.ContainsRow(A_1.Row) AndAlso Me.Selection.ContainsCol(A_1.Col) AndAlso Not Me.Selection.IsSingleCell Then
											If Not MyBase.Styles.Contains("^^User" + drawCellEventArgs.Style) Then
												MyBase.Styles.Add("^^User" + drawCellEventArgs.Style).MergeWith(MyBase.Styles("User" + drawCellEventArgs.Style))
											End If
											Dim cellStyle As CellStyle = MyBase.Styles("^^User" + drawCellEventArgs.Style)
											Dim color As Color = MyBase.Styles("User" + drawCellEventArgs.Style).BackColor
											Dim color2 As Color = MyBase.Styles.Highlight.BackColor
											Dim color3 As Color = Color.FromArgb(CInt(Math.Round((CDbl(color.R) * 0.7 + CDbl(color2.R)) / 2.0)), CInt(Math.Round((CDbl(color.G) * 0.7 + CDbl(color2.G)) / 2.0)), CInt(Math.Round((CDbl(color.B) * 0.7 + CDbl(color2.B)) / 2.0)))
											If cellStyle.BackColor <> color3 Then
												cellStyle.BackColor = color3
											End If
											color = MyBase.Styles("User" + drawCellEventArgs.Style).ForeColor
											color2 = MyBase.Styles.Highlight.ForeColor
											color3 = Color.FromArgb(CInt(Math.Round((CDbl(color.R) * 0.7 + CDbl(color2.R)) / 2.0)), CInt(Math.Round((CDbl(color.G) * 0.7 + CDbl(color2.G)) / 2.0)), CInt(Math.Round((CDbl(color.B) * 0.7 + CDbl(color2.B)) / 2.0)))
											If cellStyle.ForeColor <> color3 Then
												cellStyle.ForeColor = color3
											End If
											A_1.Style = cellStyle
										Else
											A_1.Style = MyBase.Styles("User" + drawCellEventArgs.Style)
										End If
									End If
								Catch a_3 As Exception
									If methodInfo2 Is O_O0OO.O0_00o.o0__o..oO0o_.__O0. Then
										O_O0OO.O0_00o.o0__o..oO0o_.__O0. = Nothing
										ooO.oOo0Oo.o.(a_3, "全局表事件,DrawCell")
									Else
										Me.o.0O_O0o_..DataTable.OO00.oO_. = Nothing
										ooO.oOo0Oo.o.(a_3, "表，" + Me.o.0O_O0o_..DataTable.Name + "，DrawCell")
									End If
									MessageBox.Show("DrawCell事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								End Try
							End If
						End If
						If MyBase.Rows(A_1.Row).DataIndex > -1 Then
							If Me.o.0O_O0o_..GridTreeVisible AndAlso A_1.Col >= MyBase.Cols.Fixed AndAlso Operators.CompareString(name, A_1.Style.Name, True) = 0 AndAlso Me.o.0O_O0o_..oO._o. Then
								Dim dataIndex As Integer = MyBase.Rows(A_1.Row).DataIndex
								Dim row5 As Row = Me.o.0O_O0o_..Rows(dataIndex)
								If row5.HasChild Then
									Dim hierarchy As Integer = row5.Hierarchy
									Dim num4 As Integer = 14 + hierarchy Mod 6
									Dim style As CellStyle = MyBase.Styles(num4)
									If Not Me.Selection.ContainsRow(A_1.Row) OrElse Not Me.Selection.ContainsCol(A_1.Col) OrElse Me.Selection.IsSingleCell Then
										A_1.Style = style
									End If
								End If
							End If
							If A_1.Col >= MyBase.Cols.Fixed AndAlso Me.o.0O_O0o_..HierarchyData AndAlso Operators.CompareString(MyBase.Cols(A_1.Col).Name, Me.o.0O_O0o_..OO0o_o0.0oOo0o., True) = 0 Then
								Dim dataIndex2 As Integer = MyBase.Rows(A_1.Row).DataIndex
								Dim dataRowView2 As DataRowView = Me.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2)
								Dim dataRowView3 As DataRowView = Nothing
								If dataIndex2 < Me.o.0O_O0o_..View.Count - 1 Then
									dataRowView3 = Me.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2 + 1)
								End If
								If Not dataRowView2.Row.IsNull("sys_Hierarchy_Level") Then
									Dim num5 As Integer = Conversions.ToInteger(dataRowView2("sys_Hierarchy_Level"))
									Dim flag2 As Boolean = Me.GetUserData(A_1.Row, MyBase.Cols.Fixed - 1) Is Nothing
									A_1.Text = New String("　"c, num5 + 1) + " " + A_1.Text
									If dataRowView3 IsNot Nothing AndAlso Not dataRowView3.Row.IsNull("sys_Hierarchy_Level") AndAlso num5 < Conversions.ToInteger(dataRowView3("sys_Hierarchy_Level")) Then
										Dim image2 As Image
										If flag2 Then
											image2 = MyBase.Glyphs(6)
										Else
											image2 = MyBase.Glyphs(5)
										End If
										A_1.DrawCell(255)
										Dim num6 As Integer = CInt(Math.Ceiling(CDbl((Me.OO_.00oO0Oo.(A_1) * CSng((num5 + 1)))) - CDbl(image2.Width) * 1.5)) + 4
										A_1.Graphics.DrawImageUnscaled(image2, A_1.Bounds.X + num6, CInt(Math.Round(CDbl(A_1.Bounds.Y) + CDbl((A_1.Bounds.Height - image2.Height)) / 2.0)))
										A_1.Handled = True
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000477 RID: 1143 RVA: 0x00018898 File Offset: 0x00016A98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If OO_00oOO.SystemReady AndAlso Me.Focused AndAlso A_1.Row <= MyBase.Rows.Count - 1 AndAlso A_1.Col <= MyBase.Cols.Count - 1 Then
				Dim row As Row = MyBase.Rows(A_1.Row)
				Dim column As Column = MyBase.Cols(A_1.Col)
				If row.DataIndex >= 0 Then
					MyBase.Invalidate(A_1.Row, A_1.Col)
					If(Me.o.0O_O0o_..DataTable.o_0.0O0o__0. IsNot Nothing OrElse O_O0OO.O0_00o.o0__o..oO00_.0. IsNot Nothing) AndAlso MyBase.Editor Is Nothing AndAlso A_1.Row >= MyBase.Rows.Fixed AndAlso A_1.Col >= MyBase.Cols.Fixed Then
						Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.o_0.0O0o__0.
						Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), Me.o.0O_O0o_..Cols(column.Name), Nothing)
						If methodInfo IsNot Nothing Then
							Try
								methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "表，" + MyBase.Name + "，MouseEnterCell")
							End Try
						End If
						If Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.MouseEnterCell Then
							methodInfo = O_O0OO.O0_00o.o0__o..oO00_.0.
							If methodInfo IsNot Nothing Then
								Try
									methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
								Catch a_2 As Exception
									ooO.oOo0Oo.o.(a_2, "全局事件, MouseEnterCell")
								End Try
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000478 RID: 1144 RVA: 0x00018AA0 File Offset: 0x00016CA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If OO_00oOO.SystemReady AndAlso Not O_O0OO.o0OoO00OO.00O. AndAlso Me.Focused AndAlso A_1.Row <= MyBase.Rows.Count - 1 AndAlso A_1.Col <= MyBase.Cols.Count - 1 Then
				Dim row As Row = MyBase.Rows(A_1.Row)
				Dim column As Column = MyBase.Cols(A_1.Col)
				If row.DataIndex >= 0 Then
					MyBase.Invalidate(A_1.Row, A_1.Col)
					If(Me.o.0O_O0o_..DataTable.Oo0O0.0. IsNot Nothing OrElse O_O0OO.O0_00o.o0__o..O0OO.OoOOoo_. IsNot Nothing) AndAlso MyBase.Editor Is Nothing AndAlso A_1.Row >= MyBase.Rows.Fixed AndAlso A_1.Col >= MyBase.Cols.Fixed Then
						Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.Oo0O0.0.
						Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), Me.o.0O_O0o_..Cols(column.Name), Nothing)
						If methodInfo IsNot Nothing Then
							Try
								methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "表，" + MyBase.Name + "，MouseLeaveCell")
							End Try
						End If
						If Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.MouseLeaveCell Then
							methodInfo = O_O0OO.O0_00o.o0__o..O0OO.OoOOoo_.
							If methodInfo IsNot Nothing Then
								Try
									methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
								Catch a_2 As Exception
									ooO.oOo0Oo.o.(a_2, "全局事件, MouseLeaveCell")
								End Try
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000479 RID: 1145 RVA: 0x00018CB0 File Offset: 0x00016EB0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If OO_00oOO.SystemReady Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(A_0)
				Dim a_ As Boolean = True
				Dim a_2 As Boolean = False
				Dim flag As Boolean = False
				Me.OO_.00oO0Oo.(objectValue, A_1, a_, a_2, flag)
			End If
		End Sub

		' Token: 0x0600047A RID: 1146 RVA: 0x00018CD7 File Offset: 0x00016ED7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed AndAlso MyBase.FindForm() IsNot Nothing Then
				Me.O.O00O_oO_OO00.(False)
			End If
		End Sub

		' Token: 0x0600047B RID: 1147 RVA: 0x00018CF8 File Offset: 0x00016EF8
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs, A_2 As RecordGrid)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_0 IsNot Me OrElse (A_1.Row = MyBase.Row AndAlso A_1.Col = MyBase.Col) Then
					GoTo IL_37
				End If
				IL_29:
				num2 = 3
				MyBase.FinishEditing()
				GoTo IL_318
				IL_37:
				num2 = 5
				Dim editor As System.Windows.Forms.Control = CType(A_0, C1FlexGrid).Editor
				IL_45:
				num2 = 6
				If MyBase.Rows(A_1.Row).DataIndex = -1 Then
					GoTo IL_318
				End If
				IL_63:
				num2 = 8
				If DataTableProperty.Connected Then
					GoTo IL_7B
				End If
				IL_6C:
				num2 = 9
				editor.Enabled = False
				GoTo IL_318
				IL_7B:
				num2 = 11
				If Not(TypeOf editor Is O0o__o0_o0) Then
					GoTo IL_10F
				End If
				IL_89:
				num2 = 12
				Dim o0o__o0_o As O0o__o0_o0 = CType(editor, O0o__o0_o0)
				IL_94:
				num2 = 13
				o0o__o0_o.DataType = MyBase.Cols(A_1.Col).DataType
				IL_B4:
				num2 = 14
				o0o__o0_o.EditMask = MyBase.Cols(A_1.Col).EditMask
				IL_D4:
				num2 = 15
				o0o__o0_o.CustomFormat = ""
				IL_E3:
				num2 = 16
				o0o__o0_o.EditFormat.FormatType = 2
				IL_F3:
				num2 = 17
				o0o__o0_o.EditFormat.CustomFormat = ""
				IL_107:
				o0o__o0_o = Nothing
				GoTo IL_26D
				IL_10F:
				num2 = 20
				If Not(TypeOf editor Is OO__oo_0ooo0_) Then
					GoTo IL_1A3
				End If
				IL_11D:
				num2 = 21
				Dim oo__oo_0ooo0_ As OO__oo_0ooo0_ = CType(editor, OO__oo_0ooo0_)
				IL_128:
				num2 = 22
				oo__oo_0ooo0_.DataType = MyBase.Cols(A_1.Col).DataType
				IL_148:
				num2 = 23
				oo__oo_0ooo0_.EditMask = MyBase.Cols(A_1.Col).EditMask
				IL_168:
				num2 = 24
				oo__oo_0ooo0_.CustomFormat = ""
				IL_177:
				num2 = 25
				oo__oo_0ooo0_.EditFormat.FormatType = 2
				IL_187:
				num2 = 26
				oo__oo_0ooo0_.EditFormat.CustomFormat = ""
				IL_19B:
				oo__oo_0ooo0_ = Nothing
				GoTo IL_26D
				IL_1A3:
				num2 = 29
				If Not(TypeOf editor Is O0_0_0_Oo_o) Then
					GoTo IL_234
				End If
				IL_1B1:
				num2 = 30
				Dim o0_0_0_Oo_o As O0_0_0_Oo_o = CType(editor, O0_0_0_Oo_o)
				IL_1BC:
				num2 = 31
				o0_0_0_Oo_o.DataType = MyBase.Cols(A_1.Col).DataType
				IL_1DC:
				num2 = 32
				o0_0_0_Oo_o.EditMask = MyBase.Cols(A_1.Col).EditMask
				IL_1FC:
				num2 = 33
				o0_0_0_Oo_o.CustomFormat = ""
				IL_20B:
				num2 = 34
				o0_0_0_Oo_o.EditFormat.FormatType = 2
				IL_21B:
				num2 = 35
				o0_0_0_Oo_o.EditFormat.CustomFormat = ""
				IL_22F:
				o0_0_0_Oo_o = Nothing
				GoTo IL_26D
				IL_234:
				num2 = 38
				If TypeOf editor Is o0_o_o_0 Then
					GoTo IL_26D
				End If
				IL_23F:
				num2 = 40
				If Not(TypeOf editor Is BuildInDropTree) Then
					GoTo IL_26D
				End If
				IL_24A:
				num2 = 41
				Dim buildInDropTree As BuildInDropTree = CType(editor, BuildInDropTree)
				IL_255:
				num2 = 42
				buildInDropTree.Row = Me.o.0O_O0o_..Current
				IL_26A:
				buildInDropTree = Nothing
				IL_26D:
				num2 = 44
				Dim setupEditorEventArgs As SetupEditorEventArgs = New SetupEditorEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name), editor, A_2)
				IL_2D6:
				num2 = 45
				Dim a_ As String = "SetupEditor"
				IL_2E0:
				num2 = 46
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { setupEditorEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_318:
				GoTo IL_426
				IL_31D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_3E7:
				GoTo IL_41B
				IL_3E9:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3F9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3E9
			End Try
			IL_41B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_426:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600047C RID: 1148 RVA: 0x00019150 File Offset: 0x00017350
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If TypeOf MyBase.Editor Is Oooo Then
				CType(MyBase.Editor, Oooo).DataType = GetType(String)
			End If
			Me.OO0o_o_OO.O_O.(RuntimeHelpers.GetObjectValue(A_0), A_1, Nothing)
		End Sub

		' Token: 0x0600047D RID: 1149 RVA: 0x0001918C File Offset: 0x0001738C
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs, A_2 As RecordGrid)
			Me.oo_OOo0.O___oo. = True
			If A_1.Col = 0 AndAlso A_0 Is Me Then
				If Not Me.Selection.ContainsRow(A_1.Row) Then
					MyBase.Row = A_1.Row
				End If
				Dim topRow As Integer = Me.Selection.TopRow
				Dim bottomRow As Integer = Me.Selection.BottomRow
				For i As Integer = topRow To bottomRow
					Dim dataIndex As Integer = MyBase.Rows(i).DataIndex
					If dataIndex >= 0 Then
						Dim row As Row = Me.o.0O_O0o_..Rows(dataIndex)
						row.Checked = Not row.Checked
					End If
				Next
				A_1.Cancel = True
				Return
			End If
			Me.O__o._oOOoO. = 0
			Me.o_.o. = False
			Me.o_.o. = DateTime.Now
			Dim dataIndex2 As Integer = MyBase.Rows(A_1.Row).DataIndex
			Dim row2 As DataRow = Me.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2).Row
			Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(dataIndex2)), Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name), A_2)
			If A_0 IsNot Me Then
				rowColEventArgs.IsFocusCell = True
			Else
				rowColEventArgs.IsFocusCell = (A_1.Row = MyBase.Row AndAlso MyBase.Col = A_1.Col)
			End If
			Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.Oo_.O_.
			If methodInfo IsNot Nothing AndAlso OO_00oOO.SystemReady Then
				Try
					methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "表，" + Me.o.0O_O0o_..DataTable.Name + "，StartEdit")
				End Try
			End If
			If Not rowColEventArgs.Cancel AndAlso Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.StartEdit AndAlso OO_00oOO.SystemReady Then
				methodInfo = O_O0OO.O0_00o.o0__o..oo_00_0._.
				If methodInfo IsNot Nothing Then
					Try
						methodInfo.Invoke(Nothing, New Object() { rowColEventArgs })
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "全局表事件，StartEdit")
					End Try
				End If
			End If
			A_1.Cancel = rowColEventArgs.Cancel
			Me.oo_OOo0.O___oo. = rowColEventArgs.[Continue]
		End Sub

		' Token: 0x0600047E RID: 1150 RVA: 0x00019424 File Offset: 0x00017624
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.O_._. Is Nothing Then
				Me.OOOo_oO_O.O.(RuntimeHelpers.GetObjectValue(A_0), A_1, Nothing)
				Return
			End If
			If Me.O_._. = 2 Then
				A_1.Cancel = True
			End If
			Me.O_._. = 0
		End Sub

		' Token: 0x0600047F RID: 1151 RVA: 0x00019454 File Offset: 0x00017654
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs, A_2 As RecordGrid)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
				IL_10:
				num2 = 3
				Dim editor As System.Windows.Forms.Control = CType(A_0, C1FlexGrid).Editor
				IL_1E:
				num2 = 4
				If A_1.Col = 0 Then
					GoTo IL_691
				End If
				IL_2B:
				num2 = 6
				Me.o_.o. = Nothing
				IL_34:
				num2 = 7
				If MyBase.Rows(A_1.Row).DataIndex = -1 Then
					GoTo IL_691
				End If
				IL_52:
				num2 = 9
				If Not OO_00oOO.Tables.get_Contains(Me.o.0O_O0o_..Name) Then
					GoTo IL_691
				End If
				IL_6F:
				num2 = 11
				Dim col As Col = Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name)
				IL_9A:
				num2 = 12
				If col.CodeDictonary Is Nothing OrElse Not(TypeOf editor Is C1TextBox) OrElse Operators.CompareString(editor.Text, "", True) <= 0 Then
					GoTo IL_F9
				End If
				IL_C2:
				num2 = 13
				If Not col.CodeDictonary.ContainsKey(editor.Text) Then
					GoTo IL_F9
				End If
				IL_D9:
				num2 = 14
				CType(editor, C1TextBox).Value = col.CodeDictonary(editor.Text)
				IL_F9:
				num2 = 15
				If Not(TypeOf editor Is C1TextBox) Then
					GoTo IL_194
				End If
				IL_107:
				num2 = 16
				Dim c1TextBox As C1TextBox = CType(editor, C1TextBox)
				IL_112:
				num2 = 17
				Dim c1TextBox2 As C1TextBox = c1TextBox
				Dim text As Object = c1TextBox.Text
				If c1TextBox2.ParseContent(text, c1TextBox.ErrorInfo) IsNot Nothing Then
					GoTo IL_17D
				End If
				IL_130:
				num2 = 18
				Dim validateEditEventArgs As ValidateEditEventArgs = New ValidateEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), col, c1TextBox.Text, A_2)
				IL_18C:
				c1TextBox = Nothing
				GoTo IL_287
				IL_17D:
				num2 = 20
				A_1.Cancel = True
				GoTo IL_691
				IL_194:
				num2 = 24
				If Not(TypeOf editor Is System.Windows.Forms.TextBox) AndAlso Not(TypeOf editor Is System.Windows.Forms.ComboBox) Then
					GoTo IL_1F6
				End If
				IL_1A7:
				num2 = 25
				validateEditEventArgs = New ValidateEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), col, editor.Text, A_2)
				GoTo IL_287
				IL_1F6:
				num2 = 27
				If editor IsNot Nothing OrElse MyBase.Cols(A_1.Col).DataType IsNot GetType(Boolean) Then
					GoTo IL_691
				End If
				IL_224:
				num2 = 28
				validateEditEventArgs = New ValidateEditEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex)), col, Interaction.IIf(A_1.Checkbox = 1, True, False).ToString(), A_2)
				IL_287:
				num2 = 31
				If Operators.CompareString(validateEditEventArgs.Text, "", True) <= 0 OrElse Operators.CompareString(validateEditEventArgs.Text, Me.GetData(A_1.Row, A_1.Col).ToString(), True) = 0 Then
					GoTo IL_443
				End If
				IL_2CB:
				num2 = 32
				Dim dataCol As DataCol = Me.o.0O_O0o_..Cols(MyBase.Cols(A_1.Col).Name).DataCol
				IL_2FB:
				num2 = 33
				If Not dataCol.Unique Then
					GoTo IL_443
				End If
				IL_30A:
				num2 = 34
				Dim text2 As String = ""
				IL_314:
				num2 = 35
				If Not dataCol.IsString Then
					GoTo IL_35E
				End If
				IL_320:
				num2 = 36
				text2 = String.Concat(New String() { "[", dataCol.Name, "] = '", validateEditEventArgs.Text, "'" })
				GoTo IL_3D6
				IL_35E:
				num2 = 38
				If Not dataCol.IsDate Then
					GoTo IL_3A8
				End If
				IL_36A:
				num2 = 39
				text2 = String.Concat(New String() { "[", dataCol.Name, "] = #", validateEditEventArgs.Text, "#" })
				GoTo IL_3D6
				IL_3A8:
				num2 = 41
				If Not dataCol.IsNumeric Then
					GoTo IL_3D6
				End If
				IL_3B4:
				num2 = 42
				text2 = "[" + dataCol.Name + "] = " + validateEditEventArgs.Text
				IL_3D6:
				num2 = 43
				If Operators.CompareString(text2, "", True) <= 0 Then
					GoTo IL_443
				End If
				IL_3E9:
				num2 = 44
				If Me.o.0O_O0o_..DataTable.BaseTable.[Select](text2).Length <= 0 Then
					GoTo IL_443
				End If
				IL_408:
				num2 = 45
				MessageBox.Show(dataCol.Name + "禁止重复，您输入的值已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_42A:
				num2 = 46
				editor.Focus()
				IL_434:
				num2 = 47
				A_1.Cancel = True
				GoTo IL_691
				IL_443:
				num2 = 49
				If String.Compare(validateEditEventArgs.Text, Me.GetData(A_1.Row, A_1.Col).ToString(), False) = 0 Then
					GoTo IL_4C1
				End If
				IL_46C:
				num2 = 50
				Me.o_.o. = New o0o0o00(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(A_1.Row).DataIndex).Row, MyBase.Cols(A_1.Col).Name)
				IL_4C1:
				num2 = 51
				If editor Is Nothing Then
					GoTo IL_691
				End If
				IL_4CA:
				num2 = 53
				Dim a_ As String = "ValidateEdit"
				IL_4D4:
				num2 = 54
				O_O0OO.OoO_o.oO0o0O.(Me.o.0O_O0o_..DataTable.o_0_00_.oo0O0., a_, New Object() { validateEditEventArgs }, False, Me.o.0O_O0o_..DataTable.Name, False)
				IL_50C:
				num2 = 55
				If MyBase.Disposing OrElse MyBase.IsDisposed OrElse validateEditEventArgs.Cancel OrElse Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.ValidateEdit Then
					GoTo IL_573
				End If
				IL_551:
				num2 = 56
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { validateEditEventArgs }, False, "全局表事件", False)
				IL_573:
				num2 = 57
				A_1.Cancel = validateEditEventArgs.Cancel
				IL_583:
				num2 = 58
				If A_1.Cancel Then
					GoTo IL_67C
				End If
				IL_591:
				num2 = 59
				If Operators.CompareString(validateEditEventArgs.Text, "", True) <= 0 Then
					GoTo IL_5CA
				End If
				IL_5A9:
				num2 = 60
				validateEditEventArgs.Text = validateEditEventArgs.Text.TrimEnd(New Char() { " "c })
				IL_5CA:
				num2 = 61
				If TypeOf editor Is Oooo Then
					GoTo IL_691
				End If
				IL_5D8:
				num2 = 63
				If Not(TypeOf editor Is C1TextBox) Then
					GoTo IL_648
				End If
				IL_5E3:
				num2 = 64
				Dim c1TextBox3 As C1TextBox = CType(editor, C1TextBox)
				IL_5EE:
				num2 = 65
				If Operators.CompareString(validateEditEventArgs.Text, "", True) > 0 Then
					Dim c1TextBox4 As C1TextBox = c1TextBox3
					text = validateEditEventArgs.Text
					If c1TextBox4.ParseContent(text, c1TextBox3.ErrorInfo) IsNot Nothing Then
						GoTo IL_634
					End If
					IL_621:
					num2 = 66
					c1TextBox3.Value = validateEditEventArgs.Text
					GoTo IL_643
				End If
				IL_634:
				num2 = 68
				c1TextBox3.Value = DBNull.Value
				IL_643:
				c1TextBox3 = Nothing
				GoTo IL_691
				IL_648:
				num2 = 71
				If Operators.CompareString(editor.Text, validateEditEventArgs.Text.ToString(), True) = 0 Then
					GoTo IL_691
				End If
				IL_665:
				num2 = 72
				editor.Text = validateEditEventArgs.Text.ToString()
				GoTo IL_691
				IL_67C:
				num2 = 74
				If Not editor.CanFocus Then
					GoTo IL_691
				End If
				IL_687:
				num2 = 75
				editor.Focus()
				IL_691:
				GoTo IL_813
				IL_696:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_7D4:
				GoTo IL_808
				IL_7D6:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7E6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7D6
			End Try
			IL_808:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_813:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000480 RID: 1152 RVA: 0x00019C98 File Offset: 0x00017E98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			Me.O_._.(RuntimeHelpers.GetObjectValue(A_0), A_1, Nothing)
		End Sub

		' Token: 0x06000481 RID: 1153 RVA: 0x00019CA8 File Offset: 0x00017EA8
		Friend Sub <<EMPTY_NAME>>()
			Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.Ooo.Oo0o0.
			If methodInfo Is Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.BeforeDrawRow AndAlso O_O0OO.O0_00o.o0__o..OO.OOOO. IsNot Nothing Then
				methodInfo = O_O0OO.O0_00o.o0__o..OO.OOOO.
			End If
			If methodInfo IsNot Nothing Then
				Dim fixed As Integer = MyBase.Rows.Fixed
				Dim num As Integer = MyBase.Rows.Count - 1
				For i As Integer = fixed To num
					If MyBase.Rows(i).DataIndex > 0 Then
						Dim drawRowEventArgs As DrawRowEventArgs = New DrawRowEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(MyBase.Rows(i).DataIndex)), MyBase.Rows(i).Height)
						Try
							methodInfo.Invoke(Nothing, New Object() { drawRowEventArgs })
							If MyBase.Rows(i).Height <> drawRowEventArgs.Height Then
								MyBase.Rows(i).Height = drawRowEventArgs.Height
							End If
						Catch a_ As Exception
							If methodInfo Is O_O0OO.O0_00o.o0__o..OO.OOOO. Then
								O_O0OO.O0_00o.o0__o..OO.OOOO. = Nothing
								ooO.oOo0Oo.o.(a_, "全局表事件,BeforeDrawRow")
							Else
								Me.o.0O_O0o_..DataTable.Ooo.Oo0o0. = Nothing
								ooO.oOo0Oo.o.(a_, "表，" + Me.o.0O_O0o_..DataTable.Name + "，BeforeDrawRow")
							End If
							MessageBox.Show("BeforeDrawRow事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End Try
					End If
				Next
			End If
		End Sub

		' Token: 0x06000482 RID: 1154 RVA: 0x00019E5C File Offset: 0x0001805C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If InputLanguage.CurrentInputLanguage.Culture.LCID = 2052 AndAlso ((Me.o_O.Oo. AndAlso OO_00oOO.OSVersion() = 10 AndAlso MyBase.Row >= MyBase.Rows.Fixed) And MyBase.Col >= MyBase.Cols.Fixed) AndAlso MyBase.Editor Is Nothing AndAlso A_1.KeyCode = Keys.ProcessKey AndAlso MyBase.Cols(MyBase.Col).DataType Is GetType(String) AndAlso Operators.CompareString(MyBase.Cols(MyBase.Col).ComboList, "...", True) <> 0 Then
				Dim currentInputMethodDesc As String = TSFWrapper.GetCurrentInputMethodDesc(2052S)
				If Environment.OSVersion.Version.Build < 19042 OrElse ((currentInputMethodDesc Is Nothing OrElse currentInputMethodDesc.IndexOf("微软") < 0) AndAlso currentInputMethodDesc.IndexOf("QQ") < 0 AndAlso currentInputMethodDesc.IndexOf("搜狗") < 0) Then
					Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(MyBase.Row, MyBase.Col)
					Me.OOOo_oO_O.O.(RuntimeHelpers.GetObjectValue(A_0), rowColEventArgs, Nothing)
					If rowColEventArgs.Cancel Then
						Me.O_._. = 2
					Else
						Me.O_._. = 1
					End If
					If Not rowColEventArgs.Cancel Then
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetData(MyBase.Row, MyBase.Col))
						Dim text As String = ""
						If objectValue IsNot Nothing Then
							text = objectValue.ToString()
						End If
						MyBase.StartEditing()
						Application.DoEvents()
						If MyBase.Editor IsNot Nothing AndAlso Operators.CompareString(MyBase.Editor.Text, text, True) <> 0 Then
							text = MyBase.Editor.Text
							MyBase.Editor.Text = ""
							SendKeys.Send(text)
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000483 RID: 1155 RVA: 0x0001A038 File Offset: 0x00018238
		Private Sub <<EMPTY_NAME>>()
			Dim fixed As Integer = MyBase.Cols.Fixed
			Dim num As Integer = MyBase.Col - 1
			For i As Integer = fixed To num
				If MyBase.Cols(i).Visible Then
					MyBase.[Select](MyBase.Row, i, True)
					Return
				End If
			Next
		End Sub

		' Token: 0x06000484 RID: 1156 RVA: 0x0001A088 File Offset: 0x00018288
		Private Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False)
			Dim num As Integer = MyBase.Col + 1
			Dim num2 As Integer = MyBase.Cols.Count - 1
			Dim i As Integer = num
			While i <= num2
				If MyBase.Cols(i).Visible Then
					MyBase.[Select](MyBase.Row, i, True)
					If A_0 AndAlso MyBase.PreserveEditMode AndAlso Me.o000OOo.OO.(MyBase.Row, MyBase.Col) Then
						MyBase.StartEditing()
						Return
					End If
					Return
				Else
					i += 1
				End If
			End While
			Me.O_o.O_O__O.(A_0)
		End Sub

		' Token: 0x06000485 RID: 1157 RVA: 0x0001A108 File Offset: 0x00018308
		Private Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False)
			Dim num As Integer = MyBase.Row + 1
			Dim num2 As Integer = MyBase.Rows.Count - 1
			Dim i As Integer = num
			While i <= num2
				If MyBase.Rows(i).Visible Then
					MyBase.[Select](i, MyBase.Col, True)
					If A_0 AndAlso MyBase.PreserveEditMode AndAlso Me.o000OOo.OO.(MyBase.Row, MyBase.Col) Then
						MyBase.StartEditing()
						Return
					End If
					Exit While
				Else
					i += 1
				End If
			End While
		End Sub

		' Token: 0x06000486 RID: 1158 RVA: 0x0001A180 File Offset: 0x00018380
		Private Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False)
			Dim fixed As Integer = MyBase.Cols.Fixed
			Dim col As Integer = MyBase.Col
			For i As Integer = fixed To col
				If MyBase.Cols(i).Visible Then
					Dim num As Integer = MyBase.Row + 1
					Dim num2 As Integer = MyBase.Rows.Count - 1
					Dim j As Integer = num
					While j <= num2
						If MyBase.Rows(j).Visible Then
							MyBase.[Select](j, i, True)
							If A_0 AndAlso MyBase.PreserveEditMode AndAlso Me.o000OOo.OO.(MyBase.Row, MyBase.Col) Then
								MyBase.StartEditing()
								Return
							End If
							Return
						Else
							j += 1
						End If
					End While
					Return
				End If
			Next
		End Sub

		' Token: 0x06000487 RID: 1159 RVA: 0x0001A224 File Offset: 0x00018424
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Me.o.0O_O0o_. IsNot Nothing AndAlso A_1.Button = MouseButtons.Left Then
				Dim p As Point = System.Windows.Forms.Control.MousePosition
				Dim a_ As Boolean = System.Windows.Forms.Control.ModifierKeys = Keys.Control
				Dim a_2 As Boolean = System.Windows.Forms.Control.ModifierKeys = (Keys.Control Or Keys.Alt)
				Dim mouseRow As Integer = Me.MouseRow
				If mouseRow >= MyBase.Rows.Fixed Then
					Dim mouseCol As Integer = Me.MouseCol
					If mouseCol >= MyBase.Cols.Fixed AndAlso Me.o.0O_O0o_..HierarchyData AndAlso Operators.CompareString(MyBase.Cols(mouseCol).Name, Me.o.0O_O0o_..OO0o_o0.0oOo0o., True) = 0 AndAlso MyBase.Rows(mouseRow).DataIndex >= 0 Then
						Dim o_ As O_0 = Me.o.0O_O0o_..View
						If Not o_.O0O_0_0__.0O.(MyBase.Rows(mouseRow).DataIndex).Row.IsNull("sys_Hierarchy_Level") Then
							Dim num As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(MyBase.Rows(mouseRow).DataIndex)("sys_Hierarchy_Level"))
							p = MyBase.PointToClient(p)
							Dim left As Integer = MyBase.Cols(mouseCol).Left
							Dim num2 As Double = CDbl(left) + CDbl(Me.OO_.00oO0Oo.(Nothing)) * (CDbl(num) + 1.5)
							Dim num3 As Double = CDbl((CSng(left) + Me.OO_.00oO0Oo.(Nothing) * CSng(num)))
							If CDbl((p.X - MyBase.ScrollPosition.X)) > num3 AndAlso CDbl((p.X - MyBase.ScrollPosition.X)) < num2 Then
								Me.O_._.(mouseRow, a_2, a_)
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000488 RID: 1160 RVA: 0x0001A3D8 File Offset: 0x000185D8
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Boolean, A_2 As Boolean)
			Dim o_ As O_0 = Me.o.0O_O0o_..View
			If Not o_.O0O_0_0__.0O.(MyBase.Rows(A_0).DataIndex).Row.IsNull("sys_Hierarchy_Level") Then
				Dim num As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(MyBase.Rows(A_0).DataIndex)("sys_Hierarchy_Level"))
				Dim flag As Boolean = Me.GetUserData(A_0, MyBase.Cols.Fixed - 1) Is Nothing
				flag = Not flag
				If A_1 Then
					If flag Then
						Me.OoO._OOo__.(num + 1)
						Return
					End If
					Me.OoO._OOo__.(num)
					Return
				Else
					If A_2 Then
						For i As Integer = A_0 - 1 To 0 Step -1
							If MyBase.Rows(i).DataIndex > -1 Then
								Dim num2 As Integer
								If o_.O0O_0_0__.0O.(MyBase.Rows(i).DataIndex).Row.IsNull("sys_Hierarchy_Level") Then
									num2 = 0
								Else
									num2 = Conversions.ToInteger(o_.O0O_0_0__.0O.(MyBase.Rows(i).DataIndex)("sys_Hierarchy_Level"))
								End If
								If num2 = num Then
									A_0 = i
								ElseIf num2 < num Then
									Exit For
								End If
							End If
						Next
					End If
					Try
						Me.BeginUpdate()
						While A_0 < MyBase.Rows.Count - 1
							Dim j As Integer = A_0
							If MyBase.Rows(j).DataIndex < 0 Then
								A_0 += 1
							Else
								Dim num3 As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(MyBase.Rows(j).DataIndex)("sys_Hierarchy_Level"))
								If num3 < num Then
									Exit While
								End If
								If num3 > num Then
									A_0 += 1
								Else
									If flag Then
										Me.SetUserData(j, MyBase.Cols.Fixed - 1, Nothing)
									Else
										Me.SetUserData(j, MyBase.Cols.Fixed - 1, "1")
									End If
									j += 1
									While j < MyBase.Rows.Count
										If MyBase.Rows(j).DataIndex >= 0 AndAlso Not o_.O0O_0_0__.0O.(MyBase.Rows(j).DataIndex).Row.IsNull("sys_Hierarchy_Level") Then
											Dim num4 As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(MyBase.Rows(j).DataIndex)("sys_Hierarchy_Level"))
											If num4 <= num Then
												Exit While
											End If
											If num4 = num + 1 Then
												Me.o_.OO.(j, flag)
											End If
										End If
										j += 1
									End While
									If Not A_2 Then
										Exit While
									End If
									A_0 += 1
								End If
							End If
						End While
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						Me.EndUpdate()
					End Try
				End If
			End If
		End Sub

		' Token: 0x06000489 RID: 1161 RVA: 0x0001A6B8 File Offset: 0x000188B8
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.BeginUpdate()
			If A_0 = -1 Then
				Dim num As Integer = MyBase.Rows.Count - 1
				For i As Integer = 0 To num
					MyBase.Rows(i).Visible = True
					Me.SetUserData(i, MyBase.Cols.Fixed - 1, Nothing)
				Next
			Else
				Dim o_ As O_0 = Me.o.0O_O0o_..View
				Dim fixed As Integer = MyBase.Rows.Fixed
				Dim num2 As Integer = MyBase.Rows.Count - 1
				For j As Integer = fixed To num2
					If MyBase.Rows(j).DataIndex >= 0 AndAlso Not o_.O0O_0_0__.0O.(MyBase.Rows(j).DataIndex).Row.IsNull("sys_Hierarchy_Level") Then
						Dim num3 As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(MyBase.Rows(j).DataIndex)("sys_Hierarchy_Level"))
						If num3 < A_0 Then
							MyBase.Rows(j).Visible = True
							Me.SetUserData(j, MyBase.Cols.Fixed - 1, Nothing)
						ElseIf num3 = A_0 Then
							MyBase.Rows(j).Visible = True
							Me.SetUserData(j, MyBase.Cols.Fixed - 1, 1)
						Else
							MyBase.Rows(j).Visible = False
							Me.SetUserData(j, MyBase.Cols.Fixed - 1, 1)
						End If
					End If
				Next
			End If
			Me.EndUpdate()
		End Sub

		' Token: 0x0600048A RID: 1162 RVA: 0x0001A858 File Offset: 0x00018A58
		Private Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Boolean)
			MyBase.Rows(A_0).Visible = A_1
			Dim o_ As O_0 = Me.o.0O_O0o_..View
			Dim dataIndex As Integer = MyBase.Rows(A_0).DataIndex
			Dim num As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(dataIndex)("sys_Hierarchy_Level"))
			If Me.GetUserData(A_0, MyBase.Cols.Fixed - 1) Is Nothing Then
				A_0 += 1
				While A_0 < MyBase.Rows.Count
					Dim dataIndex2 As Integer = MyBase.Rows(A_0).DataIndex
					If dataIndex < 0 Then
						A_0 += 1
					Else
						If dataIndex2 >= 0 AndAlso Not o_.O0O_0_0__.0O.(dataIndex2).Row.IsNull("sys_Hierarchy_Level") Then
							Dim num2 As Integer = Conversions.ToInteger(o_.O0O_0_0__.0O.(dataIndex2)("sys_Hierarchy_Level"))
							If num2 <= num Then
								Exit While
							End If
							If num2 = num + 1 Then
								Me.o_.OO.(A_0, A_1)
							End If
						End If
						A_0 += 1
					End If
				End While
			End If
		End Sub

		' Token: 0x0600048B RID: 1163 RVA: 0x0001A944 File Offset: 0x00018B44
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.O_._.
		End Function

		' Token: 0x0600048C RID: 1164 RVA: 0x0001A94C File Offset: 0x00018B4C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.O.O0_0.
			Dim o_._. As Timer = Me.O_._.
			If o_._. IsNot Nothing Then
				RemoveHandler o_._..Tick, value
			End If
			Me.O_._. = A_0
			o_._. = Me.O_._.
			If o_._. IsNot Nothing Then
				AddHandler o_._..Tick, value
			End If
		End Sub

		' Token: 0x0600048D RID: 1165 RVA: 0x0001A98F File Offset: 0x00018B8F
		Private Overloads Function <<EMPTY_NAME>>() As Timer
			If Me.OO.o_o00o.() Is Nothing Then
				Me.OO0o_o_OO.O_O.(New Timer())
			End If
			Return Me.OO.o_o00o.()
		End Function

		' Token: 0x0600048E RID: 1166 RVA: 0x0001A9AC File Offset: 0x00018BAC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO_.00oO0Oo.().Enabled = False
			If Me.Focused Then
				Dim mouseRow As Integer = Me.MouseRow
				Dim mouseCol As Integer = Me.MouseCol
				If mouseRow <= MyBase.Rows.Count - 1 AndAlso mouseRow >= MyBase.Rows.Fixed AndAlso mouseCol <= MyBase.Cols.Count - 1 AndAlso mouseCol >= MyBase.Cols.Fixed Then
					Dim row As Row = MyBase.Rows(mouseRow)
					Dim column As Column = MyBase.Cols(mouseCol)
					If row.DataIndex >= 0 AndAlso (Me.o.0O_O0o_..DataTable.oo.o0_oO__o. IsNot Nothing OrElse O_O0OO.O0_00o.o0__o..OOO0_.o__OO. IsNot Nothing) AndAlso MyBase.Editor Is Nothing Then
						Me.OOOOOO.o0Oo0. = True
						Me.O.o__OO0oO_0. = mouseRow
						Me.OOOOOO.o0Oo0. = mouseCol
						Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.oo.o0_oO__o.
						Dim mouseHoverCellEventArgs As MouseHoverCellEventArgs = New MouseHoverCellEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), Me.o.0O_O0o_..Cols(column.Name), Nothing, True)
						If methodInfo IsNot Nothing Then
							Try
								methodInfo.Invoke(Nothing, New Object() { mouseHoverCellEventArgs })
							Catch a_ As Exception
								ooO.oOo0Oo.o.(a_, "表，" + MyBase.Name + "，MouseHoverCell")
							End Try
						End If
						If Me.o.0O_O0o_..foxGrid.FindForm() IsNot Nothing AndAlso Me.o.0O_O0o_..DataTable.GlobalHandler.MouseHoverCell Then
							methodInfo = O_O0OO.O0_00o.o0__o..OOO0_.o__OO.
							If methodInfo IsNot Nothing Then
								Try
									methodInfo.Invoke(Nothing, New Object() { mouseHoverCellEventArgs })
								Catch a_2 As Exception
									ooO.oOo0Oo.o.(a_2, "全局事件, MouseHoverCell")
								End Try
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600048F RID: 1167 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0O_O0o_..DataTable.oo.o0_oO__o. IsNot Nothing OrElse O_O0OO.O0_00o.o0__o..OOO0_.o__OO. IsNot Nothing Then
				If Me.OOOOOO.o0Oo0. Then
					Me.OOOOOO.o0Oo0. = False
					Dim o.o__OO0oO_0. As Integer = Me.O.o__OO0oO_0.
					Dim oooooo.o0Oo0. As Integer = Me.OOOOOO.o0Oo0.
					If o.o__OO0oO_0. > MyBase.Rows.Count - 1 OrElse o.o__OO0oO_0. < MyBase.Rows.Fixed OrElse o.o__OO0oO_0. > MyBase.Cols.Count - 1 OrElse oooooo.o0Oo0. < MyBase.Cols.Fixed Then
						Return
					End If
					Dim row As Row = MyBase.Rows(o.o__OO0oO_0.)
					Dim column As Column = MyBase.Cols(oooooo.o0Oo0.)
					If row.DataIndex < 0 Then
						Return
					End If
					Dim methodInfo As MethodInfo = Me.o.0O_O0o_..DataTable.oo.o0_oO__o.
					Dim mouseHoverCellEventArgs As MouseHoverCellEventArgs = New MouseHoverCellEventArgs(Me.o.0O_O0o_., New Row(Me.o.0O_O0o_., Me.o.0O_O0o_..View.O0O_0_0__.0O.(row.DataIndex)), Me.o.0O_O0o_..Cols(column.Name), Nothing, False)
					If methodInfo IsNot Nothing Then
						Try
							methodInfo.Invoke(Nothing, New Object() { mouseHoverCellEventArgs })
						Catch a_ As Exception
							ooO.oOo0Oo.o.(a_, "表，" + MyBase.Name + "，MouseHoverCell")
						End Try
					End If
					If Me.o.0O_O0o_..foxGrid.FindForm() Is Nothing OrElse Not Me.o.0O_O0o_..DataTable.GlobalHandler.MouseHoverCell Then
						Return
					End If
					methodInfo = O_O0OO.O0_00o.o0__o..OOO0_.o__OO.
					If methodInfo Is Nothing Then
						Return
					End If
					Try
						methodInfo.Invoke(Nothing, New Object() { mouseHoverCellEventArgs })
						Return
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "全局事件, MouseHoverCell")
						Return
					End Try
				End If
				Me.OO_.00oO0Oo.().Enabled = False
				Me.OO_.00oO0Oo.().Interval = 500
				Me.OO_.00oO0Oo.().Enabled = True
			End If
		End Sub

		' Token: 0x06000490 RID: 1168 RVA: 0x0001ADBC File Offset: 0x00018FBC
		Protected Overrides Sub Dispose(disposing As Boolean)
			If Me.OO.o_o00o.() IsNot Nothing Then
				Me.OO.o_o00o.().Enabled = False
				Me.OO.o_o00o.().Dispose()
				Me.OO0o_o_OO.O_O.(Nothing)
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000491 RID: 1169 RVA: 0x0001ADEC File Offset: 0x00018FEC
		Public Overloads Function <<EMPTY_NAME>>(A_0 As OwnerDrawCellEventArgs) As Single
			If Me.O_._. <= 0F Then
				If A_0 Is Nothing Then
					Return 12.342F
				End If
				Me.O_._. = (A_0.Graphics.MeasureString("w　w", A_0.Style.Font).Width - A_0.Graphics.MeasureString("ww", A_0.Style.Font).Width) * A_0.Graphics.DpiX / 96F
			End If
			Return Me.O_._.
		End Function

		' Token: 0x040000E0 RID: 224
		Friend <<EMPTY_NAME>> As Foxtable.Table

		' Token: 0x040000E1 RID: 225
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x040000E2 RID: 226
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x040000E3 RID: 227
		Private <<EMPTY_NAME>> As LookAndFeelProperty

		' Token: 0x040000E4 RID: 228
		Private <<EMPTY_NAME>> As Dictionary(Of Column, Integer)

		' Token: 0x040000E5 RID: 229
		Private <<EMPTY_NAME>> As o0o0o00

		' Token: 0x040000E6 RID: 230
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000E7 RID: 231
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000E8 RID: 232
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040000E9 RID: 233
		Private Shared <<EMPTY_NAME>> As Integer

		' Token: 0x040000EA RID: 234
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x040000EB RID: 235
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000EC RID: 236
		Private Shared <<EMPTY_NAME>> As Image = a.oO000_0.O_0.().ToBitmap()

		' Token: 0x040000ED RID: 237
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040000EE RID: 238
		Friend <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040000EF RID: 239
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040000F0 RID: 240
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x040000F1 RID: 241
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040000F2 RID: 242
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000F3 RID: 243
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000F4 RID: 244
		Private <<EMPTY_NAME>> As Single
	End Class
End Namespace
