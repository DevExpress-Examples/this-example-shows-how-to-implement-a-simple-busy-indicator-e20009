Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Threading

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			busyIndicator.Visibility = Visibility.Visible
			Try
				ThreadPool.QueueUserWorkItem(AddressOf OnCompleted)
			Catch
				busyIndicator.Visibility = Visibility.Collapsed
				Throw
			End Try
		End Sub

		Private Sub OnCompleted(ByVal state As Object)
			Thread.Sleep(1000)
				'
			Dispatcher.BeginInvoke(Function() AnonymousMethod1())
		End Sub
		
		Private Function AnonymousMethod1() As Boolean
			busyIndicator.Visibility = Visibility.Collapsed
			Return True
		End Function
	End Class
End Namespace
