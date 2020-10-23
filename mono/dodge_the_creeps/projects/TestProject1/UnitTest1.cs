using System;
using ClassLibrary1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello", new Class1().State);
        }
    }
}
