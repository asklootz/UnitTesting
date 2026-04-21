# Repo for øvelser til å lære _Unit Testing_ innenfor C# språket.


## Kalkulator-øvelser:
1. Start med å skrive en test som skal teste at subtraksjon er riktig.
   - (Du kan legge til flere matematiske operasjoner og lage tester for de og om du ønsker)
2. Skriv en test som kjører flere metoder og tester dem med assert i én test. 
   - Helst å bruke pluss og minus samtidig
3. Skriv en test som skal teste flere verdier for en metode. Håper du har en god _teori_ :D
   - For eksempel at 2 + 2 = 4, 3 + 3 = 6, osv.
4. Ferdig her, men lag flere tester om du vil eller gå til bilen :)


## Bil-øvelser:
1. Det alt en test skrevet, du skal fullføre metoden "RemainingFuel()" slik at testen passerer. 
   - Det er en metode som skal regne ut hvor mye bensin det er igjen i tanken etter å ha kjørt en viss distanse.
2. Her skal du lage flere biler og teste dem:
    - Lag en statisk metode som skal lage flere biler og legge dem i listen "cars".
    - Skriv en test som skal sjekke at alle bilene i listen har mer du opprettet er i listen.
3. Skriv en test som skal lage en "Theory"-test som skal sjekke at alle bilene er der, med å test hvert bilmerke. (Hint: Se på testene i "CalculatorTests"-klassen)
4. Sett alt sammen i en stor test:
   - Theory-test som tar in paramter for bilmerke og distanse kjørt på alle testene.
   - Skal kjøre metoden for å opprette bilene.
   - Sjekke at alle bilene er i listen.
   - Lag en variabel som lagrer mengde bensin bilens bensintank etter den er opprettet.
   - Kjør metoden "RemainingFuel()" for hver bil og sjekk at den er mindre enn eller lik mengden bensin i tanken etter å ha kjørt distansen.