using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**************
 * Author: Elisabeth Feeley
 * Date: 11/29/2011
 * ************/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string firstname;
            string lastname;

            //User Input
            Console.Write("Enter your first name:");
            firstname = Console.ReadLine();

        
            Console.Write("Enter your last name:");
            lastname = Console.ReadLine();

            Console.Clear(); //clear the console


            if (firstname == "Elisabeth")
            {
                Console.WriteLine("Hello " + firstname + " " + lastname + "!");
            }// end if
            else
            {
                for (int x = 1; x <= 5; x++)
                {
                    Console.WriteLine("Hello LOSER!!");
                }//end for
            }//end else
            
           
            Console.WriteLine("On the roster your name would appear as: "+ lastname + ", " + firstname);
            Console.ReadLine();

        }//end method main
    }// end method class
}//end method namespace Helloworld
