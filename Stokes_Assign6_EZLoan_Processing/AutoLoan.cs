using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Jesse Stokes
// 4/5/2019
// Assign7 EZLoan App

namespace Stokes_Assign6_EZLoan_Processing
{
    class AutoLoan : Loan
    {
        private int yearBuilt;
        private string model;
        private string make;
        private string autoColor;

        public AutoLoan()
        : base()
        {
        }
        public AutoLoan(double intRate, double prinBorrowed,
        double duration, int yr, string mod,
        string carMake)
        : base(intRate, prinBorrowed, duration)
        {
            YearBuilt = yr;
            Model = mod;
            Make = carMake;
        }
        public AutoLoan(string first, string last, double intRate, double prinBorrowed,
        double duration, int yr, string mod, string carMake)
        : base(first, last, intRate, prinBorrowed, duration)
        {
            YearBuilt = yr;
            Model = mod;
            Make = carMake;
        }
        public int YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public string AutoColor { get => autoColor; set => autoColor = value; }
        public override string ToString()
        {
            return base.ToString() +
            "\nType of Car: " +
            YearBuilt + " " +
            AutoColor + " " + Model;
        }
    }
}
