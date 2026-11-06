Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002DA RID: 730
	<DesignerGenerated()>
	Friend Partial Class d0
		Inherits Form

		' Token: 0x060026B0 RID: 9904 RVA: 0x001068D0 File Offset: 0x00104AD0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O00_._. IsNot Nothing Then
					Me.O00_._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060026B1 RID: 9905 RVA: 0x00106910 File Offset: 0x00104B10
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(d0))
			Me.o_0O._O_O.(New C1Button())
			Me.oO_0oO.oo_.(New C1FlexGrid())
			Me.oO_0oO.oo_.(New C1Button())
			Me.O00_._.(New C1TextBox())
			Me.O00_._.(New Label())
			Me.oO_0oO.oo_.(New C1ComboBox())
			Me.O.__OO.().BeginInit()
			MyBase.SuspendLayout()
			Me.oo0.oo.().Location = New Point(475, 468)
			Me.oo0.oo.().Name = "btnCancel"
			Me.oo0.oo.().Size = New Size(75, 23)
			Me.oo0.oo.().TabIndex = 12
			Me.oo0.oo.().Text = "取消"
			Me.oo0.oo.().UseVisualStyleBackColor = True
			Me.O.__OO.().AllowDragging = 0
			Me.O.__OO.().AllowEditing = False
			Me.O.__OO.().BorderStyle = 4
			Me.O.__OO.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.O.__OO.().ExtendLastCol = True
			Me.O.__OO.().FocusRect = 0
			Me.O.__OO.().Location = New Point(11, 37)
			Me.O.__OO.().Name = "C1FlexGrid1"
			Me.O.__OO.().Rows.Count = 2
			Me.O.__OO.().Rows.DefaultSize = 19
			Me.O.__OO.().SelectionMode = 7
			Me.O.__OO.().Size = New Size(538, 328)
			Me.O.__OO.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.O.__OO.().TabIndex = 7
			Me.O.__OO.().VisualStyle = 1
			Me.O.__OO.().Location = New Point(394, 468)
			Me.O.__OO.().Name = "btnOK"
			Me.O.__OO.().Size = New Size(75, 23)
			Me.O.__OO.().TabIndex = 13
			Me.O.__OO.().Text = "确定"
			Me.O.__OO.().UseVisualStyleBackColor = True
			Me.oO_0oO.oo_.().ForeColor = Color.Blue
			Me.oO_0oO.oo_.().Location = New Point(12, 371)
			Me.oO_0oO.oo_.().Multiline = True
			Me.oO_0oO.oo_.().Name = "TextBox1"
			Me.oO_0oO.oo_.().ScrollBars = ScrollBars.Vertical
			Me.oO_0oO.oo_.().Size = New Size(538, 86)
			Me.oO_0oO.oo_.().TabIndex = 14
			Me.oO_0oO.oo_.().AutoSize = True
			Me.oO_0oO.oo_.().Location = New Point(9, 13)
			Me.oO_0oO.oo_.().Name = "Label1"
			Me.oO_0oO.oo_.().Size = New Size(53, 12)
			Me.oO_0oO.oo_.().TabIndex = 15
			Me.oO_0oO.oo_.().Text = "FTP路径:"
			Me.O.__OO.().Location = New Point(72, 10)
			Me.O.__OO.().Name = "cmbFTPPath"
			Me.O.__OO.().Size = New Size(477, 20)
			Me.O.__OO.().TabIndex = 20
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(561, 502)
			MyBase.Controls.Add(Me.O.__OO.())
			MyBase.Controls.Add(Me.oO_0oO.oo_.())
			MyBase.Controls.Add(Me.oO_0oO.oo_.())
			MyBase.Controls.Add(Me.O.__OO.())
			MyBase.Controls.Add(Me.oo0.oo.())
			MyBase.Controls.Add(Me.O.__OO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o..o.0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择目录"
			Me.O.__OO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060026B2 RID: 9906 RVA: 0x00106D46 File Offset: 0x00104F46
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00_._.
		End Function

		' Token: 0x060026B3 RID: 9907 RVA: 0x00106D50 File Offset: 0x00104F50
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo.oo__.
			Dim o00_._. As C1Button = Me.O00_._.
			If o00_._. IsNot Nothing Then
				RemoveHandler o00_._..Click, value
			End If
			Me.O00_._. = A_0
			o00_._. = Me.O00_._.
			If o00_._. IsNot Nothing Then
				AddHandler o00_._..Click, value
			End If
		End Sub

		' Token: 0x060026B4 RID: 9908 RVA: 0x00106D93 File Offset: 0x00104F93
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O00_._.
		End Function

		' Token: 0x060026B5 RID: 9909 RVA: 0x00106D9C File Offset: 0x00104F9C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim sortColEventHandler As SortColEventHandler = AddressOf Me.O0O_.oO.
			Dim value As EventHandler = AddressOf Me.oO__00._O.
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.O0O_.oO.
			Dim o00_._. As C1FlexGrid = Me.O00_._.
			If o00_._. IsNot Nothing Then
				o00_._..AfterSort -= sortColEventHandler
				RemoveHandler o00_._..DoubleClick, value
				o00_._..OwnerDrawCell -= ownerDrawCellEventHandler
			End If
			Me.O00_._. = A_0
			o00_._. = Me.O00_._.
			If o00_._. IsNot Nothing Then
				o00_._..AfterSort += sortColEventHandler
				AddHandler o00_._..DoubleClick, value
				o00_._..OwnerDrawCell += ownerDrawCellEventHandler
			End If
		End Sub

		' Token: 0x060026B6 RID: 9910 RVA: 0x00106E15 File Offset: 0x00105015
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o._0_0o.
		End Function

		' Token: 0x060026B7 RID: 9911 RVA: 0x00106E20 File Offset: 0x00105020
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o._ooOOoooO000.
			Dim c1Button As C1Button = Me.o._0_0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o._0_0o. = A_0
			c1Button = Me.o._0_0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060026B8 RID: 9912 RVA: 0x00106E63 File Offset: 0x00105063
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O00_._.
		End Function

		' Token: 0x060026B9 RID: 9913 RVA: 0x00106E6B File Offset: 0x0010506B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O00_._. = A_0
		End Sub

		' Token: 0x060026BA RID: 9914 RVA: 0x00106E74 File Offset: 0x00105074
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O00_._.
		End Function

		' Token: 0x060026BB RID: 9915 RVA: 0x00106E7C File Offset: 0x0010507C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O00_._. = A_0
		End Sub

		' Token: 0x060026BC RID: 9916 RVA: 0x00106E85 File Offset: 0x00105085
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O00_._.
		End Function

		' Token: 0x060026BD RID: 9917 RVA: 0x00106E90 File Offset: 0x00105090
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim value As KeyEventHandler = AddressOf Me.O0O_.oO.
			Dim value2 As KeyPressEventHandler = AddressOf Me.O0O_.oO.
			Dim eventHandler As EventHandler = AddressOf Me.O0.Oo0O_o.
			Dim value3 As EventHandler = AddressOf Me.O0O_.oO.
			Dim o00_._. As C1ComboBox = Me.O00_._.
			If o00_._. IsNot Nothing Then
				RemoveHandler o00_._..KeyDown, value
				RemoveHandler o00_._..KeyPress, value2
				o00_._..SelectedIndexChanged -= eventHandler
				RemoveHandler o00_._..Enter, value3
			End If
			Me.O00_._. = A_0
			o00_._. = Me.O00_._.
			If o00_._. IsNot Nothing Then
				AddHandler o00_._..KeyDown, value
				AddHandler o00_._..KeyPress, value2
				o00_._..SelectedIndexChanged += eventHandler
				AddHandler o00_._..Enter, value3
			End If
		End Sub

		' Token: 0x060026BE RID: 9918 RVA: 0x00106F30 File Offset: 0x00105130
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As FTPClient
			Return Me.O00_._.
		End Function

		' Token: 0x060026BF RID: 9919 RVA: 0x00106F38 File Offset: 0x00105138
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As FTPClient)
			Dim a_ As FTPClient.OooO_O0O_0_O = AddressOf Me.O.__OO.
			Dim a_2 As FTPClient.OoO_00_o = AddressOf Me.O.__OO.
			Dim a_3 As FTPClient.OOOOO00OoOOo = AddressOf Me.O.__OO.
			Dim o00_._. As FTPClient = Me.O00_._.
			If o00_._. IsNot Nothing Then
				RemoveHandler o00_._..ServerConnected, a_
				RemoveHandler o00_._..ShowError, a_2
				RemoveHandler o00_._..ShowMessage, a_3
			End If
			Me.O00_._. = A_0
			o00_._. = Me.O00_._.
			If o00_._. IsNot Nothing Then
				AddHandler o00_._..ServerConnected, a_
				AddHandler o00_._..ShowError, a_2
				AddHandler o00_._..ShowMessage, a_3
			End If
		End Sub

		' Token: 0x060026C0 RID: 9920 RVA: 0x00106FB4 File Offset: 0x001051B4
		Public Sub New(A_0 As FTPClient, Optional A_1 As String = "")
			AddHandler MyBase.Activated, AddressOf Me.Oooo.o0O00o.
			AddHandler MyBase.FormClosed, AddressOf Me.O.__OO.
			AddHandler MyBase.Load, AddressOf Me.oO0Oo0.Oo0.
			Me.O0OO.o00O00o. = True
			Me.O.o_oo_o00OOO_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oO_0oO.oo_.(A_0)
			If Operators.CompareString(A_1, "", True) > 0 Then
				Me.oO_0oO.oo_.().ChangeDir(A_1)
			End If
			Me.O.__OO.().Styles.Focus.MergeWith(Me.O.__OO.().Styles.Highlight)
			Me.O.__OO.().Styles.EmptyArea.Border.Style = 0
			Me.O.__OO.().Styles.EmptyArea.BackColor = Me.O.__OO.().Styles.Normal.BackColor
			Me.O.__OO.().DrawMode = 1
			Me.O.__OO.().Cols(1).Format = "yyyy-MM-dd HH:mm"
			Me.O.__OO.().Value = Me.oO_0oO.oo_.().CurrentDir
		End Sub

		' Token: 0x060026C1 RID: 9921 RVA: 0x001070E8 File Offset: 0x001052E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.O0OO.o00O00o. Then
				Me.O.__OO.().SelectionMode = 3
			End If
		End Sub

		' Token: 0x060026C2 RID: 9922 RVA: 0x001070FE File Offset: 0x001052FE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Me.oO_0oO.oo_.(Nothing)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x060026C3 RID: 9923 RVA: 0x00107117 File Offset: 0x00105317
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0O._O_O.()
		End Sub

		' Token: 0x060026C4 RID: 9924 RVA: 0x00107120 File Offset: 0x00105320
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.oO_0oO.oo_.().Ooo_Oo_O0.00O..ContainsKey(Me.oO_0oO.oo_.().CurrentDir) Then
					GoTo IL_46
				End If
				IL_26:
				num2 = 3
				Dim a_ As List(Of String) = Me.oO_0oO.oo_.().Ooo_Oo_O0.00O.(Me.oO_0oO.oo_.().CurrentDir)
				GoTo IL_59
				IL_46:
				num2 = 5
				a_ = Me.oO_0oO.oo_.().GetDetailList("")
				IL_59:
				num2 = 6
				Dim ftpbeforeListDetailsEventArgs As FTPBeforeListDetailsEventArgs = New FTPBeforeListDetailsEventArgs(Me.oO_0oO.oo_.().CurrentDir, a_, Me.oO_0oO.oo_.().FTPName)
				IL_79:
				num2 = 7
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeListDetails", New Object() { ftpbeforeListDetailsEventArgs }, True, "FTP", False)
				IL_9D:
				num2 = 8
				Dim array As String() = ftpbeforeListDetailsEventArgs.RemovedItems
				IL_A8:
				num2 = 9
				Me.O.__OO.().Rows.Count = 1
				IL_BC:
				num2 = 10
				Me.O.__OO.().BeginUpdate()
				IL_CA:
				num2 = 11
				Dim enumerator As List(Of String()).Enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator()
				While enumerator.MoveNext()
					Dim array2 As String() = enumerator.Current
					IL_E9:
					num2 = 12
					If Operators.CompareString(array2(2), "D", True) = 0 Then
						IL_FD:
						num2 = 14
						If Array.BinarySearch(Of String)(array, array2(0)) < 0 Then
							IL_10E:
							num2 = 16
							Me.O.__OO.().AddItem(String.Concat(New String() { array2(0), vbTab, array2(1), vbTab & " " & vbTab, Conversions.ToString(1) }))
							IL_14F:
							num2 = 17
							Me.O.__OO.().SetCellImage(Me.O.__OO.().Rows.Count - 1, 0, a.oO0O_O.__oo.().ToBitmap())
						End If
					End If
					IL_17A:
					num2 = 18
				End While
				IL_189:
				num2 = 19
				CType(enumerator, IDisposable).Dispose()
				IL_199:
				num2 = 20
				If Operators.CompareString(Me.oO_0oO.oo_.().CurrentDir, "/", True) = 0 Then
					GoTo IL_22C
				End If
				IL_1B4:
				num2 = 21
				Me.O.__OO.().AddItem("..", 1)
				IL_1C9:
				num2 = 22
				Me.O.__OO.().SetData(1, 3, 0)
				IL_1E0:
				num2 = 23
				Me.O.__OO.().SetCellImage(1, 0, a.o___o.00Oo__.().ToBitmap())
				IL_1FA:
				num2 = 24
				If Me.O.__OO.().Rows.Count <= 2 Then
					GoTo IL_25C
				End If
				IL_210:
				num2 = 25
				Me.O.__OO.().Rows(2).Selected = True
				GoTo IL_25C
				IL_22C:
				num2 = 27
				If Me.O.__OO.().Rows.Count <= 1 Then
					GoTo IL_25C
				End If
				IL_242:
				num2 = 28
				Me.O.__OO.().Rows(1).Selected = True
				IL_25C:
				num2 = 29
				Me.O.__OO.().EndUpdate()
				IL_26A:
				GoTo IL_334
				IL_26F:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2F5:
				GoTo IL_329
				IL_2F7:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_307:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2F7
			End Try
			IL_329:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_334:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060026C5 RID: 9925 RVA: 0x00107488 File Offset: 0x00105688
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SortColEventArgs)
			If Me.O.__OO.().Row > 0 Then
				Me.O.__OO.().Sort(1, 3)
				Me.O.__OO.().ShowCell(Me.O.__OO.().Row, Me.O.__OO.().Col)
			End If
		End Sub

		' Token: 0x060026C6 RID: 9926 RVA: 0x001074C8 File Offset: 0x001056C8
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
				If Me.O.__OO.().Row <= 0 Then
					GoTo IL_1FB
				End If
				IL_1A:
				num2 = 3
				If Operators.CompareString(Me.O.__OO.()(Me.O.__OO.().Row, 3).ToString(), "1", True) <> 0 Then
					GoTo IL_CE
				End If
				IL_48:
				num2 = 4
				Dim text As String = Me.O.__OO.()(Me.O.__OO.().Row, 0).ToString()
				IL_67:
				num2 = 5
				If Not Me.OOOOo.o000.(Me.oO_0oO.oo_.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + text) Then
					GoTo IL_1FB
				End If
				IL_9A:
				num2 = 7
				Me.oO_0oO.oo_.().ChangeDir(text)
				IL_A8:
				num2 = 8
				Me.o_0O._O_O.()
				IL_B0:
				num2 = 9
				Me.O.__OO.().Value = Me.oO_0oO.oo_.().CurrentDir
				GoTo IL_1FB
				IL_CE:
				num2 = 11
				If Operators.CompareString(Me.O.__OO.()(Me.O.__OO.().Row, 3).ToString(), "0", True) <> 0 Then
					GoTo IL_1FB
				End If
				IL_FD:
				num2 = 12
				Dim text2 As String = Me.oO_0oO.oo_.().CurrentDir
				IL_10D:
				num2 = 13
				Dim array As String() = text2.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_125:
				num2 = 14
				If array.Length <= 0 Then
					GoTo IL_1D9
				End If
				IL_132:
				num2 = 15
				text2 = text2.Substring(0, text2.LastIndexOf("/") + 1)
				IL_14D:
				num2 = 16
				If Operators.CompareString(Me.oO_0oO.oo_.().RootDir, "", True) <= 0 Then
					GoTo IL_1B1
				End If
				IL_169:
				num2 = 17
				If text2.Length >= Me.oO_0oO.oo_.().RootDir.Length OrElse Not Me.oO_0oO.oo_.().RootDir.StartsWith(text2) Then
					GoTo IL_1B1
				End If
				IL_199:
				num2 = 18
				MessageBox.Show("您无权访问上级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_1FB
				IL_1B1:
				num2 = 20
				If Not Me.OOOOo.o000.(text2) Then
					GoTo IL_1FB
				End If
				IL_1BE:
				num2 = 22
				Me.oO_0oO.oo_.().ChangeDir(text2)
				IL_1CE:
				num2 = 23
				Me.o_0O._O_O.()
				GoTo IL_1E2
				IL_1D9:
				num2 = 25
				Me.o_0O._O_O.()
				IL_1E2:
				num2 = 26
				Me.O.__OO.().Value = Me.oO_0oO.oo_.().CurrentDir
				IL_1FB:
				GoTo IL_2B9
				IL_200:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_27A:
				GoTo IL_2AE
				IL_27C:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_28C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27C
			End Try
			IL_2AE:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2B9:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060026C7 RID: 9927 RVA: 0x001077B4 File Offset: 0x001059B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0OO.o00O00o. = Me.O.__OO.().Text
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060026C8 RID: 9928 RVA: 0x001077CE File Offset: 0x001059CE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x060026C9 RID: 9929 RVA: 0x001077D7 File Offset: 0x001059D7
		Private Sub <<EMPTY_NAME>>()
			Me.o_0O._O_O.()
		End Sub

		' Token: 0x060026CA RID: 9930 RVA: 0x001077E0 File Offset: 0x001059E0
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Me.oO_0oO.oo_.().AppendText(String.Concat(New String() { "[", Strings.Format(DateTime.Now, "HH:mm:ss"), "] ", A_0, ",服务器返回信息:", A_1 }))
			Me.oO_0oO.oo_.().AppendText(vbCrLf)
		End Sub

		' Token: 0x060026CB RID: 9931 RVA: 0x0010784C File Offset: 0x00105A4C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If MyBase.Visible Then
				Me.oO_0oO.oo_.().AppendText("[" + Strings.Format(DateTime.Now, "HH:mm:ss") + "] " + A_0)
				Me.oO_0oO.oo_.().AppendText(vbCrLf)
			End If
		End Sub

		' Token: 0x060026CC RID: 9932 RVA: 0x001078A0 File Offset: 0x00105AA0
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

		' Token: 0x060026CD RID: 9933 RVA: 0x0010793C File Offset: 0x00105B3C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			A_1.Handled = True
		End Sub

		' Token: 0x060026CE RID: 9934 RVA: 0x00107945 File Offset: 0x00105B45
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			A_1.Handled = True
		End Sub

		' Token: 0x060026CF RID: 9935 RVA: 0x00107950 File Offset: 0x00105B50
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.__OO.().Focus()
			Dim text As String = Me.O.__OO.().SelectedItem.ToString()
			If Operators.CompareString(Me.oO_0oO.oo_.().CurrentDir.Trim(New Char() { "/"c }), text.Trim(New Char() { "/"c }), True) <> 0 Then
				If Operators.CompareString(Me.oO_0oO.oo_.().RootDir, "", True) > 0 AndAlso text.Length < Me.oO_0oO.oo_.().RootDir.Length AndAlso Me.oO_0oO.oo_.().RootDir.StartsWith(text) Then
					Me.O.__OO.().SelectedItem = Me.oO_0oO.oo_.().CurrentDir + "/"
					MessageBox.Show("您无权访问此目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If Me.OOOOo.o000.(text) Then
					Me.oO_0oO.oo_.().ChangeDir(text)
					Me.o_0O._O_O.()
				End If
			End If
		End Sub

		' Token: 0x060026D0 RID: 9936 RVA: 0x00107A44 File Offset: 0x00105C44
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim array As String() = Me.O.__OO.().Text.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries)
			Me.O.__OO.().Items.Clear()
			Me.O.__OO.().Items.Add("/")
			Dim text As String = "/"
			For Each str As String In array
				text = text + str + "/"
				Me.O.__OO.().Items.Add(text)
			Next
		End Sub

		' Token: 0x060026D1 RID: 9937 RVA: 0x00107ACC File Offset: 0x00105CCC
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim ftpfolderEventArgs As FTPFolderEventArgs = New FTPFolderEventArgs(A_0, Me.oO_0oO.oo_.().FTPName)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeEnterFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
			Return Not ftpfolderEventArgs.Cancel
		End Function

		' Token: 0x04001009 RID: 4105
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400100A RID: 4106
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400100B RID: 4107
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x0400100C RID: 4108
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400100D RID: 4109
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400100E RID: 4110
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400100F RID: 4111
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001010 RID: 4112
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04001011 RID: 4113
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001012 RID: 4114
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
