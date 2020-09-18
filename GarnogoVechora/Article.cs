using System;
using System.Collections.Generic;
using System.Text;

namespace GarnogoVechora
{
    class Article : IRateAndCopy, ICloneable
    {
        public double Rating { get; }
        public Person Info { get; set; }
        public string Title { get; set; }
        //public double Rate { get; set; }

        public Article(string title, double rate)
        {
            Title = title;
            Rating = rate;
            Info = new Person("Dan", "Brown", new DateTime(1964, 6, 22));
        }

        public Article()
        {
            Title = "Forbes";
            Rating = 8.8;
            Info = new Person();
        }
        public object Clone()
        {
            return new Article { Info = this.Info, Title = this.Title };
        }

        public virtual object DeepCopy()
        {
            Article a = new Article();

            a.Title = this.Title;
            a.Info = this.Info;

            return a;
        }

        public override string ToString()
        {
            return $"About person: {Info}. Title: {Title}. It`s rate: {Rating}.";
        }

        public string ToShortString()
        {
            return $"Title: {Title}. It`s rate: {Rating}.";
        }

    }
}
