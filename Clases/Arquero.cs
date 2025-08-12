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

        public override void Atacar(Personaje objetivo)
        {
            Random random = new Random();
            
            int danio = Ataque - objetivo.Defensa;
            if(random.NextDouble() <= 0.25)
            { 
                objetivo.RecibirDanio(danio * 2);
            }
            else
            {
                objetivo.RecibirDanio(danio);
            }
        }
    }
}
