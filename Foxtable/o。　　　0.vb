Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000343 RID: 835
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3000\u30000
		Inherits Form

		' Token: 0x060032CB RID: 13003 RVA: 0x0014CA54 File Offset: 0x0014AC54
		<DebuggerNonUserCode()>
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oooOo_0oOo0o.0. IsNot Nothing Then
					Me.oooOo_0oOo0o.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060032CC RID: 13004 RVA: 0x0014CA94 File Offset: 0x0014AC94
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo_ooo.oOOO.(New C1Button())
			Me.O0_oo0.oo.(New C1DockingTab())
			Me.oo_ooo.oOOO.(New C1DockingTabPage())
			Me.O0_o_.O.(New PropertyGrid())
			Me.O0_o_.O.(New C1DockingTabPage())
			Me.O0_o_.O.(New SplitContainer())
			Me.Oo_.Oo__00.(New PropertyGrid())
			Me.O0_o_.O.(New RichTextBox())
			Me.O0_oo0.oo.(New C1Button())
			Me.O_0__o0_oO0.o0.(New C1Button())
			Me.o._oOO0Oo0oOoo.().BeginInit()
			Me.O_0__.O_OO0_O_.().BeginInit()
			Me.O_0__.O_OO0_O_.().SuspendLayout()
			Me.o._oOO0Oo0oOoo.().SuspendLayout()
			Me.O_0__.O_OO0_O_.().SuspendLayout()
			CType(Me.O_0__.O_OO0_O_.(), ISupportInitialize).BeginInit()
			Me.O_0__.O_OO0_O_.().Panel1.SuspendLayout()
			Me.O_0__.O_OO0_O_.().Panel2.SuspendLayout()
			Me.O_0__.O_OO0_O_.().SuspendLayout()
			Me.O_0__.O_OO0_O_.().BeginInit()
			Me.Oo_0o0.O.().BeginInit()
			MyBase.SuspendLayout()
			Me.o._oOO0Oo0oOoo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o._oOO0Oo0oOoo.().Location = New Point(388, 526)
			Me.o._oOO0Oo0oOoo.().Name = "btnCancel"
			Me.o._oOO0Oo0oOoo.().Size = New Size(75, 23)
			Me.o._oOO0Oo0oOoo.().TabIndex = 2
			Me.o._oOO0Oo0oOoo.().Text = "取消"
			Me.o._oOO0Oo0oOoo.().UseVisualStyleBackColor = True
			Me.O_0__.O_OO0_O_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_0__.O_OO0_O_.().BorderStyle = BorderStyle.None
			Me.O_0__.O_OO0_O_.().Controls.Add(Me.o._oOO0Oo0oOoo.())
			Me.O_0__.O_OO0_O_.().Controls.Add(Me.O_0__.O_OO0_O_.())
			Me.O_0__.O_OO0_O_.().Location = New Point(12, 12)
			Me.O_0__.O_OO0_O_.().Name = "C1DockingTab1"
			Me.O_0__.O_OO0_O_.().Size = New Size(451, 497)
			Me.O_0__.O_OO0_O_.().TabIndex = 0
			Me.O_0__.O_OO0_O_.().TabsSpacing = 0
			Me.O_0__.O_OO0_O_.().TabStyle = 1
			Me.O_0__.O_OO0_O_.().VisualStyle = 13
			Me.O_0__.O_OO0_O_.().VisualStyleBase = 13
			Me.o._oOO0Oo0oOoo.().Controls.Add(Me.O_0__.O_OO0_O_.())
			Me.o._oOO0Oo0oOoo.().Location = New Point(0, 25)
			Me.o._oOO0Oo0oOoo.().Name = "C1DockingTabPage1"
			Me.o._oOO0Oo0oOoo.().Size = New Size(451, 472)
			Me.o._oOO0Oo0oOoo.().TabIndex = 0
			Me.o._oOO0Oo0oOoo.().Text = "属性"
			Me.O_0__.O_OO0_O_.().Dock = DockStyle.Fill
			Me.O_0__.O_OO0_O_.().Location = New Point(0, 0)
			Me.O_0__.O_OO0_O_.().Name = "PropertyGrid1"
			Me.O_0__.O_OO0_O_.().Size = New Size(451, 472)
			Me.O_0__.O_OO0_O_.().TabIndex = 0
			Me.O_0__.O_OO0_O_.().ToolbarVisible = False
			Me.O_0__.O_OO0_O_.().Controls.Add(Me.O_0__.O_OO0_O_.())
			Me.O_0__.O_OO0_O_.().Location = New Point(0, 25)
			Me.O_0__.O_OO0_O_.().Name = "C1DockingTabPage2"
			Me.O_0__.O_OO0_O_.().Size = New Size(451, 472)
			Me.O_0__.O_OO0_O_.().TabIndex = 1
			Me.O_0__.O_OO0_O_.().Text = "事件"
			Me.O_0__.O_OO0_O_.().Dock = DockStyle.Fill
			Me.O_0__.O_OO0_O_.().Location = New Point(0, 0)
			Me.O_0__.O_OO0_O_.().Name = "SplitContainer1"
			Me.O_0__.O_OO0_O_.().Orientation = Orientation.Horizontal
			Me.O_0__.O_OO0_O_.().Panel1.Controls.Add(Me.o._oOO0Oo0oOoo.())
			Me.O_0__.O_OO0_O_.().Panel2.Controls.Add(Me.O_0__.O_OO0_O_.())
			Me.O_0__.O_OO0_O_.().Size = New Size(451, 472)
			Me.O_0__.O_OO0_O_.().SplitterDistance = 384
			Me.O_0__.O_OO0_O_.().TabIndex = 0
			Me.o._oOO0Oo0oOoo.().Dock = DockStyle.Fill
			Me.o._oOO0Oo0oOoo.().Location = New Point(0, 0)
			Me.o._oOO0Oo0oOoo.().Name = "PropertyGrid2"
			Me.o._oOO0Oo0oOoo.().Size = New Size(451, 384)
			Me.o._oOO0Oo0oOoo.().TabIndex = 0
			Me.o._oOO0Oo0oOoo.().ToolbarVisible = False
			Me.O_0__.O_OO0_O_.().BorderStyle = BorderStyle.FixedSingle
			Me.O_0__.O_OO0_O_.().Dock = DockStyle.Fill
			Me.O_0__.O_OO0_O_.().Location = New Point(0, 0)
			Me.O_0__.O_OO0_O_.().Name = "txtCode"
			Me.O_0__.O_OO0_O_.().[ReadOnly] = True
			Me.O_0__.O_OO0_O_.().Size = New Size(451, 84)
			Me.O_0__.O_OO0_O_.().TabIndex = 0
			Me.O_0__.O_OO0_O_.().Text = ""
			Me.O_0__.O_OO0_O_.().WordWrap = False
			Me.O_0__.O_OO0_O_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O_0__.O_OO0_O_.().DialogResult = DialogResult.OK
			Me.O_0__.O_OO0_O_.().Location = New Point(297, 526)
			Me.O_0__.O_OO0_O_.().Name = "btnOK"
			Me.O_0__.O_OO0_O_.().Size = New Size(75, 23)
			Me.O_0__.O_OO0_O_.().TabIndex = 1
			Me.O_0__.O_OO0_O_.().Text = "确定"
			Me.O_0__.O_OO0_O_.().UseVisualStyleBackColor = True
			Me.Oo_0o0.O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Oo_0o0.O.().Location = New Point(13, 526)
			Me.Oo_0o0.O.().Name = "Button1"
			Me.Oo_0o0.O.().Size = New Size(84, 23)
			Me.Oo_0o0.O.().TabIndex = 3
			Me.Oo_0o0.O.().Text = "输出代码"
			Me.Oo_0o0.O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(475, 561)
			MyBase.Controls.Add(Me.Oo_0o0.O.())
			MyBase.Controls.Add(Me.O_0__.O_OO0_O_.())
			MyBase.Controls.Add(Me.O_0__.O_OO0_O_.())
			MyBase.Controls.Add(Me.o._oOO0Oo0oOoo.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.0._._."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "表属性"
			Me.o._oOO0Oo0oOoo.().EndInit()
			Me.O_0__.O_OO0_O_.().EndInit()
			Me.O_0__.O_OO0_O_.().ResumeLayout(False)
			Me.o._oOO0Oo0oOoo.().ResumeLayout(False)
			Me.O_0__.O_OO0_O_.().ResumeLayout(False)
			Me.O_0__.O_OO0_O_.().Panel1.ResumeLayout(False)
			Me.O_0__.O_OO0_O_.().Panel2.ResumeLayout(False)
			CType(Me.O_0__.O_OO0_O_.(), ISupportInitialize).EndInit()
			Me.O_0__.O_OO0_O_.().ResumeLayout(False)
			Me.O_0__.O_OO0_O_.().EndInit()
			Me.Oo_0o0.O.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060032CD RID: 13005 RVA: 0x0014D1C1 File Offset: 0x0014B3C1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_o_.O.
		End Function

		' Token: 0x060032CE RID: 13006 RVA: 0x0014D1C9 File Offset: 0x0014B3C9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0_o_.O. = A_0
		End Sub

		' Token: 0x060032CF RID: 13007 RVA: 0x0014D1D2 File Offset: 0x0014B3D2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.O0_o_.O.
		End Function

		' Token: 0x060032D0 RID: 13008 RVA: 0x0014D1DA File Offset: 0x0014B3DA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.O0_o_.O. = A_0
		End Sub

		' Token: 0x060032D1 RID: 13009 RVA: 0x0014D1E3 File Offset: 0x0014B3E3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O0_o_.O.
		End Function

		' Token: 0x060032D2 RID: 13010 RVA: 0x0014D1EB File Offset: 0x0014B3EB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O0_o_.O. = A_0
		End Sub

		' Token: 0x060032D3 RID: 13011 RVA: 0x0014D1F4 File Offset: 0x0014B3F4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.oOoo.oO.
		End Function

		' Token: 0x060032D4 RID: 13012 RVA: 0x0014D1FC File Offset: 0x0014B3FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.oOoo.oO. = A_0
		End Sub

		' Token: 0x060032D5 RID: 13013 RVA: 0x0014D205 File Offset: 0x0014B405
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.oooOo_0oOo0o.0.
		End Function

		' Token: 0x060032D6 RID: 13014 RVA: 0x0014D20D File Offset: 0x0014B40D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.oooOo_0oOo0o.0. = A_0
		End Sub

		' Token: 0x060032D7 RID: 13015 RVA: 0x0014D216 File Offset: 0x0014B416
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.oooOo_0oOo0o.0.
		End Function

		' Token: 0x060032D8 RID: 13016 RVA: 0x0014D21E File Offset: 0x0014B41E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.oooOo_0oOo0o.0. = A_0
		End Sub

		' Token: 0x060032D9 RID: 13017 RVA: 0x0014D227 File Offset: 0x0014B427
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.oOoo.oO.
		End Function

		' Token: 0x060032DA RID: 13018 RVA: 0x0014D22F File Offset: 0x0014B42F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.oOoo.oO. = A_0
		End Sub

		' Token: 0x060032DB RID: 13019 RVA: 0x0014D238 File Offset: 0x0014B438
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.Oo__00.
		End Function

		' Token: 0x060032DC RID: 13020 RVA: 0x0014D240 File Offset: 0x0014B440
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo_.Oo__00. = A_0
		End Sub

		' Token: 0x060032DD RID: 13021 RVA: 0x0014D249 File Offset: 0x0014B449
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RichTextBox
			Return Me.oooOo_0oOo0o.0.
		End Function

		' Token: 0x060032DE RID: 13022 RVA: 0x0014D251 File Offset: 0x0014B451
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RichTextBox)
			Me.oooOo_0oOo0o.0. = A_0
		End Sub

		' Token: 0x060032DF RID: 13023 RVA: 0x0014D25A File Offset: 0x0014B45A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_Ooo_O.o.
		End Function

		' Token: 0x060032E0 RID: 13024 RVA: 0x0014D262 File Offset: 0x0014B462
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0_Ooo_O.o. = A_0
		End Sub

		' Token: 0x060032E1 RID: 13025 RVA: 0x0014D26C File Offset: 0x0014B46C
		Friend Sub New(A_0 As DataTable)
			Me.oooOo_0oOo0o.0. = New List(Of String)()
			Me.O_0__o0_oO0.o0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.O_0__.O_OO0_O_.() })
		End Sub

		' Token: 0x0400147B RID: 5243
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400147C RID: 5244
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400147D RID: 5245
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x0400147E RID: 5246
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400147F RID: 5247
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04001480 RID: 5248
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x04001481 RID: 5249
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04001482 RID: 5250
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x04001483 RID: 5251
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001484 RID: 5252
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RichTextBox

		' Token: 0x04001485 RID: 5253
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001486 RID: 5254
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001487 RID: 5255
		Private <<EMPTY_NAME>> As DataTableProperty

		' Token: 0x04001488 RID: 5256
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001489 RID: 5257
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400148A RID: 5258
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400148B RID: 5259
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400148C RID: 5260
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400148D RID: 5261
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
