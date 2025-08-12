using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public List<Combate> listadoCombates { get; set; }

        public virtual void Atacar(Personaje objetivo)
        {
            int danio = Ataque - objetivo.Defensa;
            objetivo.RecibirDanio(danio);
        }

        public void RecibirDanio(int danio)
        {
            Vida -= danio;
            if (Vida < 0)
            {
                Vida = 0;
            }
        }
    }
}
