Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000354 RID: 852
	<DesignerGenerated()>
	Friend Partial Class o0o\u3002
		Inherits Form

		' Token: 0x060033FE RID: 13310 RVA: 0x00156AD4 File Offset: 0x00154CD4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OooO_ooo0_.___. IsNot Nothing Then
					Me.OooO_ooo0_.___..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060033FF RID: 13311 RVA: 0x00156B14 File Offset: 0x00154D14
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O_0.0O0.(New Label())
			Me.Oo__o._o_O.(New C1ComboBox())
			Me.oo._0O.(New C1Button())
			Me.o_o___.OOOO.(New C1Button())
			Me.o.0___.(New C1ComboBox())
			Me.oo._0O.(New C1CheckBox())
			Me.oo._0O.(New Label())
			Me.o0O0.o0o.(New Label())
			Me.OOOo0__.0o.(New C1ComboBox())
			Me.o_Oo._.(New C1Button())
			Me.oo._0O.(New C1ComboBox())
			Me.O_o0oo._.(New C1ComboBox())
			Me.O_o0oo._.(New Label())
			Me.oO_._O0_oO_o_O.(New Label())
			Me.o.0___.(New C1Button())
			MyBase.SuspendLayout()
			Me.O_0o0.OOO0.().AutoSize = True
			Me.O_0o0.OOO0.().Location = New Point(12, 16)
			Me.O_0o0.OOO0.().Name = "Label1"
			Me.O_0o0.OOO0.().Size = New Size(59, 12)
			Me.O_0o0.OOO0.().TabIndex = 0
			Me.O_0o0.OOO0.().Text = "查找内容:"
			Me.O_0o0.OOO0.().Location = New Point(77, 12)
			Me.O_0o0.OOO0.().Name = "ContentFind"
			Me.O_0o0.OOO0.().Size = New Size(319, 20)
			Me.O_0o0.OOO0.().TabIndex = 0
			Me.ooO_o_._o.().Location = New Point(413, 12)
			Me.ooO_o_._o.().Name = "FindNext"
			Me.ooO_o_._o.().Size = New Size(98, 23)
			Me.ooO_o_._o.().TabIndex = 6
			Me.ooO_o_._o.().Text = "查找下一个"
			Me.ooO_o_._o.().UseVisualStyleBackColor = True
			Me.O_0o0.OOO0.().Location = New Point(413, 42)
			Me.O_0o0.OOO0.().Name = "Button2"
			Me.O_0o0.OOO0.().Size = New Size(98, 23)
			Me.O_0o0.OOO0.().TabIndex = 7
			Me.O_0o0.OOO0.().Text = "替换"
			Me.O_0o0.OOO0.().UseVisualStyleBackColor = True
			Me.o0Ooo_.oO0.().DropDownStyle = 1
			Me.o0Ooo_.oO0.().Location = New Point(77, 39)
			Me.o0Ooo_.oO0.().Name = "ColList"
			Me.o0Ooo_.oO0.().Size = New Size(203, 20)
			Me.o0Ooo_.oO0.().TabIndex = 1
			Me.ooO_o_._o.().AutoSize = True
			Me.ooO_o_._o.().Checked = True
			Me.ooO_o_._o.().CheckState = CheckState.Checked
			Me.ooO_o_._o.().Location = New Point(77, 93)
			Me.ooO_o_._o.().Name = "CaseSensitive"
			Me.ooO_o_._o.().Size = New Size(84, 16)
			Me.ooO_o_._o.().TabIndex = 3
			Me.ooO_o_._o.().Text = "区分大小写"
			Me.ooO_o_._o.().UseVisualStyleBackColor = True
			Me.o_o___.OOOO.().AutoSize = True
			Me.o_o___.OOOO.().Location = New Point(12, 43)
			Me.o_o___.OOOO.().Name = "Label2"
			Me.o_o___.OOOO.().Size = New Size(59, 12)
			Me.o_o___.OOOO.().TabIndex = 10
			Me.o_o___.OOOO.().Text = "查找位置:"
			Me.O00O0.0o_ooOOo.().AutoSize = True
			Me.O00O0.0o_ooOOo.().Location = New Point(12, 70)
			Me.O00O0.0o_ooOOo.().Name = "Label3"
			Me.O00O0.0o_ooOOo.().Size = New Size(59, 12)
			Me.O00O0.0o_ooOOo.().TabIndex = 11
			Me.O00O0.0o_ooOOo.().Text = "匹配方式:"
			Me.o_o___.OOOO.().AccessibleRole = AccessibleRole.None
			Me.o_o___.OOOO.().DropDownStyle = 1
			Me.o_o___.OOOO.().Items.AddRange(New Object() { "完全匹配", "开始位置", "结束位置", "任意位置" })
			Me.o_o___.OOOO.().Location = New Point(77, 66)
			Me.o_o___.OOOO.().Name = "MatchMode"
			Me.o_o___.OOOO.().Size = New Size(121, 20)
			Me.o_o___.OOOO.().TabIndex = 2
			Me.O_.oo_oo0ooOo.().AccessibleRole = AccessibleRole.None
			Me.O_.oo_oo0ooOo.().Location = New Point(413, 131)
			Me.O_.oo_oo0ooOo.().Name = "cmdReplace"
			Me.O_.oo_oo0ooOo.().Size = New Size(97, 23)
			Me.O_.oo_oo0ooOo.().TabIndex = 8
			Me.O_.oo_oo0ooOo.().Text = "替换"
			Me.O_.oo_oo0ooOo.().UseVisualStyleBackColor = True
			Me.ooO_o_._o.().Location = New Point(77, 133)
			Me.ooO_o_._o.().Name = "ContentReplace"
			Me.ooO_o_._o.().Size = New Size(319, 20)
			Me.ooO_o_._o.().TabIndex = 4
			Me.O00O0.0o_ooOOo.().DropDownStyle = 1
			Me.O00O0.0o_ooOOo.().Items.AddRange(New Object() { "全部内容", "匹配内容" })
			Me.O00O0.0o_ooOOo.().Location = New Point(77, 161)
			Me.O00O0.0o_ooOOo.().Name = "ReplaceMode"
			Me.O00O0.0o_ooOOo.().Size = New Size(121, 20)
			Me.O00O0.0o_ooOOo.().TabIndex = 5
			Me.oO.o_o_0.().AutoSize = True
			Me.oO.o_o_0.().Location = New Point(12, 137)
			Me.oO.o_o_0.().Name = "Label4"
			Me.oO.o_o_0.().Size = New Size(47, 12)
			Me.oO.o_o_0.().TabIndex = 19
			Me.oO.o_o_0.().Text = "替换为:"
			Me.OOoOo0.oo___oo.().AutoSize = True
			Me.OOoOo0.oo___oo.().Location = New Point(12, 165)
			Me.OOoOo0.oo___oo.().Name = "Label5"
			Me.OOoOo0.oo___oo.().Size = New Size(59, 12)
			Me.OOoOo0.oo___oo.().TabIndex = 21
			Me.OOoOo0.oo___oo.().Text = "替换方式:"
			Me.o0Ooo_.oO0.().Location = New Point(413, 160)
			Me.o0Ooo_.oO0.().Name = "cmdReplaceAll"
			Me.o0Ooo_.oO0.().Size = New Size(98, 23)
			Me.o0Ooo_.oO0.().TabIndex = 9
			Me.o0Ooo_.oO0.().Text = "全部替换"
			Me.o0Ooo_.oO0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(522, 194)
			MyBase.Controls.Add(Me.O_.oo_oo0ooOo.())
			MyBase.Controls.Add(Me.ooO_o_._o.())
			MyBase.Controls.Add(Me.O00O0.0o_ooOOo.())
			MyBase.Controls.Add(Me.oO.o_o_0.())
			MyBase.Controls.Add(Me.OOoOo0.oo___oo.())
			MyBase.Controls.Add(Me.o0Ooo_.oO0.())
			MyBase.Controls.Add(Me.o_o___.OOOO.())
			MyBase.Controls.Add(Me.O00O0.0o_ooOOo.())
			MyBase.Controls.Add(Me.o_o___.OOOO.())
			MyBase.Controls.Add(Me.ooO_o_._o.())
			MyBase.Controls.Add(Me.o0Ooo_.oO0.())
			MyBase.Controls.Add(Me.O_0o0.OOO0.())
			MyBase.Controls.Add(Me.ooO_o_._o.())
			MyBase.Controls.Add(Me.O_0o0.OOO0.())
			MyBase.Controls.Add(Me.O_0o0.OOO0.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "OO0...Oo"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "查找"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003400 RID: 13312 RVA: 0x0015733E File Offset: 0x0015553E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooOOO.0.
		End Function

		' Token: 0x06003401 RID: 13313 RVA: 0x00157346 File Offset: 0x00155546
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooOOO.0. = A_0
		End Sub

		' Token: 0x06003402 RID: 13314 RVA: 0x0015734F File Offset: 0x0015554F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.ooOOO.0.
		End Function

		' Token: 0x06003403 RID: 13315 RVA: 0x00157358 File Offset: 0x00155558
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim value As EventHandler = AddressOf Me.oo_.000o000.
			Dim c1ComboBox As C1ComboBox = Me.ooOOO.0.
			If c1ComboBox IsNot Nothing Then
				RemoveHandler c1ComboBox.TextChanged, value
			End If
			Me.ooOOO.0. = A_0
			c1ComboBox = Me.ooOOO.0.
			If c1ComboBox IsNot Nothing Then
				AddHandler c1ComboBox.TextChanged, value
			End If
		End Sub

		' Token: 0x06003404 RID: 13316 RVA: 0x0015739B File Offset: 0x0015559B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooOOO.0.
		End Function

		' Token: 0x06003405 RID: 13317 RVA: 0x001573A4 File Offset: 0x001555A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_.O_.
			Dim c1Button As C1Button = Me.ooOOO.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooOOO.0. = A_0
			c1Button = Me.ooOOO.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003406 RID: 13318 RVA: 0x001573E7 File Offset: 0x001555E7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O0.o0o.
		End Function

		' Token: 0x06003407 RID: 13319 RVA: 0x001573F0 File Offset: 0x001555F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_Oo_Oo.0_0.
			Dim c1Button As C1Button = Me.o0O0.o0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O0.o0o. = A_0
			c1Button = Me.o0O0.o0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003408 RID: 13320 RVA: 0x00157433 File Offset: 0x00155633
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0O0.o0o.
		End Function

		' Token: 0x06003409 RID: 13321 RVA: 0x0015743C File Offset: 0x0015563C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O.oo0O_Ooo_o.
			Dim c1ComboBox As C1ComboBox = Me.o0O0.o0o.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o0O0.o0o. = A_0
			c1ComboBox = Me.o0O0.o0o.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600340A RID: 13322 RVA: 0x0015747F File Offset: 0x0015567F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0O0Oo.000o0.
		End Function

		' Token: 0x0600340B RID: 13323 RVA: 0x00157488 File Offset: 0x00155688
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.OoOO.O__o0o_O0.
			Dim o0O0Oo.000o0. As C1CheckBox = Me.O0O0Oo.000o0.
			If o0O0Oo.000o0. IsNot Nothing Then
				RemoveHandler o0O0Oo.000o0..CheckedChanged, value
			End If
			Me.O0O0Oo.000o0. = A_0
			o0O0Oo.000o0. = Me.O0O0Oo.000o0.
			If o0O0Oo.000o0. IsNot Nothing Then
				AddHandler o0O0Oo.000o0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x0600340C RID: 13324 RVA: 0x001574CB File Offset: 0x001556CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.___.
		End Function

		' Token: 0x0600340D RID: 13325 RVA: 0x001574D3 File Offset: 0x001556D3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.___. = A_0
		End Sub

		' Token: 0x0600340E RID: 13326 RVA: 0x001574DC File Offset: 0x001556DC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0_0_O__._O.
		End Function

		' Token: 0x0600340F RID: 13327 RVA: 0x001574E4 File Offset: 0x001556E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0_0_O__._O. = A_0
		End Sub

		' Token: 0x06003410 RID: 13328 RVA: 0x001574ED File Offset: 0x001556ED
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O0_0_O__._O.
		End Function

		' Token: 0x06003411 RID: 13329 RVA: 0x001574F8 File Offset: 0x001556F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o_o___.OOOO.
			Dim o0_0_O__._O. As C1ComboBox = Me.O0_0_O__._O.
			If o0_0_O__._O. IsNot Nothing Then
				o0_0_O__._O..SelectedIndexChanged -= eventHandler
			End If
			Me.O0_0_O__._O. = A_0
			o0_0_O__._O. = Me.O0_0_O__._O.
			If o0_0_O__._O. IsNot Nothing Then
				o0_0_O__._O..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06003412 RID: 13330 RVA: 0x0015753B File Offset: 0x0015573B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_o0oo._.
		End Function

		' Token: 0x06003413 RID: 13331 RVA: 0x00157544 File Offset: 0x00155744
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.ooo0O.O0OO_.
			Dim o_o0oo._. As C1Button = Me.O_o0oo._.
			If o_o0oo._. IsNot Nothing Then
				RemoveHandler o_o0oo._..Click, value
			End If
			Me.O_o0oo._. = A_0
			o_o0oo._. = Me.O_o0oo._.
			If o_o0oo._. IsNot Nothing Then
				AddHandler o_o0oo._..Click, value
			End If
		End Sub

		' Token: 0x06003414 RID: 13332 RVA: 0x00157587 File Offset: 0x00155787
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O.O__OOoO0Oo0.
		End Function

		' Token: 0x06003415 RID: 13333 RVA: 0x0015758F File Offset: 0x0015578F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O.O__OOoO0Oo0. = A_0
		End Sub

		' Token: 0x06003416 RID: 13334 RVA: 0x00157598 File Offset: 0x00155798
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oo._o00o_o_0_O.
		End Function

		' Token: 0x06003417 RID: 13335 RVA: 0x001575A0 File Offset: 0x001557A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.oo._o00o_o_0_O. = A_0
		End Sub

		' Token: 0x06003418 RID: 13336 RVA: 0x001575A9 File Offset: 0x001557A9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.O__OOoO0Oo0.
		End Function

		' Token: 0x06003419 RID: 13337 RVA: 0x001575B1 File Offset: 0x001557B1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.O__OOoO0Oo0. = A_0
		End Sub

		' Token: 0x0600341A RID: 13338 RVA: 0x001575BA File Offset: 0x001557BA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo._o00o_o_0_O.
		End Function

		' Token: 0x0600341B RID: 13339 RVA: 0x001575C2 File Offset: 0x001557C2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo._o00o_o_0_O. = A_0
		End Sub

		' Token: 0x0600341C RID: 13340 RVA: 0x001575CB File Offset: 0x001557CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOOo0__.0o.
		End Function

		' Token: 0x0600341D RID: 13341 RVA: 0x001575D4 File Offset: 0x001557D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O._0_O0O_.
			Dim oooo0__.0o. As C1Button = Me.OOOo0__.0o.
			If oooo0__.0o. IsNot Nothing Then
				RemoveHandler oooo0__.0o..Click, value
			End If
			Me.OOOo0__.0o. = A_0
			oooo0__.0o. = Me.OOOo0__.0o.
			If oooo0__.0o. IsNot Nothing Then
				AddHandler oooo0__.0o..Click, value
			End If
		End Sub

		' Token: 0x0600341E RID: 13342 RVA: 0x00157618 File Offset: 0x00155818
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.O._0_O0O_.
			AddHandler MyBase.Load, AddressOf Me.o_00_0.0.
			Me.OooO_ooo0_.___. = -1
			Me.OooO_ooo0_.___. = New Dictionary(Of String, String)()
			Me.o0oO00.__0__.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600341F RID: 13343 RVA: 0x0015767C File Offset: 0x0015587C
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 Then
				MyBase.Size = New Size(MyBase.Width, CInt(Math.Round(CDbl((228F * SysInfo.ScreenDpiY / 96F)))))
				Me.O_0o0.OOO0.().Visible = False
			Else
				MyBase.Size = New Size(MyBase.Width, 156)
			End If
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As Control = CType(obj, Control)
					If control.Top > Me.ooO_o_._o.().Top Then
						control.Visible = A_0
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003420 RID: 13344 RVA: 0x0015773C File Offset: 0x0015593C
		Private Overloads Sub <<EMPTY_NAME>>()
			If Not MyBase.DesignMode Then
				Me.OooO_ooo0_.___. = OO_00oOO.CurrentTable
				Me.o0Ooo_.oO0.().Items.Clear()
				Me.OooO_ooo0_.___..Clear()
				Dim num As Integer = Me.OooO_ooo0_.___..Cols.Count - 1
				For i As Integer = 0 To num
					Dim text As String = Me.OooO_ooo0_.___..Cols(i).Caption
					If Me.OooO_ooo0_.___..Cols.Contains(text) OrElse Me.OooO_ooo0_.___..ContainsKey(text) Then
						text = Me.OooO_ooo0_.___..Cols(i).Name
					End If
					Me.o0Ooo_.oO0.().Items.Add(text)
					Me.OooO_ooo0_.___..Add(text, Me.OooO_ooo0_.___..Cols(i).Name)
					If Me.OooO_ooo0_.___..foxGrid.Col - 1 = i Then
						Me.o0Ooo_.oO0.().SelectedIndex = Me.o0Ooo_.oO0.().Items.Count - 1
					End If
				Next
				If Me.o0Ooo_.oO0.().SelectedIndex < 0 Then
					Me.o0Ooo_.oO0.().SelectedIndex = 0
				End If
				Me.O_0o0.OOO0.().Items.Clear()
				Try
					For Each text2 As String In Me.OooO_ooo0_.___..o.0o00ooo_.
						Me.O_0o0.OOO0.().Items.Add(text2)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If Me.O_0o0.OOO0.().Items.Count > 0 Then
					Me.O_0o0.OOO0.().SelectedIndex = 0
				End If
				Me.ooO_o_._o.().Items.Clear()
				Try
					For Each text3 As String In Me.OooO_ooo0_.___..o.OOoo_o.
						Me.ooO_o_._o.().Items.Add(text3)
					Next
				Finally
					Dim enumerator2 As List(Of String).Enumerator
					CType(enumerator2, IDisposable).Dispose()
				End Try
				Me.OooO_ooo0_.___. = -1
			End If
		End Sub

		' Token: 0x06003421 RID: 13345 RVA: 0x00157970 File Offset: 0x00155B70
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			RemoveHandler OO_00oOO.CurrentTableChanged, AddressOf Me.O._0_O0O_.
			o0o\u3002.OooO_ooo0_.___. = Me.ooO_o_._o.().Checked
			o0o\u3002.o00__.O_. = Me.o_o___.OOOO.().SelectedIndex
			o0o\u3002.Oo._o_. = Me.O00O0.0o_ooOOo.().SelectedIndex
			Me.OooO_ooo0_.___. = -1
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06003422 RID: 13346 RVA: 0x001579D8 File Offset: 0x00155BD8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			AddHandler OO_00oOO.CurrentTableChanged, AddressOf Me.O._0_O0O_.
			Me.O._0_O0O_.()
			Me.ooO_o_._o.().Checked = o0o\u3002.OooO_ooo0_.___.
			Me.o_o___.OOOO.().SelectedIndex = o0o\u3002.o00__.O_.
			Me.O00O0.0o_ooOOo.().SelectedIndex = o0o\u3002.Oo._o_.
		End Sub

		' Token: 0x06003423 RID: 13347 RVA: 0x00157A2C File Offset: 0x00155C2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.0___.(True)
			Me.Text = "替换"
		End Sub

		' Token: 0x06003424 RID: 13348 RVA: 0x00157A40 File Offset: 0x00155C40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.O_0o0.OOO0.().Text, "", True) > 0 AndAlso (Me.OooO_ooo0_.___..o.0o00ooo_..Count <= 0 OrElse Operators.CompareString(Me.OooO_ooo0_.___..o.0o00ooo_.(0), Me.O_0o0.OOO0.().Text, True) <> 0) Then
				Me.OooO_ooo0_.___..o.0o00ooo_..Remove(Me.O_0o0.OOO0.().Text)
				Me.OooO_ooo0_.___..o.0o00ooo_..Insert(0, Me.O_0o0.OOO0.().Text)
				Me.O_0o0.OOO0.().Items.Clear()
				Try
					For Each text As String In Me.OooO_ooo0_.___..o.0o00ooo_.
						Me.O_0o0.OOO0.().Items.Add(text)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			Dim num As Integer = Me.O._0_O0O_.(Me.OooO_ooo0_.___..foxGrid.Row + 1, Me.OooO_ooo0_.___..foxGrid.Rows.Count - 1)
			If num = -1 Then
				num = Me.O._0_O0O_.(Me.OooO_ooo0_.___..foxGrid.Rows.Fixed, Me.OooO_ooo0_.___..foxGrid.Row - 1)
			End If
			If num > -1 Then
				Me.OooO_ooo0_.___..foxGrid.Row = num
			Else
				MessageBox.Show("没有找到符合条件的行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
			Me.OooO_ooo0_.___. = num
		End Sub

		' Token: 0x06003425 RID: 13349 RVA: 0x00157BD8 File Offset: 0x00155DD8
		Private Overloads Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Integer
			Dim num As Integer
			Dim result As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = Me.O_0o0.OOO0.().Text
				IL_16:
				num2 = 3
				Dim num3 As Integer = Me.OooO_ooo0_.___..foxGrid.Cols.IndexOf(Me.OooO_ooo0_.___.(Me.o0Ooo_.oO0.().Text))
				IL_45:
				num2 = 4
				Dim num4 As Integer = -1
				IL_4A:
				num2 = 5
				o0o\u3002.OooO_ooo0_.___. = Me.ooO_o_._o.().Checked
				IL_5C:
				num2 = 6
				o0o\u3002.o00__.O_. = Me.o_o___.OOOO.().SelectedIndex
				IL_6E:
				num2 = 7
				For i As Integer = A_0 To A_1
					IL_7B:
					num2 = 8
					If Me.OooO_ooo0_.___..foxGrid.Rows(i).DataIndex <> -1 Then
						IL_9F:
						num2 = 10
						If Operators.CompareString(text, "", True) = 0 AndAlso Me.OooO_ooo0_.___..foxGrid.GetData(i, num3) Is DBNull.Value Then
							IL_CC:
							num2 = 11
							num4 = i
							Exit For
						End If
						IL_D8:
						num2 = 13
						Dim text2 As String = Me.OooO_ooo0_.___..foxGrid.GetData(i, num3).ToString()
						IL_F6:
						num2 = 14
						Select Case o0o\u3002.o00__.O_.
							Case 0
								IL_11C:
								num2 = 16
								If String.Compare(text2, text, Not o0o\u3002.OooO_ooo0_.___.) = 0 Then
									IL_135:
									num2 = 17
									num4 = i
									GoTo IL_248
								End If
							Case 1
								IL_141:
								num2 = 20
								If Operators.CompareString(text, "", True) = 0 Then
									GoTo IL_248
								End If
								IL_156:
								num2 = 23
								If o0o\u3002.OooO_ooo0_.___. Then
									IL_160:
									num2 = 24
									If text2.StartsWith(text) Then
										IL_171:
										num2 = 25
										num4 = i
										GoTo IL_248
									End If
								Else
									IL_17D:
									num2 = 28
									If text2.StartsWith(text, StringComparison.CurrentCultureIgnoreCase) Then
										IL_18F:
										num2 = 29
										num4 = i
										GoTo IL_248
									End If
								End If
							Case 2
								IL_19B:
								num2 = 32
								If Operators.CompareString(text, "", True) = 0 Then
									GoTo IL_248
								End If
								IL_1B0:
								num2 = 35
								If o0o\u3002.OooO_ooo0_.___. Then
									IL_1BA:
									num2 = 36
									If text2.EndsWith(text) Then
										IL_1C8:
										num2 = 37
										num4 = i
										GoTo IL_248
									End If
								Else
									IL_1D1:
									num2 = 40
									If text2.EndsWith(text, StringComparison.CurrentCultureIgnoreCase) Then
										IL_1E0:
										num2 = 41
										num4 = i
										GoTo IL_248
									End If
								End If
							Case 3
								IL_1E9:
								num2 = 44
								If Operators.CompareString(text, "", True) = 0 Then
									GoTo IL_248
								End If
								IL_1FB:
								num2 = 47
								If o0o\u3002.OooO_ooo0_.___. Then
									IL_205:
									num2 = 48
									If text2.IndexOf(text) >= 0 Then
										IL_214:
										num2 = 49
										num4 = i
										GoTo IL_248
									End If
								Else
									IL_21D:
									num2 = 52
									If text2.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
										IL_22D:
										num2 = 53
										num4 = i
										GoTo IL_248
									End If
								End If
						End Select
					End If
					IL_236:
					num2 = 56
				Next
				IL_248:
				num2 = 57
				Me.OooO_ooo0_.___..foxGrid.Col = num3
				IL_25D:
				num2 = 58
				result = num4
				IL_263:
				GoTo IL_3A1
				IL_268:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_362:
				GoTo IL_396
				IL_364:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_374:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_364
			End Try
			IL_396:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3A1:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003426 RID: 13350 RVA: 0x00157FAC File Offset: 0x001561AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OooO_ooo0_.___. = -1
		End Sub

		' Token: 0x06003427 RID: 13351 RVA: 0x00157FB5 File Offset: 0x001561B5
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OooO_ooo0_.___. = -1
		End Sub

		' Token: 0x06003428 RID: 13352 RVA: 0x00157FBE File Offset: 0x001561BE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OooO_ooo0_.___. = -1
		End Sub

		' Token: 0x06003429 RID: 13353 RVA: 0x00157FC7 File Offset: 0x001561C7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OooO_ooo0_.___. = -1
		End Sub

		' Token: 0x0600342A RID: 13354 RVA: 0x00157FD0 File Offset: 0x001561D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OooO_ooo0_.___. = Me.OooO_ooo0_.___..foxGrid.Row Then
				Me.oO.o_o_0.(Nothing)
			End If
			Me.ooO_o_._o.().PerformClick()
		End Sub

		' Token: 0x0600342B RID: 13355 RVA: 0x00158000 File Offset: 0x00156200
		Private Function <<EMPTY_NAME>>(Optional A_0 As O0__000O = Nothing) As Boolean
			o0o\u3002.Oo._o_. = Me.O00O0.0o_ooOOo.().SelectedIndex
			If Operators.CompareString(Me.ooO_o_._o.().Text, "", True) > 0 AndAlso (Me.OooO_ooo0_.___..o.OOoo_o..Count <= 0 OrElse Operators.CompareString(Me.OooO_ooo0_.___..o.OOoo_o.(0), Me.ooO_o_._o.().Text, True) <> 0) Then
				Me.OooO_ooo0_.___..o.OOoo_o..Remove(Me.ooO_o_._o.().Text)
				Me.OooO_ooo0_.___..o.OOoo_o..Insert(0, Me.ooO_o_._o.().Text)
				Me.ooO_o_._o.().Items.Clear()
				Try
					For Each text As String In Me.OooO_ooo0_.___..o.OOoo_o.
						Me.ooO_o_._o.().Items.Add(text)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			Dim num As Integer = Me.OooO_ooo0_.___..foxGrid.Cols.IndexOf(Me.OooO_ooo0_.___.(Me.o0Ooo_.oO0.().Text))
			Dim result As Boolean
			If Me.OooO_ooo0_.___. = -1 OrElse Me.OooO_ooo0_.___..foxGrid.Rows(Me.OooO_ooo0_.___.).DataIndex = -1 Then
				result = False
			ElseIf Not Me.OooO_ooo0_.___..foxGrid.o000OOo.OO.(Me.OooO_ooo0_.___., num) Then
				result = False
			Else
				If A_0 Is Nothing Then
					Me.OooO_ooo0_.___..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.OooO_ooo0_.___., Me.OooO_ooo0_.___..View.O0O_0_0__.0O.(Me.OooO_ooo0_.___..foxGrid.Rows(Me.OooO_ooo0_.___.).DataIndex).Row, Me.OooO_ooo0_.___..foxGrid.Cols(num).Name))
				Else
					A_0.Ooo._O.(Me.OooO_ooo0_.___..View.O0O_0_0__.0O.(Me.OooO_ooo0_.___..foxGrid.Rows(Me.OooO_ooo0_.___.).DataIndex).Row)
				End If
				Dim row As DataRow = CType(Me.OooO_ooo0_.___..foxGrid.Rows(Me.OooO_ooo0_.___.).DataSource, DataRowView).Row
				Dim column As DataColumn = row.Table.Columns(Me.OooO_ooo0_.___..foxGrid.Cols(num).Name)
				Try
					If o0o\u3002.Oo._o_. = 0 Then
						row(column) = Me.ooO_o_._o.().Text
					Else
						Dim text2 As String = Me.OooO_ooo0_.___..foxGrid(Me.OooO_ooo0_.___., num).ToString()
						Dim text3 As String = Me.O_0o0.OOO0.().Text
						Dim text4 As String = Me.ooO_o_._o.().Text
						Select Case Me.o_o___.OOOO.().SelectedIndex
							Case 0
								row(column) = text4
							Case 1
								row(column) = text4 + text2.Substring(text3.Length)
							Case 2
								row(column) = text2.Substring(0, text2.Length - text3.Length) + text4
							Case 3
								row(column) = text2.Replace(text3, text4)
						End Select
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
					A_0.o_ooo.OO0ooo_.()
					Return False
				End Try
				Me.OooO_ooo0_.___..foxGrid.O.O0_0.(Me.OooO_ooo0_.___., num, Nothing)
				result = True
			End If
			Return result
		End Function

		' Token: 0x0600342C RID: 13356 RVA: 0x001583C0 File Offset: 0x001565C0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o0__000O As O0__000O = New O0__000O(Me.OooO_ooo0_.___., Me.OooO_ooo0_.___.(Me.o0Ooo_.oO0.().Text))
			Me.OooO_ooo0_.___. = Me.O._0_O0O_.(Me.OooO_ooo0_.___..foxGrid.Rows.Fixed, Me.OooO_ooo0_.___..foxGrid.Rows.Count - 1)
			Dim num As Integer
			While Me.OooO_ooo0_.___. > -1
				If Not Me.oO.o_o_0.(o0__000O) Then
					Return
				End If
				num += 1
				Me.OooO_ooo0_.___. = Me.O._0_O0O_.(Me.OooO_ooo0_.___. + 1, Me.OooO_ooo0_.___..foxGrid.Rows.Count - 1)
			End While
			If o0__000O.Ooo._O.() > 0 Then
				Me.OooO_ooo0_.___..O_o0OOo_.o0..O__00.__0_O.(o0__000O)
			End If
			MessageBox.Show("总共替换" + Conversions.ToString(num) + "处！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x04001530 RID: 5424
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001531 RID: 5425
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001532 RID: 5426
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001533 RID: 5427
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001534 RID: 5428
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001535 RID: 5429
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001536 RID: 5430
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001537 RID: 5431
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001538 RID: 5432
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001539 RID: 5433
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400153A RID: 5434
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400153B RID: 5435
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400153C RID: 5436
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400153D RID: 5437
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400153E RID: 5438
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400153F RID: 5439
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001540 RID: 5440
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001541 RID: 5441
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001542 RID: 5442
		Private Shared <<EMPTY_NAME>> As Integer = 0

		' Token: 0x04001543 RID: 5443
		Private Shared <<EMPTY_NAME>> As Integer = 0

		' Token: 0x04001544 RID: 5444
		Private Shared <<EMPTY_NAME>> As Boolean = True

		' Token: 0x04001545 RID: 5445
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
