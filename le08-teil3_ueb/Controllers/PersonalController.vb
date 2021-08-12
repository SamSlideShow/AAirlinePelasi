Public Class PersonalController
    Inherits System.Web.Mvc.Controller

    Private Shared mlstPersonal As List(Of Personal)
    Private db As VerwaltungEntities = New VerwaltungEntities
    Public Sub New()
        MyBase.New()
    End Sub

    '
    ' GET: /Personal
    <HttpGet>
    Function Index() As ActionResult

        Dim per As Personal
        Dim perEntity As PersonalEntity
        Dim vmPersonaleListe As PersonaleListe


        vmPersonaleListe = New PersonaleListe()

        For Each perEntity In db.tblPersonal.ToList
            per = New Personal(perEntity)
            vmPersonaleListe.Personal.Add(per)
        Next

        Return View(vmPersonaleListe)
    End Function

    <HttpGet>
    Function Bearbeiten(ID As Integer) As ActionResult

        Dim per As Personal
        Dim perEntity As PersonalEntity
        Dim vmPer As PersonalViewModel

        perEntity = db.tblPersonal.Find(ID)
        per = New Personal(perEntity)

        If per Is Nothing Then
            Return New HttpNotFoundResult("Personal mit ID='" & ID & "' nicht gefunden")
        End If

        vmPer = New PersonalViewModel
        vmPer.Personal = per

        Return View(vmPer)

    End Function

    <HttpPost>
    Function Bearbeiten(pvmPer As PersonalViewModel)

        Dim perEntity As PersonalEntity


        perEntity = pvmPer.Personal.gibAlsPersonalEntity
        db.tblPersonal.Attach(perEntity)
        db.Entry(perEntity).State = EntityState.Modified

        db.SaveChanges()

        Return RedirectToAction("Index")
    End Function

    <HttpGet>
    Function Loeschen(ID As Integer) As ActionResult

        Dim per As Personal
        Dim vmPer As PersonalViewModel
        Dim perEntity As PersonalEntity

        perEntity = db.tblPersonal.Find(ID)
        per = New Personal(perEntity)

        vmPer = New PersonalViewModel
        vmPer.Personal = per

        Return View(vmPer)

    End Function

    <HttpPost>
    <ActionName("Loeschen")>
    Function LoeschenBestaetigt(ID As Integer)

        Dim perEntity As PersonalEntity

        perEntity = db.tblPersonal.Find(ID)

        db.Entry(perEntity).State = EntityState.Deleted
        db.SaveChanges()


        Return RedirectToAction("Index")
    End Function

    <HttpGet>
    Function Hinzufuegen() As ActionResult

        Dim per As Personal
        Dim vmPer As PersonalViewModel

        per = New Personal()

        vmPer = New PersonalViewModel
        vmPer.Personal = per

        Return View(vmPer)

    End Function

    <HttpPost>
    Function Hinzufuegen(pvmPer As PersonalViewModel)

        Dim perNeu As Personal
        Dim perEntity As PersonalEntity

        perNeu = pvmPer.Personal

        perEntity = perNeu.gibAlsPersonalEntity

        db.tblPersonal.Attach(perEntity)
        db.Entry(perEntity).State = EntityState.Added
        db.SaveChanges()

        mlstPersonal.Add(perNeu)

        Return RedirectToAction("Index")
    End Function

    Private Shared Function gibNaechstePersonalPaerId() As Integer
        Dim intPerId As Integer

        For Each per In mlstPersonal
            If per.PerId > intPerId Then
                intPerId = per.PerId
            End If
        Next
        intPerId = intPerId + 1

        Return intPerId
    End Function


End Class