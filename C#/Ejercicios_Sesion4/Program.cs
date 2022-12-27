global using NUnit.Framework;

public class OperationTables_Ejercicio1
{
    public void multiplication(int numberToOperate)
    {
        int multiplier = 1;

        while (multiplier<=10)
        {
            int result = numberToOperate*multiplier;
            Console.WriteLine($"{numberToOperate}x{multiplier} = {result}");
            multiplier+=1;
        }
    }
}

public class Counter_Ejercicio2
{
    public int initialCounter;
    public Counter_Ejercicio2(int initialCounter)
    {
        this.initialCounter = initialCounter;
    }

    public void presentCounter()
    {
        if (initialCounter > 0)
        {
            createPositiveCounter();
        }
        else if(initialCounter < 0)
        {
            createNegativeCounter();
        }
        else
        {
            Console.WriteLine("Please write a positive or negative number");
        }
    }
    
    public void createPositiveCounter()
    {
        do
        {
            Console.Write($"{initialCounter}...");

            this.initialCounter -= 1;
                        
        } while (initialCounter > 0);
    }

    public void createNegativeCounter()
    {
        do
        {
            Console.Write($"{initialCounter}...");
            this.initialCounter += 1;    

        } while (initialCounter < 0);
    }
}

public class Figure_Ejercicio3
{
    int height; // Rows
    int width;  // Columns
    bool filled;
    int[,] figure;

    public Figure_Ejercicio3(int height, int width, bool filled)
    {
        this.height = height;
        this.width = width;
        this.filled = filled;
        this.figure = new int[height, width];
    }

    public void createFigureRequired()
    {
        if (this.filled == true)
        {
            createFigureWithFilled();
        }
        else
        {
            createFigureWithoutFilled();
        }

        writeFigureCreated();
    }

    public void writeFigureCreated()
    {

    }

    public void createFigureWithFilled()
    {
        for (int row = 0; row < this.figure.GetLength(0); row++)
        {
            for (int column = 0; column < this.figure.GetLength(1); column++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }

    public void createFigureWithoutFilled()
    {
        for (int row = 0; row < this.figure.GetLength(0); row++)
        {
            for (int column = 0; column < this.figure.GetLength(1); column++)
            {
                if (column == 0 || row == 0 || column == this.figure.GetLength(1)-1 || row == this.figure.GetLength(0)-1 )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
}
