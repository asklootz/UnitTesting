namespace UnitTesting;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double FuelAmount { get; set; } // Skal regne med at det er i Liter
    public double KilometersPerLiter { get; set; }

    public static List<Car> cars = new List<Car>();

    public Car(string brand, string model, double fuelAmount, double kilometersPerLiter)
    {
        Brand = brand;
        Model = model;
        FuelAmount = fuelAmount;
        KilometersPerLiter = kilometersPerLiter;
    }

    // Fiks metoden, slik at den returnerer hvor mye bensin som er igjen etter å ha kjørt en gitt distanse. Den skal kunne brukes på testen "TestGotEnoughFuel" i CarTests-klassen
    public double RemainingFuel(double distance)
    {
        return 0; // Skal returnere noe annet.
    }

    


    // Lag en "public static" klasse som skal genere 2 eller flere biler og legge de i "cars" listen. (Hint: cars.Add(..... ) ;P
    
    
    
    
    
}