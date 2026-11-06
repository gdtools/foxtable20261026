Imports System
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports O0o0.00

Namespace Foxtable
	' Token: 0x02000114 RID: 276
	Public Class OpenFileDialogA
		' Token: 0x06000DD2 RID: 3538 RVA: 0x00060726 File Offset: 0x0005E926
		Public Sub New()
			Me.o_.oOO_. = New OpenFileDialog()
		End Sub

		' Token: 0x06000DD3 RID: 3539 RVA: 0x0006073C File Offset: 0x0005E93C
		Public Function ShowDialog() As Task(Of DialogResult)
			Dim o__00oO00oo As OpenFileDialogA.O__00oO00oo = Nothing
			o__00oO00oo.Ooo0o0._0O_. = Me
			o__00oO00oo.Ooo0o0._0O_. = -1
			o__00oO00oo.Ooo0o0._0O_. = AsyncTaskMethodBuilder(Of DialogResult).Create()
			o__00oO00oo.Ooo0o0._0O_..Start(Of OpenFileDialogA.O__00oO00oo)(o__00oO00oo)
			Return o__00oO00oo.Ooo0o0._0O_..Task
		End Function

		' Token: 0x17000259 RID: 601
		' (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00060787 File Offset: 0x0005E987
		' (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00060794 File Offset: 0x0005E994
		Public Property Title As String
			Get
				Return Me.o_.oOO_..Title
			End Get
			Set(value As String)
				Me.o_.oOO_..Title = value
			End Set
		End Property

		' Token: 0x1700025A RID: 602
		' (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000607A2 File Offset: 0x0005E9A2
		' (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000607AF File Offset: 0x0005E9AF
		Public Property InitialDirectory As String
			Get
				Return Me.o_.oOO_..InitialDirectory
			End Get
			Set(value As String)
				Me.o_.oOO_..InitialDirectory = value
			End Set
		End Property

		' Token: 0x1700025B RID: 603
		' (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000607BD File Offset: 0x0005E9BD
		' (set) Token: 0x06000DD9 RID: 3545 RVA: 0x000607CA File Offset: 0x0005E9CA
		Public Property FileName As String
			Get
				Return Me.o_.oOO_..FileName
			End Get
			Set(value As String)
				Me.o_.oOO_..FileName = value
			End Set
		End Property

		' Token: 0x1700025C RID: 604
		' (get) Token: 0x06000DDA RID: 3546 RVA: 0x000607D8 File Offset: 0x0005E9D8
		Public ReadOnly Property FileNames As String()
			Get
				Return Me.o_.oOO_..FileNames
			End Get
		End Property

		' Token: 0x1700025D RID: 605
		' (get) Token: 0x06000DDB RID: 3547 RVA: 0x000607E5 File Offset: 0x0005E9E5
		' (set) Token: 0x06000DDC RID: 3548 RVA: 0x000607F2 File Offset: 0x0005E9F2
		Public Property Filter As String
			Get
				Return Me.o_.oOO_..Filter
			End Get
			Set(value As String)
				Me.o_.oOO_..Filter = value
			End Set
		End Property

		' Token: 0x1700025E RID: 606
		' (get) Token: 0x06000DDD RID: 3549 RVA: 0x00060800 File Offset: 0x0005EA00
		' (set) Token: 0x06000DDE RID: 3550 RVA: 0x0006080D File Offset: 0x0005EA0D
		Public Property MultiSelect As Boolean
			Get
				Return Me.o_.oOO_..Multiselect
			End Get
			Set(value As Boolean)
				Me.o_.oOO_..Multiselect = value
			End Set
		End Property

		' Token: 0x06000DDF RID: 3551 RVA: 0x0006081C File Offset: 0x0005EA1C
		<CompilerGenerated()>
		Private Function <<EMPTY_NAME>>() As DialogResult
			Dim oo__ooO_0_0oO As OpenFileDialogA.Oo__ooO_0_0oO = New OpenFileDialogA.Oo__ooO_0_0oO()
			oo__ooO_0_0oO.o_.oOO_. = Me
			oo__ooO_0_0oO.o_.oOO_. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oo__ooO_0_0oO.o_.oOO_.)
			End If
			Return oo__ooO_0_0oO.o_.oOO_.
		End Function

		' Token: 0x04000563 RID: 1379
		Private <<EMPTY_NAME>> As OpenFileDialog

		' Token: 0x02000115 RID: 277
		<CompilerGenerated()>
		Friend NotInheritable Class Oo__ooO_0_0oO
			' Token: 0x06000DE1 RID: 3553 RVA: 0x00060869 File Offset: 0x0005EA69
			Friend Sub <<EMPTY_NAME>>()
				Me.o_.oOO_. = Me.o_.oOO_..o_.oOO_..ShowDialog()
			End Sub

			' Token: 0x04000564 RID: 1380
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000565 RID: 1381
			Public <<EMPTY_NAME>> As OpenFileDialogA
		End Class
	End Class
End Namespace
