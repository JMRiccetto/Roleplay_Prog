using System;

namespace Roleplay_Prog.Library
{
    public class TunicaCuero
    {
        private int ataque;
        public int Ataque
        {
            get
            {
                return this.ataque;
            }
            set
            {
                if(value >=0)
                {
                    this.ataque = value;
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
                return this.defensa;
            }
            set
            {
                if(value >=0)
                {
                    this.defensa = value;
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