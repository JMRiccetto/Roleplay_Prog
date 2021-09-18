using System;

namespace Roleplay_Prog.Library
{
    public class Spell
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
    }
}