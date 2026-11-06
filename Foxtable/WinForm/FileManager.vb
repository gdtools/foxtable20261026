Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200050A RID: 1290
	<ComVisible(True)>
	Public Class FileManager
		Inherits Control
		Implements OoO_

		' Token: 0x060054C5 RID: 21701 RVA: 0x0021F868 File Offset: 0x0021DA68
		Friend Sub New(A_0 As FileManager)
			MyBase.New(A_0, ControlTypeEnum.FileManager)
			Me.oo00.oo. = 1
			Me.OOo_o.Oo. = 2
			Me.oo00.oo. = 21
			Me.O.00oo_OO0O. = A_0
		End Sub

		' Token: 0x1700142E RID: 5166
		' (get) Token: 0x060054C6 RID: 21702 RVA: 0x0021F890 File Offset: 0x0021DA90
		' (set) Token: 0x060054C7 RID: 21703 RVA: 0x0021F898 File Offset: 0x0021DA98
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.O.00oo_OO0O..DataBindings.Clear()
				Me.O.00oo_OO0O..FileString = Nothing
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.FileManager, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.O.00oo_OO0O..DataBindings.Add("FileString", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("FileString", value)
							If binding IsNot Nothing Then
								Me.O.00oo_OO0O..DataBindings.Add(binding)
								If Me.O.00oo_OO0O..DataBindings.Count > 0 Then
									Me.O.00oo_OO0O..DataBindings(0).DataSourceUpdateMode = DataSourceUpdateMode.Never
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700142F RID: 5167
		' (get) Token: 0x060054C8 RID: 21704 RVA: 0x0021F9A7 File Offset: 0x0021DBA7
		' (set) Token: 0x060054C9 RID: 21705 RVA: 0x0021F9B4 File Offset: 0x0021DBB4
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O.00oo_OO0O..[ReadOnly]
			End Get
			Set(value As BooleanEnum)
				Me.O.00oo_OO0O..[ReadOnly] = value
			End Set
		End Property

		' Token: 0x17001430 RID: 5168
		' (get) Token: 0x060054CA RID: 21706 RVA: 0x0021F9C2 File Offset: 0x0021DBC2
		' (set) Token: 0x060054CB RID: 21707 RVA: 0x0021F9D7 File Offset: 0x0021DBD7
		Public Property CommandVisible As Boolean
			Get
				Return Not Me.O.00oo_OO0O..SplitContainer1.Panel2Collapsed
			End Get
			Set(value As Boolean)
				Me.O.00oo_OO0O..SplitContainer1.Panel2Collapsed = Not value
			End Set
		End Property

		' Token: 0x17001431 RID: 5169
		' (get) Token: 0x060054CC RID: 21708 RVA: 0x0021F9ED File Offset: 0x0021DBED
		' (set) Token: 0x060054CD RID: 21709 RVA: 0x0021F9FF File Offset: 0x0021DBFF
		Public Property OpenEnabled As Boolean
			Get
				Return Me.O.00oo_OO0O..Open.Enabled
			End Get
			Set(value As Boolean)
				Me.O.00oo_OO0O..Open.Enabled = value
			End Set
		End Property

		' Token: 0x17001432 RID: 5170
		' (get) Token: 0x060054CE RID: 21710 RVA: 0x0021FA12 File Offset: 0x0021DC12
		' (set) Token: 0x060054CF RID: 21711 RVA: 0x0021FA1F File Offset: 0x0021DC1F
		Public Property DoubleClickOpen As Boolean
			Get
				Return Me.O.00oo_OO0O..DoubleClickOpen
			End Get
			Set(value As Boolean)
				Me.O.00oo_OO0O..DoubleClickOpen = value
			End Set
		End Property

		' Token: 0x17001433 RID: 5171
		' (get) Token: 0x060054D0 RID: 21712 RVA: 0x0021FA30 File Offset: 0x0021DC30
		' (set) Token: 0x060054D1 RID: 21713 RVA: 0x0021FA70 File Offset: 0x0021DC70
		Public Property SelectedItem As String
			Get
				Dim result As String
				If Me.O.00oo_OO0O..ListBox1.SelectedItem Is Nothing Then
					result = ""
				Else
					result = Me.O.00oo_OO0O..ListBox1.SelectedItem.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer = Me.O.00oo_OO0O..ListBox1.Items.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Me.O.00oo_OO0O..ListBox1.Items(i).ToString(), value, True) = 0 Then
						Me.O.00oo_OO0O..ListBox1.SelectedIndex = i
						Return
					End If
				Next
			End Set
		End Property

		' Token: 0x17001434 RID: 5172
		' (get) Token: 0x060054D2 RID: 21714 RVA: 0x0021FAD8 File Offset: 0x0021DCD8
		' (set) Token: 0x060054D3 RID: 21715 RVA: 0x0021FB34 File Offset: 0x0021DD34
		Public Property Files As List(Of String)
			Get
				Dim list As List(Of String) = New List(Of String)()
				Dim num As Integer = Me.O.00oo_OO0O..ListBox1.Items.Count - 1
				For i As Integer = 0 To num
					list.Add(Me.O.00oo_OO0O..ListBox1.Items(i).ToString())
				Next
				Return list
			End Get
			Set(value As List(Of String))
				Dim text As String = ""
				Try
					For Each str As String In value
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCrLf
						End If
						text += str
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.O.00oo_OO0O..FileString = text
			End Set
		End Property

		' Token: 0x17001435 RID: 5173
		' (get) Token: 0x060054D4 RID: 21716 RVA: 0x0021FBB0 File Offset: 0x0021DDB0
		<oO0oooo("2285")>
		Public ReadOnly Property AddCommand As Label
			Get
				Return Me.O.00oo_OO0O..Add
			End Get
		End Property

		' Token: 0x17001436 RID: 5174
		' (get) Token: 0x060054D5 RID: 21717 RVA: 0x0021FBBD File Offset: 0x0021DDBD
		<oO0oooo("2285")>
		Public ReadOnly Property AddFolderCommand As Label
			Get
				Return Me.O.00oo_OO0O..Folder
			End Get
		End Property

		' Token: 0x17001437 RID: 5175
		' (get) Token: 0x060054D6 RID: 21718 RVA: 0x0021FBCA File Offset: 0x0021DDCA
		<oO0oooo("2285")>
		Public ReadOnly Property ClearCommand As Label
			Get
				Return Me.O.00oo_OO0O..Clear
			End Get
		End Property

		' Token: 0x17001438 RID: 5176
		' (get) Token: 0x060054D7 RID: 21719 RVA: 0x0021FBD7 File Offset: 0x0021DDD7
		<oO0oooo("2285")>
		Public ReadOnly Property DeleteCommand As Label
			Get
				Return Me.O.00oo_OO0O..Delete
			End Get
		End Property

		' Token: 0x17001439 RID: 5177
		' (get) Token: 0x060054D8 RID: 21720 RVA: 0x0021FBE4 File Offset: 0x0021DDE4
		<oO0oooo("2285")>
		Public ReadOnly Property OpenCommand As Label
			Get
				Return Me.O.00oo_OO0O..Open
			End Get
		End Property

		' Token: 0x1700143A RID: 5178
		' (get) Token: 0x060054D9 RID: 21721 RVA: 0x0021FBF1 File Offset: 0x0021DDF1
		<oO0oooo("2285")>
		Public ReadOnly Property ManagerCommand As Label
			Get
				Return Me.O.00oo_OO0O..Manager
			End Get
		End Property

		' Token: 0x1700143B RID: 5179
		' (get) Token: 0x060054DA RID: 21722 RVA: 0x0021FBFE File Offset: 0x0021DDFE
		<oO0oooo("2285")>
		Public ReadOnly Property SaveAsCommand As Label
			Get
				Return Me.O.00oo_OO0O..SaveAs
			End Get
		End Property

		' Token: 0x1700143C RID: 5180
		' (get) Token: 0x060054DB RID: 21723 RVA: 0x0021FC0B File Offset: 0x0021DE0B
		Public ReadOnly Property FullViewCommand As Label
			Get
				Return Me.O.00oo_OO0O..FullView
			End Get
		End Property

		' Token: 0x1700143D RID: 5181
		' (get) Token: 0x060054DC RID: 21724 RVA: 0x0021FC18 File Offset: 0x0021DE18
		Public ReadOnly Property ConnectCommand As Label
			Get
				Return Me.O.00oo_OO0O..Connect
			End Get
		End Property

		' Token: 0x060054DD RID: 21725 RVA: 0x0021FC25 File Offset: 0x0021DE25
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x1700143E RID: 5182
		' (get) Token: 0x060054DE RID: 21726 RVA: 0x0021FC2E File Offset: 0x0021DE2E
		' (set) Token: 0x060054DF RID: 21727 RVA: 0x0021FC3B File Offset: 0x0021DE3B
		<oO0oooo("1898")>
		Public Property FTPClient As FTPClient
			Get
				Return Me.O.00oo_OO0O..FTPclient
			End Get
			Set(value As FTPClient)
				Me.O.00oo_OO0O..FTPclient = value
			End Set
		End Property

		' Token: 0x1700143F RID: 5183
		' (get) Token: 0x060054E0 RID: 21728 RVA: 0x0021FC49 File Offset: 0x0021DE49
		' (set) Token: 0x060054E1 RID: 21729 RVA: 0x0021FC56 File Offset: 0x0021DE56
		Public Property AutoUpdate As Boolean
			Get
				Return Me.O.00oo_OO0O..AutoUpdate
			End Get
			Set(value As Boolean)
				Me.O.00oo_OO0O..AutoUpdate = value
			End Set
		End Property

		' Token: 0x17001440 RID: 5184
		' (get) Token: 0x060054E2 RID: 21730 RVA: 0x0021FC64 File Offset: 0x0021DE64
		' (set) Token: 0x060054E3 RID: 21731 RVA: 0x0021FC6C File Offset: 0x0021DE6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Remote As Boolean
			Get
				Return Me.oo00.oo.
			End Get
			Set(value As Boolean)
				Me.oo00.oo. = value
			End Set
		End Property

		' Token: 0x17001441 RID: 5185
		' (get) Token: 0x060054E4 RID: 21732 RVA: 0x0021FC75 File Offset: 0x0021DE75
		' (set) Token: 0x060054E5 RID: 21733 RVA: 0x0021FC7D File Offset: 0x0021DE7D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Host As String
			Get
				Return Me.oo00.oo.
			End Get
			Set(value As String)
				Me.oo00.oo. = value
			End Set
		End Property

		' Token: 0x17001442 RID: 5186
		' (get) Token: 0x060054E6 RID: 21734 RVA: 0x0021FC86 File Offset: 0x0021DE86
		' (set) Token: 0x060054E7 RID: 21735 RVA: 0x0021FC8E File Offset: 0x0021DE8E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Account As String
			Get
				Return Me.OOo_o.Oo.
			End Get
			Set(value As String)
				Me.OOo_o.Oo. = value
			End Set
		End Property

		' Token: 0x17001443 RID: 5187
		' (get) Token: 0x060054E8 RID: 21736 RVA: 0x0021FC97 File Offset: 0x0021DE97
		' (set) Token: 0x060054E9 RID: 21737 RVA: 0x0021FC9F File Offset: 0x0021DE9F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Password As String
			Get
				Return Me.o._0oo_O_o_.
			End Get
			Set(value As String)
				Me.o._0oo_O_o_. = value
			End Set
		End Property

		' Token: 0x17001444 RID: 5188
		' (get) Token: 0x060054EA RID: 21738 RVA: 0x0021FCA8 File Offset: 0x0021DEA8
		' (set) Token: 0x060054EB RID: 21739 RVA: 0x0021FCB0 File Offset: 0x0021DEB0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property UTF8 As Boolean
			Get
				Return Me.o.oo0__o.
			End Get
			Set(value As Boolean)
				Me.o.oo0__o. = value
			End Set
		End Property

		' Token: 0x17001445 RID: 5189
		' (get) Token: 0x060054EC RID: 21740 RVA: 0x0021FCB9 File Offset: 0x0021DEB9
		' (set) Token: 0x060054ED RID: 21741 RVA: 0x0021FCC1 File Offset: 0x0021DEC1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property Port As Integer
			Get
				Return Me.oo00.oo.
			End Get
			Set(value As Integer)
				Me.oo00.oo. = value
			End Set
		End Property

		' Token: 0x17001446 RID: 5190
		' (get) Token: 0x060054EE RID: 21742 RVA: 0x0021FCCA File Offset: 0x0021DECA
		' (set) Token: 0x060054EF RID: 21743 RVA: 0x0021FCD2 File Offset: 0x0021DED2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property RootDir As String
			Get
				Return Me.o0.O00o.
			End Get
			Set(value As String)
				Me.o0.O00o. = value
			End Set
		End Property

		' Token: 0x060054F0 RID: 21744 RVA: 0x0021FCDB File Offset: 0x0021DEDB
		<oO0oooo("2697")>
		Public Sub AddFile(FileName As String)
			Me.O.00oo_OO0O..O0oO_0._o_.(FileName)
		End Sub

		' Token: 0x060054F1 RID: 21745 RVA: 0x0021FCEA File Offset: 0x0021DEEA
		<oO0oooo("2698")>
		Public Sub DeleteFile(Filename As String)
			Me.O.00oo_OO0O..o0O0o_O.O0.(Filename)
		End Sub

		' Token: 0x17001447 RID: 5191
		' (get) Token: 0x060054F2 RID: 21746 RVA: 0x0021FCF8 File Offset: 0x0021DEF8
		' (set) Token: 0x060054F3 RID: 21747 RVA: 0x0021FD00 File Offset: 0x0021DF00
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FolderName As String
			Get
				Return Me.oO_.o_O___O.
			End Get
			Set(value As String)
				Me.oO_.o_O___O. = value
			End Set
		End Property

		' Token: 0x17001448 RID: 5192
		' (get) Token: 0x060054F4 RID: 21748 RVA: 0x0021FD09 File Offset: 0x0021DF09
		' (set) Token: 0x060054F5 RID: 21749 RVA: 0x0021FD11 File Offset: 0x0021DF11
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property SourceFolder As String
			Get
				Return Me.oO.0oo_0_O_.
			End Get
			Set(value As String)
				Me.oO.0oo_0_O_. = value
			End Set
		End Property

		' Token: 0x17001449 RID: 5193
		' (get) Token: 0x060054F6 RID: 21750 RVA: 0x0021FD1A File Offset: 0x0021DF1A
		' (set) Token: 0x060054F7 RID: 21751 RVA: 0x0021FD22 File Offset: 0x0021DF22
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoCopyAttachFile As BooleanEnum
			Get
				Return Me.oo00.oo.
			End Get
			Set(value As BooleanEnum)
				Me.oo00.oo. = value
			End Set
		End Property

		' Token: 0x1700144A RID: 5194
		' (get) Token: 0x060054F8 RID: 21752 RVA: 0x0021FD2B File Offset: 0x0021DF2B
		' (set) Token: 0x060054F9 RID: 21753 RVA: 0x0021FD33 File Offset: 0x0021DF33
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AutoDeleteAttachFile As BooleanEnum
			Get
				Return Me.OOo_o.Oo.
			End Get
			Set(value As BooleanEnum)
				Me.OOo_o.Oo. = value
			End Set
		End Property

		' Token: 0x1700144B RID: 5195
		' (get) Token: 0x060054FA RID: 21754 RVA: 0x0021FD3C File Offset: 0x0021DF3C
		' (set) Token: 0x060054FB RID: 21755 RVA: 0x0021FD44 File Offset: 0x0021DF44
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FileFilter As String
			Get
				Return Me.O0__0.0Oo.
			End Get
			Set(value As String)
				Me.O0__0.0Oo. = value
			End Set
		End Property

		' Token: 0x040021D0 RID: 8656
		Private <<EMPTY_NAME>> As FileManager

		' Token: 0x040021D1 RID: 8657
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040021D2 RID: 8658
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021D3 RID: 8659
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021D4 RID: 8660
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021D5 RID: 8661
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021D6 RID: 8662
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040021D7 RID: 8663
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021D8 RID: 8664
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021D9 RID: 8665
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040021DA RID: 8666
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040021DB RID: 8667
		Private <<EMPTY_NAME>> As String

		' Token: 0x040021DC RID: 8668
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
