// Ejercicio 1: Escribe un programa que reciba tu nombre y lo escriba por consola.
// Ejercicio 2: Escribe un programa que tome la hora y la escriba por pantalla.

internal class Program{
    
    private static void Main(string[] args) 
    {
        System.Console.WriteLine($"Welcome {getName()}!");
        System.Console.WriteLine($"it's {getCurrentTime()}");
    }

    public static String getName()
    {
        System.Console.WriteLine("Please Write your name");
        String name = Console.ReadLine();
        return name;
    }

    public static String getCurrentTime()
    {
        string currentTime = DateTime.Now.ToString("hh:mm:ss tt");
        return currentTime;
    }
}