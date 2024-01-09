using AWP_1;

// variable
// property
// field
// method

public class Program
{
    // field
    private string _name = string.Empty;

    // property
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // public string Name { get; set; }
    public static void Main(string[] args)
    {
        Console.WriteLine("geben Sie den erste Wert ein.");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("geben Sie den Operator ein");
        string op = Console.ReadLine();

        Console.WriteLine("geben Sie den zweite Wert ein.");
        int b = int.Parse(Console.ReadLine());

        switch(op)
        {
            case "+":
                Console.WriteLine(a + b);
                break;
            case "-":
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.WriteLine(a * b);
                break;
            case "/":
                Console.WriteLine(a / b);
                break;
            default:
                Console.WriteLine("ungültiger Operator");
                break;
        }

        var student = new Student();

        student.Name = "Hans";
        Student.InstanceCount += 1;
    }
}