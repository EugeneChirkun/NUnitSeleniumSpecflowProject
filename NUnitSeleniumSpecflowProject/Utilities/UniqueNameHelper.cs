using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitSeleniumSpecflowProject.Utilities
{
    public class UniqueNameHelper
    {
        private readonly static Random random = new();

        public static string Generate(string root)
        {
            return root + Guid.NewGuid();
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomStringWithNumbers(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int RandomNumber()
        {
            return random.Next();
        }

        public static int RandomNumber(int maxNumber)
        {
            return random.Next(maxNumber);
        }

        public static int RandomNumber(int minNumber, int maxNumber)
        {
            return random.Next(minNumber, maxNumber);
        }

    }
}
