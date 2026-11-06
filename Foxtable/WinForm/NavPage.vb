Imports System
Imports System.Collections
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020003B5 RID: 949
	<oO0oooo("0877")>
	<ComVisible(True)>
	Public Class NavPage
		Inherits C1NavBarPanel

		' Token: 0x17000D50 RID: 3408
		' (get) Token: 0x06003CE6 RID: 15590 RVA: 0x001AA99C File Offset: 0x001A8B9C
		' (set) Token: 0x06003CE7 RID: 15591 RVA: 0x001AA9A9 File Offset: 0x001A8BA9
		<oO0oooo("0880")>
		Public Property HeaderText As String
			Get
				Return MyBase.Button.PanelHeader
			End Get
			Set(value As String)
				MyBase.Button.PanelHeader = value
			End Set
		End Property

		' Token: 0x17000D51 RID: 3409
		' (get) Token: 0x06003CE8 RID: 15592 RVA: 0x001AA9B7 File Offset: 0x001A8BB7
		' (set) Token: 0x06003CE9 RID: 15593 RVA: 0x001AA9C4 File Offset: 0x001A8BC4
		Public Property ButtonText As String
			Get
				Return MyBase.Button.Text
			End Get
			Set(value As String)
				MyBase.Button.Text = value
			End Set
		End Property

		' Token: 0x17000D52 RID: 3410
		' (get) Token: 0x06003CEA RID: 15594 RVA: 0x001AA9D2 File Offset: 0x001A8BD2
		' (set) Token: 0x06003CEB RID: 15595 RVA: 0x001AA9DA File Offset: 0x001A8BDA
		<oO0oooo("0881")>
		Public Property ButtonImageFile As String
			Get
				Return Me.o.oO_oo_O.
			End Get
			Set(value As String)
				Me.o.oO_oo_O. = value
				MyBase.Button.Image = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x17000D53 RID: 3411
		' (get) Token: 0x06003CEC RID: 15596 RVA: 0x001AA9F4 File Offset: 0x001A8BF4
		' (set) Token: 0x06003CED RID: 15597 RVA: 0x001AA9FC File Offset: 0x001A8BFC
		Public Property ButtonSmallImageFile As String
			Get
				Return Me.o._o0o___O0ooO.
			End Get
			Set(value As String)
				Me.o._o0o___O0ooO. = value
				MyBase.Button.SmallImage = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x17000D54 RID: 3412
		' (get) Token: 0x06003CEE RID: 15598 RVA: 0x001AAA16 File Offset: 0x001A8C16
		' (set) Token: 0x06003CEF RID: 15599 RVA: 0x001AAA1E File Offset: 0x001A8C1E
		Public Property Visible As Boolean
			Get
				Return MyBase.PanelVisible
			End Get
			Set(value As Boolean)
				MyBase.PanelVisible = value
			End Set
		End Property

		' Token: 0x06003CF0 RID: 15600 RVA: 0x001AAA28 File Offset: 0x001A8C28
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

		' Token: 0x06003CF1 RID: 15601 RVA: 0x001AAA84 File Offset: 0x001A8C84
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

		' Token: 0x06003CF2 RID: 15602 RVA: 0x001AAAFC File Offset: 0x001A8CFC
		Public Sub ClearControl()
			For i As Integer = MyBase.Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = MyBase.Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(MyBase.Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me)
		End Sub

		' Token: 0x17000D55 RID: 3413
		' (get) Token: 0x06003CF3 RID: 15603 RVA: 0x001AAB40 File Offset: 0x001A8D40
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me)
			End Get
		End Property

		' Token: 0x040018FD RID: 6397
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018FE RID: 6398
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
