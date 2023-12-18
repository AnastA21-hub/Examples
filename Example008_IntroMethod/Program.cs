// Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)//эта функция будет находить максимум из этих чисел, затем сравним три числа
{
	int result = arg1; //задаем первый аргумент - максимум
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result;
}
int a1 = 25;
int b1 = 17;
int c1 = 94;
int a2 = 42;
int b2 = 19;
int c2 = 81;
int a3 = 40;
int b3 = 69;
int c3 = 5;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);