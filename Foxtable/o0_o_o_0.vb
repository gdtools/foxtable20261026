Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200006C RID: 108
	Friend Class o0_o_o_0
		Inherits C1DropDownControl

		' Token: 0x0600039B RID: 923 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As CustomCheckedListBox
			Return Me.o_.O_.
		End Function

		' Token: 0x0600039C RID: 924 RVA: 0x0000C1EA File Offset: 0x0000A3EA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As CustomCheckedListBox)
			Me.o_.O_. = A_0
		End Sub

		' Token: 0x0600039D RID: 925 RVA: 0x0000C1F3 File Offset: 0x0000A3F3
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As O\u3002\u3000
			Return Me.o_o.O_0OOO.
		End Function

		' Token: 0x0600039E RID: 926 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000)
			Dim value As EventHandler = AddressOf Me.o._0__00_oo.
			Dim o_u3002_u As O\u3002\u3000 = Me.o_o.O_0OOO.
			If o_u3002_u IsNot Nothing Then
				RemoveHandler o_u3002_u.Disposed, value
			End If
			Me.o_o.O_0OOO. = A_0
			o_u3002_u = Me.o_o.O_0OOO.
			If o_u3002_u IsNot Nothing Then
				AddHandler o_u3002_u.Disposed, value
			End If
		End Sub

		' Token: 0x0600039F RID: 927 RVA: 0x0000C240 File Offset: 0x0000A440
		Public Sub New()
			MyBase.DropDownOpened += AddressOf Me.O0oo0o.o_o_.
			AddHandler MyBase.FontChanged, AddressOf Me.O._0.
			AddHandler MyBase.GotFocus, AddressOf Me.o_O.0O.
			AddHandler MyBase.KeyDown, AddressOf Me.o._0__00_oo.
			AddHandler MyBase.KeyPress, AddressOf Me.o._0__00_oo.
			Me.o_o.O_0OOO. = ","
			Me.o_.O_. = True
			Me.ShowUpDownButtons = False
			Me.DataType = GetType(String)
			Me.o_.O_.(New O\u3002\u3000())
			Me.O.0o0O.(Me.o.O0.().O__0o.o0_.())
			Me.DropDownForm = Me.o.O0.()
			MyBase.VisualStyle = 1
			Me.o.O0.().O__0o.o0_.().Font = Me.Font
		End Sub

		' Token: 0x060003A0 RID: 928 RVA: 0x0000C31B File Offset: 0x0000A51B
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If A_0.Msg <> 770 OrElse Me.o._0__00_oo.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x060003A1 RID: 929 RVA: 0x0000C339 File Offset: 0x0000A539
		Public Function <<EMPTY_NAME>>() As String
			Return Me.o_o.O_0OOO.
		End Function

		' Token: 0x060003A2 RID: 930 RVA: 0x0000C341 File Offset: 0x0000A541
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o_o.O_0OOO. = A_0
			Me.o.O0.().O__0o.o0_.().Separator = A_0
		End Sub

		' Token: 0x060003A3 RID: 931 RVA: 0x0000C35B File Offset: 0x0000A55B
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.o_.O_.
		End Function

		' Token: 0x060003A4 RID: 932 RVA: 0x0000C363 File Offset: 0x0000A563
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o_.O_. = A_0
		End Sub

		' Token: 0x060003A5 RID: 933 RVA: 0x0000C36C File Offset: 0x0000A56C
		Public Function <<EMPTY_NAME>>() As CheckedListBox.ObjectCollection
			Return Me.o.O0.().Items
		End Function

		' Token: 0x060003A6 RID: 934 RVA: 0x0000C379 File Offset: 0x0000A579
		Public Function <<EMPTY_NAME>>() As String
			Return Me.o.O0.().DisplayMember
		End Function

		' Token: 0x060003A7 RID: 935 RVA: 0x0000C386 File Offset: 0x0000A586
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o.O0.().DisplayMember = A_0
		End Sub

		' Token: 0x060003A8 RID: 936 RVA: 0x0000C394 File Offset: 0x0000A594
		Public Function <<EMPTY_NAME>>() As String
			Return Me.o.O0.().ValueMember
		End Function

		' Token: 0x060003A9 RID: 937 RVA: 0x0000C3A1 File Offset: 0x0000A5A1
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o.O0.().ValueMember = A_0
		End Sub

		' Token: 0x060003AA RID: 938 RVA: 0x0000C3AF File Offset: 0x0000A5AF
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.o.O0.().DataSource
		End Function

		' Token: 0x060003AB RID: 939 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim a_ As String = Me.oOo_o_o000.o.()
			Me.o.O0.().DataSource = RuntimeHelpers.GetObjectValue(A_0)
			Me.OoO00_0_._0.(a_)
		End Sub

		' Token: 0x060003AC RID: 940 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.o.O0.().MultiColumn
		End Function

		' Token: 0x060003AD RID: 941 RVA: 0x0000C3F5 File Offset: 0x0000A5F5
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o.O0.().MultiColumn = A_0
		End Sub

		' Token: 0x060003AE RID: 942 RVA: 0x0000C403 File Offset: 0x0000A603
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.o.O0.().ColumnWidth
		End Function

		' Token: 0x060003AF RID: 943 RVA: 0x0000C410 File Offset: 0x0000A610
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.o.O0.().ColumnWidth = A_0
		End Sub

		' Token: 0x060003B0 RID: 944 RVA: 0x0000C41E File Offset: 0x0000A61E
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.o_o.O_0OOO.
		End Function

		' Token: 0x060003B1 RID: 945 RVA: 0x0000C426 File Offset: 0x0000A626
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.o_o.O_0OOO. = A_0
		End Sub

		' Token: 0x060003B2 RID: 946 RVA: 0x0000C42F File Offset: 0x0000A62F
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O0.0oOO00O.
		End Function

		' Token: 0x060003B3 RID: 947 RVA: 0x0000C437 File Offset: 0x0000A637
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O0.0oOO00O. = A_0
		End Sub

		' Token: 0x060003B4 RID: 948 RVA: 0x0000C440 File Offset: 0x0000A640
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O.o_.
		End Function

		' Token: 0x060003B5 RID: 949 RVA: 0x0000C448 File Offset: 0x0000A648
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O.o_. = A_0
		End Sub

		' Token: 0x060003B6 RID: 950 RVA: 0x0000C454 File Offset: 0x0000A654
		Friend Overloads Sub <<EMPTY_NAME>>()
			If Me.O_o.Ooo.() = 0 Then
				Me.o.O0.().Width = Math.Max(168, MyBase.Width)
			Else
				Me.o.O0.().Width = Math.Max(131, Me.O_o.Ooo.())
			End If
			If Not Me.oOo_o_o000.o.() Then
				Dim num As Integer = Math.Min(Me.oOo_o_o000.o.(), Math.Max(1, Me.o.O0.().Items.Count))
				Me.o.O0.().O__0o.o0_.().Height = Me.o.O0.().O__0o.o0_.().ItemHeight * num + 4
				Me.o.O0.().Height = Me.o.O0.().O__0o.o0_.().Height + 32
				Return
			End If
			If Me.o.O0.() > 0 Then
				Dim num2 As Integer = CInt(Convert.ToInt16(Math.Floor(CDbl((Me.o.O0.() - 36)) / CDbl(Me.o.O0.().O__0o.o0_.().ItemHeight))))
				num2 = Math.Max(1, num2)
				Me.o.O0.().O__0o.o0_.().Height = Me.o.O0.().O__0o.o0_.().ItemHeight * num2 + 4
				Me.o.O0.().Height = Me.o.O0.().O__0o.o0_.().Height + 32
			End If
		End Sub

		' Token: 0x060003B7 RID: 951 RVA: 0x0000C588 File Offset: 0x0000A788
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_.O_.()
			If Me.Value Is Nothing Then
				Me.o.O0.().Value = ""
			Else
				Me.o.O0.().Value = Me.Value.ToString()
			End If
			Me.o.O0.().Owner = Nothing
		End Sub

		' Token: 0x060003B8 RID: 952 RVA: 0x0000C5D7 File Offset: 0x0000A7D7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.O0.().O__0o.o0_.().Font = Me.Font
		End Sub

		' Token: 0x060003B9 RID: 953 RVA: 0x0000C5EF File Offset: 0x0000A7EF
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_.O_.()
		End Sub

		' Token: 0x060003BA RID: 954 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If Not Me.o._0__00_oo.() AndAlso A_1.KeyCode = Keys.Delete Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
			End If
			If A_1.KeyCode = Keys.Down Then
				If TypeOf MyBase.Parent Is O_oOooO_O AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					SendKeys.Send("{DOWN}")
					Return
				End If
			ElseIf A_1.KeyCode = Keys.Up AndAlso TypeOf MyBase.Parent Is O_oOooO_O AndAlso CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
				SendKeys.Send("{UP}")
			End If
		End Sub

		' Token: 0x060003BB RID: 955 RVA: 0x0000C68C File Offset: 0x0000A88C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If Not Me.o._0__00_oo.() Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
			End If
		End Sub

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x060003BC RID: 956 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		' (set) Token: 0x060003BD RID: 957 RVA: 0x0000C6CA File Offset: 0x0000A8CA
		Public Property Value As Object
			Get
				Dim result As Object
				If MyBase.Value Is DBNull.Value Then
					result = Nothing
				Else
					result = MyBase.Value
				End If
				Return result
			End Get
			Set(value As Object)
				MyBase.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x060003BE RID: 958 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Main.OO_O.o..Disposing AndAlso Not Main.OO_O.o..IsDisposed AndAlso Not Main.OO_O.o..o_O.o__. Then
				Dim right As String = ""
				Dim flag As Boolean
				Try
					For Each table As Table In OO_00oOO.Tables
						If Operators.CompareString(table.Name, table.DataTable.Name, True) = 0 Then
							Try
								For Each obj As Object In table.Grid.Cols
									Dim column As Column = CType(obj, Column)
									If column.Editor Is Me AndAlso table.DataTable.DataCols(column.Name).oO0._00o_0. Is Me Then
										flag = True
										right = table.DataTable.Name
										table.DataTable.DataCols(column.Name).oO0._00o_0. = Nothing
										Exit For
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If flag Then
					Try
						For Each table2 As Table In OO_00oOO.Tables
							If Operators.CompareString(table2.DataTable.Name, right, True) = 0 Then
								Try
									For Each obj2 As Object In table2.Grid.Cols
										Dim column2 As Column = CType(obj2, Column)
										If column2.Editor Is Me Then
											column2.Editor = Nothing
											table2.Cols(column2.Name).o0.O.()
										End If
									Next
								Finally
									Dim enumerator4 As IEnumerator
									If TypeOf enumerator4 Is IDisposable Then
										TryCast(enumerator4, IDisposable).Dispose()
									End If
								End Try
							End If
						Next
						Return
					Finally
						Dim enumerator3 As IEnumerator(Of Table)
						If enumerator3 IsNot Nothing Then
							enumerator3.Dispose()
						End If
					End Try
				End If
				Try
					For Each table3 As Table In OO_00oOO.Tables
						Try
							For Each obj3 As Object In table3.Grid.Cols
								Dim column3 As Column = CType(obj3, Column)
								If column3.Editor Is Me Then
									column3.Editor = Nothing
									Dim col As Col = table3.Cols(column3.Name)
									If Operators.CompareString(col.o_0.oo., "", True) > 0 Then
										col.ComboList = col.o_0.oo.
									ElseIf Operators.CompareString(col.DataSource, "", True) > 0 Then
										col.DataSource = col.DataSource
									End If
								End If
							Next
						Finally
							Dim enumerator6 As IEnumerator
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator5 As IEnumerator(Of Table)
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x040000C6 RID: 198
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000C7 RID: 199
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000C8 RID: 200
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000C9 RID: 201
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000CA RID: 202
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000CB RID: 203
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CustomCheckedListBox

		' Token: 0x040000CC RID: 204
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O\u3002\u3000

		' Token: 0x040000CD RID: 205
		Private Const <<EMPTY_NAME>> As Integer = 770
	End Class
End Namespace
