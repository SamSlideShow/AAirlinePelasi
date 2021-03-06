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
         <%=Html.ActionLink("Eigene Flüge", "EigeneFluege") %>
         <%=Html.ActionLink("Mein Konto", "MeinKonto") %>
    </div>

    <h2>Über Uns</h2>
    <p>
        Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum.<br /> Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.
        At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.
    </p>
    <h2>Impressum von Pelasi Airlines</h2>
    <p>
        <strong>Pelasi Airlines GmbH</strong> <br />
        <strong>Berliner Straße 15</strong> <br />
        <strong>10115 Berlin</strong>
    </p> <br />

    <p>
        <strong>Tel +49 (0)30/ 746 43-500</strong><br />
        <strong>Fax +49 (0)30/ 746 43-533</strong><br />
        <strong>Website:</strong>www.pelasi-airlines.de<br />
        <strong>E-Mails an:</strong>info@pealsi-airlines.de
    </p>

    <p>Jugendschutzbeauftragter: Rechtsanwalt Tobias Reichelt, JBB Rechtsanwälte</p>
    <p>
        Geschäftsführung: Sebastian Schiffer (CEO), Martina Winter (COO) <br />Veratwortlich i.S.v. §55 Abs.2 RStV: Sahra Schmidt, <br /> Berliner Straße 15, 10115 Berlin
    </p>
    <p>Alle auf dieser Website gennanten Produktnamen, Produktbezeichnungen und Logos sind eingetragene Warenzeichen und Eigentum der jeweiligen Rechteinhaber.</p>

    <footer>
        <p>Carina Lammel, Charlene Pennig, Samuel Simon</p>
    </footer>

</body>
</html>
