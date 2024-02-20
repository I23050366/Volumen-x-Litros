



using System;

class PhysicsConverter
{
    static void Main()
    {
        // Get user input for volume in liters
        Console.Write("Enter volume in liters: ");
        double litersVolume = Convert.ToDouble(Console.ReadLine());

        // Convert volume to gallons using the formula: gallons = liters * 0.264172
        double gallonsVolume = ConvertLitersToGallons(litersVolume);

        // Display the converted volume
        Console.WriteLine($"The volume in gallons is: {gallonsVolume} gallons");
    }

    // Method to convert liters to gallons
    // Formula: gallons = liters * 0.264172
    static double ConvertLitersToGallons(double litersVolume)
    {
        return litersVolume * 0.264172;
    }
}