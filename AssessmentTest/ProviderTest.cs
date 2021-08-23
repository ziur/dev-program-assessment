using System.Linq;
using System;
using Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTest
{
    [TestClass]
    public class ProviderTest
    {
        
        private const string PIPE_SAMPLE = "a|b|c|d|e|f|g|h|i|j|k|l|m|n|o|p|q|r|s|t|u|v|w|x|y|z";
        
        [TestMethod]
        public void TestCommaSeparator()
        {
            string source = "a,b,c,d,e";
            IElementsProvider<string> provider = new StringProvider();
            string [] expectedElements = {"a", "b", "c", "d", "e"};
            CollectionAssert.AreEqual(expectedElements, provider.ProcessData(source).ToList());
        }

        [TestMethod]
        public void TestPipeSeparator()
        {
            string source = "a|b|c|d|e";
            IElementsProvider<string> provider = new StringProvider();
            string [] expectedElements = {"a", "b", "c", "d", "e"};
            CollectionAssert.AreEqual(expectedElements, provider.ProcessData(source).ToList());
        }

        [TestMethod]
        public void TestSpaceSeparator()
        {
            string source = "a b c d e";
            IElementsProvider<string> provider = new StringProvider();
            string [] expectedElements = {"a", "b", "c", "d", "e"};
            CollectionAssert.AreEqual(expectedElements, provider.ProcessData(source).ToList());
        }
    }
}
