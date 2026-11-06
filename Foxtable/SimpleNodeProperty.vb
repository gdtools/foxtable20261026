Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020002B0 RID: 688
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class SimpleNodeProperty
		' Token: 0x0600247B RID: 9339 RVA: 0x000FAA98 File Offset: 0x000F8C98
		Friend Sub New(A_0 As O_o__00Ooo)
			Me.o0O_.00. = A_0
		End Sub

		' Token: 0x1700087A RID: 2170
		' (get) Token: 0x0600247C RID: 9340 RVA: 0x000FAAA7 File Offset: 0x000F8CA7
		' (set) Token: 0x0600247D RID: 9341 RVA: 0x000FAAB4 File Offset: 0x000F8CB4
		<DefaultValue("")>
		Public Property Name As String
			Get
				Return Me.o0O_.00..Name
			End Get
			Set(value As String)
				Me.o0O_.00..Name = value
			End Set
		End Property

		' Token: 0x1700087B RID: 2171
		' (get) Token: 0x0600247E RID: 9342 RVA: 0x000FAAC4 File Offset: 0x000F8CC4
		' (set) Token: 0x0600247F RID: 9343 RVA: 0x000FAAEA File Offset: 0x000F8CEA
		<DefaultValue("")>
		Public Property Text As String
			Get
				Dim result As String
				If Me.o0O_.00. Is Nothing Then
					result = Nothing
				Else
					result = Me.o0O_.00..Text
				End If
				Return result
			End Get
			Set(value As String)
				If Me.o0O_.00. IsNot Nothing Then
					Me.o0O_.00..Text = value
				End If
			End Set
		End Property

		' Token: 0x04000EFE RID: 3838
		Friend <<EMPTY_NAME>> As O_o__00Ooo
	End Class
End Namespace
