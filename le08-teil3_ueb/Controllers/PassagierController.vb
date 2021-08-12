Public Class PassagierController
    Inherits System.Web.Mvc.Controller

    Private Shared mlstPassagiere As List(Of Passagier)
    Private db As VerwaltungEntities = New VerwaltungEntities
    Public Sub New()
        MyBase.New()
    End Sub

    '
    ' GET: /Passagiere
    <HttpGet>
    Function Index() As ActionResult

        Dim pas As Passagier
        Dim pasEntity As PassagierEntity
        Dim vmPassagiereListe As PassagiereListe


        vmPassagiereListe = New PassagiereListe()

        For Each pasEntity In db.tblPassagiere.ToList
            pas = New Passagier(pasEntity)
            vmPassagiereListe.Passagier.Add(pas)
        Next

        Return View(vmPassagiereListe)
    End Function

    <HttpGet>
    Function Bearbeiten(ID As Integer) As ActionResult

        Dim pas As Passagier
        Dim pasEntity As PassagierEntity
        Dim vmPas As PassagierViewModel

        pasEntity = db.tblPassagiere.Find(ID)
        pas = New Passagier(pasEntity)

        If pas Is Nothing Then
            Return New HttpNotFoundResult("Passagier mit ID='" & ID & "' nicht gefunden")
        End If

        vmPas = New PassagierViewModel
        vmPas.Passagier = pas

        Return View(vmPas)

    End Function

    <HttpPost>
    Function Bearbeiten(pvmPas As PassagierViewModel)

        Dim pasEntity As PassagierEntity


        pasEntity = pvmPas.Passagier.gibAlsPassagierEntity
        db.tblPassagiere.Attach(pasEntity)
        db.Entry(pasEntity).State = EntityState.Modified

        db.SaveChanges()

        Return RedirectToAction("Index")
    End Function

    <HttpGet>
    Function Loeschen(ID As Integer) As ActionResult

        Dim pas As Passagier
        Dim vmPas As PassagierViewModel
        Dim pasEntity As PassagierEntity

        pasEntity = db.tblPassagiere.Find(ID)
        pas = New Passagier(pasEntity)

        vmPas = New PassagierViewModel
        vmPas.Passagier = pas

        Return View(vmPas)

    End Function

    <HttpPost>
    <ActionName("Loeschen")>
    Function LoeschenBestaetigt(ID As Integer)

        Dim pasEntity As PassagierEntity

        pasEntity = db.tblPassagiere.Find(ID)

        db.Entry(pasEntity).State = EntityState.Deleted
        db.SaveChanges()


        Return RedirectToAction("Index")
    End Function

    <HttpGet>
    Function Hinzufuegen() As ActionResult

        Dim pas As Passagier
        Dim vmPas As PassagierViewModel

        pas = New Passagier()

        vmPas = New PassagierViewModel
        vmPas.Passagier = pas

        Return View(vmPas)

    End Function

    <HttpPost>
    Function Hinzufuegen(pvmAuf As PassagierViewModel)

        Dim pasNeu As Passagier
        Dim pasEntity As PassagierEntity

        pasNeu = pvmAuf.Passagier

        pasEntity = pasNeu.gibAlsPassagierEntity

        db.tblPassagiere.Attach(pasEntity)
        db.Entry(pasEntity).State = EntityState.Added
        db.SaveChanges()

        mlstPassagiere.Add(pasNeu)

        Return RedirectToAction("Index")
    End Function

    Private Shared Function gibNaechstePassagierePasId() As Integer
        Dim intPaId As Integer

        For Each pas In mlstPassagiere
            If pas.PaId > intPaId Then
                intPaId = pas.PaId
            End If
        Next
        intPaId = intPaId + 1

        Return intPaId
    End Function


End Class