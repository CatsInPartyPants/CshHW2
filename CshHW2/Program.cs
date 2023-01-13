using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
                        
            int userNumber;

            userNumber = Convert.ToInt32(Console.ReadLine());
            
            if(userNumber <= 0 || userNumber > 100)
            {
                Console.WriteLine("Error, the number must be from 1 to 100");
             
            }
            else if(userNumber % 3 == 0 && userNumber % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
                
            }
            else if(userNumber %3 ==0)
            {
                Console.WriteLine("Fizz");
               
            }
            else if(userNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
                
            }

            Console.ReadKey();
            
            //task 2

            double userNumber2;
            double procents;
            Console.WriteLine("Enter number");
            userNumber2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter procents");
            procents = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Answer is: {(userNumber2/100) * procents}");
            Console.ReadKey();
            
            //task 3

            
            int num1, num2, num3, num4;
            int result;
            Console.WriteLine("Enter 1 number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3 number");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4 number");
            num4 = Convert.ToInt32(Console.ReadLine());
            result = num4 + (num3 * 10) + (num2 * 100) + (num1 * 1000);
            Console.WriteLine(result);
            Console.ReadKey();
            
            //task 4
                        
            int userNumberTask4;
            int[] temp4 = new int[6];
            int firstPos = 0;
            int secondPos = 0;
            int tempTask4;
            int result4 = 0;
            int seed = 100000;
            Console.WriteLine("Enter 6 digits number");
            userNumberTask4 = Convert.ToInt32(Console.ReadLine());
            int checker=temp4.Length-1;
            
            while(userNumberTask4 != 0)
            {
                temp4[checker]=userNumberTask4 % 10;
                userNumberTask4 /= 10;
                checker--;
            }
            
            if (checker != -1)
                Console.WriteLine("Entered number is not 6 digit!");
            else
            {
                Console.WriteLine("Enter first position for change:");
                firstPos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second position for change:");
                secondPos = Convert.ToInt32(Console.ReadLine());
                firstPos--;
                secondPos--;
                tempTask4 = temp4[firstPos];
                temp4[firstPos] = temp4[secondPos];
                temp4[secondPos] = tempTask4;
            }
            
            for (int i = 0; i <= temp4.Length - 1; i++)
            {
                result4 += temp4[i] * seed;
                seed /= 10;
            }

            Console.WriteLine(result4);
               
            

            //task 5
            
            string temp5;
            string season;
            int month;
            Console.WriteLine("Please, enter the date in forman dd.mm.yyyy");
            temp5 = Console.ReadLine();
            string[] date = temp5.Split('.');
            DateTime myDateTime = new DateTime(Int32.Parse(date[2]), Int32.Parse(date[1]), Int32.Parse(date[0]));
            
            month = Int32.Parse(date[1]);
            if (month == 12 || month <= 2)
                season = "Winter";
            else if (month <= 5)
                season = "Spring";
            else if (month <= 8)
                season = "Summer";
            else
                season = "Autumn";

            Console.WriteLine($"{season} {myDateTime.DayOfWeek}");
            

            //task 6

            
            double temperature;
            int choise;

            Console.WriteLine("Enter temperature:");
            temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("is temperature that you entered in Celsius or Fahrenhei? press 1 or 2");
            choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
                Console.WriteLine($"This is {temperature * 1.8 + 32} in Fahrenhei");
            else if (choise == 2)
                Console.WriteLine($"This is {(temperature-32) / 1.8} in Celsius");
            else
                Console.WriteLine("Wrong input");
            

            //task 7

            int startRange = 0;
            int endRange = 0;

            Console.WriteLine("Enter range start");
            startRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter range stop");
            endRange = Convert.ToInt32(Console.ReadLine());

            if(startRange < endRange)
            {
                for(int i = startRange; i <= endRange; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            else if (startRange > endRange)
            {
                for(int i = endRange; i <= startRange; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
