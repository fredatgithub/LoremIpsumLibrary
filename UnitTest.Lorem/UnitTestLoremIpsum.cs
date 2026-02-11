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
    }
  }
}
