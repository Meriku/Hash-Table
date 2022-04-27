using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new HashTable2<int>(10);

            table.Add(500);
            table.Add(340);
            table.Add(140);
            table.Add(66);
            table.Add(770);

            Console.WriteLine(table.Search(500));   // True

            Console.WriteLine(table.Search(550));   // False


            Console.ReadLine();


        }
    }
}
