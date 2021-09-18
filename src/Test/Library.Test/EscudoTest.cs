using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class EscudoTest
    {
        private Escudo escudo;
        [SetUp]
        public void Setup()
        {
            this.escudo = new Escudo(0,40);
        }
        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueValido()
        {
            this.escudo.Ataque = 20;
            Assert.AreEqual(this.escudo.Ataque, 20);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.escudo.Ataque = -20;
            Assert.AreEqual(this.escudo.Ataque, 0);
        }
        /*
            Es necesario probar la asignacion de una defensa valida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaValida()
        {
            this.escudo.Defensa = 60;
            Assert.AreEqual(this.escudo.Defensa, 60);
        }
        /*
            Es necesario probar la asignacion de una defensa invalida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.escudo.Defensa = -40;
            Assert.AreEqual(this.escudo.Defensa, 0);
        }
    }


}

