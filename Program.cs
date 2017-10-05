using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write Two Numbers");
            float number1 = float.Parse(Console.ReadLine ());
            float number2 = float.Parse(Console.ReadLine ());
            Console.WriteLine(AddTwoNumbers(number1, number2));
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }
    }
}
