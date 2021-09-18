using System;

namespace Roleplay_Prog.Library
{
    public class Orco
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
        private int vida = 130;
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
        public Mazo ItemOf;
        public Yelmo ItemDef;

        public Orco(string nombre)
        {
            this.Nombre = nombre;
        }

        public void CambiarItemOf(Mazo mazo)
        {
            this.ItemOf = mazo;
        }

        public void QuitarItemOf()
        {
            this.ItemOf = null;
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
            return this.ItemOf.Ataque;
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
            Orco orco1 = new Orco("Jose");
            this.vida = orco1.vida;
        }
    }
}