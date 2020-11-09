using Godot;
using NUnit.Framework;

namespace DodgeTheCreeps.nunit
{
    [TestFixture]
    public class NUnitTest 
    { 
        [Test]
        public void Test()
        {
            int i = 0;
            GD.Print("t");
            
            // var main = (Main)ResourceLoader.Load<PackedScene>("res://Main.tscn").Instance();
            // GD.Print(main.Name);
            // Assert.AreEqual(200, main.Name);
        }
    }
}
