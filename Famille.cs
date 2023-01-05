using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class Famille
    {
        private string fam_code;
        private string fam_libelle;
        private int fam_nb_med_aut;

        public Famille(string code, string libelle, int nbMedAut)
        {
            this.fam_code = code;
            this.fam_libelle = libelle;
            this.fam_nb_med_aut = nbMedAut;
        }

        public string getCode()
        {
            return this.fam_code;
        }

        public string getLibelle()
        {
            return this.fam_libelle;
        }

        public int getNbMedAut()
        {
            return this.fam_nb_med_aut;
        }

        public void setCode(string leCode)
        {
            this.fam_code = leCode;
        }

        public void setLibelle(string leLibelle)
        {
            this.fam_libelle = leLibelle;
        }

        public void setNbMedAut(int leNbMedAut)
        {
            this.fam_nb_med_aut = leNbMedAut;
        }
    }
}
