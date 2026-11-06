Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002AA RID: 682
	<DesignerGenerated()>
	Friend Partial Class O\u3002o
		Inherits O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000

		' Token: 0x060023ED RID: 9197 RVA: 0x000F9C58 File Offset: 0x000F7E58
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.ooO00.0o0. IsNot Nothing Then
					Me.ooO00.0o0..Dispose()
				End If
			Finally
				MyBase.O0oO.0o_0O0_O.(A_0)
			End Try
		End Sub

		' Token: 0x060023EE RID: 9198 RVA: 0x000F9C98 File Offset: 0x000F7E98
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.OOooOO.(New C1Button())
			Me.oO__.OOO_0OO_O.(New C1Button())
			Me.O._oO0O.(New C1Button())
			Me.oO000.0_Oo.(New C1Button())
			MyBase.SuspendLayout()
			Me.oO__.OOO_0OO_O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.oO__.OOO_0OO_O.().Location = New Point(282, 292)
			Me.oO__.OOO_0OO_O.().Name = "btnSaveAs"
			Me.oO__.OOO_0OO_O.().Size = New Size(91, 23)
			Me.oO__.OOO_0OO_O.().TabIndex = 11
			Me.oO__.OOO_0OO_O.().Text = "保存为文件"
			Me.oO__.OOO_0OO_O.().UseVisualStyleBackColor = True
			Me.oO000.0_Oo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.oO000.0_Oo.().Location = New Point(282, 321)
			Me.oO000.0_Oo.().Name = "btnOpen"
			Me.oO000.0_Oo.().Size = New Size(91, 23)
			Me.oO000.0_Oo.().TabIndex = 12
			Me.oO000.0_Oo.().Text = "从文件生成"
			Me.oO000.0_Oo.().UseVisualStyleBackColor = True
			Me.O._0o0_00OOo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O._0o0_00OOo.().Location = New Point(293, 420)
			Me.O._0o0_00OOo.().Name = "btnCancel"
			Me.O._0o0_00OOo.().Size = New Size(80, 23)
			Me.O._0o0_00OOo.().TabIndex = 13
			Me.O._0o0_00OOo.().Text = "取消"
			Me.O._0o0_00OOo.().UseVisualStyleBackColor = True
			Me.oOO00_Ooo.Oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oOO00_Ooo.Oo.().Location = New Point(210, 420)
			Me.oOO00_Ooo.Oo.().Name = "btnOK"
			Me.oOO00_Ooo.Oo.().Size = New Size(77, 23)
			Me.oOO00_Ooo.Oo.().TabIndex = 14
			Me.oOO00_Ooo.Oo.().Text = "确定"
			Me.oOO00_Ooo.Oo.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(384, 455)
			MyBase.Controls.Add(Me.oOO00_Ooo.Oo.())
			MyBase.Controls.Add(Me.O._0o0_00OOo.())
			MyBase.Controls.Add(Me.oO__.OOO_0OO_O.())
			MyBase.Controls.Add(Me.oO000.0_Oo.())
			MyBase.Name = "O0O.o..."
			MyBase.Controls.SetChildIndex(Me.oO000.0_Oo.(), 0)
			MyBase.Controls.SetChildIndex(Me.oO__.OOO_0OO_O.(), 0)
			MyBase.Controls.SetChildIndex(Me.O._0o0_00OOo.(), 0)
			MyBase.Controls.SetChildIndex(Me.oOO00_Ooo.Oo.(), 0)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060023EF RID: 9199 RVA: 0x000F9F76 File Offset: 0x000F8176
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO00.0o0.
		End Function

		' Token: 0x060023F0 RID: 9200 RVA: 0x000F9F80 File Offset: 0x000F8180
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O._0o0_00OOo.
			Dim c1Button As C1Button = Me.ooO00.0o0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooO00.0o0. = A_0
			c1Button = Me.ooO00.0o0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060023F1 RID: 9201 RVA: 0x000F9FC3 File Offset: 0x000F81C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._oO0O.
		End Function

		' Token: 0x060023F2 RID: 9202 RVA: 0x000F9FCC File Offset: 0x000F81CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOO00_Ooo.Oo.
			Dim o._oO0O. As C1Button = Me.O._oO0O.
			If o._oO0O. IsNot Nothing Then
				RemoveHandler o._oO0O..Click, value
			End If
			Me.O._oO0O. = A_0
			o._oO0O. = Me.O._oO0O.
			If o._oO0O. IsNot Nothing Then
				AddHandler o._oO0O..Click, value
			End If
		End Sub

		' Token: 0x060023F3 RID: 9203 RVA: 0x000FA00F File Offset: 0x000F820F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO000.0_Oo.
		End Function

		' Token: 0x060023F4 RID: 9204 RVA: 0x000FA018 File Offset: 0x000F8218
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOOOo00_.__O.
			Dim c1Button As C1Button = Me.oO000.0_Oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO000.0_Oo. = A_0
			c1Button = Me.oO000.0_Oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060023F5 RID: 9205 RVA: 0x000FA05B File Offset: 0x000F825B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO__.OOO_0OO_O.
		End Function

		' Token: 0x060023F6 RID: 9206 RVA: 0x000FA064 File Offset: 0x000F8264
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_.o_o.
			Dim c1Button As C1Button = Me.oO__.OOO_0OO_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO__.OOO_0OO_O. = A_0
			c1Button = Me.oO__.OOO_0OO_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060023F7 RID: 9207 RVA: 0x000FA0A8 File Offset: 0x000F82A8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			If Me.o0Oo_O.0. Then
				Dim dialogResult As DialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If dialogResult = DialogResult.Yes Then
					Me.oOO00_Ooo.Oo.().PerformClick()
					Return
				End If
				If dialogResult = DialogResult.Cancel Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x060023F8 RID: 9208 RVA: 0x000FA0EC File Offset: 0x000F82EC
		Public Sub New(A_0 As System.Windows.Forms.TreeView)
			AddHandler MyBase.FormClosing, AddressOf Me.oOO00_Ooo.Oo.
			AddHandler MyBase.FormClosed, AddressOf Me.oOO00_Ooo.Oo.
			Me.o.OOooOO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "Office2013Green")
			Me.ooO00.0o0. = A_0
			Me.OOo_Oo.oooo.().CheckBoxes = A_0.CheckBoxes
			Dim treeView As Foxtable.WinForm.TreeView = New Foxtable.WinForm.TreeView(Me.OOo_Oo.oooo.())
			Dim nodesSettingString As String = Nothing
			oOO0oo_o0.O__o0o0O0O_.0.(A_0.Nodes, nodesSettingString)
			treeView.NodesSettingString = nodesSettingString
		End Sub

		' Token: 0x060023F9 RID: 9209 RVA: 0x000FA176 File Offset: 0x000F8376
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0Oo_O.0. = False
			MyBase.Close()
		End Sub

		' Token: 0x060023FA RID: 9210 RVA: 0x000FA188 File Offset: 0x000F8388
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As Foxtable.WinForm.TreeView = New Foxtable.WinForm.TreeView(Me.ooO00.0o0.)
			Dim nodesSettingString As String = Nothing
			oOO0oo_o0.O__o0o0O0O_.0.(Me.OOo_Oo.oooo.().Nodes, nodesSettingString)
			treeView.Nodes.Clear()
			treeView.NodesSettingString = nodesSettingString
			Me.o0Oo_O.0. = False
			MyBase.Close()
		End Sub

		' Token: 0x060023FB RID: 9211 RVA: 0x000FA1D4 File Offset: 0x000F83D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Me.o0Oo_O.0. = saveFileDialog.FileName
				Me.oOO00_Ooo.Oo..Save(Me.o0Oo_O.0., False)
			End If
		End Sub

		' Token: 0x060023FC RID: 9212 RVA: 0x000FA21C File Offset: 0x000F841C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr"
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) <> 0 Then
				openFileDialog.InitialDirectory = OO_00oOO.ProjectPath + "\Attachments"
			End If
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Me.oOO00_Ooo.Oo..Load(openFileDialog.FileName)
				Me.o0Oo_O.0. = openFileDialog.FileName
				If Me.OOo_Oo.oooo.().Nodes.Count > 0 Then
					Me.OOo_Oo.oooo.().SelectedNode = Me.OOo_Oo.oooo.().Nodes(0)
					Me.OOo_Oo.oooo.().Focus()
				End If
			End If
			Me.o0Oo_O.0. = True
		End Sub

		' Token: 0x060023FD RID: 9213 RVA: 0x000FA2C9 File Offset: 0x000F84C9
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000EDE RID: 3806
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000EDF RID: 3807
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EE0 RID: 3808
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EE1 RID: 3809
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EE2 RID: 3810
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EE3 RID: 3811
		Private <<EMPTY_NAME>> As System.Windows.Forms.TreeView
	End Class
End Namespace
