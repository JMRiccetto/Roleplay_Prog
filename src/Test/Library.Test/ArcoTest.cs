using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{

    public class ArcoTest
    {
        private Arco arco;
        [SetUp]
        public void Setup()
        {
            this.arco = new Arco(50,0);
        }

        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */

        [Test]
        public void AsignarAtaqueValido()
        {
            this.Arco.Ataque = 10;
            Assert.AreEqual(this.arco.Ataque, 10);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.arco.Ataque = -10;
            Assert.AreEqual(this.arco.Ataque, 0);
        }
        /*
            Es necesario probar la asignacion de una defensa valida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaValida()
        {
            this.arco.Defensa = 20;
            Assert.AreEqual(this.arco.Defensa, 20);
        }
        /*
            Es necesario probar la asignacion de una defensa invalida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.arco.Defensa = -10;
            Assert.AreEqual(this.arco.Defensa, 0);
        }
    }


}