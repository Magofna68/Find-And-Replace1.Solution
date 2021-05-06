using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplaceSolution;

namespace FindAndReplaceSolution.Tests //Change to match Title
{
  [TestClass]
  public class FindAndReplaceTests
  {
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    [TestMethod]
    public void FindAndReplaceAll_HelloWorld_Hello_World_WorldWorld()
    {
      // Arrange
      string sentence = "Hello World";
      string findWord = "Hello";
      string replaceWord = "World";
      string expectedOutputString = "World World";
      // Act
      string actualOutputString = FindAndReplace.FindAndReplaceAll(sentence, findWord, replaceWord);
      // Assert
      Assert.AreEqual(expectedOutputString, actualOutputString);
    }
  }
}
