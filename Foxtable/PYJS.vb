Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000C4 RID: 196
	<ComVisible(True)>
	Public Class PYJS
		' Token: 0x06000878 RID: 2168 RVA: 0x0003A034 File Offset: 0x00038234
		Public Function GetPY(ParamArray args As Object()) As String
			Dim result As String
			Select Case args.Length
				Case 1
					result = PY.GetPY(Conversions.ToString(args(0)))
				Case 2
					result = PY.GetPY(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)))
				Case 3
					result = PY.GetPY(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)), Conversions.ToInteger(args(2)))
				Case Else
					result = Nothing
			End Select
			Return result
		End Function

		' Token: 0x06000879 RID: 2169 RVA: 0x0003A0A8 File Offset: 0x000382A8
		Public Function GetNamePY(ParamArray args As Object()) As String
			Dim result As String
			Select Case args.Length
				Case 1
					result = PY.GetNamePY(Conversions.ToString(args(0)))
				Case 2
					result = PY.GetNamePY(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)))
				Case 3
					result = PY.GetNamePY(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)), Conversions.ToInteger(args(2)))
				Case Else
					result = Nothing
			End Select
			Return result
		End Function

		' Token: 0x0600087A RID: 2170 RVA: 0x0003A11A File Offset: 0x0003831A
		Public Function IsHanzi(char As String) As Boolean
			Return PY.IsHanzi(char(0))
		End Function
	End Class
End Namespace
