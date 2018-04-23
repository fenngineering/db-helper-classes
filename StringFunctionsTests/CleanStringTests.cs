using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringFunctionsTests
{
    [TestClass]
    public class CleanStringTests
    {
        [TestMethod]
        public void AssertThatAStringIsCleanWhenItContainsInvalidData()
        {
            var expression = "SomeString\r\n\t";

            var actual = HelperClasses.StringFunctions.CleanString(expression, " ");

            var expected = "SomeString   ";

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void AssertThatAStringIsCleanWhenItContainsInvalidDataOverride()
        {
            var expression = "SomeString,";

            var pattern = "[^-a-zA-ZÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïðòóôõöùúûüýÿñ£$%&! ./0-9:=\\#()]";

            var actual = HelperClasses.StringFunctions.CleanString(expression, " ", pattern);

            var expected = "SomeString ";

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void AssertThatAStringIsCleanWhenItContainsInvalidDataChangeDefaultPattern()
        {
            var expression = "SomeString,";

            var pattern = HelperClasses.StringFunctions.DefaultPattern.Replace(",", "");
            
            var actual = HelperClasses.StringFunctions.CleanString(expression, " ", pattern);

            var expected = "SomeString ";

            Assert.AreEqual(actual, expected);
        }
    }
}
