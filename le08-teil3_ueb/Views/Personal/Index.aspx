<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.PersonaleListe)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Alle Mitarbeiter</title>
</head>
<body>
    <div>
        <%="" %>
        <h1>Personalübersicht</h1>
        <p>Hier sehen Sie alle Mitarbeiter in einer Übersicht.</p>

        <table>
            <tr>
                <th>PersonalID</th>
                <th>Anrede</th>
                <th>Name</th>
                <th>Vorname</th>
                <th>E-Mail</th>
                <th>Mitarbeiter?</th>
            </tr>

            <%For Each per In Model.Personal%>
            <tr>
                <td><%=per.PerId%></td>
                <td><%=per.Anrede%></td>
                <td><%=per.Name%></td>
                <td><%=per.Vorname%></td>
                <td><%=per.EMail%></td>
                <td><%=per.Mitarbeiter%></td>
                <td>
                    <%=Html.ActionLink("Bearbeiten", "Bearbeiten", New With {.ID = per.PerId}) %>
                    <%=Html.ActionLink("Löschen", "Loeschen", New With {.ID = per.PerId})%>
                </td>
            </tr>
            <%Next %>
       </table>
        <%=Html.ActionLink("Hinzufügen", "Hinzufuegen") %>
    </div>
</body>
</html>
