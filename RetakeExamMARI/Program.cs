using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetakeExamMARI
{
    class Program
    {
        static void Main(string[] args)
        {

            GetMyInfo();
            OddEven();
            CountCharacter();
            Count15();
            Add();
            Day();
            GreaterLesser();
            Check();
            LetterCapitalize();
            Calculate();

            Console.ReadKey();
        }
        private static void GetMyInfo()
        {//1.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            DateTime time = new DateTime();
            try
            {
                time = DateTime.Now;
                Console.WriteLine("{0} log in ({1})", name, time);

            }
            catch (Exception ex)

            {

                Console.WriteLine("An error occurred: " + ex.ToString());

            }

        }
        private static void OddEven()
        {//2.
            int i = 0;


            Console.WriteLine("Enter Number");
            i = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("This Number is {0}", i);

            try
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("ODD");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("EVEN");
                    Console.Read();
                }
            }

            catch (Exception ex)

            {

                Console.WriteLine("An error occurred: " + ex.ToString());

            }
        }
        private static void CountCharacter() {
        }//3.
        //string str = "THIS IS AN EXAMPLE";
        //int Length =str.Length;

        //Console.WriteLine(Length);


        

        private static void Count15()
        {//4.

            int a;

            try
            { for (a = 1; a <= 15; a++)

                    Console.Write(a);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Errour" + ex.ToString());
            }
        } private static void Add()
        {//5.
            Console.WriteLine("Type number1");
            int number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Type number2");
            int number2 = Convert.ToInt16(Console.ReadLine());

            int result = number1 + number2;
            try
            {
                Console.WriteLine("{0}+{1}={2}", number1, number2, result); ;
            }
            catch { Console.WriteLine("Type number"); }

        }
        private static void Day(){
            //6.   

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
           string s = now.DayOfWeek.ToString();
            try
            {
                Console.WriteLine("Today is {0}", s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }

        }
        private static void GreaterLesser()
        {//7.
            int e = Convert.ToInt32(Console.ReadLine());
            try
            {
                if(e==2000)
                {
                    Console.WriteLine("{ 0 } is 2000");
                }
                if (e < 2000)
                {
                    Console.WriteLine("{0} is less than 2000", e);
                }
                else
                {
                    Console.WriteLine("{0}is greater than 2000", e);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }
        }


            private static void Check()
        {// 8.
            Console.WriteLine("Type number 1");
            int number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Type Number2");
            int number2 = Convert.ToInt16(Console.ReadLine()); ;
            bool flag = number1 < number2;

            Console.WriteLine("number1 is less than number2:" + flag);


            try
            {
                if (flag == true)
                {
                    return;
                }

                else
                {
                    flag = false;

                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }

        }
        private static void LetterCapitalize()
        {//9.
            string letter = Console.ReadLine();
            string Upper = letter.ToUpper();
            
            try
            {
                Console.WriteLine(Upper);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errour" + ex.ToString());
            }

        }



        private static void Calculate()
        {
            //10. 

            Console.WriteLine(" Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine(factorial);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }

        }
    }
}


                       
