// Найти максимум из 9 чисел
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
int Max(int arg1, int arg2, int arg3)//эта функция будет находить максимум из этих чисел, затем сравним три числа
{
	int result = arg1; //задаем первый аргумент - максимум
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result;
}


int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
