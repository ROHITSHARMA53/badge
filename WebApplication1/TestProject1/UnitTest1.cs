using WebApplication1.Modules;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "value should be equal to 1");

        }
        [Fact]
        public void CheckAddFunction()
        {
            
            function func = new function();
            int y = func.Add(3, 2);
            bool result = false;
            if (y == 5) result = true;
            Assert.True(result, "value should be equal to 5");
        }
    }
}