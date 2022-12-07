using System;
using System.Collections.Generic;
using System.Text;

namespace gsb_gesAMM_APP
{
    class Globale
    {
        public static Dictionary<string, Famille> lesFamilles;
        public static Dictionary<string, Medicament> lesMedicaments;
        public static List<Workflow> lesEtapes;
        public static List<Decision> lesDecisions;
        public static gestion_bdd bdd;
    }
}
