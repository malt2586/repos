using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Department
    {
        //FIELDS
        private List<Employee> employees;
        private bool isBudgetExceeded;
        private decimal yearlyBudget;

        private decimal monthlyPayout;
        private decimal yearlyPayout;

        //PROPERTIES
        public IReadOnlyList<Employee> Employees
        {
            get { return employees; }
        }

        public bool IsBudgetExceeded
        {
            get
            {
                CalculateBudgetExcession();
                return isBudgetExceeded;
            }
        }

        public decimal YearlyBudget
        {
            get { return yearlyBudget; }
            set { yearlyBudget = value; }
        }

        public decimal MonthlyPayout
        {
            get
            {
                CalculateMonthlyPayout();
                return monthlyPayout;
            }
        }

        public decimal YearlyPayout
        {
            get { return MonthlyPayout * 12; }
        }

        //CONSTRUCTORS
        public Department(List<Employee> employees, decimal yearlyBudget)
        {
            this.employees = employees;
        }

        //METHODS
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee GetEmployeeBy(string ssn)
        {
            return employees.Find(x => x.SSN == ssn);
        }

        public Employee GetEmployeeBy(string firstnames, string lastnames)
        {
            return employees.Find(x => x.Firstname == firstnames && x.Lastname == lastnames);
        }

        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }

        private void CalculateBudgetExcession()
        {
            if (YearlyPayout > yearlyBudget)
            {
                isBudgetExceeded = true;
            }
        }

        private void CalculateMonthlyPayout()
        {
            decimal payout = 0;
            foreach (Employee e in employees)
            {
                payout += e.GetMonthlyPayout();
            }
            monthlyPayout = payout;
        }
    }
}
