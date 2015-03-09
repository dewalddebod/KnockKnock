using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using Readify.Services.Contracts;
using Readify.Services.Contracts.Data;

namespace Readify.Services
{
    public class RedPillServiceImplementation : IRedPill
    {
        #region Properties

        static readonly Dictionary<long, long> GResults = new Dictionary<long, long>();

        #endregion

        #region Contract Methods
        public Guid WhatIsYourToken()
        {
            try
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, string.Empty, string.Empty);
                return Properties.Settings.Default.Token;
            }
            catch (Exception exception)
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, string.Empty, exception.Message);
                throw;
            }
        }

        public long FibonacciNumber(long n)
        {
            try
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, n.ToString(), string.Empty);
                return Fibonacci(n);
            }
            catch (Exception exception)
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, n.ToString(), exception.Message);
                throw;
            }
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            try
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, string.Format("A:{0},B:{1},C:{2}", a, b, c), string.Empty);
                return GetTriangleType(a, b, c);
            }
            catch (Exception exception)
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, string.Format("A:{0},B:{1},C:{2}", a, b, c), exception.Message);
                throw;
            }
        }

        public string ReverseWords(string s)
        {
            try
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, s, string.Empty);
                return ReverseWordsInString(s);
            }
            catch (Exception exception)
            {
                WriteToLog(MethodBase.GetCurrentMethod().Name, s, exception.Message);
                throw;
            }
        }
        #endregion

        #region Private Methods

        private static long Fibonacci(long n)
        {
            var convertedToPositive = false;
            if (n > 92 || n < -92)
                throw new FaultException(string.Format("Fib(>92) will cause a 64-bit integer overflow.{0}Parameter name: n", Environment.NewLine));

            if (n < 0)
            {
                n = Math.Abs(n);
                convertedToPositive = true;
            }
                

            if (n < 2)
                return n;

            if (GResults.ContainsKey(n))
                return GResults[n];

            var result = Fibonacci(n - 1) + Fibonacci(n - 2);
            GResults.Add(n, result);

            if (convertedToPositive)
                result = result * -1;
            return result;
        }

        private static string ReverseWordsInString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            var words = value.Split(' ');
            var result = new StringBuilder();

            if (!words.Any()) return result.ToString();
            foreach (var word in words)
            {
                result.Append(string.Format("{0} ", ReverseWord(word)));
            }

            if (result.Length > 0)
                result.Remove(result.Length - 1, 1);

            return result.ToString();
        }

        private static string ReverseWord(string word)
        {
            var returnString = word.ToCharArray();
            Array.Reverse(returnString);
            return new string(returnString);
        }

        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            var resultantType = TriangleType.Error;

            var values = new[] { a, b, c };

            if (values.Any(x => x <= 1))
            {
                if (!values.All(x=> x == a && x > 0))
                    return resultantType;
            }

            if (values.Distinct().Count() == 1)
                resultantType = TriangleType.Equilateral;

            else if (values.Distinct().Count() == 2)
                resultantType = TriangleType.Isosceles;

            else if (values.Distinct().Count() == 3)
                resultantType = TriangleType.Scalene;

            return resultantType;
        }

        private void WriteToLog(string method, string values, string exp)
        {
            using (var testData = new StreamWriter(string.Format("{0}/log.txt", AppDomain.CurrentDomain.BaseDirectory), true))
            {
                testData.WriteLine("Method: {0}, Values:{1}, Exception: {2}", method, values, exp);
            }
        }

        #endregion
    }
}
