int Sumnatur(int M, int N)
{
    if(M < 0) M = 1;
    if(M < N) return M + Sumnatur(M + 1, N);
    else return N;
    

}
Console.WriteLine("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(Sumnatur(m,n));
