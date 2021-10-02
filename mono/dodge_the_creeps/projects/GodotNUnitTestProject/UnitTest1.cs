using System;
using DodgeTheCreeps;
using Godot;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
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
