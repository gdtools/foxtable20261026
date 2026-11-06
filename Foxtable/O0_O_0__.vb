Imports System
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000271 RID: 625
	Friend Class O0_O_0__
		Inherits ListBox

		' Token: 0x06001E1C RID: 7708 RVA: 0x000C04F0 File Offset: 0x000BE6F0
		Protected Overrides Function IsInputKey(keyData As Keys) As Boolean
			Return keyData = Keys.Tab OrElse MyBase.IsInputKey(keyData)
		End Function
	End Class
End Namespace
