using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kā Tevi sauc?");

            string myName = Console.ReadLine();

            Console.WriteLine($"Sveiks, {myName}");

            //--------------------------------------------------------------------------------------

            Console.WriteLine("Kāds ir tavs vecums?");

            string myAgeTxt = Console.ReadLine();

            int myAge = int.Parse(myAgeTxt);

            int ageNextYear = myAge++;

            bool isAdult = myAge >= 18;

            Console.WriteLine($"Nākamgad Tev paliks {myAge}, Tu esi pilngadīgs: {isAdult}");


            //---------------------------------------------------------------------------------------





        }
    }
}
