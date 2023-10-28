using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animals
{
    // Properties
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    // Getter methods
    public string GetName()
    {
        return Name;
    }

    public string GetColour()
    {
        return Colour;
    }

    public int GetAge()
    {
        return Age;
    }

    // Setter methods
    public void SetName(string name)
    {
        Name = name;
    }

    public void SetColour(string colour)
    {
        Colour = colour;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    // Abstract Eat method
    public abstract void Eat();
}

