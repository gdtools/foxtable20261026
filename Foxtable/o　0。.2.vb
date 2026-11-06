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
	' Token: 0x02000197 RID: 407
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class o\u30000\u3002\u3000\u3000\u3000
		Inherits Form

		' Token: 0x06001360 RID: 4960 RVA: 0x0007D8E0 File Offset: 0x0007BAE0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOooooo.OO00. IsNot Nothing Then
					Me.oOooooo.OO00..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001361 RID: 4961 RVA: 0x0007D920 File Offset: 0x0007BB20
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Oo__.o.(New Label())
			Me.O_.O0o.(New C1ComboBox())
			Me.oOO0OOo._OO.(New Label())
			Me.oOO0OOo._OO.(New C1ComboBox())
			Me.oOO0OOo._OO.(New C1Button())
			Me.O_.O0o.(New C1Button())
			Me.oOO0OOo._OO.(New C1CheckBox())
			MyBase.SuspendLayout()
			Me.oOO0OOo._OO.().AutoSize = True
			Me.oOO0OOo._OO.().Location = New Point(23, 56)
			Me.oOO0OOo._OO.().Name = "Label2"
			Me.oOO0OOo._OO.().Size = New Size(47, 12)
			Me.oOO0OOo._OO.().TabIndex = 1
			Me.oOO0OOo._OO.().Text = "数据源:"
			Me.Oo.0o_0__oOOo.().DropDownStyle = 1
			Me.Oo.0o_0__oOOo.().Enabled = False
			Me.Oo.0o_0__oOOo.().Location = New Point(25, 77)
			Me.Oo.0o_0__oOOo.().Name = "cmbDataSource"
			Me.Oo.0o_0__oOOo.().Size = New Size(262, 20)
			Me.Oo.0o_0__oOOo.().TabIndex = 2
			Me.O_.O0o.().AutoSize = True
			Me.O_.O0o.().Location = New Point(23, 113)
			Me.O_.O0o.().Name = "Label10"
			Me.O_.O0o.().Size = New Size(47, 12)
			Me.O_.O0o.().TabIndex = 3
			Me.O_.O0o.().Text = "数据表:"
			Me.oOO0OOo._OO.().DropDownStyle = 1
			Me.oOO0OOo._OO.().Enabled = False
			Me.oOO0OOo._OO.().Location = New Point(25, 134)
			Me.oOO0OOo._OO.().Name = "cmbDataTable"
			Me.oOO0OOo._OO.().Size = New Size(262, 20)
			Me.oOO0OOo._OO.().TabIndex = 4
			Me.O.OoOO_OO.().Location = New Point(67, 176)
			Me.O.OoOO_OO.().Name = "btnOK"
			Me.O.OoOO_OO.().Size = New Size(75, 23)
			Me.O.OoOO_OO.().TabIndex = 5
			Me.O.OoOO_OO.().Text = "确定"
			Me.O.OoOO_OO.().UseVisualStyleBackColor = True
			Me.Oo.0o_0__oOOo.().Location = New Point(158, 176)
			Me.Oo.0o_0__oOOo.().Name = "btnCancel"
			Me.Oo.0o_0__oOOo.().Size = New Size(75, 23)
			Me.Oo.0o_0__oOOo.().TabIndex = 6
			Me.Oo.0o_0__oOOo.().Text = "取消"
			Me.Oo.0o_0__oOOo.().UseVisualStyleBackColor = True
			Me.O.OoOO_OO.().AutoSize = True
			Me.O.OoOO_OO.().Location = New Point(25, 23)
			Me.O.OoOO_OO.().Name = "CheckBox1"
			Me.O.OoOO_OO.().Size = New Size(180, 16)
			Me.O.OoOO_OO.().TabIndex = 0
			Me.O.OoOO_OO.().Text = "使用外部数据表存储用户信息"
			Me.O.OoOO_OO.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(307, 211)
			MyBase.Controls.Add(Me.O.OoOO_OO.())
			MyBase.Controls.Add(Me.Oo.0o_0__oOOo.())
			MyBase.Controls.Add(Me.O.OoOO_OO.())
			MyBase.Controls.Add(Me.oOO0OOo._OO.())
			MyBase.Controls.Add(Me.Oo.0o_0__oOOo.())
			MyBase.Controls.Add(Me.O_.O0o.())
			MyBase.Controls.Add(Me.oOO0OOo._OO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o..00o.."
			Me.Text = "选择用户数据表"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06001362 RID: 4962 RVA: 0x0007DD19 File Offset: 0x0007BF19
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOooooo.OO00.
		End Function

		' Token: 0x06001363 RID: 4963 RVA: 0x0007DD21 File Offset: 0x0007BF21
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOooooo.OO00. = A_0
		End Sub

		' Token: 0x06001364 RID: 4964 RVA: 0x0007DD2A File Offset: 0x0007BF2A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oOooooo.OO00.
		End Function

		' Token: 0x06001365 RID: 4965 RVA: 0x0007DD34 File Offset: 0x0007BF34
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0ooo0._.
			Dim c1ComboBox As C1ComboBox = Me.oOooooo.OO00.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.oOooooo.OO00. = A_0
			c1ComboBox = Me.oOooooo.OO00.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06001366 RID: 4966 RVA: 0x0007DD77 File Offset: 0x0007BF77
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo__.o.
		End Function

		' Token: 0x06001367 RID: 4967 RVA: 0x0007DD7F File Offset: 0x0007BF7F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo__.o. = A_0
		End Sub

		' Token: 0x06001368 RID: 4968 RVA: 0x0007DD88 File Offset: 0x0007BF88
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oo__.o.
		End Function

		' Token: 0x06001369 RID: 4969 RVA: 0x0007DD90 File Offset: 0x0007BF90
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.Oo__.o. = A_0
		End Sub

		' Token: 0x0600136A RID: 4970 RVA: 0x0007DD99 File Offset: 0x0007BF99
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOooooo.OO00.
		End Function

		' Token: 0x0600136B RID: 4971 RVA: 0x0007DDA4 File Offset: 0x0007BFA4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo.0o_0__oOOo.
			Dim c1Button As C1Button = Me.oOooooo.OO00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOooooo.OO00. = A_0
			c1Button = Me.oOooooo.OO00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600136C RID: 4972 RVA: 0x0007DDE7 File Offset: 0x0007BFE7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo__.o.
		End Function

		' Token: 0x0600136D RID: 4973 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.0O0_O00.
			Dim oo__.o. As C1Button = Me.Oo__.o.
			If oo__.o. IsNot Nothing Then
				RemoveHandler oo__.o..Click, value
			End If
			Me.Oo__.o. = A_0
			oo__.o. = Me.Oo__.o.
			If oo__.o. IsNot Nothing Then
				AddHandler oo__.o..Click, value
			End If
		End Sub

		' Token: 0x0600136E RID: 4974 RVA: 0x0007DE33 File Offset: 0x0007C033
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oOooooo.OO00.
		End Function

		' Token: 0x0600136F RID: 4975 RVA: 0x0007DE3C File Offset: 0x0007C03C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.O.OoOO_OO.
			Dim c1CheckBox As C1CheckBox = Me.oOooooo.OO00.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.oOooooo.OO00. = A_0
			c1CheckBox = Me.oOooooo.OO00.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06001370 RID: 4976 RVA: 0x0007DE80 File Offset: 0x0007C080
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oo_oOO._.
			AddHandler MyBase.FormClosed, AddressOf Me.O.OoOO_OO.
			Me.OoO_O0o.O0__O. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.())
			Me.oOO0OOo._OO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06001371 RID: 4977 RVA: 0x0007DEEC File Offset: 0x0007C0EC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.Oo.0o_0__oOOo.().ItemsDataSource = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.())
				IL_28:
				num2 = 3
				Me.Oo.0o_0__oOOo.().ItemsDisplayMember = "Name"
				IL_3A:
				num2 = 4
				Me.Oo.0o_0__oOOo.().TranslateValue = True
				IL_48:
				num2 = 5
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.o.0_O_O. })
				IL_81:
				num2 = 6
				If dataRow Is Nothing OrElse Operators.CompareString(dataRow("Config").ToString(), "1", True) <> 0 Then
					GoTo IL_234
				End If
				IL_A9:
				num2 = 7
				Me.O.OoOO_OO.().Checked = True
				IL_B7:
				num2 = 8
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.Oo0_.o0. })
				IL_F0:
				num2 = 9
				If dataRow Is Nothing Then
					GoTo IL_17E
				End If
				IL_F9:
				num2 = 10
				Dim right As String = dataRow("Config").ToString()
				IL_10E:
				num2 = 11
				Dim num3 As Integer = Me.Oo.0o_0__oOOo.().Items.Count - 1
				For i As Integer = 0 To num3
					IL_12A:
					num2 = 12
					If Operators.CompareString(CType(Me.Oo.0o_0__oOOo.().Items(i), DataRowView)("Name").ToString(), right, True) = 0 Then
						IL_15D:
						num2 = 13
						Me.Oo.0o_0__oOOo.().SelectedIndex = i
						Exit For
					End If
					IL_16F:
					num2 = 15
				Next
				IL_17E:
				num2 = 16
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.OO_O.O0ooO0O. })
				IL_1B8:
				num2 = 17
				If dataRow Is Nothing Then
					GoTo IL_234
				End If
				IL_1BE:
				num2 = 18
				Dim right2 As String = dataRow("Config").ToString()
				IL_1D3:
				num2 = 19
				Dim num4 As Integer = Me.oOO0OOo._OO.().Items.Count - 1
				For j As Integer = 0 To num4
					IL_1EF:
					num2 = 20
					If Operators.CompareString(Me.oOO0OOo._OO.().Items(j).ToString(), right2, True) = 0 Then
						IL_213:
						num2 = 21
						Me.oOO0OOo._OO.().SelectedIndex = j
						Exit For
					End If
					IL_225:
					num2 = 23
				Next
				IL_234:
				GoTo IL_2E6
				IL_239:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_2A7:
				GoTo IL_2DB
				IL_2A9:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2B9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2A9
			End Try
			IL_2DB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2E6:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001372 RID: 4978 RVA: 0x0007E204 File Offset: 0x0007C404
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Oo.0o_0__oOOo.().SelectedItem Is Nothing Then
				Me.oOO0OOo._OO.().Items.Clear()
				Return
			End If
			Dim row As DataRow = CType(Me.Oo.0o_0__oOOo.().SelectedItem, DataRowView).Row
			Me.oOO0OOo._OO.().Items.Clear()
			If Not row.IsNull("ConnectionString") Then
				Try
					Dim list As List(Of String) = CType(OO_00oOO.Connections(Conversions.ToString(row("Name"))).GetTableNames(), List(Of String))
					Try
						For Each text As String In list
							If Not MyBase.Name.StartsWith("~") Then
								Me.oOO0OOo._OO.().Items.Add(text)
							End If
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
		End Sub

		' Token: 0x06001373 RID: 4979 RVA: 0x0007E314 File Offset: 0x0007C514
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06001374 RID: 4980 RVA: 0x0007E320 File Offset: 0x0007C520
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.O.OoOO_OO.().Checked OrElse (Operators.CompareString(Me.Oo.0o_0__oOOo.().Text, "", True) <> 0 AndAlso Operators.CompareString(Me.oOO0OOo._OO.().Text, "", True) <> 0) Then
					GoTo IL_60
				End If
				IL_46:
				num2 = 3
				MessageBox.Show("请选择数据源和数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_6C4
				IL_60:
				num2 = 5
				If Not Me.O.OoOO_OO.().Checked Then
					GoTo IL_5B9
				End If
				IL_72:
				num2 = 6
				Dim dataTable As DataTable = New DataTable()
				IL_7A:
				num2 = 7
				If Not O_O0OO.O._o_.().ContainsKey(Me.Oo.0o_0__oOOo.().Text) Then
					GoTo IL_15C
				End If
				IL_96:
				num2 = 8
				Me.oOooooo.OO00. = O_O0OO.O._o_.()(Me.Oo.0o_0__oOOo.().Text)
				IL_B3:
				num2 = 9
				Dim text As String = Me.oOO0OOo._OO.().Text
				IL_C3:
				num2 = 10
				If text.StartsWith("[") OrElse text.EndsWith("]") Then
					GoTo IL_101
				End If
				IL_E2:
				num2 = 12
				text = "[" + Me.oOO0OOo._OO.().Text + "]"
				IL_101:
				num2 = 13
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("Select * From " + text, Me.oOooooo.OO00.)
				IL_11D:
				num2 = 14
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_12A:
				num2 = 15
				If Information.Err().Number = 0 AndAlso dataTable IsNot Nothing Then
					GoTo IL_1A0
				End If
				IL_13C:
				num2 = 16
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_6C4
				IL_15C:
				num2 = 19
				If Not O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.Oo.0o_0__oOOo.().Text) Then
					GoTo IL_1A0
				End If
				IL_176:
				num2 = 20
				dataTable = O_O0OO.OoO__.0oO0oo.()(Me.Oo.0o_0__oOOo.().Text).O_0_O_0_o_.0.(Me.oOO0OOo._OO.().Text, False)
				IL_1A0:
				num2 = 21
				If Not dataTable.Columns.Contains("Name") OrElse Not dataTable.Columns.Contains("Type") OrElse Not dataTable.Columns.Contains("Config") Then
					GoTo IL_59E
				End If
				IL_1E2:
				num2 = 22
				If dataTable.PrimaryKey.Length <> 1 OrElse ((dataTable.PrimaryKey(0).DataType IsNot GetType(String) OrElse Operators.CompareString(dataTable.PrimaryKey(0).ColumnName, "Name", True) <> 0) AndAlso Not dataTable.PrimaryKey(0).AutoIncrement) Then
					GoTo IL_59E
				End If
				IL_238:
				num2 = 23
				If dataTable.Columns("Type").DataType IsNot GetType(Integer) AndAlso dataTable.Columns("Type").DataType IsNot GetType(Short) AndAlso dataTable.Columns("Type").DataType IsNot GetType(Long) Then
					GoTo IL_59E
				End If
				IL_2A1:
				num2 = 24
				If dataTable.Columns("Name").DataType IsNot GetType(String) OrElse dataTable.Columns("Config").DataType IsNot GetType(String) OrElse (dataTable.Columns("Config").MaxLength <> -1 AndAlso dataTable.Columns("Config").MaxLength <= 255) Then
					GoTo IL_59E
				End If
				IL_323:
				num2 = 25
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.o.0_O_O. })
				IL_35E:
				num2 = 26
				If dataRow IsNot Nothing Then
					GoTo IL_3D0
				End If
				IL_365:
				num2 = 27
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_383:
				num2 = 28
				dataRow("Name") = "User"
				IL_397:
				num2 = 29
				dataRow("Type") = o0_O.o.0_O_O.
				IL_3AD:
				num2 = 30
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow)
				IL_3D0:
				num2 = 31
				dataRow("Config") = "1"
				IL_3E4:
				num2 = 32
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.Oo0_.o0. })
				IL_41F:
				num2 = 33
				If dataRow IsNot Nothing Then
					GoTo IL_491
				End If
				IL_426:
				num2 = 34
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_444:
				num2 = 35
				dataRow("Name") = "User"
				IL_458:
				num2 = 36
				dataRow("Type") = o0_O.Oo0_.o0.
				IL_46E:
				num2 = 37
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow)
				IL_491:
				num2 = 38
				dataRow("Config") = Me.Oo.0o_0__oOOo.().Text
				IL_4AB:
				num2 = 39
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.OO_O.O0ooO0O. })
				IL_4E6:
				num2 = 40
				If dataRow IsNot Nothing Then
					GoTo IL_558
				End If
				IL_4ED:
				num2 = 41
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_50B:
				num2 = 42
				dataRow("Name") = "User"
				IL_51F:
				num2 = 43
				dataRow("Type") = o0_O.OO_O.O0ooO0O.
				IL_535:
				num2 = 44
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow)
				IL_558:
				num2 = 45
				dataRow("Config") = Me.oOO0OOo._OO.().Text
				IL_572:
				num2 = 46
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
				IL_58F:
				num2 = 47
				MyBase.DialogResult = DialogResult.OK
				GoTo IL_6C4
				IL_59E:
				num2 = 49
				MessageBox.Show("所有用户表的结构不符合规范！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_6C4
				IL_5B9:
				num2 = 51
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.o.0_O_O. })
				IL_5F4:
				num2 = 52
				If dataRow2 Is Nothing Then
					GoTo IL_605
				End If
				IL_5FB:
				num2 = 53
				dataRow2.Delete()
				IL_605:
				num2 = 54
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.Oo0_.o0. })
				IL_640:
				num2 = 55
				If dataRow2 Is Nothing Then
					GoTo IL_651
				End If
				IL_647:
				num2 = 56
				dataRow2.Delete()
				IL_651:
				num2 = 57
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.OO_O.O0ooO0O. })
				IL_68C:
				num2 = 58
				If dataRow2 Is Nothing Then
					GoTo IL_69D
				End If
				IL_693:
				num2 = 59
				dataRow2.Delete()
				IL_69D:
				num2 = 60
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
				IL_6BA:
				num2 = 61
				MyBase.DialogResult = DialogResult.OK
				IL_6C4:
				GoTo IL_80E
				IL_6C9:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_7CF:
				GoTo IL_803
				IL_7D1:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7E1:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7D1
			End Try
			IL_803:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_80E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001375 RID: 4981 RVA: 0x0007EB60 File Offset: 0x0007CD60
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Oo.0o_0__oOOo.().Enabled = Me.O.OoOO_OO.().Checked
			Me.oOO0OOo._OO.().Enabled = Me.O.OoOO_OO.().Checked
		End Sub

		' Token: 0x06001376 RID: 4982 RVA: 0x0007EB8E File Offset: 0x0007CD8E
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040007A3 RID: 1955
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040007A4 RID: 1956
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040007A5 RID: 1957
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040007A6 RID: 1958
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040007A7 RID: 1959
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040007A8 RID: 1960
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040007A9 RID: 1961
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040007AA RID: 1962
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040007AB RID: 1963
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x040007AC RID: 1964
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
