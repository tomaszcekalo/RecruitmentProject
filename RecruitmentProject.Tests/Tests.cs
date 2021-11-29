using NUnit.Framework;

namespace RecruitmentProject.Tests
{
    public class Tests
    {
        [TestCase("abcdef", "")]
        [TestCase("abcdee", "e2")]
        [TestCase("aabcdee", "a2e2")]
        [TestCase("eabeaa", "a3e2")]
        [TestCase("eeabeA", "a2e3")]
        public void TestDuplicateCount(string input, string expectedResult)
        {
            var c = new DuplicateCounter();
            Assert.AreEqual(expectedResult, c.Count(input));
        }
    }
}