Public Class PassagierViewModel

    Private mPassagier As Passagier

    Public Property Passagier() As Passagier
        Get
            Return mPassagier
        End Get
        Set(ByVal value As Passagier)
            mPassagier = value
        End Set
    End Property

    Friend Function Passagiere() As Object
        Throw New NotImplementedException()
    End Function
End Class
