namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Test
  {
    [Test]
    public void SampleTests()
    {
      Assert.AreEqual("four", Kata.AverageString("zero nine five two"));
      Assert.AreEqual("three", Kata.AverageString("four six two three"));
      Assert.AreEqual("three", Kata.AverageString("one two three four five"));
      Assert.AreEqual("four", Kata.AverageString("five four"));
      Assert.AreEqual("zero", Kata.AverageString("zero zero zero zero zero"));
      Assert.AreEqual("two", Kata.AverageString("one one eight one"));
      Assert.AreEqual("n/a", Kata.AverageString(""));
      Assert.AreEqual("nine", Kata.AverageString("nine"));
      Assert.AreEqual("n/a", Kata.AverageString("one ska sss two four"));
    }
  }
}