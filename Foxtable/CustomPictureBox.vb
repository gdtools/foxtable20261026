Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003D2 RID: 978
	Friend Class CustomPictureBox
		Inherits System.Windows.Forms.Panel
		Implements O0_0_0_0_

		' Token: 0x17000D96 RID: 3478
		' (get) Token: 0x06003E7D RID: 15997 RVA: 0x001B07BE File Offset: 0x001AE9BE
		' (set) Token: 0x06003E7E RID: 15998 RVA: 0x001B07C8 File Offset: 0x001AE9C8
		Friend Overridable Property PictureBox1 As C1PictureBox
			<CompilerGenerated()>
			Get
				Return Me.O.o__.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As C1PictureBox)
				Dim value2 As AsyncCompletedEventHandler = AddressOf Me.O0O00O0oO0.0.
				Dim value3 As MouseEventHandler = AddressOf Me.O__0o.OOOOo.
				Dim value4 As MouseEventHandler = AddressOf Me.oO_OOoOoO.O0O.
				Dim value5 As MouseEventHandler = AddressOf Me.oO_._o.
				Dim value6 As MouseEventHandler = AddressOf Me.Oo0o.0O0Oo0.
				Dim o.o__. As C1PictureBox = Me.O.o__.
				If o.o__. IsNot Nothing Then
					RemoveHandler o.o__..LoadCompleted, value2
					RemoveHandler o.o__..MouseDoubleClick, value3
					RemoveHandler o.o__..MouseDown, value4
					RemoveHandler o.o__..MouseMove, value5
					RemoveHandler o.o__..MouseUp, value6
				End If
				Me.O.o__. = value
				o.o__. = Me.O.o__.
				If o.o__. IsNot Nothing Then
					AddHandler o.o__..LoadCompleted, value2
					AddHandler o.o__..MouseDoubleClick, value3
					AddHandler o.o__..MouseDown, value4
					AddHandler o.o__..MouseMove, value5
					AddHandler o.o__..MouseUp, value6
				End If
			End Set
		End Property

		' Token: 0x17000D97 RID: 3479
		' (get) Token: 0x06003E7F RID: 15999 RVA: 0x001B0888 File Offset: 0x001AEA88
		' (set) Token: 0x06003E80 RID: 16000 RVA: 0x001B0890 File Offset: 0x001AEA90
		Private Overridable Property httpDown As OOO__0oo_oo
			<CompilerGenerated()>
			Get
				Return Me.o.o0_O_O.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OOO__0oo_oo)
				Dim a_ As OOO__0oo_oo.oOOO = AddressOf Me.O0O00O0oO0.0.
				Dim ooo__0oo_oo As OOO__0oo_oo = Me.o.o0_O_O.
				If ooo__0oo_oo IsNot Nothing Then
					ooo__0oo_oo.o0O_.0o0_oO.(a_)
				End If
				Me.o.o0_O_O. = value
				ooo__0oo_oo = Me.o.o0_O_O.
				If ooo__0oo_oo IsNot Nothing Then
					ooo__0oo_oo.O_o0.0oo0_o.(a_)
				End If
			End Set
		End Property

		' Token: 0x17000D98 RID: 3480
		' (get) Token: 0x06003E81 RID: 16001 RVA: 0x001B08D3 File Offset: 0x001AEAD3
		' (set) Token: 0x06003E82 RID: 16002 RVA: 0x001B08DC File Offset: 0x001AEADC
		Private Overridable Property _FTPClient As FTPClient
			<CompilerGenerated()>
			Get
				Return Me.o.o0_O_O.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FTPClient)
				Dim a_ As FTPClient.oO_o_0OOo__0 = AddressOf Me.O.0O_oo.
				Dim a_2 As FTPClient.O__0O000__Oo = AddressOf Me.O.0O_oo.
				Dim a_3 As FTPClient.Oo__ = AddressOf Me.O.0O_oo.
				Dim ftpclient As FTPClient = Me.o.o0_O_O.
				If ftpclient IsNot Nothing Then
					RemoveHandler ftpclient.DownloadCompleted, a_
					RemoveHandler ftpclient.DownloadError, a_2
					RemoveHandler ftpclient.FileCompared, a_3
				End If
				Me.o.o0_O_O. = value
				ftpclient = Me.o.o0_O_O.
				If ftpclient IsNot Nothing Then
					AddHandler ftpclient.DownloadCompleted, a_
					AddHandler ftpclient.DownloadError, a_2
					AddHandler ftpclient.FileCompared, a_3
				End If
			End Set
		End Property

		' Token: 0x06003E83 RID: 16003 RVA: 0x001B0958 File Offset: 0x001AEB58
		Public Sub New(A_0 As Foxtable.WinForm.Form)
			AddHandler MyBase.ParentChanged, AddressOf Me.Oo0o.0O0Oo0.
			Me.PictureBox1 = New C1PictureBox()
			Me.oOO__OoO.o. = True
			Me.O.Oo. = ""
			Me.PictureBox1.Dock = DockStyle.Fill
			MyBase.Controls.Add(Me.PictureBox1)
			Me.PictureBox1.InitialImage = O_O0OO.o0_OO.000.()
			Me.BackColor = Color.White
			Me.O0O00O0oO0.0.()
			Me.o.o0_O_O. = A_0
		End Sub

		' Token: 0x17000D99 RID: 3481
		' (get) Token: 0x06003E84 RID: 16004 RVA: 0x001B09DF File Offset: 0x001AEBDF
		' (set) Token: 0x06003E85 RID: 16005 RVA: 0x001B09E7 File Offset: 0x001AEBE7
		Friend Property AutoUpdate As Boolean
			Get
				Return Me.oOO__OoO.o.
			End Get
			Set(value As Boolean)
				Me.oOO__OoO.o. = value
			End Set
		End Property

		' Token: 0x17000D9A RID: 3482
		' (get) Token: 0x06003E86 RID: 16006 RVA: 0x001B09F0 File Offset: 0x001AEBF0
		' (set) Token: 0x06003E87 RID: 16007 RVA: 0x001B0A00 File Offset: 0x001AEC00
		Public Property Image As Image
			Get
				Return Me.PictureBox1.Image
			End Get
			Set(value As Image)
				Dim image As Image = Me.PictureBox1.Image
				If image IsNot Nothing Then
					image.Dispose()
				End If
				Me.PictureBox1.Image = value
				Me.O0O00O0oO0.0.()
			End Set
		End Property

		' Token: 0x17000D9B RID: 3483
		' (get) Token: 0x06003E88 RID: 16008 RVA: 0x001B0A36 File Offset: 0x001AEC36
		' (set) Token: 0x06003E89 RID: 16009 RVA: 0x001B0A3E File Offset: 0x001AEC3E
		Public Property SizeMode As ImageSizeMode
			Get
				Return Me.O.o__.
			End Get
			Set(value As ImageSizeMode)
				Me.O.o__. = value
				Me.O0O00O0oO0.0.()
			End Set
		End Property

		' Token: 0x17000D9C RID: 3484
		' (get) Token: 0x06003E8A RID: 16010 RVA: 0x001B0A4D File Offset: 0x001AEC4D
		' (set) Token: 0x06003E8B RID: 16011 RVA: 0x001B0A58 File Offset: 0x001AEC58
		Public Property ImageFile As String
			Get
				Return Me.o.o0_O_O.
			End Get
			Set(value As String)
				Dim text As String = value
				If Me.o.o0_O_O. IsNot Nothing Then
					Dim beforeGetImageEventArgs As BeforeGetImageEventArgs = New BeforeGetImageEventArgs(Me, Me.o.o0_O_O., value)
					Dim a_ As String = "BeforeGetImage_" + Conversions.ToString(MyBase.Tag)
					O_O0OO.OoO_o.oO0o0O.(Me.o.o0_O_O..O_0.O00o_00_O., a_, New Object() { beforeGetImageEventArgs }, False, Me.o.o0_O_O..mmname + "," + MyBase.Name, False)
					text = beforeGetImageEventArgs.File
				End If
				If Operators.CompareString(Me.o.o0_O_O., value, True) <> 0 Then
					Me.o.o0_O_O. = value
					Me.oO0O0Ooo0OO._o. = ""
					Me.oO0O0Ooo0OO._o. = True
					Me.O_0o_0O._00o0o. = False
					Dim c1PictureBox As C1PictureBox = Me.PictureBox1
					If c1PictureBox.Image IsNot Nothing AndAlso c1PictureBox.Image IsNot O_O0OO.o0_OO.000.() AndAlso c1PictureBox.Image IsNot c1PictureBox.ErrorImage Then
						c1PictureBox.Image.Dispose()
					End If
					c1PictureBox.Image = Nothing
					c1PictureBox.Dock = DockStyle.Fill
					If Me.FTPClient IsNot Nothing AndAlso Me.FTPClient.AsyncState = Oo_0.Oo_o_o.__oo. Then
						Me.FTPClient.o_0_.__0OO.()
					End If
					If Me.o000O0O__.o_. Then
						Me.PictureBox1.CancelAsync()
					End If
					Me.O.Oo. = text
					If Operators.CompareString(text, "", True) <> 0 Then
						If text.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) Then
							If Me.httpDown Is Nothing Then
								Me.httpDown = New OOO__0oo_oo()
							End If
							Me.httpDown.o0O_.0o0_oO.()
							Me.oO0O0Ooo0OO._o. = text
							Dim text2 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + Me.O0O00O0oO0.0.(OO_00oOO.FileSys.GetName(Me.oO0O0Ooo0OO._o.))
							If OO_00oOO.FileSys.FileExists(text2) Then
								Me.o000O0O__.o_. = True
								Me.PictureBox1.LoadAsync(text2)
								Return
							End If
						ElseIf Me.FTPClient Is Nothing Then
							If(text.Length < 2 OrElse Operators.CompareString(text.Substring(1, 1), ":", True) <> 0) AndAlso Not text.StartsWith("\\") Then
								If MyBase.DataBindings.Count > 0 Then
									Dim bindingMemberInfo As BindingMemberInfo = MyBase.DataBindings(0).BindingMemberInfo
									If TypeOf MyBase.DataBindings(0).DataSource Is O_0 Then
										Dim text3 As String = CType(MyBase.DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
										If OO_00oOO.Tables.get_Contains(text3) AndAlso OO_00oOO.Tables(text3).Cols.Contains(bindingMemberInfo.BindingField) Then
											Dim dataCol As DataCol = OO_00oOO.Tables(text3).Cols(bindingMemberInfo.BindingField).DataCol
											If Operators.CompareString(dataCol.DefaultFolder, "", True) > 0 Then
												text = dataCol.DefaultFolder.TrimEnd(New Char() { "\"c }) + "\" + text
											End If
										End If
									End If
									bindingMemberInfo = Nothing
								End If
								text = ooO.OoO0o_o___.O.(text)
							End If
							If OO_00oOO.FileSys.FileExists(text) Then
								Me.o000O0O__.o_. = True
								Me.PictureBox1.LoadAsync(text)
								Return
							End If
							Me.o.o0_O_O. = ""
							Return
						Else
							Me.oOO__OoO.o. = ""
							Me.O.o_0. = ""
							Dim text4 As String = text
							Dim text5 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + text4.Replace("/", "\").Trim(New Char() { "\"c })
							If OO_00oOO.FileSys.FileExists(text5) Then
								Me.o000O0O__.o_. = True
								Me.PictureBox1.LoadAsync(text5)
								If Me.AutoUpdate Then
									Me.O.o_0. = text
									Me.O.o__. = DateTime.Now
									Return
								End If
							Else
								Me.PictureBox1.Image = Nothing
								Me.oOO__OoO.o. = text
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17000D9D RID: 3485
		' (get) Token: 0x06003E8C RID: 16012 RVA: 0x001B0E0E File Offset: 0x001AF00E
		' (set) Token: 0x06003E8D RID: 16013 RVA: 0x001B0E18 File Offset: 0x001AF018
		Friend Property FTPClient As FTPClient
			Get
				Return Me._FTPClient
			End Get
			Set(value As FTPClient)
				If value IsNot Nothing Then
					Me._FTPClient = New FTPClient()
					Me._FTPClient.Host = value.Host
					Me._FTPClient.Account = value.Account
					Me._FTPClient.Password = value.Password
					Me._FTPClient.Port = value.Port
					Me._FTPClient.UTF8 = value.UTF8
					If Not Me.oo00__O.0_0. Then
						Me.oo00__O.0_0. = True
						AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.O0O00O0oO0.0.
						AddHandler NetworkChange.NetworkAddressChanged, AddressOf Me.O_.000o_.
						Return
					End If
				Else
					Me._FTPClient = Nothing
				End If
			End Set
		End Property

		' Token: 0x06003E8E RID: 16014 RVA: 0x001B0EC4 File Offset: 0x001AF0C4
		Private Sub <<EMPTY_NAME>>()
			If Me.SizeMode = ImageSizeMode.Normal And Me.PictureBox1.Image IsNot Nothing Then
				Dim width As Integer = Math.Max(MyBase.ClientRectangle.Width, Me.PictureBox1.Image.Size.Width)
				Dim height As Integer = Math.Max(MyBase.ClientRectangle.Height, Me.PictureBox1.Image.Size.Height)
				Me.PictureBox1.Dock = DockStyle.None
				Me.PictureBox1.SetBounds(0, 0, width, height)
			Else
				Me.PictureBox1.Dock = DockStyle.Fill
			End If
			Select Case Me.SizeMode
				Case ImageSizeMode.Normal
					Me.PictureBox1.SizeMode = PictureBoxSizeMode.Normal
					Return
				Case ImageSizeMode.CenterImage
					Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
					Return
				Case ImageSizeMode.StretchImage
					Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
					Return
				Case ImageSizeMode.Zoom
					Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
					Return
				Case Else
					Return
			End Select
		End Sub

		' Token: 0x06003E8F RID: 16015 RVA: 0x001B0FC0 File Offset: 0x001AF1C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As AsyncCompletedEventArgs)
			Me.o000O0O__.o_. = False
			If MyBase.FindForm() IsNot Nothing AndAlso (Me.FTPClient Is Nothing OrElse Not Me.FTPClient.O0.o0.) AndAlso Not MyBase.IsDisposed Then
				If A_1.[Error] Is Nothing AndAlso Not A_1.Cancelled Then
					If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
						OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O0O00O0oO0.0., New Object() { True })
						Return
					End If
				ElseIf OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
					OO_00oOO.BaseMainForm.Invoke(AddressOf Me.O0O00O0oO0.0., New Object() { False })
				End If
			End If
		End Sub

		' Token: 0x06003E90 RID: 16016 RVA: 0x001B1088 File Offset: 0x001AF288
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Not A_0 Then
				If Operators.CompareString(Me.o.o0_O_O., "", True) > 0 Then
					Me.PictureBox1.Image = Me.PictureBox1.ErrorImage
				Else
					Me.PictureBox1.Image = Nothing
				End If
				Me.PictureBox1.Dock = DockStyle.Fill
				Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
				Return
			End If
			Me.O0O00O0oO0.0.()
		End Sub

		' Token: 0x06003E91 RID: 16017 RVA: 0x001B10F0 File Offset: 0x001AF2F0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Not(TypeOf MyBase.Parent Is ControlHolder) AndAlso Operators.CompareString(Me.ImageFile, "", True) > 0 AndAlso Operators.CompareString(Me.O.Oo., "", True) > 0 AndAlso Operators.CompareString(Me.oOO__OoO.o., "", True) = 0 AndAlso Operators.CompareString(Me.oO0O0Ooo0OO._o., "", True) = 0 Then
				If Me.O.Oo..StartsWith("http", StringComparison.CurrentCultureIgnoreCase) Then
					Me.oO0O0Ooo0OO._o. = Me.O.Oo.
					Me.O_0o_0O._00o0o. = True
					Return
				End If
				If(Me.FTPClient IsNot Nothing And Operators.CompareString(Me.oOO__OoO.o., "", True) = 0) AndAlso Me.FTPClient.AsyncState = Oo_0.OOoo0_OO__._o. AndAlso Not O_O0OO.oO_00Ooo___0._..Contains(Me.ImageFile.ToLower()) Then
					Me.oOO__OoO.o. = Me.O.Oo.
					Me.O_0o_0O._00o0o. = True
				End If
			End If
		End Sub

		' Token: 0x06003E92 RID: 16018 RVA: 0x001B11E4 File Offset: 0x001AF3E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Not(TypeOf MyBase.Parent Is ControlHolder) AndAlso A_1.Button = MouseButtons.Left Then
				Me.O.o__. = A_1.X
				Me.oo0_.0_. = A_1.Y
				Me.O.o__. = True
				Me.PictureBox1.Cursor = Cursors.Hand
			End If
		End Sub

		' Token: 0x06003E93 RID: 16019 RVA: 0x001B123C File Offset: 0x001AF43C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Not(TypeOf MyBase.Parent Is ControlHolder) Then
				Dim num As Integer = MyBase.HorizontalScroll.Value - (A_1.X - Me.O.o__.)
				Dim num2 As Integer = MyBase.VerticalScroll.Value - (A_1.Y - Me.oo0_.0_.)
				If Me.O.o__. Then
					If Not(num >= 0 And num <= MyBase.HorizontalScroll.Maximum) Then
						num = MyBase.HorizontalScroll.Value
					End If
					If Not(num2 >= 0 And num2 <= MyBase.VerticalScroll.Maximum) Then
						num2 = MyBase.VerticalScroll.Value
					End If
					MyBase.AutoScrollPosition = New Point(num, num2)
				End If
			End If
		End Sub

		' Token: 0x06003E94 RID: 16020 RVA: 0x001B12F0 File Offset: 0x001AF4F0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Not(TypeOf MyBase.Parent Is ControlHolder) Then
				Me.O.o__. = False
				Me.PictureBox1.Cursor = Cursors.[Default]
			End If
		End Sub

		' Token: 0x06003E95 RID: 16021 RVA: 0x001B1318 File Offset: 0x001AF518
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()) Then
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower())
			End If
			If Operators.CompareString(A_0, Me.ImageFile, True) = 0 Then
				Dim text As String = OO_00oOO.ProjectPath + "RemoteFiles\" + A_0.Replace("/", "\").Trim(New Char() { "\"c })
				If OO_00oOO.FileSys.FileExists(text) Then
					Me.o000O0O__.o_. = True
					Me.PictureBox1.LoadAsync(text)
				End If
			End If
		End Sub

		' Token: 0x06003E96 RID: 16022 RVA: 0x001B13A8 File Offset: 0x001AF5A8
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean)
			If O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()) Then
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower())
			End If
			If Operators.CompareString(A_0, Me.ImageFile, True) = 0 Then
				Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
				Me.PictureBox1.Image = Me.PictureBox1.ErrorImage
			End If
		End Sub

		' Token: 0x06003E97 RID: 16023 RVA: 0x001B1409 File Offset: 0x001AF609
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NetworkAvailabilityEventArgs)
			If Me.FTPClient IsNot Nothing Then
				Me.FTPClient.Connected = False
			End If
		End Sub

		' Token: 0x06003E98 RID: 16024 RVA: 0x001B141F File Offset: 0x001AF61F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.FTPClient IsNot Nothing Then
				Me.FTPClient.Connected = False
			End If
		End Sub

		' Token: 0x06003E99 RID: 16025 RVA: 0x001B1438 File Offset: 0x001AF638
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.FindForm() Is Nothing OrElse (Me.FTPClient IsNot Nothing AndAlso Me.FTPClient.O0.o0.) Then
				RemoveHandler Application.Idle, AddressOf Me.oO_._o.
				RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.O0O00O0oO0.0.
				RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf Me.O_.000o_.
				If Me.FTPClient IsNot Nothing Then
					Me.FTPClient.Connected = False
					Me.FTPClient = Nothing
					Return
				End If
			ElseIf Me.FTPClient IsNot Nothing AndAlso Me.FTPClient.AsyncState = Oo_0.OOoo0_OO__._o. Then
				If Operators.CompareString(Me.oOO__OoO.o., "", True) > 0 Then
					Dim text As String = Me.oOO__OoO.o.
					If text.IndexOf(vbLf) < 0 AndAlso text.IndexOf(vbCr) < 0 Then
						Dim text2 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + text.Replace("/", "\").Trim(New Char() { "\"c })
						If O_O0OO.oO_00Ooo___0._..Contains(text.ToLower()) Then
							Me.oO0O0Ooo0OO._o. = False
							Return
						End If
						Me.oOO__OoO.o. = ""
						Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(text2)
						If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
							OO_00oOO.FileSys.CreateDirectory(parentPath)
						End If
						If OO_00oOO.FileSys.FileExists(text2) AndAlso Not Me.O_0o_0O._00o0o. Then
							Me.o000O0O__.o_. = True
							Me.PictureBox1.LoadAsync(text2)
							Return
						End If
						Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
						Me.PictureBox1.Image = O_O0OO.o0_OO.000.()
						O_O0OO.oO_00Ooo___0._..Add(text.ToLower())
						Me.FTPClient.O_O0Ooo_00.o.(text, text2, False)
						Return
					End If
				ElseIf Operators.CompareString(Me.O.o_0., "", True) > 0 AndAlso (DateTime.Now - Me.O.o__.).TotalSeconds > 2.0 Then
					Dim o.o_0. As String = Me.O.o_0.
					Me.O.o_0. = ""
					Dim a_ As String = OO_00oOO.ProjectPath + "RemoteFiles\" + o.o_0..Replace("/", "\").Trim(New Char() { "\"c })
					Me.FTPClient.O_O_0_O0.oOO.(o.o_0., a_)
					Return
				End If
			ElseIf Operators.CompareString(Me.oO0O0Ooo0OO._o., "", True) > 0 AndAlso Me.httpDown.o0O_.0o0_oO.() Then
				Dim text3 As String = Me.oO0O0Ooo0OO._o.
				Dim text4 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + Me.O0O00O0oO0.0.(OO_00oOO.FileSys.GetName(text3))
				If O_O0OO.oO_00Ooo___0._..Contains(Me.oO0O0Ooo0OO._o..ToLower()) Then
					Me.oO0O0Ooo0OO._o. = False
					Me.O_0o_0O._00o0o. = False
					Return
				End If
				If OO_00oOO.FileSys.FileExists(text4) AndAlso Not Me.oO0O0Ooo0OO._o. AndAlso Not Me.O_0o_0O._00o0o. Then
					Me.oO0O0Ooo0OO._o. = ""
					Me.o000O0O__.o_. = True
					Me.PictureBox1.LoadAsync(text4)
					Return
				End If
				Me.oO0O0Ooo0OO._o. = ""
				O_O0OO.oO_00Ooo___0._..Add(text3.ToLower())
				If OO_00oOO.FileSys.FileExists(text4) AndAlso Me.O_0o_0O._00o0o. Then
					Me.httpDown.o0O_.0o0_oO.(text3, text4, False)
				Else
					Me.httpDown.o0O_.0o0_oO.(text3, text4, True)
				End If
				If Not OO_00oOO.FileSys.FileExists(text4) OrElse Me.O_0o_0O._00o0o. Then
					Me.PictureBox1.Dock = DockStyle.Fill
					Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
					Me.PictureBox1.Image = O_O0OO.o0_OO.000.()
				End If
			End If
		End Sub

		' Token: 0x06003E9A RID: 16026 RVA: 0x001B17C0 File Offset: 0x001AF9C0
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			For Each value As Char In "<>*?/\|:"""
				A_0 = A_0.Replace(Conversions.ToString(value), "")
			Next
			Return A_0
		End Function

		' Token: 0x06003E9B RID: 16027 RVA: 0x001B1800 File Offset: 0x001AFA00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.Parent IsNot Nothing Then
				AddHandler Application.Idle, AddressOf Me.oO_._o.
				Return
			End If
			RemoveHandler Application.Idle, AddressOf Me.oO_._o.
			If Me.oo00__O.0_0. Then
				RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.O0O00O0oO0.0.
				RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf Me.O_.000o_.
			End If
			If Me.FTPClient IsNot Nothing Then
				If Me.FTPClient.Connected Then
					Me.FTPClient.Close()
				End If
				Me.FTPClient = Nothing
				If Operators.CompareString(Me.o.o0_O_O., "", True) > 0 AndAlso O_O0OO.oO_00Ooo___0._..Contains(Me.o.o0_O_O..ToLower()) Then
					O_O0OO.oO_00Ooo___0._..Remove(Me.o.o0_O_O..ToLower())
				End If
			End If
			If Me.httpDown IsNot Nothing Then
				Me.httpDown.o0O_.0o0_oO.()
			End If
		End Sub

		' Token: 0x06003E9C RID: 16028 RVA: 0x001B18DD File Offset: 0x001AFADD
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean)
			If Operators.CompareString(A_0, Me.ImageFile, True) = 0 Then
				Me.oO0O0Ooo0OO._o. = False
				If Not A_2 Then
					Me.O_0o_0O._00o0o. = True
					Me.oOO__OoO.o. = A_0
				End If
			End If
		End Sub

		' Token: 0x17000D9E RID: 3486
		' (get) Token: 0x06003E9D RID: 16029 RVA: 0x001B1906 File Offset: 0x001AFB06
		' (set) Token: 0x06003E9E RID: 16030 RVA: 0x001B190E File Offset: 0x001AFB0E
		Public Property CurrentTabOrder As Integer
			Get
				Return Me.OOOoo.0_oo.
			End Get
			Set(value As Integer)
				Me.OOOoo.0_oo. = value
			End Set
		End Property

		' Token: 0x17000D9F RID: 3487
		' (get) Token: 0x06003E9F RID: 16031 RVA: 0x001B1917 File Offset: 0x001AFB17
		' (set) Token: 0x06003EA0 RID: 16032 RVA: 0x001B191F File Offset: 0x001AFB1F
		Public Property MaxTabOrder As Integer
			Get
				Return Me.O_0o_0O._00o0o.
			End Get
			Set(value As Integer)
				Me.O_0o_0O._00o0o. = value
			End Set
		End Property

		' Token: 0x06003EA1 RID: 16033 RVA: 0x001B1928 File Offset: 0x001AFB28
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			oOO0oo_o0.O00OO_O_oO_.o.(Me, Me.PictureBox1.Controls)
		End Sub

		' Token: 0x06003EA2 RID: 16034 RVA: 0x001B193B File Offset: 0x001AFB3B
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			oOO0oo_o0.O._0O0__o.(Me.PictureBox1.Controls)
		End Sub

		' Token: 0x06003EA3 RID: 16035 RVA: 0x001B1950 File Offset: 0x001AFB50
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean, A_1 As String, A_2 As String, A_3 As Boolean)
			If A_0 AndAlso Not A_3 Then
				If O_O0OO.oO_00Ooo___0._..Contains(A_1.ToLower()) Then
					O_O0OO.oO_00Ooo___0._..Remove(A_1.ToLower())
				End If
				If Operators.CompareString(A_1, Me.O.Oo., True) = 0 AndAlso OO_00oOO.FileSys.FileExists(A_2) Then
					Me.o000O0O__.o_. = True
					Me.PictureBox1.LoadAsync(A_2)
				End If
			End If
			If Not A_0 AndAlso Operators.CompareString(A_1, Me.O.Oo., True) = 0 AndAlso Me.PictureBox1.Image Is O_O0OO.o0_OO.000.() Then
				Me.PictureBox1.Image = Me.PictureBox1.ErrorImage
			End If
		End Sub

		' Token: 0x04001957 RID: 6487
		<AccessedThroughProperty("PictureBox1")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1PictureBox

		' Token: 0x04001958 RID: 6488
		<AccessedThroughProperty("httpDown")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OOO__0oo_oo

		' Token: 0x04001959 RID: 6489
		Private <<EMPTY_NAME>> As ImageSizeMode

		' Token: 0x0400195A RID: 6490
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400195B RID: 6491
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400195C RID: 6492
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400195D RID: 6493
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400195E RID: 6494
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x0400195F RID: 6495
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001960 RID: 6496
		<CompilerGenerated()>
		<AccessedThroughProperty("_FTPClient")>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04001961 RID: 6497
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001962 RID: 6498
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001963 RID: 6499
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001964 RID: 6500
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001965 RID: 6501
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001966 RID: 6502
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001967 RID: 6503
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04001968 RID: 6504
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001969 RID: 6505
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400196A RID: 6506
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400196B RID: 6507
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x020003D3 RID: 979
		' (Invoke) Token: 0x06003EA7 RID: 16039
		Private Delegate Sub oo0ooOoOOoO__(A_0 As Boolean)
	End Class
End Namespace
