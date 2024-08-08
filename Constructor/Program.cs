public class Baby
{
    public DateTime birthDate;
    public string Name;
    public string LastName;

    // Constructors:
    /*
    public Baby()
    {
        birthDate = new DateTime(2014, 4, 21);
        Name = "sinan";
        LastName = "senkul"; // Varsayılan olarak 2020 yılı atandı
    }
    */

    public Baby(string name, string lastName)
    {
        birthDate = new DateTime(2014, 4, 21);
        Name = name;
        LastName = lastName; // Varsayılan olarak 2020 yılı atandı
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a baby object with two different constructors:
        //Baby newBaby = new Baby(); //this one is with the no-parameter constructor. 
        Baby newBaby = new Baby("sinan", "şenkul");
        Console.WriteLine($"new baby's name: {newBaby.Name} and lastname: {newBaby.LastName} and birth date: {newBaby.birthDate}");
    }
}