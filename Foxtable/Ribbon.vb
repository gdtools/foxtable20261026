Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000469 RID: 1129
	<OoO0___o("Ribbon")>
	Friend Class Ribbon
		' Token: 0x06004B92 RID: 19346 RVA: 0x001FFEDC File Offset: 0x001FE0DC
		Public Sub New(A_0 As DataTable)
			Me.OoOOo.0OoO_oo_. = VisualStyleEnum.Office2007Blue
			Me.OoOOo.0OoO_oo_. = "Foxtable"
			Me.OoOOo.0OoO_oo_. = True
			Me.o0O0.0_oo. = False
			Me.o._oOOO00_o_0O. = False
			Me.oO.0oO. = False
			Me.O0o.O00. = New ContextMenuCollection()
			Me.oo00OO_0.0o000. = New RibbonTabCollection()
			Me.oo00OO_0.0o000. = New RibbonTopTabCollection()
			Me.oO_.ooOoo. = A_0
			Me.oo0o.oo_oOoOo0.()
		End Sub

		' Token: 0x06004B93 RID: 19347 RVA: 0x001FFF4C File Offset: 0x001FE14C
		Friend Sub <<EMPTY_NAME>>()
			Dim array As DataRow() = Me.DataTable.[Select]("[Type] = " + Conversions.ToString(0))
			If array.Length = 0 Then
				Me.O0o.O00. = Me.DataTable.NewRow()
				Me.O0o.O00.("Key") = ShareLibriay.GetRandString(8)
				Me.O0o.O00.("Type") = RibbonItemTypeEnum.Ribbon
				Me.DataTable.Rows.Add(Me.O0o.O00.)
			Else
				Me.O0o.O00. = array(0)
				o_O_o_oOoo__.OOOO_OO._oo.(Me, Me.O0o.O00., False)
			End If
			array = Me.DataTable.[Select]("[Type] = " + Conversions.ToString(2))
			If array.Length = 0 Then
				Me.Oo_.0o_o___O. = Me.DataTable.NewRow()
				Me.Oo_.0o_o___O.("Key") = ShareLibriay.GetRandString(8)
				Me.Oo_.0o_o___O.("Type") = RibbonItemTypeEnum.QAT
				Me.DataTable.Rows.Add(Me.Oo_.0o_o___O.)
			Else
				Me.Oo_.0o_o___O. = array(0)
			End If
			Me.O0o.O00. = New RibbonQat(Me.Oo_.0o_o___O.)
			array = Me.DataTable.[Select]("[Type] = " + Conversions.ToString(3))
			If array.Length = 0 Then
				Me.o0.0_o_O_0. = Me.DataTable.NewRow()
				Me.o0.0_o_O_0.("Key") = ShareLibriay.GetRandString(8)
				Me.o0.0_o_O_0.("Type") = RibbonItemTypeEnum.ConfigBar
				Me.DataTable.Rows.Add(Me.o0.0_o_O_0.)
			Else
				Me.o0.0_o_O_0. = array(0)
			End If
			Me.O0o.O00. = New RibbonConfigToolBar(Me.o0.0_o_O_0.)
			array = Me.DataTable.[Select]("[Type] = " + Conversions.ToString(35))
			If array.Length = 0 Then
				Me.o00.__. = Me.DataTable.NewRow()
				Me.o00.__.("Key") = ShareLibriay.GetRandString(8)
				Me.o00.__.("Type") = RibbonItemTypeEnum.TopToolBar
				Me.DataTable.Rows.Add(Me.o00.__.)
			Else
				Me.o00.__. = array(0)
			End If
			Me.oo00OO_0.0o000. = New RibbonTopToolBar(Me.o00.__.)
			If o_O_o_oOoo__.O_o_._o0. Is Nothing Then
				o_O_o_oOoo__.O_o_._o0. = New Boolean?(Me.oo0o.oo_oOoOo0.())
			End If
			array = Me.DataTable.[Select]("[Type] = " + Conversions.ToString(36))
			If array.Length = 0 Then
				Me.o_0_oO.0O_. = Me.DataTable.NewRow()
				Me.o_0_oO.0O_.("Key") = ShareLibriay.GetRandString(8)
				Me.o_0_oO.0O_.("Type") = RibbonItemTypeEnum.BottomToolBar
				Me.DataTable.Rows.Add(Me.o_0_oO.0O_.)
			Else
				Me.o_0_oO.0O_. = array(0)
			End If
			Me.O0o.O00. = New RibbonBottomToolBar(Me.o_0_oO.0O_.)
			array = Me.DataTable.[Select]("[Type] = " + Conversions.ToString(1))
			If array.Length = 0 Then
				Me.OoOo_0O_oo_._0. = Me.DataTable.NewRow()
				Me.OoOo_0O_oo_._0.("Key") = ShareLibriay.GetRandString(8)
				Me.OoOo_0O_oo_._0.("Type") = RibbonItemTypeEnum.ApplicationMenu
				Me.DataTable.Rows.Add(Me.OoOo_0O_oo_._0.)
			Else
				Me.OoOo_0O_oo_._0. = array(0)
			End If
			Me.O0o.O00. = New RibbonApplicationMenu(Me.OoOo_0O_oo_._0.)
		End Sub

		' Token: 0x06004B94 RID: 19348 RVA: 0x002002D8 File Offset: 0x001FE4D8
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = SysInfo.dmstring
				IL_10:
				num2 = 3
				text = o_O_o_oOoo__.OOOO_OO._oo.(text)
				IL_1B:
				num2 = 4
				Dim array As String() = text.Split(New Char() { "|"c })
				IL_31:
				num2 = 5
				Dim typeName As String = array(0)
				IL_39:
				num2 = 6
				Dim name As String = array(1)
				IL_41:
				num2 = 7
				Dim name2 As String = array(2)
				IL_49:
				num2 = 8
				Dim type As Type = Type.[GetType](typeName, True)
				IL_55:
				num2 = 9
				Dim [property] As PropertyInfo = type.GetProperty(name, BindingFlags.[Static] Or BindingFlags.[Public])
				IL_65:
				num2 = 10
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue([property].GetValue(Nothing, Nothing))
				IL_78:
				num2 = 11
				Dim property2 As PropertyInfo = type.GetProperty(name2, BindingFlags.Instance Or BindingFlags.[Public])
				IL_88:
				num2 = 12
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(property2.GetValue(RuntimeHelpers.GetObjectValue(objectValue), Nothing))
				IL_A1:
				num2 = 13
				result = (objectValue2 IsNot Nothing)
				IL_AA:
				GoTo IL_134
				IL_AF:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_F5:
				GoTo IL_129
				IL_F7:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_107:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_F7
			End Try
			IL_129:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_134:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06004B95 RID: 19349 RVA: 0x00200440 File Offset: 0x001FE640
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim a_ As String = ooO0__OO.O_Oo00oO.Ooo.()
			Dim str As String = ""
			Dim str2 As String = ""
			If A_0 Is Me.O0o.O00. Then
				Me.Oo_.0o_o___O.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., False, vbVerticalTab, False)
				Me.Oo_.0o_o___O.("Code") = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., True, vbVerticalTab, False), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2
			End If
			If A_0 Is Me.O0o.O00. Then
				Me.OoOo_0O_oo_._0.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., False, vbVerticalTab, False)
				Me.OoOo_0O_oo_._0.("Code") = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., True, vbVerticalTab, False), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2
			End If
			If A_0 Is Me.O0o.O00. Then
				Me.o0.0_o_O_0.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., False, vbVerticalTab, False)
				Me.o0.0_o_O_0.("Code") = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., True, vbVerticalTab, False), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2
			End If
			If A_0 Is Me.oo00OO_0.0o000. Then
				Me.o00.__.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(Me.oo00OO_0.0o000., False, vbVerticalTab, False)
				Me.o00.__.("Code") = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(Me.oo00OO_0.0o000., True, vbVerticalTab, False), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2
			End If
			If A_0 Is Me.O0o.O00. Then
				Me.o_0_oO.0O_.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., False, vbVerticalTab, False)
				Me.o_0_oO.0O_.("Code") = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(Me.O0o.O00., True, vbVerticalTab, False), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2
			End If
			If A_0 Is Me Then
				Me.O0o.O00.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(Me, False, vbVerticalTab, False)
				Me.O0o.O00.("Code") = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(Me, True, vbVerticalTab, False), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2
			End If
		End Sub

		' Token: 0x170010B3 RID: 4275
		' (get) Token: 0x06004B96 RID: 19350 RVA: 0x00200666 File Offset: 0x001FE866
		Friend ReadOnly Property DataTable As DataTable
			Get
				Return Me.oO_.ooOoo.
			End Get
		End Property

		' Token: 0x170010B4 RID: 4276
		' (get) Token: 0x06004B97 RID: 19351 RVA: 0x0020066E File Offset: 0x001FE86E
		' (set) Token: 0x06004B98 RID: 19352 RVA: 0x00200676 File Offset: 0x001FE876
		<O_Oo00Oo000O0(1.0)>
		<DisplayName("标题")>
		<Category("属性")>
		Public Property Text As String
			Get
				Return Me.OoOOo.0OoO_oo_.
			End Get
			Set(value As String)
				Me.OoOOo.0OoO_oo_. = value
			End Set
		End Property

		' Token: 0x170010B5 RID: 4277
		' (get) Token: 0x06004B99 RID: 19353 RVA: 0x0020067F File Offset: 0x001FE87F
		' (set) Token: 0x06004B9A RID: 19354 RVA: 0x00200687 File Offset: 0x001FE887
		<DisplayName("图标")>
		<Category("属性")>
		<O_Oo00Oo000O0(3.0)>
		<Description("一个32*32尺寸的图标，或者对应大小的图片。")>
		<Editor(GetType(ooo), GetType(UITypeEditor))>
		Public Property Image As String
			Get
				Return Me.o0O0.0_oo.
			End Get
			Set(value As String)
				Me.o0O0.0_oo. = value
			End Set
		End Property

		' Token: 0x170010B6 RID: 4278
		' (get) Token: 0x06004B9B RID: 19355 RVA: 0x00200690 File Offset: 0x001FE890
		' (set) Token: 0x06004B9C RID: 19356 RVA: 0x00200698 File Offset: 0x001FE898
		<O_Oo00Oo000O0(3.1)>
		<DefaultValue(False)>
		<DisplayName("允许最小化")>
		<Category("属性")>
		Public Property AllowMinimize As Boolean
			Get
				Return Me.o._oOOO00_o_0O.
			End Get
			Set(value As Boolean)
				Me.o._oOOO00_o_0O. = value
			End Set
		End Property

		' Token: 0x170010B7 RID: 4279
		' (get) Token: 0x06004B9D RID: 19357 RVA: 0x002006A1 File Offset: 0x001FE8A1
		' (set) Token: 0x06004B9E RID: 19358 RVA: 0x002006A9 File Offset: 0x001FE8A9
		<DisplayName("默认最小化")>
		<O_Oo00Oo000O0(3.11)>
		<Category("属性")>
		<DefaultValue(False)>
		Public Property Minimized As Boolean
			Get
				Return Me.o0O0.0_oo.
			End Get
			Set(value As Boolean)
				Me.o0O0.0_oo. = value
			End Set
		End Property

		' Token: 0x170010B8 RID: 4280
		' (get) Token: 0x06004B9F RID: 19359 RVA: 0x002006B2 File Offset: 0x001FE8B2
		' (set) Token: 0x06004BA0 RID: 19360 RVA: 0x002006BA File Offset: 0x001FE8BA
		<DisplayName("显示文件名")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(3.2)>
		<Category("属性")>
		<Description("是否在标题栏显示当前打开文件的名称。")>
		Public Property ShowFileName As Boolean
			Get
				Return Me.OoOOo.0OoO_oo_.
			End Get
			Set(value As Boolean)
				Me.OoOOo.0OoO_oo_. = value
			End Set
		End Property

		' Token: 0x170010B9 RID: 4281
		' (get) Token: 0x06004BA1 RID: 19361 RVA: 0x002006C3 File Offset: 0x001FE8C3
		' (set) Token: 0x06004BA2 RID: 19362 RVA: 0x002006CB File Offset: 0x001FE8CB
		<Category("属性")>
		<DefaultValue(False)>
		<DisplayName("隐藏功能区标题")>
		<O_Oo00Oo000O0(4.0)>
		Public Property HideTabHederRow As Boolean
			Get
				Return Me.oO.0oO.
			End Get
			Set(value As Boolean)
				Me.oO.0oO. = value
			End Set
		End Property

		' Token: 0x170010BA RID: 4282
		' (get) Token: 0x06004BA3 RID: 19363 RVA: 0x002006D4 File Offset: 0x001FE8D4
		' (set) Token: 0x06004BA4 RID: 19364 RVA: 0x002006DC File Offset: 0x001FE8DC
		<Browsable(False)>
		Public Property Developer As String
			Get
				Return Me.oOO.O_00o.
			End Get
			Set(value As String)
				Me.oOO.O_00o. = value
			End Set
		End Property

		' Token: 0x170010BB RID: 4283
		' (get) Token: 0x06004BA5 RID: 19365 RVA: 0x002006E5 File Offset: 0x001FE8E5
		' (set) Token: 0x06004BA6 RID: 19366 RVA: 0x002006ED File Offset: 0x001FE8ED
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("单击某按钮后执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property Click As EventString
			Get
				Return Me.ooOOOoo__.O_.
			End Get
			Set(value As EventString)
				Me.ooOOOoo__.O_. = value
			End Set
		End Property

		' Token: 0x170010BC RID: 4284
		' (get) Token: 0x06004BA7 RID: 19367 RVA: 0x002006F6 File Offset: 0x001FE8F6
		' (set) Token: 0x06004BA8 RID: 19368 RVA: 0x002006FE File Offset: 0x001FE8FE
		<oO0oooo("1129")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Browsable(False)>
		<Category("全局事件")>
		<Description("双击某按钮后执行。")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property DoubleClick As EventString
			Get
				Return Me.oOO.O_00o.
			End Get
			Set(value As EventString)
				Me.oOO.O_00o. = value
			End Set
		End Property

		' Token: 0x170010BD RID: 4285
		' (get) Token: 0x06004BA9 RID: 19369 RVA: 0x00200707 File Offset: 0x001FE907
		' (set) Token: 0x06004BAA RID: 19370 RVA: 0x0020070F File Offset: 0x001FE90F
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<Description("某编辑框取消修改后执行。")>
		<oO0oooo("1129")>
		<Category("全局事件")>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(3.0)>
		Public Property ChangeCanceled As EventString
			Get
				Return Me.OO.__OO0o.
			End Get
			Set(value As EventString)
				Me.OO.__OO0o. = value
			End Set
		End Property

		' Token: 0x170010BE RID: 4286
		' (get) Token: 0x06004BAB RID: 19371 RVA: 0x00200718 File Offset: 0x001FE918
		' (set) Token: 0x06004BAC RID: 19372 RVA: 0x00200720 File Offset: 0x001FE920
		<Category("全局事件")>
		<oO0oooo("1129")>
		<Description("某编辑框提交修改后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property ChangeCommitted As EventString
			Get
				Return Me.O00O0.0O000__.
			End Get
			Set(value As EventString)
				Me.O00O0.0O000__. = value
			End Set
		End Property

		' Token: 0x170010BF RID: 4287
		' (get) Token: 0x06004BAD RID: 19373 RVA: 0x00200729 File Offset: 0x001FE929
		' (set) Token: 0x06004BAE RID: 19374 RVA: 0x00200731 File Offset: 0x001FE931
		<Description("某编辑框内容改变后执行。")>
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property TextChanged As EventString
			Get
				Return Me.O0o.OoOo_.
			End Get
			Set(value As EventString)
				Me.O0o.OoOo_. = value
			End Set
		End Property

		' Token: 0x170010C0 RID: 4288
		' (get) Token: 0x06004BAF RID: 19375 RVA: 0x0020073A File Offset: 0x001FE93A
		' (set) Token: 0x06004BB0 RID: 19376 RVA: 0x00200742 File Offset: 0x001FE942
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("某编辑框获得输入焦点后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property GotFocus As EventString
			Get
				Return Me.O0O.___O0__.
			End Get
			Set(value As EventString)
				Me.O0O.___O0__. = value
			End Set
		End Property

		' Token: 0x170010C1 RID: 4289
		' (get) Token: 0x06004BB1 RID: 19377 RVA: 0x0020074B File Offset: 0x001FE94B
		' (set) Token: 0x06004BB2 RID: 19378 RVA: 0x00200753 File Offset: 0x001FE953
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("某编辑框失去输入焦点后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(7.0)>
		Public Property LostFocus As EventString
			Get
				Return Me.o_0_._o.
			End Get
			Set(value As EventString)
				Me.o_0_._o. = value
			End Set
		End Property

		' Token: 0x170010C2 RID: 4290
		' (get) Token: 0x06004BB3 RID: 19379 RVA: 0x0020075C File Offset: 0x001FE95C
		' (set) Token: 0x06004BB4 RID: 19380 RVA: 0x00200764 File Offset: 0x001FE964
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("某检查框的选中状态改变后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(9.0)>
		Public Property CheckedChanged As EventString
			Get
				Return Me.OO0_o0.0O0O.
			End Get
			Set(value As EventString)
				Me.OO0_o0.0O0O. = value
			End Set
		End Property

		' Token: 0x170010C3 RID: 4291
		' (get) Token: 0x06004BB5 RID: 19381 RVA: 0x0020076D File Offset: 0x001FE96D
		' (set) Token: 0x06004BB6 RID: 19382 RVA: 0x00200775 File Offset: 0x001FE975
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("某状态按钮的状态改变后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(10.0)>
		Public Property PressedChanged As EventString
			Get
				Return Me.o_oOOo_o.O_O0.
			End Get
			Set(value As EventString)
				Me.o_oOOo_o.O_O0. = value
			End Set
		End Property

		' Token: 0x170010C4 RID: 4292
		' (get) Token: 0x06004BB7 RID: 19383 RVA: 0x0020077E File Offset: 0x001FE97E
		' (set) Token: 0x06004BB8 RID: 19384 RVA: 0x00200786 File Offset: 0x001FE986
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("在状态分组中，某一个状态按钮的状态改变后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(11.0)>
		Public Property PressedButtonChanged As EventString
			Get
				Return Me.oooO.O.
			End Get
			Set(value As EventString)
				Me.oooO.O. = value
			End Set
		End Property

		' Token: 0x170010C5 RID: 4293
		' (get) Token: 0x06004BB9 RID: 19385 RVA: 0x0020078F File Offset: 0x001FE98F
		' (set) Token: 0x06004BBA RID: 19386 RVA: 0x00200797 File Offset: 0x001FE997
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("在某组合框中选择不同项目后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(12.0)>
		Public Property SelectedIndexChanged As EventString
			Get
				Return Me.O0O_O0oo.OOOO_.
			End Get
			Set(value As EventString)
				Me.O0O_O0oo.OOOO_. = value
			End Set
		End Property

		' Token: 0x170010C6 RID: 4294
		' (get) Token: 0x06004BBB RID: 19387 RVA: 0x002007A0 File Offset: 0x001FE9A0
		' (set) Token: 0x06004BBC RID: 19388 RVA: 0x002007A8 File Offset: 0x001FE9A8
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("打开下拉列表或菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(13.0)>
		Public Property DropDown As EventString
			Get
				Return Me.o0._OoO.
			End Get
			Set(value As EventString)
				Me.o0._OoO. = value
			End Set
		End Property

		' Token: 0x170010C7 RID: 4295
		' (get) Token: 0x06004BBD RID: 19389 RVA: 0x002007B1 File Offset: 0x001FE9B1
		' (set) Token: 0x06004BBE RID: 19390 RVA: 0x002007B9 File Offset: 0x001FE9B9
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("关闭下拉列表或菜单的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(14.0)>
		Public Property DropDownClosed As EventString
			Get
				Return Me.O_00O.o0.
			End Get
			Set(value As EventString)
				Me.O_00O.o0. = value
			End Set
		End Property

		' Token: 0x170010C8 RID: 4296
		' (get) Token: 0x06004BBF RID: 19391 RVA: 0x002007C2 File Offset: 0x001FE9C2
		' (set) Token: 0x06004BC0 RID: 19392 RVA: 0x002007CA File Offset: 0x001FE9CA
		<Category("全局事件")>
		<oO0oooo("1129")>
		<Description("单击某分组的对话按钮后执行")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(15.0)>
		Public Property DialogLauncherClick As EventString
			Get
				Return Me.oOO_._0_.
			End Get
			Set(value As EventString)
				Me.oOO_._0_. = value
			End Set
		End Property

		' Token: 0x170010C9 RID: 4297
		' (get) Token: 0x06004BC1 RID: 19393 RVA: 0x002007D3 File Offset: 0x001FE9D3
		' (set) Token: 0x06004BC2 RID: 19394 RVA: 0x002007DB File Offset: 0x001FE9DB
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("选择某功能区后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(16.0)>
		Public Property SelectTab As EventString
			Get
				Return Me.O0o.O_00.
			End Get
			Set(value As EventString)
				Me.O0o.O_00. = value
			End Set
		End Property

		' Token: 0x170010CA RID: 4298
		' (get) Token: 0x06004BC3 RID: 19395 RVA: 0x002007E4 File Offset: 0x001FE9E4
		' (set) Token: 0x06004BC4 RID: 19396 RVA: 0x002007EC File Offset: 0x001FE9EC
		<oO0oooo("1129")>
		<Category("全局事件")>
		<Description("离开某功能区后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(17.0)>
		Public Property DeselectTab As EventString
			Get
				Return Me.OOo_.00o.
			End Get
			Set(value As EventString)
				Me.OOo_.00o. = value
			End Set
		End Property

		' Token: 0x170010CB RID: 4299
		' (get) Token: 0x06004BC5 RID: 19397 RVA: 0x002007F5 File Offset: 0x001FE9F5
		' (set) Token: 0x06004BC6 RID: 19398 RVA: 0x002007FD File Offset: 0x001FE9FD
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("系统空闲的时候执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(0.0)>
		Public Property SystemIdle As EventString
			Get
				Return Me.O00_O_o_O.00oo.
			End Get
			Set(value As EventString)
				Me.O00_O_o_O.00oo. = value
			End Set
		End Property

		' Token: 0x170010CC RID: 4300
		' (get) Token: 0x06004BC7 RID: 19399 RVA: 0x00200806 File Offset: 0x001FEA06
		' (set) Token: 0x06004BC8 RID: 19400 RVA: 0x0020080E File Offset: 0x001FEA0E
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("选择不同主表后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(1.0)>
		Public Property MainTableChanged As EventString
			Get
				Return Me.oO_.OO_0_.
			End Get
			Set(value As EventString)
				Me.oO_.OO_0_. = value
			End Set
		End Property

		' Token: 0x170010CD RID: 4301
		' (get) Token: 0x06004BC9 RID: 19401 RVA: 0x00200817 File Offset: 0x001FEA17
		' (set) Token: 0x06004BCA RID: 19402 RVA: 0x0020081F File Offset: 0x001FEA1F
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("选择不同表后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(2.0)>
		Public Property CurrentTableChanged As EventString
			Get
				Return Me.Ooo0o00.oo_o.
			End Get
			Set(value As EventString)
				Me.Ooo0o00.oo_o. = value
			End Set
		End Property

		' Token: 0x170010CE RID: 4302
		' (get) Token: 0x06004BCB RID: 19403 RVA: 0x00200828 File Offset: 0x001FEA28
		' (set) Token: 0x06004BCC RID: 19404 RVA: 0x00200830 File Offset: 0x001FEA30
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("选择不同行后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(4.0)>
		Public Property CurrentChanged As EventString
			Get
				Return Me.O.00_0O0_OO0.
			End Get
			Set(value As EventString)
				Me.O.00_0O0_OO0. = value
			End Set
		End Property

		' Token: 0x170010CF RID: 4303
		' (get) Token: 0x06004BCD RID: 19405 RVA: 0x00200839 File Offset: 0x001FEA39
		' (set) Token: 0x06004BCE RID: 19406 RVA: 0x00200841 File Offset: 0x001FEA41
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("选择不同行位置后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(5.0)>
		Public Property PositionChanged As EventString
			Get
				Return Me.oOo00.0o_O_O_.
			End Get
			Set(value As EventString)
				Me.oOo00.0o_O_O_. = value
			End Set
		End Property

		' Token: 0x170010D0 RID: 4304
		' (get) Token: 0x06004BCF RID: 19407 RVA: 0x0020084A File Offset: 0x001FEA4A
		' (set) Token: 0x06004BD0 RID: 19408 RVA: 0x00200852 File Offset: 0x001FEA52
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("选择不同的单元格后执行，也就是表的RowSel、ColSel属性发生变化后执行。")>
		<O_Oo00Oo000O0(5.1)>
		<O0O0oOO00_0OO(True)>
		Public Property AfterSelChange As EventString
			Get
				Return Me.O_._0_O.
			End Get
			Set(value As EventString)
				Me.O_._0_O. = value
			End Set
		End Property

		' Token: 0x170010D1 RID: 4305
		' (get) Token: 0x06004BD1 RID: 19409 RVA: 0x0020085B File Offset: 0x001FEA5B
		' (set) Token: 0x06004BD2 RID: 19410 RVA: 0x00200863 File Offset: 0x001FEA63
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("在表中选择不同区域后执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化后执行。")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(6.0)>
		Public Property AfterSelRangeChange As EventString
			Get
				Return Me.OOOOo0._o.
			End Get
			Set(value As EventString)
				Me.OOOOo0._o. = value
			End Set
		End Property

		' Token: 0x170010D2 RID: 4306
		' (get) Token: 0x06004BD3 RID: 19411 RVA: 0x0020086C File Offset: 0x001FEA6C
		' (set) Token: 0x06004BD4 RID: 19412 RVA: 0x00200874 File Offset: 0x001FEA74
		<Description("生成菜单后执行，通常用来做一些初始化工作。")>
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<O0O0oOO00_0OO(True)>
		<O_Oo00Oo000O0(7.0)>
		Public Property Load As EventString
			Get
				Return Me.OO_0o.o_O0__0_.
			End Get
			Set(value As EventString)
				Me.OO_0o.o_O0__0_. = value
			End Set
		End Property

		' Token: 0x170010D3 RID: 4307
		' (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0020087D File Offset: 0x001FEA7D
		' (set) Token: 0x06004BD6 RID: 19414 RVA: 0x00200885 File Offset: 0x001FEA85
		<Editor(GetType(o_oo0_0_Oo0O_), GetType(UITypeEditor))>
		<oO0oooo("1130")>
		<Category("系统事件")>
		<Description("打开系统或者切换用户之后执行，可以在此针对用户进行权限方面的设置。")>
		<O_Oo00Oo000O0(8.0)>
		<O0O0oOO00_0OO(True)>
		Public Property LoadUserSetting As EventString
			Get
				Return Me.o00O00.0O_o.
			End Get
			Set(value As EventString)
				Me.o00O00.0O_o. = value
			End Set
		End Property

		' Token: 0x04001F00 RID: 7936
		Private <<EMPTY_NAME>> As VisualStyleEnum

		' Token: 0x04001F01 RID: 7937
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F02 RID: 7938
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001F03 RID: 7939
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F04 RID: 7940
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F05 RID: 7941
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F06 RID: 7942
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001F07 RID: 7943
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001F08 RID: 7944
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001F09 RID: 7945
		Friend <<EMPTY_NAME>> As RibbonQat

		' Token: 0x04001F0A RID: 7946
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001F0B RID: 7947
		Friend <<EMPTY_NAME>> As RibbonConfigToolBar

		' Token: 0x04001F0C RID: 7948
		Friend <<EMPTY_NAME>> As RibbonTopToolBar

		' Token: 0x04001F0D RID: 7949
		Friend <<EMPTY_NAME>> As DataRow

		' Token: 0x04001F0E RID: 7950
		Friend <<EMPTY_NAME>> As RibbonBottomToolBar

		' Token: 0x04001F0F RID: 7951
		Friend <<EMPTY_NAME>> As DataRow

		' Token: 0x04001F10 RID: 7952
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04001F11 RID: 7953
		Friend <<EMPTY_NAME>> As RibbonApplicationMenu

		' Token: 0x04001F12 RID: 7954
		Friend <<EMPTY_NAME>> As ContextMenuCollection

		' Token: 0x04001F13 RID: 7955
		Friend <<EMPTY_NAME>> As RibbonTabCollection

		' Token: 0x04001F14 RID: 7956
		Friend <<EMPTY_NAME>> As RibbonTopTabCollection

		' Token: 0x04001F15 RID: 7957
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001F16 RID: 7958
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F17 RID: 7959
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F18 RID: 7960
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F19 RID: 7961
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F1A RID: 7962
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F1B RID: 7963
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F1C RID: 7964
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F1D RID: 7965
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F1E RID: 7966
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F1F RID: 7967
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F20 RID: 7968
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F21 RID: 7969
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F22 RID: 7970
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F23 RID: 7971
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F24 RID: 7972
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F25 RID: 7973
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F26 RID: 7974
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F27 RID: 7975
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F28 RID: 7976
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F29 RID: 7977
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F2A RID: 7978
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F2B RID: 7979
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F2C RID: 7980
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F2D RID: 7981
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F2E RID: 7982
		Private <<EMPTY_NAME>> As EventString

		' Token: 0x04001F2F RID: 7983
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
