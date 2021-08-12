Imports System.ComponentModel.DataAnnotations

Public Class Flug

    Private mintFluId As Integer
    Private mintPerId As Integer
    Private mstrFlugziel As String
    Private mstrAbflugsort As String
    Private mdatDatum As Date
    Private mstrStartzeitpunkt As String
    Private mstrLandung As String
    Private mintAnzahlPassagiere As Integer

    Public Sub New()
        mintFluId = -1
        mintPerId = -1
        mstrFlugziel = String.Empty
        mstrAbflugsort = String.Empty
        mdatDatum = Date.MaxValue
        mstrStartzeitpunkt = String.Empty
        mstrLandung = String.Empty
        mintAnzahlPassagiere = -1
    End Sub

    Public Sub New(pintFluId As Integer, pintPerId As Integer, pstrFlugziel As String,
                pstrAbflugsort As String, pdatDatum As Date, pstrStartzeitpunkt As String,
                pstrLandung As String, pintAnzahlPassagiere As Integer)

        mintFluId = pintFluId
        mintPerId = pintPerId
        mstrFlugziel = pstrFlugziel
        mstrAbflugsort = pstrAbflugsort
        mdatDatum = pdatDatum
        mstrStartzeitpunkt = pstrStartzeitpunkt
        mstrLandung = pstrLandung
        mintAnzahlPassagiere = pintAnzahlPassagiere

    End Sub

    Public Sub New(pfluEntity As FlugEntity)
        mintFluId = pfluEntity.FluIdPk
        mintPerId = pfluEntity.FluPerIdFk
        mstrFlugziel = pfluEntity.FluFlugziel
        mstrAbflugsort = pfluEntity.FluAbflugsort
        mdatDatum = pfluEntity.FluDatum
        mstrStartzeitpunkt = pfluEntity.FluStartzeitpunkt
        mstrLandung = pfluEntity.FluLandung
        mintAnzahlPassagiere = pfluEntity.FluAnzahlPassagiere
    End Sub
    Public Property FluId() As Integer
        Get
            Return mintFluId
        End Get
        Set(ByVal value As Integer)
            mintFluId = value
        End Set
    End Property

    Public Property PerId() As Integer
        Get
            Return mintPerId
        End Get
        Set(ByVal value As Integer)
            mintPerId = value
        End Set
    End Property

    Public Property Flugziel() As String
        Get
            Return mstrFlugziel
        End Get
        Set(ByVal value As String)
            mstrFlugziel = value
        End Set
    End Property
    Public Property Abflugsort() As String
        Get
            Return mstrAbflugsort
        End Get
        Set(ByVal value As String)
            mstrAbflugsort = value
        End Set
    End Property
    Public Property Datum() As Date
        Get
            Return mdatDatum
        End Get
        Set(ByVal value As Date)
            mdatDatum = value
        End Set
    End Property
    Public Property Startzeitpunkt() As String
        Get
            Return mstrStartzeitpunkt
        End Get
        Set(ByVal value As String)
            mstrStartzeitpunkt = value
        End Set
    End Property
    Public Property Landung() As String
        Get
            Return mstrLandung
        End Get
        Set(ByVal value As String)
            mstrLandung = value
        End Set
    End Property
    Public Property AnzahlPassagiere() As Integer
        Get
            Return mintAnzahlPassagiere
        End Get
        Set(ByVal value As Integer)
            mintAnzahlPassagiere = value
        End Set
    End Property

    Public Function gibAlsFlugEntity() As FlugEntity
        Dim fluEntity As FlugEntity
        fluEntity = New FlugEntity

        fluEntity.FluIdPk = mintFluId
        fluEntity.FluPerIdFk = mintPerId
        fluEntity.FluFlugziel = mstrFlugziel
        fluEntity.FluAbflugsort = mstrAbflugsort
        fluEntity.FluDatum = mdatDatum
        fluEntity.FluStartzeitpunkt = mstrStartzeitpunkt
        fluEntity.FluLandung = mstrLandung
        fluEntity.FluAnzahlPassagiere = mintAnzahlPassagiere

        Return fluEntity
    End Function

End Class
