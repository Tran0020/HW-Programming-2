using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {//DONE
            //Create a console application that will print out your first name and last name, with correct punctuation
            //(e.g.upper case characters where needed, like the first letter of each name). 
            //To get the characters, create two arrays, the first one with all of the lower -case characters 
            //    the alphabet.  The second array will have all of the upper case letters in the alphabet.  
            //    If you have special characters in your name that are outside of the standard english alphabet,
            //    you can disregard this or you can add them to your arrays as well.
            //    Using your two arrays, access the correct elements to concatenate your name 
            //    and output it to the console window.

            char[] lowercase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] uppercase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            
            Console.WriteLine($" My name is {uppercase[9]}{lowercase[4]}{lowercase[13]}{lowercase[13]}{lowercase[0]} {uppercase[19]}{lowercase[17]}{lowercase[0]}{lowercase[13]}") ;
            Console.ReadLine();

        
        }
    }
}
