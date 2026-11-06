Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200028F RID: 655
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TotalOn
		' Token: 0x0600200F RID: 8207 RVA: 0x000D5BAE File Offset: 0x000D3DAE
		Public Sub New()
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
		End Sub

		' Token: 0x06002010 RID: 8208 RVA: 0x000D5BC8 File Offset: 0x000D3DC8
		Public Sub New(A_0 As String)
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
			Me.O__.o__. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
		End Sub

		' Token: 0x06002011 RID: 8209 RVA: 0x000D5C14 File Offset: 0x000D3E14
		Public Sub New(A_0 As String, A_1 As String)
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
			Me.O__.o__. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.o0_0_0O0oo0.o_. = A_1
		End Sub

		' Token: 0x06002012 RID: 8210 RVA: 0x000D5C68 File Offset: 0x000D3E68
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
			Me.O__.o__. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.o0_0_0O0oo0.o_. = A_1
			Me.Ooo.oo. = A_2
		End Sub

		' Token: 0x06002013 RID: 8211 RVA: 0x000D5CC4 File Offset: 0x000D3EC4
		Public Sub New(A_0 As String, A_1 As AggregateEnum)
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
			Me.O__.o__. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.O__.o__. = A_1
		End Sub

		' Token: 0x06002014 RID: 8212 RVA: 0x000D5D18 File Offset: 0x000D3F18
		Public Sub New(A_0 As String, A_1 As AggregateEnum, A_2 As String)
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
			Me.O__.o__. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.O__.o__. = A_1
			Me.o0_0_0O0oo0.o_. = A_2
		End Sub

		' Token: 0x06002015 RID: 8213 RVA: 0x000D5D74 File Offset: 0x000D3F74
		Public Sub New(A_0 As String, A_1 As AggregateEnum, A_2 As String, A_3 As String)
			Me.O__.o__. = 2
			Me.Oo_o0O00O.o0O. = New List(Of String)()
			Me.O__.o__. = A_0.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			Me.O__.o__. = A_1
			Me.o0_0_0O0oo0.o_. = A_2
			Me.Ooo.oo. = A_3
		End Sub

		' Token: 0x17000742 RID: 1858
		' (get) Token: 0x06002016 RID: 8214 RVA: 0x000D5DD6 File Offset: 0x000D3FD6
		' (set) Token: 0x06002017 RID: 8215 RVA: 0x000D5DDE File Offset: 0x000D3FDE
		Public Property Name As String
			Get
				Return Me.O__.o__.
			End Get
			Set(value As String)
				Me.O__.o__. = value.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
			End Set
		End Property

		' Token: 0x17000743 RID: 1859
		' (get) Token: 0x06002018 RID: 8216 RVA: 0x000D5E08 File Offset: 0x000D4008
		' (set) Token: 0x06002019 RID: 8217 RVA: 0x000D5E7D File Offset: 0x000D407D
		Public Property NewName As String
			Get
				Dim result As String
				If Operators.CompareString(Me.o0_0_0O0oo0.o_., "", True) > 0 Then
					result = Me.o0_0_0O0oo0.o_.
				ElseIf Me.O__.o__..IndexOf(".") > 0 Then
					result = Me.O__.o__..Split(New Char() { "."c })(1).Trim(New Char() { "["c, "]"c })
				Else
					result = Me.O__.o__.
				End If
				Return result
			End Get
			Set(value As String)
				Me.o0_0_0O0oo0.o_. = value
			End Set
		End Property

		' Token: 0x17000744 RID: 1860
		' (get) Token: 0x0600201A RID: 8218 RVA: 0x000D5E86 File Offset: 0x000D4086
		' (set) Token: 0x0600201B RID: 8219 RVA: 0x000D5E8E File Offset: 0x000D408E
		Public Property NewCaption As String
			Get
				Return Me.Ooo.oo.
			End Get
			Set(value As String)
				Me.Ooo.oo. = value
			End Set
		End Property

		' Token: 0x17000745 RID: 1861
		' (get) Token: 0x0600201C RID: 8220 RVA: 0x000D5E97 File Offset: 0x000D4097
		' (set) Token: 0x0600201D RID: 8221 RVA: 0x000D5E9F File Offset: 0x000D409F
		Public Property Aggregate As AggregateEnum
			Get
				Return Me.O__.o__.
			End Get
			Set(value As AggregateEnum)
				Me.O__.o__. = value
			End Set
		End Property

		' Token: 0x17000746 RID: 1862
		' (get) Token: 0x0600201E RID: 8222 RVA: 0x000D5EA8 File Offset: 0x000D40A8
		' (set) Token: 0x0600201F RID: 8223 RVA: 0x000D5EB0 File Offset: 0x000D40B0
		Public Property upto As Boolean
			Get
				Return Me.Oo_o0O00O.o0O.
			End Get
			Set(value As Boolean)
				Me.Oo_o0O00O.o0O. = value
			End Set
		End Property

		' Token: 0x04000D4A RID: 3402
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D4B RID: 3403
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D4C RID: 3404
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000D4D RID: 3405
		Private <<EMPTY_NAME>> As AggregateEnum

		' Token: 0x04000D4E RID: 3406
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000D4F RID: 3407
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04000D50 RID: 3408
		Friend <<EMPTY_NAME>> As Double

		' Token: 0x04000D51 RID: 3409
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000D52 RID: 3410
		Friend <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
