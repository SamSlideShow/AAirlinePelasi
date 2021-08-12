<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.PassagierViewModel)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Passagier "<%=Model.Passagier.PaId%>" löschen</title>
</head>
<body>
    <div>
        <h1>Passagier "<%=Model.Passagier.PaId%>" löschen</h1>
        <p>Möchten Sie den Passagier "<%=Model.Passagier.PaId%>" wirklich löschen?</p>

        <%Using Html.BeginForm()%>

            <p>
                <%=Html.HiddenFor(Function(m) Model.Passagier.PaId) %>
            </p>
            <p><%=Html.ActionLink("Abbrechen", "Index")%> <input type="submit" value="Löschen"/></p>
        <%End Using%>
        
    </div>
</body>
</html>
 