using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class ElfoTest
    {
        private Elfo elfo;
        [SetUp]
        public void Setup()
        {
            this.elfo = new Elfo("Elfo1");
            Arco arco = new Arco(20,0);
            this.elfo.CambiarItemOf(arco);
            Armadura armadura = new Armadura(0,20);
            this.elfo.CambiarItemDef(armadura);
        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.elfo.Nombre= "Ebola";
            Assert.AreEqual(this.elfo.Nombre, "Ebola");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.elfo.Nombre= "";
            Assert.AreEqual(this.elfo.Nombre, "Elfo1");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.elfo.Vida= 20;
            Assert.AreEqual(this.elfo.Vida, 30);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.elfo.Vida= -60;
            Assert.AreEqual(this.elfo.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su ItemOf
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.elfo.GetAtaque(), this.elfo.ItemOf.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemOf se realiza el cambio correctamente
        */
        [Test]
        public void CambiarItemOfTest()
        {
            Arco arcoNue = new Arco(60,0);
            this.elfo.CambiarItemOf(arcoNue);
            Assert.AreEqual(this.elfo.GetAtaque(), arcoNue.Ataque);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemOf este queda en null
        */
        [Test]
        public void QuitarItemOfTest()
        {
            this.elfo.QuitarItemOf();
            Assert.AreEqual(this.elfo.ItemOf, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            Escudo armaduraNue = new Armadura(0,40);
            this.elfo.CambiarItemDef(armaduraNue);
            Assert.AreEqual(this.elfo.ItemDef, armaduraNue);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.elfo.QuitarItemDef();
            Assert.AreEqual(this.elfo.ItemDef, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque menor o igual a la armadura la 
            vida no se ve afectada
        */
        [Test]
        public void DanioRecibidoMenorOIgualQueArmaduraTest()
        {
            this.elfo.DanioRecibido(30);
            Assert.AreEqual(this.elfo.Vida, 90);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la armadura la vida
            se ve afectada
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraTest()
        {
            this.elfo.DanioRecibido(40);
            Assert.AreEqual(this.elfo.Vida, 80);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la suma de armadura y vida
            esta ultima queda en 0
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraYVidaTest()
        {
            this.elfo.DanioRecibido(300);
            Assert.AreEqual(this.elfo.Vida, 0);
            
        }
        /*
            Es necesario probar este metodo para confirmar que al curarse queda con la misma vida inicial.
        */
        [Test]
        public void CurarseTest()
        {
            this.elfo.Vida = 20;
            this.elfo.Curarse();
            Assert.AreEqual(this.elfo.Vida, 90);
        }
    }


}