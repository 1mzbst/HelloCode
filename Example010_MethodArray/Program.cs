int[] array = { 11, 12, 31, 41, 15, 61, 17, 18 };

int n = array.Length;
int find = 61;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index +1;
    index++;
}