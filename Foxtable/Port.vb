Imports System
Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Text

Namespace Foxtable
	' Token: 0x020004BB RID: 1211
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Port
		Inherits SerialPort

		' Token: 0x06004E6B RID: 20075 RVA: 0x002085ED File Offset: 0x002067ED
		Public Sub New()
			Me.Ooo0Oo_.ooO. = Encoding.Unicode
		End Sub

		' Token: 0x06004E6C RID: 20076 RVA: 0x00208600 File Offset: 0x00206800
		Public Sub Open()
			If Not MyBase.IsOpen Then
				Try
					MyBase.Open()
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
		End Sub

		' Token: 0x170011AA RID: 4522
		' (get) Token: 0x06004E6D RID: 20077 RVA: 0x00208648 File Offset: 0x00206848
		' (set) Token: 0x06004E6E RID: 20078 RVA: 0x00208650 File Offset: 0x00206850
		Public Property PortName As String
			Get
				Return MyBase.PortName
			End Get
			Friend Set(value As String)
				MyBase.PortName = value
			End Set
		End Property

		' Token: 0x06004E6F RID: 20079 RVA: 0x00208659 File Offset: 0x00206859
		Public Function GetBytes(val As String) As Byte()
			Return Encoding.Unicode.GetBytes(val)
		End Function

		' Token: 0x06004E70 RID: 20080 RVA: 0x00208666 File Offset: 0x00206866
		Public Function GetString(val As Byte()) As String
			Return Encoding.Unicode.GetString(val)
		End Function

		' Token: 0x04002072 RID: 8306
		Private <<EMPTY_NAME>> As Encoding
	End Class
End Namespace
