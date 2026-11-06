Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200022A RID: 554
	<oO0oooo("A0054")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wUploader
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060019D3 RID: 6611 RVA: 0x000A6C14 File Offset: 0x000A4E14
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Boolean, A_4 As String)
			MyBase.New(A_0, A_1)
			Me.oo.oO0. = New Dictionary(Of String, String)()
			Me.oo.oO0. = New List(Of String)()
			Me.o_.o_o_O000_0_. = New List(Of String)()
			Me.OoOoo_o_.o_. = 1
			Me.o0.oO0O_oO__O_. = True
			Me.Oo0o_._00_O. = False
			Me.o_.o_o_O000_0_. = -1
			Me.oO_0oo.0oo__0_. = -1
			Me.o0_.OO_00. = 0
			Me.oo.oO0. = A_2
			Me.oo.oO0. = A_3
			Me.Oo0o_._00_O. = A_4
		End Sub

		' Token: 0x060019D4 RID: 6612 RVA: 0x000A6C8B File Offset: 0x000A4E8B
		Public Sub AddImage(image As String)
			Me.oo.oO0..Add(image, image)
			Me.o_.o_o_O000_0_..Add(image)
		End Sub

		' Token: 0x060019D5 RID: 6613 RVA: 0x000A6CA6 File Offset: 0x000A4EA6
		<oO0oooo("A0093")>
		Public Sub AddImage(thumbnail As String, image As String)
			Me.oo.oO0..Add(thumbnail, image)
			Me.o_.o_o_O000_0_..Add(thumbnail)
		End Sub

		' Token: 0x170005C0 RID: 1472
		' (get) Token: 0x060019D6 RID: 6614 RVA: 0x000A6CC1 File Offset: 0x000A4EC1
		' (set) Token: 0x060019D7 RID: 6615 RVA: 0x000A6CC9 File Offset: 0x000A4EC9
		Public Property Label As String
			Get
				Return Me.oo.oO0.
			End Get
			Set(value As String)
				Me.oo.oO0. = value
			End Set
		End Property

		' Token: 0x170005C1 RID: 1473
		' (get) Token: 0x060019D8 RID: 6616 RVA: 0x000A6CD2 File Offset: 0x000A4ED2
		' (set) Token: 0x060019D9 RID: 6617 RVA: 0x000A6CDA File Offset: 0x000A4EDA
		<oO0oooo("A0092")>
		Public Property AllowDelete As Boolean
			Get
				Return Me.Oo0o_._00_O.
			End Get
			Set(value As Boolean)
				Me.Oo0o_._00_O. = value
			End Set
		End Property

		' Token: 0x170005C2 RID: 1474
		' (get) Token: 0x060019DA RID: 6618 RVA: 0x000A6CE3 File Offset: 0x000A4EE3
		' (set) Token: 0x060019DB RID: 6619 RVA: 0x000A6CEB File Offset: 0x000A4EEB
		<oO0oooo("A0091")>
		Public Property AllowAdd As Boolean
			Get
				Return Me.o0.oO0O_oO__O_.
			End Get
			Set(value As Boolean)
				Me.o0.oO0O_oO__O_. = value
			End Set
		End Property

		' Token: 0x170005C3 RID: 1475
		' (get) Token: 0x060019DC RID: 6620 RVA: 0x000A6CF4 File Offset: 0x000A4EF4
		' (set) Token: 0x060019DD RID: 6621 RVA: 0x000A6CFC File Offset: 0x000A4EFC
		<oO0oooo("A0089")>
		Public Property TextPosition As Integer
			Get
				Return Me.OoOoo_o_.o_.
			End Get
			Set(value As Integer)
				Me.OoOoo_o_.o_. = value
			End Set
		End Property

		' Token: 0x170005C4 RID: 1476
		' (get) Token: 0x060019DE RID: 6622 RVA: 0x000A6D05 File Offset: 0x000A4F05
		' (set) Token: 0x060019DF RID: 6623 RVA: 0x000A6D0D File Offset: 0x000A4F0D
		<oO0oooo("A0106")>
		Public Property Incremental As Boolean
			Get
				Return Me.o0_.OO_00.
			End Get
			Set(value As Boolean)
				Me.o0_.OO_00. = value
			End Set
		End Property

		' Token: 0x170005C5 RID: 1477
		' (get) Token: 0x060019E0 RID: 6624 RVA: 0x000A6D16 File Offset: 0x000A4F16
		' (set) Token: 0x060019E1 RID: 6625 RVA: 0x000A6D1E File Offset: 0x000A4F1E
		<oO0oooo("A0251")>
		Public Property ScaleWidth As Integer
			Get
				Return Me.o_.o_o_O000_0_.
			End Get
			Set(value As Integer)
				Me.o_.o_o_O000_0_. = value
			End Set
		End Property

		' Token: 0x170005C6 RID: 1478
		' (get) Token: 0x060019E2 RID: 6626 RVA: 0x000A6D27 File Offset: 0x000A4F27
		' (set) Token: 0x060019E3 RID: 6627 RVA: 0x000A6D2F File Offset: 0x000A4F2F
		<oO0oooo("A0251")>
		Public Property ScaleHeight As Integer
			Get
				Return Me.oO_0oo.0oo__0_.
			End Get
			Set(value As Integer)
				Me.oO_0oo.0oo__0_. = value
			End Set
		End Property

		' Token: 0x170005C7 RID: 1479
		' (get) Token: 0x060019E4 RID: 6628 RVA: 0x000A6D38 File Offset: 0x000A4F38
		' (set) Token: 0x060019E5 RID: 6629 RVA: 0x000A6D40 File Offset: 0x000A4F40
		<oO0oooo("0257")>
		Public Property Rotate As Integer
			Get
				Return Me.o0_.OO_00.
			End Get
			Set(value As Integer)
				Me.o0_.OO_00. = value
			End Set
		End Property

		' Token: 0x170005C8 RID: 1480
		' (get) Token: 0x060019E6 RID: 6630 RVA: 0x000A6D49 File Offset: 0x000A4F49
		' (set) Token: 0x060019E7 RID: 6631 RVA: 0x000A6D51 File Offset: 0x000A4F51
		Public Property Capture As String
			Get
				Return Me.o0.oO0O_oO__O_.
			End Get
			Set(value As String)
				Me.o0.oO0O_oO__O_. = value
			End Set
		End Property

		' Token: 0x170005C9 RID: 1481
		' (get) Token: 0x060019E8 RID: 6632 RVA: 0x000A6D5A File Offset: 0x000A4F5A
		' (set) Token: 0x060019E9 RID: 6633 RVA: 0x000A6D62 File Offset: 0x000A4F62
		Public Property Accept As String
			Get
				Return Me.Oo0o_._00_O.
			End Get
			Set(value As String)
				Me.Oo0o_._00_O. = value
			End Set
		End Property

		' Token: 0x060019EA RID: 6634 RVA: 0x000A6D6C File Offset: 0x000A4F6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildHtml(sb As StringBuilder, wui As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			sb.AppendLine("  <div class='weui_cell'>")
			If Operators.CompareString(Me.oo.oO0., "", True) > 0 AndAlso Me.OoOoo_o_.o_. = 0 Then
				sb.AppendLine("<div class='weui_cell_hd'><label class='weui_label'>" + Me.oo.oO0. + "</label></div>")
			End If
			sb.AppendLine("<div class='weui_cell_bd weui_cell_primary'>")
			sb.AppendLine(" <div class='weui_uploader'>")
			If Operators.CompareString(Me.oo.oO0., "", True) > 0 AndAlso Me.OoOoo_o_.o_. = 1 Then
				sb.AppendLine("<div class='weui_uploader_hd weui_cell'>")
				If Me.oo.oO0..IndexOf(vbVerticalTab) = -1 Then
					sb.AppendLine("<div class='weui_cell_bd weui_cell_primary'>" + Me.oo.oO0. + "</div>")
				Else
					Dim array As String() = Me.oo.oO0..Split(New Char() { vbVerticalTab })
					sb.AppendLine("<div class='weui_cell_bd weui_cell_primary'>" + array(0) + "</div>")
					sb.AppendLine("<div class='weui_cell_ft'>" + array(1) + "</div>")
				End If
				sb.AppendLine("</div>")
			End If
			sb.AppendLine(" <div class='weui_uploader_bd'>")
			sb.AppendLine("<ul class='weui_uploader_files' id='" + MyBase.ID + "_thumbnails'>")
			If Me.oo.oO0..Count > 0 Then
				Try
					For Each text As String In Me.o_.o_o_O000_0_.
						sb.AppendLine(String.Concat(New String() { "<li data-gid='", MyBase.ID, "_gallery' data-image='", Me.oo.oO0.(text), "' class='weui_uploader_file' style='background-image:url(", text, ")'></li>" }))
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			sb.AppendLine("</ul>")
			If Me.o0.oO0O_oO__O_. Then
				sb.AppendLine("<div class='weui_uploader_input_wrp'>")
				sb.AppendLine("<div id='" + MyBase.ID + "_counter' class='fox_uploader_Counter'></div>")
				sb.AppendLine(String.Concat(New String() { "<input class='weui_uploader_input' type='file' id='", MyBase.ID, "' name='", MyBase.ID, "'", Interaction.IIf(Me.oo.oO0., " multiple ", "").ToString(), Interaction.IIf(Me.o0_.OO_00., " data-incremental", "").ToString(), Interaction.IIf(Operators.CompareString(Me.Oo0o_._00_O., "", True) > 0, " accept='" + Me.Oo0o_._00_O. + "'", "").ToString(), Interaction.IIf(Operators.CompareString(Me.o0.oO0O_oO__O_., "", True) > 0, " capture='" + Me.o0.oO0O_oO__O_. + "'", "").ToString(), Interaction.IIf(Me.o_.o_o_O000_0_. > 0, " data-scalewidth=" + Conversions.ToString(Me.o_.o_o_O000_0_.), "").ToString(), Interaction.IIf(Me.oO_0oo.0oo__0_. > 0, " data-scaleheight=" + Conversions.ToString(Me.oO_0oo.0oo__0_.), "").ToString(), Interaction.IIf(Me.o0_.OO_00. > 0, " data-rotate=" + Conversions.ToString(Me.o0_.OO_00.), "").ToString(), " />" }))
				sb.AppendLine("</div>")
			End If
			sb.AppendLine("</div>")
			sb.AppendLine("</div>")
			sb.AppendLine("</div>")
			sb.AppendLine("</div>")
			If Me.Oo0o_._00_O. AndAlso Me.oo.oO0..Count > 0 Then
				Dim text2 As String = MyBase.ID + "_deleted"
				sb.Append(String.Concat(New String() { "<input name='", text2, "' id='", text2, "' hidden>" }))
			End If
			Dim wGallery As wGallery = New wGallery("", MyBase.ID + "_gallery", False, True)
			wGallery.Delete = Me.Oo0o_._00_O.
			wGallery.OooO_o0o0O.0_. = MyBase.ID
			Try
				For Each text3 As String In Me.oo.oO0..Values
					wGallery.AddImage(New String() { text3 })
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, String).ValueCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			wui.O.oO_oO..Add(MyBase.ID + "_gallery", wGallery)
		End Sub

		' Token: 0x04000AD8 RID: 2776
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AD9 RID: 2777
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000ADA RID: 2778
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000ADB RID: 2779
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000ADC RID: 2780
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000ADD RID: 2781
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000ADE RID: 2782
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000ADF RID: 2783
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AE0 RID: 2784
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000AE1 RID: 2785
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AE2 RID: 2786
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AE3 RID: 2787
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000AE4 RID: 2788
		Public <<EMPTY_NAME>> As String

		' Token: 0x04000AE5 RID: 2789
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
