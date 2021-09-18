using System;

namespace Roleplay_Prog.Library
{
    class TunicaCuero
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
                    this.ataque = 0;
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
                    this.defensa = 0;
                } 
            }
        }
        public TunicaCuero(int aAtaque, int aDefensa)
        {
            this.Ataque = aAtaque;
            this.Defensa = aDefensa;
        }
    }
}