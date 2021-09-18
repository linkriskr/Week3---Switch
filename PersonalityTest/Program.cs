using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisetada tema lemmik värv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
