Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000321 RID: 801
	Friend Class CrossTableProperty
		' Token: 0x06002B66 RID: 11110 RVA: 0x0012FB81 File Offset: 0x0012DD81
		Public Sub New(A_0 As CrossTableBuilder)
			Me.O0o__o0o.0. = 4
			Me.O0o__o0o.0. = A_0
		End Sub

		' Token: 0x17000A45 RID: 2629
		' (get) Token: 0x06002B67 RID: 11111 RVA: 0x0012FB97 File Offset: 0x0012DD97
		' (set) Token: 0x06002B68 RID: 11112 RVA: 0x0012FBA4 File Offset: 0x0012DDA4
		Public Property CrossTableName As String
			Get
				Return Me.O0o__o0o.0..TableName
			End Get
			Set(value As String)
				Me.Oo0.OOooO. = value
			End Set
		End Property

		' Token: 0x17000A46 RID: 2630
		' (get) Token: 0x06002B69 RID: 11113 RVA: 0x0012FBAD File Offset: 0x0012DDAD
		' (set) Token: 0x06002B6A RID: 11114 RVA: 0x0012FBBA File Offset: 0x0012DDBA
		Public Property CrossTableCaption As String
			Get
				Return Me.O0o__o0o.0..Caption
			End Get
			Set(value As String)
				Me.O.OooOo00. = value
			End Set
		End Property

		' Token: 0x17000A47 RID: 2631
		' (get) Token: 0x06002B6B RID: 11115 RVA: 0x0012FBC3 File Offset: 0x0012DDC3
		' (set) Token: 0x06002B6C RID: 11116 RVA: 0x0012FBD0 File Offset: 0x0012DDD0
		Public Property CrossTableFilter As String
			Get
				Return Me.O0o__o0o.0..Filter
			End Get
			Set(value As String)
				Me.oOOO.o0Oo0__. = value
			End Set
		End Property

		' Token: 0x17000A48 RID: 2632
		' (get) Token: 0x06002B6D RID: 11117 RVA: 0x0012FBD9 File Offset: 0x0012DDD9
		' (set) Token: 0x06002B6E RID: 11118 RVA: 0x0012FBE6 File Offset: 0x0012DDE6
		Public Property ExtendFilter As String
			Get
				Return Me.O0o__o0o.0..ExtendFilter
			End Get
			Set(value As String)
				Me.O0o__o0o.0..ExtendFilter = value
			End Set
		End Property

		' Token: 0x17000A49 RID: 2633
		' (get) Token: 0x06002B6F RID: 11119 RVA: 0x0012FBF4 File Offset: 0x0012DDF4
		' (set) Token: 0x06002B70 RID: 11120 RVA: 0x0012FC01 File Offset: 0x0012DE01
		Public Property FromAll As Boolean
			Get
				Return Me.O0o__o0o.0..FromAll
			End Get
			Set(value As Boolean)
				Me.O0o__o0o.0..FromAll = value
			End Set
		End Property

		' Token: 0x17000A4A RID: 2634
		' (get) Token: 0x06002B71 RID: 11121 RVA: 0x0012FC0F File Offset: 0x0012DE0F
		' (set) Token: 0x06002B72 RID: 11122 RVA: 0x0012FC1C File Offset: 0x0012DE1C
		Public Property FromServer As Boolean
			Get
				Return Me.O0o__o0o.0..FromServer
			End Get
			Set(value As Boolean)
				Me.o.OOO0__o_. = value
			End Set
		End Property

		' Token: 0x17000A4B RID: 2635
		' (get) Token: 0x06002B73 RID: 11123 RVA: 0x0012FC25 File Offset: 0x0012DE25
		' (set) Token: 0x06002B74 RID: 11124 RVA: 0x0012FC32 File Offset: 0x0012DE32
		Public Property HorizontalProportion As Boolean
			Get
				Return Me.O0o__o0o.0..HorizontalProportion
			End Get
			Set(value As Boolean)
				Me.o__.__O_o__. = value
			End Set
		End Property

		' Token: 0x17000A4C RID: 2636
		' (get) Token: 0x06002B75 RID: 11125 RVA: 0x0012FC3B File Offset: 0x0012DE3B
		' (set) Token: 0x06002B76 RID: 11126 RVA: 0x0012FC48 File Offset: 0x0012DE48
		Public Property VerticalProportion As Boolean
			Get
				Return Me.O0o__o0o.0..VerticalProportion
			End Get
			Set(value As Boolean)
				Me.oOO_.o_0OOO. = value
			End Set
		End Property

		' Token: 0x17000A4D RID: 2637
		' (get) Token: 0x06002B77 RID: 11127 RVA: 0x0012FC51 File Offset: 0x0012DE51
		' (set) Token: 0x06002B78 RID: 11128 RVA: 0x0012FC5E File Offset: 0x0012DE5E
		Public Property HorizontalProportionCaption As String
			Get
				Return Me.O0o__o0o.0..HorizontalProportionCaption
			End Get
			Set(value As String)
				Me.o.oo0. = value
			End Set
		End Property

		' Token: 0x17000A4E RID: 2638
		' (get) Token: 0x06002B79 RID: 11129 RVA: 0x0012FC67 File Offset: 0x0012DE67
		' (set) Token: 0x06002B7A RID: 11130 RVA: 0x0012FC74 File Offset: 0x0012DE74
		Public Property VerticalProportionCaption As String
			Get
				Return Me.O0o__o0o.0..VerticalProportionCaption
			End Get
			Set(value As String)
				Me.o.o_OO0. = value
			End Set
		End Property

		' Token: 0x17000A4F RID: 2639
		' (get) Token: 0x06002B7B RID: 11131 RVA: 0x0012FC7D File Offset: 0x0012DE7D
		' (set) Token: 0x06002B7C RID: 11132 RVA: 0x0012FC8A File Offset: 0x0012DE8A
		Public Property Decimals As Integer
			Get
				Return Me.O0o__o0o.0..Decimals
			End Get
			Set(value As Integer)
				Me.O0o__o0o.0. = value
			End Set
		End Property

		' Token: 0x17000A50 RID: 2640
		' (get) Token: 0x06002B7D RID: 11133 RVA: 0x0012FC93 File Offset: 0x0012DE93
		' (set) Token: 0x06002B7E RID: 11134 RVA: 0x0012FCA0 File Offset: 0x0012DEA0
		Public Property Subtotal As Boolean
			Get
				Return Me.O0o__o0o.0..Subtotal
			End Get
			Set(value As Boolean)
				Me.o.oo0. = value
			End Set
		End Property

		' Token: 0x17000A51 RID: 2641
		' (get) Token: 0x06002B7F RID: 11135 RVA: 0x0012FCAC File Offset: 0x0012DEAC
		' (set) Token: 0x06002B80 RID: 11136 RVA: 0x0012FD2C File Offset: 0x0012DF2C
		Public Property CrossTableHGroups As String
			Get
				Dim text As String = ""
				Try
					For Each a_ As GroupOn In Me.O0o__o0o.0..HGroups
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCr
						End If
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
					Next
				Finally
					Dim enumerator As IEnumerator(Of GroupOn)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text
			End Get
			Set(value As String)
				Me.o___0o.0OOOooO. = value
			End Set
		End Property

		' Token: 0x17000A52 RID: 2642
		' (get) Token: 0x06002B81 RID: 11137 RVA: 0x0012FD38 File Offset: 0x0012DF38
		' (set) Token: 0x06002B82 RID: 11138 RVA: 0x0012FDB8 File Offset: 0x0012DFB8
		Public Property CrossTableVGroups As String
			Get
				Dim text As String = ""
				Try
					For Each a_ As CrossGroupOn In Me.O0o__o0o.0..VGroups
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCr
						End If
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
					Next
				Finally
					Dim enumerator As IEnumerator(Of CrossGroupOn)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text
			End Get
			Set(value As String)
				Me.o0O0__Oo_O_0._. = value
			End Set
		End Property

		' Token: 0x17000A53 RID: 2643
		' (get) Token: 0x06002B83 RID: 11139 RVA: 0x0012FDC1 File Offset: 0x0012DFC1
		' (set) Token: 0x06002B84 RID: 11140 RVA: 0x0012FDCE File Offset: 0x0012DFCE
		Public Property CrossTableOrderByTotal As Boolean
			Get
				Return Me.O0o__o0o.0..OrderByTotal
			End Get
			Set(value As Boolean)
				Me.o___0o.0OOOooO. = value
			End Set
		End Property

		' Token: 0x17000A54 RID: 2644
		' (get) Token: 0x06002B85 RID: 11141 RVA: 0x0012FDD7 File Offset: 0x0012DFD7
		' (set) Token: 0x06002B86 RID: 11142 RVA: 0x0012FDE4 File Offset: 0x0012DFE4
		Public Property CrossTableHorizontalTotal As Boolean
			Get
				Return Me.O0o__o0o.0..HorizontalTotal
			End Get
			Set(value As Boolean)
				Me.oO.Oo0. = value
			End Set
		End Property

		' Token: 0x17000A55 RID: 2645
		' (get) Token: 0x06002B87 RID: 11143 RVA: 0x0012FDED File Offset: 0x0012DFED
		' (set) Token: 0x06002B88 RID: 11144 RVA: 0x0012FDFA File Offset: 0x0012DFFA
		Public Property CrossTableVerticalTotal As Boolean
			Get
				Return Me.O0o__o0o.0..VerticalTotal
			End Get
			Set(value As Boolean)
				Me.oOo.00o_. = value
			End Set
		End Property

		' Token: 0x17000A56 RID: 2646
		' (get) Token: 0x06002B89 RID: 11145 RVA: 0x0012FE04 File Offset: 0x0012E004
		' (set) Token: 0x06002B8A RID: 11146 RVA: 0x0012FE84 File Offset: 0x0012E084
		Public Property CrossTableTotals As String
			Get
				Dim text As String = ""
				Try
					For Each a_ As CrossTotalOn In Me.O0o__o0o.0..Totals
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCr
						End If
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
					Next
				Finally
					Dim enumerator As IEnumerator(Of CrossTotalOn)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text
			End Get
			Set(value As String)
				Me.O_O.oo0_0_. = value
			End Set
		End Property

		' Token: 0x06002B8B RID: 11147 RVA: 0x0012FE90 File Offset: 0x0012E090
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.o___0o.0OOOooO., "", True) > 0 AndAlso Operators.CompareString(Me.o0O0__Oo_O_0._., "", True) > 0 AndAlso Operators.CompareString(Me.O_O.oo0_0_., "", True) > 0 Then
				Me.O0o__o0o.0..TableName = Me.Oo0.OOooO.
				Me.O0o__o0o.0..Caption = Me.O.OooOo00.
				Me.O0o__o0o.0..Filter = Me.oOOO.o0Oo0__.
				Me.O0o__o0o.0..OrderByTotal = Me.o___0o.0OOOooO.
				Me.O0o__o0o.0..HorizontalTotal = Me.oO.Oo0.
				Me.O0o__o0o.0..VerticalTotal = Me.oOo.00o_.
				Me.O0o__o0o.0..HorizontalProportion = Me.o__.__O_o__.
				Me.O0o__o0o.0..HorizontalProportionCaption = Me.o.oo0.
				Me.O0o__o0o.0..VerticalProportion = Me.oOO_.o_0OOO.
				Me.O0o__o0o.0..VerticalProportionCaption = Me.o.o_OO0.
				Me.O0o__o0o.0..Decimals = Me.O0o__o0o.0.
				Me.O0o__o0o.0..FromServer = Me.o.OOO0__o_.
				Me.O0o__o0o.0..Subtotal = Me.o.oo0.
				Dim array As String() = Me.o___0o.0OOOooO..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				Dim array2 As String() = Me.o0O0__Oo_O_0._..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				Dim array3 As String() = Me.O_O.oo0_0_..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				For Each a_ As String In array
					Dim groupOn As GroupOn = New GroupOn()
					o_O_o_oOoo__.OOOO_OO._oo.(groupOn, a_, vbLf)
					Me.O0o__o0o.0..HGroups.Add(groupOn)
				Next
				For Each a_2 As String In array2
					Dim crossGroupOn As CrossGroupOn = New CrossGroupOn()
					o_O_o_oOoo__.OOOO_OO._oo.(crossGroupOn, a_2, vbLf)
					Me.O0o__o0o.0..VGroups.Add(crossGroupOn)
				Next
				For Each a_3 As String In array3
					Dim crossTotalOn As CrossTotalOn = New CrossTotalOn(False)
					o_O_o_oOoo__.OOOO_OO._oo.(crossTotalOn, a_3, vbLf)
					Me.O0o__o0o.0..Totals.Add(crossTotalOn)
				Next
			End If
		End Sub

		' Token: 0x04001195 RID: 4501
		Private <<EMPTY_NAME>> As CrossTableBuilder

		' Token: 0x04001196 RID: 4502
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001197 RID: 4503
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001198 RID: 4504
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001199 RID: 4505
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400119A RID: 4506
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400119B RID: 4507
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400119C RID: 4508
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400119D RID: 4509
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400119E RID: 4510
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400119F RID: 4511
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040011A0 RID: 4512
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040011A1 RID: 4513
		Private <<EMPTY_NAME>> As String

		' Token: 0x040011A2 RID: 4514
		Private <<EMPTY_NAME>> As String

		' Token: 0x040011A3 RID: 4515
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040011A4 RID: 4516
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040011A5 RID: 4517
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
