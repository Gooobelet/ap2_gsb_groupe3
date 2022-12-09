using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace gsb_gesAMM_APP
{
    class gestion_bdd
    {
        private SqlConnection cnx;

        public gestion_bdd(string nomServeur, string nomBDD)
        {
            this.cnx = new SqlConnection(); 
            this.cnx.ConnectionString = "Data Source="+nomServeur+"; Initial Catalog="+nomBDD+";Integrated Security=True;MultipleActiveResultSets=True";
            this.cnx.Open();
        }

        public void getLesMedicaments()
        {
            Globale.lesMedicaments = new Dictionary<string, Medicament>();

            SqlCommand maRequete = new SqlCommand("prc_getMedicaments", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                string depotLegal = SqlDataRead["MED_DEPOTLEGAL"].ToString();
                string nomCommercial = SqlDataRead["MED_NOMCOMMERCIAL"].ToString();
                string codeFamille = SqlDataRead["FAM_CODE"].ToString();
                string composition = SqlDataRead["MED_COMPOSITION"].ToString();
                string effets = SqlDataRead["MED_EFFETS"].ToString();
                string contreIncic = SqlDataRead["MED_CONTREINDIC"].ToString();
                string prixEchantillon = SqlDataRead["MED_PRIXECHANTILLON"].ToString();

                Globale.lesMedicaments.Add(depotLegal, new Medicament(depotLegal, nomCommercial, composition, effets, contreIncic, prixEchantillon, codeFamille));
            }

            SqlDataRead.Close();
        }

        public void getLesFamilles()
        {
            Globale.lesFamilles = new Dictionary<string, Famille>();

            SqlCommand maRequete = new SqlCommand("prc_getFamilles", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                string code = SqlDataRead["FAM_CODE"].ToString();
                string libelle = SqlDataRead["FAM_LIBELLE"].ToString();

                Globale.lesFamilles.Add(code, new Famille(code, libelle));
            }

            SqlDataRead.Close();
        }

        public void getLesEtapes()
        {
            Globale.lesEtapes = new List<Workflow>();
        }

        public void getLesDecisions()
        {
            Globale.lesDecisions = new List<Decision>();

            SqlCommand maRequete = new SqlCommand("prc_getDesisions", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                int id = Convert.ToInt32(SqlDataRead["DCS_ID"]);
                string libelle = SqlDataRead["DCS_LIBELLE"].ToString();

                Globale.lesDecisions.Add(new Decision(id, libelle));
            }

            SqlDataRead.Close();
        }

        public bool verifConnexion(string id, string mdp)
        {
            bool verifCnx = false;
            SqlCommand maRequete = new SqlCommand("prc_getUtilisateurs", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                string idUti = SqlDataRead["UTI_NOM_UTILISATEUR"].ToString();
                string mdpUti = SqlDataRead["UTI_MDP_UTILISATEUR"].ToString();

                if (idUti == id && mdpUti == mdp)
                {
                    verifCnx = true;
                }
            }

            SqlDataRead.Close();

            return verifCnx;
        }
    }
}
