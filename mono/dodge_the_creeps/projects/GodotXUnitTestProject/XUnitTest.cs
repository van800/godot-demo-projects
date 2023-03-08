using System;
using Godot;
using Xunit;

namespace TestProject1
{
    public class XUnitTest
    {
        [Fact]
        public void Test1()
        {
            int i = 0;
            Console.WriteLine("Testsss");
            GD.Print("XUnitTest");
            var main = (Main)ResourceLoader.Load<PackedScene>("res://Main.tscn").Instantiate();
            GD.Print(System.Threading.Thread.CurrentThread.IsBackground);
            Assert.Equal("Main", main.Name);
        }
    }
}
