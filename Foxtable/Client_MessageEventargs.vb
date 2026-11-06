Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x020001B0 RID: 432
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Client_MessageEventargs
		' Token: 0x1700043F RID: 1087
		' (get) Token: 0x0600145C RID: 5212 RVA: 0x00080E83 File Offset: 0x0007F083
		' (set) Token: 0x0600145D RID: 5213 RVA: 0x00080E8B File Offset: 0x0007F08B
		Public Property SendTime As DateTime

		' Token: 0x0600145E RID: 5214 RVA: 0x00080E94 File Offset: 0x0007F094
		Public Sub New(A_0 As IMClient, A_1 As String, A_2 As String)
			Me.SendTime = DateTime.MinValue
			Me.oO0OOO.0O. = A_1
			Me.o000.0. = A_2
			Me.O_o.O0. = A_0
		End Sub

		' Token: 0x17000440 RID: 1088
		' (get) Token: 0x0600145F RID: 5215 RVA: 0x00080EBC File Offset: 0x0007F0BC
		Public ReadOnly Property UserName As String
			Get
				Return Me.oO0OOO.0O.
			End Get
		End Property

		' Token: 0x17000441 RID: 1089
		' (get) Token: 0x06001460 RID: 5216 RVA: 0x00080EC4 File Offset: 0x0007F0C4
		Public ReadOnly Property Message As String
			Get
				Return Me.o000.0.
			End Get
		End Property

		' Token: 0x17000442 RID: 1090
		' (get) Token: 0x06001461 RID: 5217 RVA: 0x00080ECC File Offset: 0x0007F0CC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Client As IMClient
			Get
				Return Me.O_o.O0.
			End Get
		End Property

		' Token: 0x040007E7 RID: 2023
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x040007E8 RID: 2024
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007E9 RID: 2025
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007EA RID: 2026
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DateTime
	End Class
End Namespace
