using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word to see if it's a palindrome" );
    string userInput = Console.ReadLine();
    char[] userInputArray = userInput.ToCharArray();
    bool palindrome = CheckPalindrome(userInputArray);
    Console.WriteLine(palindrome);
  }
  static bool CheckPalindrome(char[] userInputArray)
  {
    Console.WriteLine((userInputArray));
    char[] forwardArray = (char[]) userInputArray.Clone();
    Array.Reverse(userInputArray);
    Console.WriteLine((forwardArray));
    Console.WriteLine((userInputArray));
    if (forwardArray == userInputArray)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

}