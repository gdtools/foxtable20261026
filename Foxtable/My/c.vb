Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.My
	' Token: 0x0200053E RID: 1342
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module c
		' Token: 0x0600586A RID: 22634 RVA: 0x0022F607 File Offset: 0x0022D807
		<DebuggerHidden()>
		Friend Function <<EMPTY_NAME>>() As Foxtable.My.a
			Return Foxtable.My.c.OOOOO.o..O._OO0_O.()
		End Function

		' Token: 0x0600586B RID: 22635 RVA: 0x0022F613 File Offset: 0x0022D813
		<DebuggerHidden()>
		Friend Function <<EMPTY_NAME>>() As d
			Return Foxtable.My.c.OOOOO.o..O._OO0_O.()
		End Function

		' Token: 0x0600586C RID: 22636 RVA: 0x0022F61F File Offset: 0x0022D81F
		<DebuggerHidden()>
		Friend Function <<EMPTY_NAME>>() As User
			Return Foxtable.My.c.OOOOO.o..O._OO0_O.()
		End Function

		' Token: 0x0600586D RID: 22637 RVA: 0x0022F62B File Offset: 0x0022D82B
		<DebuggerHidden()>
		Friend Function <<EMPTY_NAME>>() As Foxtable.My.c.b
			Return Foxtable.My.c.OOOOO.o..O._OO0_O.()
		End Function

		' Token: 0x0600586E RID: 22638 RVA: 0x0022F637 File Offset: 0x0022D837
		<DebuggerHidden()>
		Friend Function <<EMPTY_NAME>>() As Foxtable.My.c.c
			Return Foxtable.My.c.OOOOO.o..O._OO0_O.()
		End Function

		' Token: 0x04002259 RID: 8793
		Private <<EMPTY_NAME>> As Foxtable.My.c(Of Foxtable.My.a).a = New Foxtable.My.c(Of Foxtable.My.a).a()

		' Token: 0x0400225A RID: 8794
		Private <<EMPTY_NAME>> As Foxtable.My.c(Of d).a = New Foxtable.My.c(Of d).a()

		' Token: 0x0400225B RID: 8795
		Private <<EMPTY_NAME>> As Foxtable.My.c(Of User).a = New Foxtable.My.c(Of User).a()

		' Token: 0x0400225C RID: 8796
		Private <<EMPTY_NAME>> As Foxtable.My.c(Of Foxtable.My.c.b).a = New Foxtable.My.c(Of Foxtable.My.c.b).a()

		' Token: 0x0400225D RID: 8797
		Private <<EMPTY_NAME>> As Foxtable.My.c(Of Foxtable.My.c.c).a = New Foxtable.My.c(Of Foxtable.My.c.c).a()

		' Token: 0x0200053F RID: 1343
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class b
			' Token: 0x0600586F RID: 22639 RVA: 0x0022F644 File Offset: 0x0022D844
			<DebuggerHidden()>
			Private Shared Function <<EMPTY_NAME>>(Of a As{Form, New})(A_0 As a) As a
				If A_0 Is Nothing OrElse A_0.IsDisposed Then
					If Foxtable.My.c.b.o._0Oo0O0O. IsNot Nothing Then
						If Foxtable.My.c.b.o._0Oo0O0O..ContainsKey(GetType(a)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						Foxtable.My.c.b.o._0Oo0O0O. = New Hashtable()
					End If
					Foxtable.My.c.b.o._0Oo0O0O..Add(GetType(a), Nothing)
					Try
						Return Activator.CreateInstance(Of a)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message }), ex.InnerException)
					Finally
						Foxtable.My.c.b.o._0Oo0O0O..Remove(GetType(a))
					End Try
				End If
				Return A_0
			End Function

			' Token: 0x06005870 RID: 22640 RVA: 0x0022F748 File Offset: 0x0022D948
			<DebuggerHidden()>
			Private Overloads Sub <<EMPTY_NAME>>(Of a As Form)(ByRef A_0 As a)
				A_0.Dispose()
				A_0 = Nothing
			End Sub

			' Token: 0x06005871 RID: 22641 RVA: 0x0022F75D File Offset: 0x0022D95D
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x06005872 RID: 22642 RVA: 0x0022F765 File Offset: 0x0022D965
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overloads Function <<EMPTY_NAME>>(A_0 As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(A_0))
			End Function

			' Token: 0x06005873 RID: 22643 RVA: 0x0022F773 File Offset: 0x0022D973
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overloads Function <<EMPTY_NAME>>() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06005874 RID: 22644 RVA: 0x0022F77B File Offset: 0x0022D97B
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Overloads Function <<EMPTY_NAME>>() As Type
				Return GetType(Foxtable.My.c.b)
			End Function

			' Token: 0x06005875 RID: 22645 RVA: 0x0022F787 File Offset: 0x0022D987
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overloads Function <<EMPTY_NAME>>() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06005876 RID: 22646 RVA: 0x0022F78F File Offset: 0x0022D98F
			Public Overloads Function <<EMPTY_NAME>>() As oOo_O_0O
				Me.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.(Of oOo_O_0O)(Me.o._0Oo0O0O.)
				Return Me.o._0Oo0O0O.
			End Function

			' Token: 0x06005877 RID: 22647 RVA: 0x0022F7A8 File Offset: 0x0022D9A8
			Public Overloads Function <<EMPTY_NAME>>() As O0oO_0
				Me.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.(Of O0oO_0)(Me.o._0Oo0O0O.)
				Return Me.o._0Oo0O0O.
			End Function

			' Token: 0x06005878 RID: 22648 RVA: 0x0022F7C1 File Offset: 0x0022D9C1
			Public Overloads Function <<EMPTY_NAME>>() As oOo0o0__0
				Me.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.(Of oOo0o0__0)(Me.o._0Oo0O0O.)
				Return Me.o._0Oo0O0O.
			End Function

			' Token: 0x06005879 RID: 22649 RVA: 0x0022F7DA File Offset: 0x0022D9DA
			Public Overloads Function <<EMPTY_NAME>>() As oo0O0oO_OOOo
				Me.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.(Of oo0O0oO_OOOo)(Me.o._0Oo0O0O.)
				Return Me.o._0Oo0O0O.
			End Function

			' Token: 0x0600587A RID: 22650 RVA: 0x0022F7F3 File Offset: 0x0022D9F3
			Public Overloads Function <<EMPTY_NAME>>() As g1
				Me.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.(Of g1)(Me.o._0Oo0O0O.)
				Return Me.o._0Oo0O0O.
			End Function

			' Token: 0x0600587B RID: 22651 RVA: 0x0022F80C File Offset: 0x0022DA0C
			Public Overloads Function <<EMPTY_NAME>>() As o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002
				Me.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002)(Me.o._0Oo0O0O.)
				Return Me.o._0Oo0O0O.
			End Function

			' Token: 0x0600587C RID: 22652 RVA: 0x0022F825 File Offset: 0x0022DA25
			Public Overloads Function <<EMPTY_NAME>>() As O\u3002\u3002
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x0600587D RID: 22653 RVA: 0x0022F83E File Offset: 0x0022DA3E
			Public Overloads Function <<EMPTY_NAME>>() As o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x0600587E RID: 22654 RVA: 0x0022F857 File Offset: 0x0022DA57
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x0600587F RID: 22655 RVA: 0x0022F870 File Offset: 0x0022DA70
			Public Function <<EMPTY_NAME>>() As O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005880 RID: 22656 RVA: 0x0022F889 File Offset: 0x0022DA89
			Public Function a() As O\u3000\u3002\u3000\u3000
				Me.a = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3002\u3000\u3000)(Me.a)
				Return Me.a
			End Function

			' Token: 0x06005881 RID: 22657 RVA: 0x0022F8A2 File Offset: 0x0022DAA2
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002o
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002o)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005882 RID: 22658 RVA: 0x0022F8BB File Offset: 0x0022DABB
			Public Function <<EMPTY_NAME>>() As oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005883 RID: 22659 RVA: 0x0022F8D4 File Offset: 0x0022DAD4
			Public Function <<EMPTY_NAME>>() As O\u3002\u3000\u3000
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3000\u3000)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005884 RID: 22660 RVA: 0x0022F8ED File Offset: 0x0022DAED
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3002\u3002_o\u3000
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3002\u3002_o\u3000)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005885 RID: 22661 RVA: 0x0022F906 File Offset: 0x0022DB06
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005886 RID: 22662 RVA: 0x0022F91F File Offset: 0x0022DB1F
			Public Function <<EMPTY_NAME>>() As o\u3002\u3000\u3002
				Me.o_.__0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3002)(Me.o_.__0.)
				Return Me.o_.__0.
			End Function

			' Token: 0x06005887 RID: 22663 RVA: 0x0022F938 File Offset: 0x0022DB38
			Public Function <<EMPTY_NAME>>() As o\u3000\u3000\u3002\u3000\u3000
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3000\u3002\u3000\u3000)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x06005888 RID: 22664 RVA: 0x0022F951 File Offset: 0x0022DB51
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3002\u3002\u3000
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3002\u3002\u3000)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x06005889 RID: 22665 RVA: 0x0022F96A File Offset: 0x0022DB6A
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x0600588A RID: 22666 RVA: 0x0022F983 File Offset: 0x0022DB83
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x0600588B RID: 22667 RVA: 0x0022F99C File Offset: 0x0022DB9C
			Public Function <<EMPTY_NAME>>() As o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x0600588C RID: 22668 RVA: 0x0022F9B5 File Offset: 0x0022DBB5
			Public Function <<EMPTY_NAME>>() As o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x0600588D RID: 22669 RVA: 0x0022F9CE File Offset: 0x0022DBCE
			Public Function <<EMPTY_NAME>>() As O\u3002o_\u3002\u3002\u3002\u3000\u3002o
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002o_\u3002\u3002\u3002\u3000\u3002o)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x0600588E RID: 22670 RVA: 0x0022F9E7 File Offset: 0x0022DBE7
			Public Function <<EMPTY_NAME>>() As o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x0600588F RID: 22671 RVA: 0x0022FA00 File Offset: 0x0022DC00
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x06005890 RID: 22672 RVA: 0x0022FA19 File Offset: 0x0022DC19
			Public Function <<EMPTY_NAME>>() As oO0\u3002
				Me.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.(Of oO0\u3002)(Me.OO.0o___o0o_.)
				Return Me.OO.0o___o0o_.
			End Function

			' Token: 0x06005891 RID: 22673 RVA: 0x0022FA32 File Offset: 0x0022DC32
			Public Function <<EMPTY_NAME>>() As o0o\u3002
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of o0o\u3002)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005892 RID: 22674 RVA: 0x0022FA4B File Offset: 0x0022DC4B
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005893 RID: 22675 RVA: 0x0022FA64 File Offset: 0x0022DC64
			Public Function <<EMPTY_NAME>>() As O\u3002\u30000
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u30000)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005894 RID: 22676 RVA: 0x0022FA7D File Offset: 0x0022DC7D
			Public Function <<EMPTY_NAME>>() As o\u3002\u3002\u3000
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3002\u3000)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005895 RID: 22677 RVA: 0x0022FA96 File Offset: 0x0022DC96
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3000\u3000
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3000\u3000)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005896 RID: 22678 RVA: 0x0022FAAF File Offset: 0x0022DCAF
			Public Function <<EMPTY_NAME>>() As oo\u3000\u3000\u3000\u3002
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of oo\u3000\u3000\u3000\u3002)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005897 RID: 22679 RVA: 0x0022FAC8 File Offset: 0x0022DCC8
			Public Function <<EMPTY_NAME>>() As h0
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of h0)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005898 RID: 22680 RVA: 0x0022FAE1 File Offset: 0x0022DCE1
			Public Function <<EMPTY_NAME>>() As o\u3002\u3000\u3000\u3000\u3002
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3000\u3000\u3002)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x06005899 RID: 22681 RVA: 0x0022FAFA File Offset: 0x0022DCFA
			Public Function <<EMPTY_NAME>>() As o\u30000\u3002
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of o\u30000\u3002)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x0600589A RID: 22682 RVA: 0x0022FB13 File Offset: 0x0022DD13
			Public Function <<EMPTY_NAME>>() As O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000
				Me.o0___.o. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000)(Me.o0___.o.)
				Return Me.o0___.o.
			End Function

			' Token: 0x0600589B RID: 22683 RVA: 0x0022FB2C File Offset: 0x0022DD2C
			Public Function <<EMPTY_NAME>>() As ev
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of ev)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x0600589C RID: 22684 RVA: 0x0022FB45 File Offset: 0x0022DD45
			Public Function <<EMPTY_NAME>>() As di
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of di)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x0600589D RID: 22685 RVA: 0x0022FB5E File Offset: 0x0022DD5E
			Public Function <<EMPTY_NAME>>() As O\u30000\u3002\u3002O
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of O\u30000\u3002\u3002O)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x0600589E RID: 22686 RVA: 0x0022FB77 File Offset: 0x0022DD77
			Public Function <<EMPTY_NAME>>() As jk
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of jk)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x0600589F RID: 22687 RVA: 0x0022FB90 File Offset: 0x0022DD90
			Public Function a() As o\u3000\u3002
				Me.a = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3002)(Me.a)
				Return Me.a
			End Function

			' Token: 0x060058A0 RID: 22688 RVA: 0x0022FBA9 File Offset: 0x0022DDA9
			Public Function <<EMPTY_NAME>>() As o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x060058A1 RID: 22689 RVA: 0x0022FBC2 File Offset: 0x0022DDC2
			Public Function <<EMPTY_NAME>>() As O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x060058A2 RID: 22690 RVA: 0x0022FBDB File Offset: 0x0022DDDB
			Public Function <<EMPTY_NAME>>() As o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x060058A3 RID: 22691 RVA: 0x0022FBF4 File Offset: 0x0022DDF4
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x060058A4 RID: 22692 RVA: 0x0022FC0D File Offset: 0x0022DE0D
			Public Function <<EMPTY_NAME>>() As O\u3002\u3000
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3000)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x060058A5 RID: 22693 RVA: 0x0022FC26 File Offset: 0x0022DE26
			Public Function <<EMPTY_NAME>>() As o\u3000\u3002\u3002\u30000\u3000
				Me.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3002\u3002\u30000\u3000)(Me.o_O_.oOo.)
				Return Me.o_O_.oOo.
			End Function

			' Token: 0x060058A6 RID: 22694 RVA: 0x0022FC3F File Offset: 0x0022DE3F
			Public Function <<EMPTY_NAME>>() As o\u3002\u3000\u3000\u3002\u3002\u30020\u3002
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3000\u3002\u3002\u30020\u3002)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058A7 RID: 22695 RVA: 0x0022FC58 File Offset: 0x0022DE58
			Public Function <<EMPTY_NAME>>() As O\u3000\u3002
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3002)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058A8 RID: 22696 RVA: 0x0022FC71 File Offset: 0x0022DE71
			Public Function <<EMPTY_NAME>>() As O\u3000\u3002\u3000\u3002\u3000\u3002
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3002\u3000\u3002\u3000\u3002)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058A9 RID: 22697 RVA: 0x0022FC8A File Offset: 0x0022DE8A
			Public Function <<EMPTY_NAME>>() As O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058AA RID: 22698 RVA: 0x0022FCA3 File Offset: 0x0022DEA3
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058AB RID: 22699 RVA: 0x0022FCBC File Offset: 0x0022DEBC
			Public Function <<EMPTY_NAME>>() As o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058AC RID: 22700 RVA: 0x0022FCD5 File Offset: 0x0022DED5
			Public Function <<EMPTY_NAME>>() As o\u3000\u3002\u3002\u3002\u3002
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3002\u3002\u3002\u3002)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058AD RID: 22701 RVA: 0x0022FCEE File Offset: 0x0022DEEE
			Public Function <<EMPTY_NAME>>() As o_\u3000\u3000\u3000
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of o_\u3000\u3000\u3000)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058AE RID: 22702 RVA: 0x0022FD07 File Offset: 0x0022DF07
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058AF RID: 22703 RVA: 0x0022FD20 File Offset: 0x0022DF20
			Public Function <<EMPTY_NAME>>() As O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000
				Me.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000)(Me.O000O_.0oO0.)
				Return Me.O000O_.0oO0.
			End Function

			' Token: 0x060058B0 RID: 22704 RVA: 0x0022FD39 File Offset: 0x0022DF39
			Public Function <<EMPTY_NAME>>() As o\u30020\u3002\u3000\u3002\u3000
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o\u30020\u3002\u3000\u3002\u3000)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B1 RID: 22705 RVA: 0x0022FD52 File Offset: 0x0022DF52
			Public Function <<EMPTY_NAME>>() As O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B2 RID: 22706 RVA: 0x0022FD6B File Offset: 0x0022DF6B
			Public Function <<EMPTY_NAME>>() As o0\u3002
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o0\u3002)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B3 RID: 22707 RVA: 0x0022FD84 File Offset: 0x0022DF84
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B4 RID: 22708 RVA: 0x0022FD9D File Offset: 0x0022DF9D
			Public Function <<EMPTY_NAME>>() As o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B5 RID: 22709 RVA: 0x0022FDB6 File Offset: 0x0022DFB6
			Public Function <<EMPTY_NAME>>() As o\u30000\u3002\u3000\u3000\u3000
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o\u30000\u3002\u3000\u3000\u3000)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B6 RID: 22710 RVA: 0x0022FDCF File Offset: 0x0022DFCF
			Public Function <<EMPTY_NAME>>() As O\u3002\u3000\u3002\u3000\u3000
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3000\u3002\u3000\u3000)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B7 RID: 22711 RVA: 0x0022FDE8 File Offset: 0x0022DFE8
			Public Function <<EMPTY_NAME>>() As o\u30000\u3000\u3000\u3002O
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o\u30000\u3000\u3000\u3002O)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B8 RID: 22712 RVA: 0x0022FE01 File Offset: 0x0022E001
			Public Function <<EMPTY_NAME>>() As o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058B9 RID: 22713 RVA: 0x0022FE1A File Offset: 0x0022E01A
			Public Function <<EMPTY_NAME>>() As o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002
				Me.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002)(Me.O_0O_O.oOOo0.)
				Return Me.O_0O_O.oOOo0.
			End Function

			' Token: 0x060058BA RID: 22714 RVA: 0x0022FE33 File Offset: 0x0022E033
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058BB RID: 22715 RVA: 0x0022FE4C File Offset: 0x0022E04C
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3000
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3000)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058BC RID: 22716 RVA: 0x0022FE65 File Offset: 0x0022E065
			Public Function <<EMPTY_NAME>>() As O_\u3000
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of O_\u3000)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058BD RID: 22717 RVA: 0x0022FE7E File Offset: 0x0022E07E
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058BE RID: 22718 RVA: 0x0022FE97 File Offset: 0x0022E097
			Public Function <<EMPTY_NAME>>() As O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058BF RID: 22719 RVA: 0x0022FEB0 File Offset: 0x0022E0B0
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058C0 RID: 22720 RVA: 0x0022FEC9 File Offset: 0x0022E0C9
			Public Function <<EMPTY_NAME>>() As o0\u3000\u3000\u3000\u3000\u3002\u3002
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of o0\u3000\u3000\u3000\u3000\u3002\u3002)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058C1 RID: 22721 RVA: 0x0022FEE2 File Offset: 0x0022E0E2
			Public Function <<EMPTY_NAME>>() As o\u3002\u3000\u3002_
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of o\u3002\u3000\u3002_)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058C2 RID: 22722 RVA: 0x0022FEFB File Offset: 0x0022E0FB
			Public Function <<EMPTY_NAME>>() As Oo\u3000\u3000\u3002\u3000\u3002\u3002
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of Oo\u3000\u3000\u3002\u3000\u3002\u3002)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058C3 RID: 22723 RVA: 0x0022FF14 File Offset: 0x0022E114
			Public Function <<EMPTY_NAME>>() As gg
				Me.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.(Of gg)(Me.O.OOo_OOo__.)
				Return Me.O.OOo_OOo__.
			End Function

			' Token: 0x060058C4 RID: 22724 RVA: 0x0022FF2D File Offset: 0x0022E12D
			Public Function <<EMPTY_NAME>>() As O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000
				Me.oo_.O0O00. = Foxtable.My.c.b.OOOOO.o.(Of O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000)(Me.oo_.O0O00.)
				Return Me.oo_.O0O00.
			End Function

			' Token: 0x060058C5 RID: 22725 RVA: 0x0022FF46 File Offset: 0x0022E146
			Public Function <<EMPTY_NAME>>() As o\u3000\u3000\u3002\u3002O
				Me.oo_.O0O00. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000\u3000\u3002\u3002O)(Me.oo_.O0O00.)
				Return Me.oo_.O0O00.
			End Function

			' Token: 0x060058C6 RID: 22726 RVA: 0x0022FF5F File Offset: 0x0022E15F
			Public Overloads Function <<EMPTY_NAME>>() As o\u3000_\u3000\u3002_\u3002\u3000
				Me.oo_.O0O00. = Foxtable.My.c.b.OOOOO.o.(Of o\u3000_\u3000\u3002_\u3002\u3000)(Me.oo_.O0O00.)
				Return Me.oo_.O0O00.
			End Function

			' Token: 0x060058C7 RID: 22727 RVA: 0x0022FF78 File Offset: 0x0022E178
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As oOo_O_0O)
				If A_0 IsNot Me.o._0Oo0O0O. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of oOo_O_0O)(Me.o._0Oo0O0O.)
				End If
			End Sub

			' Token: 0x060058C8 RID: 22728 RVA: 0x0022FF9D File Offset: 0x0022E19D
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As O0oO_0)
				If A_0 IsNot Me.o._0Oo0O0O. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O0oO_0)(Me.o._0Oo0O0O.)
				End If
			End Sub

			' Token: 0x060058C9 RID: 22729 RVA: 0x0022FFC2 File Offset: 0x0022E1C2
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As oOo0o0__0)
				If A_0 IsNot Me.o._0Oo0O0O. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of oOo0o0__0)(Me.o._0Oo0O0O.)
				End If
			End Sub

			' Token: 0x060058CA RID: 22730 RVA: 0x0022FFE7 File Offset: 0x0022E1E7
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As oo0O0oO_OOOo)
				If A_0 IsNot Me.o._0Oo0O0O. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of oo0O0oO_OOOo)(Me.o._0Oo0O0O.)
				End If
			End Sub

			' Token: 0x060058CB RID: 22731 RVA: 0x0023000C File Offset: 0x0022E20C
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As g1)
				If A_0 IsNot Me.o._0Oo0O0O. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of g1)(Me.o._0Oo0O0O.)
				End If
			End Sub

			' Token: 0x060058CC RID: 22732 RVA: 0x00230031 File Offset: 0x0022E231
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002)
				If A_0 IsNot Me.o._0Oo0O0O. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002)(Me.o._0Oo0O0O.)
				End If
			End Sub

			' Token: 0x060058CD RID: 22733 RVA: 0x00230056 File Offset: 0x0022E256
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058CE RID: 22734 RVA: 0x0023007B File Offset: 0x0022E27B
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058CF RID: 22735 RVA: 0x002300A0 File Offset: 0x0022E2A0
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D0 RID: 22736 RVA: 0x002300C5 File Offset: 0x0022E2C5
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D1 RID: 22737 RVA: 0x002300EA File Offset: 0x0022E2EA
			Public Sub a(A_0 As O\u3000\u3002\u3000\u3000)
				If A_0 IsNot Me.a Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3002\u3000\u3000)(Me.a)
				End If
			End Sub

			' Token: 0x060058D2 RID: 22738 RVA: 0x0023010F File Offset: 0x0022E30F
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002o)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002o)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D3 RID: 22739 RVA: 0x00230134 File Offset: 0x0022E334
			Public Sub <<EMPTY_NAME>>(A_0 As oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D4 RID: 22740 RVA: 0x00230159 File Offset: 0x0022E359
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000\u3000)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3000\u3000)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D5 RID: 22741 RVA: 0x0023017E File Offset: 0x0022E37E
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3002\u3002_o\u3000)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3002\u3002_o\u3000)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D6 RID: 22742 RVA: 0x002301A3 File Offset: 0x0022E3A3
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D7 RID: 22743 RVA: 0x002301C8 File Offset: 0x0022E3C8
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3002)
				If A_0 IsNot Me.o_.__0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3002)(Me.o_.__0.)
				End If
			End Sub

			' Token: 0x060058D8 RID: 22744 RVA: 0x002301ED File Offset: 0x0022E3ED
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000\u3002\u3000\u3000)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3000\u3002\u3000\u3000)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058D9 RID: 22745 RVA: 0x00230212 File Offset: 0x0022E412
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3002\u3002\u3000)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3002\u3002\u3000)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058DA RID: 22746 RVA: 0x00230237 File Offset: 0x0022E437
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058DB RID: 22747 RVA: 0x0023025C File Offset: 0x0022E45C
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058DC RID: 22748 RVA: 0x00230281 File Offset: 0x0022E481
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058DD RID: 22749 RVA: 0x002302A6 File Offset: 0x0022E4A6
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058DE RID: 22750 RVA: 0x002302CB File Offset: 0x0022E4CB
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002o_\u3002\u3002\u3002\u3000\u3002o)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002o_\u3002\u3002\u3002\u3000\u3002o)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058DF RID: 22751 RVA: 0x002302F0 File Offset: 0x0022E4F0
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058E0 RID: 22752 RVA: 0x00230315 File Offset: 0x0022E515
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058E1 RID: 22753 RVA: 0x0023033A File Offset: 0x0022E53A
			Public Sub <<EMPTY_NAME>>(A_0 As oO0\u3002)
				If A_0 IsNot Me.OO.0o___o0o_. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of oO0\u3002)(Me.OO.0o___o0o_.)
				End If
			End Sub

			' Token: 0x060058E2 RID: 22754 RVA: 0x0023035F File Offset: 0x0022E55F
			Public Sub <<EMPTY_NAME>>(A_0 As o0o\u3002)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o0o\u3002)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E3 RID: 22755 RVA: 0x00230384 File Offset: 0x0022E584
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E4 RID: 22756 RVA: 0x002303A9 File Offset: 0x0022E5A9
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u30000)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u30000)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E5 RID: 22757 RVA: 0x002303CE File Offset: 0x0022E5CE
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3002\u3000)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3002\u3000)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E6 RID: 22758 RVA: 0x002303F3 File Offset: 0x0022E5F3
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3000\u3000)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3000\u3000)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E7 RID: 22759 RVA: 0x00230418 File Offset: 0x0022E618
			Public Sub <<EMPTY_NAME>>(A_0 As oo\u3000\u3000\u3000\u3002)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of oo\u3000\u3000\u3000\u3002)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E8 RID: 22760 RVA: 0x0023043D File Offset: 0x0022E63D
			Public Sub <<EMPTY_NAME>>(A_0 As h0)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of h0)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058E9 RID: 22761 RVA: 0x00230462 File Offset: 0x0022E662
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3000\u3000\u3002)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3000\u3000\u3002)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058EA RID: 22762 RVA: 0x00230487 File Offset: 0x0022E687
			Public Sub <<EMPTY_NAME>>(A_0 As o\u30000\u3002)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u30000\u3002)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058EB RID: 22763 RVA: 0x002304AC File Offset: 0x0022E6AC
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000)
				If A_0 IsNot Me.o0___.o. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000)(Me.o0___.o.)
				End If
			End Sub

			' Token: 0x060058EC RID: 22764 RVA: 0x002304D1 File Offset: 0x0022E6D1
			Public Sub <<EMPTY_NAME>>(A_0 As ev)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of ev)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058ED RID: 22765 RVA: 0x002304F6 File Offset: 0x0022E6F6
			Public Sub <<EMPTY_NAME>>(A_0 As di)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of di)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058EE RID: 22766 RVA: 0x0023051B File Offset: 0x0022E71B
			Public Sub <<EMPTY_NAME>>(A_0 As O\u30000\u3002\u3002O)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u30000\u3002\u3002O)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058EF RID: 22767 RVA: 0x00230540 File Offset: 0x0022E740
			Public Sub <<EMPTY_NAME>>(A_0 As jk)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of jk)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F0 RID: 22768 RVA: 0x00230565 File Offset: 0x0022E765
			Public Sub a(A_0 As o\u3000\u3002)
				If A_0 IsNot Me.a Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3002)(Me.a)
				End If
			End Sub

			' Token: 0x060058F1 RID: 22769 RVA: 0x0023058A File Offset: 0x0022E78A
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F2 RID: 22770 RVA: 0x002305AF File Offset: 0x0022E7AF
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F3 RID: 22771 RVA: 0x002305D4 File Offset: 0x0022E7D4
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F4 RID: 22772 RVA: 0x002305F9 File Offset: 0x0022E7F9
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F5 RID: 22773 RVA: 0x0023061E File Offset: 0x0022E81E
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3000)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F6 RID: 22774 RVA: 0x00230643 File Offset: 0x0022E843
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3002\u3002\u30000\u3000)
				If A_0 IsNot Me.o_O_.oOo. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3002\u3002\u30000\u3000)(Me.o_O_.oOo.)
				End If
			End Sub

			' Token: 0x060058F7 RID: 22775 RVA: 0x00230668 File Offset: 0x0022E868
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3000\u3002\u3002\u30020\u3002)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3000\u3002\u3002\u30020\u3002)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058F8 RID: 22776 RVA: 0x0023068D File Offset: 0x0022E88D
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3002)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3002)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058F9 RID: 22777 RVA: 0x002306B2 File Offset: 0x0022E8B2
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3002\u3000\u3002\u3000\u3002)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3002\u3000\u3002\u3000\u3002)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058FA RID: 22778 RVA: 0x002306D7 File Offset: 0x0022E8D7
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058FB RID: 22779 RVA: 0x002306FC File Offset: 0x0022E8FC
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058FC RID: 22780 RVA: 0x00230721 File Offset: 0x0022E921
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058FD RID: 22781 RVA: 0x00230746 File Offset: 0x0022E946
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3002\u3002\u3002\u3002)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3002\u3002\u3002\u3002)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058FE RID: 22782 RVA: 0x0023076B File Offset: 0x0022E96B
			Public Sub <<EMPTY_NAME>>(A_0 As o_\u3000\u3000\u3000)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o_\u3000\u3000\u3000)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x060058FF RID: 22783 RVA: 0x00230790 File Offset: 0x0022E990
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x06005900 RID: 22784 RVA: 0x002307B5 File Offset: 0x0022E9B5
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000)
				If A_0 IsNot Me.O000O_.0oO0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000)(Me.O000O_.0oO0.)
				End If
			End Sub

			' Token: 0x06005901 RID: 22785 RVA: 0x002307DA File Offset: 0x0022E9DA
			Public Sub <<EMPTY_NAME>>(A_0 As o\u30020\u3002\u3000\u3002\u3000)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u30020\u3002\u3000\u3002\u3000)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005902 RID: 22786 RVA: 0x002307FF File Offset: 0x0022E9FF
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005903 RID: 22787 RVA: 0x00230824 File Offset: 0x0022EA24
			Public Sub <<EMPTY_NAME>>(A_0 As o0\u3002)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o0\u3002)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005904 RID: 22788 RVA: 0x00230849 File Offset: 0x0022EA49
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005905 RID: 22789 RVA: 0x0023086E File Offset: 0x0022EA6E
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005906 RID: 22790 RVA: 0x00230893 File Offset: 0x0022EA93
			Public Sub <<EMPTY_NAME>>(A_0 As o\u30000\u3002\u3000\u3000\u3000)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u30000\u3002\u3000\u3000\u3000)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005907 RID: 22791 RVA: 0x002308B8 File Offset: 0x0022EAB8
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3000\u3002\u3000\u3000)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3000\u3002\u3000\u3000)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005908 RID: 22792 RVA: 0x002308DD File Offset: 0x0022EADD
			Public Sub <<EMPTY_NAME>>(A_0 As o\u30000\u3000\u3000\u3002O)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u30000\u3000\u3000\u3002O)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x06005909 RID: 22793 RVA: 0x00230902 File Offset: 0x0022EB02
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x0600590A RID: 22794 RVA: 0x00230927 File Offset: 0x0022EB27
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002)
				If A_0 IsNot Me.O_0O_O.oOOo0. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002)(Me.O_0O_O.oOOo0.)
				End If
			End Sub

			' Token: 0x0600590B RID: 22795 RVA: 0x0023094C File Offset: 0x0022EB4C
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x0600590C RID: 22796 RVA: 0x00230971 File Offset: 0x0022EB71
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3000)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3000)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x0600590D RID: 22797 RVA: 0x00230996 File Offset: 0x0022EB96
			Public Sub <<EMPTY_NAME>>(A_0 As O_\u3000)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O_\u3000)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x0600590E RID: 22798 RVA: 0x002309BB File Offset: 0x0022EBBB
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x0600590F RID: 22799 RVA: 0x002309E0 File Offset: 0x0022EBE0
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x06005910 RID: 22800 RVA: 0x00230A05 File Offset: 0x0022EC05
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x06005911 RID: 22801 RVA: 0x00230A2A File Offset: 0x0022EC2A
			Public Sub <<EMPTY_NAME>>(A_0 As o0\u3000\u3000\u3000\u3000\u3002\u3002)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o0\u3000\u3000\u3000\u3000\u3002\u3002)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x06005912 RID: 22802 RVA: 0x00230A4F File Offset: 0x0022EC4F
			Public Sub <<EMPTY_NAME>>(A_0 As o\u3002\u3000\u3002_)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3002\u3000\u3002_)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x06005913 RID: 22803 RVA: 0x00230A74 File Offset: 0x0022EC74
			Public Sub <<EMPTY_NAME>>(A_0 As Oo\u3000\u3000\u3002\u3000\u3002\u3002)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of Oo\u3000\u3000\u3002\u3000\u3002\u3002)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x06005914 RID: 22804 RVA: 0x00230A99 File Offset: 0x0022EC99
			Public Sub <<EMPTY_NAME>>(A_0 As gg)
				If A_0 IsNot Me.O.OOo_OOo__. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of gg)(Me.O.OOo_OOo__.)
				End If
			End Sub

			' Token: 0x06005915 RID: 22805 RVA: 0x00230ABE File Offset: 0x0022ECBE
			Public Sub <<EMPTY_NAME>>(A_0 As O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000)
				If A_0 IsNot Me.oo_.O0O00. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000)(Me.oo_.O0O00.)
				End If
			End Sub

			' Token: 0x06005916 RID: 22806 RVA: 0x00230AE3 File Offset: 0x0022ECE3
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000\u3002\u3002O)
				If A_0 IsNot Me.oo_.O0O00. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000\u3000\u3002\u3002O)(Me.oo_.O0O00.)
				End If
			End Sub

			' Token: 0x06005917 RID: 22807 RVA: 0x00230B08 File Offset: 0x0022ED08
			Public Overloads Sub <<EMPTY_NAME>>(A_0 As o\u3000_\u3000\u3002_\u3002\u3000)
				If A_0 IsNot Me.oo_.O0O00. Then
					If A_0 IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.OO__00ooO.0O00.(Of o\u3000_\u3000\u3002_\u3002\u3000)(Me.oo_.O0O00.)
				End If
			End Sub

			' Token: 0x0400225E RID: 8798
			<ThreadStatic()>
			Private Shared <<EMPTY_NAME>> As Hashtable

			' Token: 0x0400225F RID: 8799
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As oOo_O_0O

			' Token: 0x04002260 RID: 8800
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O0oO_0

			' Token: 0x04002261 RID: 8801
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As oOo0o0__0

			' Token: 0x04002262 RID: 8802
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As oo0O0oO_OOOo

			' Token: 0x04002263 RID: 8803
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As g1

			' Token: 0x04002264 RID: 8804
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002

			' Token: 0x04002265 RID: 8805
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002

			' Token: 0x04002266 RID: 8806
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002

			' Token: 0x04002267 RID: 8807
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000

			' Token: 0x04002268 RID: 8808
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002

			' Token: 0x04002269 RID: 8809
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public a As O\u3000\u3002\u3000\u3000

			' Token: 0x0400226A RID: 8810
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002o

			' Token: 0x0400226B RID: 8811
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000

			' Token: 0x0400226C RID: 8812
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3000\u3000

			' Token: 0x0400226D RID: 8813
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3002\u3002_o\u3000

			' Token: 0x0400226E RID: 8814
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002

			' Token: 0x0400226F RID: 8815
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3002

			' Token: 0x04002270 RID: 8816
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3000\u3002\u3000\u3000

			' Token: 0x04002271 RID: 8817
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3002\u3002\u3000

			' Token: 0x04002272 RID: 8818
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000

			' Token: 0x04002273 RID: 8819
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002

			' Token: 0x04002274 RID: 8820
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020

			' Token: 0x04002275 RID: 8821
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002

			' Token: 0x04002276 RID: 8822
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002o_\u3002\u3002\u3002\u3000\u3002o

			' Token: 0x04002277 RID: 8823
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000

			' Token: 0x04002278 RID: 8824
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000

			' Token: 0x04002279 RID: 8825
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As oO0\u3002

			' Token: 0x0400227A RID: 8826
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o0o\u3002

			' Token: 0x0400227B RID: 8827
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002

			' Token: 0x0400227C RID: 8828
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u30000

			' Token: 0x0400227D RID: 8829
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3002\u3000

			' Token: 0x0400227E RID: 8830
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3000\u3000

			' Token: 0x0400227F RID: 8831
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As oo\u3000\u3000\u3000\u3002

			' Token: 0x04002280 RID: 8832
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As h0

			' Token: 0x04002281 RID: 8833
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3000\u3000\u3002

			' Token: 0x04002282 RID: 8834
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u30000\u3002

			' Token: 0x04002283 RID: 8835
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000

			' Token: 0x04002284 RID: 8836
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As ev

			' Token: 0x04002285 RID: 8837
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As di

			' Token: 0x04002286 RID: 8838
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u30000\u3002\u3002O

			' Token: 0x04002287 RID: 8839
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As jk

			' Token: 0x04002288 RID: 8840
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public a As o\u3000\u3002

			' Token: 0x04002289 RID: 8841
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002

			' Token: 0x0400228A RID: 8842
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002

			' Token: 0x0400228B RID: 8843
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002

			' Token: 0x0400228C RID: 8844
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002

			' Token: 0x0400228D RID: 8845
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3000

			' Token: 0x0400228E RID: 8846
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3002\u3002\u30000\u3000

			' Token: 0x0400228F RID: 8847
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3000\u3002\u3002\u30020\u3002

			' Token: 0x04002290 RID: 8848
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3002

			' Token: 0x04002291 RID: 8849
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3002\u3000\u3002\u3000\u3002

			' Token: 0x04002292 RID: 8850
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000

			' Token: 0x04002293 RID: 8851
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002

			' Token: 0x04002294 RID: 8852
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000

			' Token: 0x04002295 RID: 8853
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3002\u3002\u3002\u3002

			' Token: 0x04002296 RID: 8854
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o_\u3000\u3000\u3000

			' Token: 0x04002297 RID: 8855
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000

			' Token: 0x04002298 RID: 8856
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000

			' Token: 0x04002299 RID: 8857
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u30020\u3002\u3000\u3002\u3000

			' Token: 0x0400229A RID: 8858
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000

			' Token: 0x0400229B RID: 8859
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o0\u3002

			' Token: 0x0400229C RID: 8860
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002

			' Token: 0x0400229D RID: 8861
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002

			' Token: 0x0400229E RID: 8862
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u30000\u3002\u3000\u3000\u3000

			' Token: 0x0400229F RID: 8863
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3000\u3002\u3000\u3000

			' Token: 0x040022A0 RID: 8864
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u30000\u3000\u3000\u3002O

			' Token: 0x040022A1 RID: 8865
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000

			' Token: 0x040022A2 RID: 8866
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002

			' Token: 0x040022A3 RID: 8867
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002

			' Token: 0x040022A4 RID: 8868
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3000

			' Token: 0x040022A5 RID: 8869
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O_\u3000

			' Token: 0x040022A6 RID: 8870
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000

			' Token: 0x040022A7 RID: 8871
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002

			' Token: 0x040022A8 RID: 8872
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000

			' Token: 0x040022A9 RID: 8873
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o0\u3000\u3000\u3000\u3000\u3002\u3002

			' Token: 0x040022AA RID: 8874
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3002\u3000\u3002_

			' Token: 0x040022AB RID: 8875
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As Oo\u3000\u3000\u3002\u3000\u3002\u3002

			' Token: 0x040022AC RID: 8876
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As gg

			' Token: 0x040022AD RID: 8877
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000

			' Token: 0x040022AE RID: 8878
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000\u3000\u3002\u3002O

			' Token: 0x040022AF RID: 8879
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public <<EMPTY_NAME>> As o\u3000_\u3000\u3002_\u3002\u3000
		End Class

		' Token: 0x02000540 RID: 1344
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class c
			' Token: 0x06005918 RID: 22808 RVA: 0x00230B2D File Offset: 0x0022ED2D
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overloads Function <<EMPTY_NAME>>(A_0 As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(A_0))
			End Function

			' Token: 0x06005919 RID: 22809 RVA: 0x00230B3B File Offset: 0x0022ED3B
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overloads Function <<EMPTY_NAME>>() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600591A RID: 22810 RVA: 0x00230B43 File Offset: 0x0022ED43
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Overloads Function <<EMPTY_NAME>>() As Type
				Return GetType(Foxtable.My.c.c)
			End Function

			' Token: 0x0600591B RID: 22811 RVA: 0x00230B4F File Offset: 0x0022ED4F
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overloads Function <<EMPTY_NAME>>() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600591C RID: 22812 RVA: 0x00230B58 File Offset: 0x0022ED58
			<DebuggerHidden()>
			Private Shared Overloads Function <<EMPTY_NAME>>(Of a As New)(A_0 As a) As a
				Dim result As a
				If A_0 Is Nothing Then
					result = Activator.CreateInstance(Of a)()
				Else
					result = A_0
				End If
				Return result
			End Function

			' Token: 0x0600591D RID: 22813 RVA: 0x00230B78 File Offset: 0x0022ED78
			<DebuggerHidden()>
			Private Overloads Sub <<EMPTY_NAME>>(Of a)(ByRef A_0 As a)
				A_0 = Nothing
			End Sub

			' Token: 0x0600591E RID: 22814 RVA: 0x00230B81 File Offset: 0x0022ED81
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000541 RID: 1345
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class a(Of <<EMPTY_NAME>> As New)
			' Token: 0x0600591F RID: 22815 RVA: 0x00230B89 File Offset: 0x0022ED89
			<DebuggerHidden()>
			Friend Function <<EMPTY_NAME>>() As oo_.O0O00.
				If Foxtable.My.c(Of oo_.O0O00.).a.O._OO0_O. Is Nothing Then
					Foxtable.My.c(Of oo_.O0O00.).a.O._OO0_O. = Activator.CreateInstance(Of oo_.O0O00.)()
				End If
				Return Foxtable.My.c(Of oo_.O0O00.).a.O._OO0_O.
			End Function

			' Token: 0x06005920 RID: 22816 RVA: 0x00230BA6 File Offset: 0x0022EDA6
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x040022B0 RID: 8880
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared <<EMPTY_NAME>> As oo_.O0O00.
		End Class
	End Module
End Namespace
