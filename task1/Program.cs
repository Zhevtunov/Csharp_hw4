// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

void GetDegree(int numberA, int numberB)
{
  int rez = 1;
  for (int i = 1; i <= numberB; i++)
  {
    rez = rez * numberA;
  }
  Console.WriteLine(numberA + " в степени " + numberB + " получится " + rez);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int numA = GetNum("Введите число : ");
int numB = GetNum("В какую степень возвести это число ?: ");

GetDegree(numA, numB);
