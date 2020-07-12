using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    [TestClass()]
    public class ThreeSummerTest
    {
        private ThreeSumer _ThreeSumer = new ThreeSumer();

        [TestMethod]
        public void NormalCase()
        {
            List<List<int>> expected = new List<List<int>>();
            expected.Add(new[] { -1, 0, 1 }.ToList());
            expected.Add(new[] { -1, -1, 2 }.ToList());
            ShouldBeEqual(expected, _ThreeSumer.GetSumThree(new[] { -1, 0, 1, 2, -1, -4 }));
        }

        [TestMethod]
        public void SameNumCase()
        {
            List<List<int>> expected = new List<List<int>>();
            expected.Add(new[] { 0, 0, 0 }.ToList());
            ShouldBeEqual(expected, _ThreeSumer.GetSumThree(new[] { 0, 0, 0, 0 }));
        }

        [TestMethod]
        public void DuplicateCase()
        {
            List<List<int>> expected = new List<List<int>>();
            expected.Add(new[] { -1, 0, 1 }.ToList());
            ShouldBeEqual(expected, _ThreeSumer.GetSumThree(new[] { -1, 0, 1, -1, 0, 1 }));
        }

        [TestMethod]
        public void NoAnswer()
        {
            List<List<int>> expected = new List<List<int>>();
            ShouldBeEqual(expected, _ThreeSumer.GetSumThree(new[] { -1, -1, -1, -1 }));
        }

        [TestMethod]
        public void LessThanThreeNum()
        {
            ShouldBeEqual(null, _ThreeSumer.GetSumThree(new[] { -1, 1 }));
        }

        [TestMethod]
        public void NullInput()
        {
            ShouldBeEqual(null, _ThreeSumer.GetSumThree(null));
        }

        private void ShouldBeEqual(List<List<int>> expected, List<List<int>> output)
        {
            if (expected == null)
            {
                Assert.AreEqual(expected, output, "Null not equal");
                return;
            }
            Assert.AreEqual(expected.Count, output.Count, "Ans Num Should equal");
            for (int i = 0; i < output.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], output[i], $"expected : {expected[i]} \r\n output : {output[i]}");
            }
        }
    }
}