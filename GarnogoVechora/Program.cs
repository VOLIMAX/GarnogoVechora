using System;

namespace GarnogoVechora
{
    class Program
    {
        static void Main(string[] args)
        {
            Edition e = new Edition();
            Edition ee = new Edition();
            bool qq = e.Equals(ee);
            Console.WriteLine($"e equals ee = {qq}");
            Console.WriteLine($"e`s hackcode = {e.GetHashCode()}\n ee`s hackcode = {ee.GetHashCode()}");

            //e.TurazhVydaniya = -10;
            //Console.WriteLine(e.TurazhVydaniya);

            Magazine f = new Magazine();            
            f.AddArticles(new Article("Point of deception", 8.2), new Article("Source", 9.3), new Article("Robinson Cruso", 6.2), new Article("Witcher", 10), new Article("Mister Mercedes", 9.9), new Article("The rise of cannibal", 8) );
            f.AddEditors(new Person());
            Console.WriteLine(f.ToString());

            Console.WriteLine($"Title: {f.NazvaVydaniya}, Published on {f.DataVydaniya}, Circulation of publication {f.TurazhVydaniya}");

            f.DeepCopy();

            Console.WriteLine($"\nBooks with rate more than 9.5:");
            foreach (Article a in f.GetBooks(9.5))
            {
                Console.WriteLine(a.Title);
            }

            Console.WriteLine($"\nTitle`s which have a certain string in their names");
            foreach (Article a in f.GetRyadok("M"))
            {
                Console.WriteLine(a.Title);
            }
        }
    }
}
