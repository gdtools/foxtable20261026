Imports System
Imports System.Collections
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000514 RID: 1300
	<ComVisible(True)>
	Public Class GroupBox
		Inherits Control

		' Token: 0x06005511 RID: 21777 RVA: 0x002205EE File Offset: 0x0021E7EE
		Public Sub New(A_0 As GroupBox)
			MyBase.New(A_0, ControlTypeEnum.GroupBox)
			Me.o0_0oO.OooO. = A_0
		End Sub

		' Token: 0x1700144C RID: 5196
		' (get) Token: 0x06005512 RID: 21778 RVA: 0x00220600 File Offset: 0x0021E800
		' (set) Token: 0x06005513 RID: 21779 RVA: 0x0022060D File Offset: 0x0021E80D
		Public Property Text As String
			Get
				Return Me.o0_0oO.OooO..Text
			End Get
			Set(value As String)
				Me.o0_0oO.OooO..Text = value
			End Set
		End Property

		' Token: 0x06005514 RID: 21780 RVA: 0x0022061C File Offset: 0x0021E81C
		<oO0oooo("1912")>
		Public Sub AddControl(Control As Control)
			Me.o0_0oO.OooO..Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x06005515 RID: 21781 RVA: 0x00220680 File Offset: 0x0021E880
		<oO0oooo("1912")>
		Public Sub RemoveControl(Name As String)
			Try
				For Each obj As Object In Me.o0_0oO.OooO..Controls
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, Name, True) = 0 Then
						oOO0oo_o0.O00OO_O_oO_.o.(Me.o0_0oO.OooO..Controls, control)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.o0_0oO.OooO.)
		End Sub

		' Token: 0x06005516 RID: 21782 RVA: 0x00220708 File Offset: 0x0021E908
		Public Sub ClearControl()
			For i As Integer = Me.o0_0oO.OooO..Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = Me.o0_0oO.OooO..Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(Me.o0_0oO.OooO..Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.o0_0oO.OooO.)
		End Sub

		' Token: 0x1700144D RID: 5197
		' (get) Token: 0x06005517 RID: 21783 RVA: 0x00220760 File Offset: 0x0021E960
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me.o0_0oO.OooO.)
			End Get
		End Property

		' Token: 0x04002203 RID: 8707
		Private <<EMPTY_NAME>> As GroupBox
	End Class
End Namespace
