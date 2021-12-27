using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCourseProject
{
    class Program
    {
        //Main on bottom
        static void logicOp()
        {
            Console.WriteLine("Enter a number:");
            string number1 = Console.ReadLine();
            int n1 = Int32.Parse(number1);

            bool result1 = n1 > 0 && n1 <= 100;

            Console.WriteLine(result1);
            //Console.ReadKey();


            Console.WriteLine("Enter a number:");
            string number2 = Console.ReadLine();
            int n2 = Int32.Parse(number2);

            bool result2 = n2 < 0 || n2 >= 50 || n2 == 10;
            Console.WriteLine(result2);
        }

        static void ternOp()
        {
            Console.WriteLine("Enter an even number:");
            string even = Console.ReadLine();
            int e1 = Int32.Parse(even);

            string even1 = e1 % 2 == 0 ? "even" : "-1";
            Console.WriteLine(even1);
        }

        static void IfStatement()
        {
            Console.WriteLine("Enter temperature:");
            int temp = Int32.Parse(Console.ReadLine());

            if (temp < 40 && temp > -40)
                Console.WriteLine("Celsius");

            if (temp > 40 || temp < -40)
                Console.WriteLine("Farenheit");
        }

        static void SwitchStatement()
        {
            Console.WriteLine("Enter occupation:");
            string occ = Console.ReadLine();
            int salary;

            switch (occ)
            {
                case "QA":
                    salary = 15000;
                    break;

                case "Teacher":
                    salary = 5000;
                    break;

                case "Bank":
                    salary = 10000;
                    break;

                default:
                    salary = 9100;
                    occ = "average Israeli ";
                    break;

            }

            Console.WriteLine("Monthly salary of " + occ + " is " + salary);

        }

        static void for1()
        {
            string[] countries = { "Austria", "Germany", "Canada", "Peru", "Israel" };

            Console.WriteLine("Press enter for part a:");
            Console.ReadKey();

            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine(countries[i]);
            }

            Console.WriteLine("Press enter for part b:");
            Console.ReadKey();


            for (int i = 0; i < countries.Length; i++)
            {
                if (countries[i].Equals("Israel"))
                {
                    Console.WriteLine(countries[i]);
                    break;
                }

            }

            Console.WriteLine("Press enter for part c:");
            Console.ReadKey();

            if (countries[2].Equals("China"))
                Console.WriteLine("Yes it is there");
            else
                Console.WriteLine("No sorry");

            Console.WriteLine("Press enter for part d:");
            Console.ReadKey();

            Console.WriteLine(countries[0].Length);
        }

        static void for2()
        {
            string[,] array = { { "1", "2", "3", "4", "5" },{ "6", "7", "8", "9","10" } };

            int row = array.GetLength(0);
            int col = array.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine("");
            }
        }

        static void foreach1()
        {
            int[] array = { 12,2,36,20,7 };

            
            //if(array[0]>array[1])
            //{
            //    Console.WriteLine("First is bigger");
            //}
            //else
            //    Console.WriteLine("Not bigger.");

            int start = 0;
            
            foreach(int num in array)
            {
                start += num;
            }

            Console.WriteLine("Sum of array is:");
            Console.WriteLine(start);

            Console.ReadKey();

            start = 0;

            Console.WriteLine("Largest number is:");

            foreach(int num in array)
            {
                if (num > start)
                {
                    start = num;
                }
            }

            Console.WriteLine(start);
        }

        static void while1()
        {
            Console.WriteLine("Enter a number:");
            int num = Int32.Parse(Console.ReadLine());

            int count = 0;

            while(num!=0)
            {
                num /= 10;
                count++;
            }

            Console.WriteLine("Number of digits is: " + count);
        }
        static void dowhile1()
        {
            int ini = 0, sum = 0;

            do
            {
                Console.WriteLine("Enter a number:");
                int num = Int32.Parse(Console.ReadLine());
                sum += num;
                ini = num;
            }
            while (ini != 0);

            Console.WriteLine("Sum of numbers is: " + sum);
        }

        static void dowhile2()
        {
            string[] letters = { "h", "e", "l", "l", "o" };
            int i = letters.Length;


            do
            {
                i--;
                Console.Write(letters[i]);
                
            }
            while (i != 0);
        }

        static void ExPractice()
        {
            string[] letters = { "h", "e" };
            
            try
            {
                Console.WriteLine(letters[5]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Not valid");
            }
        }

        /////////////////////////////////////////////////////////

        //MAIN

        /////////////////////////////////////////////////////////

        static void Main(string[] args)
        {

            ExPractice();

            Console.ReadKey();


        }
    }
}

