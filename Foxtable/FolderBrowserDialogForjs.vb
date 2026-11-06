Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports O0o0.00

Namespace Foxtable
	' Token: 0x02000104 RID: 260
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class FolderBrowserDialogForjs
		' Token: 0x06000D9D RID: 3485 RVA: 0x0005F9C2 File Offset: 0x0005DBC2
		Public Sub New(A_0 As WebViewer)
			Me.O_o.oOO000oO. = Nothing
			Me.O_o.oOO000oO. = Nothing
			Me.O_o.oOO000oO. = A_0
		End Sub

		' Token: 0x17000252 RID: 594
		' (get) Token: 0x06000D9E RID: 3486 RVA: 0x0005F9DF File Offset: 0x0005DBDF
		' (set) Token: 0x06000D9F RID: 3487 RVA: 0x0005F9E7 File Offset: 0x0005DBE7
		Public Property CallBack As String

		' Token: 0x06000DA0 RID: 3488 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
		Public Sub ShowDialog()
			Dim o00OoO As FolderBrowserDialogForjs.o00OoO = Nothing
			o00OoO.Oo_o00oO_.O. = Me
			o00OoO.Oo_o00oO_.O. = -1
			o00OoO.Oo_o00oO_.O. = AsyncVoidMethodBuilder.Create()
			o00OoO.Oo_o00oO_.O..Start(Of FolderBrowserDialogForjs.o00OoO)(o00OoO)
		End Sub

		' Token: 0x17000253 RID: 595
		' (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0005FA2F File Offset: 0x0005DC2F
		' (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0005FA37 File Offset: 0x0005DC37
		Public Property Description As String
			Get
				Return Me.ooOo_O00o0.ooo.
			End Get
			Set(value As String)
				Me.ooOo_O00o0.ooo. = value
			End Set
		End Property

		' Token: 0x17000254 RID: 596
		' (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0005FA40 File Offset: 0x0005DC40
		' (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0005FA48 File Offset: 0x0005DC48
		Public Property SelectedPath As String
			Get
				Return Me.OO.Oo0.
			End Get
			Set(value As String)
				Me.OO.Oo0. = value
			End Set
		End Property

		' Token: 0x17000255 RID: 597
		' (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0005FA51 File Offset: 0x0005DC51
		' (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0005FA59 File Offset: 0x0005DC59
		Public Property ShowNewFolderButton As Boolean
			Get
				Return Me.O_o.oOO000oO.
			End Get
			Set(value As Boolean)
				Me.O_o.oOO000oO. = value
			End Set
		End Property

		' Token: 0x06000DA7 RID: 3495 RVA: 0x0005FA64 File Offset: 0x0005DC64
		<CompilerGenerated()>
		Private Sub <<EMPTY_NAME>>()
			Dim ooOoO00__O As FolderBrowserDialogForjs.ooOoO00__O = New FolderBrowserDialogForjs.ooOoO00__O()
			ooOoO00__O.Oo_o00oO_.O. = Me
			ooOoO00__O.O_o.oOO000oO. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf ooOoO00__O.O_o.oOO000oO.)
			End If
		End Sub

		' Token: 0x04000536 RID: 1334
		Private <<EMPTY_NAME>> As FolderBrowserDialog

		' Token: 0x04000537 RID: 1335
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x04000538 RID: 1336
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000539 RID: 1337
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400053A RID: 1338
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400053B RID: 1339
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x02000105 RID: 261
		<CompilerGenerated()>
		Friend NotInheritable Class ooOoO00__O
			' Token: 0x06000DA9 RID: 3497 RVA: 0x0005FAAC File Offset: 0x0005DCAC
			Friend Sub <<EMPTY_NAME>>()
				Me.Oo_o00oO_.O..O_o.oOO000oO. = New FolderBrowserDialog()
				If Not String.IsNullOrEmpty(Me.Oo_o00oO_.O..Description) Then
					Me.Oo_o00oO_.O..O_o.oOO000oO..Description = Me.Oo_o00oO_.O..Description
				End If
				If Not String.IsNullOrEmpty(Me.Oo_o00oO_.O..SelectedPath) Then
					Me.Oo_o00oO_.O..O_o.oOO000oO..SelectedPath = Me.Oo_o00oO_.O..SelectedPath
				End If
				Me.Oo_o00oO_.O..O_o.oOO000oO..ShowNewFolderButton = Me.Oo_o00oO_.O..ShowNewFolderButton
				Me.O_o.oOO000oO. = Me.Oo_o00oO_.O..O_o.oOO000oO..ShowDialog(OO_00oOO.BaseMainForm)
				If Me.O_o.oOO000oO. = DialogResult.OK AndAlso Operators.CompareString(Me.Oo_o00oO_.O..CallBack, "", True) > 0 Then
					Me.Oo_o00oO_.O..SelectedPath = JsonConvert.ToString(Me.Oo_o00oO_.O..O_o.oOO000oO..SelectedPath)
					Dim text As String = String.Format("{0}({1})", Me.Oo_o00oO_.O..CallBack, Me.Oo_o00oO_.O..SelectedPath)
					Me.Oo_o00oO_.O..O_o.oOO000oO..ExecuteScriptAsync(text)
				ElseIf Operators.CompareString(Me.Oo_o00oO_.O..CallBack, "", True) > 0 Then
					Dim text2 As String = String.Format("{0}()", Me.Oo_o00oO_.O..CallBack)
					Me.Oo_o00oO_.O..O_o.oOO000oO..ExecuteScriptAsync(text2)
				End If
				Me.Oo_o00oO_.O..O_o.oOO000oO..Dispose()
			End Sub

			' Token: 0x0400053C RID: 1340
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x0400053D RID: 1341
			Public <<EMPTY_NAME>> As FolderBrowserDialogForjs
		End Class
	End Class
End Namespace
