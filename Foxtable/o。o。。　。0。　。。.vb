Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000368 RID: 872
	<DesignerGenerated()>
	Friend Partial Class o\u3002o\u3002\u3002\u3000\u30020\u3002\u3000\u3002\u3002\u3000
		Inherits Form

		' Token: 0x060036C5 RID: 14021 RVA: 0x00174120 File Offset: 0x00172320
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0_O.o_. IsNot Nothing Then
					Me.o0_O.o_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060036C6 RID: 14022 RVA: 0x00174160 File Offset: 0x00172360
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0_O.o_.(New ListBox())
			Me.O0ooO.o_O.(New C1Button())
			Me.o_oO0o.o.(New C1Button())
			Me.O0_O.oO_ooo.(New C1Button())
			Me.o__o.0.(New C1Button())
			MyBase.SuspendLayout()
			Me.O0ooO.o_O.().FormattingEnabled = True
			Me.O0ooO.o_O.().ItemHeight = 12
			Me.O0ooO.o_O.().Location = New Point(12, 12)
			Me.O0ooO.o_O.().Name = "ListBox1"
			Me.O0ooO.o_O.().Size = New Size(169, 208)
			Me.O0ooO.o_O.().TabIndex = 0
			Me.O0_O.oO_ooo.().Location = New Point(196, 12)
			Me.O0_O.oO_ooo.().Name = "btnRename"
			Me.O0_O.oO_ooo.().Size = New Size(75, 23)
			Me.O0_O.oO_ooo.().TabIndex = 1
			Me.O0_O.oO_ooo.().Text = "重命名"
			Me.O0_O.oO_ooo.().UseVisualStyleBackColor = True
			Me.O0ooO.o_O.().Location = New Point(196, 41)
			Me.O0ooO.o_O.().Name = "btnDelete"
			Me.O0ooO.o_O.().Size = New Size(75, 23)
			Me.O0ooO.o_O.().TabIndex = 2
			Me.O0ooO.o_O.().Text = "删除"
			Me.O0ooO.o_O.().UseVisualStyleBackColor = True
			Me.o_oO0o.o.().Location = New Point(196, 197)
			Me.o_oO0o.o.().Name = "btnCancel"
			Me.o_oO0o.o.().Size = New Size(75, 23)
			Me.o_oO0o.o.().TabIndex = 3
			Me.o_oO0o.o.().Text = "取消"
			Me.o_oO0o.o.().UseVisualStyleBackColor = True
			Me.o__o.0.().Location = New Point(196, 168)
			Me.o__o.0.().Name = "btnOk"
			Me.o__o.0.().Size = New Size(75, 23)
			Me.o__o.0.().TabIndex = 4
			Me.o__o.0.().Text = "确定"
			Me.o__o.0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(281, 236)
			MyBase.Controls.Add(Me.o__o.0.())
			MyBase.Controls.Add(Me.o_oO0o.o.())
			MyBase.Controls.Add(Me.O0ooO.o_O.())
			MyBase.Controls.Add(Me.O0_O.oO_ooo.())
			MyBase.Controls.Add(Me.O0ooO.o_O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO..o..."
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "表视图管理"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060036C7 RID: 14023 RVA: 0x00174465 File Offset: 0x00172665
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o0_O.o_.
		End Function

		' Token: 0x060036C8 RID: 14024 RVA: 0x0017446D File Offset: 0x0017266D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o0_O.o_. = A_0
		End Sub

		' Token: 0x060036C9 RID: 14025 RVA: 0x00174476 File Offset: 0x00172676
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_O.o_.
		End Function

		' Token: 0x060036CA RID: 14026 RVA: 0x00174480 File Offset: 0x00172680
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo_._.
			Dim c1Button As C1Button = Me.o0_O.o_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0_O.o_. = A_0
			c1Button = Me.o0_O.o_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060036CB RID: 14027 RVA: 0x001744C3 File Offset: 0x001726C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.oOo_0.
		End Function

		' Token: 0x060036CC RID: 14028 RVA: 0x001744CC File Offset: 0x001726CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo._Oooo_.
			Dim o.oOo_0. As C1Button = Me.O.oOo_0.
			If o.oOo_0. IsNot Nothing Then
				RemoveHandler o.oOo_0..Click, value
			End If
			Me.O.oOo_0. = A_0
			o.oOo_0. = Me.O.oOo_0.
			If o.oOo_0. IsNot Nothing Then
				AddHandler o.oOo_0..Click, value
			End If
		End Sub

		' Token: 0x060036CD RID: 14029 RVA: 0x0017450F File Offset: 0x0017270F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_Oo.O_o0_00_O.
		End Function

		' Token: 0x060036CE RID: 14030 RVA: 0x00174518 File Offset: 0x00172718
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOO._.
			Dim c1Button As C1Button = Me.o_Oo.O_o0_00_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_Oo.O_o0_00_O. = A_0
			c1Button = Me.o_Oo.O_o0_00_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060036CF RID: 14031 RVA: 0x0017455B File Offset: 0x0017275B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0.00_00.
		End Function

		' Token: 0x060036D0 RID: 14032 RVA: 0x00174564 File Offset: 0x00172764
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOo.o0ooO0O_O.
			Dim c1Button As C1Button = Me.o0.00_00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0.00_00. = A_0
			c1Button = Me.o0.00_00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060036D1 RID: 14033 RVA: 0x001745A8 File Offset: 0x001727A8
		Public Sub New(A_0 As Table)
			AddHandler MyBase.FormClosed, AddressOf Me.OoOO._.
			Me.O00oO0_.O. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			Me.O0ooO.o_O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O00oO0_.O. = A_0
			Me.o0_O.o_. = New DataView(Me.O00oO0_.O., "[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString(0), "", DataViewRowState.CurrentRows)
			Me.o0_O.o_. = CType(Me.BindingContext(Me.o0_O.o_.), CurrencyManager)
			Me.O0ooO.o_O.().DataSource = Me.o0_O.o_.
			Me.O0ooO.o_O.().DisplayMember = "Name"
		End Sub

		' Token: 0x060036D2 RID: 14034 RVA: 0x0017467E File Offset: 0x0017287E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0_O.o_..Position >= 0 Then
				CType(Me.o0_O.o_..Current, DataRowView).Delete()
			End If
		End Sub

		' Token: 0x060036D3 RID: 14035 RVA: 0x001746A4 File Offset: 0x001728A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0_O.o_..Position >= 0 Then
				Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("重命名", "请输入视图名称:", Conversions.ToString(CType(Me.o0_O.o_..Current, DataRowView)("Name")))
				o_u3000_u.Oo.__0o_0_Oo.(AddressOf Me.o0_O.o_.)
				If o_u3000_u.ShowDialog() = DialogResult.OK Then
					CType(Me.o0_O.o_..Current, DataRowView)("Name") = o_u3000_u.Value
					CType(Me.o0_O.o_..Current, DataRowView).EndEdit()
				End If
			End If
		End Sub

		' Token: 0x060036D4 RID: 14036 RVA: 0x00174740 File Offset: 0x00172940
		Private Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If Operators.CompareString(A_1.Value, "", True) = 0 Then
				MessageBox.Show("请输入视图名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
				Return
			End If
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 AndAlso Me.O00oO0_.O..Rows.Find(New Object() { Me.O00oO0_.O..DataTable.Name, A_1.Value, 0 }) IsNot Nothing Then
				MessageBox.Show("已经存在同名视图，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060036D5 RID: 14037 RVA: 0x001747E6 File Offset: 0x001729E6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Oo00.o0_o._O_.(Me.O00oO0_.O., True)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060036D6 RID: 14038 RVA: 0x001747FB File Offset: 0x001729FB
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O00oO0_.O..RejectChanges()
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x060036D7 RID: 14039 RVA: 0x0017480F File Offset: 0x00172A0F
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001687 RID: 5767
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001688 RID: 5768
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001689 RID: 5769
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400168A RID: 5770
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400168B RID: 5771
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400168C RID: 5772
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400168D RID: 5773
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400168E RID: 5774
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x0400168F RID: 5775
		Private <<EMPTY_NAME>> As CurrencyManager

		' Token: 0x04001690 RID: 5776
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
