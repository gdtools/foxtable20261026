Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices

Namespace Foxtable.WinForm
	' Token: 0x02000516 RID: 1302
	<oO0oooo("1598")>
	<ComVisible(True)>
	Public Class Line
		Inherits Control

		' Token: 0x0600552C RID: 21804 RVA: 0x00220AAF File Offset: 0x0021ECAF
		Public Sub New(A_0 As LineControl)
			MyBase.New(A_0, ControlTypeEnum.Line)
			Me.o0_0oO.OooO. = A_0
		End Sub

		' Token: 0x17001457 RID: 5207
		' (get) Token: 0x0600552D RID: 21805 RVA: 0x00220AC1 File Offset: 0x0021ECC1
		' (set) Token: 0x0600552E RID: 21806 RVA: 0x00220ACE File Offset: 0x0021ECCE
		Public Property Ditection As LineDirectionEnum
			Get
				Return Me.o0_0oO.OooO..Direction
			End Get
			Set(value As LineDirectionEnum)
				Me.o0_0oO.OooO..Direction = value
			End Set
		End Property

		' Token: 0x17001458 RID: 5208
		' (get) Token: 0x0600552F RID: 21807 RVA: 0x00220ADC File Offset: 0x0021ECDC
		' (set) Token: 0x06005530 RID: 21808 RVA: 0x00220AE9 File Offset: 0x0021ECE9
		Public Property Thickness As Integer
			Get
				Return Me.o0_0oO.OooO..Thickness
			End Get
			Set(value As Integer)
				Me.o0_0oO.OooO..Thickness = value
			End Set
		End Property

		' Token: 0x17001459 RID: 5209
		' (get) Token: 0x06005531 RID: 21809 RVA: 0x00220AF7 File Offset: 0x0021ECF7
		' (set) Token: 0x06005532 RID: 21810 RVA: 0x00220B04 File Offset: 0x0021ED04
		Public Property DashStyle As DashStyleEnum
			Get
				Return Me.o0_0oO.OooO..DashStyle
			End Get
			Set(value As DashStyleEnum)
				Me.o0_0oO.OooO..DashStyle = value
			End Set
		End Property

		' Token: 0x1700145A RID: 5210
		' (get) Token: 0x06005533 RID: 21811 RVA: 0x00220B12 File Offset: 0x0021ED12
		' (set) Token: 0x06005534 RID: 21812 RVA: 0x00220B1F File Offset: 0x0021ED1F
		Public Property LineColor As Color
			Get
				Return Me.o0_0oO.OooO..ForeColor
			End Get
			Set(value As Color)
				Me.o0_0oO.OooO..ForeColor = value
				Me.o0_0oO.OooO..Invalidate()
			End Set
		End Property

		' Token: 0x04002205 RID: 8709
		Private <<EMPTY_NAME>> As LineControl
	End Class
End Namespace
