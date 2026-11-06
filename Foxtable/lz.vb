Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000447 RID: 1095
	<DesignerGenerated()>
	Friend Partial Class lz
		Inherits Form

		' Token: 0x06004849 RID: 18505 RVA: 0x001E78E0 File Offset: 0x001E5AE0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OOOOo.o000. IsNot Nothing Then
					Me.OOOOo.o000..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600484A RID: 18506 RVA: 0x001E7920 File Offset: 0x001E5B20
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(lz))
			Me.o.0oOOO_.(New C1Button())
			Me.o.o_O0O_O_ooO0.(New C1FlexGrid())
			Me.o0_Oo0oOo.Ooo_.(New C1Button())
			Me.o.o_O0O_O_ooO0.(New C1TextBox())
			Me.o.o_O0O_O_ooO0.(New Label())
			Me.o.o_O0O_O_ooO0.(New C1ComboBox())
			Me.o0o_.0o.(New C1Button())
			Me.o0oO.O_o0Oo0.(New C1Button())
			Me.Ooo_oO.O0oO0.(New C1Button())
			Me.o0.Ooo__o.().BeginInit()
			MyBase.SuspendLayout()
			Me.O.ooO_.().Location = New Point(475, 468)
			Me.O.ooO_.().Name = "btnCancel"
			Me.O.ooO_.().Size = New Size(75, 23)
			Me.O.ooO_.().TabIndex = 4
			Me.O.ooO_.().Text = "取消"
			Me.O.ooO_.().UseVisualStyleBackColor = True
			Me.o0.Ooo__o.().AllowDragging = 0
			Me.o0.Ooo__o.().AllowEditing = False
			Me.o0.Ooo__o.().BorderStyle = 4
			Me.o0.Ooo__o.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.o0.Ooo__o.().ExtendLastCol = True
			Me.o0.Ooo__o.().FocusRect = 0
			Me.o0.Ooo__o.().Location = New Point(11, 37)
			Me.o0.Ooo__o.().Name = "C1FlexGrid1"
			Me.o0.Ooo__o.().Rows.Count = 2
			Me.o0.Ooo__o.().Rows.DefaultSize = 20
			Me.o0.Ooo__o.().SelectionMode = 7
			Me.o0.Ooo__o.().Size = New Size(538, 328)
			Me.o0.Ooo__o.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.o0.Ooo__o.().TabIndex = 0
			Me.o0.Ooo__o.().VisualStyle = 1
			Me.o0.Ooo__o.().Location = New Point(394, 468)
			Me.o0.Ooo__o.().Name = "btnOK"
			Me.o0.Ooo__o.().Size = New Size(75, 23)
			Me.o0.Ooo__o.().TabIndex = 3
			Me.o0.Ooo__o.().Text = "确定"
			Me.o0.Ooo__o.().UseVisualStyleBackColor = True
			Me.o0_Oo0oOo.Ooo_.().ForeColor = Color.Blue
			Me.o0_Oo0oOo.Ooo_.().Location = New Point(12, 371)
			Me.o0_Oo0oOo.Ooo_.().Multiline = True
			Me.o0_Oo0oOo.Ooo_.().Name = "TextBox1"
			Me.o0_Oo0oOo.Ooo_.().ScrollBars = ScrollBars.Vertical
			Me.o0_Oo0oOo.Ooo_.().Size = New Size(538, 86)
			Me.o0_Oo0oOo.Ooo_.().TabIndex = 2
			Me.o0_Oo0oOo.Ooo_.().AutoSize = True
			Me.o0_Oo0oOo.Ooo_.().Location = New Point(9, 13)
			Me.o0_Oo0oOo.Ooo_.().Name = "Label1"
			Me.o0_Oo0oOo.Ooo_.().Size = New Size(53, 12)
			Me.o0_Oo0oOo.Ooo_.().TabIndex = 15
			Me.o0_Oo0oOo.Ooo_.().Text = "FTP路径:"
			Me.o0.Ooo__o.().Location = New Point(72, 10)
			Me.o0.Ooo__o.().Name = "cmbFTPPath"
			Me.o0.Ooo__o.().Size = New Size(477, 20)
			Me.o0.Ooo__o.().TabIndex = 0
			Me.O_0___O_.00ooO.().Location = New Point(13, 467)
			Me.O_0___O_.00ooO.().Name = "Button1"
			Me.O_0___O_.00ooO.().Size = New Size(75, 23)
			Me.O_0___O_.00ooO.().TabIndex = 1
			Me.O_0___O_.00ooO.().Text = "刷新"
			Me.O_0___O_.00ooO.().UseVisualStyleBackColor = True
			Me.O0_.0O.().Location = New Point(94, 467)
			Me.O0_.0O.().Name = "Button2"
			Me.O0_.0O.().Size = New Size(75, 23)
			Me.O0_.0O.().TabIndex = 2
			Me.O0_.0O.().Text = "上传文件"
			Me.O0_.0O.().UseVisualStyleBackColor = True
			Me.O0OoO0oO.0_0Oo.().Location = New Point(175, 467)
			Me.O0OoO0oO.0_0Oo.().Name = "Button3"
			Me.O0OoO0oO.0_0Oo.().Size = New Size(75, 23)
			Me.O0OoO0oO.0_0Oo.().TabIndex = 16
			Me.O0OoO0oO.0_0Oo.().Text = "新建目录"
			Me.O0OoO0oO.0_0Oo.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(561, 502)
			MyBase.Controls.Add(Me.O0OoO0oO.0_0Oo.())
			MyBase.Controls.Add(Me.O0_.0O.())
			MyBase.Controls.Add(Me.O_0___O_.00ooO.())
			MyBase.Controls.Add(Me.o0.Ooo__o.())
			MyBase.Controls.Add(Me.o0_Oo0oOo.Ooo_.())
			MyBase.Controls.Add(Me.o0_Oo0oOo.Ooo_.())
			MyBase.Controls.Add(Me.o0.Ooo__o.())
			MyBase.Controls.Add(Me.O.ooO_.())
			MyBase.Controls.Add(Me.o0.Ooo__o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oo0..O.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择文件"
			Me.o0.Ooo__o.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600484B RID: 18507 RVA: 0x001E7ED3 File Offset: 0x001E60D3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o_O0O_O_ooO0.
		End Function

		' Token: 0x0600484C RID: 18508 RVA: 0x001E7EDC File Offset: 0x001E60DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.0o.
			Dim c1Button As C1Button = Me.o.o_O0O_O_ooO0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.o_O0O_O_ooO0. = A_0
			c1Button = Me.o.o_O0O_O_ooO0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600484D RID: 18509 RVA: 0x001E7F1F File Offset: 0x001E611F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.OOOOo.o000.
		End Function

		' Token: 0x0600484E RID: 18510 RVA: 0x001E7F28 File Offset: 0x001E6128
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim sortColEventHandler As SortColEventHandler = AddressOf Me.O_0O.o.
			Dim value As EventHandler = AddressOf Me.oO.0O0.
			Dim value2 As KeyEventHandler = AddressOf Me.OOoO0Oo_o000.0.
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.O_.OOO.
			Dim ooooo.o000. As C1FlexGrid = Me.OOOOo.o000.
			If ooooo.o000. IsNot Nothing Then
				ooooo.o000..AfterSort -= sortColEventHandler
				RemoveHandler ooooo.o000..DoubleClick, value
				RemoveHandler ooooo.o000..KeyDown, value2
				ooooo.o000..OwnerDrawCell -= ownerDrawCellEventHandler
			End If
			Me.OOOOo.o000. = A_0
			ooooo.o000. = Me.OOOOo.o000.
			If ooooo.o000. IsNot Nothing Then
				ooooo.o000..AfterSort += sortColEventHandler
				AddHandler ooooo.o000..DoubleClick, value
				AddHandler ooooo.o000..KeyDown, value2
				ooooo.o000..OwnerDrawCell += ownerDrawCellEventHandler
			End If
		End Sub

		' Token: 0x0600484F RID: 18511 RVA: 0x001E7FC8 File Offset: 0x001E61C8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O__oo_._oOOO.
		End Function

		' Token: 0x06004850 RID: 18512 RVA: 0x001E7FD0 File Offset: 0x001E61D0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.Ooooo_o.
			Dim o__oo_._oOOO. As C1Button = Me.O__oo_._oOOO.
			If o__oo_._oOOO. IsNot Nothing Then
				RemoveHandler o__oo_._oOOO..Click, value
			End If
			Me.O__oo_._oOOO. = A_0
			o__oo_._oOOO. = Me.O__oo_._oOOO.
			If o__oo_._oOOO. IsNot Nothing Then
				AddHandler o__oo_._oOOO..Click, value
			End If
		End Sub

		' Token: 0x06004851 RID: 18513 RVA: 0x001E8013 File Offset: 0x001E6213
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OOOOo.o000.
		End Function

		' Token: 0x06004852 RID: 18514 RVA: 0x001E801B File Offset: 0x001E621B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OOOOo.o000. = A_0
		End Sub

		' Token: 0x06004853 RID: 18515 RVA: 0x001E8024 File Offset: 0x001E6224
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOOOo.o000.
		End Function

		' Token: 0x06004854 RID: 18516 RVA: 0x001E802C File Offset: 0x001E622C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OOOOo.o000. = A_0
		End Sub

		' Token: 0x06004855 RID: 18517 RVA: 0x001E8035 File Offset: 0x001E6235
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.OOOOo.o000.
		End Function

		' Token: 0x06004856 RID: 18518 RVA: 0x001E8040 File Offset: 0x001E6240
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim value As KeyEventHandler = AddressOf Me.O_.OOO.
			Dim value2 As KeyPressEventHandler = AddressOf Me.O_.OOO.
			Dim eventHandler As EventHandler = AddressOf Me.OOOOOo.Ooo.
			Dim value3 As EventHandler = AddressOf Me.o____0O_oOo0._.
			Dim ooooo.o000. As C1ComboBox = Me.OOOOo.o000.
			If ooooo.o000. IsNot Nothing Then
				RemoveHandler ooooo.o000..KeyDown, value
				RemoveHandler ooooo.o000..KeyPress, value2
				ooooo.o000..SelectedIndexChanged -= eventHandler
				RemoveHandler ooooo.o000..Enter, value3
			End If
			Me.OOOOo.o000. = A_0
			ooooo.o000. = Me.OOOOo.o000.
			If ooooo.o000. IsNot Nothing Then
				AddHandler ooooo.o000..KeyDown, value
				AddHandler ooooo.o000..KeyPress, value2
				ooooo.o000..SelectedIndexChanged += eventHandler
				AddHandler ooooo.o000..Enter, value3
			End If
		End Sub

		' Token: 0x06004857 RID: 18519 RVA: 0x001E80E0 File Offset: 0x001E62E0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0o__0._.
		End Function

		' Token: 0x06004858 RID: 18520 RVA: 0x001E80E8 File Offset: 0x001E62E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.O0ooo_o.
			Dim o0o__0._. As C1Button = Me.O0o__0._.
			If o0o__0._. IsNot Nothing Then
				RemoveHandler o0o__0._..Click, value
			End If
			Me.O0o__0._. = A_0
			o0o__0._. = Me.O0o__0._.
			If o0o__0._. IsNot Nothing Then
				AddHandler o0o__0._..Click, value
			End If
		End Sub

		' Token: 0x06004859 RID: 18521 RVA: 0x001E812B File Offset: 0x001E632B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0_.oOoo.
		End Function

		' Token: 0x0600485A RID: 18522 RVA: 0x001E8134 File Offset: 0x001E6334
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_oOo_00_0.OoO.
			Dim c1Button As C1Button = Me.oO0_.oOoo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0_.oOoo. = A_0
			c1Button = Me.oO0_.oOoo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600485B RID: 18523 RVA: 0x001E8177 File Offset: 0x001E6377
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.O000.
		End Function

		' Token: 0x0600485C RID: 18524 RVA: 0x001E8180 File Offset: 0x001E6380
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_0O.o.
			Dim c1Button As C1Button = Me.o.O000.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.O000. = A_0
			c1Button = Me.o.O000.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600485D RID: 18525 RVA: 0x001E81C3 File Offset: 0x001E63C3
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As FTPClient
			Return Me.OOOOo.o000.
		End Function

		' Token: 0x0600485E RID: 18526 RVA: 0x001E81CC File Offset: 0x001E63CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As FTPClient)
			Dim a_ As FTPClient.OooO_O0O_0_O = AddressOf Me.o0.Ooo__o.
			Dim a_2 As FTPClient.OoO_00_o = AddressOf Me.o0.Ooo__o.
			Dim a_3 As FTPClient.OOOOO00OoOOo = AddressOf Me.o0.Ooo__o.
			Dim ooooo.o000. As FTPClient = Me.OOOOo.o000.
			If ooooo.o000. IsNot Nothing Then
				RemoveHandler ooooo.o000..ServerConnected, a_
				RemoveHandler ooooo.o000..ShowError, a_2
				RemoveHandler ooooo.o000..ShowMessage, a_3
			End If
			Me.OOOOo.o000. = A_0
			ooooo.o000. = Me.OOOOo.o000.
			If ooooo.o000. IsNot Nothing Then
				AddHandler ooooo.o000..ServerConnected, a_
				AddHandler ooooo.o000..ShowError, a_2
				AddHandler ooooo.o000..ShowMessage, a_3
			End If
		End Sub

		' Token: 0x0600485F RID: 18527 RVA: 0x001E8248 File Offset: 0x001E6448
		Public Sub New(A_0 As FTPClient, Optional A_1 As String = "")
			AddHandler MyBase.Activated, AddressOf Me.O._OO0_.
			AddHandler MyBase.FormClosed, AddressOf Me.O_.OOO.
			AddHandler MyBase.Load, AddressOf Me.o00_OO_._oO.
			Me.OOOOo.o000. = True
			Me.Ooo_oO.O0oO0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o.o_O0O_O_ooO0.(A_0)
			If Operators.CompareString(A_1, "", True) > 0 Then
				Me.o0_Oo0oOo.Ooo_.().ChangeDir(A_1)
			End If
			Me.o0.Ooo__o.().Styles.Focus.MergeWith(Me.o0.Ooo__o.().Styles.Highlight)
			Me.o0.Ooo__o.().Styles.EmptyArea.Border.Style = 0
			Me.o0.Ooo__o.().Styles.EmptyArea.BackColor = Me.o0.Ooo__o.().Styles.Normal.BackColor
			Me.o0.Ooo__o.().DrawMode = 1
			Me.o0.Ooo__o.().Cols(1).Format = "yyyy-MM-dd HH:mm"
			Me.OOOOo.o000. = New List(Of String)()
			Me.o0.Ooo__o.().Value = Me.o0_Oo0oOo.Ooo_.().CurrentDir
		End Sub

		' Token: 0x06004860 RID: 18528 RVA: 0x001E8387 File Offset: 0x001E6587
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.OOOOo.o000. Then
				Me.o0.Ooo__o.().SelectionMode = 3
			End If
		End Sub

		' Token: 0x06004861 RID: 18529 RVA: 0x001E839D File Offset: 0x001E659D
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Me.o.o_O0O_O_ooO0.(Nothing)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06004862 RID: 18530 RVA: 0x001E83B6 File Offset: 0x001E65B6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0_Oo0oOo.Ooo_.(False, ".")
		End Sub

		' Token: 0x06004863 RID: 18531 RVA: 0x001E83C4 File Offset: 0x001E65C4
		Private Sub <<EMPTY_NAME>>(Optional A_0 As Boolean = False, Optional A_1 As String = ".")
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.o0_Oo0oOo.Ooo_.().Ooo_Oo_O0.00O..ContainsKey(Me.o0_Oo0oOo.Ooo_.().CurrentDir) OrElse A_0 Then
					GoTo IL_49
				End If
				IL_29:
				num2 = 3
				Dim a_ As List(Of String) = Me.o0_Oo0oOo.Ooo_.().Ooo_Oo_O0.00O.(Me.o0_Oo0oOo.Ooo_.().CurrentDir)
				GoTo IL_5C
				IL_49:
				num2 = 5
				a_ = Me.o0_Oo0oOo.Ooo_.().GetDetailList("")
				IL_5C:
				num2 = 6
				Dim ftpbeforeListDetailsEventArgs As FTPBeforeListDetailsEventArgs = New FTPBeforeListDetailsEventArgs(Me.o0_Oo0oOo.Ooo_.().CurrentDir, a_, Me.o0_Oo0oOo.Ooo_.().FTPName)
				IL_7C:
				num2 = 7
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeListDetails", New Object() { ftpbeforeListDetailsEventArgs }, True, "FTP", False)
				IL_A0:
				num2 = 8
				Dim array As String() = ftpbeforeListDetailsEventArgs.RemovedItems
				IL_AB:
				num2 = 9
				Me.o0.Ooo__o.().Rows.Count = 1
				IL_BF:
				num2 = 10
				Me.o0.Ooo__o.().BeginUpdate()
				IL_CD:
				num2 = 11
				Dim enumerator As List(Of String()).Enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator()
				While enumerator.MoveNext()
					Dim array2 As String() = enumerator.Current
					IL_EC:
					num2 = 12
					If Operators.CompareString(array2(2), "D", True) = 0 Then
						IL_103:
						num2 = 14
						If Array.BinarySearch(Of String)(array, array2(0)) < 0 Then
							IL_117:
							num2 = 16
							Me.o0.Ooo__o.().AddItem(String.Concat(New String() { array2(0), vbTab, array2(1), vbTab & " " & vbTab, Conversions.ToString(1) }))
							IL_158:
							num2 = 17
							Me.o0.Ooo__o.().SetCellImage(Me.o0.Ooo__o.().Rows.Count - 1, 0, a.oO0O_O.__oo.().ToBitmap())
							IL_183:
							num2 = 18
							If Operators.CompareString(Me.o0.Ooo__o.().GetData(Me.o0.Ooo__o.().Rows.Count - 1, 0).ToString(), A_1, True) = 0 Then
								IL_1B2:
								num2 = 19
								Me.o0.Ooo__o.().Row = Me.o0.Ooo__o.().Rows.Count - 1
							End If
						End If
					End If
					IL_1D2:
					num2 = 20
				End While
				IL_1E1:
				num2 = 21
				CType(enumerator, IDisposable).Dispose()
				IL_1F1:
				num2 = 22
				Dim enumerator2 As List(Of String()).Enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator()
				While enumerator2.MoveNext()
					Dim array3 As String() = enumerator2.Current
					IL_210:
					num2 = 23
					If Operators.CompareString(array3(2), "D", True) <> 0 Then
						IL_227:
						num2 = 25
						If Array.BinarySearch(Of String)(array, array3(0)) < 0 Then
							IL_23B:
							num2 = 27
							Me.o0.Ooo__o.().AddItem(String.Concat(New String() { array3(0), vbTab, array3(1), vbTab, array3(2), vbTab, Conversions.ToString(2) }))
							IL_28B:
							num2 = 28
							Dim text As String = array3(0)
							IL_294:
							num2 = 29
							Dim bitmap As Bitmap = O_O0OO.O0_00o.o0__o.
							IL_29E:
							num2 = 30
							If text.LastIndexOf(".") > 0 Then
								IL_2B0:
								num2 = 31
								text = text.Substring(text.LastIndexOf(".")).ToLower()
								IL_2CD:
								num2 = 32
								If O_O0OO.O0_00o.o0__o..ContainsKey(text) Then
									IL_2DE:
									num2 = 33
									bitmap = O_O0OO.O0_00o.o0__o.(text)
								Else
									IL_2F1:
									num2 = 35
									bitmap = ooO.OoO_0._oO00_o.(text)
									IL_2FD:
									num2 = 36
									If bitmap Is Nothing Then
										IL_304:
										num2 = 37
										bitmap = O_O0OO.O0_00o.o0__o.
									End If
									IL_30E:
									num2 = 38
									O_O0OO.O0_00o.o0__o..Add(text, bitmap)
								End If
							End If
							IL_31F:
							num2 = 39
							Me.o0.Ooo__o.().SetCellImage(Me.o0.Ooo__o.().Rows.Count - 1, 0, bitmap)
							IL_342:
							num2 = 40
							If Operators.CompareString(Me.o0.Ooo__o.().GetData(Me.o0.Ooo__o.().Rows.Count - 1, 0).ToString(), A_1, True) = 0 Then
								IL_371:
								num2 = 41
								Me.o0.Ooo__o.().Row = Me.o0.Ooo__o.().Rows.Count - 1
							End If
						End If
					End If
					IL_391:
					num2 = 42
				End While
				IL_3A0:
				num2 = 43
				CType(enumerator2, IDisposable).Dispose()
				IL_3B0:
				num2 = 44
				If Operators.CompareString(Me.o0_Oo0oOo.Ooo_.().CurrentDir, "/", True) = 0 Then
					GoTo IL_45D
				End If
				IL_3CE:
				num2 = 45
				Me.o0.Ooo__o.().AddItem("..", 1)
				IL_3E3:
				num2 = 46
				Me.o0.Ooo__o.().SetData(1, 3, 0)
				IL_3FA:
				num2 = 47
				Me.o0.Ooo__o.().SetCellImage(1, 0, a.o___o.00Oo__.().ToBitmap())
				IL_414:
				num2 = 48
				If Me.o0.Ooo__o.().Rows.Count <= 2 OrElse Me.o0.Ooo__o.().Rows.Selected.Count <> 0 Then
					GoTo IL_4A4
				End If
				IL_441:
				num2 = 49
				Me.o0.Ooo__o.().Rows(2).Selected = True
				GoTo IL_4A4
				IL_45D:
				num2 = 51
				If Me.o0.Ooo__o.().Rows.Count <= 1 OrElse Me.o0.Ooo__o.().Rows.Selected.Count <> 0 Then
					GoTo IL_4A4
				End If
				IL_48A:
				num2 = 52
				Me.o0.Ooo__o.().Rows(1).Selected = True
				IL_4A4:
				num2 = 53
				Me.o0.Ooo__o.().EndUpdate()
				IL_4B2:
				GoTo IL_5DC
				IL_4B7:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_59D:
				GoTo IL_5D1
				IL_59F:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5AF:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_59F
			End Try
			IL_5D1:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5DC:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004864 RID: 18532 RVA: 0x001E89D4 File Offset: 0x001E6BD4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SortColEventArgs)
			If Me.o0.Ooo__o.().Row > 0 Then
				Me.o0.Ooo__o.().Sort(1, 3)
				Me.o0.Ooo__o.().ShowCell(Me.o0.Ooo__o.().Row, Me.o0.Ooo__o.().Col)
			End If
		End Sub

		' Token: 0x06004865 RID: 18533 RVA: 0x001E8A12 File Offset: 0x001E6C12
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0.Ooo__o.().PerformClick()
		End Sub

		' Token: 0x06004866 RID: 18534 RVA: 0x001E8A20 File Offset: 0x001E6C20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.o0.Ooo__o.().Row <= 0 Then
					GoTo IL_378
				End If
				IL_1A:
				num2 = 3
				If Operators.CompareString(Me.o0.Ooo__o.()(Me.o0.Ooo__o.().Row, 3).ToString(), "2", True) <> 0 Then
					GoTo IL_17D
				End If
				IL_48:
				num2 = 4
				If Not Me.OOOOo.o000. Then
					GoTo IL_10B
				End If
				IL_55:
				num2 = 5
				Dim num3 As Integer = Me.o0.Ooo__o.().Rows.Count - 1
				For i As Integer = 1 To num3
					IL_72:
					num2 = 6
					If Me.o0.Ooo__o.().Rows(i).Selected Then
						IL_8D:
						num2 = 7
						If Operators.CompareString(Me.o0.Ooo__o.()(i, 3).ToString(), "2", True) <> 0 Then
							GoTo IL_378
						End If
						IL_B2:
						num2 = 10
						Me.OOOOo.o000..Add(Me.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + Me.o0.Ooo__o.()(i, 0).ToString())
					End If
					IL_F8:
					num2 = 11
				Next
				GoTo IL_15A
				IL_10B:
				num2 = 13
				Me.OOOOo.o000..Add(Me.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + Me.o0.Ooo__o.()(Me.o0.Ooo__o.().Row, 0).ToString())
				IL_15A:
				num2 = 14
				If Me.OOOOo.o000..Count <= 0 Then
					GoTo IL_378
				End If
				IL_16E:
				num2 = 15
				MyBase.DialogResult = DialogResult.OK
				GoTo IL_378
				IL_17D:
				num2 = 17
				If Operators.CompareString(Me.o0.Ooo__o.()(Me.o0.Ooo__o.().Row, 3).ToString(), "1", True) <> 0 Then
					GoTo IL_23F
				End If
				IL_1AC:
				num2 = 18
				Dim text As String = Me.o0.Ooo__o.()(Me.o0.Ooo__o.().Row, 0).ToString()
				IL_1CD:
				num2 = 19
				If Not Me.O_0O.o.(Me.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + text) Then
					GoTo IL_378
				End If
				IL_202:
				num2 = 21
				Me.o0_Oo0oOo.Ooo_.().ChangeDir(text)
				IL_212:
				num2 = 22
				Me.o0_Oo0oOo.Ooo_.(False, ".")
				IL_221:
				num2 = 23
				Me.o0.Ooo__o.().Value = Me.o0_Oo0oOo.Ooo_.().CurrentDir
				GoTo IL_378
				IL_23F:
				num2 = 25
				If Operators.CompareString(Me.o0.Ooo__o.()(Me.o0.Ooo__o.().Row, 3).ToString(), "0", True) <> 0 Then
					GoTo IL_378
				End If
				IL_26E:
				num2 = 26
				Dim text2 As String = Me.o0_Oo0oOo.Ooo_.().CurrentDir
				IL_27E:
				num2 = 27
				Dim array As String() = text2.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_296:
				num2 = 28
				If array.Length <= 0 Then
					GoTo IL_350
				End If
				IL_2A3:
				num2 = 29
				text2 = text2.Substring(0, text2.LastIndexOf("/") + 1)
				IL_2BE:
				num2 = 30
				If Operators.CompareString(Me.o0_Oo0oOo.Ooo_.().RootDir, "", True) <= 0 Then
					GoTo IL_322
				End If
				IL_2DA:
				num2 = 31
				If text2.Length >= Me.o0_Oo0oOo.Ooo_.().RootDir.Length OrElse Not Me.o0_Oo0oOo.Ooo_.().RootDir.StartsWith(text2) Then
					GoTo IL_322
				End If
				IL_30A:
				num2 = 32
				MessageBox.Show("您无权访问上级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_378
				IL_322:
				num2 = 34
				If Not Me.O_0O.o.(text2) Then
					GoTo IL_378
				End If
				IL_32F:
				num2 = 36
				Me.o0_Oo0oOo.Ooo_.().ChangeDir(text2)
				IL_33F:
				num2 = 37
				Me.o0_Oo0oOo.Ooo_.(False, ".")
				GoTo IL_35F
				IL_350:
				num2 = 39
				Me.o0_Oo0oOo.Ooo_.(False, ".")
				IL_35F:
				num2 = 40
				Me.o0.Ooo__o.().Value = Me.o0_Oo0oOo.Ooo_.().CurrentDir
				IL_378:
				GoTo IL_46E
				IL_37D:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_42F:
				GoTo IL_463
				IL_431:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_441:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_431
			End Try
			IL_463:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_46E:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004867 RID: 18535 RVA: 0x001E8EC0 File Offset: 0x001E70C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06004868 RID: 18536 RVA: 0x001E8EC9 File Offset: 0x001E70C9
		Private Sub <<EMPTY_NAME>>()
			Me.o0_Oo0oOo.Ooo_.(False, ".")
		End Sub

		' Token: 0x06004869 RID: 18537 RVA: 0x001E8ED8 File Offset: 0x001E70D8
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Not Me.o_0O0.OO00. Then
				Me.o0_Oo0oOo.Ooo_.().AppendText(String.Concat(New String() { "[", Strings.Format(DateTime.Now, "HH:mm:ss"), "] ", A_0, ",服务器返回信息:", A_1 }))
				Me.o0_Oo0oOo.Ooo_.().AppendText(vbCrLf)
			End If
		End Sub

		' Token: 0x0600486A RID: 18538 RVA: 0x001E8F4C File Offset: 0x001E714C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If Not Me.o_0O0.OO00. AndAlso MyBase.Visible Then
				Me.o0_Oo0oOo.Ooo_.().AppendText("[" + Strings.Format(DateTime.Now, "HH:mm:ss") + "] " + A_0)
				Me.o0_Oo0oOo.Ooo_.().AppendText(vbCrLf)
			End If
		End Sub

		' Token: 0x0600486B RID: 18539 RVA: 0x001E8FA8 File Offset: 0x001E71A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_1.KeyCode <> Keys.Delete Then
					GoTo IL_197
				End If
				IL_16:
				num2 = 3
				Dim c1FlexGrid As C1FlexGrid = Me.o0.Ooo__o.()
				IL_1F:
				num2 = 4
				Dim num3 As Integer = c1FlexGrid.Rows.Count - 1
				Dim num4 As Integer
				For i As Integer = 1 To num3
					IL_35:
					num2 = 5
					If c1FlexGrid.Rows(i).Selected Then
						IL_4B:
						num2 = 6
						Dim left As String = c1FlexGrid.GetData(i, 3).ToString()
						IL_5D:
						num2 = 7
						If Operators.CompareString(left, "1", True) = 0 OrElse Operators.CompareString(left, "2", True) = 0 Then
							IL_7D:
							num2 = 8
							num4 += 1
						End If
					End If
					IL_85:
					num2 = 9
				Next
				IL_94:
				num2 = 10
				If num4 = 0 Then
					GoTo IL_197
				End If
				IL_9E:
				num2 = 13
				If MessageBox.Show("确定要删除选定项目吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
					GoTo IL_197
				End If
				IL_B9:
				num2 = 15
				Dim num5 As Integer = c1FlexGrid.Rows.Count - 1
				For j As Integer = 1 To num5
					IL_D3:
					num2 = 16
					If c1FlexGrid.Rows(j).Selected Then
						IL_ED:
						num2 = 17
						If Operators.CompareString(c1FlexGrid.GetData(j, 3).ToString(), "1", True) = 0 Then
							IL_10B:
							num2 = 18
							Dim dirName As String = c1FlexGrid.GetData(j, 0).ToString()
							IL_11E:
							num2 = 19
							Me.o0_Oo0oOo.Ooo_.().DeleteDir(dirName, True)
						Else
							IL_132:
							num2 = 21
							If Operators.CompareString(c1FlexGrid.GetData(j, 3).ToString(), "2", True) = 0 Then
								IL_150:
								num2 = 22
								Dim fileName As String = c1FlexGrid.GetData(j, 0).ToString()
								IL_163:
								num2 = 23
								Me.o0_Oo0oOo.Ooo_.().DeleteFile(fileName)
							End If
						End If
					End If
					IL_174:
					num2 = 24
				Next
				IL_186:
				num2 = 25
				Me.o0_Oo0oOo.Ooo_.(True, ".")
				IL_195:
				c1FlexGrid = Nothing
				IL_197:
				GoTo IL_255
				IL_19C:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_216:
				GoTo IL_24A
				IL_218:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_228:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_218
			End Try
			IL_24A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_255:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600486C RID: 18540 RVA: 0x001E9230 File Offset: 0x001E7430
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If A_1.Row > 0 AndAlso A_1.Col = 2 Then
				Dim text As String = A_1.Text
				If Operators.CompareString(text, "", True) > 0 AndAlso Versioned.IsNumeric(text) Then
					Dim num As Long = Conversions.ToLong(text)
					If num = 0L Then
						A_1.Text = "0 KB"
						Return
					End If
					If num <= 1024L Then
						A_1.Text = "1 KB"
						Return
					End If
					A_1.Text = Strings.Format(CInt(Math.Round(CDbl(num) / 1024.0)), "#,##0") + " KB"
				End If
			End If
		End Sub

		' Token: 0x0600486D RID: 18541 RVA: 0x001E92CC File Offset: 0x001E74CC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			A_1.Handled = True
		End Sub

		' Token: 0x0600486E RID: 18542 RVA: 0x001E92D5 File Offset: 0x001E74D5
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			A_1.Handled = True
		End Sub

		' Token: 0x0600486F RID: 18543 RVA: 0x001E92E0 File Offset: 0x001E74E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0.Ooo__o.().Focus()
			Dim text As String = Me.o0.Ooo__o.().SelectedItem.ToString()
			If Operators.CompareString(Me.o0_Oo0oOo.Ooo_.().CurrentDir.Trim(New Char() { "/"c }), text.Trim(New Char() { "/"c }), True) <> 0 Then
				If Operators.CompareString(Me.o0_Oo0oOo.Ooo_.().RootDir, "", True) > 0 AndAlso text.Length < Me.o0_Oo0oOo.Ooo_.().RootDir.Length AndAlso Me.o0_Oo0oOo.Ooo_.().RootDir.StartsWith(text) Then
					Me.o0.Ooo__o.().SelectedItem = Me.o0_Oo0oOo.Ooo_.().CurrentDir + "/"
					MessageBox.Show("您无权访问此目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If Me.O_0O.o.(text) Then
					Me.o0_Oo0oOo.Ooo_.().ChangeDir(text)
					Me.o0_Oo0oOo.Ooo_.(False, ".")
				End If
			End If
		End Sub

		' Token: 0x06004870 RID: 18544 RVA: 0x001E93DC File Offset: 0x001E75DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim array As String() = Me.o0.Ooo__o.().Text.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries)
			Me.o0.Ooo__o.().Items.Clear()
			Me.o0.Ooo__o.().Items.Add("/")
			Dim text As String = "/"
			For Each str As String In array
				text = text + str + "/"
				Me.o0.Ooo__o.().Items.Add(text)
			Next
		End Sub

		' Token: 0x06004871 RID: 18545 RVA: 0x001E9463 File Offset: 0x001E7663
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0_Oo0oOo.Ooo_.(True, ".")
		End Sub

		' Token: 0x06004872 RID: 18546 RVA: 0x001E9474 File Offset: 0x001E7674
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = openFileDialog.FileName
				Dim ftpuploadEventArgs As FTPUploadEventArgs = New FTPUploadEventArgs(fileName, Me.o0_Oo0oOo.Ooo_.().CurrentDir, Me.o0_Oo0oOo.Ooo_.().FTPName)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeUpload", New Object() { ftpuploadEventArgs }, True, "FTP", False)
				If Not ftpuploadEventArgs.CancelAll AndAlso Not ftpuploadEventArgs.Cancel Then
					Dim name As String = OO_00oOO.FileSys.GetName(openFileDialog.FileName)
					Dim num As Integer = Me.o0.Ooo__o.().Rows.Count - 1
					For i As Integer = 1 To num
						If Operators.CompareString(Me.o0.Ooo__o.().GetData(i, 0).ToString(), name, True) = 0 AndAlso MessageBox.Show("文件""" + name + """已经存在，是否覆盖?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
							Return
						End If
					Next
					Dim text As String = "/" + Me.o0_Oo0oOo.Ooo_.().CurrentDir.Trim(New Char() { "/"c }) + "/" + OO_00oOO.FileSys.GetName(fileName)
					New FileInfo(fileName)
					If text.StartsWith("//") Then
						text = text.Substring(1)
					End If
					Me.o_0O0.OO00. = True
					If Me.o0_Oo0oOo.Ooo_.().Upload(fileName, text, True) Then
						Me.o0_Oo0oOo.Ooo_.(True, OO_00oOO.FileSys.GetName(fileName))
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterUpload", New Object() { ftpuploadEventArgs }, True, "FTP", False)
					End If
					Me.o_0O0.OO00. = False
				End If
			End If
		End Sub

		' Token: 0x06004873 RID: 18547 RVA: 0x001E960C File Offset: 0x001E780C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("新建目录", "输入目录名称:", "")
			If o_u3000_u.ShowDialog() = DialogResult.OK AndAlso Operators.CompareString(o_u3000_u.Value, "", True) > 0 Then
				Dim a_ As String = Me.o0_Oo0oOo.Ooo_.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + o_u3000_u.Value
				Dim ftpfolderEventArgs As FTPFolderEventArgs = New FTPFolderEventArgs(a_, Me.o0_Oo0oOo.Ooo_.().FTPName)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCreateFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
				If Not ftpfolderEventArgs.Cancel AndAlso Me.o0_Oo0oOo.Ooo_.().MakeDir(o_u3000_u.Value) Then
					Me.o0_Oo0oOo.Ooo_.(True, o_u3000_u.Value)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterCreateFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
				End If
			End If
		End Sub

		' Token: 0x06004874 RID: 18548 RVA: 0x001E96FC File Offset: 0x001E78FC
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim ftpfolderEventArgs As FTPFolderEventArgs = New FTPFolderEventArgs(A_0, Me.o0_Oo0oOo.Ooo_.().FTPName)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeEnterFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
			Return Not ftpfolderEventArgs.Cancel
		End Function

		' Token: 0x04001D81 RID: 7553
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001D82 RID: 7554
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D83 RID: 7555
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001D84 RID: 7556
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D85 RID: 7557
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001D86 RID: 7558
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001D87 RID: 7559
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001D88 RID: 7560
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D89 RID: 7561
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D8A RID: 7562
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D8B RID: 7563
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04001D8C RID: 7564
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001D8D RID: 7565
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001D8E RID: 7566
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
