Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000D3 RID: 211
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3000\u3002\u3002\u30020\u3002
		Inherits Form

		' Token: 0x06000B03 RID: 2819 RVA: 0x0004F0BC File Offset: 0x0004D2BC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0.0o_0_o0. IsNot Nothing Then
					Me.O0.0o_0_o0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000B04 RID: 2820 RVA: 0x0004F0FC File Offset: 0x0004D2FC
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O0.0o_0_o0.(New PropertyGrid())
			Me.oo0O.o.(New C1Button())
			Me.OO00__.oo__00.(New C1Button())
			Me.O0.0o_0_o0.(New C1Button())
			Me.O_o0.O.().BeginInit()
			Me.O_0.O_.().BeginInit()
			Me.OO00__.oo__00.().BeginInit()
			MyBase.SuspendLayout()
			Me.O_o0.O.().Location = New Point(12, 13)
			Me.O_o0.O.().Name = "PropertyGrid1"
			Me.O_o0.O.().Size = New Size(388, 388)
			Me.O_o0.O.().TabIndex = 0
			Me.O_o0.O.().ToolbarVisible = False
			Me.O_o0.O.().Location = New Point(224, 420)
			Me.O_o0.O.().Name = "C1Button1"
			Me.O_o0.O.().Size = New Size(85, 25)
			Me.O_o0.O.().TabIndex = 1
			Me.O_o0.O.().Text = "确定"
			Me.O_o0.O.().UseVisualStyleBackColor = True
			Me.O_0.O_.().Location = New Point(315, 420)
			Me.O_0.O_.().Name = "btnCancel"
			Me.O_0.O_.().Size = New Size(85, 25)
			Me.O_0.O_.().TabIndex = 2
			Me.O_0.O_.().Text = "取消"
			Me.O_0.O_.().UseVisualStyleBackColor = True
			Me.OO00__.oo__00.().Location = New Point(12, 420)
			Me.OO00__.oo__00.().Name = "btnRestore"
			Me.OO00__.oo__00.().Size = New Size(113, 25)
			Me.OO00__.oo__00.().TabIndex = 3
			Me.OO00__.oo__00.().Text = "还原初始值"
			Me.OO00__.oo__00.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(412, 457)
			MyBase.Controls.Add(Me.OO00__.oo__00.())
			MyBase.Controls.Add(Me.O_0.O_.())
			MyBase.Controls.Add(Me.O_o0.O.())
			MyBase.Controls.Add(Me.O_o0.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO...o.."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "环境选项"
			Me.O_o0.O.().EndInit()
			Me.O_0.O_.().EndInit()
			Me.OO00__.oo__00.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06000B05 RID: 2821 RVA: 0x0004F3B7 File Offset: 0x0004D5B7
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.O0.0o_0_o0.
		End Function

		' Token: 0x06000B06 RID: 2822 RVA: 0x0004F3C0 File Offset: 0x0004D5C0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Dim value As PropertyValueChangedEventHandler = AddressOf Me.O_o0.O.
			Dim o0.0o_0_o0. As PropertyGrid = Me.O0.0o_0_o0.
			If o0.0o_0_o0. IsNot Nothing Then
				RemoveHandler o0.0o_0_o0..PropertyValueChanged, value
			End If
			Me.O0.0o_0_o0. = A_0
			o0.0o_0_o0. = Me.O0.0o_0_o0.
			If o0.0o_0_o0. IsNot Nothing Then
				AddHandler o0.0o_0_o0..PropertyValueChanged, value
			End If
		End Sub

		' Token: 0x06000B07 RID: 2823 RVA: 0x0004F403 File Offset: 0x0004D603
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.0o_0_o0.
		End Function

		' Token: 0x06000B08 RID: 2824 RVA: 0x0004F40C File Offset: 0x0004D60C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO00__.oo__00.
			Dim o0.0o_0_o0. As C1Button = Me.O0.0o_0_o0.
			If o0.0o_0_o0. IsNot Nothing Then
				RemoveHandler o0.0o_0_o0..Click, value
			End If
			Me.O0.0o_0_o0. = A_0
			o0.0o_0_o0. = Me.O0.0o_0_o0.
			If o0.0o_0_o0. IsNot Nothing Then
				AddHandler o0.0o_0_o0..Click, value
			End If
		End Sub

		' Token: 0x06000B09 RID: 2825 RVA: 0x0004F44F File Offset: 0x0004D64F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.OoOoo_O.
		End Function

		' Token: 0x06000B0A RID: 2826 RVA: 0x0004F458 File Offset: 0x0004D658
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOoo__O0_.oO_.
			Dim o.OoOoo_O. As C1Button = Me.O.OoOoo_O.
			If o.OoOoo_O. IsNot Nothing Then
				RemoveHandler o.OoOoo_O..Click, value
			End If
			Me.O.OoOoo_O. = A_0
			o.OoOoo_O. = Me.O.OoOoo_O.
			If o.OoOoo_O. IsNot Nothing Then
				AddHandler o.OoOoo_O..Click, value
			End If
		End Sub

		' Token: 0x06000B0B RID: 2827 RVA: 0x0004F49B File Offset: 0x0004D69B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo0O.o.
		End Function

		' Token: 0x06000B0C RID: 2828 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0o.o0oO_.
			Dim c1Button As C1Button = Me.oo0O.o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo0O.o. = A_0
			c1Button = Me.oo0O.o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000B0D RID: 2829 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.O_o0.O.
			Me.oo_0oooo.00O_O. = New ooo00oO()
			Me.oo_0oooo.00O_O. = O_O0OO.Oo._00O0_oO.
			Me.O.o00. = O_O0OO.o_.oO_O0.
			Me.o0_._0O_0. = O_O0OO.O_.00.
			Me.o__.Oo. = O_O0OO.oo_oo_o._.
			Me.oo_0oooo.00O_O. = O_O0OO.oO_00Ooo___0._.
			Me.O.o00. = O_O0OO.o0O._O00o.
			Me.O0.0o_0_o0. = O_O0OO.O0_00o.o0__o.
			Me.O.o00. = O_O0OO.oo0_o_.o.
			Me.O_o0.O.()
			Me.O_o0.O.().SelectedObject = New o_0oooo_OO(Me.oo_0oooo.00O_O., New String(-1) {}, False, False)
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06000B0E RID: 2830 RVA: 0x0004F5AC File Offset: 0x0004D7AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(O_O0OO.O_.00., Me.o0_._0O_0., True) <> 0 Then
				O_O0OO.O_.00. = Me.o0_._0O_0.
				Main.OO_O.o..OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme)
			End If
			If Operators.CompareString(O_O0OO.Oo._00O0_oO., Me.oo_0oooo.00O_O., True) <> 0 OrElse O_O0OO.o0O._O00o. <> Me.O.o00. OrElse O_O0OO.O0_00o.o0__o. <> Me.O0.0o_0_o0. OrElse O_O0OO.oo0_o_.o. <> Me.O.o00. Then
				O_O0OO.Oo._00O0_oO. = Me.oo_0oooo.00O_O.
				O_O0OO.o0O._O00o. = Me.O.o00.
				O_O0OO.O0_00o.o0__o. = Me.O0.0o_0_o0.
				O_O0OO.oo0_o_.o. = Me.O.o00.
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						dataTable.oOoOO0_o.O0_0.()
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			If Operators.CompareString(O_O0OO.o_.oO_O0., Me.O.o00., True) <> 0 Then
				O_O0OO.o_.oO_O0. = Me.O.o00.
				Main.OO_O.o..O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme)
			End If
			If Operators.CompareString(O_O0OO.oo_oo_o._., Me.o__.Oo., True) <> 0 OrElse O_O0OO.oO_00Ooo___0._. <> Me.oo_0oooo.00O_O. Then
				O_O0OO.oo_oo_o._. = Me.o__.Oo.
				O_O0OO.oO_00Ooo___0._. = Me.oo_0oooo.00O_O.
				Main.OO_O.o..O.OOO0_OOo.().Font = New Font(O_O0OO.oo_oo_o._., CSng(O_O0OO.oO_00Ooo___0._.), Main.OO_O.o..O.OOO0_OOo.().Font.Style)
			End If
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x06000B0F RID: 2831 RVA: 0x0004F740 File Offset: 0x0004D940
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PropertyValueChangedEventArgs)
			If Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "ControlTheme", True) = 0 Then
				O_O0OO.o_.oO_O0. = Me.oo_0oooo.00O_O..ControlTheme
				Main.OO_O.o..O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme)
			ElseIf Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "RibbonTheme", True) = 0 Then
				O_O0OO.O_.00. = Me.oo_0oooo.00O_O..RibbonTheme
				Main.OO_O.o..OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme)
				MyBase.TopMost = True
			ElseIf Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "RibbonFontName", True) = 0 OrElse Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "RibbonFontSize", True) = 0 Then
				O_O0OO.oo_oo_o._. = Me.oo_0oooo.00O_O..RibbonFontName
				O_O0OO.oO_00Ooo___0._. = Me.oo_0oooo.00O_O..RibbonFontSize
				Main.OO_O.o..O.OOO0_OOo.().Font = New Font(O_O0OO.O0_00o.o0__o..GetRibbonFontName, CSng(O_O0OO.O0_00o.o0__o..GetRibbonFontSize), Main.OO_O.o..O.OOO0_OOo.().Font.Style)
			ElseIf(Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "GridTheme", True) = 0 Or Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "DisableAlterRowMode", True) = 0) OrElse Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "AlterRowBackColor", True) = 0 OrElse Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "AlterRowForeColor", True) = 0 Then
				O_O0OO.Oo._00O0_oO. = Me.oo_0oooo.00O_O..GridTheme
				O_O0OO.o0O._O00o. = Me.oo_0oooo.00O_O..DisableAlterRowMode
				O_O0OO.O0_00o.o0__o. = Me.oo_0oooo.00O_O..AlterRowBackColor
				O_O0OO.oo0_o_.o. = Me.oo_0oooo.00O_O..AlterRowForeColor
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						dataTable.oOoOO0_o.O0_0.()
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			Me.O0.0o_0_o0. = True
		End Sub

		' Token: 0x06000B10 RID: 2832 RVA: 0x0004F978 File Offset: 0x0004DB78
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0.0o_0_o0. AndAlso Me.O0.0o_0_o0. Then
				Dim colorConverter As ColorConverter = New ColorConverter()
				Dim dataRow As DataRow = O_O0OO.O0_00o.o0__o..Rows.Find("ThemeOptions")
				If dataRow Is Nothing Then
					dataRow = O_O0OO.O0_00o.o0__o..NewRow()
					dataRow("Name") = "ThemeOptions"
				End If
				dataRow("Config") = String.Concat(New String() { O_O0OO.O_.00., vbVerticalTab, O_O0OO.Oo._00O0_oO., vbVerticalTab, O_O0OO.o_.oO_O0., vbVerticalTab, O_O0OO.oo_oo_o._., vbVerticalTab, Conversions.ToString(O_O0OO.oO_00Ooo___0._.), vbVerticalTab, Conversions.ToString(O_O0OO.o0O._O00o.), vbVerticalTab, colorConverter.ConvertTo(O_O0OO.O0_00o.o0__o., GetType(String)).ToString(), vbVerticalTab, colorConverter.ConvertTo(O_O0OO.oo0_o_.o., GetType(String)).ToString() })
				If dataRow.RowState = DataRowState.Detached Then
					O_O0OO.O0_00o.o0__o..Rows.Add(dataRow)
				End If
				Oo00.o0_o._O_.(O_O0OO.O0_00o.o0__o., True)
			End If
			MyBase.DialogResult = DialogResult.OK
			MyBase.Close()
		End Sub

		' Token: 0x06000B11 RID: 2833 RVA: 0x0004FAD8 File Offset: 0x0004DCD8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			O_O0OO.O_.00. = "Office2013Green"
			O_O0OO.Oo._00O0_oO. = "Office2013Green"
			O_O0OO.o_.oO_O0. = "VS2013Green"
			O_O0OO.oo_oo_o._. = "宋体"
			O_O0OO.oO_00Ooo___0._. = 9
			O_O0OO.O0_00o.o0__o. = Color.Transparent
			O_O0OO.oo0_o_.o. = Color.Transparent
			O_O0OO.o0O._O00o. = False
			Me.oo_0oooo.00O_O. = New ooo00oO()
			Me.O_o0.O.().SelectedObject = New o_0oooo_OO(Me.oo_0oooo.00O_O., New String(-1) {}, False, False)
			Main.OO_O.o..O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme)
			Main.OO_O.o..OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme)
			Main.OO_O.o..O.OOO0_OOo.().Font = New Font(O_O0OO.O0_00o.o0__o..GetRibbonFontName, CSng(O_O0OO.O0_00o.o0__o..GetRibbonFontSize), Main.OO_O.o..O.OOO0_OOo.().Font.Style)
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					dataTable.oOoOO0_o.O0_0.()
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.O0.0o_0_o0. = True
		End Sub

		' Token: 0x06000B12 RID: 2834 RVA: 0x0004FC00 File Offset: 0x0004DE00
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400041A RID: 1050
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400041B RID: 1051
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x0400041C RID: 1052
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400041D RID: 1053
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400041E RID: 1054
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400041F RID: 1055
		Private <<EMPTY_NAME>> As ooo00oO

		' Token: 0x04000420 RID: 1056
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000421 RID: 1057
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000422 RID: 1058
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000423 RID: 1059
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000424 RID: 1060
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000425 RID: 1061
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000426 RID: 1062
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000427 RID: 1063
		Private <<EMPTY_NAME>> As Color

		' Token: 0x04000428 RID: 1064
		Private <<EMPTY_NAME>> As Color
	End Class
End Namespace
