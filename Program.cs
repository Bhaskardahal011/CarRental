class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("===== CAR RENTAL SYSTEM =====");
        Console.WriteLine();

        // Create cars
        Car car1 = new Car("Toyota", "Corolla", "BA 2 PA 1234", 45);
        Car car2 = new Car("Honda", "Civic", "BA 3 PA 5678", 50);

        // Display available cars
        Console.WriteLine("Available Cars:");
        Console.WriteLine();

        Console.WriteLine("1. Toyota Corolla");
        car1.ShowFullInfo();
        Console.WriteLine();

        Console.WriteLine("2. Honda Civic");
        car2.ShowFullInfo();
        Console.WriteLine();

        // Select a car
        Console.Write("Select a car (1 or 2): ");
        string carChoice = Console.ReadLine();

        Car selectedCar;

        if (carChoice == "1")
        {
            selectedCar = car1;
        }
        else if (carChoice == "2")
        {
            selectedCar = car2;
        }
        else
        {
            Console.WriteLine("Invalid car selection.");
            return;
        }

        // Enter rental days
        Console.Write("Enter rental days: ");
        int days;

        if (!int.TryParse(Console.ReadLine(), out days) || days <= 0)
        {
            Console.WriteLine("Please enter a valid positive number of days.");
            return;
        }

        // Rent the car and calculate cost
        selectedCar.Rent(days);

        double totalCost = selectedCar.CalculateCost(days);

        Console.WriteLine("Total Rental Cost: £" + totalCost.ToString("F2"));
        Console.WriteLine();

        // Select payment method
        Console.WriteLine("Select Payment Method:");
        Console.WriteLine("1. Card");
        Console.WriteLine("2. Cash");
        Console.Write("Enter your choice: ");

        string paymentChoice = Console.ReadLine();

        IPaymentProcessor paymentProcessor;

        if (paymentChoice == "1")
        {
            paymentProcessor = new CardPaymentProcessor();
        }
        else if (paymentChoice == "2")
        {
            paymentProcessor = new CashPaymentProcessor();
        }
        else
        {
            Console.WriteLine("Invalid payment method.");
            return;
        }

        // Process payment
        Console.WriteLine();
        paymentProcessor.ProcessPayment(totalCost, selectedCar.RegistrationNumber);

        // Print receipt
        Console.WriteLine();
        Console.WriteLine("===== RENTAL RECEIPT =====");
        Console.WriteLine("Car: " + selectedCar.Make + " " + selectedCar.Model);
        Console.WriteLine("Registration: " + selectedCar.RegistrationNumber);
        Console.WriteLine("Rental Days: " + days);
        Console.WriteLine("Daily Rate: £" + selectedCar.DailyRate.ToString("F2"));
        Console.WriteLine("Total Paid: £" + totalCost.ToString("F2"));
        Console.WriteLine("==========================");
        Console.WriteLine("Thank you for choosing our car rental service!");
    }
}