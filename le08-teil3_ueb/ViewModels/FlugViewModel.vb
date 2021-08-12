Public Class FlugViewModel

    Private mFlug As Flug

    Public Property Flug() As Flug
        Get
            Return mFlug
        End Get
        Set(ByVal value As Flug)
            mFlug = value
        End Set
    End Property

    Friend Function Fluge() As Object
        Throw New NotImplementedException()
    End Function
End Class
