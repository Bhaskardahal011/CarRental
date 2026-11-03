class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== CAR RENTAL SYSTEM =====");
        Console.WriteLine();

        // Create the first car
        Car car1 = new Car("Toyota", "Corolla", "BA 2 PA 1234");

        // Create the second car
        Car car2 = new Car("Honda", "Civic", "BA 3 PA 5678");

        // Display first car information
        Console.WriteLine("First Car Information:");
        car1.ShowBasicInfo();
        car1.ShowFullInfo();

        Console.WriteLine();

        // Display second car information
        Console.WriteLine("Second Car Information:");
        car2.ShowBasicInfo();
        car2.ShowFullInfo();
    }
}