using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.BasicOOP.OOPTest
{
    class Student
    {
        //FIELDS
        private string name;
        private string currentCourse;
        private DateTime admissionDate;

        //PROPERTIES
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string CurrentCourse
        {
            get { return currentCourse; }
            set
            {
                if (value != null)
                {
                    currentCourse = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public DateTime AdmissionDate
        {
            get { return admissionDate; }
            set
            {
                if (value <= DateTime.Now)
                {
                    admissionDate = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //CONSTRUCTORS
        public Student(string name, string currentCourse, DateTime admissionDate)
        {
            Name = name;
            CurrentCourse = currentCourse;
            AdmissionDate = admissionDate;
        }

        //METHODS
        public override string ToString()
        {
            return $"{name} - {currentCourse} - {admissionDate}";
        }

        public TimeSpan TimeUntilGraduation()
        {
            DateTime gradDate = AdmissionDate.AddYears(3);
            TimeSpan gradTime = gradDate.Subtract(DateTime.Now);
            return gradTime;
        }
        public TimeSpan TimeFromAdmission()
        {
            TimeSpan admTime = DateTime.Now.Subtract(AdmissionDate);
            return admTime;
        }
    }
}
