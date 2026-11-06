Imports System
Imports System.Collections
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
	' Token: 0x02000381 RID: 897
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000
		Inherits Form

		' Token: 0x06003981 RID: 14721 RVA: 0x0018DC04 File Offset: 0x0018BE04
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O00.OO_0_. IsNot Nothing Then
					Me.O00.OO_0_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003982 RID: 14722 RVA: 0x0018DC44 File Offset: 0x0018BE44
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Ooo_.0__O_o_.(New Label())
			Me.o_.0O0.(New C1Button())
			Me.o_Ooo._Oooo_0.(New C1Button())
			Me.o_oo0.o_.(New C1Button())
			Me.O0._Oo.(New Label())
			Me.Ooo_.0__O_o_.(New C1ComboBox())
			Me.o0OOo0oo._O_.(New Label())
			Me.Ooo_.0__O_o_.(New oO_oO000oo())
			Me.O.O0000.().BeginInit()
			Me.O0.0O0.().BeginInit()
			Me.o_oo0.o_.().BeginInit()
			Me.o_oo0.o_.().BeginInit()
			MyBase.SuspendLayout()
			Me.o_Ooo._Oooo_0.().AutoSize = True
			Me.o_Ooo._Oooo_0.().Location = New Point(14, 63)
			Me.o_Ooo._Oooo_0.().Name = "Label2"
			Me.o_Ooo._Oooo_0.().Size = New Size(95, 12)
			Me.o_Ooo._Oooo_0.().TabIndex = 3
			Me.o_Ooo._Oooo_0.().Text = "请输入查询语句:"
			Me.O.O0000.().Location = New Point(291, 353)
			Me.O.O0000.().Name = "btnOk"
			Me.O.O0000.().Size = New Size(75, 23)
			Me.O.O0000.().TabIndex = 2
			Me.O.O0000.().Text = "确定"
			Me.O.O0000.().UseVisualStyleBackColor = True
			Me.O0.0O0.().DialogResult = DialogResult.Cancel
			Me.O0.0O0.().Location = New Point(372, 353)
			Me.O0.0O0.().Name = "btnCancel"
			Me.O0.0O0.().Size = New Size(75, 23)
			Me.O0.0O0.().TabIndex = 3
			Me.O0.0O0.().Text = "取消"
			Me.O0.0O0.().UseVisualStyleBackColor = True
			Me.o_oo0.o_.().Location = New Point(12, 352)
			Me.o_oo0.o_.().Name = "btnPreview"
			Me.o_oo0.o_.().Size = New Size(75, 23)
			Me.o_oo0.o_.().TabIndex = 4
			Me.o_oo0.o_.().Text = "预览"
			Me.o_oo0.o_.().UseVisualStyleBackColor = True
			Me.o_oo0.o_.().AutoSize = True
			Me.o_oo0.o_.().Location = New Point(14, 13)
			Me.o_oo0.o_.().Name = "Label1"
			Me.o_oo0.o_.().Size = New Size(83, 12)
			Me.o_oo0.o_.().TabIndex = 1
			Me.o_oo0.o_.().Text = "请选择数据源:"
			Me.o_oo0.o_.().AllowSpinLoop = False
			Me.o_oo0.o_.().Cursor = Cursors.Arrow
			Me.o_oo0.o_.().DropDownStyle = 1
			Me.o_oo0.o_.().GapHeight = 0
			Me.o_oo0.o_.().ImagePadding = New Padding(0, 0, 0, 0)
			Me.o_oo0.o_.().ItemsDisplayMember = ""
			Me.o_oo0.o_.().ItemsValueMember = ""
			Me.o_oo0.o_.().Location = New Point(14, 34)
			Me.o_oo0.o_.().Name = "cmbDataSource"
			Me.o_oo0.o_.().Size = New Size(433, 19)
			Me.o_oo0.o_.().TabIndex = 5
			Me.o_oo0.o_.().Tag = Nothing
			Me.o_.0O0.().Location = New Point(12, 326)
			Me.o_.0O0.().Name = "Label3"
			Me.o_.0O0.().Size = New Size(410, 23)
			Me.o_.0O0.().TabIndex = 14
			Me.o_.0O0.().Text = "提示：表的名称必须用大括号括起来，例如：Select * From {订单}"
			Me.o_oo0.o_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o_oo0.o_.().Location = New Point(14, 84)
			Me.o_oo0.o_.().Name = "txtSQL"
			Me.o_oo0.o_.().Size = New Size(433, 230)
			Me.o_oo0.o_.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(463, 387)
			MyBase.Controls.Add(Me.o_oo0.o_.())
			MyBase.Controls.Add(Me.o_.0O0.())
			MyBase.Controls.Add(Me.o_oo0.o_.())
			MyBase.Controls.Add(Me.o_oo0.o_.())
			MyBase.Controls.Add(Me.o_oo0.o_.())
			MyBase.Controls.Add(Me.O0.0O0.())
			MyBase.Controls.Add(Me.O.O0000.())
			MyBase.Controls.Add(Me.o_Ooo._Oooo_0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.oO0.O.O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterParent
			Me.Text = "查询表"
			Me.O.O0000.().EndInit()
			Me.O0.0O0.().EndInit()
			Me.o_oo0.o_.().EndInit()
			Me.o_oo0.o_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003983 RID: 14723 RVA: 0x0018E175 File Offset: 0x0018C375
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O00.OO_0_.
		End Function

		' Token: 0x06003984 RID: 14724 RVA: 0x0018E17D File Offset: 0x0018C37D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O00.OO_0_. = A_0
		End Sub

		' Token: 0x06003985 RID: 14725 RVA: 0x0018E186 File Offset: 0x0018C386
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo_.0__O_o_.
		End Function

		' Token: 0x06003986 RID: 14726 RVA: 0x0018E190 File Offset: 0x0018C390
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.0O0.
			Dim ooo_.0__O_o_. As C1Button = Me.Ooo_.0__O_o_.
			If ooo_.0__O_o_. IsNot Nothing Then
				RemoveHandler ooo_.0__O_o_..Click, value
			End If
			Me.Ooo_.0__O_o_. = A_0
			ooo_.0__O_o_. = Me.Ooo_.0__O_o_.
			If ooo_.0__O_o_. IsNot Nothing Then
				AddHandler ooo_.0__O_o_..Click, value
			End If
		End Sub

		' Token: 0x06003987 RID: 14727 RVA: 0x0018E1D3 File Offset: 0x0018C3D3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0OOo0oo._O_.
		End Function

		' Token: 0x06003988 RID: 14728 RVA: 0x0018E1DB File Offset: 0x0018C3DB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0OOo0oo._O_. = A_0
		End Sub

		' Token: 0x06003989 RID: 14729 RVA: 0x0018E1E4 File Offset: 0x0018C3E4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0._Oo.
		End Function

		' Token: 0x0600398A RID: 14730 RVA: 0x0018E1EC File Offset: 0x0018C3EC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0_0.Ooo0.
			Dim o0._Oo. As C1Button = Me.O0._Oo.
			If o0._Oo. IsNot Nothing Then
				RemoveHandler o0._Oo..Click, value
			End If
			Me.O0._Oo. = A_0
			o0._Oo. = Me.O0._Oo.
			If o0._Oo. IsNot Nothing Then
				AddHandler o0._Oo..Click, value
			End If
		End Sub

		' Token: 0x0600398B RID: 14731 RVA: 0x0018E22F File Offset: 0x0018C42F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0OOo0oo._O_.
		End Function

		' Token: 0x0600398C RID: 14732 RVA: 0x0018E237 File Offset: 0x0018C437
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0OOo0oo._O_. = A_0
		End Sub

		' Token: 0x0600398D RID: 14733 RVA: 0x0018E240 File Offset: 0x0018C440
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Ooo_.0__O_o_.
		End Function

		' Token: 0x0600398E RID: 14734 RVA: 0x0018E248 File Offset: 0x0018C448
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.Ooo_.0__O_o_. = A_0
		End Sub

		' Token: 0x0600398F RID: 14735 RVA: 0x0018E251 File Offset: 0x0018C451
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.Oo_o_0O_OO.
		End Function

		' Token: 0x06003990 RID: 14736 RVA: 0x0018E259 File Offset: 0x0018C459
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.Oo_o_0O_OO. = A_0
		End Sub

		' Token: 0x06003991 RID: 14737 RVA: 0x0018E262 File Offset: 0x0018C462
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oO_oO000oo
			Return Me.O00.OO_0_.
		End Function

		' Token: 0x06003992 RID: 14738 RVA: 0x0018E26A File Offset: 0x0018C46A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oO_oO000oo)
			Me.O00.OO_0_. = A_0
		End Sub

		' Token: 0x06003993 RID: 14739 RVA: 0x0018E274 File Offset: 0x0018C474
		Public Sub New(A_0 As DataRow)
			AddHandler MyBase.Load, AddressOf Me.O.O0000.
			AddHandler MyBase.FormClosed, AddressOf Me.o0_0.Ooo0.
			Me.o_oo0.o_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O00.OO_0_. = A_0
		End Sub

		' Token: 0x06003994 RID: 14740 RVA: 0x0018E2D0 File Offset: 0x0018C4D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_oo0.o_.().Items.Add("内部数据源")
			Try
				For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Me.o_oo0.o_.().Items.Add(Conversions.ToString(dataRow("Name")))
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.o_oo0.o_.().SelectedIndex = 0
			If Me.O00.OO_0_..RowState <> DataRowState.Detached Then
				If Not Me.O00.OO_0_..IsNull("DataSource") AndAlso Operators.CompareString(Conversions.ToString(Me.O00.OO_0_.("DataSource")), "", True) > 0 Then
					Dim num As Integer = Me.o_oo0.o_.().Items.Count - 1
					For i As Integer = 1 To num
						If Operators.CompareString(Conversions.ToString(Me.o_oo0.o_.().Items(i)), Conversions.ToString(Me.O00.OO_0_.("DataSource")), True) = 0 Then
							Me.o_oo0.o_.().SelectedIndex = i
						End If
					Next
				End If
				If Not Me.O00.OO_0_..IsNull("Property") AndAlso Operators.CompareString(Conversions.ToString(Me.O00.OO_0_.("Property")), "", True) > 0 Then
					Me.o_oo0.o_.().Text = Conversions.ToString(Me.O00.OO_0_.("Property"))
				End If
				Me.Text = Me.Text + " - " + Conversions.ToString(Me.O00.OO_0_.("Name"))
				Return
			End If
			Me.Text += " - 新建"
		End Sub

		' Token: 0x06003995 RID: 14741 RVA: 0x0018E4BC File Offset: 0x0018C6BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.o_oo0.o_.().Text.Trim(), "", True) <> 0 Then
				Dim dataTable As DataTable = New DataTable()
				Dim text As String = Me.o_oo0.o_.().Text
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim httpClient As HttpClient = Nothing
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.o_oo0.o_.().Text) Then
					Dim o0O As O0O = O_O0OO.OoO__.0oO0oo.()(Me.o_oo0.o_.().Text)
					text = Oo00.o0_o._O_.(o0O.OO.OoO0., text, False)
					dataTable = o0O.O_0_O_0_o_.0.(text, True)
					httpClient = o0O.oO0_0.o.()
					httpClient.[Select] = text
					httpClient.FormData("Action") = 2.ToString()
				Else
					If Me.o_oo0.o_.().SelectedIndex = 0 Then
						oleDbConnection = O_O0OO.OoO.0OO__0ooo.()
					Else
						oleDbConnection = O_O0OO.O._o_.()(Me.o_oo0.o_.().Text)
					End If
					text = Oo00.o0_o._O_.(oleDbConnection, text, False)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, oleDbConnection)
					Try
						oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
						Return
					End Try
				End If
				If dataTable Is Nothing AndAlso dataTable.Columns.Count = 0 Then
					MessageBox.Show("语句执行后没有返回数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If Me.O00.OO_0_..RowState = DataRowState.Detached Then
					Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "")
					o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
					If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
						Dim text2 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
						Dim text3 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
						Me.O00.OO_0_.("Name") = text2
						If Me.o_oo0.o_.().SelectedIndex > 0 Then
							Me.O00.OO_0_.("DataSource") = Me.o_oo0.o_.().Text
						End If
						Me.O00.OO_0_.("Property") = Me.o_oo0.o_.().Text.Trim()
						O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Add(Me.O00.OO_0_.)
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
						o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text, text2, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, Me.o_oo0.o_.().Text, httpClient)
						If Not OO_00oOO.DataTables.Contains(text2) Then
							Return
						End If
						OO_00oOO.DataTables(text2).o.0O000_.()
						OO_00oOO.DataTables(text2).Caption = text3
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text2))
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(Me.O00.OO_0_.("Name")), True, False)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
						If Operators.CompareString(text3, "", True) > 0 OrElse O_O0OO.O0_00o.o0__o..DevelopByCreater Then
							OO_00oOO.DataTables(text2).Developer = OO_00oOO.User.Name
							OO_00oOO.DataTables(text2).OO00_o.ooOO.(False)
						End If
						O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
					End If
				Else
					Dim text4 As String = Conversions.ToString(Me.O00.OO_0_.("Name"))
					If Me.o_oo0.o_.().SelectedIndex = 0 Then
						Me.O00.OO_0_.("DataSource") = DBNull.Value
					Else
						Me.O00.OO_0_.("DataSource") = Me.o_oo0.o_.().Text
					End If
					Me.O00.OO_0_.("Property") = Me.o_oo0.o_.().Text.Trim()
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					If OO_00oOO.DataTables.Contains(text4) Then
						Oo00.o00O0O_.O.(Me.O00.OO_0_., OO_00oOO.Tables(text4))
					Else
						o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text, text4, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, Me.o_oo0.o_.().Text, httpClient)
						If Not OO_00oOO.DataTables.Contains(text4) Then
							Return
						End If
						OO_00oOO.DataTables(text4).o.0O000_.()
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text4))
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(Me.O00.OO_0_.("Name")), True, True)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
					End If
				End If
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x06003996 RID: 14742 RVA: 0x0018E980 File Offset: 0x0018CB80
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.o_oo0.o_.().Text.Trim()
			Dim a_ As OleDbConnection = Nothing
			Dim a_2 As O0O = Nothing
			If Me.o_oo0.o_.().SelectedIndex = 0 Then
				a_ = O_O0OO.OoO.0OO__0ooo.()
			ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(Me.o_oo0.o_.().Text) Then
				a_2 = O_O0OO.OoO__.0oO0oo.()(Me.o_oo0.o_.().Text)
			Else
				a_ = O_O0OO.O._o_.()(Me.o_oo0.o_.().Text)
			End If
			If Operators.CompareString(text, "", True) <> 0 Then
				New O_\u30000_\u3002O\u3002\u3002\u3000\u3000(a_, text, a_2).ShowDialog()
			End If
		End Sub

		' Token: 0x06003997 RID: 14743 RVA: 0x0018EA18 File Offset: 0x0018CC18
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040017CE RID: 6094
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040017CF RID: 6095
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017D0 RID: 6096
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017D1 RID: 6097
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017D2 RID: 6098
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017D3 RID: 6099
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017D4 RID: 6100
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040017D5 RID: 6101
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017D6 RID: 6102
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oO_oO000oo

		' Token: 0x040017D7 RID: 6103
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
