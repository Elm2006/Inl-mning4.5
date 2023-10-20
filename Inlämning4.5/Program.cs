using System;
namespace Inlämning_4.__5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string tal = Console.ReadLine();
            string talet = "";
            for (int i = 0; i < tal.Length; i++)
            {
                int nior = tal.IndexOf("9");
                string tecken = tal[i].ToString();
                int siffra = int.Parse(tecken);
                if (i != nior)
                {
                    siffra += 1;
                }
                else if (i == nior)
                {
                    siffra = 0;
                }
                talet += "" + siffra;
            }
            Console.WriteLine(talet);
        }
    }
}
