// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

void SumNumbers(int num)
{
  int print = num;
  int count = 0;
  int rez = 0;
  while (num != 0)
  {
    count = num % 10;
    num = num / 10;
    rez = rez + count;
  }
  Console.WriteLine(" сумма всех цифр (" +print+ ") что вы ввели = " + rez);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int num = GetNum("Введите число: ");

SumNumbers(num);