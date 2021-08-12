<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="utf-8" />
    <title>Anmeldeformular</title>
    <link rel="stylesheet" type="text/css" href="css/main.css" />
    <img src="../images/Logo.jpeg" width="125" height="125" alt="Logo" text align="right"
</head>
<body>
    <h1>Mein Konto</h1>
    <h2>Name</h2>

    <div>
        <%=Html.ActionLink("Startseite", "Index")%>
        <%=Html.ActionLink("Eigene Flüge", "EigeneFluege") %>
    </div>

    <p>E-Mail Adresse oder Passwort ändern:</p>
    <p>
        <label for=" txtEmail" id="lblEmail">
            E-Mail:
            <input value="" type="text" />
        </label>
    </p>

    <p>
        <label for=" txtPasswort" id="lblPasswort">
            Passwort:
            <input value="" type="password" />
        </label>
    </p>
    <p>Erneut eingeben:</p>
    <p>
        <label for=" txtPasswort" id="lblPasswort">
            Passwort:
            <input value="" type="password" />
        </label>
    </p>
    <p>
        <button><a href="Passagierkonto.html">Speichern</a></button>
        <button><a href="Hauptfenster_Passagier.html">Abbrechen</a></button>
    </p>

    <footer>
        <p>Carina Lammel, Charlene Pennig, Samuel Simon</p>
    </footer>

</body>
</html>
