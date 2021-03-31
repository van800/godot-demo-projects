using ClassLibrary1;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("Hello",new Class1().State);
        }
    }
}
