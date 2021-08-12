<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.PersonalViewModel)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Mitarbeiter "<%=Model.Personal.PerId%>" löschen</title>
</head>
<body>
    <div>
        <h1>Mitarbeiter "<%=Model.Personal.PerId%>" löschen</h1>
        <p>Möchten Sie den Mitarbeiter "<%=Model.Personal.PerId%>" wirklich löschen?</p>

        <%Using Html.BeginForm()%>

            <p>
                <%=Html.HiddenFor(Function(m) Model.Personal.PerId) %>
            </p>
            <p><%=Html.ActionLink("Abbrechen", "Index")%> <input type="submit" value="Löschen"/></p>
        <%End Using%>
        
    </div>
</body>
</html>
 