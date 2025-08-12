using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arquero : Personaje
    {
        public Arquero(string nombre, int nivel)
        {
            Nombre = nombre;
            Nivel = nivel;
            Vida = 120 + 12 * nivel;
            Ataque = 25;
            Defensa = 10;
            listadoCombates = new List<Combate>();
        }
    }
}
