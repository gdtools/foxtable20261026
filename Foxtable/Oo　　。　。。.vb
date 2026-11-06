Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000259 RID: 601
	<DesignerGenerated()>
	Friend Partial Class Oo\u3000\u3000\u3002\u3000\u3002\u3002
		Inherits O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000

		' Token: 0x06001C14 RID: 7188 RVA: 0x000B1884 File Offset: 0x000AFA84
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0o_o.o0. IsNot Nothing Then
					Me.O0o_o.o0..Dispose()
				End If
			Finally
				MyBase.O0oO.0o_0O0_O.(A_0)
			End Try
		End Sub

		' Token: 0x06001C15 RID: 7189 RVA: 0x000B18C4 File Offset: 0x000AFAC4
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O0o_o.o0.(New C1Button())
			Me.O.0oOO.(New C1Button())
			Me.O_o__00._ooOoO.(New C1Button())
			MyBase.SuspendLayout()
			Me.O.0oOO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O.0oOO.().Location = New Point(283, 383)
			Me.O.0oOO.().Name = "btnSaveAs"
			Me.O.0oOO.().Size = New Size(90, 23)
			Me.O.0oOO.().TabIndex = 16
			Me.O.0oOO.().Text = "另存为"
			Me.O.0oOO.().UseVisualStyleBackColor = True
			Me.O_o__00._ooOoO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O_o__00._ooOoO.().Location = New Point(283, 327)
			Me.O_o__00._ooOoO.().Name = "btnOpen"
			Me.O_o__00._ooOoO.().Size = New Size(90, 23)
			Me.O_o__00._ooOoO.().TabIndex = 14
			Me.O_o__00._ooOoO.().Text = "打开"
			Me.O_o__00._ooOoO.().UseVisualStyleBackColor = True
			Me.o_o0O0o00_0._.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o_o0O0o00_0._.().Location = New Point(282, 355)
			Me.o_o0O0o00_0._.().Name = "btnSave"
			Me.o_o0O0o00_0._.().Size = New Size(91, 23)
			Me.o_o0O0o00_0._.().TabIndex = 15
			Me.o_o0O0o00_0._.().Text = "保存"
			Me.o_o0O0o00_0._.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(384, 418)
			MyBase.Controls.Add(Me.O.0oOO.())
			MyBase.Controls.Add(Me.O_o__00._ooOoO.())
			MyBase.Controls.Add(Me.o_o0O0o00_0._.())
			MyBase.Name = "o00.o..."
			Me.Text = "目录树编辑器"
			MyBase.Controls.SetChildIndex(Me.o_o0O0o00_0._.(), 0)
			MyBase.Controls.SetChildIndex(Me.O_o__00._ooOoO.(), 0)
			MyBase.Controls.SetChildIndex(Me.O.0oOO.(), 0)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001C16 RID: 7190 RVA: 0x000B1B0B File Offset: 0x000AFD0B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0o_o.o0.
		End Function

		' Token: 0x06001C17 RID: 7191 RVA: 0x000B1B14 File Offset: 0x000AFD14
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_o0O0o00_0._.
			Dim o0o_o.o0. As C1Button = Me.O0o_o.o0.
			If o0o_o.o0. IsNot Nothing Then
				RemoveHandler o0o_o.o0..Click, value
			End If
			Me.O0o_o.o0. = A_0
			o0o_o.o0. = Me.O0o_o.o0.
			If o0o_o.o0. IsNot Nothing Then
				AddHandler o0o_o.o0..Click, value
			End If
		End Sub

		' Token: 0x06001C18 RID: 7192 RVA: 0x000B1B57 File Offset: 0x000AFD57
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_0_.oO_OoO.
		End Function

		' Token: 0x06001C19 RID: 7193 RVA: 0x000B1B60 File Offset: 0x000AFD60
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00._OO000.
			Dim c1Button As C1Button = Me.o_0_.oO_OoO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_0_.oO_OoO. = A_0
			c1Button = Me.o_0_.oO_OoO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001C1A RID: 7194 RVA: 0x000B1BA3 File Offset: 0x000AFDA3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o._OoOO_0.
		End Function

		' Token: 0x06001C1B RID: 7195 RVA: 0x000B1BAC File Offset: 0x000AFDAC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O._0Oo_0.
			Dim c1Button As C1Button = Me.o._OoOO_0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o._OoOO_0. = A_0
			c1Button = Me.o._OoOO_0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001C1C RID: 7196 RVA: 0x000B1BF0 File Offset: 0x000AFDF0
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.o_o0O0o00_0._.
			AddHandler MyBase.FormClosed, AddressOf Me.o_o0O0o00_0._.
			Me.o_o0O0o00_0._.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "Office2013Green")
		End Sub

		' Token: 0x06001C1D RID: 7197 RVA: 0x000B1C44 File Offset: 0x000AFE44
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			If Me.o0Oo_O.0. Then
				Dim dialogResult As DialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If dialogResult = DialogResult.Yes Then
					Me.o_o0O0o00_0._.().PerformClick()
					If Me.o0Oo_O.0. Then
						A_1.Cancel = True
						Return
					End If
					MyBase.DialogResult = DialogResult.OK
					Return
				ElseIf dialogResult = DialogResult.Cancel Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x06001C1E RID: 7198 RVA: 0x000B1CA0 File Offset: 0x000AFEA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0Oo_O.0. Then
				Dim dialogResult As DialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If dialogResult = DialogResult.Yes Then
					Me.o_o0O0o00_0._.().PerformClick()
					If Me.o0Oo_O.0. Then
						Return
					End If
				ElseIf dialogResult = DialogResult.Cancel Then
					Return
				End If
			End If
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
			Me.o0Oo_O.0. = False
		End Sub

		' Token: 0x06001C1F RID: 7199 RVA: 0x000B1D88 File Offset: 0x000AFF88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.o0Oo_O.0., "", True) = 0 Then
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr"
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					Me.o0Oo_O.0. = saveFileDialog.FileName
				End If
			End If
			If Operators.CompareString(Me.o0Oo_O.0., "", True) > 0 Then
				Me.oOO00_Ooo.Oo..Save(Me.o0Oo_O.0., False)
				Me.o0Oo_O.0. = False
			End If
		End Sub

		' Token: 0x06001C20 RID: 7200 RVA: 0x000B1DFC File Offset: 0x000AFFFC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "目录树文件(*.foxtr)|*.foxtr"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Me.o0Oo_O.0. = saveFileDialog.FileName
				Me.oOO00_Ooo.Oo..Save(Me.o0Oo_O.0., False)
				Me.o0Oo_O.0. = False
			End If
		End Sub

		' Token: 0x06001C21 RID: 7201 RVA: 0x000B1E48 File Offset: 0x000B0048
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000BF1 RID: 3057
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000BF2 RID: 3058
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000BF3 RID: 3059
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000BF4 RID: 3060
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
