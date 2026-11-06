Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004B4 RID: 1204
	<DesignerGenerated()>
	Friend Class o\u30020\u3002\u3000\u3002\u3000
		Inherits C1RibbonForm

		' Token: 0x06004DB7 RID: 19895 RVA: 0x002022B0 File Offset: 0x002004B0
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OO0.OO_O_oO_0. IsNot Nothing Then
					Me.OO0.OO_O_oO_0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004DB8 RID: 19896 RVA: 0x002022F0 File Offset: 0x002004F0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o._0o___0.(New C1Ribbon())
			Me.o._0o___0.(New RibbonApplicationMenu())
			Me.o._0o___0.(New RibbonConfigToolBar())
			Me.Oooo._O000_.(New RibbonQat())
			Me.Oooo._O000_.(New RibbonTopToolBar())
			Me.o._0o___0.(New RibbonBottomToolBar())
			Me.o._0o___0.(New GroupBox())
			Me.o._0o___0.(New LinkLabel())
			Me.o._0o___0.(New C1ComboBox())
			Me.o._0o___0.(New C1CommandHolder())
			Me.oO.OOo0_.().BeginInit()
			Me.oO.OOo0_.().SuspendLayout()
			Me.oO.OOo0_.().BeginInit()
			MyBase.SuspendLayout()
			Me.oO.OOo0_.().ApplicationMenuHolder = Me.oO.OOo0_.()
			Me.oO.OOo0_.().BottomToolBarHolder = Me.oO.OOo0_.()
			Me.oO.OOo0_.().ConfigToolBarHolder = Me.oO.OOo0_.()
			Me.oO.OOo0_.().Location = New Point(0, 0)
			Me.oO.OOo0_.().Name = "C1Ribbon1"
			Me.oO.OOo0_.().QatHolder = Me.oO.OOo0_.()
			Me.oO.OOo0_.().Size = New Size(669, 47)
			Me.oO.OOo0_.().TopToolBarHolder = Me.o._0o___0.()
			Me.oO.OOo0_.().Name = "RibbonApplicationMenu1"
			Me.oO.OOo0_.().Name = "RibbonConfigToolBar1"
			Me.oO.OOo0_.().Name = "RibbonQat1"
			Me.o._0o___0.().Name = "RibbonTopToolBar1"
			Me.oO.OOo0_.().Name = "RibbonBottomToolBar1"
			Me.oO.OOo0_.().Anchor = AnchorStyles.None
			Me.oO.OOo0_.().Controls.Add(Me.oO.OOo0_.())
			Me.oO.OOo0_.().Controls.Add(Me.oO.OOo0_.())
			Me.oO.OOo0_.().Location = New Point(200, 164)
			Me.oO.OOo0_.().Name = "GroupBox1"
			Me.oO.OOo0_.().Size = New Size(269, 159)
			Me.oO.OOo0_.().TabIndex = 2
			Me.oO.OOo0_.().TabStop = False
			Me.oO.OOo0_.().Text = "快捷菜单测试"
			Me.oO.OOo0_.().AutoSize = True
			Me.oO.OOo0_.().Location = New Point(54, 86)
			Me.oO.OOo0_.().Name = "LinkLabel1"
			Me.oO.OOo0_.().Size = New Size(161, 12)
			Me.oO.OOo0_.().TabIndex = 1
			Me.oO.OOo0_.().TabStop = True
			Me.oO.OOo0_.().Text = "右击此处测试选定的快捷菜单"
			Me.oO.OOo0_.().DropDownStyle = 1
			Me.oO.OOo0_.().Location = New Point(52, 30)
			Me.oO.OOo0_.().Name = "ContextMenuList"
			Me.oO.OOo0_.().Size = New Size(165, 20)
			Me.oO.OOo0_.().TabIndex = 0
			Me.oO.OOo0_.().Owner = Me
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(669, 487)
			MyBase.Controls.Add(Me.oO.OOo0_.())
			MyBase.Controls.Add(Me.oO.OOo0_.())
			MyBase.Name = "OOo....o"
			MyBase.ShowInTaskbar = False
			Me.Text = "frmRebbionPreview"
			MyBase.VisualStyleHolder = 7
			Me.oO.OOo0_.().EndInit()
			Me.oO.OOo0_.().ResumeLayout(False)
			Me.oO.OOo0_.().PerformLayout()
			Me.oO.OOo0_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06004DB9 RID: 19897 RVA: 0x00202693 File Offset: 0x00200893
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Ribbon
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DBA RID: 19898 RVA: 0x0020269B File Offset: 0x0020089B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Ribbon)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DBB RID: 19899 RVA: 0x002026A4 File Offset: 0x002008A4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonApplicationMenu
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DBC RID: 19900 RVA: 0x002026AC File Offset: 0x002008AC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonApplicationMenu)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DBD RID: 19901 RVA: 0x002026B5 File Offset: 0x002008B5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonConfigToolBar
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DBE RID: 19902 RVA: 0x002026BD File Offset: 0x002008BD
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonConfigToolBar)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DBF RID: 19903 RVA: 0x002026C6 File Offset: 0x002008C6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonQat
			Return Me.OO0.OO_O_oO_0.
		End Function

		' Token: 0x06004DC0 RID: 19904 RVA: 0x002026CE File Offset: 0x002008CE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonQat)
			Me.OO0.OO_O_oO_0. = A_0
		End Sub

		' Token: 0x06004DC1 RID: 19905 RVA: 0x002026D7 File Offset: 0x002008D7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DC2 RID: 19906 RVA: 0x002026DF File Offset: 0x002008DF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DC3 RID: 19907 RVA: 0x002026E8 File Offset: 0x002008E8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As LinkLabel
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DC4 RID: 19908 RVA: 0x002026F0 File Offset: 0x002008F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As LinkLabel)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DC5 RID: 19909 RVA: 0x002026F9 File Offset: 0x002008F9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DC6 RID: 19910 RVA: 0x00202704 File Offset: 0x00200904
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o.OO0o.
			Dim oooo._O000_. As C1ComboBox = Me.Oooo._O000_.
			If oooo._O000_. IsNot Nothing Then
				oooo._O000_..SelectedIndexChanged -= eventHandler
			End If
			Me.Oooo._O000_. = A_0
			oooo._O000_. = Me.Oooo._O000_.
			If oooo._O000_. IsNot Nothing Then
				oooo._O000_..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06004DC7 RID: 19911 RVA: 0x00202747 File Offset: 0x00200947
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CommandHolder
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DC8 RID: 19912 RVA: 0x0020274F File Offset: 0x0020094F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CommandHolder)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DC9 RID: 19913 RVA: 0x00202758 File Offset: 0x00200958
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonBottomToolBar
			Return Me.Oooo._O000_.
		End Function

		' Token: 0x06004DCA RID: 19914 RVA: 0x00202760 File Offset: 0x00200960
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonBottomToolBar)
			Me.Oooo._O000_. = A_0
		End Sub

		' Token: 0x06004DCB RID: 19915 RVA: 0x00202769 File Offset: 0x00200969
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonTopToolBar
			Return Me.OO0.OO_O_oO_0.
		End Function

		' Token: 0x06004DCC RID: 19916 RVA: 0x00202771 File Offset: 0x00200971
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonTopToolBar)
			Me.OO0.OO_O_oO_0. = A_0
		End Sub

		' Token: 0x06004DCD RID: 19917 RVA: 0x0020277C File Offset: 0x0020097C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oO.OOo0_.
			AddHandler MyBase.FormClosed, AddressOf Me.o_0.o__OOoO.
			Me.OO0.OO_O_oO_0. = New Dictionary(Of String, o__o_OO_o_)()
			Me.o._0o___0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06004DCE RID: 19918 RVA: 0x002027DC File Offset: 0x002009DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO0.OO_O_oO_0..ContainsKey(Me.oO.OOo0_.().SelectedItem.ToString()) Then
				Me.oO.OOo0_.().SetC1ContextMenu(Me.oO.OOo0_.(), Me.OO0.OO_O_oO_0.(Me.oO.OOo0_.().SelectedItem.ToString()))
			End If
		End Sub

		' Token: 0x06004DCF RID: 19919 RVA: 0x00202832 File Offset: 0x00200A32
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.WindowState = FormWindowState.Maximized
			Me.oO.OOo0_.().VisualStyle = Main.OO_O.o..O.OOO0_OOo.().VisualStyle
			Me.oO.OOo0_.().HideAppMenuWithTHR = True
		End Sub

		' Token: 0x06004DD0 RID: 19920 RVA: 0x00202861 File Offset: 0x00200A61
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04002025 RID: 8229
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04002026 RID: 8230
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Ribbon

		' Token: 0x04002027 RID: 8231
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonApplicationMenu

		' Token: 0x04002028 RID: 8232
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonConfigToolBar

		' Token: 0x04002029 RID: 8233
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonQat

		' Token: 0x0400202A RID: 8234
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x0400202B RID: 8235
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As LinkLabel

		' Token: 0x0400202C RID: 8236
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400202D RID: 8237
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CommandHolder

		' Token: 0x0400202E RID: 8238
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonBottomToolBar

		' Token: 0x0400202F RID: 8239
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonTopToolBar

		' Token: 0x04002030 RID: 8240
		Friend <<EMPTY_NAME>> As Dictionary(Of String, o__o_OO_o_)
	End Class
End Namespace
