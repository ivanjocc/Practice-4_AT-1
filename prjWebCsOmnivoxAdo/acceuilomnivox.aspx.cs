using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace prjWebCsOmnivoxAdo
{
    public partial class acceuilOmnivox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int16 nbMsgs = 0;//compteur du nombre de messages
            lblInfo.Text = "Bienvenue " + Session["Nom"];
            



            //Se connecter a la BD pour recuperer les messages envoyes a ce membre(ctd les membre loges)

            //Etape 1 : Creation de l'objet connection
            SqlConnection mycon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at-1\\prjWebCsOmnivoxAdo\\prjWebCsOmnivoxAdo\\App_Data\\DBOmnivox.mdf;Integrated Security=True;Connect Timeout=30");
            mycon.Open();//ouverture de la connection

            //Etape 2: Creation de l'objet command pour faire la requete sql
            string sql = "SELECT Messages.Titre, Membres.Nom, Messages.IDMessage, Messages.Nouveau ";
            sql = sql + "FROM Membres, Messages ";
            sql = sql + "WHERE Membres.Numero = Messages.Envoyeur AND Messages.Receveur = '" + Session["Numero"].ToString() + "'";

            //Creation du tableau
            //Creation de la premiere ligne
            TableRow maLigne = new TableRow();
            maLigne.BackColor = Color.LimeGreen;
            //Creer une celule
            TableCell maCellule = new TableCell();
            maCellule.Text = "Titre Messages";
            maLigne.Cells.Add(maCellule);
            
            maCellule = new TableCell();
            maCellule.Text = "Provenances";
            maLigne.Cells.Add(maCellule);

            maCellule = new TableCell();
            maCellule.Text = "Actions";
            maLigne.Cells.Add(maCellule);

            //Ajouter la ligne dans le tableau
            tabMessages.Rows.Add(maLigne);


            SqlCommand mycmd = new SqlCommand(sql, mycon);

            //Etape 3: Creation de l'objet DataReader
            SqlDataReader myRder = mycmd.ExecuteReader();

            while (myRder.Read() == true)
            {
                //Creation de la premiere ligne
                maLigne = new TableRow();
                //maLigne.BackColor = Color.LimeGreen;
                maCellule = new TableCell();
                maCellule.Text = myRder["Titre"].ToString();
                maLigne.Cells.Add(maCellule);

                maCellule = new TableCell();
                maCellule.Text = myRder["Nom"].ToString();
                maLigne.Cells.Add(maCellule);

                Int32 refMsg = Convert.ToInt32(myRder["IDMessage"]);

                maCellule = new TableCell();
                maCellule.Text = "<a href='lireMessage.aspx?IDmsg='" + refMsg + ">Lire</a> &nbsp; &nbsp;";
                maCellule.Text += "<a href='effacerMessage.aspx?IDmsg='" + refMsg + ">Effacer</a>";
                maLigne.Cells.Add(maCellule);

                // ajouter la ligne dans le tableau
                // verifier si le message est nouveau, changer la couleur de la ligne

                if (myRder["Nouveau"].ToString() == "True")
                {
                    maLigne.BackColor = Color.LightYellow;
                }
                tabMessages.Rows.Add(maLigne);

            }
            myRder.Close();
            mycon.Close();
            nbMsgs++;

        }
    }
}