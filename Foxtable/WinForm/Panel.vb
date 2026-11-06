Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200051B RID: 1307
	<ComVisible(True)>
	Public Class Panel
		Inherits Control

		' Token: 0x0600559C RID: 21916 RVA: 0x0022175E File Offset: 0x0021F95E
		Public Sub New(A_0 As Panel)
			MyBase.New(A_0, ControlTypeEnum.Panel)
			Me.o.oO_oo_O. = A_0
		End Sub

		' Token: 0x1700148C RID: 5260
		' (get) Token: 0x0600559D RID: 21917 RVA: 0x00221770 File Offset: 0x0021F970
		' (set) Token: 0x0600559E RID: 21918 RVA: 0x0022177D File Offset: 0x0021F97D
		<oO0oooo("1915")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.oO_oo_O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.oO_oo_O..BorderStyle = value
			End Set
		End Property

		' Token: 0x1700148D RID: 5261
		' (get) Token: 0x0600559F RID: 21919 RVA: 0x0022178B File Offset: 0x0021F98B
		' (set) Token: 0x060055A0 RID: 21920 RVA: 0x00221798 File Offset: 0x0021F998
		Public Property AutoScroll As Boolean
			Get
				Return Me.o.oO_oo_O..AutoScroll
			End Get
			Set(value As Boolean)
				Me.o.oO_oo_O..AutoScroll = value
			End Set
		End Property

		' Token: 0x1700148E RID: 5262
		' (get) Token: 0x060055A1 RID: 21921 RVA: 0x002217A6 File Offset: 0x0021F9A6
		' (set) Token: 0x060055A2 RID: 21922 RVA: 0x002217B3 File Offset: 0x0021F9B3
		<oO0oooo("2398")>
		Public Property ScrollPosition As Point
			Get
				Return Me.o.oO_oo_O..AutoScrollPosition
			End Get
			Set(value As Point)
				Me.o.oO_oo_O..AutoScrollPosition = value
			End Set
		End Property

		' Token: 0x1700148F RID: 5263
		' (get) Token: 0x060055A3 RID: 21923 RVA: 0x002217C1 File Offset: 0x0021F9C1
		' (set) Token: 0x060055A4 RID: 21924 RVA: 0x002217CE File Offset: 0x0021F9CE
		<oO0oooo("0811")>
		Public Property ExtendSize As Size
			Get
				Return Me.o.oO_oo_O..AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.o.oO_oo_O..AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x060055A5 RID: 21925 RVA: 0x002217DC File Offset: 0x0021F9DC
		<oO0oooo("1912")>
		Public Sub AddControl(Control As Control)
			Me.o.oO_oo_O..Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x060055A6 RID: 21926 RVA: 0x00221840 File Offset: 0x0021FA40
		<oO0oooo("1912")>
		Public Sub RemoveControl(Name As String)
			Try
				For Each obj As Object In Me.o.oO_oo_O..Controls
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, Name, True) = 0 Then
						oOO0oo_o0.O00OO_O_oO_.o.(Me.o.oO_oo_O..Controls, control)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.o.oO_oo_O.)
		End Sub

		' Token: 0x060055A7 RID: 21927 RVA: 0x002218C8 File Offset: 0x0021FAC8
		Public Sub ClearControl()
			For i As Integer = Me.o.oO_oo_O..Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = Me.o.oO_oo_O..Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(Me.o.oO_oo_O..Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.o.oO_oo_O.)
		End Sub

		' Token: 0x17001490 RID: 5264
		' (get) Token: 0x060055A8 RID: 21928 RVA: 0x00221920 File Offset: 0x0021FB20
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me.o.oO_oo_O.)
			End Get
		End Property

		' Token: 0x0400220C RID: 8716
		Private <<EMPTY_NAME>> As Panel
	End Class
End Namespace
