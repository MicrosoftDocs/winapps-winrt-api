Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub




    ' <SnippetSineEase_code>
    ' When the user clicks the rectangle, the animation
    ' begins. 
    Private Sub Pointer_Clicked(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        myStoryboard.Begin()
    End Sub
    ' </SnippetSineEase_code>

End Class