using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class Famille
    {
        private string fam_code;
        private string fam_libelle;

        public Famille(string code, string libelle)
        {
            this.fam_code = code;
            this.fam_libelle = libelle;
        }

        public string getCode()
        {
            return this.fam_code;
        }

        public string getLibelle()
        {
            return this.fam_libelle;
        }

        public void setCode(string leCode)
        {
            this.fam_code = leCode;
        }

        public void setLibelle(string leLibelle)
        {
            this.fam_libelle = leLibelle;
        }
    }
}
