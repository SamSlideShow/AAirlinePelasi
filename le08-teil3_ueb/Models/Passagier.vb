Public Class Passagier

    Private mintPaId As Integer
    Private mstrAnrede As String
    Private mstrName As String
    Private mstrVorname As String
    Private mstrEmail As String
    Private mintFluIdFK As Integer

    Public Sub New()
        mintPaId = +1
        mstrAnrede = String.Empty
        mstrName = String.Empty
        mstrVorname = String.Empty
        mstrEmail = String.Empty
        mintFluIdFK = -1
    End Sub

    Public Sub New(pintPaId As Integer, pstrAnrede As String,
                pstrName As String, pstrVorname As String,
                pstrEmail As String, pintFluIdFK As Integer)

        mintPaId = pintPaId
        mstrAnrede = pstrAnrede
        mstrName = pstrName
        mstrVorname = pstrVorname
        mstrEmail = pstrEmail
        mintFluIdFK = pintFluIdFK

    End Sub

    Public Sub New(ppasEntity As PassagierEntity)
        mintPaId = ppasEntity.PaIdPk
        mstrAnrede = ppasEntity.PaAnrede
        mstrName = ppasEntity.PaName
        mstrVorname = ppasEntity.PaVorname
        mstrEmail = ppasEntity.PaEMail
        mintFluIdFK = ppasEntity.PaFluIDFK
    End Sub
    Public Property PaId() As Integer
        Get
            Return mintPaId
        End Get
        Set(ByVal value As Integer)
            mintPaId = value
        End Set
    End Property

    Public Property Anrede() As String
        Get
            Return mstrAnrede
        End Get
        Set(ByVal value As String)
            mstrAnrede = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return mstrName
        End Get
        Set(ByVal value As String)
            mstrName = value
        End Set
    End Property
    Public Property Vorname() As String
        Get
            Return mstrVorname
        End Get
        Set(ByVal value As String)
            mstrVorname = value
        End Set
    End Property
    Public Property EMail() As String
        Get
            Return mstrEmail
        End Get
        Set(ByVal value As String)
            mstrEmail = value
        End Set
    End Property
    Public Property FluIdFK() As Integer
        Get
            Return mintFluIdFK
        End Get
        Set(ByVal value As Integer)
            mintFluIdFK = value
        End Set
    End Property

    Public Function gibAlsPassagierEntity() As PassagierEntity
        Dim pasEntity As PassagierEntity
        pasEntity = New PassagierEntity

        pasEntity.PaIdPk = mintPaId
        pasEntity.PaAnrede = mstrAnrede
        pasEntity.PaName = mstrName
        pasEntity.PaVorname = mstrVorname
        pasEntity.PaEMail = mstrEmail
        pasEntity.PaFluIDFK = mintFluIdFK

        Return pasEntity
    End Function

End Class