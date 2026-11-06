Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000F7 RID: 247
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class AudioJs
		' Token: 0x06000D58 RID: 3416 RVA: 0x0005F1B3 File Offset: 0x0005D3B3
		Public Sub Play(ParamArray args As Object())
			If args.Length = 1 Then
				Me.Play(Conversions.ToString(args(0)))
				Return
			End If
			If args.Length = 2 Then
				Me.Play(Conversions.ToString(args(0)), CType(Conversions.ToInteger(args(1)), AudioPlayMode))
			End If
		End Sub

		' Token: 0x06000D59 RID: 3417 RVA: 0x0005F1E6 File Offset: 0x0005D3E6
		Public Sub Play(file As String)
			OO_00oOO.Audio.Play(file)
		End Sub

		' Token: 0x06000D5A RID: 3418 RVA: 0x0005F1F3 File Offset: 0x0005D3F3
		Public Sub Play(file As String, mode As AudioPlayMode)
			OO_00oOO.Audio.Play(file, mode)
		End Sub

		' Token: 0x06000D5B RID: 3419 RVA: 0x0005F201 File Offset: 0x0005D401
		Public Sub [Stop]()
			OO_00oOO.Audio.[Stop]()
		End Sub
	End Class
End Namespace
