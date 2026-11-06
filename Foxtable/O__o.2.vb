Imports System
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000267 RID: 615
	Friend Class O__o
		Inherits O0O_O0

		' Token: 0x06001D59 RID: 7513 RVA: 0x000BA57C File Offset: 0x000B877C
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As Binding
			Return Me.o__0_o0.OOO_.
		End Function

		' Token: 0x06001D5A RID: 7514 RVA: 0x000BA584 File Offset: 0x000B8784
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As Binding)
			Dim value As ConvertEventHandler = AddressOf Me.o__0_o0.OOO_.
			Dim binding As Binding = Me.o__0_o0.OOO_.
			If binding IsNot Nothing Then
				RemoveHandler binding.Parse, value
			End If
			Me.o__0_o0.OOO_. = A_0
			binding = Me.o__0_o0.OOO_.
			If binding IsNot Nothing Then
				AddHandler binding.Parse, value
			End If
		End Sub

		' Token: 0x06001D5B RID: 7515 RVA: 0x000BA5C7 File Offset: 0x000B87C7
		Public Sub New()
			Me.o__0_o0.OOO_. = True
			MyBase.VerticalAlign = 0
			Me.Multiline = True
			MyBase.ScrollBars = ScrollBars.Vertical
			MyBase.InitialSelection = 1
		End Sub

		' Token: 0x06001D5C RID: 7516 RVA: 0x000BA5F2 File Offset: 0x000B87F2
		Friend Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As String)
			MyBase.DataBindings.Add("Value", A_0.View, A_1)
			Me.o__0_o0.OOO_. = A_0
			Me.o__0_o0.OOO_.(MyBase.DataBindings(0))
		End Sub

		' Token: 0x06001D5D RID: 7517 RVA: 0x000BA628 File Offset: 0x000B8828
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ConvertEventArgs)
			Dim dataRowView As DataRowView = CType(Me.o__0_o0.OOO_.().BindingManagerBase.Current, DataRowView)
			Dim bindingField As String = Me.o__0_o0.OOO_.().BindingMemberInfo.BindingField
			If Operators.CompareString(A_1.Value.ToString(), dataRowView(bindingField).ToString(), True) <> 0 Then
				Me.o__0_o0.OOO_..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.o__0_o0.OOO_., dataRowView.Row, bindingField))
			End If
		End Sub

		' Token: 0x06001D5E RID: 7518 RVA: 0x000BA6A0 File Offset: 0x000B88A0
		Friend Function <<EMPTY_NAME>>() As DataCol
			Dim dataTable As DataTable = CType(Me.o__0_o0.OOO_.().DataSource, O_0).o_o.O0ooOo.()
			Return OO_00oOO.DataTables(dataTable.TableName).DataCols(Me.o__0_o0.OOO_.().BindingMemberInfo.BindingField)
		End Function

		' Token: 0x04000C55 RID: 3157
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C56 RID: 3158
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Binding

		' Token: 0x04000C57 RID: 3159
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
