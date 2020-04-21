using NUnit.Framework;

namespace Library.Test
{
    public class TestAnio
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AnioEsMayorIgualQueCero()
        {   Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/11/1977");
            int resultado = int.Parse(formateada.Substring(0,4));
            Assert.Greater(resultado,0);
        }
                [Test]
        public void AnioEsMenorIgualQueLimiteSuperior()
        {   int limite = 9999;
            Formato formato = new Formato();
            string formateada = Formato.ChangeFormat("10/11/1977");
            int resultado = int.Parse(formateada.Substring(0,4));
            Assert.LessOrEqual(resultado,limite);
        }
    }
}