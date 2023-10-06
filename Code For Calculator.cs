using System;

class Calculator
{
    
    // Method to add
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method to subtract
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Method to multiply
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method to divide
    static int Divide(int a, int b)
    {
        return a / b;
    }
    
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Simple Integer Calculator");

        // Getting user input 
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

      Console.Write("Enter the second integer:");
      int num2 = int.Parse(Console.ReadLine());

        
        
        //asking for the fuction
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        // Getting user's choice
        Console.Write("Enter your choice (1/2/3/4): ");
        int choice = int.Parse(Console.ReadLine());

        // Perform the selected operation using methods
        int result = 0;

        if (choice == 1)
        {
            result = Add(num1, num2);
        }
        else if (choice == 2)
        {
            result = Subtract(num1, num2);
        }
        else if (choice == 3)
        {
            result = Multiply(num1, num2);
        }
        else if (choice == 4)
        {
            // Check for division by zero
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot Divide 0.");
            }
            else
            {
                result = Divide(num1, num2);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return; // Exit the program
        }

        // Display the result
        Console.WriteLine("Result: " + result);
    }

  
}