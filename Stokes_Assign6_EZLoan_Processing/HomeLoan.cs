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
    class HomeLoan : Loan
    {
        private string address;
        private int yearBuilt;
        private int sqFootage;

        public HomeLoan()
        : base()
        {
        }
        public HomeLoan(double intRate, double prinBorrowed, double duration,
        int yrBuilt, int sqFeet, string add)
        : base(intRate, prinBorrowed, duration)
        {
            YearBuilt = yrBuilt;
            SqFootage = sqFeet;
            Address = add;
        }
        public HomeLoan(string first, string last, double intRate, double prinBorrowed,
       double duration, int yrBuilt, int sqFeet, string add)
        : base(first, last, intRate, prinBorrowed, duration)
        {
            YearBuilt = yrBuilt;
            SqFootage = sqFeet;
            Address = add;
        }
        public string Address { get => address; set => address = value; }
        public int YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public int SqFootage { get => sqFootage; set => sqFootage = value; }
        public override string ToString()
        {
            return base.ToString() +
            "\nHome Loan Address: " + Address;
        }
    }
}
