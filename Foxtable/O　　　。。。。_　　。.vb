Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000337 RID: 823
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3000
		Inherits Form

		' Token: 0x06003149 RID: 12617 RVA: 0x0013FD88 File Offset: 0x0013DF88
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_0.o__OOoO. IsNot Nothing Then
					Me.o_0.o__OOoO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600314A RID: 12618 RVA: 0x0013FDC8 File Offset: 0x0013DFC8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oO.__.(New CheckedListBox())
			Me.oo__.0_Ooooo.(New Label())
			Me.oo__.0_Ooooo.(New C1Button())
			Me.oO.__.(New C1Button())
			Me.oO.__.(New Label())
			Me.oO.__.(New C1ComboBox())
			Me.oO.__.(New C1CheckBox())
			Me.O0O_.o_O00o.().BeginInit()
			Me.oO0o.o0.().BeginInit()
			Me.oO0o.o0.().BeginInit()
			Me.oO0o.o0.().BeginInit()
			MyBase.SuspendLayout()
			Me.oO0o.o0.().CheckOnClick = True
			Me.oO0o.o0.().FormattingEnabled = True
			Me.oO0o.o0.().Location = New Point(14, 85)
			Me.oO0o.o0.().Name = "lstCols"
			Me.oO0o.o0.().Size = New Size(378, 180)
			Me.oO0o.o0.().TabIndex = 3
			Me.oO0o.o0.().AutoSize = True
			Me.oO0o.o0.().Location = New Point(14, 66)
			Me.oO0o.o0.().Name = "Label1"
			Me.oO0o.o0.().Size = New Size(47, 12)
			Me.oO0o.o0.().TabIndex = 2
			Me.oO0o.o0.().Text = "选择列:"
			Me.O0O_.o_O00o.().Location = New Point(125, 279)
			Me.O0O_.o_O00o.().Name = "btnImport"
			Me.O0O_.o_O00o.().Size = New Size(75, 23)
			Me.O0O_.o_O00o.().TabIndex = 6
			Me.O0O_.o_O00o.().Text = "确定"
			Me.O0O_.o_O00o.().UseVisualStyleBackColor = True
			Me.oO0o.o0.().DialogResult = DialogResult.Cancel
			Me.oO0o.o0.().Location = New Point(207, 279)
			Me.oO0o.o0.().Name = "btnCancel"
			Me.oO0o.o0.().Size = New Size(75, 23)
			Me.oO0o.o0.().TabIndex = 7
			Me.oO0o.o0.().Text = "取消"
			Me.oO0o.o0.().UseVisualStyleBackColor = True
			Me.O0O_.o_O00o.().AutoSize = True
			Me.O0O_.o_O00o.().Location = New Point(14, 11)
			Me.O0O_.o_O00o.().Name = "Label2"
			Me.O0O_.o_O00o.().Size = New Size(47, 12)
			Me.O0O_.o_O00o.().TabIndex = 0
			Me.O0O_.o_O00o.().Text = "选择表:"
			Me.oO0o.o0.().AllowSpinLoop = False
			Me.oO0o.o0.().Cursor = Cursors.Arrow
			Me.oO0o.o0.().DropDownStyle = 1
			Me.oO0o.o0.().GapHeight = 0
			Me.oO0o.o0.().ImagePadding = New Padding(0, 0, 0, 0)
			Me.oO0o.o0.().ItemsDisplayMember = ""
			Me.oO0o.o0.().ItemsValueMember = ""
			Me.oO0o.o0.().Location = New Point(14, 30)
			Me.oO0o.o0.().Name = "lstTable"
			Me.oO0o.o0.().Size = New Size(378, 19)
			Me.oO0o.o0.().TabIndex = 1
			Me.oO0o.o0.().Tag = Nothing
			Me.oO0o.o0.().AutoSize = True
			Me.oO0o.o0.().BorderStyle = BorderStyle.None
			Me.oO0o.o0.().Checked = True
			Me.oO0o.o0.().CheckState = CheckState.Checked
			Me.oO0o.o0.().Location = New Point(308, 63)
			Me.oO0o.o0.().Name = "CheckBox1"
			Me.oO0o.o0.().Size = New Size(84, 16)
			Me.oO0o.o0.().TabIndex = 8
			Me.oO0o.o0.().Text = "选择所有列"
			Me.oO0o.o0.().UseVisualStyleBackColor = True
			Me.oO0o.o0.().Value = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(406, 314)
			MyBase.Controls.Add(Me.oO0o.o0.())
			MyBase.Controls.Add(Me.oO0o.o0.())
			MyBase.Controls.Add(Me.O0O_.o_O00o.())
			MyBase.Controls.Add(Me.oO0o.o0.())
			MyBase.Controls.Add(Me.O0O_.o_O00o.())
			MyBase.Controls.Add(Me.oO0o.o0.())
			MyBase.Controls.Add(Me.oO0o.o0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o_o......o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "高速导入"
			Me.O0O_.o_O00o.().EndInit()
			Me.oO0o.o0.().EndInit()
			Me.oO0o.o0.().EndInit()
			Me.oO0o.o0.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600314B RID: 12619 RVA: 0x001402CB File Offset: 0x0013E4CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.o_0.o__OOoO.
		End Function

		' Token: 0x0600314C RID: 12620 RVA: 0x001402D3 File Offset: 0x0013E4D3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Me.o_0.o__OOoO. = A_0
		End Sub

		' Token: 0x0600314D RID: 12621 RVA: 0x001402DC File Offset: 0x0013E4DC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_0.o__OOoO.
		End Function

		' Token: 0x0600314E RID: 12622 RVA: 0x001402E4 File Offset: 0x0013E4E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_0.o__OOoO. = A_0
		End Sub

		' Token: 0x0600314F RID: 12623 RVA: 0x001402ED File Offset: 0x0013E4ED
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO.__.
		End Function

		' Token: 0x06003150 RID: 12624 RVA: 0x001402F8 File Offset: 0x0013E4F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0._0_Oo_O0OO.
			Dim c1Button As C1Button = Me.oO.__.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO.__. = A_0
			c1Button = Me.oO.__.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003151 RID: 12625 RVA: 0x0014033B File Offset: 0x0013E53B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo__.0_Ooooo.
		End Function

		' Token: 0x06003152 RID: 12626 RVA: 0x00140343 File Offset: 0x0013E543
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oo__.0_Ooooo. = A_0
		End Sub

		' Token: 0x06003153 RID: 12627 RVA: 0x0014034C File Offset: 0x0013E54C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.OO0o.
		End Function

		' Token: 0x06003154 RID: 12628 RVA: 0x00140354 File Offset: 0x0013E554
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.OO0o. = A_0
		End Sub

		' Token: 0x06003155 RID: 12629 RVA: 0x0014035D File Offset: 0x0013E55D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_0.o__OOoO.
		End Function

		' Token: 0x06003156 RID: 12630 RVA: 0x00140368 File Offset: 0x0013E568
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0o00._0O.
			Dim c1ComboBox As C1ComboBox = Me.o_0.o__OOoO.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o_0.o__OOoO. = A_0
			c1ComboBox = Me.o_0.o__OOoO.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06003157 RID: 12631 RVA: 0x001403AB File Offset: 0x0013E5AB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oO.__.
		End Function

		' Token: 0x06003158 RID: 12632 RVA: 0x001403B4 File Offset: 0x0013E5B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.oO.0O0_0__O0__.
			Dim c1CheckBox As C1CheckBox = Me.oO.__.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.oO.__. = A_0
			c1CheckBox = Me.oO.__.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06003159 RID: 12633 RVA: 0x001403F8 File Offset: 0x0013E5F8
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.oO.0O0_0__O0__.
			Me.o_0.o__OOoO. = New Importer()
			Me.o_0.o__OOoO. = New OleDbConnection()
			Me.oO0o.o0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim extension As String = Path.GetExtension(A_0)
			Dim left As String = extension
			If Operators.CompareString(left, ".mdb", True) = 0 OrElse Operators.CompareString(left, ".accdb", True) = 0 Then
				Me.o_0.o__OOoO..Format = "access"
				Me.o_0.o__OOoO..SourcePath = A_0
				If Operators.CompareString(extension, ".accdb", True) = 0 Then
					Me.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0
				Else
					Me.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0
				End If
				Me.O0O_.o_O00o.()
			ElseIf Operators.CompareString(left, ".xls", True) = 0 OrElse Operators.CompareString(left, ".xlsx", True) = 0 Then
				Me.o_0.o__OOoO..Format = "excel"
				Me.o_0.o__OOoO..SourcePath = A_0
				If Operators.CompareString(extension, ".xlsx", True) = 0 Then
					Me.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Extended Properties=""Excel 12.0;HDR=YES"""
				Else
					Me.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Extended Properties=""Excel 8.0;HDR=YES"""
				End If
				Me.O0O_.o_O00o.()
			ElseIf Operators.CompareString(left, ".dbf", True) = 0 Then
				Me.o_0.o__OOoO..Format = "dbase"
				Me.o_0.o__OOoO..SourcePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0)
				Me.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=dBASE IV"
				Me.oO0o.o0.().Items.Add(Path.GetFileNameWithoutExtension(A_0))
			ElseIf Operators.CompareString(left, ".txt", True) = 0 Then
				Me.o_0.o__OOoO..Format = "Delimited"
				Me.o_0.o__OOoO..SourcePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0)
				Me.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=""text;HDR=Yes;FMT=Delimited"""
				Me.oO0o.o0.().Items.Add(Path.GetFileNameWithoutExtension(A_0) + "#TXT")
			End If
			Me.oO0o.o0.().SelectedIndex = 0
		End Sub

		' Token: 0x0600315A RID: 12634 RVA: 0x00140670 File Offset: 0x0013E870
		Public Sub <<EMPTY_NAME>>()
			Dim catalog As Catalog = New CatalogClass()
			Dim connection As Connection = New ConnectionClass()
			connection.ConnectionString = Me.o_0.o__OOoO..ConnectionString
			connection.Open("", "", "", -1)
			catalog.ActiveConnection = connection
			Try
				For Each obj As Object In catalog.Tables
					Dim table As Table = CType(obj, Table)
					If(Operators.CompareString(table.Type, "View", True) = 0 OrElse Operators.CompareString(table.Type, "Table", True) = 0) AndAlso Not table.Name.StartsWith("~TMPCLP", StringComparison.CurrentCultureIgnoreCase) Then
						Me.oO0o.o0.().Items.Add(table.Name)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			connection.Close()
		End Sub

		' Token: 0x0600315B RID: 12635 RVA: 0x00140758 File Offset: 0x0013E958
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0.o__OOoO..SourceTableName = Me.oO0o.o0.().SelectedItem.ToString().Trim(New Char() { "'"c })
			Dim dataTable As DataTable = New DataTable()
			New OleDbDataAdapter("", Me.o_0.o__OOoO.) With { .SelectCommand = { .CommandText = "Select * From [" + Me.o_0.o__OOoO..SourceTableName + "]" } }.FillSchema(dataTable, SchemaType.Source)
			Me.oO0o.o0.().Items.Clear()
			Try
				For Each obj As Object In dataTable.Columns
					Dim dataColumn As DataColumn = CType(obj, DataColumn)
					If Not o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) AndAlso Not dataColumn.AutoIncrement Then
						Me.oO0o.o0.().Items.Add(dataColumn.ColumnName, True)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600315C RID: 12636 RVA: 0x00140860 File Offset: 0x0013EA60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = ""
			Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(Me.oO0o.o0.().Text, "")
			o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
			Dim num As Integer = Me.oO0o.o0.().Items.Count - 1
			For i As Integer = 0 To num
				If Me.oO0o.o0.().GetItemChecked(i) Then
					If Operators.CompareString(text, "", True) > 0 Then
						text += ","
					End If
					text = text + "[" + Me.oO0o.o0.().Items(i).ToString() + "]"
				End If
			Next
			Me.o_0.o__OOoO..Fields = text
			If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
				Me.o_0.o__OOoO..NewTableName = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
				Me.o_0.o__OOoO..NewTableCaption = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
				If Me.o_0.o__OOoO..Import() AndAlso MessageBox.Show("已经成功导入，是否继续导入其它表？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
					MyBase.DialogResult = DialogResult.OK
				End If
			End If
		End Sub

		' Token: 0x0600315D RID: 12637 RVA: 0x00140960 File Offset: 0x0013EB60
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim checked As Boolean = Me.oO0o.o0.().Checked
			Dim num As Integer = Me.oO0o.o0.().Items.Count - 1
			For i As Integer = 0 To num
				Me.oO0o.o0.().SetItemChecked(i, checked)
			Next
		End Sub

		' Token: 0x0600315E RID: 12638 RVA: 0x001409A5 File Offset: 0x0013EBA5
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040013C9 RID: 5065
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013CA RID: 5066
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x040013CB RID: 5067
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013CC RID: 5068
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013CD RID: 5069
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013CE RID: 5070
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013CF RID: 5071
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040013D0 RID: 5072
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040013D1 RID: 5073
		Friend <<EMPTY_NAME>> As Importer

		' Token: 0x040013D2 RID: 5074
		Private <<EMPTY_NAME>> As OleDbConnection
	End Class
End Namespace
