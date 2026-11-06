Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable.WinForm
	' Token: 0x020004FB RID: 1275
	<oO0oooo("2453")>
	<ComVisible(True)>
	Public Class RecordGrid
		Inherits Control

		' Token: 0x06005202 RID: 20994 RVA: 0x0021B629 File Offset: 0x00219829
		Friend Sub New(A_0 As OooOo0___oO)
			MyBase.New(A_0, ControlTypeEnum.RecordGrid)
			Me.Oooo.Oo_0O. = A_0
			A_0.BorderStyle = 3
		End Sub

		' Token: 0x06005203 RID: 20995 RVA: 0x0021B642 File Offset: 0x00219842
		Public Sub Build()
			Me.Oooo.Oo_0O..Ooo_oO._0O.()
		End Sub

		' Token: 0x170012E4 RID: 4836
		' (get) Token: 0x06005204 RID: 20996 RVA: 0x0021B64F File Offset: 0x0021984F
		' (set) Token: 0x06005205 RID: 20997 RVA: 0x0021B65C File Offset: 0x0021985C
		Public Property Table As Table
			Get
				Return Me.Oooo.Oo_0O..O.OOoo_o0.
			End Get
			Set(value As Table)
				Me.Oooo.Oo_0O..OO_.O_O0O.(Nothing)
				Me.Oooo.Oo_0O..O.OOoo_o0. = value
			End Set
		End Property

		' Token: 0x170012E5 RID: 4837
		' (get) Token: 0x06005206 RID: 20998 RVA: 0x0021B676 File Offset: 0x00219876
		' (set) Token: 0x06005207 RID: 20999 RVA: 0x0021B688 File Offset: 0x00219888
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TableName As String
			Get
				Return Me.Oooo.Oo_0O..O.OOoo_o0..Name
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..OO_.O_O0O..Clear()
				Me.Oooo.Oo_0O..OO_.O_O0O.(Nothing)
				Me.Oooo.Oo_0O..O.OOoo_o0. = OO_00oOO.Tables(value)
			End Set
		End Property

		' Token: 0x170012E6 RID: 4838
		' (get) Token: 0x06005208 RID: 21000 RVA: 0x0021B6BC File Offset: 0x002198BC
		' (set) Token: 0x06005209 RID: 21001 RVA: 0x0021B6D8 File Offset: 0x002198D8
		Public Property Columns As String
			Get
				Return String.Join("|", Me.Oooo.Oo_0O..OO_.O_O0O..ToArray())
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..OO_.O_O0O..Clear()
				Me.Oooo.Oo_0O..OO_.O_O0O..AddRange(value.Split(New Char() { "|"c }))
				Me.Oooo.Oo_0O..O.OOoo_o0. = True
			End Set
		End Property

		' Token: 0x0600520A RID: 21002 RVA: 0x0021B717 File Offset: 0x00219917
		Public Sub OpenDropDown()
			Me.Oooo.Oo_0O..oo_0OoO._.()
		End Sub

		' Token: 0x0600520B RID: 21003 RVA: 0x0021B724 File Offset: 0x00219924
		Public Sub CloseDropDown()
			Me.Oooo.Oo_0O..O.Ooo_o0.()
		End Sub

		' Token: 0x170012E7 RID: 4839
		' (get) Token: 0x0600520C RID: 21004 RVA: 0x0021B731 File Offset: 0x00219931
		Public ReadOnly Property DroppedDown As Boolean
			Get
				Return Me.Oooo.Oo_0O..oO000o.oO_oO.()
			End Get
		End Property

		' Token: 0x170012E8 RID: 4840
		' (get) Token: 0x0600520D RID: 21005 RVA: 0x0021B73E File Offset: 0x0021993E
		Friend ReadOnly Property BaseGrid As OooOo0___oO
			Get
				Return Me.Oooo.Oo_0O.
			End Get
		End Property

		' Token: 0x0600520E RID: 21006 RVA: 0x0021B746 File Offset: 0x00219946
		Public Sub Refresh()
			Me.Oooo.Oo_0O..Oo0o__.OO0o__O.()
		End Sub

		' Token: 0x040021B9 RID: 8633
		Private <<EMPTY_NAME>> As OooOo0___oO
	End Class
End Namespace
