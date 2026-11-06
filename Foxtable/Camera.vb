Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200024B RID: 587
	<ComVisible(True)>
	Public Class Camera
		' Token: 0x06001B41 RID: 6977 RVA: 0x000ACABC File Offset: 0x000AACBC
		Public Sub Capture()
			Dim frmCamera As frmCamera = New frmCamera()
			SendKeys.Send("{ENTER}")
			If frmCamera.ShowDialog() = DialogResult.OK Then
				Me.o.o___O0O_O. = frmCamera.picCapture.Image
			End If
		End Sub

		' Token: 0x17000634 RID: 1588
		' (get) Token: 0x06001B42 RID: 6978 RVA: 0x000ACAF3 File Offset: 0x000AACF3
		Public ReadOnly Property Image As Image
			Get
				Return Me.o.o___O0O_O.
			End Get
		End Property

		' Token: 0x06001B43 RID: 6979 RVA: 0x000ACAFB File Offset: 0x000AACFB
		Public Sub Save(fl As String)
			If Me.Image IsNot Nothing Then
				If OO_00oOO.FileSys.FileExists(fl) Then
					OO_00oOO.FileSys.DeleteFile(fl)
				End If
				Me.Image.Save(fl, O_O0OO.OoO_00._.(fl))
			End If
		End Sub

		' Token: 0x04000B8B RID: 2955
		Private <<EMPTY_NAME>> As Image
	End Class
End Namespace
