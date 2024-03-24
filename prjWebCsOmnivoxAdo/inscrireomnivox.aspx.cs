using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsOmnivoxAdo
{
    public partial class inscrireOmnivox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInscrire_Click(object sender, EventArgs e)
        {
            //Recuperer les infos saisies 
            string num = txtNumero.Text.Trim();//Numero
            string eml = txtEmail.Text.Trim();//Email
            //Pour la date de naissance mais on recupere l'annee
            string naissance = txtNaissance.Text;
            Int32 anNais = Convert.ToDateTime(naissance).Year; //recuperer l'annee de la dateNaissance
            string mdp = txtMot2passe.Text.Trim();//Mot2passe
            string nom = "";//pour stoker le nom de l'etudiant

            //Se connecter a la base de donnees
            //Etape 1 : Creation de l'objet connection
            SqlConnection mycon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ivanj\\Desktop\\AAA\\teccart\\session-4\\at-1\\prjWebCsOmnivoxAdo\\prjWebCsOmnivoxAdo\\App_Data\\DBOmnivox.mdf;Integrated Security=True;Connect Timeout=30");
            mycon.Open();//ouverture de la connection

            //Etape 2: Creation de l'objet command pour faire la requete sql
            string sql = "SELECT Nom FROM Etudiants ";
            sql = sql + "WHERE Numero = '" + num + "' AND ";
            sql = sql + "Email ='" + eml + "' AND AnneeNaissance = " + anNais;

            SqlCommand mycmd = new SqlCommand(sql,mycon);

            //Etape 3: Creation de l'objet DataReader
            SqlDataReader myRder = mycmd.ExecuteReader();


            //verifier  si le user est n'est pas un etudiant
            if (myRder.Read()==false)//si myreader est vide (aucun enregistrement)
            {//le blocs local

                mycon.Close();
                lblErreur.Text = "Il faut etre etudiant a Teccart pour s'inscrire";
                
            }//le bloc local
            else
            {//etudiant existe
                
                //Verifier si etudiant est deja membre
                nom = myRder["Nom"].ToString();
                myRder.Close();
                sql = "SELECT Numero FROM Membres WHERE Numero = '" + num + "'";
                SqlCommand mycmd2 = new SqlCommand(sql,mycon);
                SqlDataReader myRder2 = mycmd2.ExecuteReader();
                if (myRder2.Read() == true)
                {
                    lblErreur.Text = "Erreur, vous etes deja membre, Contacteez l'administrateur";
                }
                else //donc user est Etudiant et non-membre, alors il faut l'inscrire
                {
                    myRder2.Close();
                    sql = "INSERT INTO Membres(Numero, Nom, Mot2passe, Statut) ";
                    sql = sql + "VALUES('" + num + "','" + nom + "','" + mdp;
                    sql = sql + "','actif') ";
                    
                    SqlCommand mycmd3 = new SqlCommand(sql,mycon);
                    mycmd3.ExecuteNonQuery();
                    mycon.Close();
                    Response.Redirect("indexomnivox.aspx");
                }
            }
        }
    }
}