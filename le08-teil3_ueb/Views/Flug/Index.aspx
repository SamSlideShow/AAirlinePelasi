<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.FluegeListe)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Alle Flüge</title>
</head>
<body>
    <div>
        <%="" %>
        <h1>Flugübersicht</h1>
        <p>Hier sehen Sie alle Flüge in einer Übersicht.</p>

        <table>
            <tr>
                <th>FlugID</th>
                <th>PerID</th>
                <th>FLugziel</th>
                <th>Abflugsort</th>
                <th>Datum</th>
                <th>Startzeitpunkt</th>
                <th>Landung</th>
                <th>AnzahlPassagiere</th>
            </tr>

            <%For Each flu In Model.Flug%>
            <tr>
                <td><%=flu.FluId%></td>
                <td><%=flu.PerId%></td>
                <td><%=flu.Flugziel%></td>
                <td><%=flu.Abflugsort%></td>
                <td><%=flu.Datum%></td>
                <td><%=flu.Startzeitpunkt%></td>
                <td><%=flu.Landung%></td>
                <td><%=flu.AnzahlPassagiere%></td>
                <td>
                    <%=Html.ActionLink("Bearbeiten", "Bearbeiten", New With {.ID = flu.FluId}) %>
                    <%=Html.ActionLink("Löschen", "Loeschen", New With {.ID = flu.FluId})%>
                </td>
            </tr>
            <%Next %>
       </table>
        <%=Html.ActionLink("Hinzufügen", "Hinzufuegen") %>
    </div>
</body>
</html>
