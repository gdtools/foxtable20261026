Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports C1.Win.C1Ribbon
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.RibbonMenu
	' Token: 0x02000014 RID: 20
	<ComVisible(True)>
	Public Class SplitButton
		Inherits RibbonItem

		' Token: 0x06000090 RID: 144 RVA: 0x00002D99 File Offset: 0x00000F99
		Friend Sub New(A_0 As RibbonSplitButton)
			MyBase.New(A_0)
			Me.OO0.0OOo__. = A_0
		End Sub

		' Token: 0x06000091 RID: 145 RVA: 0x00002DA9 File Offset: 0x00000FA9
		Public Sub New(A_0 As String)
			Me.OO0.0OOo__. = New RibbonSplitButton()
			Me.oOo_.0o_O_O_0. = Me.OO0.0OOo__.
			Me.OO0.0OOo__..ID = A_0
		End Sub

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x06000092 RID: 146 RVA: 0x00002DD4 File Offset: 0x00000FD4
		' (set) Token: 0x06000093 RID: 147 RVA: 0x00002DE1 File Offset: 0x00000FE1
		Public Property Text As String
			Get
				Return Me.OO0.0OOo__..Text
			End Get
			Set(value As String)
				Me.OO0.0OOo__..Text = value
			End Set
		End Property

		' Token: 0x1700003E RID: 62
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Object
			Get
				Return Me.Items(Name)
			End Get
		End Property

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x06000095 RID: 149 RVA: 0x00002DFD File Offset: 0x00000FFD
		Public ReadOnly Property Items As RibbonItemCollection
			Get
				If Me.OO0.0OOo__. Is Nothing Then
					Me.OO0.0OOo__. = New RibbonItemCollection(Me.OO0.0OOo__..Items)
				End If
				Return Me.OO0.0OOo__.
			End Get
		End Property

		' Token: 0x06000096 RID: 150 RVA: 0x00002E24 File Offset: 0x00001024
		Public Sub PerformClick()
			Dim splitButton As SplitButton = New SplitButton(Me.OO0.0OOo__.)
			Dim ribbonSplitButtonEventArgs As RibbonSplitButtonEventArgs = New RibbonSplitButtonEventArgs(splitButton)
			Dim a_ As String = "Click_" + Conversions.ToString(splitButton.OO0.0OOo__..Tag)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { ribbonSplitButtonEventArgs }, False, "菜单" + splitButton.Name, False)
		End Sub

		' Token: 0x04000019 RID: 25
		Friend <<EMPTY_NAME>> As RibbonSplitButton

		' Token: 0x0400001A RID: 26
		Private <<EMPTY_NAME>> As RibbonItemCollection
	End Class
End Namespace
