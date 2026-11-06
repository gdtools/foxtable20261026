Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000336 RID: 822
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06003133 RID: 12595 RVA: 0x0013F368 File Offset: 0x0013D568
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oO.0O0_0__O0__. IsNot Nothing Then
					Me.oO.0O0_0__O0__..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003134 RID: 12596 RVA: 0x0013F3A8 File Offset: 0x0013D5A8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O0_OO0O.0_o.(New C1Button())
			Me.o._OO_O_O.(New C1Button())
			Me.o0._Ooo0o.(New Label())
			Me.o._OO_O_O.(New CheckedListBox())
			Me.o._OO_O_O.(New Label())
			Me.o._OO_O_O.(New C1TextBox())
			Me.o._OO_O_O.(New CheckBox())
			MyBase.SuspendLayout()
			Me.O0_OO0O.0_o.().DialogResult = DialogResult.Cancel
			Me.O0_OO0O.0_o.().Location = New Point(205, 281)
			Me.O0_OO0O.0_o.().Name = "btnCancel"
			Me.O0_OO0O.0_o.().Size = New Size(75, 23)
			Me.O0_OO0O.0_o.().TabIndex = 11
			Me.O0_OO0O.0_o.().Text = "取消"
			Me.O0_OO0O.0_o.().UseVisualStyleBackColor = True
			Me.O0O0o0oOO0.o_O.().Location = New Point(123, 281)
			Me.O0O0o0oOO0.o_O.().Name = "btnExport"
			Me.O0O0o0oOO0.o_O.().Size = New Size(75, 23)
			Me.O0O0o0oOO0.o_O.().TabIndex = 10
			Me.O0O0o0oOO0.o_O.().Text = "确定"
			Me.O0O0o0oOO0.o_O.().UseVisualStyleBackColor = True
			Me.O0O0o0oOO0.o_O.().AutoSize = True
			Me.O0O0o0oOO0.o_O.().Location = New Point(12, 16)
			Me.O0O0o0oOO0.o_O.().Name = "Label1"
			Me.O0O0o0oOO0.o_O.().Size = New Size(47, 12)
			Me.O0O0o0oOO0.o_O.().TabIndex = 8
			Me.O0O0o0oOO0.o_O.().Text = "选择列:"
			Me.O0O0o0oOO0.o_O.().CheckOnClick = True
			Me.O0O0o0oOO0.o_O.().FormattingEnabled = True
			Me.O0O0o0oOO0.o_O.().Location = New Point(12, 38)
			Me.O0O0o0oOO0.o_O.().Name = "lstCols"
			Me.O0O0o0oOO0.o_O.().Size = New Size(378, 180)
			Me.O0O0o0oOO0.o_O.().TabIndex = 9
			Me.O0_OO0O.0_o.().AutoSize = True
			Me.O0_OO0O.0_o.().Location = New Point(12, 226)
			Me.O0_OO0O.0_o.().Name = "Label2"
			Me.O0_OO0O.0_o.().Size = New Size(59, 12)
			Me.O0_OO0O.0_o.().TabIndex = 13
			Me.O0_OO0O.0_o.().Text = "目标表名:"
			Me.O0O0o0oOO0.o_O.().Location = New Point(12, 246)
			Me.O0O0o0oOO0.o_O.().Name = "txtTableName"
			Me.O0O0o0oOO0.o_O.().Size = New Size(378, 21)
			Me.O0O0o0oOO0.o_O.().TabIndex = 14
			Me.O0O0o0oOO0.o_O.().AutoSize = True
			Me.O0O0o0oOO0.o_O.().Checked = True
			Me.O0O0o0oOO0.o_O.().CheckState = CheckState.Checked
			Me.O0O0o0oOO0.o_O.().Location = New Point(306, 16)
			Me.O0O0o0oOO0.o_O.().Name = "CheckBox1"
			Me.O0O0o0oOO0.o_O.().Size = New Size(84, 16)
			Me.O0O0o0oOO0.o_O.().TabIndex = 15
			Me.O0O0o0oOO0.o_O.().Text = "选择所有列"
			Me.O0O0o0oOO0.o_O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(402, 315)
			MyBase.Controls.Add(Me.O0O0o0oOO0.o_O.())
			MyBase.Controls.Add(Me.O0O0o0oOO0.o_O.())
			MyBase.Controls.Add(Me.O0_OO0O.0_o.())
			MyBase.Controls.Add(Me.O0_OO0O.0_o.())
			MyBase.Controls.Add(Me.O0O0o0oOO0.o_O.())
			MyBase.Controls.Add(Me.O0O0o0oOO0.o_O.())
			MyBase.Controls.Add(Me.O0O0o0oOO0.o_O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oo...0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "高速导出"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003135 RID: 12597 RVA: 0x0013F7C7 File Offset: 0x0013D9C7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o._OO_O_O.
		End Function

		' Token: 0x06003136 RID: 12598 RVA: 0x0013F7D0 File Offset: 0x0013D9D0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.0OO_.
			Dim c1Button As C1Button = Me.o._OO_O_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o._OO_O_O. = A_0
			c1Button = Me.o._OO_O_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003137 RID: 12599 RVA: 0x0013F813 File Offset: 0x0013DA13
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0._Ooo0o.
		End Function

		' Token: 0x06003138 RID: 12600 RVA: 0x0013F81C File Offset: 0x0013DA1C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_0_O__0_.0.
			Dim c1Button As C1Button = Me.o0._Ooo0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0._Ooo0o. = A_0
			c1Button = Me.o0._Ooo0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003139 RID: 12601 RVA: 0x0013F85F File Offset: 0x0013DA5F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o._OO_O_O.
		End Function

		' Token: 0x0600313A RID: 12602 RVA: 0x0013F867 File Offset: 0x0013DA67
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o._OO_O_O. = A_0
		End Sub

		' Token: 0x0600313B RID: 12603 RVA: 0x0013F870 File Offset: 0x0013DA70
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.oO.0O0_0__O0__.
		End Function

		' Token: 0x0600313C RID: 12604 RVA: 0x0013F878 File Offset: 0x0013DA78
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Me.oO.0O0_0__O0__. = A_0
		End Sub

		' Token: 0x0600313D RID: 12605 RVA: 0x0013F881 File Offset: 0x0013DA81
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0._0_Oo_O0OO.
		End Function

		' Token: 0x0600313E RID: 12606 RVA: 0x0013F889 File Offset: 0x0013DA89
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0._0_Oo_O0OO. = A_0
		End Sub

		' Token: 0x0600313F RID: 12607 RVA: 0x0013F892 File Offset: 0x0013DA92
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oO.0O0_0__O0__.
		End Function

		' Token: 0x06003140 RID: 12608 RVA: 0x0013F89A File Offset: 0x0013DA9A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oO.0O0_0__O0__. = A_0
		End Sub

		' Token: 0x06003141 RID: 12609 RVA: 0x0013F8A3 File Offset: 0x0013DAA3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckBox
			Return Me.o._OO_O_O.
		End Function

		' Token: 0x06003142 RID: 12610 RVA: 0x0013F8AC File Offset: 0x0013DAAC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckBox)
			Dim value As EventHandler = AddressOf Me.ooooooO0.o.
			Dim checkBox As CheckBox = Me.o._OO_O_O.
			If checkBox IsNot Nothing Then
				RemoveHandler checkBox.CheckedChanged, value
			End If
			Me.o._OO_O_O. = A_0
			checkBox = Me.o._OO_O_O.
			If checkBox IsNot Nothing Then
				AddHandler checkBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06003143 RID: 12611 RVA: 0x0013F8F0 File Offset: 0x0013DAF0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In OO_00oOO.CurrentTable.DataTable.BaseTable.Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) Then
						Me.O0O0o0oOO0.o_O.().Items.Add(dataColumn.ColumnName, True)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003144 RID: 12612 RVA: 0x0013F980 File Offset: 0x0013DB80
		Public Sub New(A_0 As String)
			AddHandler MyBase.Load, AddressOf Me.oo.Oo0oo0_Oo.
			AddHandler MyBase.FormClosed, AddressOf Me.ooooooO0.o.
			Me.oO.0O0_0__O0__. = New Exporter()
			Me.O0O0o0oOO0.o_O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oO.0O0_0__O0__. = A_0
			Dim extension As String = Path.GetExtension(A_0)
			If Operators.CompareString(extension, ".mdb", True) = 0 Then
				Me.oO.0O0_0__O0__..Format = "access"
				Me.oO.0O0_0__O0__..FilePath = Me.oO.0O0_0__O0__.
			ElseIf Operators.CompareString(extension, ".accdb", True) = 0 Then
				Me.oO.0O0_0__O0__..Format = "access2007"
				Me.oO.0O0_0__O0__..FilePath = Me.oO.0O0_0__O0__.
			ElseIf Operators.CompareString(extension, ".xls", True) = 0 Then
				Me.oO.0O0_0__O0__..Format = "excel"
				Me.oO.0O0_0__O0__..FilePath = Me.oO.0O0_0__O0__.
			ElseIf Operators.CompareString(extension, ".xlsx", True) = 0 Then
				Me.oO.0O0_0__O0__..Format = "excel2007"
				Me.oO.0O0_0__O0__..FilePath = Me.oO.0O0_0__O0__.
			ElseIf Operators.CompareString(extension, ".dbf", True) = 0 Then
				Me.oO.0O0_0__O0__..Format = "dbase"
				Me.oO.0O0_0__O0__..FilePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0)
				Me.oO.0O0_0__O0__..NewTableName = Path.GetFileNameWithoutExtension(A_0)
			ElseIf Operators.CompareString(extension, ".txt", True) = 0 Then
				Me.oO.0O0_0__O0__..Format = "Delimited"
				Me.oO.0O0_0__O0__..FilePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0)
				Me.oO.0O0_0__O0__..NewTableName = Path.GetFileNameWithoutExtension(A_0)
			End If
			Me.oO.0O0_0__O0__..SourceTableName = OO_00oOO.CurrentTable.DataTable.Name
			If Operators.CompareString(Me.oO.0O0_0__O0__..NewTableName, "", True) = 0 Then
				Me.oO.0O0_0__O0__..NewTableName = OO_00oOO.CurrentTable.DataTable.Name
			End If
			Me.O0O0o0oOO0.o_O.().Value = Me.oO.0O0_0__O0__..NewTableName
			If OO_00oOO.CurrentTable.ApplyFilter Then
				Me.oO.0O0_0__O0__..Filter = OO_00oOO.CurrentTable.Filter
			End If
		End Sub

		' Token: 0x06003145 RID: 12613 RVA: 0x0013FBD4 File Offset: 0x0013DDD4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06003146 RID: 12614 RVA: 0x0013FBE0 File Offset: 0x0013DDE0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO.0O0_0__O0__..NewTableName = Me.O0O0o0oOO0.o_O.().Text
			Me.oO.0O0_0__O0__..Filter = OO_00oOO.DataTables(Me.oO.0O0_0__O0__..SourceTableName).LoadFilter
			Dim text As String = ""
			Dim flag As Boolean = True
			Dim num As Integer = Me.O0O0o0oOO0.o_O.().Items.Count - 1
			For i As Integer = 0 To num
				If Not Me.O0O0o0oOO0.o_O.().GetItemChecked(i) Then
					flag = False
				Else
					If Operators.CompareString(text, "", True) > 0 Then
						text += ","
					End If
					text = text + "[" + Me.O0O0o0oOO0.o_O.().Items(i).ToString() + "]"
				End If
			Next
			If flag Then
				Me.oO.0O0_0__O0__..Fields = ""
			Else
				Me.oO.0O0_0__O0__..Fields = text
			End If
			Dim extension As String = Path.GetExtension(Me.oO.0O0_0__O0__.)
			If(Operators.CompareString(extension, ".dbf", True) = 0 OrElse Operators.CompareString(extension, ".txt", True) = 0) AndAlso c.OOOOO.o.().FileSystem.FileExists(Me.oO.0O0_0__O0__.) Then
				c.OOOOO.o.().FileSystem.DeleteFile(Me.oO.0O0_0__O0__.)
			End If
			Me.oO.0O0_0__O0__..Export()
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06003147 RID: 12615 RVA: 0x0013FD30 File Offset: 0x0013DF30
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim checked As Boolean = Me.O0O0o0oOO0.o_O.().Checked
			Dim num As Integer = Me.O0O0o0oOO0.o_O.().Items.Count - 1
			For i As Integer = 0 To num
				Me.O0O0o0oOO0.o_O.().SetItemChecked(i, checked)
			Next
		End Sub

		' Token: 0x06003148 RID: 12616 RVA: 0x0013FD75 File Offset: 0x0013DF75
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040013BF RID: 5055
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013C0 RID: 5056
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013C1 RID: 5057
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013C2 RID: 5058
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013C3 RID: 5059
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x040013C4 RID: 5060
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013C5 RID: 5061
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040013C6 RID: 5062
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckBox

		' Token: 0x040013C7 RID: 5063
		Private <<EMPTY_NAME>> As String

		' Token: 0x040013C8 RID: 5064
		Private <<EMPTY_NAME>> As Exporter
	End Class
End Namespace
