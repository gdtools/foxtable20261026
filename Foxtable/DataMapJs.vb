Imports System
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020000FF RID: 255
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class DataMapJs
		' Token: 0x06000D85 RID: 3461 RVA: 0x0005F71A File Offset: 0x0005D91A
		Public Sub New()
			Me.oo._Oo0. = New ListDictionary()
		End Sub

		' Token: 0x06000D86 RID: 3462 RVA: 0x0005F72D File Offset: 0x0005D92D
		Public Sub Add(Key As Object, Value As Object)
			Me.oo._Oo0..Add(RuntimeHelpers.GetObjectValue(Key), RuntimeHelpers.GetObjectValue(Value))
		End Sub

		' Token: 0x0400052C RID: 1324
		Friend <<EMPTY_NAME>> As ListDictionary
	End Class
End Namespace
