using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class Program
    {
        public class employee
        {
            public void display(int a, string b)
            {
                Console.WriteLine("Employee id is:" + " " + a);
                Console.WriteLine("Employee Name is:" + " " + b);
                Console.ReadKey();
            }

        }
        public class trainee
        {
            public void show(ref string str)
            {
                Console.WriteLine("designation is:" + " " + str);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            string m = "prajakta";
            employee emp = new employee();
            emp.display(1, m);

            string n = "trainee";
            trainee emp1 = new trainee();
            emp1.show(ref n);


        }
    }
}
