<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.PassagiereListe)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Alle Passagiere</title>
</head>
<body>
    <div>
        <%="" %>
        <h1>Passagierübersicht</h1>
        <p>Hier sehen Sie alle Passagiere in einer Übersicht.</p>

        <table>
            <tr>
                <th>PassagierID</th>
                <th>Anrede</th>
                <th>Name</th>
                <th>Vorname</th>
                <th>E-Mail</th>
                <th>FlugID</th>
            </tr>

            <%For Each pas In Model.Passagier%>
            <tr>
                <td><%=pas.PaId%></td>
                <td><%=pas.Anrede%></td>
                <td><%=pas.Name%></td>
                <td><%=pas.Vorname%></td>
                <td><%=pas.EMail%></td>
                <td><%=pas.FluIdFK%></td>
                <td>
                    <%=Html.ActionLink("Bearbeiten", "Bearbeiten", New With {.ID = pas.PaId}) %>
                    <%=Html.ActionLink("Löschen", "Loeschen", New With {.ID = pas.PaId})%>
                </td>
            </tr>
            <%Next %>
       </table>
        <%=Html.ActionLink("Hinzufügen", "Hinzufuegen") %>
    </div>
</body>
</html>
