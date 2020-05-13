using System;

public class Program
{
    public static void Main()
    {        
        Console.Title = "Deltastic Diagonals v2.2";
        Console.WriteLine("Welcome to Deltastic Diagonals!");
        Console.WriteLine(" ");
        Console.WriteLine("Choose calculation mode: ");
        Console.WriteLine("[ A ] - calculates screen dimensions based on the diagonal size and aspect ratio");
        Console.WriteLine("[ B ] - calculates the diagonal size based on screen dimensions");
        string type = Console.ReadLine();
        Console.WriteLine(" ");
        switch (type)
        {
            case "A":
                Dimensions(GetFirstRatio(), GetSecondRatio(), GetDiagonal());
                break;

            case "B":
                Diagonal(GetFirstDimension(), GetSecondDimension());
                break;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Press [Enter] to exit");
        Console.ReadLine();
    }
    public static void Dimensions(float ratioA, float ratioB, float diagonal)
    {
        float part = Convert.ToSingle(Math.Pow(diagonal, 2) / (Math.Pow(ratioA, 2) + Math.Pow(ratioB, 2)));
        float newX = Convert.ToSingle(Math.Sqrt(part * Math.Pow(ratioA, 2)));
        float newY = Convert.ToSingle(Math.Sqrt(part * Math.Pow(ratioB, 2)));
        Console.WriteLine("First screen dimension: " 
            + Math.Round(newX, 1) + " inches; " 
            + Math.Round(newX * 2.54f, 1) 
            + " cm");
        Console.WriteLine("Second screen dimension: " 
            + Math.Round(newY, 1) + " inches; " 
            + Math.Round(newY * 2.54f, 1) 
            + " cm");
    }
    public static void Diagonal(float dimensionA, float dimensionB)
    {
        Console.WriteLine("This screen's diagonal is " + 
            Math.Round(Math.Sqrt(Math.Pow(dimensionA, 2) + Math.Pow(dimensionB, 2)) / 2.54f, 1) 
            + " inches ( " 
            + Math.Round(Math.Sqrt(Math.Pow(dimensionA, 2) + Math.Pow(dimensionB, 2)), 1) + 
            " cm )");
    }
    public static float GetDiagonal()
    {
        Console.WriteLine("Screen's diagonal [ inches ]: ");
        float temp = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return temp;
    }
    public static float GetFirstRatio()
    {
        Console.WriteLine("First ratio: ");
        float temp = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return temp;
    }
    public static float GetSecondRatio()
    {
        Console.WriteLine("Second ratio: ");
        float temp = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return temp;
    }
    public static float GetFirstDimension()
    {
        Console.WriteLine("The first dimension [ cm ]: ");
        float temp = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return temp;
    }
    public static float GetSecondDimension()
    {
        Console.WriteLine("The second dimension [ cm ]: ");
        float temp = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        return temp;
    }
}