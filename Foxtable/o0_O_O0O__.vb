Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000427 RID: 1063
	Friend Class o0_O_O0O__
		Implements O_o_0o

		' Token: 0x06004610 RID: 17936 RVA: 0x001C50F4 File Offset: 0x001C32F4
		Friend Sub New(A_0 As String, A_1 As C1DockingTabPage, A_2 As PropertyBase)
			Me.Oo_._O0oOOOo. = A_1
			Me.Oo_._O0oOOOo. = A_2
			Me.Oo_._O0oOOOo. = A_0
			Dim [property] As PropertyInfo = A_2.[GetType]().GetProperty(A_0)
			Me.oo0_O0_000o.0o. = RuntimeHelpers.GetObjectValue([property].GetValue(A_2, Nothing))
		End Sub

		' Token: 0x06004611 RID: 17937 RVA: 0x001C513C File Offset: 0x001C333C
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O_o_0o.O_OO0.O.
			Dim c1DockingTab As C1DockingTab = CType(Me.Oo_._O0oOOOo..Holder.ChildControl, C1DockingTab)
			If c1DockingTab.SelectedTab <> Me.Oo_._O0oOOOo. Then
				c1DockingTab.SelectedTab = Me.Oo_._O0oOOOo.
				Application.DoEvents()
			End If
			Me.Oo_._O0oOOOo..[GetType]().GetProperty(Me.Oo_._O0oOOOo.).SetValue(Me.Oo_._O0oOOOo., RuntimeHelpers.GetObjectValue(Me.oo0_O0_000o.0o.), Nothing)
			If Not Me.Oo_._O0oOOOo..Holder.Selected Then
				Me.Oo_._O0oOOOo..Holder.Selected = True
			End If
		End Sub

		' Token: 0x04001C93 RID: 7315
		Private <<EMPTY_NAME>> As PropertyBase

		' Token: 0x04001C94 RID: 7316
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04001C95 RID: 7317
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C96 RID: 7318
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
