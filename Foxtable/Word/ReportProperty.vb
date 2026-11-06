Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Word
	' Token: 0x02000006 RID: 6
	<OoO0___o("ExcelReport")>
	<TypeConverter(GetType(OoO0o0oo__Oo))>
	Friend Class ReportProperty
		' Token: 0x06000015 RID: 21 RVA: 0x000024C0 File Offset: 0x000006C0
		Public Sub New()
			Me.O0oOOO._OOO. = 1
		End Sub

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000016 RID: 22 RVA: 0x000024CF File Offset: 0x000006CF
		' (set) Token: 0x06000017 RID: 23 RVA: 0x000024D7 File Offset: 0x000006D7
		<Ooo0___("Word文件(*.doc;.docx)|*.doc;*.docx")>
		<O_Oo00Oo000O0(1.0)>
		<Editor(GetType(O0_000oo), GetType(UITypeEditor))>
		<Category("属性")>
		<DisplayName("模板文件")>
		Public Property Template As String
			Get
				Return Me.O0oOOO._OOO.
			End Get
			Set(value As String)
				Me.O0oOOO._OOO. = value
				If Operators.CompareString(Me.o0.0o0O_., "", True) = 0 Then
					Me.o0.0o0O_. = value
				End If
			End Set
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000018 RID: 24 RVA: 0x000024FA File Offset: 0x000006FA
		' (set) Token: 0x06000019 RID: 25 RVA: 0x00002502 File Offset: 0x00000702
		<Category("属性")>
		<Editor(GetType(OO0o_o_Oo__o), GetType(UITypeEditor))>
		<O_Oo00Oo000O0(2.0)>
		<Ooo0___("Word文件(*.doc;.docx)|*.doc;*.docx")>
		<DisplayName("目标文件")>
		Public Property FileName As String
			Get
				Return Me.o0.0o0O_.
			End Get
			Set(value As String)
				Me.o0.0o0O_. = value
			End Set
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x0600001A RID: 26 RVA: 0x0000250B File Offset: 0x0000070B
		' (set) Token: 0x0600001B RID: 27 RVA: 0x00002513 File Offset: 0x00000713
		<Description("指定每页打印多少条记录后换页，如果设为0，则自动换页。")>
		<O_Oo00Oo000O0(2.1)>
		<Category("属性")>
		<DisplayName("每页记录数")>
		Public Property RecordsOnEachPage As Integer
			Get
				Return Me.O0oOOO._OOO.
			End Get
			Set(value As Integer)
				Me.O0oOOO._OOO. = value
			End Set
		End Property

		' Token: 0x0400000A RID: 10
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400000B RID: 11
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400000C RID: 12
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
