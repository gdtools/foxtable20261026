Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x0200016E RID: 366
	<oO0oooo("3119")>
	<ComVisible(True)>
	Public Class Strip
		' Token: 0x06001115 RID: 4373 RVA: 0x0006B04C File Offset: 0x0006924C
		Friend Sub New(A_0 As ToolStrip, A_1 As Form)
			Me.oO.ooo. = A_0
			Me.oO.ooo. = A_1
			Me.oO.ooo. = New StripItemCollection(A_0.Items, Me.oO.ooo.)
		End Sub

		' Token: 0x17000390 RID: 912
		' (get) Token: 0x06001116 RID: 4374 RVA: 0x0006B079 File Offset: 0x00069279
		Public ReadOnly Property Name As String
			Get
				Return Me.oO.ooo..Name
			End Get
		End Property

		' Token: 0x17000391 RID: 913
		' (get) Token: 0x06001117 RID: 4375 RVA: 0x0006B086 File Offset: 0x00069286
		' (set) Token: 0x06001118 RID: 4376 RVA: 0x0006B093 File Offset: 0x00069293
		Public Property Visible As Boolean
			Get
				Return Me.oO.ooo..Visible
			End Get
			Set(value As Boolean)
				Me.oO.ooo..Visible = value
			End Set
		End Property

		' Token: 0x17000392 RID: 914
		' (get) Token: 0x06001119 RID: 4377 RVA: 0x0006B0A1 File Offset: 0x000692A1
		' (set) Token: 0x0600111A RID: 4378 RVA: 0x0006B0AE File Offset: 0x000692AE
		Public Property Enabled As Boolean
			Get
				Return Me.oO.ooo..Enabled
			End Get
			Set(value As Boolean)
				Me.oO.ooo..Enabled = value
			End Set
		End Property

		' Token: 0x17000393 RID: 915
		' (get) Token: 0x0600111B RID: 4379 RVA: 0x0006B0BC File Offset: 0x000692BC
		Public ReadOnly Property Items As StripItemCollection
			Get
				Return Me.oO.ooo.
			End Get
		End Property

		' Token: 0x0600111C RID: 4380 RVA: 0x0006B0C4 File Offset: 0x000692C4
		Public Sub StopRedraw()
			Me.oO.ooo..SuspendLayout()
		End Sub

		' Token: 0x0600111D RID: 4381 RVA: 0x0006B0D1 File Offset: 0x000692D1
		Public Sub ResumeRedraw()
			Me.oO.ooo..ResumeLayout()
		End Sub

		' Token: 0x17000394 RID: 916
		' (get) Token: 0x0600111E RID: 4382 RVA: 0x0006B0DE File Offset: 0x000692DE
		Public ReadOnly Property BaseControl As Object
			Get
				Return Me.oO.ooo.
			End Get
		End Property

		' Token: 0x0600111F RID: 4383 RVA: 0x0006B0E6 File Offset: 0x000692E6
		Public Sub Show()
			If TypeOf Me.BaseControl Is ContextMenuStrip Then
				CType(Me.BaseControl, ContextMenuStrip).Show(Cursor.Position)
			End If
		End Sub

		' Token: 0x06001120 RID: 4384 RVA: 0x0006B10C File Offset: 0x0006930C
		Public Sub Close()
			If TypeOf Me.oO.ooo. Is ContextMenuStrip Then
				CType(Me.oO.ooo., ContextMenuStrip).Close()
			End If
		End Sub

		' Token: 0x17000395 RID: 917
		' (get) Token: 0x06001121 RID: 4385 RVA: 0x0006B12B File Offset: 0x0006932B
		' (set) Token: 0x06001122 RID: 4386 RVA: 0x0006B13D File Offset: 0x0006933D
		<oO0oooo("3305")>
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.oO.ooo.)
			End Get
			Set(value As String)
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.oO.ooo. })
			End Set
		End Property

		' Token: 0x0400067A RID: 1658
		Private <<EMPTY_NAME>> As ToolStrip

		' Token: 0x0400067B RID: 1659
		Private <<EMPTY_NAME>> As StripItemCollection

		' Token: 0x0400067C RID: 1660
		Friend <<EMPTY_NAME>> As Form
	End Class
End Namespace
