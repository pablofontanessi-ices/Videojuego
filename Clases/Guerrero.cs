using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Guerrero : Personaje
    {
        public Guerrero(string nombre, int nivel ) {
            Nombre = nombre;
            Nivel = nivel;
            Vida = 150 + 15 * nivel;
            Ataque = 30;
            Defensa = 15;
            listadoCombates = new List<Combate>();
        }
    }
}
