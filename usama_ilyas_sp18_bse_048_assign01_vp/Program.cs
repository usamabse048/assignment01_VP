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
                    Console.WriteLine("Task 02 selected");

                }
                else if (choice.Equals("3"))
                {
                    Console.WriteLine("Task 03 Selected");
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

            void task01()
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

                for(int i = 0; i < a2.Count; i++)
                {
                    a3.Add(a2[i]);
                }
                for(int i = 0; i < a1.Count; i++)
                {
                    a3.Add(a1[i]);
                }

                Console.WriteLine("\nPrinting Appended Array(FIRST array appended into SECOND array):");

                for(int i = 0; i< a3.Count; i++)
                {
                    Console.Write(a3[i] + "    ");
                }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n\n\nTask 01 completed sucessfully\nPress any key to go back to main menu");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();








            }
        }
    }
}
