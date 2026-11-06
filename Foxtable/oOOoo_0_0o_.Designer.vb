Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000088 RID: 136
	<DesignerGenerated()>
	Friend Class oOOoo_0_0o_
		Inherits UserControl

		' Token: 0x060004ED RID: 1261 RVA: 0x0001C358 File Offset: 0x0001A558
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.Oo0O0.o. IsNot Nothing Then
					Me.Oo0O0.o..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060004EE RID: 1262 RVA: 0x0001C398 File Offset: 0x0001A598
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.Oo0O0.o. = New Container()
			Me.o0_OOo___o.0O.(New Label())
			Me.o._ooo.(New Label())
			Me.o0_OOo___o.0O.(New TextBox())
			Me.o0_OOo___o.0O.(New System.Windows.Forms.Timer(Me.Oo0O0.o.))
			Me.O_o_.O0o00o__0.(New Label())
			MyBase.SuspendLayout()
			Me.ooO00_0.0.().BackColor = Color.Transparent
			Me.ooO00_0.0.().Dock = DockStyle.Left
			Me.ooO00_0.0.().Image = a.Oo.ooO00OO.()
			Me.ooO00_0.0.().Location = New Point(0, 0)
			Me.ooO00_0.0.().Name = "_lblIcon"
			Me.ooO00_0.0.().Size = New Size(24, 24)
			Me.ooO00_0.0.().TabIndex = 1
			Me.OO0_OOo_.0o_.().BackColor = Color.Transparent
			Me.OO0_OOo_.0o_.().Dock = DockStyle.Right
			Me.OO0_OOo_.0o_.().Image = a.O00o_Ooo.0.()
			Me.OO0_OOo_.0o_.().Location = New Point(106, 0)
			Me.OO0_OOo_.0o_.().Name = "_lblClear"
			Me.OO0_OOo_.0o_.().Size = New Size(22, 24)
			Me.OO0_OOo_.0o_.().TabIndex = 3
			Me.ooO00_0.0.().BorderStyle = BorderStyle.None
			Me.ooO00_0.0.().Location = New Point(27, 0)
			Me.ooO00_0.0.().Name = "_txtSearch"
			Me.ooO00_0.0.().Size = New Size(86, 14)
			Me.ooO00_0.0.().TabIndex = 0
			Me.ooO00_0.0.().Interval = 500
			Me.o.oOO_O.().AutoSize = True
			Me.o.oOO_O.().BackColor = Color.Transparent
			Me.o.oOO_O.().ForeColor = SystemColors.ControlDark
			Me.o.oOO_O.().Location = New Point(44, 5)
			Me.o.oOO_O.().Name = "_lblWatermark"
			Me.o.oOO_O.().Size = New Size(47, 12)
			Me.o.oOO_O.().TabIndex = 2
			Me.o.oOO_O.().Text = "查找..."
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.Controls.Add(Me.o.oOO_O.())
			MyBase.Controls.Add(Me.ooO00_0.0.())
			MyBase.Controls.Add(Me.OO0_OOo_.0o_.())
			MyBase.Controls.Add(Me.ooO00_0.0.())
			MyBase.Name = "Search.Box"
			MyBase.Size = New Size(128, 24)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060004EF RID: 1263 RVA: 0x0001C638 File Offset: 0x0001A838
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.Oo0O0.o.
		End Function

		' Token: 0x060004F0 RID: 1264 RVA: 0x0001C640 File Offset: 0x0001A840
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.o.0o00oo_OOo.
			Dim oo0O0.o. As Label = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				RemoveHandler oo0O0.o..Click, value
			End If
			Me.Oo0O0.o. = A_0
			oo0O0.o. = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				AddHandler oo0O0.o..Click, value
			End If
		End Sub

		' Token: 0x060004F1 RID: 1265 RVA: 0x0001C683 File Offset: 0x0001A883
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo_0oO.o_O0.
		End Function

		' Token: 0x060004F2 RID: 1266 RVA: 0x0001C68C File Offset: 0x0001A88C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.O_0o_0_.oooOoO.
			Dim label As Label = Me.oo_0oO.o_O0.
			If label IsNot Nothing Then
				RemoveHandler label.Click, value
			End If
			Me.oo_0oO.o_O0. = A_0
			label = Me.oo_0oO.o_O0.
			If label IsNot Nothing Then
				AddHandler label.Click, value
			End If
		End Sub

		' Token: 0x060004F3 RID: 1267 RVA: 0x0001C6CF File Offset: 0x0001A8CF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As TextBox
			Return Me.Oo0O0.o.
		End Function

		' Token: 0x060004F4 RID: 1268 RVA: 0x0001C6D8 File Offset: 0x0001A8D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TextBox)
			Dim value As EventHandler = AddressOf Me.o__O0._OO00O.
			Dim value2 As EventHandler = AddressOf Me.OOOO_0.o_O_0O.
			Dim value3 As EventHandler = AddressOf Me.Oo0._0_o__0__.
			Dim oo0O0.o. As TextBox = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				RemoveHandler oo0O0.o..TextChanged, value
				RemoveHandler oo0O0.o..Enter, value2
				RemoveHandler oo0O0.o..Leave, value3
			End If
			Me.Oo0O0.o. = A_0
			oo0O0.o. = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				AddHandler oo0O0.o..TextChanged, value
				AddHandler oo0O0.o..Enter, value2
				AddHandler oo0O0.o..Leave, value3
			End If
		End Sub

		' Token: 0x060004F5 RID: 1269 RVA: 0x0001C751 File Offset: 0x0001A951
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As System.Windows.Forms.Timer
			Return Me.Oo0O0.o.
		End Function

		' Token: 0x060004F6 RID: 1270 RVA: 0x0001C75C File Offset: 0x0001A95C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Timer)
			Dim value As EventHandler = AddressOf Me.OO0o._OOOO.
			Dim oo0O0.o. As System.Windows.Forms.Timer = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				RemoveHandler oo0O0.o..Tick, value
			End If
			Me.Oo0O0.o. = A_0
			oo0O0.o. = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				AddHandler oo0O0.o..Tick, value
			End If
		End Sub

		' Token: 0x060004F7 RID: 1271 RVA: 0x0001C79F File Offset: 0x0001A99F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooo_o.0_OOO.
		End Function

		' Token: 0x060004F8 RID: 1272 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.o_o0.O_0O0OO0O.
			Dim label As Label = Me.ooo_o.0_OOO.
			If label IsNot Nothing Then
				RemoveHandler label.Click, value
			End If
			Me.ooo_o.0_OOO. = A_0
			label = Me.ooo_o.0_OOO.
			If label IsNot Nothing Then
				AddHandler label.Click, value
			End If
		End Sub

		' Token: 0x060004F9 RID: 1273 RVA: 0x0001C7EB File Offset: 0x0001A9EB
		Public Sub New()
			Me.ooO00_0.0.()
			Me.ooO00_0.0.().Image = OO_00oOO.GetImage("findn.ico")
			Me.OO0_OOo_.0o_.().Image = OO_00oOO.GetImage("deleten.ico")
		End Sub

		' Token: 0x060004FA RID: 1274 RVA: 0x0001C824 File Offset: 0x0001AA24
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As EventHandler)
			Dim eventHandler As EventHandler = Me.Oo0O0.o.
			Dim eventHandler2 As EventHandler
			Do
				eventHandler2 = eventHandler
				Dim value As EventHandler = CType([Delegate].Combine(eventHandler2, A_0), EventHandler)
				eventHandler = Interlocked.CompareExchange(Of EventHandler)(Me.Oo0O0.o., value, eventHandler2)
			Loop While eventHandler IsNot eventHandler2
		End Sub

		' Token: 0x060004FB RID: 1275 RVA: 0x0001C85C File Offset: 0x0001AA5C
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As EventHandler)
			Dim eventHandler As EventHandler = Me.Oo0O0.o.
			Dim eventHandler2 As EventHandler
			Do
				eventHandler2 = eventHandler
				Dim value As EventHandler = CType([Delegate].Remove(eventHandler2, A_0), EventHandler)
				eventHandler = Interlocked.CompareExchange(Of EventHandler)(Me.Oo0O0.o., value, eventHandler2)
			Loop While eventHandler IsNot eventHandler2
		End Sub

		' Token: 0x060004FC RID: 1276 RVA: 0x0001C894 File Offset: 0x0001AA94
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As EventHandler)
			Dim eventHandler As EventHandler = Me.oo_0oO.o_O0.
			Dim eventHandler2 As EventHandler
			Do
				eventHandler2 = eventHandler
				Dim value As EventHandler = CType([Delegate].Combine(eventHandler2, A_0), EventHandler)
				eventHandler = Interlocked.CompareExchange(Of EventHandler)(Me.oo_0oO.o_O0., value, eventHandler2)
			Loop While eventHandler IsNot eventHandler2
		End Sub

		' Token: 0x060004FD RID: 1277 RVA: 0x0001C8CC File Offset: 0x0001AACC
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As EventHandler)
			Dim eventHandler As EventHandler = Me.oo_0oO.o_O0.
			Dim eventHandler2 As EventHandler
			Do
				eventHandler2 = eventHandler
				Dim value As EventHandler = CType([Delegate].Remove(eventHandler2, A_0), EventHandler)
				eventHandler = Interlocked.CompareExchange(Of EventHandler)(Me.oo_0oO.o_O0., value, eventHandler2)
			Loop While eventHandler IsNot eventHandler2
		End Sub

		' Token: 0x060004FE RID: 1278 RVA: 0x0001C904 File Offset: 0x0001AB04
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As EventArgs)
			Dim oo0O0.o. As EventHandler = Me.Oo0O0.o.
			If oo0O0.o. IsNot Nothing Then
				oo0O0.o.(Me, A_0)
			End If
		End Sub

		' Token: 0x060004FF RID: 1279 RVA: 0x0001C924 File Offset: 0x0001AB24
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As EventArgs)
			Dim eventHandler As EventHandler = Me.oo_0oO.o_O0.
			If eventHandler IsNot Nothing Then
				eventHandler(Me, A_0)
			End If
		End Sub

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x06000500 RID: 1280 RVA: 0x0001C943 File Offset: 0x0001AB43
		' (set) Token: 0x06000501 RID: 1281 RVA: 0x0001C950 File Offset: 0x0001AB50
		Public Overridable Property Text As String
			Get
				Return Me.ooO00_0.0.().Text
			End Get
			Set(value As String)
				Me.ooO00_0.0.().Text = value
			End Set
		End Property

		' Token: 0x06000502 RID: 1282 RVA: 0x0001C95E File Offset: 0x0001AB5E
		Public Overloads Function <<EMPTY_NAME>>() As Integer
			Return Me.ooO00_0.0.().Interval
		End Function

		' Token: 0x06000503 RID: 1283 RVA: 0x0001C96B File Offset: 0x0001AB6B
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.ooO00_0.0.().Interval = A_0
		End Sub

		' Token: 0x06000504 RID: 1284 RVA: 0x0001C97C File Offset: 0x0001AB7C
		Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
			MyBase.OnPaintBackground(e)
			Dim clientRectangle As Rectangle = MyBase.ClientRectangle
			clientRectangle.Inflate(-1, -1)
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality
			oOOoo_0_0o_.ooO00_0.0.(e.Graphics, SystemPens.ControlDark, SystemBrushes.Window, clientRectangle)
		End Sub

		' Token: 0x06000505 RID: 1285 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		Protected Overrides Sub OnLayout(e As LayoutEventArgs)
			MyBase.OnLayout(e)
			Dim height As Integer = MyBase.ClientSize.Height
			Dim width As Integer = MyBase.ClientSize.Width - Me.ooO00_0.0.().Width - Me.OO0_OOo_.0o_.().Width
			Me.o.oOO_O.().Bounds = New Rectangle(Me.ooO00_0.0.().Width, CInt(Math.Round(CDbl((height - Me.o.oOO_O.().Height)) / 2.0 + 2.0)), width, Me.o.oOO_O.().Height)
			Me.ooO00_0.0.().Bounds = New Rectangle(Me.ooO00_0.0.().Width, CInt(Math.Round(CDbl((height - Me.ooO00_0.0.().Height)) / 2.0 + 1.0)), width, Me.ooO00_0.0.().Height)
		End Sub

		' Token: 0x06000506 RID: 1286 RVA: 0x0001CAAC File Offset: 0x0001ACAC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO0_OOo_.0o_.().Visible = (Me.ooO00_0.0.().Text.Length > 0)
			Me.ooO00_0.0.().[Stop]()
			Me.ooO00_0.0.().Start()
		End Sub

		' Token: 0x06000507 RID: 1287 RVA: 0x0001CAE2 File Offset: 0x0001ACE2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ooO00_0.0.().[Stop]()
			Me.O_o_.O0o00o__0.(EventArgs.Empty)
		End Sub

		' Token: 0x06000508 RID: 1288 RVA: 0x0001CAFA File Offset: 0x0001ACFA
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ooO00_0.0.().Text = String.Empty
			Me.ooO00_0.0.().[Stop]()
			Me.O_o_.O0o00o__0.(EventArgs.Empty)
		End Sub

		' Token: 0x06000509 RID: 1289 RVA: 0x0001CB22 File Offset: 0x0001AD22
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ooO00_0.0.().Focus()
		End Sub

		' Token: 0x0600050A RID: 1290 RVA: 0x0001CB30 File Offset: 0x0001AD30
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.oOO_O.().Visible = False
		End Sub

		' Token: 0x0600050B RID: 1291 RVA: 0x0001CB3E File Offset: 0x0001AD3E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.oOO_O.().Visible = (Me.ooO00_0.0.().Text.Length = 0)
		End Sub

		' Token: 0x0600050C RID: 1292 RVA: 0x0001CB60 File Offset: 0x0001AD60
		Private Shared Overloads Sub <<EMPTY_NAME>>(A_0 As Graphics, A_1 As Pen, A_2 As Brush, A_3 As Rectangle)
			Dim rectangle As Rectangle = A_3
			rectangle.Width = Math.Min(A_3.Height, CInt(Math.Round(CDbl(A_3.Width) / 3.0)))
			Dim rect As Rectangle = rectangle
			rect.X = A_3.Right - rectangle.Width
			A_3.X += A_3.Height
			A_3.Width -= 2 * A_3.Height
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			graphicsPath.AddLine(A_3.X, A_3.Y, A_3.Right, A_3.Y)
			graphicsPath.AddArc(rect, 270F, 180F)
			graphicsPath.AddLine(A_3.Right, A_3.Bottom, A_3.X, A_3.Bottom)
			graphicsPath.AddArc(rectangle, 90F, 180F)
			graphicsPath.CloseFigure()
			If A_2 IsNot Nothing Then
				A_0.FillPath(A_2, graphicsPath)
			End If
			If A_1 IsNot Nothing Then
				A_0.DrawPath(A_1, graphicsPath)
			End If
			graphicsPath.Dispose()
		End Sub

		' Token: 0x0600050D RID: 1293 RVA: 0x0001CC6E File Offset: 0x0001AE6E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0_OOo___o.0O.(EventArgs.Empty)
		End Sub

		' Token: 0x0400010D RID: 269
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400010E RID: 270
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400010F RID: 271
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000110 RID: 272
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TextBox

		' Token: 0x04000111 RID: 273
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Timer

		' Token: 0x04000112 RID: 274
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000113 RID: 275
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As EventHandler

		' Token: 0x04000114 RID: 276
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As EventHandler
	End Class
End Namespace
