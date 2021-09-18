using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai;
            //kui kasutaja sai "A", konsool kuvab "Suurepärane!";
            //kui tulemus on "B", konsool kuvab "Väga hea!";
            //kui tulemus on "C", konsool kuvab "Hea!";
            //"D", konsool kuvab "Rahuldav";
            //"E", konsool kuvab "Kasin";
            //"F", konsool kuvab "Puudulik";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus".

            //kasutame SWITCH

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A': //if(userResult == 'A')
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav.");
                    break;
                case 'E':
                    Console.WriteLine("Kasin.");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik.");
                    break;
                default:
                    Console.WriteLine($"Vale väärtus.");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
