/* 
https://www.codewars.com/kata/56cd44e1aa4ac7879200010b/train/csharp

Is the string uppercase?
Task
Create a method to see whether the string is ALL CAPS.

Examples (input -> output)
"c" -> False
"C" -> True
"hello I AM DONALD" -> False
"HELLO I AM DONALD" -> True
"ACSKLDFJSgSKLDFJSKLDFJ" -> False
"ACSKLDFJSGSKLDFJSKLDFJ" -> True
In this Kata, a string is said to be in ALL CAPS whenever it does not contain any lowercase 
letter so any string containing no letters at all is trivially considered to be in ALL CAPS.
 */

// Primeira solução
public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    return text.Equals(text.ToUpper());
  }
}

// Outra forma mais simples
public static class StringExtensions
{
  public static bool IsUpperCase(this string text) => text == text.ToUpper();
}