Public Class PassagiereListe

    Private mlstPassagiere As List(Of Passagier)

    Public Sub New()
        mlstPassagiere = New List(Of Passagier)
    End Sub

    Public Sub New(plstPassagiere As List(Of Passagier))
        mlstPassagiere = plstPassagiere
    End Sub


    Public Property Passagier As List(Of Passagier)
        Get
            Return mlstPassagiere
        End Get
        Set(value As List(Of Passagier))
            mlstPassagiere = value
        End Set
    End Property

End Class
