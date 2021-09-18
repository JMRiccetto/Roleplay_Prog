using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class EnanoTest
    {
        private Enano enano;
        [SetUp]
        public void Setup()
        {
            this.enano = new Enano("Robertinho");
            Cuchillo cuchillo = new Cuchillo(60,0);
            this.enano.CambiarItemOf(cuchillo);
            Escudo escudo = new Escudo(0,30);
            this.enano.CambiarItemDef(escudo);
        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.enano.Nombre= "Fatiga";
            Assert.AreEqual(this.enano.Nombre, "Fatiga");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.enano.Nombre= "";
            Assert.AreEqual(this.enano.Nombre, "Robertinho");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.enano.Vida= 20;
            Assert.AreEqual(this.enano.Vida, 20);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.enano.Vida= -60;
            Assert.AreEqual(this.enano.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.enano.GetAtaque(), this.enano.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Cuchillo cuchilloNue = new Cuchillo(40,0);
            this.enano.CambiarItemOf(cuchilloNue);
            Assert.AreEqual(this.enano.GetAtaque(), cuchilloNue.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.enano.QuitarItemOf();
            Assert.AreEqual(this.enano.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            Escudo escudoNue = new Escudo(0,50);
            this.enano.CambiarItemDef(escudoNue);
            Assert.AreEqual(this.enano.ItemDef, escudoNue);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.enano.QuitarItemDef();
            Assert.AreEqual(this.enano.ItemDef, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque menor o igual a la armadura la 
            vida no se ve afectada
        */
        [Test]
        public void DanioRecibidoMenorOIgualQueArmaduraTest()
        {
            this.enano.DanioRecibido(20);
            Assert.AreEqual(this.enano.Vida, 110);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la armadura la vida
            se ve afectada
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraTest()
        {
            this.enano.DanioRecibido(40);
            Assert.AreEqual(this.enano.Vida, 100);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la suma de armadura y vida
            esta ultima queda en 0
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraYVidaTest()
        {
            this.enano.DanioRecibido(300);
            Assert.AreEqual(this.enano.Vida, 0);
        }
        [Test]
        public void CurarseTest()
        {
            this.enano.Vida = 20;
            this.enano.Curarse();
            Assert.AreEqual(this.enano.Vida, 110);
        }
    }


}