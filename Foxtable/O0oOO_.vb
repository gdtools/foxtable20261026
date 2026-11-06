Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x0200041F RID: 1055
	Friend Class O0oOO_
		Implements O_o_0o

		' Token: 0x060045FD RID: 17917 RVA: 0x001C4CF4 File Offset: 0x001C2EF4
		Friend Sub New(A_0 As String, A_1 As FormProperty)
			Me.o.o0o. = A_1
			Me.o.o0o. = A_0
			Dim [property] As PropertyInfo = A_1.[GetType]().GetProperty(A_0)
			Me.o.o0o. = RuntimeHelpers.GetObjectValue([property].GetValue(A_1, Nothing))
		End Sub

		' Token: 0x060045FE RID: 17918 RVA: 0x001C4D38 File Offset: 0x001C2F38
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O_o_0o.O_OO0.O.
			Me.o.o0o..[GetType]().GetProperty(Me.o.o0o.).SetValue(Me.o.o0o., RuntimeHelpers.GetObjectValue(Me.o.o0o.), Nothing)
			CType(Me.o.o0o..Form.MdiParent, o\u3000\u3002).O0.0O00_O.().SelectedIndex = 0
			CType(Me.o.o0o..Form.MdiParent, o\u3000\u3002).O0.0O00_O.().Refresh()
		End Sub

		' Token: 0x04001C80 RID: 7296
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C81 RID: 7297
		Private <<EMPTY_NAME>> As FormProperty

		' Token: 0x04001C82 RID: 7298
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
