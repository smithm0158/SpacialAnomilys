using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLibrary;

/**
 * 3/19/22
 * CSC 153 
 * Michael Smith
 * Menu to move a character and attack using a menu
 * */
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int room = 0;
            bool exit = false;
            while (exit == false)
            {

                Console.WriteLine("Choose a number from the list below: ");
                Console.WriteLine("1. Move North");
                Console.WriteLine("2. Move South");
                Console.WriteLine("3. Attack");
                Console.WriteLine("4. Exit");
                Console.Write("Enter a choice > ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Move.MoveNorth(ref room);
                    Console.WriteLine("Room number: "+ room);
                    Console.WriteLine();
                }

                else if (input == "2")
                {
                    Move.MoveSouth(ref room);
                    if (room < 0)
                    {
                        room = 0;
                        Console.WriteLine("Sorry, you cant go any further back!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Room number: " + room);
                    }
                    Console.WriteLine();
                }

                else if (input == "3")
                {
                    
                    Console.WriteLine("Your health is: " +Attack.Attacking());
                    Console.WriteLine();
                }

                else if (input == "4")
                {
                    break;

                }

                else
                {
                    Console.WriteLine("Not a valid option. Please choose again.");
                }
            }
        }
    }
}
