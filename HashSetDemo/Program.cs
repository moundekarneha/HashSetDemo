using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stud = new SortedSet<string>();  //HashSet
            stud.Add("Alan");  
            stud.Add("John");
            stud.Add("John");
            stud.Add("John");
            foreach (var item in stud)
            {
                Console.WriteLine("Data = " + item);
            }
            Console.ReadLine();
        }
    }
}
