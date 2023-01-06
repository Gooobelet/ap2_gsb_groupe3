using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class Decision
    {
        private int id;
        private string libelle;

        public Decision(int leId, string leLibelle)
        {
            this.id = leId;
            this.libelle = leLibelle;
        }

        public int getLeId()
        {
            return this.id;
        }

        public string getLeLibelle()
        {
            return this.libelle;
        }

        public void setLeId(int leId)
        {
            this.id = leId;
        }

        public void setLeLibelle(string leLibelle)
        {
            this.libelle = leLibelle;
        }
    }
}
