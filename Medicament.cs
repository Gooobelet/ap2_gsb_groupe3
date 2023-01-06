using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class Medicament
    {
        private string med_depotlegal;
        private string med_nomcommercial;
        private string med_composition;
        private string med_effet;
        private string med_contreindic;
        private string med_prixechantillon;
        private string fam_med_code;
        private List<Workflow> lesEtapes;

        public Medicament(string leMedDepotLegal, string leMedNomCommercial, string leMedComposition, string leMedEffet, string leMedContreinDic, string leMedPrixEchantillon, string laFamilleMed)
        {
            this.med_depotlegal = leMedDepotLegal;
            this.med_nomcommercial = leMedNomCommercial;
            this.med_composition = leMedComposition;
            this.med_effet = leMedEffet;
            this.med_contreindic = leMedContreinDic;
            this.med_prixechantillon = leMedPrixEchantillon;
            this.fam_med_code = laFamilleMed;
            this.lesEtapes = new List<Workflow>();
        }

        public string getDepotLegal()
        {
            return this.med_depotlegal;   
        }

        public string getNomCommercial()
        {
            return this.med_nomcommercial;
        }

        public string getComposition()
        {
            return this.med_composition;
        }

        public string getEffet()
        {
            return this.med_effet;
        }

        public string getContreinDic()
        {
            return this.med_contreindic;
        }

        public string getPrixEchantillon()
        {
            return this.med_prixechantillon;
        }

        public string getFamMed()
        {
            return this.fam_med_code;
        }

        public List<Workflow> getLesEtapes()
        {
            return this.lesEtapes;
        }

        public void setDepotLegal(string leDepotLegal)
        {
            this.med_depotlegal = leDepotLegal;
        }

        public void setNomCommercial(string leNomCommercial)
        {
            this.med_nomcommercial = leNomCommercial;
        }

        public void setComposition(string leComposition)
        {
            this.med_composition = leComposition;
        }

        public void setEffet(string leEffet)
        {
            this.med_effet = leEffet;
        }

        public void setContreinDic(string leContreinDic)
        {
            this.med_contreindic = leContreinDic;
        }

        public void setPrixEchantillon(string lePrixEchantillon)
        {
            this.med_prixechantillon = lePrixEchantillon;
        }

        public void setFamMed(string laFamille)
        {
            this.fam_med_code = laFamille;
        }

        public void ajoutEtapeMed(Workflow uneEtape)
        {
            this.lesEtapes.Add(uneEtape);
        }
    }
}
