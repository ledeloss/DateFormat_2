//Se agrega test  para utilizar el TDD , se crea el Test y el Metodo en Formato.cs para Cumplir con la prueba


using NUnit.Framework;

namespace Library.Test
{
    public class TestTextoConEspacios
   
    {

           [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidoSiElTextoTieneEspacios()
        {   Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("  10/11/1977  ");
            string esperado = "10-11-1977";
            Assert.AreEqual(esperado,formateada);
        }
              
    }
}