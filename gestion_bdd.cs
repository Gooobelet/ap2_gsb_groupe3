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
                int nbMedAut;

                if (SqlDataRead["nbMedAutorisé"].ToString() == "")
                {
                    nbMedAut = 0;
                }
                else
                {
                    nbMedAut = Convert.ToInt32(SqlDataRead["nbMedAutorisé"]);
                }

                Globale.lesFamilles.Add(code, new Famille(code, libelle,nbMedAut));
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

        public void getLesWorkflows()
        {
            SqlCommand maRequete = new SqlCommand("prc_getWorkflows", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                Etape uneEtape = null;
                Decision uneDecision = null;
                DateTime uneDateDec = DateTime.MaxValue;
                bool trouve = false;
                int idx = 0;

                while (!trouve && idx < Globale.lesEtapes.Count)
                {
                    if (Globale.lesEtapes[idx].getNum() == Convert.ToInt32(SqlDataRead["numEtape"]))
                    {
                        uneEtape = Globale.lesEtapes[idx];
                        trouve = true;
                    }
                    else
                    {
                        idx++;
                    }
                }

                if (SqlDataRead["idDecision"].ToString() != "")
                {
                    bool trouveDec = false;
                    int idxDec = 0;

                    while (!trouveDec && idxDec < Globale.lesDecisions.Count)
                    {
                        if (Globale.lesDecisions[idxDec].getLeId() == Convert.ToInt32(SqlDataRead["idDecision"]))
                        {
                            uneDecision = Globale.lesDecisions[idxDec];
                            uneDateDec = Convert.ToDateTime(SqlDataRead["dateDecision"]);
                            trouveDec = true;
                        }
                        else
                        {
                            idxDec++;
                        }
                    }
                }

                Globale.lesMedicaments[Convert.ToString(SqlDataRead["MED_DL"])].ajoutEtapeMed(new Workflow(uneDateDec, uneEtape, uneDecision));
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

        public void setDecisionEtape(int numEtape, string medDL, DateTime dateDec, int idDec)
        {
            SqlCommand maRequete = new SqlCommand("prc_setDecisionEtape", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter paramNumEtape = new SqlParameter("@numEtape", System.Data.SqlDbType.Int);
            paramNumEtape.Value = numEtape;

            SqlParameter paramMedDL = new SqlParameter("@medDL", System.Data.SqlDbType.VarChar, 100);
            paramMedDL.Value = medDL;

            SqlParameter paramDateDec = new SqlParameter("@dateDec", System.Data.SqlDbType.DateTime);
            paramDateDec.Value = dateDec;

            SqlParameter paramIdDec = new SqlParameter("@idDec", System.Data.SqlDbType.Int);
            paramIdDec.Value = idDec;

            maRequete.Parameters.Add(paramNumEtape);
            maRequete.Parameters.Add(paramMedDL);
            maRequete.Parameters.Add(paramIdDec);
            maRequete.Parameters.Add(paramDateDec);

            maRequete.ExecuteNonQuery();
        }

        public void setMaJEtapeNormee(int numEtape, string laNorme, DateTime laDateNorme)
        {
            SqlCommand maRequete = new SqlCommand("prc_maj_etapenormee", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter paramNumEtape = new SqlParameter("@numEtape", System.Data.SqlDbType.Int);
            paramNumEtape.Value = numEtape;

            SqlParameter paramNorme = new SqlParameter("@etpNorme", System.Data.SqlDbType.VarChar, 20);
            paramNorme.Value = laNorme;

            SqlParameter paramDateNorme = new SqlParameter("@etpNormeDate", System.Data.SqlDbType.DateTime);
            paramDateNorme.Value = laDateNorme;

            maRequete.Parameters.Add(paramNumEtape);
            maRequete.Parameters.Add(paramNorme);
            maRequete.Parameters.Add(paramDateNorme);

            maRequete.ExecuteNonQuery();
        }

        public void getHistModifEtpNormee()
        {
            Globale.lhistoModifEtpNormee = new List<HistoModifEtpNormee>();

            SqlCommand maRequete = new SqlCommand("prc_getHistoModifEtpNormee", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            maRequete.ExecuteNonQuery();

            SqlDataReader SqlDataRead = maRequete.ExecuteReader();

            while (SqlDataRead.Read())
            {
                int idModif = Convert.ToInt32(SqlDataRead["idModif"]);
                DateTime dateModif = Convert.ToDateTime(SqlDataRead["dateModif"]);
                string libelle = SqlDataRead["etpLibelle"].ToString();
                string norme = SqlDataRead["etpNorme"].ToString();
                DateTime dateNorme = Convert.ToDateTime(SqlDataRead["etpDateNorme"]);


                Globale.lhistoModifEtpNormee.Add(new HistoModifEtpNormee(idModif, dateModif, libelle, norme, dateNorme ));
            }

            SqlDataRead.Close();
        }

        public void setMedicament(string depotLegale, string nomCommercial, string famCode, string composition, string effets, string contreIndication, double prixEchantillon)
        {
            SqlCommand maRequete = new SqlCommand("prc_ajout_medicament", this.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter paramDepotLegale = new SqlParameter("@depotlegale", System.Data.SqlDbType.VarChar, 100);
            paramDepotLegale.Value = depotLegale;

            SqlParameter paramNomCommercial = new SqlParameter("@nomcommercial", System.Data.SqlDbType.VarChar, 100);
            paramNomCommercial.Value = nomCommercial;

            SqlParameter paramFamCode = new SqlParameter("@famcode", System.Data.SqlDbType.VarChar, 6);
            paramFamCode.Value = famCode;

            SqlParameter paramComposition = new SqlParameter("@composition", System.Data.SqlDbType.VarChar, 255);
            paramComposition.Value = composition;

            SqlParameter paramEffets = new SqlParameter("@effets", System.Data.SqlDbType.Text);
            paramEffets.Value = effets;

            SqlParameter paramContreIndication = new SqlParameter("@contreindication", System.Data.SqlDbType.Text);
            paramContreIndication.Value = contreIndication;

            SqlParameter paramPrixEchantillon = new SqlParameter("@prixechantillon", System.Data.SqlDbType.Money);
            paramPrixEchantillon.Value = prixEchantillon;

            maRequete.Parameters.Add(paramDepotLegale);
            maRequete.Parameters.Add(paramNomCommercial);
            maRequete.Parameters.Add(paramFamCode);
            maRequete.Parameters.Add(paramComposition);
            maRequete.Parameters.Add(paramEffets);
            maRequete.Parameters.Add(paramContreIndication);
            maRequete.Parameters.Add(paramPrixEchantillon);

            maRequete.ExecuteNonQuery();
        }
    }
}
