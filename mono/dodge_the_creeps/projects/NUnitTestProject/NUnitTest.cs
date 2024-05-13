using System;
using ClassLibrary1;
using Godot;
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
            Console.WriteLine(new Vector3I(0, 0, 0));
        }
    }
}
