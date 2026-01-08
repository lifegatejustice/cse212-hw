public class Person
{
    public string _givenName = "";
    public string _familyName = "";

    public Person()
    {
        
    }

    public void ShowEasternName()
    {
        System.Console.WriteLine($"{_familyName} {_givenName}");
    }

}