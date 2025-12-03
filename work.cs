using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BMI Calculator ===");

        Console.Write("Enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height (m): ");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine($"\nYour BMI is: {bmi:F2}");

        string interpretation;

        if (bmi < 18.5)
        {
            interpretation = "Underweight";
        }
        else if (bmi < 25)
        {
            interpretation = "Normal weight";
        }
        else if (bmi < 30)
        {
            interpretation = "Overweight";
        }
        else
        {
            interpretation = "Obesity";
        }

        Console.WriteLine("Interpretation: " + interpretation);
    }
}
