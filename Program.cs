
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int  gigSec(int num1)
{
    int n = num1 / 10;
    n = n % 10;
    return n;
}

Console.Write("Input your three-digit number: ");
int numV = Convert.ToInt32(Console.ReadLine());
if(numV < 100 || numV > 999)
{
    Console.WriteLine("Your number is not three-digit number");
}
else
{
    int num2 = gigSec(numV);
    Console.Write($"The second digit is {num2}");
}


/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Метод для определения разряда введённого числа
int digNum(ulong entNum)
{
    int k = 0; //счётчик

    do
    {
        entNum = entNum/10;
        k++;
    }
    while(entNum>0);

    return k;
}

//Метод для опреления третьей цифры числа(при отсчёте слева)
int thirdNum(ulong entNum)
{
    int j = digNum(entNum); //Степень введённого числа
    if (j<3)
    {
        return 0; //Возвращаем 0 при отсутствии третьей цифры в числе
    }
    else
    {
        double p = Math.Pow(10, (j - 3)); //10*(j - 3);// та степень десятки на которую надо будет разделить исходное число
        entNum = entNum/Convert.ToUInt64(p); // Получили трёхзначное число
        
        return Convert.ToInt32(entNum % 10);
    }
}

Console.Write("Input your number: ");
ulong numV = Convert.ToUInt64(Console.ReadLine());
int th_Num = thirdNum(numV);
if (th_Num == 0)
{
    Console.Write("There's not the third digit in your number");
}
else
{
    Console.Write($"The third digit is {th_Num}");
}
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool  isHoliday(int num3)
{
    if(num3 > 5) return true;
    else return false;
}



Console.Write("Input your week day number[1-7]: ");
int numV1 = Convert.ToInt32(Console.ReadLine());
if(numV1 < 1 || numV1 > 7)
{
    Console.WriteLine("Your number is not week day number");
}
else
{
    if(isHoliday(numV1))
    Console.Write($"The day {numV1} of a week IS a holiday");
    else 
    Console.Write($"The day {numV1} of a week IS NOT a holiday");
}
*/




/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Task2. Determining the maximum and the minimum number");
Console.Write("Input your first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int second = Convert.ToInt32(Console.ReadLine());

if(first > second)
{
    Console.Write($"Max = {first}; Min = {second}");
}
else
{
    Console.Write($"Max = {second}; Min = {first}");
}
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Task4. Determining the maximum number out of three numbers");
Console.Write("Input your first number: ");
int first4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int second4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your third number: ");
int third4 = Convert.ToInt32(Console.ReadLine());

int num;

if(first4 > second4)
{
    num = first4;
}
else
{
    num = second4;
}

if(num > third4)
{
    Console.Write($"Maximum number is: {num}");
}
else
{
     Console.Write($"Maximum number is: {third4}");
}
*/

/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Task6. Determining the number is even or odd");
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = number % 2;

if(num2 == 0)
{
    Console.Write($"Number {number} is even");
}
else
{
    Console.Write($"Number {number} is odd");
}
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Task8. Put all even nubers from 1 to  the input number");
Console.Write("Input your number: ");
int number8 = Convert.ToInt32(Console.ReadLine());

int numV = 2;

while (numV <= number8)
{
   Console.Write($"{numV} ");
    numV = numV + 2;
}
*/


