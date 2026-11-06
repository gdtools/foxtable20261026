Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x0200042C RID: 1068
	Friend Class WebBrowserProperty
		Inherits ControlPropertyBase

		' Token: 0x0600461B RID: 17947 RVA: 0x001C54B4 File Offset: 0x001C36B4
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.O___oOO0o.0o. = CType(A_0.ChildControl, O_O_00)
		End Sub

		' Token: 0x17001041 RID: 4161
		' (get) Token: 0x0600461C RID: 17948 RVA: 0x001C54CE File Offset: 0x001C36CE
		' (set) Token: 0x0600461D RID: 17949 RVA: 0x001C54D6 File Offset: 0x001C36D6
		<O_Oo00Oo000O0(2.1)>
		<Category("基本")>
		<DefaultValue(2)>
		<MergableProperty(True)>
		<DisplayName("地址")>
		Public Property Address As String
			Get
				Return Me.O___oOO0o.0o.
			End Get
			Set(value As String)
				Me.O___oOO0o.0o. = value
			End Set
		End Property

		' Token: 0x04001CA5 RID: 7333
		Private <<EMPTY_NAME>> As O_O_00

		' Token: 0x04001CA6 RID: 7334
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
