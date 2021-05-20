using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using kata1_Anagrams;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAnagrams
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GetAnagrams getAnagrams = new GetAnagrams();
            string path = @"C:\Users\Mario\Desktop\tendencias de aplic\kata1\kata1 Anagrams\words.txt";
            int estimateVal = 20683;

            IEnumerable<string> anagrams = getAnagrams.Get(path);
            Assert.AreEqual(anagrams.Count(), estimateVal);
        }
    }
}
