using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suma;
namespace TestCalculador
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testSuma()
        {
          
            double resultado = suma.sumar(3, 2);
            double esperado_resultado = 5;
       Assert.AreEqual(resultado, esperado_resultado);


        }

        [TestMethod]
        public void testResta()
        {

            double resultado = suma.restar(3, 2);
            double esperado_resultado = 1;
            Assert.AreEqual(resultado, esperado_resultado);


        }

        [TestMethod]
        public void testMultiplicar()
        {

            double resultado = suma.multiplicar(3, 2);
            double esperado_resultado = 6;
            Assert.AreEqual(resultado, esperado_resultado);


        }
    }
}
