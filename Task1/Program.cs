void ShowNumbers(int N, int M)
{
    if (N>M)
    {
        return;
    }
    Console.Write($"{N} ");
    ShowNumbers(N+1, M);
}

ShowNumbers(1, 10);
