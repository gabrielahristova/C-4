using System;
using System.Collections.Generic;
using System.Text;

namespace NameAndAge
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public int Age { get => age; private set =>  age = value; }
        public decimal Salary { get => salary; private set => salary = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}
