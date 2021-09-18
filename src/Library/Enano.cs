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
    public class Enano
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
        private int vida = 110;
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
        public Cuchillo ItemOf;
        public Escudo ItemDef;

        public Enano(string nombre)
        {
            this.Nombre = nombre;
        }

        public void CambiarItemOf(Cuchillo cuchillo)
        {
            this.ItemOf = cuchillo;
        }

        public void QuitarItemOf()
        {
            this.ItemOf = null;
        }
        public void CambiarItemDef(Escudo escudo)
        {
            this.ItemDef = escudo;
        }

        public void QuitarItemDef()
        {
            this.ItemDef = null;
        }

        public int GetAtaque()
        {
            return this.ItemOf.Ataque;
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
            Enano enano1 = new Enano("Roberto");
            this.vida = enano1.vida;
        }
    }
}


