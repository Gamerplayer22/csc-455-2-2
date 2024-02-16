using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csc_455_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            string x= "0";
            string str;

            List<string> dinosaurs = new List<string>();
            dinosaurs.Add("Gorgosaurus");
            dinosaurs.Add("Allosaurus");
            dinosaurs.Add("Aardonyx");
            dinosaurs.Add("Megalosaurus");
            dinosaurs.Add("Abrosaurus");
            dinosaurs.Add("Homalocephale");
            dinosaurs.Add("Alvarezsaurus");
            dinosaurs.Add("Datousaurus");
            dinosaurs.Add("Ammosaurus");
            dinosaurs.Add("Capitalsaurus");

            while (choice == 1)
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("1. random number");
                Console.WriteLine("2. today`s date");
                Console.WriteLine("3. list of dinosaurs");
                Console.WriteLine("4. string magic");
                Console.WriteLine("5. exit");
                Console.WriteLine("Choose 1-5:");
                x = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                
                if (x == "1") 
                {
                    Random rnd = new Random();
                    Console.WriteLine("The random number: {0}",rnd.Next(10)+1);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "2") 
                {
                    DateTime thisDay = DateTime.Today;
                    Console.WriteLine("Today's date: {0}",thisDay.ToShortDateString());
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "3") 
                {
                    Console.WriteLine("unordered list: ");
                    foreach (string d in dinosaurs)
                        Console.WriteLine(d);
                    Console.WriteLine();
                    Console.WriteLine("ordered list: ");

                    var result = dinosaurs.OrderBy(n=>n);

                    foreach(var d in result)
                        Console.WriteLine(d);
                    Console.WriteLine();
                    Random rnd = new Random();                    
                    Console.WriteLine("Random dinosaur picked: {0}", dinosaurs[rnd.Next(10)]);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "4") 
                {
                    Console.WriteLine("give a string, at least 10 characters: ");
                    str = Console.ReadLine();
                    Random rnd= new Random();
                    Console.WriteLine("something random happens to the string:");
                    switch (rnd.Next(10))
                    {
                        case 0:
                            Console.WriteLine(str.Reverse());
                            break;
                        case 1:
                            Console.WriteLine(str.Substring(1,3));
                            break;
                        case 2:
                            Console.WriteLine(str.ToUpper());
                            break;
                        case 3:
                            Console.WriteLine(str.ToLower());
                            break;
                        case 4:
                            Console.WriteLine(str.GetHashCode());
                            break;
                        case 5:
                            Console.WriteLine(str.Replace('a','e'));
                            break;
                        case 6:
                            Console.WriteLine(str.Remove(2,4));
                            break;
                        case 7:
                            Console.WriteLine(str.Split());
                            break;
                        case 8:
                            Console.WriteLine("letter 'a' first occurrance: {0}",str.IndexOf('a'));
                            break;
                        case 9:
                            Console.WriteLine("letter 'a' last occurrance: {0}",str.LastIndexOf('a'));
                            break;
                    }

                }
                if (x == "5") { choice = 0; }
            }
        }
    }
}