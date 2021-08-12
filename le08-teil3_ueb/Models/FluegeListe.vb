Public Class FluegeListe

    Private mlstFluege As List(Of Flug)

    Public Sub New()
        mlstFluege = New List(Of Flug)
    End Sub

    Public Sub New(plstFluege As List(Of Flug))
        mlstFluege = plstFluege
    End Sub


    Public Property Flug As List(Of Flug)
        Get
            Return mlstFluege
        End Get
        Set(value As List(Of Flug))
            mlstFluege = value
        End Set
    End Property

End Class
