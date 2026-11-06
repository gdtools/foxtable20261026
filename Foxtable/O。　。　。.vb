Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200034A RID: 842
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3002\u3000\u3002\u3000\u3000
		Inherits Form

		' Token: 0x0600335C RID: 13148 RVA: 0x001512D4 File Offset: 0x0014F4D4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_O0_OO0.0__. IsNot Nothing Then
					Me.O_O0_OO0.0__..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600335D RID: 13149 RVA: 0x00151314 File Offset: 0x0014F514
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O0oOOO0OO000.O.(New C1Button())
			Me.Oo0_.o_o0oo00O.(New C1Button())
			Me.o0_OOOOo_oo.__.(New Label())
			Me.o0_OOOOo_oo.__.(New C1DateEdit())
			Me.o0_OOOOo_oo.__.(New C1ComboBox())
			Me.Oo0_.o_o0oo00O.().BeginInit()
			MyBase.SuspendLayout()
			Me.Oo0_.o_o0oo00O.().DialogResult = DialogResult.Cancel
			Me.Oo0_.o_o0oo00O.().Location = New Point(240, 121)
			Me.Oo0_.o_o0oo00O.().Margin = New Padding(4, 5, 4, 5)
			Me.Oo0_.o_o0oo00O.().Name = "Button2"
			Me.Oo0_.o_o0oo00O.().Size = New Size(112, 35)
			Me.Oo0_.o_o0oo00O.().TabIndex = 2
			Me.Oo0_.o_o0oo00O.().Text = "取消"
			Me.Oo0_.o_o0oo00O.().UseVisualStyleBackColor = True
			Me.o_OOO0.0O.().Location = New Point(102, 121)
			Me.o_OOO0.0O.().Margin = New Padding(4, 5, 4, 5)
			Me.o_OOO0.0O.().Name = "Button1"
			Me.o_OOO0.0O.().Size = New Size(112, 35)
			Me.o_OOO0.0O.().TabIndex = 1
			Me.o_OOO0.0O.().Text = "确定"
			Me.o_OOO0.0O.().UseVisualStyleBackColor = True
			Me.Oo0_.o_o0oo00O.().AutoSize = True
			Me.Oo0_.o_o0oo00O.().Location = New Point(19, 18)
			Me.Oo0_.o_o0oo00O.().Margin = New Padding(4, 0, 4, 0)
			Me.Oo0_.o_o0oo00O.().Name = "Label1"
			Me.Oo0_.o_o0oo00O.().Size = New Size(62, 18)
			Me.Oo0_.o_o0oo00O.().TabIndex = 9
			Me.Oo0_.o_o0oo00O.().Text = "Label1"
			Me.Oo0_.o_o0oo00O.().AllowSpinLoop = False
			Me.Oo0_.o_o0oo00O.().BorderStyle = BorderStyle.FixedSingle
			Me.Oo0_.o_o0oo00O.().Calendar.Font = New Font("Tahoma", 8F)
			Me.Oo0_.o_o0oo00O.().Calendar.VisualStyle = 4
			Me.Oo0_.o_o0oo00O.().Calendar.VisualStyleBaseStyle = 4
			Me.Oo0_.o_o0oo00O.().DateTimeInput = False
			Me.Oo0_.o_o0oo00O.().EmptyAsNull = True
			Me.Oo0_.o_o0oo00O.().Font = New Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.Oo0_.o_o0oo00O.().FormatType = 2
			Me.Oo0_.o_o0oo00O.().ImagePadding = New Padding(0)
			Me.Oo0_.o_o0oo00O.().Location = New Point(166, 59)
			Me.Oo0_.o_o0oo00O.().Margin = New Padding(4, 5, 4, 5)
			Me.Oo0_.o_o0oo00O.().MaskInfo.ShowLiterals = 3
			Me.Oo0_.o_o0oo00O.().Name = "C1DateEdit1"
			Me.Oo0_.o_o0oo00O.().Size = New Size(266, 28)
			Me.Oo0_.o_o0oo00O.().TabIndex = 0
			Me.Oo0_.o_o0oo00O.().Tag = Nothing
			Me.Oo0_.o_o0oo00O.().VisibleButtons = 2
			Me.Oo0_.o_o0oo00O.().VisualStyle = 4
			Me.Oo0_.o_o0oo00O.().VisualStyleBaseStyle = 4
			Me.Oo0_.o_o0oo00O.().Location = New Point(22, 60)
			Me.Oo0_.o_o0oo00O.().Margin = New Padding(3, 4, 3, 4)
			Me.Oo0_.o_o0oo00O.().Name = "ComboBox1"
			Me.Oo0_.o_o0oo00O.().Size = New Size(136, 26)
			Me.Oo0_.o_o0oo00O.().TabIndex = 10
			MyBase.AcceptButton = Me.o_OOO0.0O.()
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.Oo0_.o_o0oo00O.()
			MyBase.ClientSize = New Size(454, 175)
			MyBase.Controls.Add(Me.Oo0_.o_o0oo00O.())
			MyBase.Controls.Add(Me.Oo0_.o_o0oo00O.())
			MyBase.Controls.Add(Me.Oo0_.o_o0oo00O.())
			MyBase.Controls.Add(Me.o_OOO0.0O.())
			MyBase.Controls.Add(Me.Oo0_.o_o0oo00O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 5, 4, 5)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.o.o.l."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "日期筛选"
			Me.Oo0_.o_o0oo00O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600335E RID: 13150 RVA: 0x00151784 File Offset: 0x0014F984
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_OOOOo_oo.__.
		End Function

		' Token: 0x0600335F RID: 13151 RVA: 0x0015178C File Offset: 0x0014F98C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0_OOOOo_oo.__. = A_0
		End Sub

		' Token: 0x06003360 RID: 13152 RVA: 0x00151795 File Offset: 0x0014F995
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0oOOO0OO000.O.
		End Function

		' Token: 0x06003361 RID: 13153 RVA: 0x001517A0 File Offset: 0x0014F9A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo0__oO_o0O.Oo.
			Dim o0oOOO0OO000.O. As C1Button = Me.O0oOOO0OO000.O.
			If o0oOOO0OO000.O. IsNot Nothing Then
				RemoveHandler o0oOOO0OO000.O..Click, value
			End If
			Me.O0oOOO0OO000.O. = A_0
			o0oOOO0OO000.O. = Me.O0oOOO0OO000.O.
			If o0oOOO0OO000.O. IsNot Nothing Then
				AddHandler o0oOOO0OO000.O..Click, value
			End If
		End Sub

		' Token: 0x06003362 RID: 13154 RVA: 0x001517E3 File Offset: 0x0014F9E3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o0_OOOOo_oo.__.
		End Function

		' Token: 0x06003363 RID: 13155 RVA: 0x001517EB File Offset: 0x0014F9EB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0_OOOOo_oo.__. = A_0
		End Sub

		' Token: 0x06003364 RID: 13156 RVA: 0x001517F4 File Offset: 0x0014F9F4
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1DateEdit
			Return Me.o0_OOOOo_oo.__.
		End Function

		' Token: 0x06003365 RID: 13157 RVA: 0x001517FC File Offset: 0x0014F9FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DateEdit)
			Me.o0_OOOOo_oo.__. = A_0
		End Sub

		' Token: 0x06003366 RID: 13158 RVA: 0x00151805 File Offset: 0x0014FA05
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0_OOOOo_oo.__.
		End Function

		' Token: 0x06003367 RID: 13159 RVA: 0x00151810 File Offset: 0x0014FA10
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.Oo0_.o_o0oo00O.
			Dim c1ComboBox As C1ComboBox = Me.o0_OOOOo_oo.__.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o0_OOOOo_oo.__. = A_0
			c1ComboBox = Me.o0_OOOOo_oo.__.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06003368 RID: 13160 RVA: 0x00151854 File Offset: 0x0014FA54
		Public Sub New(A_0 As Table, A_1 As Col, A_2 As O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum)
			AddHandler MyBase.FormClosed, AddressOf Me.Oo0_.o_o0oo00O.
			Me.Oo0_.o_o0oo00O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O_O0_OO0.0__. = A_0
			Me.o0_OOOOo_oo.__. = A_1
			Me.O_O0_OO0.0__. = A_2
			Me.Oo0_.o_o0oo00O.().Text = A_1.Name + ":"
			Me.Oo0_.o_o0oo00O.().EditMask = A_0.foxGrid.Cols(A_1.Name).EditMask
			Me.Oo0_.o_o0oo00O.().CustomFormat = A_0.foxGrid.Cols(A_1.Name).Format
			If A_1.DataCol.DateTimeFormat IsNot Nothing Then
				Me.Oo0_.o_o0oo00O.().VisibleButtons = 0
			End If
			Me.Oo0_.o_o0oo00O.().Items.AddRange([Enum].GetNames(GetType(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum)))
			Me.Oo0_.o_o0oo00O.().MaxDropDownItems = Me.Oo0_.o_o0oo00O.().Items.Count
			Me.Oo0_.o_o0oo00O.().SelectedIndex = CInt(Me.O_O0_OO0.0__.)
		End Sub

		' Token: 0x06003369 RID: 13161 RVA: 0x00151974 File Offset: 0x0014FB74
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim flag As Boolean = Oo00.O____0O._0.(Me.O_O0_OO0.0__.)
				IL_15:
				num2 = 3
				If Not flag Then
					GoTo IL_36
				End If
				IL_1A:
				num2 = 4
				Dim text As String = Oo00.OoOo_oo_.o_o.(Me.o0_OOOOo_oo.__..Name, Me.O_O0_OO0.0__.)
				GoTo IL_54
				IL_36:
				num2 = 6
				text = "[" + Me.o0_OOOOo_oo.__..Name + "]"
				IL_54:
				num2 = 7
				If Me.Oo0_.o_o0oo00O.().Value IsNot DBNull.Value Then
					GoTo IL_AC
				End If
				IL_68:
				num2 = 8
				Dim o_O0_OO0.0__. As O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum = Me.O_O0_OO0.0__.
				If o_O0_OO0.0__. <> O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.等于 Then
					If o_O0_OO0.0__. <> O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不等于 Then
						GoTo IL_266
					End If
					IL_96:
					num2 = 12
					text += " Is Not Null"
					GoTo IL_24B
				End If
				IL_80:
				num2 = 10
				text += " Is Null"
				GoTo IL_24B
				IL_AC:
				num2 = 17
				Dim text2 As String = Strings.Format(Conversions.ToDate(Me.Oo0_.o_o0oo00O.().Value), "MM/dd/yyyy HH:mm:ss")
				IL_D0:
				num2 = 18
				If Not flag Then
					GoTo IL_163
				End If
				IL_D9:
				num2 = 19
				If Me.O_O0_OO0.0__..DataTable.SourceType <> 1 Then
					GoTo IL_107
				End If
				IL_EF:
				num2 = 20
				text2 = "#" + text2 + "#"
				GoTo IL_179
				IL_107:
				num2 = 22
				If Me.O_O0_OO0.0__..DataTable.SourceType <> 2 Then
					GoTo IL_135
				End If
				IL_11D:
				num2 = 23
				text2 = "'" + text2 + "'"
				GoTo IL_179
				IL_135:
				num2 = 25
				If Me.O_O0_OO0.0__..DataTable.SourceType <> 3 Then
					GoTo IL_179
				End If
				IL_14B:
				num2 = 26
				text2 = "TO_DATE('" + text2 + "', 'MM/DD/YYYY HH24:MI:SS')"
				GoTo IL_179
				IL_163:
				num2 = 28
				text2 = "#" + text2 + "#"
				IL_179:
				num2 = 29
				Select Case Me.O_O0_OO0.0__.
					Case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.等于
						IL_1A8:
						num2 = 31
						text = text + " = " + text2
					Case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.早于
						IL_223:
						num2 = 39
						text = text + " < " + text2
					Case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.晚于
						IL_1F9:
						num2 = 35
						text = text + " > " + text2
					Case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不等于
						IL_1C0:
						num2 = 33
						text = String.Concat(New String() { text, " <> ", text2, " Or ", text, "Is Null" })
					Case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不早于
						IL_238:
						num2 = 41
						text = text + " >= " + text2
					Case O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不晚于
						IL_20E:
						num2 = 37
						text = text + " <= " + text2
				End Select
				IL_24B:
				num2 = 43
				Filter.O0O0o.Oo0OO_oO.(Me.O_O0_OO0.0__., text, True)
				IL_25C:
				num2 = 44
				MyBase.DialogResult = DialogResult.OK
				IL_266:
				GoTo IL_36C
				IL_26B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_32D:
				GoTo IL_361
				IL_32F:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_33F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_32F
			End Try
			IL_361:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_36C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600336A RID: 13162 RVA: 0x00151D14 File Offset: 0x0014FF14
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_O0_OO0.0__. = CType(Me.Oo0_.o_o0oo00O.().SelectedIndex, O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum)
		End Sub

		' Token: 0x0600336B RID: 13163 RVA: 0x00151D27 File Offset: 0x0014FF27
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040014C3 RID: 5315
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040014C4 RID: 5316
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014C5 RID: 5317
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014C6 RID: 5318
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014C7 RID: 5319
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DateEdit

		' Token: 0x040014C8 RID: 5320
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040014C9 RID: 5321
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040014CA RID: 5322
		Private <<EMPTY_NAME>> As Col

		' Token: 0x040014CB RID: 5323
		Private <<EMPTY_NAME>> As O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum

		' Token: 0x0200034B RID: 843
		Friend Enum FilterModeEnum
			' Token: 0x040014CD RID: 5325
			等于
			' Token: 0x040014CE RID: 5326
			早于
			' Token: 0x040014CF RID: 5327
			晚于
			' Token: 0x040014D0 RID: 5328
			不等于
			' Token: 0x040014D1 RID: 5329
			不早于
			' Token: 0x040014D2 RID: 5330
			不晚于
		End Enum
	End Class
End Namespace
