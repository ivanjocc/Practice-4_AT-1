<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageTest.aspx.cs" Inherits="prjWebCsOmnivoxAdo.pageTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> LE TABLEAU ASP.NET </h1>
        </div>
    </form>
     <asp:Table ID="tabMessages" runat="server">
         <asp:TableRow runat="server" BackColor="#CCFFFF">
             <asp:TableCell runat="server">Noms</asp:TableCell>
             <asp:TableCell runat="server">Fonctions</asp:TableCell>
         </asp:TableRow>
         <asp:TableRow runat="server">
             <asp:TableCell runat="server">Bill Gates</asp:TableCell>
             <asp:TableCell runat="server">CEO</asp:TableCell>
         </asp:TableRow>
         <asp:TableRow runat="server">
             <asp:TableCell runat="server">Makhlouf</asp:TableCell>
             <asp:TableCell runat="server">Chauffeur</asp:TableCell>
         </asp:TableRow>
         <asp:TableRow runat="server">
             <asp:TableCell runat="server">Khadija</asp:TableCell>
             <asp:TableCell runat="server">Mme CEO</asp:TableCell>
         </asp:TableRow>
    </asp:Table>
</body>
</html>
