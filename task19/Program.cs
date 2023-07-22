// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

void Palindrom(int num)
{
   int end = num%100;
   int first = num/1000 ;
   if (first/10 == end%10 & first%10 == end/10)
   {Console.Write("yes");}
   else
   {
    Console.Write("no");
   } }

int FiveInput(string text) {

Console.WriteLine(text);
return Convert.ToInt32(Console.ReadLine());
}

int num = FiveInput("Введите пятизначное число");
Palindrom (num);