using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] sachovnice = new string[,] { {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "},
                                                   {" ", " ", " ", " ", " ", " ", " ", " "} };

            string vstupbila = "a2, b2, c3, f2, h4, Kb1, Vc1, Sd3, Se3";
            string vstupcerna = "a7, b7, c7, f7, g6, h5, Ke8, Va8, Sd6, Je5";

            char[] separators = new char[] { ' ', ',' };
            string[] subsb = vstupbila.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] subsc = vstupcerna.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var subb in subsb)
            {
                Console.WriteLine($"Substring bile: {subb}");
            }
            Console.WriteLine("");
            foreach (var subc in subsc)
            {
                Console.WriteLine($"Substring cerne: {subc}");
            }
            Console.ReadKey();
        }
    }
}
