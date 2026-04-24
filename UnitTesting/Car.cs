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

    // Fiks metoden, slik at den returnerer hvor mye bensin som er igjen etter å ha kjørt en gitt distanse, litt enkel matte. Den skal kunne brukes på testen "TestGotEnoughFuel" i CarTests-klassen
    public double RemainingFuel(double distance)
    {
        double remainingFuel = FuelAmount - (distance / KilometersPerLiter);
        return remainingFuel;
    }




    // Lag en "public static" klasse som skal genere 2 eller flere biler og legge de i "cars" listen. (Hint: cars.Add(..... ) ;P
    public static void CarMaker() // Car-klassen
    {
        cars.Add(new Car("Toyota", "Corolla", 50, 10));
        cars.Add(new Car("BMW", "i8", 100, 8));
        cars.Add(new Car("Audi", "A4", 60, 12));
    }
    
    
    
    
}