int [] array = {1, 3, 8, 4, 5, 7, 9, 5};
int n = array.Length;
int find = 5;

int index = 0;
while(index< n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}
