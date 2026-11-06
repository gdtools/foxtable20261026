Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000372 RID: 882
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002
		Inherits Form

		' Token: 0x060037B9 RID: 14265 RVA: 0x0017B9C3 File Offset: 0x00179BC3
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.O_oOO.0o__O0. IsNot Nothing Then
				Me.O_oOO.0o__O0..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x060037BA RID: 14266 RVA: 0x0017B9E4 File Offset: 0x00179BE4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.0_ooooo0.(New C1Button())
			Me.O.oo_.(New C1Button())
			Me.OoOO_o.__O_0.(New oo0_o0o_0o__())
			Me.o.0o_Oo_oOo0.(New C1Button())
			Me.OoOO_o.__O_0.(New C1Button())
			Me.OOo.0o.(New C1Button())
			Me.OoOO_o.__O_0.(New Label())
			Me.OoOO_o.__O_0.(New C1ComboBox())
			MyBase.SuspendLayout()
			Me.oooOo0OO0.o0_0.().Location = New Point(411, 400)
			Me.oooOo0OO0.o0_0.().Name = "Button1"
			Me.oooOo0OO0.o0_0.().Size = New Size(75, 23)
			Me.oooOo0OO0.o0_0.().TabIndex = 5
			Me.oooOo0OO0.o0_0.().Text = "确定"
			Me.oooOo0OO0.o0_0.().UseVisualStyleBackColor = True
			Me.ooO__o_O_O.o_.().DialogResult = DialogResult.Cancel
			Me.ooO__o_O_O.o_.().Location = New Point(492, 400)
			Me.ooO__o_O_O.o_.().Name = "Button2"
			Me.ooO__o_O_O.o_.().Size = New Size(75, 23)
			Me.ooO__o_O_O.o_.().TabIndex = 6
			Me.ooO__o_O_O.o_.().Text = "取消"
			Me.ooO__o_O_O.o_.().UseVisualStyleBackColor = True
			Me.OoOO_o.__O_0.().Location = New Point(15, 41)
			Me.OoOO_o.__O_0.().Name = "StructureEditor1"
			Me.OoOO_o.__O_0.().Size = New Size(552, 337)
			Me.OoOO_o.__O_0.().TabIndex = 1
			Me.O__.o0.().Location = New Point(15, 400)
			Me.O__.o0.().Name = "btnMoveUp"
			Me.O__.o0.().Size = New Size(75, 23)
			Me.O__.o0.().TabIndex = 2
			Me.O__.o0.().Text = "上移行"
			Me.O__.o0.().UseVisualStyleBackColor = True
			Me.OO0000.o.().Location = New Point(97, 400)
			Me.OO0000.o.().Name = "btnMoveDown"
			Me.OO0000.o.().Size = New Size(75, 23)
			Me.OO0000.o.().TabIndex = 3
			Me.OO0000.o.().Text = "下移行"
			Me.OO0000.o.().UseVisualStyleBackColor = True
			Me.o__._.().Location = New Point(179, 400)
			Me.o__._.().Name = "btnDelete"
			Me.o__._.().Size = New Size(75, 23)
			Me.o__._.().TabIndex = 4
			Me.o__._.().Text = "删除行"
			Me.o__._.().UseVisualStyleBackColor = True
			Me.ooO__o_O_O.o_.().AutoSize = True
			Me.ooO__o_O_O.o_.().Location = New Point(15, 13)
			Me.ooO__o_O_O.o_.().Name = "Label1"
			Me.ooO__o_O_O.o_.().Size = New Size(71, 12)
			Me.ooO__o_O_O.o_.().TabIndex = 6
			Me.ooO__o_O_O.o_.().Text = "选择数据源:"
			Me.ooO__o_O_O.o_.().DropDownStyle = 1
			Me.ooO__o_O_O.o_.().Location = New Point(97, 10)
			Me.ooO__o_O_O.o_.().Name = "cmbDatasource"
			Me.ooO__o_O_O.o_.().Size = New Size(201, 20)
			Me.ooO__o_O_O.o_.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(583, 435)
			MyBase.Controls.Add(Me.ooO__o_O_O.o_.())
			MyBase.Controls.Add(Me.ooO__o_O_O.o_.())
			MyBase.Controls.Add(Me.o__._.())
			MyBase.Controls.Add(Me.OO0000.o.())
			MyBase.Controls.Add(Me.O__.o0.())
			MyBase.Controls.Add(Me.OoOO_o.__O_0.())
			MyBase.Controls.Add(Me.ooO__o_O_O.o_.())
			MyBase.Controls.Add(Me.oooOo0OO0.o0_0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "ooo.O.O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "增加表"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060037BB RID: 14267 RVA: 0x0017BE56 File Offset: 0x0017A056
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_oOO.0o__O0.
		End Function

		' Token: 0x060037BC RID: 14268 RVA: 0x0017BE60 File Offset: 0x0017A060
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0O_.oOO_.
			Dim o_oOO.0o__O0. As C1Button = Me.O_oOO.0o__O0.
			If o_oOO.0o__O0. IsNot Nothing Then
				RemoveHandler o_oOO.0o__O0..Click, value
			End If
			Me.O_oOO.0o__O0. = A_0
			o_oOO.0o__O0. = Me.O_oOO.0o__O0.
			If o_oOO.0o__O0. IsNot Nothing Then
				AddHandler o_oOO.0o__O0..Click, value
			End If
		End Sub

		' Token: 0x060037BD RID: 14269 RVA: 0x0017BEA3 File Offset: 0x0017A0A3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOoo.O00oo0.
		End Function

		' Token: 0x060037BE RID: 14270 RVA: 0x0017BEAB File Offset: 0x0017A0AB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oOoo.O00oo0. = A_0
		End Sub

		' Token: 0x060037BF RID: 14271 RVA: 0x0017BEB4 File Offset: 0x0017A0B4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oo0_o0o_0o__
			Return Me.O_oOO.0o__O0.
		End Function

		' Token: 0x060037C0 RID: 14272 RVA: 0x0017BEBC File Offset: 0x0017A0BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oo0_o0o_0o__)
			Me.O_oOO.0o__O0. = A_0
		End Sub

		' Token: 0x060037C1 RID: 14273 RVA: 0x0017BEC5 File Offset: 0x0017A0C5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_O0o0.Oo00.
		End Function

		' Token: 0x060037C2 RID: 14274 RVA: 0x0017BED0 File Offset: 0x0017A0D0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0o.o_.
			Dim o_O0o0.Oo00. As C1Button = Me.O_O0o0.Oo00.
			If o_O0o0.Oo00. IsNot Nothing Then
				RemoveHandler o_O0o0.Oo00..Click, value
			End If
			Me.O_O0o0.Oo00. = A_0
			o_O0o0.Oo00. = Me.O_O0o0.Oo00.
			If o_O0o0.Oo00. IsNot Nothing Then
				AddHandler o_O0o0.Oo00..Click, value
			End If
		End Sub

		' Token: 0x060037C3 RID: 14275 RVA: 0x0017BF13 File Offset: 0x0017A113
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o_0.
		End Function

		' Token: 0x060037C4 RID: 14276 RVA: 0x0017BF1C File Offset: 0x0017A11C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_O_Oo._OO00o.
			Dim c1Button As C1Button = Me.o.o_0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.o_0. = A_0
			c1Button = Me.o.o_0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060037C5 RID: 14277 RVA: 0x0017BF5F File Offset: 0x0017A15F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo0O0_ooo.O.
		End Function

		' Token: 0x060037C6 RID: 14278 RVA: 0x0017BF68 File Offset: 0x0017A168
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0O.o0.
			Dim c1Button As C1Button = Me.oo0O0_ooo.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo0O0_ooo.O. = A_0
			c1Button = Me.oo0O0_ooo.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060037C7 RID: 14279 RVA: 0x0017BFAB File Offset: 0x0017A1AB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.O_oOO.0o__O0.
		End Function

		' Token: 0x060037C8 RID: 14280 RVA: 0x0017BFB3 File Offset: 0x0017A1B3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_oOO.0o__O0. = A_0
		End Sub

		' Token: 0x060037C9 RID: 14281 RVA: 0x0017BFBC File Offset: 0x0017A1BC
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O_oOO.0o__O0.
		End Function

		' Token: 0x060037CA RID: 14282 RVA: 0x0017BFC4 File Offset: 0x0017A1C4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O_.O0.
			Dim o_oOO.0o__O0. As C1ComboBox = Me.O_oOO.0o__O0.
			If o_oOO.0o__O0. IsNot Nothing Then
				o_oOO.0o__O0..SelectedIndexChanged -= eventHandler
			End If
			Me.O_oOO.0o__O0. = A_0
			o_oOO.0o__O0. = Me.O_oOO.0o__O0.
			If o_oOO.0o__O0. IsNot Nothing Then
				o_oOO.0o__O0..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x060037CB RID: 14283 RVA: 0x0017C008 File Offset: 0x0017A208
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oooOo0OO0.o0_0.
			AddHandler MyBase.FormClosed, AddressOf Me.ooO__o_O_O.o_.
			Me.OoOO_o.__O_0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060037CC RID: 14284 RVA: 0x0017C05C File Offset: 0x0017A25C
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
				Dim text As String = ""
				IL_0F:
				num2 = 3
				If Me.OoOO_o.__O_0.().O_oo.0oOO..Rows.Count <> 0 Then
					GoTo IL_36
				End If
				IL_28:
				num2 = 4
				MyBase.DialogResult = DialogResult.OK
				GoTo IL_6A3
				IL_36:
				num2 = 6
				Dim enumerator As IEnumerator = Me.OoOO_o.__O_0.().O_oo.0oOO..Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_5F:
					num2 = 7
					If dataRow.IsNull("列名") OrElse Operators.CompareString(Conversions.ToString(dataRow("列名")), "", True) = 0 Then
						IL_8D:
						num2 = 8
						MessageBox.Show("请输入列名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						GoTo IL_6A3
					End If
					IL_A7:
					num2 = 10
				End While
				IL_B3:
				num2 = 11
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_CB:
				num2 = 12
				Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "")
				IL_DF:
				num2 = 13
				o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
				IL_EA:
				num2 = 14
				If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() <> DialogResult.OK Then
					GoTo IL_6A3
				End If
				IL_FA:
				num2 = 15
				text = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
				IL_105:
				num2 = 16
				Dim text2 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
				IL_111:
				num2 = 19
				If Not Me.O_oOO.0o__O0. Then
					GoTo IL_3FF
				End If
				IL_11F:
				num2 = 20
				For Each dataRow2 As DataRow In Me.OoOO_o.__O_0.().O_oo.0oOO..[Select]("", "ID", DataViewRowState.CurrentRows)
					IL_14F:
					num2 = 21
					Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.())
					IL_168:
					num2 = 22
					Dim dataRow3 As DataRow = dataTable.NewRow()
					IL_174:
					num2 = 23
					dataRow3("Table") = text
					IL_184:
					num2 = 24
					dataRow3("Column") = RuntimeHelpers.GetObjectValue(dataRow2("列名"))
					IL_1A4:
					num2 = 25
					dataRow3("DataType") = CType(Conversions.ToInteger(dataRow2("类型")), ColumnDataTypeEnum)
					IL_1C9:
					num2 = 26
					If Not dataRow2.IsNull("长度") Then
						IL_1DA:
						num2 = 27
						dataRow3("MaxLength") = Conversions.ToInteger(dataRow2("长度"))
					End If
					IL_1FF:
					num2 = 28
					dataRow3("Expression") = ""
					IL_213:
					num2 = 29
					If Not dataRow2.IsNull("标题") Then
						IL_227:
						num2 = 30
						Dim dataRow4 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { text, dataRow2("列名") })
						IL_263:
						num2 = 31
						If dataRow4 Is Nothing Then
							IL_26A:
							num2 = 32
							dataRow4 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).NewRow()
							IL_288:
							num2 = 33
							dataRow4("Table") = text
							IL_298:
							num2 = 34
							dataRow4("Column") = RuntimeHelpers.GetObjectValue(dataRow2("列名"))
							IL_2B8:
							num2 = 35
							O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Add(dataRow4)
						End If
						IL_2DB:
						num2 = 36
						dataRow4("Config") = "Caption" & vbVerticalTab + Conversions.ToString(dataRow2("标题"))
					End If
					IL_305:
					num2 = 37
					dataTable.Rows.Add(dataRow3)
					IL_316:
					dataTable = Nothing
					IL_319:
					num2 = 39
				Next
				IL_32D:
				num2 = 40
				Dim dataTable2 As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.())
				IL_346:
				num2 = 41
				Dim dataRow5 As DataRow = dataTable2.NewRow()
				IL_352:
				num2 = 42
				dataRow5("Name") = text
				IL_362:
				num2 = 43
				dataTable2.Rows.Add(dataRow5)
				IL_373:
				num2 = 44
				o0OoOOoOOo0.OOOOO.o000.(dataRow5, O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, True)
				IL_38D:
				num2 = 45
				OO_00oOO.DataTables(text).o.0O000_.()
				IL_3A0:
				dataTable2 = Nothing
				IL_3A3:
				num2 = 47
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
				IL_3C0:
				num2 = 48
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o_0_000._O.()), True)
				IL_3DD:
				num2 = 49
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				GoTo IL_5D5
				IL_3FF:
				num2 = 51
				If Me.ooO__o_O_O.o_.().SelectedIndex <> 0 Then
					GoTo IL_422
				End If
				IL_40F:
				num2 = 52
				Dim o_oo As o_oo0 = New o_oo0(O_O0OO.OoO.0OO__0ooo.(), False, True)
				GoTo IL_455
				IL_422:
				num2 = 54
				Dim a_ As OleDbConnection = O_O0OO.O._o_.()(Me.ooO__o_O_O.o_.().SelectedItem.ToString())
				IL_441:
				num2 = 55
				o_oo = New o_oo0(a_, o_O_o_oOoo__.OOOO_OO._oo.(a_), False)
				IL_455:
				num2 = 56
				If Not Oo00.OO.0O0o.(o_oo, Me.OoOO_o.__O_0.().O_oo.0oOO., text, "") Then
					GoTo IL_6A3
				End If
				IL_475:
				num2 = 58
				o_oo.o0_oo0._.(True, False)
				IL_482:
				num2 = 59
				If Me.ooO__o_O_O.o_.().SelectedIndex <> 0 Then
					GoTo IL_4CA
				End If
				IL_492:
				num2 = 60
				o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text, True, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), False)
				GoTo IL_5C2
				IL_4CA:
				num2 = 62
				Dim dataRow6 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).NewRow()
				IL_4E8:
				num2 = 63
				dataRow6("Type") = 0
				IL_4FD:
				num2 = 64
				dataRow6("Name") = text
				IL_50D:
				num2 = 65
				Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
				IL_517:
				num2 = 66
				outerTableSetting.SourceTable = text
				IL_522:
				num2 = 67
				dataRow6("DataSource") = Me.ooO__o_O_O.o_.().SelectedItem.ToString()
				IL_541:
				num2 = 68
				dataRow6("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
				IL_55B:
				num2 = 69
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Add(dataRow6)
				IL_57E:
				num2 = 70
				Oo00.O0Oo_O.0O_0O.(dataRow6)
				IL_588:
				num2 = 71
				o0OoOOoOOo0.OOOOO.o000.(dataRow6, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), True, False, Nothing)
				IL_5C2:
				num2 = 72
				OO_00oOO.DataTables(text).o.0O000_.()
				IL_5D5:
				num2 = 73
				OO_00oOO.DataTables(text).Caption = text2
				IL_5EA:
				num2 = 74
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text))
				IL_602:
				num2 = 75
				Main.OO_O.o..o0_o_o_0.0O.(text, True, False)
				IL_612:
				num2 = 76
				Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
				IL_63A:
				num2 = 77
				If Operators.CompareString(text2, "", True) <= 0 AndAlso Not O_O0OO.O0_00o.o0__o..DevelopByCreater Then
					GoTo IL_68A
				End If
				IL_659:
				num2 = 78
				OO_00oOO.DataTables(text).Developer = OO_00oOO.User.Name
				IL_676:
				num2 = 79
				OO_00oOO.DataTables(text).OO00_o.ooOO.(False)
				IL_68A:
				num2 = 80
				O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				IL_699:
				num2 = 81
				MyBase.DialogResult = DialogResult.OK
				IL_6A3:
				GoTo IL_83D
				IL_6A8:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_7FE:
				GoTo IL_832
				IL_800:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_810:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_800
			End Try
			IL_832:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_83D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060037CD RID: 14285 RVA: 0x0017C8CC File Offset: 0x0017AACC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O_oOO.0o__O0. Then
				Me.OoOO_o.__O_0.().O_oo.0oOO. = False
			Else
				Me.OoOO_o.__O_0.().O_oo.0oOO. = True
			End If
			Me.OoOO_o.__O_0.().o00_0O0.0O_.()
			Oo00.o_o_oo.0o.(Me.OoOO_o.__O_0.().O_oo.0oOO.)
			Me.ooO__o_O_O.o_.().Items.Add("内部数据源")
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.())
			Try
				For Each obj As Object In dataTable.Rows
					Dim text As String = CType(obj, DataRow)("Name").ToString()
					If O_O0OO.O._o_.().ContainsKey(text) AndAlso (OO_00oOO.Connections(text).SourceType = 1 OrElse OO_00oOO.Connections(text).SourceType = 2) Then
						Me.ooO__o_O_O.o_.().Items.Add(text)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ooO__o_O_O.o_.().SelectedIndex = 0
		End Sub

		' Token: 0x060037CE RID: 14286 RVA: 0x0017C9EC File Offset: 0x0017ABEC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OoOO_o.__O_0.().OoO_Oo._o.()
		End Sub

		' Token: 0x060037CF RID: 14287 RVA: 0x0017C9F9 File Offset: 0x0017ABF9
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OoOO_o.__O_0.().O_._O0Oo_o.()
		End Sub

		' Token: 0x060037D0 RID: 14288 RVA: 0x0017CA06 File Offset: 0x0017AC06
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OoOO_o.__O_0.().O0o.OOoo.()
		End Sub

		' Token: 0x060037D1 RID: 14289 RVA: 0x0017CA14 File Offset: 0x0017AC14
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.ooO__o_O_O.o_.().SelectedIndex = 0 Then
				Me.OoOO_o.__O_0.().O_oo.0oOO. = True
			Else
				Dim a_ As OleDbConnection = O_O0OO.O._o_.()(Me.ooO__o_O_O.o_.().SelectedItem.ToString())
				Me.OoOO_o.__O_0.().O_oo.0oOO. = Not o_O_o_oOoo__.OOOO_OO._oo.(a_)
			End If
			Me.OoOO_o.__O_0.().O_0Oo_._00oo0.()
		End Sub

		' Token: 0x060037D2 RID: 14290 RVA: 0x0017CA76 File Offset: 0x0017AC76
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040016FA RID: 5882
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040016FB RID: 5883
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016FC RID: 5884
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016FD RID: 5885
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oo0_o0o_0o__

		' Token: 0x040016FE RID: 5886
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016FF RID: 5887
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001700 RID: 5888
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001701 RID: 5889
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001702 RID: 5890
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001703 RID: 5891
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
