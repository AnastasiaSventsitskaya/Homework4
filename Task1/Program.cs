// Цикл, который принимает на вход два числа А и В и возводит А в натуральную степень В.

Console.WriteLine("Write number1: ");
double A = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Write natural number2: ");
int B = Convert.ToInt32(Console.ReadLine());



double Power(double num1, int num2) 
{
     double result = 1;

     for (int i = 0; i < num2; i++)
     {
        result *= num1;
     }
     return result;
}

double res = Power(A, B);
Console.WriteLine(res);


