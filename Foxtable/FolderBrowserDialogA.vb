Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports O0o0.00

Namespace Foxtable
	' Token: 0x02000101 RID: 257
	Public Class FolderBrowserDialogA
		' Token: 0x06000D90 RID: 3472 RVA: 0x0005F7C7 File Offset: 0x0005D9C7
		Public Sub New()
			Me.Oo000o.O_OOO. = New FolderBrowserDialog()
		End Sub

		' Token: 0x06000D91 RID: 3473 RVA: 0x0005F7DC File Offset: 0x0005D9DC
		Public Function ShowDialog() As Task(Of DialogResult)
			Dim o_OOO As FolderBrowserDialogA.O_OOO0 = Nothing
			o_OOO.oO_O__OO.___O. = Me
			o_OOO.oO_O__OO.___O. = -1
			o_OOO.oO_O__OO.___O. = AsyncTaskMethodBuilder(Of DialogResult).Create()
			o_OOO.oO_O__OO.___O..Start(Of FolderBrowserDialogA.O_OOO0)(o_OOO)
			Return o_OOO.oO_O__OO.___O..Task
		End Function

		' Token: 0x1700024F RID: 591
		' (get) Token: 0x06000D92 RID: 3474 RVA: 0x0005F827 File Offset: 0x0005DA27
		' (set) Token: 0x06000D93 RID: 3475 RVA: 0x0005F834 File Offset: 0x0005DA34
		Public Property Description As String
			Get
				Return Me.Oo000o.O_OOO..Description
			End Get
			Set(value As String)
				Me.Oo000o.O_OOO..Description = value
			End Set
		End Property

		' Token: 0x17000250 RID: 592
		' (get) Token: 0x06000D94 RID: 3476 RVA: 0x0005F842 File Offset: 0x0005DA42
		' (set) Token: 0x06000D95 RID: 3477 RVA: 0x0005F84F File Offset: 0x0005DA4F
		Public Property SelectedPath As String
			Get
				Return Me.Oo000o.O_OOO..SelectedPath
			End Get
			Set(value As String)
				Me.Oo000o.O_OOO..SelectedPath = value
			End Set
		End Property

		' Token: 0x17000251 RID: 593
		' (get) Token: 0x06000D96 RID: 3478 RVA: 0x0005F85D File Offset: 0x0005DA5D
		' (set) Token: 0x06000D97 RID: 3479 RVA: 0x0005F86A File Offset: 0x0005DA6A
		Public Property ShowNewFolderButton As Boolean
			Get
				Return Me.Oo000o.O_OOO..ShowNewFolderButton
			End Get
			Set(value As Boolean)
				Me.Oo000o.O_OOO..ShowNewFolderButton = value
			End Set
		End Property

		' Token: 0x06000D98 RID: 3480 RVA: 0x0005F878 File Offset: 0x0005DA78
		<CompilerGenerated()>
		Private Function <<EMPTY_NAME>>() As DialogResult
			Dim oo0Oo_oO0o As FolderBrowserDialogA.OO0Oo_oO0o = New FolderBrowserDialogA.OO0Oo_oO0o()
			oo0Oo_oO0o.Oo000o.O_OOO. = Me
			oo0Oo_oO0o.Oo000o.O_OOO. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oo0Oo_oO0o.Oo000o.O_OOO.)
			End If
			Return oo0Oo_oO0o.Oo000o.O_OOO.
		End Function

		' Token: 0x0400052F RID: 1327
		Private <<EMPTY_NAME>> As FolderBrowserDialog

		' Token: 0x02000102 RID: 258
		<CompilerGenerated()>
		Friend NotInheritable Class OO0Oo_oO0o
			' Token: 0x06000D9A RID: 3482 RVA: 0x0005F8C5 File Offset: 0x0005DAC5
			Friend Sub <<EMPTY_NAME>>()
				Me.Oo000o.O_OOO. = Me.Oo000o.O_OOO..Oo000o.O_OOO..ShowDialog()
			End Sub

			' Token: 0x04000530 RID: 1328
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000531 RID: 1329
			Public <<EMPTY_NAME>> As FolderBrowserDialogA
		End Class
	End Class
End Namespace
