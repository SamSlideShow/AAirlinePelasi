<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
     <meta charset="utf-8" />
    <title>Hauptfenster der Mitarbeiter</title>
    <link rel="stylesheet" type="text/css" href="css/main.css" />
</head>
<body>
    <h1>Say Yes to new adventures ~ Pelasi</h1>

    <div>
        <%=Html.ActionLink("Startseite", "Index")%>
        <%=Html.ActionLink("Mein Konto", "MeinKonto") %>
    </div>

    <h1>Eigene Flüge</h1>
    <table border="1">
        <tr>
            <th>FlugID</th>
            <th>Flugziel</th>
            <th>Abflugsort</th>
            <th>Datum</th>
            <th>Startzeitpunkt</th>
            <th>Landung</th>
        </tr>
        
            <%For Each flu In Model.Flug%>
            <tr>
                <td><%=flu.FluId%></td>
                <td><%=flu.Flugziel%></td>
                <td><%=flu.Abflugsort%></td>
                <td><%=flu.Datum%></td>
                <td><%=flu.Startzeitpunkt%></td>
                <td><%=flu.Landung%></td>
       </tr>
        </table>

        <footer>
            <p>Carina Lammel, Charlene Pennig, Samuel Simon</p>
        </footer>

</body>
</html>
