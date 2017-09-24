using System;
using System.Linq;
using System.Text;

class Smartphone : ICall, IBrowsing
{
    public string Call(string numbers)
    {
        string[] nums = numbers.Split(' ').ToArray();
        StringBuilder sb = new StringBuilder();
        foreach (var num in nums)
        {

            if (num.Any(char.IsLetter))
            {
                sb.Append("Invalid number!");
            }
            else
            {
                sb.Append("Calling... " + num);
            }
            sb.Append(Environment.NewLine);
        }
        return sb.ToString();
    }

    public string Browsing(string browse)
    {
        string[] sites = browse.Split(' ').ToArray();
        StringBuilder sb = new StringBuilder();
        foreach (var site in sites)
        {
            if (site.Any(char.IsDigit))
            {
                sb.Append("Invalid URL!");
            }
            else
            {
                sb.Append("Browsing: " + site + "!");
            }
            sb.Append(Environment.NewLine);
        }
        return sb.ToString();
    }
}

