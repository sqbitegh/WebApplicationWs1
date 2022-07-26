using WebApplicationWs1.Pages;

namespace TestProjectxUnit1
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
            var em = new ErrorModel(null);
            em.NotFound();

            Assert.True(false);
        }
    }
}