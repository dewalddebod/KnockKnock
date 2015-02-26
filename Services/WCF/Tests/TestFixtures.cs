using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readify.Services.WCF.Tests.ReadifyService;

namespace Readify.Services.WCF.Tests
{
    [TestClass]
    public class TestFixtures
    {
        [TestMethod]
        public void GetWhosThereToken()
        {
            var client = new RedPillService.RedPillClient("BasicHttpBinding_IRedPill1");
            var response = client.WhatIsYourToken();

            Assert.IsTrue(!string.IsNullOrWhiteSpace(response.ToString()));
        }


        [TestMethod]
        public void FibonacciNumber()
        {
            var readifyClient = new ReadifyService.RedPillClient("BasicHttpBinding_IRedPill");
            var redPillClient = new RedPillService.RedPillClient("BasicHttpBinding_IRedPill1");
            long[] numbers = { -4, -5, 0, 1, -6, 3, 4, 5, 6, 7, 46, 47, 92, 2, -3, -1, -92, -47, -46, -7, -93, 93, -9223372036854775808, -2147483648, 2147483647, 9223372036854775807 };
            var exceptionOccured = false;
            foreach (var number in numbers)
            {
                long readifyResult = 0;
                long redPillResult = 0;
                try
                {
                    readifyResult = readifyClient.FibonacciNumber(number);
                }
                catch { }
                try
                {
                    redPillResult = redPillClient.FibonacciNumber(number);
                }
                catch {}
                if (readifyResult != redPillResult)
                    exceptionOccured = true;
            }
            Assert.IsFalse(exceptionOccured);
        }

        [TestMethod]
        public void ReverseWords()
        {
            var readifyClient = new ReadifyService.RedPillClient("BasicHttpBinding_IRedPill");
            var redPillClient = new RedPillService.RedPillClient("BasicHttpBinding_IRedPill1");

            string[] words = { "", "cat", "trailing space ", "Bang!", "", "cat and dog", "two  spaces", " leading space", "Capital", "This is a snark: ⸮", "P!u@n#c$t%u^a&t*i(o)n", "detartrated kayak detartrated", "¿Qué?", "  S  P  A  C  E  Y  ", "!B!A!N!G!S!" };
            foreach (var word in words)
            {
                var readifyResult = readifyClient.ReverseWords(word);
                var redPillResult = redPillClient.ReverseWords(word);

                Assert.AreEqual(readifyResult, redPillResult);
            }
        }

        [TestMethod]
        public void WhatShapeIsThis()
        {
            var readifyClient = new ReadifyService.RedPillClient("BasicHttpBinding_IRedPill");
            var redPillClient = new RedPillService.RedPillClient("BasicHttpBinding_IRedPill1");

            int[] a = { 0, 1, 1, 1, 2, 1, 1, 1, 2, 2147483647, 2, 2, 3, 2, 3, 4, 4, 1, -2147483648, -1, -1, 1, 1, 0, 2147483647 };
            int[] b = { 0, 1, 1, 0, 1, 2, 1, 1, 2, 2147483647, 2, 3, 2, 3, 4, 2, 3, 2, -2147483648, -1, 1, -1, 1, 1, 2147483647 };
            int[] c = { 0, 0, 2, 1, 1, 3, 2147483647, 1, 2, 2147483647, 3, 2, 2, 4, 2, 3, 2, 1, -2147483648, -1, 1, 1, -1, 1, 2147483647 };
            if (a.Length == b.Length && b.Length == c.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    var currentA = a[i];
                    var currentB = b[i];
                    var currentC = c[i];
                    var readifyResult = readifyClient.WhatShapeIsThis(a[i], b[i], c[i]);
                    var redPillResult = redPillClient.WhatShapeIsThis(a[i], b[i], c[i]);

                    Assert.AreEqual(readifyResult.ToString("G"), redPillResult.ToString("G"));
                }
            }
        }
    }
}
