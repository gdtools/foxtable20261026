Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003EF RID: 1007
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u3002\u3002\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06003F6D RID: 16237 RVA: 0x001B9578 File Offset: 0x001B7778
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o._O0o_. IsNot Nothing Then
					Me.o._O0o_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003F6E RID: 16238 RVA: 0x001B95B8 File Offset: 0x001B77B8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oOo_O__.o0oO.(New C1Button())
			Me.o_o0.__.(New C1Button())
			Me.OO0OO_o.OOOo.(New GroupBox())
			Me.o0.oo0oO00_O_.(New Label())
			Me.OO0OO_o.OOOo.(New C1ComboBox())
			Me.O0O_oOO.OOO.(New Label())
			Me.o_o0.__.(New C1ComboBox())
			Me.ooo00_OOOO._0O.(New Label())
			Me.oOo_O__.o0oO.(New C1ComboBox())
			Me.oOo_O__.o0oO.(New GroupBox())
			Me.ooo0O0Oo_.O0OO.(New C1TextBox())
			Me.OO.O_OO_o.(New Label())
			Me.O0__._O__O_oo.(New C1TextBox())
			Me.O0_.__OOO_.(New Label())
			Me.Oooo0.OOO.(New C1TextBox())
			Me.O._O_o.(New Label())
			Me.O._0O0Oo.(New C1TextBox())
			Me.o00OOOooO0.0__.(New Label())
			Me.O0.oo_oo0_o_0_.(New GroupBox())
			Me.OO.O_OO_o.(New RadioButton())
			Me.o.o__O0.(New RadioButton())
			Me.o_o0.__.(New GroupBox())
			Me.oooO0.0.(New C1TextBox())
			Me.OOooOoo.0.(New Label())
			Me.oooo.0.(New C1TextBox())
			Me.o.o__O0.(New Label())
			Me.O.O_o_0_oo_0_O.().SuspendLayout()
			Me.Oo.O_0__oOo_.().SuspendLayout()
			Me.ooo__0oO_._O_.().SuspendLayout()
			Me.OO00_0_0_.O.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.ooo__0oO_._O_.().Location = New Point(114, 328)
			Me.ooo__0oO_._O_.().Name = "btnOK"
			Me.ooo__0oO_._O_.().Size = New Size(75, 23)
			Me.ooo__0oO_._O_.().TabIndex = 8
			Me.ooo__0oO_._O_.().Text = "确定"
			Me.ooo__0oO_._O_.().UseVisualStyleBackColor = True
			Me.ooo0Oo__.0_o_o.().DialogResult = DialogResult.Cancel
			Me.ooo0Oo__.0_o_o.().Location = New Point(195, 328)
			Me.ooo0Oo__.0_o_o.().Name = "Button2"
			Me.ooo0Oo__.0_o_o.().Size = New Size(75, 23)
			Me.ooo0Oo__.0_o_o.().TabIndex = 9
			Me.ooo0Oo__.0_o_o.().Text = "取消"
			Me.ooo0Oo__.0_o_o.().UseVisualStyleBackColor = True
			Me.O.O_o_0_oo_0_O.().Controls.Add(Me.oO.o0_O0_.())
			Me.O.O_o_0_oo_0_O.().Controls.Add(Me.ooo__0oO_._O_.())
			Me.O.O_o_0_oo_0_O.().Controls.Add(Me.o_0O_0_oOoo.OO.())
			Me.O.O_o_0_oo_0_O.().Controls.Add(Me.ooo0Oo__.0_o_o.())
			Me.O.O_o_0_oo_0_O.().Controls.Add(Me.o0o.0O0o0.())
			Me.O.O_o_0_oo_0_O.().Controls.Add(Me.OO00_0_0_.O.())
			Me.O.O_o_0_oo_0_O.().Location = New Point(16, 12)
			Me.O.O_o_0_oo_0_O.().Name = "GroupBox8"
			Me.O.O_o_0_oo_0_O.().Size = New Size(353, 112)
			Me.O.O_o_0_oo_0_O.().TabIndex = 10
			Me.O.O_o_0_oo_0_O.().TabStop = False
			Me.O.O_o_0_oo_0_O.().Text = "纸张"
			Me.oO.o0_O0_.().AutoSize = True
			Me.oO.o0_O0_.().Location = New Point(19, 24)
			Me.oO.o0_O0_.().Name = "Label9"
			Me.oO.o0_O0_.().Size = New Size(47, 12)
			Me.oO.o0_O0_.().TabIndex = 6
			Me.oO.o0_O0_.().Text = "打印机:"
			Me.ooo__0oO_._O_.().DropDownStyle = 1
			Me.ooo__0oO_._O_.().Location = New Point(72, 20)
			Me.ooo__0oO_._O_.().Name = "cmbPrinters"
			Me.ooo__0oO_._O_.().Size = New Size(245, 20)
			Me.ooo__0oO_._O_.().TabIndex = 0
			Me.o_0O_0_oOoo.OO.().AutoSize = True
			Me.o_0O_0_oOoo.OO.().Location = New Point(19, 53)
			Me.o_0O_0_oOoo.OO.().Name = "Label1"
			Me.o_0O_0_oOoo.OO.().Size = New Size(47, 12)
			Me.o_0O_0_oOoo.OO.().TabIndex = 4
			Me.o_0O_0_oOoo.OO.().Text = "进纸盒:"
			Me.ooo0Oo__.0_o_o.().DropDownStyle = 1
			Me.ooo0Oo__.0_o_o.().Location = New Point(72, 49)
			Me.ooo0Oo__.0_o_o.().Name = "cmbPaperSource"
			Me.ooo0Oo__.0_o_o.().Size = New Size(245, 20)
			Me.ooo0Oo__.0_o_o.().TabIndex = 1
			Me.o0o.0O0o0.().AutoSize = True
			Me.o0o.0O0o0.().Location = New Point(19, 82)
			Me.o0o.0O0o0.().Name = "Label2"
			Me.o0o.0O0o0.().Size = New Size(47, 12)
			Me.o0o.0O0o0.().TabIndex = 2
			Me.o0o.0O0o0.().Text = "纸  张:"
			Me.OO00_0_0_.O.().DropDownStyle = 1
			Me.OO00_0_0_.O.().Location = New Point(72, 78)
			Me.OO00_0_0_.O.().Name = "cmbPaperSize"
			Me.OO00_0_0_.O.().Size = New Size(245, 20)
			Me.OO00_0_0_.O.().TabIndex = 2
			Me.Oo.O_0__oOo_.().Controls.Add(Me.Oo_0.o_0oO_0o.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.oo.000_.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.O.OOoO0_.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.O_.oo___.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.o0O0O.0OOO.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.Oo.O_0__oOo_.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.oO.o0_O0_.())
			Me.Oo.O_0__oOo_.().Controls.Add(Me.O.O_o_0_oo_0_O.())
			Me.Oo.O_0__oOo_.().Location = New Point(136, 222)
			Me.Oo.O_0__oOo_.().Name = "GroupBox3"
			Me.Oo.O_0__oOo_.().Size = New Size(233, 86)
			Me.Oo.O_0__oOo_.().TabIndex = 13
			Me.Oo.O_0__oOo_.().TabStop = False
			Me.Oo.O_0__oOo_.().Text = "页边距(毫米)"
			Me.Oo_0.o_0oO_0o.().Location = New Point(145, 50)
			Me.Oo_0.o_0oO_0o.().Name = "txtBottomMargin"
			Me.Oo_0.o_0oO_0o.().Size = New Size(52, 21)
			Me.Oo_0.o_0oO_0o.().TabIndex = 3
			Me.oo.000_.().AutoSize = True
			Me.oo.000_.().Location = New Point(116, 54)
			Me.oo.000_.().Name = "Label7"
			Me.oo.000_.().Size = New Size(23, 12)
			Me.oo.000_.().TabIndex = 6
			Me.oo.000_.().Text = "下:"
			Me.O.OOoO0_.().Location = New Point(50, 50)
			Me.O.OOoO0_.().Name = "txtTopMargin"
			Me.O.OOoO0_.().Size = New Size(52, 21)
			Me.O.OOoO0_.().TabIndex = 2
			Me.O_.oo___.().AutoSize = True
			Me.O_.oo___.().Location = New Point(21, 54)
			Me.O_.oo___.().Name = "Label8"
			Me.O_.oo___.().Size = New Size(23, 12)
			Me.O_.oo___.().TabIndex = 4
			Me.O_.oo___.().Text = "上:"
			Me.o0O0O.0OOO.().Location = New Point(145, 23)
			Me.o0O0O.0OOO.().Name = "txtRightMargin"
			Me.o0O0O.0OOO.().Size = New Size(52, 21)
			Me.o0O0O.0OOO.().TabIndex = 1
			Me.Oo.O_0__oOo_.().AutoSize = True
			Me.Oo.O_0__oOo_.().Location = New Point(116, 27)
			Me.Oo.O_0__oOo_.().Name = "Label6"
			Me.Oo.O_0__oOo_.().Size = New Size(23, 12)
			Me.Oo.O_0__oOo_.().TabIndex = 2
			Me.Oo.O_0__oOo_.().Text = "右:"
			Me.oO.o0_O0_.().Location = New Point(50, 23)
			Me.oO.o0_O0_.().Name = "txtLeftMargin"
			Me.oO.o0_O0_.().Size = New Size(52, 21)
			Me.oO.o0_O0_.().TabIndex = 0
			Me.O.O_o_0_oo_0_O.().AutoSize = True
			Me.O.O_o_0_oo_0_O.().Location = New Point(21, 27)
			Me.O.O_o_0_oo_0_O.().Name = "Label5"
			Me.O.O_o_0_oo_0_O.().Size = New Size(23, 12)
			Me.O.O_o_0_oo_0_O.().TabIndex = 0
			Me.O.O_o_0_oo_0_O.().Text = "左:"
			Me.ooo__0oO_._O_.().Controls.Add(Me.o0O0O.0OOO.())
			Me.ooo__0oO_._O_.().Controls.Add(Me.Oo_0.o_0oO_0o.())
			Me.ooo__0oO_._O_.().Location = New Point(16, 222)
			Me.ooo__0oO_._O_.().Name = "GroupBox2"
			Me.ooo__0oO_._O_.().Size = New Size(100, 86)
			Me.ooo__0oO_._O_.().TabIndex = 12
			Me.ooo__0oO_._O_.().TabStop = False
			Me.ooo__0oO_._O_.().Text = "方向"
			Me.o0O0O.0OOO.().AutoSize = True
			Me.o0O0O.0OOO.().Location = New Point(19, 50)
			Me.o0O0O.0OOO.().Name = "rdoLandScape"
			Me.o0O0O.0OOO.().Size = New Size(47, 16)
			Me.o0O0O.0OOO.().TabIndex = 1
			Me.o0O0O.0OOO.().Text = "横向"
			Me.o0O0O.0OOO.().UseVisualStyleBackColor = True
			Me.Oo_0.o_0oO_0o.().AutoSize = True
			Me.Oo_0.o_0oO_0o.().Checked = True
			Me.Oo_0.o_0oO_0o.().Location = New Point(19, 21)
			Me.Oo_0.o_0oO_0o.().Name = "RadioButton1"
			Me.Oo_0.o_0oO_0o.().Size = New Size(47, 16)
			Me.Oo_0.o_0oO_0o.().TabIndex = 0
			Me.Oo_0.o_0oO_0o.().TabStop = True
			Me.Oo_0.o_0oO_0o.().Text = "纵向"
			Me.Oo_0.o_0oO_0o.().UseVisualStyleBackColor = True
			Me.OO00_0_0_.O.().Controls.Add(Me.O.____0o.())
			Me.OO00_0_0_.O.().Controls.Add(Me.OoO0O._o0.())
			Me.OO00_0_0_.O.().Controls.Add(Me.o0.0O_0_.())
			Me.OO00_0_0_.O.().Controls.Add(Me.o0_o__O_oo.0O.())
			Me.OO00_0_0_.O.().Location = New Point(16, 144)
			Me.OO00_0_0_.O.().Name = "GroupBox1"
			Me.OO00_0_0_.O.().Size = New Size(353, 59)
			Me.OO00_0_0_.O.().TabIndex = 11
			Me.OO00_0_0_.O.().TabStop = False
			Me.OO00_0_0_.O.().Text = "自定义尺寸(毫米)"
			Me.O.____0o.().Location = New Point(231, 24)
			Me.O.____0o.().Name = "txtPaperHeight"
			Me.O.____0o.().[ReadOnly] = True
			Me.O.____0o.().Size = New Size(100, 21)
			Me.O.____0o.().TabIndex = 1
			Me.OoO0O._o0.().AutoSize = True
			Me.OoO0O._o0.().Location = New Point(189, 28)
			Me.OoO0O._o0.().Name = "Label4"
			Me.OoO0O._o0.().Size = New Size(35, 12)
			Me.OoO0O._o0.().TabIndex = 2
			Me.OoO0O._o0.().Text = "高度:"
			Me.o0.0O_0_.().Location = New Point(56, 24)
			Me.o0.0O_0_.().Name = "txtPaperWidth"
			Me.o0.0O_0_.().[ReadOnly] = True
			Me.o0.0O_0_.().Size = New Size(100, 21)
			Me.o0.0O_0_.().TabIndex = 0
			Me.o0_o__O_oo.0O.().AutoSize = True
			Me.o0_o__O_oo.0O.().Location = New Point(15, 28)
			Me.o0_o__O_oo.0O.().Name = "Label3"
			Me.o0_o__O_oo.0O.().Size = New Size(35, 12)
			Me.o0_o__O_oo.0O.().TabIndex = 0
			Me.o0_o__O_oo.0O.().Text = "宽度:"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(384, 363)
			MyBase.Controls.Add(Me.O.O_o_0_oo_0_O.())
			MyBase.Controls.Add(Me.Oo.O_0__oOo_.())
			MyBase.Controls.Add(Me.ooo__0oO_._O_.())
			MyBase.Controls.Add(Me.OO00_0_0_.O.())
			MyBase.Controls.Add(Me.ooo0Oo__.0_o_o.())
			MyBase.Controls.Add(Me.ooo__0oO_._O_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o...00.."
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.CenterParent
			Me.Text = "页面设置"
			Me.O.O_o_0_oo_0_O.().ResumeLayout(False)
			Me.O.O_o_0_oo_0_O.().PerformLayout()
			Me.Oo.O_0__oOo_.().ResumeLayout(False)
			Me.Oo.O_0__oOo_.().PerformLayout()
			Me.ooo__0oO_._O_.().ResumeLayout(False)
			Me.ooo__0oO_._O_.().PerformLayout()
			Me.OO00_0_0_.O.().ResumeLayout(False)
			Me.OO00_0_0_.O.().PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003F6F RID: 16239 RVA: 0x001BA374 File Offset: 0x001B8574
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oooO0.0.
		End Function

		' Token: 0x06003F70 RID: 16240 RVA: 0x001BA37C File Offset: 0x001B857C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00__.O_.
			Dim c1Button As C1Button = Me.oooO0.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oooO0.0. = A_0
			c1Button = Me.oooO0.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003F71 RID: 16241 RVA: 0x001BA3BF File Offset: 0x001B85BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._0O0Oo.
		End Function

		' Token: 0x06003F72 RID: 16242 RVA: 0x001BA3C7 File Offset: 0x001B85C7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O._0O0Oo. = A_0
		End Sub

		' Token: 0x06003F73 RID: 16243 RVA: 0x001BA3D0 File Offset: 0x001B85D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.oo.o_O.
		End Function

		' Token: 0x06003F74 RID: 16244 RVA: 0x001BA3D8 File Offset: 0x001B85D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.oo.o_O. = A_0
		End Sub

		' Token: 0x06003F75 RID: 16245 RVA: 0x001BA3E1 File Offset: 0x001B85E1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo.o_O.
		End Function

		' Token: 0x06003F76 RID: 16246 RVA: 0x001BA3E9 File Offset: 0x001B85E9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo.o_O. = A_0
		End Sub

		' Token: 0x06003F77 RID: 16247 RVA: 0x001BA3F2 File Offset: 0x001B85F2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oo.o_O.
		End Function

		' Token: 0x06003F78 RID: 16248 RVA: 0x001BA3FA File Offset: 0x001B85FA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.oo.o_O. = A_0
		End Sub

		' Token: 0x06003F79 RID: 16249 RVA: 0x001BA403 File Offset: 0x001B8603
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_OOO._Oo0.
		End Function

		' Token: 0x06003F7A RID: 16250 RVA: 0x001BA40B File Offset: 0x001B860B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_OOO._Oo0. = A_0
		End Sub

		' Token: 0x06003F7B RID: 16251 RVA: 0x001BA414 File Offset: 0x001B8614
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O._0O0Oo.
		End Function

		' Token: 0x06003F7C RID: 16252 RVA: 0x001BA41C File Offset: 0x001B861C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.Oo._o_.
			Dim o._0O0Oo. As C1ComboBox = Me.O._0O0Oo.
			If o._0O0Oo. IsNot Nothing Then
				o._0O0Oo..SelectedIndexChanged -= eventHandler
			End If
			Me.O._0O0Oo. = A_0
			o._0O0Oo. = Me.O._0O0Oo.
			If o._0O0Oo. IsNot Nothing Then
				o._0O0Oo..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06003F7D RID: 16253 RVA: 0x001BA45F File Offset: 0x001B865F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.o_OOO._Oo0.
		End Function

		' Token: 0x06003F7E RID: 16254 RVA: 0x001BA467 File Offset: 0x001B8667
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.o_OOO._Oo0. = A_0
		End Sub

		' Token: 0x06003F7F RID: 16255 RVA: 0x001BA470 File Offset: 0x001B8670
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OoO0__00.0OO__.
		End Function

		' Token: 0x06003F80 RID: 16256 RVA: 0x001BA478 File Offset: 0x001B8678
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OoO0__00.0OO__. = A_0
		End Sub

		' Token: 0x06003F81 RID: 16257 RVA: 0x001BA481 File Offset: 0x001B8681
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOO0.___Oo_o_O.
		End Function

		' Token: 0x06003F82 RID: 16258 RVA: 0x001BA489 File Offset: 0x001B8689
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOO0.___Oo_o_O. = A_0
		End Sub

		' Token: 0x06003F83 RID: 16259 RVA: 0x001BA492 File Offset: 0x001B8692
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_0.0__O.
		End Function

		' Token: 0x06003F84 RID: 16260 RVA: 0x001BA49A File Offset: 0x001B869A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_0.0__O. = A_0
		End Sub

		' Token: 0x06003F85 RID: 16261 RVA: 0x001BA4A3 File Offset: 0x001B86A3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.__0O_0_0.
		End Function

		' Token: 0x06003F86 RID: 16262 RVA: 0x001BA4AB File Offset: 0x001B86AB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.__0O_0_0. = A_0
		End Sub

		' Token: 0x06003F87 RID: 16263 RVA: 0x001BA4B4 File Offset: 0x001B86B4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O0.O00.
		End Function

		' Token: 0x06003F88 RID: 16264 RVA: 0x001BA4BC File Offset: 0x001B86BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O0.O00. = A_0
		End Sub

		' Token: 0x06003F89 RID: 16265 RVA: 0x001BA4C5 File Offset: 0x001B86C5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo._0_o.
		End Function

		' Token: 0x06003F8A RID: 16266 RVA: 0x001BA4CD File Offset: 0x001B86CD
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo._0_o. = A_0
		End Sub

		' Token: 0x06003F8B RID: 16267 RVA: 0x001BA4D6 File Offset: 0x001B86D6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O.__0O_0_0.
		End Function

		' Token: 0x06003F8C RID: 16268 RVA: 0x001BA4DE File Offset: 0x001B86DE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O.__0O_0_0. = A_0
		End Sub

		' Token: 0x06003F8D RID: 16269 RVA: 0x001BA4E7 File Offset: 0x001B86E7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO0_.O.
		End Function

		' Token: 0x06003F8E RID: 16270 RVA: 0x001BA4EF File Offset: 0x001B86EF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO0_.O. = A_0
		End Sub

		' Token: 0x06003F8F RID: 16271 RVA: 0x001BA4F8 File Offset: 0x001B86F8
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As GroupBox
			Return Me.Oo0o.o_.
		End Function

		' Token: 0x06003F90 RID: 16272 RVA: 0x001BA500 File Offset: 0x001B8700
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.Oo0o.o_. = A_0
		End Sub

		' Token: 0x06003F91 RID: 16273 RVA: 0x001BA509 File Offset: 0x001B8709
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.OoO0__00.0OO__.
		End Function

		' Token: 0x06003F92 RID: 16274 RVA: 0x001BA511 File Offset: 0x001B8711
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.OoO0__00.0OO__. = A_0
		End Sub

		' Token: 0x06003F93 RID: 16275 RVA: 0x001BA51A File Offset: 0x001B871A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Oo0OO0_.0_o_.
		End Function

		' Token: 0x06003F94 RID: 16276 RVA: 0x001BA522 File Offset: 0x001B8722
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.Oo0OO0_.0_o_. = A_0
		End Sub

		' Token: 0x06003F95 RID: 16277 RVA: 0x001BA52B File Offset: 0x001B872B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.o_.__o_Oo_0.
		End Function

		' Token: 0x06003F96 RID: 16278 RVA: 0x001BA533 File Offset: 0x001B8733
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.o_.__o_Oo_0. = A_0
		End Sub

		' Token: 0x06003F97 RID: 16279 RVA: 0x001BA53C File Offset: 0x001B873C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo._0_o.
		End Function

		' Token: 0x06003F98 RID: 16280 RVA: 0x001BA544 File Offset: 0x001B8744
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.Oo._0_o. = A_0
		End Sub

		' Token: 0x06003F99 RID: 16281 RVA: 0x001BA54D File Offset: 0x001B874D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_OO0O._0O0OO_.
		End Function

		' Token: 0x06003F9A RID: 16282 RVA: 0x001BA555 File Offset: 0x001B8755
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_OO0O._0O0OO_. = A_0
		End Sub

		' Token: 0x06003F9B RID: 16283 RVA: 0x001BA55E File Offset: 0x001B875E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O.0_o_0.
		End Function

		' Token: 0x06003F9C RID: 16284 RVA: 0x001BA566 File Offset: 0x001B8766
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O.0_o_0. = A_0
		End Sub

		' Token: 0x06003F9D RID: 16285 RVA: 0x001BA56F File Offset: 0x001B876F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooOo0_.0o.
		End Function

		' Token: 0x06003F9E RID: 16286 RVA: 0x001BA577 File Offset: 0x001B8777
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooOo0_.0o. = A_0
		End Sub

		' Token: 0x06003F9F RID: 16287 RVA: 0x001BA580 File Offset: 0x001B8780
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOOOo.__0o__0_.
		End Function

		' Token: 0x06003FA0 RID: 16288 RVA: 0x001BA588 File Offset: 0x001B8788
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OOOOo.__0o__0_. = A_0
		End Sub

		' Token: 0x06003FA1 RID: 16289 RVA: 0x001BA591 File Offset: 0x001B8791
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oo0o.o_.
		End Function

		' Token: 0x06003FA2 RID: 16290 RVA: 0x001BA59C File Offset: 0x001B879C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.OooO_ooo0_.___.
			Dim oo0o.o_. As C1ComboBox = Me.Oo0o.o_.
			If oo0o.o_. IsNot Nothing Then
				oo0o.o_..SelectedIndexChanged -= eventHandler
			End If
			Me.Oo0o.o_. = A_0
			oo0o.o_. = Me.Oo0o.o_.
			If oo0o.o_. IsNot Nothing Then
				oo0o.o_..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06003FA3 RID: 16291 RVA: 0x001BA5E0 File Offset: 0x001B87E0
		Public Sub New(A_0 As PrintPageProperty)
			AddHandler MyBase.Load, AddressOf Me.O0O._oo.
			AddHandler MyBase.FormClosed, AddressOf Me.ooo__0oO_._O_.
			Me.o._O0o_. = New PrinterSettings()
			Me.o0O0O.0OOO.()
			Me.o._O0o_. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003FA4 RID: 16292 RVA: 0x001BA644 File Offset: 0x001B8844
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each text As String In OO_00oOO.InstalledPrinters
					Me.ooo__0oO_._O_.().Items.Add(text)
					If Operators.CompareString(text, Me.o._O0o_..PrinterName, True) = 0 Then
						Me.ooo__0oO_._O_.().SelectedIndex = Me.ooo__0oO_._O_.().Items.Count - 1
					End If
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			If Me.ooo__0oO_._O_.().SelectedIndex = -1 Then
				Dim num As Integer = Me.ooo__0oO_._O_.().Items.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Me.ooo__0oO_._O_.().Items(i).ToString(), Me.o._O0o_..PrinterName, True) = 0 Then
						Me.ooo__0oO_._O_.().SelectedIndex = i
					End If
				Next
			End If
			Dim printPageProperty As PrintPageProperty = Me.o._O0o_.
			Me.o0.0O_0_.().[ReadOnly] = (Me.o._O0o_..PaperKind > PaperKind.Custom)
			Me.O.____0o.().[ReadOnly] = (Me.o._O0o_..PaperKind > PaperKind.Custom)
			Me.oO.o0_O0_.().Value = Me.o._O0o_..LeftMargin.ToString()
			Me.o0O0O.0OOO.().Value = Me.o._O0o_..RightMargin.ToString()
			Me.O.OOoO0_.().Value = Me.o._O0o_..TopMargin.ToString()
			Me.Oo_0.o_0oO_0o.().Value = Me.o._O0o_..BottomMargin.ToString()
			Me.o0O0O.0OOO.().Checked = printPageProperty.Landscape
		End Sub

		' Token: 0x06003FA5 RID: 16293 RVA: 0x001BA800 File Offset: 0x001B8A00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In Me.o._O0o_..PaperSizes
					Dim paperSize As PaperSize = CType(obj, PaperSize)
					If Operators.CompareString(paperSize.PaperName, Me.OO00_0_0_.O.().SelectedItem.ToString(), True) = 0 Then
						Me.oooO0.0.(paperSize)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.O.____0o.().[ReadOnly] = (Me.OO00_0_0_.O.().SelectedIndex <> Me.OO00_0_0_.O.().Items.Count - 1 OrElse Operators.CompareString(Me.OO00_0_0_.O.().SelectedItem.ToString(), "自定义", True) <> 0)
			Me.o0.0O_0_.().[ReadOnly] = Me.O.____0o.().[ReadOnly]
		End Sub

		' Token: 0x06003FA6 RID: 16294 RVA: 0x001BA8E4 File Offset: 0x001B8AE4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o._O0o_..PrinterName = Me.ooo__0oO_._O_.().SelectedItem.ToString()
			If Me.OO00_0_0_.O.().SelectedIndex = Me.OO00_0_0_.O.().Items.Count - 1 Then
				Me.o._O0o_..PaperKind = PaperKind.Custom
				If Me.o._O0o_..PaperKind = PaperKind.Custom Then
					Me.o._O0o_..Width = Convert.ToDouble(Conversion.Val(Me.o0.0O_0_.().Text))
					Me.o._O0o_..Height = Convert.ToDouble(Conversion.Val(Me.O.____0o.().Text))
				End If
			Else
				Try
					For Each obj As Object In Me.o._O0o_..PaperSizes
						Dim paperSize As PaperSize = CType(obj, PaperSize)
						If Operators.CompareString(paperSize.PaperName, Me.OO00_0_0_.O.().SelectedItem.ToString(), True) = 0 Then
							Me.o._O0o_..PaperKind = paperSize.Kind
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			If Me.ooo0Oo__.0_o_o.().SelectedItem IsNot Nothing Then
				Try
					For Each obj2 As Object In Me.o._O0o_..PaperSources
						Dim paperSource As PaperSource = CType(obj2, PaperSource)
						If Operators.CompareString(paperSource.SourceName, Me.ooo0Oo__.0_o_o.().SelectedItem.ToString(), True) = 0 Then
							Me.o._O0o_..PaperSourceKind = paperSource.Kind
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
			Dim printPageProperty As PrintPageProperty = Me.o._O0o_.
			printPageProperty.LeftMargin = Convert.ToDouble(Conversion.Val(Me.oO.o0_O0_.().Text))
			printPageProperty.RightMargin = Convert.ToDouble(Conversion.Val(Me.o0O0O.0OOO.().Text))
			printPageProperty.TopMargin = Convert.ToDouble(Conversion.Val(Me.O.OOoO0_.().Text))
			printPageProperty.BottomMargin = Convert.ToDouble(Conversion.Val(Me.Oo_0.o_0oO_0o.().Text))
			printPageProperty.Landscape = Me.o0O0O.0OOO.().Checked
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06003FA7 RID: 16295 RVA: 0x001BAB18 File Offset: 0x001B8D18
		Private Sub <<EMPTY_NAME>>(A_0 As PaperSize)
			If A_0.Kind <> PaperKind.Custom Then
				Me.o0.0O_0_.().Value = Math.Round(CDbl(A_0.Width) * 0.254, 2).ToString()
				Me.O.____0o.().Value = Math.Round(CDbl(A_0.Height) * 0.254, 2).ToString()
			End If
		End Sub

		' Token: 0x06003FA8 RID: 16296 RVA: 0x001BAB84 File Offset: 0x001B8D84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o._O0o_..PrinterName = Me.ooo__0oO_._O_.().SelectedItem.ToString()
			Me.OO00_0_0_.O.().Items.Clear()
			Me.ooo0Oo__.0_o_o.().Items.Clear()
			Try
				For Each obj As Object In Me.o._O0o_..PaperSizes
					Dim paperSize As PaperSize = CType(obj, PaperSize)
					Me.OO00_0_0_.O.().Items.Add(paperSize.PaperName)
					If paperSize.Kind = Me.o._O0o_..PaperKind Then
						Me.OO00_0_0_.O.().SelectedIndex = Me.OO00_0_0_.O.().Items.Count - 1
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.OO00_0_0_.O.().Items.Add("自定义")
			If Me.o._O0o_..PaperKind = PaperKind.Custom Then
				Me.OO00_0_0_.O.().SelectedIndex = Me.OO00_0_0_.O.().Items.Count - 1
				Me.o0.0O_0_.().Value = Me.o._O0o_..Width.ToString()
				Me.O.____0o.().Value = Me.o._O0o_..Height.ToString()
			End If
			Try
				For Each obj2 As Object In Me.o._O0o_..PaperSources
					Dim paperSource As PaperSource = CType(obj2, PaperSource)
					Me.ooo0Oo__.0_o_o.().Items.Add(paperSource.SourceName)
					If paperSource.Kind = Me.o._O0o_..PaperSourceKind Then
						Me.ooo0Oo__.0_o_o.().SelectedIndex = Me.ooo0Oo__.0_o_o.().Items.Count - 1
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			If Me.ooo0Oo__.0_o_o.().SelectedIndex = -1 Then
				Dim num As Integer = Me.ooo0Oo__.0_o_o.().Items.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Me.ooo0Oo__.0_o_o.().Items(i).ToString(), Me.o._O0o_..DefaultPageSettings.PaperSource.SourceName, True) = 0 Then
						Me.ooo0Oo__.0_o_o.().SelectedIndex = i
					End If
				Next
			End If
			If Me.OO00_0_0_.O.().SelectedIndex = -1 Then
				Dim num2 As Integer = Me.OO00_0_0_.O.().Items.Count - 1
				For j As Integer = 0 To num2
					If Operators.CompareString(Me.OO00_0_0_.O.().Items(j).ToString(), Me.o._O0o_..DefaultPageSettings.PaperSize.PaperName, True) = 0 Then
						Me.OO00_0_0_.O.().SelectedIndex = j
					End If
				Next
			End If
		End Sub

		' Token: 0x06003FA9 RID: 16297 RVA: 0x001BAE58 File Offset: 0x001B9058
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001A3B RID: 6715
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001A3C RID: 6716
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001A3D RID: 6717
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001A3E RID: 6718
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001A3F RID: 6719
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A40 RID: 6720
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001A41 RID: 6721
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A42 RID: 6722
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001A43 RID: 6723
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001A44 RID: 6724
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001A45 RID: 6725
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A46 RID: 6726
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001A47 RID: 6727
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A48 RID: 6728
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001A49 RID: 6729
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A4A RID: 6730
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001A4B RID: 6731
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A4C RID: 6732
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001A4D RID: 6733
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001A4E RID: 6734
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001A4F RID: 6735
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001A50 RID: 6736
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001A51 RID: 6737
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A52 RID: 6738
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001A53 RID: 6739
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A54 RID: 6740
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001A55 RID: 6741
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001A56 RID: 6742
		Private <<EMPTY_NAME>> As PrintPageProperty

		' Token: 0x04001A57 RID: 6743
		Private <<EMPTY_NAME>> As PrinterSettings
	End Class
End Namespace
