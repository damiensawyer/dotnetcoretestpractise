using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNumbersWorks()
        {
            var r = Functions.AddNumbers(1, 2);
            Assert.IsTrue(r == 3);
        }

        [TestMethod]
        public void AddNumbersFails()
        {
            var r = Functions.AddNumbers(1, 2);
            Assert.IsFalse(r == 5);
        }
    }
}
