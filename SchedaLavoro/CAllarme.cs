using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedaLavoro
{
    public class CAllarme : ISwitchable
    {
        public bool Acceso { get; private set; }
        public void Accendi() { Acceso = true; }
        public void Spegni() { Acceso = false; }
    }
}
