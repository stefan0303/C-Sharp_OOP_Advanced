using System;

class Program
{
    static void Main()
    {
      string a = "s";
      string b = "s";
      Scale<string >scale =new Scale<string>(a,b);
      Console.WriteLine(scale.GetHavier());
    }
}

