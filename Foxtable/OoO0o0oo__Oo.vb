Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x02000046 RID: 70
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OoO0o0oo__Oo
		Inherits ExpandableObjectConverter

		' Token: 0x060002A9 RID: 681 RVA: 0x00005CE1 File Offset: 0x00003EE1
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002AA RID: 682 RVA: 0x00005CE4 File Offset: 0x00003EE4
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As Object, A_2 As Attribute()) As PropertyDescriptorCollection
			Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(A_1), A_2)
			Dim arrayList As ArrayList = New ArrayList()
			Dim arrayList2 As ArrayList = New ArrayList()
			Try
				For Each obj As Object In properties
					Dim propertyDescriptor As PropertyDescriptor = CType(obj, PropertyDescriptor)
					Dim attribute As Attribute = propertyDescriptor.Attributes(GetType(O_Oo00Oo000O0))
					If attribute IsNot Nothing Then
						Dim o_Oo00Oo000O As O_Oo00Oo000O0 = CType(attribute, O_Oo00Oo000O0)
						arrayList.Add(New O0o_00oO__0_(propertyDescriptor.Name, o_Oo00Oo000O.o0oO__._Oo0O.()))
					Else
						arrayList.Add(New O0o_00oO__0_(propertyDescriptor.Name, 0.0))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			arrayList.Sort()
			Try
				For Each obj2 As Object In arrayList
					Dim o0o_00oO__0_ As O0o_00oO__0_ = CType(obj2, O0o_00oO__0_)
					arrayList2.Add(o0o_00oO__0_.Name)
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			Return properties.Sort(CType(arrayList2.ToArray(GetType(String)), String()))
		End Function
	End Class
End Namespace
