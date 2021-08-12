Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult
        Return RedirectToAction("Index", "Flug")
    End Function

End Class