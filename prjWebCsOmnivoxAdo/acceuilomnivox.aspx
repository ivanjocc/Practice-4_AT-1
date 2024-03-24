<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="acceuilomnivox.aspx.cs" Inherits="prjWebCsOmnivoxAdo.acceuilOmnivox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        h1{
            /*//pour centrer le texte*/
            text-align:center;
        }
        .tableau {
            border-radius: 10px;
            padding: 4px;
            border-spacing: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>OMNIVOX - INSTITUT TECCART <br />
                Boite de Reception des Messages
            </h1>

            <hr />
            <asp:Label ID="lblInfo" runat="server" Text="Label" Font-Bold="True" ForeColor="#ff0000"></asp:Label>
            <br />

            <asp:Table ID="tabMessages" runat="server" Font-Bold="true" BorderStyle="Solid" GridLines="Both" Width="800px" >

            </asp:Table>
        </div>
    </form>
</body>
</html>
