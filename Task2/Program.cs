int FunctionAkkerman(int n, int m)
{
    if (n ==0)
    {
        return m+1;
    }
    else if(n !=0 && m == 0)
    {
        return FunctionAkkerman(n - 1, 1);
    }
    else
    {
        return FunctionAkkerman(n-1, FunctionAkkerman(n, m-1));
    }
}
Console.Write(FunctionAkkerman(4,4));