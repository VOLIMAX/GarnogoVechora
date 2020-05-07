using System;

namespace GarnogoVechora
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine f = new Magazine();
            Console.WriteLine(f.ToShortString());
            Console.WriteLine(f.ToString());            
            f.AddArticles(new Article("Point of deception", 9.2), new Article("Source", 10) );                                    
            Console.WriteLine(f.ToString());
        }
    }
}
