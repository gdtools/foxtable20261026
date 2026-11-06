Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Chart
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003F4 RID: 1012
	<ProvideProperty("PrintRowNumber", GetType(Control))>
	<ProvideProperty("MaxRows", GetType(Control))>
	<ProvideProperty("NewPage", GetType(Control))>
	<ProvideProperty("MinRows", GetType(Control))>
	<ProvideProperty("PrintBorder", GetType(Control))>
	<ProvideProperty("Printable", GetType(Control))>
	Friend Class OoOO0ooo
		Inherits Component
		Implements IExtenderProvider

		' Token: 0x060040AD RID: 16557 RVA: 0x001BF110 File Offset: 0x001BD310
		Public Sub New()
			Me.PrintableValues = New Hashtable()
			Me.MinRowsValues = New Hashtable()
			Me.MaxRowsValues = New Hashtable()
			Me.PrintRowNumberValues = New Hashtable()
			Me.NewPageValues = New Hashtable()
			Me.O0O.o____o00. = New Hashtable()
		End Sub

		' Token: 0x060040AE RID: 16558 RVA: 0x001BF168 File Offset: 0x001BD368
		Friend Function CanExtend(extendee As Object) As Boolean Implements System.ComponentModel.IExtenderProvider.CanExtend
			Return TypeOf extendee Is Label OrElse TypeOf extendee Is C1TextBox OrElse TypeOf extendee Is C1FlexGrid OrElse (TypeOf extendee Is CheckBox OrElse TypeOf extendee Is RadioButton OrElse TypeOf extendee Is O_oo) OrElse (TypeOf extendee Is CustomPictureBox OrElse TypeOf extendee Is C1Chart OrElse TypeOf extendee Is LineControl) OrElse (TypeOf extendee Is OOo00o_0o0_ OrElse TypeOf extendee Is PictureViewer)
		End Function

		' Token: 0x060040AF RID: 16559 RVA: 0x001BF1E0 File Offset: 0x001BD3E0
		Friend Function GetPrintable(ctl As Control) As Boolean
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.PrintableValues(ctl))
			Return objectValue IsNot Nothing AndAlso Conversions.ToBoolean(objectValue)
		End Function

		' Token: 0x060040B0 RID: 16560 RVA: 0x001BF210 File Offset: 0x001BD410
		Friend Function <<EMPTY_NAME>>(A_0 As Control) As Boolean
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.O0O.o____o00.(A_0))
			Return objectValue IsNot Nothing AndAlso Conversions.ToBoolean(objectValue)
		End Function

		' Token: 0x060040B1 RID: 16561 RVA: 0x001BF240 File Offset: 0x001BD440
		Friend Function GetNewPage(ctl As Control) As Boolean
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.NewPageValues(ctl))
			Return objectValue IsNot Nothing AndAlso Conversions.ToBoolean(objectValue)
		End Function

		' Token: 0x060040B2 RID: 16562 RVA: 0x001BF26E File Offset: 0x001BD46E
		Friend Sub SetPrintable(ctl As Control, Value As Boolean)
			Me.PrintableValues(ctl) = Value
		End Sub

		' Token: 0x060040B3 RID: 16563 RVA: 0x001BF282 File Offset: 0x001BD482
		Friend Sub <<EMPTY_NAME>>(A_0 As Control, A_1 As Boolean)
			Me.O0O.o____o00.(A_0) = A_1
		End Sub

		' Token: 0x060040B4 RID: 16564 RVA: 0x001BF296 File Offset: 0x001BD496
		Friend Sub SetNewPage(ctl As Control, Value As Boolean)
			Me.NewPageValues(ctl) = Value
		End Sub

		' Token: 0x060040B5 RID: 16565 RVA: 0x001BF2AC File Offset: 0x001BD4AC
		Friend Function GetMinRows(ctl As Control) As Integer
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.MinRowsValues(ctl))
			Dim result As Integer
			If objectValue Is Nothing Then
				result = 0
			Else
				result = Conversions.ToInteger(objectValue)
			End If
			Return result
		End Function

		' Token: 0x060040B6 RID: 16566 RVA: 0x001BF2DC File Offset: 0x001BD4DC
		Friend Function GetMaxRows(ctl As Control) As Integer
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.MaxRowsValues(ctl))
			Dim result As Integer
			If objectValue Is Nothing Then
				result = 0
			Else
				result = Conversions.ToInteger(objectValue)
			End If
			Return result
		End Function

		' Token: 0x060040B7 RID: 16567 RVA: 0x001BF30A File Offset: 0x001BD50A
		Friend Sub SetMinRows(ctl As Control, Value As Integer)
			Me.MinRowsValues(ctl) = Value
		End Sub

		' Token: 0x060040B8 RID: 16568 RVA: 0x001BF31E File Offset: 0x001BD51E
		Friend Sub SetMaxRows(ctl As Control, Value As Integer)
			Me.MaxRowsValues(ctl) = Value
		End Sub

		' Token: 0x060040B9 RID: 16569 RVA: 0x001BF334 File Offset: 0x001BD534
		Friend Function GetPrintRowNumber(ctl As Control) As Boolean
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.PrintRowNumberValues(ctl))
			Return objectValue IsNot Nothing AndAlso Conversions.ToBoolean(objectValue)
		End Function

		' Token: 0x060040BA RID: 16570 RVA: 0x001BF362 File Offset: 0x001BD562
		Friend Sub SetPrintRowNumber(ctl As Control, Value As Boolean)
			Me.PrintRowNumberValues(ctl) = Value
		End Sub

		' Token: 0x060040BB RID: 16571 RVA: 0x001BF378 File Offset: 0x001BD578
		Friend Sub Clear()
			Me.PrintableValues.Clear()
			Me.NewPageValues.Clear()
			Me.MinRowsValues.Clear()
			Me.MaxRowsValues.Clear()
			Me.PrintRowNumberValues.Clear()
			Me.O0O.o____o00..Clear()
			MyBase.Dispose()
		End Sub

		' Token: 0x060040BC RID: 16572 RVA: 0x001BF3D0 File Offset: 0x001BD5D0
		Friend Sub Remove(ctl As Control)
			If Me.PrintableValues.ContainsKey(ctl) Then
				Me.PrintableValues.Remove(ctl)
			End If
			If Me.NewPageValues.ContainsKey(ctl) Then
				Me.NewPageValues.Remove(ctl)
			End If
			If Me.MinRowsValues.ContainsKey(ctl) Then
				Me.MinRowsValues.Remove(ctl)
			End If
			If Me.MaxRowsValues.ContainsKey(ctl) Then
				Me.MaxRowsValues.Remove(ctl)
			End If
			If Me.PrintRowNumberValues.ContainsKey(ctl) Then
				Me.PrintRowNumberValues.Remove(ctl)
			End If
			If Me.O0O.o____o00..ContainsKey(ctl) Then
				Me.O0O.o____o00..Remove(ctl)
			End If
		End Sub

		' Token: 0x060040BD RID: 16573 RVA: 0x001BF47C File Offset: 0x001BD67C
		Friend Sub Refresh()
			Dim list As List(Of Control) = New List(Of Control)()
			Try
				For Each obj As Object In Me.PrintableValues.Keys
					Dim control As Control = CType(obj, Control)
					If control.FindForm() Is Nothing Then
						list.Add(control)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				For Each ctl As Control In list
					Me.Remove(ctl)
				Next
			Finally
				Dim enumerator2 As List(Of Control).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x04001AD9 RID: 6873
		Private PrintableValues As Hashtable

		' Token: 0x04001ADA RID: 6874
		Private MinRowsValues As Hashtable

		' Token: 0x04001ADB RID: 6875
		Private MaxRowsValues As Hashtable

		' Token: 0x04001ADC RID: 6876
		Private PrintRowNumberValues As Hashtable

		' Token: 0x04001ADD RID: 6877
		Private NewPageValues As Hashtable

		' Token: 0x04001ADE RID: 6878
		Private <<EMPTY_NAME>> As Hashtable
	End Class
End Namespace
