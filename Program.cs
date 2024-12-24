namespace Assignment
{
    #region #03
    /*We need to restrict the Gender field to be only M or F [Male or Female] */
    

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP 02!");

            #region #01
            /*Design and implement a Class for the employees in a company:
            Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            */
            //Employee employee = new Employee(
            //id: 1,
            //name: "Marawan Bablo",
            //securityLevel: 3,
            //salary: 5000.00m,
            //hireDate: new DateTime(2024, 1, 1),
            //gender: Gender.M
            //);
            //Console.WriteLine(employee);
            #endregion

            #region #02
            //try
            //{
            //    HiringDate hireDate = new HiringDate(15, 3, 2024);
            //    Console.WriteLine(hireDate);

            //    DateTime dateTime = hireDate.ToDateTime();
            //    Console.WriteLine(dateTime);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region #04
            /*Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum*/

            //Employee emp1 = new Employee(1, "John Doe", SecurityPrivilege.Developer, Gender.M);

            //if (emp1.SecurityLevel == SecurityPrivilege.Developer)
            //{
            //    Console.WriteLine("This employee is a Developer");
            //}
            #endregion

            #region #06
            /*We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]*/
            Employee emp = new Employee(
            id: 1,
            name: "Ahmed Santa",
            securityLevel: SecurityPrivilege.Developer,
            salary: 75000.50m,
            hireDate: new DateTime(2024, 3, 15),
            gender: Gender.M
            );

            Console.WriteLine(emp);
            #endregion


        }
    }
}
