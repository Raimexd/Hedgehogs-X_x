

using System.ComponentModel;
using System.ComponentModel.Design;
Random random = new Random();

Forest forest = new Forest();
Hedgehog hedgehog1 = new Hedgehog();
hedgehog1.name = "Egorchik";
hedgehog1.color = "Krutoy cvet";
hedgehog1.AmountOfSpikes = random.Next(1, 500);

Hedgehog hedgehog2 = new Hedgehog();
hedgehog2.name = "Rubick";
hedgehog2.color = "Green";
hedgehog2.AmountOfSpikes = hedgehog1.AmountOfSpikes;

forest.AddHedgehogs(hedgehog1);
forest.AddHedgehogs(hedgehog2);

forest.PrintThem();
class Forest
{
    private List<Hedgehog> _hedgehog;

    public Forest()
    {
        _hedgehog = new List<Hedgehog>();
    }
    public void AddHedgehogs(Hedgehog hedgehog)
    {
        _hedgehog.Add(hedgehog);
    }
    public void PrintThem()
    {
        foreach (Hedgehog i in _hedgehog)
        {
            i.InformationAboutAnimal();
        }
    }
}

class animal
{
    private string Name;
    private string Color;

    public string color { get { return Color; } set { Color = value; } }
    public string name { get { return Name; } set { Name = value; } }

    public virtual void InformationAboutAnimal()
    {
        Console.WriteLine($"Name of ur animal is {name}, color of ur animal is {color}");
    }
}

class Hedgehog : animal
{
    private int amountofspikes;
    public int AmountOfSpikes { get { return amountofspikes; } set { amountofspikes = value; } }

    public virtual void InformationAboutAnimal()
    {
        Console.WriteLine($"Name of ur Hedgehog is {name} his color is {color} and he has {AmountOfSpikes} spikes on his back");
    }
}