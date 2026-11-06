Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000403 RID: 1027
	Friend Class GroupBoxProperty
		Inherits ControlPropertyBase

		' Token: 0x06004370 RID: 17264 RVA: 0x001C1E7E File Offset: 0x001C007E
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o_0ooO.Oo. = CType(A_0.ChildControl, GroupBox)
		End Sub

		' Token: 0x17000F0D RID: 3853
		' (get) Token: 0x06004371 RID: 17265 RVA: 0x001C1E98 File Offset: 0x001C0098
		' (set) Token: 0x06004372 RID: 17266 RVA: 0x001C1EA5 File Offset: 0x001C00A5
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("标题")>
		<Category("基本")>
		<MergableProperty(True)>
		Public Overridable Property Text As String
			Get
				Return Me.o_0ooO.Oo..Text
			End Get
			Set(value As String)
				Me.o_0ooO.Oo..Text = value
			End Set
		End Property

		' Token: 0x17000F0E RID: 3854
		' (get) Token: 0x06004373 RID: 17267 RVA: 0x001C1EB3 File Offset: 0x001C00B3
		' (set) Token: 0x06004374 RID: 17268 RVA: 0x001C1EC5 File Offset: 0x001C00C5
		<O_Oo00Oo000O0(0.0)>
		<DefaultValue("(none)")>
		<TypeConverter(GetType(o00))>
		<DisplayName("样式")>
		<Category("外观")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.o_0ooO.Oo.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.o_0ooO.Oo. })
			End Set
		End Property

		' Token: 0x04001B94 RID: 7060
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001B95 RID: 7061
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
