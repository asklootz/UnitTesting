namespace UnitTesting.Tests;

public class CalculatorTests
{
    //  Eksempel på hvordan en test skal skrives.
    [Fact] 
    public void TestAddition()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
    
    //  Skriv din egen test for subtraksjons-metoden i Calculator klassen.
    
    
    
    
    // Skriv en test som tester pluss og minus samtidig. Skal kun passere om alle Assert er riktig.
    // (NB! Du tester 2 forskjellige metoder sammen, viktig å også teste metodene seperat. Hvis én metode feiler så feiler hele testen uten å klart si hva gjorde at testen feilet)
    
    
    
    
    // Skriv en test som kjøres flere ganger med forskjellige parametre  (Hint: Theory not Fact)
    
    
    
    
    // Rom for å lage flere tester eller teste ut nye metoder du la til i Calculator klassen, som for eksempel multiplikasjon og divisjon.
    
}