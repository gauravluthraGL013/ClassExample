using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
  
        class Person
        {
            // Member Variables
            // method s

            private string position { get; set; }
            private int salary { get; set; }
            private string department { get; set; }

            // Methods

            public void SetMember(string setposition, int setsalary, string setdepartment)
            {
                position = setposition;
                salary = setsalary;
                department = setdepartment;


            }

            public void GetMember(out string getposition, out int getsalary, out string getdepartment)
            {
                getposition = position;
                getsalary = salary;
                getdepartment = department;
            }


        }


    }


