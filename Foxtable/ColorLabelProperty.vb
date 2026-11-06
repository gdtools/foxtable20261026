Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020003FB RID: 1019
	Friend Class ColorLabelProperty
		Inherits ControlPropertyBase

		' Token: 0x06004216 RID: 16918 RVA: 0x001C0A00 File Offset: 0x001BEC00
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.oOO._O0OOO_o. = CType(A_0.ChildControl, Label)
		End Sub

		' Token: 0x17000E63 RID: 3683
		' (get) Token: 0x06004217 RID: 16919 RVA: 0x001C0A1A File Offset: 0x001BEC1A
		' (set) Token: 0x06004218 RID: 16920 RVA: 0x001C0A22 File Offset: 0x001BEC22
		<Category("基本")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(True)>
		<DisplayName("绑定到")>
		<DefaultValue("")>
		<O_Oo00Oo000O0(2.1)>
		Public Property BindingField As String
			Get
				Return Me.oOO._O0OOO_o.
			End Get
			Set(value As String)
				Me.oOO._O0OOO_o. = value
			End Set
		End Property

		' Token: 0x17000E64 RID: 3684
		' (get) Token: 0x06004219 RID: 16921 RVA: 0x001C0A2B File Offset: 0x001BEC2B
		' (set) Token: 0x0600421A RID: 16922 RVA: 0x001C0A40 File Offset: 0x001BEC40
		<Category("基本")>
		<O_Oo00Oo000O0(2.2)>
		<DisplayName("当前值")>
		<MergableProperty(True)>
		Public Overrides Property BackColor As Color
			Get
				Return Me.o_0_.Oo..ChildControl.BackColor
			End Get
			Set(value As Color)
				If Me.o_0_.Oo..ControlType <> ControlTypeEnum.Button OrElse Not(value = SystemColors.Control) OrElse Not(Me.o_0_.Oo..ChildControl.BackColor = value) Then
					Me.o_0_.Oo..ChildControl.BackColor = value
				End If
			End Set
		End Property

		' Token: 0x17000E65 RID: 3685
		' (get) Token: 0x0600421B RID: 16923 RVA: 0x001C0A91 File Offset: 0x001BEC91
		' (set) Token: 0x0600421C RID: 16924 RVA: 0x001C0A99 File Offset: 0x001BEC99
		<Category("基本")>
		<DisplayName("只读")>
		<DefaultValue(False)>
		<O_Oo00Oo000O0(2.3)>
		<Description("禁止用户修改。")>
		<MergableProperty(True)>
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.oOO._O0OOO_o.
			End Get
			Set(value As BooleanEnum)
				Me.oOO._O0OOO_o. = value
			End Set
		End Property

		' Token: 0x17000E66 RID: 3686
		' (get) Token: 0x0600421D RID: 16925 RVA: 0x001C0AA2 File Offset: 0x001BECA2
		' (set) Token: 0x0600421E RID: 16926 RVA: 0x001C0AAF File Offset: 0x001BECAF
		<MergableProperty(True)>
		<DisplayName("边框")>
		<Category("外观")>
		<DefaultValue(2)>
		<O_Oo00Oo000O0(3.1)>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.oOO._O0OOO_o..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.oOO._O0OOO_o..BorderStyle = value
			End Set
		End Property

		' Token: 0x17000E67 RID: 3687
		' (get) Token: 0x0600421F RID: 16927 RVA: 0x001C0ABD File Offset: 0x001BECBD
		' (set) Token: 0x06004220 RID: 16928 RVA: 0x001C0ACA File Offset: 0x001BECCA
		<DisplayName("文本位置")>
		<O_Oo00Oo000O0(0.1)>
		<MergableProperty(True)>
		<DefaultValue(0)>
		<Category("外观")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.oOO._O0OOO_o..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.oOO._O0OOO_o..TextAlign = value
			End Set
		End Property

		' Token: 0x17000E68 RID: 3688
		' (get) Token: 0x06004221 RID: 16929 RVA: 0x001C0AD8 File Offset: 0x001BECD8
		' (set) Token: 0x06004222 RID: 16930 RVA: 0x001C0AE0 File Offset: 0x001BECE0
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("0792")>
		<O_Oo00Oo000O0(0.2)>
		<Description("值改变后执行")>
		<Category("事件")>
		<O0O0oOO00_0OO(True)>
		Public Property ValueChanged As EventString
			Get
				Return Me.oOO._O0OOO_o.
			End Get
			Set(value As EventString)
				Me.oOO._O0OOO_o. = value
			End Set
		End Property

		' Token: 0x04001B18 RID: 6936
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001B19 RID: 6937
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001B1A RID: 6938
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001B1B RID: 6939
		Private <<EMPTY_NAME>> As EventString
	End Class
End Namespace
