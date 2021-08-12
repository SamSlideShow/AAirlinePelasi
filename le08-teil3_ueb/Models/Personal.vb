Public Class Personal

    Private mintPerId As Integer
    Private mstrAnrede As String
    Private mstrName As String
    Private mstrVorname As String
    Private mstrEmail As String
    Private mbolMitarbeiter As Boolean

    Public Sub New()
        mintPerId = +1
        mstrAnrede = String.Empty
        mstrName = String.Empty
        mstrVorname = String.Empty
        mstrEmail = String.Empty
        mbolMitarbeiter = False
    End Sub

    Public Sub New(pintPerId As Integer, pstrAnrede As String,
                pstrName As String, pstrVorname As String,
                pstrEmail As String, pbolMitarbeiter As Boolean)

        mintPerId = pintPerId
        mstrAnrede = pstrAnrede
        mstrName = pstrName
        mstrVorname = pstrVorname
        mstrEmail = pstrEmail
        mbolMitarbeiter = pbolMitarbeiter

    End Sub

    Public Sub New(pperEntity As PersonalEntity)
        mintPerId = pperEntity.PerIdPk
        mstrAnrede = pperEntity.PerAnrede
        mstrName = pperEntity.PerName
        mstrVorname = pperEntity.PerVorame
        mstrEmail = pperEntity.PerEMail
        mbolMitarbeiter = pperEntity.PerMitarbeiter_
    End Sub
    Public Property PerId() As Integer
        Get
            Return mintPerId
        End Get
        Set(ByVal value As Integer)
            mintPerId = value
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
    Public Property Mitarbeiter() As Boolean
        Get
            Return mbolMitarbeiter
        End Get
        Set(ByVal value As Boolean)
            mbolMitarbeiter = value
        End Set
    End Property

    Public Function gibAlsPersonalEntity() As PersonalEntity
        Dim perEntity As PersonalEntity
        perEntity = New PersonalEntity

        perEntity.PerIdPk = mintPerId
        perEntity.PerAnrede = mstrAnrede
        perEntity.PerName = mstrName
        perEntity.PerVorame = mstrVorname
        perEntity.PerEMail = mstrEmail
        perEntity.PerMitarbeiter_ = mbolMitarbeiter

        Return perEntity
    End Function

End Class