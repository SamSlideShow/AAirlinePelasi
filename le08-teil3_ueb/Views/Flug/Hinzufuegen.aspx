<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.FlugViewModel)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Neuer Flug</title>
</head>
<body>
    <div>
        <h1>Neuen Flug hinzufügen</h1>
        <p>Sie können einen neuen Flug hinzfügen.</p>

        <%Using Html.BeginForm()%>

            <p>
                <%=Html.HiddenFor(Function(m) Model.Flug.FluId) %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Flug.PerId) %>
                <%=Html.TextBoxFor(Function(m) Model.Flug.PerId) %>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.PerId)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Flug.Flugziel)%>
                <%=Html.TextAreaFor(Function(m) Model.Flug.Flugziel)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.Flugziel)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Flug.Abflugsort)%>
                <%=Html.TextAreaFor(Function(m) Model.Flug.Abflugsort)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.Abflugsort)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Flug.Datum)%>
                <%=Html.TextBoxFor(Function(m) Model.Flug.Datum, "{0:dd.MM.yyyy}")%>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.Datum)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Flug.Startzeitpunkt)%>
                <%=Html.TextBoxFor(Function(m) Model.Flug.Startzeitpunkt)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.Startzeitpunkt)  %>
            </p>
             <p>
                <%=Html.LabelFor(Function(m) Model.Flug.Landung)%>
                <%=Html.TextBoxFor(Function(m) Model.Flug.Landung)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.Landung)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Flug.AnzahlPassagiere)%>
                <%=Html.TextBoxFor(Function(m) Model.Flug.AnzahlPassagiere)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Flug.AnzahlPassagiere)  %>
            </p>

            <p><%=Html.ActionLink("Abbrechen", "Index")%> <input type="submit" value="Speichern"/></p>
        <%End Using%>
        
    </div>
</body>
</html>
