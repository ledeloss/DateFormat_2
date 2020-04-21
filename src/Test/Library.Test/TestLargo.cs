using NUnit.Framework;

namespace Library.Test
{
    public class TestLargo
   
    {

           [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SeparadorEsGuion()
        {   Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/11/1977");
            int largo = formateada.Length;
            Assert.AreEqual(largo,10);
        }
               
    }
}