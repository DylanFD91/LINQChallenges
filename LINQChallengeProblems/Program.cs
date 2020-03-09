using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallengeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Using LINQ, write a function that returns all words that contain the substring “th” from a list.
                List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };
            */
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> wordsWith_th = words.FindAll(m => m.Contains("th"));
            foreach (var word in wordsWith_th)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
            /*
            2. Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
                List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" }; *UNION LIST METHOD*
            */
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> tempList = new List<string>();
            var namesNoDupes = names.Union(tempList);
            foreach (var item in namesNoDupes)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            /*
            3. Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student. The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
                List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                 };
                Expected output: 86.125
            */
            List<string> classGrades = new List<string>(){
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };// Original list

            classGrades.ForEach(m => m.Split(',').ToArray().Select(s => int.Parse(s)).OrderByDescending(h => h));


            /*
                4. Write a function that takes in a string of letters (i.e. “Terrill”) and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")

             */
        }
    }
}
