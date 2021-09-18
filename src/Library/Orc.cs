using System;

namespace Roleplay_Prog.Library
{
    class Orc
    {
        public string Nombre;
        public string Vida;
        public Mazo Mazo;
        public Yelmo Yelmo;

        public Orc(string nombre, string vida, Mazo mazo, Yelmo yelmo)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Mazo = mazo;
            this.Yelmo = yelmo;
        }
    }
}