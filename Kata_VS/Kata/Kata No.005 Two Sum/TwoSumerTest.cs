using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass()]
    public class TwoSumerTest
    {
        private TwoSumer _TwoSumer = new TwoSumer();

        [TestMethod]
        public void NormalCase()
        {
            ShouldBeEqual(new[] { 0, 1 }, _TwoSumer.GetSumTwo(new[] { 2, 7, 11, 15 }, 9));
        }

        [TestMethod]
        public void CheckCanNotFoundDuplicatTwoSum()
        {
            ShouldBeEqual(new[] { 1, 2 }, _TwoSumer.GetSumTwo(new[] { 3, 2, 4 }, 6));
        }

        [TestMethod]
        public void DuplicateNum()
        {
            ShouldBeEqual(new[] { 0, 1 }, _TwoSumer.GetSumTwo(new[] { 3, 3 }, 6));
        }

        [TestMethod]
        public void CanNotFoundTwoSum()
        {
            ShouldBeEqual(null, _TwoSumer.GetSumTwo(new[] { 3, 3 }, 7));
        }

        [TestMethod]
        public void NullInput()
        {
            ShouldBeEqual(null, _TwoSumer.GetSumTwo(null, 0));
        }

        [TestMethod]
        public void EmptyInput()
        {
            ShouldBeEqual(null, _TwoSumer.GetSumTwo(new int[] { }, 0));
        }

        [TestMethod]
        public void OnlyOneNum()
        {
            ShouldBeEqual(null, _TwoSumer.GetSumTwo(new[] { 3 }, 0));
        }

        [TestMethod]
        public void NagativeInput()
        {
            ShouldBeEqual(new[] { 1, 2 }, _TwoSumer.GetSumTwo(new[] { 1, -3, 4 }, 1));
        }

        [TestMethod]
        public void NagativeTarget()
        {
            ShouldBeEqual(new[] { 0, 1 }, _TwoSumer.GetSumTwo(new[] { 1, -3, 4 }, -2));
        }

        private void ShouldBeEqual(int[] expected, int[] output)
        {
            if (expected == null)
            {
                Assert.AreEqual(expected, output, "Null not equal");
            }
            else
            {
                Assert.AreEqual(expected.Length, output.Length, "array length not equal");
                Assert.AreEqual(expected[0], output[0], "firstNum not equal");
                Assert.AreEqual(expected[1], output[1], "secondNum not equal");
            }
        }
    }
}