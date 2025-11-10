using System;
using System.Runtime.CompilerServices;

namespace Project;
class Robot
{
    private string name;
    private short weight;
    private byte[] coordinates;

    public void setValues(string _name,short _weight, byte[] _coordinates)
    {
        name = _name;
        weight = _weight;
        coordinates = _coordinates;
    }
    public void printValues()
    {
        Console.WriteLine("");
        Console.Write(name + " " + weight + "kg ");
        foreach(byte coord in coordinates)
        {
            Console.Write(coord + "");
        }
    }
}
