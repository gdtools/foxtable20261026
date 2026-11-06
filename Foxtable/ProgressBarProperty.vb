Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200040E RID: 1038
	Friend Class ProgressBarProperty
		Inherits ControlPropertyBase

		' Token: 0x06004474 RID: 17524 RVA: 0x001C2F8F File Offset: 0x001C118F
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.OOO._oOooO. = CType(A_0.ChildControl, ProgressBar)
		End Sub

		' Token: 0x17000F89 RID: 3977
		' (get) Token: 0x06004475 RID: 17525 RVA: 0x001C2FA9 File Offset: 0x001C11A9
		' (set) Token: 0x06004476 RID: 17526 RVA: 0x001C2FB1 File Offset: 0x001C11B1
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("绑定到")>
		<Category("基本")>
		<DefaultValue("")>
		<Editor(GetType(oo0000o0oo), GetType(UITypeEditor))>
		<MergableProperty(True)>
		Public Property BindingField As String
			Get
				Return Me.o0O0.O0_o.
			End Get
			Set(value As String)
				Me.o0O0.O0_o. = value
			End Set
		End Property

		' Token: 0x17000F8A RID: 3978
		' (get) Token: 0x06004477 RID: 17527 RVA: 0x001C2FBA File Offset: 0x001C11BA
		' (set) Token: 0x06004478 RID: 17528 RVA: 0x001C2FC7 File Offset: 0x001C11C7
		<DisplayName("当前值")>
		<O_Oo00Oo000O0(1.0)>
		<DefaultValue(50)>
		<MergableProperty(True)>
		<Category("进度")>
		Public Property Value As Integer
			Get
				Return Me.OOO._oOooO..Value
			End Get
			Set(value As Integer)
				Me.OOO._oOooO..Value = value
			End Set
		End Property

		' Token: 0x17000F8B RID: 3979
		' (get) Token: 0x06004479 RID: 17529 RVA: 0x001C2FD5 File Offset: 0x001C11D5
		' (set) Token: 0x0600447A RID: 17530 RVA: 0x001C2FE2 File Offset: 0x001C11E2
		<Category("进度")>
		<DefaultValue(100)>
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("最大值")>
		Public Property Maximum As Integer
			Get
				Return Me.OOO._oOooO..Maximum
			End Get
			Set(value As Integer)
				Me.OOO._oOooO..Maximum = value
			End Set
		End Property

		' Token: 0x17000F8C RID: 3980
		' (get) Token: 0x0600447B RID: 17531 RVA: 0x001C2FF0 File Offset: 0x001C11F0
		' (set) Token: 0x0600447C RID: 17532 RVA: 0x001C2FFD File Offset: 0x001C11FD
		<MergableProperty(True)>
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(0)>
		<DisplayName("最小值")>
		<Category("进度")>
		Public Property Minimum As Integer
			Get
				Return Me.OOO._oOooO..Minimum
			End Get
			Set(value As Integer)
				Me.OOO._oOooO..Minimum = value
			End Set
		End Property

		' Token: 0x17000F8D RID: 3981
		' (get) Token: 0x0600447D RID: 17533 RVA: 0x001C300B File Offset: 0x001C120B
		' (set) Token: 0x0600447E RID: 17534 RVA: 0x001C3018 File Offset: 0x001C1218
		<O_Oo00Oo000O0(3.0)>
		<DefaultValue(0)>
		<DisplayName("样式")>
		<Category("进度")>
		<MergableProperty(True)>
		Public Property Style As ProgressBarStyle
			Get
				Return Me.OOO._oOooO..Style
			End Get
			Set(value As ProgressBarStyle)
				Me.OOO._oOooO..Style = value
			End Set
		End Property

		' Token: 0x04001BE0 RID: 7136
		Private <<EMPTY_NAME>> As ProgressBar

		' Token: 0x04001BE1 RID: 7137
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
