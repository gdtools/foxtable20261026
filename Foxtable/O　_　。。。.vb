Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200035A RID: 858
	<DesignerGenerated()>
	Friend Partial Class O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06003568 RID: 13672 RVA: 0x001689F4 File Offset: 0x00166BF4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O.oO0_. IsNot Nothing Then
					Me.O.oO0_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003569 RID: 13673 RVA: 0x00168A34 File Offset: 0x00166C34
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O.oO0_.(New PictureViewer())
			MyBase.SuspendLayout()
			Me.O.oO0_.().AutoScroll = True
			Me.O.oO0_.().BackColor = SystemColors.ControlLightLight
			Me.O.oO0_.().Dock = DockStyle.Fill
			Me.O.oO0_.().ImageFiles = Nothing
			Me.O.oO0_.().Location = New Point(0, 0)
			Me.O.oO0_.().Name = "PictureViewer1"
			Me.O.oO0_.().[ReadOnly] = 0
			Me.O.oO0_.().Size = New Size(703, 471)
			Me.O.oO0_.().SizeMode = PictureBoxSizeMode.Zoom
			Me.O.oO0_.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(703, 471)
			MyBase.Controls.Add(Me.O.oO0_.())
			MyBase.Name = "O...oo.."
			MyBase.ShowIcon = False
			Me.Text = "图片浏览"
			MyBase.WindowState = FormWindowState.Maximized
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600356A RID: 13674 RVA: 0x00168B53 File Offset: 0x00166D53
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.O.oO0_.
			AddHandler MyBase.Load, AddressOf Me.O.oO0_.
			Me.O.oO0_.()
		End Sub

		' Token: 0x0600356B RID: 13675 RVA: 0x00168B85 File Offset: 0x00166D85
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As PictureViewer
			Return Me.O.oO0_.
		End Function

		' Token: 0x0600356C RID: 13676 RVA: 0x00168B8D File Offset: 0x00166D8D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As PictureViewer)
			Me.O.oO0_. = A_0
		End Sub

		' Token: 0x0600356D RID: 13677 RVA: 0x00168B96 File Offset: 0x00166D96
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Me.O.oO0_.().DataBindings(0).WriteValue()
		End Sub

		' Token: 0x0600356E RID: 13678 RVA: 0x00168BAE File Offset: 0x00166DAE
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.oO0_.().PrevRecord.Visible = True
			Me.O.oO0_.().NextRecord.Visible = True
			Me.O.oO0_.().Full.Visible = False
		End Sub

		' Token: 0x040015E5 RID: 5605
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040015E6 RID: 5606
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PictureViewer
	End Class
End Namespace
