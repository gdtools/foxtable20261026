Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200017E RID: 382
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FormMenuProperty
		' Token: 0x060011E5 RID: 4581 RVA: 0x0006E66C File Offset: 0x0006C86C
		Public Sub New()
			Me.o__OOO.00O0_O. = StripTypeEnum2.快捷菜单
			Me.o__OOO.00O0_O. = New Size(16, 16)
			Me.o__OOO.00O0_O. = DockStyle.Top
			Me.o__OOO.00O0_O. = True
			Me.o0.0_O00. = True
			Me.o0.0_O00. = "(default)"
		End Sub

		' Token: 0x170003C3 RID: 963
		' (get) Token: 0x060011E6 RID: 4582 RVA: 0x0006E6AA File Offset: 0x0006C8AA
		<O_Oo00Oo000O0(0.0)>
		<DisplayName("类型")>
		<Category("属性")>
		Public ReadOnly Property Type2 As StripTypeEnum2
			Get
				Return Me.o__OOO.00O0_O.
			End Get
		End Property

		' Token: 0x170003C4 RID: 964
		' (get) Token: 0x060011E7 RID: 4583 RVA: 0x0006E6B2 File Offset: 0x0006C8B2
		' (set) Token: 0x060011E8 RID: 4584 RVA: 0x0006E6BA File Offset: 0x0006C8BA
		<Browsable(False)>
		Public Property Type As StripTypeEnum2
			Get
				Return Me.o__OOO.00O0_O.
			End Get
			Set(value As StripTypeEnum2)
				Me.o__OOO.00O0_O. = value
			End Set
		End Property

		' Token: 0x170003C5 RID: 965
		' (get) Token: 0x060011E9 RID: 4585 RVA: 0x0006E6C3 File Offset: 0x0006C8C3
		' (set) Token: 0x060011EA RID: 4586 RVA: 0x0006E6CB File Offset: 0x0006C8CB
		<O_Oo00Oo000O0(0.0)>
		<Category("属性")>
		<DisplayName("名称")>
		Public Property Name As String
			Get
				Return Me.o__OOO.00O0_O.
			End Get
			Set(value As String)
				Me.o__OOO.00O0_O. = value
			End Set
		End Property

		' Token: 0x170003C6 RID: 966
		' (get) Token: 0x060011EB RID: 4587 RVA: 0x0006E6D4 File Offset: 0x0006C8D4
		' (set) Token: 0x060011EC RID: 4588 RVA: 0x0006E6DC File Offset: 0x0006C8DC
		<O_Oo00Oo000O0(1.0)>
		<Category("属性")>
		<DisplayName("样式")>
		<DefaultValue("(default)")>
		<TypeConverter(GetType(oo__O__O_OoO))>
		Public Property Theme As String
			Get
				Return Me.o0.0_O00.
			End Get
			Set(value As String)
				Me.o0.0_O00. = value
			End Set
		End Property

		' Token: 0x170003C7 RID: 967
		' (get) Token: 0x060011ED RID: 4589 RVA: 0x0006E6E5 File Offset: 0x0006C8E5
		' (set) Token: 0x060011EE RID: 4590 RVA: 0x0006E6ED File Offset: 0x0006C8ED
		<DefaultValue(True)>
		<DisplayName("可见")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Visible As Boolean
			Get
				Return Me.o0.0_O00.
			End Get
			Set(value As Boolean)
				Me.o0.0_O00. = value
			End Set
		End Property

		' Token: 0x170003C8 RID: 968
		' (get) Token: 0x060011EF RID: 4591 RVA: 0x0006E6F6 File Offset: 0x0006C8F6
		' (set) Token: 0x060011F0 RID: 4592 RVA: 0x0006E6FE File Offset: 0x0006C8FE
		<O_Oo00Oo000O0(1.2)>
		<DefaultValue(True)>
		<Category("属性")>
		<DisplayName("可用")>
		Public Property Enabeld As Boolean
			Get
				Return Me.o__OOO.00O0_O.
			End Get
			Set(value As Boolean)
				Me.o__OOO.00O0_O. = value
			End Set
		End Property

		' Token: 0x170003C9 RID: 969
		' (get) Token: 0x060011F1 RID: 4593 RVA: 0x0006E707 File Offset: 0x0006C907
		' (set) Token: 0x060011F2 RID: 4594 RVA: 0x0006E70F File Offset: 0x0006C90F
		<DisplayName("图标尺寸")>
		<O_Oo00Oo000O0(2.0)>
		<Category("属性")>
		Public Property ImageSize As Size
			Get
				Return Me.o__OOO.00O0_O.
			End Get
			Set(value As Size)
				Me.o__OOO.00O0_O. = value
			End Set
		End Property

		' Token: 0x170003CA RID: 970
		' (get) Token: 0x060011F3 RID: 4595 RVA: 0x0006E718 File Offset: 0x0006C918
		' (set) Token: 0x060011F4 RID: 4596 RVA: 0x0006E720 File Offset: 0x0006C920
		<O_Oo00Oo000O0(2.0)>
		<DisplayName("停靠位置")>
		<Category("属性")>
		Public Property Dock As DockStyle
			Get
				Return Me.o__OOO.00O0_O.
			End Get
			Set(value As DockStyle)
				If value <> DockStyle.None AndAlso value <> DockStyle.Fill Then
					Me.o__OOO.00O0_O. = value
				End If
			End Set
		End Property

		' Token: 0x040006DB RID: 1755
		Private <<EMPTY_NAME>> As String

		' Token: 0x040006DC RID: 1756
		Private <<EMPTY_NAME>> As StripTypeEnum2

		' Token: 0x040006DD RID: 1757
		Private <<EMPTY_NAME>> As Size

		' Token: 0x040006DE RID: 1758
		Private <<EMPTY_NAME>> As DockStyle

		' Token: 0x040006DF RID: 1759
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006E0 RID: 1760
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006E1 RID: 1761
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
