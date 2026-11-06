Imports System
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000203 RID: 515
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0008")>
	Public Class wButton
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600186B RID: 6251 RVA: 0x0009F8BC File Offset: 0x0009DABC
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.o.oOo_oo0__O0_. = True
			Me.OOOO.__O__Oo. = A_2
		End Sub

		' Token: 0x0600186C RID: 6252 RVA: 0x0009F8D4 File Offset: 0x0009DAD4
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String)
			MyBase.New(A_0, A_1)
			Me.o.oOo_oo0__O0_. = True
			Me.OOOO.__O__Oo. = A_2
			Me.o_oOO_o._oOO. = A_3
		End Sub

		' Token: 0x0600186D RID: 6253 RVA: 0x0009F8F4 File Offset: 0x0009DAF4
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String)
			MyBase.New(A_0, A_1)
			Me.o.oOo_oo0__O0_. = True
			Me.OOOO.__O__Oo. = A_2
			Me.o_oOO_o._oOO. = A_3
			Me.o.oOo_oo0__O0_. = A_4
		End Sub

		' Token: 0x17000559 RID: 1369
		' (get) Token: 0x0600186E RID: 6254 RVA: 0x0009F91C File Offset: 0x0009DB1C
		Private ReadOnly Property TagName As String
			Get
				Dim result As String
				If Operators.CompareString(Me.o.oOo_oo0__O0_., "", True) > 0 OrElse Me.o_oOO_o._oOO. Then
					result = "a"
				Else
					result = "button"
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700055A RID: 1370
		' (get) Token: 0x0600186F RID: 6255 RVA: 0x0009F954 File Offset: 0x0009DB54
		' (set) Token: 0x06001870 RID: 6256 RVA: 0x0009F95C File Offset: 0x0009DB5C
		Public Property Enabled As Boolean
			Get
				Return Me.o.oOo_oo0__O0_.
			End Get
			Set(value As Boolean)
				Me.o.oOo_oo0__O0_. = value
			End Set
		End Property

		' Token: 0x1700055B RID: 1371
		' (get) Token: 0x06001871 RID: 6257 RVA: 0x0009F965 File Offset: 0x0009DB65
		' (set) Token: 0x06001872 RID: 6258 RVA: 0x0009F96D File Offset: 0x0009DB6D
		<oO0oooo("A0008")>
		Public Property Kind As Integer
			Get
				Return Me.o.oOo_oo0__O0_.
			End Get
			Set(value As Integer)
				Me.o.oOo_oo0__O0_. = value
			End Set
		End Property

		' Token: 0x1700055C RID: 1372
		' (get) Token: 0x06001873 RID: 6259 RVA: 0x0009F976 File Offset: 0x0009DB76
		' (set) Token: 0x06001874 RID: 6260 RVA: 0x0009F97E File Offset: 0x0009DB7E
		Public Property Mini As Boolean
			Get
				Return Me.OOOO.__O__Oo.
			End Get
			Set(value As Boolean)
				Me.OOOO.__O__Oo. = value
			End Set
		End Property

		' Token: 0x1700055D RID: 1373
		' (get) Token: 0x06001875 RID: 6261 RVA: 0x0009F987 File Offset: 0x0009DB87
		' (set) Token: 0x06001876 RID: 6262 RVA: 0x0009F98F File Offset: 0x0009DB8F
		<oO0oooo("A0122")>
		Public Property Value As String
			Get
				Return Me.o_0O.0OO__Oo.
			End Get
			Set(value As String)
				Me.o_0O.0OO__Oo. = value
			End Set
		End Property

		' Token: 0x1700055E RID: 1374
		' (get) Token: 0x06001877 RID: 6263 RVA: 0x0009F998 File Offset: 0x0009DB98
		' (set) Token: 0x06001878 RID: 6264 RVA: 0x0009F9A0 File Offset: 0x0009DBA0
		<oO0oooo("A0122")>
		Public Property FormAction As String
			Get
				Return Me.o0_oo0oO_0._00.
			End Get
			Set(value As String)
				Me.o0_oo0oO_0._00. = value
			End Set
		End Property

		' Token: 0x1700055F RID: 1375
		' (get) Token: 0x06001879 RID: 6265 RVA: 0x0009F9AC File Offset: 0x0009DBAC
		Public ReadOnly Property baseClass As String
			Get
				Dim text As String = Interaction.IIf(Me.o_oOO_o._oOO., "weui_btn_dialog", "weui_btn").ToString()
				If Not Me.Enabled Then
					text += "  weui_btn_disabled"
				End If
				Select Case Me.Kind
					Case 0
						If Me.o_oOO_o._oOO. Then
							text += " primary"
						Else
							text += " weui_btn_primary"
						End If
					Case 1
						If Me.o_oOO_o._oOO. Then
							text += " default"
						Else
							text += " weui_btn_default"
						End If
					Case 2
						text += " weui_btn_warn"
				End Select
				If Me.Mini Then
					text += " weui_btn_mini"
				End If
				Return text
			End Get
		End Property

		' Token: 0x0600187A RID: 6266 RVA: 0x0009FA6C File Offset: 0x0009DC6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append(String.Concat(New String() { "<", Me.TagName, " id='", MyBase.ID, "' name='", MyBase.ID, "'" }))
			If Operators.CompareString(Me.o_oOO_o._oOO., "", True) > 0 Then
				A_0.Append(" type='" + Me.o_oOO_o._oOO. + "'")
			End If
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(String.Concat(New String() { " class='", Me.baseClass, " ", MyBase.[Class], "'" }))
			Else
				A_0.Append(" class='" + Me.baseClass + "'")
			End If
			If Operators.CompareString(Me.o.oOo_oo0__O0_., "", True) > 0 OrElse Me.o_oOO_o._oOO. Then
				If Operators.CompareString(Me.o.oOo_oo0__O0_., "", True) = 0 Then
					Me.o.oOo_oo0__O0_. = "javascript:;"
				End If
				A_0.Append(" href='" + Me.o.oOo_oo0__O0_. + "'")
			End If
			If Operators.CompareString(Me.o_0O.0OO__Oo., "", True) > 0 Then
				A_0.Append(" value='" + Me.o_0O.0OO__Oo. + "'")
			End If
			If Operators.CompareString(Me.o0_oo0oO_0._00., "", True) > 0 Then
				A_0.Append(" formaction='" + Me.o0_oo0oO_0._00. + "'")
			End If
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.Append(">")
			A_0.Append(Me.OOOO.__O__Oo.)
			A_0.AppendLine("</" + Me.TagName + ">")
		End Sub

		' Token: 0x04000A3B RID: 2619
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A3C RID: 2620
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000A3D RID: 2621
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A3E RID: 2622
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A3F RID: 2623
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A40 RID: 2624
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A41 RID: 2625
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A42 RID: 2626
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A43 RID: 2627
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
