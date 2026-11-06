Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000CE RID: 206
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3002\u3000o\u3002\u3000\u3000\u3000
		Inherits Form

		' Token: 0x06000982 RID: 2434 RVA: 0x00042760 File Offset: 0x00040960
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o000__OO._. IsNot Nothing Then
					Me.o000__OO._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000983 RID: 2435 RVA: 0x000427A0 File Offset: 0x000409A0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o000__OO._. = New Container()
			Me.o00__o.o00__oO.(New C1CheckBox())
			Me.o00__o.o00__oO.(New Label())
			Me.ooo.O.(New C1Button())
			Me.o00__o.o00__oO.(New C1Button())
			Me.o00__o.o00__oO.(New TreeView())
			Me.o00__o.o00__oO.(New ImageList(Me.o000__OO._.))
			Me.O_ooO_oo.O0.().BeginInit()
			Me.O_ooO_oo.O0.().BeginInit()
			Me.O._Ooo.().BeginInit()
			MyBase.SuspendLayout()
			Me.O_ooO_oo.O0.().AutoSize = True
			Me.O_ooO_oo.O0.().BorderStyle = BorderStyle.None
			Me.O_ooO_oo.O0.().Location = New Point(248, 19)
			Me.O_ooO_oo.O0.().Name = "CheckBox1"
			Me.O_ooO_oo.O0.().Size = New Size(96, 16)
			Me.O_ooO_oo.O0.().TabIndex = 6
			Me.O_ooO_oo.O0.().Text = "选择所有函数"
			Me.O_ooO_oo.O0.().UseVisualStyleBackColor = True
			Me.O_ooO_oo.O0.().Value = Nothing
			Me.O_ooO_oo.O0.().AutoSize = True
			Me.O_ooO_oo.O0.().Location = New Point(12, 19)
			Me.O_ooO_oo.O0.().Name = "Label1"
			Me.O_ooO_oo.O0.().Size = New Size(107, 12)
			Me.O_ooO_oo.O0.().TabIndex = 9
			Me.O_ooO_oo.O0.().Text = "选择要导入的函数:"
			Me.O_ooO_oo.O0.().Location = New Point(189, 483)
			Me.O_ooO_oo.O0.().Name = "Button2"
			Me.O_ooO_oo.O0.().Size = New Size(75, 23)
			Me.O_ooO_oo.O0.().TabIndex = 8
			Me.O_ooO_oo.O0.().Text = "取消"
			Me.O_ooO_oo.O0.().UseVisualStyleBackColor = True
			Me.O._Ooo.().Location = New Point(97, 483)
			Me.O._Ooo.().Name = "Button1"
			Me.O._Ooo.().Size = New Size(75, 23)
			Me.O._Ooo.().TabIndex = 7
			Me.O._Ooo.().Text = "确定"
			Me.O._Ooo.().UseVisualStyleBackColor = True
			Me.O_ooO_oo.O0.().Location = New Point(15, 50)
			Me.O_ooO_oo.O0.().Name = "TreeView1"
			Me.O_ooO_oo.O0.().Size = New Size(330, 417)
			Me.O_ooO_oo.O0.().TabIndex = 10
			Me.O_ooO_oo.O0.().ColorDepth = ColorDepth.Depth8Bit
			Me.O_ooO_oo.O0.().ImageSize = New Size(16, 16)
			Me.O_ooO_oo.O0.().TransparentColor = Color.Transparent
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(361, 517)
			MyBase.Controls.Add(Me.O_ooO_oo.O0.())
			MyBase.Controls.Add(Me.O_ooO_oo.O0.())
			MyBase.Controls.Add(Me.O_ooO_oo.O0.())
			MyBase.Controls.Add(Me.O_ooO_oo.O0.())
			MyBase.Controls.Add(Me.O._Ooo.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.o0..0_0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "导入函数"
			Me.O_ooO_oo.O0.().EndInit()
			Me.O_ooO_oo.O0.().EndInit()
			Me.O._Ooo.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000984 RID: 2436 RVA: 0x00042B47 File Offset: 0x00040D47
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o000__OO._.
		End Function

		' Token: 0x06000985 RID: 2437 RVA: 0x00042B4F File Offset: 0x00040D4F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o000__OO._. = A_0
		End Sub

		' Token: 0x06000986 RID: 2438 RVA: 0x00042B58 File Offset: 0x00040D58
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o000__OO._.
		End Function

		' Token: 0x06000987 RID: 2439 RVA: 0x00042B60 File Offset: 0x00040D60
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o000__OO._. = A_0
		End Sub

		' Token: 0x06000988 RID: 2440 RVA: 0x00042B69 File Offset: 0x00040D69
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o000__OO._.
		End Function

		' Token: 0x06000989 RID: 2441 RVA: 0x00042B71 File Offset: 0x00040D71
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o000__OO._. = A_0
		End Sub

		' Token: 0x0600098A RID: 2442 RVA: 0x00042B7A File Offset: 0x00040D7A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooo.O.
		End Function

		' Token: 0x0600098B RID: 2443 RVA: 0x00042B82 File Offset: 0x00040D82
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.ooo.O. = A_0
		End Sub

		' Token: 0x0600098C RID: 2444 RVA: 0x00042B8B File Offset: 0x00040D8B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As TreeView
			Return Me.o000__OO._.
		End Function

		' Token: 0x0600098D RID: 2445 RVA: 0x00042B93 File Offset: 0x00040D93
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Me.o000__OO._. = A_0
		End Sub

		' Token: 0x0600098E RID: 2446 RVA: 0x00042B9C File Offset: 0x00040D9C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As ImageList
			Return Me.o000__OO._.
		End Function

		' Token: 0x0600098F RID: 2447 RVA: 0x00042BA4 File Offset: 0x00040DA4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ImageList)
			Me.o000__OO._. = A_0
		End Sub

		' Token: 0x06000990 RID: 2448 RVA: 0x00042BB0 File Offset: 0x00040DB0
		Public Sub New(A_0 As String)
			Me.o000__OO._. = New HashSet(Of TreeNode)()
			Me.ooo.O.()
			Me.o000__OO._. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim selectConnection As OleDbConnection = New OleDbConnection(Oo00.o_._0OOo.(Me.o000__OO._.))
			Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("Select * From [Functions]", selectConnection)
			Me.o000__OO._. = New DataTable()
			dbDataAdapter.Fill(Me.o000__OO._.)
			Me.O_ooO_oo.O0.().PathSeparator = vbTab
			Me.O_ooO_oo.O0.().Images.Add(a.oO0O_O.__oo.())
			Me.O_ooO_oo.O0.().Images.Add(a.O.o_oo0O_.())
			Me.O_ooO_oo.O0.().ImageList = Me.O_ooO_oo.O0.()
			Me.O_ooO_oo.O0.().CheckBoxes = True
		End Sub

		' Token: 0x04000365 RID: 869
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000366 RID: 870
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000367 RID: 871
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000368 RID: 872
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000369 RID: 873
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400036A RID: 874
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x0400036B RID: 875
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x0400036C RID: 876
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400036D RID: 877
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400036E RID: 878
		Private <<EMPTY_NAME>> As HashSet(Of TreeNode)
	End Class
End Namespace
