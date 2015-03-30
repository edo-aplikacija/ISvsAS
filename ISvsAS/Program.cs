using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISvsAS
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class PermanentEmployee : Employee
    {
        public int MonthlySalary { get; set; }
    }

    class ContractEmployee : Employee
    {
        public int HourlySalary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- FirstExample -----");
            FirstExample();
            Console.WriteLine("---- FirstExample -----");
            Console.WriteLine();
            Console.WriteLine("---- SecondExample -----");
            SecondExample();
            Console.WriteLine("---- SecondExample -----");
            Console.WriteLine();
            Console.WriteLine("---- ThirdExample -----");
            ThirdExample();
            Console.WriteLine("---- ThirdExample -----");
            Console.WriteLine();
            Console.WriteLine("---- FourExample -----");
            FourExample();
            Console.WriteLine("---- FourExample -----");
            Console.WriteLine();
            Console.WriteLine("---- FiveExample -----");
            FiveExample();
            Console.WriteLine("---- FiveExample -----");
            Console.WriteLine();
            Console.WriteLine("---- SixExample -----");
            SixExample();
            Console.WriteLine("---- SixExample -----");

            Console.ReadLine();
        }

        public static void FirstExample()
        {
            Employee emp = new Employee() { ID = 1, Name = "John" };
            if (emp is Employee)
            {
                Console.WriteLine(emp.Name + " is Employee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT Employee");
            }
            if (emp is PermanentEmployee)
            {
                Console.WriteLine(emp.Name + " is PermanentEmployee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT PermanentEmployee");
            }
            if (emp is ContractEmployee)
            {
                Console.WriteLine(emp.Name + " is ContractEmployee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT ContractEmployee");
            }
        }

        public static void SecondExample()
        {
            Employee emp = new PermanentEmployee() { ID = 1, Name = "Mike" };
            if (emp is Employee)
            {
                Console.WriteLine(emp.Name + " is Employee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT Employee");
            }
            if (emp is PermanentEmployee)
            {
                Console.WriteLine(emp.Name + " is PermanentEmployee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT PermanentEmployee");
            }
            if (emp is ContractEmployee)
            {
                Console.WriteLine(emp.Name + " is ContractEmployee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT ContractEmployee");
            }
        }

        public static void ThirdExample()
        {
            PermanentEmployee emp = new PermanentEmployee() { ID = 1, Name = "Mary" };
            if (emp is Employee)
            {
                Console.WriteLine(emp.Name + " is Employee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT Employee");
            }
            if (emp is PermanentEmployee)
            {
                Console.WriteLine(emp.Name + " is PermanentEmployee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT PermanentEmployee");
            }
            if (emp is ContractEmployee)
            {
                Console.WriteLine(emp.Name + " is ContractEmployee");
            }
            else
            {
                Console.WriteLine(emp.Name + " is NOT ContractEmployee");
            }
        }

        public static void FourExample()
        {
            Employee emp = new Employee() { ID = 1, Name = "Todd" };

            PermanentEmployee perEmp = emp as PermanentEmployee;
            if (perEmp == null)
            {
                Console.WriteLine("PermanentEmployee IS NULL");
            }
            else
            {
                Console.WriteLine("PermanentEmployee IS NOT NULL");
            }

            ContractEmployee conEmp = emp as ContractEmployee;
            if (conEmp == null)
            {
                Console.WriteLine("ContractEmployee IS NULL");
            }
            else
            {
                Console.WriteLine("ContractEmployee IS NOT NULL");
            }
        }

        public static void FiveExample()
        {
            Employee emp = new PermanentEmployee() { ID = 1, Name = "Todd" };

            PermanentEmployee perEmp = emp as PermanentEmployee;
            if (perEmp == null)
            {
                Console.WriteLine("PermanentEmployee IS NULL");
            }
            else
            {
                Console.WriteLine("PermanentEmployee IS NOT NULL");
            }

            ContractEmployee conEmp = emp as ContractEmployee;
            if (conEmp == null)
            {
                Console.WriteLine("ContractEmployee IS NULL");
            }
            else
            {
                Console.WriteLine("ContractEmployee IS NOT NULL");
            }
        }

        public static void SixExample()
        {
            PermanentEmployee emp1 = new PermanentEmployee() { ID = 1, Name = "Aaron" };
            ContractEmployee emp2 = new ContractEmployee() { ID = 1, Name = "Ted" };

            Employee employee1 = emp1 as Employee;
            if (employee1 == null)
            {
                Console.WriteLine("employee1 IS NULL");
            }
            else
            {
                Console.WriteLine("employee1 IS NOT NULL");
            }

            Employee employee2 = emp2 as Employee;
            if (employee2 == null)
            {
                Console.WriteLine("employee2 IS NULL");
            }
            else
            {
                Console.WriteLine("employee2 IS NOT NULL");
            }
        }

    }

    
}
