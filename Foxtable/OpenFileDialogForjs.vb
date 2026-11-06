Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports O0o0.00

Namespace Foxtable
	' Token: 0x02000117 RID: 279
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class OpenFileDialogForjs
		' Token: 0x06000DE4 RID: 3556 RVA: 0x00060966 File Offset: 0x0005EB66
		Public Sub New(A_0 As WebViewer)
			Me.OoOo00o.o00_0O. = Nothing
			Me.OoOo00o.o00_0O. = Nothing
			Me.OoOo00o.o00_0O. = False
			Me.OoOo00o.o00_0O. = A_0
		End Sub

		' Token: 0x1700025F RID: 607
		' (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0006098A File Offset: 0x0005EB8A
		' (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00060992 File Offset: 0x0005EB92
		Public Property CallBack As String

		' Token: 0x06000DE7 RID: 3559 RVA: 0x0006099C File Offset: 0x0005EB9C
		Public Sub ShowDialog()
			Dim oo_O0o As OpenFileDialogForjs.oo_O0o = Nothing
			oo_O0o.OOoo.00O_0. = Me
			oo_O0o.OOoo.00O_0. = -1
			oo_O0o.OOoo.00O_0. = AsyncVoidMethodBuilder.Create()
			oo_O0o.OOoo.00O_0..Start(Of OpenFileDialogForjs.oo_O0o)(oo_O0o)
		End Sub

		' Token: 0x17000260 RID: 608
		' (get) Token: 0x06000DE8 RID: 3560 RVA: 0x000609DB File Offset: 0x0005EBDB
		' (set) Token: 0x06000DE9 RID: 3561 RVA: 0x000609E3 File Offset: 0x0005EBE3
		Public Property Title As String
			Get
				Return Me.oo_OO.O000.
			End Get
			Set(value As String)
				Me.oo_OO.O000. = value
			End Set
		End Property

		' Token: 0x17000261 RID: 609
		' (get) Token: 0x06000DEA RID: 3562 RVA: 0x000609EC File Offset: 0x0005EBEC
		' (set) Token: 0x06000DEB RID: 3563 RVA: 0x000609F4 File Offset: 0x0005EBF4
		Public Property InitialDirectory As String
			Get
				Return Me.O0O_O.0_0OO.
			End Get
			Set(value As String)
				Me.O0O_O.0_0OO. = value
			End Set
		End Property

		' Token: 0x17000262 RID: 610
		' (get) Token: 0x06000DEC RID: 3564 RVA: 0x000609FD File Offset: 0x0005EBFD
		' (set) Token: 0x06000DED RID: 3565 RVA: 0x00060A05 File Offset: 0x0005EC05
		Public Property FileName As String
			Get
				Return Me.oooOoo0._Oo000.
			End Get
			Set(value As String)
				Me.oooOoo0._Oo000. = value
			End Set
		End Property

		' Token: 0x17000263 RID: 611
		' (get) Token: 0x06000DEE RID: 3566 RVA: 0x00060A0E File Offset: 0x0005EC0E
		' (set) Token: 0x06000DEF RID: 3567 RVA: 0x00060A16 File Offset: 0x0005EC16
		Public Property FileNames As String()
			Get
				Return Me.OoOo00o.o00_0O.
			End Get
			Private Set(value As String())
				Me.OoOo00o.o00_0O. = value
			End Set
		End Property

		' Token: 0x17000264 RID: 612
		' (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00060A1F File Offset: 0x0005EC1F
		' (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00060A27 File Offset: 0x0005EC27
		Public Property Filter As String
			Get
				Return Me.O0.O_0OOO0_.
			End Get
			Set(value As String)
				Me.O0.O_0OOO0_. = value
			End Set
		End Property

		' Token: 0x17000265 RID: 613
		' (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00060A30 File Offset: 0x0005EC30
		' (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00060A38 File Offset: 0x0005EC38
		Public Property MultiSelect As Boolean
			Get
				Return Me.OoOo00o.o00_0O.
			End Get
			Set(value As Boolean)
				Me.OoOo00o.o00_0O. = value
			End Set
		End Property

		' Token: 0x06000DF4 RID: 3572 RVA: 0x00060A44 File Offset: 0x0005EC44
		<CompilerGenerated()>
		Private Sub <<EMPTY_NAME>>()
			Dim o_0_ As OpenFileDialogForjs.O_0_ = New OpenFileDialogForjs.O_0_(o_0_)
			o_0_.OOoo.00O_0. = Me
			o_0_.OOoo.00O_0. = DialogResult.Cancel
			If OO_00oOO.BaseMainForm IsNot Nothing Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf o_0_.OOoo.00O_0.)
			End If
		End Sub

		' Token: 0x0400056A RID: 1386
		Friend <<EMPTY_NAME>> As OpenFileDialog

		' Token: 0x0400056B RID: 1387
		Private <<EMPTY_NAME>> As WebViewer

		' Token: 0x0400056C RID: 1388
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400056D RID: 1389
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400056E RID: 1390
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400056F RID: 1391
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000570 RID: 1392
		Private <<EMPTY_NAME>> As String()

		' Token: 0x04000571 RID: 1393
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000572 RID: 1394
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x02000118 RID: 280
		<CompilerGenerated()>
		Friend NotInheritable Class O_0_
			' Token: 0x06000DF5 RID: 3573 RVA: 0x00060A84 File Offset: 0x0005EC84
			Public Sub New(A_0 As OpenFileDialogForjs.O_0_)
				If A_0 IsNot Nothing Then
					Me.OOoo.00O_0. = A_0.OOoo.00O_0.
				End If
			End Sub

			' Token: 0x06000DF6 RID: 3574 RVA: 0x00060A9C File Offset: 0x0005EC9C
			Friend Sub <<EMPTY_NAME>>()
				Me.OOoo.00O_0..OoOo00o.o00_0O. = New OpenFileDialog()
				If Not String.IsNullOrEmpty(Me.OOoo.00O_0..Filter) Then
					Me.OOoo.00O_0..OoOo00o.o00_0O..Filter = Me.OOoo.00O_0..Filter
				End If
				If Not String.IsNullOrEmpty(Me.OOoo.00O_0..FileName) Then
					Me.OOoo.00O_0..OoOo00o.o00_0O..FileName = Me.OOoo.00O_0..FileName
				End If
				If Not String.IsNullOrEmpty(Me.OOoo.00O_0..Title) Then
					Me.OOoo.00O_0..OoOo00o.o00_0O..Title = Me.OOoo.00O_0..Title
				End If
				If Not String.IsNullOrEmpty(Me.OOoo.00O_0..InitialDirectory) Then
					Me.OOoo.00O_0..OoOo00o.o00_0O..InitialDirectory = Me.OOoo.00O_0..InitialDirectory
				End If
				Me.OOoo.00O_0..OoOo00o.o00_0O..Multiselect = Me.OOoo.00O_0..MultiSelect
				Me.OOoo.00O_0. = Me.OOoo.00O_0..OoOo00o.o00_0O..ShowDialog(OO_00oOO.BaseMainForm)
				If Me.OOoo.00O_0. = DialogResult.OK AndAlso Operators.CompareString(Me.OOoo.00O_0..CallBack, "", True) > 0 Then
					Me.OOoo.00O_0..FileName = JsonConvert.ToString(Me.OOoo.00O_0..OoOo00o.o00_0O..FileName)
					Dim list As List(Of String) = New List(Of String)()
					For Each text As String In Me.OOoo.00O_0..OoOo00o.o00_0O..FileNames
						list.Add(JsonConvert.ToString(text))
					Next
					Me.OOoo.00O_0..FileNames = list.ToArray()
					Dim text2 As String = String.Format("{0}({1})", Me.OOoo.00O_0..CallBack, Me.OOoo.00O_0..FileName)
					Me.OOoo.00O_0..OoOo00o.o00_0O..ExecuteScriptAsync(text2)
				ElseIf Operators.CompareString(Me.OOoo.00O_0..CallBack, "", True) > 0 Then
					Dim text3 As String = String.Format("{0}()", Me.OOoo.00O_0..CallBack)
					Me.OOoo.00O_0..OoOo00o.o00_0O..ExecuteScriptAsync(text3)
				End If
				Me.OOoo.00O_0..OoOo00o.o00_0O..Dispose()
			End Sub

			' Token: 0x04000573 RID: 1395
			Public <<EMPTY_NAME>> As DialogResult

			' Token: 0x04000574 RID: 1396
			Public <<EMPTY_NAME>> As OpenFileDialogForjs
		End Class
	End Class
End Namespace
