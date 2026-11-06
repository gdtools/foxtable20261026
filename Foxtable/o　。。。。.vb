Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200035B RID: 859
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3002\u3002\u3002
		Inherits Form

		' Token: 0x0600356F RID: 13679 RVA: 0x00168BE4 File Offset: 0x00166DE4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0__.Oo0O_O0O_. IsNot Nothing Then
					Me.o0__.Oo0O_O0O_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003570 RID: 13680 RVA: 0x00168C24 File Offset: 0x00166E24
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o0__.Oo0O_O0O_.(New Label())
			MyBase.SuspendLayout()
			Me.o0__.Oo0O_O0O_.().Location = New Point(29, 24)
			Me.o0__.Oo0O_O0O_.().Name = "Label1"
			Me.o0__.Oo0O_O0O_.().Size = New Size(196, 16)
			Me.o0__.Oo0O_O0O_.().TabIndex = 0
			Me.o0__.Oo0O_O0O_.().Text = "正在打开文件，请稍候..."
			Me.o0__.Oo0O_O0O_.().TextAlign = ContentAlignment.MiddleCenter
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.Azure
			MyBase.ClientSize = New Size(254, 58)
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.o0__.Oo0O_O0O_.())
			MyBase.FormBorderStyle = FormBorderStyle.None
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O....0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			MyBase.TopMost = True
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003571 RID: 13681 RVA: 0x00168D3A File Offset: 0x00166F3A
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o0__.Oo0O_O0O_.
		End Function

		' Token: 0x06003572 RID: 13682 RVA: 0x00168D42 File Offset: 0x00166F42
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0__.Oo0O_O0O_. = A_0
		End Sub

		' Token: 0x06003573 RID: 13683 RVA: 0x00168D4C File Offset: 0x00166F4C
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.o0__.Oo0O_O0O_.
			Me.o0__.Oo0O_O0O_.()
			If Main.OO_O.o. IsNot Nothing Then
				Main.OO_O.o..o.O000oo.(New Object() { Me })
				Return
			End If
			Me.BackColor = Color.FromArgb(207, 221, 208)
		End Sub

		' Token: 0x06003574 RID: 13684 RVA: 0x00168DAD File Offset: 0x00166FAD
		Friend Overloads Function <<EMPTY_NAME>>() As String
			Return Me.o0__.Oo0O_O0O_.().Text
		End Function

		' Token: 0x06003575 RID: 13685 RVA: 0x00168DBA File Offset: 0x00166FBA
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0__.Oo0O_O0O_.().Text = A_0
		End Sub

		' Token: 0x06003576 RID: 13686 RVA: 0x00168DC8 File Offset: 0x00166FC8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			If Main.OO_O.o. IsNot Nothing Then
				Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me })
			End If
		End Sub

		' Token: 0x040015E7 RID: 5607
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040015E8 RID: 5608
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label
	End Class
End Namespace
