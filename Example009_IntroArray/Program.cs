int Max(int arg1, int arg2, int arg3)   // Возвращ.ТипДанных Функция(имена аргументов)
{
	int result = arg1;                    // { Тело функции }
	if(arg2> result) result = arg2;
	if(arg3> result) result = arg3;
	return result;                         //Возвращаемое значение
}
int [] array = {11,26,34,41,52,61,77,85,99};
//array[0] = 12;
// Console.WriteLine(array[0]);


int max = Max(
	Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));  //Максимальное одной строкой
	
Console.WriteLine(max);

