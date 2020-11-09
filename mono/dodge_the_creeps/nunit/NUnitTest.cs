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
            GD.Print(main.Name);
            Assert.AreEqual(200, main.Name);
        }
    }
}
