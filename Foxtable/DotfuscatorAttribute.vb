Imports System
Imports System.Runtime.InteropServices

' Token: 0x02000002 RID: 2
<AttributeUsage(AttributeTargets.Assembly)>
<ComVisible(False)>
Public NotInheritable Class DotfuscatorAttribute
	Inherits Attribute

	' Token: 0x06000001 RID: 1 RVA: 0x000021D4 File Offset: 0x000003D4
	Public Sub New(a As String, c As Integer, b As Boolean)
		Me.a = a
		Me.c = c
		Me.b = b
	End Sub

	' Token: 0x17000001 RID: 1
	' (get) Token: 0x06000002 RID: 2 RVA: 0x000021FC File Offset: 0x000003FC
	Public ReadOnly Property A As String
		Get
			Return Me.a
		End Get
	End Property

	' Token: 0x17000002 RID: 2
	' (get) Token: 0x06000003 RID: 3 RVA: 0x00002210 File Offset: 0x00000410
	Public ReadOnly Property B As Boolean
		Get
			Return Me.b
		End Get
	End Property

	' Token: 0x17000003 RID: 3
	' (get) Token: 0x06000004 RID: 4 RVA: 0x00002224 File Offset: 0x00000424
	Public ReadOnly Property C As Integer
		Get
			Return Me.c
		End Get
	End Property

	' Token: 0x04000001 RID: 1
	Private a As String

	' Token: 0x04000002 RID: 2
	Private b As Boolean

	' Token: 0x04000003 RID: 3
	Private c As Integer
End Class
