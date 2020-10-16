using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usama_ilyas_sp18_bse_048_assign01_vp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Visual Programming (Assignment 01)------------\n--------------     Usama Ilyas SP18-BSE-048     ------------\n");
            while (true)
            {
                Console.WriteLine("\nPlease enter the task you want to check:\n1. Task 01\n2. Task 02\n3. Task 03\n4. Exit");
                String choice = Console.ReadLine();
                if (choice.Equals("1"))
                {
                    task01();
                }
                else if (choice.Equals("2"))
                {
                    task02();

                }
                else if (choice.Equals("3"))
                {
                    task03();
                }
                else if (choice.Equals("4"))
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("\n----------Enter Right Choice Please!-------------\n");
                }


            }

           

           
        }

        //Task 01


        static void  task01()
        {
            ArrayList a1 = new ArrayList();
            ArrayList a2 = new ArrayList();
            ArrayList a3 = new ArrayList();

            Console.WriteLine("-------Welcome to Task 01-------");
            Console.Write("Please enter the items of FIRST array ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(when completed enter - 1)");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                String a1Element = Console.ReadLine();
                if (a1Element.Equals("-1"))
                {
                    break;
                }
                else
                {
                    a1.Add(a1Element);
                }

            }

            Console.Write("Please enter the items of SECOND array ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(when completed enter - 1)");
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                String a2Element = Console.ReadLine();
                if (a2Element.Equals("-1"))
                {
                    break;
                }
                else
                {
                    a2.Add(a2Element);
                }

            }

            for (int i = 0; i < a2.Count; i++)
            {
                a3.Add(a2[i]);
            }
            for (int i = 0; i < a1.Count; i++)
            {
                a3.Add(a1[i]);
            }

            Console.WriteLine("\nPrinting Appended Array(FIRST array appended into SECOND array):\n");

            for (int i = 0; i < a3.Count; i++)
            {
                Console.Write(a3[i] + "    ");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\n\nTask 01 completed sucessfully\nPress any key to go back to main menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();



        }


        //task 02
        static void task02()
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;
            int a2Element = -1;


            Console.Write("Please enter the items of array which you want to sort");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(when completed enter - 1)");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                try
                {
                     a2Element = int.Parse(Console.ReadLine());

                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can enter positive integers only");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }



                if (a2Element == -1 )
                {
                    break;
                }
                else if(a2Element <= -2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can enter positive integers only");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    unsorted.Add(a2Element);
                }

            }
            Console.WriteLine();

            sorted = MergeSort(unsorted);

            Console.WriteLine("Congratulations! your array has been sorted: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nTask 02 completed sucessfully\nPress any key to go back to main menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();


        }


        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }


        //task 03
        static void task03()
        {
            Console.WriteLine("\n-------Welcome to Task 03-------");
            Console.WriteLine("Enter a String to reverse it:");

            String s = Console.ReadLine();

            char[] array = s.ToCharArray();
            Array.Reverse(array);
            s = new String(array);


            Console.WriteLine("Printing revered String:\n");
            Console.WriteLine(s);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\nTask 03 completed sucessfully\nPress any key to go back to main menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

        }
    }
}
