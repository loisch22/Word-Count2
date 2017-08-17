using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_Return0MatchingWords_0()
    {
      RepeatCounter newSearch = new RepeatCounter("Hello world", "Goodbye");
      int expected = 0;
      int actual = newSearch.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_Return1MatchingWord_1()
    {
      RepeatCounter newSearch = new RepeatCounter("I like dogs.", "like");
      int expected = 1;
      int actual = newSearch.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_Return3MatchingWords_3()
    {
      RepeatCounter newSearch = new RepeatCounter("He has, she has, the dog has", "has");
      int expected = 3;
      int actual = newSearch.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_Return3MatchingWordRegardlessOfCase_3()
    {
      RepeatCounter newSearch = new RepeatCounter("He has, she has, the dog has", "Has");
      int expected = 3;
      int actual = newSearch.CountRepeats();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_ReturnsPartialWords_4()
    {
      RepeatCounter newSearch = new RepeatCounter("He has she has the dog has. She hasn't been to the store.", "Has");

      int expected = 4;
      int actual = newSearch.CountRepeats();

      Assert.AreEqual(expected, actual);
    }
  }
}
