using System;
using System.Collections.Generic;
using System.Text;

namespace GarnogoVechora
{
    public enum Frequency
    {
        Weekly,
        Monthly,
        Yearly
    }

    class Person
    {
        private string Name { get; set; }
        private string Sname { get; set; }
        private DateTime date = new DateTime();
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Person(string name, string sname, DateTime date)
        {
            Name = name;
            Sname = sname;
            Date = date;
        }
        public Person()
        {
            Name = "Endi";
            Sname = "Grove";
            Date = new DateTime(1958, 4, 17);
        }
        public override string ToString()
        {
            return $"{Name} {Sname} was born on {Date}";
        }
        public string ToShortString()
        {
            return $"{Name} {Sname}";
        }
    }

    class Article
    {
        public Person Info { get; set; }
        public string Title { get; set; }
      
        public double Rate { get; set; }
        public Article(string title, double rate)
        {
            Title = title;            
            Rate = rate;
            Info = new Person("Dan","Brown",new DateTime(1964, 6, 22) );
        }
        public Article()
        {
            Title = "Forbes";           
            Rate = 8.8;
            Info = new Person();
        }
        public override string ToString()
        {
            return $"About person: {Info}. Title: {Title}. It`s rate: {Rate}.";
        }
        public string ToShortString()
        {
            return $"Title: {Title}. It`s rate: {Rate}.";
        }
    }

    class Magazine
    {
        public string MagName { get; private set; }
        public Frequency Period { get; private set; }
        public DateTime ReleaseTime { get; private set; }
        public int Amount { get; private set; }
        public Article Titlee{ get; private set; }     
        public string Nazva { get; set; }
        public double Ratingp { get; set; }
        private double aver = 0;
        public double Aver
        {
            get 
            {
                foreach (Article collection in dobirka)
                {
                    aver += collection.Rate;
                }                
                return  aver / dobirka.Count;                
            }
        }
        public List<Article> dobirka = new List<Article>() { };
        public Magazine(string magName, Frequency period, DateTime releaseTime, int amount)
        {
            MagName = magName;
            Period = period;
            ReleaseTime = releaseTime;
            Amount = amount;
            Titlee = new Article("title1", 9);
        }
        public Magazine()
        {
            MagName = "Hello Home";
            Period = Frequency.Weekly;
            ReleaseTime = new DateTime(2015, 1, 25);
            Amount = 5000;
            Titlee = new Article();
        }
        public void AddArticle(string nazva, double ratingp)
        {
            Nazva = nazva;
            Ratingp = ratingp;
            dobirka.Add(new Article(nazva, ratingp));
        }
        public void AddArticles(params Article[] articleList)
        {
            foreach (Article qq in articleList)
            {
                dobirka.Add(qq);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Статт1: ");
            foreach (Article qq in dobirka)
            {
                sb.Append($"{qq.Title}, ");
            }
            return $"\n'{MagName}' is being published {Period}. There are some articles, which you can find in the magazine: {sb}. \nFirst was released at {ReleaseTime}. The whole amount of circulation = {Amount}. \nIn the article {Titlee}\n";
        }
        public string ToShortString()
        {
            return $"\n'{MagName}' is being published {Period}. The average rating of all articles: {Aver}. \nFirst was released at {ReleaseTime}. The whole amount of circulation = {Amount}. \n\t\t\t\t\tIn the article:\n{Titlee}\n";
        }

        public Frequency this [int q]
        {
            get
            {
                if (q == 1)
                    return Frequency.Monthly;
                else if (q == 2)
                    return Frequency.Weekly;
                else
                    return Frequency.Yearly;
            }
        }
    }

}