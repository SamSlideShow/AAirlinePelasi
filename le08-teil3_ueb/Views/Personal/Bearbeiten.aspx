<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.PersonalViewModel)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Personal "<%=Model.Personal.PerId%>" bearbeiten</title>
</head>
<body>
    <div>
        <h1>Mitarbeiter "<%=Model.Personal.PerId%>" bearbeiten</h1>
        <p>Den folgenden Mitarbeiter können Sie bearbeiten.</p>

        <%Using Html.BeginForm()%>

            <p>
                <%=Html.HiddenFor(Function(m) Model.Personal.PerId) %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Personal.Anrede) %>
                <%=Html.TextBoxFor(Function(m) Model.Personal.Anrede) %>
                <%=Html.ValidationMessageFor(Function(m) Model.Personal.Anrede)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Personal.Name)%>
                <%=Html.TextAreaFor(Function(m) Model.Personal.Name)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Personal.Name)  %>
            </p>
             <p>
                <%=Html.LabelFor(Function(m) Model.Personal.Vorname)%>
                <%=Html.TextAreaFor(Function(m) Model.Personal.Vorname)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Personal.Vorname)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Personal.EMail)%>
                <%=Html.TextBoxFor(Function(m) Model.Personal.EMail)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Personal.EMail)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Personal.Mitarbeiter)%>
                <%=Html.CheckBoxFor(Function(m) Model.Personal.Mitarbeiter)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Personal.Mitarbeiter)%>
            </p>
         

            <p><%=Html.ActionLink("Abbrechen", "Index")%> <input type="submit" value="Speichern"/></p>
        <%End Using%>

    </div>
</body>
</html>
