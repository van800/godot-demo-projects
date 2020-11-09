using System;
using Godot;
using NUnit.Framework;

namespace DodgeTheCreeps.nunit
{
    [TestFixture]
    public class NUnitTest 
    {
        [Test]
        public void Test1()
        {
            int i = 0;
            Console.WriteLine("Testsss");
            GD.Print("NUnitTest");
            var main = (Main)ResourceLoader.Load<PackedScene>("res://Main.tscn").Instance();
            Assert.AreEqual("Main", main.Name);
        }
    }
}
