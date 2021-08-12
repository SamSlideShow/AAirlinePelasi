<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.FlugViewModel)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Flug "<%=Model.Flug.FluId%>" löschen</title>
</head>
<body>
    <div>
        <h1>Flug "<%=Model.Flug.FluId%>" löschen</h1>
        <p>Möchten Sie den Flug "<%=Model.Flug.FluId%>" wirklich löschen?</p>

        <%Using Html.BeginForm()%>

            <p>
                <%=Html.HiddenFor(Function(m) Model.Flug.FluId) %>
            </p>
            <p><%=Html.ActionLink("Abbrechen", "Index")%> <input type="submit" value="Löschen"/></p>
        <%End Using%>
        
    </div>
</body>
</html>
 