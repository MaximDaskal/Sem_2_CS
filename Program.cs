
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