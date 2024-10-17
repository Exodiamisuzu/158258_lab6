
namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            RunExercises();
        }

        static void RunExercises()
        {
            // Exercise 1
            Console.WriteLine("exercise1");
            for (var i = 0; i <= 10; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.WriteLine("exercise2");
            int j = 0;
            while (j <= 10)
            {
                Console.Write(j);
                Console.Write(" ");
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("exercise3");
            int k = 0;
            do
            {
                Console.Write(k);
                Console.Write(" ");
                k++;
            } while (k <= 10);
            
            Console.WriteLine();
            Console.WriteLine("exercise4");
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("exercise5");
            Console.Write("Answer: \nThe issue with the provided do-while loop is that the condition while (Result >= 0) creates an infinite loop. This happens because Result is always being incremented by 1 (Result += 1;), so it will never be less than 0. Since the condition requires Result to be non-negative (>= 0), the loop will continue forever.");
            Console.WriteLine();

            RunExercise7();
        }

        static void RunExercise7()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    if (!double.TryParse(Console.ReadLine(), out double a))
                    {
                        Console.WriteLine("Please enter a valid number!");
                        continue;
                    }

                    Console.Write("Enter an operator (+, -, *, /): ");
                    char c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (!(c == '+' || c == '-' || c == '*' || c == '/'))
                    {
                        Console.WriteLine("Please enter a correct operator: +, -, *, /");
                        continue;
                    }

                    Console.Write("Enter the second number: ");
                    if (!double.TryParse(Console.ReadLine(), out double b))
                    {
                        Console.WriteLine("Please enter a valid number!");
                        continue;
                    }

                    double result = c switch
                    {
                        '+' => a + b,
                        '-' => a - b,
                        '*' => a * b,
                        '/' => b != 0 ? Math.Round(a / b, 2) : throw new DivideByZeroException(),
                        _ => throw new InvalidOperationException("Invalid operator")
                    };

                    Console.WriteLine($"{a} {c} {b} = {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Calculation attempt completed.");
                }
            }
        }
    }
}
