/* https://www.codewars.com/kata/56170e844da7c6f647000063/train/csharp


Kids drink toddy.
Teens drink coke.
Young adults drink beer.
Adults drink whisky.
Make a function that receive age, and return what they drink.

Rules:

Children under 14 old.
Teens under 18 old.
Young under 21 old.
Adults have 21 or more.
Examples: (Input --> Output)

13 --> "drink toddy"
17 --> "drink coke"
18 --> "drink beer"
20 --> "drink beer"
30 --> "drink whisky"
 */


//One possible traditional solution
public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    if (old<14)
    {
      return "drink toddy";
    }
    else if (old >= 14 & old <= 18)
    {
      return "drink coke";
    }
    else if (old > 18 & old < 21)
    {
      return "drink beer";      
    }
    else
    {
      return "drink whisky";
    }
  }
}

// Another traditional solution
public class Kata
{
    public static string PeopleWithAgeDrink(int old)
    {
        if (old < 14)
        {
            return "drink toddy";
        }

        if (old < 18)
        {
            return "drink coke";
        }

        if (old < 21)
        {
            return "drink beer";
        }

        if (old > 30)
        {
            return "drink whisky";
        }

        return "drink whisky";
    }
}

// Optimized solution
public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    return "drink " + (old < 14? "toddy": old < 18? "coke": old < 21? "beer": "whisky");
  
  }
}
// Or with good layout
public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
    return "drink " + (old < 14? "toddy": 
                       old < 18? "coke": 
                       old < 21? "beer": 
                       "whisky");
  
  }
}





