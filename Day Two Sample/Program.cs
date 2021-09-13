using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Two_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Software is Awesome.");

            //SampleMethod();
            MeetAlien();
            Console.ReadKey();
        }

        static void SampleMethod()
        {
            Random numGen = new Random();
            int number = numGen.Next(0, 20);
            Console.WriteLine(number);
            
            Console.ReadKey();
            SampleMethod();
        }

        static void MeetAlien()
        {
            Random numGen = new Random();
            string name = "X-" + numGen.Next(10, 9999);
            int age = numGen.Next(10, 500);

            Console.WriteLine($"Howdy, I'm {name}.");
            Console.WriteLine($"I'm {age} years old.");
            Console.WriteLine($"Oh and I am a alien.");
            Console.ReadKey();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            MeetAlien();
        }



    }
}
