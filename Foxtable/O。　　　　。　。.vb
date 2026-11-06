Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Chart
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002A1 RID: 673
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002
		Inherits System.Windows.Forms.Form

		' Token: 0x06002392 RID: 9106 RVA: 0x000F6090 File Offset: 0x000F4290
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o.OO_. IsNot Nothing Then
					Me.o.OO_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06002393 RID: 9107 RVA: 0x000F60D0 File Offset: 0x000F42D0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002))
			Me.o.OO_.(New C1Chart())
			Me.o0_Oo.OO.(New C1Button())
			Me.Oo.OOoO.(New C1Button())
			Me.O_oO0o.O.(New C1Button())
			Me.o.OO_.(New C1Button())
			Me.oOoo.O0O_o.().BeginInit()
			MyBase.SuspendLayout()
			Me.oOoo.O0O_o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oOoo.O0O_o.().Location = New Point(12, 12)
			Me.oOoo.O0O_o.().Name = "C1Chart1"
			Me.oOoo.O0O_o.().PropBag = componentResourceManager.GetString("C1Chart1.PropBag")
			Me.oOoo.O0O_o.().Size = New Size(814, 428)
			Me.oOoo.O0O_o.().TabIndex = 0
			Me.o0_Oo.OO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o0_Oo.OO.().Location = New Point(589, 459)
			Me.o0_Oo.OO.().Name = "btnPrint"
			Me.o0_Oo.OO.().Size = New Size(75, 23)
			Me.o0_Oo.OO.().TabIndex = 1
			Me.o0_Oo.OO.().Text = "打印"
			Me.o0_Oo.OO.().UseVisualStyleBackColor = True
			Me.Oo.OOoO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Oo.OOoO.().Location = New Point(670, 459)
			Me.Oo.OOoO.().Name = "btnCopy"
			Me.Oo.OOoO.().Size = New Size(75, 23)
			Me.Oo.OOoO.().TabIndex = 2
			Me.Oo.OOoO.().Text = "复制"
			Me.Oo.OOoO.().UseVisualStyleBackColor = True
			Me.oOoo.O0O_o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oOoo.O0O_o.().Location = New Point(751, 459)
			Me.oOoo.O0O_o.().Name = "btnSave"
			Me.oOoo.O0O_o.().Size = New Size(75, 23)
			Me.oOoo.O0O_o.().TabIndex = 3
			Me.oOoo.O0O_o.().Text = "保存"
			Me.oOoo.O0O_o.().UseVisualStyleBackColor = True
			Me.O_oO0o.O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_oO0o.O.().Location = New Point(13, 459)
			Me.O_oO0o.O.().Name = "Button1"
			Me.O_oO0o.O.().Size = New Size(97, 23)
			Me.O_oO0o.O.().TabIndex = 4
			Me.O_oO0o.O.().Text = "改变配色方案"
			Me.O_oO0o.O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(838, 494)
			MyBase.Controls.Add(Me.O_oO0o.O.())
			MyBase.Controls.Add(Me.oOoo.O0O_o.())
			MyBase.Controls.Add(Me.Oo.OOoO.())
			MyBase.Controls.Add(Me.o0_Oo.OO.())
			MyBase.Controls.Add(Me.oOoo.O0O_o.())
			MyBase.MinimizeBox = False
			MyBase.Name = "O..O0oO."
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "图表"
			Me.oOoo.O0O_o.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06002394 RID: 9108 RVA: 0x000F642D File Offset: 0x000F462D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Chart
			Return Me.o.OO_.
		End Function

		' Token: 0x06002395 RID: 9109 RVA: 0x000F6438 File Offset: 0x000F4638
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Chart)
			Dim value As MouseEventHandler = AddressOf Me.Oo._Oo.
			Dim c1Chart As C1Chart = Me.o.OO_.
			If c1Chart IsNot Nothing Then
				RemoveHandler c1Chart.MouseUp, value
			End If
			Me.o.OO_. = A_0
			c1Chart = Me.o.OO_.
			If c1Chart IsNot Nothing Then
				AddHandler c1Chart.MouseUp, value
			End If
		End Sub

		' Token: 0x06002396 RID: 9110 RVA: 0x000F647B File Offset: 0x000F467B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.OO_.
		End Function

		' Token: 0x06002397 RID: 9111 RVA: 0x000F6484 File Offset: 0x000F4684
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O000._O__.
			Dim c1Button As C1Button = Me.o.OO_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.OO_. = A_0
			c1Button = Me.o.OO_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06002398 RID: 9112 RVA: 0x000F64C7 File Offset: 0x000F46C7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0.0000_Oooo.
		End Function

		' Token: 0x06002399 RID: 9113 RVA: 0x000F64D0 File Offset: 0x000F46D0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.ooO.0O_oO0OOO.
			Dim c1Button As C1Button = Me.o0.0000_Oooo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0.0000_Oooo. = A_0
			c1Button = Me.o0.0000_Oooo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600239A RID: 9114 RVA: 0x000F6513 File Offset: 0x000F4713
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooo._o.
		End Function

		' Token: 0x0600239B RID: 9115 RVA: 0x000F651C File Offset: 0x000F471C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_oO_00o0.o.
			Dim c1Button As C1Button = Me.ooo._o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooo._o. = A_0
			c1Button = Me.ooo._o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600239C RID: 9116 RVA: 0x000F655F File Offset: 0x000F475F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOO._00.
		End Function

		' Token: 0x0600239D RID: 9117 RVA: 0x000F6568 File Offset: 0x000F4768
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo._Oo.
			Dim ooo._00. As C1Button = Me.OOO._00.
			If ooo._00. IsNot Nothing Then
				RemoveHandler ooo._00..Click, value
			End If
			Me.OOO._00. = A_0
			ooo._00. = Me.OOO._00.
			If ooo._00. IsNot Nothing Then
				AddHandler ooo._00..Click, value
			End If
		End Sub

		' Token: 0x0600239E RID: 9118 RVA: 0x000F65AB File Offset: 0x000F47AB
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.oOoo.O0O_o.
			Me.oOoo.O0O_o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600239F RID: 9119 RVA: 0x000F65E0 File Offset: 0x000F47E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New Chart(Me.oOoo.O0O_o.()).Print(False, True)
		End Sub

		' Token: 0x060023A0 RID: 9120 RVA: 0x000F65F4 File Offset: 0x000F47F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New Chart(Me.oOoo.O0O_o.()).CopyImage()
		End Sub

		' Token: 0x060023A1 RID: 9121 RVA: 0x000F6608 File Offset: 0x000F4808
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim chart As Chart = New Chart(Me.oOoo.O0O_o.())
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "WMF|*.wmf|BMP|*.bmp|GIF|*.gif|JPEG|*.jpg|PNG|*.png|TIFF|*.tif|EMF|*.emf"
			saveFileDialog.FilterIndex = 0
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = saveFileDialog.FileName
				Dim imageFormat As ImageFormat = ImageFormat.Bmp
				Dim left As String = Path.GetExtension(fileName).TrimStart(New Char() { "."c })
				If Operators.CompareString(left, "wmf", True) = 0 Then
					imageFormat = ImageFormat.Wmf
				ElseIf Operators.CompareString(left, "bmp", True) = 0 Then
					imageFormat = ImageFormat.Bmp
				ElseIf Operators.CompareString(left, "gif", True) = 0 Then
					imageFormat = ImageFormat.Gif
				ElseIf Operators.CompareString(left, "jpg", True) = 0 Then
					imageFormat = ImageFormat.Jpeg
				ElseIf Operators.CompareString(left, "png", True) = 0 Then
					imageFormat = ImageFormat.Png
				ElseIf Operators.CompareString(left, "tif", True) = 0 Then
					imageFormat = ImageFormat.Tiff
				ElseIf Operators.CompareString(left, "emf", True) = 0 Then
					imageFormat = ImageFormat.Emf
				End If
				chart.SaveImage(fileName, imageFormat)
			End If
		End Sub

		' Token: 0x060023A2 RID: 9122 RVA: 0x000F6714 File Offset: 0x000F4914
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim chart As Chart = New Chart(Me.oOoo.O0O_o.())
			Dim index As Integer
			Dim num As Integer
			Dim chartSeries As ChartSeries
			Dim chartTypeEnum As ChartTypeEnum
			If chart.CoordToDataIndex(A_1.X, A_1.Y, index, num) Then
				chartSeries = chart.SeriesList(index)
				chartTypeEnum = chart.ChartType
			Else
				If Not chart.CoordToDataIndex(A_1.X, A_1.Y, index, num) Then
					Return
				End If
				chartSeries = chart.SeriesList2(index)
				chartTypeEnum = chart.ChartType
			End If
			If chartTypeEnum = ChartTypeEnum.Pie Then
				If chartSeries.Offset = 20 Then
					chartSeries.Offset = 0
					Return
				End If
				chartSeries.Offset = 20
			End If
		End Sub

		' Token: 0x060023A3 RID: 9123 RVA: 0x000F67A8 File Offset: 0x000F49A8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim names As String() = [Enum].GetNames(GetType(ColorGeneration))
			Dim text As String = [Enum].GetName(GetType(ColorGeneration), Me.oOoo.O0O_o.().ColorGeneration)
			Dim num As Integer = names.Length - 1
			For i As Integer = 0 To num
				If Operators.CompareString(names(i), text, True) = 0 Then
					i += 1
					If i >= names.Length - 1 Then
						i = 0
					End If
					text = names(i)
					Me.oOoo.O0O_o.().ColorGeneration = Conversions.ToInteger([Enum].Parse(GetType(ColorGeneration), text))
					Return
				End If
			Next
		End Sub

		' Token: 0x060023A4 RID: 9124 RVA: 0x000F6836 File Offset: 0x000F4A36
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000EB6 RID: 3766
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000EB7 RID: 3767
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Chart

		' Token: 0x04000EB8 RID: 3768
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EB9 RID: 3769
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EBA RID: 3770
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EBB RID: 3771
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
