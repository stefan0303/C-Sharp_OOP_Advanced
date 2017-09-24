using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var rankValues = Enum.GetValues(typeof(Rank));
        var suitsValues = Enum.GetValues(typeof(Suits));

        foreach (var suit in suitsValues)
        {
            foreach (var r in rankValues)
            {
                Console.WriteLine(r + " of "+suit);
            }
        }
       
    }
}

