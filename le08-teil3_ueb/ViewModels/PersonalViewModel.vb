Public Class PersonalViewModel

    Private mPersonal As Personal

    Public Property Personal() As Personal
        Get
            Return mPersonal
        End Get
        Set(ByVal value As Personal)
            mPersonal = value
        End Set
    End Property

    Friend Function Personale() As Object
        Throw New NotImplementedException()
    End Function
End Class
