using System;

public static class Palindrome
{
  static void Main()
  {
    Console.WriteLine("Enter a word");
    string inputWordAsIs = Console.ReadLine();
    string inputWord = inputWordAsIs.ToLower();
    CheckPalindrome(inputWord);
  }
  public static void CheckPalindrome(string word)
  {
    char [] wordArr = word.ToCharArray();
    Array.Reverse(wordArr);
    string reversedWord = String.Join("", wordArr);
    if (word == reversedWord)
    {
      Console.WriteLine("That word is a palindrome!");
    }
    else
    {
      Console.WriteLine("That word is not a palindrome.");
    }
  }
}