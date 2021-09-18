using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class WizardTest
    {
        private Wizard wizard;
        [SetUp]
        public void Setup()
        {
            this.wizard = new Wizard("Joseph");
            Spell spell = new Spell(50);
            LibroHechizos libroHechizos = new LibroHechizos(spell);
            this.wizard.CambiarLibroHechizos(libroHechizos);
            TunicaCuero tunicaCuero = new TunicaCuero(0,30);
            this.wizard.CambiarItemDef(tunicaCuero);
        }
        /*
            Es necesario probar la asignacion de un nombre valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreValidoTest()
        {
            this.wizard.Nombre= "Mata";
            Assert.AreEqual(this.wizard.Nombre, "Mata");
        }
        /*
            Es necesario probar la asignacion de un nombre invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void NombreInvalidoTest()
        {
            this.wizard.Nombre= "";
            Assert.AreEqual(this.wizard.Nombre, "Joseph");
        }
        /*
            Es necesario probar la asignacion de un valor de vida valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaValidaTest()
        {
            this.wizard.Vida= 100;
            Assert.AreEqual(this.wizard.Vida, 100);
        }
        /*
            Es necesario probar la asignacion de un valor de vida invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void VidaInvalidaTest()
        {
            this.wizard.Vida= -50;
            Assert.AreEqual(this.wizard.Vida, 0);
        }
        /*
            Es necesario probar este metodo para confirmar que
            el ataque que devuelve es el mismo ataque que el de su LibroHechizos
        */
        [Test]
        public void GetAtaqueTest()
        {
            Assert.AreEqual(this.wizard.GetAtaque(), this.wizard.LibroHechizos.AtaqueSpell());
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de LibroHechizos se realiza el cambio correctamente
        */
        [Test]
        public void CambiarLibroHechizosTest()
        {
            Spell spellNu = new Spell(30);
            LibroHechizos libroHechizosNu = new LibroHechizos(spellNu);
            this.wizard.CambiarLibroHechizos(libroHechizosNu);
            Assert.AreEqual(this.wizard.GetAtaque(), libroHechizosNu.AtaqueSpell());
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el LibroHechizos este queda en null
        */
        [Test]
        public void QuitarLibroHechizosTest()
        {
            this.wizard.QuitarLibroHechizos();
            Assert.AreEqual(this.wizard.LibroHechizos, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al realizar un cambio de ItemDef se realiza el cambio correctamente
        */
         [Test]
        public void CambiarItemDefTest()
        {
            TunicaCuero tunicaCueroNu = new TunicaCuero(0,50);
            this.wizard.CambiarItemDef(tunicaCueroNu);
            Assert.AreEqual(this.wizard.ItemDef, tunicaCueroNu);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al quitar el ItemDef este queda en null
        */
        [Test]
        public void QuitarItemDefTest()
        {
            this.wizard.QuitarItemDef();
            Assert.AreEqual(this.wizard.ItemDef, null);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque menor o igual a la armadura la 
            vida no se ve afectada
        */
        [Test]
        public void DanioRecibidoMenorOIgualQueArmaduraTest()
        {
            this.wizard.DanioRecibido(20);
            Assert.AreEqual(this.wizard.Vida, 80);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la armadura la vida
            se ve afectada
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraTest()
        {
            this.wizard.DanioRecibido(60);
            Assert.AreEqual(this.wizard.Vida, 50);
        }
        /*
            Es necesario probar este metodo para confirmar que
            al recibir un ataque mayor a la suma de armadura y vida
            esta ultima queda en 0
        */
        [Test]
        public void DanioRecibidoMayorQueArmaduraYVidaTest()
        {
            this.wizard.DanioRecibido(300);
            Assert.AreEqual(this.wizard.Vida, 0);
        }
        [Test]
        public void CurarseTest()
        {
            this.wizard.Vida = 20;
            this.wizard.Curarse();
            Assert.AreEqual(this.wizard.Vida, 80);
        }
    }
}