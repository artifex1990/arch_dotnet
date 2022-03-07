using architekt;
using NUnit.Framework;

namespace architekt_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(new double [0], Lesson3.solve(1,0, 1));
        }
    }
}