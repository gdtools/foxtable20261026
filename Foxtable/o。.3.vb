Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200045F RID: 1119
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u3002\u3000
		Inherits Form

		' Token: 0x06004AB2 RID: 19122 RVA: 0x001F7258 File Offset: 0x001F5458
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_O0_O.O_OOO. IsNot Nothing Then
					Me.o_O0_O.O_OOO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004AB3 RID: 19123 RVA: 0x001F7298 File Offset: 0x001F5498
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_.O0OO.(New C1ComboBox())
			Me.o_o_OO.00__.(New Label())
			Me.oO0o00.ooOo.(New Label())
			Me.o_.O0OO.(New C1NumericEdit())
			Me.Ooo0oo_00OoO.o.(New C1Button())
			Me.OOO._0o_oO.(New C1Button())
			Me.o_.O0OO.(New CheckedListBox())
			Me.o_.O0OO.(New Label())
			Me.o_.O0OO.(New ListBox())
			Me.Ooo.O_0___O.(New Label())
			Me.o_.O0OO.(New C1Button())
			Me.oO._00_o0_0.(New C1Button())
			Me.oO0o00.ooOo.(New C1Button())
			Me.O_o.oOoOOO_0o.().BeginInit()
			Me.O_oO_o.O0O.().BeginInit()
			Me.Oo_o0o._o0.().BeginInit()
			Me.o_OoO_0O_.o_0.().BeginInit()
			Me.O0o_.__O.().BeginInit()
			Me.O0oo.OoO.().BeginInit()
			Me.O_o.oOoOOO_0o.().BeginInit()
			MyBase.SuspendLayout()
			Me.O_o.oOoOOO_0o.().AllowSpinLoop = False
			Me.O_o.oOoOOO_0o.().Cursor = Cursors.Arrow
			Me.O_o.oOoOOO_0o.().DropDownStyle = 1
			Me.O_o.oOoOOO_0o.().GapHeight = 0
			Me.O_o.oOoOOO_0o.().ImagePadding = New Padding(0)
			Me.O_o.oOoOOO_0o.().ItemsDisplayMember = ""
			Me.O_o.oOoOOO_0o.().ItemsValueMember = ""
			Me.O_o.oOoOOO_0o.().Location = New Point(13, 30)
			Me.O_o.oOoOOO_0o.().Name = "cmbTables"
			Me.O_o.oOoOOO_0o.().Size = New Size(210, 19)
			Me.O_o.oOoOOO_0o.().TabIndex = 0
			Me.O_o.oOoOOO_0o.().Tag = Nothing
			Me.O0oo.OoO.().AutoSize = True
			Me.O0oo.OoO.().Location = New Point(13, 11)
			Me.O0oo.OoO.().Name = "Label1"
			Me.O0oo.OoO.().Size = New Size(71, 12)
			Me.O0oo.OoO.().TabIndex = 1
			Me.O0oo.OoO.().Text = "选择关联表:"
			Me.oO._00_o0_0.().AutoSize = True
			Me.oO._00_o0_0.().Location = New Point(242, 11)
			Me.oO._00_o0_0.().Name = "Label3"
			Me.oO._00_o0_0.().Size = New Size(59, 12)
			Me.oO._00_o0_0.().TabIndex = 4
			Me.oO._00_o0_0.().Text = "打印行数:"
			Me.O_oO_o.O0O.().ImagePadding = New Padding(0)
			Me.O_oO_o.O0O.().Location = New Point(244, 30)
			Me.O_oO_o.O0O.().Name = "NumericUpDown1"
			Dim intervals As ValueIntervalCollection = Me.O_oO_o.O0O.().PostValidation.Intervals
			Dim array As ValueInterval() = New ValueInterval(0) {}
			Dim num As Integer = 0
			Dim array2 As Integer() = New Integer(3) {}
			array2(0) = 1
			Dim obj As Object = New Decimal(array2)
			Dim array3 As Integer() = New Integer(3) {}
			array3(0) = 100
			array(num) = New ValueInterval(obj, New Decimal(array3), True, True)
			intervals.AddRange(array)
			Me.O_oO_o.O0O.().Size = New Size(117, 19)
			Me.O_oO_o.O0O.().TabIndex = 5
			Me.O_oO_o.O0O.().Tag = Nothing
			Dim c1TextBox As C1TextBox = Me.O_oO_o.O0O.()
			Dim array4 As Integer() = New Integer(3) {}
			array4(0) = 5
			c1TextBox.Value = New Decimal(array4)
			Me.O_oO_o.O0O.().VisibleButtons = 1
			Me.Oo_o0o._o0.().Location = New Point(281, 367)
			Me.Oo_o0o._o0.().Name = "btnOk"
			Me.Oo_o0o._o0.().Size = New Size(75, 23)
			Me.Oo_o0o._o0.().TabIndex = 6
			Me.Oo_o0o._o0.().Text = "确定"
			Me.Oo_o0o._o0.().UseVisualStyleBackColor = True
			Me.o_OoO_0O_.o_0.().Location = New Point(362, 367)
			Me.o_OoO_0O_.o_0.().Name = "btnCancel"
			Me.o_OoO_0O_.o_0.().Size = New Size(75, 23)
			Me.o_OoO_0O_.o_0.().TabIndex = 7
			Me.o_OoO_0O_.o_0.().Text = "取消"
			Me.o_OoO_0O_.o_0.().UseVisualStyleBackColor = True
			Me.O_oO_o.O0O.().CheckOnClick = True
			Me.O_oO_o.O0O.().FormattingEnabled = True
			Me.O_oO_o.O0O.().Location = New Point(11, 87)
			Me.O_oO_o.O0O.().Name = "lstCols"
			Me.O_oO_o.O0O.().Size = New Size(212, 260)
			Me.O_oO_o.O0O.().TabIndex = 2
			Me.O0o_.__O.().AutoSize = True
			Me.O0o_.__O.().Location = New Point(11, 68)
			Me.O0o_.__O.().Name = "Label2"
			Me.O0o_.__O.().Size = New Size(47, 12)
			Me.O0o_.__O.().TabIndex = 3
			Me.O0o_.__O.().Text = "选择列:"
			Me.O_oO_o.O0O.().FormattingEnabled = True
			Me.O_oO_o.O0O.().IntegralHeight = False
			Me.O_oO_o.O0O.().ItemHeight = 12
			Me.O_oO_o.O0O.().Location = New Point(229, 87)
			Me.O_oO_o.O0O.().Name = "lstFields"
			Me.O_oO_o.O0O.().Size = New Size(208, 260)
			Me.O_oO_o.O0O.().TabIndex = 9
			Me.O_oO_o.O0O.().AutoSize = True
			Me.O_oO_o.O0O.().Location = New Point(229, 68)
			Me.O_oO_o.O0O.().Name = "Label4"
			Me.O_oO_o.O0O.().Size = New Size(47, 12)
			Me.O_oO_o.O0O.().TabIndex = 10
			Me.O_oO_o.O0O.().Text = "已选列:"
			Me.O0o_.__O.().Image = a.OO.oO__O00.()
			Me.O0o_.__O.().Location = New Point(443, 87)
			Me.O0o_.__O.().Name = "btnUp"
			Me.O0o_.__O.().Size = New Size(30, 23)
			Me.O0o_.__O.().TabIndex = 11
			Me.O0o_.__O.().UseVisualStyleBackColor = True
			Me.O0oo.OoO.().Image = a.OoOoOOOOOO.0_.()
			Me.O0oo.OoO.().Location = New Point(444, 117)
			Me.O0oo.OoO.().Name = "btnDown"
			Me.O0oo.OoO.().Size = New Size(30, 23)
			Me.O0oo.OoO.().TabIndex = 12
			Me.O0oo.OoO.().UseVisualStyleBackColor = True
			Me.O_o.oOoOOO_0o.().Location = New Point(379, 29)
			Me.O_o.oOoOOO_0o.().Name = "btnSelectall"
			Me.O_o.oOoOOO_0o.().Size = New Size(95, 23)
			Me.O_o.oOoOOO_0o.().TabIndex = 13
			Me.O_o.oOoOOO_0o.().Text = "选择所有列"
			Me.O_o.oOoOOO_0o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(485, 404)
			MyBase.Controls.Add(Me.O_o.oOoOOO_0o.())
			MyBase.Controls.Add(Me.O0oo.OoO.())
			MyBase.Controls.Add(Me.O0o_.__O.())
			MyBase.Controls.Add(Me.O_oO_o.O0O.())
			MyBase.Controls.Add(Me.O_oO_o.O0O.())
			MyBase.Controls.Add(Me.o_OoO_0O_.o_0.())
			MyBase.Controls.Add(Me.Oo_o0o._o0.())
			MyBase.Controls.Add(Me.O_oO_o.O0O.())
			MyBase.Controls.Add(Me.oO._00_o0_0.())
			MyBase.Controls.Add(Me.O0o_.__O.())
			MyBase.Controls.Add(Me.O_oO_o.O0O.())
			MyBase.Controls.Add(Me.O0oo.OoO.())
			MyBase.Controls.Add(Me.O_o.oOoOOO_0o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.1.OO._."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "插入关联表"
			Me.O_o.oOoOOO_0o.().EndInit()
			Me.O_oO_o.O0O.().EndInit()
			Me.Oo_o0o._o0.().EndInit()
			Me.o_OoO_0O_.o_0.().EndInit()
			Me.O0o_.__O.().EndInit()
			Me.O0oo.OoO.().EndInit()
			Me.O_o.oOoOOO_0o.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06004AB4 RID: 19124 RVA: 0x001F7B18 File Offset: 0x001F5D18
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0OOoO_O.o0_O.
		End Function

		' Token: 0x06004AB5 RID: 19125 RVA: 0x001F7B20 File Offset: 0x001F5D20
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.oo_.0__O_Ooo0.
			Dim c1ComboBox As C1ComboBox = Me.o0OOoO_O.o0_O.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o0OOoO_O.o0_O. = A_0
			c1ComboBox = Me.o0OOoO_O.o0_O.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06004AB6 RID: 19126 RVA: 0x001F7B63 File Offset: 0x001F5D63
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0OOoO_O.o0_O.
		End Function

		' Token: 0x06004AB7 RID: 19127 RVA: 0x001F7B6B File Offset: 0x001F5D6B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0OOoO_O.o0_O. = A_0
		End Sub

		' Token: 0x06004AB8 RID: 19128 RVA: 0x001F7B74 File Offset: 0x001F5D74
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.O_oo0ooO.
		End Function

		' Token: 0x06004AB9 RID: 19129 RVA: 0x001F7B7C File Offset: 0x001F5D7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.O_oo0ooO. = A_0
		End Sub

		' Token: 0x06004ABA RID: 19130 RVA: 0x001F7B85 File Offset: 0x001F5D85
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.o_O0_O.O_OOO.
		End Function

		' Token: 0x06004ABB RID: 19131 RVA: 0x001F7B8D File Offset: 0x001F5D8D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.o_O0_O.O_OOO. = A_0
		End Sub

		' Token: 0x06004ABC RID: 19132 RVA: 0x001F7B96 File Offset: 0x001F5D96
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0OOoO_O.o0_O.
		End Function

		' Token: 0x06004ABD RID: 19133 RVA: 0x001F7BA0 File Offset: 0x001F5DA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.Oo_O.
			Dim c1Button As C1Button = Me.o0OOoO_O.o0_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0OOoO_O.o0_O. = A_0
			c1Button = Me.o0OOoO_O.o0_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004ABE RID: 19134 RVA: 0x001F7BE3 File Offset: 0x001F5DE3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.O_oo0ooO.
		End Function

		' Token: 0x06004ABF RID: 19135 RVA: 0x001F7BEC File Offset: 0x001F5DEC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0_.00_O.
			Dim c1Button As C1Button = Me.o.O_oo0ooO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.O_oo0ooO. = A_0
			c1Button = Me.o.O_oo0ooO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004AC0 RID: 19136 RVA: 0x001F7C2F File Offset: 0x001F5E2F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.o_O0_O.O_OOO.
		End Function

		' Token: 0x06004AC1 RID: 19137 RVA: 0x001F7C38 File Offset: 0x001F5E38
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.O_oO_o.O0O.
			Dim checkedListBox As CheckedListBox = Me.o_O0_O.O_OOO.
			If checkedListBox IsNot Nothing Then
				RemoveHandler checkedListBox.ItemCheck, value
			End If
			Me.o_O0_O.O_OOO. = A_0
			checkedListBox = Me.o_O0_O.O_OOO.
			If checkedListBox IsNot Nothing Then
				AddHandler checkedListBox.ItemCheck, value
			End If
		End Sub

		' Token: 0x06004AC2 RID: 19138 RVA: 0x001F7C7B File Offset: 0x001F5E7B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo_0.0.
		End Function

		' Token: 0x06004AC3 RID: 19139 RVA: 0x001F7C83 File Offset: 0x001F5E83
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo_0.0. = A_0
		End Sub

		' Token: 0x06004AC4 RID: 19140 RVA: 0x001F7C8C File Offset: 0x001F5E8C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o_O0_O.O_OOO.
		End Function

		' Token: 0x06004AC5 RID: 19141 RVA: 0x001F7C94 File Offset: 0x001F5E94
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o_O0_O.O_OOO. = A_0
		End Sub

		' Token: 0x06004AC6 RID: 19142 RVA: 0x001F7C9D File Offset: 0x001F5E9D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOOO00._0Oo0Oo.
		End Function

		' Token: 0x06004AC7 RID: 19143 RVA: 0x001F7CA5 File Offset: 0x001F5EA5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOOO00._0Oo0Oo. = A_0
		End Sub

		' Token: 0x06004AC8 RID: 19144 RVA: 0x001F7CAE File Offset: 0x001F5EAE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_0.0.
		End Function

		' Token: 0x06004AC9 RID: 19145 RVA: 0x001F7CB8 File Offset: 0x001F5EB8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO.o_o0_.
			Dim c1Button As C1Button = Me.oo_0.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo_0.0. = A_0
			c1Button = Me.oo_0.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004ACA RID: 19146 RVA: 0x001F7CFB File Offset: 0x001F5EFB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOOO00._0Oo0Oo.
		End Function

		' Token: 0x06004ACB RID: 19147 RVA: 0x001F7D04 File Offset: 0x001F5F04
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.O00ooO_.
			Dim c1Button As C1Button = Me.oOOO00._0Oo0Oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOOO00._0Oo0Oo. = A_0
			c1Button = Me.oOOO00._0Oo0Oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004ACC RID: 19148 RVA: 0x001F7D47 File Offset: 0x001F5F47
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.__0.
		End Function

		' Token: 0x06004ACD RID: 19149 RVA: 0x001F7D50 File Offset: 0x001F5F50
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.ooo.O_OOO.
			Dim o.__0. As C1Button = Me.O.__0.
			If o.__0. IsNot Nothing Then
				RemoveHandler o.__0..Click, value
			End If
			Me.O.__0. = A_0
			o.__0. = Me.O.__0.
			If o.__0. IsNot Nothing Then
				AddHandler o.__0..Click, value
			End If
		End Sub

		' Token: 0x06004ACE RID: 19150 RVA: 0x001F7D93 File Offset: 0x001F5F93
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06004ACF RID: 19151 RVA: 0x001F7D9C File Offset: 0x001F5F9C
		Public Sub New(A_0 As Application, A_1 As Table)
			AddHandler MyBase.Load, AddressOf Me.O0_o.O0o0_.
			AddHandler MyBase.FormClosed, AddressOf Me.O_o.oOoOOO_0o.
			Me.O_oO_o.O0O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o_O0_O.O_OOO. = A_1
			Me.o_O0_O.O_OOO. = A_0
		End Sub

		' Token: 0x06004AD0 RID: 19152 RVA: 0x001F7DFC File Offset: 0x001F5FFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					If Operators.CompareString(dataRelation.ParentTable.TableName, Me.o_O0_O.O_OOO..Name, True) = 0 AndAlso Not Me.O_o.oOoOOO_0o.().Items.Contains(dataRelation.ChildTable.TableName) Then
						Me.O_o.oOoOOO_0o.().Items.Add(dataRelation.ChildTable.TableName)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Me.O_o.oOoOOO_0o.().Items.Count > 0 Then
				Me.O_o.oOoOOO_0o.().SelectedIndex = 0
				Return
			End If
			MessageBox.Show("不存在可插入的关联子表!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06004AD1 RID: 19153 RVA: 0x001F7EE0 File Offset: 0x001F60E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_oO_o.O0O.().Items.Clear()
			Try
				For Each dataCol As DataCol In OO_00oOO.DataTables(Me.O_o.oOoOOO_0o.().SelectedItem.ToString()).DataCols
					Me.O_oO_o.O0O.().Items.Add(dataCol.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.O_oO_o.O0O.().SelectedIndex = 0
		End Sub

		' Token: 0x06004AD2 RID: 19154 RVA: 0x001F7F74 File Offset: 0x001F6174
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.O_o.oOoOOO_0o.().Text, "", True) > 0 AndAlso Me.O_oO_o.O0O.().Items.Count > 0 Then
				Me.o_O0_O.O_OOO..Selection.TypeParagraph()
				Dim tables As Tables = Me.o_O0_O.O_OOO..Selection.Document.Tables
				Dim range As Range = Me.o_O0_O.O_OOO..Selection.Range
				Dim num As Integer = Math.Max(2, Conversions.ToInteger(Me.O_oO_o.O0O.().Value) + 1)
				Dim count As Integer = Me.O_oO_o.O0O.().Items.Count
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim table As Table = tables.Add(range, num, count, objectValue, objectValue2)
				table.Borders.Enable = 1
				table.Borders.OutsideLineWidth = 4
				table.Rows(1).Alignment = 1
				Dim text As String = Me.O_o.oOoOOO_0o.().Text
				Dim num2 As Integer = Me.O_oO_o.O0O.().Items.Count - 1
				For i As Integer = 0 To num2
					Dim text2 As String = Me.O_oO_o.O0O.().Items(i).ToString()
					table.Cell(1, i + 1).Range.Text = text2
					table.Cell(1, i + 1).Range.ParagraphFormat.Alignment = 1
					Dim count2 As Integer = table.Rows.Count
					For j As Integer = 2 To count2
						table.Cell(j, i + 1).Range.Text = String.Concat(New String() { "[@", text, ",", text2, ",", Conversions.ToString(j - 1), "]" })
						If OO_00oOO.Tables(text).Cols(text2).IsNumeric() Then
							table.Cell(j, i + 1).Range.ParagraphFormat.Alignment = 2
						Else
							table.Cell(j, i + 1).Range.ParagraphFormat.Alignment = 0
						End If
					Next
				Next
				MyBase.Close()
				Return
			End If
			MessageBox.Show("请选择要打印的关联表和列!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
		End Sub

		' Token: 0x06004AD3 RID: 19155 RVA: 0x001F81C8 File Offset: 0x001F63C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim value As Boolean = Me.O_oO_o.O0O.().CheckedItems.Count <> Me.O_oO_o.O0O.().Items.Count
			Dim num As Integer = Me.O_oO_o.O0O.().Items.Count - 1
			For i As Integer = 0 To num
				Me.O_oO_o.O0O.().SetItemChecked(i, value)
			Next
		End Sub

		' Token: 0x06004AD4 RID: 19156 RVA: 0x001F822C File Offset: 0x001F642C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			Dim text As String = Me.O_oO_o.O0O.().Items(A_1.Index).ToString()
			If A_1.NewValue = CheckState.Checked Then
				If Not Me.O_oO_o.O0O.().Items.Contains(text) Then
					Me.O_oO_o.O0O.().Items.Add(text)
					Return
				End If
			ElseIf Me.O_oO_o.O0O.().Items.Contains(text) Then
				Me.O_oO_o.O0O.().Items.Remove(text)
			End If
		End Sub

		' Token: 0x06004AD5 RID: 19157 RVA: 0x001F82A8 File Offset: 0x001F64A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O_oO_o.O0O.().SelectedIndex > 0 Then
				Dim item As String = Me.O_oO_o.O0O.().SelectedItem.ToString()
				Dim num As Integer = Me.O_oO_o.O0O.().SelectedIndex - 1
				Me.O_oO_o.O0O.().Items.RemoveAt(Me.O_oO_o.O0O.().SelectedIndex)
				Me.O_oO_o.O0O.().Items.Insert(num, item)
				Me.O_oO_o.O0O.().SelectedIndex = num
			End If
		End Sub

		' Token: 0x06004AD6 RID: 19158 RVA: 0x001F831C File Offset: 0x001F651C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O_oO_o.O0O.().SelectedIndex < Me.O_oO_o.O0O.().Items.Count - 1 Then
				Dim item As String = Me.O_oO_o.O0O.().SelectedItem.ToString()
				Dim num As Integer = Me.O_oO_o.O0O.().SelectedIndex + 1
				Me.O_oO_o.O0O.().Items.RemoveAt(Me.O_oO_o.O0O.().SelectedIndex)
				Me.O_oO_o.O0O.().Items.Insert(num, item)
				Me.O_oO_o.O0O.().SelectedIndex = num
			End If
		End Sub

		' Token: 0x06004AD7 RID: 19159 RVA: 0x001F83A0 File Offset: 0x001F65A0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001EA6 RID: 7846
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001EA7 RID: 7847
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001EA8 RID: 7848
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EA9 RID: 7849
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EAA RID: 7850
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x04001EAB RID: 7851
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EAC RID: 7852
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EAD RID: 7853
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001EAE RID: 7854
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EAF RID: 7855
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001EB0 RID: 7856
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EB1 RID: 7857
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EB2 RID: 7858
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EB3 RID: 7859
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EB4 RID: 7860
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001EB5 RID: 7861
		Private <<EMPTY_NAME>> As Application
	End Class
End Namespace
