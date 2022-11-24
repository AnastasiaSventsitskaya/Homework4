// // Напишите программу, которая принимает на вход число и выдает сумму из цифр в числе.



Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма " + GetSumNum(num));

int GetSumNum(int input)
{
    int sum = 0;
    while(input > 0)
    {
        sum += input % 10; 
        input = input /10;    
    }
    return sum;
}

// Console.WriteLine("Write number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Сумма " + GetSumNum(num));

// int GetSumNum(int input)
// {
//    string string_input = input.ToString();
//    int sum = 0;
//    for (int i = 0; i < string_input.Length; i++)
//    {
//       int new_input = Convert.ToInt32(string_input[i].ToString());
//         sum += new_input;
//    }
//    return sum;
// }

