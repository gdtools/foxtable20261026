Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000093 RID: 147
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class mrpPlan
		' Token: 0x06000578 RID: 1400 RVA: 0x0001D3AC File Offset: 0x0001B5AC
		Public Sub New()
			Me.O._O0O0_0. = New Dictionary(Of String, Double)()
		End Sub

		' Token: 0x06000579 RID: 1401 RVA: 0x0001D3BF File Offset: 0x0001B5BF
		Public Sub Add(key As String, Value As Double)
			Me.O._O0O0_0..Add(key, Value)
		End Sub

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x0600057A RID: 1402 RVA: 0x0001D3CE File Offset: 0x0001B5CE
		Public ReadOnly Property Keys As IEnumerable(Of String)
			Get
				Return Me.O._O0O0_0..Keys
			End Get
		End Property

		' Token: 0x1700015F RID: 351
		Public Default Property Item(A_0 As String) As Double
			Get
				Return Me.O._O0O0_0.(A_0)
			End Get
			Set(value As Double)
				Me.O._O0O0_0.(A_0) = value
			End Set
		End Property

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x0600057D RID: 1405 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O._O0O0_0..Count
			End Get
		End Property

		' Token: 0x0400013F RID: 319
		Private <<EMPTY_NAME>> As Dictionary(Of String, Double)
	End Class
End Namespace
