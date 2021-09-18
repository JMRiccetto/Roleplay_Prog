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
    }
}