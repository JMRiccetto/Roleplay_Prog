using System;

namespace Roleplay_Prog.Library
{
    public class Orco
    {
        public string Nombre;
        public int Vida;
        public Mazo Mazo;
        public Yelmo Yelmo;

        public Orco(string nombre, int vida, Mazo mazo, Yelmo yelmo)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Mazo = mazo;
            this.Yelmo = yelmo;
        }
    }
}