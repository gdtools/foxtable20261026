Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000331 RID: 817
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3002\u3000
		Inherits Form

		' Token: 0x060030B2 RID: 12466 RVA: 0x0013B9BC File Offset: 0x00139BBC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_oO.o__0o0. IsNot Nothing Then
					Me.O_oO.o__0o0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060030B3 RID: 12467 RVA: 0x0013B9FC File Offset: 0x00139BFC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0.oO_o00.(New C1TextBox())
			Me.oOO0o_oo._oo.(New RadioButton())
			Me.Oo_O0._.(New RadioButton())
			Me.oo_.Oo_o_.(New RadioButton())
			Me.o0.oO_o00.(New C1FlexGrid())
			Me.oOO0_00.O_O00O.(New C1Button())
			Me.oOO0o_oo._oo.(New C1Button())
			Me.o0.oO_o00.(New OpenFileDialog())
			Me.o0.oO_o00.(New C1CheckBox())
			Me.Oo_O0._.(New C1Button())
			Me.Oo_O0._.().BeginInit()
			MyBase.SuspendLayout()
			Me.Oo_O0._.().AcceptsReturn = True
			Me.Oo_O0._.().Location = New Point(127, 346)
			Me.Oo_O0._.().Name = "txtSeparator"
			Me.Oo_O0._.().[ReadOnly] = True
			Me.Oo_O0._.().Size = New Size(100, 21)
			Me.Oo_O0._.().TabIndex = 5
			Me.Oo_O0._.().Value = ","
			Me.Ooo.o_O.().AutoSize = True
			Me.Ooo.o_O.().Location = New Point(14, 348)
			Me.Ooo.o_O.().Name = "Custom"
			Me.Ooo.o_O.().Size = New Size(107, 16)
			Me.Ooo.o_O.().TabIndex = 4
			Me.Ooo.o_O.().TabStop = True
			Me.Ooo.o_O.().Text = "自定义列分隔符"
			Me.Ooo.o_O.().UseVisualStyleBackColor = True
			Me.o._o0_.().AutoSize = True
			Me.o._o0_.().Location = New Point(133, 316)
			Me.o._o0_.().Name = "Comma"
			Me.o._o0_.().Size = New Size(95, 16)
			Me.o._o0_.().TabIndex = 2
			Me.o._o0_.().Text = "用逗号分割列"
			Me.o._o0_.().UseVisualStyleBackColor = True
			Me.oOO0o_oo._oo.().AutoSize = True
			Me.oOO0o_oo._oo.().Checked = True
			Me.oOO0o_oo._oo.().Location = New Point(14, 317)
			Me.oOO0o_oo._oo.().Name = "Tab"
			Me.oOO0o_oo._oo.().Size = New Size(101, 16)
			Me.oOO0o_oo._oo.().TabIndex = 1
			Me.oOO0o_oo._oo.().TabStop = True
			Me.oOO0o_oo._oo.().Text = "用Tab符分隔列"
			Me.oOO0o_oo._oo.().UseVisualStyleBackColor = True
			Me.Oo_O0._.().AllowDragging = 0
			Me.Oo_O0._.().AllowEditing = False
			Me.Oo_O0._.().AllowSorting = 0
			Me.Oo_O0._.().ColumnInfo = "10,1,0,25,0,0,Columns:"
			Me.Oo_O0._.().Location = New Point(14, 14)
			Me.Oo_O0._.().Name = "Grid"
			Me.Oo_O0._.().Rows.DefaultSize = 20
			Me.Oo_O0._.().SelectionMode = 6
			Me.Oo_O0._.().Size = New Size(597, 287)
			Me.Oo_O0._.().TabIndex = 0
			Me.o0._0o.().Location = New Point(455, 382)
			Me.o0._0o.().Name = "Button1"
			Me.o0._0o.().Size = New Size(75, 23)
			Me.o0._0o.().TabIndex = 7
			Me.o0._0o.().Text = "确定"
			Me.o0._0o.().UseVisualStyleBackColor = True
			Me.o._o0_.().DialogResult = DialogResult.OK
			Me.o._o0_.().Location = New Point(536, 382)
			Me.o._o0_.().Name = "Button2"
			Me.o._o0_.().Size = New Size(75, 23)
			Me.o._o0_.().TabIndex = 8
			Me.o._o0_.().Text = "取消"
			Me.o._o0_.().UseVisualStyleBackColor = True
			Me.o._o0_.().Filter = "Text文件(*.txt)|*.txt"
			Me.o._o0_.().AutoSize = True
			Me.o._o0_.().Checked = True
			Me.o._o0_.().CheckState = CheckState.Checked
			Me.o._o0_.().Location = New Point(527, 317)
			Me.o._o0_.().Name = "FirstRowIsFixed"
			Me.o._o0_.().Size = New Size(84, 16)
			Me.o._o0_.().TabIndex = 3
			Me.o._o0_.().Text = "首行为标题"
			Me.o._o0_.().UseVisualStyleBackColor = True
			Me.Ooo.o_O.().Location = New Point(14, 382)
			Me.Ooo.o_O.().Name = "Button3"
			Me.Ooo.o_O.().Size = New Size(75, 23)
			Me.Ooo.o_O.().TabIndex = 6
			Me.Ooo.o_O.().Text = "删除列"
			Me.Ooo.o_O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(623, 417)
			MyBase.Controls.Add(Me.Ooo.o_O.())
			MyBase.Controls.Add(Me.o._o0_.())
			MyBase.Controls.Add(Me.o._o0_.())
			MyBase.Controls.Add(Me.o0._0o.())
			MyBase.Controls.Add(Me.Oo_O0._.())
			MyBase.Controls.Add(Me.Oo_O0._.())
			MyBase.Controls.Add(Me.Ooo.o_O.())
			MyBase.Controls.Add(Me.o._o0_.())
			MyBase.Controls.Add(Me.oOO0o_oo._oo.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o0.0.O.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "导入"
			Me.Oo_O0._.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060030B4 RID: 12468 RVA: 0x0013BFFE File Offset: 0x0013A1FE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_oO.o__0o0.
		End Function

		' Token: 0x060030B5 RID: 12469 RVA: 0x0013C008 File Offset: 0x0013A208
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As EventHandler = AddressOf Me.o.ooo_.
			Dim o_oO.o__0o0. As C1TextBox = Me.O_oO.o__0o0.
			If o_oO.o__0o0. IsNot Nothing Then
				RemoveHandler o_oO.o__0o0..TextChanged, value
			End If
			Me.O_oO.o__0o0. = A_0
			o_oO.o__0o0. = Me.O_oO.o__0o0.
			If o_oO.o__0o0. IsNot Nothing Then
				AddHandler o_oO.o__0o0..TextChanged, value
			End If
		End Sub

		' Token: 0x060030B6 RID: 12470 RVA: 0x0013C04B File Offset: 0x0013A24B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_oO.o__0o0.
		End Function

		' Token: 0x060030B7 RID: 12471 RVA: 0x0013C054 File Offset: 0x0013A254
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O000oo00oOo0.0.
			Dim o_oO.o__0o0. As RadioButton = Me.O_oO.o__0o0.
			If o_oO.o__0o0. IsNot Nothing Then
				RemoveHandler o_oO.o__0o0..CheckedChanged, value
			End If
			Me.O_oO.o__0o0. = A_0
			o_oO.o__0o0. = Me.O_oO.o__0o0.
			If o_oO.o__0o0. IsNot Nothing Then
				AddHandler o_oO.o__0o0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060030B8 RID: 12472 RVA: 0x0013C097 File Offset: 0x0013A297
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O.OOo_0oO__.
		End Function

		' Token: 0x060030B9 RID: 12473 RVA: 0x0013C0A0 File Offset: 0x0013A2A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O000oo00oOo0.0.
			Dim o.OOo_0oO__. As RadioButton = Me.O.OOo_0oO__.
			If o.OOo_0oO__. IsNot Nothing Then
				RemoveHandler o.OOo_0oO__..CheckedChanged, value
			End If
			Me.O.OOo_0oO__. = A_0
			o.OOo_0oO__. = Me.O.OOo_0oO__.
			If o.OOo_0oO__. IsNot Nothing Then
				AddHandler o.OOo_0oO__..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060030BA RID: 12474 RVA: 0x0013C0E3 File Offset: 0x0013A2E3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.OOoo_OO0oO.0o.
		End Function

		' Token: 0x060030BB RID: 12475 RVA: 0x0013C0EC File Offset: 0x0013A2EC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O000oo00oOo0.0.
			Dim oooo_OO0oO.0o. As RadioButton = Me.OOoo_OO0oO.0o.
			If oooo_OO0oO.0o. IsNot Nothing Then
				RemoveHandler oooo_OO0oO.0o..CheckedChanged, value
			End If
			Me.OOoo_OO0oO.0o. = A_0
			oooo_OO0oO.0o. = Me.OOoo_OO0oO.0o.
			If oooo_OO0oO.0o. IsNot Nothing Then
				AddHandler oooo_OO0oO.0o..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060030BC RID: 12476 RVA: 0x0013C12F File Offset: 0x0013A32F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_oO.o__0o0.
		End Function

		' Token: 0x060030BD RID: 12477 RVA: 0x0013C137 File Offset: 0x0013A337
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.O_oO.o__0o0. = A_0
		End Sub

		' Token: 0x060030BE RID: 12478 RVA: 0x0013C140 File Offset: 0x0013A340
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0.oO_o00.
		End Function

		' Token: 0x060030BF RID: 12479 RVA: 0x0013C148 File Offset: 0x0013A348
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__.oOO.
			Dim c1Button As C1Button = Me.o0.oO_o00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0.oO_o00. = A_0
			c1Button = Me.o0.oO_o00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060030C0 RID: 12480 RVA: 0x0013C18B File Offset: 0x0013A38B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_.Oo_o_.
		End Function

		' Token: 0x060030C1 RID: 12481 RVA: 0x0013C193 File Offset: 0x0013A393
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oo_.Oo_o_. = A_0
		End Sub

		' Token: 0x060030C2 RID: 12482 RVA: 0x0013C19C File Offset: 0x0013A39C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As OpenFileDialog
			Return Me.O_oO.o__0o0.
		End Function

		' Token: 0x060030C3 RID: 12483 RVA: 0x0013C1A4 File Offset: 0x0013A3A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OpenFileDialog)
			Me.O_oO.o__0o0. = A_0
		End Sub

		' Token: 0x060030C4 RID: 12484 RVA: 0x0013C1AD File Offset: 0x0013A3AD
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_oO.o__0o0.
		End Function

		' Token: 0x060030C5 RID: 12485 RVA: 0x0013C1B8 File Offset: 0x0013A3B8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.O000oo00oOo0.0.
			Dim o_oO.o__0o0. As C1CheckBox = Me.O_oO.o__0o0.
			If o_oO.o__0o0. IsNot Nothing Then
				RemoveHandler o_oO.o__0o0..CheckedChanged, value
			End If
			Me.O_oO.o__0o0. = A_0
			o_oO.o__0o0. = Me.O_oO.o__0o0.
			If o_oO.o__0o0. IsNot Nothing Then
				AddHandler o_oO.o__0o0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060030C6 RID: 12486 RVA: 0x0013C1FB File Offset: 0x0013A3FB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.ooo_.
		End Function

		' Token: 0x060030C7 RID: 12487 RVA: 0x0013C204 File Offset: 0x0013A404
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOOO0oo000.00o.
			Dim c1Button As C1Button = Me.o.ooo_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.ooo_. = A_0
			c1Button = Me.o.ooo_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060030C8 RID: 12488 RVA: 0x0013C247 File Offset: 0x0013A447
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.o._o0_.
			Me.Oo_O0._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060030C9 RID: 12489 RVA: 0x0013C27C File Offset: 0x0013A47C
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.O_oO.o__0o0., "", True) <> 0 Then
				Me.Oo_O0._.().AutoResize = True
				Me.Oo_O0._.().Rows.Count = 1
				Me.Oo_O0._.().Cols.Count = 1
				Me.Oo_O0._.().Clear(65535)
				If Me.oOO0o_oo._oo.().Checked Then
					If Me.o._o0_.().Checked Then
						Extensions.LoadGrid(Me.Oo_O0._.(), Me.O_oO.o__0o0., 1, 1, Encoding.[Default])
						Me.Oo_O0._.().Cols.Insert(0)
					Else
						Extensions.LoadGrid(Me.Oo_O0._.(), Me.O_oO.o__0o0., 1, 0, Encoding.[Default])
					End If
				ElseIf Me.o._o0_.().Checked Then
					If Me.o._o0_.().Checked Then
						Extensions.LoadGrid(Me.Oo_O0._.(), Me.O_oO.o__0o0., 0, 1, Encoding.[Default])
						Me.Oo_O0._.().Cols.Insert(0)
					Else
						Extensions.LoadGrid(Me.Oo_O0._.(), Me.O_oO.o__0o0., 0, 0, Encoding.[Default])
					End If
				ElseIf Operators.CompareString(Me.Oo_O0._.().Text, "", True) > 0 Then
					Me.Oo_O0._.().ClipSeparators = Conversions.ToString(Me.Oo_O0._.().Text.ToCharArray()(0)) + vbCr
					If Me.o._o0_.().Checked Then
						Extensions.LoadGrid(Me.Oo_O0._.(), Me.O_oO.o__0o0., 2, 1, Encoding.[Default])
						Me.Oo_O0._.().Cols.Insert(0)
					Else
						Extensions.LoadGrid(Me.Oo_O0._.(), Me.O_oO.o__0o0., 2, 0, Encoding.[Default])
					End If
				End If
				For i As Integer = Me.Oo_O0._.().Cols.Count - 1 To 1 Step -1
					Dim text As String = ""
					If Me.Oo_O0._.()(0, i) IsNot Nothing Then
						text = Me.Oo_O0._.()(0, i).ToString()
					End If
					If o_O_o_oOoo__.oO.O_..Contains(text) Then
						Me.Oo_O0._.().Cols.Remove(i)
					Else
						If Operators.CompareString(text, "", True) = 0 OrElse Not o_O_o_oOoo__.O_o_._o0.(text, True) Then
							Dim num As Integer = 1
							While Me.o._o0_.("第" + Conversions.ToString(num) + "列", i)
								num += 1
							End While
							Me.Oo_O0._.()(0, i) = "第" + Conversions.ToString(num) + "列"
							text = "第" + Conversions.ToString(num) + "列"
						End If
						Me.Oo_O0._.().Cols(i).Name = text
					End If
				Next
				Me.Oo_O0._.().AutoSizeCols()
				Me.Oo_O0._.().Cols(0).Width = 23
			End If
		End Sub

		' Token: 0x060030CA RID: 12490 RVA: 0x0013C560 File Offset: 0x0013A760
		Private Overloads Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer) As Boolean
			Dim num As Integer = Me.Oo_O0._.().Cols.Count - 1
			For i As Integer = 1 To num
				If i <> A_1 AndAlso Me.Oo_O0._.()(0, i) IsNot Nothing AndAlso Operators.CompareString(Me.Oo_O0._.()(0, i).ToString(), A_0, True) = 0 Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x060030CB RID: 12491 RVA: 0x0013C5C1 File Offset: 0x0013A7C1
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oOO0_00.O_O00O.()
			Me.Oo_O0._.().[ReadOnly] = Not Me.Ooo.o_O.().Checked
		End Sub

		' Token: 0x060030CC RID: 12492 RVA: 0x0013C5E2 File Offset: 0x0013A7E2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Oo_O0._.().Text.Length > 0 Then
				Me.oOO0_00.O_O00O.()
			End If
		End Sub

		' Token: 0x060030CD RID: 12493 RVA: 0x0013C600 File Offset: 0x0013A800
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Oo_O0._.().Col >= Me.Oo_O0._.().Cols.Fixed Then
				Dim leftCol As Integer = Me.Oo_O0._.().Selection.LeftCol
				Dim rightCol As Integer = Me.Oo_O0._.().Selection.RightCol
				Dim num As Integer = leftCol
				Dim num2 As Integer = rightCol
				For i As Integer = num To num2
					Me.Oo_O0._.().Cols.Remove(leftCol)
				Next
			End If
		End Sub

		' Token: 0x060030CE RID: 12494 RVA: 0x0013C678 File Offset: 0x0013A878
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				Me.Cursor = Cursors.WaitCursor
				If Oo00.O____0O._0.(Me.Oo_O0._.(), Path.GetFileNameWithoutExtension(Me.O_oO.o__0o0.)) Then
					MyBase.DialogResult = DialogResult.OK
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Me.Cursor = Cursors.[Default]
			End Try
		End Sub

		' Token: 0x060030CF RID: 12495 RVA: 0x0013C6F4 File Offset: 0x0013A8F4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001389 RID: 5001
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400138A RID: 5002
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400138B RID: 5003
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400138C RID: 5004
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400138D RID: 5005
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400138E RID: 5006
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x0400138F RID: 5007
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001390 RID: 5008
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001391 RID: 5009
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OpenFileDialog

		' Token: 0x04001392 RID: 5010
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001393 RID: 5011
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001394 RID: 5012
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
