Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000009 RID: 9
	<ComVisible(True)>
	Public Class Button
		Inherits RibbonItem

		' Token: 0x06000033 RID: 51 RVA: 0x000026B6 File Offset: 0x000008B6
		Friend Sub New(A_0 As RibbonButton)
			MyBase.New(A_0)
			Me.oOoOoOoO._o0. = A_0
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x000026C6 File Offset: 0x000008C6
		Public Sub New(A_0 As String)
			Me.oOoOoOoO._o0. = New RibbonButton()
			Me.oOo_.0o_O_O_0. = Me.oOoOoOoO._o0.
			Me.oOoOoOoO._o0..ID = A_0
		End Sub

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x06000035 RID: 53 RVA: 0x000026F1 File Offset: 0x000008F1
		' (set) Token: 0x06000036 RID: 54 RVA: 0x000026FE File Offset: 0x000008FE
		Public Property Text As String
			Get
				Return Me.oOoOoOoO._o0..Text
			End Get
			Set(value As String)
				Me.oOoOoOoO._o0..Text = value
			End Set
		End Property

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000037 RID: 55 RVA: 0x0000270C File Offset: 0x0000090C
		' (set) Token: 0x06000038 RID: 56 RVA: 0x00002719 File Offset: 0x00000919
		Public Property ShortcutKeys As Keys
			Get
				Return Me.oOoOoOoO._o0..ShortcutKeys
			End Get
			Set(value As Keys)
				Me.oOoOoOoO._o0..ShortcutKeys = value
			End Set
		End Property

		' Token: 0x06000039 RID: 57 RVA: 0x00002728 File Offset: 0x00000928
		<oO0oooo("1103")>
		Public Sub PerformClick()
			Dim button As Button = New Button(Me.oOoOoOoO._o0.)
			Dim ribbonButtonEventArgs As RibbonButtonEventArgs = New RibbonButtonEventArgs(button)
			Dim a_ As String = "Click_" + Conversions.ToString(button.oOoOoOoO._o0..Tag)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { ribbonButtonEventArgs }, False, "菜单," + button.Name, False)
		End Sub

		' Token: 0x0400000F RID: 15
		Friend <<EMPTY_NAME>> As RibbonButton
	End Class
End Namespace
