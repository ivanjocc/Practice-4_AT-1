using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//ADO.NET

namespace prjWebCsOmnivoxAdo
{
    public partial class indexOmnivox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrer_Click(object sender, EventArgs e)
        {
            //Recuperer mes contenues (les numeros et mot2passe) de l'utilisateur
            string numero = txtNumero.Text.Trim();
            string mdp = txtMot2passe.Text.Trim();

            //Se connecter a la base de donnees
            //Etape 1 : Creation de l'objet connection
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at-1\\prjWebCsOmnivoxAdo\\prjWebCsOmnivoxAdo\\App_Data\\DBOmnivox.mdf;Integrated Security=True;Connect Timeout=30";
            mycon.Open();//ouverture de la connection

            //Etape 2: Creation de l'objet command pour faire la requete sql
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            string sql = "SELECT Nom FROM Membres ";
            sql = sql + "WHERE Numero = '" + numero + "' AND ";
            sql = sql + "Mot2passe ='" + mdp + "'";
            mycmd.CommandText = sql;

            //Etape 3: Creation de l'objet DataReader
            SqlDataReader myRder = mycmd.ExecuteReader();


            //verifier mes contenues si ils sont vides ou pas,et verifier si le mdp est mascule ou miniscul(ToUpper)
            if (myRder.Read())//si myreader a trouver un enregistrement
            {//le blocs local

                //Variable global au site web (Le nom et le numero du membres courant)

                Session["Nom"] = myRder["Nom"];//variable globale au site web
                Session["Numero"] = numero;
                mycon.Close();//fermer la connection
                //Redirection vers la page acceuilomnivox.aspx
                Response.Redirect("acceuilomnivox.aspx");
            }//le bloc local
            else
            {
                mycon.Close();
                lblErreur.Text = "Numero ou Mot de passe invalide, Essayez de nouveau";
                //pour vider les champs de remplissage
                txtMot2passe.Text = "";
                //le cursor sur mdp
                txtMot2passe.Focus();
            }
        }
    }
}