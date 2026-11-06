Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Neodynamic.WinControls.BarcodeProfessional

Namespace Foxtable
	' Token: 0x0200038F RID: 911
	Friend Class OOo00o_0o0_
		Inherits BarcodeProfessional

		' Token: 0x06003A77 RID: 14967 RVA: 0x00196268 File Offset: 0x00194468
		Public Sub New()
			MyBase.BarcodeUnit = 1
			MyBase.BorderStyle = Border3DStyle.Adjust
			MyBase.BorderWidth = 0.0
			MyBase.Symbology = 3
			MyBase.Code = "123456"
			MyBase.Width = 1
			MyBase.Height = 1
			MyBase.QuietZoneWidth = 2.0
			MyBase.QRCodeByteEncodingName = "gb2312"
			Dim barcodePadding As Margin = MyBase.BarcodePadding
			barcodePadding.Left = 0.5
			barcodePadding.Right = 0.5
			barcodePadding.Bottom = 0.5
			barcodePadding.Top = 0.5
			MyBase.BarWidth = 0.2642
			MyBase.BarHeight = 5.08
			MyBase.BearerBarWidth = 1.27
			MyBase.AztecCodeModuleSize = 1.0592
			MyBase.DataMatrixModuleSize = 1.0592
			MyBase.EanUpcSupplementSeparation = 3.81
			MyBase.EanUpcSupplementTopMargin = 3.81
			MyBase.GuardBarHeight = 6.35
			MyBase.PharmacodeBarsSpacing = 1.0592
			MyBase.PharmacodeThickBarWidth = 1.5875
			MyBase.PharmacodeThinBarWidth = 0.5283
			MyBase.PlanetHeightShortBar = 5.0
			MyBase.PlanetHeightTallBar = 10.0
			MyBase.Postal4StateBarsSpacing = 0.795
			MyBase.Postal4StateTrackerBarHeight = 2.032
			MyBase.Postal4StateTrackerBarWidth = 0.5283
			MyBase.PostnetHeightShortBar = 5.0
			MyBase.PostnetHeightTallBar = 10.0
			MyBase.QRCodeModuleSize = 1.0592
			MyBase.TextForeColor = Color.Black
			Me.ForeColor = Color.Black
		End Sub

		' Token: 0x06003A78 RID: 14968 RVA: 0x0019644C File Offset: 0x0019464C
		Shared Sub New()
			BarcodeProfessional.LicenseOwner = "Zhanjiang Huixun Software Co., Ltd-Ultimate Edition-Developer License"
			BarcodeProfessional.LicenseKey = "8C232EXH778ME8FD9E5KSRXUXFRVE74VZB5QU2TLU8WBZGAX3W8Q"
		End Sub
	End Class
End Namespace
