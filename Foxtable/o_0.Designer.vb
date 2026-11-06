Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Foxtable.My.Resources
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200029F RID: 671
	<DesignerGenerated()>
	Friend Class o_0
		Inherits UserControl

		' Token: 0x060022BD RID: 8893 RVA: 0x000EEDFC File Offset: 0x000ECFFC
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.oOo0O.___ooOO0. IsNot Nothing Then
					Me.oOo0O.___ooOO0..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060022BE RID: 8894 RVA: 0x000EEE3C File Offset: 0x000ED03C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OOOO0_o_o._o.(New System.Windows.Forms.TreeView())
			Me.oOOoo.o.(New System.Windows.Forms.Button())
			Me.o_0o.O__0_0O.(New System.Windows.Forms.Button())
			Me.oO.Oo0__O_.(New System.Windows.Forms.Button())
			Me.o000.oO0.(New System.Windows.Forms.Button())
			Me.OOOO0_o_o._o.(New System.Windows.Forms.TextBox())
			Me.o000.oO0.(New System.Windows.Forms.Panel())
			Me.OOOO_.o.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.OOOO_.o.().Dock = DockStyle.Fill
			Me.OOOO_.o.().Location = New Point(0, 0)
			Me.OOOO_.o.().Name = "tr"
			Me.OOOO_.o.().Size = New Size(178, 345)
			Me.OOOO_.o.().TabIndex = 0
			Me.OOO0o.0OO.().FlatAppearance.BorderSize = 0
			Me.OOO0o.0OO.().FlatStyle = FlatStyle.Flat
			Me.OOO0o.0OO.().Location = New Point(9, 7)
			Me.OOO0o.0OO.().Name = "btnFirst"
			Me.OOO0o.0OO.().Size = New Size(11, 12)
			Me.OOO0o.0OO.().TabIndex = 2
			Me.OOO0o.0OO.().UseVisualStyleBackColor = False
			Me.O_0o_._0o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O_0o_._0o.().FlatAppearance.BorderSize = 0
			Me.O_0o_._0o.().FlatStyle = FlatStyle.Flat
			Me.O_0o_._0o.().Location = New Point(157, 7)
			Me.O_0o_._0o.().Name = "btnLast"
			Me.O_0o_._0o.().Size = New Size(11, 12)
			Me.O_0o_._0o.().TabIndex = 3
			Me.O_0o_._0o.().UseVisualStyleBackColor = False
			Me.OOOO_.o.().FlatAppearance.BorderSize = 0
			Me.OOOO_.o.().FlatStyle = FlatStyle.Flat
			Me.OOOO_.o.().Location = New Point(26, 7)
			Me.OOOO_.o.().Name = "btnPrev"
			Me.OOOO_.o.().Size = New Size(8, 12)
			Me.OOOO_.o.().TabIndex = 4
			Me.OOOO_.o.().UseVisualStyleBackColor = False
			Me.o.OOoo_0_o__.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.o.OOoo_0_o__.().FlatAppearance.BorderSize = 0
			Me.o.OOoo_0_o__.().FlatStyle = FlatStyle.Flat
			Me.o.OOoo_0_o__.().Location = New Point(143, 7)
			Me.o.OOoo_0_o__.().Name = "btnNext"
			Me.o.OOoo_0_o__.().Size = New Size(8, 12)
			Me.o.OOoo_0_o__.().TabIndex = 5
			Me.o.OOoo_0_o__.().UseVisualStyleBackColor = False
			Me.OOOO_.o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.OOOO_.o.().Location = New Point(40, 3)
			Me.OOOO_.o.().Name = "TextBox1"
			Me.OOOO_.o.().Size = New Size(98, 21)
			Me.OOOO_.o.().TabIndex = 6
			Me.OOOO_.o.().TextAlign = HorizontalAlignment.Center
			Me.OOOO_.o.().Controls.Add(Me.OOOO_.o.())
			Me.OOOO_.o.().Controls.Add(Me.OOO0o.0OO.())
			Me.OOOO_.o.().Controls.Add(Me.o.OOoo_0_o__.())
			Me.OOOO_.o.().Controls.Add(Me.OOOO_.o.())
			Me.OOOO_.o.().Controls.Add(Me.O_0o_._0o.())
			Me.OOOO_.o.().Dock = DockStyle.Bottom
			Me.OOOO_.o.().Location = New Point(0, 345)
			Me.OOOO_.o.().Name = "Panel1"
			Me.OOOO_.o.().Size = New Size(178, 27)
			Me.OOOO_.o.().TabIndex = 7
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.Controls.Add(Me.OOOO_.o.())
			MyBase.Controls.Add(Me.OOOO_.o.())
			MyBase.Name = "O.....oo"
			MyBase.Size = New Size(178, 372)
			Me.OOOO_.o.().ResumeLayout(False)
			Me.OOOO_.o.().PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060022BF RID: 8895 RVA: 0x000EF264 File Offset: 0x000ED464
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.TreeView
			Return Me.oOo0O.___ooOO0.
		End Function

		' Token: 0x060022C0 RID: 8896 RVA: 0x000EF26C File Offset: 0x000ED46C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.o000.oO0.
			Dim value2 As TreeNodeMouseClickEventHandler = AddressOf Me.OOOO0_o_o._o.
			Dim value3 As EventHandler = AddressOf Me.o_00O.0ooo0o00.
			Dim treeView As System.Windows.Forms.TreeView = Me.oOo0O.___ooOO0.
			If treeView IsNot Nothing Then
				RemoveHandler treeView.AfterSelect, value
				RemoveHandler treeView.NodeMouseDoubleClick, value2
				RemoveHandler treeView.SizeChanged, value3
			End If
			Me.oOo0O.___ooOO0. = A_0
			treeView = Me.oOo0O.___ooOO0.
			If treeView IsNot Nothing Then
				AddHandler treeView.AfterSelect, value
				AddHandler treeView.NodeMouseDoubleClick, value2
				AddHandler treeView.SizeChanged, value3
			End If
		End Sub

		' Token: 0x060022C1 RID: 8897 RVA: 0x000EF2E5 File Offset: 0x000ED4E5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Button
			Return Me.OOOO0_o_o._o.
		End Function

		' Token: 0x060022C2 RID: 8898 RVA: 0x000EF2F0 File Offset: 0x000ED4F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Button)
			Dim value As EventHandler = AddressOf Me.o0Oo00.0O.
			Dim oooo0_o_o._o. As System.Windows.Forms.Button = Me.OOOO0_o_o._o.
			If oooo0_o_o._o. IsNot Nothing Then
				RemoveHandler oooo0_o_o._o..Click, value
			End If
			Me.OOOO0_o_o._o. = A_0
			oooo0_o_o._o. = Me.OOOO0_o_o._o.
			If oooo0_o_o._o. IsNot Nothing Then
				AddHandler oooo0_o_o._o..Click, value
			End If
		End Sub

		' Token: 0x060022C3 RID: 8899 RVA: 0x000EF333 File Offset: 0x000ED533
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Button
			Return Me.o.oO0OO_.
		End Function

		' Token: 0x060022C4 RID: 8900 RVA: 0x000EF33C File Offset: 0x000ED53C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Button)
			Dim value As EventHandler = AddressOf Me.o0Oo00.0O.
			Dim button As System.Windows.Forms.Button = Me.o.oO0OO_.
			If button IsNot Nothing Then
				RemoveHandler button.Click, value
			End If
			Me.o.oO0OO_. = A_0
			button = Me.o.oO0OO_.
			If button IsNot Nothing Then
				AddHandler button.Click, value
			End If
		End Sub

		' Token: 0x060022C5 RID: 8901 RVA: 0x000EF37F File Offset: 0x000ED57F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Button
			Return Me.o_00O.0ooo0o00.
		End Function

		' Token: 0x060022C6 RID: 8902 RVA: 0x000EF388 File Offset: 0x000ED588
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Button)
			Dim value As EventHandler = AddressOf Me.o0Oo00.0O.
			Dim button As System.Windows.Forms.Button = Me.o_00O.0ooo0o00.
			If button IsNot Nothing Then
				RemoveHandler button.Click, value
			End If
			Me.o_00O.0ooo0o00. = A_0
			button = Me.o_00O.0ooo0o00.
			If button IsNot Nothing Then
				AddHandler button.Click, value
			End If
		End Sub

		' Token: 0x060022C7 RID: 8903 RVA: 0x000EF3CB File Offset: 0x000ED5CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Button
			Return Me.O0O.000.
		End Function

		' Token: 0x060022C8 RID: 8904 RVA: 0x000EF3D4 File Offset: 0x000ED5D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Button)
			Dim value As EventHandler = AddressOf Me.o0Oo00.0O.
			Dim o0O.000. As System.Windows.Forms.Button = Me.O0O.000.
			If o0O.000. IsNot Nothing Then
				RemoveHandler o0O.000..Click, value
			End If
			Me.O0O.000. = A_0
			o0O.000. = Me.O0O.000.
			If o0O.000. IsNot Nothing Then
				AddHandler o0O.000..Click, value
			End If
		End Sub

		' Token: 0x060022C9 RID: 8905 RVA: 0x000EF417 File Offset: 0x000ED617
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.TextBox
			Return Me.oOo0O.___ooOO0.
		End Function

		' Token: 0x060022CA RID: 8906 RVA: 0x000EF420 File Offset: 0x000ED620
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TextBox)
			Dim value As KeyEventHandler = AddressOf Me.OOOO0_o_o._o.
			Dim textBox As System.Windows.Forms.TextBox = Me.oOo0O.___ooOO0.
			If textBox IsNot Nothing Then
				RemoveHandler textBox.KeyDown, value
			End If
			Me.oOo0O.___ooOO0. = A_0
			textBox = Me.oOo0O.___ooOO0.
			If textBox IsNot Nothing Then
				AddHandler textBox.KeyDown, value
			End If
		End Sub

		' Token: 0x060022CB RID: 8907 RVA: 0x000EF463 File Offset: 0x000ED663
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Panel
			Return Me.oOo0O.___ooOO0.
		End Function

		' Token: 0x060022CC RID: 8908 RVA: 0x000EF46B File Offset: 0x000ED66B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Panel)
			Me.oOo0O.___ooOO0. = A_0
		End Sub

		' Token: 0x060022CD RID: 8909 RVA: 0x000EF474 File Offset: 0x000ED674
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Button
			Return Me.Ooo_O._o.
		End Function

		' Token: 0x060022CE RID: 8910 RVA: 0x000EF47C File Offset: 0x000ED67C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Button)
			Dim value As EventHandler = AddressOf Me.OOOO_.o.
			Dim ooo_O._o. As System.Windows.Forms.Button = Me.Ooo_O._o.
			If ooo_O._o. IsNot Nothing Then
				RemoveHandler ooo_O._o..Click, value
			End If
			Me.Ooo_O._o. = A_0
			ooo_O._o. = Me.Ooo_O._o.
			If ooo_O._o. IsNot Nothing Then
				AddHandler ooo_O._o..Click, value
			End If
		End Sub

		' Token: 0x060022CF RID: 8911 RVA: 0x000EF4C0 File Offset: 0x000ED6C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.O__O_._..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_3F
				End If
				IL_27:
				num2 = 3
				Dim flag As Boolean = Me.O__O_._..DataTable.DataServerType = DataServerTypeEnum.Oracle
				GoTo IL_57
				IL_3F:
				num2 = 5
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O__O_._..DataTable.frd_Connection)
				IL_57:
				num2 = 6
				If Operators.CompareString(Me.O__O_._..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_90
				End If
				IL_77:
				num2 = 7
				Dim flag2 As Boolean = Me.O__O_._..DataTable.DataServerType = DataServerTypeEnum.SqlServer
				GoTo IL_AA
				IL_90:
				num2 = 9
				flag2 = o_O_o_oOoo__.OOOO_OO._oo.(Me.O__O_._..DataTable.frd_Connection)
				IL_AA:
				num2 = 10
				Dim text As String = ""
				IL_B4:
				num2 = 11
				If System.Windows.Forms.Control.ModifierKeys = Keys.Control AndAlso A_1.Node IsNot Me.OOOO_.o.().Nodes(0) Then
					GoTo IL_14B
				End If
				IL_DC:
				num2 = 12
				Dim enumerator As List(Of System.Windows.Forms.TreeNode).Enumerator = Me.oOo0O.___ooOO0..GetEnumerator()
				While enumerator.MoveNext()
					Dim treeNode As System.Windows.Forms.TreeNode = enumerator.Current
					IL_F7:
					num2 = 13
					treeNode.BackColor = Me.OOOO_.o.().BackColor
					IL_10C:
					num2 = 14
					treeNode.ForeColor = Me.OOOO_.o.().ForeColor
					IL_121:
					num2 = 15
				End While
				IL_12D:
				num2 = 16
				CType(enumerator, IDisposable).Dispose()
				IL_13D:
				num2 = 17
				Me.oOo0O.___ooOO0..Clear()
				IL_14B:
				num2 = 18
				If A_1.Node Is Me.OOOO_.o.().Nodes(0) Then
					GoTo IL_4D5
				End If
				IL_16A:
				num2 = 20
				Dim treeNode2 As System.Windows.Forms.TreeNode = A_1.Node
				IL_175:
				num2 = 21
				A_1.Node.BackColor = Color.Blue
				IL_188:
				num2 = 22
				A_1.Node.ForeColor = Color.White
				IL_19B:
				num2 = 23
				Me.oOo0O.___ooOO0..Add(A_1.Node)
				IL_1AF:
				num2 = 24
				Dim enumerator2 As List(Of System.Windows.Forms.TreeNode).Enumerator = Me.oOo0O.___ooOO0..GetEnumerator()
				While enumerator2.MoveNext()
					treeNode2 = enumerator2.Current
					IL_1CD:
					num2 = 25
					Dim text2 As String = ""
					IL_1D7:
					num2 = 26
					Dim level As Integer = treeNode2.Level
					IL_1E3:
					num2 = 27
					Dim array As System.Windows.Forms.TreeNode() = New System.Windows.Forms.TreeNode(level + 1 - 1) {}
					IL_1F1:
					num2 = 28
					For i As Integer = level To 0 Step -1
						IL_1FA:
						num2 = 29
						array(i) = treeNode2
						IL_204:
						num2 = 30
						treeNode2 = treeNode2.Parent
						IL_210:
						num2 = 31
					Next
					IL_21E:
					num2 = 32
					Dim num3 As Integer = level
					For j As Integer = 0 To num3
						IL_22D:
						num2 = 33
						If j > 0 Then
							IL_235:
							num2 = 34
							text2 += " And ("
						Else
							IL_248:
							num2 = 36
							text2 = "("
						End If
						IL_252:
						num2 = 37
						text2 = text2 + Me.oOo0O.___ooOO0.(j) + " ="
						IL_270:
						num2 = 38
						If Me.oOo0O.___ooOO0..Columns(j).DataType Is GetType(String) Then
							IL_296:
							num2 = 39
							text2 = text2 + "'" + array(j).Text.Replace("'", "''") + "'"
						Else
							IL_2CA:
							num2 = 41
							If Me.oOo0O.___ooOO0..Columns(j).DataType Is GetType(DateTime) Then
								IL_2F3:
								num2 = 42
								If flag Then
									IL_2F9:
									num2 = 43
									Dim dateTime As DateTime = DateTime.Parse(array(j).Text)
									IL_30D:
									num2 = 44
									Dim str As String = "'" + Strings.Format(dateTime, "MM/dd/yyyy") + "'"
									IL_332:
									num2 = 45
									text2 = text2 + "TO_DATE(" + str + ",'MM/DD/YYYY')"
								Else
									IL_34F:
									num2 = 47
									If flag2 Then
										IL_356:
										num2 = 48
										text2 = text2 + "'" + array(j).Text + "'"
									Else
										IL_37B:
										num2 = 50
										text2 = text2 + "#" + array(j).Text + "#"
									End If
								End If
							Else
								IL_3A0:
								num2 = 52
								If Me.oOo0O.___ooOO0..Columns(j).DataType Is GetType(Boolean) Then
									IL_3C6:
									num2 = 53
									If flag OrElse flag2 Then
										IL_3D0:
										num2 = 54
										If Operators.CompareString(array(j).Text, "True", True) = 0 Then
											IL_3EA:
											num2 = 55
											text2 += "1"
										Else
											IL_3FD:
											num2 = 57
											text2 = text2 + "0 or " + Me.oOo0O.___ooOO0.(j) + " Is Null"
										End If
									Else
										IL_422:
										num2 = 59
										text2 += array(j).Text
									End If
								Else
									IL_43A:
									num2 = 61
									text2 += array(j).Text
								End If
							End If
						End If
						IL_450:
						num2 = 62
						text2 += ")"
						IL_461:
						num2 = 63
					Next
					IL_473:
					num2 = 64
					If Operators.CompareString(text, "", True) > 0 Then
						IL_486:
						num2 = 65
						text = text + " or (" + text2 + ")"
					Else
						IL_4A0:
						num2 = 67
						text = "(" + text2 + ")"
					End If
					IL_4B6:
					num2 = 68
				End While
				IL_4C5:
				num2 = 69
				CType(enumerator2, IDisposable).Dispose()
				IL_4D5:
				num2 = 70
				Me.O__O_._..DataTable.LoadTop = Me.O__O_._..o.0__o0..ToString()
				IL_4F8:
				num2 = 71
				Me.O__O_._..DataTable.LoadPage = 0
				IL_50C:
				num2 = 72
				If Operators.CompareString(Me.oOo0O.___ooOO0., "", True) <= 0 OrElse Operators.CompareString(Me.oOo0O.___ooOO0., "-", True) = 0 Then
					GoTo IL_5C2
				End If
				IL_53C:
				num2 = 73
				If Operators.CompareString(text, "", True) <> 0 Then
					GoTo IL_56A
				End If
				IL_54E:
				num2 = 74
				text = "(" + Me.oOo0O.___ooOO0. + ")"
				GoTo IL_5C2
				IL_56A:
				num2 = 76
				If text.IndexOf("(" + Me.oOo0O.___ooOO0. + ")") >= 0 Then
					GoTo IL_5C2
				End If
				IL_58C:
				num2 = 77
				text = String.Concat(New String() { "(", text, ") And (", Me.oOo0O.___ooOO0., ")" })
				IL_5C2:
				num2 = 78
				Me.O__O_._..DataTable.LoadFilter = text
				IL_5D7:
				num2 = 79
				Me.O__O_._..DataTable.LoadReverse = Me.O__O_._..o00Oo.O0O.
				IL_5F5:
				num2 = 80
				If Operators.CompareString(Me.O__O_._..O0__O_.O., "", True) <= 0 Then
					GoTo IL_631
				End If
				IL_611:
				num2 = 81
				Me.O__O_._..DataTable.LoadOver = Me.O__O_._..O0__O_.O.
				GoTo IL_649
				IL_631:
				num2 = 83
				Me.O__O_._..DataTable.LoadOver = ""
				IL_649:
				num2 = 84
				Me.O__O_._..DataTable.o0.o.(True, Nothing)
				IL_65E:
				num2 = 85
				Application.DoEvents()
				IL_666:
				num2 = 86
				Me.oO.Oo0__O_.()
				IL_66F:
				GoTo IL_81D
				IL_674:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_7DE:
				GoTo IL_812
				IL_7E0:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7F0:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7E0
			End Try
			IL_812:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_81D:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060022D0 RID: 8912 RVA: 0x000EFD10 File Offset: 0x000EDF10
		Friend Sub <<EMPTY_NAME>>()
			Me.oo0o.0__o. = CInt(Math.Round(Me.O__O_._..DataTable.TotalPages))
			Me.O__O_._. = 0
			Me.OOOO_.o.().Text = Conversions.ToString(Me.O__O_._. + 1) + "/" + Conversions.ToString(Me.oo0o.0__o.)
		End Sub

		' Token: 0x060022D1 RID: 8913 RVA: 0x000EFD70 File Offset: 0x000EDF70
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Information.Err().Clear()
				IL_13:
				num2 = 3
				Me.oOo0O.___ooOO0. = New DataTable()
				IL_20:
				num2 = 4
				Me.oOo0O.___ooOO0..Clear()
				IL_2D:
				num2 = 5
				If Operators.CompareString(Me.O__O_._..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_66
				End If
				IL_4D:
				num2 = 6
				Dim flag As Boolean = Me.O__O_._..DataTable.DataServerType = DataServerTypeEnum.Oracle
				GoTo IL_7F
				IL_66:
				num2 = 8
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.O__O_._..DataTable.frd_Connection)
				IL_7F:
				num2 = 9
				If Operators.CompareString(Me.O__O_._..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_BA
				End If
				IL_A0:
				num2 = 10
				Dim flag2 As Boolean = Me.O__O_._..DataTable.DataServerType = DataServerTypeEnum.SqlServer
				GoTo IL_D4
				IL_BA:
				num2 = 12
				flag2 = o_O_o_oOoo__.OOOO_OO._oo.(Me.O__O_._..DataTable.frd_Connection)
				IL_D4:
				num2 = 13
				Dim array As String() = A_0.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_EB:
				num2 = 14
				New OleDbCommand("", Me.O__O_._..DataTable.frd_Connection)
				IL_109:
				num2 = 15
				Dim text As String = "SELECT DISTINCT "
				IL_113:
				num2 = 16
				Dim dictionary As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()
				IL_11D:
				num2 = 17
				Dim array2 As String() = array
				Dim i As Integer = 0
				While i < array2.Length
					Dim text2 As String = array2(i)
					IL_133:
					num2 = 18
					Dim array3 As String() = text2.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
					IL_14B:
					num2 = 19
					If Not Me.O__O_._..DataTable.DataCols.Contains(array3(0)) Then
						IL_169:
						num2 = 20
						array3(0) = text2
					End If
					IL_172:
					num2 = 21
					If Me.O__O_._..DataTable.DataCols.Contains(array3(0)) Then
						IL_1BE:
						num2 = 24
						If Me.O__O_._..DataTable.DataCols(array3(0)).IsTemporary Then
							IL_1E1:
							num2 = 25
							MessageBox.Show("表达式列不能用于生成加载树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							IL_1FC:
							num2 = 27
							Dim text3 As String = Oo00.OoOo_oo_.o_o.(array3(0), Me.O__O_._.)
							IL_210:
							num2 = 28
							If Operators.CompareString(text3, "", True) = 0 Then
								IL_222:
								num2 = 29
								MessageBox.Show("生成加载树失败，无效列名：" + array3(0), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								IL_241:
								num2 = 30
								result = False
								GoTo IL_BB8
							End If
							IL_24B:
							num2 = 31
							Dim num3 As Integer
							If Me.O__O_._..Cols(array3(0)).IsDate() Then
								IL_26C:
								num2 = 32
								If array3.Length = 1 Then
									IL_276:
									num2 = 33
									Me.oOo0O.___ooOO0..Add(text3)
									IL_286:
									num2 = 34
									dictionary.Add(num3, array3(0))
								Else
									IL_29B:
									num2 = 36
									If flag Then
										IL_2A2:
										num2 = 37
										Me.oOo0O.___ooOO0..Add("TO_CHAR(" + text3 + ",'YYYY')")
									Else
										IL_2C3:
										num2 = 39
										If flag2 Then
											IL_2CA:
											num2 = 40
											Me.oOo0O.___ooOO0..Add("DatePart(yyyy," + text3 + ")")
										Else
											IL_2EB:
											num2 = 42
											Me.oOo0O.___ooOO0..Add("DatePart('yyyy'," + text3 + ")")
										End If
									End If
									IL_30A:
									num2 = 43
									If Operators.CompareString(array3(1), "YQ", True) = 0 Then
										IL_31E:
										num2 = 44
										If flag Then
											IL_325:
											num2 = 45
											Me.oOo0O.___ooOO0..Add("TO_CHAR(" + text3 + ",'Q')")
										Else
											IL_346:
											num2 = 47
											If flag2 Then
												IL_34D:
												num2 = 48
												Me.oOo0O.___ooOO0..Add("DatePart(q," + text3 + ")")
											Else
												IL_36E:
												num2 = 50
												Me.oOo0O.___ooOO0..Add("DatePart('q'," + text3 + ")")
											End If
										End If
									End If
									IL_38D:
									num2 = 51
									If Operators.CompareString(array3(1), "YW", True) = 0 Then
										IL_3A4:
										num2 = 52
										If flag Then
											IL_3AB:
											num2 = 53
											Me.oOo0O.___ooOO0..Add("TO_CHAR(" + text3 + ",'WW')")
										Else
											IL_3CC:
											num2 = 55
											If flag2 Then
												IL_3D3:
												num2 = 56
												Me.oOo0O.___ooOO0..Add("DatePart(ww," + text3 + ")")
											Else
												IL_3F4:
												num2 = 58
												If Not text3.StartsWith("[") Then
													IL_405:
													num2 = 59
													Me.oOo0O.___ooOO0..Add("DatePart('ww',[" + text3 + "])")
												Else
													IL_426:
													num2 = 61
													Me.oOo0O.___ooOO0..Add("DatePart('ww'," + text3 + ")")
												End If
											End If
										End If
									End If
									IL_445:
									num2 = 62
									If Operators.CompareString(array3(1), "YM", True) = 0 OrElse Operators.CompareString(array3(1), "YMD", True) = 0 Then
										IL_46A:
										num2 = 63
										If flag Then
											IL_471:
											num2 = 64
											Me.oOo0O.___ooOO0..Add("TO_CHAR(" + text3 + ",'MM')")
										Else
											IL_492:
											num2 = 66
											If flag2 Then
												IL_499:
												num2 = 67
												Me.oOo0O.___ooOO0..Add("DatePart(m," + text3 + ")")
											Else
												IL_4BA:
												num2 = 69
												Me.oOo0O.___ooOO0..Add("DatePart('m'," + text3 + ")")
											End If
										End If
									End If
									IL_4D9:
									num2 = 70
									If Operators.CompareString(array3(1), "YMD", True) = 0 Then
										IL_4F0:
										num2 = 71
										If flag Then
											IL_4F7:
											num2 = 72
											Me.oOo0O.___ooOO0..Add("TO_CHAR(" + text3 + ",'DD')")
										Else
											IL_518:
											num2 = 74
											If flag2 Then
												IL_51F:
												num2 = 75
												Me.oOo0O.___ooOO0..Add("DatePart(d," + text3 + ")")
											Else
												IL_540:
												num2 = 77
												Me.oOo0O.___ooOO0..Add("DatePart('d'," + text3 + ")")
											End If
										End If
									End If
								End If
							Else
								IL_561:
								num2 = 79
								Me.oOo0O.___ooOO0..Add(text3)
							End If
							IL_571:
							num2 = 80
							num3 += 1
						End If
						IL_57A:
						num2 = 81
						i += 1
						Continue While
					End If
					IL_190:
					num2 = 22
					MessageBox.Show("打开加载树失败，找不到列""" + array3(0) + """!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					IL_1B4:
					num2 = 23
					result = False
					IL_BB8:
					GoTo IL_E8A
				End While
				IL_58E:
				num2 = 82
				Dim num4 As Integer = Me.oOo0O.___ooOO0..Count - 1
				For j As Integer = 0 To num4
					IL_5A8:
					num2 = 83
					Dim text4 As String = Me.oOo0O.___ooOO0.(j)
					IL_5BA:
					num2 = 84
					If text4.IndexOf(".") > 0 Then
						IL_5CC:
						num2 = 85
						text4 = text4.Substring(text4.IndexOf(".") + 1)
					End If
					IL_5E6:
					num2 = 86
					text += Me.oOo0O.___ooOO0.(j)
					IL_5FF:
					num2 = 87
					If j < Me.oOo0O.___ooOO0..Count - 1 Then
						IL_613:
						num2 = 88
						text += ","
					End If
					IL_624:
					num2 = 89
				Next
				IL_636:
				num2 = 90
				If Operators.CompareString(Me.O__O_._..DataTable.o._OOO0oOo0__., "", True) <= 0 Then
					GoTo IL_6C4
				End If
				IL_657:
				num2 = 91
				If Not flag Then
					GoTo IL_684
				End If
				IL_65E:
				num2 = 92
				text = text + " From " + Me.O__O_._..DataTable.o._OOO0oOo0__.
				GoTo IL_782
				IL_684:
				num2 = 94
				text = text + " From [" + Me.O__O_._..DataTable.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
				GoTo IL_782
				IL_6C4:
				num2 = 96
				If Operators.CompareString(Me.O__O_._..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_6FC
				End If
				IL_6E5:
				num2 = 97
				Dim a_ As String = Me.O__O_._..DataTable.HttpSelect
				GoTo IL_711
				IL_6FC:
				num2 = 99
				a_ = Me.O__O_._..DataTable.frd_SelectCommandString
				IL_711:
				num2 = 100
				Dim text5 As String = Oo00.oo_0__0.o.(a_)
				IL_71D:
				num2 = 101
				Dim regex As Regex = New Regex("[\s]+from[\s]+", RegexOptions.IgnoreCase)
				IL_72D:
				num2 = 102
				If Operators.CompareString(text5, "", True) <= 0 OrElse regex.Match(text5).Success Then
					GoTo IL_765
				End If
				IL_750:
				num2 = 103
				text = text + " From " + text5
				GoTo IL_782
				IL_765:
				num2 = 105
				text = text + " From (" + Oo00.oo_oo0o__o0.o.(a_) + ") as fox2ba54"
				IL_782:
				num2 = 106
				If Operators.CompareString(Me.oOo0O.___ooOO0., "", True) <= 0 OrElse Operators.CompareString(Me.oOo0O.___ooOO0., "-", True) = 0 Then
					GoTo IL_7C3
				End If
				IL_7AC:
				num2 = 107
				text = text + " Where " + Me.oOo0O.___ooOO0.
				IL_7C3:
				num2 = 108
				If Operators.CompareString(Me.O__O_._..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_85D
				End If
				IL_7E4:
				num2 = 109
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.O__O_._..DataTable.ConnectionName).oO0_0.o.()
				IL_808:
				num2 = 110
				httpClient.FormData.Add("IgnoreSchema", "True")
				IL_821:
				num2 = 111
				httpClient.[Select] = text
				IL_82D:
				num2 = 112
				Dim dictionary2 As Dictionary(Of String, String) = httpClient.FormData
				Dim key As String = "Action"
				Dim num5 As Integer = 2
				dictionary2(key) = num5.ToString()
				IL_84B:
				num2 = 113
				Me.oOo0O.___ooOO0. = httpClient.GetBaseDataTable()
				GoTo IL_88A
				IL_85D:
				num2 = 115
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, Me.O__O_._..DataTable.frd_Connection)
				IL_879:
				num2 = 116
				oleDbDataAdapter.Fill(Me.oOo0O.___ooOO0.)
				IL_88A:
				num2 = 117
				If Me.oOo0O.___ooOO0. IsNot Nothing AndAlso Me.oOo0O.___ooOO0..Columns.Count <> 0 Then
					GoTo IL_8FD
				End If
				IL_8A7:
				num2 = 118
				If Information.Err().Number = 0 Then
					GoTo IL_8DD
				End If
				IL_8B6:
				num2 = 119
				MessageBox.Show("打开加载树失败，错误信息 :" & vbCrLf + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				GoTo IL_8F3
				IL_8DD:
				num2 = 121
				MessageBox.Show("无法获取生成加载树所需数据,打开加载树失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_8F3:
				num2 = 122
				result = False
				GoTo IL_BB8
				IL_8FD:
				num2 = 123
				array = New String(Me.oOo0O.___ooOO0..Columns.Count - 1 + 1 - 1) {}
				IL_91B:
				num2 = 124
				num5 = Me.oOo0O.___ooOO0..Columns.Count - 1
				For k As Integer = 0 To num5
					IL_937:
					num2 = 125
					Me.oOo0O.___ooOO0..Columns(k).ColumnName = "A" + Conversions.ToString(k)
					IL_962:
					num2 = 126
					array(k) = "A" + Conversions.ToString(k)
					IL_97B:
					num2 = 127
				Next
				IL_98A:
				num2 = 128
				oOO0oo_o0.O.ooooo.(Me.OOOO_.o.(), Me.oOo0O.___ooOO0., "", "", "", String.Join("|", array), False)
				IL_9BD:
				num2 = 129
				If Not Me.oOo0O.___ooOO0. Then
					GoTo IL_9E8
				End If
				IL_9CB:
				num2 = 130
				Me.OOOO_.o.().Nodes.Insert(0, "加载所有行")
				IL_9E8:
				num2 = 131
				If dictionary.Count <= 0 Then
					GoTo IL_B9A
				End If
				IL_9FB:
				num2 = 132
				Dim treeView As Foxtable.WinForm.TreeView = New Foxtable.WinForm.TreeView(Me.OOOO_.o.())
				IL_A0E:
				num2 = 133
				Dim enumerator As Dictionary(Of Integer, String).KeyCollection.Enumerator = dictionary.Keys.GetEnumerator()
				Dim style As String
				While enumerator.MoveNext()
					Dim num3 As Integer = enumerator.Current
					IL_A30:
					num2 = 134
					Dim a_2 As String = dictionary(num3)
					IL_A41:
					num2 = 135
					style = "yyyy-MM-dd"
					IL_A4E:
					num2 = 136
					Select Case Me.O__O_._..Cols(a_2).DataCol.DateTimeFormat
						Case 0
							IL_A8F:
							num2 = 138
							style = "yyyy-MM-dd"
						Case 1
							IL_ABC:
							num2 = 144
							style = "HH:mm"
						Case 3
							IL_A9E:
							num2 = 140
							style = "yyyy-MM-dd HH:mm"
						Case 4
							IL_AAD:
							num2 = 142
							style = "yyyy-MM-dd HH:mm:ss"
					End Select
					IL_AD8:
					num2 = 148
					treeView.StopRedraw()
					IL_AE5:
					num2 = 149
					Dim enumerator2 As List(Of Foxtable.WinForm.TreeNode).Enumerator = treeView.AllNodes.GetEnumerator()
					While enumerator2.MoveNext()
						Dim treeNode As Foxtable.WinForm.TreeNode = enumerator2.Current
						IL_B04:
						num2 = 150
						If treeNode.Level = num3 Then
							IL_B15:
							num2 = 151
							Dim dateTime As DateTime
							If DateTime.TryParse(treeNode.Text, dateTime) Then
								IL_B2B:
								num2 = 152
								treeNode.Text = Strings.Format(dateTime, style)
							End If
						End If
						IL_B46:
						num2 = 153
					End While
					IL_B55:
					num2 = 154
					CType(enumerator2, IDisposable).Dispose()
					IL_B68:
					num2 = 155
					treeView.ResumeRedraw()
					IL_B75:
					num2 = 156
				End While
				IL_B87:
				num2 = 157
				CType(enumerator, IDisposable).Dispose()
				IL_B9A:
				num2 = 158
				Me.oOo0O.___ooOO0..Rows.Clear()
				IL_BB0:
				num2 = 159
				result = True
				GoTo IL_BB8
				IL_ACB:
				num2 = 146
				style = "HH:mm:ss"
				GoTo IL_AD8
				IL_BBD:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_E4B:
				GoTo IL_E7F
				IL_E4D:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_E5D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E4D
			End Try
			IL_E7F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E8A:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060022D2 RID: 8914 RVA: 0x000F0C2C File Offset: 0x000EEE2C
		Friend Sub New(A_0 As Table, A_1 As String, A_2 As String)
			AddHandler MyBase.ParentChanged, AddressOf Me.O.0O_o0.
			Me.oOo0O.___ooOO0. = New List(Of String)()
			Me.oOo0O.___ooOO0. = New List(Of System.Windows.Forms.TreeNode)()
			Me.oOo0O.___ooOO0. = ""
			Me.o000.oO0.()
			Me.O__O_._. = A_0
			Me.oOo0O.___ooOO0. = A_2
			Me.o000.oO0.(A_1)
			Me.OOO0o.0OO.().Image = OO_00oOO.GetImage("first.ico")
			Me.OOOO_.o.().Image = OO_00oOO.GetImage("prev.ico")
			Me.o.OOoo_0_o__.().Image = OO_00oOO.GetImage("next.ico")
			Me.O_0o_._0o.().Image = OO_00oOO.GetImage("last.ico")
		End Sub

		' Token: 0x060022D3 RID: 8915 RVA: 0x000F0CE4 File Offset: 0x000EEEE4
		Friend Sub New()
			AddHandler MyBase.ParentChanged, AddressOf Me.O.0O_o0.
			Me.oOo0O.___ooOO0. = New List(Of String)()
			Me.oOo0O.___ooOO0. = New List(Of System.Windows.Forms.TreeNode)()
			Me.oOo0O.___ooOO0. = ""
			Me.o000.oO0.()
			Me.OOO0o.0OO.().Image = OO_00oOO.GetImage("first.ico")
			Me.OOOO_.o.().Image = OO_00oOO.GetImage("prev.ico")
			Me.o.OOoo_0_o__.().Image = OO_00oOO.GetImage("next.ico")
			Me.O_0o_._0o.().Image = OO_00oOO.GetImage("last.ico")
		End Sub

		' Token: 0x060022D4 RID: 8916 RVA: 0x000F0D84 File Offset: 0x000EEF84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OOOO_.o.().[Select]()
			Dim name As String = CType(A_0, System.Windows.Forms.Button).Name
			If Operators.CompareString(name, "btnFirst", True) = 0 Then
				If Me.O__O_._. <= 0 Then
					Return
				End If
				Me.O__O_._. = 0
			ElseIf Operators.CompareString(name, "btnPrev", True) = 0 Then
				If Me.O__O_._. <= 0 Then
					Return
				End If
				Me.O__O_._. -= 1
			ElseIf Operators.CompareString(name, "btnNext", True) = 0 Then
				If Me.O__O_._. >= Me.oo0o.0__o. - 1 Then
					Return
				End If
				Me.O__O_._. += 1
			ElseIf Operators.CompareString(name, "btnLast", True) = 0 Then
				If Me.O__O_._. >= Me.oo0o.0__o. - 1 Then
					Return
				End If
				Me.O__O_._. = Me.oo0o.0__o. - 1
			End If
			Me.O__O_._..DataTable.LoadPage = Me.O__O_._.
			Me.O__O_._..DataTable.o0.o.(True, Nothing)
			Me.OOOO_.o.().Text = Conversions.ToString(Me.O__O_._. + 1) + "/" + Conversions.ToString(Me.oo0o.0__o.)
		End Sub

		' Token: 0x060022D5 RID: 8917 RVA: 0x000F0EAC File Offset: 0x000EF0AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeNodeMouseClickEventArgs)
			If A_1.Node Is Me.OOOO_.o.().SelectedNode Then
				Dim a_ As TreeViewEventArgs = New TreeViewEventArgs(A_1.Node)
				Me.o000.oO0.(Me.OOOO_.o.(), a_)
			End If
		End Sub

		' Token: 0x060022D6 RID: 8918 RVA: 0x000F0EE8 File Offset: 0x000EF0E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			For Each control As System.Windows.Forms.Control In New System.Windows.Forms.Control() { Me.OOOO_.o.(), Me.OOO0o.0OO.(), Me.OOOO_.o.(), Me.o.OOoo_0_o__.(), Me.O_0o_._0o.() }
				control.Top = (Me.OOOO_.o.().ClientSize.Height - control.Height) / 2
			Next
		End Sub

		' Token: 0x060022D7 RID: 8919 RVA: 0x000F0F60 File Offset: 0x000EF160
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.0O_o0.() Is Nothing Then
				Me.OO.0OO__00.(New System.Windows.Forms.Button())
				Me.O.0O_o0.().FlatStyle = FlatStyle.Flat
				Me.O.0O_o0.().FlatAppearance.BorderSize = 0
				Me.O.0O_o0.().Text = ""
				Me.O.0O_o0.().Size = New Size(18, 18)
				Me.O.0O_o0.().Location = New Point(Me.OOOO_.o.().Width - 30, Me.OOOO_.o.().Height - 30)
				Me.O.0O_o0.().Image = a.Oo.OOO_o.().ToBitmap()
				Me.O.0O_o0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
				Me.OOOO_.o.().Controls.Add(Me.O.0O_o0.())
				Main.OO_O.o..O0o__0_OO.o.().SetToolTip(Me.O.0O_o0.(), "刷新目录树")
				If Me.oOo0O.___ooOO0. Then
					Me.O.0O_o0.().Visible = False
				End If
			End If
		End Sub

		' Token: 0x060022D8 RID: 8920 RVA: 0x000F1058 File Offset: 0x000EF258
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ShareLibriay.LockWindowUpdate(MyBase.Handle)
			Me.O__O_._..Save()
			If Not Me.oOo0O.___ooOO0. Then
				Me.O__O_._..OpenLoadTree()
			ElseIf Operators.CompareString(Me.O_OOo0.0ooO., "", True) > 0 Then
				Me.o000.oO0.(Me.O_OOo0.0ooO.)
			End If
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
			Me.OOOO_.o.().Focus()
		End Sub

		' Token: 0x060022D9 RID: 8921 RVA: 0x000F10CC File Offset: 0x000EF2CC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Tab Then
				Dim text As String = Me.OOOO_.o.().Text
				Dim num As Integer
				If Operators.CompareString(text, "", True) > 0 AndAlso Operators.CompareString(text.Trim(), "", True) > 0 AndAlso Integer.TryParse(text.Trim(), num) AndAlso num > 0 AndAlso num <= Me.oo0o.0__o. AndAlso num <> Me.O__O_._. + 1 Then
					Me.O__O_._. = num - 1
					Me.O__O_._..DataTable.LoadPage = Me.O__O_._.
					Me.O__O_._..DataTable.o0.o.(True, Nothing)
					Me.OOOO_.o.().Text = Conversions.ToString(Me.O__O_._. + 1) + "/" + Conversions.ToString(Me.oo0o.0__o.)
				End If
			End If
		End Sub

		' Token: 0x04000E49 RID: 3657
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000E4A RID: 3658
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.TreeView

		' Token: 0x04000E4B RID: 3659
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Button

		' Token: 0x04000E4C RID: 3660
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Button

		' Token: 0x04000E4D RID: 3661
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Button

		' Token: 0x04000E4E RID: 3662
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Button

		' Token: 0x04000E4F RID: 3663
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.TextBox

		' Token: 0x04000E50 RID: 3664
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Panel

		' Token: 0x04000E51 RID: 3665
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x04000E52 RID: 3666
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000E53 RID: 3667
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000E54 RID: 3668
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000E55 RID: 3669
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000E56 RID: 3670
		Private <<EMPTY_NAME>> As List(Of System.Windows.Forms.TreeNode)

		' Token: 0x04000E57 RID: 3671
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Button

		' Token: 0x04000E58 RID: 3672
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000E59 RID: 3673
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E5A RID: 3674
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
