Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000062 RID: 98
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002o
		Inherits Form

		' Token: 0x06000337 RID: 823 RVA: 0x00009B3C File Offset: 0x00007D3C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oo.00O00oO0O_. IsNot Nothing Then
					Me.oo.00O00oO0O_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000338 RID: 824 RVA: 0x00009B7C File Offset: 0x00007D7C
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O_0O_.0__o.(New C1TextBox())
			Me.Oo0._o_oOOo0_0.(New C1Button())
			Me.O0.0OOOoo0OO_.(New C1Button())
			Me.O_0O_.0__o.(New Label())
			Me.O_0O_.0__o.(New C1Button())
			Me.oo0.O_o.().BeginInit()
			Me.oo0.O_o.().BeginInit()
			Me.oooo.0o_.().BeginInit()
			Me.O_.__Oo0.().BeginInit()
			MyBase.SuspendLayout()
			Me.oo0.O_o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oo0.O_o.().Location = New Point(12, 39)
			Me.oo0.O_o.().Multiline = True
			Me.oo0.O_o.().Name = "TextBox1"
			Me.oo0.O_o.().ScrollBars = ScrollBars.Vertical
			Me.oo0.O_o.().Size = New Size(417, 253)
			Me.oo0.O_o.().TabIndex = 0
			Me.oo0.O_o.().Tag = Nothing
			Me.oo0.O_o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oo0.O_o.().DialogResult = DialogResult.OK
			Me.oo0.O_o.().Location = New Point(273, 307)
			Me.oo0.O_o.().Name = "btnAccept"
			Me.oo0.O_o.().Size = New Size(75, 23)
			Me.oo0.O_o.().TabIndex = 2
			Me.oo0.O_o.().Text = "确定"
			Me.oo0.O_o.().UseVisualStyleBackColor = True
			Me.oooo.0o_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oooo.0o_.().DialogResult = DialogResult.OK
			Me.oooo.0o_.().Location = New Point(354, 307)
			Me.oooo.0o_.().Name = "btnCancel"
			Me.oooo.0o_.().Size = New Size(75, 23)
			Me.oooo.0o_.().TabIndex = 3
			Me.oooo.0o_.().Text = "取消"
			Me.oooo.0o_.().UseVisualStyleBackColor = True
			Me.oo0.O_o.().AutoSize = True
			Me.oo0.O_o.().Location = New Point(10, 19)
			Me.oo0.O_o.().Name = "Label1"
			Me.oo0.O_o.().Size = New Size(155, 12)
			Me.oo0.O_o.().TabIndex = 5
			Me.oo0.O_o.().Text = "请输入列表项目，每行一个:"
			Me.O_.__Oo0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_.__Oo0.().Location = New Point(12, 307)
			Me.O_.__Oo0.().Name = "Button1"
			Me.O_.__Oo0.().Size = New Size(106, 23)
			Me.O_.__Oo0.().TabIndex = 1
			Me.O_.__Oo0.().Text = "从数据表提取"
			Me.O_.__Oo0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(443, 342)
			MyBase.Controls.Add(Me.O_.__Oo0.())
			MyBase.Controls.Add(Me.oo0.O_o.())
			MyBase.Controls.Add(Me.oooo.0o_.())
			MyBase.Controls.Add(Me.oo0.O_o.())
			MyBase.Controls.Add(Me.oo0.O_o.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "frmComboListEditor"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "列表项目"
			Me.oo0.O_o.().EndInit()
			Me.oo0.O_o.().EndInit()
			Me.oooo.0o_.().EndInit()
			Me.O_.__Oo0.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000339 RID: 825 RVA: 0x00009F2E File Offset: 0x0000812E
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oo.00O00oO0O_.
		End Function

		' Token: 0x0600033A RID: 826 RVA: 0x00009F36 File Offset: 0x00008136
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oo.00O00oO0O_. = A_0
		End Sub

		' Token: 0x0600033B RID: 827 RVA: 0x00009F3F File Offset: 0x0000813F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_0O_.0__o.
		End Function

		' Token: 0x0600033C RID: 828 RVA: 0x00009F47 File Offset: 0x00008147
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O_0O_.0__o. = A_0
		End Sub

		' Token: 0x0600033D RID: 829 RVA: 0x00009F50 File Offset: 0x00008150
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.0OOOoo0OO_.
		End Function

		' Token: 0x0600033E RID: 830 RVA: 0x00009F58 File Offset: 0x00008158
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0.0OOOoo0OO_. = A_0
		End Sub

		' Token: 0x0600033F RID: 831 RVA: 0x00009F61 File Offset: 0x00008161
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.O_0O_.0__o.
		End Function

		' Token: 0x06000340 RID: 832 RVA: 0x00009F69 File Offset: 0x00008169
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_0O_.0__o. = A_0
		End Sub

		' Token: 0x06000341 RID: 833 RVA: 0x00009F72 File Offset: 0x00008172
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0._o_oOOo0_0.
		End Function

		' Token: 0x06000342 RID: 834 RVA: 0x00009F7C File Offset: 0x0000817C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo0.O_o.
			Dim oo0._o_oOOo0_0. As C1Button = Me.Oo0._o_oOOo0_0.
			If oo0._o_oOOo0_0. IsNot Nothing Then
				RemoveHandler oo0._o_oOOo0_0..Click, value
			End If
			Me.Oo0._o_oOOo0_0. = A_0
			oo0._o_oOOo0_0. = Me.Oo0._o_oOOo0_0.
			If oo0._o_oOOo0_0. IsNot Nothing Then
				AddHandler oo0._o_oOOo0_0..Click, value
			End If
		End Sub

		' Token: 0x06000343 RID: 835 RVA: 0x00009FBF File Offset: 0x000081BF
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.oo0.O_o.
			Me.oo0.O_o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x06000344 RID: 836 RVA: 0x00009FF4 File Offset: 0x000081F4
		' (set) Token: 0x06000345 RID: 837 RVA: 0x0000A074 File Offset: 0x00008274
		Friend Property Value As String
			Get
				Dim text As String = ""
				For Each text2 As String In Me.oo0.O_o.().Lines
					If Operators.CompareString(text2, "", True) <> 0 Then
						If Operators.CompareString(text, "", True) > 0 AndAlso Not text.EndsWith("|") AndAlso Not text2.StartsWith("|") Then
							text += "|"
						End If
						text += text2
					End If
				Next
				Return text
			End Get
			Set(value As String)
				Dim array As String() = value.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
				If array.Length > 0 Then
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Me.oo0.O_o.().AppendText(array(i))
						Me.oo0.O_o.().AppendText(vbCrLf)
					Next
				End If
			End Set
		End Property

		' Token: 0x06000346 RID: 838 RVA: 0x0000A0CC File Offset: 0x000082CC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_u3002_u3002_u3000_u3000_u3002_u3002_u3000_u3002_u3002_u As O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002 = New O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002()
			If o_u3002_u3002_u3000_u3000_u3002_u3002_u3000_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
				Dim uniqueValues As List(Of String) = OO_00oOO.DataTables(o_u3002_u3002_u3000_u3000_u3002_u3002_u3000_u3002_u3002_u.OO.__oOooo0o_.().SelectedItem.ToString()).GetUniqueValues("", o_u3002_u3002_u3000_u3000_u3002_u3002_u3000_u3002_u3002_u.o_OO._.().SelectedItem.ToString())
				Dim stringBuilder As StringBuilder = New StringBuilder()
				Try
					For Each value As String In uniqueValues
						If stringBuilder.Length > 0 Then
							stringBuilder.Append(vbCrLf)
						End If
						stringBuilder.Append(value)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.oo0.O_o.().Value = stringBuilder.ToString()
			End If
		End Sub

		' Token: 0x06000347 RID: 839 RVA: 0x0000A190 File Offset: 0x00008390
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000091 RID: 145
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000092 RID: 146
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000093 RID: 147
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000094 RID: 148
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000095 RID: 149
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000096 RID: 150
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
