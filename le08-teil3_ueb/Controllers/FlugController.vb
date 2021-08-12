Public Class FlugController
    Inherits System.Web.Mvc.Controller

    Private Shared mlstFluege As List(Of Flug)
    Private db As VerwaltungEntities = New VerwaltungEntities
    Public Sub New()
        MyBase.New()

        If mlstFluege Is Nothing Then
            erzeugeBeispieldaten()
        End If
    End Sub

    '
    ' GET: /Flug
    <HttpGet>
    Function Index() As ActionResult

        Dim flu As Flug
        Dim fluEntity As FlugEntity
        Dim vmFluegeListe As FluegeListe


        vmFluegeListe = New FluegeListe()

        For Each fluEntity In db.tblFluege.ToList
            flu = New Flug(fluEntity)
            vmFluegeListe.Flug.Add(flu)
        Next

        Return View(vmFluegeListe)
    End Function

    <HttpGet>
    Function Bearbeiten(ID As Integer) As ActionResult

        Dim flu As Flug
        Dim fluEntity As FlugEntity
        Dim vmFlu As FlugViewModel

        'flu = mlstFluege.Find(Function(m) m.FluId = ID)
        fluEntity = db.tblFluege.Find(ID)
        flu = New Flug(fluEntity)

        If flu Is Nothing Then
            Return New HttpNotFoundResult("Flug mit ID='" & ID & "' nicht gefunden")
        End If

        vmFlu = New FlugViewModel
        vmFlu.Flug = flu

        Return View(vmFlu)

    End Function

    <HttpPost>
    Function Bearbeiten(pvmFlu As FlugViewModel)

        Dim fluEntity As FlugEntity


        'flu = mlstFluege.Find(Function(a) a.FluId = intFluId)

        fluEntity = pvmFlu.Flug.gibAlsFlugEntity
        db.tblFluege.Attach(fluEntity)
        db.Entry(fluEntity).State = EntityState.Modified

        db.SaveChanges()

        Return RedirectToAction("Index")
    End Function

    <HttpGet>
    Function Loeschen(ID As Integer) As ActionResult

        Dim flu As Flug
        Dim vmFlu As FlugViewModel
        Dim fluEntity As FlugEntity

        fluEntity = db.tblFluege.Find(ID)
        flu = New Flug(fluEntity)



        'flu = mlstFluege.Find(Function(m) m.FluId = ID)

        'If flu Is Nothing Then
        'Return New HttpNotFoundResult("Flug mit ID='" & ID & "' nicht gefunden")
        'End If

        vmFlu = New FlugViewModel
        vmFlu.Flug = flu

        Return View(vmFlu)

    End Function

    <HttpPost>
    <ActionName("Loeschen")>
    Function LoeschenBestaetigt(ID As Integer)

        Dim fluEntity As FlugEntity

        fluEntity = db.tblFluege.Find(ID)

        db.Entry(fluEntity).State = EntityState.Deleted
        db.SaveChanges()


        Return RedirectToAction("Index")
    End Function

    <HttpGet>
    Function Hinzufuegen() As ActionResult

        Dim flu As Flug
        Dim vmFlu As FlugViewModel

        flu = New Flug()

        vmFlu = New FlugViewModel
        vmFlu.Flug = flu

        Return View(vmFlu)

    End Function

    <HttpPost>
    Function Hinzufuegen(pvmAuf As FlugViewModel)

        Dim fluNeu As Flug
        Dim fluEntity As FlugEntity

        fluNeu = pvmAuf.Flug

        fluEntity = fluNeu.gibAlsFlugEntity

        db.tblFluege.Attach(fluEntity)
        db.Entry(fluEntity).State = EntityState.Added
        db.SaveChanges()

        mlstFluege.Add(fluNeu)

        Return RedirectToAction("Index")
    End Function

    Private Shared Function gibNaechsteFluegeFluId() As Integer
        Dim intFluId As Integer

        For Each flu In mlstFluege
            If flu.FluId > intFluId Then
                intFluId = flu.FluId
            End If
        Next
        intFluId = intFluId + 1

        Return intFluId
    End Function

    Private Shared Sub erzeugeBeispieldaten()
        Dim fluMuenchen, fluBerlin, fluLissabon, fluMadrid As Flug


        fluMuenchen = New Flug(1, 1, "Muenchen", "BER", #05/22/2021#, "7:30", "9:00", "99")
        fluBerlin = New Flug(2, 2, "Berlin", "MUC", #05/23/2021#, "18:30", "20:00", "67")
        fluLissabon = New Flug(3, 3, "Lissabon", "BER", #05/25/2021#, "07:15", "11:30", "88")
        fluMadrid = New Flug(4, 1, "Madrid", "BER", #05/25/2021#, "09:25", "12:15", "74")



        mlstFluege = New List(Of Flug)
        mlstFluege.Add(fluMuenchen)
        mlstFluege.Add(fluBerlin)
        mlstFluege.Add(fluLissabon)
        mlstFluege.Add(fluMadrid)

    End Sub

End Class