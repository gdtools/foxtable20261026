Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.Win.C1Gauge
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000138 RID: 312
	<DesignerGenerated()>
	Friend Class O_O_OO
		Inherits UserControl

		' Token: 0x06000F1D RID: 3869 RVA: 0x00067BF5 File Offset: 0x00065DF5
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.OO00_.oo. IsNot Nothing Then
				Me.OO00_.oo..Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000F1E RID: 3870 RVA: 0x00067C14 File Offset: 0x00065E14
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.Name = "GaugesOperator"
			MyBase.Size = New Size(9, 9)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06000F1F RID: 3871 RVA: 0x00067C64 File Offset: 0x00065E64
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.OO00_.oo.
		End Function

		' Token: 0x06000F20 RID: 3872 RVA: 0x00067C6C File Offset: 0x00065E6C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.OO00_.oo. = A_0
		End Sub

		' Token: 0x06000F21 RID: 3873 RVA: 0x00067C78 File Offset: 0x00065E78
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.OO00_.oo.
		End Function

		' Token: 0x06000F22 RID: 3874 RVA: 0x00067C8C File Offset: 0x00065E8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.Ooo0o._.
				Dim oo00_.oo. As ToolStripMenuItem = Me.OO00_.oo.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							If oo00_.oo. IsNot Nothing Then
								num = 1
								Continue For
							End If
							Return
						Case 1
							AddHandler oo00_.oo..Click, value
							num = 5
							Continue For
						Case 2
							If True Then
							End If
							If oo00_.oo. IsNot Nothing Then
								num = 3
								Continue For
							End If
							GoTo IL_62
						Case 3
							RemoveHandler oo00_.oo..Click, value
							num = 4
							Continue For
						Case 4
							GoTo IL_62
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.OO00_.oo. = A_0
					oo00_.oo. = Me.OO00_.oo.
					num = 0
				End While
			End While
		End Sub

		' Token: 0x06000F23 RID: 3875 RVA: 0x00067D38 File Offset: 0x00065F38
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oO.o00_OO_0_oO.
		End Function

		' Token: 0x06000F24 RID: 3876 RVA: 0x00067D4C File Offset: 0x00065F4C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O0__._0o.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oO.o00_OO_0_oO.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 1
							RemoveHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 2
							If toolStripMenuItem IsNot Nothing Then
								If True Then
								End If
								num = 1
								Continue For
							End If
							GoTo IL_62
						Case 3
							GoTo IL_62
						Case 4
							AddHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.oO.o00_OO_0_oO. = A_0
					toolStripMenuItem = Me.oO.o00_OO_0_oO.
					num = 0
				End While
			End While
		End Sub

		' Token: 0x06000F25 RID: 3877 RVA: 0x00067DF8 File Offset: 0x00065FF8
		Public Sub New()
			AddHandler MyBase.MouseDown, AddressOf Me.O0__._0o.
			AddHandler MyBase.ParentChanged, AddressOf Me.O00O.ooo0.
			Me.O0__._0o.()
			Me.OO00_.oo.(New ContextMenuStrip())
			Me.oO.o00_OO_0_oO.(New ToolStripMenuItem("保存为模板(&S)..."))
			Me.O0__._0o.(New ToolStripMenuItem("从模板生成(&L)..."))
			Me.O0__._0o.().Items.AddRange(New ToolStripItem() { Me.Ooo0o._.(), Me.O0__._0o.() })
			Me.BackgroundImage = OO_00oOO.GetImage("Operator.ico")
			Me.BackgroundImageLayout = ImageLayout.Center
		End Sub

		' Token: 0x06000F26 RID: 3878 RVA: 0x00067E9F File Offset: 0x0006609F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.O0__._0o.().Show(Me, A_1.X, A_1.Y)
		End Sub

		' Token: 0x06000F27 RID: 3879 RVA: 0x00067EBC File Offset: 0x000660BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Location = New Point(MyBase.Parent.Width - MyBase.Width - 4, MyBase.Parent.Height - MyBase.Height - 4)
			Me.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.BackColor = CType(MyBase.Parent, ControlHolder).ChildControl.BackColor
			MyBase.BringToFront()
		End Sub

		' Token: 0x06000F28 RID: 3880 RVA: 0x00067F28 File Offset: 0x00066128
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "仪表模板|*.gauge.xml"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Dim c1Gauge As C1Gauge = CType(CType(MyBase.Parent, ControlHolder).ChildControl, C1Gauge)
				Dim memoryStream As MemoryStream = New MemoryStream()
				c1Gauge.Save(memoryStream, Encoding.UTF8)
				Dim [string] As String = Encoding.UTF8.GetString(memoryStream.ToArray(), 3, CInt(memoryStream.Length) - 3)
				memoryStream.Dispose()
				OO_00oOO.FileSys.WriteAllText(saveFileDialog.FileName, Regex.Replace([string], "\sviewTag=""\w+""", ""), False)
			End If
		End Sub

		' Token: 0x06000F29 RID: 3881 RVA: 0x00067FBC File Offset: 0x000661BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "仪表模板|*.gauge.xml"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				CType(CType(MyBase.Parent, ControlHolder).ChildControl, C1Gauge).Load(openFileDialog.FileName)
			End If
		End Sub

		' Token: 0x040005D2 RID: 1490
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040005D3 RID: 1491
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x040005D4 RID: 1492
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040005D5 RID: 1493
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem
	End Class
End Namespace
