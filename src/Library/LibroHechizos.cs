using System;

namespace Roleplay_Prog.Library
{
    public class LibroHechizos
    {
        public Spell Spell
        {
            get; set;
        }
        public LibroHechizos(Spell aSpell)
        {
            this.Spell = aSpell;
        }

        public int AtaqueSpell()
        {
            return this.Spell.Ataque;
        }
    }
}