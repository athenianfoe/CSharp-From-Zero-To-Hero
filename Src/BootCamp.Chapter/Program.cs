using System;

namespace BootCamp.Chapter
{
    class Programnnnnnn
    {
        static void Main(string[] args)
        {
            var name = Enter_input();
            var surname = Enter_input();
            var age = Enter_input();
            var weight = Enter_input();
            var height = Enter_input();
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height);

            var sum = calc_bmi(double.Parse(height), double.Parse(weight));
            Console.WriteLine(name + "\'s" + " BMI is " + sum);
         

        }

        private static string Enter_input()
        {
            return Console.ReadLine();
        }

        private static Double calc_bmi(double height, double weight)
        {
            return weight / Math.Pow((height*0.01), 2 );
        }
    }
}
