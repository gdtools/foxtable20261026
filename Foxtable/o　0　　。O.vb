Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000366 RID: 870
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class o\u30000\u3000\u3000\u3002O
		Inherits Form

		' Token: 0x060036AF RID: 13999 RVA: 0x00173268 File Offset: 0x00171468
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O.OoO_. IsNot Nothing Then
					Me.O.OoO_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060036B0 RID: 14000 RVA: 0x001732A8 File Offset: 0x001714A8
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O.OoO_. = New Container()
			Me.O.Oo0OO.(New ProgressBar())
			Me.O.Oo0OO.(New Timer(Me.O.OoO_.))
			MyBase.SuspendLayout()
			Me.O.Oo0OO.().Anchor = AnchorStyles.Bottom
			Me.O.Oo0OO.().Location = New Point(178, 200)
			Me.O.Oo0OO.().Name = "ProgressBar1"
			Me.O.Oo0OO.().Size = New Size(140, 10)
			Me.O.Oo0OO.().Style = ProgressBarStyle.Marquee
			Me.O.Oo0OO.().TabIndex = 1
			Me.O.Oo0OO.().Visible = False
			Me.O.Oo0OO.().Enabled = True
			Me.O.Oo0OO.().Interval = 20
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(496, 256)
			MyBase.Controls.Add(Me.O.Oo0OO.())
			MyBase.FormBorderStyle = FormBorderStyle.None
			MyBase.Name = "o_O....."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "frmStart"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060036B1 RID: 14001 RVA: 0x001733E0 File Offset: 0x001715E0
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As ProgressBar
			Return Me.O.OoO_.
		End Function

		' Token: 0x060036B2 RID: 14002 RVA: 0x001733E8 File Offset: 0x001715E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As ProgressBar)
			Me.O.OoO_. = A_0
		End Sub

		' Token: 0x060036B3 RID: 14003 RVA: 0x001733F1 File Offset: 0x001715F1
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Timer
			Return Me.O.OoO_.
		End Function

		' Token: 0x060036B4 RID: 14004 RVA: 0x001733FC File Offset: 0x001715FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.o.oOO_O0.
			Dim o.OoO_. As Timer = Me.O.OoO_.
			If o.OoO_. IsNot Nothing Then
				RemoveHandler o.OoO_..Tick, value
			End If
			Me.O.OoO_. = A_0
			o.OoO_. = Me.O.OoO_.
			If o.OoO_. IsNot Nothing Then
				AddHandler o.OoO_..Tick, value
			End If
		End Sub

		' Token: 0x060036B5 RID: 14005 RVA: 0x0017343F File Offset: 0x0017163F
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O0O._Oo.
			AddHandler MyBase.Shown, AddressOf Me.O.Oo0OO.
			Me.O.Oo0OO.()
		End Sub

		' Token: 0x060036B6 RID: 14006 RVA: 0x00173474 File Offset: 0x00171674
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed Then
				If Not Me.O.Oo0OO.().Visible Then
					Me.O.Oo0OO.().Visible = True
				End If
				Select Case Main.OO_O.o.
					Case 1
						If Not MyBase.Visible Then
							MyBase.ShowDialog()
							Return
						End If
					Case 2, 3
						Me.O.Oo0OO.().Enabled = False
						MyBase.Close()
						Main.OO_O.o. = 0
					Case 4
						If OO_00oOO.SystemReady Then
							Main.OO_O.o. = 3
							Me.O.Oo0OO.().Interval = 1000
							Return
						End If
						If MyBase.Top <> -1000 Then
							MyBase.Top = -1000
							Return
						End If
					Case Else
						Return
				End Select
			End If
		End Sub

		' Token: 0x060036B7 RID: 14007 RVA: 0x00173530 File Offset: 0x00171730
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim image As Image = Nothing
			Dim parentPath As String = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath)
			Dim text As String = OO_00oOO.ApplicationPath + "Project\"
			If Operators.CompareString(text, "", True) > 0 Then
				If c.OOOOO.o.().FileSystem.FileExists(text + "\Splash.jpg") Then
					image = OO_00oOO.GetImage(text + "\Splash.jpg")
				ElseIf c.OOOOO.o.().FileSystem.FileExists(text + "\Splash.png") Then
					image = OO_00oOO.GetImage(text + "\Splash.png")
				ElseIf c.OOOOO.o.().FileSystem.FileExists(text + "\Splash.gif") Then
					image = OO_00oOO.GetImage(text + "\Splash.gif")
				ElseIf c.OOOOO.o.().FileSystem.FileExists(text + "\Splash.bmp") Then
					image = OO_00oOO.GetImage(text + "\Splash.bmp")
				End If
			End If
			If image Is Nothing Then
				If c.OOOOO.o.().FileSystem.FileExists(parentPath + "\Splash.jpg") Then
					image = OO_00oOO.GetImage(parentPath + "\Splash.jpg")
				ElseIf c.OOOOO.o.().FileSystem.FileExists(parentPath + "\Splash.png") Then
					image = OO_00oOO.GetImage(parentPath + "\Splash.png")
				ElseIf c.OOOOO.o.().FileSystem.FileExists(parentPath + "\Splash.gif") Then
					image = OO_00oOO.GetImage(parentPath + "\Splash.gif")
				ElseIf c.OOOOO.o.().FileSystem.FileExists(parentPath + "\Splash.bmp") Then
					image = OO_00oOO.GetImage(parentPath + "\Splash.bmp")
				End If
			End If
			If image IsNot Nothing Then
				MyBase.Width = image.Width
				MyBase.Height = image.Height
				Me.BackgroundImage = image
			End If
			MyBase.CenterToScreen()
		End Sub

		' Token: 0x060036B8 RID: 14008 RVA: 0x00173724 File Offset: 0x00171924
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not OO_00oOO.HardWareInfo.Ready Then
				OO_00oOO.HardWareInfo.initialize()
			End If
		End Sub

		' Token: 0x04001681 RID: 5761
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001682 RID: 5762
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ProgressBar

		' Token: 0x04001683 RID: 5763
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer
	End Class
End Namespace
