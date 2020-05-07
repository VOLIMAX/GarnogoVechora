using System;

namespace GarnogoVechora
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine f = new Magazine();            
            f.AddArticle("Point of deception", 8.5);
            f.AddArticle("Source", 10);
            f.AddArticles(new Article("sds", 9.2), new Article("qweqe", 10) );
            //foreach (Article collection in f.dobirka)
            //{
            //    Console.Write("Book`s title: " + collection.Title + ", ");
            //    Console.WriteLine("Book`s rate: " + collection.Rate);
            //}
            //Console.WriteLine(f.ToShortString());
            //Console.WriteLine(f.ToString());
            
            Console.WriteLine(f.ToString());
        }
    }
}
