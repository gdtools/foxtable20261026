Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000263 RID: 611
	Friend Class OoOoo00
		Inherits TrackBar

		' Token: 0x1700067F RID: 1663
		' (get) Token: 0x06001D05 RID: 7429 RVA: 0x000B7FC8 File Offset: 0x000B61C8
		' (set) Token: 0x06001D06 RID: 7430 RVA: 0x000B7FF4 File Offset: 0x000B61F4
		Friend Property Value As Object
			Get
				Dim result As Object
				If Me.o0Ooo_O0oo.O__. IsNot Nothing Then
					result = Me.o0Ooo_O0oo.O__.
				Else
					result = MyBase.Value
				End If
				Return result
			End Get
			Set(value As Object)
				Me.o0Ooo_O0oo.O__. = RuntimeHelpers.GetObjectValue(value)
				If value Is DBNull.Value OrElse value Is Nothing Then
					MyBase.Value = 0
					Return
				End If
				Dim val As Integer
				If Integer.TryParse(value.ToString(), val) Then
					MyBase.Value = Math.Min(MyBase.Maximum, Math.Max(MyBase.Minimum, val))
					Return
				End If
				MyBase.Value = 0
			End Set
		End Property

		' Token: 0x04000C30 RID: 3120
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
