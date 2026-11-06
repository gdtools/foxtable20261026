Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200040A RID: 1034
	Friend Class PanelProperty
		Inherits ControlPropertyBase

		' Token: 0x17000F4C RID: 3916
		' (get) Token: 0x060043F5 RID: 17397 RVA: 0x001C287A File Offset: 0x001C0A7A
		' (set) Token: 0x060043F6 RID: 17398 RVA: 0x001C2884 File Offset: 0x001C0A84
		Private Overridable Property ChildControl As Panel
			<CompilerGenerated()>
			Get
				Return Me.Oo0.o_Ooo000O.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As ScrollEventHandler = AddressOf Me.O.00_0o_00.
				Dim oo0.o_Ooo000O. As Panel = Me.Oo0.o_Ooo000O.
				If oo0.o_Ooo000O. IsNot Nothing Then
					RemoveHandler oo0.o_Ooo000O..Scroll, value2
				End If
				Me.Oo0.o_Ooo000O. = value
				oo0.o_Ooo000O. = Me.Oo0.o_Ooo000O.
				If oo0.o_Ooo000O. IsNot Nothing Then
					AddHandler oo0.o_Ooo000O..Scroll, value2
				End If
			End Set
		End Property

		' Token: 0x060043F7 RID: 17399 RVA: 0x001C28C7 File Offset: 0x001C0AC7
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.ChildControl = CType(A_0.ChildControl, Panel)
		End Sub

		' Token: 0x17000F4D RID: 3917
		' (get) Token: 0x060043F8 RID: 17400 RVA: 0x001C28E1 File Offset: 0x001C0AE1
		' (set) Token: 0x060043F9 RID: 17401 RVA: 0x001C28EE File Offset: 0x001C0AEE
		<O_Oo00Oo000O0(3.2)>
		<DefaultValue(False)>
		<DisplayName("自动滚动")>
		<MergableProperty(True)>
		<Category("基本")>
		Public Property AutoScroll As Boolean
			Get
				Return Me.ChildControl.AutoScroll
			End Get
			Set(value As Boolean)
				Me.ChildControl.AutoScroll = value
			End Set
		End Property

		' Token: 0x17000F4E RID: 3918
		' (get) Token: 0x060043FA RID: 17402 RVA: 0x001C28FC File Offset: 0x001C0AFC
		' (set) Token: 0x060043FB RID: 17403 RVA: 0x001C2909 File Offset: 0x001C0B09
		<O_Oo00Oo000O0(3.3)>
		<Category("基本")>
		<MergableProperty(True)>
		<DisplayName("扩展尺寸")>
		Public Property ExtendSize As Size
			Get
				Return Me.ChildControl.AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.ChildControl.AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x17000F4F RID: 3919
		' (get) Token: 0x060043FC RID: 17404 RVA: 0x001C2917 File Offset: 0x001C0B17
		' (set) Token: 0x060043FD RID: 17405 RVA: 0x001C2924 File Offset: 0x001C0B24
		<Category("外观")>
		<O_Oo00Oo000O0(3.1)>
		<DefaultValue(0)>
		<DisplayName("边框")>
		<MergableProperty(True)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.ChildControl.BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.ChildControl.BorderStyle = value
			End Set
		End Property

		' Token: 0x17000F50 RID: 3920
		' (get) Token: 0x060043FE RID: 17406 RVA: 0x001C2932 File Offset: 0x001C0B32
		' (set) Token: 0x060043FF RID: 17407 RVA: 0x001C2944 File Offset: 0x001C0B44
		<O_Oo00Oo000O0(0.0)>
		<DisplayName("样式")>
		<DefaultValue("(none)")>
		<Category("外观")>
		<TypeConverter(GetType(o00))>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.ChildControl)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.ChildControl })
			End Set
		End Property

		' Token: 0x17000F51 RID: 3921
		' (get) Token: 0x06004400 RID: 17408 RVA: 0x001C2960 File Offset: 0x001C0B60
		' (set) Token: 0x06004401 RID: 17409 RVA: 0x001C2968 File Offset: 0x001C0B68
		<Description("滚动面板后执行")>
		<Category("事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(0.0)>
		<oO0oooo("2397")>
		<O0O0oOO00_0OO(True)>
		Public Property AfterScroll As EventString
			Get
				Return Me.Oo0.o_Ooo000O.
			End Get
			Set(value As EventString)
				Me.Oo0.o_Ooo000O. = value
			End Set
		End Property

		' Token: 0x06004402 RID: 17410 RVA: 0x001C2971 File Offset: 0x001C0B71
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ScrollEventArgs)
			Me.ChildControl.Refresh()
		End Sub

		' Token: 0x04001BB0 RID: 7088
		<CompilerGenerated()>
		<AccessedThroughProperty("ChildControl")>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x04001BB1 RID: 7089
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001BB2 RID: 7090
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
