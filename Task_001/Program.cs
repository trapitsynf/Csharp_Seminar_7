void Main() 
{
    dz1(10, 50);
}

void dz1(int m, int n)
{
    if (m > n) return;
    Console.Write(m + " ");
    dz1(m + 1, n);
}

Main();