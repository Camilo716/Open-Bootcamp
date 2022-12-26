namespace Ejercicios_Sesion4;

namespace Ejercicios_Sesion4;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void validate_multiplication_table()
    {
        using (var ConsoleOutput = new ConsoleOutput())
        {
            OperationTables_Ejercicio1 operationTableNumber2 = new OperationTables_Ejercicio1();

            string tableExpected = "2x1 = 2\n2x2 = 4\n2x3 = 6\n2x4 = 8\n2x5 = 10\n2x6 = 12\n2x7 = 14\n2x8 = 16\n2x9 = 18\n2x10 = 20\n";

            OperationTables_Ejercicio1.multiplication(2);

            Assert.AreEqual(tableExpected, ConsoleOutput.GetOuput());
        }   
    }

    [Test]
    public void validate_positive_counter()
    {
        using (var ConsoleOutput = new ConsoleOutput())
        {
            Counter_Ejercicio2 positiveCounter = new Counter_Ejercicio2(4);
            string positiveTextExpected = "4...3...2...1...\n";

            positiveCounter.presentCounter();

            Assert.AreEqual(positiveTextExpected, ConsoleOutput.GetOuput());
        }   
    }

    [Test]
    public void validate_negative_counter()
    {
        using (var ConsoleOutput = new ConsoleOutput())
        {
            Counter_Ejercicio2 negativeCounter = new Counter_Ejercicio2(-5);
            string negativeTextExpected = "-5...-4...-3...-2...-1...\n";
            
            negativeCounter.presentCounter();
            
            Assert.AreEqual(negativeTextExpected, ConsoleOutput.GetOuput());
        }   
    }

    [Test]
    public void validate_creation_of_figure_with_filled()
    {
        using (var ConsoleOutput = new ConsoleOutput())
        {
            Figure_Ejercicio3 figure1 = new Figure_Ejercicio3(3,4,true);
            string figureWritedExpected = "****\n****\n****\n";

            //                  ****
            // Figure expected: ****
            //                  ****

            figure1.createFigureRequired();

            Assert.AreEqual(figureWritedExpected, ConsoleOutput.GetOuput());
            
        }   
    }

    [Test]
    public void validate_creation_of_figure_without_filled()
    {
        using (var ConsoleOutput = new ConsoleOutput())
        {
            Figure_Ejercicio3 figure1 = new Figure_Ejercicio3(3,4,false);
            string figureWritedExpected = "****\n*  *\n****\n";

            //                  ****
            // Figure expected: *  *
            //                  ****

            figure1.createFigureRequired();

            Assert.AreEqual(figureWritedExpected, ConsoleOutput.GetOuput());
            
        }   
    }
}
