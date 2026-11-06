Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000409 RID: 1033
	Friend Class PainterProperty
		Inherits ControlPropertyBase

		' Token: 0x060043EE RID: 17390 RVA: 0x001C280F File Offset: 0x001C0A0F
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O.00_0o_00. = CType(A_0.ChildControl, o0Oo0OO)
		End Sub

		' Token: 0x17000F49 RID: 3913
		' (get) Token: 0x060043EF RID: 17391 RVA: 0x001C2829 File Offset: 0x001C0A29
		' (set) Token: 0x060043F0 RID: 17392 RVA: 0x001C2836 File Offset: 0x001C0A36
		<MergableProperty(True)>
		<Category("基本")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(3.2)>
		<DisplayName("自动滚动")>
		Public Property AutoScroll As Boolean
			Get
				Return Me.O.00_0o_00..AutoScroll
			End Get
			Set(value As Boolean)
				Me.O.00_0o_00..AutoScroll = value
			End Set
		End Property

		' Token: 0x17000F4A RID: 3914
		' (get) Token: 0x060043F1 RID: 17393 RVA: 0x001C2844 File Offset: 0x001C0A44
		' (set) Token: 0x060043F2 RID: 17394 RVA: 0x001C2851 File Offset: 0x001C0A51
		<O_Oo00Oo000O0(3.3)>
		<Category("基本")>
		<DisplayName("扩展尺寸")>
		<MergableProperty(True)>
		Public Property ExtendSize As Size
			Get
				Return Me.O.00_0o_00..AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.O.00_0o_00..AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x17000F4B RID: 3915
		' (get) Token: 0x060043F3 RID: 17395 RVA: 0x001C285F File Offset: 0x001C0A5F
		' (set) Token: 0x060043F4 RID: 17396 RVA: 0x001C286C File Offset: 0x001C0A6C
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.1)>
		<DisplayName("边框")>
		<Category("外观")>
		<DefaultValue(0)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O.00_0o_00..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O.00_0o_00..BorderStyle = value
			End Set
		End Property

		' Token: 0x04001BAF RID: 7087
		Private <<EMPTY_NAME>> As o0Oo0OO
	End Class
End Namespace
