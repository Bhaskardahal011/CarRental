public class Car : Vehicle, IRentable
{
    public string RegistrationNumber { get; set; }
    public double DailyRate { get; set; }

    public Car(string make, string model, string registrationNumber, double dailyRate)
        : base(make, model)
    {
        RegistrationNumber = registrationNumber;
        DailyRate = dailyRate;
    }

    public void ShowFullInfo()
    {
        ShowBasicInfo();
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Daily Rate: £" + DailyRate);
    }

    public double CalculateCost(int days)
    {
        return days * DailyRate;
    }

    public void Rent(int days)
    {
        Console.WriteLine("Car " + RegistrationNumber + " rented for " + days + " day(s).");
    }
}