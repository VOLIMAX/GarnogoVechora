using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace GarnogoVechora
{
    class Magazine : Edition, IRateAndCopy
    {
            
        private Frequency Period { get; set; }
        public Article Titlee { get; private set; }

        private double aver = 0;
        public double Aver
        {
            get
            {
                foreach (Article collection in dobirka)
                {
                    aver += collection.Rating;
                }
                return aver / dobirka.Count;
            }
        }
        private ArrayList SpysokReadktoriv = new ArrayList();
        private ArrayList dobirka = new ArrayList();

        //властивість типу System.Collections.ArrayList для доступу до поля зі списком статей в журналі;
        //властивість типу Edition; метод get властивості повертає об`єкт типу Edition, дані якого збігаються з даними підоб`єкту базового класу, метод set привласнює значення полів з підоб`єкту базового класу.
        public Magazine(string nazvaVydaniya, Frequency period, DateTime dataVydaniya, int turazhVydaniya) : base(nazvaVydaniya, dataVydaniya, turazhVydaniya)
        {
            Period = period;
            Titlee = new Article("title1", 9);
        }

        public Magazine() : base()
        {
            Period = Frequency.Weekly;
            Titlee = new Article();
        }

        public override object DeepCopy()
        {
            Magazine m = new Magazine();
            m.NazvaVydaniya = this.NazvaVydaniya;
            m.Period = this.Period;
            m.Titlee = this.Titlee;
            m.TurazhVydaniya = this.TurazhVydaniya;
            return m;
        }

        public void AddArticles(params Article[] articleList)
        {
            foreach (Article qq in articleList)
            {
                dobirka.Add(qq);
            }
        }

        public void AddEditors(params Person[] editorList)
        {
            foreach (Person qq in editorList)
            {
                SpysokReadktoriv.Add(qq);
            }
        }

        public IEnumerable GetBooks(double rate)
        {           
            foreach (Article qq in dobirka)
            {
                if (qq.Rating > rate)
                    yield return qq;                
            }                        
        }

        public IEnumerable GetRyadok(string qw)
        {           
            foreach (Article qq in dobirka)
            {
                int indexOfString = qq.Title.IndexOf(qw);
                if (indexOfString >= 0 && indexOfString < 100)
                    yield return qq;
            }            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            foreach (Article qq in dobirka)
            {
                sb.Append($"{qq.Title}, ");
            }

            foreach (Person qq in SpysokReadktoriv)
            {
                sb.Append($".\n Articles of such editors as: {qq.Name} {qq.Sname},  ");
            }

            return $"\n'{NazvaVydaniya}' is being published {Period}. There are some articles, which you can find in the magazine: {sb}. \nFirst was released at {DataVydaniya}. The whole amount of circulation = {TurazhVydaniya}. \nIn the article - {Titlee}\n ";
        }

        public string ToShortString()
        {
            return $"\n'{NazvaVydaniya}' is being published {Period}. The average rating of all articles: {Aver}. \nFirst was released at {DataVydaniya}. The whole amount of circulation = {TurazhVydaniya}. \n\t\t\t\t\tIn the article:\n{Titlee}\n";
        }

        public Frequency this[int q]
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
