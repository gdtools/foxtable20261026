Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports O0o0.00

Namespace Foxtable
	' Token: 0x0200011B RID: 283
	Public Class SaveFileDialogA
		' Token: 0x06000E11 RID: 3601 RVA: 0x00060E7E File Offset: 0x0005F07E
		Public Sub New()
			Me.o0o_oO_OOoO.0O. = New SaveFileDialog()
		End Sub

		' Token: 0x06000E12 RID: 3602 RVA: 0x00060E94 File Offset: 0x0005F094
		Public Function ShowDialog() As Task(Of DialogResult)
			Dim o_0OOO As SaveFileDialogA.o_0OOO = Nothing
			o_0OOO.Oo.00O0oO. = Me
			o_0OOO.Oo.00O0oO. = -1
			o_0OOO.Oo.00O0oO. = AsyncTaskMethodBuilder(Of DialogResult).Create()
			o_0OOO.Oo.00O0oO..Start(Of SaveFileDialogA.o_0OOO)(o_0OOO)
			Return o_0OOO.Oo.00O0oO..Task
		End Function

		' Token: 0x17000266 RID: 614
		' (get) Token: 0x06000E13 RID: 3603 RVA: 0x00060EDF File Offset: 0x0005F0DF
		' (set) Token: 0x06000E14 RID: 3604 RVA: 0x00060EEC File Offset: 0x0005F0EC
		Public Property Title As String
			Get
				Return Me.o0o_oO_OOoO.0O..Title
			End Get
			Set(value As String)
				Me.o0o_oO_OOoO.0O..Title = value
			End Set
		End Property

		' Token: 0x17000267 RID: 615
		' (get) Token: 0x06000E15 RID: 3605 RVA: 0x00060EFA File Offset: 0x0005F0FA
		' (set) Token: 0x06000E16 RID: 3606 RVA: 0x00060F07 File Offset: 0x0005F107
		Public Property InitialDirectory As String
			Get
				Return Me.o0o_oO_OOoO.0O..InitialDirectory
			End Get
			Set(value As String)
				Me.o0o_oO_OOoO.0O..InitialDirectory = value
			End Set
		End Property

		' Token: 0x17000268 RID: 616
		' (get) Token: 0x06000E17 RID: 3607 RVA: 0x00060F15 File Offset: 0x0005F115
		' (set) Token: 0x06000E18 RID: 3608 RVA: 0x00060F22 File Offset: 0x0005F122
		Public Property FileName As String
			Get
				Return Me.o0o_oO_OOoO.0O..FileName
			End Get
			Set(value As String)
				Me.o0o_oO_OOoO.0O..FileName = value
			End Set
		End Property

		' Token: 0x17000269 RID: 617
		' (get) Token: 0x06000E19 RID: 3609 RVA: 0x00060F30 File Offset: 0x0005F130
		' (set) Token: 0x06000E1A RID: 3610 RVA: 0x00060F3D File Offset: 0x0005F13D
		Public Property Filter As String
			Get
				Return Me.o0o_oO_OOoO.0O..Filter
			End Get
			Set(value As String)
				Me.o0o_oO_OOoO.0O..Filter = value
			End Set
		End Property

		' Token: 0x06000E1B RID: 3611 RVA: 0x00060F4C File Offset: 0x0005F14C
		<CompilerGenerated()>
		Private Function <<EMPTY_NAME>>() As DialogResult
			Dim o000OO As SaveFileDialogA.o000OO = New SaveFileDialogA.o000OO()
			o000OO.Oo.00O0oO. = Me
			o000OO.o0o_oO_OOoO.0O. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf o000OO.o0o_oO_OOoO.0O.)
			End If
			Return o000OO.o0o_oO_OOoO.0O.
		End Function

		' Token: 0x04000579 RID: 1401
		Private <<EMPTY_NAME>> As SaveFileDialog

		' Token: 0x0200011C RID: 284
		<CompilerGenerated()>
		Friend NotInheritable Class o000OO
			' Token: 0x06000E1D RID: 3613 RVA: 0x00060F99 File Offset: 0x0005F199
			Friend Sub <<EMPTY_NAME>>()
				Me.o0o_oO_OOoO.0O. = Me.Oo.00O0oO..o0o_oO_OOoO.0O..ShowDialog()
			End Sub

			' Token: 0x0400057A RID: 1402
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x0400057B RID: 1403
			Public <<EMPTY_NAME>> As SaveFileDialogA
		End Class
	End Class
End Namespace
