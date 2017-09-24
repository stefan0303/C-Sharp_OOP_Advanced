using System;


[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Enum,
    AllowMultiple = true)]

public class TypeAttribute : Attribute
{
    public TypeAttribute( string category, string description)
    {
        this.Type = "Enumeration";
        this.Category = category;
        this.Description = description;
    }

    public string Type { get; }


    public string Category { get; set; }

    public string Description { get; set; }

   
}

