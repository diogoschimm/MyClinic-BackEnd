using MyClinic.Domain.ValuesObjects;
using NUnit.Framework;

namespace MyClinic.NUnit.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var cep = new CEP("78005-180");
             
            Assert.Pass();
        }
    }
}