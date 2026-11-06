Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000067 RID: 103
	<TypeConverter(GetType(OoO0o0oo__Oo))>
	Friend Class o_0oooo_OO
		Implements ICustomTypeDescriptor

		' Token: 0x0600037F RID: 895 RVA: 0x0000BA5C File Offset: 0x00009C5C
		Public Sub New(A_0 As Object, A_1 As String(), A_2 As Boolean, A_3 As Boolean)
			Dim a_ As Integer = 11
			MyBase..ctor()
			Me.o0oO__._Oo0O. = ""
			Me.o_0Oo_0.ooOo. = ""
			Me.oo_O_o.O. = ""
			Me.oO_____000O.oO. = ""
			Me.o0oO__._Oo0O. = New Object() { Me.oo_O_o.O., Me.oO_____000O.oO., Me.o0oO__._Oo0O. }
			Me.O_oO__0.o. = RuntimeHelpers.GetObjectValue(A_0)
			Me.O_oO__0.o. = A_1
			Me.o0oO__._Oo0O. = A_2
			Me.o_0Oo_0.ooOo. = A_3
			If o_0oooo_OO.O_oO__0.o. Is Nothing Then
				o_0oooo_OO.O_oO__0.o. = o0_.Oo_0.OOo0oO0.(O00.oO_.0o_oo_0O_.(SysInfo.SourceString10, O00OOOo_O0_O.b("ﺚ", a_), O00OOOo_O0_O.b("ﺚ", a_)), "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", False)
				o_0oooo_OO.O_oO__0.o. = o_0oooo_OO.O_oO__0.o..[GetType](O00OOOo_O0_O.b("처첢솤슦", a_)).GetMethod(O00OOOo_O0_O.b("�ﺚ쾞삠톢쒤풦", a_))
				Me.O_oO__0.o.()
			End If
		End Sub

		' Token: 0x06000380 RID: 896 RVA: 0x0000BB7E File Offset: 0x00009D7E
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.O_oO__0.o.
		End Function

		' Token: 0x06000381 RID: 897 RVA: 0x0000BB86 File Offset: 0x00009D86
		Public Function <<EMPTY_NAME>>() As AttributeCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetAttributes
			Return TypeDescriptor.GetAttributes(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), True)
		End Function

		' Token: 0x06000382 RID: 898 RVA: 0x0000BB99 File Offset: 0x00009D99
		Public Function <<EMPTY_NAME>>() As String Implements System.ComponentModel.ICustomTypeDescriptor.GetClassName
			Return TypeDescriptor.GetClassName(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), True)
		End Function

		' Token: 0x06000383 RID: 899 RVA: 0x0000BBAC File Offset: 0x00009DAC
		Public Function <<EMPTY_NAME>>() As String Implements System.ComponentModel.ICustomTypeDescriptor.GetComponentName
			Return TypeDescriptor.GetComponentName(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), True)
		End Function

		' Token: 0x06000384 RID: 900 RVA: 0x0000BBBF File Offset: 0x00009DBF
		Public Function <<EMPTY_NAME>>() As TypeConverter Implements System.ComponentModel.ICustomTypeDescriptor.GetConverter
			Return TypeDescriptor.GetConverter(Me, True)
		End Function

		' Token: 0x06000385 RID: 901 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		Public Function <<EMPTY_NAME>>() As EventDescriptor Implements System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent
			Return TypeDescriptor.GetDefaultEvent(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), True)
		End Function

		' Token: 0x06000386 RID: 902 RVA: 0x0000BBDB File Offset: 0x00009DDB
		Public Function <<EMPTY_NAME>>() As PropertyDescriptor Implements System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty
			Return TypeDescriptor.GetDefaultProperty(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), True)
		End Function

		' Token: 0x06000387 RID: 903 RVA: 0x0000BBEE File Offset: 0x00009DEE
		Public Function <<EMPTY_NAME>>(A_0 As Type) As Object Implements System.ComponentModel.ICustomTypeDescriptor.GetEditor
			Return TypeDescriptor.GetEditor(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), A_0, True)
		End Function

		' Token: 0x06000388 RID: 904 RVA: 0x0000BC02 File Offset: 0x00009E02
		Public Function <<EMPTY_NAME>>() As EventDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetEvents
			Return TypeDescriptor.GetEvents(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), True)
		End Function

		' Token: 0x06000389 RID: 905 RVA: 0x0000BC15 File Offset: 0x00009E15
		Public Function <<EMPTY_NAME>>(A_0 As Attribute()) As EventDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetEvents
			Return TypeDescriptor.GetEvents(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), A_0, True)
		End Function

		' Token: 0x0600038A RID: 906 RVA: 0x0000BC29 File Offset: 0x00009E29
		Public Function <<EMPTY_NAME>>() As PropertyDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetProperties
			Return Me.OO00o0.o0___.(Nothing)
		End Function

		' Token: 0x0600038B RID: 907 RVA: 0x0000BC34 File Offset: 0x00009E34
		Public Function <<EMPTY_NAME>>(A_0 As Attribute()) As PropertyDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetProperties
			If Me.O_oO__0.o. Is Nothing Then
				Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), A_0, True)
				Me.O_oO__0.o. = New PropertyDescriptorCollection(Nothing)
				Try
					For Each obj As Object In properties
						Dim propertyDescriptor As PropertyDescriptor = CType(obj, PropertyDescriptor)
						If ooO.OO_oOO0O.O00.(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), propertyDescriptor) AndAlso Not(O00OOOo_O0_O.Oo_o_o.__oo.(propertyDescriptor) Xor Me.o_0Oo_0.ooOo.) AndAlso Me.O_oO__0.o.(propertyDescriptor) Then
							Me.O_oO__0.o..Add(propertyDescriptor)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Return Me.O_oO__0.o.
		End Function

		' Token: 0x0600038C RID: 908 RVA: 0x0000BCEC File Offset: 0x00009EEC
		Public Function <<EMPTY_NAME>>(A_0 As PropertyDescriptor) As Object Implements System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner
			Return Me.O_oO__0.o.
		End Function

		' Token: 0x0600038D RID: 909 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		Private Function <<EMPTY_NAME>>(A_0 As PropertyDescriptor) As Boolean
			Dim result As Boolean
			If Me.O_oO__0.o..Length < 1 Then
				result = True
			Else
				Dim attribute As Attribute = A_0.Attributes(GetType(CategoryAttribute))
				If attribute Is Nothing Then
					If Not Me.o0oO__._Oo0O. Then
						result = True
					End If
				ElseIf Me.o0oO__._Oo0O. AndAlso Array.IndexOf(Of String)(Me.O_oO__0.o., CType(attribute, CategoryAttribute).Category) >= 0 Then
					result = True
				ElseIf Not Me.o0oO__._Oo0O. AndAlso Array.IndexOf(Of String)(Me.O_oO__0.o., CType(attribute, CategoryAttribute).Category) < 0 Then
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x0600038E RID: 910 RVA: 0x0000BD80 File Offset: 0x00009F80
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim propertyDescriptorCollection As PropertyDescriptorCollection = Nothing
				IL_0C:
				num2 = 3
				Dim attributes As Attribute() = New Attribute(-1) {}
				IL_16:
				num2 = 4
				If propertyDescriptorCollection IsNot Nothing Then
					GoTo IL_119
				End If
				IL_1F:
				num2 = 5
				Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), attributes, True)
				IL_36:
				num2 = 6
				propertyDescriptorCollection = New PropertyDescriptorCollection(Nothing)
				IL_40:
				num2 = 7
				o_0oooo_OO.O_oO__0.o..Invoke(Nothing, Me.o0oO__._Oo0O.)
				IL_54:
				num2 = 8
				Me.oo_O_o.O. = Me.o0oO__._Oo0O.(0).ToString()
				IL_69:
				num2 = 9
				Me.oO_____000O.oO. = Me.o0oO__._Oo0O.(1).ToString()
				IL_7F:
				num2 = 10
				Me.o0oO__._Oo0O. = Me.o0oO__._Oo0O.(2).ToString()
				IL_95:
				num2 = 11
				Dim enumerator As IEnumerator = properties.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim propertyDescriptor As PropertyDescriptor = CType(obj, PropertyDescriptor)
					IL_B1:
					num2 = 12
					If ooO.OO_oOO0O.O00.(RuntimeHelpers.GetObjectValue(Me.O_oO__0.o.), propertyDescriptor) Then
						IL_C8:
						num2 = 14
						If Not(O00OOOo_O0_O.Oo_o_o.__oo.(propertyDescriptor) Xor Me.o_0Oo_0.ooOo.) Then
							IL_DB:
							num2 = 15
							If Me.O_oO__0.o.(propertyDescriptor) Then
								IL_E8:
								num2 = 16
								propertyDescriptorCollection.Add(propertyDescriptor)
							End If
						End If
					End If
					IL_F5:
					num2 = 17
				End While
				IL_101:
				num2 = 18
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_119:
				num2 = 19
				If Operators.CompareString(Me.o0oO__._Oo0O., "", True) <= 0 Then
					GoTo IL_150
				End If
				IL_130:
				num2 = 20
				Me.o0oO__._Oo0O. = O00.oO_.0o_oo_0O_.(Me.o0oO__._Oo0O., Me.oo_O_o.O., Me.oO_____000O.oO.)
				IL_150:
				num2 = 21
				Me.o_0Oo_0.ooOo. = Me.oo_O_o.O. + Me.oO_____000O.oO.
				IL_16A:
				num2 = 22
				Me.o_0Oo_0.ooOo. = O00.MD5Encrypt(Me.o_0Oo_0.ooOo.).Substring(0, 16)
				IL_186:
				num2 = 23
				Dim list As List(Of String) = New List(Of String)()
				IL_190:
				num2 = 24
				list.Add("")
				IL_19F:
				num2 = 25
				Dim enumerator2 As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator2.MoveNext()
					Dim item As String = enumerator2.Current
					IL_1BE:
					num2 = 26
					list.Add(item)
					IL_1CA:
					num2 = 27
				End While
				IL_1D6:
				num2 = 28
				CType(enumerator2, IDisposable).Dispose()
				IL_1E6:
				num2 = 29
				Dim standardValuesCollection As TypeConverter.StandardValuesCollection = New TypeConverter.StandardValuesCollection(list)
				IL_1F2:
				num2 = 30
				result = (standardValuesCollection.Count > 0)
				IL_200:
				GoTo IL_2CE
				IL_205:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_28F:
				GoTo IL_2C3
				IL_291:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2A1:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_291
			End Try
			IL_2C3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2CE:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x040000AF RID: 175
		Private <<EMPTY_NAME>> As PropertyDescriptorCollection

		' Token: 0x040000B0 RID: 176
		Private <<EMPTY_NAME>> As Object

		' Token: 0x040000B1 RID: 177
		Private <<EMPTY_NAME>> As String()

		' Token: 0x040000B2 RID: 178
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000B3 RID: 179
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000B4 RID: 180
		Private Shared <<EMPTY_NAME>> As Assembly

		' Token: 0x040000B5 RID: 181
		Private Shared <<EMPTY_NAME>> As MethodInfo

		' Token: 0x040000B6 RID: 182
		Private Shared <<EMPTY_NAME>> As Boolean

		' Token: 0x040000B7 RID: 183
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000B8 RID: 184
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000B9 RID: 185
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000BA RID: 186
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000BB RID: 187
		Private <<EMPTY_NAME>> As Object()
	End Class
End Namespace
