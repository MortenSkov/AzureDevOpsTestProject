using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureDevOps;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddTwoNumbers()
        {
            float a = 2.5f;
            float b = 3f;
            Program program = new Program();


            float actual = program.AddTwoNumbers(a, b);
            float expected = 5.5f;

            Assert.AreEqual(expected, actual);
        }
    }
}
