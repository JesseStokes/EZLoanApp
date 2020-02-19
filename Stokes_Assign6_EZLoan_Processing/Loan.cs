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
    class Loan
    {
        private string loanNumber;
        private string customerFirst;
        private string customerLast;
        private double interestRate;
        private double loanAmount;
        private double termYears;

        public Loan()
        {
        }
        public Loan(double rate, double amtBorrowed, double time)
        {
            InterestRate = rate;
            LoanAmount = amtBorrowed;
            TermYears = time;
        }
        public Loan(string first, string last,
        double rate, double amtBorrowed, double time)
        {
            CustomerFirst = first;
            CustomerLast = last;
            InterestRate = rate;
            LoanAmount = amtBorrowed;
            TermYears = time;
        }
        public string LoanNumber { get => LoanNumber; set => LoanNumber = value; }
        public string CustomerFirst { get => customerFirst; set => customerFirst = value; }
        public string CustomerLast { get => customerLast; set => customerLast = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double TermYears { get => termYears; set => termYears = value; }
        public override string ToString()
        {
            return "Customer: " + customerFirst + " " +
            customerLast +
           "\nLoan amount: " + LoanAmount.ToString("C") +
            "\nInterest Rate: " + InterestRate.ToString("p1") +
            "\nLoan Duration: " + TermYears;
        }
    }
}
