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
	' Token: 0x02000378 RID: 888
	<DesignerGenerated()>
	Friend Partial Class oo\u3000\u3000\u3000\u3002
		Inherits Form

		' Token: 0x0600388E RID: 14478 RVA: 0x00183E14 File Offset: 0x00182014
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_00oO.0. IsNot Nothing Then
					Me.o_00oO.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600388F RID: 14479 RVA: 0x00183E54 File Offset: 0x00182054
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o_00oO.0.(New CheckedListBox())
			Me.oOOO.0o.(New Label())
			Me.oOOO.0o.(New C1Button())
			Me.o.O0_O_o.(New C1Button())
			Me.o_00oO.0.(New Label())
			MyBase.SuspendLayout()
			Me.o.O0_O_o.().CheckOnClick = True
			Me.o.O0_O_o.().FormattingEnabled = True
			Me.o.O0_O_o.().Location = New Point(12, 35)
			Me.o.O0_O_o.().Name = "lstTables"
			Me.o.O0_O_o.().Size = New Size(241, 260)
			Me.o.O0_O_o.().TabIndex = 0
			Me.o.O0_O_o.().AutoSize = True
			Me.o.O0_O_o.().Location = New Point(12, 14)
			Me.o.O0_O_o.().Name = "Label1"
			Me.o.O0_O_o.().Size = New Size(119, 12)
			Me.o.O0_O_o.().TabIndex = 1
			Me.o.O0_O_o.().Text = "请选择要初始化的表:"
			Me.Oo0.0000o00__o.().Location = New Point(265, 32)
			Me.Oo0.0000o00__o.().Name = "btnOk"
			Me.Oo0.0000o00__o.().Size = New Size(75, 23)
			Me.Oo0.0000o00__o.().TabIndex = 2
			Me.Oo0.0000o00__o.().Text = "确定"
			Me.Oo0.0000o00__o.().UseVisualStyleBackColor = True
			Me.o.O0_O_o.().DialogResult = DialogResult.Cancel
			Me.o.O0_O_o.().Location = New Point(265, 61)
			Me.o.O0_O_o.().Name = "btnCancel"
			Me.o.O0_O_o.().Size = New Size(75, 23)
			Me.o.O0_O_o.().TabIndex = 3
			Me.o.O0_O_o.().Text = "取消"
			Me.o.O0_O_o.().UseVisualStyleBackColor = True
			Me.Oo0.0000o00__o.().AutoSize = True
			Me.Oo0.0000o00__o.().Location = New Point(12, 304)
			Me.Oo0.0000o00__o.().Name = "Label2"
			Me.Oo0.0000o00__o.().Size = New Size(251, 12)
			Me.Oo0.0000o00__o.().TabIndex = 4
			Me.Oo0.0000o00__o.().Text = "提示:初始化将直接从后台清除表中所有数据。"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(352, 328)
			MyBase.Controls.Add(Me.Oo0.0000o00__o.())
			MyBase.Controls.Add(Me.o.O0_O_o.())
			MyBase.Controls.Add(Me.Oo0.0000o00__o.())
			MyBase.Controls.Add(Me.o.O0_O_o.())
			MyBase.Controls.Add(Me.o.O0_O_o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O..0..o."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "初始化项目"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003890 RID: 14480 RVA: 0x0018416B File Offset: 0x0018236B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.o_00oO.0.
		End Function

		' Token: 0x06003891 RID: 14481 RVA: 0x00184173 File Offset: 0x00182373
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Me.o_00oO.0. = A_0
		End Sub

		' Token: 0x06003892 RID: 14482 RVA: 0x0018417C File Offset: 0x0018237C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o_00oO.0.
		End Function

		' Token: 0x06003893 RID: 14483 RVA: 0x00184184 File Offset: 0x00182384
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_00oO.0. = A_0
		End Sub

		' Token: 0x06003894 RID: 14484 RVA: 0x0018418D File Offset: 0x0018238D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_00oO.0.
		End Function

		' Token: 0x06003895 RID: 14485 RVA: 0x00184198 File Offset: 0x00182398
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o000__OO._.
			Dim c1Button As C1Button = Me.o_00oO.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_00oO.0. = A_0
			c1Button = Me.o_00oO.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003896 RID: 14486 RVA: 0x001841DB File Offset: 0x001823DB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOOO.0o.
		End Function

		' Token: 0x06003897 RID: 14487 RVA: 0x001841E3 File Offset: 0x001823E3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oOOO.0o. = A_0
		End Sub

		' Token: 0x06003898 RID: 14488 RVA: 0x001841EC File Offset: 0x001823EC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOOO.0o.
		End Function

		' Token: 0x06003899 RID: 14489 RVA: 0x001841F4 File Offset: 0x001823F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOOO.0o. = A_0
		End Sub

		' Token: 0x0600389A RID: 14490 RVA: 0x00184200 File Offset: 0x00182400
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Oo0.0000o00__o.
			AddHandler MyBase.FormClosed, AddressOf Me.o.O0_O_o.
			Me.o.O0_O_o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600389B RID: 14491 RVA: 0x00184254 File Offset: 0x00182454
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					If(dataTable.frd_IsInnerTable OrElse dataTable.frd_IsOuterTable) AndAlso dataTable.AllowInitialize Then
						Me.o.O0_O_o.().Items.Add(dataTable.Name)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600389C RID: 14492 RVA: 0x001842C8 File Offset: 0x001824C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			OO_00oOO.DataTables.Save()
			Dim num As Integer = Me.o.O0_O_o.().Items.Count - 1
			For i As Integer = 0 To num
				If Me.o.O0_O_o.().GetItemChecked(i) Then
					Dim dataTable As DataTable = OO_00oOO.DataTables(Me.o.O0_O_o.().Items(i).ToString())
					If MessageBox.Show("[" + dataTable.Name + "]的所有数据将被清除，且不可恢复，是否确定要执行？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
						Return
					End If
					dataTable.DataRows.Clear(False)
				End If
				OO_00oOO.CompactAccessFile(OO_00oOO.ProjectFile, O_O0OO.oO_00Ooo___0._., True)
			Next
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x0600389D RID: 14493 RVA: 0x00184377 File Offset: 0x00182577
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001755 RID: 5973
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001756 RID: 5974
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001757 RID: 5975
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001758 RID: 5976
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001759 RID: 5977
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400175A RID: 5978
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label
	End Class
End Namespace
