using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata1_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnagrams getAnagrams = new GetAnagrams();
            string path = @"C:\Users\Mario\Desktop\tendencias de aplic\kata1\kata1 Anagrams\words.txt";


            List<string> anagramList = getAnagrams.Get(path).ToList();

            foreach (var item in anagramList)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine(anagramList.Count());
            Console.ReadKey();
        }
    }
}
