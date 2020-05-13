using System;

public class Program {
    public static void Main () {
        Console.Title = "Deltastic Diagonals v2.1";
        Console.WriteLine ("Welcome to Deltastic Diagonals!");
        Console.WriteLine (" ");
        Console.WriteLine ("Choose calculation mode: ");
        Console.WriteLine ("[ A ] - calculates screen dimensions based on the diagonal size and aspect ratio");
        Console.WriteLine ("[ B ] - calculates the diagonal size based on screen dimensions");
        string type = Console.ReadLine ();
        Console.WriteLine (" ");
        switch (type) {

            case "A":
                Dimensions();
                break;

            case "B":
                Diagonal();
                break;
        }

    }
    private void Dimensions()
    {
        Console.WriteLine("Screen's diagonal [ inches ]: ");
        float diagonal = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("First ratio: ");
        float xA = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Second ratio: ");
        float yA = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        float part = (diagonal * diagonal) / ((xA * xA) + (yA * yA));
        float newX = Convert.ToSingle(Math.Sqrt(part * xA * xA));
        float newY = Convert.ToSingle(Math.Sqrt(part * yA * yA));
        Console.WriteLine("First screen dimension: " + Math.Round(newX, 1) + " inches; " + Math.Round(newX * 2.54f, 1) + " cm");
        Console.WriteLine("Second screen dimension: " + Math.Round(newY, 1) + " inches; " + Math.Round(newY * 2.54f, 1) + " cm");
        string analphabet = Console.ReadLine();
    }
    private void Diagonal()
    {
        Console.WriteLine("The first dimension [ cm ]: ");
        float xB = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("The second dimension [ cm ]: ");
        float yB = float.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("This screen's diagonal is " + Math.Round(Math.Sqrt(xB * xB + yB * yB) / 2.54f, 1) + " inches ( " + Math.Round(Math.Sqrt(xB * xB + yB * yB), 1) + " cm )");
        string bitchlasaga = Console.ReadLine();
    }
}