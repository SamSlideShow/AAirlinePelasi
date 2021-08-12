<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of le08_teil3_ueb.PassagierViewModel)" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Passagier "<%=Model.Passagier.PaId%>" bearbeiten</title>
</head>
<body>
    <div>
        <h1>Passagier "<%=Model.Passagier.PaId%>" bearbeiten</h1>
        <p>Den folgenden Passagier können Sie bearbeiten.</p>

        <%Using Html.BeginForm()%>

            <p>
                <%=Html.HiddenFor(Function(m) Model.Passagier.PaId) %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Passagier.Anrede) %>
                <%=Html.TextBoxFor(Function(m) Model.Passagier.Anrede) %>
                <%=Html.ValidationMessageFor(Function(m) Model.Passagier.Anrede)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Passagier.Name)%>
                <%=Html.TextAreaFor(Function(m) Model.Passagier.Name)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Passagier.Name)  %>
            </p>
             <p>
                <%=Html.LabelFor(Function(m) Model.Passagier.Vorname)%>
                <%=Html.TextAreaFor(Function(m) Model.Passagier.Vorname)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Passagier.Vorname)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Passagier.EMail)%>
                <%=Html.TextBoxFor(Function(m) Model.Passagier.EMail)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Passagier.EMail)  %>
            </p>
            <p>
                <%=Html.LabelFor(Function(m) Model.Passagier.FluIdFK)%>
                <%=Html.TextBoxFor(Function(m) Model.Passagier.FluIdFK)%>
                <%=Html.ValidationMessageFor(Function(m) Model.Passagier.FluIdFK)  %>
            </p>
         

            <p><%=Html.ActionLink("Abbrechen", "Index")%> <input type="submit" value="Speichern"/></p>
        <%End Using%>

    </div>
</body>
</html>
