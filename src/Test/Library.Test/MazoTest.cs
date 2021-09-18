using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{

    public class MazoTest
    {
        private Mazo mazo;
        [SetUp]
        public void Setup()
        {
            this.mazo = new Mazo(40,0);
        }

        [Test]
        public void AsignarAtaqueValido()
        {
            this.mazo.Ataque = 10;
            Assert.AreEqual(this.mazo.Ataque, 10);
        }
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.mazo.Ataque = -10;
            Assert.AreEqual(this.mazo.Ataque, 0);
        }
        [Test]
        public void AsignarDefensaValida()
        {
            this.mazo.Defensa = 30;
            Assert.AreEqual(this.mazo.Defensa, 30);
        }
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.mazo.Defensa = -20;
            Assert.AreEqual(this.mazo.Defensa, 0);
        }
    }


}