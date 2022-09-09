using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataAccess;
using BusinessLayer.Helper;
using BusinessLayer.Rules;

namespace PoemGenTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetFile()
        {
            var readIO = new ReadIO();
            var result = readIO.GetFile(@"C:\temp\test.txt");

        }
        [TestMethod]
        public void TestGLoadData()
        {
            char[] seperator = new char[1];
            seperator[0] = '|';
            var loader = new RuleLoader();
            loader.LoadData(@"C:\temp\test.txt", seperator);

            var nounRule = Noun.Get();
            var verbrul = Verb.Get();

        }
    }
}
