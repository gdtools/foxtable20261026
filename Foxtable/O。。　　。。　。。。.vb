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
	' Token: 0x02000063 RID: 99
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002
		Inherits Form

		' Token: 0x06000348 RID: 840 RVA: 0x0000A1A4 File Offset: 0x000083A4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_O.0. IsNot Nothing Then
					Me.O_O.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000349 RID: 841 RVA: 0x0000A1E4 File Offset: 0x000083E4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_OO._.(New C1Button())
			Me.O__O.Oo.(New C1Button())
			Me.O__O.Oo.(New C1ComboBox())
			Me.o_OO._.(New C1ComboBox())
			Me.O__O.Oo.(New Label())
			Me.o_OO._.(New Label())
			MyBase.SuspendLayout()
			Me.OO.__oOooo0o_.().Location = New Point(60, 95)
			Me.OO.__oOooo0o_.().Name = "Button1"
			Me.OO.__oOooo0o_.().Size = New Size(75, 23)
			Me.OO.__oOooo0o_.().TabIndex = 0
			Me.OO.__oOooo0o_.().Text = "确定"
			Me.OO.__oOooo0o_.().UseVisualStyleBackColor = True
			Me.O0OO.o00O00o.().DialogResult = DialogResult.Cancel
			Me.O0OO.o00O00o.().Location = New Point(141, 95)
			Me.O0OO.o00O00o.().Name = "Button2"
			Me.O0OO.o00O00o.().Size = New Size(75, 23)
			Me.O0OO.o00O00o.().TabIndex = 1
			Me.O0OO.o00O00o.().Text = "取消"
			Me.O0OO.o00O00o.().UseVisualStyleBackColor = True
			Me.OO.__oOooo0o_.().DropDownStyle = 1
			Me.OO.__oOooo0o_.().Location = New Point(68, 20)
			Me.OO.__oOooo0o_.().Name = "ComboBox1"
			Me.OO.__oOooo0o_.().Size = New Size(171, 20)
			Me.OO.__oOooo0o_.().TabIndex = 2
			Me.o_OO._.().DropDownStyle = 1
			Me.o_OO._.().Location = New Point(68, 47)
			Me.o_OO._.().Name = "ComboBox2"
			Me.o_OO._.().Size = New Size(171, 20)
			Me.o_OO._.().TabIndex = 3
			Me.o_OO._.().AutoSize = True
			Me.o_OO._.().Location = New Point(15, 24)
			Me.o_OO._.().Name = "Label1"
			Me.o_OO._.().Size = New Size(47, 12)
			Me.o_OO._.().TabIndex = 4
			Me.o_OO._.().Text = "选择表:"
			Me.O__O.Oo.().AutoSize = True
			Me.O__O.Oo.().Location = New Point(15, 51)
			Me.O__O.Oo.().Name = "Label2"
			Me.O__O.Oo.().Size = New Size(47, 12)
			Me.O__O.Oo.().TabIndex = 5
			Me.O__O.Oo.().Text = "选择列:"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(269, 131)
			MyBase.Controls.Add(Me.O__O.Oo.())
			MyBase.Controls.Add(Me.o_OO._.())
			MyBase.Controls.Add(Me.o_OO._.())
			MyBase.Controls.Add(Me.OO.__oOooo0o_.())
			MyBase.Controls.Add(Me.O0OO.o00O00o.())
			MyBase.Controls.Add(Me.OO.__oOooo0o_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.O.o.o."
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "来自于列"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600034A RID: 842 RVA: 0x0000A54B File Offset: 0x0000874B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_O.0.
		End Function

		' Token: 0x0600034B RID: 843 RVA: 0x0000A554 File Offset: 0x00008754
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0OO.o00O00o.
			Dim o_O.0. As C1Button = Me.O_O.0.
			If o_O.0. IsNot Nothing Then
				RemoveHandler o_O.0..Click, value
			End If
			Me.O_O.0. = A_0
			o_O.0. = Me.O_O.0.
			If o_O.0. IsNot Nothing Then
				AddHandler o_O.0..Click, value
			End If
		End Sub

		' Token: 0x0600034C RID: 844 RVA: 0x0000A597 File Offset: 0x00008797
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo.O00.
		End Function

		' Token: 0x0600034D RID: 845 RVA: 0x0000A59F File Offset: 0x0000879F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oo.O00. = A_0
		End Sub

		' Token: 0x0600034E RID: 846 RVA: 0x0000A5A8 File Offset: 0x000087A8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O_O.0.
		End Function

		' Token: 0x0600034F RID: 847 RVA: 0x0000A5B0 File Offset: 0x000087B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.OO.__oOooo0o_.
			Dim o_O.0. As C1ComboBox = Me.O_O.0.
			If o_O.0. IsNot Nothing Then
				o_O.0..SelectedIndexChanged -= eventHandler
			End If
			Me.O_O.0. = A_0
			o_O.0. = Me.O_O.0.
			If o_O.0. IsNot Nothing Then
				o_O.0..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06000350 RID: 848 RVA: 0x0000A5F3 File Offset: 0x000087F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oo.O00.
		End Function

		' Token: 0x06000351 RID: 849 RVA: 0x0000A5FB File Offset: 0x000087FB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.oo.O00. = A_0
		End Sub

		' Token: 0x06000352 RID: 850 RVA: 0x0000A604 File Offset: 0x00008804
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_O.0.
		End Function

		' Token: 0x06000353 RID: 851 RVA: 0x0000A60C File Offset: 0x0000880C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_O.0. = A_0
		End Sub

		' Token: 0x06000354 RID: 852 RVA: 0x0000A615 File Offset: 0x00008815
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo.O00.
		End Function

		' Token: 0x06000355 RID: 853 RVA: 0x0000A61D File Offset: 0x0000881D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo.O00. = A_0
		End Sub

		' Token: 0x06000356 RID: 854 RVA: 0x0000A628 File Offset: 0x00008828
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O_.OoO0O0_o0_.
			AddHandler MyBase.FormClosed, AddressOf Me.O0OO.o00O00o.
			Me.o_OO._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06000357 RID: 855 RVA: 0x0000A67C File Offset: 0x0000887C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					Me.OO.__oOooo0o_.().Items.Add(dataTable.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.OO.__oOooo0o_.().SelectedIndex = 0
		End Sub

		' Token: 0x06000358 RID: 856 RVA: 0x0000A6E4 File Offset: 0x000088E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO.__oOooo0o_.().SelectedItem IsNot Nothing Then
				Dim dataTable As DataTable = OO_00oOO.DataTables(Me.OO.__oOooo0o_.().SelectedItem.ToString())
				Me.o_OO._.().Items.Clear()
				Try
					For Each dataCol As DataCol In dataTable.DataCols
						Me.o_OO._.().Items.Add(dataCol.Name)
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataCol)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000359 RID: 857 RVA: 0x0000A77C File Offset: 0x0000897C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO.__oOooo0o_.().SelectedItem IsNot Nothing AndAlso Me.o_OO._.().SelectedItem IsNot Nothing Then
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x0600035A RID: 858 RVA: 0x0000A79F File Offset: 0x0000899F
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000097 RID: 151
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000098 RID: 152
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000099 RID: 153
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400009A RID: 154
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400009B RID: 155
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400009C RID: 156
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400009D RID: 157
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label
	End Class
End Namespace
