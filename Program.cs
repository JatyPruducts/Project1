using System;

// Базовый класс для всех письменных принадлежностей
public abstract class WritingImplement
{
    public static int TotalCount { get; private set; } = 0;  // Статическая переменная для подсчета общего количества
    public double Price { get; set; }
    public string Manufacturer { get; set; }

    protected WritingImplement(double price, string manufacturer)
    {
        Price = price;
        Manufacturer = manufacturer;
        TotalCount++;  // Увеличиваем общий счетчик при создании экземпляра
    }
}

// Класс для гелиевой ручки
public class GelPen : WritingImplement
{
    public string LineColor { get; set; }
    public double GelMass { get; set; }

    public GelPen(double price, string manufacturer, string lineColor, double gelMass)
        : base(price, manufacturer)
    {
        LineColor = lineColor;
        GelMass = gelMass;
    }
}

// Класс для шариковой ручки
public class BallPen : WritingImplement
{
    public string LineColor { get; set; }
    public bool HasRefills { get; set; }

    public BallPen(double price, string manufacturer, string lineColor, bool hasRefills)
        : base(price, manufacturer)
    {
        LineColor = lineColor;
        HasRefills = hasRefills;
    }
}

// Класс для простого карандаша
public class Pencil : WritingImplement
{
    public string Hardness { get; set; }
    public double Length { get; set; }
    public string LineColor { get; set; }

    public Pencil(double price, string manufacturer, string hardness, double length, string lineColor)
        : base(price, manufacturer)
    {
        Hardness = hardness;
        Length = length;
        LineColor = lineColor;
    }
}

// Класс для маркера
public class Marker : WritingImplement
{
    public string LineColor { get; set; }
    public double LineWidth { get; set; }

    public Marker(double price, string manufacturer, string lineColor, double lineWidth)
        : base(price, manufacturer)
    {
        LineColor = lineColor;
        LineWidth = lineWidth;
    }
}

// Класс для тетради
public class Notebook : WritingImplement
{
    public string Lining { get; set; }
    public int PageCount { get; set; }

    public Notebook(double price, string manufacturer, string lining, int pageCount)
        : base(price, manufacturer)
    {
        Lining = lining;
        PageCount = pageCount;
    }
}

// Пример использования
public class Program
{
    public static void Main()
    {
        var gelPen = new GelPen(1.99, "Bic", "Blue", 10.0);
        var ballPen = new BallPen(0.99, "Parker", "Black", true);
        var pencil = new Pencil(0.59, "Faber-Castell", "2B", 16.0, "Grey");
        var marker = new Marker(1.50, "Sharpie", "Red", 0.5);
        var notebook = new Notebook(2.00, "Moleskine", "Ruled", 192);

        Console.WriteLine($"Total number of writing implements: {WritingImplement.TotalCount}");
    }
}
