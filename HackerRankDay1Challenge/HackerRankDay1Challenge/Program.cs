using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Collections.Generic;

namespace HackerRankDay1Challenge
{
    class Solution
    {
        #region Day1 Challenge
        //static void Main(String[] args)
        //{
        //    // Declare a variable named 'inputString' to hold our input.
        //    String inputString;

        //    // Read a full line of input from stdin (cin) and save it to our variable, input_string.
        //    inputString = Console.ReadLine();

        //    // Print a string literal saying "Hello, World." to stdout using cout.
        //    Console.WriteLine("Hello, World.");
        //// TODO: Write a line of code here that prints the contents of input_string to stdout.
        //     Console.WriteLine(inputString);
        //     Console.ReadKey();


        //}
        #endregion

        #region Day1 Challenge 2
        //static void Main(String[] args)
        //{
        //    int i = 4;
        //    double d = 4.0;
        //    string s = "HackerRank ";


        //    // Declare second integer, double, and String variables.
        //    int inputvalueinterger;
        //    double inputvaluedouble;
        //    string inputvaluestring;

        //    // Read and save an integer, double, and String to your variables.
        //    var intvalue = Console.ReadLine();
        //    var doublevalue = Console.ReadLine();
        //    inputvaluestring = Console.ReadLine();

        //    if(int.TryParse(intvalue,out inputvalueinterger))
        //    {
        //        // Print the sum of both integer variables on a new line.           
        //        Console.WriteLine( i += inputvalueinterger);
        //    }
        //    else
        //    {
        //        Console.WriteLine("input was not integer!");                
        //    }
        //    if (double.TryParse(doublevalue, out inputvaluedouble))
        //    {
        //        // Print the sum of the double variables on a new line.
        //        if ((d += inputvaluedouble).ToString().Contains("."))               
        //        Console.WriteLine((d));
        //        else
        //        Console.WriteLine(d+".0");
        //    }
        //    else
        //    {
        //        Console.WriteLine("input was not Double!");
        //    }
        //    // Concatenate and print the String variables on a new line
        //    // The 's' variable above should be printed first.
        //    Console.Write("{0}{1}", s, inputvaluestring);
        //    Console.ReadKey();
        //}

        #endregion

        #region Day 2 Challenge
        // Complete the solve function below.
        // static void solve(double meal_cost, int tip_percent, int tax_percent)
        // {
        //     #region Type1

        //     //float Tipcost = ((float)meal_cost * tip_percent/100);

        //     //Console.WriteLine("Total Tipcost is:" + Tipcost);

        //     //float TaxCost = ((float)meal_cost * tax_percent / 100);
        //     //Console.WriteLine("Total TaxCost is:" + TaxCost);

        //     //float TotalCost = (float)meal_cost + Tipcost + TaxCost;
        //     //Console.WriteLine("The total meal cost is " + TotalCost);
        //     //Console.WriteLine("The total meal cost is "
        //     //                   + Math.Round(TotalCost, MidpointRounding.AwayFromZero) + " dollars.");

        //     #endregion

        //     #region Type2
        //     // Get the Tax
        //     //double tax = (meal_cost * tax_percent) / 100;
        //     //// Get the Tip
        //     //double tip = (meal_cost * tip_percent / 100);
        //     //// Total Cost
        //     //double totalCost = meal_cost + tax + tip;
        //     //// Round the total cost and output to console
        //     //Console.WriteLine("The total meal cost is "
        //     //                    + Math.Round(totalCost) + " dollars.");
        //     //  Console.WriteLine("Total MealCost is:" + (meal_cost * (1 + (tip_percent + tax_percent) / 100)));



        //     //Console.ReadLine();
        //     #endregion
        //     #region Arjun 

        //     //double Tipcost = meal_cost * tip_percent / 100;

        //     //Console.WriteLine("Total Tipcost is:" + Tipcost);

        //     //double TaxCost = meal_cost * tax_percent / 100;
        //     //Console.WriteLine("Total TaxCost is:" + TaxCost);

        //     //double TotalCost = meal_cost + Tipcost + TaxCost;
        //     //Console.WriteLine("The total meal cost is " + TotalCost);
        //     //Console.WriteLine("The total meal cost is "
        //     //                   + Math.Round(TotalCost, 0) + " dollars.");
        //     //Console.ReadLine();
        //     #endregion
        // }

        // static void Main(string[] args)
        // {
        //         double meal_cost = Convert.ToDouble(Console.ReadLine());

        //         int tip_percent = Convert.ToInt32(Console.ReadLine());

        //         int tax_percent = Convert.ToInt32(Console.ReadLine());

        //         solve(meal_cost, tip_percent, tax_percent);
        //}
        #endregion

        #region Day 3 Challenge
        ////static void Main(string[] args)
        ////{
        ////    int N = Convert.ToInt32(Console.ReadLine());
        ////    if (N % 2 == 0)
        ////    {
        ////        if (N >= 2 && N <= 5)
        ////        {
        ////            Console.WriteLine("Not Weird");
        ////        }
        ////        else if (N>=6 && N <= 20)
        ////        {
        ////            Console.WriteLine("Weird");
        ////        }
        ////        else if(N>20)
        ////        {
        ////            Console.WriteLine("Not Weird");
        ////        }
        ////    }

        ////    else
        ////    {
        ////        Console.WriteLine("Weird");
        ////    }
        ////    Console.ReadKey();
        ////}
        #endregion

        #region  Day 4 Challennge
        //class Person
        //{
        //    public int age;
        //    public Person(int initialAge)
        //    {
        //       if(initialAge < 0)
        //        {
        //            Console.WriteLine(" Age is not valid, setting age to 0.");
        //            age = 0;
        //        }
        //       else
        //        {
        //            age = initialAge;
        //        }
        //    }
        //    public void amIOld()
        //    {
        //        if(age<13)
        //        {
        //            Console.WriteLine("You are young.".Trim());
        //        }
        //        else if(age >=13 && age< 18 )
        //        {
        //            Console.WriteLine("You are a teenager.".Trim());
        //        }
        //        else if(age >= 18 )
        //        {
        //            Console.WriteLine("You are old.".Trim());
        //        }               
        //    }

        //    public void yearPasses()
        //    {
        //        age += 1;
        //    }

        //    static void Main(String[] args)
        //    {
        //        int T = int.Parse(Console.In.ReadLine());
        //        for (int i = 0; i < T; i++)
        //        {
        //            int age = int.Parse(Console.In.ReadLine());
        //            Person p = new Person(age);
        //            p.amIOld();
        //            for (int j = 0; j < 3; j++)
        //            {
        //                p.yearPasses();
        //            }
        //            p.amIOld();
        //            Console.WriteLine();
        //        }
        //        Console.ReadKey();
        //    }
        //}

        #endregion

        #region Day5 Challenge
        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    if(n>=2 && n<=20)
        //    {
        //        for(int i=1;i<=10;i++)
        //        {
        //            int r = n * i;
        //            Console.WriteLine("{0} x {1} = {2}", n, i, r);                    
        //        }
        //    }
        //    Console.ReadKey();
        //}

        #endregion



        #region Day 6  - Add String and Event String Display

        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //    string[] inputstrings = new string[10];
        //    int NumberOfStrings = Convert.ToInt32(Console.ReadLine());
        //    if (NumberOfStrings >= 1 && NumberOfStrings <= 10)
        //    {
        //        for (int j = 0; j < NumberOfStrings; j++)
        //        {
        //            string input = Console.ReadLine();

        //            stringseperation(input);

        //            inputstrings[j] = input;
        //        }
        //        Console.ReadKey();
        //    }            
        //}
        //public static void stringseperation(string inputsting)
        //{
        //    StringBuilder oddstbld = new StringBuilder();
        //    StringBuilder evnstbld = new StringBuilder();
        //    int stnglnth = inputsting.Length;
        //    if (stnglnth > 2 && stnglnth <= 10000)
        //    {
        //        oddstbld.Append(inputsting[0]);
        //        for (int i = 1; i < stnglnth; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                oddstbld.Append(inputsting[i]);
        //            }
        //            else if (i % 2 == 1)
        //            {
        //                evnstbld.Append(inputsting[i]);
        //            }
        //        }
        //        Console.WriteLine("{0} {1}",oddstbld.ToString(), evnstbld.ToString());

        //    }


        //}
        #endregion

        #region Days 7 - Array Reverse
        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        //    int arraylength = arr.Length;
        //    int index = 0;
        //    int[] reversearray = new int[n];
        //    if (arraylength >= 1 && arraylength<=1000)
        //    {
        //        for(int j=arraylength-1; j>=0 ;j--)
        //        {                   
        //                reversearray[index] = arr[j];
        //                index++;                    
        //        }
        //        foreach (int value in reversearray)
        //        {
        //            if (value >= 1 && value <= 10000)
        //            {
        //                Console.Write(value);
        //                Console.Write(' ');
        //            }
        //        }
        //    }
        //    Console.ReadKey();
        //}       

        #endregion

        //#region Minimum Swap Array
        //// Complete the minimumSwaps function below.
        //static int minimumSwaps(int[] arr)
        //{
        //    int swap = 0;int tempval = 0;
        //    int arraylength = arr.Length;

        //    for(int i=0;i<arraylength-1;i++)
        //    {
        //        for (int j = i + 1; j < arraylength; j++)
        //        {
        //            if (arr[i] > arr[j])
        //            {
        //                tempval = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = tempval;
        //                swap++;

        //            }
        //            #region To print and see what happens inside loop
        //            Console.WriteLine("swap " + swap + " ");
        //            foreach (int value in arr)
        //            {

        //                Console.Write(value);

        //            }
        //            Console.WriteLine();
        //            #endregion
        //        }

        //    }
        //    return swap;
        //}

        //static void Main(string[] args)
        //{
        //   // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //    ;
        //    int res = minimumSwaps(arr);

        //   // textWriter.WriteLine(res);
        //    Console.ReadKey();
        //   // textWriter.Flush();
        //   // textWriter.Close();
        //}
        //#endregion

        #region Day 8 Dictionary

        //static void Main(String[] args)
        //{
        //    string inputs;          
        //    Dictionary<string, int> dictionary = new Dictionary<string, int>();
        //    int numbofKeyValuePairs = Convert.ToInt32(Console.ReadLine());           
        //    List<string> inputquerie = new List<string>();

        //    if (numbofKeyValuePairs >= 1 && numbofKeyValuePairs <= (100000))
        //    {
        //        for (int i = 0; i < numbofKeyValuePairs; i++)
        //        {
        //            string[] input = Console.ReadLine().ToString().Split(' ');
        //            dictionary.Add(input[0], Convert.ToInt32(input[1]));
        //        }

        //        while (!string.IsNullOrEmpty(inputs = Console.ReadLine()))
        //        {
        //            inputquerie.Add(inputs);
        //        }

        //        Console.WriteLine("Output");
        //        foreach (string value in inputquerie)
        //        {
        //            if (dictionary.ContainsKey(value))
        //            {
        //                Console.WriteLine(value + "=" + dictionary[value]);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Not found");
        //            }
        //        }
        //    }

        //    Console.ReadKey();

        //}
        #endregion


        #region Day 9 Factorial
        //static int factorial(int n)
        //{
        //    int result = 1;
        //    while(n!=1)
        //    {
        //        result = result * n;
        //        n = n - 1;
        //    }
        //    return result;
        //}

        //static void Main(string[] args)
        //{
        //    //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());
        //    if (n >= 1 && n <= 12)
        //    { 
        //         int result = factorial(n);
        //        Console.WriteLine(result);
        //    }
        //    Console.ReadKey();
        //  //  textWriter.WriteLine(result);

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
        #endregion

        #region Day 10 Binary Numbers
   
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] binaryvalue = new int[1000000];
            int index = 0;          

            int Reminder;
            int quotiont;
            string BinaryNumber= string.Empty;
            if (n > 1 && n < 1000000)
            {
                while (n > 1)
                {
                    Reminder = n % 2;
                    quotiont = n / 2;
                    BinaryNumber = BinaryNumber + Reminder.ToString();
                    n = quotiont;                   
                }
            }
           
          //  Console.WriteLine(BinaryNumber);
           int bincount = getConsecutiveCount(BinaryNumber);
            Console.WriteLine(bincount);
            Console.ReadKey();
        }
      public static int getConsecutiveCount(string BinaryNumber)
        {
            int counter = 1,value;
            int firstindex = BinaryNumber.IndexOf("1");
            int lastindex = BinaryNumber.LastIndexOf("1");
            List<int> bincount = new List<int>();
            for (int i=firstindex;i<lastindex+1;)
            {
                value = i;
                while(BinaryNumber[value++]!= '1')
                {
                    counter++;
                }
                i = value;
                bincount.Add(counter);
                counter = 1;
            }
            return bincount.Max();
          
        }

        #endregion
    }
}
        
        
    

    

