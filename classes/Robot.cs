using System;
using System.Runtime.CompilerServices;

namespace Project;
class Robot
{
    private string name;
    private short weight;
    private byte[] coordinates;


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
        printValues();
    }
    public void setValues(string _name, short _weight,
    byte[] _coordinates)
    {
        name = _name;
        weight = _weight;
        coordinates = _coordinates;
    }
    public void printValues()
    {
        Console.Write(name + " " + weight + "kg ");
        foreach (byte coord in coordinates)
        {
            Console.Write(coord + "");
        }
        Console.WriteLine("");
    }
    public static void Print()
    {
        Console.WriteLine("Count"+count);
    }
}
