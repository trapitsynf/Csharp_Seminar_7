void Main() 
{
     Console.WriteLine(dz2(3, 2));
}

int dz2(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return dz2(m - 1, 1);
    return dz2(m - 1, dz2(m, n - 1));
}

Main();