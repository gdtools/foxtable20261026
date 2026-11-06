Imports System
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports DPFP
Imports DPFP.Capture
Imports DPFP.Processing
Imports DPFP.Verification
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200024E RID: 590
	Friend Class O_O
		Inherits EventHandler

		' Token: 0x06001B4D RID: 6989 RVA: 0x000ACB38 File Offset: 0x000AAD38
		Friend Sub <<EMPTY_NAME>>()
			If Me.O00._o. IsNot Nothing Then
				Me.O00._o..StopCapture()
			End If
			Me.O00._o. = Nothing
			Me.ooo0o.ooo_ooO. = Nothing
			Me.O00._o. = False
			If Not OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "finger.lic") Then
				Dim catalogClass As CatalogClass = New CatalogClass()
				catalogClass.Create(Oo00.o00.0OO.(O_O0OO.o.00O_O.() + "finger.lic"))
				Dim table As Table = New TableClass()
				Dim index As Index = New IndexClass()
				table.Name = "~TMPCLPFinger"
				table.Columns.Append("SN", 202, 48)
				table.Columns.Append("RG", 202, 48)
				index.Name = "PrimaryKey"
				index.Columns.Append("SN", 202, 0)
				index.PrimaryKey = True
				index.Unique = True
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
				catalogClass.Tables.Append(table)
				CType(catalogClass.ActiveConnection, Connection).Close()
			End If
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(Oo00.o_._0OOo.(O_O0OO.o.00O_O.() + "finger.lic"))
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			oleDbCommand.Connection = oleDbConnection
			Dim readersCollection As ReadersCollection
			Try
				readersCollection = New ReadersCollection()
			Catch ex As Exception
				MessageBox.Show("请安装指纹仪驱动程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End Try
			If readersCollection.Count = 0 Then
				MessageBox.Show("没有检测到指纹仪！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Dim num As Integer = readersCollection.Count - 1
			Dim num2 As Integer = 0
			If num2 <= num Then
				Me.ooo0o.ooo_ooO. = readersCollection(num2)
				oleDbCommand.CommandText = "select rg from [~TMPCLPFinger] where sn = '" + Me.ooo0o.ooo_ooO..SerialNumber + "'"
				Dim text As String = ""
				oleDbConnection.Open()
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar())
				oleDbConnection.Close()
				Dim o0O_o As O_O.O0O_o = New O_O.O0O_o()
				If objectValue IsNot Nothing Then
					text = objectValue.ToString()
				End If
				If Operators.CompareString(text, "", True) = 0 OrElse Not o0O_o.linkfinger(Me.ooo0o.ooo_ooO..SerialNumber, text) Then
					Dim o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u As o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002 = New o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002()
					o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u.oOoOOO00.0_.().Text = Me.ooo0o.ooo_ooO..SerialNumber
					While o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u.ShowDialog() <> DialogResult.Cancel
						text = o_u3002_u3002_u30000O_u3000o_u3000_u3000_u3000_u.o._o0_Oo00_0.().Text.Trim()
						If o0O_o.linkfinger(Me.ooo0o.ooo_ooO..SerialNumber, text) Then
							oleDbConnection.Open()
							oleDbCommand.CommandText = "Delete  from [~TMPCLPFinger] where sn = '" + Me.ooo0o.ooo_ooO..SerialNumber + "'"
							oleDbCommand.ExecuteNonQuery()
							oleDbCommand.CommandText = String.Concat(New String() { "Insert into [~TMPCLPFinger] (SN,RG) Values('", Me.ooo0o.ooo_ooO..SerialNumber, "','", text, "')" })
							oleDbCommand.ExecuteNonQuery()
							oleDbConnection.Close()
							GoTo IL_306
						End If
						MessageBox.Show("请输入正确的激活码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End While
					Me.ooo0o.ooo_ooO. = Nothing
					Return
				End If
				IL_306:
				Me.O00._o. = New Capture(Me.ooo0o.ooo_ooO..SerialNumber)
				If Me.O00._o. IsNot Nothing Then
					Me.O00._o..EventHandler = Me
					Me.O00._o..StartCapture()
				End If
				Me.O00._o. = True
			End If
			If Not Me.O00._o. Then
				Me.ooo0o.ooo_ooO. = Nothing
				MessageBox.Show("没有找到指定型号的指纹仪！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End If
		End Sub

		' Token: 0x06001B4E RID: 6990 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		Public Sub <<EMPTY_NAME>>()
			If Me.O00._o. IsNot Nothing Then
				Me.O00._o..StopCapture()
			End If
			Me.O00._o. = Nothing
			Me.ooo0o.ooo_ooO. = Nothing
			Me.O00._o. = False
		End Sub

		' Token: 0x06001B4F RID: 6991 RVA: 0x000ACEF0 File Offset: 0x000AB0F0
		Public Function <<EMPTY_NAME>>() As String
			Me.O__O.oo_Ooo. = True
			If Me.O00._o. Is Nothing Then
				Me.O00._o. = New Enrollment()
			End If
			Me.O00._o..Clear()
			Dim o_u3000O_u3000_u3002o_u3002_u3000_u3000_u3002_u3002_u As o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020 = New o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020()
			Me.O00._o. = o_u3000O_u3000_u3002o_u3002_u3000_u3000_u3002_u3002_u
			Dim result As String = ""
			If o_u3000O_u3000_u3002o_u3002_u3000_u3000_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
				Dim inArray As Byte() = New Byte(100) {}
				Me.O00._o..Template.Serialize(inArray)
				result = Convert.ToBase64String(inArray)
			End If
			Me.O00._o..Clear()
			Me.O00._o..Close()
			Me.O00._o. = Nothing
			Me.O__O.oo_Ooo. = False
			Return result
		End Function

		' Token: 0x06001B50 RID: 6992 RVA: 0x000ACF88 File Offset: 0x000AB188
		Public Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			If Me.ooo0o.ooo_ooO. Is Nothing Then
				Me.ooo0o.ooo_ooO. = New Verification()
			End If
			Dim result As Verification.Result = New Verification.Result()
			Dim array As Byte() = Convert.FromBase64String(A_0)
			Dim array2 As Byte() = Convert.FromBase64String(A_1)
			Dim template As Template = New Template()
			Dim featureSet As FeatureSet = New FeatureSet()
			template.DeSerialize(array)
			featureSet.DeSerialize(array2)
			Me.ooo0o.ooo_ooO..Verify(featureSet, template, result)
			Return result.Verified
		End Function

		' Token: 0x06001B51 RID: 6993 RVA: 0x000ACFEE File Offset: 0x000AB1EE
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O00._o.
		End Function

		' Token: 0x06001B52 RID: 6994 RVA: 0x000ACFF8 File Offset: 0x000AB1F8
		Public Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Me.o0o.O_.() Then
				result = Me.ooo0o.ooo_ooO..SerialNumber
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06001B53 RID: 6995 RVA: 0x000AD024 File Offset: 0x000AB224
		Protected Function <<EMPTY_NAME>>(A_0 As Sample) As Bitmap
			Dim sampleConversion As SampleConversion = New SampleConversion()
			Dim result As Bitmap = Nothing
			sampleConversion.ConvertToPicture(A_0, result)
			Return result
		End Function

		' Token: 0x06001B54 RID: 6996 RVA: 0x000AD044 File Offset: 0x000AB244
		Protected Function <<EMPTY_NAME>>(A_0 As Sample, A_1 As DataPurpose, ByRef A_2 As CaptureFeedback) As FeatureSet
			Dim featureExtraction As FeatureExtraction = New FeatureExtraction()
			Dim featureSet As FeatureSet = New FeatureSet()
			featureExtraction.CreateFeatureSet(A_0, A_1, A_2, featureSet)
			Dim result As FeatureSet
			If A_2 = 0 Then
				result = featureSet
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001B55 RID: 6997 RVA: 0x000AD074 File Offset: 0x000AB274
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String, A_2 As Sample)
			If Me.O__O.oo_Ooo. Then
				Dim original As Bitmap = Me.OOO_.00.(A_2)
				Dim pictureBox As PictureBox = Me.O00._o..oOOoOO._.()
				pictureBox.Image = New Bitmap(original, pictureBox.Size)
				Dim captureFeedback As CaptureFeedback = 1
				Dim featureSet As FeatureSet = Me.o0o.O_.(A_2, 2, captureFeedback)
				If featureSet IsNot Nothing Then
					Try
						Me.O00._o..AddFeatures(featureSet)
						Me.O00._o..oO.oo__0O. = Me.O00._o..oO.oo__0O. + 1
						Dim name As String = [Enum].GetName(GetType(CaptureFeedback), captureFeedback)
						If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
							OO_00oOO.BaseMainForm.Invoke(AddressOf Me.OOO0OO0.o_o., New Object() { name })
						End If
					Catch ex As Exception
						MessageBox.Show("指纹模板采集失败！", "提示", MessageBoxButtons.OK)
						Return
					End Try
					Dim templateStatus As Enrollment.Status = Me.O00._o..TemplateStatus
					If templateStatus = 2 Then
						Me.O00._o..DialogResult = DialogResult.Cancel
						Return
					End If
					If templateStatus = 3 Then
						Me.O00._o..DialogResult = DialogResult.OK
						Return
					End If
				End If
			Else
				Dim captureFeedback2 As CaptureFeedback = 1
				Dim featureSet2 As FeatureSet = Me.o0o.O_.(A_2, 1, captureFeedback2)
				If featureSet2 IsNot Nothing Then
					Dim inArray As Byte() = New Byte(100) {}
					featureSet2.Serialize(inArray)
					Dim text As String = Convert.ToBase64String(inArray)
					If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						OO_00oOO.BaseMainForm.Invoke(AddressOf Me.o0o.O_., New Object() { text, A_2 })
					End If
				End If
			End If
		End Sub

		' Token: 0x06001B56 RID: 6998 RVA: 0x000AD208 File Offset: 0x000AB408
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Sample)
			Dim fingerCaptureEventArgs As FingerCaptureEventArgs = New FingerCaptureEventArgs(A_0, A_1)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FingerCapture", New Object() { fingerCaptureEventArgs }, False, "项目", False)
		End Sub

		' Token: 0x06001B57 RID: 6999 RVA: 0x000AD23E File Offset: 0x000AB43E
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O00._o..O_oO_0._0o.().Text = A_0
		End Sub

		' Token: 0x06001B58 RID: 7000 RVA: 0x000AD251 File Offset: 0x000AB451
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O00._o..oo__0O.OOoo.().Text = A_0
		End Sub

		' Token: 0x06001B59 RID: 7001 RVA: 0x000AD264 File Offset: 0x000AB464
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String)
			If Me.O__O.oo_Ooo. AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O00._o., New Object() { "手指离开" })
			End If
		End Sub

		' Token: 0x06001B5A RID: 7002 RVA: 0x000AD2B4 File Offset: 0x000AB4B4
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String)
			If Me.O__O.oo_Ooo. AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O00._o., New Object() { "手指接触" })
			End If
		End Sub

		' Token: 0x06001B5B RID: 7003 RVA: 0x000AD301 File Offset: 0x000AB501
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String)
		End Sub

		' Token: 0x06001B5C RID: 7004 RVA: 0x000AD303 File Offset: 0x000AB503
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String)
		End Sub

		' Token: 0x06001B5D RID: 7005 RVA: 0x000AD305 File Offset: 0x000AB505
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As String, A_2 As CaptureFeedback)
		End Sub

		' Token: 0x04000B8C RID: 2956
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B8D RID: 2957
		Private <<EMPTY_NAME>> As Capture

		' Token: 0x04000B8E RID: 2958
		Private <<EMPTY_NAME>> As ReaderDescription

		' Token: 0x04000B8F RID: 2959
		Private <<EMPTY_NAME>> As Enrollment

		' Token: 0x04000B90 RID: 2960
		Private <<EMPTY_NAME>> As Verification

		' Token: 0x04000B91 RID: 2961
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B92 RID: 2962
		Private <<EMPTY_NAME>> As o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020

		' Token: 0x0200024F RID: 591
		Private Class O0O_o
			' Token: 0x06001B5F RID: 7007 RVA: 0x000AD310 File Offset: 0x000AB510
			Friend Function linkfinger(sn As String, rg As String) As Boolean
				Dim num As Integer
				Dim result As Boolean
				Dim num5 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					IL_09:
					num2 = 3
					Me.Oo_00._o0oo_. = sn
					IL_12:
					num2 = 4
					Me.OoO0._0O__o. = Strings.Left(Me.Oo_00._o0oo_., 4)
					IL_26:
					num2 = 5
					Me.Ooo_OoOO.o0o. = Strings.Right(Me.Oo_00._o0oo_., 4)
					IL_3A:
					num2 = 6
					Me.O0O0O00.o00_. = O00.EncryptText(Me.Oo_00._o0oo_., Me.OoO0._0O__o., Me.Ooo_OoOO.o0o.)
					IL_59:
					num2 = 7
					Me.O0O0O00.o00_. = O00.ooo000o_0.00o0.(Me.O0O0O00.o00_., Me.OoO0._0O__o., Me.Ooo_OoOO.o0o.)
					IL_78:
					num2 = 8
					Me.O0O0O00.o00_. = o_o_O0OO_0__.o000oOoo.0.(Me.Oo_00._o0oo_.)
					IL_8B:
					num2 = 9
					Me.Oo_00._o0oo_. = Me.O0O0O00.o00_..ToCharArray()
					IL_9F:
					num2 = 10
					Me.oo_._O. = rg
					IL_A9:
					num2 = 11
					Me.oo_._O. = Me.oo_._O..Replace("-", "")
					IL_C7:
					num2 = 12
					If Me.oo_._O..Length <> 16 Then
						GoTo IL_310
					End If
					IL_DC:
					num2 = 13
					Dim num3 As Integer = 0
					Do
						IL_E2:
						num2 = 14
						Me.Oo_00._o0oo_. = CInt(Me.Oo_00._o0oo_.(num3))
						IL_F4:
						num2 = 15
						Me.o._Oo__. = CInt(Me.Oo_00._o0oo_.(num3 + 15))
						IL_109:
						num2 = 16
						Me.o__O0O_.o_. += Conversions.ToString((Me.Oo_00._o0oo_. + Me.o._Oo__.) Mod 10)
						IL_132:
						num2 = 17
						num3 += 1
					Loop While num3 <= 15
					IL_141:
					num2 = 18
					Me.OO0O_0.o_. = Conversions.ToInteger(Me.o__O0O_.o_..Substring(0, 4))
					IL_15C:
					num2 = 19
					Me.o_o__.0O_0. = Conversions.ToInteger(Me.o__O0O_.o_..Substring(4, 4))
					IL_177:
					num2 = 20
					Me.oOO.OoO0o. = Conversions.ToInteger(Me.o__O0O_.o_..Substring(8, 4))
					IL_192:
					num2 = 21
					Me.o.0__0_0o0o. = Conversions.ToInteger(Me.o__O0O_.o_..Substring(12, 4))
					IL_1AE:
					num2 = 22
					Me.oo__oO_.o0O_o_. = Conversions.ToInteger(Me.oo_._O..Substring(0, 4))
					IL_1C9:
					num2 = 23
					Me.o.o00o. = Conversions.ToInteger(Me.oo_._O..Substring(4, 4))
					IL_1E4:
					num2 = 24
					Me.o0._OO__. = Conversions.ToInteger(Me.oo_._O..Substring(8, 4))
					IL_1FF:
					num2 = 25
					Me.O.o0_OO_O0o. = Conversions.ToInteger(Me.oo_._O..Substring(12, 4))
					IL_21B:
					num2 = 26
					If(Me.oo__oO_.o0O_o_. Xor Me.o_o__.0O_0.) = Me.OO0O_0.o_. OrElse (Me.oo__oO_.o0O_o_. + 10000 Xor Me.o_o__.0O_0.) = Me.OO0O_0.o_. Then
						GoTo IL_258
					End If
					IL_24E:
					num2 = 27
					result = False
					GoTo IL_315
					IL_258:
					num2 = 28
					If(Me.o.o00o. Xor Me.o_o__.0O_0.) = Me.oo__oO_.o0O_o_. OrElse (Me.o.o00o. + 10000 Xor Me.o_o__.0O_0.) = Me.oo__oO_.o0O_o_. Then
						GoTo IL_295
					End If
					IL_28B:
					num2 = 29
					result = False
					GoTo IL_315
					IL_295:
					num2 = 30
					If(Me.o0._OO__. Xor Me.oOO.OoO0o.) = Me.o.o00o. OrElse (Me.o0._OO__. + 10000 Xor Me.oOO.OoO0o.) = Me.o.o00o. Then
						GoTo IL_2CF
					End If
					IL_2C8:
					num2 = 31
					result = False
					GoTo IL_315
					IL_2CF:
					num2 = 32
					If Me.O.o0_OO_O0o. = Me.o.0__0_0o0o. + Me.oOO.OoO0o. OrElse Me.O.o0_OO_O0o. + 9999 = Me.o.0__0_0o0o. + Me.oOO.OoO0o. Then
						GoTo IL_309
					End If
					IL_302:
					num2 = 33
					result = False
					GoTo IL_315
					IL_309:
					num2 = 34
					result = True
					GoTo IL_315
					IL_310:
					num2 = 36
					result = False
					IL_315:
					GoTo IL_3FB
					IL_31A:
					Dim num4 As Integer = num5 + 1
					num5 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
					IL_3BC:
					GoTo IL_3F0
					IL_3BE:
					num5 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3CE:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_3BE
				End Try
				IL_3F0:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_3FB:
				If num5 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x04000B93 RID: 2963
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000B94 RID: 2964
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000B95 RID: 2965
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000B96 RID: 2966
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000B97 RID: 2967
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000B98 RID: 2968
			Private <<EMPTY_NAME>> As Char()

			' Token: 0x04000B99 RID: 2969
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000B9A RID: 2970
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000B9B RID: 2971
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000B9C RID: 2972
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000B9D RID: 2973
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000B9E RID: 2974
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000B9F RID: 2975
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000BA0 RID: 2976
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000BA1 RID: 2977
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000BA2 RID: 2978
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000BA3 RID: 2979
			Private <<EMPTY_NAME>> As Integer

			' Token: 0x04000BA4 RID: 2980
			Private <<EMPTY_NAME>> As String
		End Class
	End Class
End Namespace
