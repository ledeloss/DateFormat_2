using NUnit.Framework;

namespace Library.Test
{
    public class TestDia
   
    {

           [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DiaEsMayorQueCero()
        {   Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/11/1977");
            int dia = int.Parse(formateada.Substring(8,2));
            Assert.Greater(dia,0);
        }
                [Test]
        public void DiaEsMenorQueTreintaYUno()
        {   int limite = 31;
            Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/13/1977");
            int dia = int.Parse(formateada.Substring(8,2));
            Assert.LessOrEqual(dia,limite);
        }
        
    }
}