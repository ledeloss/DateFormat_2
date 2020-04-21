using NUnit.Framework;

namespace Library.Test
{
    public class TestMes
   
    {

           [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MesEsMayorQueCero()
        {   Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/11/1977");
            int mes = int.Parse(formateada.Substring(5,2));
            Assert.Greater(mes,0);
        }
                [Test]
        public void MesEsMenorQueDoce()
        {   int limite = 12;
            Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/13/1977");
            int mes = int.Parse(formateada.Substring(5,2));
            Assert.LessOrEqual(mes,limite);
        }
        
    }
}