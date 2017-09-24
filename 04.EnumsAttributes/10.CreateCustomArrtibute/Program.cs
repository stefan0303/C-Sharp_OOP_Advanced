using System;

class Program
{
    static void Main()
    {
        CustomAttribute customAttribute = new CustomAttribute();
        string input = Console.ReadLine();

        while (input != "END")
        {
            switch (input)
            {
                case "Author":
                    Console.WriteLine(customAttribute.PrintAuthor());
                    break;
                case "Revision":
                    Console.WriteLine(customAttribute.PrintRevision());
                    break;
                case "Description":
                    Console.WriteLine(customAttribute.PrintDescription());
                    break;
                case "Reviewers":
                    Console.WriteLine(customAttribute.PrintReviewers());
                    break;

            }
            input = Console.ReadLine();
        }

    }
}

