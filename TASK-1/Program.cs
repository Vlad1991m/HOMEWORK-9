int Digitsum(int N)
{
    if(N > 9) 
    return 1 + Digitsum(N = N/10);
    else return 1;
    

}
Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(Digitsum(n));
