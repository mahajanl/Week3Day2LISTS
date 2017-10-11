using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day2LISTS
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testScores = new List<int>() { 22, 43, 56, 11, 4 };
            //testScores.Add(80);
            //testScores.Add(91);

            //List<int> luckyNumbers = new List<int> ();
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(9);
            //luckyNumbers.Add(4);
            //luckyNumbers.Add(1);
            //luckyNumbers.Add(11);
            //Console.WriteLine(luckyNumbers.Count);

            //List<string> faveFoods = new List<string>() { "turkey", "cheddar cheese", "avocados", "filled pasta", "gnocchi" };
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[1]);
            //Console.WriteLine(faveFoods[4]);

            //List<string> notFaveFoods = new List<string>();
            //notFaveFoods.Add("shrimp");
            //notFaveFoods.Add("soggy carbohydrates");
            //notFaveFoods.Add("rubber shoes");
            //notFaveFoods.Add("radishes");
            //Console.WriteLine(notFaveFoods[0]);
            //Console.WriteLine();

            //notFaveFoods[0] = "pizza";
            //Console.WriteLine(notFaveFoods[0]);
            //Console.WriteLine();

            //List<string> faveFilms = new List<string>() { "Labyrinth", "The Fifth Element", "Empire Records", "Fantasia" };

            //for (int i = 0; i < faveFilms.Count; i++)
            //{ Console.WriteLine(faveFilms[i]);
            //}
            //Console.WriteLine();

            //faveFilms.Insert(2, "Titan AE");

            //foreach (string film in faveFilms)
            //{ Console.WriteLine(film);
            //}
            //Console.WriteLine();

            //faveFilms.Remove("Fantasia");
            //faveFilms.Remove("Labyrinth");

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            List<string> animals = new List<string>();
            animals.Add("Horses");
            animals.Add("Dogs");
            animals.Add("Fish");
            animals.Add("Tortoises");
            animals.Add("Humans");

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            List<bool> answers = new List<bool>() { true, false, false, true, false };
            foreach (bool answer in answers)
            {
                if (answer == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }

            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            numbers.Remove(32);
            numbers.Remove(77);
            numbers.Remove(27);
            numbers.Remove(6);

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));


        }
    }
}
