using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass()]
    public class DuplicatesCounterTest
    {
        private DuplicatesCounter _duplicatesCounter = new DuplicatesCounter();

        [TestMethod]
        public void Empty()
        {
            ShouldBeEqual(0, _duplicatesCounter.CountDuplicates(""));
        }

        [TestMethod]
        public void Null()
        {
            ShouldBeEqual(0, _duplicatesCounter.CountDuplicates(null));
        }

        [TestMethod]
        public void KataTest1()
        {
            ShouldBeEqual(0, _duplicatesCounter.CountDuplicates("abcde"));
        }

        [TestMethod]
        public void KataTest2()
        {
            ShouldBeEqual(2, _duplicatesCounter.CountDuplicates("aabbcde"));
        }

        [TestMethod]
        public void DifferentCase()
        {
            ShouldBeEqual(2, _duplicatesCounter.CountDuplicates("aabBcde"));
        }

        [TestMethod]
        public void KataTest3()
        {
            ShouldBeEqual(1, _duplicatesCounter.CountDuplicates("Indivisibility"));
        }

        [TestMethod]
        public void NotBeAdjacent()
        {
            ShouldBeEqual(2, _duplicatesCounter.CountDuplicates("Indivisibilities"));
        }

        [TestMethod]
        public void Number()
        {
            ShouldBeEqual(4, _duplicatesCounter.CountDuplicates("123asd321zxcd"));
        }

        [TestMethod]
        public void MarkChar()
        {
            ShouldBeEqual(4, _duplicatesCounter.CountDuplicates(",./..,,l;21sad,./zxc1"));
        }

        private void ShouldBeEqual(int expected, int output)
        {
            Assert.AreEqual(expected, output);
        }
    }
}