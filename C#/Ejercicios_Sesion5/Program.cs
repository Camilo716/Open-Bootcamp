global using NUnit.Framework;

ProgrammingLanguages_Exercise2 exercise2 = new ProgrammingLanguages_Exercise2();

exercise2.client_interaction();
public class DrinksShop_Exercise1
{
    public string name;
    public string email;
    public bool haveDiscountCoupon;
    public string[,] productsAndPrices;
    public int percentDiscount;
    public string productInterested;

    public DrinksShop_Exercise1(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
    public void client_interaction()
    {
        if (email_is_valid() == false)
        {
            Console.WriteLine($"Invalid email, try again");
            return;
        }
        inicializate_products();
        Console.WriteLine("Hi! Welcome to our shop. Here is the list of products:\n");
        show_list_of_products();
        Console.WriteLine("\nDo you have any discount coupon? y/n");
        string check = Console.ReadLine();

        if (check.ToLower() == "y")
        {
            Console.WriteLine("How much discount percent do you have? Just write numbers" );
            percentDiscount = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"So in which product are you interested for?");
        productInterested = Console.ReadLine();
        productInterested += ": $";
        Console.WriteLine($"This is the price of product using the coupon discount: ");
        Console.WriteLine(searchProductInterested());
    }
    public void inicializate_products()
    {
        productsAndPrices = new string[,]
        {
            {"Lemonades: $", "10"},
            {"Coffies: $"  , "15"},
            {"Juices: $"   , "20"}        
        };
    }
    public void show_list_of_products()
    {
        for (int row = 0; row < productsAndPrices.GetLength(0); row++)
        {
            for (int column = 0; column < productsAndPrices.GetLength(1); column++)
            {
                Console.Write(productsAndPrices[row,column]);
            }
            Console.Write("\n");
        }
    }
    public bool email_is_valid()
    {
        for (int character = 0; character < email.Length; character++)
        {
            if (email[character] == '@')
            {
                return true;
            }
        }
        return false;   
    }

    public string searchProductInterested()
    {
        for (int row = 0; row < productsAndPrices.GetLength(0); row++)
        {
            if (productsAndPrices[row,0].ToLower() == productInterested.ToLower())
            {
                return Convert.ToString(applyDiscountForProductInterested(Convert.ToInt32(productsAndPrices[row,1])));
            }
        }
        
        return "Product not found";
    }

    public int applyDiscountForProductInterested(int price)
    {
        float finalPrice1 = price - (price*(percentDiscount/100f));
        return Convert.ToInt32(finalPrice1);
    }
    
}

public class ProgrammingLanguages_Exercise2
{
    public string[] BackendProgrammingLanguages = new string[]
    {
        "a) C#",
        "b) Java",
        "c) Python",
        "d) Elixir",
        "e) Rust",
        "f) Php",
        "g) C++",
        "h) Go",
        "i) Kotlin",
        "j) Ruby",
    };

    public char favoriteBackendPL;

    public void client_interaction()
    {
        Console.WriteLine("Most used backend programming Languages:\n");
        writeListOfProgrammingLanguages();
        Console.WriteLine("\nWrite the letter which corresponds to your favorite language");
        
        favoriteBackendPL = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("\n\nYour favorite backend Programming Language is:");
        Console.Write("|");
        Console.Write(searchLanguageSelected());
        Console.Write("|\n");
    }   
    public void writeListOfProgrammingLanguages()
    {
        for (int pL = 0; pL < BackendProgrammingLanguages.Count(); pL++)
        {
            Console.WriteLine(BackendProgrammingLanguages[pL]);
        }
    }
    public string searchLanguageSelected()
    {
        for (int pL= 0; pL < BackendProgrammingLanguages.Count(); pL++)
        {
            if (char.ToLower(favoriteBackendPL) == BackendProgrammingLanguages[pL][0])
            {
                string selectedLanguage = BackendProgrammingLanguages[pL].Replace(Convert.ToString(BackendProgrammingLanguages[pL][0]),"");
                selectedLanguage = selectedLanguage.Replace(")", "").Replace(" ", "").ToUpper();
                return selectedLanguage;
            }
        }
        return "Programming Language not found";
    }






}