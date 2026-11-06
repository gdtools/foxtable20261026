Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000D5 RID: 213
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class oo\u3002\u3000\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06000B3A RID: 2874 RVA: 0x00050840 File Offset: 0x0004EA40
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OOo__o_0OO.0. IsNot Nothing Then
					Me.OOo__o_0OO.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000B3B RID: 2875 RVA: 0x00050880 File Offset: 0x0004EA80
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o__.Oo_0.(New C1DockingTab())
			Me.ooO._00Oooo_.(New C1DockingTabPage())
			Me.o__.Oo_0.(New C1Button())
			Me.o.O0o_0O.(New C1TextBox())
			Me.ooO._00Oooo_.(New Label())
			Me.o____oO_.Oo00.(New C1Button())
			Me.O0O_0O_O__oo.0.(New C1Button())
			Me.o.O0o_0O.(New ListBox())
			Me.o__.Oo_0.(New C1DockingTabPage())
			Me.o__.Oo_0.(New Label())
			Me.o.o0o_.(New C1TextBox())
			Me.Oo__.0_O00o.(New Label())
			Me.oo000_.O_.(New C1TextBox())
			Me.OoOo._o00O.(New C1Button())
			Me.O0OOo.__O__0_o.(New C1Button())
			Me.oo000_.O_.(New ListBox())
			Me.o.o00OOoO0O00.(New C1Button())
			Me.O0_0o0oo.0.(New C1Button())
			Me.o__000.O.().BeginInit()
			Me.o__000.O.().SuspendLayout()
			Me.oOO0__O_.oo00.().SuspendLayout()
			Me.o__000.O.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.o__000.O.().Controls.Add(Me.oOO0__O_.oo00.())
			Me.o__000.O.().Controls.Add(Me.o__000.O.())
			Me.o__000.O.().Location = New Point(12, 12)
			Me.o__000.O.().Name = "C1DockingTab1"
			Me.o__000.O.().Size = New Size(368, 501)
			Me.o__000.O.().TabIndex = 0
			Me.o__000.O.().TabsSpacing = 0
			Me.o__000.O.().TabStyle = 1
			Me.o__000.O.().VisualStyle = 13
			Me.o__000.O.().VisualStyleBase = 13
			Me.oOO0__O_.oo00.().Controls.Add(Me.OOooo._o.())
			Me.oOO0__O_.oo00.().Controls.Add(Me.O0O_0O_O__oo.0.())
			Me.oOO0__O_.oo00.().Controls.Add(Me.O0O_0O_O__oo.0.())
			Me.oOO0__O_.oo00.().Controls.Add(Me.OO0o.o.())
			Me.oOO0__O_.oo00.().Controls.Add(Me.O_00_0_0.O0_oo.())
			Me.oOO0__O_.oo00.().Controls.Add(Me.OoOo._o00O.())
			Me.oOO0__O_.oo00.().Location = New Point(2, 26)
			Me.oOO0__O_.oo00.().Name = "C1DockingTabPage1"
			Me.oOO0__O_.oo00.().Size = New Size(362, 471)
			Me.oOO0__O_.oo00.().TabIndex = 0
			Me.oOO0__O_.oo00.().Text = "引用"
			Me.OOooo._o.().Location = New Point(16, 436)
			Me.OOooo._o.().Name = "btnSelectFile"
			Me.OOooo._o.().Size = New Size(75, 23)
			Me.OOooo._o.().TabIndex = 3
			Me.OOooo._o.().Text = "浏览..."
			Me.OOooo._o.().UseVisualStyleBackColor = True
			Me.O0O_0O_O__oo.0.().Location = New Point(16, 405)
			Me.O0O_0O_O__oo.0.().Name = "txtFile"
			Me.O0O_0O_O__oo.0.().Size = New Size(330, 21)
			Me.O0O_0O_O__oo.0.().TabIndex = 2
			Me.O0O_0O_O__oo.0.().AutoSize = True
			Me.O0O_0O_O__oo.0.().Location = New Point(16, 383)
			Me.O0O_0O_O__oo.0.().Name = "Label3"
			Me.O0O_0O_O__oo.0.().Size = New Size(35, 12)
			Me.O0O_0O_O__oo.0.().TabIndex = 1
			Me.O0O_0O_O__oo.0.().Text = "引用:"
			Me.OO0o.o.().Location = New Point(271, 436)
			Me.OO0o.o.().Name = "btnDeleteRefrence"
			Me.OO0o.o.().Size = New Size(75, 23)
			Me.OO0o.o.().TabIndex = 5
			Me.OO0o.o.().Text = "删除"
			Me.OO0o.o.().UseVisualStyleBackColor = True
			Me.O_00_0_0.O0_oo.().Location = New Point(190, 436)
			Me.O_00_0_0.O0_oo.().Name = "btnAddRefrence"
			Me.O_00_0_0.O0_oo.().Size = New Size(75, 23)
			Me.O_00_0_0.O0_oo.().TabIndex = 4
			Me.O_00_0_0.O0_oo.().Text = "添加"
			Me.O_00_0_0.O0_oo.().UseVisualStyleBackColor = True
			Me.OoOo._o00O.().FormattingEnabled = True
			Me.OoOo._o00O.().IntegralHeight = False
			Me.OoOo._o00O.().ItemHeight = 12
			Me.OoOo._o00O.().Location = New Point(16, 17)
			Me.OoOo._o00O.().Name = "lstRefrence"
			Me.OoOo._o00O.().Size = New Size(330, 352)
			Me.OoOo._o00O.().TabIndex = 0
			Me.o__000.O.().Controls.Add(Me.oOO0__O_.oo00.())
			Me.o__000.O.().Controls.Add(Me.Oo.O_0o0000.())
			Me.o__000.O.().Controls.Add(Me.o__000.O.())
			Me.o__000.O.().Controls.Add(Me.OoOo._o00O.())
			Me.o__000.O.().Controls.Add(Me.OOO_oo.__00.())
			Me.o__000.O.().Controls.Add(Me.O.0o__00oO0.())
			Me.o__000.O.().Controls.Add(Me.Oo.O_0o0000.())
			Me.o__000.O.().Location = New Point(2, 26)
			Me.o__000.O.().Name = "C1DockingTabPage2"
			Me.o__000.O.().Size = New Size(362, 471)
			Me.o__000.O.().TabIndex = 1
			Me.o__000.O.().Text = "命名空间"
			Me.oOO0__O_.oo00.().AutoSize = True
			Me.oOO0__O_.oo00.().Location = New Point(16, 406)
			Me.oOO0__O_.oo00.().Name = "Label2"
			Me.oOO0__O_.oo00.().Size = New Size(59, 12)
			Me.oOO0__O_.oo00.().TabIndex = 10
			Me.oOO0__O_.oo00.().Text = "空间别名:"
			Me.Oo.O_0o0000.().Location = New Point(81, 402)
			Me.Oo.O_0o0000.().Name = "txtAlias"
			Me.Oo.O_0o0000.().Size = New Size(265, 21)
			Me.Oo.O_0o0000.().TabIndex = 2
			Me.o__000.O.().AutoSize = True
			Me.o__000.O.().Location = New Point(16, 373)
			Me.o__000.O.().Name = "Label1"
			Me.o__000.O.().Size = New Size(59, 12)
			Me.o__000.O.().TabIndex = 8
			Me.o__000.O.().Text = "命名空间:"
			Me.OoOo._o00O.().Location = New Point(81, 369)
			Me.OoOo._o00O.().Name = "txtSpace"
			Me.OoOo._o00O.().Size = New Size(265, 21)
			Me.OoOo._o00O.().TabIndex = 1
			Me.OOO_oo.__00.().Location = New Point(271, 435)
			Me.OOO_oo.__00.().Name = "btnDeleteNameSpace"
			Me.OOO_oo.__00.().Size = New Size(75, 23)
			Me.OOO_oo.__00.().TabIndex = 4
			Me.OOO_oo.__00.().Text = "删除"
			Me.OOO_oo.__00.().UseVisualStyleBackColor = True
			Me.O.0o__00oO0.().Location = New Point(190, 435)
			Me.O.0o__00oO0.().Name = "btnAddNameSpace"
			Me.O.0o__00oO0.().Size = New Size(75, 23)
			Me.O.0o__00oO0.().TabIndex = 3
			Me.O.0o__00oO0.().Text = "添加"
			Me.O.0o__00oO0.().UseVisualStyleBackColor = True
			Me.Oo.O_0o0000.().FormattingEnabled = True
			Me.Oo.O_0o0000.().IntegralHeight = False
			Me.Oo.O_0o0000.().ItemHeight = 12
			Me.Oo.O_0o0000.().Location = New Point(16, 17)
			Me.Oo.O_0o0000.().Name = "lstNameSpace"
			Me.Oo.O_0o0000.().Size = New Size(330, 337)
			Me.Oo.O_0o0000.().TabIndex = 0
			Me.o__000.O.().Location = New Point(220, 527)
			Me.o__000.O.().Name = "Button5"
			Me.o__000.O.().Size = New Size(75, 23)
			Me.o__000.O.().TabIndex = 0
			Me.o__000.O.().Text = "确定"
			Me.o__000.O.().UseVisualStyleBackColor = True
			Me.oOO0__O_.oo00.().Location = New Point(301, 527)
			Me.oOO0__O_.oo00.().Name = "Button6"
			Me.oOO0__O_.oo00.().Size = New Size(75, 23)
			Me.oOO0__O_.oo00.().TabIndex = 1
			Me.oOO0__O_.oo00.().Text = "取消"
			Me.oOO0__O_.oo00.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(393, 562)
			MyBase.Controls.Add(Me.oOO0__O_.oo00.())
			MyBase.Controls.Add(Me.o__000.O.())
			MyBase.Controls.Add(Me.o__000.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.....o."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "外部引用"
			Me.o__000.O.().EndInit()
			Me.o__000.O.().ResumeLayout(False)
			Me.oOO0__O_.oo00.().ResumeLayout(False)
			Me.oOO0__O_.oo00.().PerformLayout()
			Me.o__000.O.().ResumeLayout(False)
			Me.o__000.O.().PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06000B3C RID: 2876 RVA: 0x0005129A File Offset: 0x0004F49A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.O_.O0_.
		End Function

		' Token: 0x06000B3D RID: 2877 RVA: 0x000512A2 File Offset: 0x0004F4A2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.O_.O0_. = A_0
		End Sub

		' Token: 0x06000B3E RID: 2878 RVA: 0x000512AB File Offset: 0x0004F4AB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_.O0_.
		End Function

		' Token: 0x06000B3F RID: 2879 RVA: 0x000512B3 File Offset: 0x0004F4B3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_.O0_. = A_0
		End Sub

		' Token: 0x06000B40 RID: 2880 RVA: 0x000512BC File Offset: 0x0004F4BC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.o_oo0.Ooo__O.
		End Function

		' Token: 0x06000B41 RID: 2881 RVA: 0x000512C4 File Offset: 0x0004F4C4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.o_oo0.Ooo__O. = A_0
		End Sub

		' Token: 0x06000B42 RID: 2882 RVA: 0x000512CD File Offset: 0x0004F4CD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.OOo__o_0OO.0.
		End Function

		' Token: 0x06000B43 RID: 2883 RVA: 0x000512D5 File Offset: 0x0004F4D5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.OOo__o_0OO.0. = A_0
		End Sub

		' Token: 0x06000B44 RID: 2884 RVA: 0x000512DE File Offset: 0x0004F4DE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.O0o_0O.
		End Function

		' Token: 0x06000B45 RID: 2885 RVA: 0x000512E8 File Offset: 0x0004F4E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo_oO.o00O0.
			Dim c1Button As C1Button = Me.o.O0o_0O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.O0o_0O. = A_0
			c1Button = Me.o.O0o_0O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000B46 RID: 2886 RVA: 0x0005132B File Offset: 0x0004F52B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo000_.O_.
		End Function

		' Token: 0x06000B47 RID: 2887 RVA: 0x00051334 File Offset: 0x0004F534
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_o__0_oO.o_.
			Dim c1Button As C1Button = Me.oo000_.O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo000_.O_. = A_0
			c1Button = Me.oo000_.O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000B48 RID: 2888 RVA: 0x00051377 File Offset: 0x0004F577
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o0o_.
		End Function

		' Token: 0x06000B49 RID: 2889 RVA: 0x00051380 File Offset: 0x0004F580
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o__.oO.
			Dim c1Button As C1Button = Me.o.o0o_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.o0o_. = A_0
			c1Button = Me.o.o0o_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000B4A RID: 2890 RVA: 0x000513C3 File Offset: 0x0004F5C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOO_.O0_0.
		End Function

		' Token: 0x06000B4B RID: 2891 RVA: 0x000513CC File Offset: 0x0004F5CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_o0.O__0_00O0.
			Dim ooo_.O0_0. As C1Button = Me.OOO_.O0_0.
			If ooo_.O0_0. IsNot Nothing Then
				RemoveHandler ooo_.O0_0..Click, value
			End If
			Me.OOO_.O0_0. = A_0
			ooo_.O0_0. = Me.OOO_.O0_0.
			If ooo_.O0_0. IsNot Nothing Then
				AddHandler ooo_.O0_0..Click, value
			End If
		End Sub

		' Token: 0x06000B4C RID: 2892 RVA: 0x0005140F File Offset: 0x0004F60F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o_oo0.Ooo__O.
		End Function

		' Token: 0x06000B4D RID: 2893 RVA: 0x00051417 File Offset: 0x0004F617
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o_oo0.Ooo__O. = A_0
		End Sub

		' Token: 0x06000B4E RID: 2894 RVA: 0x00051420 File Offset: 0x0004F620
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OOo__o_0OO.0.
		End Function

		' Token: 0x06000B4F RID: 2895 RVA: 0x00051428 File Offset: 0x0004F628
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OOo__o_0OO.0. = A_0
		End Sub

		' Token: 0x06000B50 RID: 2896 RVA: 0x00051431 File Offset: 0x0004F631
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_.O0_.
		End Function

		' Token: 0x06000B51 RID: 2897 RVA: 0x00051439 File Offset: 0x0004F639
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_.O0_. = A_0
		End Sub

		' Token: 0x06000B52 RID: 2898 RVA: 0x00051442 File Offset: 0x0004F642
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_.0OO.
		End Function

		' Token: 0x06000B53 RID: 2899 RVA: 0x0005144C File Offset: 0x0004F64C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_oO.O0O.
			Dim c1Button As C1Button = Me.oO_.0OO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO_.0OO. = A_0
			c1Button = Me.oO_.0OO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000B54 RID: 2900 RVA: 0x0005148F File Offset: 0x0004F68F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o__oO_o_0o.oOo.
		End Function

		' Token: 0x06000B55 RID: 2901 RVA: 0x00051498 File Offset: 0x0004F698
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.0o__00oO0.
			Dim c1Button As C1Button = Me.o__oO_o_0o.oOo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o__oO_o_0o.oOo. = A_0
			c1Button = Me.o__oO_o_0o.oOo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000B56 RID: 2902 RVA: 0x000514DB File Offset: 0x0004F6DB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_oo0.Ooo__O.
		End Function

		' Token: 0x06000B57 RID: 2903 RVA: 0x000514E3 File Offset: 0x0004F6E3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_oo0.Ooo__O. = A_0
		End Sub

		' Token: 0x06000B58 RID: 2904 RVA: 0x000514EC File Offset: 0x0004F6EC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O.00oo0.
		End Function

		' Token: 0x06000B59 RID: 2905 RVA: 0x000514F4 File Offset: 0x0004F6F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O.00oo0. = A_0
		End Sub

		' Token: 0x06000B5A RID: 2906 RVA: 0x000514FD File Offset: 0x0004F6FD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o0o_O0.ooo_o0.
		End Function

		' Token: 0x06000B5B RID: 2907 RVA: 0x00051505 File Offset: 0x0004F705
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o0o_O0.ooo_o0. = A_0
		End Sub

		' Token: 0x06000B5C RID: 2908 RVA: 0x0005150E File Offset: 0x0004F70E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O._oOO_O.
		End Function

		' Token: 0x06000B5D RID: 2909 RVA: 0x00051516 File Offset: 0x0004F716
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O._oOO_O. = A_0
		End Sub

		' Token: 0x06000B5E RID: 2910 RVA: 0x0005151F File Offset: 0x0004F71F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_._o0_0.
		End Function

		' Token: 0x06000B5F RID: 2911 RVA: 0x00051528 File Offset: 0x0004F728
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_oO.O0O_.
			Dim o0_._o0_0. As C1Button = Me.O0_._o0_0.
			If o0_._o0_0. IsNot Nothing Then
				RemoveHandler o0_._o0_0..Click, value
			End If
			Me.O0_._o0_0. = A_0
			o0_._o0_0. = Me.O0_._o0_0.
			If o0_._o0_0. IsNot Nothing Then
				AddHandler o0_._o0_0..Click, value
			End If
		End Sub

		' Token: 0x06000B60 RID: 2912 RVA: 0x0005156C File Offset: 0x0004F76C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				For Each item As String In SysInfo.referFiles.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
					IL_32:
					num2 = 3
					Me.OoOo._o00O.().Items.Add(item)
					IL_47:
					num2 = 4
				Next
				IL_57:
				num2 = 5
				For Each item2 As String In SysInfo.spaceNames.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
					IL_82:
					num2 = 6
					Me.Oo.O_0o0000.().Items.Add(item2)
					IL_97:
					num2 = 7
				Next
				IL_A7:
				num2 = 8
				Me.OOo__o_0OO.0. = Me.OoOo._o00O.().Items.Count
				IL_BF:
				num2 = 9
				Me.O.00oo0. = Me.Oo.O_0o0000.().Items.Count
				IL_D8:
				num2 = 10
				Dim dataRow As DataRow = Me.OOo__o_0OO.0..Rows.Find(New Object() { "Refrence", o0_O.oOO0.oO0O0__. })
				IL_104:
				num2 = 11
				If dataRow Is Nothing OrElse dataRow.IsNull("Config") Then
					GoTo IL_17A
				End If
				IL_117:
				num2 = 12
				Dim array3 As String() = dataRow("Config").ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_142:
				num2 = 13
				Dim num3 As Integer = array3.Length - 1
				For k As Integer = 0 To num3
					IL_152:
					num2 = 14
					Me.OoOo._o00O.().Items.Add(array3(k))
					IL_16B:
					num2 = 15
				Next
				IL_17A:
				num2 = 16
				dataRow = Me.OOo__o_0OO.0..Rows.Find(New Object() { "Space", o0_O.oo0o_OoO_.Oo. })
				IL_1A6:
				num2 = 17
				If dataRow Is Nothing OrElse dataRow.IsNull("Config") Then
					GoTo IL_21C
				End If
				IL_1B9:
				num2 = 18
				Dim array4 As String() = dataRow("Config").ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_1E4:
				num2 = 19
				Dim num4 As Integer = array4.Length - 1
				For l As Integer = 0 To num4
					IL_1F4:
					num2 = 20
					Me.Oo.O_0o0000.().Items.Add(array4(l))
					IL_20D:
					num2 = 21
				Next
				IL_21C:
				GoTo IL_2C6
				IL_221:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_287:
				GoTo IL_2BB
				IL_289:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_299:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_289
			End Try
			IL_2BB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2C6:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000B61 RID: 2913 RVA: 0x00051864 File Offset: 0x0004FA64
		Public Sub New(A_0 As DataTable)
			AddHandler MyBase.Load, AddressOf Me.o0_0.oo0O00.
			AddHandler MyBase.FormClosed, AddressOf Me.o__.oO.
			Me.Oo.O_0o0000.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.o__000.O.() })
			Me.OOo__o_0OO.0. = A_0
		End Sub

		' Token: 0x06000B62 RID: 2914 RVA: 0x000518DC File Offset: 0x0004FADC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.O0O_0O_O__oo.0.().Text.Trim()
			If Operators.CompareString(text, "", True) > 0 Then
				Try
					For Each value As Object In Me.OoOo._o00O.().Items
						Dim right As String = Conversions.ToString(value)
						If Operators.CompareString(text, right, True) = 0 Then
							MessageBox.Show("此文件已经引用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Me.o.O0o_0O.(text, True) Then
					Me.OoOo._o00O.().Items.Add(text)
				End If
			End If
		End Sub

		' Token: 0x06000B63 RID: 2915 RVA: 0x00051994 File Offset: 0x0004FB94
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OoOo._o00O.().SelectedIndex >= Me.OOo__o_0OO.0. Then
				Dim file As String = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\" + Me.OoOo._o00O.().SelectedItem.ToString()
				c.OOOOO.o.().FileSystem.FileExists(file)
				Me.OoOo._o00O.().Items.RemoveAt(Me.OoOo._o00O.().SelectedIndex)
				Return
			End If
			MessageBox.Show("此为必要的引用，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06000B64 RID: 2916 RVA: 0x00051A24 File Offset: 0x0004FC24
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "Dll文件|*.Dll"
			openFileDialog.InitialDirectory = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath)
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				If Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(openFileDialog.FileName), c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath), True) <> 0 Then
					c.OOOOO.o.().FileSystem.CopyFile(openFileDialog.FileName, c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\" + c.OOOOO.o.().FileSystem.GetName(openFileDialog.FileName), True)
				End If
				Me.O0O_0O_O__oo.0.().Value = c.OOOOO.o.().FileSystem.GetName(openFileDialog.FileName)
				If Me.o.O0o_0O.(Me.O0O_0O_O__oo.0.().Text, True) Then
					Me.O_00_0_0.O0_oo.().PerformClick()
					Return
				End If
				c.OOOOO.o.().FileSystem.DeleteFile(c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\" + Me.O0O_0O_O__oo.0.().Text)
			End If
		End Sub

		' Token: 0x06000B65 RID: 2917 RVA: 0x00051B5A File Offset: 0x0004FD5A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06000B66 RID: 2918 RVA: 0x00051B64 File Offset: 0x0004FD64
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dataRow As DataRow = Me.OOo__o_0OO.0..Rows.Find(New Object() { "Refrence", o0_O.oOO0.oO0O0__. })
				IL_32:
				num2 = 3
				If Me.OoOo._o00O.().Items.Count = Me.OOo__o_0OO.0. Then
					GoTo IL_128
				End If
				IL_4F:
				num2 = 4
				If dataRow IsNot Nothing Then
					GoTo IL_9B
				End If
				IL_54:
				num2 = 5
				dataRow = Me.OOo__o_0OO.0..NewRow()
				IL_62:
				num2 = 6
				dataRow("Name") = "Refrence"
				IL_74:
				num2 = 7
				dataRow("Type") = o0_O.oOO0.oO0O0__.
				IL_88:
				num2 = 8
				Me.OOo__o_0OO.0..Rows.Add(dataRow)
				IL_9B:
				num2 = 9
				Dim text As String = ""
				IL_A5:
				num2 = 10
				Dim ooo__o_0OO.0. As Integer = Me.OOo__o_0OO.0.
				Dim num3 As Integer = Me.OoOo._o00O.().Items.Count - 1
				For i As Integer = ooo__o_0OO.0. To num3
					IL_C6:
					num2 = 11
					If i > Me.OOo__o_0OO.0. Then
						IL_D3:
						num2 = 12
						text += vbCrLf
					End If
					IL_E4:
					num2 = 13
					text += Me.OoOo._o00O.().Items(i).ToString()
					IL_107:
					num2 = 14
				Next
				IL_116:
				num2 = 15
				dataRow("Config") = text
				GoTo IL_141
				IL_128:
				num2 = 17
				If dataRow Is Nothing Then
					GoTo IL_141
				End If
				IL_12E:
				num2 = 18
				dataRow("Config") = ""
				IL_141:
				num2 = 19
				dataRow = Me.OOo__o_0OO.0..Rows.Find(New Object() { "Space", o0_O.oo0o_OoO_.Oo. })
				IL_16D:
				num2 = 20
				If Me.Oo.O_0o0000.().Items.Count = Me.O.00oo0. Then
					GoTo IL_269
				End If
				IL_18B:
				num2 = 21
				If dataRow IsNot Nothing Then
					GoTo IL_1DC
				End If
				IL_191:
				num2 = 22
				dataRow = Me.OOo__o_0OO.0..NewRow()
				IL_1A0:
				num2 = 23
				dataRow("Name") = "Space"
				IL_1B3:
				num2 = 24
				dataRow("Type") = o0_O.oo0o_OoO_.Oo.
				IL_1C8:
				num2 = 25
				Me.OOo__o_0OO.0..Rows.Add(dataRow)
				IL_1DC:
				num2 = 26
				Dim text2 As String = ""
				IL_1E6:
				num2 = 27
				Dim o.00oo0. As Integer = Me.O.00oo0.
				Dim num4 As Integer = Me.Oo.O_0o0000.().Items.Count - 1
				For j As Integer = o.00oo0. To num4
					IL_207:
					num2 = 28
					If j > Me.O.00oo0. Then
						IL_214:
						num2 = 29
						text2 += vbCrLf
					End If
					IL_225:
					num2 = 30
					text2 += Me.Oo.O_0o0000.().Items(j).ToString()
					IL_248:
					num2 = 31
				Next
				IL_257:
				num2 = 32
				dataRow("Config") = text2
				GoTo IL_282
				IL_269:
				num2 = 34
				If dataRow Is Nothing Then
					GoTo IL_282
				End If
				IL_26F:
				num2 = 35
				dataRow("Config") = ""
				IL_282:
				num2 = 36
				MyBase.DialogResult = DialogResult.OK
				IL_28C:
				GoTo IL_372
				IL_291:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_333:
				GoTo IL_367
				IL_335:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_345:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_335
			End Try
			IL_367:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_372:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000B67 RID: 2919 RVA: 0x00051F08 File Offset: 0x00050108
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.OoOo._o00O.().Text.Trim()
			Dim text2 As String = Me.Oo.O_0o0000.().Text.Trim()
			If Operators.CompareString(text, "", True) <> 0 Then
				If Operators.CompareString(text2, "", True) = 0 Then
					MessageBox.Show("必须指定别名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Try
					For Each value As Object In Me.Oo.O_0o0000.().Items
						Dim text3 As String = Conversions.ToString(value)
						If Operators.CompareString(text3, text, True) = 0 OrElse text3.StartsWith(text + "(", StringComparison.CurrentCultureIgnoreCase) OrElse text3.EndsWith("(" + text2 + ")", StringComparison.CurrentCultureIgnoreCase) Then
							MessageBox.Show("此命名空间已经引入，或者别名和现有命名空间冲突！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				text = text + "(" + text2 + ")"
				If Me.o.O0o_0O.(text, False) Then
					Me.Oo.O_0o0000.().Items.Add(text)
				End If
			End If
		End Sub

		' Token: 0x06000B68 RID: 2920 RVA: 0x00052034 File Offset: 0x00050234
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim listBox As ListBox = Me.Oo.O_0o0000.()
			If listBox.SelectedIndex >= Me.O.00oo0. Then
				listBox.Items.RemoveAt(listBox.SelectedIndex)
			Else
				MessageBox.Show("此为必要的命名空间，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x06000B69 RID: 2921 RVA: 0x00052080 File Offset: 0x00050280
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim vbcodeProvider As VBCodeProvider = New VBCodeProvider()
				IL_10:
				num2 = 3
				Dim compilerParameters As CompilerParameters = New CompilerParameters()
				IL_19:
				num2 = 4
				Dim text As String = "Public Class User" & vbCrLf & "Private sub Test" & vbCrLf & "Dim i As Integer = 123" & vbCrLf & "End Sub" & vbCrLf & "End Class"
				IL_22:
				num2 = 5
				If Not A_1 Then
					GoTo IL_7A
				End If
				IL_27:
				num2 = 6
				If A_0.StartsWith("system.", StringComparison.CurrentCultureIgnoreCase) Then
					GoTo IL_67
				End If
				IL_37:
				num2 = 7
				compilerParameters.ReferencedAssemblies.Add(c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\" + A_0)
				GoTo IL_B2
				IL_67:
				num2 = 9
				compilerParameters.ReferencedAssemblies.Add(A_0)
				GoTo IL_B2
				IL_7A:
				num2 = 11
				Dim array As String() = A_0.Split(New Char() { "("c, ")"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_96:
				num2 = 12
				text = "Imports " + array(1) + " = " + array(0)
				IL_B2:
				num2 = 13
				Dim compilerResults As CompilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, New String() { text })
				IL_CB:
				num2 = 14
				If compilerResults.Errors.Count <= 0 Then
					GoTo IL_107
				End If
				IL_DD:
				num2 = 15
				MessageBox.Show(compilerResults.Errors(0).ErrorText, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_100:
				num2 = 16
				result = False
				GoTo IL_10C
				IL_107:
				num2 = 18
				result = True
				IL_10C:
				GoTo IL_1AA
				IL_111:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_16B:
				GoTo IL_19F
				IL_16D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_17D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_16D
			End Try
			IL_19F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1AA:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06000B6A RID: 2922 RVA: 0x0005225C File Offset: 0x0005045C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { MyBase.Controls })
		End Sub

		' Token: 0x0400043B RID: 1083
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400043C RID: 1084
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x0400043D RID: 1085
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400043E RID: 1086
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400043F RID: 1087
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04000440 RID: 1088
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000441 RID: 1089
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000442 RID: 1090
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000443 RID: 1091
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000444 RID: 1092
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04000445 RID: 1093
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000446 RID: 1094
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000447 RID: 1095
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000448 RID: 1096
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000449 RID: 1097
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400044A RID: 1098
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400044B RID: 1099
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400044C RID: 1100
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400044D RID: 1101
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400044E RID: 1102
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400044F RID: 1103
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000450 RID: 1104
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
