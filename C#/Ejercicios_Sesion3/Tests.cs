namespace Ejercicios_Sesion3;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void validate_fullname_attribute()
    {
        Customer client1 = new Customer("Camilo Gonzalez", 342344, "Calle 234", "mail@", true );

        string attribute = client1.fullName;

        Assert.AreEqual(attribute, "Camilo Gonzalez");
    }

    [Test]
    public void validate_phoneNumber_attribute()
    {
        Customer client1 = new Customer("Camilo Gonzalez", 342344, "Calle 234", "mail@", true );

        int attribute = client1.phoneNumber;

        Assert.AreEqual(attribute, 342344);
    }

    [Test]
    public void validate_address_attribute()
    {
        Customer client1 = new Customer("Camilo Gonzalez", 342344, "Calle 234", "mail@", true );

        string attribute = client1.address;

        Assert.AreEqual(attribute, "Calle 234");
    }

    [Test]
     public void validate_email_attribute()
    {
        Customer client1 = new Customer("Camilo Gonzalez", 342344, "Calle 234", "mail@", true );

        string attribute = client1.email;

        Assert.AreEqual(attribute, "mail@");
    }

    [Test]
     public void validate_knowProgramming_attribute()
    {
        Customer client1 = new Customer("Camilo Gonzalez", 342344, "Calle 234", "mail@", true );

        bool attribute = client1.knowProgramming;

        Assert.AreEqual(attribute, true);
    }
}