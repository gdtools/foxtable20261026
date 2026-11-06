Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000250 RID: 592
	<oO0oooo("2486")>
	Public NotInheritable Module FoxFinger
		' Token: 0x06001B60 RID: 7008 RVA: 0x000AD740 File Offset: 0x000AB940
		Shared Sub New()
			If FoxFinger.Reader Is Nothing Then
				FoxFinger.Reader = New O_O()
			End If
		End Sub

		' Token: 0x06001B61 RID: 7009 RVA: 0x000AD753 File Offset: 0x000AB953
		Public Sub Start()
			FoxFinger.Reader.O00._o.()
		End Sub

		' Token: 0x06001B62 RID: 7010 RVA: 0x000AD75F File Offset: 0x000AB95F
		Public Sub [Stop]()
			If FoxFinger.Reader.o0o.O_.() Then
				FoxFinger.Reader.OOO0OO0.o_o.()
			End If
		End Sub

		' Token: 0x06001B63 RID: 7011 RVA: 0x000AD778 File Offset: 0x000AB978
		Public Function Enroll() As String
			Dim result As String
			If FoxFinger.Reader.o0o.O_.() Then
				result = FoxFinger.Reader.O_0_oO.o__.()
			Else
				MessageBox.Show("请先启动指纹采集器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06001B64 RID: 7012 RVA: 0x000AD7B8 File Offset: 0x000AB9B8
		Public Function Verify(TemplateString As String, featuresString As String) As Boolean
			Dim result As Boolean
			If FoxFinger.Reader.o0o.O_.() Then
				result = FoxFinger.Reader.O00._o.(TemplateString, featuresString)
			Else
				MessageBox.Show("请先启动指纹采集器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			End If
			Return result
		End Function

		' Token: 0x17000635 RID: 1589
		' (get) Token: 0x06001B65 RID: 7013 RVA: 0x000AD7F8 File Offset: 0x000AB9F8
		Public ReadOnly Property SerialNumber As String
			Get
				Dim result As String
				If FoxFinger.Reader.o0o.O_.() Then
					result = FoxFinger.Reader.o0o.O_.()
				Else
					MessageBox.Show("请先启动指纹采集器！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = ""
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000636 RID: 1590
		' (get) Token: 0x06001B66 RID: 7014 RVA: 0x000AD838 File Offset: 0x000ABA38
		Public ReadOnly Property Ready As Boolean
			Get
				Return FoxFinger.Reader.o0o.O_.()
			End Get
		End Property

		' Token: 0x04000BA5 RID: 2981
		Private Reader As O_O
	End Module
End Namespace
