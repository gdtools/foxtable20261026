Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020003B8 RID: 952
	<ComVisible(True)>
	Public Class TabPage
		Inherits C1DockingTabPage

		' Token: 0x06003D07 RID: 15623 RVA: 0x001AADF0 File Offset: 0x001A8FF0
		Public Sub New()
			AddHandler MyBase.GotFocus, AddressOf Me.TabPage_GotFocus
		End Sub

		' Token: 0x17000D59 RID: 3417
		' (get) Token: 0x06003D08 RID: 15624 RVA: 0x001AAE0A File Offset: 0x001A900A
		' (set) Token: 0x06003D09 RID: 15625 RVA: 0x001AAE12 File Offset: 0x001A9012
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ImageFile As String
			Get
				Return Me.OooO.OO0O_.
			End Get
			Set(value As String)
				Me.OooO.OO0O_. = value
				If Operators.CompareString(value, "", True) > 0 Then
					MyBase.Image = OO_00oOO.GetImage(value)
					Return
				End If
				MyBase.Image = Nothing
			End Set
		End Property

		' Token: 0x17000D5A RID: 3418
		' (get) Token: 0x06003D0A RID: 15626 RVA: 0x001AAE3E File Offset: 0x001A903E
		' (set) Token: 0x06003D0B RID: 15627 RVA: 0x001AAE46 File Offset: 0x001A9046
		Public Property Visible As Boolean
			Get
				Return MyBase.TabVisible
			End Get
			Set(value As Boolean)
				MyBase.TabVisible = value
			End Set
		End Property

		' Token: 0x06003D0C RID: 15628 RVA: 0x001AAE4F File Offset: 0x001A904F
		Private Sub TabPage_GotFocus(sender As Object, e As EventArgs)
			MyBase.SelectNextControl(Me, True, True, True, True)
		End Sub

		' Token: 0x06003D0D RID: 15629 RVA: 0x001AAE60 File Offset: 0x001A9060
		<oO0oooo("1912")>
		Public Sub AddControl(Control As Control)
			MyBase.Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x06003D0E RID: 15630 RVA: 0x001AAEBC File Offset: 0x001A90BC
		<oO0oooo("1912")>
		Public Sub RemoveControl(Name As String)
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, Name, True) = 0 Then
						oOO0oo_o0.O00OO_O_oO_.o.(MyBase.Controls, control)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me)
		End Sub

		' Token: 0x06003D0F RID: 15631 RVA: 0x001AAF34 File Offset: 0x001A9134
		Public Sub ClearControl()
			For i As Integer = MyBase.Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = MyBase.Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(MyBase.Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me)
		End Sub

		' Token: 0x17000D5B RID: 3419
		' (get) Token: 0x06003D10 RID: 15632 RVA: 0x001AAF78 File Offset: 0x001A9178
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me)
			End Get
		End Property

		' Token: 0x04001903 RID: 6403
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
