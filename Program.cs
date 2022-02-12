List<GeometrijskaFigura> geoFigure = new();
geoFigure.Add(new Kvadrat { _a = 18 });
geoFigure.Add(new Kvadrat { _a = 2 });
geoFigure.Add(new Kvadrat { _a = 5 });
geoFigure.Add(new Kvadrat { _a = 8 });

geoFigure.Add(new Krug { _r = 15 });
geoFigure.Add(new Krug { _r = 25 });
geoFigure.Add(new Krug { _r = 35 });

geoFigure.ForEach(gFigura =>
{
    /*if (gFigura is Kvadrat k)
    {
        Console.WriteLine($"Kvadrat je, duzina stranice: {k._a}");
    }
    else if (gFigura is Krug kr)
    {
        Console.WriteLine($"Krug je: {kr._r}");
    }*/

    switch (gFigura)
    {
        case Kvadrat kvadrat:
            Console.WriteLine($"Kvadrat je, duzina stranice: {kvadrat._a}");
            break;

        case Krug krug:
            Console.WriteLine($"Krug je: {krug._r}");
            break;
    }

    Console.WriteLine($"Povrsina je {gFigura.Povrsina()}");
    Console.WriteLine($"Obim je {gFigura.Obim()}");
    Console.WriteLine("~~~~~~~~~~~~~~~~~");
});

public abstract class GeometrijskaFigura
{
    public abstract double Povrsina();

    public virtual double Obim()
    {
        Console.WriteLine("Bla bla");
        return 0;
    }
}

public class Kvadrat : GeometrijskaFigura
{
    public double _a;

    public override double Povrsina()
    {
        return _a * _a;
    }

    public override double Obim()
    {
        base.Obim();
        return _a * 4;
    }
}

public class Krug : GeometrijskaFigura
{
    public double _r;

    public override double Povrsina()
    {
        return _r * _r * Math.PI;
    }

    public override double Obim()
    {
        return 2 * Math.PI * _r;
    }
}