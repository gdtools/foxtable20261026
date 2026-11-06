Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000345 RID: 837
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3002
		Inherits Form

		' Token: 0x060032F2 RID: 13042 RVA: 0x0014D784 File Offset: 0x0014B984
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOo0OoO.oO0oo_. IsNot Nothing Then
					Me.oOo0OoO.oO0oo_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060032F3 RID: 13043 RVA: 0x0014D7C4 File Offset: 0x0014B9C4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.O_O0ooO_.(New Label())
			Me.o.O_O0ooO_.(New C1ComboBox())
			Me.o_.0_00_o_o.(New C1CheckBox())
			Me.o.O_O0ooO_.(New C1Button())
			Me.OO__o._O_.(New C1Button())
			Me.o.O_O0ooO_.(New C1CheckBox())
			Me.O_.o0__00.(New C1CheckBox())
			Me.O.Oo0oO_.(New C1CheckBox())
			Me.OO__o._O_.(New C1CheckBox())
			MyBase.SuspendLayout()
			Me.o_.0_0_0OoO__.().AutoSize = True
			Me.o_.0_0_0OoO__.().Location = New Point(24, 27)
			Me.o_.0_0_0OoO__.().Name = "Label1"
			Me.o_.0_0_0OoO__.().Size = New Size(59, 12)
			Me.o_.0_0_0OoO__.().TabIndex = 0
			Me.o_.0_0_0OoO__.().Text = "停靠位置:"
			Me.o_.0_0_0OoO__.().DropDownStyle = 1
			Me.o_.0_0_0OoO__.().Items.AddRange(New Object() { "靠左", "靠右", "靠底", "靠上" })
			Me.o_.0_0_0OoO__.().Location = New Point(89, 24)
			Me.o_.0_0_0OoO__.().Name = "cmbDockArea"
			Me.o_.0_0_0OoO__.().Size = New Size(121, 20)
			Me.o_.0_0_0OoO__.().TabIndex = 0
			Me.OOo_.ooo0O.().AutoSize = True
			Me.OOo_.ooo0O.().Location = New Point(64, 61)
			Me.OOo_.ooo0O.().Name = "chkTitle"
			Me.OOo_.ooo0O.().Size = New Size(72, 16)
			Me.OOo_.ooo0O.().TabIndex = 1
			Me.OOo_.ooo0O.().Text = "独立停靠"
			Me.OOo_.ooo0O.().UseVisualStyleBackColor = True
			Me.o.__o___0_0O_.().DialogResult = DialogResult.OK
			Me.o.__o___0_0O_.().Location = New Point(68, 141)
			Me.o.__o___0_0O_.().Name = "Button1"
			Me.o.__o___0_0O_.().Size = New Size(75, 23)
			Me.o.__o___0_0O_.().TabIndex = 5
			Me.o.__o___0_0O_.().Text = "确定"
			Me.o.__o___0_0O_.().UseVisualStyleBackColor = True
			Me.o_.0_0_0OoO__.().DialogResult = DialogResult.Cancel
			Me.o_.0_0_0OoO__.().Location = New Point(149, 141)
			Me.o_.0_0_0OoO__.().Name = "Button2"
			Me.o_.0_0_0OoO__.().Size = New Size(75, 23)
			Me.o_.0_0_0OoO__.().TabIndex = 6
			Me.o_.0_0_0OoO__.().Text = "取消"
			Me.o_.0_0_0OoO__.().UseVisualStyleBackColor = True
			Me.Ooo_O._.().AutoSize = True
			Me.Ooo_O._.().Location = New Point(64, 84)
			Me.Ooo_O._.().Name = "chkAutoOpen"
			Me.Ooo_O._.().Size = New Size(72, 16)
			Me.Ooo_O._.().TabIndex = 2
			Me.Ooo_O._.().Text = "自动打开"
			Me.Ooo_O._.().UseVisualStyleBackColor = True
			Me.o.__o___0_0O_.().AutoSize = True
			Me.o.__o___0_0O_.().Location = New Point(64, 107)
			Me.o.__o___0_0O_.().Name = "chkAutoHide"
			Me.o.__o___0_0O_.().Size = New Size(72, 16)
			Me.o.__o___0_0O_.().TabIndex = 2
			Me.o.__o___0_0O_.().Text = "自动隐藏"
			Me.o.__o___0_0O_.().UseVisualStyleBackColor = True
			Me.o_.0_0_0OoO__.().AutoSize = True
			Me.o_.0_0_0OoO__.().Location = New Point(143, 84)
			Me.o_.0_0_0OoO__.().Name = "chkShowCaption"
			Me.o_.0_0_0OoO__.().Size = New Size(72, 16)
			Me.o_.0_0_0OoO__.().TabIndex = 3
			Me.o_.0_0_0OoO__.().Text = "显示标题"
			Me.o_.0_0_0OoO__.().UseVisualStyleBackColor = True
			Me.O_.oOOo0_00.().AutoSize = True
			Me.O_.oOOo0_00.().Location = New Point(143, 107)
			Me.O_.oOOo0_00.().Name = "chkAllowClose"
			Me.O_.oOOo0_00.().Size = New Size(72, 16)
			Me.O_.oOOo0_00.().TabIndex = 4
			Me.O_.oOOo0_00.().Text = "允许关闭"
			Me.O_.oOOo0_00.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(293, 176)
			MyBase.Controls.Add(Me.O_.oOOo0_00.())
			MyBase.Controls.Add(Me.o_.0_0_0OoO__.())
			MyBase.Controls.Add(Me.o.__o___0_0O_.())
			MyBase.Controls.Add(Me.Ooo_O._.())
			MyBase.Controls.Add(Me.o_.0_0_0OoO__.())
			MyBase.Controls.Add(Me.o.__o___0_0O_.())
			MyBase.Controls.Add(Me.OOo_.ooo0O.())
			MyBase.Controls.Add(Me.o_.0_0_0OoO__.())
			MyBase.Controls.Add(Me.o_.0_0_0OoO__.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O0..oo.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "停靠设置"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060032F4 RID: 13044 RVA: 0x0014DD3A File Offset: 0x0014BF3A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOo0OoO.oO0oo_.
		End Function

		' Token: 0x060032F5 RID: 13045 RVA: 0x0014DD42 File Offset: 0x0014BF42
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOo0OoO.oO0oo_. = A_0
		End Sub

		' Token: 0x060032F6 RID: 13046 RVA: 0x0014DD4B File Offset: 0x0014BF4B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oOo0OoO.oO0oo_.
		End Function

		' Token: 0x060032F7 RID: 13047 RVA: 0x0014DD53 File Offset: 0x0014BF53
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.oOo0OoO.oO0oo_. = A_0
		End Sub

		' Token: 0x060032F8 RID: 13048 RVA: 0x0014DD5C File Offset: 0x0014BF5C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oOo0OoO.oO0oo_.
		End Function

		' Token: 0x060032F9 RID: 13049 RVA: 0x0014DD64 File Offset: 0x0014BF64
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oOo0OoO.oO0oo_. = A_0
		End Sub

		' Token: 0x060032FA RID: 13050 RVA: 0x0014DD6D File Offset: 0x0014BF6D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.O_O0ooO_.
		End Function

		' Token: 0x060032FB RID: 13051 RVA: 0x0014DD78 File Offset: 0x0014BF78
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_.OoO0.
			Dim c1Button As C1Button = Me.o.O_O0ooO_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.O_O0ooO_. = A_0
			c1Button = Me.o.O_O0ooO_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060032FC RID: 13052 RVA: 0x0014DDBB File Offset: 0x0014BFBB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_._Oo.
		End Function

		' Token: 0x060032FD RID: 13053 RVA: 0x0014DDC3 File Offset: 0x0014BFC3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_._Oo. = A_0
		End Sub

		' Token: 0x060032FE RID: 13054 RVA: 0x0014DDCC File Offset: 0x0014BFCC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_._Oo.
		End Function

		' Token: 0x060032FF RID: 13055 RVA: 0x0014DDD4 File Offset: 0x0014BFD4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o_._Oo. = A_0
		End Sub

		' Token: 0x06003300 RID: 13056 RVA: 0x0014DDDD File Offset: 0x0014BFDD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.OOO.oo.
		End Function

		' Token: 0x06003301 RID: 13057 RVA: 0x0014DDE5 File Offset: 0x0014BFE5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.OOO.oo. = A_0
		End Sub

		' Token: 0x06003302 RID: 13058 RVA: 0x0014DDEE File Offset: 0x0014BFEE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oo0oO.0.
		End Function

		' Token: 0x06003303 RID: 13059 RVA: 0x0014DDF6 File Offset: 0x0014BFF6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oo0oO.0. = A_0
		End Sub

		' Token: 0x06003304 RID: 13060 RVA: 0x0014DDFF File Offset: 0x0014BFFF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O___0Oo.o.
		End Function

		' Token: 0x06003305 RID: 13061 RVA: 0x0014DE07 File Offset: 0x0014C007
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O___0Oo.o. = A_0
		End Sub

		' Token: 0x06003306 RID: 13062 RVA: 0x0014DE10 File Offset: 0x0014C010
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
				Dim o_O0_0O As o_O0_0O0
				Select Case Me.oOo0OoO.oO0oo_.._frdDockArea
					Case 0
						IL_61:
						num2 = 7
						Me.o_.0_0_0OoO__.().SelectedIndex = 1
						IL_6F:
						num2 = 8
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab, Oo0__Oo).o__0_.o0OoOOO.()
					Case 1
						IL_8D:
						num2 = 10
						Me.o_.0_0_0OoO__.().SelectedIndex = 2
						IL_9C:
						num2 = 11
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab, Oo0__Oo).O._o_00__.()
					Case 2
						IL_32:
						num2 = 4
						Me.o_.0_0_0OoO__.().SelectedIndex = 0
						IL_40:
						num2 = 5
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab, Oo0__Oo).O__O.o_oOO.()
					Case 3
						IL_BB:
						num2 = 13
						Me.o_.0_0_0OoO__.().SelectedIndex = 3
						IL_CA:
						num2 = 14
						o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab, Oo0__Oo).O_000__.o.()
					Case Else
						GoTo IL_1CD
				End Select
				IL_E7:
				num2 = 18
				Dim enumerator As IEnumerator = o_O0_0O.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control As Control = CType(obj, Control)
					IL_107:
					num2 = 19
					If TypeOf control Is C1DockingTab Then
						IL_113:
						num2 = 20
						CType(control, C1DockingTab).AutoHiding = False
					End If
					IL_123:
					num2 = 21
				End While
				IL_12F:
				num2 = 22
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_147:
				num2 = 23
				o_O0_0O.Refresh()
				IL_150:
				num2 = 24
				Me.OOo_.ooo0O.().Checked = Me.oOo0OoO.oO0oo_.._frdDockTitle
				IL_169:
				num2 = 25
				Me.Ooo_O._.().Checked = Me.oOo0OoO.oO0oo_.._frdAutoOpen
				IL_182:
				num2 = 26
				Me.o.__o___0_0O_.().Checked = Me.oOo0OoO.oO0oo_.._frdAutoHide
				IL_19B:
				num2 = 27
				Me.o_.0_0_0OoO__.().Checked = Me.oOo0OoO.oO0oo_.._frdShowCaption
				IL_1B4:
				num2 = 28
				Me.O_.oOOo0_00.().Checked = Me.oOo0OoO.oO0oo_.._frdAllowClose
				IL_1CD:
				GoTo IL_293
				IL_1D2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_254:
				GoTo IL_288
				IL_256:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_266:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_256
			End Try
			IL_288:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_293:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003307 RID: 13063 RVA: 0x0014E0D4 File Offset: 0x0014C2D4
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.O___O.O_o0OooO.
			AddHandler MyBase.MenuStart, AddressOf Me.o.o_o.
			Me.o_.0_0_0OoO__.()
			Me.oOo0OoO.oO0oo_. = A_0
			Me.Text = Me.Text + " - " + A_0.Name
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003308 RID: 13064 RVA: 0x0014E14C File Offset: 0x0014C34C
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
				Select Case Me.o_.0_0_0OoO__.().SelectedIndex
					Case 0
						IL_2D:
						num2 = 4
						Me.oOo0OoO.oO0oo_.._frdDockArea = 2
					Case 1
						IL_3D:
						num2 = 6
						Me.oOo0OoO.oO0oo_.._frdDockArea = 0
					Case 2
						IL_4D:
						num2 = 8
						Me.oOo0OoO.oO0oo_.._frdDockArea = 1
					Case 3
						IL_5D:
						num2 = 10
						Me.oOo0OoO.oO0oo_.._frdDockArea = 3
				End Select
				IL_6C:
				num2 = 12
				Me.oOo0OoO.oO0oo_.._frdDockTitle = Me.OOo_.ooo0O.().Checked
				IL_85:
				num2 = 13
				Me.oOo0OoO.oO0oo_.._frdAutoOpen = Me.Ooo_O._.().Checked
				IL_9E:
				num2 = 14
				Me.oOo0OoO.oO0oo_.._frdAutoHide = Me.o.__o___0_0O_.().Checked
				IL_B7:
				num2 = 15
				Me.oOo0OoO.oO0oo_.._frdShowCaption = Me.o_.0_0_0OoO__.().Checked
				IL_D0:
				num2 = 16
				Me.oOo0OoO.oO0oo_.._frdAllowClose = Me.O_.oOOo0_00.().Checked
				IL_E9:
				num2 = 17
				Me.oOo0OoO.oO0oo_..NeedSaveSetting = True
				IL_F8:
				num2 = 18
				Me.oOo0OoO.oO0oo_..Oo._0oO.()
				IL_106:
				num2 = 19
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				IL_123:
				num2 = 20
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle)
				IL_136:
				num2 = 21
				OO_00oOO.BaseMainForm.SuspendLayout()
				IL_143:
				num2 = 22
				Me.oOo0OoO.oO0oo_..Visible = False
				IL_152:
				num2 = 23
				Me.oOo0OoO.oO0oo_..Visible = True
				IL_161:
				num2 = 24
				OO_00oOO.BaseMainForm.ResumeLayout()
				IL_16E:
				num2 = 25
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				IL_17C:
				GoTo IL_236
				IL_181:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1F7:
				GoTo IL_22B
				IL_1F9:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_209:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1F9
			End Try
			IL_22B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_236:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003309 RID: 13065 RVA: 0x0014E3B4 File Offset: 0x0014C5B4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001495 RID: 5269
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001496 RID: 5270
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001497 RID: 5271
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001498 RID: 5272
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001499 RID: 5273
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400149A RID: 5274
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400149B RID: 5275
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400149C RID: 5276
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400149D RID: 5277
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400149E RID: 5278
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400149F RID: 5279
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
