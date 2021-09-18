using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class YelmoTest
    {
        private Yelmo yelmo;
        [SetUp]
        public void Setup()
        {
            this.yelmo = new Yelmo(0,30);
        }

        [Test]
        public void AsignarAtaqueValido()
        {
            this.yelmo.Ataque = 10;
            Assert.AreEqual(this.yelmo.Ataque, 10);
        }
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.yelmo.Ataque = -10;
            Assert.AreEqual(this.yelmo.Ataque, 0);
        }
        [Test]
        public void AsignarDefensaValida()
        {
            this.yelmo.Defensa = 50;
            Assert.AreEqual(this.yelmo.Defensa, 50);
        }
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.yelmo.Defensa = -30;
            Assert.AreEqual(this.yelmo.Defensa, 0);
        }
    }


}