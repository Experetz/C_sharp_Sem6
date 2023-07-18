/* Задача 40: Напишите программу, которая принимает на вход 
три числа и проверяет, может ли существовать треугольник 
с сторонами такой длины.*/

int RequestNumber(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

double A = RequestNumber("Please put number A  ");
double B = RequestNumber("Please put number B  "); 
double C = RequestNumber("Please put number C ");

if((A < (B+C)) && (B < (A+C)) && (C < (A+B)))
{
    Console.WriteLine("This is triangle");
}
else 
Console.WriteLine("This is NOT triangle");