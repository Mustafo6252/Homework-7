using System.Reflection;

namespace Homework7;

public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
       
    }

    public void GetInfo()
    {
        title = "Atom Habits";
        author = "Jonathan";
        year = 2021;
    }
}