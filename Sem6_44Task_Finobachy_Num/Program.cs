/*Задача 44: Не используя рекурсию, выведите первые N 
чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int RequestNumber(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

void ShowFinobaciNumber(int n)
{
        int firstnum = 0;
        int secondnum = 1;
        int thirdnum;

    Console.Write(\tfirstnum);
    for(int i = 1; i < n; i++)
    {
        Console.Write(\tsecondnum);
        thirdnum = firstnum + secondnum;
        firstnum = secondnum;
        secondnum = thirdnum;
    }    
}

int N = RequestNumber("How many Finobachy numbers you want?    ");
ShowFinobaciNumber(N);
