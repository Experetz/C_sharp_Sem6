/*Задача 42: Напишите программу, которая будет 
преобразовывать десятичное число в двоичное.

45 -> 101101
3  -> 11
2  -> 10      */


int RequestNumber(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

string DecimalToBinary(int decimalNumber)
    {
        string binaryString = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryString = remainder + binaryString;
            decimalNumber /= 2;
        }

        return binaryString;
    }

int decimalNumber = RequestNumber("Please put number you want to convert  ");
string binaryNumber = DecimalToBinary(decimalNumber);
Console.WriteLine($"Decimal number is {decimalNumber}: {binaryNumber}");