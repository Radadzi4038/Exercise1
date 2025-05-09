internal class Program
{
    private static void Main(string[] args)
    {
        //Printing Hello and my name to console on two separate lines
        String MyName = "Richmond";
        Console.WriteLine("Hello" + "\n" + MyName);
       
        // Printing the addition of two numbers to console
        int Num1 = 10;
        int Num2 = 5;
        int sum = Num1 + Num2;
        Console.WriteLine("\n" + "the sum of the two numbers is: " + sum);

        //Printing the division of two numbers to console
        int FirstNum = 20;
        int SecondNum = 2;
        int Div = FirstNum / SecondNum;
        Console.WriteLine("\n" + "the result for diving the two numbers is: " + Div);

        // the output of adding,subtracting,multiplying,dividing two numbers by storing two numbers in variables
        int Num_1 = 12;
        int Num_2 = 6;
        int summation = Num_1 + Num_2;
        int sub = Num_1 - Num_2;
        int mul = Num_1 * Num_2;
        int div_2 = Num_1/ Num_2;
        Console.WriteLine("\n" + "the sum of the two numbers is: " + summation);
        Console.WriteLine("the result for subtracting the two numbers is: " + sub);
        Console.WriteLine("the result for multiplying the two numbers is: " + mul);
        Console.WriteLine("the result for diving the two numbers is: " + div_2);

        //Printing out the Average of four numbers
        int dig1 = 4;
        int dig2 = 8;
        int dig3 = 12;
        int dig4 = 16;
        int avg= (dig1 + dig2 + dig3 + dig4) /2 ;
        Console.WriteLine("\n" + "the average of the four numbers is: " + avg);

        // Celsius to Fahrenheit
        double celsius = 25.0;
        double fahrenheitFromCelsius = (celsius * 9 / 5) + 32;
        Console.WriteLine("\n" + $"{celsius}°C is equal to {fahrenheitFromCelsius}°F");

        // Fahrenheit to Celsius
        double fahrenheit = 77.0;
        double celsiusFromFahrenheit = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit}°F is equal to {celsiusFromFahrenheit}°C");










    }
}