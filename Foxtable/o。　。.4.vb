Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000374 RID: 884
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3002
		Inherits Form

		' Token: 0x060037F9 RID: 14329 RVA: 0x0017DE38 File Offset: 0x0017C038
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOo__.oO0. IsNot Nothing Then
					Me.oOo__.oO0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060037FA RID: 14330 RVA: 0x0017DE78 File Offset: 0x0017C078
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OoOo_o.0.(New Label())
			Me.O0O.__O0.(New C1TextBox())
			Me.o.o0o__o0_.(New RadioButton())
			Me.o.OooOO.(New RadioButton())
			Me.o.o0o__o0_.(New Label())
			Me.O0.OO.(New C1TextBox())
			Me.OoOo_o.0.(New C1Button())
			Me.o.o0o__o0_.(New C1Button())
			Me.o.OooOO.(New C1Button())
			Me.OoOo_o.0.(New C1TextBox())
			Me.o.OooOO.(New Label())
			Me.oO.__0_OOO00.().BeginInit()
			Me.o0O.0O0O_0O_.().BeginInit()
			Me.oO.__0_OOO00.().BeginInit()
			Me.oo0o00O0oo0.O.().BeginInit()
			Me.O0OOoO_.__o_0.().BeginInit()
			Me.oo0o00O0oo0.O.().BeginInit()
			MyBase.SuspendLayout()
			Me.oo0o00O0oo0.O.().AutoSize = True
			Me.oo0o00O0oo0.O.().Location = New Point(16, 30)
			Me.oo0o00O0oo0.O.().Margin = New Padding(4, 0, 4, 0)
			Me.oo0o00O0oo0.O.().Name = "Label1"
			Me.oo0o00O0oo0.O.().Size = New Size(62, 18)
			Me.oo0o00O0oo0.O.().TabIndex = 0
			Me.oo0o00O0oo0.O.().Text = "表名："
			Me.oO.__0_OOO00.().Location = New Point(16, 56)
			Me.oO.__0_OOO00.().Margin = New Padding(4, 4, 4, 4)
			Me.oO.__0_OOO00.().Name = "txtName"
			Me.oO.__0_OOO00.().Size = New Size(346, 26)
			Me.oO.__0_OOO00.().TabIndex = 0
			Me.oO.__0_OOO00.().Tag = Nothing
			Me.o0O.0O0O_0O_.().AutoSize = True
			Me.o0O.0O0O_0O_.().Location = New Point(16, 216)
			Me.o0O.0O0O_0O_.().Margin = New Padding(4, 4, 4, 4)
			Me.o0O.0O0O_0O_.().Name = "RadioButton1"
			Me.o0O.0O0O_0O_.().Size = New Size(105, 22)
			Me.o0O.0O0O_0O_.().TabIndex = 4
			Me.o0O.0O0O_0O_.().Text = "包括数据"
			Me.o0O.0O0O_0O_.().UseVisualStyleBackColor = True
			Me.oo0o00O0oo0.O.().AutoSize = True
			Me.oo0o00O0oo0.O.().Checked = True
			Me.oo0o00O0oo0.O.().Location = New Point(16, 183)
			Me.oo0o00O0oo0.O.().Margin = New Padding(4, 4, 4, 4)
			Me.oo0o00O0oo0.O.().Name = "rdoOnlyStructure"
			Me.oo0o00O0oo0.O.().Size = New Size(123, 22)
			Me.oo0o00O0oo0.O.().TabIndex = 3
			Me.oo0o00O0oo0.O.().TabStop = True
			Me.oo0o00O0oo0.O.().Text = "仅复制结构"
			Me.oo0o00O0oo0.O.().UseVisualStyleBackColor = True
			Me.o0O.0O0O_0O_.().AutoSize = True
			Me.o0O.0O0O_0O_.().Location = New Point(16, 262)
			Me.o0O.0O0O_0O_.().Margin = New Padding(4, 0, 4, 0)
			Me.o0O.0O0O_0O_.().Name = "Label2"
			Me.o0O.0O0O_0O_.().Size = New Size(98, 18)
			Me.o0O.0O0O_0O_.().TabIndex = 5
			Me.o0O.0O0O_0O_.().Text = "复制条件："
			Me.o0O.0O0O_0O_.().BackColor = Color.White
			Me.o0O.0O0O_0O_.().Location = New Point(16, 288)
			Me.o0O.0O0O_0O_.().Margin = New Padding(4, 4, 4, 4)
			Me.o0O.0O0O_0O_.().Name = "txtExpression"
			Me.o0O.0O0O_0O_.().[ReadOnly] = True
			Me.o0O.0O0O_0O_.().Size = New Size(506, 26)
			Me.o0O.0O0O_0O_.().TabIndex = 6
			Me.o0O.0O0O_0O_.().Tag = Nothing
			Me.oO.__0_OOO00.().Location = New Point(526, 288)
			Me.oO.__0_OOO00.().Margin = New Padding(4, 4, 4, 4)
			Me.oO.__0_OOO00.().Name = "Button1"
			Me.oO.__0_OOO00.().Size = New Size(66, 28)
			Me.oO.__0_OOO00.().TabIndex = 7
			Me.oO.__0_OOO00.().Text = "..."
			Me.oO.__0_OOO00.().UseVisualStyleBackColor = True
			Me.oo0o00O0oo0.O.().Location = New Point(183, 351)
			Me.oo0o00O0oo0.O.().Margin = New Padding(4, 4, 4, 4)
			Me.oo0o00O0oo0.O.().Name = "btnOK"
			Me.oo0o00O0oo0.O.().Size = New Size(112, 34)
			Me.oo0o00O0oo0.O.().TabIndex = 8
			Me.oo0o00O0oo0.O.().Text = "确定"
			Me.oo0o00O0oo0.O.().UseVisualStyleBackColor = True
			Me.O0OOoO_.__o_0.().DialogResult = DialogResult.Cancel
			Me.O0OOoO_.__o_0.().Location = New Point(320, 351)
			Me.O0OOoO_.__o_0.().Margin = New Padding(4, 4, 4, 4)
			Me.O0OOoO_.__o_0.().Name = "btnCancel"
			Me.O0OOoO_.__o_0.().Size = New Size(112, 34)
			Me.O0OOoO_.__o_0.().TabIndex = 9
			Me.O0OOoO_.__o_0.().Text = "取消"
			Me.O0OOoO_.__o_0.().UseVisualStyleBackColor = True
			Me.oo0o00O0oo0.O.().Location = New Point(16, 128)
			Me.oo0o00O0oo0.O.().Margin = New Padding(4, 4, 4, 4)
			Me.oo0o00O0oo0.O.().Name = "txtCaption"
			Me.oo0o00O0oo0.O.().Size = New Size(346, 26)
			Me.oo0o00O0oo0.O.().TabIndex = 2
			Me.oo0o00O0oo0.O.().Tag = Nothing
			Me.oO.__0_OOO00.().AutoSize = True
			Me.oO.__0_OOO00.().Location = New Point(16, 102)
			Me.oO.__0_OOO00.().Margin = New Padding(4, 0, 4, 0)
			Me.oO.__0_OOO00.().Name = "Label3"
			Me.oO.__0_OOO00.().Size = New Size(62, 18)
			Me.oO.__0_OOO00.().TabIndex = 1
			Me.oO.__0_OOO00.().Text = "标题："
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(610, 393)
			MyBase.Controls.Add(Me.oo0o00O0oo0.O.())
			MyBase.Controls.Add(Me.oO.__0_OOO00.())
			MyBase.Controls.Add(Me.O0OOoO_.__o_0.())
			MyBase.Controls.Add(Me.oo0o00O0oo0.O.())
			MyBase.Controls.Add(Me.oO.__0_OOO00.())
			MyBase.Controls.Add(Me.o0O.0O0O_0O_.())
			MyBase.Controls.Add(Me.o0O.0O0O_0O_.())
			MyBase.Controls.Add(Me.oo0o00O0oo0.O.())
			MyBase.Controls.Add(Me.o0O.0O0O_0O_.())
			MyBase.Controls.Add(Me.oO.__0_OOO00.())
			MyBase.Controls.Add(Me.oo0o00O0oo0.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o000._.1."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "复制表"
			Me.oO.__0_OOO00.().EndInit()
			Me.o0O.0O0O_0O_.().EndInit()
			Me.oO.__0_OOO00.().EndInit()
			Me.oo0o00O0oo0.O.().EndInit()
			Me.O0OOoO_.__o_0.().EndInit()
			Me.oo0o00O0oo0.O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060037FB RID: 14331 RVA: 0x0017E618 File Offset: 0x0017C818
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0.OO.
		End Function

		' Token: 0x060037FC RID: 14332 RVA: 0x0017E620 File Offset: 0x0017C820
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0.OO. = A_0
		End Sub

		' Token: 0x060037FD RID: 14333 RVA: 0x0017E629 File Offset: 0x0017C829
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oOo__.oO0.
		End Function

		' Token: 0x060037FE RID: 14334 RVA: 0x0017E631 File Offset: 0x0017C831
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oOo__.oO0. = A_0
		End Sub

		' Token: 0x060037FF RID: 14335 RVA: 0x0017E63A File Offset: 0x0017C83A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0.OO.
		End Function

		' Token: 0x06003800 RID: 14336 RVA: 0x0017E642 File Offset: 0x0017C842
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O0.OO. = A_0
		End Sub

		' Token: 0x06003801 RID: 14337 RVA: 0x0017E64B File Offset: 0x0017C84B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0O.__O0.
		End Function

		' Token: 0x06003802 RID: 14338 RVA: 0x0017E653 File Offset: 0x0017C853
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O0O.__O0. = A_0
		End Sub

		' Token: 0x06003803 RID: 14339 RVA: 0x0017E65C File Offset: 0x0017C85C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0O.__O0.
		End Function

		' Token: 0x06003804 RID: 14340 RVA: 0x0017E664 File Offset: 0x0017C864
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0O.__O0. = A_0
		End Sub

		' Token: 0x06003805 RID: 14341 RVA: 0x0017E66D File Offset: 0x0017C86D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oo_oO.o_0_.
		End Function

		' Token: 0x06003806 RID: 14342 RVA: 0x0017E675 File Offset: 0x0017C875
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oo_oO.o_0_. = A_0
		End Sub

		' Token: 0x06003807 RID: 14343 RVA: 0x0017E67E File Offset: 0x0017C87E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.OO.
		End Function

		' Token: 0x06003808 RID: 14344 RVA: 0x0017E688 File Offset: 0x0017C888
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0OOoO_.__o_0.
			Dim o0.OO. As C1Button = Me.O0.OO.
			If o0.OO. IsNot Nothing Then
				RemoveHandler o0.OO..Click, value
			End If
			Me.O0.OO. = A_0
			o0.OO. = Me.O0.OO.
			If o0.OO. IsNot Nothing Then
				AddHandler o0.OO..Click, value
			End If
		End Sub

		' Token: 0x06003809 RID: 14345 RVA: 0x0017E6CB File Offset: 0x0017C8CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0O.__O0.
		End Function

		' Token: 0x0600380A RID: 14346 RVA: 0x0017E6D4 File Offset: 0x0017C8D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO_ooO.00o.
			Dim o0O.__O0. As C1Button = Me.O0O.__O0.
			If o0O.__O0. IsNot Nothing Then
				RemoveHandler o0O.__O0..Click, value
			End If
			Me.O0O.__O0. = A_0
			o0O.__O0. = Me.O0O.__O0.
			If o0O.__O0. IsNot Nothing Then
				AddHandler o0O.__O0..Click, value
			End If
		End Sub

		' Token: 0x0600380B RID: 14347 RVA: 0x0017E717 File Offset: 0x0017C917
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo0OoOo_o.0o_.
		End Function

		' Token: 0x0600380C RID: 14348 RVA: 0x0017E71F File Offset: 0x0017C91F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oo0OoOo_o.0o_. = A_0
		End Sub

		' Token: 0x0600380D RID: 14349 RVA: 0x0017E728 File Offset: 0x0017C928
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O.0o_.
		End Function

		' Token: 0x0600380E RID: 14350 RVA: 0x0017E730 File Offset: 0x0017C930
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O.0o_. = A_0
		End Sub

		' Token: 0x0600380F RID: 14351 RVA: 0x0017E739 File Offset: 0x0017C939
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo0OoOo_o.0o_.
		End Function

		' Token: 0x06003810 RID: 14352 RVA: 0x0017E741 File Offset: 0x0017C941
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo0OoOo_o.0o_. = A_0
		End Sub

		' Token: 0x06003811 RID: 14353 RVA: 0x0017E74A File Offset: 0x0017C94A
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.OO_ooO.00o.
			Me.o.o0o__o0_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003812 RID: 14354 RVA: 0x0017E77F File Offset: 0x0017C97F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0O.0O0O_0O_.().Value = OO_00oOO.MainTable.DataTable.OOoo__00O_.o_O.(Me.o0O.0O0O_0O_.().Text, False)
		End Sub

		' Token: 0x06003813 RID: 14355 RVA: 0x0017E7A8 File Offset: 0x0017C9A8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Information.Err().Clear()
				IL_13:
				num2 = 3
				Dim oleDbConnection As OleDbConnection = OO_00oOO.MainTable.DataTable.frd_Connection
				IL_25:
				num2 = 4
				Dim text As String = Me.oO.__0_OOO00.().Text.Trim()
				IL_39:
				num2 = 5
				Dim text2 As String = ""
				IL_42:
				num2 = 6
				If Not Oo00.o.O0_O0.(text) Then
					GoTo IL_585
				End If
				IL_50:
				num2 = 8
				If oleDbConnection IsNot O_O0OO.OoO.0OO__0ooo.() Then
					GoTo IL_86
				End If
				IL_5A:
				num2 = 9
				Dim text3 As String = "~TMPCLP" + OO_00oOO.MainTable.Name
				IL_73:
				num2 = 10
				Dim text4 As String = "~TMPCLP" + text
				GoTo IL_9C
				IL_86:
				num2 = 12
				text3 = OO_00oOO.MainTable.Name
				IL_95:
				num2 = 13
				text4 = text
				IL_9C:
				num2 = 14
				For Each dataColumn As DataColumn In OO_00oOO.MainTable.DataTable.BaseTable.PrimaryKey
					IL_C1:
					num2 = 15
					text2 = text2 + ",[" + dataColumn.ColumnName + "]"
					IL_DE:
					num2 = 16
				Next
				IL_EF:
				num2 = 17
				text2 = text2.Trim(New Char() { ","c })
				IL_106:
				num2 = 18
				Dim oleDbCommand As OleDbCommand = New OleDbCommand("", oleDbConnection)
				IL_116:
				num2 = 19
				oleDbCommand.CommandText = String.Concat(New String() { "Select * Into [", text4, "] From [", text3, "]" })
				IL_14D:
				num2 = 20
				If Not Me.oo0o00O0oo0.O.().Checked Then
					GoTo IL_17A
				End If
				IL_15D:
				num2 = 21
				oleDbCommand.CommandText += " Where 1 is Null"
				GoTo IL_1BC
				IL_17A:
				num2 = 23
				If Operators.CompareString(Me.o0O.0O0O_0O_.().Text, "", True) <= 0 Then
					GoTo IL_1BC
				End If
				IL_196:
				num2 = 24
				oleDbCommand.CommandText = oleDbCommand.CommandText + " Where " + Me.o0O.0O0O_0O_.().Text
				IL_1BC:
				num2 = 25
				OO_00oOO.MainTable.DataTable.Save()
				IL_1CE:
				num2 = 26
				oleDbConnection.Open()
				IL_1D7:
				num2 = 27
				oleDbCommand.ExecuteNonQuery()
				IL_1E2:
				num2 = 28
				oleDbCommand.CommandText = String.Concat(New String() { "Alter Table [", text4, "] ADD PRIMARY KEY (", text2, ")" })
				IL_219:
				num2 = 29
				oleDbCommand.ExecuteNonQuery()
				IL_224:
				num2 = 30
				oleDbConnection.Close()
				IL_22D:
				num2 = 31
				If Information.Err().Number <> 0 Then
					GoTo IL_585
				End If
				IL_23F:
				num2 = 33
				If oleDbConnection IsNot O_O0OO.OoO.0OO__0ooo.() Then
					GoTo IL_2A1
				End If
				IL_24A:
				num2 = 34
				o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), text4, True, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), False)
				IL_274:
				num2 = 35
				OO_00oOO.DataTables(text).o.0O000_.()
				IL_288:
				num2 = 36
				OO_00oOO.DataTables(text).o0.O_o.()
				GoTo IL_418
				IL_2A1:
				num2 = 38
				Dim value As String = ""
				IL_2AB:
				num2 = 39
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text5 As String = enumerator.Current
					IL_2CA:
					num2 = 40
					If O_O0OO.O._o_.()(text5) Is oleDbConnection Then
						IL_2DC:
						num2 = 41
						value = text5
						Exit While
					End If
					IL_2E5:
					num2 = 43
				End While
				IL_2F1:
				num2 = 44
				CType(enumerator, IDisposable).Dispose()
				IL_301:
				num2 = 45
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).NewRow()
				IL_31F:
				num2 = 46
				dataRow("Type") = 0
				IL_334:
				num2 = 47
				dataRow("Name") = text
				IL_345:
				num2 = 48
				Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
				IL_34F:
				num2 = 49
				outerTableSetting.SourceTable = text
				IL_35B:
				num2 = 50
				outerTableSetting.AllRows = False
				IL_366:
				num2 = 51
				outerTableSetting.Top = 10
				IL_372:
				num2 = 52
				dataRow("DataSource") = value
				IL_383:
				num2 = 53
				dataRow("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
				IL_39D:
				num2 = 54
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Add(dataRow)
				IL_3C0:
				num2 = 55
				Oo00.O0Oo_O.0O_0O.(dataRow)
				IL_3CA:
				num2 = 56
				o0OoOOoOOo0.OOOOO.o000.(dataRow, O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), True, False, Nothing)
				IL_404:
				num2 = 57
				OO_00oOO.DataTables(text).o.0O000_.()
				IL_418:
				num2 = 58
				OO_00oOO.DataTables(text).Caption = Me.oo0o00O0oo0.O.().Text
				IL_437:
				num2 = 59
				Dim enumerator2 As IEnumerator(Of DataCol) = OO_00oOO.DataTables(text).DataCols.GetEnumerator()
				While enumerator2.MoveNext()
					Dim dataCol As DataCol = enumerator2.Current
					IL_45D:
					num2 = 60
					If OO_00oOO.MainTable.DataTable.DataCols.Contains(dataCol.Name) Then
						IL_47D:
						num2 = 61
						dataCol.Caption = OO_00oOO.MainTable.DataTable.DataCols(dataCol.Name).Caption
						IL_4A7:
						num2 = 62
						dataCol.O.O_OO.(False)
					End If
					IL_4B2:
					num2 = 63
				End While
				IL_4BE:
				num2 = 64
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_4CC:
				num2 = 65
				OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text))
				IL_4E5:
				num2 = 66
				Main.OO_O.o..o0_o_o_0.0O.(text, True, False)
				IL_4F6:
				num2 = 67
				Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
				IL_51E:
				num2 = 68
				If Operators.CompareString(Me.oo0o00O0oo0.O.().Text, "", True) <= 0 Then
					GoTo IL_54F
				End If
				IL_53A:
				num2 = 69
				OO_00oOO.DataTables(text).OO00_o.ooOO.(False)
				IL_54F:
				num2 = 70
				O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				IL_55E:
				num2 = 71
				MyBase.DialogResult = DialogResult.OK
				IL_568:
				num2 = 72
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				IL_585:
				GoTo IL_6FB
				IL_58A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_6BC:
				GoTo IL_6F0
				IL_6BE:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6CE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6BE
			End Try
			IL_6F0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6FB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003814 RID: 14356 RVA: 0x0017EED4 File Offset: 0x0017D0D4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001717 RID: 5911
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001718 RID: 5912
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001719 RID: 5913
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400171A RID: 5914
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400171B RID: 5915
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400171C RID: 5916
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400171D RID: 5917
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400171E RID: 5918
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400171F RID: 5919
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001720 RID: 5920
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001721 RID: 5921
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001722 RID: 5922
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label
	End Class
End Namespace
