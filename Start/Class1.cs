using Pillow;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            //string nimi = "Python";
            //Alamprogramm.Tere(nimi);
            //double arithm = Alamprogramm.Arith(2);
            //Console.WriteLine(arithm);
            //Console.WriteLine(Alamprogramm.Stars(20));
            Alamprogramm.NStars();

            //Random random = new Random();

            //int secretNumber = random.Next(1, 11);
            //int tries = 5;

            //Console.WriteLine("Arvuti arvas ära arvu vahemikus 1 kuni 10. Teil on {0} katset seda ära arvata.", tries);

            //for (int i = 0; i < tries; i++)
            //{
            //    Console.Write("Proovige numbrit {0}: sisestage number: ", i + 1);
            //    int guess = int.Parse(Console.ReadLine());

            //    if (guess == secretNumber)
            //    {
            //        Console.WriteLine("arvasid numbri ära {0}!", secretNumber);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sa ei arvanud numbrit ära {0}.", guess);
            //    }
            //}

            //Console.WriteLine("Mäng läbi. Arvuti arvas numbri ära {0}.", secretNumber);

            //Console.ReadLine();

            //int n = random.Next(-100, 100);
            //int m = random.Next(n, 21);
            //if (n < 0)
            //{
            //    n = Math.Abs(n);
            //}

            //if (m < 0)
            //{
            //    m = Math.Abs(m);
            //}

            //int[] numbers = new int[m - n + 1];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = n + i;
            //}

            //Console.WriteLine("numbrit {0} kuni {1}:", n, m);

            //foreach (int number in numbers)
            //{
            //    int square = number * number;
            //    Console.WriteLine("{0} * {0} = {1}", number, square);
            //}

            //Console.ReadLine();

            //int[] arvud = new int[10];

            //Console.WriteLine("Sisestage 5 numbrit:");

            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    Console.Write("Number {0}: ", i + 1);
            //    arvud[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //int product = 1;

            //foreach (int arv in arvud)
            //{
            //    sum += arv;
            //    product *= arv;
            //}

            //double average = (double)sum / arvud.Length;

            //Console.WriteLine("Summa: {0}", sum);
            //Console.WriteLine("Keskmine: {0}", average);
            //Console.WriteLine("Tulemus: {0}", product);

            //Console.ReadLine();
            //string userInput = "";

            //while (userInput.ToLower() != "elevant")
            //{
            //    Console.WriteLine("Osta elevanti!");
            //    userInput = Console.ReadLine().ToLower();
            //}

            //Console.WriteLine("Aitäh, et sa ostanud elevanti!");
            //Console.ReadLine();

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0,4}", i * j);
            //    }
            //    Console.WriteLine("\n");
            //}

            //Console.WriteLine("Sisestage 4 numbrit:");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());

            //int largo = Math.Max(Math.Max(Math.Max(num1, num2), num3), num4);

            //if (largo >= 1000 && largo <= 9999)
            //{
            //    Console.WriteLine($"suurim 4-kohaline arv on: {largo}");
            //}
            //else
            //{
            //    Console.WriteLine("Neljakohalisi numbreid pole.");
            //}

            //Console.ReadLine();

        }

    }


    //string paev = "";
    //Random rnd = new Random();
    //for (int i = 0; i < 10; i++)
    //{
    //    int nr = rnd.Next(1, 7);
    //    Console.WriteLine(nr);
    //    switch (nr)
    //    {
    //        case 1: paev = "Esmaspäev"; break;
    //        case 2: paev = "Teisipäev"; break;
    //        case 3: paev = "Kolmapäev"; break;
    //        case 4: paev = "Neljapäev"; break;
    //        case 5: paev = "Reede"; break;
    //        case 6: paev = "Laupäev"; break;
    //        case 7: paev = "Pühapäev"; break;
    //        default:
    //            paev = "Tundmata päev";
    //            break;
    //    }
    //    Console.WriteLine(paev);
    //}
    //int j = 0;
    //while (j<10)
    //{
    //    Console.WriteLine(paev);
    //    j++;
    //}
    //Console.WriteLine(j);
    //do
    //{
    //    Console.WriteLine(paev);
    //    j--;
    //} while (j!=0);
    //Console.WriteLine(j);
    //int[] arvud = new int[10];
    //for (int i = 0; i < arvud.Length; i++)
    //{
    //    arvud[i] = rnd.Next(-100, 100);
    //}
    //foreach (int arv  in arvud)
    //{
    //    Console.WriteLine(arv);

    //}


    //    Console.WriteLine("Tere tulemast mis sinu nimi on?");
    //    string eesnimi = Console.ReadLine();
    //    Console.WriteLine("Tere, " + eesnimi);
    //    if (eesnimi.ToLower() == "juku")
    //    {
    //        Console.WriteLine("Tule minu juurde külla! Kui vana sa oled?");
    //        int vanus = int.Parse(Console.ReadLine());
    //        if (vanus < 1 || vanus > 100)
    //        {
    //            Console.WriteLine("Viga!");
    //        }
    //        else if (vanus < 6)
    //        {
    //            Console.WriteLine("Tasuta!");
    //        }
    //        else if (vanus < 15)
    //        {
    //            Console.WriteLine("Lastepilet");
    //        }
    //        else if (vanus < 66)
    //        {
    //            Console.WriteLine("Täispilet");
    //        }
    //        else if (vanus > 66)
    //        {
    //            Console.WriteLine("Soodustuspilet");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Täna mind kodus pole!");
    //    }
}
