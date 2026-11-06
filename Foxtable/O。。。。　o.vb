Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200033B RID: 827
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000
		Inherits Form

		' Token: 0x060031A2 RID: 12706 RVA: 0x001428D4 File Offset: 0x00140AD4
		<DebuggerNonUserCode()>
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_oO.0o0. IsNot Nothing Then
					Me.o_oO.0o0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060031A3 RID: 12707 RVA: 0x00142914 File Offset: 0x00140B14
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_oO.0o0.(New C1FlexGrid())
			Me.o_oO.0o0.(New C1Button())
			Me.o0_.0o_O0.(New C1Button())
			Me.o_oO.0o0.().BeginInit()
			MyBase.SuspendLayout()
			Me.o_oO.0o0.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.o_oO.0o0.().Location = New Point(12, 12)
			Me.o_oO.0o0.().Name = "C1FlexGrid1"
			Me.o_oO.0o0.().Rows.DefaultSize = 19
			Me.o_oO.0o0.().Size = New Size(481, 231)
			Me.o_oO.0o0.().TabIndex = 0
			Me.o_0oOo_OO00.oO.().Location = New Point(328, 258)
			Me.o_0oOo_OO00.oO.().Name = "Button1"
			Me.o_0oOo_OO00.oO.().Size = New Size(75, 23)
			Me.o_0oOo_OO00.oO.().TabIndex = 1
			Me.o_0oOo_OO00.oO.().Text = "确定"
			Me.o_0oOo_OO00.oO.().UseVisualStyleBackColor = True
			Me.o_oO.0o0.().Location = New Point(418, 258)
			Me.o_oO.0o0.().Name = "Button2"
			Me.o_oO.0o0.().Size = New Size(75, 23)
			Me.o_oO.0o0.().TabIndex = 2
			Me.o_oO.0o0.().Text = "取消"
			Me.o_oO.0o0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(504, 293)
			MyBase.Controls.Add(Me.o_oO.0o0.())
			MyBase.Controls.Add(Me.o_0oOo_OO00.oO.())
			MyBase.Controls.Add(Me.o_oO.0o0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o...0.O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "标志列设定"
			Me.o_oO.0o0.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060031A4 RID: 12708 RVA: 0x00142B41 File Offset: 0x00140D41
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o_oO.0o0.
		End Function

		' Token: 0x060031A5 RID: 12709 RVA: 0x00142B49 File Offset: 0x00140D49
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.o_oO.0o0. = A_0
		End Sub

		' Token: 0x060031A6 RID: 12710 RVA: 0x00142B52 File Offset: 0x00140D52
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_oO.0o0.
		End Function

		' Token: 0x060031A7 RID: 12711 RVA: 0x00142B5A File Offset: 0x00140D5A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_oO.0o0. = A_0
		End Sub

		' Token: 0x060031A8 RID: 12712 RVA: 0x00142B63 File Offset: 0x00140D63
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_.0o_O0.
		End Function

		' Token: 0x060031A9 RID: 12713 RVA: 0x00142B6B File Offset: 0x00140D6B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0_.0o_O0. = A_0
		End Sub

		' Token: 0x060031AA RID: 12714 RVA: 0x00142B74 File Offset: 0x00140D74
		Public Sub New()
			Me.o_oO.0o0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o_oO.0o0.().Styles.SelectedColumnHeader.Clear()
			Me.o_oO.0o0.().Styles.Alternate.Clear()
			Me.o_oO.0o0.().Styles.Focus.Clear()
			Me.o_oO.0o0.().Styles.Focus.MergeWith(Me.o_oO.0o0.().Styles.Normal)
			Me.o_oO.0o0.().FocusRect = 3
		End Sub

		' Token: 0x040013F3 RID: 5107
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013F4 RID: 5108
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040013F5 RID: 5109
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013F6 RID: 5110
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
