Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200051C RID: 1308
	<ComVisible(True)>
	Public Class PictureBox
		Inherits Control
		Implements OoO_

		' Token: 0x060055A9 RID: 21929 RVA: 0x0022192D File Offset: 0x0021FB2D
		Friend Sub New(A_0 As CustomPictureBox)
			MyBase.New(A_0, ControlTypeEnum.PictureBox)
			Me.Oo_.0_0O0o00o. = 21
			Me.oOoo._0o0. = A_0
			Me.oOoo._0o0..AutoScroll = True
			Me.oOoo._0o0..PictureBox1.Enabled = True
		End Sub

		' Token: 0x17001491 RID: 5265
		' (get) Token: 0x060055AA RID: 21930 RVA: 0x00221964 File Offset: 0x0021FB64
		' (set) Token: 0x060055AB RID: 21931 RVA: 0x0022196C File Offset: 0x0021FB6C
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.oOoo._0o0..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If value.StartsWith("全局变量.") Then
						Dim text As String = value.Substring(value.IndexOf("."c) + 1)
						If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
							Me.oOoo._0o0..DataBindings.Add("ImageFile", OO_00oOO.Vars.VariableTable, text)
							Return
						End If
					Else
						Dim binding As Binding = Oo00.OO.0O0o.("ImageFile", value)
						If binding IsNot Nothing Then
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							Me.oOoo._0o0..DataBindings.Add(binding)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001492 RID: 5266
		' (get) Token: 0x060055AC RID: 21932 RVA: 0x00221A3E File Offset: 0x0021FC3E
		' (set) Token: 0x060055AD RID: 21933 RVA: 0x00221A4B File Offset: 0x0021FC4B
		<oO0oooo("0814")>
		Public Property Image As Image
			Get
				Return Me.oOoo._0o0..Image
			End Get
			Set(value As Image)
				Me.oOoo._0o0..Image = value
			End Set
		End Property

		' Token: 0x17001493 RID: 5267
		' (get) Token: 0x060055AE RID: 21934 RVA: 0x00221A59 File Offset: 0x0021FC59
		' (set) Token: 0x060055AF RID: 21935 RVA: 0x00221A66 File Offset: 0x0021FC66
		<oO0oooo("0813")>
		Public Property SizeMode As ImageSizeMode
			Get
				Return Me.oOoo._0o0..SizeMode
			End Get
			Set(value As ImageSizeMode)
				Me.oOoo._0o0..SizeMode = value
			End Set
		End Property

		' Token: 0x17001494 RID: 5268
		' (get) Token: 0x060055B0 RID: 21936 RVA: 0x00221A74 File Offset: 0x0021FC74
		' (set) Token: 0x060055B1 RID: 21937 RVA: 0x00221A81 File Offset: 0x0021FC81
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.oOoo._0o0..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.oOoo._0o0..BorderStyle = value
			End Set
		End Property

		' Token: 0x17001495 RID: 5269
		' (get) Token: 0x060055B2 RID: 21938 RVA: 0x00221A8F File Offset: 0x0021FC8F
		' (set) Token: 0x060055B3 RID: 21939 RVA: 0x00221A9C File Offset: 0x0021FC9C
		Public Property AutoScroll As Boolean
			Get
				Return Me.oOoo._0o0..AutoScroll
			End Get
			Set(value As Boolean)
				Me.oOoo._0o0..AutoScroll = value
			End Set
		End Property

		' Token: 0x17001496 RID: 5270
		' (get) Token: 0x060055B4 RID: 21940 RVA: 0x00221AAA File Offset: 0x0021FCAA
		' (set) Token: 0x060055B5 RID: 21941 RVA: 0x00221AB7 File Offset: 0x0021FCB7
		Public Property ImageFile As String
			Get
				Return Me.oOoo._0o0..ImageFile
			End Get
			Set(value As String)
				Me.oOoo._0o0..ImageFile = value
			End Set
		End Property

		' Token: 0x060055B6 RID: 21942 RVA: 0x00221AC8 File Offset: 0x0021FCC8
		<oO0oooo("1912")>
		Public Sub AddControl(Control As Control)
			Me.oOoo._0o0..PictureBox1.Controls.Add(Control.BaseControl)
			If TypeOf Control.BaseControl Is O_oOooO_O Then
				Dim o.0O_O0o_. As Table = CType(Control.BaseControl, O_oOooO_O).o.0O_O0o_.
				If o.0O_O0o_..TableType IsNot Nothing OrElse o.0O_O0o_..IsCopy Then
					o.0O_O0o_..oO_o_0o._0oooo.(True)
				End If
			End If
			Control.TopMost = True
		End Sub

		' Token: 0x060055B7 RID: 21943 RVA: 0x00221B30 File Offset: 0x0021FD30
		<oO0oooo("1912")>
		Public Sub RemoveControl(Name As String)
			Try
				For Each obj As Object In Me.oOoo._0o0..PictureBox1.Controls
					Dim control As Control = CType(obj, Control)
					If Operators.CompareString(control.Name, Name, True) = 0 Then
						oOO0oo_o0.O00OO_O_oO_.o.(Me.oOoo._0o0..PictureBox1.Controls, control)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.oOoo._0o0..PictureBox1)
		End Sub

		' Token: 0x060055B8 RID: 21944 RVA: 0x00221BC8 File Offset: 0x0021FDC8
		Public Sub ClearControl()
			For i As Integer = Me.oOoo._0o0..PictureBox1.Controls.Count - 1 To 0 Step -1
				Dim a_ As Control = Me.oOoo._0o0..PictureBox1.Controls(i)
				oOO0oo_o0.O00OO_O_oO_.o.(Me.oOoo._0o0..PictureBox1.Controls, a_)
			Next
			oOO0oo_o0.oOo.oO_O0_o_Oo.(Me.oOoo._0o0..PictureBox1)
		End Sub

		' Token: 0x17001497 RID: 5271
		' (get) Token: 0x060055B9 RID: 21945 RVA: 0x00221C34 File Offset: 0x0021FE34
		Public ReadOnly Property children As ChildrenCollection
			Get
				Return oOO0oo_o0.o.O0o000_.(Me.oOoo._0o0..PictureBox1)
			End Get
		End Property

		' Token: 0x060055BA RID: 21946 RVA: 0x00221C46 File Offset: 0x0021FE46
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x17001498 RID: 5272
		' (get) Token: 0x060055BB RID: 21947 RVA: 0x00221C4F File Offset: 0x0021FE4F
		' (set) Token: 0x060055BC RID: 21948 RVA: 0x00221C57 File Offset: 0x0021FE57
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Remote As Boolean
			Get
				Return Me.Oo_.0_0O0o00o.
			End Get
			Set(value As Boolean)
				Me.Oo_.0_0O0o00o. = value
			End Set
		End Property

		' Token: 0x17001499 RID: 5273
		' (get) Token: 0x060055BD RID: 21949 RVA: 0x00221C60 File Offset: 0x0021FE60
		' (set) Token: 0x060055BE RID: 21950 RVA: 0x00221C68 File Offset: 0x0021FE68
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Host As String
			Get
				Return Me.O.oo0o_O_O.
			End Get
			Set(value As String)
				Me.O.oo0o_O_O. = value
			End Set
		End Property

		' Token: 0x1700149A RID: 5274
		' (get) Token: 0x060055BF RID: 21951 RVA: 0x00221C71 File Offset: 0x0021FE71
		' (set) Token: 0x060055C0 RID: 21952 RVA: 0x00221C79 File Offset: 0x0021FE79
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Account As String
			Get
				Return Me.Oo0__O.o__oO.
			End Get
			Set(value As String)
				Me.Oo0__O.o__oO. = value
			End Set
		End Property

		' Token: 0x1700149B RID: 5275
		' (get) Token: 0x060055C1 RID: 21953 RVA: 0x00221C82 File Offset: 0x0021FE82
		' (set) Token: 0x060055C2 RID: 21954 RVA: 0x00221C8A File Offset: 0x0021FE8A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Password As String
			Get
				Return Me.OOoo0_0o_O_.0o.
			End Get
			Set(value As String)
				Me.OOoo0_0o_O_.0o. = value
			End Set
		End Property

		' Token: 0x1700149C RID: 5276
		' (get) Token: 0x060055C3 RID: 21955 RVA: 0x00221C93 File Offset: 0x0021FE93
		' (set) Token: 0x060055C4 RID: 21956 RVA: 0x00221C9B File Offset: 0x0021FE9B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property UTF8 As Boolean
			Get
				Return Me.O.oo0o_O_O.
			End Get
			Set(value As Boolean)
				Me.O.oo0o_O_O. = value
			End Set
		End Property

		' Token: 0x1700149D RID: 5277
		' (get) Token: 0x060055C5 RID: 21957 RVA: 0x00221CA4 File Offset: 0x0021FEA4
		' (set) Token: 0x060055C6 RID: 21958 RVA: 0x00221CAC File Offset: 0x0021FEAC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Port As Integer
			Get
				Return Me.Oo_.0_0O0o00o.
			End Get
			Set(value As Integer)
				Me.Oo_.0_0O0o00o. = value
			End Set
		End Property

		' Token: 0x1700149E RID: 5278
		' (get) Token: 0x060055C7 RID: 21959 RVA: 0x00221CB5 File Offset: 0x0021FEB5
		' (set) Token: 0x060055C8 RID: 21960 RVA: 0x00221CC2 File Offset: 0x0021FEC2
		<oO0oooo("2701")>
		Public Property FTPClient As FTPClient
			Get
				Return Me.oOoo._0o0..FTPClient
			End Get
			Set(value As FTPClient)
				Me.oOoo._0o0..FTPClient = value
			End Set
		End Property

		' Token: 0x1700149F RID: 5279
		' (get) Token: 0x060055C9 RID: 21961 RVA: 0x00221CD0 File Offset: 0x0021FED0
		' (set) Token: 0x060055CA RID: 21962 RVA: 0x00221CDD File Offset: 0x0021FEDD
		Public Property AutoUpdate As Boolean
			Get
				Return Me.oOoo._0o0..AutoUpdate
			End Get
			Set(value As Boolean)
				Me.oOoo._0o0..AutoUpdate = value
			End Set
		End Property

		' Token: 0x170014A0 RID: 5280
		' (get) Token: 0x060055CB RID: 21963 RVA: 0x00221CEB File Offset: 0x0021FEEB
		' (set) Token: 0x060055CC RID: 21964 RVA: 0x00221CF3 File Offset: 0x0021FEF3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property WebImage As String
			Get
				Return Me.ImageFile
			End Get
			Set(value As String)
				Me.ImageFile = value
			End Set
		End Property

		' Token: 0x170014A1 RID: 5281
		' (get) Token: 0x060055CD RID: 21965 RVA: 0x00221CFC File Offset: 0x0021FEFC
		' (set) Token: 0x060055CE RID: 21966 RVA: 0x00221D04 File Offset: 0x0021FF04
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FolderName As String
			Get
				Return Me.ooO0O.__.
			End Get
			Set(value As String)
				Me.ooO0O.__. = value
			End Set
		End Property

		' Token: 0x0400220D RID: 8717
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400220E RID: 8718
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400220F RID: 8719
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002210 RID: 8720
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002211 RID: 8721
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002212 RID: 8722
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002213 RID: 8723
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002214 RID: 8724
		Private <<EMPTY_NAME>> As CustomPictureBox

		' Token: 0x04002215 RID: 8725
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
