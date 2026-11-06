Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000371 RID: 881
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3000\u3002\u3000\u3000\u3000
		Inherits Form

		' Token: 0x06003798 RID: 14232 RVA: 0x0017A637 File Offset: 0x00178837
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.O_.O0. IsNot Nothing Then
				Me.O_.O0..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003799 RID: 14233 RVA: 0x0017A658 File Offset: 0x00178858
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo0O_O0.OOO_oO.(New C1ComboBox())
			Me.O_O00__.0oo0.(New Label())
			Me.OO_.o.(New C1TextBox())
			Me.O0o.0O0__0___0.(New Label())
			Me.oo0O_O0.OOO_oO.(New C1Button())
			Me.OO_O_0._O0O_oo.(New C1Button())
			Me.O_00_.oOOo.(New Label())
			Me.OO_.o.(New C1NumericEdit())
			Me.O0o_O00_0oOo.O.(New Label())
			Me.OO_.o.(New Label())
			Me.O_O00__.0oo0.(New C1TextBox())
			Me.o_o.0o0__.(New Label())
			Me.o0_ooo.__O.(New Label())
			Me.o0_0oo0.OOo0oo.().BeginInit()
			Me.OO_O_0._O0O_oo.().BeginInit()
			Me.o0_0oo0.OOo0oo.().BeginInit()
			Me.Oo_0o.ooOoo00O.().BeginInit()
			Me.oo0O_O0.OOO_oO.().BeginInit()
			Me.oo0O_O0.OOO_oO.().BeginInit()
			MyBase.SuspendLayout()
			Me.o0_0oo0.OOo0oo.().AllowSpinLoop = False
			Me.o0_0oo0.OOo0oo.().Cursor = Cursors.Arrow
			Me.o0_0oo0.OOo0oo.().DropDownStyle = 1
			Me.o0_0oo0.OOo0oo.().GapHeight = 0
			Me.o0_0oo0.OOo0oo.().ImagePadding = New Padding(0, 0, 0, 0)
			Me.o0_0oo0.OOo0oo.().ItemsDisplayMember = ""
			Me.o0_0oo0.OOo0oo.().ItemsValueMember = ""
			Me.o0_0oo0.OOo0oo.().Location = New Point(84, 148)
			Me.o0_0oo0.OOo0oo.().Margin = New Padding(4, 4, 4, 4)
			Me.o0_0oo0.OOo0oo.().Name = "cmbDataType"
			Me.o0_0oo0.OOo0oo.().Size = New Size(194, 26)
			Me.o0_0oo0.OOo0oo.().TabIndex = 2
			Me.o0_0oo0.OOo0oo.().Tag = Nothing
			Me.O.0_0.().AutoSize = True
			Me.O.0_0.().Location = New Point(18, 154)
			Me.O.0_0.().Margin = New Padding(4, 0, 4, 0)
			Me.O.0_0.().Name = "Label2"
			Me.O.0_0.().Size = New Size(53, 18)
			Me.O.0_0.().TabIndex = 11
			Me.O.0_0.().Text = "类型:"
			Me.OO_O_0._O0O_oo.().Location = New Point(84, 18)
			Me.OO_O_0._O0O_oo.().Margin = New Padding(4, 4, 4, 4)
			Me.OO_O_0._O0O_oo.().Name = "txtName"
			Me.OO_O_0._O0O_oo.().Size = New Size(465, 26)
			Me.OO_O_0._O0O_oo.().TabIndex = 0
			Me.OO_O_0._O0O_oo.().Tag = Nothing
			Me.o0_0oo0.OOo0oo.().AutoSize = True
			Me.o0_0oo0.OOo0oo.().Location = New Point(18, 24)
			Me.o0_0oo0.OOo0oo.().Margin = New Padding(4, 0, 4, 0)
			Me.o0_0oo0.OOo0oo.().Name = "Label1"
			Me.o0_0oo0.OOo0oo.().Size = New Size(53, 18)
			Me.o0_0oo0.OOo0oo.().TabIndex = 9
			Me.o0_0oo0.OOo0oo.().Text = "名称:"
			Me.o0_0oo0.OOo0oo.().Location = New Point(165, 368)
			Me.o0_0oo0.OOo0oo.().Margin = New Padding(4, 4, 4, 4)
			Me.o0_0oo0.OOo0oo.().Name = "btnOK"
			Me.o0_0oo0.OOo0oo.().Size = New Size(112, 34)
			Me.o0_0oo0.OOo0oo.().TabIndex = 4
			Me.o0_0oo0.OOo0oo.().Text = "确定"
			Me.o0_0oo0.OOo0oo.().UseVisualStyleBackColor = True
			Me.Oo_0o.ooOoo00O.().CausesValidation = False
			Me.Oo_0o.ooOoo00O.().DialogResult = DialogResult.Cancel
			Me.Oo_0o.ooOoo00O.().Location = New Point(286, 368)
			Me.Oo_0o.ooOoo00O.().Margin = New Padding(4, 4, 4, 4)
			Me.Oo_0o.ooOoo00O.().Name = "btnCancel"
			Me.Oo_0o.ooOoo00O.().Size = New Size(112, 34)
			Me.Oo_0o.ooOoo00O.().TabIndex = 5
			Me.Oo_0o.ooOoo00O.().Text = "取消"
			Me.Oo_0o.ooOoo00O.().UseVisualStyleBackColor = True
			Me.o0_Oo0._.().AutoSize = True
			Me.o0_Oo0._.().Location = New Point(18, 200)
			Me.o0_Oo0._.().Margin = New Padding(4, 0, 4, 0)
			Me.o0_Oo0._.().Name = "lblLenght"
			Me.o0_Oo0._.().Size = New Size(53, 18)
			Me.o0_Oo0._.().TabIndex = 15
			Me.o0_Oo0._.().Text = "长度:"
			Me.oo0O_O0.OOO_oO.().DataType = GetType(Byte)
			Me.oo0O_O0.OOO_oO.().ImagePadding = New Padding(0, 0, 0, 0)
			Me.oo0O_O0.OOO_oO.().Location = New Point(84, 194)
			Me.oo0O_O0.OOO_oO.().Margin = New Padding(4, 4, 4, 4)
			Me.oo0O_O0.OOO_oO.().Name = "Length"
			Me.oo0O_O0.OOO_oO.().PostValidation.Intervals.AddRange(New ValueInterval() { New ValueInterval(1L, 255L, True, True) })
			Me.oo0O_O0.OOO_oO.().Size = New Size(105, 26)
			Me.oo0O_O0.OOO_oO.().TabIndex = 3
			Me.oo0O_O0.OOO_oO.().Tag = Nothing
			Me.oo0O_O0.OOO_oO.().Value = 16
			Me.oo0O_O0.OOO_oO.().VisibleButtons = 1
			Me.OO.0Ooo_0.().Location = New Point(18, 246)
			Me.OO.0Ooo_0.().Margin = New Padding(4, 0, 4, 0)
			Me.OO.0Ooo_0.().Name = "Description"
			Me.OO.0Ooo_0.().Size = New Size(531, 104)
			Me.OO.0Ooo_0.().TabIndex = 17
			Me.OO.0Ooo_0.().Text = "说明:"
			Me.o.O0o00O__OO.().AutoSize = True
			Me.o.O0o00O__OO.().Location = New Point(18, 70)
			Me.o.O0o00O__OO.().Margin = New Padding(4, 0, 4, 0)
			Me.o.O0o00O__OO.().Name = "Label3"
			Me.o.O0o00O__OO.().Size = New Size(53, 18)
			Me.o.O0o00O__OO.().TabIndex = 18
			Me.o.O0o00O__OO.().Text = "标题:"
			Me.oo0O_O0.OOO_oO.().Location = New Point(84, 64)
			Me.oo0O_O0.OOO_oO.().Margin = New Padding(4, 4, 4, 4)
			Me.oo0O_O0.OOO_oO.().Name = "txtCaption"
			Me.oo0O_O0.OOO_oO.().Size = New Size(465, 26)
			Me.oo0O_O0.OOO_oO.().TabIndex = 1
			Me.oo0O_O0.OOO_oO.().Tag = Nothing
			Me.Oo_0o.ooOoo00O.().AutoSize = True
			Me.Oo_0o.ooOoo00O.().Location = New Point(198, 200)
			Me.Oo_0o.ooOoo00O.().Margin = New Padding(4, 0, 4, 0)
			Me.Oo_0o.ooOoo00O.().Name = "Label5"
			Me.Oo_0o.ooOoo00O.().Size = New Size(242, 18)
			Me.Oo_0o.ooOoo00O.().TabIndex = 21
			Me.Oo_0o.ooOoo00O.().Text = "(字符列允许输入的最大长度)"
			Me.oO0OO.O_O.().Location = New Point(80, 100)
			Me.oO0OO.O_O.().Margin = New Padding(4, 0, 4, 0)
			Me.oO0OO.O_O.().Name = "Label6"
			Me.oO0OO.O_O.().Size = New Size(470, 44)
			Me.oO0OO.O_O.().TabIndex = 22
			Me.oO0OO.O_O.().Text = "标题是列名更具描述性的表示，可以不输入，直接用列名作为标题。"
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.Oo_0o.ooOoo00O.()
			MyBase.ClientSize = New Size(568, 418)
			MyBase.Controls.Add(Me.oO0OO.O_O.())
			MyBase.Controls.Add(Me.Oo_0o.ooOoo00O.())
			MyBase.Controls.Add(Me.oo0O_O0.OOO_oO.())
			MyBase.Controls.Add(Me.o.O0o00O__OO.())
			MyBase.Controls.Add(Me.OO.0Ooo_0.())
			MyBase.Controls.Add(Me.oo0O_O0.OOO_oO.())
			MyBase.Controls.Add(Me.o0_Oo0._.())
			MyBase.Controls.Add(Me.Oo_0o.ooOoo00O.())
			MyBase.Controls.Add(Me.o0_0oo0.OOo0oo.())
			MyBase.Controls.Add(Me.o0_0oo0.OOo0oo.())
			MyBase.Controls.Add(Me.O.0_0.())
			MyBase.Controls.Add(Me.OO_O_0._O0O_oo.())
			MyBase.Controls.Add(Me.o0_0oo0.OOo0oo.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O1.1I.oI"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "增加列"
			Me.o0_0oo0.OOo0oo.().EndInit()
			Me.OO_O_0._O0O_oo.().EndInit()
			Me.o0_0oo0.OOo0oo.().EndInit()
			Me.Oo_0o.ooOoo00O.().EndInit()
			Me.oo0O_O0.OOO_oO.().EndInit()
			Me.oo0O_O0.OOO_oO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600379A RID: 14234 RVA: 0x0017AFB1 File Offset: 0x001791B1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oOO0o.0_.
		End Function

		' Token: 0x0600379B RID: 14235 RVA: 0x0017AFBC File Offset: 0x001791BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0__.0o0O_O.
			Dim c1ComboBox As C1ComboBox = Me.oOO0o.0_.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.oOO0o.0_. = A_0
			c1ComboBox = Me.oOO0o.0_.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600379C RID: 14236 RVA: 0x0017AFFF File Offset: 0x001791FF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOO0o.0_.
		End Function

		' Token: 0x0600379D RID: 14237 RVA: 0x0017B007 File Offset: 0x00179207
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOO0o.0_. = A_0
		End Sub

		' Token: 0x0600379E RID: 14238 RVA: 0x0017B010 File Offset: 0x00179210
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_.O0.
		End Function

		' Token: 0x0600379F RID: 14239 RVA: 0x0017B018 File Offset: 0x00179218
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_.O0. = A_0
		End Sub

		' Token: 0x060037A0 RID: 14240 RVA: 0x0017B021 File Offset: 0x00179221
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_O_O0oo_O.oo.
		End Function

		' Token: 0x060037A1 RID: 14241 RVA: 0x0017B029 File Offset: 0x00179229
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_O_O0oo_O.oo. = A_0
		End Sub

		' Token: 0x060037A2 RID: 14242 RVA: 0x0017B032 File Offset: 0x00179232
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO_.o.
		End Function

		' Token: 0x060037A3 RID: 14243 RVA: 0x0017B03C File Offset: 0x0017923C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__o.oO.
			Dim oo_.o. As C1Button = Me.OO_.o.
			If oo_.o. IsNot Nothing Then
				RemoveHandler oo_.o..Click, value
			End If
			Me.OO_.o. = A_0
			oo_.o. = Me.OO_.o.
			If oo_.o. IsNot Nothing Then
				AddHandler oo_.o..Click, value
			End If
		End Sub

		' Token: 0x060037A4 RID: 14244 RVA: 0x0017B07F File Offset: 0x0017927F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_O00__.0oo0.
		End Function

		' Token: 0x060037A5 RID: 14245 RVA: 0x0017B087 File Offset: 0x00179287
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O_O00__.0oo0. = A_0
		End Sub

		' Token: 0x060037A6 RID: 14246 RVA: 0x0017B090 File Offset: 0x00179290
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooo.oO0.
		End Function

		' Token: 0x060037A7 RID: 14247 RVA: 0x0017B098 File Offset: 0x00179298
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooo.oO0. = A_0
		End Sub

		' Token: 0x060037A8 RID: 14248 RVA: 0x0017B0A1 File Offset: 0x001792A1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.oOO0o.0_.
		End Function

		' Token: 0x060037A9 RID: 14249 RVA: 0x0017B0A9 File Offset: 0x001792A9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.oOO0o.0_. = A_0
		End Sub

		' Token: 0x060037AA RID: 14250 RVA: 0x0017B0B2 File Offset: 0x001792B2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o__o___.0Ooo.
		End Function

		' Token: 0x060037AB RID: 14251 RVA: 0x0017B0BA File Offset: 0x001792BA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o__o___.0Ooo. = A_0
		End Sub

		' Token: 0x060037AC RID: 14252 RVA: 0x0017B0C3 File Offset: 0x001792C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0OO0O0_0O_.oO.
		End Function

		' Token: 0x060037AD RID: 14253 RVA: 0x0017B0CB File Offset: 0x001792CB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0OO0O0_0O_.oO. = A_0
		End Sub

		' Token: 0x060037AE RID: 14254 RVA: 0x0017B0D4 File Offset: 0x001792D4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o_O_O0oo_O.oo.
		End Function

		' Token: 0x060037AF RID: 14255 RVA: 0x0017B0DC File Offset: 0x001792DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o_O_O0oo_O.oo. = A_0
		End Sub

		' Token: 0x060037B0 RID: 14256 RVA: 0x0017B0E5 File Offset: 0x001792E5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0._0_O.
		End Function

		' Token: 0x060037B1 RID: 14257 RVA: 0x0017B0ED File Offset: 0x001792ED
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0._0_O. = A_0
		End Sub

		' Token: 0x060037B2 RID: 14258 RVA: 0x0017B0F6 File Offset: 0x001792F6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0_oo_O.oO_0_0.
		End Function

		' Token: 0x060037B3 RID: 14259 RVA: 0x0017B0FE File Offset: 0x001792FE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0_oo_O.oO_0_0. = A_0
		End Sub

		' Token: 0x060037B4 RID: 14260 RVA: 0x0017B108 File Offset: 0x00179308
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0_0oo0.OOo0oo.().ItemsDisplayMember = "DisplayName"
			Me.o0_0oo0.OOo0oo.().ItemsValueMember = "DataType"
			Me.o0_0oo0.OOo0oo.().TranslateValue = True
			If OO_00oOO.DataTables(Me.O_.O0.).frd_IsTemporary OrElse o_O_o_oOoo__.OOOO_OO._oo.(OO_00oOO.DataTables(Me.O_.O0.).frd_Connection) Then
				Me.o0_0oo0.OOo0oo.().ItemsDataSource = DataTypePair.CreateDataTypePairs(False)
			Else
				Me.o0_0oo0.OOo0oo.().ItemsDataSource = DataTypePair.CreateDataTypePairs(True)
			End If
			Me.o0_0oo0.OOo0oo.().SelectedIndex = 0
		End Sub

		' Token: 0x060037B5 RID: 14261 RVA: 0x0017B1A4 File Offset: 0x001793A4
		Public Sub New(A_0 As String, A_1 As Boolean)
			AddHandler MyBase.Load, AddressOf Me.oO0OO.O_O.
			AddHandler MyBase.FormClosed, AddressOf Me.O0__.0o0O_O.
			Me.oo0O_O0.OOO_oO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o0O.o0. = A_0
			Me.O_.O0. = OO_00oOO.Tables(A_0).DataTable.Name
			Me.O_.O0. = A_1
			If Me.O_.O0. Then
				Me.Text = "插入列"
			End If
			Me.Text = Me.Text + " - " + Me.O_.O0.
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.foxGrid.FindForm() IsNot Nothing AndAlso Operators.CompareString(table.DataTable.Name, Me.O_.O0., True) = 0 Then
						table._frdTableLayout.OOooOOo_.0_0_o.()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060037B6 RID: 14262 RVA: 0x0017B2B8 File Offset: 0x001794B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				OO_00oOO.SystemReady = False
				If Me.o0_0oo0.OOo0oo.().SelectedItem IsNot Nothing AndAlso o_O_o_oOoo__.O_o_._o0.(Me.OO_O_0._O0O_oo.().Text.Trim(), "列名称", 64, False) Then
					Dim text As String = Me.OO_O_0._O0O_oo.().Text.Trim()
					Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(Me.o0_0oo0.OOo0oo.().SelectedItem), ColumnDataTypeEnum)
					Dim num As Integer = Conversions.ToInteger(Me.oo0O_O0.OOO_oO.().Value)
					Try
						Dim enumerator As IEnumerator = OO_00oOO.DataTables(Me.O_.O0.).BaseTable.Columns.GetEnumerator()
						While enumerator.MoveNext()
							If Operators.CompareString(CType(enumerator.Current, DataColumn).ColumnName, text, True) = 0 Then
								MessageBox.Show("已经存在同名列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Return
							End If
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If Oo00.o.OO0.(Me.O_.O0., text) Then
						If OO_00oOO.DataTables(Me.O_.O0.).frd_IsTemporary Then
							Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.())
							Dim dataRow As DataRow = dataTable.NewRow()
							dataRow("Table") = Me.O_.O0.
							dataRow("Column") = text
							dataRow("DataType") = columnDataTypeEnum
							dataRow("Maxlength") = num
							dataRow("Expression") = ""
							dataTable.Rows.Add(dataRow)
							If Operators.CompareString(Me.oo0O_O0.OOO_oO.().Text.Trim(), "", True) <> 0 Then
								Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { Me.O_.O0., text })
								If dataRow2 Is Nothing Then
									dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).NewRow()
									dataRow2("Table") = Me.O_.O0.
									dataRow2("Column") = text
									O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Add(dataRow2)
								End If
								dataRow2("Config") = "Caption" & vbVerticalTab + Me.oo0O_O0.OOO_oO.().Text.Trim()
								Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
							End If
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
						Else
							Dim oleDbConnection As OleDbConnection = OO_00oOO.DataTables(Me.O_.O0.).frd_Connection
							Dim o_oo As o_oo0 = New o_oo0(oleDbConnection, o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection), oleDbConnection Is O_O0OO.OoO.0OO__0ooo.())
							Dim a_ As String
							If oleDbConnection Is O_O0OO.OoO.0OO__0ooo.() Then
								a_ = Me.O_.O0.
							Else
								a_ = OO_00oOO.DataTables(Me.O_.O0.).o._OOO0oOo0__.
							End If
							Dim o_0O_ As O_0O_ = o_oo.o0_oo0._.().O.0_O.(a_)
							If o_0O_.o_O00_.00_.().O_o0.Oo00o0.(text) Then
								MessageBox.Show("已经存在同名列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Return
							End If
							o_0O_.o_O00_.00_.().O_o0.Oo00o0.(text, columnDataTypeEnum, Integer.MinValue)
							If Operators.CompareString(Me.oo0O_O0.OOO_oO.().Text.Trim(), "", True) <> 0 Then
								o_0O_.o_O00_.00_.().OO00o__OOO.o0_.(text).O.0_.(Me.oo0O_O0.OOO_oO.().Text.Trim())
							End If
							If columnDataTypeEnum = ColumnDataTypeEnum.[String] Then
								o_0O_.o_O00_.00_.().OO00o__OOO.o0_.(text).O_o0.Oo00o0.(num)
							End If
							o_oo.o0_oo0._.(True, False)
							OO_00oOO.DataTables(Me.O_.O0.).O_00_._.()
						End If
						If columnDataTypeEnum = ColumnDataTypeEnum.[String] Then
							OO_00oOO.DataTables(Me.O_.O0.).DataCols.Add(text, Oo00.OO.0O0o.(columnDataTypeEnum), num, "")
						Else
							OO_00oOO.DataTables(Me.O_.O0.).DataCols.Add(text, Oo00.OO.0O0o.(columnDataTypeEnum), -1, "")
						End If
						If Not OO_00oOO.DataTables(Me.O_.O0.).frd_IsTemporary Then
							OO_00oOO.DataTables(Me.O_.O0.).DataCols(text).IsTemporary = False
						End If
						Try
							For Each table As Table In OO_00oOO.Tables
								If table.foxGrid.FindForm() IsNot Nothing Then
									table.O.__O0o0.(True, True)
									If Operators.CompareString(table.DataTable.Name, Me.O_.O0., True) = 0 Then
										table._frdTableLayout.Oo_.oo_oOo_oO.()
									End If
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Table)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
						If Me.O_.O0. AndAlso o_oOooO_O.Col > o_oOooO_O.Cols.Fixed - 1 AndAlso o_oOooO_O.Cols.Contains(text) Then
							o_oOooO_O.Cols(text).Move(o_oOooO_O.Col)
						End If
						If o_oOooO_O.Cols.Contains(text) Then
							o_oOooO_O.Col = o_oOooO_O.Cols.IndexOf(text)
							o_oOooO_O.ShowCell(o_oOooO_O.Row, o_oOooO_O.Col)
						End If
						Try
							For Each table2 As Table In OO_00oOO.Tables
								If Operators.CompareString(table2.DataTable.Name, Me.O_.O0., True) = 0 Then
									If table2.Cols.Contains(text) Then
										table2.Cols(text).o0.O.()
										table2.Cols(text).OpenWindow(0)
									End If
									table2.NeedSaveSetting = True
									table2.Oo._0oO.()
								End If
							Next
						Finally
							Dim enumerator3 As IEnumerator(Of Table)
							If enumerator3 IsNot Nothing Then
								enumerator3.Dispose()
							End If
						End Try
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
						MyBase.DialogResult = DialogResult.OK
					End If
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				OO_00oOO.SystemReady = True
			End Try
		End Sub

		' Token: 0x060037B7 RID: 14263 RVA: 0x0017B958 File Offset: 0x00179B58
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oo0O_O0.OOO_oO.().Enabled = (Conversions.ToInteger(Me.o0_0oo0.OOo0oo.().SelectedItem) = 202)
			Me.OO.0Ooo_0.().Text = "说明:" + ooO.oO0__o.0o__.(CType(Conversions.ToInteger(Me.o0_0oo0.OOo0oo.().SelectedItem), ColumnDataTypeEnum))
		End Sub

		' Token: 0x060037B8 RID: 14264 RVA: 0x0017B9B1 File Offset: 0x00179BB1
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040016E9 RID: 5865
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040016EA RID: 5866
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040016EB RID: 5867
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016EC RID: 5868
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040016ED RID: 5869
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016EE RID: 5870
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016EF RID: 5871
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016F0 RID: 5872
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016F1 RID: 5873
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x040016F2 RID: 5874
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016F3 RID: 5875
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016F4 RID: 5876
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040016F5 RID: 5877
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016F6 RID: 5878
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016F7 RID: 5879
		Private <<EMPTY_NAME>> As String

		' Token: 0x040016F8 RID: 5880
		Private <<EMPTY_NAME>> As String

		' Token: 0x040016F9 RID: 5881
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
