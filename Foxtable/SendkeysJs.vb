Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000121 RID: 289
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SendkeysJs
		' Token: 0x06000E32 RID: 3634 RVA: 0x0006144E File Offset: 0x0005F64E
		Public Sub Send(keys As String)
			SendKeys.Send(keys)
		End Sub

		' Token: 0x06000E33 RID: 3635 RVA: 0x00061456 File Offset: 0x0005F656
		Public Sub SendWait(keys As String)
			SendKeys.SendWait(keys)
		End Sub

		' Token: 0x06000E34 RID: 3636 RVA: 0x0006145E File Offset: 0x0005F65E
		Public Sub Flush()
			SendKeys.Flush()
		End Sub
	End Class
End Namespace
