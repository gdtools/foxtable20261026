Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Gauge
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000150 RID: 336
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GaugeFormatLabelEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F96 RID: 3990 RVA: 0x00068E78 File Offset: 0x00067078
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As FormatLabelEventArgs)
			MyBase.New(A_0, A_1)
			Me.O0_oO0.o_o. = A_2
		End Sub

		' Token: 0x170002D9 RID: 729
		' (get) Token: 0x06000F97 RID: 3991 RVA: 0x00068E89 File Offset: 0x00067089
		Public ReadOnly Property Decorator As C1GaugeDecorator
			Get
				Return Me.O0_oO0.o_o..Decorator
			End Get
		End Property

		' Token: 0x170002DA RID: 730
		' (get) Token: 0x06000F98 RID: 3992 RVA: 0x00068E96 File Offset: 0x00067096
		Public ReadOnly Property Value As Double
			Get
				Return Me.O0_oO0.o_o..Value
			End Get
		End Property

		' Token: 0x170002DB RID: 731
		' (get) Token: 0x06000F99 RID: 3993 RVA: 0x00068EA3 File Offset: 0x000670A3
		Public ReadOnly Property ScaledValue As Double
			Get
				Return Me.O0_oO0.o_o..ScaledValue
			End Get
		End Property

		' Token: 0x170002DC RID: 732
		' (get) Token: 0x06000F9A RID: 3994 RVA: 0x00068EB0 File Offset: 0x000670B0
		' (set) Token: 0x06000F9B RID: 3995 RVA: 0x00068EBD File Offset: 0x000670BD
		Public Property Text As String
			Get
				Return Me.O0_oO0.o_o..Text
			End Get
			Set(value As String)
				Me.O0_oO0.o_o..Text = value
			End Set
		End Property

		' Token: 0x040005FA RID: 1530
		Private <<EMPTY_NAME>> As FormatLabelEventArgs
	End Class
End Namespace
