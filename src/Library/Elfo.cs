using System;

namespace Roleplay_Prog.Library
{
    public class Elfo
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
        private int vida = 90;
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
        public Arco ItemOf;
        public  ItemDef;

        public Elfo(string nombre)
        {
            this.Nombre = nombre;
        }

        public void CambiarItemOf(Arco arco)
        {
            this.ItemOf = arco;
        }

        public void QuitarItemOf()
        {
            this.ItemOf = null;
        }
        public void CambiarItemDef(Armadura armadura)
        {
            this.ItemDef = armadura;
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
            Elfo elfo1 = new elfo("Elfo1");
            this.vida = orco1.vida;
        }
    }
}