Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Gauge
Imports C1.Win.C1Input
Imports C1.Win.Map
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200038A RID: 906
	<DesignerGenerated()>
	Friend Class ControlHolder
		Inherits UserControl

		' Token: 0x06003A2A RID: 14890 RVA: 0x00192E43 File Offset: 0x00191043
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.O_O00._. IsNot Nothing Then
				Me.O_O00._..Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06003A2B RID: 14891 RVA: 0x00192E64 File Offset: 0x00191064
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.FocusLabel = New TextBox()
			MyBase.SuspendLayout()
			Me.FocusLabel.BackColor = SystemColors.Control
			Me.FocusLabel.BorderStyle = BorderStyle.None
			Me.FocusLabel.Location = New Point(94, 13)
			Me.FocusLabel.Name = "FocusLabel"
			Me.FocusLabel.Size = New Size(0, 14)
			Me.FocusLabel.TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.Transparent
			MyBase.Controls.Add(Me.FocusLabel)
			MyBase.Name = "o.o..0o."
			MyBase.Size = New Size(164, 48)
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003A2C RID: 14892 RVA: 0x00192F44 File Offset: 0x00191144
		Public Sub New()
			AddHandler MyBase.DockChanged, AddressOf Me.o0O._O_O.
			AddHandler MyBase.Load, AddressOf Me.O0.0O.
			AddHandler MyBase.Paint, AddressOf Me.o_.0Oo.
			Me.O0._o.()
			MyBase.SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)
			MyBase.SetStyle(ControlStyles.Selectable, False)
			Me.BackColor = Color.Transparent
		End Sub

		' Token: 0x17000CC3 RID: 3267
		' (get) Token: 0x06003A2D RID: 14893 RVA: 0x00192FB6 File Offset: 0x001911B6
		' (set) Token: 0x06003A2E RID: 14894 RVA: 0x00192FBE File Offset: 0x001911BE
		Friend Overridable Property FocusLabel As TextBox

		' Token: 0x1400000D RID: 13
		' (add) Token: 0x06003A2F RID: 14895 RVA: 0x00192FC8 File Offset: 0x001911C8
		' (remove) Token: 0x06003A30 RID: 14896 RVA: 0x00193000 File Offset: 0x00191200
		Public Custom Event ActivatedChanged As ControlHolder.oOo
			<CompilerGenerated()>
			AddHandler
				Dim oOo As ControlHolder.oOo = Me.o.O_o00O_0o_O.
				Dim oOo2 As ControlHolder.oOo
				Do
					oOo2 = oOo
					Dim value2 As ControlHolder.oOo = CType([Delegate].Combine(oOo2, value), ControlHolder.oOo)
					oOo = Interlocked.CompareExchange(Of ControlHolder.oOo)(Me.o.O_o00O_0o_O., value2, oOo2)
				Loop While oOo IsNot oOo2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oOo As ControlHolder.oOo = Me.o.O_o00O_0o_O.
				Dim oOo2 As ControlHolder.oOo
				Do
					oOo2 = oOo
					Dim value2 As ControlHolder.oOo = CType([Delegate].Remove(oOo2, value), ControlHolder.oOo)
					oOo = Interlocked.CompareExchange(Of ControlHolder.oOo)(Me.o.O_o00O_0o_O., value2, oOo2)
				Loop While oOo IsNot oOo2
			End RemoveHandler
		End Event

		' Token: 0x1400000E RID: 14
		' (add) Token: 0x06003A31 RID: 14897 RVA: 0x00193038 File Offset: 0x00191238
		' (remove) Token: 0x06003A32 RID: 14898 RVA: 0x00193070 File Offset: 0x00191270
		Public Custom Event SelectedChanged As ControlHolder.o_o_0oO0o000
			<CompilerGenerated()>
			AddHandler
				Dim o_o_0oO0o As ControlHolder.o_o_0oO0o000 = Me.O_O00._.
				Dim o_o_0oO0o2 As ControlHolder.o_o_0oO0o000
				Do
					o_o_0oO0o2 = o_o_0oO0o
					Dim value2 As ControlHolder.o_o_0oO0o000 = CType([Delegate].Combine(o_o_0oO0o2, value), ControlHolder.o_o_0oO0o000)
					o_o_0oO0o = Interlocked.CompareExchange(Of ControlHolder.o_o_0oO0o000)(Me.O_O00._., value2, o_o_0oO0o2)
				Loop While o_o_0oO0o IsNot o_o_0oO0o2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim o_o_0oO0o As ControlHolder.o_o_0oO0o000 = Me.O_O00._.
				Dim o_o_0oO0o2 As ControlHolder.o_o_0oO0o000
				Do
					o_o_0oO0o2 = o_o_0oO0o
					Dim value2 As ControlHolder.o_o_0oO0o000 = CType([Delegate].Remove(o_o_0oO0o2, value), ControlHolder.o_o_0oO0o000)
					o_o_0oO0o = Interlocked.CompareExchange(Of ControlHolder.o_o_0oO0o000)(Me.O_O00._., value2, o_o_0oO0o2)
				Loop While o_o_0oO0o IsNot o_o_0oO0o2
			End RemoveHandler
		End Event

		' Token: 0x1400000F RID: 15
		' (add) Token: 0x06003A33 RID: 14899 RVA: 0x001930A8 File Offset: 0x001912A8
		' (remove) Token: 0x06003A34 RID: 14900 RVA: 0x001930E0 File Offset: 0x001912E0
		Public Custom Event LockedChanged As ControlHolder.OO__oOoO_
			<CompilerGenerated()>
			AddHandler
				Dim oo__oOoO_ As ControlHolder.OO__oOoO_ = Me.O_O00._.
				Dim oo__oOoO_2 As ControlHolder.OO__oOoO_
				Do
					oo__oOoO_2 = oo__oOoO_
					Dim value2 As ControlHolder.OO__oOoO_ = CType([Delegate].Combine(oo__oOoO_2, value), ControlHolder.OO__oOoO_)
					oo__oOoO_ = Interlocked.CompareExchange(Of ControlHolder.OO__oOoO_)(Me.O_O00._., value2, oo__oOoO_2)
				Loop While oo__oOoO_ IsNot oo__oOoO_2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oo__oOoO_ As ControlHolder.OO__oOoO_ = Me.O_O00._.
				Dim oo__oOoO_2 As ControlHolder.OO__oOoO_
				Do
					oo__oOoO_2 = oo__oOoO_
					Dim value2 As ControlHolder.OO__oOoO_ = CType([Delegate].Remove(oo__oOoO_2, value), ControlHolder.OO__oOoO_)
					oo__oOoO_ = Interlocked.CompareExchange(Of ControlHolder.OO__oOoO_)(Me.O_O00._., value2, oo__oOoO_2)
				Loop While oo__oOoO_ IsNot oo__oOoO_2
			End RemoveHandler
		End Event

		' Token: 0x14000010 RID: 16
		' (add) Token: 0x06003A35 RID: 14901 RVA: 0x00193118 File Offset: 0x00191318
		' (remove) Token: 0x06003A36 RID: 14902 RVA: 0x00193150 File Offset: 0x00191350
		Public Custom Event DockStyleChanged As ControlHolder.oo_O__O_
			<CompilerGenerated()>
			AddHandler
				Dim oo_O__O_ As ControlHolder.oo_O__O_ = Me.O_O00._.
				Dim oo_O__O_2 As ControlHolder.oo_O__O_
				Do
					oo_O__O_2 = oo_O__O_
					Dim value2 As ControlHolder.oo_O__O_ = CType([Delegate].Combine(oo_O__O_2, value), ControlHolder.oo_O__O_)
					oo_O__O_ = Interlocked.CompareExchange(Of ControlHolder.oo_O__O_)(Me.O_O00._., value2, oo_O__O_2)
				Loop While oo_O__O_ IsNot oo_O__O_2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oo_O__O_ As ControlHolder.oo_O__O_ = Me.O_O00._.
				Dim oo_O__O_2 As ControlHolder.oo_O__O_
				Do
					oo_O__O_2 = oo_O__O_
					Dim value2 As ControlHolder.oo_O__O_ = CType([Delegate].Remove(oo_O__O_2, value), ControlHolder.oo_O__O_)
					oo_O__O_ = Interlocked.CompareExchange(Of ControlHolder.oo_O__O_)(Me.O_O00._., value2, oo_O__O_2)
				Loop While oo_O__O_ IsNot oo_O__O_2
			End RemoveHandler
		End Event

		' Token: 0x06003A37 RID: 14903 RVA: 0x00193188 File Offset: 0x00191388
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_O00._. As ControlHolder.oo_O__O_ = Me.O_O00._.
			If o_O00._. IsNot Nothing Then
				o_O00._.(Me)
			End If
		End Sub

		' Token: 0x17000CC4 RID: 3268
		' (get) Token: 0x06003A38 RID: 14904 RVA: 0x001931A6 File Offset: 0x001913A6
		<Browsable(False)>
		Public ReadOnly Property DisplayName As String
			Get
				Return MyBase.Name
			End Get
		End Property

		' Token: 0x06003A39 RID: 14905 RVA: 0x001931B0 File Offset: 0x001913B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim value As Oo0oo_O_O00__ = New Oo0oo_O_O00__(O0OO000oo0O.OOOOo._.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.o_.0_0O.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.Oo0ooo.OO.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.o_oO._0O.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.o.00o000O00o__.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.OO_._O.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.o0_OoOo.OO.)
			MyBase.Controls.Add(value)
			value = New Oo0oo_O_O00__(O0OO000oo0O.ooo_O0o._.)
			MyBase.Controls.Add(value)
			Me.O_.0oo_O. = New o0O__ooOO00()
			MyBase.Controls.Add(Me.O_.0oo_O.)
			AddHandler MyBase.TabIndexChanged, AddressOf Me.O_.0oo_O..O00Oo0o._.
			Me.FocusLabel.SendToBack()
		End Sub

		' Token: 0x17000CC5 RID: 3269
		' (get) Token: 0x06003A3A RID: 14906 RVA: 0x00193293 File Offset: 0x00191493
		' (set) Token: 0x06003A3B RID: 14907 RVA: 0x0019329B File Offset: 0x0019149B
		Public Property Key As String
			Get
				Return Me.o.O_o00O_0o_O.
			End Get
			Set(value As String)
				Me.o.O_o00O_0o_O. = value
			End Set
		End Property

		' Token: 0x17000CC6 RID: 3270
		' (get) Token: 0x06003A3C RID: 14908 RVA: 0x001932A4 File Offset: 0x001914A4
		' (set) Token: 0x06003A3D RID: 14909 RVA: 0x001932AC File Offset: 0x001914AC
		Public Property DataRow As DataRow
			Get
				Return Me.o.O_o00O_0o_O.
			End Get
			Set(value As DataRow)
				Me.o.O_o00O_0o_O. = value
			End Set
		End Property

		' Token: 0x17000CC7 RID: 3271
		' (get) Token: 0x06003A3E RID: 14910 RVA: 0x001932B5 File Offset: 0x001914B5
		' (set) Token: 0x06003A3F RID: 14911 RVA: 0x001932C0 File Offset: 0x001914C0
		Public Property Activated As Boolean
			Get
				Return Me.o.O_o00O_0o_O.
			End Get
			Set(value As Boolean)
				If Me.o.O_o00O_0o_O. <> value Then
					If value Then
						oOO0oo_o0.o_0O.O.(MyBase.FindForm().Controls)
					End If
					Me.o.O_o00O_0o_O. = value
					Dim oOo As ControlHolder.oOo = Me.o.O_o00O_0o_O.
					If oOo IsNot Nothing Then
						oOo(Me)
					End If
					If value Then
						Me.FocusLabel.Focus()
					End If
				End If
			End Set
		End Property

		' Token: 0x17000CC8 RID: 3272
		' (get) Token: 0x06003A40 RID: 14912 RVA: 0x00193311 File Offset: 0x00191511
		' (set) Token: 0x06003A41 RID: 14913 RVA: 0x0019331C File Offset: 0x0019151C
		Public Property Selected As Boolean
			Get
				Return Me.OOOOooo0000.o.
			End Get
			Set(value As Boolean)
				Dim num As Integer
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					If Me.OOOOooo0000.o. = value Then
						GoTo IL_E6
					End If
					IL_15:
					num2 = 4
					Me.OOOOooo0000.o. = value
					IL_1E:
					num2 = 5
					Dim o_O00._. As ControlHolder.o_o_0oO0o000 = Me.O_O00._.
					If o_O00._. IsNot Nothing Then
						o_O00._.(Me)
					End If
					IL_31:
					num2 = 6
					If Not(Not value And Me.Activated) Then
						GoTo IL_53
					End If
					IL_40:
					num2 = 7
					oOO0oo_o0.O.ooooo.(MyBase.FindForm().Controls)
					IL_53:
					num2 = 8
					Me.Activated = value
					IL_5C:
					num2 = 9
					If Not value Then
						GoTo IL_B1
					End If
					IL_62:
					num2 = 10
					If Not(TypeOf MyBase.Parent Is O_O_) Then
						GoTo IL_B1
					End If
					IL_72:
					num2 = 11
					Dim c1DockingTab As C1DockingTab = CType(MyBase.Parent.Parent, C1DockingTab)
					IL_87:
					num2 = 12
					If c1DockingTab.SelectedTab Is MyBase.Parent Then
						GoTo IL_AE
					End If
					IL_99:
					num2 = 13
					c1DockingTab.SelectedTab = CType(MyBase.Parent, O_O_)
					IL_AE:
					c1DockingTab = Nothing
					IL_B1:
					num2 = 15
					If Me.ControlType <> ControlTypeEnum.Line Then
						GoTo IL_E6
					End If
					IL_BE:
					num2 = 16
					If Not value Then
						GoTo IL_DD
					End If
					IL_C4:
					num2 = 17
					CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).oOO_0._000..Add(Me)
					IL_DD:
					num2 = 18
					MyBase.Invalidate()
					IL_E6:
					GoTo IL_184
					IL_EB:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_145:
					GoTo IL_179
					IL_147:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_157:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_147
				End Try
				IL_179:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_184:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x17000CC9 RID: 3273
		' (get) Token: 0x06003A42 RID: 14914 RVA: 0x001934D4 File Offset: 0x001916D4
		' (set) Token: 0x06003A43 RID: 14915 RVA: 0x001934DC File Offset: 0x001916DC
		Public Property Locked As Boolean
			Get
				Return Me.o0.O_o_o0O.
			End Get
			Set(value As Boolean)
				Me.o0.O_o_o0O. = value
				Dim o_O00._. As ControlHolder.OO__oOoO_ = Me.O_O00._.
				If o_O00._. IsNot Nothing Then
					o_O00._.(Me)
				End If
			End Set
		End Property

		' Token: 0x17000CCA RID: 3274
		' (get) Token: 0x06003A44 RID: 14916 RVA: 0x00193501 File Offset: 0x00191701
		' (set) Token: 0x06003A45 RID: 14917 RVA: 0x00193509 File Offset: 0x00191709
		Public Property ControlType As ControlTypeEnum
			Get
				Return Me.o.O_o00O_0o_O.
			End Get
			Set(value As ControlTypeEnum)
				Me.o.O_o00O_0o_O. = value
			End Set
		End Property

		' Token: 0x17000CCB RID: 3275
		' (get) Token: 0x06003A46 RID: 14918 RVA: 0x00193514 File Offset: 0x00191714
		Public ReadOnly Property IsContainer As Boolean
			Get
				Dim controlTypeEnum As ControlTypeEnum = Me.ControlType
				If controlTypeEnum <= ControlTypeEnum.TreeView Then
					If controlTypeEnum <> ControlTypeEnum.TopicBar AndAlso controlTypeEnum - ControlTypeEnum.GroupBox > 5 Then
						GoTo IL_55
					End If
				ElseIf controlTypeEnum <> ControlTypeEnum.NavBar Then
					Select Case controlTypeEnum
						Case ControlTypeEnum.FilterTree, ControlTypeEnum.LoadTree, ControlTypeEnum.InlineTree, ControlTypeEnum.LayersTree, ControlTypeEnum.Gauges, ControlTypeEnum.GanttView, ControlTypeEnum.Map
						Case ControlTypeEnum.FontPicker, ControlTypeEnum.ColorPicker, ControlTypeEnum.PDFViewer
							GoTo IL_55
						Case Else
							GoTo IL_55
					End Select
				End If
				Return True
				IL_55:
				Return False
			End Get
		End Property

		' Token: 0x17000CCC RID: 3276
		' (get) Token: 0x06003A47 RID: 14919 RVA: 0x00193579 File Offset: 0x00191779
		' (set) Token: 0x06003A48 RID: 14920 RVA: 0x00193584 File Offset: 0x00191784
		Public Property ChildControl As Control
			Get
				Return Me.OOOOooo0000.o.
			End Get
			Set(value As Control)
				Dim num As Integer
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Me.OOOOooo0000.o. = value
					IL_10:
					num2 = 3
					Me.OOOOooo0000.o..Dock = DockStyle.Fill
					IL_1E:
					num2 = 4
					If Me.ChildControl.[GetType]() IsNot GetType(C1TextBox) AndAlso Not(TypeOf Me.ChildControl Is C1DropDownControl) Then
						GoTo IL_59
					End If
					IL_44:
					num2 = 5
					MyBase.Height = Me.OOOOooo0000.o..Height
					GoTo IL_76
					IL_59:
					num2 = 7
					If Not Me.IsFixedHeight Then
						GoTo IL_76
					End If
					IL_63:
					num2 = 8
					MyBase.Height = Me.OOOOooo0000.o..Height
					IL_76:
					num2 = 9
					If Not Me.IsFixedWidth Then
						GoTo IL_95
					End If
					IL_81:
					num2 = 10
					MyBase.Width = Me.OOOOooo0000.o..Width
					IL_95:
					num2 = 11
					AddHandler Me.OOOOooo0000.o..Resize, AddressOf Me.O000_oo.o_.
					IL_AF:
					num2 = 12
					If Not(TypeOf Me.OOOOooo0000.o. Is C1TextBox) Then
						GoTo IL_DE
					End If
					IL_BF:
					num2 = 13
					AddHandler CType(Me.OOOOooo0000.o., C1TextBox).MultilineChanged, AddressOf Me.o_.0Oo.
					IL_DE:
					num2 = 14
					If Not(TypeOf Me.OOOOooo0000.o. Is C1TextBox) AndAlso Not(TypeOf Me.OOOOooo0000.o. Is C1DropDownControl) Then
						GoTo IL_115
					End If
					IL_FB:
					num2 = 15
					AddHandler Me.OOOOooo0000.o..FontChanged, AddressOf Me.O_0oO0OOoOO0.o.
					IL_115:
					num2 = 16
					Dim controlTypeEnum As ControlTypeEnum = Me.ControlType
					If controlTypeEnum <= ControlTypeEnum.TreeView Then
						If controlTypeEnum - ControlTypeEnum.GroupBox <= 2 OrElse controlTypeEnum - ControlTypeEnum.TabControl <= 1 Then
							GoTo IL_184
						End If
					Else
						If controlTypeEnum = ControlTypeEnum.NavBar Then
							GoTo IL_184
						End If
						Select Case controlTypeEnum
							Case ControlTypeEnum.FilterTree, ControlTypeEnum.LoadTree, ControlTypeEnum.InlineTree, ControlTypeEnum.LayersTree, ControlTypeEnum.Gauges, ControlTypeEnum.GanttView, ControlTypeEnum.Map
								GoTo IL_184
						End Select
					End If
					IL_16A:
					num2 = 19
					AddHandler Me.OOOOooo0000.o..Enter, AddressOf Me.o0__0.OOO.
					IL_184:
					num2 = 21
					If Me.ControlType <> ControlTypeEnum.TreeView Then
						GoTo IL_206
					End If
					IL_191:
					num2 = 22
					MyBase.Controls.Add(New O00_Oooo0oo00())
					IL_1A4:
					num2 = 23
					AddHandler CType(Me.ChildControl, TreeView).AfterSelect, AddressOf Me.O.O_000.
					IL_1C3:
					num2 = 24
					AddHandler CType(Me.ChildControl, TreeView).AfterLabelEdit, AddressOf Me.O.O0.
					IL_1E2:
					num2 = 25
					AddHandler CType(Me.ChildControl, TreeView).BeforeLabelEdit, AddressOf Me.O.O_000.
					GoTo IL_33B
					IL_206:
					num2 = 27
					If Me.ControlType <> ControlTypeEnum.SplitContainer Then
						GoTo IL_256
					End If
					IL_213:
					num2 = 28
					AddHandler CType(Me.ChildControl, SplitContainer).SplitterMoving, AddressOf Me.O.O_000.
					IL_232:
					num2 = 29
					AddHandler CType(Me.ChildControl, SplitContainer).SplitterMoved, AddressOf Me.O.O_000.
					GoTo IL_33B
					IL_256:
					num2 = 31
					If Me.ControlType <> ControlTypeEnum.TabControl Then
						GoTo IL_2B9
					End If
					IL_263:
					num2 = 32
					MyBase.Controls.Add(New oOOOO_Oo_())
					IL_276:
					num2 = 33
					CType(Me.OOOOooo0000.o., C1DockingTab).SelectedIndexChanging += AddressOf Me.O0_.0.
					IL_295:
					num2 = 34
					CType(Me.OOOOooo0000.o., C1DockingTab).SelectedIndexChanged += AddressOf Me.O.oOO0_o0_.
					GoTo IL_33B
					IL_2B9:
					num2 = 36
					If Me.ControlType <> ControlTypeEnum.NavBar Then
						GoTo IL_2FA
					End If
					IL_2C6:
					num2 = 37
					MyBase.Controls.Add(New OOO0_00O())
					IL_2D9:
					num2 = 38
					CType(Me.OOOOooo0000.o., C1NavBar).SelectedPanelChanged += AddressOf Me.O__oO_.__0_0OO.
					GoTo IL_33B
					IL_2FA:
					num2 = 40
					If Me.ControlType <> ControlTypeEnum.Gauges Then
						GoTo IL_31C
					End If
					IL_307:
					num2 = 41
					MyBase.Controls.Add(New O_O_OO())
					GoTo IL_33B
					IL_31C:
					num2 = 43
					If Me.ControlType <> ControlTypeEnum.TopicBar Then
						GoTo IL_33B
					End If
					IL_328:
					num2 = 44
					MyBase.Controls.Add(New oOOO0oo0_oO_o())
					IL_33B:
					num2 = 45
					If Not O_O0OO.O0_00o.o0__o..PropertyIsValid Then
						GoTo IL_3FF
					End If
					IL_34D:
					num2 = 46
					If Not Me.IsContainer Then
						GoTo IL_38E
					End If
					IL_358:
					num2 = 47
					Dim value2 As OO0 = New OO0()
					IL_362:
					num2 = 48
					MyBase.Controls.Add(value2)
					IL_372:
					num2 = 49
					AddHandler Me.OOOOooo0000.o..MouseDown, AddressOf Me.o_.0Oo.
					GoTo IL_3FF
					IL_38E:
					num2 = 51
					AddHandler Me.OOOOooo0000.o..MouseDown, AddressOf Me.o0_.0O_O0O.
					IL_3A8:
					num2 = 52
					AddHandler Me.OOOOooo0000.o..MouseMove, AddressOf Me.oOO.O.
					IL_3C2:
					num2 = 53
					AddHandler Me.OOOOooo0000.o..MouseUp, AddressOf Me.O000_oo.o_.
					IL_3DC:
					num2 = 54
					If TypeOf Me.OOOOooo0000.o. Is WebBrowser Then
						GoTo IL_3FF
					End If
					IL_3EC:
					num2 = 55
					Me.OOOOooo0000.o..Cursor = Cursors.SizeAll
					IL_3FF:
					num2 = 56
					MyBase.Controls.Add(Me.OOOOooo0000.o.)
					IL_413:
					GoTo IL_549
					IL_418:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_50A:
					GoTo IL_53E
					IL_50C:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_51C:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_50C
				End Try
				IL_53E:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_549:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x17000CCD RID: 3277
		' (get) Token: 0x06003A49 RID: 14921 RVA: 0x00193B00 File Offset: 0x00191D00
		Public ReadOnly Property IsFixedWidth As Boolean
			Get
				If Me.ChildControl.[GetType]() Is GetType(C1Label) Then
					If Me.ChildControl.AutoSize Then
						Return True
					End If
				ElseIf Me.ChildControl.[GetType]() Is GetType(TrackBar) AndAlso CType(Me.ChildControl, TrackBar).Orientation = Orientation.Vertical Then
					Return True
				End If
				Dim result As Boolean
				If Me.ChildControl.[GetType]() Is GetType(OOo00o_0o0_) Then
					result = True
				ElseIf TypeOf Me.ChildControl Is MonthCalendar Then
					result = True
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000CCE RID: 3278
		' (get) Token: 0x06003A4A RID: 14922 RVA: 0x00193B90 File Offset: 0x00191D90
		Public ReadOnly Property IsFixedHeight As Boolean
			Get
				Dim result As Boolean
				If(Me.ChildControl.[GetType]() Is GetType(C1Label) OrElse Me.ChildControl.[GetType]() Is GetType(CheckBox)) AndAlso Me.ChildControl.AutoSize Then
					result = True
				ElseIf Me.ChildControl.[GetType]() Is GetType(C1TextBox) AndAlso Not CType(Me.ChildControl, C1TextBox).Multiline Then
					result = True
				ElseIf TypeOf Me.ChildControl Is C1DropDownControl Then
					result = True
				ElseIf TypeOf Me.ChildControl Is MonthCalendar Then
					result = True
				ElseIf Me.ChildControl.[GetType]() Is GetType(TrackBar) AndAlso CType(Me.ChildControl, TrackBar).Orientation = Orientation.Horizontal Then
					result = True
				ElseIf Me.ChildControl.[GetType]() Is GetType(OOo00o_0o0_) Then
					result = True
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000CCF RID: 3279
		' (get) Token: 0x06003A4B RID: 14923 RVA: 0x00193C78 File Offset: 0x00191E78
		Public ReadOnly Property ParentHolder As ControlHolder
			Get
				Dim result As ControlHolder
				If TypeOf MyBase.Parent Is o0_OO0 Then
					result = CType(MyBase.Parent.Parent.Parent.Parent, ControlHolder)
				ElseIf TypeOf MyBase.Parent Is oO_0 Then
					result = CType(MyBase.Parent.Parent.Parent, ControlHolder)
				ElseIf TypeOf MyBase.Parent Is Panel Or TypeOf MyBase.Parent Is GroupBox Or TypeOf MyBase.Parent Is C1Gauge Or TypeOf MyBase.Parent Is C1Map Then
					result = CType(MyBase.Parent.Parent, ControlHolder)
				ElseIf TypeOf MyBase.Parent.Parent Is CustomPictureBox Then
					result = CType(MyBase.Parent.Parent.Parent, ControlHolder)
				ElseIf TypeOf MyBase.Parent Is C1DockingTabPage Then
					result = CType(MyBase.Parent.Parent.Parent, ControlHolder)
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x06003A4C RID: 14924 RVA: 0x00193D7C File Offset: 0x00191F7C
		Protected Overrides Sub OnParentChanged(e As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				IL_09:
				num2 = 3
				MyBase.OnParentChanged(e)
				IL_12:
				num2 = 4
				If MyBase.FindForm() Is Nothing Then
					GoTo IL_5A8
				End If
				IL_1F:
				num2 = 6
				If MyBase.Parent IsNot MyBase.FindForm() Then
					GoTo IL_62
				End If
				IL_2F:
				num2 = 7
				Me.DataRow("ParentKey") = RuntimeHelpers.GetObjectValue(CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).o_0O.OO0_0_.("Key"))
				GoTo IL_80
				IL_62:
				num2 = 9
				Me.DataRow("ParentKey") = Me.ParentHolder.Key
				IL_80:
				num2 = 10
				If Me.a = 1 Then
					GoTo IL_5A8
				End If
				IL_8F:
				num2 = 12
				Me.a = 1
				IL_99:
				num2 = 13
				AddHandler Me.ChildControl.Click, AddressOf Me.Ooo0O00_0._O0.
				IL_B3:
				num2 = 14
				If Not(Me.ControlType = ControlTypeEnum.GroupBox Or Me.ControlType = ControlTypeEnum.Panel Or Me.ControlType = ControlTypeEnum.Gauges Or Me.ControlType = ControlTypeEnum.Map) Then
					GoTo IL_18D
				End If
				IL_E6:
				num2 = 15
				Dim [object] As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
				IL_F5:
				num2 = 16
				AddHandler Me.ChildControl.MouseDown, AddressOf [object].O0ooOo0.o.
				IL_10F:
				num2 = 17
				AddHandler Me.ChildControl.MouseMove, AddressOf [object].oooo_._O.
				IL_129:
				num2 = 18
				AddHandler Me.ChildControl.MouseUp, AddressOf [object].OOOoO.Oo_O0o_0.
				IL_143:
				num2 = 19
				Me.ChildControl.AllowDrop = True
				IL_152:
				num2 = 20
				AddHandler Me.ChildControl.DragEnter, AddressOf [object].o_.000OOOoo.
				IL_16C:
				num2 = 21
				AddHandler Me.ChildControl.DragDrop, AddressOf [object].o.Ooo0__0.
				IL_186:
				[object] = Nothing
				GoTo IL_576
				IL_18D:
				num2 = 24
				If Me.ControlType <> ControlTypeEnum.PictureBox Then
					GoTo IL_25E
				End If
				IL_19D:
				num2 = 25
				Dim pictureBox As PictureBox = CType(Me.ChildControl, CustomPictureBox).PictureBox1
				IL_1B2:
				num2 = 26
				Dim object2 As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
				IL_1C2:
				num2 = 27
				AddHandler pictureBox.MouseDown, AddressOf Me.o_.0Oo.
				IL_1D8:
				num2 = 28
				AddHandler pictureBox.MouseDown, AddressOf object2.O0ooOo0.o.
				IL_1EF:
				num2 = 29
				AddHandler pictureBox.MouseMove, AddressOf object2.oooo_._O.
				IL_206:
				num2 = 30
				AddHandler pictureBox.MouseUp, AddressOf object2.OOOoO.Oo_O0o_0.
				IL_21D:
				num2 = 31
				pictureBox.AllowDrop = True
				IL_228:
				num2 = 32
				AddHandler pictureBox.DragEnter, AddressOf object2.o_.000OOOoo.
				IL_23F:
				num2 = 33
				AddHandler pictureBox.DragDrop, AddressOf object2.o.Ooo0__0.
				IL_256:
				object2 = Nothing
				GoTo IL_576
				IL_25E:
				num2 = 36
				If Me.ControlType <> ControlTypeEnum.SplitContainer Then
					GoTo IL_43A
				End If
				IL_26E:
				num2 = 37
				Dim o0000O As o0000O = CType(Me.ChildControl, o0000O)
				IL_27E:
				num2 = 38
				Dim object3 As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
				IL_28E:
				num2 = 39
				AddHandler o0000O.oo0oO_O.oooO0O.().Click, AddressOf Me.Ooo0O00_0._O0.
				IL_2A9:
				num2 = 40
				AddHandler o0000O.oo0oO_O.oooO0O.().MouseDown, AddressOf Me.o_.0Oo.
				IL_2C4:
				num2 = 41
				AddHandler o0000O.oo0oO_O.oooO0O.().MouseDown, AddressOf object3.O0ooOo0.o.
				IL_2E0:
				num2 = 42
				AddHandler o0000O.oo0oO_O.oooO0O.().MouseMove, AddressOf object3.oooo_._O.
				IL_2FC:
				num2 = 43
				AddHandler o0000O.oo0oO_O.oooO0O.().MouseUp, AddressOf object3.OOOoO.Oo_O0o_0.
				IL_318:
				num2 = 44
				o0000O.oo0oO_O.oooO0O.().AllowDrop = True
				IL_328:
				num2 = 45
				AddHandler o0000O.oo0oO_O.oooO0O.().DragEnter, AddressOf object3.o_.000OOOoo.
				IL_344:
				num2 = 46
				AddHandler o0000O.oo0oO_O.oooO0O.().DragDrop, AddressOf object3.o.Ooo0__0.
				IL_360:
				num2 = 47
				AddHandler o0000O.o.Oo0oo000O.().Click, AddressOf Me.Ooo0O00_0._O0.
				IL_37B:
				num2 = 48
				AddHandler o0000O.o.Oo0oo000O.().MouseDown, AddressOf Me.o_.0Oo.
				IL_396:
				num2 = 49
				AddHandler o0000O.o.Oo0oo000O.().MouseDown, AddressOf object3.O0ooOo0.o.
				IL_3B2:
				num2 = 50
				AddHandler o0000O.o.Oo0oo000O.().MouseMove, AddressOf object3.oooo_._O.
				IL_3CE:
				num2 = 51
				AddHandler o0000O.o.Oo0oo000O.().MouseUp, AddressOf object3.OOOoO.Oo_O0o_0.
				IL_3EA:
				num2 = 52
				o0000O.o.Oo0oo000O.().AllowDrop = True
				IL_3FA:
				num2 = 53
				AddHandler o0000O.o.Oo0oo000O.().DragEnter, AddressOf object3.o_.000OOOoo.
				IL_416:
				num2 = 54
				AddHandler o0000O.o.Oo0oo000O.().DragDrop, AddressOf object3.o.Ooo0__0.
				IL_432:
				object3 = Nothing
				GoTo IL_576
				IL_43A:
				num2 = 57
				If Me.ControlType <> ControlTypeEnum.TabControl Then
					GoTo IL_4B3
				End If
				IL_447:
				num2 = 58
				If CType(Me.ChildControl, C1DockingTab).TabPages.Count <> 0 Then
					GoTo IL_576
				End If
				IL_464:
				num2 = 59
				Me.oo_.o_O.().Text = "Page1"
				IL_477:
				num2 = 60
				Me.oo_.o_O.().Text = "Page2"
				IL_48A:
				num2 = 61
				Me.oo_.o_O.().Text = "Page3"
				IL_49D:
				num2 = 62
				Dim c1DockingTab As C1DockingTab = CType(Me.ChildControl, C1DockingTab)
				IL_4AC:
				GoTo IL_576
				IL_4B3:
				num2 = 65
				If Me.ControlType <> ControlTypeEnum.NavBar Then
					GoTo IL_576
				End If
				IL_4C3:
				num2 = 66
				If CType(Me.ChildControl, C1NavBar).Panels.Count <> 0 Then
					GoTo IL_576
				End If
				IL_4E0:
				num2 = 67
				Dim array As String() = "日历|联系人|任务".Split(New Char() { "|"c })
				IL_4FA:
				num2 = 68
				Dim num3 As Integer = 1
				Do
					IL_500:
					num2 = 69
					Dim a_ As oO_0 = Me.oo_.o_O.()
					IL_50B:
					num2 = 70
					Dim customNavBarPanelProperty As CustomNavBarPanelProperty = New CustomNavBarPanelProperty(a_)
					IL_517:
					num2 = 71
					customNavBarPanelProperty.ButtonText = array(num3 - 1)
					IL_528:
					num2 = 72
					customNavBarPanelProperty.ButtonImageFile = "240" + Conversions.ToString(num3) + ".ico"
					IL_548:
					num2 = 73
					customNavBarPanelProperty.ButtonSmallImageFile = "160" + Conversions.ToString(num3) + ".ico"
					IL_568:
					num2 = 74
					num3 += 1
				Loop While num3 <= 3
				IL_576:
				num2 = 75
				If Operators.CompareString(OO_00oOO.BaseMainForm.[GetType]().Name, OO_00oOO.BaseMainForm.Name, True) <> 0 Then
					GoTo IL_5A8
				End If
				IL_59A:
				num2 = 76
				MyBase.Controls.Clear()
				IL_5A8:
				GoTo IL_72E
				IL_5AD:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_6EF:
				GoTo IL_723
				IL_6F1:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_701:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6F1
			End Try
			IL_723:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_72E:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003A4D RID: 14925 RVA: 0x001944DC File Offset: 0x001926DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If A_1.Button = MouseButtons.Left Then
				If Control.ModifierKeys = Keys.Control Then
					Me.Selected = Not Me.Selected
					Return
				End If
				If Me.Selected Then
					Me.Activated = True
					Return
				End If
				oOO0oo_o0.o0.Oo__.(MyBase.FindForm().Controls)
				Me.Selected = True
			End If
		End Sub

		' Token: 0x06003A4E RID: 14926 RVA: 0x00194539 File Offset: 0x00192739
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
		End Sub

		' Token: 0x06003A4F RID: 14927 RVA: 0x0019453C File Offset: 0x0019273C
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o_o_O._. = MyBase.Location
				IL_15:
				num2 = 3
				If A_1.Button <> MouseButtons.Left Then
					GoTo IL_15C
				End If
				IL_27:
				num2 = 4
				If Control.ModifierKeys <> Keys.Control Then
					GoTo IL_48
				End If
				IL_35:
				num2 = 5
				Me.Selected = Not Me.Selected
				GoTo IL_7A
				IL_48:
				num2 = 7
				If Not Me.Selected Then
					GoTo IL_5D
				End If
				IL_52:
				num2 = 8
				Me.Activated = True
				GoTo IL_7A
				IL_5D:
				num2 = 10
				oOO0oo_o0.o0.Oo__.(MyBase.FindForm().Controls)
				IL_70:
				num2 = 11
				Me.Selected = True
				IL_7A:
				num2 = 12
				Me.O_O00._. = MyBase.Parent
				IL_89:
				num2 = 13
				Me.O_.0oo_O. = New Point(A_1.X, A_1.Y)
				IL_A3:
				num2 = 14
				Me.OO_00.OO_o. = New Point(A_1.X, A_1.Y)
				IL_BD:
				num2 = 15
				Me.O_O00._. = New O__o00(MyBase.Parent)
				IL_D1:
				num2 = 16
				Me.DynamicKey = ShareLibriay.GetRandString(8)
				IL_E0:
				num2 = 17
				Dim enumerator As IEnumerator = MyBase.Parent.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control As Control = CType(obj, Control)
					IL_103:
					num2 = 18
					If TypeOf control Is ControlHolder Then
						IL_10F:
						num2 = 19
						CType(control, ControlHolder).DynamicKey = Me.DynamicKey
						IL_124:
						num2 = 20
						Me.O_O00._..o.oO0O0OO_o_.(CType(control, ControlHolder))
					End If
					IL_139:
					num2 = 21
				End While
				IL_144:
				num2 = 22
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_170
				End If
				GoTo IL_170
				IL_15C:
				num2 = 24
				Me.O_O00._. = Nothing
				IL_166:
				num2 = 25
				Me.o0o0.0OO. = False
				IL_170:
				GoTo IL_22A
				IL_175:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1EB:
				GoTo IL_21F
				IL_1ED:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1FD:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_1ED
			End Try
			IL_21F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_22A:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003A50 RID: 14928 RVA: 0x00194798 File Offset: 0x00192998
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_1.Button <> MouseButtons.Left Then
					GoTo IL_221
				End If
				IL_19:
				num2 = 3
				If Me.o0o0.0OO. Then
					GoTo IL_7F
				End If
				IL_23:
				num2 = 4
				Dim point As Point = New Point(Me.O_.0oo_O..X - A_1.X, Me.O_.0oo_O..Y - A_1.Y)
				IL_50:
				num2 = 5
				If Math.Abs(point.X) < 3 And Math.Abs(point.Y) < 3 Then
					GoTo IL_221
				End If
				IL_76:
				num2 = 8
				Me.o0o0.0OO. = True
				IL_7F:
				num2 = 9
				Dim point2 As Point = New Point(A_1.X, A_1.Y)
				IL_95:
				num2 = 10
				If Not Me.Activated Then
					GoTo IL_DF
				End If
				IL_A0:
				num2 = 11
				oOO0oo_o0.O00OO_O_oO_.o.(MyBase.Parent.Controls, point2.X - Me.OO_00.OO_o..X, point2.Y - Me.OO_00.OO_o..Y, Me.DynamicKey)
				IL_DF:
				num2 = 12
				CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.().Refresh()
				IL_FC:
				num2 = 13
				If Control.ModifierKeys = Keys.Shift Then
					GoTo IL_1CA
				End If
				IL_10E:
				num2 = 14
				Dim control As Control = Me.O0._o.(CType(A_0, Control).PointToScreen(New Point(A_1.X, A_1.Y)), MyBase.FindForm(), Me, True)
				IL_13C:
				num2 = 15
				If control IsNot Nothing Then
					GoTo IL_14C
				End If
				IL_142:
				num2 = 16
				control = MyBase.FindForm()
				IL_14C:
				num2 = 17
				control.Refresh()
				IL_155:
				num2 = 18
				If MyBase.Parent Is control Then
					GoTo IL_1CA
				End If
				IL_161:
				num2 = 19
				Dim p As Point = MyBase.Parent.PointToScreen(MyBase.Location)
				IL_177:
				num2 = 20
				p = control.PointToClient(p)
				IL_184:
				num2 = 21
				Dim a_ As Integer = p.X - MyBase.Location.X
				IL_1A0:
				num2 = 22
				Dim a_2 As Integer = p.Y - MyBase.Location.Y
				IL_1BC:
				num2 = 23
				Me.O.O_000.(control, a_, a_2)
				IL_1CA:
				num2 = 24
				If MyBase.Parent IsNot Me.O_O00._. Then
					GoTo IL_1F0
				End If
				IL_1DB:
				num2 = 25
				CType(A_0, Control).Cursor = Cursors.SizeAll
				GoTo IL_221
				IL_1F0:
				num2 = 27
				CType(A_0, Control).Cursor = New Cursor(c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\Images\DRAGMOVE.CUR")
				IL_221:
				GoTo IL_2E3
				IL_226:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2A4:
				GoTo IL_2D8
				IL_2A6:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2B6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2A6
			End Try
			IL_2D8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2E3:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003A51 RID: 14929 RVA: 0x00194AAC File Offset: 0x00192CAC
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If CType(A_0, Control).Cursor IsNot Cursors.SizeAll Then
				CType(A_0, Control).Cursor = Cursors.SizeAll
			End If
			If Me.o0o0.0OO. Then
				Me.o0o0.0OO. = False
			End If
			If Me.o_o_O._. <> MyBase.Location AndAlso Me.O_O00._. IsNot Nothing Then
				CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).o_0O.OO0_0_..Add(Me.O_O00._.)
				Me.O_O00._. = Nothing
			End If
		End Sub

		' Token: 0x06003A52 RID: 14930 RVA: 0x00194B2C File Offset: 0x00192D2C
		Private Sub <<EMPTY_NAME>>(A_0 As Control, A_1 As Integer, A_2 As Integer)
			Dim list As List(Of ControlHolder) = New List(Of ControlHolder)()
			Try
				For Each obj As Object In MyBase.Parent.Controls
					Dim control As Control = CType(obj, Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Selected And Operators.CompareString(controlHolder.DynamicKey, Me.DynamicKey, True) = 0 Then
							list.Add(CType(control, ControlHolder))
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each control As Control In list
					Dim controlHolder2 As ControlHolder = CType(control, ControlHolder)
					controlHolder2.Parent = A_0
					controlHolder2.Location = New Point(controlHolder2.Location.X + A_1, controlHolder2.Location.Y + A_2)
				Next
			Finally
				Dim enumerator2 As List(Of ControlHolder).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06003A53 RID: 14931 RVA: 0x00194C44 File Offset: 0x00192E44
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.FocusLabel.Focus()
		End Sub

		' Token: 0x06003A54 RID: 14932 RVA: 0x00194C54 File Offset: 0x00192E54
		Public Function <<EMPTY_NAME>>(A_0 As Point, A_1 As Control, A_2 As ControlHolder, A_3 As Boolean) As Control
			Dim num As Integer
			Dim result As Control
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_2.ParentHolder Is Nothing OrElse Not A_3 Then
					GoTo IL_6C
				End If
				IL_17:
				num2 = 3
				If Not A_2.Parent.ClientRectangle.Contains(A_2.Parent.PointToClient(A_0)) Then
					GoTo IL_6C
				End If
				IL_3B:
				num2 = 4
				Dim control As Control = Me.O0._o.(A_0, A_2.Parent, A_2, False)
				IL_4E:
				num2 = 5
				If control Is Nothing Then
					GoTo IL_5E
				End If
				IL_54:
				num2 = 6
				result = control
				GoTo IL_412
				IL_5E:
				num2 = 8
				result = A_2.Parent
				GoTo IL_412
				IL_6C:
				num2 = 9
				Dim enumerator As IEnumerator = A_1.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control2 As Control = CType(obj, Control)
					IL_8F:
					num2 = 10
					If control2 IsNot A_2 AndAlso TypeOf control2 Is ControlHolder Then
						IL_A6:
						num2 = 11
						Dim controlHolder As ControlHolder = CType(control2, ControlHolder)
						IL_B2:
						num2 = 12
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							IL_E6:
							num2 = 13
							If controlHolder.ChildControl.ClientRectangle.Contains(controlHolder.ChildControl.PointToClient(A_0)) Then
								IL_110:
								num2 = 14
								control = Me.O0._o.(A_0, controlHolder.ChildControl, A_2, False)
								IL_125:
								num2 = 15
								If control IsNot Nothing Then
									IL_12C:
									num2 = 16
									result = control
									GoTo IL_412
								End If
								IL_137:
								num2 = 18
								result = controlHolder.ChildControl
								GoTo IL_412
							End If
						Else
							IL_147:
							num2 = 20
							If controlHolder.ControlType = ControlTypeEnum.PictureBox Then
								IL_158:
								num2 = 21
								Dim pictureBox As PictureBox = CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1
								IL_16E:
								num2 = 22
								Dim controlHolder2 As ControlHolder = Nothing
								IL_174:
								num2 = 23
								Dim control3 As Control = pictureBox
								While True
									IL_1A3:
									num2 = 25
									If control3 Is Nothing Then
										Exit For
									End If
									IL_17D:
									num2 = 26
									If TypeOf control3 Is ControlHolder Then
										GoTo IL_189
									End If
									IL_197:
									num2 = 29
									control3 = control3.Parent
								End While
								IL_1AA:
								num2 = 31
								If controlHolder2 Is Nothing Then
									GoTo IL_3E6
								End If
								IL_1B4:
								num2 = 33
								If Not controlHolder2.ClientRectangle.Contains(pictureBox.PointToClient(A_0)) Then
									GoTo IL_3E6
								End If
								IL_1D4:
								num2 = 34
								control = Me.O0._o.(A_0, pictureBox, A_2, False)
								IL_1E4:
								num2 = 35
								If control IsNot Nothing Then
									IL_1EB:
									num2 = 36
									result = control
									GoTo IL_412
								End If
								IL_1F6:
								num2 = 38
								result = pictureBox
								GoTo IL_412
								IL_189:
								num2 = 27
								controlHolder2 = CType(control3, ControlHolder)
								GoTo IL_1AA
							End If
							IL_201:
							num2 = 40
							If controlHolder.ControlType = ControlTypeEnum.TabControl Then
								IL_20F:
								num2 = 41
								Dim c1DockingTab As C1DockingTab = CType(controlHolder.ChildControl, C1DockingTab)
								IL_220:
								num2 = 42
								If c1DockingTab.SelectedTab.ClientRectangle.Contains(c1DockingTab.SelectedTab.PointToClient(A_0)) Then
									IL_247:
									num2 = 43
									control = Me.O0._o.(A_0, c1DockingTab.SelectedTab, A_2, False)
									IL_25C:
									num2 = 44
									If control IsNot Nothing Then
										IL_263:
										num2 = 45
										result = control
										GoTo IL_412
									End If
									IL_26E:
									num2 = 47
									result = c1DockingTab.SelectedTab
									GoTo IL_412
								Else
									IL_27E:
									c1DockingTab = Nothing
								End If
							Else
								IL_286:
								num2 = 50
								If controlHolder.ControlType = ControlTypeEnum.NavBar Then
									IL_294:
									num2 = 51
									Dim c1NavBar As C1NavBar = CType(controlHolder.ChildControl, C1NavBar)
									IL_2A5:
									num2 = 52
									If c1NavBar.SelectedPanel.ClientRectangle.Contains(c1NavBar.SelectedPanel.PointToClient(A_0)) Then
										IL_2CC:
										num2 = 53
										control = Me.O0._o.(A_0, c1NavBar.SelectedPanel, A_2, False)
										IL_2E1:
										num2 = 54
										If control IsNot Nothing Then
											IL_2E8:
											num2 = 55
											result = control
											GoTo IL_412
										End If
										IL_2F3:
										num2 = 57
										result = c1NavBar.SelectedPanel
										GoTo IL_412
									Else
										IL_303:
										c1NavBar = Nothing
									End If
								Else
									IL_30B:
									num2 = 60
									If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
										IL_31C:
										num2 = 61
										Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
										IL_32D:
										num2 = 62
										If o0000O.oo0oO_O.oooO0O.().ClientRectangle.Contains(o0000O.oo0oO_O.oooO0O.().PointToClient(A_0)) Then
											IL_354:
											num2 = 63
											control = Me.O0._o.(A_0, o0000O.oo0oO_O.oooO0O.(), A_2, False)
											IL_369:
											num2 = 64
											If control IsNot Nothing Then
												IL_370:
												num2 = 65
												result = control
												GoTo IL_412
											End If
											IL_37B:
											num2 = 67
											result = o0000O.oo0oO_O.oooO0O.()
											GoTo IL_412
										Else
											IL_38B:
											num2 = 68
											If o0000O.o.Oo0oo000O.().ClientRectangle.Contains(o0000O.o.Oo0oo000O.().PointToClient(A_0)) Then
												IL_3B2:
												num2 = 69
												control = Me.O0._o.(A_0, o0000O.o.Oo0oo000O.(), A_2, False)
												IL_3C7:
												num2 = 70
												If control IsNot Nothing Then
													IL_3CE:
													num2 = 71
													result = control
													GoTo IL_412
												End If
												IL_3D6:
												num2 = 73
												result = o0000O.o.Oo0oo000O.()
												GoTo IL_412
											Else
												IL_3E3:
												o0000O = Nothing
											End If
										End If
									End If
								End If
							End If
						End If
					End If
					IL_3E6:
					num2 = 75
				End While
				IL_3F5:
				num2 = 76
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_40D:
				num2 = 77
				result = Nothing
				IL_412:
				GoTo IL_59C
				IL_417:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_55D:
				GoTo IL_591
				IL_55F:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_56F:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_55F
			End Try
			IL_591:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_59C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003A55 RID: 14933 RVA: 0x00195224 File Offset: 0x00193424
		Public Function <<EMPTY_NAME>>() As O_O_
			Dim control As Control = CType(Me.ChildControl, C1DockingTab)
			Dim o_O_ As O_O_ = New O_O_()
			control.Controls.Add(o_O_)
			Dim [object] As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
			AddHandler o_O_.Click, AddressOf Me.Ooo0O00_0._O0.
			AddHandler o_O_.MouseDown, AddressOf Me.o_.0Oo.
			AddHandler o_O_.MouseDown, AddressOf [object].O0ooOo0.o.
			AddHandler o_O_.MouseMove, AddressOf [object].oooo_._O.
			AddHandler o_O_.MouseUp, AddressOf [object].OOOoO.Oo_O0o_0.
			o_O_.AllowDrop = True
			AddHandler o_O_.DragEnter, AddressOf [object].o_.000OOOoo.
			AddHandler o_O_.DragDrop, AddressOf [object].o.Ooo0__0.
			Return o_O_
		End Function

		' Token: 0x06003A56 RID: 14934 RVA: 0x001952E4 File Offset: 0x001934E4
		Friend Function <<EMPTY_NAME>>() As oO_0
			Dim control As Control = CType(Me.ChildControl, C1NavBar)
			Dim oO_ As oO_0 = New oO_0()
			control.Controls.Add(oO_)
			Dim [object] As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
			AddHandler oO_.Click, AddressOf Me.Ooo0O00_0._O0.
			AddHandler oO_.MouseDown, AddressOf Me.o_.0Oo.
			AddHandler oO_.MouseDown, AddressOf [object].O0ooOo0.o.
			AddHandler oO_.MouseMove, AddressOf [object].oooo_._O.
			AddHandler oO_.MouseUp, AddressOf [object].OOOoO.Oo_O0o_0.
			oO_.AllowDrop = True
			AddHandler oO_.DragEnter, AddressOf [object].o_.000OOOoo.
			AddHandler oO_.DragDrop, AddressOf [object].o.Ooo0__0.
			Return oO_
		End Function

		' Token: 0x06003A57 RID: 14935 RVA: 0x001953A4 File Offset: 0x001935A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SelectedIndexChangingEventArgs)
			Dim c1DockingTab As C1DockingTab = CType(A_0, C1DockingTab)
			If c1DockingTab.SelectedTab IsNot Nothing Then
				oOO0oo_o0.o0.Oo__.(c1DockingTab.SelectedTab.Controls)
			End If
		End Sub

		' Token: 0x06003A58 RID: 14936 RVA: 0x001953D2 File Offset: 0x001935D2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.FindForm() IsNot Nothing Then
				Dim propertyGridEx As PropertyGridEx2 = CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.()
				propertyGridEx.SelectedObjects = propertyGridEx.SelectedObjects
			End If
		End Sub

		' Token: 0x06003A59 RID: 14937 RVA: 0x00195400 File Offset: 0x00193600
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In CType(A_0, C1NavBar).Panels
					oOO0oo_o0.o0.Oo__.(CType(obj, C1NavBarPanel).Controls)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If MyBase.FindForm() IsNot Nothing Then
				Dim propertyGridEx As PropertyGridEx2 = CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.()
				propertyGridEx.SelectedObjects = propertyGridEx.SelectedObjects
			End If
		End Sub

		' Token: 0x06003A5A RID: 14938 RVA: 0x00195490 File Offset: 0x00193690
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.IsFixedHeight Then
				MyBase.Height = Me.ChildControl.Height
			End If
			If Me.IsFixedWidth Then
				MyBase.Width = Me.ChildControl.Width
			End If
		End Sub

		' Token: 0x06003A5B RID: 14939 RVA: 0x001954C4 File Offset: 0x001936C4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.FindForm() IsNot Nothing AndAlso TypeOf Me.ChildControl Is C1TextBox Then
				Dim c1TextBox As C1TextBox = CType(Me.ChildControl, C1TextBox)
				If Not c1TextBox.Multiline Then
					MyBase.Height = c1TextBox.PreferredHeight
				End If
			End If
		End Sub

		' Token: 0x06003A5C RID: 14940 RVA: 0x00195508 File Offset: 0x00193708
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf Me.ChildControl Is C1TextBox Then
				Dim c1TextBox As C1TextBox = CType(Me.ChildControl, C1TextBox)
				If Not c1TextBox.Multiline Then
					MyBase.Height = c1TextBox.PreferredHeight
				Else
					MyBase.Height = c1TextBox.PreferredHeight * 5
				End If
			End If
		End Sub

		' Token: 0x06003A5D RID: 14941 RVA: 0x00195554 File Offset: 0x00193754
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.().Refresh()
		End Sub

		' Token: 0x06003A5E RID: 14942 RVA: 0x00195570 File Offset: 0x00193770
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NodeLabelEditEventArgs)
			Dim propertyGridEx As PropertyGridEx2 = CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.()
			propertyGridEx.SelectedObjects = propertyGridEx.SelectedObjects
			If Me.O_O00._. IsNot Nothing AndAlso Operators.CompareString(Me.O_O00._..o_0_0.O_o__0o.(), A_1.Label, True) <> 0 Then
				CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).o_0O.OO0_0_..Add(Me.O_O00._.)
			End If
			Me.O_O00._. = Nothing
		End Sub

		' Token: 0x06003A5F RID: 14943 RVA: 0x001955E2 File Offset: 0x001937E2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NodeLabelEditEventArgs)
			Me.O_O00._. = New O0oo_0O(A_1.Node, Me)
		End Sub

		' Token: 0x06003A60 RID: 14944 RVA: 0x001955F8 File Offset: 0x001937F8
		Public Sub <<EMPTY_NAME>>()
			Dim o_u3002_u3002_u3000_u3000_u As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
			If TypeOf Me.ChildControl Is Panel Then
				CType(Me.ChildControl, Panel).AutoScrollPosition = New Point(0, 0)
			End If
			If Me.ControlType = ControlTypeEnum.Table Then
				Dim text As String = Conversions.ToString(Me.DataRow("Key"))
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { text, o0_O.Oo.Oo__O. })
				If dataRow IsNot Nothing Then
					dataRow("Config") = ""
				End If
			End If
			Me.DataRow("Property") = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.(Me.Key), False, vbVerticalTab, False)
			Dim text2 As String = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.(Me.Key), True, vbVerticalTab, False)
			If Operators.CompareString(text2, "", True) > 0 Then
				Me.DataRow("Code") = O00.ooo000o_0.00o0.(text2, ooO0__OO.O_Oo00oO.Ooo.(), ooO0__OO.O_Oo00oO.Ooo.())
			Else
				Me.DataRow("Code") = Nothing
			End If
			If Me.ControlType = ControlTypeEnum.Panel Or Me.ControlType = ControlTypeEnum.GroupBox Or Me.ControlType = ControlTypeEnum.Gauges Or Me.ControlType = ControlTypeEnum.Map Then
				Try
					For Each obj As Object In Me.ChildControl.Controls
						Dim control As Control = CType(obj, Control)
						If TypeOf control Is ControlHolder Then
							CType(control, ControlHolder).oO_O.0O__o.()
						End If
					Next
					Return
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			If Me.ControlType = ControlTypeEnum.PictureBox Then
				Try
					For Each obj2 As Object In CType(Me.ChildControl, CustomPictureBox).PictureBox1.Controls
						Dim control As Control = CType(obj2, Control)
						If TypeOf control Is ControlHolder Then
							CType(control, ControlHolder).oO_O.0O__o.()
						End If
					Next
					Return
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
			If Me.ControlType = ControlTypeEnum.TabControl Then
				Dim c1DockingTab As C1DockingTab = CType(Me.ChildControl, C1DockingTab)
				Try
					For Each obj3 As Object In c1DockingTab.TabPages
						Dim o_O_ As O_O_ = CType(obj3, O_O_)
						Try
							For Each obj4 As Object In o_O_.Controls
								Dim control As Control = CType(obj4, Control)
								If TypeOf control Is ControlHolder Then
									CType(control, ControlHolder).oO_O.0O__o.()
									CType(control, ControlHolder).DataRow("Page") = c1DockingTab.TabPages.IndexOf(o_O_)
								End If
							Next
						Finally
							Dim enumerator4 As IEnumerator
							If TypeOf enumerator4 Is IDisposable Then
								TryCast(enumerator4, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
				c1DockingTab = Nothing
			ElseIf Me.ControlType = ControlTypeEnum.NavBar Then
				Dim c1NavBar As C1NavBar = CType(Me.ChildControl, C1NavBar)
				Try
					For Each obj5 As Object In c1NavBar.Panels
						Dim oO_ As oO_0 = CType(obj5, oO_0)
						Try
							For Each obj6 As Object In oO_.Controls
								Dim control As Control = CType(obj6, Control)
								If TypeOf control Is ControlHolder Then
									CType(control, ControlHolder).oO_O.0O__o.()
									CType(control, ControlHolder).DataRow("Page") = c1NavBar.Panels.IndexOf(oO_)
								End If
							Next
						Finally
							Dim enumerator6 As IEnumerator
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator5 As IEnumerator
					If TypeOf enumerator5 Is IDisposable Then
						TryCast(enumerator5, IDisposable).Dispose()
					End If
				End Try
				c1NavBar = Nothing
			ElseIf Me.ControlType = ControlTypeEnum.SplitContainer Then
				Dim o0000O As o0000O = CType(Me.ChildControl, o0000O)
				Try
					For Each obj7 As Object In o0000O.oo0oO_O.oooO0O.().Controls
						Dim control As Control = CType(obj7, Control)
						If TypeOf control Is ControlHolder Then
							CType(control, ControlHolder).oO_O.0O__o.()
							CType(control, ControlHolder).DataRow("Page") = 1
						End If
					Next
				Finally
					Dim enumerator7 As IEnumerator
					If TypeOf enumerator7 Is IDisposable Then
						TryCast(enumerator7, IDisposable).Dispose()
					End If
				End Try
				Try
					For Each obj8 As Object In o0000O.o.Oo0oo000O.().Controls
						Dim control As Control = CType(obj8, Control)
						If TypeOf control Is ControlHolder Then
							CType(control, ControlHolder).oO_O.0O__o.()
							CType(control, ControlHolder).DataRow("Page") = 2
						End If
					Next
				Finally
					Dim enumerator8 As IEnumerator
					If TypeOf enumerator8 Is IDisposable Then
						TryCast(enumerator8, IDisposable).Dispose()
					End If
				End Try
				o0000O = Nothing
			End If
		End Sub

		' Token: 0x06003A61 RID: 14945 RVA: 0x00195B40 File Offset: 0x00193D40
		Public Function <<EMPTY_NAME>>(A_0 As DataTable) As DataRow
			Dim num As Integer
			Dim result As DataRow
			Dim num5 As Integer
			Dim obj9 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dataRow As DataRow = A_0.NewRow()
				IL_11:
				num2 = 3
				dataRow.ItemArray = Me.DataRow.ItemArray
				IL_25:
				num2 = 4
				A_0.Rows.Add(dataRow)
				IL_34:
				num2 = 5
				Dim o_u3002_u3002_u3000_u3000_u As o\u3002\u3002\u3000\u3000\u3002 = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
				IL_43:
				num2 = 6
				dataRow("Property") = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.(Me.Key), False, vbVerticalTab, False)
				IL_6C:
				num2 = 7
				Dim a_ As String = o_O_o_oOoo__.OOOO_OO._oo.(o_u3002_u3002_u3000_u3000_u.O0o._0.(Me.Key), True, vbVerticalTab, False)
				IL_8B:
				num2 = 8
				dataRow("Code") = O00.ooo000o_0.00o0.(a_, ooO0__OO.O_Oo00oO.Ooo.(), ooO0__OO.O_Oo00oO.Ooo.())
				IL_AA:
				num2 = 9
				If Not(Me.ControlType = ControlTypeEnum.Panel Or Me.ControlType = ControlTypeEnum.GroupBox Or Me.ControlType = ControlTypeEnum.Gauges Or Me.ControlType = ControlTypeEnum.Map) Then
					GoTo IL_148
				End If
				IL_DA:
				num2 = 10
				Dim enumerator As IEnumerator = Me.ChildControl.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control As Control = CType(obj, Control)
					IL_FF:
					num2 = 11
					If TypeOf control Is ControlHolder Then
						IL_10B:
						num2 = 12
						CType(control, ControlHolder).o_.0Oo.(A_0)
					End If
					IL_11C:
					num2 = 13
				End While
				IL_128:
				num2 = 14
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_4E1
				End If
				GoTo IL_4E1
				IL_148:
				num2 = 16
				If Me.ControlType <> ControlTypeEnum.PictureBox Then
					GoTo IL_1CD
				End If
				IL_155:
				num2 = 17
				Dim enumerator2 As IEnumerator = CType(Me.ChildControl, CustomPictureBox).PictureBox1.Controls.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim control As Control = CType(obj2, Control)
					IL_184:
					num2 = 18
					If TypeOf control Is ControlHolder Then
						IL_190:
						num2 = 19
						CType(control, ControlHolder).o_.0Oo.(A_0)
					End If
					IL_1A1:
					num2 = 20
				End While
				IL_1AD:
				num2 = 21
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
					GoTo IL_4E1
				End If
				GoTo IL_4E1
				IL_1CD:
				num2 = 23
				If Me.ControlType <> ControlTypeEnum.TabControl Then
					GoTo IL_2CC
				End If
				IL_1DD:
				num2 = 24
				Dim c1DockingTab As C1DockingTab = CType(Me.ChildControl, C1DockingTab)
				IL_1ED:
				num2 = 25
				Dim enumerator3 As IEnumerator = c1DockingTab.TabPages.GetEnumerator()
				While enumerator3.MoveNext()
					Dim obj3 As Object = enumerator3.Current
					Dim o_O_ As O_O_ = CType(obj3, O_O_)
					IL_211:
					num2 = 26
					Dim enumerator4 As IEnumerator = o_O_.Controls.GetEnumerator()
					While enumerator4.MoveNext()
						Dim obj4 As Object = enumerator4.Current
						Dim control As Control = CType(obj4, Control)
						IL_232:
						num2 = 27
						If TypeOf control Is ControlHolder Then
							IL_23E:
							num2 = 28
							Dim num3 As Integer = c1DockingTab.TabPages.IndexOf(o_O_)
							IL_251:
							num2 = 29
							Dim dataRow2 As DataRow = CType(control, ControlHolder).o_.0Oo.(A_0)
							IL_263:
							num2 = 30
							dataRow2("Page") = num3
						End If
						IL_279:
						num2 = 31
					End While
					IL_285:
					num2 = 32
					If TypeOf enumerator4 Is IDisposable Then
						TryCast(enumerator4, IDisposable).Dispose()
					End If
					IL_29D:
					num2 = 33
				End While
				IL_2AC:
				num2 = 34
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
				IL_2C4:
				c1DockingTab = Nothing
				GoTo IL_4E1
				IL_2CC:
				num2 = 37
				If Me.ControlType <> ControlTypeEnum.NavBar Then
					GoTo IL_3C4
				End If
				IL_2DC:
				num2 = 38
				Dim c1NavBar As C1NavBar = CType(Me.ChildControl, C1NavBar)
				IL_2EC:
				num2 = 39
				Dim enumerator5 As IEnumerator = c1NavBar.Panels.GetEnumerator()
				While enumerator5.MoveNext()
					Dim obj5 As Object = enumerator5.Current
					Dim oO_ As oO_0 = CType(obj5, oO_0)
					IL_310:
					num2 = 40
					Dim enumerator6 As IEnumerator = oO_.Controls.GetEnumerator()
					While enumerator6.MoveNext()
						Dim obj6 As Object = enumerator6.Current
						Dim control As Control = CType(obj6, Control)
						IL_331:
						num2 = 41
						If TypeOf control Is ControlHolder Then
							IL_33D:
							num2 = 42
							Dim dataRow2 As DataRow = CType(control, ControlHolder).o_.0Oo.(A_0)
							IL_34F:
							num2 = 43
							dataRow2("Page") = c1NavBar.Panels.IndexOf(oO_)
						End If
						IL_371:
						num2 = 44
					End While
					IL_37D:
					num2 = 45
					If TypeOf enumerator6 Is IDisposable Then
						TryCast(enumerator6, IDisposable).Dispose()
					End If
					IL_395:
					num2 = 46
				End While
				IL_3A4:
				num2 = 47
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
				IL_3BC:
				c1NavBar = Nothing
				GoTo IL_4E1
				IL_3C4:
				num2 = 50
				If Me.ControlType <> ControlTypeEnum.SplitContainer Then
					GoTo IL_4E1
				End If
				IL_3D4:
				num2 = 51
				Dim o0000O As o0000O = CType(Me.ChildControl, o0000O)
				IL_3E4:
				num2 = 52
				Dim enumerator7 As IEnumerator = o0000O.oo0oO_O.oooO0O.().Controls.GetEnumerator()
				While enumerator7.MoveNext()
					Dim obj7 As Object = enumerator7.Current
					Dim control As Control = CType(obj7, Control)
					IL_40A:
					num2 = 53
					If TypeOf control Is ControlHolder Then
						IL_416:
						num2 = 54
						Dim dataRow2 As DataRow = CType(control, ControlHolder).o_.0Oo.(A_0)
						IL_428:
						num2 = 55
						dataRow2("Page") = 1
					End If
					IL_43D:
					num2 = 56
				End While
				IL_449:
				num2 = 57
				If TypeOf enumerator7 Is IDisposable Then
					TryCast(enumerator7, IDisposable).Dispose()
				End If
				IL_461:
				num2 = 58
				Dim enumerator8 As IEnumerator = o0000O.o.Oo0oo000O.().Controls.GetEnumerator()
				While enumerator8.MoveNext()
					Dim obj8 As Object = enumerator8.Current
					Dim control As Control = CType(obj8, Control)
					IL_487:
					num2 = 59
					If TypeOf control Is ControlHolder Then
						IL_493:
						num2 = 60
						Dim dataRow2 As DataRow = CType(control, ControlHolder).o_.0Oo.(A_0)
						IL_4A5:
						num2 = 61
						dataRow2("Page") = 2
					End If
					IL_4BA:
					num2 = 62
				End While
				IL_4C6:
				num2 = 63
				If TypeOf enumerator8 Is IDisposable Then
					TryCast(enumerator8, IDisposable).Dispose()
				End If
				IL_4DE:
				o0000O = Nothing
				IL_4E1:
				o_u3002_u3002_u3000_u3000_u = Nothing
				IL_4E4:
				num2 = 66
				result = dataRow
				IL_4EA:
				GoTo IL_648
				IL_4EF:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_609:
				GoTo IL_63D
				IL_60B:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_61B:
			Catch obj10 When endfilter(TypeOf obj9 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj10, Exception)
				GoTo IL_60B
			End Try
			IL_63D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_648:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003A62 RID: 14946 RVA: 0x001961BC File Offset: 0x001943BC
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SplitterCancelEventArgs)
			If Me.O_.0oo_O. Is Nothing Then
				Me.O_.0oo_O. = New o00OOoo(Me)
			End If
		End Sub

		' Token: 0x06003A63 RID: 14947 RVA: 0x001961D2 File Offset: 0x001943D2
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SplitterEventArgs)
			If Me.O_.0oo_O. IsNot Nothing Then
				CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).o_0O.OO0_0_..Add(Me.O_.0oo_O.)
				Me.O_.0oo_O. = Nothing
			End If
		End Sub

		' Token: 0x17000CD0 RID: 3280
		' (get) Token: 0x06003A64 RID: 14948 RVA: 0x001961FE File Offset: 0x001943FE
		' (set) Token: 0x06003A65 RID: 14949 RVA: 0x00196206 File Offset: 0x00194406
		Public Property DynamicKey As String
			Get
				Return Me.OOOOooo0000.o.
			End Get
			Set(value As String)
				Me.OOOOooo0000.o. = value
			End Set
		End Property

		' Token: 0x06003A66 RID: 14950 RVA: 0x00196210 File Offset: 0x00194410
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PaintEventArgs)
			If Me.ControlType = ControlTypeEnum.Line Then
				If Not Me.Selected Then
					Try
						MyBase.Region = Me.ChildControl.Region
						Return
					Catch ex As Exception
						Return
					End Try
				End If
				MyBase.Region = Nothing
			End If
		End Sub

		' Token: 0x0400180D RID: 6157
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400180E RID: 6158
		<CompilerGenerated()>
		<AccessedThroughProperty("FocusLabel")>
		Private <<EMPTY_NAME>> As TextBox

		' Token: 0x0400180F RID: 6159
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001810 RID: 6160
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001811 RID: 6161
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001812 RID: 6162
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001813 RID: 6163
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001814 RID: 6164
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001815 RID: 6165
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ControlHolder.oOo

		' Token: 0x04001816 RID: 6166
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ControlHolder.o_o_0oO0o000

		' Token: 0x04001817 RID: 6167
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ControlHolder.OO__oOoO_

		' Token: 0x04001818 RID: 6168
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ControlHolder.oo_O__O_

		' Token: 0x04001819 RID: 6169
		Friend <<EMPTY_NAME>> As o0O__ooOO00

		' Token: 0x0400181A RID: 6170
		Private <<EMPTY_NAME>> As Point

		' Token: 0x0400181B RID: 6171
		Private <<EMPTY_NAME>> As Point

		' Token: 0x0400181C RID: 6172
		Private <<EMPTY_NAME>> As Control

		' Token: 0x0400181D RID: 6173
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400181E RID: 6174
		Private <<EMPTY_NAME>> As Control

		' Token: 0x0400181F RID: 6175
		Private <<EMPTY_NAME>> As ControlTypeEnum

		' Token: 0x04001820 RID: 6176
		Private <<EMPTY_NAME>> As O__o00

		' Token: 0x04001821 RID: 6177
		Private <<EMPTY_NAME>> As o00OOoo

		' Token: 0x04001822 RID: 6178
		Private <<EMPTY_NAME>> As O0oo_0O

		' Token: 0x04001823 RID: 6179
		Private <<EMPTY_NAME>> As Point

		' Token: 0x04001824 RID: 6180
		Private a As Integer

		' Token: 0x0200038B RID: 907
		' (Invoke) Token: 0x06003A6A RID: 14954
		Public Delegate Sub oOo(A_0 As ControlHolder)

		' Token: 0x0200038C RID: 908
		' (Invoke) Token: 0x06003A6E RID: 14958
		Public Delegate Sub o_o_0oO0o000(A_0 As ControlHolder)

		' Token: 0x0200038D RID: 909
		' (Invoke) Token: 0x06003A72 RID: 14962
		Public Delegate Sub OO__oOoO_(A_0 As ControlHolder)

		' Token: 0x0200038E RID: 910
		' (Invoke) Token: 0x06003A76 RID: 14966
		Public Delegate Sub oo_O__O_(A_0 As ControlHolder)
	End Class
End Namespace
