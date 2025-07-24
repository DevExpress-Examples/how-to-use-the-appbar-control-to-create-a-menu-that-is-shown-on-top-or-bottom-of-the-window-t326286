Imports System.Windows
Imports System.Windows.Controls

Namespace AppBarExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub OnMoveAppBarTop(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.appBar.Alignment = DevExpress.Xpf.WindowsUI.AppBarAlignment.Top
        End Sub

        Private Sub OnMoveAppBarBottom(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.appBar.Alignment = DevExpress.Xpf.WindowsUI.AppBarAlignment.Bottom
        End Sub
    End Class
End Namespace
