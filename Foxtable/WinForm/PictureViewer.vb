Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200051D RID: 1309
	<ComVisible(True)>
	Public Class PictureViewer
		Inherits Control
		Implements OoO_

		' Token: 0x060055CF RID: 21967 RVA: 0x00221D0D File Offset: 0x0021FF0D
		Friend Sub New(A_0 As PictureViewer)
			MyBase.New(A_0, ControlTypeEnum.PictureViewer)
			Me.oOoo._0o0. = 1
			Me.o_O0__._. = 2
			Me.oOoo._0o0. = 21
			Me.Oooo.Oo_0O. = A_0
		End Sub

		' Token: 0x170014A2 RID: 5282
		' (get) Token: 0x060055D0 RID: 21968 RVA: 0x00221D35 File Offset: 0x0021FF35
		' (set) Token: 0x060055D1 RID: 21969 RVA: 0x00221D40 File Offset: 0x0021FF40
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..DataBindings.Clear()
				Me.Oooo.Oo_0O..ImageFiles = ""
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.PictureViewer, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.Oooo.Oo_0O..DataBindings.Add("ImageFiles", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("ImageFiles", value)
							If binding IsNot Nothing Then
								Me.Oooo.Oo_0O..DataBindings.Add(binding)
								If Me.Oooo.Oo_0O..DataBindings.Count > 0 Then
									Me.Oooo.Oo_0O..DataBindings(0).DataSourceUpdateMode = DataSourceUpdateMode.Never
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170014A3 RID: 5283
		' (get) Token: 0x060055D2 RID: 21970 RVA: 0x00221E53 File Offset: 0x00220053
		' (set) Token: 0x060055D3 RID: 21971 RVA: 0x00221E60 File Offset: 0x00220060
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.Oooo.Oo_0O..[ReadOnly]
			End Get
			Set(value As BooleanEnum)
				Me.Oooo.Oo_0O..[ReadOnly] = value
			End Set
		End Property

		' Token: 0x170014A4 RID: 5284
		' (get) Token: 0x060055D4 RID: 21972 RVA: 0x00221E6E File Offset: 0x0022006E
		' (set) Token: 0x060055D5 RID: 21973 RVA: 0x00221E83 File Offset: 0x00220083
		Public Property CommandVisible As Boolean
			Get
				Return Not Me.Oooo.Oo_0O..SplitContainer.Panel2Collapsed
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..SplitContainer.Panel2Collapsed = Not value
			End Set
		End Property

		' Token: 0x170014A5 RID: 5285
		' (get) Token: 0x060055D6 RID: 21974 RVA: 0x00221E99 File Offset: 0x00220099
		' (set) Token: 0x060055D7 RID: 21975 RVA: 0x00221EAB File Offset: 0x002200AB
		Public Property OpenEnabled As Boolean
			Get
				Return Me.Oooo.Oo_0O..Open.Enabled
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..Open.Enabled = value
			End Set
		End Property

		' Token: 0x170014A6 RID: 5286
		' (get) Token: 0x060055D8 RID: 21976 RVA: 0x00221EBE File Offset: 0x002200BE
		' (set) Token: 0x060055D9 RID: 21977 RVA: 0x00221ECE File Offset: 0x002200CE
		Public Property AutoSize As Boolean
			Get
				Return Me.Oooo.Oo_0O..SizeMode = PictureBoxSizeMode.Zoom
			End Get
			Set(value As Boolean)
				If value Then
					Me.Oooo.Oo_0O..SizeMode = PictureBoxSizeMode.Zoom
					Return
				End If
				Me.Oooo.Oo_0O..SizeMode = PictureBoxSizeMode.AutoSize
			End Set
		End Property

		' Token: 0x170014A7 RID: 5287
		' (get) Token: 0x060055DA RID: 21978 RVA: 0x00221EEC File Offset: 0x002200EC
		' (set) Token: 0x060055DB RID: 21979 RVA: 0x00221EFE File Offset: 0x002200FE
		Public Overrides Property BackColor As Color
			Get
				Return Me.Oooo.Oo_0O..C1PictureBox1.BackColor
			End Get
			Set(value As Color)
				Me.Oooo.Oo_0O..C1PictureBox1.BackColor = value
				Me.Oooo.Oo_0O..Panel2.BackColor = value
			End Set
		End Property

		' Token: 0x170014A8 RID: 5288
		' (get) Token: 0x060055DC RID: 21980 RVA: 0x00221F22 File Offset: 0x00220122
		Public ReadOnly Property SelectedItem As String
			Get
				Return Me.Oooo.Oo_0O..SelectedItem
			End Get
		End Property

		' Token: 0x170014A9 RID: 5289
		' (get) Token: 0x060055DD RID: 21981 RVA: 0x00221F2F File Offset: 0x0022012F
		<oO0oooo("2286")>
		Public ReadOnly Property AddCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Add
			End Get
		End Property

		' Token: 0x170014AA RID: 5290
		' (get) Token: 0x060055DE RID: 21982 RVA: 0x00221F3C File Offset: 0x0022013C
		<oO0oooo("2286")>
		Public ReadOnly Property ClearCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Clear
			End Get
		End Property

		' Token: 0x170014AB RID: 5291
		' (get) Token: 0x060055DF RID: 21983 RVA: 0x00221F49 File Offset: 0x00220149
		<oO0oooo("2286")>
		Public ReadOnly Property DeleteCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Delete
			End Get
		End Property

		' Token: 0x170014AC RID: 5292
		' (get) Token: 0x060055E0 RID: 21984 RVA: 0x00221F56 File Offset: 0x00220156
		<oO0oooo("2286")>
		Public ReadOnly Property OpenCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Open
			End Get
		End Property

		' Token: 0x170014AD RID: 5293
		' (get) Token: 0x060055E1 RID: 21985 RVA: 0x00221F63 File Offset: 0x00220163
		<oO0oooo("2286")>
		Public ReadOnly Property FullViewCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Full
			End Get
		End Property

		' Token: 0x170014AE RID: 5294
		' (get) Token: 0x060055E2 RID: 21986 RVA: 0x00221F70 File Offset: 0x00220170
		<oO0oooo("2286")>
		Public ReadOnly Property ManagerCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Manager
			End Get
		End Property

		' Token: 0x170014AF RID: 5295
		' (get) Token: 0x060055E3 RID: 21987 RVA: 0x00221F7D File Offset: 0x0022017D
		<oO0oooo("2286")>
		Public ReadOnly Property SaveAsCommand As Label
			Get
				Return Me.Oooo.Oo_0O..SaveAs
			End Get
		End Property

		' Token: 0x170014B0 RID: 5296
		' (get) Token: 0x060055E4 RID: 21988 RVA: 0x00221F8A File Offset: 0x0022018A
		<oO0oooo("2286")>
		Public ReadOnly Property StretchCommand As Label
			Get
				Return Me.Oooo.Oo_0O..Stretch
			End Get
		End Property

		' Token: 0x170014B1 RID: 5297
		' (get) Token: 0x060055E5 RID: 21989 RVA: 0x00221F97 File Offset: 0x00220197
		<oO0oooo("2286")>
		Public ReadOnly Property ConnectCommand As Label
			Get
				Return Me.Oooo.Oo_0O..lblConnect
			End Get
		End Property

		' Token: 0x170014B2 RID: 5298
		' (get) Token: 0x060055E6 RID: 21990 RVA: 0x00221FA4 File Offset: 0x002201A4
		<oO0oooo("2286")>
		Public ReadOnly Property UpdateCommand As Label
			Get
				Return Me.Oooo.Oo_0O..lblUpdate
			End Get
		End Property

		' Token: 0x060055E7 RID: 21991 RVA: 0x00221FB1 File Offset: 0x002201B1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x170014B3 RID: 5299
		' (get) Token: 0x060055E8 RID: 21992 RVA: 0x00221FBA File Offset: 0x002201BA
		' (set) Token: 0x060055E9 RID: 21993 RVA: 0x00221FC7 File Offset: 0x002201C7
		Public Property AutoDownload As Boolean
			Get
				Return Me.Oooo.Oo_0O..AutoDownLoad
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..AutoDownLoad = value
			End Set
		End Property

		' Token: 0x170014B4 RID: 5300
		' (get) Token: 0x060055EA RID: 21994 RVA: 0x00221FD5 File Offset: 0x002201D5
		' (set) Token: 0x060055EB RID: 21995 RVA: 0x00221FE2 File Offset: 0x002201E2
		Public Property AutoUpdate As Boolean
			Get
				Return Me.Oooo.Oo_0O..AutoUpdate
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..AutoUpdate = value
			End Set
		End Property

		' Token: 0x170014B5 RID: 5301
		' (get) Token: 0x060055EC RID: 21996 RVA: 0x00221FF0 File Offset: 0x002201F0
		' (set) Token: 0x060055ED RID: 21997 RVA: 0x00221FFD File Offset: 0x002201FD
		<oO0oooo("2696")>
		Public Property FTPClient As FTPClient
			Get
				Return Me.Oooo.Oo_0O..FTPclient
			End Get
			Set(value As FTPClient)
				Me.Oooo.Oo_0O..FTPclient = value
			End Set
		End Property

		' Token: 0x170014B6 RID: 5302
		' (get) Token: 0x060055EE RID: 21998 RVA: 0x0022200B File Offset: 0x0022020B
		' (set) Token: 0x060055EF RID: 21999 RVA: 0x00222013 File Offset: 0x00220213
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Remote As Boolean
			Get
				Return Me.oOoo._0o0.
			End Get
			Set(value As Boolean)
				Me.oOoo._0o0. = value
			End Set
		End Property

		' Token: 0x170014B7 RID: 5303
		' (get) Token: 0x060055F0 RID: 22000 RVA: 0x0022201C File Offset: 0x0022021C
		' (set) Token: 0x060055F1 RID: 22001 RVA: 0x00222024 File Offset: 0x00220224
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Host As String
			Get
				Return Me.oOoo._0o0.
			End Get
			Set(value As String)
				Me.oOoo._0o0. = value
			End Set
		End Property

		' Token: 0x170014B8 RID: 5304
		' (get) Token: 0x060055F2 RID: 22002 RVA: 0x0022202D File Offset: 0x0022022D
		' (set) Token: 0x060055F3 RID: 22003 RVA: 0x00222035 File Offset: 0x00220235
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Account As String
			Get
				Return Me.o_O0__._.
			End Get
			Set(value As String)
				Me.o_O0__._. = value
			End Set
		End Property

		' Token: 0x170014B9 RID: 5305
		' (get) Token: 0x060055F4 RID: 22004 RVA: 0x0022203E File Offset: 0x0022023E
		' (set) Token: 0x060055F5 RID: 22005 RVA: 0x00222046 File Offset: 0x00220246
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Password As String
			Get
				Return Me.O_OO0.0oO0oo_.
			End Get
			Set(value As String)
				Me.O_OO0.0oO0oo_. = value
			End Set
		End Property

		' Token: 0x170014BA RID: 5306
		' (get) Token: 0x060055F6 RID: 22006 RVA: 0x0022204F File Offset: 0x0022024F
		' (set) Token: 0x060055F7 RID: 22007 RVA: 0x00222057 File Offset: 0x00220257
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property UTF8 As Boolean
			Get
				Return Me.o_Oo00_0_o.oOo.
			End Get
			Set(value As Boolean)
				Me.o_Oo00_0_o.oOo. = value
			End Set
		End Property

		' Token: 0x170014BB RID: 5307
		' (get) Token: 0x060055F8 RID: 22008 RVA: 0x00222060 File Offset: 0x00220260
		' (set) Token: 0x060055F9 RID: 22009 RVA: 0x00222068 File Offset: 0x00220268
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Port As Integer
			Get
				Return Me.oOoo._0o0.
			End Get
			Set(value As Integer)
				Me.oOoo._0o0. = value
			End Set
		End Property

		' Token: 0x170014BC RID: 5308
		' (get) Token: 0x060055FA RID: 22010 RVA: 0x00222071 File Offset: 0x00220271
		' (set) Token: 0x060055FB RID: 22011 RVA: 0x00222079 File Offset: 0x00220279
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property RootDir As String
			Get
				Return Me.O___.0oo_Oo.
			End Get
			Set(value As String)
				Me.O___.0oo_Oo. = value
			End Set
		End Property

		' Token: 0x060055FC RID: 22012 RVA: 0x00222082 File Offset: 0x00220282
		<oO0oooo("2699")>
		Public Sub AddFile(FileName As String)
			Me.Oooo.Oo_0O..oOo.o0Oo_.(FileName)
		End Sub

		' Token: 0x060055FD RID: 22013 RVA: 0x00222091 File Offset: 0x00220291
		<oO0oooo("2700")>
		Public Sub DeleteFile(FileName As String)
			Me.Oooo.Oo_0O..oO0__0O0o00._.(FileName)
		End Sub

		' Token: 0x170014BD RID: 5309
		' (get) Token: 0x060055FE RID: 22014 RVA: 0x0022209F File Offset: 0x0022029F
		' (set) Token: 0x060055FF RID: 22015 RVA: 0x002220A7 File Offset: 0x002202A7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FolderName As String
			Get
				Return Me.o.OOO_.
			End Get
			Set(value As String)
				Me.o.OOO_. = value
			End Set
		End Property

		' Token: 0x170014BE RID: 5310
		' (get) Token: 0x06005600 RID: 22016 RVA: 0x002220B0 File Offset: 0x002202B0
		' (set) Token: 0x06005601 RID: 22017 RVA: 0x002220B8 File Offset: 0x002202B8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SourceFolder As String
			Get
				Return Me.Oo000.ooO.
			End Get
			Set(value As String)
				Me.Oo000.ooO. = value
			End Set
		End Property

		' Token: 0x170014BF RID: 5311
		' (get) Token: 0x06005602 RID: 22018 RVA: 0x002220C1 File Offset: 0x002202C1
		' (set) Token: 0x06005603 RID: 22019 RVA: 0x002220C9 File Offset: 0x002202C9
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoCopyAttachFile As BooleanEnum
			Get
				Return Me.oOoo._0o0.
			End Get
			Set(value As BooleanEnum)
				Me.oOoo._0o0. = value
			End Set
		End Property

		' Token: 0x170014C0 RID: 5312
		' (get) Token: 0x06005604 RID: 22020 RVA: 0x002220D2 File Offset: 0x002202D2
		' (set) Token: 0x06005605 RID: 22021 RVA: 0x002220DA File Offset: 0x002202DA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoDeleteAttachFile As BooleanEnum
			Get
				Return Me.o_O0__._.
			End Get
			Set(value As BooleanEnum)
				Me.o_O0__._. = value
			End Set
		End Property

		' Token: 0x170014C1 RID: 5313
		' (get) Token: 0x06005606 RID: 22022 RVA: 0x002220E3 File Offset: 0x002202E3
		' (set) Token: 0x06005607 RID: 22023 RVA: 0x002220EB File Offset: 0x002202EB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FileFilter As String
			Get
				Return Me.OO0O_00._.
			End Get
			Set(value As String)
				Me.OO0O_00._. = value
			End Set
		End Property

		' Token: 0x04002216 RID: 8726
		Private <<EMPTY_NAME>> As PictureViewer

		' Token: 0x04002217 RID: 8727
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002218 RID: 8728
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002219 RID: 8729
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400221A RID: 8730
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400221B RID: 8731
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400221C RID: 8732
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400221D RID: 8733
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400221E RID: 8734
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400221F RID: 8735
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04002220 RID: 8736
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04002221 RID: 8737
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002222 RID: 8738
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
