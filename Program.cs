static void Main(string[] args)
{
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    System.Console.WriteLine(Ford.model);
    System.Console.WriteLine(Opel.model);
}