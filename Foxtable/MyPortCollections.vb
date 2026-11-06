Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO.Ports
Imports Foxtable.My

Namespace Foxtable
	' Token: 0x020004BA RID: 1210
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("1968")>
	Public Class MyPortCollections
		Inherits Dictionary(Of String, Port)

		' Token: 0x06004E64 RID: 20068 RVA: 0x00208430 File Offset: 0x00206630
		Public Sub Add(PortName As String)
			If Not MyBase.ContainsKey(PortName) Then
				Dim port As Port = New Port()
				port.PortName = PortName
				port.ReadTimeout = 500
				port.WriteTimeout = 500
				AddHandler port.DataReceived, AddressOf Me.O0_Oo0.0o_o0.
				MyBase.Add(PortName, port)
			End If
		End Sub

		' Token: 0x06004E65 RID: 20069 RVA: 0x00208484 File Offset: 0x00206684
		Public Sub Remove(PortName As String)
			If MyBase.ContainsKey(PortName) Then
				Dim port As Port = MyBase(PortName)
				RemoveHandler port.DataReceived, AddressOf Me.O0_Oo0.0o_o0.
				If port.IsOpen Then
					port.Close()
				End If
				MyBase.Remove(PortName)
			End If
		End Sub

		' Token: 0x06004E66 RID: 20070 RVA: 0x002084CC File Offset: 0x002066CC
		Public Sub Clear()
			Try
				For Each key As String In MyBase.Keys
					Dim port As Port = MyBase(key)
					RemoveHandler port.DataReceived, AddressOf Me.O0_Oo0.0o_o0.
					If port.IsOpen Then
						port.Close()
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, Port).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			MyBase.Clear()
		End Sub

		' Token: 0x06004E67 RID: 20071 RVA: 0x00208548 File Offset: 0x00206748
		Public Function Contains(PortName As String) As Boolean
			Return MyBase.ContainsKey(PortName)
		End Function

		' Token: 0x06004E68 RID: 20072 RVA: 0x00208554 File Offset: 0x00206754
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SerialDataReceivedEventArgs)
			Dim method As MyPortCollections.ReceiveDataMethod = AddressOf Me.oO_o.0_o0_.
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				Main.OO_O.o..Invoke(method, New Object() { CType(A_0, Port) })
			End If
		End Sub

		' Token: 0x06004E69 RID: 20073 RVA: 0x0020859C File Offset: 0x0020679C
		Private Sub <<EMPTY_NAME>>(A_0 As Port)
			Dim dataReceivedEventArgs As DataReceivedEventArgs = New DataReceivedEventArgs(A_0)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "DataReceived", New Object() { dataReceivedEventArgs }, False, "串口监视器", False)
		End Sub

		' Token: 0x170011A9 RID: 4521
		' (get) Token: 0x06004E6A RID: 20074 RVA: 0x002085D1 File Offset: 0x002067D1
		Public ReadOnly Property PortNames As List(Of String)
			Get
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(c.OOOOO.o.().Ports.SerialPortNames)
				Return list
			End Get
		End Property

		' Token: 0x020004BC RID: 1212
		' (Invoke) Token: 0x06004E74 RID: 20084
		Public Delegate Sub ReceiveDataMethod(A_0 As Port)
	End Class
End Namespace
