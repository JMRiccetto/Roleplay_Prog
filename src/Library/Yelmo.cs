using System;

namespace Roleplay_Prog.Library
{
    public class Yelmo
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
<<<<<<< HEAD
                    this.Defensa = 0;
=======
                    this.defensa = 0;
>>>>>>> master
                } 
            }
        }

        public Yelmo(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}