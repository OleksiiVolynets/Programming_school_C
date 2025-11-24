using System;
using System.Runtime.CompilerServices;

namespace Project;
class Robot
{
    protected string name;
    protected short weight;
    protected byte[] coordinates;


    public string Name
  {
        get { return name; }
  }

    public short Weight
    {
        get{
            Console.WriteLine("Get weight called");
            return this.weight;
        }
        set
        {
            if(value<10)
                this.weight=1;
            else
                this.weight=value;
        }
    }
    public int Width
    {
        get; set;
    }

    public static int count = 0;
    public Robot()
    {
        count++;
    }
    public Robot(string _name)
    {
        name = _name;
        count++;
    }
    public Robot(string _name, short _weight,
    byte[] _coordinates)
    {
        count++;
        setValues(_name, _weight, _coordinates);
       // printValues();
    }
    public void setValues(string name, short weight,
    byte[] coordinates)
    {
        this.name = name;
        this.weight = weight;
        this.coordinates = coordinates;
    }
    public virtual void printValues()
    {
        Console.Write(name + " " + weight + "kg ");
        foreach (byte coord in coordinates)
        {
            Console.Write(coord + " ");
        }
        Console.WriteLine("");
    }
    public static void Print()
    {
        Console.WriteLine("Count"+count);
    }
}
