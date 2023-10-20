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
                Console.WriteLine(tal[i]);
                string tecken = tal[i].ToString();
                int siffra = int.Parse(tecken);
                if (i == nior)
                {
                    siffra = 0;
                }
                if(i+1 == tal.Length)
                {
                    siffra += 1;
                }
                talet += "" + siffra;
            }
            Console.WriteLine(talet);
        }
    }
}
