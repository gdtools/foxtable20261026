Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Timers
Imports System.Windows.Forms
Imports Foxtable.My
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003B1 RID: 945
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0703")>
	<ComVisible(True)>
	Public Class FormCollection
		Implements IEnumerable(Of Foxtable.WinForm.Form)

		' Token: 0x17000D0B RID: 3339
		' (get) Token: 0x06003BA2 RID: 15266 RVA: 0x00199EB0 File Offset: 0x001980B0
		' (set) Token: 0x06003BA3 RID: 15267 RVA: 0x00199EB8 File Offset: 0x001980B8
		Private Overridable Property TT As System.Timers.Timer

		' Token: 0x06003BA4 RID: 15268 RVA: 0x00199EC4 File Offset: 0x001980C4
		Friend Sub New()
			Me.O.o_0oOo_O00. = New Dictionary(Of String, Foxtable.WinForm.Form)()
			Me.O.o_0oOo_O00. = 90
			Me.ooO0_o._o. = False
			Me.O.o_0oOo_O00. = DateTime.Now
			Me.O.o_0oOo_O00. = ""
			Me.TT = New System.Timers.Timer()
			Me.TT.Enabled = True
			Me.TT.Interval = 60000.0
			AddHandler Me.TT.Elapsed, AddressOf Me.ooO0_o._o.
		End Sub

		' Token: 0x06003BA5 RID: 15269 RVA: 0x00199F4C File Offset: 0x0019814C
		Friend Sub <<EMPTY_NAME>>()
			Me.O.o_0oOo_O00..Clear()
			For Each a_ As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()).[Select]("[Type] = " + Conversions.ToString(229) + "Or [Type] = " + Conversions.ToString(233))
				Me.ooO0_o._o.(a_)
			Next
		End Sub

		' Token: 0x06003BA6 RID: 15270 RVA: 0x00199FBC File Offset: 0x001981BC
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow)
			Dim form As Foxtable.WinForm.Form = New Foxtable.WinForm.Form(A_0, False)
			If Not Me.O.o_0oOo_O00..ContainsKey(form.Name) Then
				Me.O.o_0oOo_O00..Add(form.Name, form)
			End If
		End Sub

		' Token: 0x06003BA7 RID: 15271 RVA: 0x00199FF6 File Offset: 0x001981F6
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Foxtable.WinForm.Form)
			Me.O.o_0oOo_O00..Add(A_0, A_1)
		End Sub

		' Token: 0x06003BA8 RID: 15272 RVA: 0x0019A008 File Offset: 0x00198208
		Friend Sub <<EMPTY_NAME>>()
			Try
				For Each form As Foxtable.WinForm.Form In Me.O.o_0oOo_O00..Values
					form.O_0.O00o_00_O. = False
					form.Close()
				Next
			Finally
				Dim enumerator As Dictionary(Of String, Foxtable.WinForm.Form).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each table As Table In OO_00oOO.Tables
					table.CloseRecordGrid()
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of Table)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003BA9 RID: 15273 RVA: 0x0019A0A0 File Offset: 0x001982A0
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O.o_0oOo_O00..Remove(A_0)
		End Sub

		' Token: 0x17000D0C RID: 3340
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(Name As String) As Foxtable.WinForm.Form
			Get
				Dim result As Foxtable.WinForm.Form
				If Me.O.o_0oOo_O00. IsNot Nothing AndAlso Operators.CompareString(Me.O.o_0oOo_O00..Name, Name, True) = 0 Then
					result = Me.O.o_0oOo_O00.
				ElseIf Me.O.o_0oOo_O00..ContainsKey(Name) Then
					If Not Me.ooO0_o._o. AndAlso (DateTime.Now - Me.O.o_0oOo_O00.).TotalSeconds > 480.0 AndAlso Not O_O0OO.O_oO_o0O.o__. Then
						Me.O.o_0oOo_O00..Clear()
					End If
					result = Me.O.o_0oOo_O00.(Name)
				Else
					Try
						For Each text As String In Me.O.o_0oOo_O00..Keys
							If Operators.CompareString(text, Name, True) = 0 Then
								Return Me.O.o_0oOo_O00.(text)
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, Foxtable.WinForm.Form).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					MessageBox.Show("不存在名称为""" + Name + """的窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000D0D RID: 3341
		' (get) Token: 0x06003BAB RID: 15275 RVA: 0x0019A1C0 File Offset: 0x001983C0
		Public ReadOnly Property Count As Integer
			Get
				Return Me.O.o_0oOo_O00..Count
			End Get
		End Property

		' Token: 0x06003BAC RID: 15276 RVA: 0x0019A1D0 File Offset: 0x001983D0
		Public Function Contains(Name As String) As Boolean
			Return(Me.O.o_0oOo_O00. IsNot Nothing AndAlso Operators.CompareString(Me.O.o_0oOo_O00..Name, Name, True) = 0) OrElse Me.O.o_0oOo_O00..ContainsKey(Name)
		End Function

		' Token: 0x06003BAD RID: 15277 RVA: 0x0019A20B File Offset: 0x0019840B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Foxtable.WinForm.Form) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.Form).GetEnumerator
			Return CType(Me.O.o_0oOo_O00..Values.GetEnumerator(), IEnumerator(Of Foxtable.WinForm.Form))
		End Function

		' Token: 0x06003BAE RID: 15278 RVA: 0x0019A227 File Offset: 0x00198427
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.O.o_0oOo_O00..Values.GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x17000D0E RID: 3342
		' (get) Token: 0x06003BAF RID: 15279 RVA: 0x0019A244 File Offset: 0x00198444
		<oO0oooo("1547")>
		Public ReadOnly Property ActiveForm As Foxtable.WinForm.Form
			Get
				If System.Windows.Forms.Form.ActiveForm Is Main.OO_O.o. Then
					Dim control As System.Windows.Forms.Control = Main.OO_O.o..ActiveControl
					While control IsNot Nothing
						If TypeOf control Is FormPanel Then
							If OO_00oOO.Forms.Contains(control.Name) Then
								Return OO_00oOO.Forms(control.Name)
							End If
							Exit While
						Else
							control = control.Parent
						End If
					End While
				ElseIf System.Windows.Forms.Form.ActiveForm IsNot Nothing Then
					Dim activeForm As System.Windows.Forms.Form = System.Windows.Forms.Form.ActiveForm
					If activeForm.Controls.Count > 0 AndAlso TypeOf activeForm.Controls(0)Is FormPanel AndAlso OO_00oOO.Forms.Contains(activeForm.Controls(0).Name) Then
						Return OO_00oOO.Forms(activeForm.Controls(0).Name)
					End If
				End If
				Return Nothing
			End Get
		End Property

		' Token: 0x06003BB0 RID: 15280 RVA: 0x0019A314 File Offset: 0x00198514
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ElapsedEventArgs)
			If OO_00oOO.SystemReady AndAlso Not O_O0OO.O_oO_o0O.o__. Then
				If Me.a = 1 Then
					Me.O.o_0oOo_O00. = "HKEY_CURRENT_USER\Software\" + O00.ooo000o_0.00o0.(o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 4), "Tick", "Tick")
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(Me.O.o_0oOo_O00., "Count", 0))
					If objectValue IsNot Nothing Then
						Integer.TryParse(objectValue.ToString(), Me.o_.O__O00OOO.)
					End If
				End If
				If Me.a = 3 Then
					Me.O.o_0oOo_O00. = -10
					Dim o0OoOo00__Oo As FormCollection.o0OoOo00__Oo0 = New FormCollection.o0OoOo00__Oo0()
					If Me.o_.O__O00OOO. > 60 Then
						O_O0OO.O_O.OOO_o.(True)
					End If
					Me.o_.O__O00OOO. = 180
					If Me.o_.O__O00OOO. > Me.O.o_0oOo_O00. AndAlso Not o0OoOo00__Oo.O.o_0oOo_O00.() Then
						Try
							For Each form As Foxtable.WinForm.Form In OO_00oOO.Forms
								Dim opened As Boolean = form.Opened
							Next
						Finally
							Dim enumerator As IEnumerator(Of Foxtable.WinForm.Form)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						Me.OoO___.0_o. = True
						O_O0OO.O00O0o_O_._O. = False
					End If
					Me.TT.Enabled = False
				End If
				Me.a += 1
			End If
		End Sub

		' Token: 0x040018B2 RID: 6322
		Private <<EMPTY_NAME>> As Dictionary(Of String, Foxtable.WinForm.Form)

		' Token: 0x040018B3 RID: 6323
		<CompilerGenerated()>
		<AccessedThroughProperty("TT")>
		Private <<EMPTY_NAME>> As System.Timers.Timer

		' Token: 0x040018B4 RID: 6324
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040018B5 RID: 6325
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040018B6 RID: 6326
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040018B7 RID: 6327
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040018B8 RID: 6328
		Friend <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x040018B9 RID: 6329
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040018BA RID: 6330
		Private <<EMPTY_NAME>> As String

		' Token: 0x040018BB RID: 6331
		Private a As Integer

		' Token: 0x020003B3 RID: 947
		Private Class o0OoOo00__Oo0
			' Token: 0x06003CD6 RID: 15574 RVA: 0x001AA723 File Offset: 0x001A8923
			Public Sub New()
				Me.O.o_0oOo_O00. = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(8, 4)
				Me.o_0O.O. = o_o_O0OO_0__.O0_O_o.o_.()
				OO_00oOO.Forms.ooO0_o._o. = True
			End Sub

			' Token: 0x06003CD7 RID: 15575 RVA: 0x001AA753 File Offset: 0x001A8953
			Friend Function <<EMPTY_NAME>>() As Boolean
				Return True
			End Function

			' Token: 0x040018F7 RID: 6391
			Private <<EMPTY_NAME>> As String

			' Token: 0x040018F8 RID: 6392
			Private <<EMPTY_NAME>> As String

			' Token: 0x040018F9 RID: 6393
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x040018FA RID: 6394
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x040018FB RID: 6395
			Private <<EMPTY_NAME>> As String
		End Class
	End Class
End Namespace
