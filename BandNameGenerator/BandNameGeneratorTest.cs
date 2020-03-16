namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("The Knife", Kata.BandNameGenerator("knife"));
      Assert.AreEqual("Tartart", Kata.BandNameGenerator("tart"));
      Assert.AreEqual("Sandlesandles", Kata.BandNameGenerator("sandles"));
      Assert.AreEqual("The Bed", Kata.BandNameGenerator("bed"));
      Assert.AreEqual("Ttt", Kata.BandNameGenerator("tt"));
      Assert.AreEqual("", Kata.BandNameGenerator(""));
      Assert.AreEqual("", Kata.BandNameGenerator(null));
      Assert.AreEqual("Kk", Kata.BandNameGenerator("k"));
    }
  }
}