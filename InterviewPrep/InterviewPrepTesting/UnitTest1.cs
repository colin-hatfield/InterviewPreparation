using Microsoft.VisualStudio.TestTools.UnitTesting;

using InterviewPrepMVC.Controllers;

namespace InterviewPrepTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void tmFirstLast()
        {
            string test = "colin c";
            int result = HomeController.LongestNonRepeatingString(test);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void tmFirstSecond()
        {
            string test = "aacolin";
            int result = HomeController.LongestNonRepeatingString(test);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void tmSecondLastLast()
        {
            string test = "colinaa";
            int result = HomeController.LongestNonRepeatingString(test);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void tmThreeTimes()
        {
            string test = "iZdhasZtoZf";
            int result = HomeController.LongestNonRepeatingString(test);
            Assert.AreEqual(5, result);
        }
    }
}
