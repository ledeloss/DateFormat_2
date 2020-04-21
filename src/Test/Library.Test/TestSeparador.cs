using NUnit.Framework;

namespace Library.Test
{
    public class TestSeparador
   
    {

           [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SeparadorEsGuion()
        {   Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/11/1977");
            string separador = formateada.Substring(4,1);
            Assert.AreEqual(separador,"-");
        }
               
    }
}