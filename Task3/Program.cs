void ReversalArray(int[] array, int size)
{
    if (size < 1)
    {
        return;
    }
    Console.Write($"{array[size - 1]}");
    ReversalArray(array, size - 1);
}

int[] array = [1,2,3,4,5];
ReversalArray(array, array.Length);