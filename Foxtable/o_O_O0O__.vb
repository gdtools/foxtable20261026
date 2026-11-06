Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020003D4 RID: 980
	Friend Class o_O_O0O__
		Inherits ProgressBar

		' Token: 0x17000DA0 RID: 3488
		' (get) Token: 0x06003EA9 RID: 16041 RVA: 0x001B19F8 File Offset: 0x001AFBF8
		' (set) Token: 0x06003EAA RID: 16042 RVA: 0x001B1A24 File Offset: 0x001AFC24
		Public Property Value As Object
			Get
				Dim result As Object
				If Me.O00_o0_.O__oo. IsNot Nothing Then
					result = Me.O00_o0_.O__oo.
				Else
					result = MyBase.Value
				End If
				Return result
			End Get
			Set(value As Object)
				Me.O00_o0_.O__oo. = RuntimeHelpers.GetObjectValue(value)
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

		' Token: 0x0400196C RID: 6508
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
