Imports Microsoft.VisualBasic
	Imports System
	Imports System.Windows.Controls
	Imports System.Windows.Media.Animation
Namespace DevExpress.Xpf.Toolkit
	Public Class BusyIndicator
		Inherits Control
		Public Sub New()
			DefaultStyleKey = GetType(BusyIndicator)
		End Sub
		Public Overrides Sub OnApplyTemplate()
			MyBase.OnApplyTemplate()
			Dim story As Storyboard = CType(GetTemplateChild("Storyboard"), Storyboard)
			If story IsNot Nothing Then
				story.Begin()
			End If
		End Sub
	End Class
End Namespace