Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000420 RID: 1056
	Friend Class O__o00
		Implements O_o_0o

		' Token: 0x060045FF RID: 17919 RVA: 0x001C4DB1 File Offset: 0x001C2FB1
		Friend Sub New(A_0 As Control)
			Me.o.oO0O0OO_o_. = New List(Of OoO)()
			Me.o.oO0O0OO_o_. = A_0
		End Sub

		' Token: 0x06004600 RID: 17920 RVA: 0x001C4DCB File Offset: 0x001C2FCB
		Friend Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Me.o.oO0O0OO_o_..Add(New OoO(A_0))
		End Sub

		' Token: 0x06004601 RID: 17921 RVA: 0x001C4DE0 File Offset: 0x001C2FE0
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O_o_0o.O_OO0.O.
			Try
				For Each ooO As OoO In Me.o.oO0O0OO_o_.
					If ooO.OO00_O0_._OO0..Parent IsNot Me.o.oO0O0OO_o_. Then
						Me.o.oO0O0OO_o_..Controls.Add(ooO.OO00_O0_._OO0.)
					End If
					ooO.OO00_O0_._OO0..Location = ooO.OO00_O0_._OO0.
					ooO.OO00_O0_._OO0..Selected = True
				Next
			Finally
				Dim enumerator As List(Of OoO).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x04001C83 RID: 7299
		Private <<EMPTY_NAME>> As Control

		' Token: 0x04001C84 RID: 7300
		Private <<EMPTY_NAME>> As List(Of OoO)
	End Class
End Namespace
