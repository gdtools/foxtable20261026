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
	' Token: 0x02000361 RID: 865
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class O\u3002_\u3002\u3000\u3002
		Inherits Form

		' Token: 0x0600361A RID: 13850 RVA: 0x0016DB4C File Offset: 0x0016BD4C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oO_0_0O0.o0__0. IsNot Nothing Then
					Me.oO_0_0O0.o0__0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600361B RID: 13851 RVA: 0x0016DB8C File Offset: 0x0016BD8C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O.o000OO_O0.(New C1Button())
			Me.oO_0_0O0.o0__0.(New C1Button())
			Me.oO_0_0O0.o0__0.(New C1ComboBox())
			Me.oO_0_0O0.o0__0.(New Label())
			MyBase.SuspendLayout()
			Me.O____0_0.0OO_0.().DialogResult = DialogResult.Cancel
			Me.O____0_0.0OO_0.().Location = New Point(138, 73)
			Me.O____0_0.0OO_0.().Name = "btnCancel"
			Me.O____0_0.0OO_0.().Size = New Size(75, 23)
			Me.O____0_0.0OO_0.().TabIndex = 12
			Me.O____0_0.0OO_0.().Tag = ""
			Me.O____0_0.0OO_0.().Text = "取消"
			Me.O____0_0.0OO_0.().UseVisualStyleBackColor = True
			Me.O__.__O_.().Location = New Point(57, 73)
			Me.O__.__O_.().Name = "btnOK"
			Me.O__.__O_.().Size = New Size(75, 23)
			Me.O__.__O_.().TabIndex = 11
			Me.O__.__O_.().Text = "确定"
			Me.O__.__O_.().UseVisualStyleBackColor = True
			Me.O__.__O_.().Location = New Point(14, 36)
			Me.O__.__O_.().Name = "ComboBox1"
			Me.O__.__O_.().Size = New Size(243, 20)
			Me.O__.__O_.().TabIndex = 10
			Me.O__.__O_.().AutoSize = True
			Me.O__.__O_.().Location = New Point(14, 15)
			Me.O__.__O_.().Name = "Label1"
			Me.O__.__O_.().Size = New Size(59, 12)
			Me.O__.__O_.().TabIndex = 9
			Me.O__.__O_.().Text = "设置名称:"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(272, 114)
			MyBase.Controls.Add(Me.O____0_0.0OO_0.())
			MyBase.Controls.Add(Me.O__.__O_.())
			MyBase.Controls.Add(Me.O__.__O_.())
			MyBase.Controls.Add(Me.O__.__O_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O...0..0"
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "保存设置"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600361C RID: 13852 RVA: 0x0016DE0D File Offset: 0x0016C00D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_0_0O0.o0__0.
		End Function

		' Token: 0x0600361D RID: 13853 RVA: 0x0016DE15 File Offset: 0x0016C015
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oO_0_0O0.o0__0. = A_0
		End Sub

		' Token: 0x0600361E RID: 13854 RVA: 0x0016DE1E File Offset: 0x0016C01E
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.o000OO_O0.
		End Function

		' Token: 0x0600361F RID: 13855 RVA: 0x0016DE28 File Offset: 0x0016C028
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__.__O_.
			Dim o.o000OO_O0. As C1Button = Me.O.o000OO_O0.
			If o.o000OO_O0. IsNot Nothing Then
				RemoveHandler o.o000OO_O0..Click, value
			End If
			Me.O.o000OO_O0. = A_0
			o.o000OO_O0. = Me.O.o000OO_O0.
			If o.o000OO_O0. IsNot Nothing Then
				AddHandler o.o000OO_O0..Click, value
			End If
		End Sub

		' Token: 0x06003620 RID: 13856 RVA: 0x0016DE6B File Offset: 0x0016C06B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oO_0_0O0.o0__0.
		End Function

		' Token: 0x06003621 RID: 13857 RVA: 0x0016DE73 File Offset: 0x0016C073
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.oO_0_0O0.o0__0. = A_0
		End Sub

		' Token: 0x06003622 RID: 13858 RVA: 0x0016DE7C File Offset: 0x0016C07C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.oO_0_0O0.o0__0.
		End Function

		' Token: 0x06003623 RID: 13859 RVA: 0x0016DE84 File Offset: 0x0016C084
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO_0_0O0.o0__0. = A_0
		End Sub

		' Token: 0x06003624 RID: 13860 RVA: 0x0016DE90 File Offset: 0x0016C090
		Public Sub New(A_0 As Table, A_1 As String, A_2 As ExtendTablePropertyTypeEnum)
			AddHandler MyBase.FormClosed, AddressOf Me.O__.__O_.
			Me.oO_0_0O0.o0__0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O00O_.__. = A_0
			Me.O00O_.__. = A_1
			Me.O00O_.__. = A_2
			For Each dataRow As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).[Select]("[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString(A_2), "", DataViewRowState.CurrentRows)
				Me.O__.__O_.().Items.Add(dataRow("Name").ToString())
			Next
		End Sub

		' Token: 0x06003625 RID: 13861 RVA: 0x0016DF5C File Offset: 0x0016C15C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.O__.__O_.().Text.Trim(), "", True) <> 0 Then
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
				Dim dataRow As DataRow = dataTable.Rows.Find(New Object() { Me.O00O_.__..DataTable.Name, Me.O__.__O_.().Text.Trim(), Me.O00O_.__. })
				If dataRow Is Nothing Then
					dataRow = dataTable.NewRow()
					dataRow("Table") = Me.O00O_.__..DataTable.Name
					dataRow("Type") = Me.O00O_.__.
					dataRow("Name") = Me.O__.__O_.().Text.Trim()
					dataTable.Rows.Add(dataRow)
				ElseIf MessageBox.Show("设置" + Me.O__.__O_.().Text.Trim() + "已经存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
					Return
				End If
				dataRow("Property") = Me.O00O_.__.
				Oo00.o0_o._O_.(dataTable, True)
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x06003626 RID: 13862 RVA: 0x0016E096 File Offset: 0x0016C296
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400163E RID: 5694
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400163F RID: 5695
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001640 RID: 5696
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001641 RID: 5697
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001642 RID: 5698
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001643 RID: 5699
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001644 RID: 5700
		Private <<EMPTY_NAME>> As ExtendTablePropertyTypeEnum

		' Token: 0x04001645 RID: 5701
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
