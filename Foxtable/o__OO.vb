Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Gauge.Design

Namespace Foxtable
	' Token: 0x0200015B RID: 347
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o__OO
		Inherits GaugeCollectionEditor

		' Token: 0x06000FCC RID: 4044 RVA: 0x000694B2 File Offset: 0x000676B2
		Public Sub New(A_0 As Type)
			MyBase.New(A_0)
		End Sub

		' Token: 0x06000FCD RID: 4045 RVA: 0x000694BC File Offset: 0x000676BC
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
