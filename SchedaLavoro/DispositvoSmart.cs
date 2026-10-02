using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedaLavoro
{
    public abstract class DispositvoSmart : ISwitchable
    {
        public bool Acceso { get; protected set; }
        public string Nome { get; protected set; }
        public string Stanza { get; protected set; }


        protected DispositvoSmart(string Nome, string Stanza)
        {
            this.Nome = Nome;
            this.Stanza = Stanza;
        }

        public void Accendi()
        {
            Acceso = true;
        }
        public void Spegni()
        {
            Acceso = false;
        }

        public abstract string MostraDettagli();



    }
}
