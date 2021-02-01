using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager personManager = new CustomerManager();
            personManager.Add();


            ProjectManager projectManager = new ProjectManager();
            projectManager.AddCustomer(customerManager);

        }
    }

    interface IPersonManager
    {

        void Add();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri eklemndi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("personel eklendi");
        }
    }

    class ProjectManager
    {
        public void AddCustomer(CustomerManager customerManager)
        {
            customerManager.Add();

        }

        public void AddEmployee(EmployeeManager employeeManager)
        {
            employeeManager.Add();
        }

    }

    



}
