
using System;
using System.Linq;
using System.Reflection;

class BlackBoxIntegerTests
{
    static void Main()
    {
        Type classType = typeof(BlackBoxInt);
        BlackBoxInt blackBox = (BlackBoxInt)Activator.CreateInstance(classType, true);//First way

        ConstructorInfo methodInfo = classType.GetConstructor //Second way
            (BindingFlags.Instance | BindingFlags.NonPublic,
            Type.DefaultBinder, new Type[] { }, null);

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "END")
        {
            string[] tokens = inputLine.Split('_');
            string methodName = tokens[0];
            int value = int.Parse(tokens[1]);

            classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                .Invoke(blackBox, new object[] { value });

            object innerStateValue = classType
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First()
                .GetValue(blackBox);

            Console.WriteLine(innerStateValue);
        }
    }
}




