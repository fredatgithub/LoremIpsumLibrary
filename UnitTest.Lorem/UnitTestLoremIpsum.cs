using LoremIpsumLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Lorem
{
  [TestClass]
  public class UnitTestLoremIpsum
  {
    [TestMethod]
    public void LoremIpsum_GenerateWords_shouldReturnOneWord()
    {
      string source = LoremIpsum.CreateText(LipsumType.Words, 1);
      Assert.IsNotEmpty(source);
      Assert.StartsWith("Lorem", source);
    }

    [TestMethod]
    public void LoremIpsum_GenerateWords_shouldReturnTwoWords()
    {
      string source = LoremIpsum.CreateText(LipsumType.Words, 2);
      Assert.IsNotEmpty(source);
      Assert.StartsWith("Lorem ipsum", source);
    }

    [TestMethod]
    public void LoremIpsum_GenerateWords_shouldReturnThreeWords()
    {
      string source = LoremIpsum.CreateText(LipsumType.Words, 3);
      Assert.IsNotEmpty(source);
      Assert.StartsWith("Lorem ipsum dolor", source);
    }

    [TestMethod]
    public void LoremIpsum_GenerateWords_shouldReturnFourWords()
    {
      string source = LoremIpsum.CreateText(LipsumType.Words, 4);
      Assert.IsNotEmpty(source);
      Assert.StartsWith("Lorem ipsum dolor sit", source);
    }

    [TestMethod]
    public void LoremIpsum_GenerateWords_shouldReturnFiveWords()
    {
      string source = LoremIpsum.CreateText(LipsumType.Words, 5);
      Assert.IsNotEmpty(source);
      Assert.StartsWith("Lorem ipsum dolor sit amet", source);
    }
  }
}
