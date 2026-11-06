Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000176 RID: 374
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000
		Inherits Form

		' Token: 0x06001164 RID: 4452 RVA: 0x0006C070 File Offset: 0x0006A270
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_Ooo._. IsNot Nothing Then
					Me.o_Ooo._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001165 RID: 4453 RVA: 0x0006C0B0 File Offset: 0x0006A2B0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_Ooo._.(New GroupBox())
			Me.o_Ooo._.(New LinkLabel())
			Me.o_Ooo._.(New C1ComboBox())
			Me.O.OoO_.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.O.OoO_.().Anchor = AnchorStyles.None
			Me.O.OoO_.().Controls.Add(Me.O.OoO_.())
			Me.O.OoO_.().Controls.Add(Me.O.OoO_.())
			Me.O.OoO_.().Location = New Point(183, 149)
			Me.O.OoO_.().Name = "GroupBox1"
			Me.O.OoO_.().Size = New Size(269, 99)
			Me.O.OoO_.().TabIndex = 3
			Me.O.OoO_.().TabStop = False
			Me.O.OoO_.().Text = "快捷菜单测试"
			Me.O.OoO_.().AutoSize = True
			Me.O.OoO_.().Location = New Point(54, 67)
			Me.O.OoO_.().Name = "LinkLabel1"
			Me.O.OoO_.().Size = New Size(161, 12)
			Me.O.OoO_.().TabIndex = 1
			Me.O.OoO_.().TabStop = True
			Me.O.OoO_.().Text = "右击此处测试选定的快捷菜单"
			Me.O.OoO_.().DropDownStyle = 1
			Me.O.OoO_.().Location = New Point(52, 27)
			Me.O.OoO_.().Name = "ContextMenuList"
			Me.O.OoO_.().Size = New Size(165, 20)
			Me.O.OoO_.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(635, 435)
			MyBase.Controls.Add(Me.O.OoO_.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o..o.O.0"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "窗口菜单预览"
			Me.O.OoO_.().ResumeLayout(False)
			Me.O.OoO_.().PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001166 RID: 4454 RVA: 0x0006C2EB File Offset: 0x0006A4EB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As GroupBox
			Return Me.o_Ooo._.
		End Function

		' Token: 0x06001167 RID: 4455 RVA: 0x0006C2F3 File Offset: 0x0006A4F3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.o_Ooo._. = A_0
		End Sub

		' Token: 0x06001168 RID: 4456 RVA: 0x0006C2FC File Offset: 0x0006A4FC
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As LinkLabel
			Return Me.o_Ooo._.
		End Function

		' Token: 0x06001169 RID: 4457 RVA: 0x0006C304 File Offset: 0x0006A504
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As LinkLabel)
			Me.o_Ooo._. = A_0
		End Sub

		' Token: 0x0600116A RID: 4458 RVA: 0x0006C30D File Offset: 0x0006A50D
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_Ooo._.
		End Function

		' Token: 0x0600116B RID: 4459 RVA: 0x0006C318 File Offset: 0x0006A518
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O.OoO_.
			Dim c1ComboBox As C1ComboBox = Me.o_Ooo._.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o_Ooo._. = A_0
			c1ComboBox = Me.o_Ooo._.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600116C RID: 4460 RVA: 0x0006C35C File Offset: 0x0006A55C
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.O.OoO_.
			Me.OO00O.0O0O0o. = New Dictionary(Of String, ToolStrip)()
			Me.o_Ooo._. = "(default)"
			Me.o_Ooo._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600116D RID: 4461 RVA: 0x0006C3B4 File Offset: 0x0006A5B4
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim oo_ As OO_ = New OO_(A_0, Nothing)
			oo_.O_oOoo._o_oo. = Me.o_Ooo._.
			oo_.o.__o_O.()
			Me.OO00O.0O0O0o. = oo_.o.__o_O.
			Dim list As List(Of String) = New List(Of String)()
			list.AddRange(Me.OO00O.0O0O0o..Keys)
			For i As Integer = list.Count - 1 To 0 Step -1
				Dim toolStrip As ToolStrip = Me.OO00O.0O0O0o.(list(i))
				If TypeOf toolStrip Is ContextMenuStrip Then
					Me.O.OoO_.().Items.Add(list(i))
				Else
					MyBase.Controls.Add(toolStrip)
				End If
			Next
		End Sub

		' Token: 0x0600116E RID: 4462 RVA: 0x0006C452 File Offset: 0x0006A652
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.OoO_.().ContextMenuStrip = CType(Me.OO00O.0O0O0o.(Me.O.OoO_.().SelectedItem.ToString()), ContextMenuStrip)
		End Sub

		' Token: 0x0600116F RID: 4463 RVA: 0x0006C47F File Offset: 0x0006A67F
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000694 RID: 1684
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000695 RID: 1685
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04000696 RID: 1686
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As LinkLabel

		' Token: 0x04000697 RID: 1687
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000698 RID: 1688
		Private <<EMPTY_NAME>> As Dictionary(Of String, ToolStrip)

		' Token: 0x04000699 RID: 1689
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
