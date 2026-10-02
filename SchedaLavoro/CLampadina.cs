using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedaLavoro
{
    public class CLampadina : DispositvoSmart
    {

        protected int Luminosità { get; set; }


        public CLampadina(string Nome, string Stanza, int Luminosità) : base(Nome, Stanza)
        {

            this.Luminosità = Luminosità;

        }

        public override string MostraDettagli()
        {
            return $"Nome: {Nome} - Stanza: {Stanza} - Acceso? {Acceso} - Luminosità: {Luminosità}";
        }

    }
}
