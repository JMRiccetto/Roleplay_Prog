using System;

namespace Roleplay_Prog.Library
{
    class Wizard
    {
        public string Nombre;
        public int Vida;
        public LibroHechizos LibroHechizos;
        public TunicaCuero ItemDef;

        public Wizard (string aName, int aVida, LibroHechizos aLibroHechizos, TunicaCuero aItemDef)
        {
            Nombre = aName;
            Vida = aVida;
            LibroHechizos = aLibroHechizos;
            ItemDef = aItemDef;
        }
    }

}