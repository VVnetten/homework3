// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


void ThirdNum(int a, int b, int c, int x, int y, int z ) 
{

double dist = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2)  + Math.Pow(z - c, 2));

Console.WriteLine(dist);

}


int EnterNum(string text) {

    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int a = EnterNum("Введите координату 1:");
int b = EnterNum("Введите координату 2:");
int c = EnterNum("Введите координату 3:");
int x = EnterNum("Введите координату 4:");
int y = EnterNum("Введите координату 5:");
int z = EnterNum("Введите координату 6:");

ThirdNum(a, b, c, x, y, z);