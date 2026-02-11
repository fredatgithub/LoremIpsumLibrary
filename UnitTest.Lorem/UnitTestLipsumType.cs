using LoremIpsumLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.Lorem
{
  [TestClass]
  public class UnitTestLoremIpsumType
  {
    [TestMethod]
    public void LipsumType_ShouldContainFourValues()
    {
      var values = Enum.GetValues(typeof(LipsumType));
      Assert.HasCount(4, values);
    }

    [TestMethod]
    public void LipsumType_ShouldContainExpectedNames()
    {
      var names = Enum.GetNames(typeof(LipsumType));
      CollectionAssert.AreEquivalent(new[] { "Words", "Paragraphs", "Bytes", "Lists" }, names);
    }

    [TestMethod]
    public void LipsumType_Parse_ShouldReturnCorrectEnum()
    {
      var result = (LipsumType)Enum.Parse(typeof(LipsumType), "Words");
      Assert.AreEqual(LipsumType.Words, result);
    }

    [TestMethod]
    public void LipsumType_TryParse_ShouldReturnTrue_ForValidValue()
    {
      bool success = Enum.TryParse("Paragraphs", out LipsumType result);
      Assert.IsTrue(success);
      Assert.AreEqual(LipsumType.Paragraphs, result);
    }

    [TestMethod]
    public void LipsumType_TryParse_ShouldReturnFalse_ForInvalidValue()
    {
      bool success = Enum.TryParse("InvalidValue", out LipsumType result);
      Assert.IsFalse(success);
    }

    [TestMethod]
    public void LipsumType_AllDefinedValues_ShouldBeValidEnumValues()
    {
      foreach (LipsumType value in Enum.GetValues(typeof(LipsumType)))
      {
        Assert.IsTrue(Enum.IsDefined(typeof(LipsumType), value));
      }
    }

    [TestMethod]
    [DataRow("Words", LipsumType.Words)]
    [DataRow("Paragraphs", LipsumType.Paragraphs)]
    [DataRow("Bytes", LipsumType.Bytes)]
    [DataRow("Lists", LipsumType.Lists)]
    public void LipsumType_TryParse_ShouldMapCorrectly(string input, LipsumType expected)
    {
      bool success = Enum.TryParse(input, out LipsumType result);
      Assert.IsTrue(success);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void LipsumType_InvalidNumericValue_ShouldNotBeDefined()
    {
      const LipsumType invalidValue = (LipsumType)99;
      Assert.IsFalse(Enum.IsDefined(typeof(LipsumType), invalidValue));
    }
  }
}
