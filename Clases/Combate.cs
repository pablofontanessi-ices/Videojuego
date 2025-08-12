using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Combate
    {
        public Personaje Personaje1 { get; set; }
        public Personaje Personaje2 { get; set; }
        public Personaje Ganador { get; private set; }
        public int DuracionTotal { get; set; }
        public int CantDanioPersonaje1 { get; set; }
        public int CantDanioPersonaje2 { get; set; }
        public Combate(Personaje personaje1, Personaje personaje2)
        {
            Personaje1 = personaje1;
            Personaje2 = personaje2;
            Ganador = null;
            DuracionTotal = 0;
            CantDanioPersonaje1 = 0;
            CantDanioPersonaje2 = 0; 
        }
       
    }
}
