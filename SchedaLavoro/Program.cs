using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedaLavoro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DispositvoSmart> elencodispositivi = new List<DispositvoSmart>();

            CLampadina l = new CLampadina("LampadinaBagno", "Bagno", 80);
            CTermostato t = new CTermostato("TermostatoSalotto", "Salotto", 21);

            elencodispositivi.Add(l);
            elencodispositivi.Add(t);


            foreach (DispositvoSmart d in elencodispositivi)
            {
                d.Accendi();
                Console.WriteLine(d.MostraDettagli());
            }

            List<ISwitchable> elencoSwitchable = new List<ISwitchable>();

            CLampadina l2 = new CLampadina("LampadinaCucina", "Cucina", 50);
            CTermostato t2 = new CTermostato("TermostatoCamera", "Camera", 19);
            CAllarme allarme = new CAllarme();

            elencoSwitchable.Add(l2);
            elencoSwitchable.Add(t2);
            elencoSwitchable.Add(allarme);

            foreach (ISwitchable s in elencoSwitchable)
            {
                s.Accendi();
                Console.WriteLine($"Acceso: {s.Acceso}");
            }
        }
    }
}
