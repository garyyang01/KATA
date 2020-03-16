namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Tests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(0, Kata.DeadAntCount("ant ant ant ant"));
      Assert.AreEqual(0, Kata.DeadAntCount(null));
      Assert.AreEqual(2, Kata.DeadAntCount("ant anantt aantnt"));
      Assert.AreEqual(1, Kata.DeadAntCount("ant ant .... a nt"));
      Assert.AreEqual(3, Kata.DeadAntCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t"));
      Assert.AreEqual(1, Kata.DeadAntCount("a"));
      Assert.AreEqual(1, Kata.DeadAntCount("n"));
      Assert.AreEqual(1, Kata.DeadAntCount("t"));
      Assert.AreEqual(0, Kata.DeadAntCount("...."));
      Assert.AreEqual(0, Kata.DeadAntCount(""));
    }
  }
}