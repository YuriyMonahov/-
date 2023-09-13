int[] array = {14,26,36,48,59,69,87,83,};
int n = array.Length;
int find = 59;
int index = 0;
 while (index < n)
 {
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
 }