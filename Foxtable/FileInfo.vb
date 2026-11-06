Imports System
Imports System.IO
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020000B7 RID: 183
	<ComVisible(True)>
	<oO0oooo("2707")>
	Public Class FileInfo
		' Token: 0x06000787 RID: 1927 RVA: 0x0002F8CC File Offset: 0x0002DACC
		Public Sub New(A_0 As String)
			Me.O0oO_0._o_. = New FileInfo(A_0)
		End Sub

		' Token: 0x170001FA RID: 506
		' (get) Token: 0x06000788 RID: 1928 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		' (set) Token: 0x06000789 RID: 1929 RVA: 0x0002F8ED File Offset: 0x0002DAED
		Public Property CreationTime As DateTime
			Get
				Return Me.O0oO_0._o_..CreationTime
			End Get
			Set(value As DateTime)
				Me.O0oO_0._o_..CreationTime = value
			End Set
		End Property

		' Token: 0x170001FB RID: 507
		' (get) Token: 0x0600078A RID: 1930 RVA: 0x0002F8FB File Offset: 0x0002DAFB
		' (set) Token: 0x0600078B RID: 1931 RVA: 0x0002F908 File Offset: 0x0002DB08
		Public Property LastAccessTime As DateTime
			Get
				Return Me.O0oO_0._o_..LastAccessTime
			End Get
			Set(value As DateTime)
				Me.O0oO_0._o_..LastAccessTime = value
			End Set
		End Property

		' Token: 0x170001FC RID: 508
		' (get) Token: 0x0600078C RID: 1932 RVA: 0x0002F916 File Offset: 0x0002DB16
		' (set) Token: 0x0600078D RID: 1933 RVA: 0x0002F923 File Offset: 0x0002DB23
		Public Property LastWriteTime As DateTime
			Get
				Return Me.O0oO_0._o_..LastWriteTime
			End Get
			Set(value As DateTime)
				Me.O0oO_0._o_..LastWriteTime = value
			End Set
		End Property

		' Token: 0x170001FD RID: 509
		' (get) Token: 0x0600078E RID: 1934 RVA: 0x0002F931 File Offset: 0x0002DB31
		Public ReadOnly Property Length As Long
			Get
				Return Me.O0oO_0._o_..Length
			End Get
		End Property

		' Token: 0x170001FE RID: 510
		' (get) Token: 0x0600078F RID: 1935 RVA: 0x0002F93E File Offset: 0x0002DB3E
		Public ReadOnly Property Name As String
			Get
				Return Me.O0oO_0._o_..Name
			End Get
		End Property

		' Token: 0x170001FF RID: 511
		' (get) Token: 0x06000790 RID: 1936 RVA: 0x0002F94B File Offset: 0x0002DB4B
		Public ReadOnly Property Extension As String
			Get
				Return Me.O0oO_0._o_..Extension
			End Get
		End Property

		' Token: 0x17000200 RID: 512
		' (get) Token: 0x06000791 RID: 1937 RVA: 0x0002F958 File Offset: 0x0002DB58
		' (set) Token: 0x06000792 RID: 1938 RVA: 0x0002F965 File Offset: 0x0002DB65
		Public Property [ReadOnly] As Boolean
			Get
				Return Me.O0oO_0._o_..IsReadOnly
			End Get
			Set(value As Boolean)
				Me.O0oO_0._o_..IsReadOnly = value
			End Set
		End Property

		' Token: 0x17000201 RID: 513
		' (get) Token: 0x06000793 RID: 1939 RVA: 0x0002F973 File Offset: 0x0002DB73
		' (set) Token: 0x06000794 RID: 1940 RVA: 0x0002F985 File Offset: 0x0002DB85
		Public Property Hidden As Boolean
			Get
				Return(Me.O0oO_0._o_..Attributes And FileAttributes.Hidden) > CType(0, FileAttributes)
			End Get
			Set(value As Boolean)
				If value Then
					Me.O0oO_0._o_..Attributes = (Me.O0oO_0._o_..Attributes Or FileAttributes.Hidden)
					Return
				End If
				Me.O0oO_0._o_..Attributes = (Me.O0oO_0._o_..Attributes And Not FileAttributes.Hidden)
			End Set
		End Property

		' Token: 0x17000202 RID: 514
		' (get) Token: 0x06000795 RID: 1941 RVA: 0x0002F9BC File Offset: 0x0002DBBC
		Public ReadOnly Property Path As String
			Get
				Return Me.O0oO_0._o_..DirectoryName
			End Get
		End Property

		' Token: 0x04000243 RID: 579
		Private <<EMPTY_NAME>> As FileInfo
	End Class
End Namespace
