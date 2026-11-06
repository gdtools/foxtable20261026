Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Xml
Imports C1.Win.C1Gauge
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004F4 RID: 1268
	<ComVisible(True)>
	Public Class Gauges
		Inherits Control

		' Token: 0x0600512B RID: 20779 RVA: 0x00219A2E File Offset: 0x00217C2E
		Friend Sub New(A_0 As O0_O_0O)
			MyBase.New(A_0, ControlTypeEnum.Gauges)
		End Sub

		' Token: 0x1700127B RID: 4731
		' (set) Token: 0x0600512C RID: 20780 RVA: 0x00219A3C File Offset: 0x00217C3C
		<Browsable(False)>
		Public WriteOnly Property Settings As String
			Set(value As String)
				Dim xmlDocument As XmlDocument = New XmlDocument()
				xmlDocument.LoadXml(value)
				CType(MyBase.BaseControl, C1Gauge).Load(xmlDocument)
			End Set
		End Property

		' Token: 0x1700127C RID: 4732
		' (get) Token: 0x0600512D RID: 20781 RVA: 0x00219A68 File Offset: 0x00217C68
		Public ReadOnly Property RadialGauge As C1RadialGauge
			Get
				Dim c1Gauge As C1Gauge = CType(MyBase.BaseControl, C1Gauge)
				Dim num As Integer = c1Gauge.Gauges.Count - 1
				For i As Integer = 0 To num
					If TypeOf c1Gauge.Gauges(i)Is C1RadialGauge Then
						Return CType(c1Gauge.Gauges(i), C1RadialGauge)
					End If
				Next
				Throw New NullReferenceException()
			End Get
		End Property

		' Token: 0x1700127D RID: 4733
		' (get) Token: 0x0600512E RID: 20782 RVA: 0x00219ACC File Offset: 0x00217CCC
		Public ReadOnly Property LinearGauge As C1LinearGauge
			Get
				Dim c1Gauge As C1Gauge = CType(MyBase.BaseControl, C1Gauge)
				Dim num As Integer = c1Gauge.Gauges.Count - 1
				For i As Integer = 0 To num
					If TypeOf c1Gauge.Gauges(i)Is C1LinearGauge Then
						Return CType(c1Gauge.Gauges(i), C1LinearGauge)
					End If
				Next
				Throw New NullReferenceException()
			End Get
		End Property

		' Token: 0x1700127E RID: 4734
		' (get) Token: 0x0600512F RID: 20783 RVA: 0x00219B2F File Offset: 0x00217D2F
		' (set) Token: 0x06005130 RID: 20784 RVA: 0x00219B4C File Offset: 0x00217D4C
		Public Property Value As Double
			Get
				Return CType(MyBase.BaseControl, C1Gauge).Gauges(0).Value
			End Get
			Set(value As Double)
				CType(MyBase.BaseControl, C1Gauge).Gauges(0).Value = value
			End Set
		End Property

		' Token: 0x1700127F RID: 4735
		' (get) Token: 0x06005131 RID: 20785 RVA: 0x00219B6C File Offset: 0x00217D6C
		Public ReadOnly Property Gauges As GaugeCollection
			Get
				Return CType(MyBase.BaseControl, C1Gauge).Gauges
			End Get
		End Property

		' Token: 0x17001280 RID: 4736
		' (get) Token: 0x06005132 RID: 20786 RVA: 0x00219B7E File Offset: 0x00217D7E
		' (set) Token: 0x06005133 RID: 20787 RVA: 0x00219B81 File Offset: 0x00217D81
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BackGroundImageFile As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				MyBase.BaseControl.BackgroundImage = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x17001281 RID: 4737
		' (get) Token: 0x06005134 RID: 20788 RVA: 0x00219B94 File Offset: 0x00217D94
		' (set) Token: 0x06005135 RID: 20789 RVA: 0x00219BA1 File Offset: 0x00217DA1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BackgroundImageLayout As ImageLayout
			Get
				Return MyBase.BaseControl.BackgroundImageLayout
			End Get
			Set(value As ImageLayout)
				MyBase.BaseControl.BackgroundImageLayout = value
			End Set
		End Property

		' Token: 0x06005136 RID: 20790 RVA: 0x00219BB0 File Offset: 0x00217DB0
		<oO0oooo("1912")>
		Public Sub AddControl(Control As Control)
			MyBase.BaseControl.Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x06005137 RID: 20791 RVA: 0x00219C14 File Offset: 0x00217E14
		<oO0oooo("1912")>
		Public Sub RemoveControl(Name As String)
			Try
				For Each obj As Object In MyBase.BaseControl.Controls
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, Name, True) = 0 Then
						oOO0oo_o0.O00OO_O_oO_.o.(MyBase.BaseControl.Controls, control)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			oOO0oo_o0.oOo.oO_O0_o_Oo.(MyBase.BaseControl)
		End Sub

		' Token: 0x06005138 RID: 20792 RVA: 0x00219C9C File Offset: 0x00217E9C
		Public Sub ClearControl()
			For i As Integer = MyBase.BaseControl.Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = MyBase.BaseControl.Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(MyBase.BaseControl.Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(MyBase.BaseControl)
		End Sub

		' Token: 0x17001282 RID: 4738
		' (get) Token: 0x06005139 RID: 20793 RVA: 0x00219CF4 File Offset: 0x00217EF4
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(MyBase.BaseControl)
			End Get
		End Property
	End Class
End Namespace
