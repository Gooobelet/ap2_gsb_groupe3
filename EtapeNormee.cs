using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace gsb_gesAMM_APP
{
    class EtapeNormee : Etape
    {
        private string norme;
        private DateTime dateNorme;

        public EtapeNormee(string norme, DateTime dateNorme, int num,string libelle) : base(num,libelle)
        {
            this.norme = norme;
            this.dateNorme = dateNorme;
        }

        public string getNorme()
        {
            return this.norme;
        }

        public DateTime getDateNorme()
        {
            return this.dateNorme;
        }

        public void setNorme(string norme)
        {
            this.norme = norme;
        }

        public void setDateNorme(DateTime dateNorme)
        {
            this.dateNorme= dateNorme;
        }
    }
}
