using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        //FIELDS
        private string firstname;
        private string lastname;
        private string ssn;

        private decimal monthlyBaseSalary;
        private decimal monthlyBonusSalary;
        private decimal christmasBonus;

        private const decimal TopTaxLimit = 467300m;
        private const double TopTaxRate = 0.15;
        private const double NormalTaxRate = 0.37;

        //PROPERTIEs
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public decimal MonthlyBaseSalary
        {
            get { return monthlyBaseSalary; }
            set { monthlyBaseSalary = value; }
        }

        public decimal MonthlyBonusSalary
        {
            get { return monthlyBonusSalary; }
            set { monthlyBonusSalary = value; }
        }

        public decimal ChristmasBonus
        {
            get { return christmasBonus; }
            set { christmasBonus = value; }
        }

        //CONSTRUCTORS
        public Employee(string firstname, string lastname, string ssn, decimal monthlyBaseSalary, decimal monthlyBonusSalary, decimal christmasBonus)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.ssn = ssn;
            this.monthlyBaseSalary = monthlyBaseSalary;
            this.monthlyBonusSalary = monthlyBonusSalary;
            this.christmasBonus = christmasBonus;
        }

        //METHODS
        public decimal GetMonthlyPayout()
        {
            return (monthlyBaseSalary + monthlyBonusSalary) * 0.63m;
        }

        public decimal GetYearlyPayout()
        {
            decimal payout = GetMonthlyPayout() * 12 + christmasBonus;
            if (payout > TopTaxLimit)
            {
                decimal difference = payout - TopTaxLimit;
                difference *= 0.85m;
                payout = TopTaxLimit + difference;
            }
            return payout;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} - {SSN}";
        }
    }
}
