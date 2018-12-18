using Calc.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Xunit;

namespace Calc.WebAPI.Tests
{
    public class CalcControllerTests
    {
        [Fact]
        public void Add_5_6_should_return_11()
        {
            var calcController = new CalcController();

            var result = (ObjectResult) calcController.Add(new values() { value1 = "5", value2 = "6" });

            Assert.Equal(11, result.Value);
        }

        [Fact]
        public void Add_one_invalid_number_should_return_error()
        {
            var calcController = new CalcController();

            var result = (ObjectResult)calcController.Add(new values() { value1 = "5", value2 = "6a" });

            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
