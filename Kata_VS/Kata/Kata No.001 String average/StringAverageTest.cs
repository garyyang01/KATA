using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass()]
    public class StringAverageTest
    {
        private AverageString _stringAverage = new AverageString();

        [TestMethod]
        public void Zero_Nine_Five_Two()
        {
            ShouldBeEqual("four", _stringAverage.Average("zero nine five two"));
        }

        [TestMethod]
        public void Four_Six_Two_Three()
        {
            ShouldBeEqual("three", _stringAverage.Average("four six two three"));
        }

        [TestMethod]
        public void One_Two_Three_Four_Five()
        {
            ShouldBeEqual("three", _stringAverage.Average("one two three four five"));
        }

        [TestMethod]
        public void Five_Four()
        {
            ShouldBeEqual("four", _stringAverage.Average("five four"));
        }

        [TestMethod]
        public void Zero_Zero_Zero_Zero_Zero()
        {
            ShouldBeEqual("zero", _stringAverage.Average("zero zero zero zero zero"));
        }

        [TestMethod]
        public void One_One_Eight_One()
        {
            ShouldBeEqual("two", _stringAverage.Average("one one eight one"));
        }

        [TestMethod]
        public void EmptyInputString()
        {
            ShouldBeEqual("n/a", _stringAverage.Average(""));
        }

        [TestMethod]
        public void Nine()
        {
            ShouldBeEqual("nine", _stringAverage.Average("nine"));
        }

        [TestMethod]
        public void One_Ska_Sss_Two_Four()
        {
            ShouldBeEqual("n/a", _stringAverage.Average("one ska sss two four"));
        }

        [TestMethod]
        public void ONE_TWO_THREE_FOUR_FIVE()
        {
            ShouldBeEqual("three", _stringAverage.Average("ONE TWO THREE FOUR FIVE"));
        }

        [TestMethod]
        public void ONE_TWOee_THREEss_FOURteen_FIVE()
        {
            ShouldBeEqual("n/a", _stringAverage.Average("ONE TWOee THREErr FOURteen FIVE"));
        }

        [TestMethod]
        public void oNe_tWo_tHree_fOur_fIve()
        {
            ShouldBeEqual("three", _stringAverage.Average("oNe tWo tHree fOur fIve"));
        }

        [TestMethod]
        public void NULL()
        {
            ShouldBeEqual("n/a", _stringAverage.Average(null));
        }

        private void ShouldBeEqual(string expected, string output)
        {
            Assert.AreEqual(expected, output);
        }
    }
}