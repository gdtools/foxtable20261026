Imports System
Imports System.ComponentModel
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000457 RID: 1111
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module Ooo_O
		' Token: 0x06004A6C RID: 19052 RVA: 0x001F58C4 File Offset: 0x001F3AC4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetRemoteImageFile(FileName As String, dc As DataCol) As String
			Dim result As String
			If Not dc.Remote Then
				If Operators.CompareString(dc.DefaultFolder, "", True) > 0 Then
					FileName = dc.DefaultFolder.TrimEnd(New Char() { "\"c }) + "\" + FileName
				End If
				FileName = ooO.OoO0o_o___.O.(FileName)
				result = FileName
			ElseIf dc.FTPClient IsNot Nothing Then
				Dim text As String = OO_00oOO.ProjectPath + "RemoteFiles\" + FileName.Replace("/", "\").Trim(New Char() { "\"c })
				If OO_00oOO.FileSys.FileExists(text) Then
					result = text
				Else
					If O_O0OO.oO_00Ooo___0._..Contains(FileName.ToLower()) Then
						Do
							Thread.Sleep(200)
						Loop While O_O0OO.oO_00Ooo___0._..Contains(FileName.ToLower())
					Else
						dc.FTPClient.Download(FileName, text, True)
					End If
					result = text
				End If
			Else
				result = FileName
			End If
			Return result
		End Function
	End Module
End Namespace
