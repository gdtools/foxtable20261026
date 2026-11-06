Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports C1.Win.C1Input
Imports Foxtable.My

Namespace Foxtable
	' Token: 0x02000313 RID: 787
	<ComVisible(True)>
	Public Class Output
		' Token: 0x06002AD8 RID: 10968 RVA: 0x0012D128 File Offset: 0x0012B328
		<oO0oooo("2642")>
		Public Shared Sub Show(Message As String)
			If Output.oo.oOoO0. IsNot Nothing AndAlso Not Output.oo.oOoO0..IsDisposed Then
				If Message Is Nothing Then
					Message = ""
				End If
				Dim c1TextBox As C1TextBox = Output.oo.oOoO0..oo._OoO.()
				c1TextBox.AppendText(Message)
				c1TextBox.AppendText(vbCrLf)
			End If
		End Sub

		' Token: 0x06002AD9 RID: 10969 RVA: 0x0012D164 File Offset: 0x0012B364
		Public Shared Sub Clear()
			If Output.oo.oOoO0. IsNot Nothing AndAlso Not Output.oo.oOoO0..IsDisposed Then
				Output.oo.oOoO0..oo._OoO.().Value = Nothing
			End If
		End Sub

		' Token: 0x17000A19 RID: 2585
		' (get) Token: 0x06002ADA RID: 10970 RVA: 0x0012D18B File Offset: 0x0012B38B
		<oO0oooo("0435")>
		Public Shared ReadOnly Property Logs(Key As String) As Output.Log
			Get
				If Not Output.oo.oOoO0..ContainsKey(Key) Then
					Output.oo.oOoO0..Add(Key, New Output.Log())
				End If
				Return Output.oo.oOoO0.(Key)
			End Get
		End Property

		' Token: 0x17000A1A RID: 2586
		' (get) Token: 0x06002ADB RID: 10971 RVA: 0x0012D1B5 File Offset: 0x0012B3B5
		Public Shared ReadOnly Property Logs As Dictionary(Of String, Output.Log)
			Get
				Return Output.oo.oOoO0.
			End Get
		End Property

		' Token: 0x04001167 RID: 4455
		Private Shared <<EMPTY_NAME>> As Dictionary(Of String, Output.Log) = New Dictionary(Of String, Output.Log)()

		' Token: 0x04001168 RID: 4456
		Friend Shared <<EMPTY_NAME>> As oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000

		' Token: 0x02000314 RID: 788
		<oO0oooo("0435")>
		<ComVisible(True)>
		Public Class Log
			' Token: 0x06002ADC RID: 10972 RVA: 0x0012D1BC File Offset: 0x0012B3BC
			Public Sub New()
				Me.Builder = New StringBuilder()
			End Sub

			' Token: 0x17000A1B RID: 2587
			' (get) Token: 0x06002ADD RID: 10973 RVA: 0x0012D1CF File Offset: 0x0012B3CF
			' (set) Token: 0x06002ADE RID: 10974 RVA: 0x0012D1D7 File Offset: 0x0012B3D7
			Private Overridable Property Builder As StringBuilder

			' Token: 0x06002ADF RID: 10975 RVA: 0x0012D1E0 File Offset: 0x0012B3E0
			Public Sub Add(Message As String)
				If Me.Builder.Length > 0 Then
					Me.Builder.Append(vbCrLf)
				End If
				Me.Builder.Append(Message)
			End Sub

			' Token: 0x06002AE0 RID: 10976 RVA: 0x0012D20E File Offset: 0x0012B40E
			Public Sub Clear()
				If Me.Builder.Length > 0 Then
					Me.Builder.Remove(0, Me.Builder.Length)
				End If
			End Sub

			' Token: 0x06002AE1 RID: 10977 RVA: 0x0012D238 File Offset: 0x0012B438
			Public Sub Save(FileName As String, Append As Boolean)
				If c.OOOOO.o.().FileSystem.FileExists(FileName) Then
					c.OOOOO.o.().FileSystem.WriteAllText(FileName, vbCrLf, Append)
				End If
				c.OOOOO.o.().FileSystem.WriteAllText(FileName, Me.Builder.ToString(), Append)
				Me.Clear()
			End Sub

			' Token: 0x04001169 RID: 4457
			<AccessedThroughProperty("Builder")>
			<CompilerGenerated()>
			Private <<EMPTY_NAME>> As StringBuilder
		End Class
	End Class
End Namespace
