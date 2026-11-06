Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000328 RID: 808
	Friend Class SubtotalModeProperty
		' Token: 0x06002F68 RID: 12136 RVA: 0x00134940 File Offset: 0x00132B40
		Public Sub New(A_0 As SubtotalGroupCollection, A_1 As Boolean, A_2 As Boolean, A_3 As Boolean)
			Me.O._OOo__. = A_0
			Me.o0o_.O_0. = A_2
			Me.oO0O_0.ooo00. = A_1
			Me.o_OO.o0O. = A_3
		End Sub

		' Token: 0x17000C38 RID: 3128
		' (get) Token: 0x06002F69 RID: 12137 RVA: 0x00134968 File Offset: 0x00132B68
		' (set) Token: 0x06002F6A RID: 12138 RVA: 0x001349E4 File Offset: 0x00132BE4
		Public Property SubtotalGroups As String
			Get
				Dim text As String = ""
				Try
					For Each a_ As SubtotalGroup In Me.O._OOo__.
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCr
						End If
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
					Next
				Finally
					Dim enumerator As IEnumerator(Of SubtotalGroup)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text
			End Get
			Set(value As String)
				Me.O._OOo__. = value
			End Set
		End Property

		' Token: 0x17000C39 RID: 3129
		' (get) Token: 0x06002F6B RID: 12139 RVA: 0x001349ED File Offset: 0x00132BED
		' (set) Token: 0x06002F6C RID: 12140 RVA: 0x001349F5 File Offset: 0x00132BF5
		Public Property GroupAboveData As Boolean
			Get
				Return Me.oO0O_0.ooo00.
			End Get
			Set(value As Boolean)
				Me.oO0O_0.ooo00. = value
			End Set
		End Property

		' Token: 0x17000C3A RID: 3130
		' (get) Token: 0x06002F6D RID: 12141 RVA: 0x001349FE File Offset: 0x00132BFE
		' (set) Token: 0x06002F6E RID: 12142 RVA: 0x00134A06 File Offset: 0x00132C06
		Public Property TreeVisible As Boolean
			Get
				Return Me.o0o_.O_0.
			End Get
			Set(value As Boolean)
				Me.o0o_.O_0. = value
			End Set
		End Property

		' Token: 0x17000C3B RID: 3131
		' (get) Token: 0x06002F6F RID: 12143 RVA: 0x00134A0F File Offset: 0x00132C0F
		' (set) Token: 0x06002F70 RID: 12144 RVA: 0x00134A17 File Offset: 0x00132C17
		Public Property SpillNode As Boolean
			Get
				Return Me.o_OO.o0O.
			End Get
			Set(value As Boolean)
				Me.o_OO.o0O. = value
			End Set
		End Property

		' Token: 0x06002F71 RID: 12145 RVA: 0x00134A20 File Offset: 0x00132C20
		Friend Sub Restore()
			Dim array As String() = Me.O._OOo__..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
			Me.O._OOo__..Clear()
			For Each a_ As String In array
				Dim subtotalGroup As SubtotalGroup = New SubtotalGroup()
				o_O_o_oOoo__.OOOO_OO._oo.(subtotalGroup, a_, vbLf)
				Me.O._OOo__..Add(subtotalGroup)
			Next
		End Sub

		' Token: 0x0400132B RID: 4907
		Private <<EMPTY_NAME>> As SubtotalGroupCollection

		' Token: 0x0400132C RID: 4908
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400132D RID: 4909
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400132E RID: 4910
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400132F RID: 4911
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
