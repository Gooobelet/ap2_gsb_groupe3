using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class Workflow
    {
        private DateTime dateDecision;
        private int numEtape;
        private int idDecision;

        public Workflow(DateTime laDateDecision, int leNumEtap, int leIdDecision)
        {
            this.dateDecision = laDateDecision;
            this.numEtape = leNumEtap;
            this.idDecision = leIdDecision;
        }

        public DateTime getDateDecision()
        {
            return this.dateDecision;
        }

        public int getNumEtape()
        {
            return this.numEtape;
        }

        public int getIdDecision()
        {
            return this.idDecision;
        }

        public void setDateDecision(DateTime laDateDecision)
        {
            this.dateDecision = laDateDecision;
        }

        public void setNumEtape(int leNumEtape)
        {
            this.numEtape = leNumEtape;
        }

        public void setIdDecision(int leIdDecision)
        {
            this.idDecision = leIdDecision;
        }
    }
}
