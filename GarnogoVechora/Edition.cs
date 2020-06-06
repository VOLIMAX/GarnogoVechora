using System;
using System.Collections.Generic;
using System.Text;

namespace GarnogoVechora
{
    class Edition
    {
        public  double Rating { get; }

        private DateTime dataVydaniya;
        public DateTime DataVydaniya
        {
            get { return dataVydaniya; }
            set { dataVydaniya = value; }
        }

        private string nazvaVydaniya;
        public string NazvaVydaniya
        {
            get { return nazvaVydaniya; }
            set { nazvaVydaniya = value; }
        }

        private int turazhVydaniya;
        public int TurazhVydaniya
        {
            get { return turazhVydaniya; }
            set
            {
                if (value < 0)
                    throw new IndexOutOfRangeException("The number is less than zero!");

                turazhVydaniya = value;
            }
        }

        public Edition(string nazvaVydaniya, DateTime dataVydaniya, int turazhVydaniya)
        {
            NazvaVydaniya = nazvaVydaniya;
            DataVydaniya = dataVydaniya;
            TurazhVydaniya = turazhVydaniya;
        }

        public Edition()
        {
            NazvaVydaniya = "qqq";
            DataVydaniya = new DateTime(2020, 5, 13);
            TurazhVydaniya = 2020;
        }

        public virtual object DeepCopy()
        {
            return new Edition
            {
                DataVydaniya = DataVydaniya,
                NazvaVydaniya = NazvaVydaniya,
                TurazhVydaniya = TurazhVydaniya
            };
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Edition e = (Edition)obj;
            return (this.TurazhVydaniya == e.TurazhVydaniya);
        }

        public override int GetHashCode()
        {
            return TurazhVydaniya.GetHashCode() + DataVydaniya.GetHashCode() + NazvaVydaniya.GetHashCode();
        }

        public override string ToString()
        {
            return NazvaVydaniya + DataVydaniya + TurazhVydaniya;
        }

    }
}
