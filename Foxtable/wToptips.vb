Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000228 RID: 552
	<oO0oooo("A0083")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wToptips
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060019A3 RID: 6563 RVA: 0x000A5C17 File Offset: 0x000A3E17
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.o0_._00. = A_2
		End Sub

		' Token: 0x170005BA RID: 1466
		' (get) Token: 0x060019A4 RID: 6564 RVA: 0x000A5C28 File Offset: 0x000A3E28
		' (set) Token: 0x060019A5 RID: 6565 RVA: 0x000A5C30 File Offset: 0x000A3E30
		Public Property msec As Integer
			Get
				Return Me.o00O_OO.O.
			End Get
			Set(value As Integer)
				Me.o00O_OO.O. = value
			End Set
		End Property

		' Token: 0x170005BB RID: 1467
		' (get) Token: 0x060019A6 RID: 6566 RVA: 0x000A5C39 File Offset: 0x000A3E39
		Private ReadOnly Property baseClass As String
			Get
				Return "weui_toptips weui_warn fox_toptips"
			End Get
		End Property

		' Token: 0x060019A7 RID: 6567 RVA: 0x000A5C40 File Offset: 0x000A3E40
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String = "<div"
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = text + " class='" + Me.baseClass + "'"
			Else
				text = String.Concat(New String() { text, " class='", Me.baseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " name='", MyBase.ID, "' id='", MyBase.ID, "'style='display:none'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text = text + ">" + Me.o0_._00. + "</div>"
			A_0.AppendLine(text)
			If Me.msec > 0 Then
				A_1.Scripts.Add(String.Concat(New String() { "show('", MyBase.ID, "',", Conversions.ToString(Me.msec), ");" }))
			End If
		End Sub

		' Token: 0x04000ACD RID: 2765
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000ACE RID: 2766
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
