public class Program{
    
    public static void Main(string[] args) {
        System.Console.WriteLine(getCurrentTime());
        System.Console.WriteLine(getName());
    }

    public static String getName(){
        System.Console.WriteLine("Please Write your name");
        String name = Console.ReadLine();
        return name;
    }

    public static String getCurrentTime() {
        string currentTime = DateTime.Now.ToString("hh:mm:ss tt");
        return currentTime;
    }
}


