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

            Console.WriteLine("Ievadi skaitli:");
            string number1Txt = Console.ReadLine();
            int number1 = int.Parse(number1Txt);
            Console.WriteLine("Ievadi vēl vienu skaitli:");
            string number2Txt = Console.ReadLine();
            int number2 = int.Parse(number2Txt);
            int numberMax = Math.Max(number1, number2);
            Console.WriteLine($"{numberMax} ir lielākais skaitlis!");

            //---------------------------------------------------------------------------------------

            Console.WriteLine("Ievadi vēl vienu skaitli:");
            string number3Txt = Console.ReadLine();
            int number3 = int.Parse(number3Txt);
            Console.WriteLine("Ievadi vēl pēdējo skaitli:");
            string number4Txt = Console.ReadLine();
            int number4 = int.Parse(number4Txt);
            int numberMin = Math.Min(number3, number4);
            Console.WriteLine($"{numberMin} ir mazākais skaitlis!");

            //---------------------------------------------------------------------------------------

            Console.WriteLine("Ievadi skaitli, kuru Tu gribi sadalīt:");
            string number5Txt = Console.ReadLine();
            int number5 = int.Parse(number5Txt);
            Console.WriteLine("Ievadi skaitli, ar kuru Tu gribi sadalīt:");
            string number6Txt = Console.ReadLine();
            int number6 = int.Parse(number6Txt);
            int numberAtlikums = number5 % number6;
            string outputText = string.Format("Dalījuma atlikums ir {0}", numberAtlikums);
            Console.WriteLine(outputText);

            //---------------------------------------------------------------------------------------

            Console.WriteLine("Ievadi skaitli, lai noteiktu vai tas ir pāra vai nepāra skaitlis:");
            string number7Txt = Console.ReadLine();
            int number7 = int.Parse(number7Txt);
            bool paraSkaitlis = number7 % 2 == 0;
            string outputText2 = string.Format("{0} ir pāra skaitlis: {1}", number7, paraSkaitlis);
            Console.WriteLine(outputText2);

            //---------------------------------------------------------------------------------------

            double a;
            double b;
            double S;
            Console.WriteLine("Ievadi taisnstūra malas garumu:");
            string aTxt = Console.ReadLine();
            a = double.Parse(aTxt);
            Console.WriteLine("Ievadi taisnstūra malas platumu:");
            string bTxt = Console.ReadLine();
            b = double.Parse(bTxt);
            S = Math.Round(a * b, 2);
            Console.WriteLine($"Taisnstūra laukums ir {S}");








        }
    }
}
