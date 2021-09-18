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
        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueValido()
        {
            this.mazo.Ataque = 10;
            Assert.AreEqual(this.mazo.Ataque, 10);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.mazo.Ataque = -10;
            Assert.AreEqual(this.mazo.Ataque, 0);
        }
        /*
            Es necesario probar la asignacion de una defensa valida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaValida()
        {
            this.mazo.Defensa = 30;
            Assert.AreEqual(this.mazo.Defensa, 30);
        }
        /*
            Es necesario probar la asignacion de una defensa invalida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.mazo.Defensa = -20;
            Assert.AreEqual(this.mazo.Defensa, 0);
        }
    }


}