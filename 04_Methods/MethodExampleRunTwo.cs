using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExampleRunTwo
    {
        //Input
        //What we do
        //Output

        //Access modifier   Return Type  Method Signature(Name and List of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int diff = a - b;
            return diff;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }


        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int sumTwo = AddTwoNumbers(5, 42);
            Assert.AreEqual(47, sumTwo);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);



        }
    }
}
