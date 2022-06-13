Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);


if (stringNumber.Length < 3) 
{
  Console.WriteLine("Третьей цифры заданного числа не существует");
  
}

else
{
  Console.WriteLine("Третья цифра заданного числа: "+ stringNumber[2]);
}