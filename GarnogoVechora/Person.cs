using System;
using System.Collections.Generic;
using System.Text;

namespace GarnogoVechora
{
    class Person : ICloneable
    {
        public string Name { get; set; }
        public string Sname { get; set; }
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
            Name = "Endy";
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


        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Person person = (Person)obj;
            return this.Name == person.Name && 
                this.Sname == person.Sname &&
                this.Date == person.Date;
        }

        public object Clone()
        {
            return new Person { Name = this.Name, Sname = this.Sname, Date = this.Date };
        }

        public virtual object DeepCopy()
        {
            Person p = new Person();
            p.Name = this.Name;
            p.Sname = this.Sname;
            p.Date = this.Date;
            return p;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Sname.GetHashCode() + Date.GetHashCode();
        }
    }
}
