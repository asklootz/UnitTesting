namespace UnitTesting.Tests;

public class CarTests
{
    
    // Denne er all good, bare å lage metoden i Car klassen så den passer til testen ;)
    [Fact]
    public void TestGotEnoughFuel()
    {
        Car car = new Car("Toyota", "Corolla", 50, 10);
        var result = car.RemainingFuel(100);
        Assert.True(2 <= result);
    }

    
    
    // I denne testen skal du den andre metoden du lagde i Car-klassen til å lage en liste del biler. 
    // Etterpå i "Assert.Contains()" skal du bruke dine kule LINQ-skills til å sjekke om et merke du velger er i listen av biler metoden lager. 

    
    
    
    // Lag en "Theory"-test for å sjekke alle bilene i listen med en test som kjøres flere ganger. Akkurat som testen over. (Hint: Se på testene i "CalculatorTests"-klassen)

    
    

    
    // Sett alt sommen i en stor "Theory"-test
    // Skal kjøre metoden som legger til biler i listen, sjekke at et merke er i listen.
    // Så skal du og sjekke at det er nok bensin igjen etter å ha kjørt en gitt distanse på akkurat det merket som er gitt.
    // Skal kun passere om alle Assert er riktig.
    

}