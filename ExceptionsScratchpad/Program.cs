using ExceptionsScratchpad;


Calculator calc = new Calculator();

Console.Write("Enter the first number: ");
string leftString = Console.ReadLine();
int left = int.Parse(leftString);

Console.Write("Enter the operator: ");
string oper = Console.ReadLine();

Console.Write("Enter the second number: ");
string rightString = Console.ReadLine();
int right = int.Parse(rightString);


try
{
    int result = calc.Calculate(oper, left, right);
    Console.WriteLine($"Your result is {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero!");
}
catch (Exception)
{
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("End of try");
}

Console.WriteLine(calc.IsCalculating);

//Console.WriteLine("Enter a number:");
//string s = Console.ReadLine();
//try
//{
//    int n = int.Parse(s);

//    if (n == 13)
//    {
//        throw new UnluckyNumberException();
//    }
//    Console.WriteLine(100 / n);
//}
//catch (FormatException)
//{
//    Console.WriteLine("That's not a number!");
//    //Console.WriteLine(ex.Message);

//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Can't divide by zero!");
//}
//catch (UnluckyNumberException)
//{
//    Console.WriteLine("That number is unlucky");
//}




//Console.WriteLine("End");
////string s = null;
////Console.WriteLine(s.Length);

////int numerator = 42;
////int denominator = 0;
////Console.WriteLine(numerator / denominator);