Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports O0o0.00

Namespace Foxtable
	' Token: 0x0200011E RID: 286
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SaveFileDialogForjs
		' Token: 0x06000E20 RID: 3616 RVA: 0x00061096 File Offset: 0x0005F296
		Public Sub New(A_0 As WebViewer)
			Me.OoO0.000O__O_. = Nothing
			Me.OoO0.000O__O_. = Nothing
			Me.OoO0.000O__O_. = A_0
		End Sub

		' Token: 0x1700026A RID: 618
		' (get) Token: 0x06000E21 RID: 3617 RVA: 0x000610B3 File Offset: 0x0005F2B3
		' (set) Token: 0x06000E22 RID: 3618 RVA: 0x000610BB File Offset: 0x0005F2BB
		Public Property CallBack As String

		' Token: 0x06000E23 RID: 3619 RVA: 0x000610C4 File Offset: 0x0005F2C4
		Public Sub ShowDialog()
			Dim ooo_ As SaveFileDialogForjs.ooo_ = Nothing
			ooo_.O.o0Oo_0Oo. = Me
			ooo_.O.o0Oo_0Oo. = -1
			ooo_.O.o0Oo_0Oo. = AsyncVoidMethodBuilder.Create()
			ooo_.O.o0Oo_0Oo..Start(Of SaveFileDialogForjs.ooo_)(ooo_)
		End Sub

		' Token: 0x1700026B RID: 619
		' (get) Token: 0x06000E24 RID: 3620 RVA: 0x00061103 File Offset: 0x0005F303
		' (set) Token: 0x06000E25 RID: 3621 RVA: 0x0006110B File Offset: 0x0005F30B
		Public Property Title As String
			Get
				Return Me.O0.0Oo_.
			End Get
			Set(value As String)
				Me.O0.0Oo_. = value
			End Set
		End Property

		' Token: 0x1700026C RID: 620
		' (get) Token: 0x06000E26 RID: 3622 RVA: 0x00061114 File Offset: 0x0005F314
		' (set) Token: 0x06000E27 RID: 3623 RVA: 0x0006111C File Offset: 0x0005F31C
		Public Property InitialDirectory As String
			Get
				Return Me.O_OO.0OOOo0.
			End Get
			Set(value As String)
				Me.O_OO.0OOOo0. = value
			End Set
		End Property

		' Token: 0x1700026D RID: 621
		' (get) Token: 0x06000E28 RID: 3624 RVA: 0x00061125 File Offset: 0x0005F325
		' (set) Token: 0x06000E29 RID: 3625 RVA: 0x0006112D File Offset: 0x0005F32D
		Public Property FileName As String
			Get
				Return Me.o__o00_OoO.o_o.
			End Get
			Set(value As String)
				Me.o__o00_OoO.o_o. = value
			End Set
		End Property

		' Token: 0x1700026E RID: 622
		' (get) Token: 0x06000E2A RID: 3626 RVA: 0x00061136 File Offset: 0x0005F336
		' (set) Token: 0x06000E2B RID: 3627 RVA: 0x0006113E File Offset: 0x0005F33E
		Public Property Filter As String
			Get
				Return Me.o_o0OO0_.0O_.
			End Get
			Set(value As String)
				Me.o_o0OO0_.0O_. = value
			End Set
		End Property

		' Token: 0x06000E2C RID: 3628 RVA: 0x00061148 File Offset: 0x0005F348
		<CompilerGenerated()>
		Private Sub <<EMPTY_NAME>>()
			Dim oO_oO_O As SaveFileDialogForjs.oO_oO_O = New SaveFileDialogForjs.oO_oO_O()
			oO_oO_O.OoO0.000O__O_. = Me
			oO_oO_O.OoO0.000O__O_. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf oO_oO_O.OoO0.000O__O_.)
			End If
		End Sub

		' Token: 0x04000580 RID: 1408
		Private <<EMPTY_NAME>> As SaveFileDialog

		' Token: 0x04000581 RID: 1409
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x04000582 RID: 1410
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000583 RID: 1411
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000584 RID: 1412
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000585 RID: 1413
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000586 RID: 1414
		Private <<EMPTY_NAME>> As String

		' Token: 0x0200011F RID: 287
		<CompilerGenerated()>
		Friend NotInheritable Class oO_oO_O
			' Token: 0x06000E2E RID: 3630 RVA: 0x00061190 File Offset: 0x0005F390
			Friend Sub <<EMPTY_NAME>>()
				Me.OoO0.000O__O_..OoO0.000O__O_. = New SaveFileDialog()
				If Not String.IsNullOrEmpty(Me.OoO0.000O__O_..Filter) Then
					Me.OoO0.000O__O_..OoO0.000O__O_..Filter = Me.OoO0.000O__O_..Filter
				End If
				If Not String.IsNullOrEmpty(Me.OoO0.000O__O_..FileName) Then
					Me.OoO0.000O__O_..OoO0.000O__O_..FileName = Me.OoO0.000O__O_..FileName
				End If
				If Not String.IsNullOrEmpty(Me.OoO0.000O__O_..Title) Then
					Me.OoO0.000O__O_..OoO0.000O__O_..Title = Me.OoO0.000O__O_..Title
				End If
				If Not String.IsNullOrEmpty(Me.OoO0.000O__O_..InitialDirectory) Then
					Me.OoO0.000O__O_..OoO0.000O__O_..InitialDirectory = Me.OoO0.000O__O_..InitialDirectory
				End If
				Me.OoO0.000O__O_. = Me.OoO0.000O__O_..OoO0.000O__O_..ShowDialog(OO_00oOO.BaseMainForm)
				If Me.OoO0.000O__O_. = DialogResult.OK AndAlso Operators.CompareString(Me.OoO0.000O__O_..CallBack, "", True) > 0 Then
					Me.OoO0.000O__O_..FileName = JsonConvert.ToString(Me.OoO0.000O__O_..OoO0.000O__O_..FileName)
					Dim text As String = String.Format("{0}({1})", Me.OoO0.000O__O_..CallBack, Me.OoO0.000O__O_..FileName)
					Me.OoO0.000O__O_..OoO0.000O__O_..ExecuteScriptAsync(text)
				ElseIf Operators.CompareString(Me.OoO0.000O__O_..CallBack, "", True) > 0 Then
					Dim text2 As String = String.Format("{0}()", Me.OoO0.000O__O_..CallBack)
					Me.OoO0.000O__O_..OoO0.000O__O_..ExecuteScriptAsync(text2)
				End If
				Me.OoO0.000O__O_..OoO0.000O__O_..Dispose()
			End Sub

			' Token: 0x04000587 RID: 1415
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000588 RID: 1416
			Public <<EMPTY_NAME>> As SaveFileDialogForjs
		End Class
	End Class
End Namespace
