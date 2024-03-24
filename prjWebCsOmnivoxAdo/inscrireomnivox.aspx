<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscrireomnivox.aspx.cs" Inherits="prjWebCsOmnivoxAdo.inscrireOmnivox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        h1,h2{
            text-align:center;
        }
        #tableau{
            background-color:aquamarine;
            font-weight:bold;
            width:500px;
            margin:auto;
            border-radius:5px;
            padding:4px;
            border-spacing:4px;
            color:black;
        }
        body{
            background-color:aliceblue;
        }
        .boite{
            width:250px;
            color:darkblue;
            border-radius:5px;
            font-weight:bold;
        }

        .bouton{
            width:200px;
            color:orange;
            border-radius:2px;
            font-weight:bold;
            background-color:black
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>OMNIVOX - TECCART</h1>
            <h2>INSCRIPTION DU NOUVEAU MEMBRE</h2>
            <hr />
            <table id="tableau">
                <tr>
                    <td>Numero Etudiant : </td>
                    <td>
                        <asp:TextBox ID="txtNumero" CssClass="boite" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="reqNumero" runat="server" ErrorMessage="Erreur : Numero obligatoire" ControlToValidate="txtNumero" Font-Bold="True" Text="*"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>

                <tr>
                    <td>Couriel Etudiant : </td>
                    <td>
                        <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="boite" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="reqEmail" runat="server" ErrorMessage="Erreur : Email obligatoire" ControlToValidate="txtEmail" Font-Bold="True" Text="*"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>

                <tr>
                    <td>Naissance Etudiant : </td>
                    <td>
                        <asp:TextBox ID="txtNaissance" TextMode="Date" CssClass="boite" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="reqNaissance" runat="server" ErrorMessage="Erreur : Date Naissance obligatoire" ControlToValidate="txtNaissance" Font-Bold="True" Text="*"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>

                <tr>
                    <td>Mode de passe Membre : </td>
                    <td>
                        <asp:TextBox ID="txtMot2passe" TextMode="Password" CssClass="boite" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="reqMot2passe" runat="server" ErrorMessage="Erreur : Mot de passe obligatoire" ControlToValidate="txtMot2passe" Font-Bold="True" foreColor="Red" Text="*"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>

                <tr>
                    <td>Confirmer Mot de passe : </td>
                    <td>
                        <asp:TextBox ID="txtMot2passe2" TextMode="Password" CssClass="boite" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="reqMot2passe2" runat="server" ErrorMessage="Erreur : Mot de passe 2 obligatoire" ControlToValidate="txtMot2passe2" Font-Bold="True" Text="*"></asp:RequiredFieldValidator>

                        <asp:CompareValidator ID="cmpMot2passe" runat="server" ErrorMessage="Erreur : Les deux mots de passe non identique" ControlToValidate="txtMot2passe2" ControlToCompare="txtMot2passe" ForeColor="Red" Text="*"></asp:CompareValidator>
                    </td>
                    
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnInscrire" CssClass="bouton" runat="server" Text="Inscrire Membre" onClick="btnInscrire_Click"/>
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btnEffacer" CssClass="bouton" runat="server" Text="Effacer/Recommencer" />
                        
                    </td> 
                </tr>

                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblErreur" runat="server" font-Bold="true" ForeColor="Red" ></asp:Label>
                    </td> 
                </tr>

                <tr>
                    <td colspan="3">
                        <asp:ValidationSummary ID="ValidationSummary1" Font-Bold="true" ForeColor="Red" runat="server" />
                    </td>
                    
                </tr>

            </table>

        </div>
    </form> 

</body>
</html>
