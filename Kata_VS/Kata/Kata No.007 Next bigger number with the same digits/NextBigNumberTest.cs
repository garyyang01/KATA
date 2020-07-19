using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass()]
    public class NextBigNumberTest
    {
        private SameDigitCaculater _sameDigitCaculater = new SameDigitCaculater();

        [TestMethod]
        public void NormalCase1()
        {
            ShouldBeEqual(21, _sameDigitCaculater.GetBigNumber(12));
        }

        [TestMethod]
        public void NormalCase2()
        {
            ShouldBeEqual(531, _sameDigitCaculater.GetBigNumber(513));
        }

        [TestMethod]
        public void NormalCase3()
        {
            ShouldBeEqual(1423, _sameDigitCaculater.GetBigNumber(1342));
        }

        [TestMethod]
        public void NormalCase4()
        {
            ShouldBeEqual(414, _sameDigitCaculater.GetBigNumber(144));
        }

        [TestMethod]
        public void NormalCase5()
        {
            ShouldBeEqual(908, _sameDigitCaculater.GetBigNumber(890));
        }

        [TestMethod]
        public void NormalCase6()
        {
            ShouldBeEqual(9119, _sameDigitCaculater.GetBigNumber(1991));
        }

        [TestMethod]
        public void DuplicateNumber()
        {
            ShouldBeEqual(-1, _sameDigitCaculater.GetBigNumber(555));
        }

        [TestMethod]
        public void OneDigit()
        {
            ShouldBeEqual(-1, _sameDigitCaculater.GetBigNumber(1));
        }

        [TestMethod]
        public void NegativeNumber()
        {
            ShouldBeEqual(-1, _sameDigitCaculater.GetBigNumber(-124));
        }

        [TestMethod]
        public void Zero()
        {
            ShouldBeEqual(-1, _sameDigitCaculater.GetBigNumber(0));
        }

        [TestMethod]
        public void ZeroFirst()
        {
            ShouldBeEqual(21, _sameDigitCaculater.GetBigNumber(0012));
        }

        [TestMethod]
        public void BigNumber()
        {
            ShouldBeEqual(3321545083902189405, _sameDigitCaculater.GetBigNumber(3321545083902189054));
        }

        private void ShouldBeEqual(long expected, long output)
        {
            Assert.AreEqual(expected, output, "not equal");
        }
    }
}