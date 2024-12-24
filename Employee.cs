using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public enum SecurityPrivilege
    {
        Guest,
        Secretary,
        Developer,
        DBA
    }

    //internal class Employee
    //{
    //}

    public class Employee
    {
        #region Attributes Or Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }


        #endregion


        // Constructor
        public Employee(int id, string name, SecurityPrivilege securityLevel,
                   decimal salary, DateTime hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        #region Method
        public override string ToString()
        {
            return $"Employee ID: {Id}\n Name: {Name}\n Security Level: {SecurityLevel}\n Salary: {Salary}\n Hire Date: {HireDate}\nGender: {(Gender == Gender.M ? "Male" : "Female")}";
        }
        #endregion

    }

    // Enum for Gender
    #region #03
    /*We need to restrict the Gender field to be only M or F [Male or Female] */
    public enum Gender
        {
            M,  // Male
            F   // Female
        }

    #endregion

    
}
