Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200025C RID: 604
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class af
		Inherits Form

		' Token: 0x06001C50 RID: 7248 RVA: 0x000B3330 File Offset: 0x000B1530
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o.O0_ooo0. IsNot Nothing Then
					Me.o.O0_ooo0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001C51 RID: 7249 RVA: 0x000B3370 File Offset: 0x000B1570
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(af))
			Me.O0OOo.Oo_o.(New C1ComboBox())
			Me.O0OOo.Oo_o.(New Label())
			Me.Oo000.0_oO_.(New C1Button())
			Me.OO___O.0O0.(New C1Button())
			Me.O0OOo.Oo_o.(New C1FlexGrid())
			Me.O_.0O__O.(New Label())
			Me.Oo.0oo_0oO.(New C1TextBox())
			Me.o_OOo0O.o.(New C1Button())
			Me.O_0.OoO_.(New C1FlexGrid())
			Me.O_0.OoO_.(New Label())
			Me.oo0_.0oO.(New C1TextBox())
			Me.O_0.OoO_.(New C1CheckBox())
			Me.OO_0.OoOO00oo.(New Label())
			Me.O._O__o.(New C1TextBox())
			Me.O0OOo.Oo_o.(New C1CheckBox())
			Me.O_.___oO_O_.(New Label())
			Me.o_0.o.().BeginInit()
			Me.OO0o0OO_.o.().BeginInit()
			MyBase.SuspendLayout()
			Me.o_O.o_0O.().DropDownStyle = 1
			Me.o_O.o_0O.().Location = New Point(68, 12)
			Me.o_O.o_0O.().Name = "cmbDataSource"
			Me.o_O.o_0O.().Size = New Size(149, 20)
			Me.o_O.o_0O.().TabIndex = 6
			Me.OOO0_.__O0_o.().AutoSize = True
			Me.OOO0_.__O0_o.().Location = New Point(15, 16)
			Me.OOO0_.__O0_o.().Name = "Label2"
			Me.OOO0_.__O0_o.().Size = New Size(47, 12)
			Me.OOO0_.__O0_o.().TabIndex = 5
			Me.OOO0_.__O0_o.().Text = "数据源:"
			Me.o_O.o_0O.().Location = New Point(621, 531)
			Me.o_O.o_0O.().Name = "btnOK"
			Me.o_O.o_0O.().Size = New Size(75, 23)
			Me.o_O.o_0O.().TabIndex = 9
			Me.o_O.o_0O.().Text = "确定"
			Me.o_O.o_0O.().UseVisualStyleBackColor = True
			Me.O.0Oo_0o_Ooo_.().Location = New Point(702, 531)
			Me.O.0Oo_0o_Ooo_.().Name = "btnCancel"
			Me.O.0Oo_0o_Ooo_.().Size = New Size(75, 23)
			Me.O.0Oo_0o_Ooo_.().TabIndex = 10
			Me.O.0Oo_0o_Ooo_.().Text = "取消"
			Me.O.0Oo_0o_Ooo_.().UseVisualStyleBackColor = True
			Me.o_0.o.().AllowDelete = True
			Me.o_0.o.().AutoClipboard = True
			Me.o_0.o.().ColumnInfo = componentResourceManager.GetString("grdColumns.ColumnInfo")
			Me.o_0.o.().ExtendLastCol = True
			Me.o_0.o.().HighLight = 0
			Me.o_0.o.().Location = New Point(14, 163)
			Me.o_0.o.().Name = "grdColumns"
			Me.o_0.o.().Rows.Count = 1
			Me.o_0.o.().Rows.DefaultSize = 20
			Me.o_0.o.().SelectionMode = 3
			Me.o_0.o.().ShowThemedHeaders = 1
			Me.o_0.o.().Size = New Size(765, 233)
			Me.o_0.o.().TabIndex = 7
			Me.o.0___0O_Oo__.().AutoSize = True
			Me.o.0___0O_Oo__.().Location = New Point(12, 437)
			Me.o.0___0O_Oo__.().Name = "Label1"
			Me.o.0___0O_Oo__.().Size = New Size(35, 12)
			Me.o.0___0O_Oo__.().TabIndex = 11
			Me.o.0___0O_Oo__.().Text = "条件:"
			Me.OO0o0OO_.o.().Location = New Point(47, 433)
			Me.OO0o0OO_.o.().Name = "txtFilter"
			Me.OO0o0OO_.o.().Size = New Size(730, 21)
			Me.OO0o0OO_.o.().TabIndex = 12
			Me.o_0.o.().Location = New Point(540, 531)
			Me.o_0.o.().Name = "btnPreview"
			Me.o_0.o.().Size = New Size(75, 23)
			Me.o_0.o.().TabIndex = 8
			Me.o_0.o.().Text = "预览"
			Me.o_0.o.().UseVisualStyleBackColor = True
			Me.OO0o0OO_.o.().AllowDelete = True
			Me.OO0o0OO_.o.().AllowDragging = 0
			Me.OO0o0OO_.o.().AllowSorting = 0
			Me.OO0o0OO_.o.().AutoClipboard = True
			Me.OO0o0OO_.o.().ColumnInfo = componentResourceManager.GetString("grdTables.ColumnInfo")
			Me.OO0o0OO_.o.().ExtendLastCol = True
			Me.OO0o0OO_.o.().HighLight = 0
			Me.OO0o0OO_.o.().Location = New Point(14, 40)
			Me.OO0o0OO_.o.().Name = "grdTables"
			Me.OO0o0OO_.o.().Rows.Count = 1
			Me.OO0o0OO_.o.().Rows.DefaultSize = 20
			Me.OO0o0OO_.o.().SelectionMode = 3
			Me.OO0o0OO_.o.().ShowThemedHeaders = 1
			Me.OO0o0OO_.o.().Size = New Size(765, 106)
			Me.OO0o0OO_.o.().TabIndex = 0
			Me.OoOO_o00oo.O.().AutoSize = True
			Me.OoOO_o00oo.O.().Location = New Point(12, 468)
			Me.OoOO_o00oo.O.().Name = "Label3"
			Me.OoOO_o00oo.O.().Size = New Size(35, 12)
			Me.OoOO_o00oo.O.().TabIndex = 13
			Me.OoOO_o00oo.O.().Text = "排序:"
			Me.oooO00O.0_.().Location = New Point(47, 464)
			Me.oooO00O.0_.().Name = "txtOrder"
			Me.oooO00O.0_.().Size = New Size(247, 21)
			Me.oooO00O.0_.().TabIndex = 14
			Me.o_0.o.().AutoSize = True
			Me.o_0.o.().Location = New Point(693, 479)
			Me.o_0.o.().Name = "chkDistinct"
			Me.o_0.o.().Size = New Size(84, 16)
			Me.o_0.o.().TabIndex = 15
			Me.o_0.o.().Text = "排除重复值"
			Me.o_0.o.().UseVisualStyleBackColor = True
			Me.OO0o0OO_.o.().AutoSize = True
			Me.OO0o0OO_.o.().Location = New Point(12, 499)
			Me.OO0o0OO_.o.().Name = "Label4"
			Me.OO0o0OO_.o.().Size = New Size(35, 12)
			Me.OO0o0OO_.o.().TabIndex = 17
			Me.OO0o0OO_.o.().Text = "行数:"
			Me.o.0___0O_Oo__.().Location = New Point(47, 495)
			Me.o.0___0O_Oo__.().Name = "txtTop"
			Me.o.0___0O_Oo__.().Size = New Size(247, 21)
			Me.o.0___0O_Oo__.().TabIndex = 18
			Me.o_O.o_0O.().AutoSize = True
			Me.o_O.o_0O.().Checked = True
			Me.o_O.o_0O.().CheckState = CheckState.Checked
			Me.o_O.o_0O.().Location = New Point(693, 12)
			Me.o_O.o_0O.().Name = "chkSysColumns"
			Me.o_O.o_0O.().Size = New Size(84, 16)
			Me.o_O.o_0O.().TabIndex = 19
			Me.o_O.o_0O.().Text = "列出系统列"
			Me.o_O.o_0O.().UseVisualStyleBackColor = True
			Me.oooO00O.0_.().AutoSize = True
			Me.oooO00O.0_.().Location = New Point(12, 408)
			Me.oooO00O.0_.().Name = "Label5"
			Me.oooO00O.0_.().Size = New Size(329, 12)
			Me.oooO00O.0_.().TabIndex = 20
			Me.oooO00O.0_.().Text = "提示: 按Delete删除行，按Ctrl+D下移行，按Ctrl+U上移行。"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(789, 565)
			MyBase.Controls.Add(Me.oooO00O.0_.())
			MyBase.Controls.Add(Me.o_O.o_0O.())
			MyBase.Controls.Add(Me.o.0___0O_Oo__.())
			MyBase.Controls.Add(Me.OO0o0OO_.o.())
			MyBase.Controls.Add(Me.o_0.o.())
			MyBase.Controls.Add(Me.oooO00O.0_.())
			MyBase.Controls.Add(Me.OoOO_o00oo.O.())
			MyBase.Controls.Add(Me.OO0o0OO_.o.())
			MyBase.Controls.Add(Me.o.0___0O_Oo__.())
			MyBase.Controls.Add(Me.O.0Oo_0o_Ooo_.())
			MyBase.Controls.Add(Me.o_O.o_0O.())
			MyBase.Controls.Add(Me.o_0.o.())
			MyBase.Controls.Add(Me.o_0.o.())
			MyBase.Controls.Add(Me.o_O.o_0O.())
			MyBase.Controls.Add(Me.OOO0_.__O0_o.())
			MyBase.Controls.Add(Me.OO0o0OO_.o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O0..o0O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "查询表生成器"
			Me.o_0.o.().EndInit()
			Me.OO0o0OO_.o.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06001C52 RID: 7250 RVA: 0x000B3CFA File Offset: 0x000B1EFA
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oo.0oo_0oO.
		End Function

		' Token: 0x06001C53 RID: 7251 RVA: 0x000B3D04 File Offset: 0x000B1F04
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.Oo_o00__._.
			Dim oo.0oo_0oO. As C1ComboBox = Me.Oo.0oo_0oO.
			If oo.0oo_0oO. IsNot Nothing Then
				oo.0oo_0oO..SelectedIndexChanged -= eventHandler
			End If
			Me.Oo.0oo_0oO. = A_0
			oo.0oo_0oO. = Me.Oo.0oo_0oO.
			If oo.0oo_0oO. IsNot Nothing Then
				oo.0oo_0oO..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06001C54 RID: 7252 RVA: 0x000B3D47 File Offset: 0x000B1F47
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_O_.oo.
		End Function

		' Token: 0x06001C55 RID: 7253 RVA: 0x000B3D4F File Offset: 0x000B1F4F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_O_.oo. = A_0
		End Sub

		' Token: 0x06001C56 RID: 7254 RVA: 0x000B3D58 File Offset: 0x000B1F58
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo.0oo_0oO.
		End Function

		' Token: 0x06001C57 RID: 7255 RVA: 0x000B3D60 File Offset: 0x000B1F60
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim value As EventHandler = AddressOf Me.oo.O_Oo.
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.Oo000.0_oO_.
			Dim value2 As KeyEventHandler = AddressOf Me.Oo000.0_oO_.
			Dim oo.0oo_0oO. As C1FlexGrid = Me.Oo.0oo_0oO.
			If oo.0oo_0oO. IsNot Nothing Then
				RemoveHandler oo.0oo_0oO..Enter, value
				oo.0oo_0oO..StartEdit -= rowColEventHandler
				RemoveHandler oo.0oo_0oO..KeyDown, value2
			End If
			Me.Oo.0oo_0oO. = A_0
			oo.0oo_0oO. = Me.Oo.0oo_0oO.
			If oo.0oo_0oO. IsNot Nothing Then
				AddHandler oo.0oo_0oO..Enter, value
				oo.0oo_0oO..StartEdit += rowColEventHandler
				AddHandler oo.0oo_0oO..KeyDown, value2
			End If
		End Sub

		' Token: 0x06001C58 RID: 7256 RVA: 0x000B3DD9 File Offset: 0x000B1FD9
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo.0oo_0oO.
		End Function

		' Token: 0x06001C59 RID: 7257 RVA: 0x000B3DE4 File Offset: 0x000B1FE4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.0__Oo_.
			Dim oo.0oo_0oO. As C1Button = Me.Oo.0oo_0oO.
			If oo.0oo_0oO. IsNot Nothing Then
				RemoveHandler oo.0oo_0oO..Click, value
			End If
			Me.Oo.0oo_0oO. = A_0
			oo.0oo_0oO. = Me.Oo.0oo_0oO.
			If oo.0oo_0oO. IsNot Nothing Then
				AddHandler oo.0oo_0oO..Click, value
			End If
		End Sub

		' Token: 0x06001C5A RID: 7258 RVA: 0x000B3E27 File Offset: 0x000B2027
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._O__o.
		End Function

		' Token: 0x06001C5B RID: 7259 RVA: 0x000B3E30 File Offset: 0x000B2030
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_.000o.
			Dim o._O__o. As C1Button = Me.O._O__o.
			If o._O__o. IsNot Nothing Then
				RemoveHandler o._O__o..Click, value
			End If
			Me.O._O__o. = A_0
			o._O__o. = Me.O._O__o.
			If o._O__o. IsNot Nothing Then
				AddHandler o._O__o..Click, value
			End If
		End Sub

		' Token: 0x06001C5C RID: 7260 RVA: 0x000B3E73 File Offset: 0x000B2073
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_0O00._ooO0.
		End Function

		' Token: 0x06001C5D RID: 7261 RVA: 0x000B3E7B File Offset: 0x000B207B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_0O00._ooO0. = A_0
		End Sub

		' Token: 0x06001C5E RID: 7262 RVA: 0x000B3E84 File Offset: 0x000B2084
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_O_.oo.
		End Function

		' Token: 0x06001C5F RID: 7263 RVA: 0x000B3E8C File Offset: 0x000B208C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_O_.oo. = A_0
		End Sub

		' Token: 0x06001C60 RID: 7264 RVA: 0x000B3E95 File Offset: 0x000B2095
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo0_.0oO.
		End Function

		' Token: 0x06001C61 RID: 7265 RVA: 0x000B3EA0 File Offset: 0x000B20A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO.OoOOo__.
			Dim c1Button As C1Button = Me.oo0_.0oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo0_.0oO. = A_0
			c1Button = Me.oo0_.0oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001C62 RID: 7266 RVA: 0x000B3EE3 File Offset: 0x000B20E3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o_0O00._ooO0.
		End Function

		' Token: 0x06001C63 RID: 7267 RVA: 0x000B3EEC File Offset: 0x000B20EC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.oo.O_Oo.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.OO___O.0O0.
			Dim rowColEventHandler3 As RowColEventHandler = AddressOf Me.o_OOo0O.o.
			Dim value As KeyEventHandler = AddressOf Me.Oo000.0_oO_.
			Dim c1FlexGrid As C1FlexGrid = Me.o_0O00._ooO0.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.AfterEdit -= rowColEventHandler
				c1FlexGrid.BeforeEdit -= rowColEventHandler2
				c1FlexGrid.StartEdit -= rowColEventHandler3
				RemoveHandler c1FlexGrid.KeyDown, value
			End If
			Me.o_0O00._ooO0. = A_0
			c1FlexGrid = Me.o_0O00._ooO0.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.AfterEdit += rowColEventHandler
				c1FlexGrid.BeforeEdit += rowColEventHandler2
				c1FlexGrid.StartEdit += rowColEventHandler3
				AddHandler c1FlexGrid.KeyDown, value
			End If
		End Sub

		' Token: 0x06001C64 RID: 7268 RVA: 0x000B3F8C File Offset: 0x000B218C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOo0_._o_o00.
		End Function

		' Token: 0x06001C65 RID: 7269 RVA: 0x000B3F94 File Offset: 0x000B2194
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOo0_._o_o00. = A_0
		End Sub

		' Token: 0x06001C66 RID: 7270 RVA: 0x000B3F9D File Offset: 0x000B219D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o_0O00._ooO0.
		End Function

		' Token: 0x06001C67 RID: 7271 RVA: 0x000B3FA5 File Offset: 0x000B21A5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o_0O00._ooO0. = A_0
		End Sub

		' Token: 0x06001C68 RID: 7272 RVA: 0x000B3FAE File Offset: 0x000B21AE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Oo.0oo_0oO.
		End Function

		' Token: 0x06001C69 RID: 7273 RVA: 0x000B3FB6 File Offset: 0x000B21B6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.Oo.0oo_0oO. = A_0
		End Sub

		' Token: 0x06001C6A RID: 7274 RVA: 0x000B3FBF File Offset: 0x000B21BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.0__0oo.
		End Function

		' Token: 0x06001C6B RID: 7275 RVA: 0x000B3FC7 File Offset: 0x000B21C7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.0__0oo. = A_0
		End Sub

		' Token: 0x06001C6C RID: 7276 RVA: 0x000B3FD0 File Offset: 0x000B21D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oOo0_._o_o00.
		End Function

		' Token: 0x06001C6D RID: 7277 RVA: 0x000B3FD8 File Offset: 0x000B21D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oOo0_._o_o00. = A_0
		End Sub

		' Token: 0x06001C6E RID: 7278 RVA: 0x000B3FE1 File Offset: 0x000B21E1
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O._O__o.
		End Function

		' Token: 0x06001C6F RID: 7279 RVA: 0x000B3FE9 File Offset: 0x000B21E9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O._O__o. = A_0
		End Sub

		' Token: 0x06001C70 RID: 7280 RVA: 0x000B3FF2 File Offset: 0x000B21F2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO.OOO_00oo0O.
		End Function

		' Token: 0x06001C71 RID: 7281 RVA: 0x000B3FFA File Offset: 0x000B21FA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO.OOO_00oo0O. = A_0
		End Sub

		' Token: 0x06001C72 RID: 7282 RVA: 0x000B4004 File Offset: 0x000B2204
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o_O.o_0O.().Items.Add("内部数据源")
				IL_1F:
				num2 = 3
				Dim enumerator As IEnumerator = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_51:
					num2 = 4
					Me.o_O.o_0O.().Items.Add(Conversions.ToString(dataRow("Name")))
					IL_75:
					num2 = 5
				End While
				IL_80:
				num2 = 6
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_97:
				num2 = 7
				Me.o_O.o_0O.().SelectedIndex = 0
				IL_A5:
				num2 = 8
				If Me.o.O0_ooo0..RowState = DataRowState.Detached Then
					GoTo IL_4C1
				End If
				IL_B8:
				num2 = 9
				If Me.o.O0_ooo0..IsNull("DataSource") OrElse Operators.CompareString(Conversions.ToString(Me.o.O0_ooo0.("DataSource")), "", True) <= 0 Then
					GoTo IL_165
				End If
				IL_F3:
				num2 = 10
				Dim num3 As Integer = Me.o_O.o_0O.().Items.Count - 1
				For i As Integer = 1 To num3
					IL_10F:
					num2 = 11
					If Operators.CompareString(Conversions.ToString(Me.o_O.o_0O.().Items(i)), Conversions.ToString(Me.o.O0_ooo0.("DataSource")), True) = 0 Then
						IL_146:
						num2 = 12
						Me.o_O.o_0O.().SelectedIndex = i
					End If
					IL_156:
					num2 = 13
				Next
				IL_165:
				num2 = 14
				If Me.o.O0_ooo0..IsNull("Property") OrElse Operators.CompareString(Conversions.ToString(Me.o.O0_ooo0.("Property")), "", True) <= 0 Then
					GoTo IL_491
				End If
				IL_1A3:
				num2 = 15
				Dim text As String = Conversions.ToString(Me.o.O0_ooo0.("Property"))
				IL_1BD:
				num2 = 16
				text = text.Trim(New Char() { "{"c, "}"c })
				IL_1D9:
				num2 = 17
				Dim joinTableProperty As JoinTableProperty = New JoinTableProperty()
				IL_1E3:
				num2 = 18
				o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, text, vbVerticalTab)
				IL_1F1:
				num2 = 19
				Me.OO0o0OO_.o.().Value = joinTableProperty.Filter
				IL_206:
				num2 = 20
				Me.oooO00O.0_.().Value = joinTableProperty.Order
				IL_21B:
				num2 = 21
				Me.o.0___0O_Oo__.().Value = joinTableProperty.Top
				IL_230:
				num2 = 22
				Me.o_0.o.().Checked = joinTableProperty.Distinct
				IL_245:
				num2 = 23
				If Operators.CompareString(joinTableProperty.LinkTables, "", True) <= 0 Then
					GoTo IL_3AA
				End If
				IL_260:
				num2 = 24
				Dim array As String() = joinTableProperty.LinkTables.Split(New Char() { vbLf })
				IL_27C:
				num2 = 25
				For Each text2 As String In array
					IL_292:
					num2 = 26
					Dim array3 As String() = text2.Split(New Char() { vbTab })
					IL_2A9:
					num2 = 27
					Dim c1FlexGrid As C1FlexGrid = Me.OO0o0OO_.o.()
					IL_2B4:
					num2 = 28
					c1FlexGrid.AddItem(String.Concat(New String() { array3(0), vbTab, array3(1), vbTab, array3(2), vbTab, array3(3) }))
					IL_2FE:
					num2 = 29
					Select Case Conversions.ToInteger([Enum].Parse(GetType(JoinModeEnum), array3(4)))
						Case 0
							IL_330:
							num2 = 31
							c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, "内连接")
						Case 1
							IL_351:
							num2 = 33
							c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, "左连接")
						Case 2
							IL_372:
							num2 = 35
							c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, "右连接")
					End Select
					IL_391:
					c1FlexGrid = Nothing
					IL_394:
					num2 = 38
				Next
				GoTo IL_3C0
				IL_3AA:
				num2 = 40
				Me.OO0o0OO_.o.().AddItem(joinTableProperty.BaseTable)
				IL_3C0:
				num2 = 41
				If Operators.CompareString(joinTableProperty.Columns, "", True) <= 0 Then
					GoTo IL_491
				End If
				IL_3DB:
				num2 = 42
				Dim array4 As String() = joinTableProperty.Columns.Split(New Char() { vbLf })
				IL_3F7:
				num2 = 43
				For Each text3 As String In array4
					IL_40D:
					num2 = 44
					Dim array6 As String() = text3.Split(New Char() { vbTab })
					IL_424:
					num2 = 45
					Dim c1FlexGrid2 As C1FlexGrid = Me.o_0.o.()
					IL_42F:
					num2 = 46
					c1FlexGrid2.AddItem(array6(0) + vbTab + array6(1))
					IL_44C:
					num2 = 47
					If Operators.CompareString(array6(2), "1", True) = 0 Then
						IL_460:
						num2 = 48
						c1FlexGrid2.SetCellCheck(c1FlexGrid2.Rows.Count - 1, 2, 1)
					End If
					IL_47A:
					c1FlexGrid2 = Nothing
					IL_47D:
					num2 = 50
				Next
				IL_491:
				num2 = 51
				Me.Text = Me.Text + " - " + Conversions.ToString(Me.o.O0_ooo0.("Name"))
				GoTo IL_4DA
				IL_4C1:
				num2 = 53
				Me.Text += " - 新建"
				IL_4DA:
				num2 = 54
				Me.OO0o0OO_.o.().Cols(1).Editor = New o0_o_o_0()
				IL_4F8:
				num2 = 55
				Me.OO0o0OO_.o.().Cols(3).Editor = New o0_o_o_0()
				IL_516:
				num2 = 56
				Dim c1DropDownControl As C1DropDownControl = New C1DropDownControl()
				IL_51F:
				num2 = 57
				c1DropDownControl.ShowUpDownButtons = False
				IL_529:
				num2 = 58
				c1DropDownControl.DropDownForm = Me.o.O0_ooo0.
				IL_538:
				num2 = 59
				Me.o_0.o.().Cols(0).Editor = c1DropDownControl
				IL_552:
				num2 = 60
				Me.OO0o0OO_.o.().AllowAddNew = True
				IL_561:
				num2 = 61
				Me.o_0.o.().AllowAddNew = True
				IL_570:
				num2 = 62
				Me.o_0.o.().Rows.DefaultSize = 22
				IL_585:
				num2 = 63
				Me.OO0o0OO_.o.().Rows.DefaultSize = 22
				IL_59A:
				num2 = 64
				Me.o_0.o.().Styles.Fixed.TextAlign = 4
				IL_5B3:
				num2 = 65
				Me.OO0o0OO_.o.().Styles.Fixed.TextAlign = 4
				IL_5CC:
				GoTo IL_726
				IL_5D1:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_6E7:
				GoTo IL_71B
				IL_6E9:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6F9:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_6E9
			End Try
			IL_71B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_726:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001C73 RID: 7283 RVA: 0x000B475C File Offset: 0x000B295C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.O_O_.oo. = Nothing
				IL_10:
				num2 = 3
				Me.o.O0_ooo0. = Nothing
				IL_19:
				num2 = 4
				If Me.o_O.o_0O.().SelectedIndex <> 0 Then
					GoTo IL_37
				End If
				IL_28:
				num2 = 5
				Me.O_O_.oo. = O_O0OO.OoO.0OO__0ooo.()
				GoTo IL_8D
				IL_37:
				num2 = 7
				If Not O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.o_O.o_0O.().Text) Then
					GoTo IL_6F
				End If
				IL_50:
				num2 = 8
				Me.o.O0_ooo0. = O_O0OO.OoO__.0oO0oo.()(Me.o_O.o_0O.().Text)
				GoTo IL_8D
				IL_6F:
				num2 = 10
				Me.O_O_.oo. = O_O0OO.O._o_.()(Me.o_O.o_0O.().Text)
				IL_8D:
				num2 = 11
				Dim text As String = ""
				IL_96:
				num2 = 12
				If Me.O_O_.oo. Is Nothing Then
					GoTo IL_2C8
				End If
				IL_A4:
				num2 = 13
				Me.O_O_.oo..Open()
				IL_B2:
				num2 = 14
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O_O_.oo.) Then
					GoTo IL_191
				End If
				IL_C5:
				num2 = 15
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", Me.O_O_.oo.)
				IL_DA:
				num2 = 16
				Dim dataTable As DataTable = New DataTable()
				IL_E4:
				num2 = 17
				oleDbDataAdapter.Fill(dataTable)
				IL_F1:
				num2 = 18
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_112:
					num2 = 19
					text = String.Concat(New String() { text, "|""", dataRow("OWNER").ToString(), """.""", dataRow("TABLE_NAME").ToString(), """" })
					IL_165:
					num2 = 20
				End While
				IL_171:
				num2 = 21
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_2B8
				End If
				GoTo IL_2B8
				IL_191:
				num2 = 23
				dataTable = Me.O_O_.oo..GetSchema("Tables")
				IL_1A6:
				num2 = 24
				Dim filterExpression As String = "[TABLE_TYPE]='TABLE'"
				IL_1B0:
				num2 = 25
				For Each dataRow2 As DataRow In dataTable.[Select](filterExpression)
					IL_1CD:
					num2 = 26
					Dim text2 As String = Conversions.ToString(dataRow2("TABLE_NAME"))
					IL_1E3:
					num2 = 27
					If Not dataRow2.IsNull("TABLE_SCHEMA") AndAlso Operators.CompareString(dataRow2("TABLE_SCHEMA").ToString(), "dbo", True) <> 0 Then
						IL_212:
						num2 = 29
						text2 = String.Concat(New String() { "[", dataRow2("TABLE_SCHEMA").ToString(), "].[", text2, "]" })
					End If
					IL_253:
					num2 = 30
					If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text2) Then
						IL_264:
						num2 = 32
						If Me.O_O_.oo. Is O_O0OO.OoO.0OO__0ooo.() Then
							IL_274:
							num2 = 33
							If text2.StartsWith("~TMPCLP", StringComparison.CurrentCultureIgnoreCase) Then
								IL_286:
								num2 = 34
								text2 = text2.Substring(7)
							End If
						End If
						IL_293:
						num2 = 35
						text = text + "|" + text2
					End If
					IL_2A4:
					num2 = 36
				Next
				IL_2B8:
				num2 = 37
				Me.O_O_.oo..Close()
				GoTo IL_2ED
				IL_2C8:
				num2 = 39
				Dim list As List(Of String) = Me.o.O0_ooo0..OO._o_OO.()
				IL_2D8:
				num2 = 40
				text = String.Join("|", list.ToArray())
				IL_2ED:
				num2 = 41
				text = text.Trim(New Char() { "|"c })
				IL_302:
				num2 = 42
				Me.OO0o0OO_.o.().Cols(0).ComboList = text
				IL_31C:
				num2 = 43
				Me.OO0o0OO_.o.().Cols(2).ComboList = text
				IL_336:
				GoTo IL_438
				IL_33B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_3F9:
				GoTo IL_42D
				IL_3FB:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_40B:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_3FB
			End Try
			IL_42D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_438:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001C74 RID: 7284 RVA: 0x000B4BC8 File Offset: 0x000B2DC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.OO0o0OO_.o.()
			If c1FlexGrid.Col = 2 AndAlso Operators.CompareString(c1FlexGrid.GetDataDisplay(A_1.Row, 4), "", True) = 0 Then
				c1FlexGrid.SetData(c1FlexGrid.Row, 4, "内连接")
			End If
		End Sub

		' Token: 0x06001C75 RID: 7285 RVA: 0x000B4C14 File Offset: 0x000B2E14
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim dataDisplay As String
			If A_1.Col = 1 Then
				dataDisplay = Me.OO0o0OO_.o.().GetDataDisplay(A_1.Row, 0)
			Else
				If A_1.Col <> 3 Then
					Return
				End If
				dataDisplay = Me.OO0o0OO_.o.().GetDataDisplay(A_1.Row, 2)
			End If
			If Operators.CompareString(dataDisplay, "", True) <> 0 Then
				Dim list As List(Of String) = Me.OO0o0OO_.o.(dataDisplay)
				Dim o0_o_o_ As o0_o_o_0 = CType(Me.OO0o0OO_.o.().Cols(A_1.Col).Editor, o0_o_o_0)
				o0_o_o_.o.O0.().Clear()
				o0_o_o_.o.O0.().AddRange(list.ToArray())
				o0_o_o_.O.0o0O.(False)
			End If
		End Sub

		' Token: 0x06001C76 RID: 7286 RVA: 0x000B4CB4 File Offset: 0x000B2EB4
		Private Function <<EMPTY_NAME>>(A_0 As String) As List(Of String)
			Dim num As Integer
			Dim result As List(Of String)
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.o.O0_ooo0..ContainsKey(Me.o_O.o_0O.().Text + "," + A_0) Then
					GoTo IL_55
				End If
				IL_2C:
				num2 = 3
				result = Me.o.O0_ooo0.(Me.o_O.o_0O.().Text + "," + A_0)
				GoTo IL_28D
				IL_55:
				num2 = 4
				If(Me.O_O_.oo. Is Nothing OrElse Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O_O_.oo.)) AndAlso (Me.o.O0_ooo0. Is Nothing OrElse Me.o.O0_ooo0..OO.OoO0. <> DataServerTypeEnum.Oracle) Then
					GoTo IL_D4
				End If
				IL_82:
				num2 = 5
				Dim array As String() = A_0.Split(New Char() { """"c, "."c }, StringSplitOptions.RemoveEmptyEntries)
				IL_9D:
				num2 = 6
				Dim text As String = String.Concat(New String() { "select column_name from all_tab_columns Where table_name = '", array(1), "' And owner = '", array(0), "'" })
				GoTo IL_120
				IL_D4:
				num2 = 8
				text = "Select * from " + Oo00.o.oo_0.(A_0)
				IL_E8:
				num2 = 9
				If Me.O_O_.oo. Is Nothing Then
					GoTo IL_108
				End If
				IL_F3:
				num2 = 10
				text = Oo00.o0_o._O_.(Me.O_O_.oo., text, False)
				GoTo IL_120
				IL_108:
				num2 = 12
				text = Oo00.o0_o._O_.(Me.o.O0_ooo0..OO.OoO0., text, False)
				IL_120:
				num2 = 13
				Dim dataTable As DataTable = New DataTable()
				IL_12A:
				num2 = 14
				Dim list As List(Of String) = New List(Of String)()
				IL_134:
				num2 = 15
				If Me.O_O_.oo. Is Nothing Then
					GoTo IL_17E
				End If
				IL_13F:
				num2 = 16
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, Me.O_O_.oo.)
				IL_151:
				num2 = 17
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_15F:
				num2 = 18
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O_O_.oo.) Then
					GoTo IL_191
				End If
				IL_16F:
				num2 = 19
				oleDbDataAdapter.Fill(dataTable)
				GoTo IL_191
				IL_17E:
				num2 = 21
				dataTable = Me.o.O0_ooo0..O_0_O_0_o_.0.(text, True)
				IL_191:
				num2 = 22
				If Me.O_O_.oo. Is Nothing OrElse Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O_O_.oo.) Then
					GoTo IL_20B
				End If
				IL_1A9:
				num2 = 23
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_1CA:
					num2 = 24
					list.Add(dataRow("COLUMN_NAME").ToString())
					IL_1E5:
					num2 = 25
				End While
				IL_1F1:
				num2 = 26
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_261
				End If
				GoTo IL_261
				IL_20B:
				num2 = 28
				Dim enumerator2 As IEnumerator = dataTable.Columns.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataColumn As DataColumn = CType(obj2, DataColumn)
					IL_22C:
					num2 = 29
					list.Add(dataColumn.ColumnName)
					IL_23D:
					num2 = 30
				End While
				IL_249:
				num2 = 31
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_261:
				num2 = 32
				Me.o.O0_ooo0.(Me.o_O.o_0O.().Text + "," + A_0) = list
				IL_287:
				num2 = 33
				result = list
				IL_28D:
				GoTo IL_367
				IL_292:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_328:
				GoTo IL_35C
				IL_32A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_33A:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_32A
			End Try
			IL_35C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_367:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06001C77 RID: 7287 RVA: 0x000B5050 File Offset: 0x000B3250
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If TypeOf Me.OO0o0OO_.o.().Editor Is o0_o_o_0 Then
				Dim o0_o_o_ As o0_o_o_0 = CType(Me.OO0o0OO_.o.().Editor, o0_o_o_0)
				If o0_o_o_.oOo_o_o000.o.() = 0 Then
					o0_o_o_.o_.O_.(15)
				End If
				o0_o_o_.Value = RuntimeHelpers.GetObjectValue(Me.OO0o0OO_.o.().GetData(A_1.Row, A_1.Col))
			End If
		End Sub

		' Token: 0x06001C78 RID: 7288 RVA: 0x000B50B4 File Offset: 0x000B32B4
		Public Sub New(A_0 As DataRow)
			AddHandler MyBase.Load, AddressOf Me.o__o.oO.
			AddHandler MyBase.FormClosed, AddressOf Me.o_O.o_0O.
			Me.O_O_.oo. = Nothing
			Me.o.O0_ooo0. = Nothing
			Me.o.O0_ooo0. = New O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000()
			Me.o.O0_ooo0. = New Dictionary(Of String, List(Of String))(StringComparer.OrdinalIgnoreCase)
			Me.Oo000.0_oO_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			For Each c1FlexGrid As C1FlexGrid In New C1FlexGrid() { Me.OO0o0OO_.o.(), Me.o_0.o.() }
				c1FlexGrid.Styles.SelectedColumnHeader.Clear()
				c1FlexGrid.Styles.Alternate.Clear()
				c1FlexGrid.Styles.Focus.Clear()
				c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
				c1FlexGrid.FocusRect = 3
				c1FlexGrid.AllowSorting = 0
			Next
			Me.o.O0_ooo0. = A_0
		End Sub

		' Token: 0x06001C79 RID: 7289 RVA: 0x000B51BC File Offset: 0x000B33BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o.O0_ooo0..o_O0_O.O_OOO.().Nodes.Clear()
				IL_1E:
				num2 = 3
				Dim list As List(Of String) = New List(Of String)()
				IL_26:
				num2 = 4
				Dim num3 As Integer = Me.OO0o0OO_.o.().Rows.Count - 1
				For i As Integer = 1 To num3
					IL_44:
					num2 = 5
					Dim dataDisplay As String = Me.OO0o0OO_.o.().GetDataDisplay(i, 0)
					IL_56:
					num2 = 6
					If Operators.CompareString(dataDisplay, "", True) > 0 AndAlso Not list.Contains(dataDisplay) Then
						IL_72:
						num2 = 7
						list.Add(dataDisplay)
					End If
					IL_7C:
					num2 = 8
					dataDisplay = Me.OO0o0OO_.o.().GetDataDisplay(i, 2)
					IL_8E:
					num2 = 9
					If Operators.CompareString(dataDisplay, "", True) > 0 AndAlso Not list.Contains(dataDisplay) Then
						IL_AB:
						num2 = 10
						list.Add(dataDisplay)
					End If
					IL_B6:
					num2 = 11
					Me.o_0.o.().Cols(0).ComboList = String.Join("|", list.ToArray())
					IL_DF:
					num2 = 12
				Next
				IL_F1:
				num2 = 13
				Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_107:
					num2 = 14
					Dim treeNode As TreeNode = Me.o.O0_ooo0..o_O0_O.O_OOO.().Nodes.Add(text, text)
					IL_125:
					num2 = 15
					Dim list2 As List(Of String) = Me.OO0o0OO_.o.(text)
					IL_132:
					num2 = 16
					Dim enumerator2 As List(Of String).Enumerator = list2.GetEnumerator()
					While enumerator2.MoveNext()
						Dim text2 As String = enumerator2.Current
						IL_149:
						num2 = 17
						treeNode.Nodes.Add(text2, text2)
						IL_15D:
						num2 = 18
					End While
					IL_169:
					num2 = 19
					CType(enumerator2, IDisposable).Dispose()
					IL_179:
					num2 = 20
				End While
				IL_188:
				num2 = 21
				CType(enumerator, IDisposable).Dispose()
				IL_198:
				GoTo IL_242
				IL_19D:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_203:
				GoTo IL_237
				IL_205:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_215:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_205
			End Try
			IL_237:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_242:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001C7A RID: 7290 RVA: 0x000B5430 File Offset: 0x000B3630
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj8 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_1.Col <> 0 Then
					GoTo IL_43D
				End If
				IL_14:
				num2 = 3
				Dim dataDisplay As String = Me.o_0.o.().GetDataDisplay(A_1.Row, A_1.Col)
				IL_2E:
				num2 = 4
				Dim array As String() = dataDisplay.Split(New Char() { ","c })
				IL_43:
				num2 = 5
				Dim treeView As TreeView = Me.o.O0_ooo0..o_O0_O.O_OOO.()
				IL_52:
				num2 = 6
				Me.o.O0_ooo0..oo_.000o. = False
				IL_60:
				num2 = 7
				Dim enumerator As IEnumerator = treeView.Nodes.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					IL_80:
					num2 = 8
					treeNode.Checked = False
					IL_8A:
					num2 = 9
					Dim enumerator2 As IEnumerator = treeNode.Nodes.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj2 As Object = enumerator2.Current
						Dim treeNode2 As TreeNode = CType(obj2, TreeNode)
						IL_AB:
						num2 = 10
						treeNode2.Checked = False
						IL_B6:
						num2 = 11
					End While
					IL_C2:
					num2 = 12
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
					IL_DA:
					num2 = 13
				End While
				IL_E6:
				num2 = 14
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_FE:
				num2 = 15
				For Each text As String In array
					IL_114:
					num2 = 16
					If text.IndexOf("].[") < 0 Then
						IL_126:
						num2 = 17
						text = text.Trim(New Char() { "["c, "]"c, " "c })
					End If
					IL_143:
					num2 = 18
					If text.EndsWith(".*") Then
						IL_157:
						num2 = 19
						text = text.Substring(0, text.Length - 2).Trim(New Char() { "{"c, "}"c }).Trim()
						IL_187:
						num2 = 20
						Dim enumerator3 As IEnumerator = treeView.Nodes.GetEnumerator()
						While enumerator3.MoveNext()
							Dim obj3 As Object = enumerator3.Current
							Dim treeNode3 As TreeNode = CType(obj3, TreeNode)
							IL_1A8:
							num2 = 21
							If Operators.CompareString(treeNode3.Name, text, True) = 0 Then
								IL_1BC:
								num2 = 22
								treeNode3.Checked = True
								Exit While
							End If
							IL_1C9:
							num2 = 24
						End While
						IL_1D5:
						num2 = 25
						If TypeOf enumerator3 Is IDisposable Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					Else
						IL_1F5:
						num2 = 27
						If text.IndexOf("."c) > 0 Then
							IL_207:
							num2 = 28
							Dim num3 As Integer = text.LastIndexOf(".")
							IL_218:
							num2 = 29
							Dim array3 As String() = New String(1) {}
							IL_223:
							num2 = 30
							array3(0) = text.Substring(0, num3).Trim(New Char() { "{"c, "}"c })
							IL_249:
							num2 = 31
							array3(1) = text.Substring(num3 + 1).Trim(New Char() { "["c, "]"c })
							IL_270:
							num2 = 32
							Dim treeNode4 As TreeNode = Nothing
							IL_276:
							num2 = 33
							Dim enumerator4 As IEnumerator = treeView.Nodes.GetEnumerator()
							While enumerator4.MoveNext()
								Dim obj4 As Object = enumerator4.Current
								Dim treeNode5 As TreeNode = CType(obj4, TreeNode)
								IL_29A:
								num2 = 34
								If Operators.CompareString(treeNode5.Name, array3(0), True) = 0 Then
									IL_2B0:
									num2 = 35
									Dim enumerator5 As IEnumerator = treeNode5.Nodes.GetEnumerator()
									While enumerator5.MoveNext()
										Dim obj5 As Object = enumerator5.Current
										Dim treeNode6 As TreeNode = CType(obj5, TreeNode)
										IL_2D1:
										num2 = 36
										If Operators.CompareString(treeNode6.Name, array3(1), True) = 0 Then
											IL_2E7:
											num2 = 37
											treeNode4 = treeNode6
											IL_2EE:
											num2 = 38
											treeNode6.Checked = True
											Exit While
										End If
										IL_2FB:
										num2 = 40
									End While
									IL_307:
									num2 = 41
									If TypeOf enumerator5 Is IDisposable Then
										TryCast(enumerator5, IDisposable).Dispose()
									End If
								End If
								IL_31F:
								num2 = 42
								If treeNode4 IsNot Nothing Then
									Exit While
								End If
								IL_326:
								num2 = 44
							End While
							IL_335:
							num2 = 45
							If TypeOf enumerator4 Is IDisposable Then
								TryCast(enumerator4, IDisposable).Dispose()
							End If
						Else
							IL_355:
							num2 = 47
							Dim treeNode7 As TreeNode = Nothing
							IL_35B:
							num2 = 48
							Dim enumerator6 As IEnumerator = treeView.Nodes.GetEnumerator()
							While enumerator6.MoveNext()
								Dim obj6 As Object = enumerator6.Current
								Dim treeNode8 As TreeNode = CType(obj6, TreeNode)
								IL_37F:
								num2 = 49
								Dim enumerator7 As IEnumerator = treeNode8.Nodes.GetEnumerator()
								While enumerator7.MoveNext()
									Dim obj7 As Object = enumerator7.Current
									Dim treeNode9 As TreeNode = CType(obj7, TreeNode)
									IL_3A0:
									num2 = 50
									If Operators.CompareString(treeNode9.Name, text, True) = 0 Then
										IL_3B4:
										num2 = 51
										treeNode7 = treeNode9
										IL_3BB:
										num2 = 52
										treeNode9.Checked = True
										Exit While
									End If
									IL_3C8:
									num2 = 54
								End While
								IL_3D4:
								num2 = 55
								If TypeOf enumerator7 Is IDisposable Then
									TryCast(enumerator7, IDisposable).Dispose()
								End If
								IL_3EC:
								num2 = 56
								If treeNode7 IsNot Nothing Then
									Exit While
								End If
								IL_3F3:
								num2 = 58
							End While
							IL_402:
							num2 = 59
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End If
					End If
					IL_41A:
					num2 = 60
				Next
				IL_42E:
				num2 = 61
				Me.o.O0_ooo0..oo_.000o. = True
				IL_43D:
				GoTo IL_587
				IL_442:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_548:
				GoTo IL_57C
				IL_54A:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_55A:
			Catch obj9 When endfilter(TypeOf obj8 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj9, Exception)
				GoTo IL_54A
			End Try
			IL_57C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_587:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001C7B RID: 7291 RVA: 0x000B59E8 File Offset: 0x000B3BE8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As JoinTableProperty = New JoinTableProperty()
			If Me.oo_.000o.(a_) Then
				Dim value As String = "{" + o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbVerticalTab, False) + "}"
				Dim dataTable As DataTable = New DataTable()
				Dim text As String = Oo00.OO.0O0o.(a_)
				Dim httpClient As HttpClient = Nothing
				If Me.O_O_.oo. IsNot Nothing Then
					text = Oo00.o0_o._O_.(Me.O_O_.oo., text, False)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, Me.O_O_.oo.)
					Try
						oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
						If dataTable.Columns.Count = 0 Then
							MessageBox.Show("语句执行后没有返回数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
						GoTo IL_100
					Catch a_2 As Exception
						ooO.oOo0Oo.o.(a_2, "")
						Return
					End Try
				End If
				text = Oo00.o0_o._O_.(Me.o.O0_ooo0..OO.OoO0., text, False)
				dataTable = Me.o.O0_ooo0..O_0_O_0_o_.0.(text, True)
				httpClient = Me.o.O0_ooo0..oO0_0.o.()
				httpClient.[Select] = text
				httpClient.FormData("Action") = 2.ToString()
				IL_100:
				If Me.o.O0_ooo0..RowState = DataRowState.Detached Then
					Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "")
					o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
					If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
						Dim text2 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
						Dim text3 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
						Me.o.O0_ooo0.("Name") = text2
						If Me.o_O.o_0O.().SelectedIndex > 0 Then
							Me.o.O0_ooo0.("DataSource") = Me.o_O.o_0O.().Text
						End If
						Me.o.O0_ooo0.("Property") = value
						O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Add(Me.o.O0_ooo0.)
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
						o0OoOOoOOo0.OOOOO.o000.(Me.O_O_.oo., text, text2, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, Me.o_O.o_0O.().Text, httpClient)
						OO_00oOO.DataTables(text2).o.0O000_.()
						OO_00oOO.DataTables(text2).Caption = text3
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text2))
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(Me.o.O0_ooo0.("Name")), True, False)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
						If Operators.CompareString(text3, "", True) > 0 OrElse O_O0OO.O0_00o.o0__o..DevelopByCreater Then
							OO_00oOO.DataTables(text2).Developer = OO_00oOO.User.Name
							OO_00oOO.DataTables(text2).OO00_o.ooOO.(False)
						End If
						O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
					End If
				Else
					Dim text4 As String = Conversions.ToString(Me.o.O0_ooo0.("Name"))
					If Me.o_O.o_0O.().SelectedIndex = 0 Then
						Me.o.O0_ooo0.("DataSource") = DBNull.Value
					Else
						Me.o.O0_ooo0.("DataSource") = Me.o_O.o_0O.().Text
					End If
					Me.o.O0_ooo0.("Property") = value
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					If OO_00oOO.DataTables.Contains(text4) Then
						Oo00.o00O0O_.O.(Me.o.O0_ooo0., OO_00oOO.Tables(text4))
					Else
						o0OoOOoOOo0.OOOOO.o000.(Me.O_O_.oo., text, text4, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, Me.o_O.o_0O.().Text, httpClient)
						OO_00oOO.DataTables(text4).o.0O000_.()
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text4))
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(Me.o.O0_ooo0.("Name")), True, True)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
					End If
				End If
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x06001C7C RID: 7292 RVA: 0x000B5E4C File Offset: 0x000B404C
		Private Function <<EMPTY_NAME>>(A_0 As JoinTableProperty) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1FlexGrid As C1FlexGrid = Me.OO0o0OO_.o.()
				IL_11:
				num2 = 3
				If Operators.CompareString(c1FlexGrid.GetDataDisplay(1, 0), "", True) <= 0 Then
					GoTo IL_3D
				End If
				IL_2A:
				num2 = 4
				A_0.BaseTable = c1FlexGrid.GetDataDisplay(1, 0)
				IL_53:
				num2 = 8
				Dim text As String = ""
				IL_5C:
				num2 = 9
				Dim fixed As Integer = c1FlexGrid.Rows.Fixed
				Dim num3 As Integer = c1FlexGrid.Rows.Count - 1
				For i As Integer = fixed To num3
					IL_82:
					num2 = 10
					If Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 0), "", True) > 0 AndAlso Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 1), "", True) > 0 AndAlso Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 2), "", True) > 0 AndAlso Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 3), "", True) > 0 Then
						IL_F1:
						num2 = 11
						Dim joinModeEnum As JoinModeEnum = 0
						IL_F7:
						num2 = 12
						text = String.Concat(New String() { text, c1FlexGrid.GetDataDisplay(i, 0), vbTab, c1FlexGrid.GetDataDisplay(i, 1), vbTab, c1FlexGrid.GetDataDisplay(i, 2), vbTab, c1FlexGrid.GetDataDisplay(i, 3), vbTab })
						IL_161:
						num2 = 13
						Dim dataDisplay As String = c1FlexGrid.GetDataDisplay(i, 4)
						IL_170:
						num2 = 15
						If Operators.CompareString(dataDisplay, "左连接", True) = 0 Then
							IL_182:
							num2 = 16
							joinModeEnum = 1
						Else
							IL_18A:
							num2 = 18
							If Operators.CompareString(dataDisplay, "右连接", True) = 0 Then
								IL_19C:
								num2 = 19
								joinModeEnum = 2
							End If
						End If
						IL_1A2:
						num2 = 20
						text = text + [Enum].GetName(GetType(JoinModeEnum), joinModeEnum) + vbLf
					End If
					IL_1C9:
					num2 = 21
				Next
				IL_1DB:
				num2 = 22
				A_0.LinkTables = text.Trim(New Char() { vbLf })
				IL_1F6:
				c1FlexGrid = Nothing
				IL_1F9:
				num2 = 24
				Dim c1FlexGrid2 As C1FlexGrid = Me.o_0.o.()
				IL_204:
				num2 = 25
				Dim text2 As String = ""
				IL_20E:
				num2 = 26
				If Operators.CompareString(c1FlexGrid2.GetDataDisplay(1, 0), "", True) <> 0 Then
					GoTo IL_23F
				End If
				IL_227:
				num2 = 27
				MessageBox.Show("至少要指定一列！")
				IL_235:
				num2 = 28
				result = False
				GoTo IL_39C
				IL_23F:
				num2 = 29
				Dim fixed2 As Integer = c1FlexGrid2.Rows.Fixed
				Dim num4 As Integer = c1FlexGrid2.Rows.Count - 1
				For j As Integer = fixed2 To num4
					IL_265:
					num2 = 30
					If Operators.CompareString(c1FlexGrid2.GetDataDisplay(j, 0), "", True) > 0 Then
						IL_283:
						num2 = 31
						Operators.CompareString(c1FlexGrid2.GetDataDisplay(j, 1), "", True)
						IL_29E:
						num2 = 32
						text2 = text2 + c1FlexGrid2.GetDataDisplay(j, 0) + vbTab + c1FlexGrid2.GetDataDisplay(j, 1)
						IL_2C3:
						num2 = 33
						If c1FlexGrid2.GetCellCheck(j, 2) = 1 Then
							IL_2D3:
							num2 = 34
							text2 += vbTab & "1"
						Else
							IL_2E6:
							num2 = 36
							text2 += vbTab & "0"
						End If
						IL_2F7:
						num2 = 37
						text2 += vbLf
					End If
					IL_308:
					num2 = 38
				Next
				IL_31A:
				num2 = 39
				A_0.Columns = text2.Trim(New Char() { vbLf })
				IL_335:
				c1FlexGrid2 = Nothing
				IL_338:
				num2 = 41
				A_0.Filter = Me.OO0o0OO_.o.().Text.Trim()
				IL_351:
				num2 = 42
				A_0.Order = Me.oooO00O.0_.().Text.Trim()
				IL_36A:
				num2 = 43
				A_0.Top = Me.o.0___0O_Oo__.().Text.Trim()
				IL_383:
				num2 = 44
				A_0.Distinct = Me.o_0.o.().Checked
				IL_397:
				num2 = 45
				result = True
				GoTo IL_39C
				IL_3D:
				num2 = 6
				MessageBox.Show("至少要指定一个表！")
				IL_4A:
				num2 = 7
				result = False
				IL_39C:
				GoTo IL_4A6
				IL_3A1:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_467:
				GoTo IL_49B
				IL_469:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_479:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_469
			End Try
			IL_49B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4A6:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06001C7D RID: 7293 RVA: 0x000B6324 File Offset: 0x000B4524
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As JoinTableProperty = New JoinTableProperty()
			If Me.oo_.000o.(a_) Then
				Dim a_2 As String = Oo00.OO.0O0o.(a_)
				New O_\u30000_\u3002O\u3002\u3002\u3000\u3000(Me.O_O_.oo., a_2, Me.o.O0_ooo0.).ShowDialog()
			End If
		End Sub

		' Token: 0x06001C7E RID: 7294 RVA: 0x000B6360 File Offset: 0x000B4560
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
			If A_1.Control Then
				If A_1.KeyCode = Keys.D Then
					If c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2 Then
						c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row + 1)
						Return
					End If
				ElseIf A_1.KeyCode = Keys.U AndAlso c1FlexGrid.Row < c1FlexGrid.Rows.Count - 1 AndAlso c1FlexGrid.Row > 1 Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row - 1)
				End If
			End If
		End Sub

		' Token: 0x06001C7F RID: 7295 RVA: 0x000B6403 File Offset: 0x000B4603
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001C80 RID: 7296 RVA: 0x000B640B File Offset: 0x000B460B
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000C07 RID: 3079
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C08 RID: 3080
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000C09 RID: 3081
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C0A RID: 3082
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000C0B RID: 3083
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000C0C RID: 3084
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000C0D RID: 3085
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C0E RID: 3086
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000C0F RID: 3087
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000C10 RID: 3088
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000C11 RID: 3089
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C12 RID: 3090
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000C13 RID: 3091
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000C14 RID: 3092
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C15 RID: 3093
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000C16 RID: 3094
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000C17 RID: 3095
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C18 RID: 3096
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04000C19 RID: 3097
		Private <<EMPTY_NAME>> As O0O

		' Token: 0x04000C1A RID: 3098
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04000C1B RID: 3099
		Private <<EMPTY_NAME>> As O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000

		' Token: 0x04000C1C RID: 3100
		Private <<EMPTY_NAME>> As Dictionary(Of String, List(Of String))
	End Class
End Namespace
