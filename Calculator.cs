using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Calculator
    {
        int a;
        int b;
        int sum;
        int diff;
        int mult;
        int div;
        int choice;
        public void getvalue()
        {
            Console.WriteLine("Enter the value of two numbers::");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void Sum()
        {
            sum = a + b;
            Console.WriteLine("the sum of two number {0} and {1} is {2}",a,b,sum);
        }
        public void Diff()
        {
            diff = a - b;
            Console.WriteLine("the diff of two number {0} and {1} is {2}", a, b, diff);
        }
        public void Mul()
        {
            mult = a * b;
            Console.WriteLine("the multiplication of two number {0} and {1} is {2}", a, b, mult);
        }
        public void Div()
        {
            div = a / b;
            Console.WriteLine("the sum of two number {0} and {1} is {2}", a, b, div);
        }
        public void Menu()
        {
            Console.WriteLine("1.getvalue 2.Sum 3.Diff 4.Mul 5.Div");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                getvalue();
                    break;
                case 2:
                    Sum();
                    break;
                case 3:
                    Diff();
                    break;
                case 4:
                    Mul();
                    break;
                case 5:
                    Div();
                    break;
            }
        }


        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while(true)
            {
                calculator.Menu();
            }

               
        }
    }
}
