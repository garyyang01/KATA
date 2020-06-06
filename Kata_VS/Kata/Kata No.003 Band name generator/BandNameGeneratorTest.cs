using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass()]
    public class BandNameGeneratorTest
    {
        private BandNameGenerator _BandNameGenerator = new BandNameGenerator();

        [TestMethod]
        public void Knife()
        {
            ShouldBeEqual("The Knife", _BandNameGenerator.GenerateBandName("knife"));
        }
        [TestMethod]
        public void Tart()
        {
            ShouldBeEqual("Tartart", _BandNameGenerator.GenerateBandName("tart"));
        }
        [TestMethod]
        public void Sandles()
        {
            ShouldBeEqual("Sandlesandles", _BandNameGenerator.GenerateBandName("sandles"));
        }
        [TestMethod]
        public void Bed()
        {
            ShouldBeEqual("The Bed", _BandNameGenerator.GenerateBandName("bed"));
        }
        [TestMethod]
        public void RepeatLetters()
        {
            ShouldBeEqual("Ttt", _BandNameGenerator.GenerateBandName("tt"));
        }
        [TestMethod]
        public void EmptyInput()
        {
            ShouldBeEqual("", _BandNameGenerator.GenerateBandName(""));
        }
        [TestMethod]
        public void NullInput()
        {
            ShouldBeEqual("", _BandNameGenerator.GenerateBandName(null));
        }
        [TestMethod]
        public void SingleLetter()
        {
            ShouldBeEqual("Kk", _BandNameGenerator.GenerateBandName("k"));
        }
        private void ShouldBeEqual(string expected, string output)
        {
            Assert.AreEqual(expected, output);
        }
    }
}