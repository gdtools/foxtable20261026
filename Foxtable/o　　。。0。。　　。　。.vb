Imports System
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
	' Token: 0x02000087 RID: 135
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3000\u3002\u30020\u3002\u3002\u3000\u3000\u3002\u3000\u3002
		Inherits Form

		' Token: 0x060004D7 RID: 1239 RVA: 0x0001BB88 File Offset: 0x00019D88
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o._Oo0o_Oo_O_o. IsNot Nothing Then
					Me.o._Oo0o_Oo_O_o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060004D8 RID: 1240 RVA: 0x0001BBC8 File Offset: 0x00019DC8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o._o_o.(New C1ComboBox())
			Me.ooo.0_0_oOOo_.(New C1TextBox())
			Me.o._o_o.(New C1Button())
			Me.oO_o.0O0OO__o.(New C1Button())
			Me.oo0_0Oo_.0o.(New Label())
			Me.o._o_o.(New Label())
			Me.oO_o.0O0OO__o.(New Label())
			Me.O0._OoOoO.(New C1TextBox())
			MyBase.SuspendLayout()
			Me.O0oO0_O0.O.().Location = New Point(12, 32)
			Me.O0oO0_O0.O.().Name = "cmbCategory"
			Me.O0oO0_O0.O.().Size = New Size(239, 20)
			Me.O0oO0_O0.O.().TabIndex = 0
			Me.oO_o.0O0OO__o.().Location = New Point(12, 80)
			Me.oO_o.0O0OO__o.().Multiline = True
			Me.oO_o.0O0OO__o.().Name = "txtCode"
			Me.oO_o.0O0OO__o.().ScrollBars = ScrollBars.Vertical
			Me.oO_o.0O0OO__o.().Size = New Size(497, 280)
			Me.oO_o.0O0OO__o.().TabIndex = 2
			Me.o_00.0O_0.().Location = New Point(178, 369)
			Me.o_00.0O_0.().Name = "Button1"
			Me.o_00.0O_0.().Size = New Size(75, 23)
			Me.o_00.0O_0.().TabIndex = 3
			Me.o_00.0O_0.().Text = "确定"
			Me.o_00.0O_0.().UseVisualStyleBackColor = True
			Me.O0oO0_O0.O.().Location = New Point(269, 369)
			Me.O0oO0_O0.O.().Name = "Button2"
			Me.O0oO0_O0.O.().Size = New Size(75, 23)
			Me.O0oO0_O0.O.().TabIndex = 4
			Me.O0oO0_O0.O.().Text = "取消"
			Me.O0oO0_O0.O.().UseVisualStyleBackColor = True
			Me.O0oO0_O0.O.().AutoSize = True
			Me.O0oO0_O0.O.().Location = New Point(12, 12)
			Me.O0oO0_O0.O.().Name = "Label1"
			Me.O0oO0_O0.O.().Size = New Size(35, 12)
			Me.O0oO0_O0.O.().TabIndex = 4
			Me.O0oO0_O0.O.().Text = "目录:"
			Me.o_00.0O_0.().AutoSize = True
			Me.o_00.0O_0.().Location = New Point(268, 12)
			Me.o_00.0O_0.().Name = "Label2"
			Me.o_00.0O_0.().Size = New Size(35, 12)
			Me.o_00.0O_0.().TabIndex = 6
			Me.o_00.0O_0.().Text = "名称:"
			Me.oo0_0Oo_.0o.().AutoSize = True
			Me.oo0_0Oo_.0o.().Location = New Point(12, 60)
			Me.oo0_0Oo_.0o.().Name = "Label3"
			Me.oo0_0Oo_.0o.().Size = New Size(35, 12)
			Me.oo0_0Oo_.0o.().TabIndex = 7
			Me.oo0_0Oo_.0o.().Text = "代码:"
			Me.o._o_o.().Location = New Point(270, 32)
			Me.o._o_o.().Name = "txtName"
			Me.o._o_o.().Size = New Size(239, 21)
			Me.o._o_o.().TabIndex = 1
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(522, 401)
			MyBase.Controls.Add(Me.o._o_o.())
			MyBase.Controls.Add(Me.oo0_0Oo_.0o.())
			MyBase.Controls.Add(Me.o_00.0O_0.())
			MyBase.Controls.Add(Me.O0oO0_O0.O.())
			MyBase.Controls.Add(Me.O0oO0_O0.O.())
			MyBase.Controls.Add(Me.o_00.0O_0.())
			MyBase.Controls.Add(Me.oO_o.0O0OO__o.())
			MyBase.Controls.Add(Me.O0oO0_O0.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O0...O.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "代码管理"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060004D9 RID: 1241 RVA: 0x0001C01B File Offset: 0x0001A21B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O0._OoOoO.
		End Function

		' Token: 0x060004DA RID: 1242 RVA: 0x0001C023 File Offset: 0x0001A223
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O0._OoOoO. = A_0
		End Sub

		' Token: 0x060004DB RID: 1243 RVA: 0x0001C02C File Offset: 0x0001A22C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O0._OoOoO.
		End Function

		' Token: 0x060004DC RID: 1244 RVA: 0x0001C034 File Offset: 0x0001A234
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O0._OoOoO. = A_0
		End Sub

		' Token: 0x060004DD RID: 1245 RVA: 0x0001C03D File Offset: 0x0001A23D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0._OoOoO.
		End Function

		' Token: 0x060004DE RID: 1246 RVA: 0x0001C048 File Offset: 0x0001A248
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0oO0_O0.O.
			Dim o0._OoOoO. As C1Button = Me.O0._OoOoO.
			If o0._OoOoO. IsNot Nothing Then
				RemoveHandler o0._OoOoO..Click, value
			End If
			Me.O0._OoOoO. = A_0
			o0._OoOoO. = Me.O0._OoOoO.
			If o0._OoOoO. IsNot Nothing Then
				AddHandler o0._OoOoO..Click, value
			End If
		End Sub

		' Token: 0x060004DF RID: 1247 RVA: 0x0001C08B File Offset: 0x0001A28B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooo.0_0_oOOo_.
		End Function

		' Token: 0x060004E0 RID: 1248 RVA: 0x0001C094 File Offset: 0x0001A294
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_00.0O_0.
			Dim c1Button As C1Button = Me.ooo.0_0_oOOo_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooo.0_0_oOOo_. = A_0
			c1Button = Me.ooo.0_0_oOOo_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060004E1 RID: 1249 RVA: 0x0001C0D7 File Offset: 0x0001A2D7
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.O0._OoOoO.
		End Function

		' Token: 0x060004E2 RID: 1250 RVA: 0x0001C0DF File Offset: 0x0001A2DF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0._OoOoO. = A_0
		End Sub

		' Token: 0x060004E3 RID: 1251 RVA: 0x0001C0E8 File Offset: 0x0001A2E8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooo.0_0_oOOo_.
		End Function

		' Token: 0x060004E4 RID: 1252 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooo.0_0_oOOo_. = A_0
		End Sub

		' Token: 0x060004E5 RID: 1253 RVA: 0x0001C0F9 File Offset: 0x0001A2F9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0O.__.
		End Function

		' Token: 0x060004E6 RID: 1254 RVA: 0x0001C101 File Offset: 0x0001A301
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0O.__. = A_0
		End Sub

		' Token: 0x060004E7 RID: 1255 RVA: 0x0001C10A File Offset: 0x0001A30A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.ooo.0_0_oOOo_.
		End Function

		' Token: 0x060004E8 RID: 1256 RVA: 0x0001C112 File Offset: 0x0001A312
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.ooo.0_0_oOOo_. = A_0
		End Sub

		' Token: 0x060004E9 RID: 1257 RVA: 0x0001C11C File Offset: 0x0001A31C
		Public Sub New(A_0 As DataRow)
			AddHandler MyBase.FormClosed, AddressOf Me.O0oO0_O0.O.
			Me.o._o_o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o._Oo0o_Oo_O_o. = A_0
			Me.O0oO0_O0.O.().Value = A_0("Category").ToString()
			Me.o._o_o.().Value = A_0("Name").ToString()
			Me.oO_o.0O0OO__o.().Value = A_0("Code").ToString()
			Dim list As List(Of String) = Oo00.O____0O._0.(A_0.Table, "", "", "Category")
			Try
				For Each text As String In list
					Me.O0oO0_O0.O.().Items.Add(text)
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x060004EA RID: 1258 RVA: 0x0001C21C File Offset: 0x0001A41C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x060004EB RID: 1259 RVA: 0x0001C228 File Offset: 0x0001A428
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o._Oo0o_Oo_O_o.("Category") = Me.O0oO0_O0.O.().Text.Trim()
			Me.o._Oo0o_Oo_O_o.("Name") = Me.o._o_o.().Text.Trim()
			Me.o._Oo0o_Oo_O_o.("Code") = Me.oO_o.0O0OO__o.().Text
			If Operators.CompareString(Me.o._Oo0o_Oo_O_o.("Code").ToString(), "", True) = 0 OrElse Operators.CompareString(Me.o._Oo0o_Oo_O_o.("Name").ToString(), "", True) = 0 OrElse Operators.CompareString(Me.o._Oo0o_Oo_O_o.("Code").ToString(), "", True) = 0 Then
				MessageBox.Show("请输入分类、名称和代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.o._Oo0o_Oo_O_o..RowState = DataRowState.Detached Then
				Me.o._Oo0o_Oo_O_o..Table.Rows.Add(Me.o._Oo0o_Oo_O_o.)
			End If
			Oo00.O0Oo_O.0O_0O.(Me.o._Oo0o_Oo_O_o.)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060004EC RID: 1260 RVA: 0x0001C345 File Offset: 0x0001A545
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000103 RID: 259
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000104 RID: 260
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000105 RID: 261
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000106 RID: 262
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000107 RID: 263
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000108 RID: 264
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000109 RID: 265
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400010A RID: 266
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400010B RID: 267
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400010C RID: 268
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
