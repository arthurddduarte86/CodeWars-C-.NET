/* 
DESCRIPTION:
This is a spin off of my first kata.

You are given a string containing a sequence of character sequences separated by commas.

Write a function which returns a new string containing the same character sequences except the first and the last ones but this time separated by spaces.

If the input string is empty or the removal of the first and last items would cause the resulting string to be empty, return an empty value (represented as a generic value NULL in the examples below).

Examples
"1,2,3"      =>  "2"
"1,2,3,4"    =>  "2 3"
"1,2,3,4,5"  =>  "2 3 4"

""     =>  NULL
"1"    =>  NULL
"1,2"  =>  NULL
 */



// Solution

using System;

public static class Kata
{
    public static string Array(string s)
    {
        if (string.IsNullOrEmpty(s) || s.IndexOf(',') == -1)
            return null;

        string[] items = s.Split(',');
        if (items.Length <= 2)
            return null;

        return string.Join(" ", items[1..^1]);
    }
}
/*items[1..^1] é uma expressão que pega todos os elementos
de items a partir do segundo elemento até o penúltimo elemento, 
excluindo assim o primeiro e o último elementos.*/





