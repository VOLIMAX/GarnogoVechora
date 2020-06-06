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
    interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy(); // класс Object является базовым типом для всех классов
    }               
}