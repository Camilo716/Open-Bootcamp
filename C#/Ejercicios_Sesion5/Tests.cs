namespace Ejercicios_Sesion5;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void check_validation_of_email()
    {
        DrinksShop_Exercise1 shop1 = new DrinksShop_Exercise1("Gabriel", "esteesuncoreoinvalido.com");
        DrinksShop_Exercise1 shop2 = new DrinksShop_Exercise1("Gabriel", "esteesuncoreovalido@gmail.com");

        bool result1 = shop1.email_is_valid();
        bool result2 = shop2.email_is_valid();

        Assert.That(result1, Is.EqualTo(false));
        Assert.That(result2, Is.EqualTo(true));
    }
    
    [Test]
    public void validate_application_of_discount()
    {
        DrinksShop_Exercise1 shop = new DrinksShop_Exercise1("Gabriel", "esteesuncoreovalido@gmail.com");
        shop.percentDiscount = 20;

        int result = shop.applyDiscountForProductInterested(200);

        Assert.That(result, Is.EqualTo(160));
    }

    [Test]
    public void validate_language_selected()
    {
        ProgrammingLanguages_Exercise2 exercise2 = new ProgrammingLanguages_Exercise2();
        exercise2.favoriteBackendPL = 'e';

        string result = exercise2.searchLanguageSelected();

        Assert.That(result, Is.EqualTo("RUST"));   
    }
}