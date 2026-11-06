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
	' Token: 0x02000347 RID: 839
	<DesignerGenerated()>
	Friend Partial Class O\u3002o_\u3002\u3002\u3002\u3000\u3002o
		Inherits Form

		' Token: 0x06003314 RID: 13076 RVA: 0x0014E770 File Offset: 0x0014C970
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_.0o. IsNot Nothing Then
					Me.o_.0o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003315 RID: 13077 RVA: 0x0014E7B0 File Offset: 0x0014C9B0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oO_._0o0.(New C1ComboBox())
			Me.OoooO0O0._o0_O.(New Label())
			Me.oO_._0o0.(New C1Button())
			Me.o_.0o.(New Label())
			Me.o.Oo0o0oo__.(New Label())
			Me.o_.0o.(New oO_oO000oo())
			Me.oO_._0o0.().BeginInit()
			Me.oO_._0o0.().BeginInit()
			MyBase.SuspendLayout()
			Me.oO_._0o0.().AllowSpinLoop = False
			Me.oO_._0o0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oO_._0o0.().Cursor = Cursors.Arrow
			Me.oO_._0o0.().DropDownStyle = 1
			Me.oO_._0o0.().GapHeight = 0
			Me.oO_._0o0.().ImagePadding = New Padding(0)
			Me.oO_._0o0.().ItemsDisplayMember = ""
			Me.oO_._0o0.().ItemsValueMember = ""
			Me.oO_._0o0.().Location = New Point(12, 30)
			Me.oO_._0o0.().Name = "cmbDataSource"
			Me.oO_._0o0.().Size = New Size(503, 19)
			Me.oO_._0o0.().TabIndex = 1
			Me.oO_._0o0.().Tag = Nothing
			Me.oO_._0o0.().AutoSize = True
			Me.oO_._0o0.().Location = New Point(12, 9)
			Me.oO_._0o0.().Name = "Label1"
			Me.oO_._0o0.().Size = New Size(83, 12)
			Me.oO_._0o0.().TabIndex = 11
			Me.oO_._0o0.().Text = "请选择数据源:"
			Me.oO_._0o0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oO_._0o0.().Location = New Point(440, 322)
			Me.oO_._0o0.().Name = "btnPreview"
			Me.oO_._0o0.().Size = New Size(75, 24)
			Me.oO_._0o0.().TabIndex = 2
			Me.oO_._0o0.().Text = "执行"
			Me.oO_._0o0.().UseVisualStyleBackColor = True
			Me.o_oOO__oO._.().AutoSize = True
			Me.o_oOO__oO._.().Location = New Point(12, 59)
			Me.o_oOO__oO._.().Name = "Label2"
			Me.o_oOO__oO._.().Size = New Size(89, 12)
			Me.o_oOO__oO._.().TabIndex = 9
			Me.o_oOO__oO._.().Text = "请输入SQL语句:"
			Me.OoooO0O0._o0_O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OoooO0O0._o0_O.().Location = New Point(12, 317)
			Me.OoooO0O0._o0_O.().Name = "Label3"
			Me.OoooO0O0._o0_O.().Size = New Size(410, 23)
			Me.OoooO0O0._o0_O.().TabIndex = 13
			Me.OoooO0O0._o0_O.().Text = "提示：表的名称必须用大括号括起来，例如：Select * From {订单}"
			Me.oO_._0o0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oO_._0o0.().Location = New Point(12, 80)
			Me.oO_._0o0.().Name = "txtSql"
			Me.oO_._0o0.().Size = New Size(503, 230)
			Me.oO_._0o0.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(527, 357)
			MyBase.Controls.Add(Me.oO_._0o0.())
			MyBase.Controls.Add(Me.OoooO0O0._o0_O.())
			MyBase.Controls.Add(Me.oO_._0o0.())
			MyBase.Controls.Add(Me.oO_._0o0.())
			MyBase.Controls.Add(Me.oO_._0o0.())
			MyBase.Controls.Add(Me.o_oOO__oO._.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o0.0_...o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterParent
			Me.Text = "SQL Excuter"
			Me.oO_._0o0.().EndInit()
			Me.oO_._0o0.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003316 RID: 13078 RVA: 0x0014EBC6 File Offset: 0x0014CDC6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_.0o.
		End Function

		' Token: 0x06003317 RID: 13079 RVA: 0x0014EBCE File Offset: 0x0014CDCE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_.0o. = A_0
		End Sub

		' Token: 0x06003318 RID: 13080 RVA: 0x0014EBD7 File Offset: 0x0014CDD7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_.0o.
		End Function

		' Token: 0x06003319 RID: 13081 RVA: 0x0014EBDF File Offset: 0x0014CDDF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_.0o. = A_0
		End Sub

		' Token: 0x0600331A RID: 13082 RVA: 0x0014EBE8 File Offset: 0x0014CDE8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_.0o.
		End Function

		' Token: 0x0600331B RID: 13083 RVA: 0x0014EBF0 File Offset: 0x0014CDF0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o__00.ooOo.
			Dim c1Button As C1Button = Me.o_.0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_.0o. = A_0
			c1Button = Me.o_.0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600331C RID: 13084 RVA: 0x0014EC33 File Offset: 0x0014CE33
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.Oo0o0oo__.
		End Function

		' Token: 0x0600331D RID: 13085 RVA: 0x0014EC3B File Offset: 0x0014CE3B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.Oo0o0oo__. = A_0
		End Sub

		' Token: 0x0600331E RID: 13086 RVA: 0x0014EC44 File Offset: 0x0014CE44
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOoOo_O.OO.
		End Function

		' Token: 0x0600331F RID: 13087 RVA: 0x0014EC4C File Offset: 0x0014CE4C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOoOo_O.OO. = A_0
		End Sub

		' Token: 0x06003320 RID: 13088 RVA: 0x0014EC55 File Offset: 0x0014CE55
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oO_oO000oo
			Return Me.o_.0o.
		End Function

		' Token: 0x06003321 RID: 13089 RVA: 0x0014EC5D File Offset: 0x0014CE5D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oO_oO000oo)
			Me.o_.0o. = A_0
		End Sub

		' Token: 0x06003322 RID: 13090 RVA: 0x0014EC68 File Offset: 0x0014CE68
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O.0oOO0o00Oo.
			AddHandler MyBase.FormClosed, AddressOf Me.o__00.ooOo.
			Me.oO_._0o0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003323 RID: 13091 RVA: 0x0014ECBC File Offset: 0x0014CEBC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO_._0o0.().Items.Add("内部数据源")
			Try
				For Each obj As Object In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Not dataRow.IsNull("Name") AndAlso Operators.CompareString(Conversions.ToString(dataRow("Name")), "", True) > 0 Then
						Me.oO_._0o0.().Items.Add(Conversions.ToString(dataRow("Name")))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.oO_._0o0.().SelectedIndex = 0
		End Sub

		' Token: 0x06003324 RID: 13092 RVA: 0x0014ED94 File Offset: 0x0014CF94
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.oO_._0o0.().Text, "", True) > 0 Then
				Me.oO_._0o0.().Text = Me.oO_._0o0.().Text.Trim(New Char() { " "c, vbCr, vbLf })
			End If
			If Not Me.oO_._0o0.().Text.ToLower().StartsWith("select") AndAlso Not Me.oO_._0o0.().Text.ToLower().StartsWith("transform") AndAlso Not Me.oO_._0o0.().Text.ToLower().StartsWith("exec") Then
				Dim sqlcommand As SQLCommand = New SQLCommand()
				If Me.oO_._0o0.().SelectedIndex > 0 Then
					sqlcommand.ConnectionName = Me.oO_._0o0.().SelectedItem.ToString()
				End If
				sqlcommand.CommandText = Me.oO_._0o0.().Text
				sqlcommand.ExecuteNonQuery()
				Return
			End If
			If Me.oO_._0o0.().SelectedIndex = 0 Then
				New O_\u30000_\u3002O\u3002\u3002\u3000\u3000(O_O0OO.OoO.0OO__0ooo.(), Me.oO_._0o0.().Text, Nothing).ShowDialog()
				Return
			End If
			Dim a_ As OleDbConnection = Nothing
			Dim a_2 As O0O = Nothing
			If O_O0OO.O._o_.().ContainsKey(Me.oO_._0o0.().Text) Then
				a_ = O_O0OO.O._o_.()(Me.oO_._0o0.().Text)
			Else
				a_2 = O_O0OO.OoO__.0oO0oo.()(Me.oO_._0o0.().Text)
			End If
			New O_\u30000_\u3002O\u3002\u3002\u3000\u3000(a_, Me.oO_._0o0.().Text, a_2).ShowDialog()
		End Sub

		' Token: 0x06003325 RID: 13093 RVA: 0x0014EF0B File Offset: 0x0014D10B
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040014A4 RID: 5284
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040014A5 RID: 5285
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040014A6 RID: 5286
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014A7 RID: 5287
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014A8 RID: 5288
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014A9 RID: 5289
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014AA RID: 5290
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oO_oO000oo
	End Class
End Namespace
