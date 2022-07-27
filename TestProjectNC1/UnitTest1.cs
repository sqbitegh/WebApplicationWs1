using System;
using WebApplicationNC1.Models;
using Xunit;

namespace TestProjectNC1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {
            var em = new ErrorViewModel();
            em.RequestId = "undef";
            Assert.True(true);


        }
    }
}
