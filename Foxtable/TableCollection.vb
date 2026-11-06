Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200030E RID: 782
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TableCollection
		Implements IEnumerable(Of Table)

		' Token: 0x06002AB9 RID: 10937 RVA: 0x0012CAB4 File Offset: 0x0012ACB4
		Friend Sub New(A_0 As Dictionary(Of String, O_0))
			Me.o0O0Oo.OoO_. = New Dictionary(Of String, Table)()
			Try
				For Each o_ As O_0 In A_0.Values
					Me.o0O0Oo.OoO_..Add(o_.Oo._Oo0OO.(), New Table(o_))
				Next
			Finally
				Dim enumerator As Dictionary(Of String, O_0).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06002ABA RID: 10938 RVA: 0x0012CB28 File Offset: 0x0012AD28
		Friend Sub <<EMPTY_NAME>>(A_0 As Table)
			Me.o0O0Oo.OoO_..Add(A_0.View.Oo._Oo0OO.(), A_0)
		End Sub

		' Token: 0x06002ABB RID: 10939 RVA: 0x0012CB41 File Offset: 0x0012AD41
		Friend Sub <<EMPTY_NAME>>(A_0 As O_0)
			Me.o0O0Oo.OoO_..Add(A_0.Oo._Oo0OO.(), New Table(A_0))
		End Sub

		' Token: 0x06002ABC RID: 10940 RVA: 0x0012CB5A File Offset: 0x0012AD5A
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0O0Oo.OoO_..Remove(A_0)
		End Sub

		' Token: 0x06002ABD RID: 10941 RVA: 0x0012CB6C File Offset: 0x0012AD6C
		Friend Sub <<EMPTY_NAME>>(A_0 As Table)
			Try
				For Each key As String In Me.o0O0Oo.OoO_..Keys
					If Me.o0O0Oo.OoO_.(key) Is A_0 Then
						Me.o0O0Oo.OoO_..Remove(key)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, Table).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06002ABE RID: 10942 RVA: 0x0012CBDC File Offset: 0x0012ADDC
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each o_ As O_0 In O_O0OO.o__.O.().Values
					If Not Me.o0O0Oo.OoO_..ContainsKey(o_.Oo._Oo0OO.()) Then
						Me.o0O0Oo.OoO_..Add(o_.Oo._Oo0OO.(), New Table(o_))
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, O_0).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x17000A0E RID: 2574
		' (get) Token: 0x06002ABF RID: 10943 RVA: 0x0012CC58 File Offset: 0x0012AE58
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Name As String) As Table
			Get
				Dim result As Table
				If Me.o0O0Oo.OoO_..ContainsKey(Name) Then
					result = Me.o0O0Oo.OoO_.(Name)
				Else
					Try
						For Each text As String In Me.o0O0Oo.OoO_..Keys
							If Operators.CompareString(text, Name, True) = 0 Then
								Return Me.o0O0Oo.OoO_.(text)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, Table).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					MessageBox.Show("不存在名称为""" + Name + """的Table！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000A0F RID: 2575
		' (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0012CD04 File Offset: 0x0012AF04
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend ReadOnly Property Item(A_0 As Integer) As Table
			Get
				Dim num As Integer = 0
				Try
					For Each result As Table In Me.o0O0Oo.OoO_..Values
						If num = A_0 Then
							Return result
						End If
						num += 1
					Next
				Finally
					Dim enumerator As Dictionary(Of String, Table).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return Nothing
			End Get
		End Property

		' Token: 0x17000A10 RID: 2576
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Table
			Get
				Dim a_ As Integer = -1
				Dim result As Table
				If Integer.TryParse(A_0.ToString(), a_) Then
					result = Me.OO._O_o__.(a_)
				Else
					result = Me.get_Item(A_0.ToString())
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000A11 RID: 2577
		' (get) Token: 0x06002AC2 RID: 10946 RVA: 0x0012CD9E File Offset: 0x0012AF9E
		Public ReadOnly Property Count As Integer
			Get
				Return Me.o0O0Oo.OoO_..Count
			End Get
		End Property

		' Token: 0x17000A12 RID: 2578
		' (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0012CDAC File Offset: 0x0012AFAC
		Public ReadOnly Property Contains(TableName As String) As Boolean
			Get
				Dim result As Boolean
				If Me.o0O0Oo.OoO_..ContainsKey(TableName) Then
					result = True
				Else
					Try
						Dim enumerator As Dictionary(Of String, Table).KeyCollection.Enumerator = Me.o0O0Oo.OoO_..Keys.GetEnumerator()
						While enumerator.MoveNext()
							If Operators.CompareString(enumerator.Current, TableName, True) = 0 Then
								Return True
							End If
						End While
					Finally
						Dim enumerator As Dictionary(Of String, Table).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					result = False
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002AC4 RID: 10948 RVA: 0x0012CE20 File Offset: 0x0012B020
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Table) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Table).GetEnumerator
			Return CType(Me.o0O0Oo.OoO_..Values.GetEnumerator(), IEnumerator(Of Table))
		End Function

		' Token: 0x06002AC5 RID: 10949 RVA: 0x0012CE3C File Offset: 0x0012B03C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.o0O0Oo.OoO_..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x04001153 RID: 4435
		Friend <<EMPTY_NAME>> As Dictionary(Of String, Table)
	End Class
End Namespace
