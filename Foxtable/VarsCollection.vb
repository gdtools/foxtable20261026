Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200031F RID: 799
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class VarsCollection
		' Token: 0x17000A3D RID: 2621
		' (get) Token: 0x06002B4E RID: 11086 RVA: 0x0012F5D4 File Offset: 0x0012D7D4
		' (set) Token: 0x06002B4F RID: 11087 RVA: 0x0012F5DC File Offset: 0x0012D7DC
		Friend Overridable Property VariableTable As DataTable
			<CompilerGenerated()>
			Get
				Return Me.o0.oooO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataTable)
				Dim value2 As DataColumnChangeEventHandler = AddressOf Me.o0.oooO.
				Dim dataTable As DataTable = Me.o0.oooO.
				If dataTable IsNot Nothing Then
					RemoveHandler dataTable.ColumnChanged, value2
				End If
				Me.o0.oooO. = value
				dataTable = Me.o0.oooO.
				If dataTable IsNot Nothing Then
					AddHandler dataTable.ColumnChanged, value2
				End If
			End Set
		End Property

		' Token: 0x06002B50 RID: 11088 RVA: 0x0012F61F File Offset: 0x0012D81F
		Public Sub New()
			Me.VariableTable = New DataTable()
			Me.VariableTable.Rows.Add(Me.VariableTable.NewRow())
		End Sub

		' Token: 0x17000A3E RID: 2622
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(VarName As String) As Object
			Get
				If Me.VariableTable.Columns.Contains(VarName) Then
					If Not Me.VariableTable.Rows(0).IsNull(VarName) Then
						Return Me.VariableTable.Rows(0)(VarName)
					End If
				ElseIf O_O0OO.O0_00o.o0__o..DeclareVar Then
					MessageBox.Show("未定义变量" + VarName + "！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
				Return Nothing
			End Get
			Set(value As Object)
				Dim flag As Boolean
				If Not Me.VariableTable.Columns.Contains(VarName) Then
					If O_O0OO.O0_00o.o0__o..DeclareVar Then
						MessageBox.Show("未定义变量" + VarName + "！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					flag = True
					Me.Add(VarName, value.[GetType]())
				End If
				If flag OrElse ((value IsNot Nothing OrElse (Me.VariableTable.Rows(0)(VarName) IsNot Nothing AndAlso Not Me.VariableTable.Rows(0).IsNull(VarName))) AndAlso (value Is Nothing OrElse Me.VariableTable.Rows(0)(VarName) Is Nothing OrElse (Not value.[GetType]().IsValueType AndAlso Not(TypeOf value Is String)) OrElse Operators.CompareString(value.ToString(), Me.VariableTable.Rows(0)(VarName).ToString(), True) <> 0)) Then
					If value Is Nothing Then
						value = DBNull.Value
					End If
					Me.VariableTable.Rows(0)(VarName) = RuntimeHelpers.GetObjectValue(value)
					Me.VariableTable.Rows(0).EndEdit()
				End If
			End Set
		End Property

		' Token: 0x06002B53 RID: 11091 RVA: 0x0012F808 File Offset: 0x0012DA08
		Public Sub Clear()
			For i As Integer = Me.VariableTable.Columns.Count - 1 To 0 Step -1
				If Not Me.VariableTable.Columns(i).ColumnName.ToLower().StartsWith("sys") Then
					Me.VariableTable.Columns.RemoveAt(i)
				End If
			Next
		End Sub

		' Token: 0x06002B54 RID: 11092 RVA: 0x0012F86C File Offset: 0x0012DA6C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Add(ParamArray args As Object())
			If args.Length >= 2 Then
				Dim varName As String = Conversions.ToString(args(0))
				Dim type As Type = ooO.o.O_0000_O.(Conversions.ToString(args(1)))
				If args.Length = 2 Then
					Me.Add(varName, type)
					Return
				End If
				If args.Length = 3 Then
					Me.Add(varName, type, RuntimeHelpers.GetObjectValue(args(2)))
				End If
			End If
		End Sub

		' Token: 0x06002B55 RID: 11093 RVA: 0x0012F8BB File Offset: 0x0012DABB
		Public Sub Add(VarName As String, Type As Type)
			Me.Add(VarName, Type, Nothing)
		End Sub

		' Token: 0x06002B56 RID: 11094 RVA: 0x0012F8C8 File Offset: 0x0012DAC8
		Public Sub Add(VarName As String, Type As Type, Value As Object)
			If VarName.ToLower().StartsWith("sys") Then
				MessageBox.Show("全局变量名不能以sys开头！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Operators.CompareString(VarName, "", True) > 0 AndAlso Type IsNot Nothing Then
				Me.o.O0o_O.(VarName, Type, RuntimeHelpers.GetObjectValue(Value))
			End If
		End Sub

		' Token: 0x06002B57 RID: 11095 RVA: 0x0012F91C File Offset: 0x0012DB1C
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Type, A_2 As Object)
			If Me.VariableTable.Columns.Contains(A_0) Then
				If Me.VariableTable.Columns(A_0).DataType IsNot A_1 Then
					Me.VariableTable.Columns.Remove(A_0)
					Me.VariableTable.Columns.Add(A_0, A_1)
				End If
			Else
				Me.VariableTable.Columns.Add(A_0, A_1)
			End If
			If A_2 IsNot Nothing AndAlso Operators.CompareString(A_2.ToString(), "", True) <> 0 Then
				If o_O_o_oOoo__.OO_.O.(Me.VariableTable.Columns(A_0).DataType) Then
					Dim num As Double
					If Double.TryParse(A_2.ToString(), num) Then
						Me.VariableTable.Rows(0)(A_0) = num
						Return
					End If
				ElseIf Me.VariableTable.Columns(A_0).DataType Is GetType(DateTime) Then
					Dim dateTime As DateTime
					If DateTime.TryParse(A_2.ToString(), dateTime) Then
						Me.VariableTable.Rows(0)(A_0) = dateTime
						Return
					End If
				ElseIf Me.VariableTable.Columns(A_0).DataType Is GetType(Boolean) Then
					Dim flag As Boolean
					If Boolean.TryParse(A_2.ToString(), flag) Then
						Me.VariableTable.Rows(0)(A_0) = flag
						Return
					End If
				Else
					Me.VariableTable.Rows(0)(A_0) = RuntimeHelpers.GetObjectValue(A_2)
				End If
			End If
		End Sub

		' Token: 0x06002B58 RID: 11096 RVA: 0x0012FAB8 File Offset: 0x0012DCB8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataColumnChangeEventArgs)
			If Not A_1.Column.ColumnName.ToLower().StartsWith("sys") Then
				Dim globalVariableChangedEventArgs As GlobalVariableChangedEventArgs = New GlobalVariableChangedEventArgs(A_1.Column.ColumnName)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "GlobalVariableChanged", New Object() { globalVariableChangedEventArgs }, False, "项目", False)
			End If
		End Sub

		' Token: 0x0400118E RID: 4494
		<AccessedThroughProperty("VariableTable")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
