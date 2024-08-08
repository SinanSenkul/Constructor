public class Baby
{
    public DateTime birthDate;
    public string Name;
    public string LastName;

    // Constructors:
    //this constructor creates a default object with predefined values, doesnt take any parameters:
    public Baby()
    {
        Console.WriteLine("Ingaaa");
        birthDate = DateTime.Now;
        Name = "ali";
        LastName = "veli"; // Varsayılan olarak 2020 yılı atandı
    }

    //this constructor takes two parameters and creates an object with given parameters:
    public Baby(string name, string lastName)
    {
        Console.WriteLine("Ingaaa");
        birthDate = DateTime.Now;
        Name = name;
        LastName = lastName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a baby object with two different constructors:
        Baby newBaby1 = new Baby(); //this one is with the no-parameter constructor. 
        Baby newBaby2 = new Baby("sinan", "şenkul");
        Console.WriteLine($"new baby's name: {newBaby1.Name} and lastname: {newBaby1.LastName} and birth date: {newBaby1.birthDate}");
        Console.WriteLine($"new baby's name: {newBaby2.Name} and lastname: {newBaby2.LastName} and birth date: {newBaby2.birthDate}");
    }
}