using System;

namespace RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            //string response;
            int tries = 0;
            int desiredValue = 5000;
            int maxTries = desiredValue * 5;
            int desiredValRand = desiredValue + 1;
            for (int i = 0; i < maxTries; i++)
            {
                tries++;
                value = Random(desiredValRand);
                //response = value == desiredValue ? "Got it!" : "Didn't get it.";             
                //Console.WriteLine(response);
                if (value == desiredValue)
                {
                    Console.WriteLine("It took " + tries + " tries");
                    break;
                }
            }
            if (tries >= maxTries)
            {
                Console.WriteLine("It took over " + maxTries + " attempts to roll the desired value of " + desiredValue);
            }
        }

        static int Random(int desiredValue)
        {
            Random random = new Random();
            int myVal = random.Next(0, desiredValue);
            return myVal;
        }
    }
}
