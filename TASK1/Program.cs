Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

if (stringNumber.Length !=3) 
{
  Console.WriteLine("Введено не верное число");
}

else
{
  Console.WriteLine("Вторая цифра числа: "+ stringNumber[1]);
}