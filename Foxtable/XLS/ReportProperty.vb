Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.XLS
	' Token: 0x020004E3 RID: 1251
	<TypeConverter(GetType(OoO0o0oo__Oo))>
	<OoO0___o("ExcelReport")>
	Friend Class ReportProperty
		' Token: 0x17001221 RID: 4641
		' (get) Token: 0x0600504C RID: 20556 RVA: 0x00218647 File Offset: 0x00216847
		' (set) Token: 0x0600504D RID: 20557 RVA: 0x0021864F File Offset: 0x0021684F
		<Category("属性")>
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("模板文件")>
		<Ooo0___("Excel文件(*.xls;.xlsx)|*.xls;*.xlsx")>
		<Editor(GetType(O0_000oo), GetType(UITypeEditor))>
		Public Property Template As String
			Get
				Return Me.OoOoo.o.
			End Get
			Set(value As String)
				Me.OoOoo.o. = value
				If Operators.CompareString(Me.O__0oO_OO__.0o., "", True) = 0 Then
					Me.O__0oO_OO__.0o. = value
				End If
			End Set
		End Property

		' Token: 0x17001222 RID: 4642
		' (get) Token: 0x0600504E RID: 20558 RVA: 0x00218672 File Offset: 0x00216872
		' (set) Token: 0x0600504F RID: 20559 RVA: 0x0021867A File Offset: 0x0021687A
		<DisplayName("目标文件")>
		<Ooo0___("Excel文件(*.xls;.xlsx)|*.xls;*.xlsx")>
		<Editor(GetType(OO0o_o_Oo__o), GetType(UITypeEditor))>
		<Category("属性")>
		<O_Oo00Oo000O0(2.0)>
		Public Property FileName As String
			Get
				Return Me.O__0oO_OO__.0o.
			End Get
			Set(value As String)
				Me.O__0oO_OO__.0o. = value
			End Set
		End Property

		' Token: 0x17001223 RID: 4643
		' (get) Token: 0x06005050 RID: 20560 RVA: 0x00218683 File Offset: 0x00216883
		' (set) Token: 0x06005051 RID: 20561 RVA: 0x0021868B File Offset: 0x0021688B
		<O_Oo00Oo000O0(4.0)>
		<DisplayName("自由合并")>
		<Category("属性")>
		<DefaultValue(False)>
		<Description("如果报表模板中设置了合并列，可以用此属性指定合并类型。")>
		Public Property MergeFree As Boolean
			Get
				Return Me.OoOoo.o.
			End Get
			Set(value As Boolean)
				Me.OoOoo.o. = value
			End Set
		End Property

		' Token: 0x04002197 RID: 8599
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002198 RID: 8600
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002199 RID: 8601
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
