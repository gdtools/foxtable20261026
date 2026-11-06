Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x02000315 RID: 789
	<oO0oooo("0353")>
	<ComVisible(True)>
	Public Class Process
		' Token: 0x06002AE2 RID: 10978 RVA: 0x0012D28F File Offset: 0x0012B48F
		Public Sub New()
			Me.o0O0.O0_o. = New Process()
		End Sub

		' Token: 0x17000A1C RID: 2588
		' (get) Token: 0x06002AE3 RID: 10979 RVA: 0x0012D2A2 File Offset: 0x0012B4A2
		' (set) Token: 0x06002AE4 RID: 10980 RVA: 0x0012D2B4 File Offset: 0x0012B4B4
		Public Property File As String
			Get
				Return Me.o0O0.O0_o..StartInfo.FileName
			End Get
			Set(value As String)
				Me.o0O0.O0_o..StartInfo.FileName = value
			End Set
		End Property

		' Token: 0x17000A1D RID: 2589
		' (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0012D2C7 File Offset: 0x0012B4C7
		' (set) Token: 0x06002AE6 RID: 10982 RVA: 0x0012D2D9 File Offset: 0x0012B4D9
		Public Property Verb As String
			Get
				Return Me.o0O0.O0_o..StartInfo.Verb
			End Get
			Set(value As String)
				Me.o0O0.O0_o..StartInfo.Verb = value
			End Set
		End Property

		' Token: 0x17000A1E RID: 2590
		' (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0012D2EC File Offset: 0x0012B4EC
		Public ReadOnly Property Verbs As String()
			Get
				Return Me.o0O0.O0_o..StartInfo.Verbs
			End Get
		End Property

		' Token: 0x17000A1F RID: 2591
		' (get) Token: 0x06002AE8 RID: 10984 RVA: 0x0012D2FE File Offset: 0x0012B4FE
		' (set) Token: 0x06002AE9 RID: 10985 RVA: 0x0012D310 File Offset: 0x0012B510
		Public Property Arguments As String
			Get
				Return Me.o0O0.O0_o..StartInfo.Arguments
			End Get
			Set(value As String)
				Me.o0O0.O0_o..StartInfo.Arguments = value
			End Set
		End Property

		' Token: 0x17000A20 RID: 2592
		' (get) Token: 0x06002AEA RID: 10986 RVA: 0x0012D323 File Offset: 0x0012B523
		' (set) Token: 0x06002AEB RID: 10987 RVA: 0x0012D32B File Offset: 0x0012B52B
		Public Property WaitForClose As Boolean
			Get
				Return Me.o0O0.O0_o.
			End Get
			Set(value As Boolean)
				Me.o0O0.O0_o. = value
			End Set
		End Property

		' Token: 0x06002AEC RID: 10988 RVA: 0x0012D334 File Offset: 0x0012B534
		Public Sub Start()
			Try
				Me.o0O0.O0_o..Start()
				If Me.WaitForClose Then
					Me.o0O0.O0_o..WaitForExit()
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x17000A21 RID: 2593
		' (get) Token: 0x06002AED RID: 10989 RVA: 0x0012D38C File Offset: 0x0012B58C
		' (set) Token: 0x06002AEE RID: 10990 RVA: 0x0012D399 File Offset: 0x0012B599
		Public Property StartInfo As ProcessStartInfo
			Get
				Return Me.o0O0.O0_o..StartInfo
			End Get
			Set(value As ProcessStartInfo)
				Me.o0O0.O0_o..StartInfo = value
			End Set
		End Property

		' Token: 0x06002AEF RID: 10991 RVA: 0x0012D3A7 File Offset: 0x0012B5A7
		Public Shared Function Start(fileName As String) As Process
			Return Process.Start(fileName)
		End Function

		' Token: 0x06002AF0 RID: 10992 RVA: 0x0012D3AF File Offset: 0x0012B5AF
		Public Sub Close()
			Me.o0O0.O0_o..CloseMainWindow()
			Me.o0O0.O0_o..Close()
		End Sub

		' Token: 0x06002AF1 RID: 10993 RVA: 0x0012D3C8 File Offset: 0x0012B5C8
		Public Sub WaitForExit()
			Me.o0O0.O0_o..WaitForExit()
		End Sub

		' Token: 0x17000A22 RID: 2594
		' (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0012D3D5 File Offset: 0x0012B5D5
		Public ReadOnly Property MainWindowHandle As IntPtr
			Get
				Return Me.o0O0.O0_o..MainWindowHandle
			End Get
		End Property

		' Token: 0x17000A23 RID: 2595
		' (get) Token: 0x06002AF3 RID: 10995 RVA: 0x0012D3E2 File Offset: 0x0012B5E2
		Public ReadOnly Property HasExited As Boolean
			Get
				Return Me.o0O0.O0_o..HasExited
			End Get
		End Property

		' Token: 0x06002AF4 RID: 10996 RVA: 0x0012D3EF File Offset: 0x0012B5EF
		Public Function WaitForInputIdle() As Boolean
			Return Me.o0O0.O0_o..WaitForInputIdle()
		End Function

		' Token: 0x0400116A RID: 4458
		Private <<EMPTY_NAME>> As Process

		' Token: 0x0400116B RID: 4459
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
