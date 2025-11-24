using System;

namespace Project;

  class Killer: Robot
  {
    public int Damage{get;private set;}

    public Killer(){}

    public Killer(string name, short weight,
    byte[] coordinates,int damage):base(name,weight,coordinates)
    {
      this.Damage=damage;
      base.printValues();
      base.weight=5;
    }

  public override void printValues()
  {
    base.printValues();
    Console.WriteLine("Damage: " + Damage);
  }
    public void Laser()
    {
      Console.WriteLine("laser is shooting");
    }





  }

