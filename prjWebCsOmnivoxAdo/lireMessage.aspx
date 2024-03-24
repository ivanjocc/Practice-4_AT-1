<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lireMessage.aspx.cs" Inherits="prjWebCsOmnivoxAdo.lireMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>OMNIVOX - INSTITUT TECCART <br />
                Page de lecture de un message
            </h1>

            <table>
                <tr>
                    <td>Titre : </td>
                    <td>
                        <asp:Label ID="lblTitre" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="#33CC33"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>De la part de : </td>
                    <td>
                        <asp:Label ID="lblEnvoyeur" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="#33CC33"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Date d'envoi : </td>
                    <td>
                        <asp:Label ID="lblDate" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="#33CC33"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Contenu message : </td>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="#33CC33"></asp:Label>
                    </td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
