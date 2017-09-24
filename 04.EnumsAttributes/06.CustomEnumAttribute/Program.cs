using System;

namespace _05.Test
{
    class Program
    {
        public static void Main()
        {

            PrintAttribute();
        }

        public static void PrintAttribute()
        {
            string targetEnum = Console.ReadLine();

            object[] result = null;
            if (targetEnum == "Rank")
            {
                result = typeof(Rank).GetCustomAttributes(true);
            }
            else
            {
                result = typeof(Suits).GetCustomAttributes(true);
            }
            foreach (var attr in result)
            {
                var typeAttr = attr as TypeAttribute;
                Console.WriteLine($"Type = {typeAttr.Type}, Description = {typeAttr.Description}");
            }
        }
    }
}
