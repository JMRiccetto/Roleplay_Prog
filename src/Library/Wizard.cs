using System;

namespace Roleplay_Prog.Library
{
    /*
        Para la parte 3 decidimos implementar los metodos a 
        esta clase porque la consideramos la experta
        en la informacion que se necesita para poder llevarlos a cabo.
        A partir de este se rompe el SRP ya que hay varias
        razones de cambio pero lo vimos necesario.
    */
    public class Wizard
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
        public TunicaCuero ItemDef
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
        public void CambiarItemDef(TunicaCuero tunicaCuero)
        {
            this.ItemDef = tunicaCuero;
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
                this.Vida -= danio;
            }
        }

        public void Curarse()
        {
            this.Vida = 80;
        }
    }

}