Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Mvvm.DataAnnotations
Imports System.Windows.Media

Namespace Example.ViewModel
	<POCOViewModel> _
	Public Class MainViewModel
		Private privateInvalidValue As String
		Public Overridable Property InvalidValue() As String
			Get
				Return privateInvalidValue
			End Get
			Set(ByVal value As String)
				privateInvalidValue = value
			End Set
		End Property
		Private privateValidBrush As Brush
		Public Overridable Property ValidBrush() As Brush
			Get
				Return privateValidBrush
			End Get
			Set(ByVal value As Brush)
				privateValidBrush = value
			End Set
		End Property
		Private privateInvalidBrush As Brush
		Public Overridable Property InvalidBrush() As Brush
			Get
				Return privateInvalidBrush
			End Get
			Set(ByVal value As Brush)
				privateInvalidBrush = value
			End Set
		End Property

		Public Sub SetRedValidBrush()
			ValidBrush = New SolidColorBrush(Colors.Red)
		End Sub
		Public Sub SetBlueValidBrush()
			ValidBrush = New SolidColorBrush(Colors.Blue)
		End Sub
		Public Sub SetBlackValidBrush()
			ValidBrush = New SolidColorBrush(Colors.Black)
		End Sub

		Public Sub SetRedInvalidBrush()
			InvalidBrush = New SolidColorBrush(Colors.Red)
		End Sub
		Public Sub SetBlueInvalidBrush()
			InvalidBrush = New SolidColorBrush(Colors.Blue)
		End Sub
		Public Sub SetBlackInvalidBrush()
			InvalidBrush = New SolidColorBrush(Colors.Black)
		End Sub

		Public Sub New()
			InvalidValue = "Error"
			SetBlackValidBrush()
			SetRedInvalidBrush()
		End Sub
	End Class
End Namespace
