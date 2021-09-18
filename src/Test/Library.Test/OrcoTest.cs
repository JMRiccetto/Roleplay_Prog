using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class OrcoTest
    {
        private Orco orco;
        [SetUp]
        public void Setup()
        {
            this.orco = new Orco("Joseph");
            Mazo mazo = new Mazo(50,0);
            this.orco.CambiarItemOf(mazo);
            Yelmo yelmo = new Yelmo(0,30);
            this.orco.CambiarItemDef(yelmo);
        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.orco.Nombre= "Mata";
            Assert.AreEqual(this.orco.Nombre, "Mata");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.orco.Nombre= "";
            Assert.AreEqual(this.orco.Nombre, "Joseph");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.orco.Vida= 100;
            Assert.AreEqual(this.orco.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.orco.Vida= -50;
            Assert.AreEqual(this.orco.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.orco.GetAtaque(), this.orco.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Mazo mazoNu = new Mazo(60,0);
            this.orco.CambiarItemOf(mazoNu);
            Assert.AreEqual(this.orco.GetAtaque(), mazoNu.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.orco.QuitarItemOf();
            Assert.AreEqual(this.orco.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            Yelmo yelmoNu = new Yelmo(0,50);
            this.orco.CambiarItemDef(yelmoNu);
            Assert.AreEqual(this.orco.ItemDef, yelmoNu);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.orco.QuitarItemDef();
            Assert.AreEqual(this.orco.ItemDef, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque menor o igual a la armadura la 
            vida no se ve afectada
        */
        [Test]
        public void DanioRecibidoMenorOIgualQueArmaduraTest()
        {
            this.orco.DanioRecibido(20);
            Assert.AreEqual(this.orco.Vida, 130);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la armadura la vida
            se ve afectada
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraTest()
        {
            this.orco.DanioRecibido(60);
            Assert.AreEqual(this.orco.Vida, 100);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la suma de armadura y vida
            esta ultima queda en 0
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraYVidaTest()
        {
            this.orco.DanioRecibido(300);
            Assert.AreEqual(this.orco.Vida, 0);
        }
        [Test]
        public void CurarseTest()
        {
            this.orco.Vida = 20;
            this.orco.Curarse();
            Assert.AreEqual(this.orco.Vida, 130);
        }
    }


}