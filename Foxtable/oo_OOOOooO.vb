Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Gauge.Design

Namespace Foxtable
	' Token: 0x0200016C RID: 364
	Public Class oo_OOOOooO
		Inherits ShapeCollectionEditor

		' Token: 0x06001108 RID: 4360 RVA: 0x0006ACB9 File Offset: 0x00068EB9
		Public Sub New(A_0 As Type)
			MyBase.New(A_0)
		End Sub

		' Token: 0x06001109 RID: 4361 RVA: 0x0006ACC4 File Offset: 0x00068EC4
		Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
			Try
				For Each obj As Object In Application.OpenForms
					Dim form As Form = CType(obj, Form)
					If TypeOf form Is o\u3000\u3002 Then
						CType(form, o\u3000\u3002).OO_._oOo. = True
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return MyBase.EditValue(context, provider, RuntimeHelpers.GetObjectValue(value))
		End Function
	End Class
End Namespace
