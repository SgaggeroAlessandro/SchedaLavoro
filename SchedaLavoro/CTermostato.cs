using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedaLavoro
{
    public class CTermostato : DispositvoSmart
    {
        protected int Temperatura { get; set; }


        public CTermostato(string Nome, string Stanza, int Temperatura) : base(Nome, Stanza)
        {

            this.Temperatura = Temperatura;

        }

        public override string MostraDettagli()
        {
            return $"Nome: {Nome} - Stanza: {Stanza} - Acceso? {Acceso} - Temperatura: {Temperatura}";
        }

    }

}
