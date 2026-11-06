Imports System
Imports System.Runtime.InteropServices

Namespace Foxtable.WinForm
	' Token: 0x020004EC RID: 1260
	<ComVisible(True)>
	Public Class WebViewer
		Inherits Control

		' Token: 0x060050D6 RID: 20694 RVA: 0x00219091 File Offset: 0x00217291
		Friend Sub New(A_0 As WebViewer)
			MyBase.New(A_0, ControlTypeEnum.WebViewer)
			Me.O_ooo.0. = A_0
		End Sub

		' Token: 0x17001257 RID: 4695
		' (get) Token: 0x060050D7 RID: 20695 RVA: 0x002190A3 File Offset: 0x002172A3
		Public ReadOnly Property WebViewer As WebViewer
			Get
				Return Me.O_ooo.0.
			End Get
		End Property

		' Token: 0x17001258 RID: 4696
		' (get) Token: 0x060050D8 RID: 20696 RVA: 0x002190AB File Offset: 0x002172AB
		' (set) Token: 0x060050D9 RID: 20697 RVA: 0x002190B8 File Offset: 0x002172B8
		Public Property AreDevToolsEnabled As Boolean
			Get
				Return Me.O_ooo.0..AreDevToolsEnabled
			End Get
			Set(value As Boolean)
				Me.O_ooo.0..AreDevToolsEnabled = value
			End Set
		End Property

		' Token: 0x17001259 RID: 4697
		' (get) Token: 0x060050DA RID: 20698 RVA: 0x002190C6 File Offset: 0x002172C6
		' (set) Token: 0x060050DB RID: 20699 RVA: 0x002190D3 File Offset: 0x002172D3
		Public Property AreSaveAsEnabled As Boolean
			Get
				Return Me.O_ooo.0..AreSaveAsEnabled
			End Get
			Set(value As Boolean)
				Me.O_ooo.0..AreSaveAsEnabled = value
			End Set
		End Property

		' Token: 0x1700125A RID: 4698
		' (get) Token: 0x060050DC RID: 20700 RVA: 0x002190E1 File Offset: 0x002172E1
		' (set) Token: 0x060050DD RID: 20701 RVA: 0x002190EE File Offset: 0x002172EE
		Public Property AreDefaultContextMenusEnabled As Boolean
			Get
				Return Me.O_ooo.0..AreDefaultContextMenusEnabled
			End Get
			Set(value As Boolean)
				Me.O_ooo.0..AreDefaultContextMenusEnabled = value
			End Set
		End Property

		' Token: 0x1700125B RID: 4699
		' (get) Token: 0x060050DE RID: 20702 RVA: 0x002190FC File Offset: 0x002172FC
		' (set) Token: 0x060050DF RID: 20703 RVA: 0x00219109 File Offset: 0x00217309
		Public Property AreBrowserAcceleratorKeysEnabled As Boolean
			Get
				Return Me.O_ooo.0..AreBrowserAcceleratorKeysEnabled
			End Get
			Set(value As Boolean)
				Me.O_ooo.0..AreBrowserAcceleratorKeysEnabled = value
			End Set
		End Property

		' Token: 0x040021A9 RID: 8617
		Private <<EMPTY_NAME>> As WebViewer
	End Class
End Namespace
