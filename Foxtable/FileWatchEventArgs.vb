Imports System
Imports System.ComponentModel
Imports System.IO

Namespace Foxtable
	' Token: 0x0200029C RID: 668
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FileWatchEventArgs
		' Token: 0x060022A0 RID: 8864 RVA: 0x000ECC59 File Offset: 0x000EAE59
		Public Sub New(A_0 As FileSystemEventArgs)
			Me.oooOO.OO. = A_0
		End Sub

		' Token: 0x1700082A RID: 2090
		' (get) Token: 0x060022A1 RID: 8865 RVA: 0x000ECC68 File Offset: 0x000EAE68
		Public ReadOnly Property Name As String
			Get
				Return Me.oooOO.OO..Name
			End Get
		End Property

		' Token: 0x1700082B RID: 2091
		' (get) Token: 0x060022A2 RID: 8866 RVA: 0x000ECC75 File Offset: 0x000EAE75
		Public ReadOnly Property FullPath As String
			Get
				Return Me.oooOO.OO..FullPath
			End Get
		End Property

		' Token: 0x04000E3D RID: 3645
		Private <<EMPTY_NAME>> As FileSystemEventArgs
	End Class
End Namespace
