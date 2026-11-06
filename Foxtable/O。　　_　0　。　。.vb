Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000382 RID: 898
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000
		Inherits System.Windows.Forms.Form

		' Token: 0x06003998 RID: 14744 RVA: 0x0018EA2A File Offset: 0x0018CC2A
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.ooooooO0.o. IsNot Nothing Then
				Me.ooooooO0.o..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003999 RID: 14745 RVA: 0x0018EA4C File Offset: 0x0018CC4C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.ooooooO0.o. = New Container()
			Me.O_O__.Oo0.(New C1Button())
			Me.o.0_0_ooO_00__.(New C1Button())
			Me.O_o0Oo.__0OOOO.(New C1Button())
			Me.o0_O0._0OO.(New C1Button())
			Me.Oo0.0___0Ooo.(New C1Button())
			Me.O_O__.Oo0.(New System.Windows.Forms.ListBox())
			Me.O_O__.Oo0.(New ContextMenuStrip(Me.ooooooO0.o.))
			Me.O_O__.Oo0.(New ToolStripMenuItem())
			Me.Ooo.O0.(New ToolStripMenuItem())
			Me.O_O0_Oo_Oo.o_.(New C1Button())
			Me.oOo._O_0O__o.(New oOOoo_0_0o_())
			Me.oOOoo0.__0o.().BeginInit()
			Me.o_Oo.OO_.().BeginInit()
			Me.o0o.o_O.().BeginInit()
			Me.O__0.__00o_O.().BeginInit()
			Me.OoOooOo__._o.().BeginInit()
			Me.oO.__Oo_O_O_0_.().SuspendLayout()
			Me.O__O00.O0OO.().BeginInit()
			MyBase.SuspendLayout()
			Me.oOOoo0.__0o.().Location = New Point(331, 416)
			Me.oOOoo0.__0o.().Name = "btnClose"
			Me.oOOoo0.__0o.().Size = New Size(75, 23)
			Me.oOOoo0.__0o.().TabIndex = 5
			Me.oOOoo0.__0o.().Text = "关闭"
			Me.oOOoo0.__0o.().UseVisualStyleBackColor = True
			Me.o_Oo.OO_.().Location = New Point(331, 102)
			Me.o_Oo.OO_.().Name = "btnRename"
			Me.o_Oo.OO_.().Size = New Size(75, 23)
			Me.o_Oo.OO_.().TabIndex = 4
			Me.o_Oo.OO_.().Text = "重命名"
			Me.o_Oo.OO_.().UseVisualStyleBackColor = True
			Me.o0o.o_O.().Location = New Point(331, 73)
			Me.o0o.o_O.().Name = "btnDelete"
			Me.o0o.o_O.().Size = New Size(75, 23)
			Me.o0o.o_O.().TabIndex = 3
			Me.o0o.o_O.().Text = "删除"
			Me.o0o.o_O.().UseVisualStyleBackColor = True
			Me.O__0.__00o_O.().Location = New Point(331, 44)
			Me.O__0.__00o_O.().Name = "btnEdit"
			Me.O__0.__00o_O.().Size = New Size(75, 23)
			Me.O__0.__00o_O.().TabIndex = 2
			Me.O__0.__00o_O.().Text = "编辑"
			Me.O__0.__00o_O.().UseVisualStyleBackColor = True
			Me.OoOooOo__._o.().Location = New Point(331, 15)
			Me.OoOooOo__._o.().Name = "btnAdd"
			Me.OoOooOo__._o.().Size = New Size(75, 23)
			Me.OoOooOo__._o.().TabIndex = 1
			Me.OoOooOo__._o.().Text = "增加"
			Me.OoOooOo__._o.().UseVisualStyleBackColor = True
			Me.oO.__Oo_O_O_0_.().DrawMode = DrawMode.OwnerDrawFixed
			Me.oO.__Oo_O_O_0_.().FormattingEnabled = True
			Me.oO.__Oo_O_O_0_.().IntegralHeight = False
			Me.oO.__Oo_O_O_0_.().ItemHeight = 15
			Me.oO.__Oo_O_O_0_.().Location = New Point(12, 15)
			Me.oO.__Oo_O_O_0_.().Name = "lstTables"
			Me.oO.__Oo_O_O_0_.().Size = New Size(302, 424)
			Me.oO.__Oo_O_O_0_.().TabIndex = 0
			Me.oO.__Oo_O_O_0_.().Items.AddRange(New ToolStripItem() { Me.oO.__Oo_O_O_0_.(), Me.OOO_OOOOOo._.() })
			Me.oO.__Oo_O_O_0_.().Name = "ContextMenuStrip1"
			Me.oO.__Oo_O_O_0_.().ShowImageMargin = False
			Me.oO.__Oo_O_O_0_.().Size = New Size(133, 48)
			Me.oO.__Oo_O_O_0_.().Name = "JoinTableBuilder"
			Me.oO.__Oo_O_O_0_.().Size = New Size(132, 22)
			Me.oO.__Oo_O_O_0_.().Text = "查询表生成器..."
			Me.OOO_OOOOOo._.().Name = "SelectString"
			Me.OOO_OOOOOo._.().Size = New Size(132, 22)
			Me.OOO_OOOOOo._.().Text = "Select语句..."
			Me.O__O00.O0OO.().Location = New Point(331, 131)
			Me.O__O00.O0OO.().Name = "btnFilter"
			Me.O__O00.O0OO.().Size = New Size(75, 23)
			Me.O__O00.O0OO.().TabIndex = 22
			Me.O__O00.O0OO.().Text = "查找"
			Me.O__O00.O0OO.().UseVisualStyleBackColor = True
			Me.oO.__Oo_O_O_0_.().o0_OOo___o.0O.(500)
			Me.oO.__Oo_O_O_0_.().Location = New Point(12, 450)
			Me.oO.__Oo_O_O_0_.().Name = "SearchBox1"
			Me.oO.__Oo_O_O_0_.().Size = New Size(302, 24)
			Me.oO.__Oo_O_O_0_.().TabIndex = 21
			Me.oO.__Oo_O_O_0_.().Visible = False
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(418, 455)
			MyBase.Controls.Add(Me.O__O00.O0OO.())
			MyBase.Controls.Add(Me.oO.__Oo_O_O_0_.())
			MyBase.Controls.Add(Me.oO.__Oo_O_O_0_.())
			MyBase.Controls.Add(Me.o_Oo.OO_.())
			MyBase.Controls.Add(Me.o0o.o_O.())
			MyBase.Controls.Add(Me.oOOoo0.__0o.())
			MyBase.Controls.Add(Me.O__0.__00o_O.())
			MyBase.Controls.Add(Me.OoOooOo__._o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o0.o0_o0."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "查询表管理"
			Me.oOOoo0.__0o.().EndInit()
			Me.o_Oo.OO_.().EndInit()
			Me.o0o.o_O.().EndInit()
			Me.O__0.__00o_O.().EndInit()
			Me.OoOooOo__._o.().EndInit()
			Me.oO.__Oo_O_O_0_.().ResumeLayout(False)
			Me.O__O00.O0OO.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600399A RID: 14746 RVA: 0x0018F081 File Offset: 0x0018D281
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOo._O_0O__o.
		End Function

		' Token: 0x0600399B RID: 14747 RVA: 0x0018F08C File Offset: 0x0018D28C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_00o.__O.
			Dim c1Button As C1Button = Me.oOo._O_0O__o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOo._O_0O__o. = A_0
			c1Button = Me.oOo._O_0O__o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600399C RID: 14748 RVA: 0x0018F0CF File Offset: 0x0018D2CF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo.O0.
		End Function

		' Token: 0x0600399D RID: 14749 RVA: 0x0018F0D8 File Offset: 0x0018D2D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOOoo0.__0o.
			Dim ooo.O0. As C1Button = Me.Ooo.O0.
			If ooo.O0. IsNot Nothing Then
				RemoveHandler ooo.O0..Click, value
			End If
			Me.Ooo.O0. = A_0
			ooo.O0. = Me.Ooo.O0.
			If ooo.O0. IsNot Nothing Then
				AddHandler ooo.O0..Click, value
			End If
		End Sub

		' Token: 0x0600399E RID: 14750 RVA: 0x0018F11B File Offset: 0x0018D31B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO0O.0o_o.
		End Function

		' Token: 0x0600399F RID: 14751 RVA: 0x0018F124 File Offset: 0x0018D324
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_O.O0_O.
			Dim oo0O.0o_o. As C1Button = Me.OO0O.0o_o.
			If oo0O.0o_o. IsNot Nothing Then
				RemoveHandler oo0O.0o_o..Click, value
			End If
			Me.OO0O.0o_o. = A_0
			oo0O.0o_o. = Me.OO0O.0o_o.
			If oo0O.0o_o. IsNot Nothing Then
				AddHandler oo0O.0o_o..Click, value
			End If
		End Sub

		' Token: 0x060039A0 RID: 14752 RVA: 0x0018F167 File Offset: 0x0018D367
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo_OooO.O.
		End Function

		' Token: 0x060039A1 RID: 14753 RVA: 0x0018F170 File Offset: 0x0018D370
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_0o__.00o_.
			Dim ooo_OooO.O. As C1Button = Me.Ooo_OooO.O.
			If ooo_OooO.O. IsNot Nothing Then
				RemoveHandler ooo_OooO.O..Click, value
			End If
			Me.Ooo_OooO.O. = A_0
			ooo_OooO.O. = Me.Ooo_OooO.O.
			If ooo_OooO.O. IsNot Nothing Then
				AddHandler ooo_OooO.O..Click, value
			End If
		End Sub

		' Token: 0x060039A2 RID: 14754 RVA: 0x0018F1B3 File Offset: 0x0018D3B3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo.oOo00O.
		End Function

		' Token: 0x060039A3 RID: 14755 RVA: 0x0018F1BC File Offset: 0x0018D3BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.Oo.
			Dim oo.oOo00O. As C1Button = Me.Oo.oOo00O.
			If oo.oOo00O. IsNot Nothing Then
				RemoveHandler oo.oOo00O..Click, value
			End If
			Me.Oo.oOo00O. = A_0
			oo.oOo00O. = Me.Oo.oOo00O.
			If oo.oOo00O. IsNot Nothing Then
				AddHandler oo.oOo00O..Click, value
			End If
		End Sub

		' Token: 0x060039A4 RID: 14756 RVA: 0x0018F1FF File Offset: 0x0018D3FF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.ListBox
			Return Me.ooooooO0.o.
		End Function

		' Token: 0x060039A5 RID: 14757 RVA: 0x0018F208 File Offset: 0x0018D408
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.ListBox)
			Dim value As DrawItemEventHandler = AddressOf Me.oO.__Oo_O_O_0_.
			Dim listBox As System.Windows.Forms.ListBox = Me.ooooooO0.o.
			If listBox IsNot Nothing Then
				RemoveHandler listBox.DrawItem, value
			End If
			Me.ooooooO0.o. = A_0
			listBox = Me.ooooooO0.o.
			If listBox IsNot Nothing Then
				AddHandler listBox.DrawItem, value
			End If
		End Sub

		' Token: 0x060039A6 RID: 14758 RVA: 0x0018F24B File Offset: 0x0018D44B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.oOo._O_0O__o.
		End Function

		' Token: 0x060039A7 RID: 14759 RVA: 0x0018F253 File Offset: 0x0018D453
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.oOo._O_0O__o. = A_0
		End Sub

		' Token: 0x060039A8 RID: 14760 RVA: 0x0018F25C File Offset: 0x0018D45C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.ooooooO0.o.
		End Function

		' Token: 0x060039A9 RID: 14761 RVA: 0x0018F270 File Offset: 0x0018D470
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o_Oo.OO_.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.ooooooO0.o.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							RemoveHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 1
							Return
						Case 2
							If True Then
							End If
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							GoTo IL_62
						Case 3
							GoTo IL_62
						Case 4
							AddHandler toolStripMenuItem.Click, value
							num = 1
							Continue For
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
					End Select
					Exit For
					IL_62:
					Me.ooooooO0.o. = A_0
					toolStripMenuItem = Me.ooooooO0.o.
					num = 5
				End While
			End While
		End Sub

		' Token: 0x060039AA RID: 14762 RVA: 0x0018F31C File Offset: 0x0018D51C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_0_O__0_.0.
		End Function

		' Token: 0x060039AB RID: 14763 RVA: 0x0018F330 File Offset: 0x0018D530
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o0_O0._0OO.
				Dim o_0_O__0_.0. As ToolStripMenuItem = Me.O_0_O__0_.0.
				Dim num As Integer = 3
				While True
					Select Case num
						Case 0
							RemoveHandler o_0_O__0_.0..Click, value
							num = 2
							Continue For
						Case 1
							AddHandler o_0_O__0_.0..Click, value
							num = 5
							Continue For
						Case 2
							GoTo IL_62
						Case 3
							If o_0_O__0_.0. IsNot Nothing Then
								If True Then
								End If
								num = 0
								Continue For
							End If
							GoTo IL_62
						Case 4
							If o_0_O__0_.0. IsNot Nothing Then
								num = 1
								Continue For
							End If
							Return
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.O_0_O__0_.0. = A_0
					o_0_O__0_.0. = Me.O_0_O__0_.0.
					num = 4
				End While
			End While
		End Sub

		' Token: 0x060039AC RID: 14764 RVA: 0x0018F3D9 File Offset: 0x0018D5D9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oOOoo_0_0o_
			Return Me.ooooooO0.o.
		End Function

		' Token: 0x060039AD RID: 14765 RVA: 0x0018F3E4 File Offset: 0x0018D5E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oOOoo_0_0o_)
			Dim a_ As EventHandler = AddressOf Me.oO.__Oo_O_O_0_.
			Dim oOOoo_0_0o_ As oOOoo_0_0o_ = Me.ooooooO0.o.
			If oOOoo_0_0o_ IsNot Nothing Then
				oOOoo_0_0o_.o0_OOo___o.0O.(a_)
			End If
			Me.ooooooO0.o. = A_0
			oOOoo_0_0o_ = Me.ooooooO0.o.
			If oOOoo_0_0o_ IsNot Nothing Then
				oOOoo_0_0o_.o.oOO_O.(a_)
			End If
		End Sub

		' Token: 0x060039AE RID: 14766 RVA: 0x0018F427 File Offset: 0x0018D627
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_0Oo_O_O0_.O.
		End Function

		' Token: 0x060039AF RID: 14767 RVA: 0x0018F430 File Offset: 0x0018D630
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.0ooOO.
			Dim o_0Oo_O_O0_.O. As C1Button = Me.O_0Oo_O_O0_.O.
			If o_0Oo_O_O0_.O. IsNot Nothing Then
				RemoveHandler o_0Oo_O_O0_.O..Click, value
			End If
			Me.O_0Oo_O_O0_.O. = A_0
			o_0Oo_O_O0_.O. = Me.O_0Oo_O_O0_.O.
			If o_0Oo_O_O0_.O. IsNot Nothing Then
				AddHandler o_0Oo_O_O0_.O..Click, value
			End If
		End Sub

		' Token: 0x060039B0 RID: 14768 RVA: 0x0018F474 File Offset: 0x0018D674
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oo0.o_oO.
			AddHandler MyBase.FormClosed, AddressOf Me.o0o.o_O.
			Me.OOO_OOOOOo._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060039B1 RID: 14769 RVA: 0x0018F4C8 File Offset: 0x0018D6C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO.__Oo_O_O_0_.().DataSource = New DataView(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), "[Type] <> " + Conversions.ToString(0), "", DataViewRowState.CurrentRows)
			Me.oO.__Oo_O_O_0_.().DisplayMember = "Name"
		End Sub

		' Token: 0x060039B2 RID: 14770 RVA: 0x0018F520 File Offset: 0x0018D720
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO.__Oo_O_O_0_.().Show(Me.OoOooOo__._o.(), New Point(0, Me.OoOooOo__._o.().Height))
		End Sub

		' Token: 0x060039B3 RID: 14771 RVA: 0x0018F544 File Offset: 0x0018D744
		Private Overloads Sub <<EMPTY_NAME>>()
			If Me.oO.__Oo_O_O_0_.().Visible AndAlso Operators.CompareString(Me.oO.__Oo_O_O_0_.().Text, "", True) > 0 Then
				Me.oO.__Oo_O_O_0_.().Text = ""
				Me.oO.__Oo_O_O_0_.().O_o_.O0o00o__0.(EventArgs.Empty)
			End If
		End Sub

		' Token: 0x060039B4 RID: 14772 RVA: 0x0018F598 File Offset: 0x0018D798
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO.__Oo_O_O_0_.().SelectedItem IsNot Nothing Then
				Dim dataRowView As DataRowView = CType(Me.oO.__Oo_O_O_0_.().SelectedItem, DataRowView)
				Dim text As String = Conversions.ToString(dataRowView("Name"))
				If Oo00.o0.__oO0_.(text) Then
					Try
						Dim enumerator As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
						While enumerator.MoveNext()
							If Operators.CompareString(enumerator.Current.TableName, text, True) = 0 Then
								MessageBox.Show("请在删除表之前，先删除此表的窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Return
							End If
						End While
					Finally
						Dim enumerator As IEnumerator(Of Foxtable.WinForm.Form)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					If O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(text) Then
						OO_00oOO.DataTables.OO0o00.0O_0o.(text, True)
						Return
					End If
					dataRowView.Row.Delete()
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					OO_00oOO.DataTables.OO0o00.0O_0o.(text)
				End If
			End If
		End Sub

		' Token: 0x060039B5 RID: 14773 RVA: 0x0018F690 File Offset: 0x0018D890
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060039B6 RID: 14774 RVA: 0x0018F698 File Offset: 0x0018D898
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO.__Oo_O_O_0_.().SelectedItem IsNot Nothing Then
				Dim row As DataRow = CType(Me.oO.__Oo_O_O_0_.().SelectedItem, DataRowView).Row
				If Oo00.o0.__oO0_.(row("Name").ToString()) Then
					If row("Property").ToString().StartsWith("{") Then
						New af(row).ShowDialog()
						Return
					End If
					New O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000(row).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x060039B7 RID: 14775 RVA: 0x0018F714 File Offset: 0x0018D914
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO.__Oo_O_O_0_.().SelectedItem IsNot Nothing Then
				Dim row As DataRow = CType(Me.oO.__Oo_O_O_0_.().SelectedItem, DataRowView).Row
				Dim a_ As String = row("Name").ToString()
				If Oo00.o0.__oO0_.(a_) Then
					If OO_00oOO.DataTables.Contains("") Then
						Foxtable.Syscmd.Table.OO.OO_0o.(OO_00oOO.DataTables(a_))
						Return
					End If
					Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(a_, "")
					If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
						row("Name") = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
						Foxtable.Syscmd.Table.OO.OO_0o.(a_, o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.())
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					End If
				End If
			End If
		End Sub

		' Token: 0x060039B8 RID: 14776 RVA: 0x0018F7D0 File Offset: 0x0018D9D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Foxtable.Syscmd.Table.OO__OO.0.() Then
				Me.o0o.o_O.()
				Dim count As Integer = Me.oO.__Oo_O_O_0_.().Items.Count
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).NewRow()
				dataRow("Type") = 1
				New af(dataRow).ShowDialog()
				If Me.oO.__Oo_O_O_0_.().Items.Count > count Then
					Me.oO.__Oo_O_O_0_.().SelectedIndex = Me.oO.__Oo_O_O_0_.().Items.Count - 1
					OO_00oOO.MainTable = OO_00oOO.Tables(dataRow("Name").ToString())
				End If
			End If
		End Sub

		' Token: 0x060039B9 RID: 14777 RVA: 0x0018F884 File Offset: 0x0018DA84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Foxtable.Syscmd.Table.OO__OO.0.() Then
				Me.o0o.o_O.()
				Dim count As Integer = Me.oO.__Oo_O_O_0_.().Items.Count
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).NewRow()
				dataRow("Type") = 1
				New O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000(dataRow).ShowDialog()
				If Me.oO.__Oo_O_O_0_.().Items.Count > count Then
					Me.oO.__Oo_O_O_0_.().SelectedIndex = Me.oO.__Oo_O_O_0_.().Items.Count - 1
					OO_00oOO.MainTable = OO_00oOO.Tables(dataRow("Name").ToString())
				End If
			End If
		End Sub

		' Token: 0x060039BA RID: 14778 RVA: 0x0018F938 File Offset: 0x0018DB38
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x060039BB RID: 14779 RVA: 0x0018F94C File Offset: 0x0018DB4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.oO.__Oo_O_O_0_.().Visible Then
				Me.a = MyBase.Height
				MyBase.Height = Me.oO.__Oo_O_O_0_.().Bottom + 44
				Me.oO.__Oo_O_O_0_.().Visible = True
				Me.oO.__Oo_O_O_0_.().ooO00_0.0.().[Select]()
				Return
			End If
			MyBase.Height = Me.a
			Me.oO.__Oo_O_O_0_.().Visible = False
			Me.oO.__Oo_O_O_0_.().Text = ""
		End Sub

		' Token: 0x060039BC RID: 14780 RVA: 0x0018F9CC File Offset: 0x0018DBCC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataView As DataView = TryCast(Me.oO.__Oo_O_O_0_.().DataSource, DataView)
			If String.IsNullOrWhiteSpace(Me.oO.__Oo_O_O_0_.().Text) Then
				dataView.RowFilter = "[Type] <> " + Conversions.ToString(0)
				Return
			End If
			dataView.RowFilter = "name like '%" + Me.oO.__Oo_O_O_0_.().Text.Trim() + "%' And [Type] <> " + Conversions.ToString(0)
		End Sub

		' Token: 0x060039BD RID: 14781 RVA: 0x0018FA40 File Offset: 0x0018DC40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawItemEventArgs)
			If A_1.Index >= 0 Then
				A_1.DrawBackground()
				A_1.DrawFocusRectangle()
				A_1.Graphics.DrawString(CType(Me.oO.__Oo_O_O_0_.().Items(A_1.Index), DataRowView)(Me.oO.__Oo_O_O_0_.().DisplayMember).ToString(), A_1.Font, New SolidBrush(A_1.ForeColor), A_1.Bounds, StringFormat.GenericDefault)
			End If
		End Sub

		' Token: 0x040017D8 RID: 6104
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040017D9 RID: 6105
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017DA RID: 6106
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017DB RID: 6107
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017DC RID: 6108
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017DD RID: 6109
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017DE RID: 6110
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.ListBox

		' Token: 0x040017DF RID: 6111
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x040017E0 RID: 6112
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040017E1 RID: 6113
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040017E2 RID: 6114
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oOOoo_0_0o_

		' Token: 0x040017E3 RID: 6115
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017E4 RID: 6116
		Private a As Integer
	End Class
End Namespace
