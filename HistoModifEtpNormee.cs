using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class HistoModifEtpNormee
    {
        private int idModif;
        private DateTime dateModif;
        private string libelle;
        private string norme;
        private DateTime dateNorme;

        public HistoModifEtpNormee(int leIdModif, DateTime laDateModif, string leLibelle, string laNorme, DateTime laDateNorme)
        {
            this.idModif = leIdModif;
            this.dateModif = laDateModif;
            this.libelle = leLibelle;
            this.norme = laNorme;
            this.dateNorme = laDateNorme;
        }

        public int getLeIdModif()
        {
            return this.idModif;
        }

        public DateTime getLaDateModif()
        {
            return this.dateModif;
        }

        public string getLeLibelle()
        {
            return this.libelle;
        }

        public string getLaNorme()
        {
            return this.norme;
        }

        public DateTime getLaDateNorme()
        {
            return this.dateNorme;
        }
    }
}
