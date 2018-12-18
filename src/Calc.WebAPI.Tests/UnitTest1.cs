using System;
using Xunit;
using Calc.WebAPI;
using Calc.WebAPI.Controllers;

namespace Calc.WebAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();

            controller.Post("Hello World");

            Assert.True(true);
        }
    }
}
