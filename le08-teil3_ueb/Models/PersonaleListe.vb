Public Class PersonaleListe

    Private mlstPersonal As List(Of Personal)

    Public Sub New()
        mlstPersonal = New List(Of Personal)
    End Sub

    Public Sub New(plstPersonal As List(Of Personal))
        mlstPersonal = plstPersonal
    End Sub


    Public Property Personal As List(Of Personal)
        Get
            Return mlstPersonal
        End Get
        Set(value As List(Of Personal))
            mlstPersonal = value
        End Set
    End Property

End Class
