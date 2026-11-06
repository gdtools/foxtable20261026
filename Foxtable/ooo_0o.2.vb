Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x0200041B RID: 1051
	Friend Class ooo_0o
		Implements O_o_0o

		' Token: 0x060045F3 RID: 17907 RVA: 0x001C48AD File Offset: 0x001C2AAD
		Public Sub New()
			Me.ooO_O.O_O. = Nothing
			Me.ooO_O.O_O. = New List(Of ParentChildPair)()
			Me.ooO_O.O_O. = New Dictionary(Of String, Object)()
			Me.O0_o.0. = New Dictionary(Of String, Object)()
			Me.ooO_O.O_O. = New Dictionary(Of String, PropertyBase)()
		End Sub

		' Token: 0x060045F4 RID: 17908 RVA: 0x001C48E8 File Offset: 0x001C2AE8
		Friend Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Me.ooO_O.O_O..Add(New ParentChildPair(A_0))
			If Me.ooO_O.O_O. Is Nothing Then
				Me.ooO_O.O_O. = CType(A_0.FindForm(), o\u3002\u3002\u3000\u3000\u3002)
			End If
			Me.ooO_O.O_O..Add(A_0.Key, Me.ooO_O.O_O..O0o._0.(A_0.Key))
			Me.ooO_O.O_O..Add(A_0.Key, RuntimeHelpers.GetObjectValue(Me.ooO_O.O_O..o_0O.OO0_0_.(A_0.Key)))
			Me.O0_o.0..Add(A_0.Key, RuntimeHelpers.GetObjectValue(Me.ooO_O.O_O..ooOOOO.0o.(A_0.Key)))
		End Sub

		' Token: 0x060045F5 RID: 17909 RVA: 0x001C49A0 File Offset: 0x001C2BA0
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O_o_0o.O_OO0.O.
			Try
				For Each parentChildPair As ParentChildPair In Me.ooO_O.O_O.
					parentChildPair.Parent.Controls.Add(parentChildPair.Holder)
					parentChildPair.Holder.DataRow("Delete") = False
					Me.ooO_O.O_O..O0o._0..Add(parentChildPair.Holder)
					Me.ooO_O.O_O..O0o._0..Add(parentChildPair.Holder.Key, Me.ooO_O.O_O.(parentChildPair.Holder.Key))
					Me.ooO_O.O_O..o_0O.OO0_0_..Add(parentChildPair.Holder.Key, RuntimeHelpers.GetObjectValue(Me.ooO_O.O_O.(parentChildPair.Holder.Key)))
					Me.ooO_O.O_O..ooOOOO.0o..Add(parentChildPair.Holder.Key, RuntimeHelpers.GetObjectValue(Me.O0_o.0.(parentChildPair.Holder.Key)))
				Next
			Finally
				Dim enumerator As List(Of ParentChildPair).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Me.ooO_O.O_O..OOOoO.Oo_O0o_0.()
			Try
				For Each parentChildPair As ParentChildPair In Me.ooO_O.O_O.
					parentChildPair.Holder.Selected = True
				Next
			Finally
				Dim enumerator2 As List(Of ParentChildPair).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x060045F6 RID: 17910 RVA: 0x001C4B40 File Offset: 0x001C2D40
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.ooO_O.O_O..Count
		End Function

		' Token: 0x04001C6E RID: 7278
		Friend <<EMPTY_NAME>> As o\u3002\u3002\u3000\u3000\u3002

		' Token: 0x04001C6F RID: 7279
		Private <<EMPTY_NAME>> As List(Of ParentChildPair)

		' Token: 0x04001C70 RID: 7280
		Private <<EMPTY_NAME>> As Dictionary(Of String, Object)

		' Token: 0x04001C71 RID: 7281
		Private <<EMPTY_NAME>> As Dictionary(Of String, Object)

		' Token: 0x04001C72 RID: 7282
		Friend <<EMPTY_NAME>> As Dictionary(Of String, PropertyBase)
	End Class
End Namespace
