public class Car : Vehicle
{
    public string RegistrationNumber { get; set; }

    public Car(string make, string model, string registrationNumber)
        : base(make, model)
    {
        RegistrationNumber = registrationNumber;
    }

    public void ShowFullInfo()
    {
        ShowBasicInfo();
        Console.WriteLine("Registration Number: " + RegistrationNumber);
    }
}