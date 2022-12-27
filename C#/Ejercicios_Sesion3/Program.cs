global using NUnit.Framework;

public class Customer
{
    public string fullName;
    public int phoneNumber;
    public string address;
    public string email;
    public bool knowProgramming;

    public Customer(string fullName, int phoneNumber, string address, string email, bool knowProgramming)
    {
        this.fullName = fullName;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.email = email;
        this.knowProgramming = knowProgramming;
    }
}