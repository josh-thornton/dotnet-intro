using System;

namespace PrimitiveTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome to Dotnet 101!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Welcome to class, {name}!");
      Console.WriteLine($"There are {name.Length} letters in your name!");
      Console.WriteLine("How old are you?");
      string strAge = Console.ReadLine();
      Int32.TryParse(strAge, out int age);
      Console.WriteLine($"In ten years {name} will be {age + 10}");
      //   int age = 33;
      //   decimal bankAccount = 10.75m;
      //   float sisterAge = 23f;
      //   bool imTrue = true;
    }
  }
}
