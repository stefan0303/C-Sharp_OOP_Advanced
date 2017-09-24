using System.Linq;
using System.Reflection;
using System;
using System.Text;

class HarvestingFieldsTest
{


    static void Main()
    {
        string command = Console.ReadLine();
        while (command!="HARVEST")
        {
            switch (command)
            {
                case "private":
                    Console.WriteLine(PrintPrivate());
                    break;
                case "protected":
                    Console.WriteLine(PrintProtected());
                    break;
                case "public":
                    Console.WriteLine(PrintPublic());
                    break;
                case "all":
                    Console.WriteLine(PrintAll());
                    break;
            }

            command = Console.ReadLine();
        }

    }

    public static string PrintAll()
    {
        Type classType = Type.GetType("HarvestingFields");
        FieldInfo[] fileInfos = classType.GetFields(BindingFlags.Instance|
            BindingFlags.Public|BindingFlags.NonPublic);
        StringBuilder sb = new StringBuilder();
        foreach (var field in fileInfos)
        {
            if (field.IsPrivate)
            {
                sb.AppendLine($"private {field.FieldType.Name} {field.Name}");
            }
            else if(field.IsFamily)
            {
                sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
            }
            else
            {
                sb.AppendLine($"public {field.FieldType.Name} {field.Name}");
            }
        }
        return sb.ToString().Trim();
    }

    public static string PrintPublic()
    {
        Type classType = Type.GetType("HarvestingFields");
        FieldInfo[] fileInfos = classType.GetFields(BindingFlags.Instance |
                                                    BindingFlags.Public);
        StringBuilder sb = new StringBuilder();
        foreach (var field in fileInfos)
        {
            sb.AppendLine($"public {field.FieldType.Name} {field.Name}");
        }
        return sb.ToString().Trim();
    }

    public static string PrintPrivate()
    {
        Type classType = Type.GetType("HarvestingFields");
        FieldInfo[] fileInfos = classType.GetFields(BindingFlags.Instance |
                                                    BindingFlags.NonPublic);
        StringBuilder sb = new StringBuilder();
        foreach (var field in fileInfos.Where(f=>f.IsPrivate))
        {
            sb.AppendLine($"private {field.FieldType.Name} {field.Name}");
        }
        return sb.ToString().Trim();
    }
    public static string PrintProtected()
    {
        Type classType = Type.GetType("HarvestingFields");
        FieldInfo[] fileInfos = classType.GetFields(BindingFlags.Instance |
                                                    BindingFlags.NonPublic);
        StringBuilder sb = new StringBuilder();
        foreach (var field in fileInfos.Where(f => f.IsFamily))
        {
            sb.AppendLine($"protected {field.FieldType.Name} {field.Name}");
        }
        return sb.ToString().Trim();
    }
}

