int[] array = { 99, 92, 33, 4, 99, 56, 47, 8, 75, 99 };

int n = array.Length;
int find = 99;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index + 1;
}