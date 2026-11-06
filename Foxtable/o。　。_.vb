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
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200036D RID: 877
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3002_
		Inherits Form

		' Token: 0x06003741 RID: 14145 RVA: 0x00177658 File Offset: 0x00175858
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oooO_.o. IsNot Nothing Then
					Me.oooO_.o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003742 RID: 14146 RVA: 0x00177698 File Offset: 0x00175898
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O.00oOoo0___00.(New C1Button())
			Me.O._ooOoo0__o_0.(New C1Button())
			Me.oOOOoO0.0o0.(New C1Button())
			Me.o0.o__0o.(New C1Button())
			Me.O.00oOoo0___00.(New C1FlexGrid())
			Me.oO._O0.(New C1Button())
			Me.Oo.O_O0__0O_0.(New C1Button())
			Me.OOooOoO_.O.(New C1Button())
			Me.oo000_o__.O.(New C1Button())
			Me.o___0oO.0Oo0_0.(New C1Button())
			Me.OOoO_O_0_.O0o0.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0___O.O.().Location = New Point(322, 15)
			Me.O0___O.O.().Name = "btnAdd"
			Me.O0___O.O.().Size = New Size(82, 23)
			Me.O0___O.O.().TabIndex = 1
			Me.O0___O.O.().Text = "增加"
			Me.O0___O.O.().UseVisualStyleBackColor = True
			Me.O0oo_OO_.oO_oO.().Location = New Point(322, 44)
			Me.O0oo_OO_.oO_oO.().Name = "btnDelete"
			Me.O0oo_OO_.oO_oO.().Size = New Size(82, 23)
			Me.O0oo_OO_.oO_oO.().TabIndex = 2
			Me.O0oo_OO_.oO_oO.().Text = "删除"
			Me.O0oo_OO_.oO_oO.().UseVisualStyleBackColor = True
			Me.oo._ooO.().Location = New Point(322, 73)
			Me.oo._ooO.().Name = "btnEdit"
			Me.oo._ooO.().Size = New Size(82, 23)
			Me.oo._ooO.().TabIndex = 3
			Me.oo._ooO.().Text = "修改"
			Me.oo._ooO.().UseVisualStyleBackColor = True
			Me.O__.Oo.().Location = New Point(322, 160)
			Me.O__.Oo.().Name = "btnGroup"
			Me.O__.Oo.().Size = New Size(82, 23)
			Me.O__.Oo.().TabIndex = 6
			Me.O__.Oo.().Text = "组定义"
			Me.O__.Oo.().UseVisualStyleBackColor = True
			Me.OOoO_O_0_.O0o0.().AllowDragging = 0
			Me.OOoO_O_0_.O0o0.().AllowResizing = 0
			Me.OOoO_O_0_.O0o0.().AllowSorting = 0
			Me.OOoO_O_0_.O0o0.().BorderStyle = 4
			Me.OOoO_O_0_.O0o0.().ColumnInfo = "1,0,0,20,0,0,Columns:"
			Me.OOoO_O_0_.O0o0.().ExtendLastCol = True
			Me.OOoO_O_0_.O0o0.().FocusRect = 0
			Me.OOoO_O_0_.O0o0.().Location = New Point(13, 15)
			Me.OOoO_O_0_.O0o0.().Name = "lstUsers"
			Me.OOoO_O_0_.O0o0.().Rows.Count = 1
			Me.OOoO_O_0_.O0o0.().Rows.DefaultSize = 19
			Me.OOoO_O_0_.O0o0.().Rows.Fixed = 0
			Me.OOoO_O_0_.O0o0.().SelectionMode = 3
			Me.OOoO_O_0_.O0o0.().Size = New Size(292, 363)
			Me.OOoO_O_0_.O0o0.().TabIndex = 0
			Me.OOoO_O_0_.O0o0.().VisualStyle = 1
			Me.oO0O.O_o000Oo0.().Location = New Point(322, 102)
			Me.oO0O.O_o000Oo0.().Name = "btnDefault"
			Me.oO0O.O_o000Oo0.().Size = New Size(82, 23)
			Me.oO0O.O_o000Oo0.().TabIndex = 4
			Me.oO0O.O_o000Oo0.().Text = "默认用户"
			Me.oO0O.O_o000Oo0.().UseVisualStyleBackColor = True
			Me.OOoO_O_0_.O0o0.().Location = New Point(322, 131)
			Me.OOoO_O_0_.O0o0.().Name = "btnExtProperty"
			Me.OOoO_O_0_.O0o0.().Size = New Size(82, 23)
			Me.OOoO_O_0_.O0o0.().TabIndex = 5
			Me.OOoO_O_0_.O0o0.().Text = "扩展属性"
			Me.OOoO_O_0_.O0o0.().UseVisualStyleBackColor = True
			Me.oO_0oO._o.().Location = New Point(322, 189)
			Me.oO_0oO._o.().Name = "btnRole"
			Me.oO_0oO._o.().Size = New Size(82, 23)
			Me.oO_0oO._o.().TabIndex = 7
			Me.oO_0oO._o.().Text = "角色定义"
			Me.oO_0oO._o.().UseVisualStyleBackColor = True
			Me.OO0_OO0O0.00Oo.().Location = New Point(322, 218)
			Me.OO0_OO0O0.00Oo.().Name = "btnUserTable"
			Me.OO0_OO0O0.00Oo.().Size = New Size(82, 23)
			Me.OO0_OO0O0.00Oo.().TabIndex = 9
			Me.OO0_OO0O0.00Oo.().Text = "用户数据表"
			Me.OO0_OO0O0.00Oo.().UseVisualStyleBackColor = True
			Me.oo00__oo._o_O.().Location = New Point(322, 355)
			Me.oo00__oo._o_O.().Name = "Button2"
			Me.oo00__oo._o_O.().Size = New Size(82, 23)
			Me.oo00__oo._o_O.().TabIndex = 10
			Me.oo00__oo._o_O.().Text = "关闭"
			Me.oo00__oo._o_O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(418, 393)
			MyBase.Controls.Add(Me.oo00__oo._o_O.())
			MyBase.Controls.Add(Me.OO0_OO0O0.00Oo.())
			MyBase.Controls.Add(Me.oO_0oO._o.())
			MyBase.Controls.Add(Me.OOoO_O_0_.O0o0.())
			MyBase.Controls.Add(Me.oO0O.O_o000Oo0.())
			MyBase.Controls.Add(Me.OOoO_O_0_.O0o0.())
			MyBase.Controls.Add(Me.O__.Oo.())
			MyBase.Controls.Add(Me.oo._ooO.())
			MyBase.Controls.Add(Me.O0oo_OO_.oO_oO.())
			MyBase.Controls.Add(Me.O0___O.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.O.o..."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "用户管理"
			Me.OOoO_O_0_.O0o0.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003743 RID: 14147 RVA: 0x00177CCB File Offset: 0x00175ECB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OoO.0O.
		End Function

		' Token: 0x06003744 RID: 14148 RVA: 0x00177CD4 File Offset: 0x00175ED4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoO_o_ooo.0.
			Dim ooO.0O. As C1Button = Me.OoO.0O.
			If ooO.0O. IsNot Nothing Then
				RemoveHandler ooO.0O..Click, value
			End If
			Me.OoO.0O. = A_0
			ooO.0O. = Me.OoO.0O.
			If ooO.0O. IsNot Nothing Then
				AddHandler ooO.0O..Click, value
			End If
		End Sub

		' Token: 0x06003745 RID: 14149 RVA: 0x00177D17 File Offset: 0x00175F17
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOo_oo._O.
		End Function

		' Token: 0x06003746 RID: 14150 RVA: 0x00177D20 File Offset: 0x00175F20
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00O_._ooOo.
			Dim c1Button As C1Button = Me.oOo_oo._O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOo_oo._O. = A_0
			c1Button = Me.oOo_oo._O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003747 RID: 14151 RVA: 0x00177D63 File Offset: 0x00175F63
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0O.0OOOOoO0.
		End Function

		' Token: 0x06003748 RID: 14152 RVA: 0x00177D6C File Offset: 0x00175F6C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OooO.O_0o0.
			Dim o0O.0OOOOoO0. As C1Button = Me.O0O.0OOOOoO0.
			If o0O.0OOOOoO0. IsNot Nothing Then
				RemoveHandler o0O.0OOOOoO0..Click, value
			End If
			Me.O0O.0OOOOoO0. = A_0
			o0O.0OOOOoO0. = Me.O0O.0OOOOoO0.
			If o0O.0OOOOoO0. IsNot Nothing Then
				AddHandler o0O.0OOOOoO0..Click, value
			End If
		End Sub

		' Token: 0x06003749 RID: 14153 RVA: 0x00177DAF File Offset: 0x00175FAF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_OoO.O.
		End Function

		' Token: 0x0600374A RID: 14154 RVA: 0x00177DB8 File Offset: 0x00175FB8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_O0Oo_0_Oo.o.
			Dim c1Button As C1Button = Me.oO_OoO.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO_OoO.O. = A_0
			c1Button = Me.oO_OoO.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600374B RID: 14155 RVA: 0x00177DFB File Offset: 0x00175FFB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.OoO.0O.
		End Function

		' Token: 0x0600374C RID: 14156 RVA: 0x00177E04 File Offset: 0x00176004
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.OOoO_O_0_.O0o0.
			Dim ooO.0O. As C1FlexGrid = Me.OoO.0O.
			If ooO.0O. IsNot Nothing Then
				ooO.0O..OwnerDrawCell -= ownerDrawCellEventHandler
			End If
			Me.OoO.0O. = A_0
			ooO.0O. = Me.OoO.0O.
			If ooO.0O. IsNot Nothing Then
				ooO.0O..OwnerDrawCell += ownerDrawCellEventHandler
			End If
		End Sub

		' Token: 0x0600374D RID: 14157 RVA: 0x00177E47 File Offset: 0x00176047
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.OOO0.
		End Function

		' Token: 0x0600374E RID: 14158 RVA: 0x00177E50 File Offset: 0x00176050
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo.O0_0.
			Dim c1Button As C1Button = Me.o.OOO0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.OOO0. = A_0
			c1Button = Me.o.OOO0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600374F RID: 14159 RVA: 0x00177E93 File Offset: 0x00176093
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.OoO__O0o.
		End Function

		' Token: 0x06003750 RID: 14160 RVA: 0x00177E9C File Offset: 0x0017609C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0._O____OO_.
			Dim c1Button As C1Button = Me.o.OoO__O0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.OoO__O0o. = A_0
			c1Button = Me.o.OoO__O0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003751 RID: 14161 RVA: 0x00177EDF File Offset: 0x001760DF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_.0o0OOO_0.
		End Function

		' Token: 0x06003752 RID: 14162 RVA: 0x00177EE8 File Offset: 0x001760E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO0O.O_o000Oo0.
			Dim c1Button As C1Button = Me.o_.0o0OOO_0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_.0o0OOO_0. = A_0
			c1Button = Me.o_.0o0OOO_0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003753 RID: 14163 RVA: 0x00177F2B File Offset: 0x0017612B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.0o0.
		End Function

		' Token: 0x06003754 RID: 14164 RVA: 0x00177F34 File Offset: 0x00176134
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.O0Oo0_.
			Dim o.0o0. As C1Button = Me.O.0o0.
			If o.0o0. IsNot Nothing Then
				RemoveHandler o.0o0..Click, value
			End If
			Me.O.0o0. = A_0
			o.0o0. = Me.O.0o0.
			If o.0o0. IsNot Nothing Then
				AddHandler o.0o0..Click, value
			End If
		End Sub

		' Token: 0x06003755 RID: 14165 RVA: 0x00177F77 File Offset: 0x00176177
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.0O00oO.
		End Function

		' Token: 0x06003756 RID: 14166 RVA: 0x00177F80 File Offset: 0x00176180
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_.0_00oO_0.
			Dim c1Button As C1Button = Me.o.0O00oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.0O00oO. = A_0
			c1Button = Me.o.0O00oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003757 RID: 14167 RVA: 0x00177FC4 File Offset: 0x001761C4
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.O_.0_00oO_0.
			AddHandler MyBase.Load, AddressOf Me.o_OO.o__.
			Me.O__.Oo.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003758 RID: 14168 RVA: 0x00178018 File Offset: 0x00176218
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
			OO_00oOO.Users.ooo___o_0.__.()
			If Me.oooO_.o. IsNot O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()) Then
				Me.oooO_.o..ExtendedProperties.Clear()
				Me.oooO_.o..Reset()
				Me.oooO_.o..Dispose()
			End If
		End Sub

		' Token: 0x06003759 RID: 14169 RVA: 0x00178081 File Offset: 0x00176281
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OOoO_O_0_.O0o0.()
			If OO_00oOO.User.Type IsNot Nothing AndAlso OO_00oOO.User.Type <> 1 Then
				Me.OO0_OO0O0.00Oo.().Enabled = False
			End If
		End Sub

		' Token: 0x0600375A RID: 14170 RVA: 0x001780B0 File Offset: 0x001762B0
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.oooO_.o. = Nothing
				IL_10:
				num2 = 3
				Me.oooO_.o. = Nothing
				IL_19:
				num2 = 4
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.())
				IL_30:
				num2 = 5
				If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()).Rows.Count <> 0 Then
					GoTo IL_59
				End If
				IL_52:
				num2 = 6
				Oo00.o_o_oo.0o.()
				IL_59:
				num2 = 7
				Dim dataRow As DataRow = dataTable.Rows.Find(New Object() { "User", o0_O.o.0_O_O. })
				IL_80:
				num2 = 8
				If dataRow Is Nothing OrElse Operators.CompareString(dataRow("Config").ToString(), "1", True) <> 0 Then
					GoTo IL_AE
				End If
				IL_A4:
				num2 = 9
				Me.oooO_.o. = True
				IL_AE:
				num2 = 10
				If Not Me.oooO_.o. Then
					GoTo IL_550
				End If
				IL_BC:
				num2 = 11
				Dim text As String = ""
				IL_C6:
				num2 = 12
				Dim text2 As String = ""
				IL_D0:
				num2 = 13
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.Oo0_.o0. })
				IL_10B:
				num2 = 14
				If dataRow2 Is Nothing Then
					GoTo IL_128
				End If
				IL_112:
				num2 = 15
				text = dataRow2("Config").ToString()
				IL_128:
				num2 = 16
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "User", o0_O.OO_O.O0ooO0O. })
				IL_163:
				num2 = 17
				If dataRow2 Is Nothing Then
					GoTo IL_180
				End If
				IL_16A:
				num2 = 18
				text2 = dataRow2("Config").ToString()
				IL_180:
				num2 = 19
				If Operators.CompareString(text, "", True) <= 0 OrElse Operators.CompareString(text2, "", True) <= 0 Then
					GoTo IL_531
				End If
				IL_1A9:
				num2 = 20
				If Not O_O0OO.O._o_.().ContainsKey(text) Then
					GoTo IL_291
				End If
				IL_1BD:
				num2 = 21
				Me.oooO_.o. = O_O0OO.O._o_.()(text)
				IL_1D2:
				num2 = 22
				Me.oooO_.o. = New DataTable()
				IL_1E0:
				num2 = 23
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()(text)) Then
					GoTo IL_214
				End If
				IL_1F6:
				num2 = 24
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("Select * From " + text2, Me.oooO_.o.)
				GoTo IL_257
				IL_214:
				num2 = 26
				If text2.StartsWith("[") Then
					GoTo IL_23B
				End If
				IL_225:
				num2 = 27
				text2 = "[" + text2 + "]"
				IL_23B:
				num2 = 28
				oleDbDataAdapter = New OleDbDataAdapter("Select * From " + text2, Me.oooO_.o.)
				IL_257:
				num2 = 29
				oleDbDataAdapter.Fill(Me.oooO_.o.)
				IL_268:
				num2 = 30
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
				IL_272:
				num2 = 31
				Me.oooO_.o..ExtendedProperties.Add("DataAdapter", oleDbDataAdapter)
				GoTo IL_400
				IL_291:
				num2 = 33
				If Not O_O0OO.OoO__.0oO0oo.().ContainsKey(text) Then
					GoTo IL_400
				End If
				IL_2A5:
				num2 = 34
				Me.oooO_.o. = O_O0OO.OoO__.0oO0oo.()(text)
				IL_2BA:
				num2 = 35
				If Me.oooO_.o..OO.OoO0. <> DataServerTypeEnum.Oracle Then
					GoTo IL_2DE
				End If
				IL_2CB:
				num2 = 36
				Dim a_ As String = "Select * From " + text2
				GoTo IL_316
				IL_2DE:
				num2 = 38
				If text2.StartsWith("[") Then
					GoTo IL_305
				End If
				IL_2EF:
				num2 = 39
				text2 = "[" + text2 + "]"
				IL_305:
				num2 = 40
				a_ = "Select * From " + text2
				IL_316:
				num2 = 41
				Dim httpClient As HttpClient = Me.oooO_.o..oO0_0.o.()
				IL_326:
				num2 = 42
				Dim dictionary As Dictionary(Of String, String) = httpClient.FormData
				Dim key As String = "Action"
				Dim num3 As Integer = 1
				dictionary(key) = num3.ToString()
				IL_344:
				num2 = 43
				httpClient.[Select] = a_
				IL_350:
				num2 = 44
				Me.oooO_.o. = httpClient.GetBaseDataTable()
				IL_360:
				num2 = 45
				Dim dataTable2 As DataTable = New DataTable(Me.oooO_.o., Nothing, Nothing, text2, Nothing)
				IL_375:
				num2 = 46
				dataTable2.ConnectionName = text
				IL_381:
				num2 = 47
				dataTable2.DataServer = httpClient.Oo_0oO0Oo0_.O_.
				IL_392:
				num2 = 48
				dataTable2.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.
				IL_3A3:
				num2 = 49
				dataTable2.HttpSelect = a_
				IL_3AF:
				num2 = 50
				dataTable2.UpdateColumns = CType(Me.oooO_.o..ExtendedProperties("UpdateColumns"), List(Of String))
				IL_3D3:
				num2 = 51
				Me.oooO_.o..ExtendedProperties.Clear()
				IL_3E6:
				num2 = 52
				Me.oooO_.o..ExtendedProperties.Add("WebUpdater", dataTable2)
				IL_400:
				num2 = 53
				Me.oooO_.o..Columns.Add("Row", GetType(DataRow))
				IL_423:
				num2 = 54
				Dim array As DataRow() = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()).[Select]("[Type] = " + Conversions.ToString(0) + " Or [Type] = " + Conversions.ToString(1))
				IL_45C:
				num2 = 55
				num3 = array.Length - 1
				For i As Integer = 0 To num3
					IL_46F:
					num2 = 56
					Dim dataRow3 As DataRow = array(i)
					IL_479:
					num2 = 57
					Dim dataRow4 As DataRow = Me.oooO_.o..NewRow()
					IL_489:
					num2 = 58
					dataRow4("Name") = RuntimeHelpers.GetObjectValue(dataRow3("Name"))
					IL_4A9:
					num2 = 59
					dataRow4("Type") = RuntimeHelpers.GetObjectValue(dataRow3("Type"))
					IL_4C9:
					num2 = 60
					dataRow4("Config") = RuntimeHelpers.GetObjectValue(dataRow3("Config"))
					IL_4E9:
					num2 = 61
					dataRow4("Row") = dataRow3
					IL_4FA:
					num2 = 62
					Me.oooO_.o..Rows.Add(dataRow4)
					IL_50F:
					num2 = 63
				Next
				IL_521:
				num2 = 64
				Me.oooO_.o..AcceptChanges()
				GoTo IL_56D
				IL_531:
				num2 = 66
				Me.oooO_.o. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
				GoTo IL_56D
				IL_550:
				num2 = 68
				Me.oooO_.o. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
				IL_56D:
				num2 = 69
				Dim dataView As DataView = New DataView(Me.oooO_.o., "[Type] <= " + Conversions.ToString(4), "[Type]", DataViewRowState.CurrentRows)
				IL_594:
				num2 = 70
				If OO_00oOO.User.Type <> 2 AndAlso OO_00oOO.User.Type <> 4 Then
					GoTo IL_5FA
				End If
				IL_5B1:
				num2 = 71
				dataView.RowFilter = "[Name] = '" + OO_00oOO.User.Name + "' And [Type] <= " + Conversions.ToString(4)
				IL_5DA:
				num2 = 72
				Me.O0___O.O.().Enabled = False
				IL_5E9:
				num2 = 73
				Me.O0oo_OO_.oO_oO.().Enabled = False
				GoTo IL_628
				IL_5FA:
				num2 = 75
				dataView.RowFilter = "[Type] >= " + Conversions.ToString(OO_00oOO.User.Type) + " And [Type] <= " + Conversions.ToString(4)
				IL_628:
				num2 = 76
				Me.oO0O.O_o000Oo0.().Enabled = (OO_00oOO.User.Type = 0)
				IL_643:
				num2 = 77
				Me.OOoO_O_0_.O0o0.().Enabled = (OO_00oOO.User.Type = 0)
				IL_65E:
				num2 = 78
				Me.oO_0oO._o.().Enabled = (OO_00oOO.User.Type = 0)
				IL_679:
				num2 = 79
				Me.O__.Oo.().Enabled = (OO_00oOO.User.Type = 0)
				IL_694:
				num2 = 80
				Me.OO0_OO0O0.00Oo.().Enabled = (OO_00oOO.User.Type = 0)
				IL_6AF:
				num2 = 81
				Me.OOoO_O_0_.O0o0.().DataSource = dataView
				IL_6BF:
				num2 = 82
				Me.OOoO_O_0_.O0o0.().Styles.Normal.Border.Style = 0
				IL_6DD:
				num2 = 83
				For j As Integer = Me.OOoO_O_0_.O0o0.().Cols.Count - 1 To 0 Step -1
					IL_6F6:
					num2 = 84
					If Operators.CompareString(Me.OOoO_O_0_.O0o0.().Cols(j).Name, "Name", True) <> 0 Then
						IL_71D:
						num2 = 85
						Me.OOoO_O_0_.O0o0.().Cols.Remove(j)
					Else
						IL_735:
						num2 = 87
						Me.OOoO_O_0_.O0o0.().AllowEditing = False
					End If
					IL_744:
					num2 = 88
				Next
				IL_752:
				num2 = 89
				Me.OOoO_O_0_.O0o0.().DrawMode = 1
				IL_761:
				GoTo IL_91B
				IL_766:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_8DC:
				GoTo IL_910
				IL_8DE:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_8EE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_8DE
			End Try
			IL_910:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_91B:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600375B RID: 14171 RVA: 0x001789FC File Offset: 0x00176BFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New O\u3000\u3002O(5, Me.oooO_.o.).ShowDialog()
		End Sub

		' Token: 0x0600375C RID: 14172 RVA: 0x00178A10 File Offset: 0x00176C10
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New O\u3000o\u3000\u300200\u3002\u3000\u3000(Nothing, Me.oooO_.o.) With { .Text = "新增用户" }.ShowDialog()
			OO_00oOO.Users.ooo___o_0.__.()
		End Sub

		' Token: 0x0600375D RID: 14173 RVA: 0x00178A3C File Offset: 0x00176C3C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OOoO_O_0_.O0o0.().Row >= 0 Then
				Dim dataRowView As DataRowView = CType(Me.OOoO_O_0_.O0o0.().Rows(Me.OOoO_O_0_.O0o0.().Row).DataSource, DataRowView)
				Dim userTypeEnum As UserTypeEnum = Conversions.ToInteger(dataRowView("Type"))
				If userTypeEnum = 1 OrElse userTypeEnum Is Nothing Then
					MessageBox.Show("不能删除系统用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If OO_00oOO.Users.ooo___o_0.__..ContainsKey(dataRowView.Row) Then
					OO_00oOO.Users.ooo___o_0.__..Remove(dataRowView.Row)
				End If
				dataRowView.Delete()
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()), True)
				If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()) IsNot Me.oooO_.o. AndAlso Me.oooO_.o. IsNot Nothing Then
					Oo00.o0_o._O_.(Me.oooO_.o., True)
				End If
			End If
		End Sub

		' Token: 0x0600375E RID: 14174 RVA: 0x00178B2C File Offset: 0x00176D2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OOoO_O_0_.O0o0.().Row >= 0 Then
				Dim row As DataRow = CType(Me.OOoO_O_0_.O0o0.().Rows(Me.OOoO_O_0_.O0o0.().Row).DataSource, DataRowView).Row
				New O\u3000o\u3000\u300200\u3002\u3000\u3000(row, Me.oooO_.o.).ShowDialog()
				If OO_00oOO.Users.ooo___o_0.__..ContainsKey(row) Then
					OO_00oOO.Users.ooo___o_0.__..Remove(row)
				End If
			End If
		End Sub

		' Token: 0x0600375F RID: 14175 RVA: 0x00178BA8 File Offset: 0x00176DA8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.OOoO_O_0_.O0o0.().Row < 0 Then
					GoTo IL_1CC
				End If
				IL_1A:
				num2 = 3
				Dim row As DataRow = CType(Me.OOoO_O_0_.O0o0.().Rows(Me.OOoO_O_0_.O0o0.().Row).DataSource, DataRowView).Row
				IL_47:
				num2 = 4
				Dim userTypeEnum As UserTypeEnum = Conversions.ToInteger(row("Type"))
				IL_5B:
				num2 = 5
				If userTypeEnum <> 1 AndAlso userTypeEnum IsNot Nothing Then
					GoTo IL_80
				End If
				IL_66:
				num2 = 6
				MessageBox.Show("开发者和管理员不能作为默认用户使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_1CC
				IL_80:
				num2 = 8
				If userTypeEnum <> 4 Then
					GoTo IL_A0
				End If
				IL_87:
				num2 = 9
				row("Type") = 2
				GoTo IL_16B
				IL_A0:
				num2 = 11
				If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()) Is Me.oooO_.o. OrElse Me.oooO_.o. Is Nothing Then
					GoTo IL_E2
				End If
				IL_C7:
				num2 = 12
				MessageBox.Show("使用外部数据表存储用户信息时，不能设置默认用户!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_16B
				IL_E2:
				num2 = 14
				Dim enumerator As IEnumerator = row.Table.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_107:
					num2 = 15
					If Conversions.ToInteger(dataRow("Type")) = 4 Then
						IL_11E:
						num2 = 16
						dataRow("Type") = 2
					End If
					IL_133:
					num2 = 17
				End While
				IL_13F:
				num2 = 18
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_157:
				num2 = 19
				row("Type") = 4
				IL_16B:
				num2 = 20
				Me.OOoO_O_0_.O0o0.().Refresh()
				IL_179:
				num2 = 21
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()), True)
				IL_196:
				num2 = 22
				If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()) Is Me.oooO_.o. OrElse Me.oooO_.o. Is Nothing Then
					GoTo IL_1CC
				End If
				IL_1BD:
				num2 = 23
				Oo00.o0_o._O_.(Me.oooO_.o., True)
				IL_1CC:
				GoTo IL_27E
				IL_1D1:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_23F:
				GoTo IL_273
				IL_241:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_251:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_241
			End Try
			IL_273:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_27E:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003760 RID: 14176 RVA: 0x00178E58 File Offset: 0x00177058
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If A_1.Row >= 0 AndAlso Me.OOoO_O_0_.O0o0.().Rows(A_1.Row).DataSource IsNot Nothing Then
				Dim row As DataRow = CType(Me.OOoO_O_0_.O0o0.().Rows(A_1.Row).DataSource, DataRowView).Row
				If Conversions.ToInteger(row("Type")) = 4 Then
					A_1.Text = row("Name").ToString() + "(默认)"
				End If
			End If
		End Sub

		' Token: 0x06003761 RID: 14177 RVA: 0x00178EE4 File Offset: 0x001770E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000(Me.oooO_.o.).ShowDialog()
		End Sub

		' Token: 0x06003762 RID: 14178 RVA: 0x00178EF7 File Offset: 0x001770F7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New O\u3000\u3002O(6, Me.oooO_.o.).ShowDialog()
		End Sub

		' Token: 0x06003763 RID: 14179 RVA: 0x00178F0B File Offset: 0x0017710B
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If New o\u30000\u3002\u3000\u3000\u3000().ShowDialog() = DialogResult.OK Then
				Me.OOoO_O_0_.O0o0.()
			End If
		End Sub

		' Token: 0x06003764 RID: 14180 RVA: 0x00178F20 File Offset: 0x00177120
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x040016C5 RID: 5829
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040016C6 RID: 5830
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016C7 RID: 5831
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016C8 RID: 5832
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016C9 RID: 5833
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016CA RID: 5834
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040016CB RID: 5835
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016CC RID: 5836
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016CD RID: 5837
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016CE RID: 5838
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016CF RID: 5839
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016D0 RID: 5840
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040016D1 RID: 5841
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040016D2 RID: 5842
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040016D3 RID: 5843
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x040016D4 RID: 5844
		Private <<EMPTY_NAME>> As O0O
	End Class
End Namespace
