//Перепишем код из примера 10 код с использованием псевдогенератора случайных чисел
//и с использованием методов:
//1. Взять метод, передать его в массив, заполнить массив нужным количеством элементов
//2. Опишем метод, который будет выводить все элементы по порядку
//3. Превратим код поиска в нужный метод
//для заполнения массива напишем метод
void FillArray(int[] collection)//заполнение массива
{
	int length = collection.Length;//получаем длину массива
	int index = 0;
	while (index < length)//до тех пор пока индекс меньше длины
	{
		collection[index] = new Random().Next(1, 10);
		//кладем в индекс радомное число от 1 до 10
		index++;//переходим к следующему индексу
	}
}

//Создаем метод для печати массива:
void PrintArray(int[] col)
{
	int count = col.Length;//счет соответствует длине массива
	int position = 0;//запишем не индекс, а позицию
	while (position < count)//до тех пор пока позиция меньше счета
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

//Опишем метод, который будет возвращать позицию искомого числа, он будт возвращать позицию
int IndexOf(int[] collection, int find)
{
	int count = collection.Length;//счет равен длине массива
	int index = 0;
	int position = 0;//куда сохранять элемент
	while (index < count)
	{
		if (collection[index] == find)//если число соответствует find
		{
			position = index;//индекс записываем в позицию, но не выводим
		}
		index++;
	}
	return position;
}

//Протестируем методы
int[] array = new int[10];//создаем массив из 10 элементов;
						  //по умолчанию массив зполнится 00000
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
