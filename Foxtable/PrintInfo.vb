Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000454 RID: 1108
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class PrintInfo
		' Token: 0x060049EF RID: 18927 RVA: 0x001F4BDC File Offset: 0x001F2DDC
		Public Sub New(A_0 As Table)
			Me.oO._0Oo_0000o0. = "[TableCaption]"
			Me.oO_.O0o. = "||第[PageNo]页，共[PageCount]页"
			Me.o00.o0. = False
			Me.oOoo.OOo_. = False
			Me.o00.o0. = New Font("宋体", 9F)
			Me.oOoo.OOo_. = New Font("宋体", 9F)
			Me.o_0OO0.O__O00o. = New Font("宋体", 16F, FontStyle.Bold)
			Me.o_o0oO.__0. = New Font("宋体", 12F)
			Me.oO__0_.O0_0O. = 3
			Me.oO._0Oo_0000o0. = 3
			Me.o_.__o0_O. = 3
			Me.ooo_oo0.Ooo0o0. = 3
			Me.O_O.O_00. = True
			Me.oO_.O0o. = 1
			Me.ooo_oo0.Ooo0o0. = True
			Me.o.ooo0_o_0O. = True
			Me.o0.0_o_O. = True
			Me.oo0o.OoO_0_Oo. = True
			Me.O._o0o. = False
			Me.O0.__o_O000O. = True
			Me.OOo._o0O__00_O. = True
			Me.O_oO.O. = True
			Me.O_oO0_O.0. = False
			Me.ooo0o_.__O. = True
			Me.oo_0O.__0o0O. = True
			Me.oOOo_o0oo.00. = True
			Me.OOo__._00oo. = True
			Me.oOo.oo. = True
			Me.oOo0_.OooOOo. = True
			Me.oO.OoO_. = True
			Me.OO_O_o0_O.o. = New Font("宋体", 9F)
			Me.oo_._O0_oOooO. = A_0
		End Sub

		' Token: 0x1700104E RID: 4174
		' (get) Token: 0x060049F0 RID: 18928 RVA: 0x001F4D1E File Offset: 0x001F2F1E
		Friend ReadOnly Property Table As Table
			Get
				Return Me.oo_._O0_oOooO.
			End Get
		End Property

		' Token: 0x1700104F RID: 4175
		' (get) Token: 0x060049F1 RID: 18929 RVA: 0x001F4D28 File Offset: 0x001F2F28
		' (set) Token: 0x060049F2 RID: 18930 RVA: 0x001F4D54 File Offset: 0x001F2F54
		Public Property PrinterName As String
			Get
				Dim result As String
				If Me.PrinterSettings.IsDefaultPrinter Then
					result = Nothing
				Else
					result = Me.PrinterSettings.PrinterName
				End If
				Return result
			End Get
			Set(value As String)
				Try
					Try
						Dim enumerator As IEnumerator = PrinterSettings.InstalledPrinters.GetEnumerator()
						While enumerator.MoveNext()
							If Operators.CompareString(Conversions.ToString(enumerator.Current), value, True) = 0 Then
								Me.PrinterSettings.PrinterName = value
							End If
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
			End Set
		End Property

		' Token: 0x17001050 RID: 4176
		' (get) Token: 0x060049F3 RID: 18931 RVA: 0x001F4DD8 File Offset: 0x001F2FD8
		Friend ReadOnly Property PrinterSettings As PrinterSettings
			Get
				Return Me.oo_._O0_oOooO..foxGrid.PrintParameters.PrintDocument.PrinterSettings
			End Get
		End Property

		' Token: 0x17001051 RID: 4177
		' (get) Token: 0x060049F4 RID: 18932 RVA: 0x001F4DF4 File Offset: 0x001F2FF4
		Friend ReadOnly Property PageSettings As PageSettings
			Get
				Return Me.oo_._O0_oOooO..foxGrid.PrintParameters.PrintDocument.DefaultPageSettings
			End Get
		End Property

		' Token: 0x17001052 RID: 4178
		' (get) Token: 0x060049F5 RID: 18933 RVA: 0x001F4E10 File Offset: 0x001F3010
		' (set) Token: 0x060049F6 RID: 18934 RVA: 0x001F4E60 File Offset: 0x001F3060
		Friend Property PaperSize As PaperSize
			Get
				Dim result As PaperSize
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						result = New PaperSize()
					Else
						result = Me.PageSettings.PaperSize
					End If
				Catch ex As Exception
					result = Nothing
				End Try
				Return result
			End Get
			Set(value As PaperSize)
				Me.PageSettings.PaperSize = value
			End Set
		End Property

		' Token: 0x17001053 RID: 4179
		' (get) Token: 0x060049F7 RID: 18935 RVA: 0x001F4E70 File Offset: 0x001F3070
		' (set) Token: 0x060049F8 RID: 18936 RVA: 0x001F4EA8 File Offset: 0x001F30A8
		Public Property PaperSource As String
			Get
				Dim result As String
				If Me.PageSettings.PaperSource.Kind = PaperSourceKind.FormSource Then
					result = Nothing
				Else
					result = Me.PageSettings.PaperSource.SourceName
				End If
				Return result
			End Get
			Set(value As String)
				Try
					Try
						For Each obj As Object In Me.PrinterSettings.PaperSources
							Dim paperSource As PaperSource = CType(obj, PaperSource)
							If Operators.CompareString(paperSource.SourceName, value, True) = 0 Then
								Me.PageSettings.PaperSource = paperSource
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Catch ex As Exception
				End Try
			End Set
		End Property

		' Token: 0x17001054 RID: 4180
		' (get) Token: 0x060049F9 RID: 18937 RVA: 0x001F4F3C File Offset: 0x001F313C
		' (set) Token: 0x060049FA RID: 18938 RVA: 0x001F4F8C File Offset: 0x001F318C
		<DefaultValue(9)>
		Public Property PaperRawKind As Integer
			Get
				Dim result As Integer
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						result = 9
					Else
						result = Me.PaperSize.RawKind
					End If
				Catch ex As Exception
					result = 0
				End Try
				Return result
			End Get
			Set(value As Integer)
				Try
					If PrinterSettings.InstalledPrinters.Count <> 0 Then
						Me.PaperSize.RawKind = value
					End If
				Catch ex As Exception
				End Try
			End Set
		End Property

		' Token: 0x17001055 RID: 4181
		' (get) Token: 0x060049FB RID: 18939 RVA: 0x001F4FD4 File Offset: 0x001F31D4
		' (set) Token: 0x060049FC RID: 18940 RVA: 0x001F4FDC File Offset: 0x001F31DC
		<OooO0(True)>
		Public Property PaperKind As Integer
			Get
				Return Me.PaperRawKind
			End Get
			Set(value As Integer)
				Me.PaperRawKind = value
			End Set
		End Property

		' Token: 0x17001056 RID: 4182
		' (get) Token: 0x060049FD RID: 18941 RVA: 0x001F4FE8 File Offset: 0x001F31E8
		' (set) Token: 0x060049FE RID: 18942 RVA: 0x001F501B File Offset: 0x001F321B
		Public Property PaperWidth As Double
			Get
				Dim result As Double
				If Me.PaperSize IsNot Nothing Then
					result = Math.Round(CDbl(Me.PaperSize.Width) * 0.254, 1)
				End If
				Return result
			End Get
			Set(value As Double)
				If Me.PaperSize IsNot Nothing AndAlso Me.PaperRawKind = 0 Then
					Me.PaperSize.Width = Convert.ToInt32(value / 0.254)
				End If
			End Set
		End Property

		' Token: 0x17001057 RID: 4183
		' (get) Token: 0x060049FF RID: 18943 RVA: 0x001F5048 File Offset: 0x001F3248
		' (set) Token: 0x06004A00 RID: 18944 RVA: 0x001F507B File Offset: 0x001F327B
		Public Property PaperHeight As Double
			Get
				Dim result As Double
				If Me.PaperSize IsNot Nothing Then
					result = Math.Round(CDbl(Me.PaperSize.Height) * 0.254, 1)
				End If
				Return result
			End Get
			Set(value As Double)
				If Me.PaperSize IsNot Nothing AndAlso Me.PaperRawKind = 0 Then
					Me.PaperSize.Height = Convert.ToInt32(value / 0.254)
				End If
			End Set
		End Property

		' Token: 0x17001058 RID: 4184
		' (get) Token: 0x06004A01 RID: 18945 RVA: 0x001F50A8 File Offset: 0x001F32A8
		' (set) Token: 0x06004A02 RID: 18946 RVA: 0x001F50CB File Offset: 0x001F32CB
		<DefaultValue(25.4)>
		Public Property LeftMargin As Double
			Get
				Return Math.Round(CDbl(Me.PageSettings.Margins.Left) * 0.254, 1)
			End Get
			Set(value As Double)
				Me.PageSettings.Margins.Left = Convert.ToInt32(value / 0.254)
			End Set
		End Property

		' Token: 0x17001059 RID: 4185
		' (get) Token: 0x06004A03 RID: 18947 RVA: 0x001F50ED File Offset: 0x001F32ED
		' (set) Token: 0x06004A04 RID: 18948 RVA: 0x001F5110 File Offset: 0x001F3310
		<DefaultValue(25.4)>
		Public Property TopMargin As Double
			Get
				Return Math.Round(CDbl(Me.PageSettings.Margins.Top) * 0.254, 1)
			End Get
			Set(value As Double)
				Me.PageSettings.Margins.Top = Convert.ToInt32(value / 0.254)
			End Set
		End Property

		' Token: 0x1700105A RID: 4186
		' (get) Token: 0x06004A05 RID: 18949 RVA: 0x001F5132 File Offset: 0x001F3332
		' (set) Token: 0x06004A06 RID: 18950 RVA: 0x001F5155 File Offset: 0x001F3355
		<DefaultValue(25.4)>
		Public Property RightMargin As Double
			Get
				Return Math.Round(CDbl(Me.PageSettings.Margins.Right) * 0.254, 1)
			End Get
			Set(value As Double)
				Me.PageSettings.Margins.Right = Convert.ToInt32(value / 0.254)
			End Set
		End Property

		' Token: 0x1700105B RID: 4187
		' (get) Token: 0x06004A07 RID: 18951 RVA: 0x001F5177 File Offset: 0x001F3377
		' (set) Token: 0x06004A08 RID: 18952 RVA: 0x001F519A File Offset: 0x001F339A
		<DefaultValue(25.4)>
		Public Property BottomMargin As Double
			Get
				Return Math.Round(CDbl(Me.PageSettings.Margins.Bottom) * 0.254, 1)
			End Get
			Set(value As Double)
				Me.PageSettings.Margins.Bottom = Convert.ToInt32(value / 0.254)
			End Set
		End Property

		' Token: 0x1700105C RID: 4188
		' (get) Token: 0x06004A09 RID: 18953 RVA: 0x001F51BC File Offset: 0x001F33BC
		' (set) Token: 0x06004A0A RID: 18954 RVA: 0x001F51C9 File Offset: 0x001F33C9
		<DefaultValue(False)>
		Public Property LandScape As Boolean
			Get
				Return Me.PageSettings.Landscape
			End Get
			Set(value As Boolean)
				Me.PageSettings.Landscape = value
			End Set
		End Property

		' Token: 0x1700105D RID: 4189
		' (get) Token: 0x06004A0B RID: 18955 RVA: 0x001F51D7 File Offset: 0x001F33D7
		' (set) Token: 0x06004A0C RID: 18956 RVA: 0x001F51DF File Offset: 0x001F33DF
		<DefaultValue("[TableCaption]")>
		Public Property Title As String
			Get
				Return Me.oO._0Oo_0000o0.
			End Get
			Set(value As String)
				Me.oO._0Oo_0000o0. = value
			End Set
		End Property

		' Token: 0x1700105E RID: 4190
		' (get) Token: 0x06004A0D RID: 18957 RVA: 0x001F51E8 File Offset: 0x001F33E8
		' (set) Token: 0x06004A0E RID: 18958 RVA: 0x001F51F0 File Offset: 0x001F33F0
		<DefaultValue("")>
		Public Property SubTitle As String
			Get
				Return Me.o_0OO0.O__O00o.
			End Get
			Set(value As String)
				Me.o_0OO0.O__O00o. = value
			End Set
		End Property

		' Token: 0x1700105F RID: 4191
		' (get) Token: 0x06004A0F RID: 18959 RVA: 0x001F51F9 File Offset: 0x001F33F9
		' (set) Token: 0x06004A10 RID: 18960 RVA: 0x001F5201 File Offset: 0x001F3401
		<DefaultValue("")>
		Public Property PageHeader As String
			Get
				Return Me.o0O_0o.0O.
			End Get
			Set(value As String)
				Me.o0O_0o.0O. = value
			End Set
		End Property

		' Token: 0x17001060 RID: 4192
		' (get) Token: 0x06004A11 RID: 18961 RVA: 0x001F520C File Offset: 0x001F340C
		' (set) Token: 0x06004A12 RID: 18962 RVA: 0x001F5230 File Offset: 0x001F3430
		<DefaultValue("||第[PageNo]页，共[PageCount]页")>
		Public Property PageFooter As String
			Get
				Dim result As String
				If O_O0OO.O00.00OO000___.() Then
					result = "||www.foxtable.com"
				Else
					result = Me.oO_.O0o.
				End If
				Return result
			End Get
			Set(value As String)
				Me.oO_.O0o. = value
			End Set
		End Property

		' Token: 0x17001061 RID: 4193
		' (get) Token: 0x06004A13 RID: 18963 RVA: 0x001F5239 File Offset: 0x001F3439
		' (set) Token: 0x06004A14 RID: 18964 RVA: 0x001F5241 File Offset: 0x001F3441
		<DefaultValue(False)>
		Public Property PageHeaderLine As Boolean
			Get
				Return Me.o00.o0.
			End Get
			Set(value As Boolean)
				Me.o00.o0. = value
			End Set
		End Property

		' Token: 0x17001062 RID: 4194
		' (get) Token: 0x06004A15 RID: 18965 RVA: 0x001F524A File Offset: 0x001F344A
		' (set) Token: 0x06004A16 RID: 18966 RVA: 0x001F5252 File Offset: 0x001F3452
		<DefaultValue(False)>
		Public Property PageFooterLine As Boolean
			Get
				Return Me.oOoo.OOo_.
			End Get
			Set(value As Boolean)
				Me.oOoo.OOo_. = value
			End Set
		End Property

		' Token: 0x17001063 RID: 4195
		' (get) Token: 0x06004A17 RID: 18967 RVA: 0x001F525B File Offset: 0x001F345B
		' (set) Token: 0x06004A18 RID: 18968 RVA: 0x001F5263 File Offset: 0x001F3463
		<DefaultValue(3)>
		Public Property SpaceAfterPagerHeader As Integer
			Get
				Return Me.oO__0_.O0_0O.
			End Get
			Set(value As Integer)
				Me.oO__0_.O0_0O. = value
			End Set
		End Property

		' Token: 0x17001064 RID: 4196
		' (get) Token: 0x06004A19 RID: 18969 RVA: 0x001F526C File Offset: 0x001F346C
		' (set) Token: 0x06004A1A RID: 18970 RVA: 0x001F5274 File Offset: 0x001F3474
		<DefaultValue(3)>
		Public Property SpaceBeforePagerFooter As Integer
			Get
				Return Me.oO._0Oo_0000o0.
			End Get
			Set(value As Integer)
				Me.oO._0Oo_0000o0. = value
			End Set
		End Property

		' Token: 0x17001065 RID: 4197
		' (get) Token: 0x06004A1B RID: 18971 RVA: 0x001F527D File Offset: 0x001F347D
		' (set) Token: 0x06004A1C RID: 18972 RVA: 0x001F5285 File Offset: 0x001F3485
		<DefaultValue(3)>
		Public Property SpaceAfterTitle As Integer
			Get
				Return Me.o_.__o0_O.
			End Get
			Set(value As Integer)
				Me.o_.__o0_O. = value
			End Set
		End Property

		' Token: 0x17001066 RID: 4198
		' (get) Token: 0x06004A1D RID: 18973 RVA: 0x001F528E File Offset: 0x001F348E
		' (set) Token: 0x06004A1E RID: 18974 RVA: 0x001F5296 File Offset: 0x001F3496
		<DefaultValue(3)>
		Public Property SpaceAfterSubtitle As Integer
			Get
				Return Me.ooo_oo0.Ooo0o0.
			End Get
			Set(value As Integer)
				Me.ooo_oo0.Ooo0o0. = value
			End Set
		End Property

		' Token: 0x17001067 RID: 4199
		' (get) Token: 0x06004A1F RID: 18975 RVA: 0x001F529F File Offset: 0x001F349F
		' (set) Token: 0x06004A20 RID: 18976 RVA: 0x001F52A7 File Offset: 0x001F34A7
		<DefaultValue("宋体,9")>
		Public Property PageHeaderFont As Font
			Get
				Return Me.o00.o0.
			End Get
			Set(value As Font)
				Me.o00.o0. = value
			End Set
		End Property

		' Token: 0x17001068 RID: 4200
		' (get) Token: 0x06004A21 RID: 18977 RVA: 0x001F52B0 File Offset: 0x001F34B0
		' (set) Token: 0x06004A22 RID: 18978 RVA: 0x001F52B8 File Offset: 0x001F34B8
		<DefaultValue("宋体,9")>
		Public Property PageFooterFont As Font
			Get
				Return Me.oOoo.OOo_.
			End Get
			Set(value As Font)
				Me.oOoo.OOo_. = value
			End Set
		End Property

		' Token: 0x17001069 RID: 4201
		' (get) Token: 0x06004A23 RID: 18979 RVA: 0x001F52C1 File Offset: 0x001F34C1
		' (set) Token: 0x06004A24 RID: 18980 RVA: 0x001F52C9 File Offset: 0x001F34C9
		<DefaultValue("宋体,16,Bold")>
		Public Property TitleFont As Font
			Get
				Return Me.o_0OO0.O__O00o.
			End Get
			Set(value As Font)
				Me.o_0OO0.O__O00o. = value
			End Set
		End Property

		' Token: 0x1700106A RID: 4202
		' (get) Token: 0x06004A25 RID: 18981 RVA: 0x001F52D2 File Offset: 0x001F34D2
		' (set) Token: 0x06004A26 RID: 18982 RVA: 0x001F52DA File Offset: 0x001F34DA
		<DefaultValue("宋体,12")>
		Public Property SubtitleFont As Font
			Get
				Return Me.o_o0oO.__0.
			End Get
			Set(value As Font)
				Me.o_o0oO.__0. = value
			End Set
		End Property

		' Token: 0x1700106B RID: 4203
		' (get) Token: 0x06004A27 RID: 18983 RVA: 0x001F52E3 File Offset: 0x001F34E3
		' (set) Token: 0x06004A28 RID: 18984 RVA: 0x001F52EB File Offset: 0x001F34EB
		<DefaultValue(1)>
		Public Property PageColumns As Integer
			Get
				Return Me.oO_.O0o.
			End Get
			Set(value As Integer)
				Me.oO_.O0o. = value
			End Set
		End Property

		' Token: 0x1700106C RID: 4204
		' (get) Token: 0x06004A29 RID: 18985 RVA: 0x001F52F4 File Offset: 0x001F34F4
		' (set) Token: 0x06004A2A RID: 18986 RVA: 0x001F52FC File Offset: 0x001F34FC
		<DefaultValue("")>
		Public Property WaterMark As String
			Get
				Return Me.O__O.O0_O.
			End Get
			Set(value As String)
				Me.O__O.O0_O. = value
			End Set
		End Property

		' Token: 0x1700106D RID: 4205
		' (get) Token: 0x06004A2B RID: 18987 RVA: 0x001F5305 File Offset: 0x001F3505
		' (set) Token: 0x06004A2C RID: 18988 RVA: 0x001F530D File Offset: 0x001F350D
		<DefaultValue(True)>
		Public Property RepeatFixedRows As Boolean
			Get
				Return Me.o.ooo0_o_0O.
			End Get
			Set(value As Boolean)
				Me.o.ooo0_o_0O. = value
			End Set
		End Property

		' Token: 0x1700106E RID: 4206
		' (get) Token: 0x06004A2D RID: 18989 RVA: 0x001F5316 File Offset: 0x001F3516
		' (set) Token: 0x06004A2E RID: 18990 RVA: 0x001F531E File Offset: 0x001F351E
		<DefaultValue(True)>
		Public Property RepeatFixedCols As Boolean
			Get
				Return Me.o0.0_o_O.
			End Get
			Set(value As Boolean)
				Me.o0.0_o_O. = value
			End Set
		End Property

		' Token: 0x1700106F RID: 4207
		' (get) Token: 0x06004A2F RID: 18991 RVA: 0x001F5327 File Offset: 0x001F3527
		' (set) Token: 0x06004A30 RID: 18992 RVA: 0x001F532F File Offset: 0x001F352F
		<DefaultValue(True)>
		Public Property PrintFixedCols As Boolean
			Get
				Return Me.ooo_oo0.Ooo0o0.
			End Get
			Set(value As Boolean)
				Me.ooo_oo0.Ooo0o0. = value
			End Set
		End Property

		' Token: 0x17001070 RID: 4208
		' (get) Token: 0x06004A31 RID: 18993 RVA: 0x001F5338 File Offset: 0x001F3538
		' (set) Token: 0x06004A32 RID: 18994 RVA: 0x001F5340 File Offset: 0x001F3540
		<DefaultValue(True)>
		Public Property ExcuteDrawCell As Boolean
			Get
				Return Me.oo0o.OoO_0_Oo.
			End Get
			Set(value As Boolean)
				Me.oo0o.OoO_0_Oo. = value
			End Set
		End Property

		' Token: 0x17001071 RID: 4209
		' (get) Token: 0x06004A33 RID: 18995 RVA: 0x001F5349 File Offset: 0x001F3549
		' (set) Token: 0x06004A34 RID: 18996 RVA: 0x001F5351 File Offset: 0x001F3551
		<DefaultValue(False)>
		Public Property FitIntoPage As Boolean
			Get
				Return Me.O._o0o.
			End Get
			Set(value As Boolean)
				Me.O._o0o. = value
			End Set
		End Property

		' Token: 0x17001072 RID: 4210
		' (get) Token: 0x06004A35 RID: 18997 RVA: 0x001F535A File Offset: 0x001F355A
		' (set) Token: 0x06004A36 RID: 18998 RVA: 0x001F5362 File Offset: 0x001F3562
		<DefaultValue(True)>
		Public Property WrapMemo As Boolean
			Get
				Return Me.O0.__o_O000O.
			End Get
			Set(value As Boolean)
				Me.O0.__o_O000O. = value
			End Set
		End Property

		' Token: 0x17001073 RID: 4211
		' (get) Token: 0x06004A37 RID: 18999 RVA: 0x001F536B File Offset: 0x001F356B
		' (set) Token: 0x06004A38 RID: 19000 RVA: 0x001F5373 File Offset: 0x001F3573
		<DefaultValue(True)>
		Public Property ExtendMemoRow As Boolean
			Get
				Return Me.OOo._o0O__00_O.
			End Get
			Set(value As Boolean)
				Me.OOo._o0O__00_O. = value
			End Set
		End Property

		' Token: 0x17001074 RID: 4212
		' (get) Token: 0x06004A39 RID: 19001 RVA: 0x001F537C File Offset: 0x001F357C
		' (set) Token: 0x06004A3A RID: 19002 RVA: 0x001F5384 File Offset: 0x001F3584
		<DefaultValue(True)>
		Public Property OnlyPrintTitleOnFirstPage As Boolean
			Get
				Return Me.O_O.O_00.
			End Get
			Set(value As Boolean)
				Me.O_O.O_00. = value
			End Set
		End Property

		' Token: 0x17001075 RID: 4213
		' (get) Token: 0x06004A3B RID: 19003 RVA: 0x001F538D File Offset: 0x001F358D
		' (set) Token: 0x06004A3C RID: 19004 RVA: 0x001F5395 File Offset: 0x001F3595
		<DefaultValue(True)>
		Public Property AdjustFontSize As Boolean
			Get
				Return Me.O_oO.O.
			End Get
			Set(value As Boolean)
				Me.O_oO.O. = value
			End Set
		End Property

		' Token: 0x17001076 RID: 4214
		' (get) Token: 0x06004A3D RID: 19005 RVA: 0x001F539E File Offset: 0x001F359E
		' (set) Token: 0x06004A3E RID: 19006 RVA: 0x001F53A6 File Offset: 0x001F35A6
		<DefaultValue(False)>
		Public Property OnlySelectedRows As Boolean
			Get
				Return Me.O0OoO___.OO.
			End Get
			Set(value As Boolean)
				Me.O0OoO___.OO. = value
			End Set
		End Property

		' Token: 0x17001077 RID: 4215
		' (get) Token: 0x06004A3F RID: 19007 RVA: 0x001F53AF File Offset: 0x001F35AF
		' (set) Token: 0x06004A40 RID: 19008 RVA: 0x001F53B7 File Offset: 0x001F35B7
		<DefaultValue(False)>
		Public Property Renumber As Boolean
			Get
				Return Me.o._0_O__0.
			End Get
			Set(value As Boolean)
				Me.o._0_O__0. = value
			End Set
		End Property

		' Token: 0x17001078 RID: 4216
		' (get) Token: 0x06004A41 RID: 19009 RVA: 0x001F53C0 File Offset: 0x001F35C0
		' (set) Token: 0x06004A42 RID: 19010 RVA: 0x001F53C8 File Offset: 0x001F35C8
		<DefaultValue(True)>
		Public Property EnableStyle As Boolean
			Get
				Return Me.ooo0o_.__O.
			End Get
			Set(value As Boolean)
				Me.ooo0o_.__O. = value
			End Set
		End Property

		' Token: 0x17001079 RID: 4217
		' (get) Token: 0x06004A43 RID: 19011 RVA: 0x001F53D1 File Offset: 0x001F35D1
		' (set) Token: 0x06004A44 RID: 19012 RVA: 0x001F53D9 File Offset: 0x001F35D9
		<DefaultValue(True)>
		Public Property PrintTitle As Boolean
			Get
				Return Me.oo_0O.__0o0O.
			End Get
			Set(value As Boolean)
				Me.oo_0O.__0o0O. = value
			End Set
		End Property

		' Token: 0x1700107A RID: 4218
		' (get) Token: 0x06004A45 RID: 19013 RVA: 0x001F53E2 File Offset: 0x001F35E2
		' (set) Token: 0x06004A46 RID: 19014 RVA: 0x001F53EA File Offset: 0x001F35EA
		<DefaultValue(True)>
		Public Property PrintHeader As Boolean
			Get
				Return Me.oOOo_o0oo.00.
			End Get
			Set(value As Boolean)
				Me.oOOo_o0oo.00. = value
			End Set
		End Property

		' Token: 0x1700107B RID: 4219
		' (get) Token: 0x06004A47 RID: 19015 RVA: 0x001F53F3 File Offset: 0x001F35F3
		' (set) Token: 0x06004A48 RID: 19016 RVA: 0x001F53FB File Offset: 0x001F35FB
		<DefaultValue(True)>
		Public Property PrintFooter As Boolean
			Get
				Return Me.OOo__._00oo.
			End Get
			Set(value As Boolean)
				Me.OOo__._00oo. = value
			End Set
		End Property

		' Token: 0x1700107C RID: 4220
		' (get) Token: 0x06004A49 RID: 19017 RVA: 0x001F5404 File Offset: 0x001F3604
		' (set) Token: 0x06004A4A RID: 19018 RVA: 0x001F540C File Offset: 0x001F360C
		<DefaultValue(False)>
		Public Property ExtendLastCol As Boolean
			Get
				Return Me.O_oO0_O.0.
			End Get
			Set(value As Boolean)
				Me.O_oO0_O.0. = value
			End Set
		End Property

		' Token: 0x1700107D RID: 4221
		' (get) Token: 0x06004A4B RID: 19019 RVA: 0x001F5415 File Offset: 0x001F3615
		' (set) Token: 0x06004A4C RID: 19020 RVA: 0x001F541D File Offset: 0x001F361D
		<DefaultValue(False)>
		Public Property DirectFitIntoPage As Boolean
			Get
				Return Me.o__oO_.O.
			End Get
			Set(value As Boolean)
				Me.o__oO_.O. = value
			End Set
		End Property

		' Token: 0x1700107E RID: 4222
		' (get) Token: 0x06004A4D RID: 19021 RVA: 0x001F5426 File Offset: 0x001F3626
		' (set) Token: 0x06004A4E RID: 19022 RVA: 0x001F542E File Offset: 0x001F362E
		<DefaultValue(False)>
		Public Property DirectFitIntoOnePage As Boolean
			Get
				Return Me.ooOooO0o0o.ooo.
			End Get
			Set(value As Boolean)
				Me.ooOooO0o0o.ooo. = value
			End Set
		End Property

		' Token: 0x1700107F RID: 4223
		' (get) Token: 0x06004A4F RID: 19023 RVA: 0x001F5437 File Offset: 0x001F3637
		' (set) Token: 0x06004A50 RID: 19024 RVA: 0x001F543F File Offset: 0x001F363F
		<DefaultValue(False)>
		Public Property DirectExtendLastCol As Boolean
			Get
				Return Me.Oo_0O0_0.Oo.
			End Get
			Set(value As Boolean)
				Me.Oo_0O0_0.Oo. = value
			End Set
		End Property

		' Token: 0x17001080 RID: 4224
		' (get) Token: 0x06004A51 RID: 19025 RVA: 0x001F5448 File Offset: 0x001F3648
		' (set) Token: 0x06004A52 RID: 19026 RVA: 0x001F5450 File Offset: 0x001F3650
		<DefaultValue("")>
		Public Property DirectPageHeader As String
			Get
				Return Me.o0OOO0_o.oO00_.
			End Get
			Set(value As String)
				Me.o0OOO0_o.oO00_. = value
			End Set
		End Property

		' Token: 0x17001081 RID: 4225
		' (get) Token: 0x06004A53 RID: 19027 RVA: 0x001F5459 File Offset: 0x001F3659
		' (set) Token: 0x06004A54 RID: 19028 RVA: 0x001F5461 File Offset: 0x001F3661
		<DefaultValue("")>
		Public Property DirectPageFooter As String
			Get
				Return Me.OO00__00_0.__0.
			End Get
			Set(value As String)
				Me.OO00__00_0.__0. = value
			End Set
		End Property

		' Token: 0x17001082 RID: 4226
		' (get) Token: 0x06004A55 RID: 19029 RVA: 0x001F546A File Offset: 0x001F366A
		' (set) Token: 0x06004A56 RID: 19030 RVA: 0x001F5472 File Offset: 0x001F3672
		<DefaultValue(True)>
		Public Property DirectHighLight As Boolean
			Get
				Return Me.oO.OoO_.
			End Get
			Set(value As Boolean)
				Me.oO.OoO_. = value
			End Set
		End Property

		' Token: 0x17001083 RID: 4227
		' (get) Token: 0x06004A57 RID: 19031 RVA: 0x001F547B File Offset: 0x001F367B
		' (set) Token: 0x06004A58 RID: 19032 RVA: 0x001F5483 File Offset: 0x001F3683
		<DefaultValue("宋体,9")>
		Public Property DirectPageHeaderFont As Font
			Get
				Return Me.OO_O_o0_O.o.
			End Get
			Set(value As Font)
				Me.OO_O_o0_O.o. = value
			End Set
		End Property

		' Token: 0x17001084 RID: 4228
		' (get) Token: 0x06004A59 RID: 19033 RVA: 0x001F548C File Offset: 0x001F368C
		' (set) Token: 0x06004A5A RID: 19034 RVA: 0x001F5494 File Offset: 0x001F3694
		<DefaultValue(True)>
		Public Property DirectPrintHeader As Boolean
			Get
				Return Me.oOo.oo.
			End Get
			Set(value As Boolean)
				Me.oOo.oo. = value
			End Set
		End Property

		' Token: 0x17001085 RID: 4229
		' (get) Token: 0x06004A5B RID: 19035 RVA: 0x001F549D File Offset: 0x001F369D
		' (set) Token: 0x06004A5C RID: 19036 RVA: 0x001F54A5 File Offset: 0x001F36A5
		<DefaultValue(True)>
		Public Property DirectPrintFooter As Boolean
			Get
				Return Me.oOo0_.OooOOo.
			End Get
			Set(value As Boolean)
				Me.oOo0_.OooOOo. = value
			End Set
		End Property

		' Token: 0x04001E52 RID: 7762
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001E53 RID: 7763
		Private Const <<EMPTY_NAME>> As String = "[TableCaption]"

		' Token: 0x04001E54 RID: 7764
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E55 RID: 7765
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E56 RID: 7766
		Private Const <<EMPTY_NAME>> As String = "||第[PageNo]页，共[PageCount]页"

		' Token: 0x04001E57 RID: 7767
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E58 RID: 7768
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E59 RID: 7769
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E5A RID: 7770
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E5B RID: 7771
		Private <<EMPTY_NAME>> As Font

		' Token: 0x04001E5C RID: 7772
		Private <<EMPTY_NAME>> As Font

		' Token: 0x04001E5D RID: 7773
		Private <<EMPTY_NAME>> As Font

		' Token: 0x04001E5E RID: 7774
		Private <<EMPTY_NAME>> As Font

		' Token: 0x04001E5F RID: 7775
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E60 RID: 7776
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E61 RID: 7777
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E62 RID: 7778
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E63 RID: 7779
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E64 RID: 7780
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001E65 RID: 7781
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E66 RID: 7782
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E67 RID: 7783
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E68 RID: 7784
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E69 RID: 7785
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E6A RID: 7786
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E6B RID: 7787
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E6C RID: 7788
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E6D RID: 7789
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E6E RID: 7790
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E6F RID: 7791
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E70 RID: 7792
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E71 RID: 7793
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E72 RID: 7794
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E73 RID: 7795
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E74 RID: 7796
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E75 RID: 7797
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E76 RID: 7798
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E77 RID: 7799
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E78 RID: 7800
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E79 RID: 7801
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001E7A RID: 7802
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E7B RID: 7803
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E7C RID: 7804
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001E7D RID: 7805
		Private <<EMPTY_NAME>> As Font
	End Class
End Namespace
