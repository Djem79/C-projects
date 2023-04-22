int[] array ={12, 25, 34, 4, 578, 6, 76, 8};

int n = array.Length;
int find = 76;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

//console.WriteLine();
