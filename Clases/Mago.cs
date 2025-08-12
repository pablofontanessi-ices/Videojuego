using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mago : Personaje
    {
        //string VariableNombre = Console.ReadLine();
        //Mago mago1 = new Mago(VariableNombre, 5);
        public Mago(string nombre, int nivel)
        {
            Nombre = nombre;
            Nivel = nivel;
            Vida = 100 + 10 * nivel;
            Ataque = 50 ;
            Defensa = 5;
            listadoCombates = new List<Combate>();
        }

        
    }
}
