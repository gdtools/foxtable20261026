Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace Foxtable
	' Token: 0x02000405 RID: 1029
	Friend Class LineProperty
		Inherits ControlPropertyBase

		' Token: 0x06004386 RID: 17286 RVA: 0x001C1FEC File Offset: 0x001C01EC
		Public Sub New(A_0 As ControlHolder)
			MyBase.New(A_0)
			Me.o._Ooo0oOO. = CType(A_0.ChildControl, LineControl)
		End Sub

		' Token: 0x17000F17 RID: 3863
		' (get) Token: 0x06004387 RID: 17287 RVA: 0x001C2006 File Offset: 0x001C0206
		' (set) Token: 0x06004388 RID: 17288 RVA: 0x001C200E File Offset: 0x001C020E
		<Browsable(False)>
		<OooO0(True)>
		Public Property BackColor As Color
			Get
				Return MyBase.BackColor
			End Get
			Set(value As Color)
				MyBase.BackColor = value
			End Set
		End Property

		' Token: 0x17000F18 RID: 3864
		' (get) Token: 0x06004389 RID: 17289 RVA: 0x001C2017 File Offset: 0x001C0217
		' (set) Token: 0x0600438A RID: 17290 RVA: 0x001C201F File Offset: 0x001C021F
		<OooO0(True)>
		<Browsable(False)>
		Public Property Font As Font
			Get
				Return MyBase.Font
			End Get
			Set(value As Font)
				MyBase.Font = value
			End Set
		End Property

		' Token: 0x17000F19 RID: 3865
		' (get) Token: 0x0600438B RID: 17291 RVA: 0x001C2028 File Offset: 0x001C0228
		' (set) Token: 0x0600438C RID: 17292 RVA: 0x001C203A File Offset: 0x001C023A
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.0)>
		<DefaultValue(-16777216)>
		<DisplayName("颜色")>
		<Category("外观")>
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o_0_.Oo..ChildControl.ForeColor
			End Get
			Set(value As Color)
				Me.o_0_.Oo..ChildControl.ForeColor = value
			End Set
		End Property

		' Token: 0x17000F1A RID: 3866
		' (get) Token: 0x0600438D RID: 17293 RVA: 0x001C204D File Offset: 0x001C024D
		' (set) Token: 0x0600438E RID: 17294 RVA: 0x001C205A File Offset: 0x001C025A
		<MergableProperty(True)>
		<O_Oo00Oo000O0(2.1)>
		<DisplayName("方向")>
		<Category("外观")>
		<DefaultValue(0)>
		Public Property Ditection As LineDirectionEnum
			Get
				Return Me.o._Ooo0oOO..Direction
			End Get
			Set(value As LineDirectionEnum)
				Me.o._Ooo0oOO..Direction = value
			End Set
		End Property

		' Token: 0x17000F1B RID: 3867
		' (get) Token: 0x0600438F RID: 17295 RVA: 0x001C2068 File Offset: 0x001C0268
		' (set) Token: 0x06004390 RID: 17296 RVA: 0x001C2075 File Offset: 0x001C0275
		<DefaultValue(1)>
		<O_Oo00Oo000O0(2.2)>
		<DisplayName("线宽")>
		<Category("外观")>
		<MergableProperty(True)>
		Public Property Thickness As Integer
			Get
				Return Me.o._Ooo0oOO..Thickness
			End Get
			Set(value As Integer)
				Me.o._Ooo0oOO..Thickness = value
			End Set
		End Property

		' Token: 0x17000F1C RID: 3868
		' (get) Token: 0x06004391 RID: 17297 RVA: 0x001C2083 File Offset: 0x001C0283
		' (set) Token: 0x06004392 RID: 17298 RVA: 0x001C2090 File Offset: 0x001C0290
		<Category("外观")>
		<O_Oo00Oo000O0(2.2)>
		<DisplayName("线形")>
		<MergableProperty(True)>
		<DefaultValue(0)>
		Public Property DashStyle As DashStyleEnum
			Get
				Return Me.o._Ooo0oOO..DashStyle
			End Get
			Set(value As DashStyleEnum)
				Me.o._Ooo0oOO..DashStyle = value
			End Set
		End Property

		' Token: 0x04001B99 RID: 7065
		Private <<EMPTY_NAME>> As LineControl
	End Class
End Namespace
