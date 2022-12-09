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
            Globale.lesEtapes = new List<Etape>();

            SqlCommand maRequete = new SqlCommand("prc_getEtapes", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                int num = Convert.ToInt32(SqlDataRead["ETP_NUM"]);
                string libelle = SqlDataRead["ETP_LIBELLE"].ToString();
                string norme = SqlDataRead["ETP_NORME"].ToString();
                DateTime dateNorme = DateTime.MaxValue;

                if (SqlDataRead["ETP_DATE_NORME"].ToString() != "")
                {
                    dateNorme = Convert.ToDateTime(SqlDataRead["ETP_DATE_NORME"]);
                }

                if (norme == "" && dateNorme == DateTime.MaxValue)
                {
                    Globale.lesEtapes.Add(new Etape(num, libelle));
                }
                else
                {
                    Globale.lesEtapes.Add(new EtapeNormee(norme,dateNorme,num,libelle));
                }
            }

            SqlDataRead.Close();
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
                string idUti = SqlDataRead["nomUtilisateur"].ToString();
                string mdpUti = SqlDataRead["mdpUtilisateur"].ToString();

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
