internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    public class Person_Exercice1
    {
        string name;
        string lastname;
        int age;
        float height;
        bool knowProgramming;

        public void setName(string name)
        {
            this.name = name;
        }

        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setHeight(float height)
        {
            this.height = height;
        }

        public void setKnowProgramming(bool knowProgramming)
        {
            this.knowProgramming = knowProgramming;
        }

        //--------------
        public string getName()
        {
            return this.name;
        }

        public string getLastname()
        {
            return this.lastname;
        }

        public int getAge()
        {
            return this.age;
        }

        public float getHeight()
        {
            return this.height;
        }

        public bool getKnowProgramming()
        {
            return this.knowProgramming;
        }
    }

    public class Car_Exercise2
    {
        private int doors;
        private int wheels;
        private float speed;
        private string model;

        public Car_Exercise2(int doors, int wheels, float speed, string model){
            this.doors = doors;
            this.wheels = wheels;
            this.speed = speed;
            this.model = model;
        }
    }

    public class Table_Excercise2
    {
        private float weight;

        private float length;
        private string material;
        private string color;

        public Table_Excercise2(float weight, float length, string material, string color)
        {
            this.weight = weight;
            this.length = length;
            this.material = material;
            this.color = color;
        }
    }

    public class Operators_Exercise3
    {
        public static bool numIsHigherOrEqualTo(int number1, int number2)
        {
            if (number1 >= number2)
            {
                return true;
            }
            return false;
        }

        public static bool yourWordIsAChar(string yourWord)
        {
            if (yourWord.Length == 1)
            {
                return true;
            }
           return false;
        }

        public static bool personIsATeenager(int age){
            if (age>=15 && age<= 20)
            {
                return true;
            }
            return false;
        }

        public static bool personIsBackend(string favProgrammingLanguage)
        {
            if (favProgrammingLanguage == "Java" || favProgrammingLanguage == "C#" ||  favProgrammingLanguage =="Python")
            {
                return true;
            }
            return false;
        }
    }
}