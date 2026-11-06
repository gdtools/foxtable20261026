Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x0200000E RID: 14
	<ComVisible(True)>
	Public Class NumericBox
		Inherits RibbonItem

		' Token: 0x06000057 RID: 87 RVA: 0x000029B5 File Offset: 0x00000BB5
		Friend Sub New(A_0 As RibbonNumericBox)
			MyBase.New(A_0)
			Me.OOo.O_o. = A_0
		End Sub

		' Token: 0x06000058 RID: 88 RVA: 0x000029C5 File Offset: 0x00000BC5
		Public Sub New(A_0 As String)
			Me.OOo.O_o. = New RibbonNumericBox()
			Me.oOo_.0o_O_O_0. = Me.OOo.O_o.
			Me.OOo.O_o..ID = A_0
		End Sub

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000059 RID: 89 RVA: 0x000029F0 File Offset: 0x00000BF0
		' (set) Token: 0x0600005A RID: 90 RVA: 0x000029FD File Offset: 0x00000BFD
		Public Property Minimum As Decimal
			Get
				Return Me.OOo.O_o..Minimum
			End Get
			Set(value As Decimal)
				Me.OOo.O_o..Minimum = value
			End Set
		End Property

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x0600005B RID: 91 RVA: 0x00002A0B File Offset: 0x00000C0B
		' (set) Token: 0x0600005C RID: 92 RVA: 0x00002A18 File Offset: 0x00000C18
		Public Property Maximum As Decimal
			Get
				Return Me.OOo.O_o..Maximum
			End Get
			Set(value As Decimal)
				Me.OOo.O_o..Maximum = value
			End Set
		End Property

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x0600005D RID: 93 RVA: 0x00002A28 File Offset: 0x00000C28
		' (set) Token: 0x0600005E RID: 94 RVA: 0x00002A53 File Offset: 0x00000C53
		Public Property value As Object
			Get
				Dim result As Object
				If Me.ValueIsNull Then
					result = Nothing
				Else
					result = Me.OOo.O_o..Value
				End If
				Return result
			End Get
			Set(value As Object)
				If value Is Nothing Then
					Me.OOo.O_o..ValueIsNull = True
					Return
				End If
				Me.OOo.O_o..Value = Conversions.ToDecimal(value)
			End Set
		End Property

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x0600005F RID: 95 RVA: 0x00002A76 File Offset: 0x00000C76
		' (set) Token: 0x06000060 RID: 96 RVA: 0x00002A83 File Offset: 0x00000C83
		Public Property Increment As Decimal
			Get
				Return Me.OOo.O_o..Increment
			End Get
			Set(value As Decimal)
				Me.OOo.O_o..Increment = value
			End Set
		End Property

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000061 RID: 97 RVA: 0x00002A91 File Offset: 0x00000C91
		' (set) Token: 0x06000062 RID: 98 RVA: 0x00002A9E File Offset: 0x00000C9E
		Public Property Label As String
			Get
				Return Me.OOo.O_o..Label
			End Get
			Set(value As String)
				Me.OOo.O_o..Label = value
			End Set
		End Property

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000063 RID: 99 RVA: 0x00002AAC File Offset: 0x00000CAC
		' (set) Token: 0x06000064 RID: 100 RVA: 0x00002AB9 File Offset: 0x00000CB9
		Public Property TextAreaWidth As Integer
			Get
				Return Me.OOo.O_o..TextAreaWidth
			End Get
			Set(value As Integer)
				Me.OOo.O_o..TextAreaWidth = value
			End Set
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000065 RID: 101 RVA: 0x00002AC7 File Offset: 0x00000CC7
		Public ReadOnly Property ValueIsNull As Boolean
			Get
				Return Me.OOo.O_o..ValueIsNull
			End Get
		End Property

		' Token: 0x04000013 RID: 19
		Friend <<EMPTY_NAME>> As RibbonNumericBox
	End Class
End Namespace
