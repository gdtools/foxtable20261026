Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200034E RID: 846
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002
		Inherits Form

		' Token: 0x060033BE RID: 13246 RVA: 0x00154330 File Offset: 0x00152530
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oo000.ooOOO___. IsNot Nothing Then
					Me.oo000.ooOOO___..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060033BF RID: 13247 RVA: 0x00154370 File Offset: 0x00152570
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oO0_oo0oo0oO.O.(New C1Button())
			Me.oOoOO0.OO0oO.(New C1Button())
			Me.oOoOO0.OO0oO.(New Label())
			Me.oOoOO0.OO0oO.(New C1NumericEdit())
			Me.oOoOO0.OO0oO.(New C1ComboBox())
			Me.o0.o_.().BeginInit()
			MyBase.SuspendLayout()
			Me.o0.o_.().DialogResult = DialogResult.Cancel
			Me.o0.o_.().Location = New Point(210, 121)
			Me.o0.o_.().Margin = New Padding(4, 5, 4, 5)
			Me.o0.o_.().Name = "Button2"
			Me.o0.o_.().Size = New Size(112, 35)
			Me.o0.o_.().TabIndex = 2
			Me.o0.o_.().Text = "取消"
			Me.o0.o_.().UseVisualStyleBackColor = True
			Me.O.o0o.().Location = New Point(73, 121)
			Me.O.o0o.().Margin = New Padding(4, 5, 4, 5)
			Me.O.o0o.().Name = "Button1"
			Me.O.o0o.().Size = New Size(112, 35)
			Me.O.o0o.().TabIndex = 1
			Me.O.o0o.().Text = "确定"
			Me.O.o0o.().UseVisualStyleBackColor = True
			Me.oOoOO0.OO0oO.().AutoSize = True
			Me.oOoOO0.OO0oO.().Location = New Point(19, 18)
			Me.oOoOO0.OO0oO.().Margin = New Padding(4, 0, 4, 0)
			Me.oOoOO0.OO0oO.().Name = "Label1"
			Me.oOoOO0.OO0oO.().Size = New Size(62, 18)
			Me.oOoOO0.OO0oO.().TabIndex = 4
			Me.oOoOO0.OO0oO.().Text = "Label1"
			Me.o0.o_.().BorderStyle = BorderStyle.FixedSingle
			Me.o0.o_.().Calculator.BackColor = Color.FromArgb(240, 241, 242)
			Me.o0.o_.().Calculator.VisualStyle = 4
			Me.o0.o_.().Calculator.VisualStyleBaseStyle = 4
			Me.o0.o_.().Font = New Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.o0.o_.().ImagePadding = New Padding(0)
			Me.o0.o_.().Location = New Point(165, 60)
			Me.o0.o_.().Margin = New Padding(4, 5, 4, 5)
			Me.o0.o_.().Name = "C1NumericEdit1"
			Me.o0.o_.().Size = New Size(212, 28)
			Me.o0.o_.().TabIndex = 0
			Me.o0.o_.().Tag = Nothing
			Me.o0.o_.().VisibleButtons = 2
			Me.o0.o_.().VisualStyle = 4
			Me.o0.o_.().VisualStyleBaseStyle = 4
			Me.oOoOO0.OO0oO.().DropDownStyle = 1
			Me.oOoOO0.OO0oO.().Location = New Point(22, 61)
			Me.oOoOO0.OO0oO.().Margin = New Padding(3, 4, 3, 4)
			Me.oOoOO0.OO0oO.().Name = "ComboBox1"
			Me.oOoOO0.OO0oO.().Size = New Size(134, 26)
			Me.oOoOO0.OO0oO.().TabIndex = 5
			MyBase.AcceptButton = Me.O.o0o.()
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.o0.o_.()
			MyBase.ClientSize = New Size(397, 175)
			MyBase.Controls.Add(Me.oOoOO0.OO0oO.())
			MyBase.Controls.Add(Me.o0.o_.())
			MyBase.Controls.Add(Me.o0.o_.())
			MyBase.Controls.Add(Me.O.o0o.())
			MyBase.Controls.Add(Me.oOoOO0.OO0oO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 5, 4, 5)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.1.o1O_."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "数值筛选"
			Me.o0.o_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060033C0 RID: 13248 RVA: 0x001547AE File Offset: 0x001529AE
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOoOO0.OO0oO.
		End Function

		' Token: 0x060033C1 RID: 13249 RVA: 0x001547B6 File Offset: 0x001529B6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oOoOO0.OO0oO. = A_0
		End Sub

		' Token: 0x060033C2 RID: 13250 RVA: 0x001547BF File Offset: 0x001529BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0_oo0oo0oO.O.
		End Function

		' Token: 0x060033C3 RID: 13251 RVA: 0x001547C8 File Offset: 0x001529C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.o0o.
			Dim c1Button As C1Button = Me.oO0_oo0oo0oO.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0_oo0oo0oO.O. = A_0
			c1Button = Me.oO0_oo0oo0oO.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060033C4 RID: 13252 RVA: 0x0015480B File Offset: 0x00152A0B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo000.ooOOO___.
		End Function

		' Token: 0x060033C5 RID: 13253 RVA: 0x00154813 File Offset: 0x00152A13
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo000.ooOOO___. = A_0
		End Sub

		' Token: 0x060033C6 RID: 13254 RVA: 0x0015481C File Offset: 0x00152A1C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.oo000.ooOOO___.
		End Function

		' Token: 0x060033C7 RID: 13255 RVA: 0x00154824 File Offset: 0x00152A24
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.oo000.ooOOO___. = A_0
		End Sub

		' Token: 0x060033C8 RID: 13256 RVA: 0x0015482D File Offset: 0x00152A2D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oo000.ooOOO___.
		End Function

		' Token: 0x060033C9 RID: 13257 RVA: 0x00154838 File Offset: 0x00152A38
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o0.o_.
			Dim c1ComboBox As C1ComboBox = Me.oo000.ooOOO___.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.oo000.ooOOO___. = A_0
			c1ComboBox = Me.oo000.ooOOO___.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x060033CA RID: 13258 RVA: 0x0015487C File Offset: 0x00152A7C
		Public Sub New(A_0 As Table, A_1 As Col, A_2 As O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum)
			AddHandler MyBase.FormClosed, AddressOf Me.o0.o_.
			Me.oOoOO0.OO0oO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oo000.ooOOO___. = A_0
			Me.oo000.ooOOO___. = A_1
			Me.oo000.ooOOO___. = A_2
			Me.oOoOO0.OO0oO.().Text = A_1.Name + ":"
			Me.o0.o_.().DataType = A_0.foxGrid.Cols(A_1.Name).DataType
			Me.oOoOO0.OO0oO.().Items.AddRange([Enum].GetNames(GetType(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum)))
			Me.oOoOO0.OO0oO.().MaxDropDownItems = Me.oOoOO0.OO0oO.().Items.Count
			Me.oOoOO0.OO0oO.().SelectedIndex = CInt(Me.oo000.ooOOO___.)
		End Sub

		' Token: 0x060033CB RID: 13259 RVA: 0x00154960 File Offset: 0x00152B60
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
				Dim flag As Boolean = Oo00.O____0O._0.(Me.oo000.ooOOO___.)
				IL_15:
				num2 = 3
				If Not flag Then
					GoTo IL_36
				End If
				IL_1A:
				num2 = 4
				Dim text As String = Oo00.OoOo_oo_.o_o.(Me.oo000.ooOOO___..Name, Me.oo000.ooOOO___.)
				GoTo IL_54
				IL_36:
				num2 = 6
				text = "[" + Me.oo000.ooOOO___..Name + "]"
				IL_54:
				num2 = 7
				If Me.o0.o_.().Value IsNot DBNull.Value Then
					GoTo IL_AC
				End If
				IL_68:
				num2 = 8
				Dim filterModeEnum As O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum = Me.oo000.ooOOO___.
				If filterModeEnum <> O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.等于 Then
					If filterModeEnum <> O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不等于 Then
						GoTo IL_1F0
					End If
					IL_96:
					num2 = 12
					text += " Is Not Null"
					GoTo IL_1D5
				End If
				IL_80:
				num2 = 10
				text += " Is Null"
				GoTo IL_1D5
				IL_AC:
				num2 = 17
				Select Case Me.oo000.ooOOO___.
					Case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.等于
						IL_DB:
						num2 = 19
						text = text + " = " + Me.o0.o_.().Value.ToString()
					Case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.大于
						IL_14B:
						num2 = 23
						text = text + " > " + Me.o0.o_.().Value.ToString()
					Case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.小于
						IL_191:
						num2 = 27
						text = text + " < " + Me.o0.o_.().Value.ToString()
					Case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不等于
						IL_101:
						num2 = 21
						text = String.Concat(New String() { text, " <> ", Me.o0.o_.().Value.ToString(), " Or ", text, " Is Null" })
					Case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不大于
						IL_16E:
						num2 = 25
						text = text + " <= " + Me.o0.o_.().Value.ToString()
					Case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不小于
						IL_1B4:
						num2 = 29
						text = text + " >= " + Me.o0.o_.().Value.ToString()
				End Select
				IL_1D5:
				num2 = 31
				Filter.O0O0o.Oo0OO_oO.(Me.oo000.ooOOO___., text, True)
				IL_1E6:
				num2 = 32
				MyBase.DialogResult = DialogResult.OK
				IL_1F0:
				GoTo IL_2C6
				IL_1F5:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_287:
				GoTo IL_2BB
				IL_289:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_299:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_289
			End Try
			IL_2BB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2C6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060033CC RID: 13260 RVA: 0x00154C58 File Offset: 0x00152E58
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oo000.ooOOO___. = CType(Me.oOoOO0.OO0oO.().SelectedIndex, O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum)
		End Sub

		' Token: 0x060033CD RID: 13261 RVA: 0x00154C6B File Offset: 0x00152E6B
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040014FB RID: 5371
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040014FC RID: 5372
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014FD RID: 5373
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014FE RID: 5374
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014FF RID: 5375
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x04001500 RID: 5376
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001501 RID: 5377
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001502 RID: 5378
		Private <<EMPTY_NAME>> As Col

		' Token: 0x04001503 RID: 5379
		Private <<EMPTY_NAME>> As O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum

		' Token: 0x0200034F RID: 847
		Friend Enum FilterModeEnum
			' Token: 0x04001505 RID: 5381
			等于
			' Token: 0x04001506 RID: 5382
			大于
			' Token: 0x04001507 RID: 5383
			小于
			' Token: 0x04001508 RID: 5384
			不等于
			' Token: 0x04001509 RID: 5385
			不大于
			' Token: 0x0400150A RID: 5386
			不小于
		End Enum
	End Class
End Namespace
