using System;

namespace Roleplay_Prog.Library
{
    class Wizard
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }
        private int vida = 80;
        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                if(value >=0)
                {
                    this.vida = value;
                }
                else
                {
                    this.vida = 0;
                }
            }
        }
        public LibroHechizos LibroHechizos
        {
            get; set;
        }
        public TunicaCuero Itemdef
        {
            get; set;
        }
        public Wizard(string nombre)
        {
            this.Nombre = nombre;
        }

        public void CambiarLibroHechizos(LibroHechizos libroHechizos)
        {
            this.LibroHechizos = libroHechizos;
        }

        public void QuitarLibroHechizos()
        {
            this.LibroHechizos = null;
        }
        public void CambiarItemDef(Yelmo yelmo)
        {
            this.ItemDef = yelmo;
        }

        public void QuitarItemDef()
        {
            this.ItemDef = null;
        }

        public int GetAtaque()
        {
            return this.LibroHechizos.AtaqueSpell();
        }

        public void DanioRecibido(int danio)
        {
            if(this.ItemDef.Defensa < danio)
            {
                danio -= this.ItemDef.Defensa;
                this.vida -= danio;
            }
        }

        public void Curarse()
        {
            Wizard wizard1 = new Wizard("Harry");
            this.vida = wizard1.vida;
        }
    }

}