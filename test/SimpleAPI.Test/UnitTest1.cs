using System;
using Xunit;
using SimpleAPISln.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName(){
            var returnValue = controller.Get(1);
            Assert.Equal("Marcelo", returnValue.Value);
        }
        

        [Fact]
        public void Test1()
        {

        }
    }
}
