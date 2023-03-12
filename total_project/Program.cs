// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Task 66
/*int sum(int m)
{
    if (m == 1) return 1;
    return sum(m-1) + m;
}
// int m = 10;
Console.WriteLine("Enter M(from) and N(to include):");
int[] m_n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine(sum(m_n[1]) - sum(m_n[0]-1));*/


// Task 68
int acker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return acker(m - 1, 1);
    return acker(m - 1, acker(m, n - 1));
}
Console.WriteLine("Enter M and N:");
int[] m_n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Ackerman function for your numbers:");
Console.WriteLine(acker(m_n[0], m_n[1]));
