Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200036C RID: 876
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3002O
		Inherits Form

		' Token: 0x06003733 RID: 14131 RVA: 0x001770FC File Offset: 0x001752FC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_.0O0000_ooo. IsNot Nothing Then
					Me.O_.0O0000_ooo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003734 RID: 14132 RVA: 0x0017713C File Offset: 0x0017533C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O._0_O00.(New Label())
			Me.O._0_O00.(New C1TextBox())
			Me.O._0_O00.(New C1Button())
			Me.O0O_0oo.o.(New C1Button())
			MyBase.SuspendLayout()
			Me.O._0_O00.().AutoSize = True
			Me.O._0_O00.().Location = New Point(12, 12)
			Me.O._0_O00.().Name = "Label1"
			Me.O._0_O00.().Size = New Size(179, 12)
			Me.O._0_O00.().TabIndex = 0
			Me.O._0_O00.().Text = "请输入用户分组名称，每行一个:"
			Me.O._0_O00.().Location = New Point(14, 30)
			Me.O._0_O00.().Multiline = True
			Me.O._0_O00.().Name = "TextBox1"
			Me.O._0_O00.().Size = New Size(277, 238)
			Me.O._0_O00.().TabIndex = 1
			Me.o__oOO.oO.().DialogResult = DialogResult.OK
			Me.o__oOO.oO.().Location = New Point(74, 285)
			Me.o__oOO.oO.().Name = "Button1"
			Me.o__oOO.oO.().Size = New Size(75, 23)
			Me.o__oOO.oO.().TabIndex = 2
			Me.o__oOO.oO.().Text = "确定"
			Me.o__oOO.oO.().UseVisualStyleBackColor = True
			Me.Oo__0o0O._.().DialogResult = DialogResult.Cancel
			Me.Oo__0o0O._.().Location = New Point(155, 285)
			Me.Oo__0o0O._.().Name = "Button2"
			Me.Oo__0o0O._.().Size = New Size(75, 23)
			Me.Oo__0o0O._.().TabIndex = 3
			Me.Oo__0o0O._.().Text = "取消"
			Me.Oo__0o0O._.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(305, 322)
			MyBase.Controls.Add(Me.Oo__0o0O._.())
			MyBase.Controls.Add(Me.o__oOO.oO.())
			MyBase.Controls.Add(Me.O._0_O00.())
			MyBase.Controls.Add(Me.O._0_O00.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o0...o.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "预定义用户分组"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003735 RID: 14133 RVA: 0x001773D7 File Offset: 0x001755D7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O._0_O00.
		End Function

		' Token: 0x06003736 RID: 14134 RVA: 0x001773DF File Offset: 0x001755DF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O._0_O00. = A_0
		End Sub

		' Token: 0x06003737 RID: 14135 RVA: 0x001773E8 File Offset: 0x001755E8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_.0O0000_ooo.
		End Function

		' Token: 0x06003738 RID: 14136 RVA: 0x001773F0 File Offset: 0x001755F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_.0O0000_ooo. = A_0
		End Sub

		' Token: 0x06003739 RID: 14137 RVA: 0x001773F9 File Offset: 0x001755F9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._0_O00.
		End Function

		' Token: 0x0600373A RID: 14138 RVA: 0x00177404 File Offset: 0x00175604
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo__0o0O._.
			Dim o._0_O00. As C1Button = Me.O._0_O00.
			If o._0_O00. IsNot Nothing Then
				RemoveHandler o._0_O00..Click, value
			End If
			Me.O._0_O00. = A_0
			o._0_O00. = Me.O._0_O00.
			If o._0_O00. IsNot Nothing Then
				AddHandler o._0_O00..Click, value
			End If
		End Sub

		' Token: 0x0600373B RID: 14139 RVA: 0x00177447 File Offset: 0x00175647
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0O_0oo.o.
		End Function

		' Token: 0x0600373C RID: 14140 RVA: 0x0017744F File Offset: 0x0017564F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0O_0oo.o. = A_0
		End Sub

		' Token: 0x0600373D RID: 14141 RVA: 0x00177458 File Offset: 0x00175658
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In Me.O_.0O0000_ooo..Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Not dataRow.IsNull("Type") AndAlso Conversions.ToInteger(dataRow("Type")) = Me.O_.0O0000_ooo. Then
						Me.O_.0O0000_ooo. = dataRow
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Me.O_.0O0000_ooo. Is Nothing Then
				Me.O_.0O0000_ooo. = Me.O_.0O0000_ooo..NewRow()
				Me.O_.0O0000_ooo.("Name") = [Enum].GetName(GetType(UserTypeEnum), Me.O_.0O0000_ooo.)
				Me.O_.0O0000_ooo.("Type") = Me.O_.0O0000_ooo.
				Me.O_.0O0000_ooo..Rows.Add(Me.O_.0O0000_ooo.)
			End If
			If Not Me.O_.0O0000_ooo..IsNull("Config") Then
				Me.O._0_O00.().Value = Conversions.ToString(Me.O_.0O0000_ooo.("Config"))
			End If
			If Me.O_.0O0000_ooo. = 6 Then
				Me.Text = "预定义用户角色"
				Me.O._0_O00.().Text = "请输入用户角色，每行一个:"
			End If
		End Sub

		' Token: 0x0600373E RID: 14142 RVA: 0x001775AC File Offset: 0x001757AC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_.0O0000_ooo.("Config") = Me.O._0_O00.().Text.Trim()
			Oo00.o0_o._O_.(Me.O_.0O0000_ooo., True)
		End Sub

		' Token: 0x0600373F RID: 14143 RVA: 0x001775DC File Offset: 0x001757DC
		Public Sub New(A_0 As UserTypeEnum, A_1 As DataTable)
			AddHandler MyBase.Load, AddressOf Me.o__oOO.oO.
			AddHandler MyBase.FormClosed, AddressOf Me.Oo__0o0O._.
			Me.O_.0O0000_ooo. = Nothing
			Me.O._0_O00.()
			Me.O_.0O0000_ooo. = A_0
			Me.O_.0O0000_ooo. = A_1
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003740 RID: 14144 RVA: 0x00177643 File Offset: 0x00175843
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040016BD RID: 5821
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040016BE RID: 5822
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016BF RID: 5823
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040016C0 RID: 5824
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016C1 RID: 5825
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016C2 RID: 5826
		Private <<EMPTY_NAME>> As UserTypeEnum

		' Token: 0x040016C3 RID: 5827
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040016C4 RID: 5828
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
