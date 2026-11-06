Imports System
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200040D RID: 1037
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class PrintPageProperty
		' Token: 0x0600445F RID: 17503 RVA: 0x001C2E3C File Offset: 0x001C103C
		Public Sub New()
			Me.O_O_oO0_00o.0. = PaperKind.A4
			Me.O_O_oO0_00o.0. = PaperSourceKind.FormSource
			Me.OO.OOO. = 25.4
			Me.o_00o.O0_0. = 25.4
			Me.o_.0OOO. = 25.4
			Me.ooOO0oO.0_oO. = 25.4
			Me.O0O.o____o00. = New PrinterSettings()
		End Sub

		' Token: 0x17000F7F RID: 3967
		' (get) Token: 0x06004460 RID: 17504 RVA: 0x001C2EA8 File Offset: 0x001C10A8
		' (set) Token: 0x06004461 RID: 17505 RVA: 0x001C2EED File Offset: 0x001C10ED
		Public Property PrinterName As String
			Get
				If Me.O0O.o____o00. Is Nothing Then
					Me.O0O.o____o00. = New PrinterSettings()
					If Operators.CompareString(Me.O0O.o____o00..PrinterName, Me.O_O_oO0_00o.0., True) = 0 Then
						Return Nothing
					End If
				End If
				Return Me.O_O_oO0_00o.0.
			End Get
			Set(value As String)
				Me.O_O_oO0_00o.0. = value
			End Set
		End Property

		' Token: 0x17000F80 RID: 3968
		' (get) Token: 0x06004462 RID: 17506 RVA: 0x001C2EF6 File Offset: 0x001C10F6
		' (set) Token: 0x06004463 RID: 17507 RVA: 0x001C2EFE File Offset: 0x001C10FE
		<DefaultValue(9)>
		Public Property PaperKind As PaperKind
			Get
				Return Me.O_O_oO0_00o.0.
			End Get
			Set(value As PaperKind)
				Me.O_O_oO0_00o.0. = value
			End Set
		End Property

		' Token: 0x17000F81 RID: 3969
		' (get) Token: 0x06004464 RID: 17508 RVA: 0x001C2F07 File Offset: 0x001C1107
		' (set) Token: 0x06004465 RID: 17509 RVA: 0x001C2F0F File Offset: 0x001C110F
		<DefaultValue(15)>
		Public Property PaperSourceKind As PaperSourceKind
			Get
				Return Me.O_O_oO0_00o.0.
			End Get
			Set(value As PaperSourceKind)
				Me.O_O_oO0_00o.0. = value
			End Set
		End Property

		' Token: 0x17000F82 RID: 3970
		' (get) Token: 0x06004466 RID: 17510 RVA: 0x001C2F18 File Offset: 0x001C1118
		' (set) Token: 0x06004467 RID: 17511 RVA: 0x001C2F20 File Offset: 0x001C1120
		<DefaultValue(False)>
		Public Property Landscape As Boolean
			Get
				Return Me.O_O_oO0_00o.0.
			End Get
			Set(value As Boolean)
				Me.O_O_oO0_00o.0. = value
			End Set
		End Property

		' Token: 0x17000F83 RID: 3971
		' (get) Token: 0x06004468 RID: 17512 RVA: 0x001C2F29 File Offset: 0x001C1129
		' (set) Token: 0x06004469 RID: 17513 RVA: 0x001C2F31 File Offset: 0x001C1131
		Public Property Width As Double
			Get
				Return Me.O_O_oO0_00o.0.
			End Get
			Set(value As Double)
				Me.O_O_oO0_00o.0. = value
			End Set
		End Property

		' Token: 0x17000F84 RID: 3972
		' (get) Token: 0x0600446A RID: 17514 RVA: 0x001C2F3A File Offset: 0x001C113A
		' (set) Token: 0x0600446B RID: 17515 RVA: 0x001C2F42 File Offset: 0x001C1142
		Public Property Height As Double
			Get
				Return Me.O.OO00o.
			End Get
			Set(value As Double)
				Me.O.OO00o. = value
			End Set
		End Property

		' Token: 0x17000F85 RID: 3973
		' (get) Token: 0x0600446C RID: 17516 RVA: 0x001C2F4B File Offset: 0x001C114B
		' (set) Token: 0x0600446D RID: 17517 RVA: 0x001C2F53 File Offset: 0x001C1153
		<DefaultValue(25.4)>
		Public Property LeftMargin As Double
			Get
				Return Me.OO.OOO.
			End Get
			Set(value As Double)
				Me.OO.OOO. = value
			End Set
		End Property

		' Token: 0x17000F86 RID: 3974
		' (get) Token: 0x0600446E RID: 17518 RVA: 0x001C2F5C File Offset: 0x001C115C
		' (set) Token: 0x0600446F RID: 17519 RVA: 0x001C2F64 File Offset: 0x001C1164
		<DefaultValue(25.4)>
		Public Property RightMargin As Double
			Get
				Return Me.o_00o.O0_0.
			End Get
			Set(value As Double)
				Me.o_00o.O0_0. = value
			End Set
		End Property

		' Token: 0x17000F87 RID: 3975
		' (get) Token: 0x06004470 RID: 17520 RVA: 0x001C2F6D File Offset: 0x001C116D
		' (set) Token: 0x06004471 RID: 17521 RVA: 0x001C2F75 File Offset: 0x001C1175
		<DefaultValue(25.4)>
		Public Property TopMargin As Double
			Get
				Return Me.o_.0OOO.
			End Get
			Set(value As Double)
				Me.o_.0OOO. = value
			End Set
		End Property

		' Token: 0x17000F88 RID: 3976
		' (get) Token: 0x06004472 RID: 17522 RVA: 0x001C2F7E File Offset: 0x001C117E
		' (set) Token: 0x06004473 RID: 17523 RVA: 0x001C2F86 File Offset: 0x001C1186
		<DefaultValue(25.4)>
		Public Property BottomMargin As Double
			Get
				Return Me.ooOO0oO.0_oO.
			End Get
			Set(value As Double)
				Me.ooOO0oO.0_oO. = value
			End Set
		End Property

		' Token: 0x04001BD5 RID: 7125
		Private <<EMPTY_NAME>> As PaperKind

		' Token: 0x04001BD6 RID: 7126
		Private <<EMPTY_NAME>> As PaperSourceKind

		' Token: 0x04001BD7 RID: 7127
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001BD8 RID: 7128
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001BD9 RID: 7129
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001BDA RID: 7130
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001BDB RID: 7131
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001BDC RID: 7132
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001BDD RID: 7133
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001BDE RID: 7134
		Private <<EMPTY_NAME>> As Double

		' Token: 0x04001BDF RID: 7135
		Private <<EMPTY_NAME>> As PrinterSettings
	End Class
End Namespace
