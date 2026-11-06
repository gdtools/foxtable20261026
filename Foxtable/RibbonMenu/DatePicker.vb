Imports System
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x0200000D RID: 13
	<ComVisible(True)>
	Public Class DatePicker
		Inherits RibbonItem

		' Token: 0x0600004E RID: 78 RVA: 0x000028E7 File Offset: 0x00000AE7
		Friend Sub New(A_0 As RibbonDatePicker)
			MyBase.New(A_0)
			Me.o_.o0_o. = A_0
		End Sub

		' Token: 0x0600004F RID: 79 RVA: 0x000028F7 File Offset: 0x00000AF7
		Public Sub New(A_0 As String)
			Me.o_.o0_o. = New RibbonDatePicker()
			Me.oOo_.0o_O_O_0. = Me.o_.o0_o.
			Me.o_.o0_o..ID = A_0
		End Sub

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000050 RID: 80 RVA: 0x00002924 File Offset: 0x00000B24
		' (set) Token: 0x06000051 RID: 81 RVA: 0x0000294F File Offset: 0x00000B4F
		Public Property value As Object
			Get
				Dim result As Object
				If Me.ValueIsNull Then
					result = Nothing
				Else
					result = Me.o_.o0_o..Value
				End If
				Return result
			End Get
			Set(value As Object)
				If value Is Nothing Then
					Me.o_.o0_o..ValueIsNull = True
					Return
				End If
				Me.o_.o0_o..Value = Conversions.ToDate(value)
			End Set
		End Property

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000052 RID: 82 RVA: 0x00002972 File Offset: 0x00000B72
		' (set) Token: 0x06000053 RID: 83 RVA: 0x0000297F File Offset: 0x00000B7F
		Public Property Label As String
			Get
				Return Me.o_.o0_o..Label
			End Get
			Set(value As String)
				Me.o_.o0_o..Label = value
			End Set
		End Property

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000054 RID: 84 RVA: 0x0000298D File Offset: 0x00000B8D
		' (set) Token: 0x06000055 RID: 85 RVA: 0x0000299A File Offset: 0x00000B9A
		Public Property TextAreaWidth As Integer
			Get
				Return Me.o_.o0_o..TextAreaWidth
			End Get
			Set(value As Integer)
				Me.o_.o0_o..TextAreaWidth = value
			End Set
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000056 RID: 86 RVA: 0x000029A8 File Offset: 0x00000BA8
		Public ReadOnly Property ValueIsNull As Boolean
			Get
				Return Me.o_.o0_o..ValueIsNull
			End Get
		End Property

		' Token: 0x04000012 RID: 18
		Friend <<EMPTY_NAME>> As RibbonDatePicker
	End Class
End Namespace
