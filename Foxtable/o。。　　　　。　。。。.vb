Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000386 RID: 902
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002
		Inherits Form

		' Token: 0x060039EE RID: 14830 RVA: 0x00190FD4 File Offset: 0x0018F1D4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOoO_OOo._. IsNot Nothing Then
					Me.oOoO_OOo._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060039EF RID: 14831 RVA: 0x00191014 File Offset: 0x0018F214
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002))
			Me.o_O_0O.0_.(New C1FlexGrid())
			Me.O0._o0oO0O.(New C1Button())
			Me.o0___O0O00.0_.(New C1Button())
			Me.o_.0O_O.(New C1Button())
			Me.O0o00o.OO.(New C1Button())
			Me.Oo000o.o.(New C1Button())
			Me.ooo000o0.o.(New C1Button())
			Me.Oo0OOO.O_O.(New C1Button())
			Me.o_OoO.o_OOo.(New C1Button())
			Me.O0._o0oO0O.().BeginInit()
			Me.O_o0Oo._oOoOO0.().BeginInit()
			Me.O0__0._0_0.().BeginInit()
			Me.oo_._OoO.().BeginInit()
			Me.O0._o0oO0O.().BeginInit()
			Me.O_Oo._0Oo_oo.().BeginInit()
			Me.O_O.OoO.().BeginInit()
			Me.o0___O0O00.0_.().BeginInit()
			Me.oO_oo.O__o.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0._o0oO0O.().AllowDragging = 0
			Me.O0._o0oO0O.().AllowEditing = False
			Me.O0._o0oO0O.().AllowSorting = 0
			Me.O0._o0oO0O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O0._o0oO0O.().ColumnInfo = "5,0,0,30,0,100,Columns:0{Width:139;Caption:""列名"";Style:""ImageAlign:RightCenter;"";}" & vbTab & "1{Width:74;Caption:""类型"";}" & vbTab & "2{Width:34;Caption:""长度"";}" & vbTab & "3{Width:261;Caption:""标题"";}" & vbTab & "4{Width:85;Caption:""表达式"";}" & vbTab
			Me.O0._o0oO0O.().DrawMode = 1
			Me.O0._o0oO0O.().ExtendLastCol = True
			Me.O0._o0oO0O.().Font = New Font("宋体", 9F)
			Me.O0._o0oO0O.().Location = New Point(11, 12)
			Me.O0._o0oO0O.().Name = "C1FlexGrid1"
			Me.O0._o0oO0O.().Rows.Count = 1
			Me.O0._o0oO0O.().Rows.DefaultSize = 20
			Me.O0._o0oO0O.().SelectionMode = 3
			Me.O0._o0oO0O.().Size = New Size(793, 433)
			Me.O0._o0oO0O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.O0._o0oO0O.().TabIndex = 0
			Me.O_o0Oo._oOoOO0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_o0Oo._oOoOO0.().Location = New Point(12, 451)
			Me.O_o0Oo._oOoOO0.().Name = "btnAdd"
			Me.O_o0Oo._oOoOO0.().Size = New Size(75, 23)
			Me.O_o0Oo._oOoOO0.().TabIndex = 1
			Me.O_o0Oo._oOoOO0.().Text = "增加数据列"
			Me.O_o0Oo._oOoOO0.().UseVisualStyleBackColor = True
			Me.O0__0._0_0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O0__0._0_0.().Location = New Point(184, 451)
			Me.O0__0._0_0.().Name = "btnDelete"
			Me.O0__0._0_0.().Size = New Size(75, 23)
			Me.O0__0._0_0.().TabIndex = 5
			Me.O0__0._0_0.().Text = "删除列"
			Me.O0__0._0_0.().UseVisualStyleBackColor = True
			Me.oo_._OoO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oo_._OoO.().Location = New Point(265, 451)
			Me.oo_._OoO.().Name = "btnRename"
			Me.oo_._OoO.().Size = New Size(75, 23)
			Me.oo_._OoO.().TabIndex = 6
			Me.oo_._OoO.().Text = "更改列"
			Me.oo_._OoO.().UseVisualStyleBackColor = True
			Me.O0._o0oO0O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O0._o0oO0O.().Location = New Point(93, 451)
			Me.O0._o0oO0O.().Name = "Button1"
			Me.O0._o0oO0O.().Size = New Size(85, 23)
			Me.O0._o0oO0O.().TabIndex = 2
			Me.O0._o0oO0O.().Text = "增加表达式列"
			Me.O0._o0oO0O.().UseVisualStyleBackColor = True
			Me.O_Oo._0Oo_oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_Oo._0Oo_oo.().Location = New Point(346, 451)
			Me.O_Oo._0Oo_oo.().Name = "Button2"
			Me.O_Oo._0Oo_oo.().Size = New Size(75, 23)
			Me.O_Oo._0Oo_oo.().TabIndex = 3
			Me.O_Oo._0Oo_oo.().Text = "修改表达式"
			Me.O_Oo._0Oo_oo.().UseVisualStyleBackColor = True
			Me.O_O.OoO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_O.OoO.().Location = New Point(427, 451)
			Me.O_O.OoO.().Name = "Button3"
			Me.O_O.OoO.().Size = New Size(75, 23)
			Me.O_O.OoO.().TabIndex = 7
			Me.O_O.OoO.().Text = "上移"
			Me.O_O.OoO.().UseVisualStyleBackColor = True
			Me.o0___O0O00.0_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o0___O0O00.0_.().Location = New Point(508, 451)
			Me.o0___O0O00.0_.().Name = "Button4"
			Me.o0___O0O00.0_.().Size = New Size(75, 23)
			Me.o0___O0O00.0_.().TabIndex = 8
			Me.o0___O0O00.0_.().Text = "下移"
			Me.o0___O0O00.0_.().UseVisualStyleBackColor = True
			Me.oO_oo.O__o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oO_oo.O__o.().Location = New Point(724, 451)
			Me.oO_oo.O__o.().Name = "btnPrint"
			Me.oO_oo.O__o.().Size = New Size(75, 23)
			Me.oO_oo.O__o.().TabIndex = 11
			Me.oO_oo.O__o.().Text = "打印"
			Me.oO_oo.O__o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(814, 480)
			MyBase.Controls.Add(Me.oO_oo.O__o.())
			MyBase.Controls.Add(Me.o0___O0O00.0_.())
			MyBase.Controls.Add(Me.O_O.OoO.())
			MyBase.Controls.Add(Me.O_Oo._0Oo_oo.())
			MyBase.Controls.Add(Me.O0._o0oO0O.())
			MyBase.Controls.Add(Me.oo_._OoO.())
			MyBase.Controls.Add(Me.O0__0._0_0.())
			MyBase.Controls.Add(Me.O_o0Oo._oOoOO0.())
			MyBase.Controls.Add(Me.O0._o0oO0O.())
			MyBase.MinimizeBox = False
			MyBase.Name = "o.0O0.OO."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "查看表结构"
			Me.O0._o0oO0O.().EndInit()
			Me.O_o0Oo._oOoOO0.().EndInit()
			Me.O0__0._0_0.().EndInit()
			Me.oo_._OoO.().EndInit()
			Me.O0._o0oO0O.().EndInit()
			Me.O_Oo._0Oo_oo.().EndInit()
			Me.O_O.OoO.().EndInit()
			Me.o0___O0O00.0_.().EndInit()
			Me.oO_oo.O__o.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060039F0 RID: 14832 RVA: 0x001916F1 File Offset: 0x0018F8F1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.oOoO_OOo._.
		End Function

		' Token: 0x060039F1 RID: 14833 RVA: 0x001916FC File Offset: 0x0018F8FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim value As EventHandler = AddressOf Me.oooo.O.
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.o_00oOO.O__000.
			Dim c1FlexGrid As C1FlexGrid = Me.oOoO_OOo._.
			If c1FlexGrid IsNot Nothing Then
				RemoveHandler c1FlexGrid.DoubleClick, value
				c1FlexGrid.OwnerDrawCell -= ownerDrawCellEventHandler
			End If
			Me.oOoO_OOo._. = A_0
			c1FlexGrid = Me.oOoO_OOo._.
			If c1FlexGrid IsNot Nothing Then
				AddHandler c1FlexGrid.DoubleClick, value
				c1FlexGrid.OwnerDrawCell += ownerDrawCellEventHandler
			End If
		End Sub

		' Token: 0x060039F2 RID: 14834 RVA: 0x0019175A File Offset: 0x0018F95A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_O_0O.0_.
		End Function

		' Token: 0x060039F3 RID: 14835 RVA: 0x00191764 File Offset: 0x0018F964
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOOo__00__._0.
			Dim c1Button As C1Button = Me.o_O_0O.0_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_O_0O.0_. = A_0
			c1Button = Me.o_O_0O.0_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060039F4 RID: 14836 RVA: 0x001917A7 File Offset: 0x0018F9A7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo000o.o.
		End Function

		' Token: 0x060039F5 RID: 14837 RVA: 0x001917B0 File Offset: 0x0018F9B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOo0OO.OoO_O_.
			Dim oo000o.o. As C1Button = Me.Oo000o.o.
			If oo000o.o. IsNot Nothing Then
				RemoveHandler oo000o.o..Click, value
			End If
			Me.Oo000o.o. = A_0
			oo000o.o. = Me.Oo000o.o.
			If oo000o.o. IsNot Nothing Then
				AddHandler oo000o.o..Click, value
			End If
		End Sub

		' Token: 0x060039F6 RID: 14838 RVA: 0x001917F3 File Offset: 0x0018F9F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooo_.oo.
		End Function

		' Token: 0x060039F7 RID: 14839 RVA: 0x001917FC File Offset: 0x0018F9FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0o_o_.O_.
			Dim c1Button As C1Button = Me.ooo_.oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooo_.oo. = A_0
			c1Button = Me.ooo_.oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060039F8 RID: 14840 RVA: 0x0019183F File Offset: 0x0018FA3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00_o00.0O_0O_.
		End Function

		' Token: 0x060039F9 RID: 14841 RVA: 0x00191848 File Offset: 0x0018FA48
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_OOO0oO_.O.
			Dim o00_o00.0O_0O_. As C1Button = Me.O00_o00.0O_0O_.
			If o00_o00.0O_0O_. IsNot Nothing Then
				RemoveHandler o00_o00.0O_0O_..Click, value
			End If
			Me.O00_o00.0O_0O_. = A_0
			o00_o00.0O_0O_. = Me.O00_o00.0O_0O_.
			If o00_o00.0O_0O_. IsNot Nothing Then
				AddHandler o00_o00.0O_0O_..Click, value
			End If
		End Sub

		' Token: 0x060039FA RID: 14842 RVA: 0x0019188B File Offset: 0x0018FA8B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_00OOOoo0.0o.
		End Function

		' Token: 0x060039FB RID: 14843 RVA: 0x00191894 File Offset: 0x0018FA94
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.OooOo.
			Dim oo_00OOOoo0.0o. As C1Button = Me.Oo_00OOOoo0.0o.
			If oo_00OOOoo0.0o. IsNot Nothing Then
				RemoveHandler oo_00OOOoo0.0o..Click, value
			End If
			Me.Oo_00OOOoo0.0o. = A_0
			oo_00OOOoo0.0o. = Me.Oo_00OOOoo0.0o.
			If oo_00OOOoo0.0o. IsNot Nothing Then
				AddHandler oo_00OOOoo0.0o..Click, value
			End If
		End Sub

		' Token: 0x060039FC RID: 14844 RVA: 0x001918D7 File Offset: 0x0018FAD7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.o_oO0o___.
		End Function

		' Token: 0x060039FD RID: 14845 RVA: 0x001918E0 File Offset: 0x0018FAE0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_._ooOo_o.
			Dim o.o_oO0o___. As C1Button = Me.O.o_oO0o___.
			If o.o_oO0o___. IsNot Nothing Then
				RemoveHandler o.o_oO0o___..Click, value
			End If
			Me.O.o_oO0o___. = A_0
			o.o_oO0o___. = Me.O.o_oO0o___.
			If o.o_oO0o___. IsNot Nothing Then
				AddHandler o.o_oO0o___..Click, value
			End If
		End Sub

		' Token: 0x060039FE RID: 14846 RVA: 0x00191923 File Offset: 0x0018FB23
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0O.0oO0.
		End Function

		' Token: 0x060039FF RID: 14847 RVA: 0x0019192C File Offset: 0x0018FB2C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_00__o.OO__.
			Dim o0O.0oO0. As C1Button = Me.O0O.0oO0.
			If o0O.0oO0. IsNot Nothing Then
				RemoveHandler o0O.0oO0..Click, value
			End If
			Me.O0O.0oO0. = A_0
			o0O.0oO0. = Me.O0O.0oO0.
			If o0O.0oO0. IsNot Nothing Then
				AddHandler o0O.0oO0..Click, value
			End If
		End Sub

		' Token: 0x06003A00 RID: 14848 RVA: 0x0019196F File Offset: 0x0018FB6F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0o00o.OO.
		End Function

		' Token: 0x06003A01 RID: 14849 RVA: 0x00191978 File Offset: 0x0018FB78
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO00O.0O0O0o.
			Dim o0o00o.OO. As C1Button = Me.O0o00o.OO.
			If o0o00o.OO. IsNot Nothing Then
				RemoveHandler o0o00o.OO..Click, value
			End If
			Me.O0o00o.OO. = A_0
			o0o00o.OO. = Me.O0o00o.OO.
			If o0o00o.OO. IsNot Nothing Then
				AddHandler o0o00o.OO..Click, value
			End If
		End Sub

		' Token: 0x06003A02 RID: 14850 RVA: 0x001919BC File Offset: 0x0018FBBC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oo.0O__.
			AddHandler MyBase.FormClosed, AddressOf Me.o_00oOO.O__000.
			Me.O_Oo._0Oo_oo.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O0._o0oO0O.().Styles.SelectedColumnHeader.Clear()
		End Sub

		' Token: 0x06003A03 RID: 14851 RVA: 0x00191A23 File Offset: 0x0018FC23
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0._o0oO0O.().Rows.DefaultSize = 25
			Me.O0._o0oO0O.()
		End Sub

		' Token: 0x06003A04 RID: 14852 RVA: 0x00191A40 File Offset: 0x0018FC40
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If OO_00oOO.CurrentTable Is Nothing Then
					GoTo IL_4A0
				End If
				IL_13:
				num2 = 4
				Dim right As String = ""
				IL_1B:
				num2 = 5
				If Me.O0._o0oO0O.().Row <= 0 Then
					GoTo IL_45
				End If
				IL_2B:
				num2 = 6
				right = Me.O0._o0oO0O.().GetDataDisplay(Me.O0._o0oO0O.().Row, 0)
				IL_45:
				num2 = 7
				Me.O0._o0oO0O.().Rows.Count = 1
				IL_58:
				num2 = 8
				Dim enumerator As IEnumerator(Of Col) = OO_00oOO.CurrentTable.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_79:
					num2 = 9
					Me.O0._o0oO0O.().Rows.Count = Me.O0._o0oO0O.().Rows.Count + 1
					IL_9E:
					num2 = 10
					Dim c1FlexGrid As C1FlexGrid = Me.O0._o0oO0O.()
					IL_A9:
					num2 = 11
					c1FlexGrid.BeginUpdate()
					IL_B3:
					num2 = 12
					c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 0, col.Name)
					IL_D4:
					num2 = 13
					If col.DataCol.BaseColumn.DataType Is GetType(Byte) Then
						IL_F4:
						num2 = 14
						c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "微整数")
					Else
						IL_118:
						num2 = 16
						If col.DataCol.BaseColumn.DataType Is GetType(Short) Then
							IL_138:
							num2 = 17
							c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "短整数")
						Else
							IL_15C:
							num2 = 19
							If col.DataCol.BaseColumn.DataType Is GetType(Integer) Then
								IL_17C:
								num2 = 20
								c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "整数")
							Else
								IL_1A0:
								num2 = 22
								If col.DataCol.BaseColumn.DataType Is GetType(Long) Then
									IL_1C0:
									num2 = 23
									c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "长整数")
								Else
									IL_1E4:
									num2 = 25
									If col.DataCol.BaseColumn.DataType Is GetType(Single) Then
										IL_204:
										num2 = 26
										c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "单精度小数")
									Else
										IL_228:
										num2 = 28
										If col.DataCol.BaseColumn.DataType Is GetType(Double) Then
											IL_248:
											num2 = 29
											c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "双精度小数")
										Else
											IL_26C:
											num2 = 31
											If col.DataCol.BaseColumn.DataType Is GetType(Decimal) Then
												IL_28C:
												num2 = 32
												c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "高精度小数")
											Else
												IL_2B0:
												num2 = 34
												If col.DataCol.BaseColumn.DataType Is GetType(Boolean) Then
													IL_2D0:
													num2 = 35
													c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "逻辑型")
												Else
													IL_2F4:
													num2 = 37
													If col.DataCol.BaseColumn.DataType Is GetType(DateTime) Then
														IL_314:
														num2 = 38
														c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "日期时间型")
													Else
														IL_338:
														num2 = 40
														If col.DataCol.BaseColumn.DataType Is GetType(String) Then
															IL_35B:
															num2 = 41
															If col.DataCol.BaseColumn.MaxLength = -1 OrElse col.DataCol.BaseColumn.MaxLength > 255 Then
																IL_38A:
																num2 = 42
																c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "备注型")
															Else
																IL_3AB:
																num2 = 44
																c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "字符型")
																IL_3CA:
																num2 = 45
																c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 2, col.DataCol.BaseColumn.MaxLength)
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
					IL_3FA:
					num2 = 46
					c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 3, col.DataCol.Caption)
					IL_420:
					num2 = 47
					c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, col.DataCol.BaseColumn.Expression)
					IL_44B:
					num2 = 48
					If Operators.CompareString(col.Name, right, True) = 0 Then
						IL_45E:
						num2 = 49
						c1FlexGrid.Row = c1FlexGrid.Rows.Count - 1
					End If
					IL_476:
					num2 = 50
					c1FlexGrid.EndUpdate()
					IL_480:
					c1FlexGrid = Nothing
					IL_483:
					num2 = 52
				End While
				IL_492:
				num2 = 53
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_4A0:
				GoTo IL_5CA
				IL_4A5:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_58B:
				GoTo IL_5BF
				IL_58D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_59D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_58D
			End Try
			IL_5BF:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5CA:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003A05 RID: 14853 RVA: 0x0019203C File Offset: 0x0019023C
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If OO_00oOO.CurrentTable Is Nothing Then
				result = False
			ElseIf Me.O0._o0oO0O.().Row > 0 Then
				Dim dataDisplay As String = Me.O0._o0oO0O.().GetDataDisplay(Me.O0._o0oO0O.().Row, 0)
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				If o_oOooO_O.Cols.Contains(dataDisplay) Then
					If Not o_oOooO_O.Cols(dataDisplay).Visible Then
						o_oOooO_O.Cols(dataDisplay).Visible = True
					End If
					o_oOooO_O.[Select](o_oOooO_O.Row, o_oOooO_O.Cols(dataDisplay).Index, True)
					result = True
				Else
					result = False
				End If
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x06003A06 RID: 14854 RVA: 0x001920E8 File Offset: 0x001902E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim count As Integer = OO_00oOO.CurrentTable.DataTable.DataCols.Count
			Column.AddDataColumn()
			If count <> OO_00oOO.CurrentTable.DataTable.DataCols.Count Then
				Me.O0._o0oO0O.()
				Me.O0._o0oO0O.().Row = Me.O0._o0oO0O.().Rows.Count - 1
				Me.O0._o0oO0O.().ShowCell(Me.O0._o0oO0O.().Row, 1)
			End If
		End Sub

		' Token: 0x06003A07 RID: 14855 RVA: 0x00192160 File Offset: 0x00190360
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim count As Integer = OO_00oOO.CurrentTable.DataTable.DataCols.Count
			Column.AddExpressionColumn()
			If count <> OO_00oOO.CurrentTable.DataTable.DataCols.Count Then
				Me.O0._o0oO0O.()
				Me.O0._o0oO0O.().Row = Me.O0._o0oO0O.().Rows.Count - 1
				Me.O0._o0oO0O.().ShowCell(Me.O0._o0oO0O.().Row, 1)
			End If
		End Sub

		' Token: 0x06003A08 RID: 14856 RVA: 0x001921D6 File Offset: 0x001903D6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Column.EditExpression()
				Me.O0._o0oO0O.()
			End If
		End Sub

		' Token: 0x06003A09 RID: 14857 RVA: 0x001921EB File Offset: 0x001903EB
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Column.ChangeType()
				Me.O0._o0oO0O.()
			End If
		End Sub

		' Token: 0x06003A0A RID: 14858 RVA: 0x00192200 File Offset: 0x00190400
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Dim row As Integer = Me.O0._o0oO0O.().Row
				Dim count As Integer = OO_00oOO.CurrentTable.DataTable.DataCols.Count
				Column.Delete()
				If count <> OO_00oOO.CurrentTable.DataTable.DataCols.Count Then
					Me.O0._o0oO0O.()
					Me.O0._o0oO0O.().Row = Math.Min(Me.O0._o0oO0O.().Rows.Count - 1, row)
					Me.O0._o0oO0O.().ShowCell(Me.O0._o0oO0O.().Row, 1)
				End If
			End If
		End Sub

		' Token: 0x06003A0B RID: 14859 RVA: 0x00192290 File Offset: 0x00190490
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Dim row As Integer = Me.O0._o0oO0O.().Row
				Column.Rename()
				Me.O0._o0oO0O.()
				Me.O0._o0oO0O.().Row = row
				Me.O0._o0oO0O.().ShowCell(Me.O0._o0oO0O.().Row, 1)
			End If
		End Sub

		' Token: 0x06003A0C RID: 14860 RVA: 0x001922DF File Offset: 0x001904DF
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Column.EditGetValueCode()
			End If
		End Sub

		' Token: 0x06003A0D RID: 14861 RVA: 0x001922EE File Offset: 0x001904EE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Column.MoveLeft()
				Me.O0._o0oO0O.()
			End If
		End Sub

		' Token: 0x06003A0E RID: 14862 RVA: 0x00192303 File Offset: 0x00190503
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Column.MoveRight()
				Me.O0._o0oO0O.()
			End If
		End Sub

		' Token: 0x06003A0F RID: 14863 RVA: 0x00192318 File Offset: 0x00190518
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0._o0oO0O.() Then
				Column.Rename()
				Me.O0._o0oO0O.()
			End If
		End Sub

		' Token: 0x06003A10 RID: 14864 RVA: 0x00192330 File Offset: 0x00190530
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If A_1.Col = 0 AndAlso A_1.Row > 0 AndAlso Operators.CompareString(A_1.Text, "", True) > 0 Then
				Dim dataCol As DataCol = OO_00oOO.CurrentTable.DataTable.DataCols(A_1.Text)
				If(OO_00oOO.CurrentTable.DataTable.frd_IsInnerTable OrElse OO_00oOO.CurrentTable.DataTable.frd_IsOuterTable) AndAlso dataCol.IsTemporary Then
					A_1.Image = a.O.o_oo0O_.().ToBitmap()
				End If
			End If
		End Sub

		' Token: 0x06003A11 RID: 14865 RVA: 0x001923B8 File Offset: 0x001905B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0._o0oO0O.().PrintParameters.PrintGridFlags = 1
			Me.O0._o0oO0O.().PrintParameters.Footer = OO_00oOO.CurrentTable.DataTable.Name
			Me.O0._o0oO0O.().PrintGrid(OO_00oOO.CurrentTable.DataTable.Name)
		End Sub

		' Token: 0x06003A12 RID: 14866 RVA: 0x00192410 File Offset: 0x00190610
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040017FB RID: 6139
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040017FC RID: 6140
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040017FD RID: 6141
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017FE RID: 6142
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017FF RID: 6143
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001800 RID: 6144
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001801 RID: 6145
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001802 RID: 6146
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001803 RID: 6147
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001804 RID: 6148
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
