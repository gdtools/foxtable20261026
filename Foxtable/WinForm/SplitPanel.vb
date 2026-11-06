Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000521 RID: 1313
	<oO0oooo("1918")>
	<ComVisible(True)>
	Public Class SplitPanel
		Inherits Control

		' Token: 0x0600564B RID: 22091 RVA: 0x0022266A File Offset: 0x0022086A
		Public Sub New(A_0 As SplitterPanel)
			MyBase.New(A_0, ControlTypeEnum.Panel)
			Me.oO.ooo. = A_0
		End Sub

		' Token: 0x170014E2 RID: 5346
		' (get) Token: 0x0600564C RID: 22092 RVA: 0x0022267C File Offset: 0x0022087C
		' (set) Token: 0x0600564D RID: 22093 RVA: 0x00222689 File Offset: 0x00220889
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.oO.ooo..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.oO.ooo..BorderStyle = value
			End Set
		End Property

		' Token: 0x170014E3 RID: 5347
		' (get) Token: 0x0600564E RID: 22094 RVA: 0x00222697 File Offset: 0x00220897
		' (set) Token: 0x0600564F RID: 22095 RVA: 0x002226A4 File Offset: 0x002208A4
		Public Property AutoScroll As Boolean
			Get
				Return Me.oO.ooo..AutoScroll
			End Get
			Set(value As Boolean)
				Me.oO.ooo..AutoScroll = value
			End Set
		End Property

		' Token: 0x170014E4 RID: 5348
		' (get) Token: 0x06005650 RID: 22096 RVA: 0x002226B2 File Offset: 0x002208B2
		' (set) Token: 0x06005651 RID: 22097 RVA: 0x002226BF File Offset: 0x002208BF
		Public Property ExtendSize As Size
			Get
				Return Me.oO.ooo..AutoScrollMinSize
			End Get
			Set(value As Size)
				Me.oO.ooo..AutoScrollMinSize = value
			End Set
		End Property

		' Token: 0x170014E5 RID: 5349
		' (get) Token: 0x06005652 RID: 22098 RVA: 0x002226D0 File Offset: 0x002208D0
		' (set) Token: 0x06005653 RID: 22099 RVA: 0x00222710 File Offset: 0x00220910
		Public Property Collapsed As Boolean
			Get
				Dim splitContainer As SplitContainer = CType(Me.oO.ooo..Parent, SplitContainer)
				Dim result As Boolean
				If Me.oO.ooo. Is splitContainer.Panel1 Then
					result = splitContainer.Panel1Collapsed
				Else
					result = splitContainer.Panel2Collapsed
				End If
				Return result
			End Get
			Set(value As Boolean)
				Dim splitContainer As SplitContainer = CType(Me.oO.ooo..Parent, SplitContainer)
				If Me.oO.ooo. Is splitContainer.Panel1 Then
					splitContainer.Panel1Collapsed = value
					Return
				End If
				splitContainer.Panel2Collapsed = value
			End Set
		End Property

		' Token: 0x06005654 RID: 22100 RVA: 0x0022274C File Offset: 0x0022094C
		<oO0oooo("1912")>
		Public Sub AddControl(Control As Control)
			Me.oO.ooo..Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x06005655 RID: 22101 RVA: 0x002227B0 File Offset: 0x002209B0
		<oO0oooo("1912")>
		Public Sub RemoveControl(Name As String)
			Try
				For Each obj As Object In Me.oO.ooo..Controls
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, Name, True) = 0 Then
						oOO0oo_o0.O00OO_O_oO_.o.(Me.oO.ooo..Controls, control)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.oO.ooo.)
		End Sub

		' Token: 0x06005656 RID: 22102 RVA: 0x00222838 File Offset: 0x00220A38
		Public Sub ClearControl()
			For i As Integer = Me.oO.ooo..Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = Me.oO.ooo..Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(Me.oO.ooo..Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.oO.ooo.)
		End Sub

		' Token: 0x170014E6 RID: 5350
		' (get) Token: 0x06005657 RID: 22103 RVA: 0x00222890 File Offset: 0x00220A90
		Friend ReadOnly Property BaseControl As SplitterPanel
			Get
				Return Me.oO.ooo.
			End Get
		End Property

		' Token: 0x170014E7 RID: 5351
		' (get) Token: 0x06005658 RID: 22104 RVA: 0x00222898 File Offset: 0x00220A98
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me.oO.ooo.)
			End Get
		End Property

		' Token: 0x04002228 RID: 8744
		Private <<EMPTY_NAME>> As SplitterPanel
	End Class
End Namespace
