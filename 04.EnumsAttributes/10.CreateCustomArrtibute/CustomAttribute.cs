using System;

[AttributeUsage(AttributeTargets.Class |
               AttributeTargets.All,
    AllowMultiple = true)]

public class CustomAttribute : Attribute
{

    public CustomAttribute()
    {
        Author = "Pesho";
        Revision = 3;
        Description = "Used for C# OOP Advanced Course - Enumerations and Attributes.";
        Reviewers = "Pesho, Svetlio";
    }

    public string Author { get; set; }
    public int Revision { get; set; }
    public string Description { get; set; }
    public string Reviewers { get; set; }

    public string PrintAuthor()
    {
        return "Author: " + this.Author;
    }
    public string PrintRevision()
    {
        return "Revision: " + this.Revision.ToString();
    }
    public string PrintDescription()
    {
        return "Class description: " + this.Description;
    }
    public string PrintReviewers()
    {
        return "Reviewers: " + this.Reviewers;
    }
}

