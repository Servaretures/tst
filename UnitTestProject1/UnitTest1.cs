using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            int test = Lab1.Program.Calculate(a);
            Assert.AreEqual(test,64);
        }
        public void TestMethod2()
        {
            int a = 4;
            int test = Lab1.Program.Calculate2(a);
            Assert.AreEqual(test, 96);
        }
    }
}
