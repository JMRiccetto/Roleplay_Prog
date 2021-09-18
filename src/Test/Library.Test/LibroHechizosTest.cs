using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{
    public class LibroHechizosTest
    {
        private LibroHechizos libroHechizos;
        [SetUp]
        public void SetUp()
        {
            Spell spell = new Spell(50);
            libroHechizos = new LibroHechizos(spell);
        }
        /*
            Es necesesario probar este metodo para confirmar que el ataque que devuelve es el mismo que el del spell que tiene
        */
        [Test]
        public void AtaqueSpellTest()
        {
            Assert.AreEqual(this.libroHechizos.AtaqueSpell(), this.libroHechizos.Spell.Ataque);
        }
    }
}