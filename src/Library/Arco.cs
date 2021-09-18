using System;

namespace Roleplay_Prog.Library
{
    public class Arco
    {
        private int ataque;
        public int Ataque
        {
            get
            {
                return this.Ataque;
            }
            set
            {
                if(value >=0)
                {
                    this.Ataque = value;
                }
                else
                {
                    this.Ataque = 0;
                }
            }
        }
        private int defensa;
        public int Defensa
        {
            get
            {
                return this.Defensa;
            }
            set
            {
                if(value >=0)
                {
                    this.Defensa = value;
                }
                else
                {
                    this.Defensa = 0;
                } 
            }
        }

        public Arco(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}