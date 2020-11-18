using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExample
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;

            //1 starting point
            //2 condition while true keeps the loop running
            //3 what happens after each loop
            //4 body of the loop, what happens each iteration

            for (int i = 0; i < studentCount; i++) // i = i + 1
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForEachLoop()
        {
            string name = "Eleven Fifty Academy";

            //1 collection that is being worked on
            //2 name of the current iteration being used
            //3 current type in the collection
            //4 in keyword, used to seperate that individual and the collection
            //5 body of the loop

            //foreach //3  //2  //4  //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter); //5
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 Loop runs while the condition is true
            //2 The body of the loop

            while (total != 30)
            {
                Console.WriteLine(total);
                total++;
            }
        }
    }
}
