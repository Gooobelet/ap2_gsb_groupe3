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

            SqlDataReader SqlDateRead = maRequete.ExecuteReader();

            while (SqlDateRead.Read())
            {
                string depotLegal = SqlDateRead["MED_DEPOTLEGAL"].ToString();
                string nomCommercial = SqlDateRead["MED_NOMCOMMERCIAL"].ToString();
                string codeFamille = SqlDateRead["FAM_CODE"].ToString();
                string composition = SqlDateRead["MED_COMPOSITION"].ToString();
                string effets = SqlDateRead["MED_EFFETS"].ToString();
                string contreIncic = SqlDateRead["MED_CONTREINDIC"].ToString();
                string prixEchantillon = SqlDateRead["MED_PRIXECHANTILLON"].ToString();

                Globale.lesMedicaments.Add(depotLegal, new Medicament(depotLegal, nomCommercial, composition, effets, contreIncic, prixEchantillon, codeFamille));
            }
        }

        public void getLesFamilles()
        {
            Globale.lesFamilles = new Dictionary<string, Famille>();
            SqlCommand maRequete = new SqlCommand("prc_getFamilles", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDateRead = maRequete.ExecuteReader();

            while (SqlDateRead.Read())
            {
                string code = SqlDateRead["FAM_CODE"].ToString();
                string libelle = SqlDateRead["FAM_LIBELLE"].ToString();

                Globale.lesFamilles.Add(code, new Famille(code, libelle));
            }
        }
    }
}
