Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200016F RID: 367
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class OO_
		' Token: 0x06001123 RID: 4387 RVA: 0x0006B159 File Offset: 0x00069359
		Friend Sub New(A_0 As String, A_1 As Foxtable.WinForm.Form)
			Me.o.__o_O. = New Dictionary(Of String, ToolStrip)()
			Me.o.__o_O. = New Stack(Of OO_.Oo__000)()
			Me.O_oOoo._o_oo. = "(default)"
			Me.o.__o_O. = A_0
			Me.o.__o_O. = A_1
		End Sub

		' Token: 0x06001124 RID: 4388 RVA: 0x0006B190 File Offset: 0x00069390
		Friend Sub <<EMPTY_NAME>>()
			If Me.o.__o_O. IsNot Nothing AndAlso Operators.CompareString(Me.o.__o_O..Trim(), "", True) <> 0 Then
				Dim array As String() = Me.o.__o_O..Split(New Char() { vbFormFeed })
				Dim toolStripItemCollection As ToolStripItemCollection = Nothing
				Dim toolStripItem As ToolStripItem = Nothing
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim text As String = array(i)
					If Operators.CompareString(text, "Inner", True) = 0 Then
						If toolStripItem IsNot Nothing Then
							Me.o.__o_O..Push(New OO_.Oo__000(toolStripItem, toolStripItemCollection))
							toolStripItemCollection = CType(toolStripItem, ToolStripDropDownItem).DropDownItems
						End If
					ElseIf Operators.CompareString(text, "Outer", True) = 0 Then
						If Me.o.__o_O..Count > 0 Then
							Dim oo__ As OO_.Oo__000 = Me.o.__o_O..Pop()
							toolStripItem = oo__.o.__o_O.
							toolStripItemCollection = oo__.o.__o_O.
						End If
					Else
						Dim obj As Object
						If text.StartsWith(vbTab) Then
							obj = New FormMenuProperty()
						Else
							obj = New FormMenuItemProperty()
						End If
						text = text.Trim(New Char() { vbTab })
						o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(obj), text, vbTab)
						If TypeOf obj Is FormMenuProperty Then
							Dim formMenuProperty As FormMenuProperty = CType(obj, FormMenuProperty)
							Dim toolStrip As ToolStrip = Nothing
							Select Case formMenuProperty.Type
								Case StripTypeEnum2.主菜单
									toolStrip = New MenuStrip()
									toolStrip.Dock = DockStyle.Top
								Case StripTypeEnum2.工具栏
									toolStrip = New ToolStrip()
								Case StripTypeEnum2.状态栏
									toolStrip = New StatusStrip()
									toolStrip.Dock = DockStyle.Bottom
									toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
									CType(toolStrip, StatusStrip).SizingGrip = True
								Case StripTypeEnum2.快捷菜单
									toolStrip = New ContextMenuStrip()
							End Select
							If Me.o.__o_O. IsNot Nothing Then
								Me.O_oOoo._o_oo. = Me.o.__o_O..MenuTheme
							End If
							If Operators.CompareString(formMenuProperty.Theme, "(none)", True) = 0 OrElse (Operators.CompareString(formMenuProperty.Theme, "(default)", True) = 0 AndAlso Operators.CompareString(Me.O_oOoo._o_oo., "(none)", True) = 0) Then
								toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode
								toolStrip.Renderer = O_O0OO.o0_OO.000.()
							ElseIf Operators.CompareString(formMenuProperty.Theme, "(default)", True) <> 0 Then
								Main.OO_O.o..Oo.oOo_o0Oo0.(formMenuProperty.Theme, New Object() { toolStrip })
							Else
								Main.OO_O.o..Oo.oOo_o0Oo0.(Me.O_oOoo._o_oo., New Object() { toolStrip })
							End If
							toolStrip.Name = formMenuProperty.Name
							toolStrip.ImageScalingSize = formMenuProperty.ImageSize
							toolStrip.Enabled = formMenuProperty.Enabeld
							toolStrip.Visible = formMenuProperty.Visible
							If formMenuProperty.Type = StripTypeEnum2.工具栏 Then
								toolStrip.Dock = formMenuProperty.Dock
							End If
							toolStripItemCollection = toolStrip.Items
							toolStripItem = Nothing
							Me.o.__o_O..Add(toolStrip.Name, toolStrip)
							If Me.o.__o_O. IsNot Nothing Then
								AddHandler toolStrip.ItemClicked, AddressOf Me.o.__o_O..o_O._o_0_o.
							End If
						Else
							Dim formMenuItemProperty As FormMenuItemProperty = CType(obj, FormMenuItemProperty)
							Dim toolStripItem2 As ToolStripItem = Nothing
							Select Case formMenuItemProperty.Type
								Case StripItemTypeEnum.MenuItem
									toolStripItem2 = New ToolStripMenuItem()
									Dim toolStripMenuItem As ToolStripMenuItem = CType(toolStripItem2, ToolStripMenuItem)
									toolStripMenuItem.Checked = formMenuItemProperty.Checked
									toolStripMenuItem.ShortcutKeys = formMenuItemProperty.ShortcutKeys
									If Me.o.__o_O. IsNot Nothing Then
										AddHandler CType(toolStripMenuItem.DropDown, ToolStripDropDownMenu).ItemClicked, AddressOf Me.o.__o_O..o_O._o_0_o.
									End If
								Case StripItemTypeEnum.Button
									toolStripItem2 = New ToolStripButton()
									CType(toolStripItem2, ToolStripButton).Checked = formMenuItemProperty.Checked
								Case StripItemTypeEnum.Label
									toolStripItem2 = New ToolStripLabel()
								Case StripItemTypeEnum.SplitButton
									toolStripItem2 = New ToolStripSplitButton()
									If Me.o.__o_O. IsNot Nothing Then
										AddHandler CType(CType(toolStripItem2, ToolStripSplitButton).DropDown, ToolStripDropDownMenu).ItemClicked, AddressOf Me.o.__o_O..o_O._o_0_o.
										CType(CType(toolStripItem2, ToolStripSplitButton).DropDown, ToolStripDropDownMenu).Name = formMenuItemProperty.Name
									End If
								Case StripItemTypeEnum.TextBox
									toolStripItem2 = New ToolStripTextBox()
								Case StripItemTypeEnum.ComboBox
									toolStripItem2 = New ToolStripComboBox()
									If Operators.CompareString(formMenuItemProperty.ComboList, "", True) > 0 Then
										CType(toolStripItem2, ToolStripComboBox).Items.AddRange(formMenuItemProperty.ComboList.Split(New Char() { "|"c }))
									End If
								Case StripItemTypeEnum.Separator
									toolStripItem2 = New ToolStripSeparator()
							End Select
							toolStripItem2.Name = formMenuItemProperty.Name
							toolStripItem2.Alignment = formMenuItemProperty.Alignment
							toolStripItem2.Enabled = formMenuItemProperty.Enabeld
							toolStripItem2.Visible = formMenuItemProperty.Visible
							If formMenuItemProperty.Type <> StripItemTypeEnum.Separator Then
								toolStripItem2.Text = formMenuItemProperty.Text
								toolStripItem2.ToolTipText = formMenuItemProperty.ToolTipText
								If Operators.CompareString(formMenuItemProperty.ImageFile, "", True) > 0 Then
									toolStripItem2.Image = OO_00oOO.GetImage(formMenuItemProperty.ImageFile)
								End If
							End If
							If formMenuItemProperty.Type = StripItemTypeEnum.Button OrElse formMenuItemProperty.Type = StripItemTypeEnum.SplitButton Then
								If Not formMenuItemProperty.DisplayText Then
									toolStripItem2.DisplayStyle = ToolStripItemDisplayStyle.Image
								Else
									toolStripItem2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
								End If
								If formMenuItemProperty.TextPosition = TextPositionEnum.Right Then
									toolStripItem2.TextImageRelation = TextImageRelation.ImageBeforeText
								Else
									toolStripItem2.TextImageRelation = TextImageRelation.ImageAboveText
								End If
							End If
							If Me.o.__o_O. IsNot Nothing Then
								AddHandler toolStripItem2.MouseEnter, AddressOf Me.o.__o_O..O0O_o.OOOO0o.
								AddHandler toolStripItem2.MouseLeave, AddressOf Me.o.__o_O..Oo_o.OO.
								AddHandler toolStripItem2.MouseHover, AddressOf Me.o.__o_O..o.0__0_0o.
							End If
							toolStripItemCollection.Add(toolStripItem2)
							toolStripItem = toolStripItem2
						End If
					End If
				Next
			End If
		End Sub

		' Token: 0x0400067D RID: 1661
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400067E RID: 1662
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x0400067F RID: 1663
		Friend <<EMPTY_NAME>> As Dictionary(Of String, ToolStrip)

		' Token: 0x04000680 RID: 1664
		Private <<EMPTY_NAME>> As Stack(Of OO_.Oo__000)

		' Token: 0x04000681 RID: 1665
		Friend <<EMPTY_NAME>> As String

		' Token: 0x02000170 RID: 368
		Friend Class Oo__000
			' Token: 0x06001125 RID: 4389 RVA: 0x0006B727 File Offset: 0x00069927
			Friend Sub New(A_0 As ToolStripItem, A_1 As ToolStripItemCollection)
				Me.o.__o_O. = A_0
				Me.o.__o_O. = A_1
			End Sub

			' Token: 0x04000682 RID: 1666
			Friend <<EMPTY_NAME>> As ToolStripItemCollection

			' Token: 0x04000683 RID: 1667
			Friend <<EMPTY_NAME>> As ToolStripItem
		End Class
	End Class
End Namespace
