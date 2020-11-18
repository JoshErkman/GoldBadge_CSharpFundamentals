using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExmples
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 31;

            byte someByte = 23;

            int anotherNumber = 47;

            anotherNumber = 49;

            // double doesnt need a suffix
            double someDouble = 23.234567;

            // float needs a suffix of f
            float someFloat = 23.2345f;

            // float needs a suffix of m
            decimal someDecimal = 23.34567m;

            char letter = 'm';

            bool someBool = true;
        }

        [TestMethod]
        public void RefrenceTypes()
        {
            string randomCharacters = "asdfl;ksjf;as ;asldkja;sdjf";
            string specialCharacters = "\"Josh\"";
            Console.WriteLine(specialCharacters);

            DateTime rightNow = DateTime.Now;

            //array
            string[] names = { "casey", "michael", "simon" };
        }
    }
}
