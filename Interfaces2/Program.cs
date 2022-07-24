using System;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager= new EmployeeManager(); 

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager()) ;
            projectManager.Add(new EmployeeManager()) ;
            projectManager.Add(new InternManager()) ;         
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Çalışan Eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Çalışan Güncellendi!");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajer güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
 
    }
}
