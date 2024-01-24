using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TabelAdevar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool p = true;
            bool q = false;

            byte bp = Convert.ToByte(p);
            byte bq = Convert.ToByte(q);

            Console.WriteLine("{0} converted to {1}.", p, bp);
            Console.WriteLine("{0} converted to {1}.", q, bq);
            Console.WriteLine("\n");

            Console.WriteLine("'AND' Truth Table\n");
            Console.WriteLine("__________________\n\n");
            Console.WriteLine("|  p  |  q  | p & q |");
            Console.WriteLine("|-----|-----|-------|");

            for (int a = 0; a <= 1; a++)
            {
                for (int b = 0; b <= 1; b++)
                {
                    bool an = p & q;
                    Console.WriteLine($"|  {p}  |  {q}  |   {an}       |");
                }
            }
            */

            Console.WriteLine("'AND' Truth Table\n");
            Console.WriteLine("__________________\n\n");
            Console.WriteLine("|  a  |  b  | a & b |");
            Console.WriteLine("|-----|-----|-------|");

            for (int a = 1; a >= 0; a--)
            {
                for (int b = 1; b >= 0; b--)
                {
                    int an = a * b;
                    Console.WriteLine($"|  {a}  |  {b}  |   {an}       |");
                }
            }

        }
    }
}

