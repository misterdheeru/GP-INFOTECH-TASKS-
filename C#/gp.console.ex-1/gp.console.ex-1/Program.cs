using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp.console.ex_1
{

    class Employees
    {


        public int ID { set; get; } 
        public string Name { set; get; }
        public double Salary { set; get; }

        public Employees(int id , string name, double sal)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = sal;
        }
        
        public void Show ()
        {
            Console.WriteLine("YOUR ID IS :" + ID);
            Console.WriteLine("YOUR NAME IS :" +Name);
            Console.WriteLine("YOUR SALARY IS :" + Salary);
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees(1, "RAMA", 2500);

            emp.Show();
        }
    }
}
